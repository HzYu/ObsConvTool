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

        public ObsConvTool()
        {
            InitializeComponent();
            ValueModel = new ValueModel();
            SdrTable = new DataTable();
            SdrText = "";
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
                }

                SdrTable = CSVToDataTable(SdrText);
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
                MessageBox.Show("錯誤!!", "Error");
            }
        }

        //打開ConfirmCol3From視窗，並確認 Cols3數值是否區隔正確 
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
    }
}
