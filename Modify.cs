using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CSRegexStringLayer;

namespace RadioEye
{
    public partial class Modify : Form
    {
        public string szDumpData;
        private int DataLen;

        public Modify()
        {
            InitializeComponent();
        }

        public Modify(string szRowHeader, string szCloHeader, string szDumpDataTmp)
        {
            InitializeComponent();
            Text = "[" + szRowHeader + "] [" + szCloHeader + "]";
            txt_Data.Text = szDumpData = szDumpDataTmp;
            DataLen = szDumpData.Length;
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (!RegexStringLayer.CheckMatch(txt_Data.Text, @"^[0-9a-fA-F]{" + DataLen.ToString()+ @"}$"))
            {
                MessageBox.Show("请输入一个" + DataLen.ToString() + "位的16进制值！");
                return;
            }
            DialogResult = DialogResult.OK;
            szDumpData = txt_Data.Text.ToUpper();
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Data.Text = szDumpData;
        }

        private void txt_Data_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar < 'a' || e.KeyChar > 'f') && (e.KeyChar < 'A' || e.KeyChar > 'F') && e.KeyChar != 8) || (e.KeyChar != 8 && ((TextBox)(sender)).Text.Length >= DataLen))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
