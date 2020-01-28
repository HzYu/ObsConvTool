using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObsConvTool.Model;

namespace ObsConvTool
{
    public partial class ObsConvTool : Form
    {

        public ValueModel ValueModel { get; set; }
        private DataTable SdrTable { get; set; }
        private string SdrText { get; set; }
        private string MacText { get; set; }

        public ObsConvTool()
        {
            InitializeComponent();
            ValueModel = new ValueModel();
            SdrTable = new DataTable();
            SdrText = "";
            MacText = "";
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            string strLine = "";
            bool Enable = false;

            try
            {
                OpenFileDialog OpenFile = new OpenFileDialog();
                OpenFile.InitialDirectory = ".\\";
                OpenFile.Filter = "sdr files|*.sdr|mac files|*.mac";
                if (OpenFile.ShowDialog() == DialogResult.OK)
                {
                    SdrText = "column1,column2,column3,column4,column5,column6\r\n";
                    FileName.Text = OpenFile.FileName.Substring(OpenFile.FileName.LastIndexOf("\\") + 1); //取得檔名

                    //讀取檔案
                    StreamReader StrReader = new StreamReader(OpenFile.FileName); //檔案路徑+檔名
                    while (!StrReader.EndOfStream)
                    {
                        strLine = StrReader.ReadLine();
                        if (strLine.IndexOf("07TP") > -1) { Enable = true; }
                        if (Enable)
                        {
                            SdrText += SdrToCSV(strLine) + "\r\n";
                        }
                    }
                    SdrToMac.Enabled = false;
                    MacTextbox.Text = "";
                }

                SdrTable = CSVToDataTable(SdrText);
                SdrTable.Columns.RemoveAt(5); //刪除多餘的 column6
                dataGridView1.DataSource = SdrTable;

                //按鈕(確認Col3資料)是否鎖定
                if (dataGridView1.RowCount > 1) { ConfirmCol3.Enabled = true; }
                else
                {
                    MessageBox.Show("資料格式不對，或者沒有'07TP'標頭判斷", "Error");
                    ConfirmCol3.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("開啟檔案錯誤或者讀取檔案錯誤", "Error");
            }
        }

        //打開ConfirmCol3From視窗，並確認 Cols3 數值是否區隔正確 
        private void ConfirmCol3_Click(object sender, EventArgs e)
        {
            this.ValueModel.Col3Text = "";

            //取Column3的值
            foreach (DataRow row in SdrTable.Rows)
            {
                if(row["column1"].ToString() == "09F1")
                {
                    this.ValueModel.Col3Text += row["column3"].ToString() + "\r\n";
                }   
            }

            ConfirmCol3Form ConfirmCol3Form = new ConfirmCol3Form(this.ValueModel,this);//(this 為 ObsConvTool winform) 可以傳物件到另一個 winform
            ConfirmCol3Form.Show();
        }

        //Sdr 轉 Mac
        private void SdrToMac_Click(object sender, EventArgs e)
        {
            int c = 0;
            this.MacText = "LS\r\n"; //Header
            try
            {
                List<string> List = new List<string>(this.ValueModel.Col3Text.Split(new string[] { ",", "\r\n" }, StringSplitOptions.RemoveEmptyEntries));

                foreach (DataRow row in SdrTable.Rows)
                {
                    if (row["column1"].ToString() == "07TP")
                    {
                        this.MacText += ReverseText(row["column2"].ToString(), "07TP") + "  ";
                        this.MacText += ReverseText(row["column3"].ToString(), "07TP") + "\r\n";
                    }
                    else if (row["column1"].ToString() == "09F1")
                    {
                        string val1 = List[c];
                        string val2 = List[c + 1];

                        this.MacText += ReverseText(val1, "09F1") + " ";
                        this.MacText += Mac_Col2(row["column5"].ToString()) + "  ";
                        this.MacText += Mac_Col3(val2, row["column4"].ToString()) + "  \r\n";

                        c += 2;
                    }
                }
                MacTextbox.Text = this.MacText;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sdr 轉 Mac 錯誤 \r\n確認 Col3 數值是否有誤", "Error");
            }
        }

        /// <summary>
        /// Sdr格式的字串轉換成CSV
        /// </summary>
        private string SdrToCSV(string SdrText)
        {
            SdrText = new Regex("[\r\n]+").Replace(SdrText, "(CR)"); //空行先取代為文字
            SdrText = new Regex("[\\s]+").Replace(SdrText, " ");//連續空白 轉成 一個空白
            SdrText = SdrText.Replace("(CR)", "\r\n").Replace(" ",",");
            return SdrText;
        }

        private DataTable CSVToDataTable(string msg)
        {
            DataTable dt = new DataTable();

            string[] tableData = msg.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var col = from c in tableData[0].Split(",".ToCharArray())
                      select new DataColumn(c);

            dt.Columns.AddRange(col.ToArray());

            (from st in tableData.Skip(1)
             select dt.Rows.Add(st.Split(",".ToCharArray()))).ToList();
            return dt;
        }

        private string ReverseText(string str , string title)
        {
            string Retxt = "";
            string[] StrSplit = str.Split('.');

            if (StrSplit[1].Length > 2 && title == "07TP")
            {
                StrSplit[1] = StrSplit[1].Substring(0, 2);
            }

            Retxt = StrSplit[1] + "." + StrSplit[0];
            return Retxt;
        }

        //計算Mac Col2 的值
        private string Mac_Col2(string str)
        {
            string Result = "";

            string[] StrSplit = str.Split('.');

            double Val1 = double.Parse("0." + StrSplit[1]) * 60;
            string[] StrSplit2 = Val1.ToString().Split('.');
            //如果是個位數字，前面補 0
            if (StrSplit2[0].Length == 1)
            {
                StrSplit2[0] = "0" + StrSplit2[0];
            }

            //如果小數點後面為 0 ，代表整個數值為 0
            if (Val1 != 0)
            {
                double Val2 = Math.Round(double.Parse("0." + StrSplit2[1]) * 60,0);
                string[] StrSplit3 = Val2.ToString().Split('.');
                if(StrSplit3[0].Length == 1)
                {
                    StrSplit3[0] = "0" + StrSplit3[0];
                }
                Result += StrSplit[0] + "." + StrSplit2[0] + StrSplit3[0];
            }
            else
            { Result = "0.0000";}
            return Result;
        }

        //計算Mac Col3 的值
        private string Mac_Col3(string str , string Val)
        {
            string Result = "";

            Result = (Math.Round(double.Parse(str) * Math.Cos((90 - double.Parse(Val)) * Math.PI / 180), 3)).ToString();

            return Result;
        }
    }
}
