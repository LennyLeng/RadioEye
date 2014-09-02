using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CSHexStringByteArrayConverter;
using System.Threading;
using System.Diagnostics;
using CSHttpTransferLayer;

namespace RadioEye
{
    public partial class List : Form
    {
        public byte[] RetBytes;
        public string szSource;

        public List()
        {
            InitializeComponent();
        }

        private void Download_Load(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(GetList));
            t.IsBackground = true;
            t.Start();
        }

        private void GetList()
        {
            btn_Refresh.Enabled = false;
            btn_Download.Enabled = false;
            btn_Del.Enabled = false;
            Update();

            lv_DumpList.Items.Clear();

            List<ListItem> list = HttpTransferLayer.GetList();
            foreach (ListItem li in list)
            {
                ListViewItem lvi = new ListViewItem(li.title);
                lvi.Tag = li.id;
                lv_DumpList.Items.Add(lvi);
            }
            btn_Refresh.Enabled = true;
            btn_Download.Enabled = true;
            btn_Del.Enabled = true;
            Update();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            GetList();
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            if (lv_DumpList.SelectedItems.Count == 0)
            {
                return;
            }
            //string szRet = HttpBaseLayer.Get(ConfigManager.GetDomain() + "index.php/dump/item_show/" + lv_DumpList.SelectedItems[0].Tag.ToString(), ConfigManager.GetUserAgent());
            
            //RetBytes = Convert.FromBase64String(szRet);
            RetBytes = HttpTransferLayer.GetItem(lv_DumpList.SelectedItems[0].Tag.ToString());
            szSource = lv_DumpList.SelectedItems[0].Text;
            if (RetBytes == null)
            {
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
            Close();
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (lv_DumpList.SelectedItems.Count == 0)
            {
                return;
            }
            Del DelDialog = new Del(lv_DumpList.SelectedItems[0].Tag.ToString(), lv_DumpList.SelectedItems[0].Text.ToString());
            if (DelDialog.ShowDialog() == DialogResult.OK)
            {
                GetList();
            }
        }
    }
}
