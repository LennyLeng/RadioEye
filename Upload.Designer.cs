namespace RadioEye
{
    partial class Upload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Upload));
            this.btn_Upload = new System.Windows.Forms.Button();
            this.lb_Prefix = new System.Windows.Forms.Label();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.lb_Suffix = new System.Windows.Forms.Label();
            this.lb_ret = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Upload
            // 
            this.btn_Upload.Location = new System.Drawing.Point(258, 60);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(75, 23);
            this.btn_Upload.TabIndex = 0;
            this.btn_Upload.Text = "Upload";
            this.btn_Upload.UseVisualStyleBackColor = true;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // lb_Prefix
            // 
            this.lb_Prefix.AutoSize = true;
            this.lb_Prefix.Location = new System.Drawing.Point(12, 30);
            this.lb_Prefix.Name = "lb_Prefix";
            this.lb_Prefix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_Prefix.Size = new System.Drawing.Size(41, 12);
            this.lb_Prefix.TabIndex = 1;
            this.lb_Prefix.Text = "Prefix";
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(196, 25);
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(100, 21);
            this.txt_Note.TabIndex = 2;
            // 
            // lb_Suffix
            // 
            this.lb_Suffix.AutoSize = true;
            this.lb_Suffix.Location = new System.Drawing.Point(296, 30);
            this.lb_Suffix.Name = "lb_Suffix";
            this.lb_Suffix.Size = new System.Drawing.Size(41, 12);
            this.lb_Suffix.TabIndex = 3;
            this.lb_Suffix.Text = "].dump";
            // 
            // lb_ret
            // 
            this.lb_ret.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_ret.Location = new System.Drawing.Point(105, 65);
            this.lb_ret.Name = "lb_ret";
            this.lb_ret.Size = new System.Drawing.Size(133, 12);
            this.lb_ret.TabIndex = 4;
            this.lb_ret.Text = "lb_ret";
            this.lb_ret.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_ret.Visible = false;
            // 
            // Upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 95);
            this.Controls.Add(this.lb_ret);
            this.Controls.Add(this.lb_Suffix);
            this.Controls.Add(this.txt_Note);
            this.Controls.Add(this.lb_Prefix);
            this.Controls.Add(this.btn_Upload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Upload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Upload";
            this.Load += new System.EventHandler(this.Upload_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.Label lb_Prefix;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.Label lb_Suffix;
        private System.Windows.Forms.Label lb_ret;
    }
}