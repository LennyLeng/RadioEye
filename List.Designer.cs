namespace RadioEye
{
    partial class List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List));
            this.btn_Download = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lv_DumpList = new System.Windows.Forms.ListView();
            this.col_Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Download
            // 
            this.btn_Download.Location = new System.Drawing.Point(12, 262);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(75, 23);
            this.btn_Download.TabIndex = 0;
            this.btn_Download.Text = "Download";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(247, 262);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 1;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // lv_DumpList
            // 
            this.lv_DumpList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Title});
            this.lv_DumpList.FullRowSelect = true;
            this.lv_DumpList.Location = new System.Drawing.Point(12, 12);
            this.lv_DumpList.Name = "lv_DumpList";
            this.lv_DumpList.Size = new System.Drawing.Size(310, 244);
            this.lv_DumpList.TabIndex = 2;
            this.lv_DumpList.UseCompatibleStateImageBehavior = false;
            this.lv_DumpList.View = System.Windows.Forms.View.Details;
            // 
            // col_Title
            // 
            this.col_Title.Text = "Title";
            this.col_Title.Width = 306;
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(130, 262);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(75, 23);
            this.btn_Del.TabIndex = 3;
            this.btn_Del.Text = "Delete";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 291);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.lv_DumpList);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Download);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NetStorage";
            this.Load += new System.EventHandler(this.Download_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Download;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.ListView lv_DumpList;
        private System.Windows.Forms.ColumnHeader col_Title;
        private System.Windows.Forms.Button btn_Del;
    }
}