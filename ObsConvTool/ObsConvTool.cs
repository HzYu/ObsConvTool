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

namespace ObsConvTool
{
    public partial class ObsConvTool : Form
    {

        private string SdrText { get; set; }

        public ObsConvTool()
        {
            InitializeComponent();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.InitialDirectory = ".\\";
            OpenFile.Filter = "sdr files|*.sdr|mac files|*.mac";
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                FileName.Text = OpenFile.FileName.Substring(OpenFile.FileName.LastIndexOf("\\") + 1); //取得檔名

                //讀取檔案
                StreamReader StrReader = new StreamReader(OpenFile.FileName, Encoding.Default);
                SdrText = StrReader.ReadToEnd();
                SdrText = SdrToCSV(SdrText);
                SdrTextBox.Text = SdrText;
                StrReader.Close();
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
    }
}
