namespace RadioEye
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.grp_Base = new System.Windows.Forms.GroupBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.chk_Mode = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_WriteId = new System.Windows.Forms.Button();
            this.btn_ReadId = new System.Windows.Forms.Button();
            this.grp_Crack = new System.Windows.Forms.GroupBox();
            this.btn_KeyList = new System.Windows.Forms.Button();
            this.ud_distance = new System.Windows.Forms.NumericUpDown();
            this.lb_static_1 = new System.Windows.Forms.Label();
            this.lb_static_0 = new System.Windows.Forms.Label();
            this.ud_Probe = new System.Windows.Forms.NumericUpDown();
            this.chk_Key = new System.Windows.Forms.CheckBox();
            this.btn_Crack = new System.Windows.Forms.Button();
            this.btn_ImportFile = new System.Windows.Forms.Button();
            this.grp_Data = new System.Windows.Forms.GroupBox();
            this.btn_UploadNet = new System.Windows.Forms.Button();
            this.btn_DownloadNet = new System.Windows.Forms.Button();
            this.lb_source = new System.Windows.Forms.Label();
            this.lb_static_2 = new System.Windows.Forms.Label();
            this.btn_ExportFile = new System.Windows.Forms.Button();
            this.dgv_DumpData = new System.Windows.Forms.DataGridView();
            this.Sector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Block0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Block1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Block2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessBits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_Log = new System.Windows.Forms.GroupBox();
            this.txt_Log = new System.Windows.Forms.TextBox();
            this.grp_Write = new System.Windows.Forms.GroupBox();
            this.lb_static_3 = new System.Windows.Forms.Label();
            this.rb_KeyB = new System.Windows.Forms.RadioButton();
            this.rb_KeyA = new System.Windows.Forms.RadioButton();
            this.btn_WriteU = new System.Windows.Forms.Button();
            this.btn_WriteC = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.ProcStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.Device = new System.Windows.Forms.ToolStripStatusLabel();
            this.Author = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.grp_Base.SuspendLayout();
            this.grp_Crack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud_distance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_Probe)).BeginInit();
            this.grp_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DumpData)).BeginInit();
            this.grp_Log.SuspendLayout();
            this.grp_Write.SuspendLayout();
            this.Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_Base
            // 
            this.grp_Base.Controls.Add(this.txt_Id);
            this.grp_Base.Controls.Add(this.chk_Mode);
            this.grp_Base.Controls.Add(this.label1);
            this.grp_Base.Controls.Add(this.btn_WriteId);
            this.grp_Base.Controls.Add(this.btn_ReadId);
            this.grp_Base.Location = new System.Drawing.Point(12, 12);
            this.grp_Base.Name = "grp_Base";
            this.grp_Base.Size = new System.Drawing.Size(272, 82);
            this.grp_Base.TabIndex = 0;
            this.grp_Base.TabStop = false;
            this.grp_Base.Text = "Base";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(172, 15);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.ReadOnly = true;
            this.txt_Id.Size = new System.Drawing.Size(94, 21);
            this.txt_Id.TabIndex = 2;
            this.txt_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Id_KeyPress);
            // 
            // chk_Mode
            // 
            this.chk_Mode.AutoSize = true;
            this.chk_Mode.Location = new System.Drawing.Point(164, 57);
            this.chk_Mode.Name = "chk_Mode";
            this.chk_Mode.Size = new System.Drawing.Size(102, 16);
            this.chk_Mode.TabIndex = 0;
            this.chk_Mode.Text = "Write ID Mode";
            this.chk_Mode.UseVisualStyleBackColor = true;
            this.chk_Mode.CheckedChanged += new System.EventHandler(this.chk_Mode_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // btn_WriteId
            // 
            this.btn_WriteId.Enabled = false;
            this.btn_WriteId.Location = new System.Drawing.Point(6, 53);
            this.btn_WriteId.Name = "btn_WriteId";
            this.btn_WriteId.Size = new System.Drawing.Size(126, 23);
            this.btn_WriteId.TabIndex = 1;
            this.btn_WriteId.Text = "Write ID";
            this.btn_WriteId.UseVisualStyleBackColor = true;
            this.btn_WriteId.Click += new System.EventHandler(this.btn_WriteId_Click);
            // 
            // btn_ReadId
            // 
            this.btn_ReadId.Location = new System.Drawing.Point(6, 13);
            this.btn_ReadId.Name = "btn_ReadId";
            this.btn_ReadId.Size = new System.Drawing.Size(126, 23);
            this.btn_ReadId.TabIndex = 0;
            this.btn_ReadId.Text = "Read ID";
            this.btn_ReadId.UseVisualStyleBackColor = true;
            this.btn_ReadId.Click += new System.EventHandler(this.btn_ReadId_Click);
            // 
            // grp_Crack
            // 
            this.grp_Crack.Controls.Add(this.btn_KeyList);
            this.grp_Crack.Controls.Add(this.ud_distance);
            this.grp_Crack.Controls.Add(this.lb_static_1);
            this.grp_Crack.Controls.Add(this.lb_static_0);
            this.grp_Crack.Controls.Add(this.ud_Probe);
            this.grp_Crack.Controls.Add(this.chk_Key);
            this.grp_Crack.Controls.Add(this.btn_Crack);
            this.grp_Crack.Location = new System.Drawing.Point(12, 100);
            this.grp_Crack.Name = "grp_Crack";
            this.grp_Crack.Size = new System.Drawing.Size(560, 61);
            this.grp_Crack.TabIndex = 1;
            this.grp_Crack.TabStop = false;
            this.grp_Crack.Text = "Crack";
            // 
            // btn_KeyList
            // 
            this.btn_KeyList.Enabled = false;
            this.btn_KeyList.Location = new System.Drawing.Point(103, 23);
            this.btn_KeyList.Name = "btn_KeyList";
            this.btn_KeyList.Size = new System.Drawing.Size(97, 23);
            this.btn_KeyList.TabIndex = 8;
            this.btn_KeyList.Text = "Config Key";
            this.btn_KeyList.UseVisualStyleBackColor = true;
            this.btn_KeyList.Click += new System.EventHandler(this.btn_KeyList_Click);
            // 
            // ud_distance
            // 
            this.ud_distance.Location = new System.Drawing.Point(393, 24);
            this.ud_distance.Name = "ud_distance";
            this.ud_distance.Size = new System.Drawing.Size(41, 21);
            this.ud_distance.TabIndex = 7;
            this.ud_distance.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lb_static_1
            // 
            this.lb_static_1.AutoSize = true;
            this.lb_static_1.Location = new System.Drawing.Point(331, 28);
            this.lb_static_1.Name = "lb_static_1";
            this.lb_static_1.Size = new System.Drawing.Size(59, 12);
            this.lb_static_1.TabIndex = 6;
            this.lb_static_1.Text = "Distance:";
            // 
            // lb_static_0
            // 
            this.lb_static_0.AutoSize = true;
            this.lb_static_0.Location = new System.Drawing.Point(224, 28);
            this.lb_static_0.Name = "lb_static_0";
            this.lb_static_0.Size = new System.Drawing.Size(41, 12);
            this.lb_static_0.TabIndex = 5;
            this.lb_static_0.Text = "Probe:";
            // 
            // ud_Probe
            // 
            this.ud_Probe.Location = new System.Drawing.Point(268, 24);
            this.ud_Probe.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.ud_Probe.Name = "ud_Probe";
            this.ud_Probe.Size = new System.Drawing.Size(41, 21);
            this.ud_Probe.TabIndex = 4;
            this.ud_Probe.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // chk_Key
            // 
            this.chk_Key.AutoSize = true;
            this.chk_Key.Location = new System.Drawing.Point(14, 27);
            this.chk_Key.Name = "chk_Key";
            this.chk_Key.Size = new System.Drawing.Size(84, 16);
            this.chk_Key.TabIndex = 1;
            this.chk_Key.Text = "Custom Key";
            this.chk_Key.UseVisualStyleBackColor = true;
            this.chk_Key.CheckedChanged += new System.EventHandler(this.chk_Key_CheckedChanged);
            // 
            // btn_Crack
            // 
            this.btn_Crack.Location = new System.Drawing.Point(457, 23);
            this.btn_Crack.Name = "btn_Crack";
            this.btn_Crack.Size = new System.Drawing.Size(97, 23);
            this.btn_Crack.TabIndex = 0;
            this.btn_Crack.Text = "Crack";
            this.btn_Crack.UseVisualStyleBackColor = true;
            this.btn_Crack.Click += new System.EventHandler(this.btn_Crack_Click);
            // 
            // btn_ImportFile
            // 
            this.btn_ImportFile.Location = new System.Drawing.Point(6, 354);
            this.btn_ImportFile.Name = "btn_ImportFile";
            this.btn_ImportFile.Size = new System.Drawing.Size(101, 23);
            this.btn_ImportFile.TabIndex = 0;
            this.btn_ImportFile.Text = "Import File";
            this.btn_ImportFile.UseVisualStyleBackColor = true;
            this.btn_ImportFile.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // grp_Data
            // 
            this.grp_Data.Controls.Add(this.btn_UploadNet);
            this.grp_Data.Controls.Add(this.btn_DownloadNet);
            this.grp_Data.Controls.Add(this.lb_source);
            this.grp_Data.Controls.Add(this.lb_static_2);
            this.grp_Data.Controls.Add(this.btn_ExportFile);
            this.grp_Data.Controls.Add(this.btn_ImportFile);
            this.grp_Data.Controls.Add(this.dgv_DumpData);
            this.grp_Data.Location = new System.Drawing.Point(578, 12);
            this.grp_Data.Name = "grp_Data";
            this.grp_Data.Size = new System.Drawing.Size(600, 389);
            this.grp_Data.TabIndex = 3;
            this.grp_Data.TabStop = false;
            this.grp_Data.Text = "Data";
            // 
            // btn_UploadNet
            // 
            this.btn_UploadNet.Location = new System.Drawing.Point(493, 354);
            this.btn_UploadNet.Name = "btn_UploadNet";
            this.btn_UploadNet.Size = new System.Drawing.Size(101, 23);
            this.btn_UploadNet.TabIndex = 6;
            this.btn_UploadNet.Text = "Upload Net";
            this.btn_UploadNet.UseVisualStyleBackColor = true;
            this.btn_UploadNet.Click += new System.EventHandler(this.btn_UploadNet_Click);
            // 
            // btn_DownloadNet
            // 
            this.btn_DownloadNet.Location = new System.Drawing.Point(340, 354);
            this.btn_DownloadNet.Name = "btn_DownloadNet";
            this.btn_DownloadNet.Size = new System.Drawing.Size(101, 23);
            this.btn_DownloadNet.TabIndex = 5;
            this.btn_DownloadNet.Text = "Download Net";
            this.btn_DownloadNet.UseVisualStyleBackColor = true;
            this.btn_DownloadNet.Click += new System.EventHandler(this.btn_DownloadNet_Click);
            // 
            // lb_source
            // 
            this.lb_source.AutoSize = true;
            this.lb_source.Location = new System.Drawing.Point(59, 18);
            this.lb_source.Name = "lb_source";
            this.lb_source.Size = new System.Drawing.Size(29, 12);
            this.lb_source.TabIndex = 4;
            this.lb_source.Text = "NULL";
            // 
            // lb_static_2
            // 
            this.lb_static_2.AutoSize = true;
            this.lb_static_2.Location = new System.Drawing.Point(6, 18);
            this.lb_static_2.Name = "lb_static_2";
            this.lb_static_2.Size = new System.Drawing.Size(47, 12);
            this.lb_static_2.TabIndex = 3;
            this.lb_static_2.Text = "Source:";
            // 
            // btn_ExportFile
            // 
            this.btn_ExportFile.Location = new System.Drawing.Point(170, 354);
            this.btn_ExportFile.Name = "btn_ExportFile";
            this.btn_ExportFile.Size = new System.Drawing.Size(101, 23);
            this.btn_ExportFile.TabIndex = 2;
            this.btn_ExportFile.Text = "Export File";
            this.btn_ExportFile.UseVisualStyleBackColor = true;
            this.btn_ExportFile.Click += new System.EventHandler(this.btn_Export2File_Click);
            // 
            // dgv_DumpData
            // 
            this.dgv_DumpData.AllowUserToAddRows = false;
            this.dgv_DumpData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DumpData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DumpData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DumpData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sector,
            this.Block0,
            this.Block1,
            this.Block2,
            this.KeyA,
            this.KeyB,
            this.AccessBits});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DumpData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DumpData.Location = new System.Drawing.Point(6, 40);
            this.dgv_DumpData.Name = "dgv_DumpData";
            this.dgv_DumpData.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DumpData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_DumpData.RowTemplate.Height = 23;
            this.dgv_DumpData.Size = new System.Drawing.Size(588, 300);
            this.dgv_DumpData.TabIndex = 1;
            this.dgv_DumpData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DumpData_CellDoubleClick);
            // 
            // Sector
            // 
            this.Sector.HeaderText = "Sector";
            this.Sector.Name = "Sector";
            this.Sector.ReadOnly = true;
            this.Sector.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Sector.Width = 50;
            // 
            // Block0
            // 
            this.Block0.HeaderText = "Block0";
            this.Block0.Name = "Block0";
            this.Block0.ReadOnly = true;
            this.Block0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Block0.Width = 200;
            // 
            // Block1
            // 
            this.Block1.HeaderText = "Block1";
            this.Block1.Name = "Block1";
            this.Block1.ReadOnly = true;
            this.Block1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Block1.Width = 200;
            // 
            // Block2
            // 
            this.Block2.HeaderText = "Block2";
            this.Block2.Name = "Block2";
            this.Block2.ReadOnly = true;
            this.Block2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Block2.Width = 200;
            // 
            // KeyA
            // 
            this.KeyA.HeaderText = "KeyA";
            this.KeyA.Name = "KeyA";
            this.KeyA.ReadOnly = true;
            this.KeyA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.KeyA.Width = 80;
            // 
            // KeyB
            // 
            this.KeyB.HeaderText = "KeyB";
            this.KeyB.Name = "KeyB";
            this.KeyB.ReadOnly = true;
            this.KeyB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.KeyB.Width = 80;
            // 
            // AccessBits
            // 
            this.AccessBits.HeaderText = "AccessBits";
            this.AccessBits.Name = "AccessBits";
            this.AccessBits.ReadOnly = true;
            this.AccessBits.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AccessBits.Width = 70;
            // 
            // grp_Log
            // 
            this.grp_Log.Controls.Add(this.txt_Log);
            this.grp_Log.Location = new System.Drawing.Point(12, 167);
            this.grp_Log.Name = "grp_Log";
            this.grp_Log.Size = new System.Drawing.Size(560, 234);
            this.grp_Log.TabIndex = 4;
            this.grp_Log.TabStop = false;
            this.grp_Log.Text = "Log";
            // 
            // txt_Log
            // 
            this.txt_Log.Location = new System.Drawing.Point(8, 17);
            this.txt_Log.Multiline = true;
            this.txt_Log.Name = "txt_Log";
            this.txt_Log.ReadOnly = true;
            this.txt_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Log.Size = new System.Drawing.Size(544, 211);
            this.txt_Log.TabIndex = 0;
            // 
            // grp_Write
            // 
            this.grp_Write.Controls.Add(this.lb_static_3);
            this.grp_Write.Controls.Add(this.rb_KeyB);
            this.grp_Write.Controls.Add(this.rb_KeyA);
            this.grp_Write.Controls.Add(this.btn_WriteU);
            this.grp_Write.Controls.Add(this.btn_WriteC);
            this.grp_Write.Location = new System.Drawing.Point(290, 12);
            this.grp_Write.Name = "grp_Write";
            this.grp_Write.Size = new System.Drawing.Size(282, 82);
            this.grp_Write.TabIndex = 2;
            this.grp_Write.TabStop = false;
            this.grp_Write.Text = "Write";
            // 
            // lb_static_3
            // 
            this.lb_static_3.AutoSize = true;
            this.lb_static_3.Location = new System.Drawing.Point(171, 18);
            this.lb_static_3.Name = "lb_static_3";
            this.lb_static_3.Size = new System.Drawing.Size(29, 12);
            this.lb_static_3.TabIndex = 6;
            this.lb_static_3.Text = "Use:";
            // 
            // rb_KeyB
            // 
            this.rb_KeyB.AutoSize = true;
            this.rb_KeyB.Location = new System.Drawing.Point(206, 57);
            this.rb_KeyB.Name = "rb_KeyB";
            this.rb_KeyB.Size = new System.Drawing.Size(47, 16);
            this.rb_KeyB.TabIndex = 5;
            this.rb_KeyB.Text = "KeyB";
            this.rb_KeyB.UseVisualStyleBackColor = true;
            // 
            // rb_KeyA
            // 
            this.rb_KeyA.AutoSize = true;
            this.rb_KeyA.Checked = true;
            this.rb_KeyA.Location = new System.Drawing.Point(206, 16);
            this.rb_KeyA.Name = "rb_KeyA";
            this.rb_KeyA.Size = new System.Drawing.Size(47, 16);
            this.rb_KeyA.TabIndex = 4;
            this.rb_KeyA.TabStop = true;
            this.rb_KeyA.Text = "KeyA";
            this.rb_KeyA.UseVisualStyleBackColor = true;
            // 
            // btn_WriteU
            // 
            this.btn_WriteU.Location = new System.Drawing.Point(6, 53);
            this.btn_WriteU.Name = "btn_WriteU";
            this.btn_WriteU.Size = new System.Drawing.Size(126, 23);
            this.btn_WriteU.TabIndex = 3;
            this.btn_WriteU.Text = "Write UID Card";
            this.btn_WriteU.UseVisualStyleBackColor = true;
            this.btn_WriteU.Click += new System.EventHandler(this.btn_WriteU_Click);
            // 
            // btn_WriteC
            // 
            this.btn_WriteC.Location = new System.Drawing.Point(6, 13);
            this.btn_WriteC.Name = "btn_WriteC";
            this.btn_WriteC.Size = new System.Drawing.Size(126, 23);
            this.btn_WriteC.TabIndex = 1;
            this.btn_WriteC.Text = "Write  Card";
            this.btn_WriteC.UseVisualStyleBackColor = true;
            this.btn_WriteC.Click += new System.EventHandler(this.btn_WriteC_Click);
            // 
            // Status
            // 
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProcStatus,
            this.Device,
            this.Author});
            this.Status.Location = new System.Drawing.Point(0, 409);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(1190, 22);
            this.Status.TabIndex = 5;
            this.Status.Text = "statusStrip1";
            // 
            // ProcStatus
            // 
            this.ProcStatus.Name = "ProcStatus";
            this.ProcStatus.Size = new System.Drawing.Size(104, 17);
            this.ProcStatus.Text = "Proc Status: Ready";
            // 
            // Device
            // 
            this.Device.Name = "Device";
            this.Device.Size = new System.Drawing.Size(989, 17);
            this.Device.Spring = true;
            this.Device.Text = "Device Info:";
            // 
            // Author
            // 
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(82, 17);
            this.Author.Text = "Author: Lenny";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1190, 431);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.grp_Write);
            this.Controls.Add(this.grp_Log);
            this.Controls.Add(this.grp_Data);
            this.Controls.Add(this.grp_Crack);
            this.Controls.Add(this.grp_Base);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RFID RadioEye V1.02";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.grp_Base.ResumeLayout(false);
            this.grp_Base.PerformLayout();
            this.grp_Crack.ResumeLayout(false);
            this.grp_Crack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud_distance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_Probe)).EndInit();
            this.grp_Data.ResumeLayout(false);
            this.grp_Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DumpData)).EndInit();
            this.grp_Log.ResumeLayout(false);
            this.grp_Log.PerformLayout();
            this.grp_Write.ResumeLayout(false);
            this.grp_Write.PerformLayout();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Base;
        private System.Windows.Forms.GroupBox grp_Crack;
        private System.Windows.Forms.GroupBox grp_Data;
        private System.Windows.Forms.GroupBox grp_Log;
        private System.Windows.Forms.Button btn_WriteId;
        private System.Windows.Forms.Button btn_ReadId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.CheckBox chk_Mode;
        private System.Windows.Forms.TextBox txt_Log;
        private System.Windows.Forms.Button btn_Crack;
        private System.Windows.Forms.GroupBox grp_Write;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripStatusLabel Author;
        private System.Windows.Forms.ToolStripStatusLabel ProcStatus;
        private System.Windows.Forms.ToolStripStatusLabel Device;
        private System.Windows.Forms.CheckBox chk_Key;
        private System.Windows.Forms.NumericUpDown ud_Probe;
        private System.Windows.Forms.NumericUpDown ud_distance;
        private System.Windows.Forms.Label lb_static_1;
        private System.Windows.Forms.Label lb_static_0;
        private System.Windows.Forms.Button btn_WriteU;
        private System.Windows.Forms.Button btn_WriteC;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btn_ImportFile;
        private System.Windows.Forms.DataGridView dgv_DumpData;
        private System.Windows.Forms.Button btn_ExportFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label lb_static_2;
        private System.Windows.Forms.Label lb_source;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sector;
        private System.Windows.Forms.DataGridViewTextBoxColumn Block0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Block1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Block2;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyA;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyB;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessBits;
        private System.Windows.Forms.Button btn_DownloadNet;
        private System.Windows.Forms.Button btn_UploadNet;
        private System.Windows.Forms.RadioButton rb_KeyB;
        private System.Windows.Forms.RadioButton rb_KeyA;
        private System.Windows.Forms.Label lb_static_3;
        private System.Windows.Forms.Button btn_KeyList;
    }
}

