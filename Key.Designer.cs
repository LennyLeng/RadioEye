namespace RadioEye
{
    partial class Key
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
            this.lv_KeyList = new System.Windows.Forms.ListView();
            this.col_Key = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_Key = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_DelAll = new System.Windows.Forms.Button();
            this.btn_ImportData = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_KeyList
            // 
            this.lv_KeyList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Key});
            this.lv_KeyList.FullRowSelect = true;
            this.lv_KeyList.Location = new System.Drawing.Point(12, 13);
            this.lv_KeyList.Name = "lv_KeyList";
            this.lv_KeyList.Size = new System.Drawing.Size(188, 209);
            this.lv_KeyList.TabIndex = 0;
            this.lv_KeyList.UseCompatibleStateImageBehavior = false;
            this.lv_KeyList.View = System.Windows.Forms.View.Details;
            // 
            // col_Key
            // 
            this.col_Key.Text = "Key";
            this.col_Key.Width = 184;
            // 
            // txt_Key
            // 
            this.txt_Key.Location = new System.Drawing.Point(12, 229);
            this.txt_Key.Name = "txt_Key";
            this.txt_Key.Size = new System.Drawing.Size(132, 21);
            this.txt_Key.TabIndex = 1;
            this.txt_Key.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Key_KeyPress);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(150, 229);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(50, 23);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_DelAll
            // 
            this.btn_DelAll.Location = new System.Drawing.Point(218, 42);
            this.btn_DelAll.Name = "btn_DelAll";
            this.btn_DelAll.Size = new System.Drawing.Size(75, 23);
            this.btn_DelAll.TabIndex = 3;
            this.btn_DelAll.Text = "Delete All";
            this.btn_DelAll.UseVisualStyleBackColor = true;
            this.btn_DelAll.Click += new System.EventHandler(this.btn_DelAll_Click);
            // 
            // btn_ImportData
            // 
            this.btn_ImportData.Location = new System.Drawing.Point(218, 210);
            this.btn_ImportData.Name = "btn_ImportData";
            this.btn_ImportData.Size = new System.Drawing.Size(75, 40);
            this.btn_ImportData.TabIndex = 4;
            this.btn_ImportData.Text = "Import From Data";
            this.btn_ImportData.UseVisualStyleBackColor = true;
            this.btn_ImportData.Click += new System.EventHandler(this.btn_ImportData_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(218, 13);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(75, 23);
            this.btn_Del.TabIndex = 6;
            this.btn_Del.Text = "Delete";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // Key
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 264);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_ImportData);
            this.Controls.Add(this.btn_DelAll);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_Key);
            this.Controls.Add(this.lv_KeyList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Key";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Key List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Key_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_KeyList;
        private System.Windows.Forms.TextBox txt_Key;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_DelAll;
        private System.Windows.Forms.Button btn_ImportData;
        private System.Windows.Forms.ColumnHeader col_Key;
        private System.Windows.Forms.Button btn_Del;
    }
}