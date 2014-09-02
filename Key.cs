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
    public partial class Key : Form
    {
        public string[] m_KeyList;
        private DataGridView m_dgv_Data;

        public Key(string[] KeyList, DataGridView dgv_Data)
        {
            InitializeComponent();
            
            m_dgv_Data = dgv_Data;

            if (KeyList != null)
            {
                foreach (string item in KeyList)
                {
                    ListViewItem lvi = new ListViewItem(item);
                    lv_KeyList.Items.Add(lvi);
                }
            }
        }

        private void Key_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<string> KeyListTmp = new List<string>();

            foreach (ListViewItem item in lv_KeyList.Items)
            {
                KeyListTmp.Add(item.Text);
            }
            m_KeyList = KeyListTmp.ToArray();
            DialogResult = DialogResult.OK;
            return;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!RegexStringLayer.CheckMatch(txt_Key.Text, @"^[0-9a-fA-F]{12}$"))
            {
                MessageBox.Show("请输入一个12位的16进制KEY值！");
                return;
            }
            ListViewItem lvi = new ListViewItem(txt_Key.Text);
            lv_KeyList.Items.Add(lvi);
            txt_Key.Text = "";
        }

        private void btn_ImportData_Click(object sender, EventArgs e)
        {
            if (m_dgv_Data.Rows.Count != 64)
            {
                return;
            }
            List<string> KeyListTmp = new List<string>();
            for (int i = 0; i < 64; i++)
            {
                KeyListTmp.Add(m_dgv_Data.Rows[i].Cells[4].Value.ToString());
                KeyListTmp.Add(m_dgv_Data.Rows[i].Cells[5].Value.ToString());
            }

            KeyListTmp = KeyListTmp.Distinct().ToList();

            foreach (string item in KeyListTmp)
            {
                ListViewItem lvi = new ListViewItem(item);
                lv_KeyList.Items.Add(lvi);
            }
        }

        private void btn_DelAll_Click(object sender, EventArgs e)
        {
            lv_KeyList.Items.Clear();
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lv_KeyList.SelectedItems)
            {
                lv_KeyList.Items.Remove(item);
            }
        }

        private void txt_Key_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar < 'a' || e.KeyChar > 'f') && (e.KeyChar < 'A' || e.KeyChar > 'F') && e.KeyChar != 8) || (e.KeyChar != 8 && ((TextBox)(sender)).Text.Length >= 12 ))
            {
                e.Handled = true;
            }
        }
    }
}
