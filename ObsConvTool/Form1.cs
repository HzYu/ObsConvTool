using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObsConvTool
{
    public partial class Form1 : Form
    {

        private string SdrText { get; set; }

        public Form1()
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
                StreamReader StrReader = new StreamReader(OpenFile.FileName, Encoding.Default);
                SdrText = StrReader.ReadToEnd();
                SdrText = SdrText.Replace(" ", "");
                SdrTextBox.Text = SdrText;
                StrReader.Close();
            }

            //if (Regex.IsMatch(a, "[\\s]+"))
            //{
            //    a = new Regex("[\\s]+").Replace(a, " ");//連續空白 轉成 一個空白
            //    a = a.Replace(" ", ",");
            //}

        }
    }
}
