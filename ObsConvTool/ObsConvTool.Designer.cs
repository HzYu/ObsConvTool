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
            this.FileNametxt = new System.Windows.Forms.Label();
            this.FileName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SdrToMac = new System.Windows.Forms.Button();
            this.ConfirmCol3 = new System.Windows.Forms.Button();
            this.MacTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.存檔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存新檔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.version = new System.Windows.Forms.Label();
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
            this.menuStrip1.Size = new System.Drawing.Size(1426, 33);
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
            // FileNametxt
            // 
            this.FileNametxt.AutoSize = true;
            this.FileNametxt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FileNametxt.Location = new System.Drawing.Point(17, 133);
            this.FileNametxt.Name = "FileNametxt";
            this.FileNametxt.Size = new System.Drawing.Size(152, 25);
            this.FileNametxt.TabIndex = 2;
            this.FileNametxt.Text = "目前開啟檔案：";
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.Font = new System.Drawing.Font("新細明體", 12F);
            this.FileName.Location = new System.Drawing.Point(176, 135);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(0, 20);
            this.FileName.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(773, 468);
            this.dataGridView1.TabIndex = 4;
            // 
            // SdrToMac
            // 
            this.SdrToMac.Enabled = false;
            this.SdrToMac.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.SdrToMac.Location = new System.Drawing.Point(205, 66);
            this.SdrToMac.Name = "SdrToMac";
            this.SdrToMac.Size = new System.Drawing.Size(126, 38);
            this.SdrToMac.TabIndex = 5;
            this.SdrToMac.Text = "轉換成 Mac";
            this.SdrToMac.UseVisualStyleBackColor = true;
            this.SdrToMac.Click += new System.EventHandler(this.SdrToMac_Click);
            // 
            // ConfirmCol3
            // 
            this.ConfirmCol3.Enabled = false;
            this.ConfirmCol3.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.ConfirmCol3.Location = new System.Drawing.Point(22, 66);
            this.ConfirmCol3.Name = "ConfirmCol3";
            this.ConfirmCol3.Size = new System.Drawing.Size(154, 38);
            this.ConfirmCol3.TabIndex = 6;
            this.ConfirmCol3.Text = "確認 Col3 資料";
            this.ConfirmCol3.UseVisualStyleBackColor = true;
            this.ConfirmCol3.Click += new System.EventHandler(this.ConfirmCol3_Click);
            // 
            // MacTextbox
            // 
            this.MacTextbox.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MacTextbox.Location = new System.Drawing.Point(830, 179);
            this.MacTextbox.Multiline = true;
            this.MacTextbox.Name = "MacTextbox";
            this.MacTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MacTextbox.Size = new System.Drawing.Size(525, 468);
            this.MacTextbox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(825, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "轉換後 Mac";
            // 
            // 存檔ToolStripMenuItem
            // 
            this.存檔ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.另存新檔ToolStripMenuItem});
            this.存檔ToolStripMenuItem.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.存檔ToolStripMenuItem.Name = "存檔ToolStripMenuItem";
            this.存檔ToolStripMenuItem.Size = new System.Drawing.Size(66, 29);
            this.存檔ToolStripMenuItem.Text = "存檔";
            // 
            // 另存新檔ToolStripMenuItem
            // 
            this.另存新檔ToolStripMenuItem.Name = "另存新檔ToolStripMenuItem";
            this.另存新檔ToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.另存新檔ToolStripMenuItem.Text = "另存新檔";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.version.Location = new System.Drawing.Point(1369, 660);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(45, 22);
            this.version.TabIndex = 9;
            this.version.Text = "V1.0";
            // 
            // ObsConvTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 691);
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
        private System.Windows.Forms.ToolStripMenuItem 另存新檔ToolStripMenuItem;
        private System.Windows.Forms.Label version;
    }
}

