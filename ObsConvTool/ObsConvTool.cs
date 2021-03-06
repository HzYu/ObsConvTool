﻿using System;
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

                    SdrText = "column1,column2,column3,column4,column5,column6,column7\r\n";
                    FileName.Text = OpenFile.FileName.Substring(OpenFile.FileName.LastIndexOf("\\") + 1); //取得檔名
                    string ExtensionName = Path.GetExtension(FileName.Text); //取得副檔名

                    if(ExtensionName == ".sdr")
                    {
                        //讀取檔案
                        StreamReader StrReader = new StreamReader(OpenFile.FileName); //檔案路徑+檔名
                        while (!StrReader.EndOfStream)
                        {
                            strLine = StrReader.ReadLine();
                            if (strLine.IndexOf("07TP") > -1) { Enable = true; } //遇到07TP標題開關開啟，儲存以下內容
                            if (Enable)
                            {
                                SdrText += SdrToCSV(strLine) + "\r\n";
                            }
                        }
                        SdrToMac.Enabled = true;
                        MacTextbox.Text = "";

                        SdrTable = CSVToDataTable(SdrText);
                        SdrTable.Columns.RemoveAt(6); //刪除多餘的 column7
                        dataGridView1.DataSource = SdrTable; //繫結 dataGridView

                        //按鈕(確認Col3資料)是否鎖定
                        if (dataGridView1.RowCount > 1) { ConfirmCol3.Enabled = true; }
                        else
                        {
                            MessageBox.Show("資料格式不對，或者沒有'07TP'標頭判斷", "Error");
                            ConfirmCol3.Enabled = false;
                        }
                    }
                    else if(ExtensionName == ".mac")
                    {
                        MacTextbox.Text = "";
                        StreamReader StrReader = new StreamReader(OpenFile.FileName); //檔案路徑+檔名
                        while (!StrReader.EndOfStream)
                        {
                            strLine = StrReader.ReadLine();
                            MacTextbox.Text += strLine + "\r\n";
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("開啟檔案錯誤或者讀取檔案錯誤", "Error");
            }
        }

        #region [適用於 v1.0 ~ v1.4 版本] 打開 ConfirmCol3From 視窗，並確認 Cols3 數值是否區隔正確 
        private void ConfirmCol3_Click(object sender, EventArgs e)
        {
            this.ValueModel.Col3Text = "";

            //取得Column3的值
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
        #endregion

        //Sdr 轉 Mac 按紐
        private void SdrToMac_Click(object sender, EventArgs e)
        {
            //int c = 0;
            this.MacText = "LS\r\n"; //Header
            try
            {
                //List<string> List = new List<string>(this.ValueModel.Col3Text.Split(new string[] { ",", "\r\n" }, StringSplitOptions.RemoveEmptyEntries));

                foreach (DataRow row in SdrTable.Rows)
                {
                    if (row["column1"].ToString() == "07TP")
                    {
                        this.MacText += ReverseText(row["column2"].ToString(), "07TP") + "       ";
                        this.MacText += ReverseText(row["column3"].ToString(), "07TP-Col3") + "\r\n";
                    }
                    else if (row["column1"].ToString() == "09F1")
                    {
                        //string val1 = List[c];
                        //string val2 = List[c + 1];

                        this.MacText += ReverseText(row["column3"].ToString(), "09F1") + "     ";
                        this.MacText += Mac_Col2(row["column6"].ToString()) + "    ";
                        this.MacText += Mac_Col3(row["column4"].ToString(), row["column5"].ToString()) + "  \r\n";

                        //c += 2;
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
            //07TP 和 09F1 資料行，利用空白判斷(36個空白)，Col2 新增逗號區隔數值
            if (SdrText.IndexOf("07TP") > -1 || SdrText.IndexOf("09F1") > -1)
            {
                SdrText = SdrText.Insert(36, ",");
            }

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

        private string ReverseText(string str, string title)
        {
            string Retxt = "";
            string[] StrSplit = str.Split('.');

            if(StrSplit.Length != 1)
            {
                if (StrSplit[1].Length > 2 && title == "07TP")
                {
                    StrSplit[1] = StrSplit[1].Substring(0, 2);
                    Retxt = StrSplit[1] + "." + StrSplit[0];
                }
                else if (title == "07TP-Col3") //標題 col3 改為取前兩位
                {
                    Retxt = StrSplit[0].Substring(0, 2);
                }
                else //09F1
                {
                    Retxt = StrSplit[1] + "." + StrSplit[0];
                }
            }
            else{ Retxt = StrSplit[0]; }

            return Retxt;
        }

        #region 計算 Mac Col2 和 Col3 的值
        //計算Mac Col2 的值
        private string Mac_Col2(string str)
        {
            string Result = "";
            string[] StrSplit2 = new string[2] { "0","0" };

            string[] StrSplit = str.Split('.');
            double Val1 = double.Parse("0." + StrSplit[1]) * 60;

            //如果Val1為整數，StrSplit2[1]為0
            if (Val1.ToString().IndexOf(".") == -1)//整數
            {
                StrSplit2[1] = "0";
            }
            else
            {
                StrSplit2 = Val1.ToString().Split('.');
            }

            //如果是個位數字，前面補 0
            if (StrSplit2[0].Length == 1)
            {
                StrSplit2[0] = "0" + StrSplit2[0];
            }

            //如果小數點後面為 0 ，代表整個數值為 0
            //小數點後面不為0的話，後面小數則繼續運算
            if (Val1 != 0)
            {
                double Val2 = Math.Round(double.Parse("0." + StrSplit2[1]) * 60,0);
                string[] StrSplit3 = Val2.ToString().Split('.');
                if(StrSplit3[0].Length == 1)
                {
                    StrSplit3[0] = "0" + StrSplit3[0];
                }
                Result += StrSplit[0] + "." + StrSplit2[0] + StrSplit3[0];
                Result = Result.PadRight(6,' ');
            }
            else
            { Result = "0.000000"; }
            return Result;
        }

        //計算Mac Col3 的值
        private string Mac_Col3(string str, string Val)
        {
            string Result = "";

            Result = (Math.Round(double.Parse(str) * Math.Cos((90 - double.Parse(Val)) * Math.PI / 180), 3)).ToString();

            string[] StrSplit = Result.ToString().Split('.');
            if(StrSplit[1].Length == 1)
            {
                Result = StrSplit[0] + "." + StrSplit[1] + "00";
            }
            else if(StrSplit[1].Length == 2)
            {
                Result = StrSplit[0] + "." + StrSplit[1] + "0";
            }
            Result = Result.PadLeft(6, ' ');
            return Result;
        }
        #endregion

        //另存新檔
        private void Save_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.Filter = "Mac檔|*.Mac";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(MacTextbox.Text);
                sw.Flush();
                sw.Close();
            }
        }
    }
}
