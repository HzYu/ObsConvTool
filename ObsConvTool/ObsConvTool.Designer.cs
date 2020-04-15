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
            this.存檔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.FileNametxt = new System.Windows.Forms.Label();
            this.FileName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SdrToMac = new System.Windows.Forms.Button();
            this.ConfirmCol3 = new System.Windows.Forms.Button();
            this.MacTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.檔案ToolStripMenuItem,
            this.存檔ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1070, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFile});
            this.檔案ToolStripMenuItem.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // OpenFile
            // 
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(142, 24);
            this.OpenFile.Text = "開啟檔案";
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // 存檔ToolStripMenuItem
            // 
            this.存檔ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save});
            this.存檔ToolStripMenuItem.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.存檔ToolStripMenuItem.Name = "存檔ToolStripMenuItem";
            this.存檔ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.存檔ToolStripMenuItem.Text = "存檔";
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(178, 30);
            this.Save.Text = "另存新檔";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // FileNametxt
            // 
            this.FileNametxt.AutoSize = true;
            this.FileNametxt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FileNametxt.Location = new System.Drawing.Point(13, 106);
            this.FileNametxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FileNametxt.Name = "FileNametxt";
            this.FileNametxt.Size = new System.Drawing.Size(121, 20);
            this.FileNametxt.TabIndex = 2;
            this.FileNametxt.Text = "目前開啟檔案：";
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.Font = new System.Drawing.Font("新細明體", 12F);
            this.FileName.Location = new System.Drawing.Point(132, 108);
            this.FileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(0, 16);
            this.FileName.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 143);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(580, 374);
            this.dataGridView1.TabIndex = 4;
            // 
            // SdrToMac
            // 
            this.SdrToMac.Enabled = false;
            this.SdrToMac.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.SdrToMac.Location = new System.Drawing.Point(154, 53);
            this.SdrToMac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SdrToMac.Name = "SdrToMac";
            this.SdrToMac.Size = new System.Drawing.Size(94, 30);
            this.SdrToMac.TabIndex = 5;
            this.SdrToMac.Text = "轉換成 Mac";
            this.SdrToMac.UseVisualStyleBackColor = true;
            this.SdrToMac.Click += new System.EventHandler(this.SdrToMac_Click);
            // 
            // ConfirmCol3
            // 
            this.ConfirmCol3.Enabled = false;
            this.ConfirmCol3.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.ConfirmCol3.Location = new System.Drawing.Point(16, 53);
            this.ConfirmCol3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConfirmCol3.Name = "ConfirmCol3";
            this.ConfirmCol3.Size = new System.Drawing.Size(116, 30);
            this.ConfirmCol3.TabIndex = 6;
            this.ConfirmCol3.Text = "確認 Col3 資料";
            this.ConfirmCol3.UseVisualStyleBackColor = true;
            this.ConfirmCol3.Click += new System.EventHandler(this.ConfirmCol3_Click);
            // 
            // MacTextbox
            // 
            this.MacTextbox.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MacTextbox.Location = new System.Drawing.Point(622, 143);
            this.MacTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MacTextbox.Multiline = true;
            this.MacTextbox.Name = "MacTextbox";
            this.MacTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MacTextbox.Size = new System.Drawing.Size(395, 375);
            this.MacTextbox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(619, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "轉換後 Mac";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.version.Location = new System.Drawing.Point(1027, 528);
            this.version.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(36, 18);
            this.version.TabIndex = 9;
            this.version.Text = "V1.3";
            // 
            // ObsConvTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 553);
            this.Controls.Add(this.version);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MacTextbox);
            this.Controls.Add(this.ConfirmCol3);
            this.Controls.Add(this.SdrToMac);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.FileNametxt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ObsConvTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ObsConvTool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFile;
        private System.Windows.Forms.Label FileNametxt;
        private System.Windows.Forms.Label FileName;
        public System.Windows.Forms.DataGridView dataGridView1;
        public  System.Windows.Forms.Button SdrToMac;
        private System.Windows.Forms.Button ConfirmCol3;
        private System.Windows.Forms.TextBox MacTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 存檔ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

