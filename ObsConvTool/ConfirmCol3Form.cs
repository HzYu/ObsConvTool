using ObsConvTool.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObsConvTool
{
    public partial class ConfirmCol3Form : Form
    {
        public ValueModel ValueModel { get; set; }
        public ObsConvTool ObsConvTool { get; set; }

        public ConfirmCol3Form(ValueModel ValueModel,ObsConvTool obsConvTool)
        {
            InitializeComponent();
            this.ValueModel = ValueModel;
            this.ObsConvTool = obsConvTool;
        }

        private void ConfirmCol3Form_Load(object sender, EventArgs e)
        {
            int Length = 2;

            try
            {
                //利用txt的換行，用List接值
                List<string> List = new List<string>(this.ValueModel.Col3Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries));

                //判斷 List 裡的數值是否已經有逗號做區隔
                int ListCheck = List[0].ToString().IndexOf(",");

                if (ListCheck == -1)
                {
                    this.ValueModel.Col3Text = "";//清空內容 並換加上逗號過的字串
                    CheckId(List, out Length);  //判斷數值哪個位置需要加上逗號做區隔

                    for (int i = 0; i < List.Count; i++)
                    {
                        int index = List[i].IndexOf(".");
                        List[i] = List[i].Insert(index + Length + 1, ",");
                        this.ValueModel.Col3Text += List[i] + "\r\n";
                    }
                }
                Confiretxt.Text = this.ValueModel.Col3Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show("逗號區隔錯誤!!","Error");
            }
        }

        //確認 Col3 按鈕
        private void Confirm_Click(object sender, EventArgs e)
        {
            this.ValueModel.Col3Text = Confiretxt.Text;
            this.ObsConvTool.SdrToMac.Enabled = true; //轉換成Mac(按鈕開啟)

            try
            {
                //利用txt的換行，用List接值
                List<string> List = new List<string>(this.ValueModel.Col3Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries));

                //編輯 DataGridView 裡面的數值
                int c = 0;
                for (int i = 0; i < this.ObsConvTool.dataGridView1.RowCount - 1; i++)
                {
                    if (this.ObsConvTool.dataGridView1.Rows[i].Cells[0].Value.ToString() == "09F1")
                    {
                        this.ObsConvTool.dataGridView1.Rows[i].Cells[2].Value = List[c];
                        c++;
                    }
                }
                this.ValueModel.Col3Text = Confiretxt.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show("確認 Col3 錯誤!!", "Error");
            }
            
            Close();
        }

        //取消
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //判斷哪個位置需要加逗號
        private void CheckId(List<string> List, out int SplitLength)
        {
            SplitLength = 2;
            int[] ArrayId = new int[4];

            for (int i = 0; i < 4; i++)
            {
                int index = List[i].IndexOf(".");
                int Id = Convert.ToInt32(List[i].Substring(index + 1, SplitLength)); //切割編號的數字
                ArrayId[i] = Id;
            }

            if(ArrayId[0] == ArrayId[1] && ArrayId[1] == ArrayId[2])
            {
                SplitLength = 3;
            }
            else if(ArrayId[0]+1 == ArrayId[1] && ArrayId[1]+1 == ArrayId[2])
            {
                SplitLength = 2;
            }
            else
            {
                if(ArrayId[1] + 1 == ArrayId[2]  && ArrayId[2] + 1 == ArrayId[3])
                {
                    SplitLength = 2;
                }
                else if(ArrayId[1] == ArrayId[2] && ArrayId[2] == ArrayId[3])
                {
                    SplitLength = 3;
                }
            }
        }
    }
}
