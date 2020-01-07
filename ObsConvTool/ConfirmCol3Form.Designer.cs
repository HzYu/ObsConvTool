namespace ObsConvTool
{
    partial class ConfirmCol3Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Confirm = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Confiretxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(102, 594);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(82, 32);
            this.Confirm.TabIndex = 0;
            this.Confirm.Text = "確認";
            this.Confirm.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(309, 594);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(82, 32);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Confiretxt
            // 
            this.Confiretxt.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.Confiretxt.Location = new System.Drawing.Point(76, 135);
            this.Confiretxt.Multiline = true;
            this.Confiretxt.Name = "Confiretxt";
            this.Confiretxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Confiretxt.Size = new System.Drawing.Size(337, 432);
            this.Confiretxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13F);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(71, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "請確認數值間的逗號是否區隔正確";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13F);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(71, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "如有誤 請直接編輯正確逗號的位置";
            // 
            // ConfirmCol3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 666);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Confiretxt);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Confirm);
            this.Name = "ConfirmCol3Form";
            this.Text = "ConfirmCol3Form";
            this.Load += new System.EventHandler(this.ConfirmCol3Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox Confiretxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}