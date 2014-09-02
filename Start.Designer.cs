namespace RadioEye
{
    partial class Start
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.lab_Tip = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lab_Ret = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Margin = new System.Windows.Forms.Padding(0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(480, 320);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // lab_Tip
            // 
            this.lab_Tip.AutoSize = true;
            this.lab_Tip.BackColor = System.Drawing.Color.White;
            this.lab_Tip.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Tip.Location = new System.Drawing.Point(12, 288);
            this.lab_Tip.Name = "lab_Tip";
            this.lab_Tip.Size = new System.Drawing.Size(47, 12);
            this.lab_Tip.TabIndex = 1;
            this.lab_Tip.Text = "lab_Tip";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lab_Ret
            // 
            this.lab_Ret.BackColor = System.Drawing.Color.White;
            this.lab_Ret.Location = new System.Drawing.Point(191, 288);
            this.lab_Ret.Name = "lab_Ret";
            this.lab_Ret.Size = new System.Drawing.Size(264, 12);
            this.lab_Ret.TabIndex = 2;
            this.lab_Ret.Text = "lab_Ret";
            this.lab_Ret.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 314);
            this.ControlBox = false;
            this.Controls.Add(this.lab_Ret);
            this.Controls.Add(this.lab_Tip);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Start";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label lab_Tip;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lab_Ret;
    }
}