namespace ObsConvTool
{
    partial class ObsConvTool
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SdrTextBox = new System.Windows.Forms.TextBox();
            this.FileNametxt = new System.Windows.Forms.Label();
            this.FileName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1281, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFile});
            this.檔案ToolStripMenuItem.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(66, 29);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // OpenFile
            // 
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(224, 30);
            this.OpenFile.Text = "開啟檔案";
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // SdrTextBox
            // 
            this.SdrTextBox.Font = new System.Drawing.Font("新細明體", 11F);
            this.SdrTextBox.Location = new System.Drawing.Point(24, 135);
            this.SdrTextBox.Multiline = true;
            this.SdrTextBox.Name = "SdrTextBox";
            this.SdrTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SdrTextBox.Size = new System.Drawing.Size(626, 368);
            this.SdrTextBox.TabIndex = 1;
            // 
            // FileNametxt
            // 
            this.FileNametxt.AutoSize = true;
            this.FileNametxt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FileNametxt.Location = new System.Drawing.Point(20, 102);
            this.FileNametxt.Name = "FileNametxt";
            this.FileNametxt.Size = new System.Drawing.Size(152, 25);
            this.FileNametxt.TabIndex = 2;
            this.FileNametxt.Text = "目前開啟檔案：";
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.Font = new System.Drawing.Font("新細明體", 12F);
            this.FileName.Location = new System.Drawing.Point(179, 104);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(0, 20);
            this.FileName.TabIndex = 3;
            // 
            // ObsConvTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 586);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.FileNametxt);
            this.Controls.Add(this.SdrTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ObsConvTool";
            this.Text = "ObsConvTool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.TextBox SdrTextBox;
        private System.Windows.Forms.ToolStripMenuItem OpenFile;
        private System.Windows.Forms.Label FileNametxt;
        private System.Windows.Forms.Label FileName;
    }
}

