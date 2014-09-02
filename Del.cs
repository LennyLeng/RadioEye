using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using CSHttpTransferLayer;

namespace RadioEye
{
    public partial class Del : Form
    {
        private string id;

        public Del(string id_tmp, string title_tmp)
        {
            InitializeComponent();
            id = id_tmp;
            lb_tip.Text = "Are you sure to delete [" + title_tmp + "]?";
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(GetDel));
            t.IsBackground = true;
            t.Start();
        }

        void GetDel()
        {
            btn_Ok.Visible = false;
            btn_Cancel.Visible = false;

            lb_ret.Text = "Processing...";
            lb_ret.Visible = true;
            Update();

            DialogResult bRetVal;
            string szRetTip;
            bool bRetFlag = HttpTransferLayer.DelItem(id, out szRetTip);

            if (bRetFlag == true)
            {
                bRetVal = DialogResult.OK;
                lb_ret.ForeColor = Color.Green;
            }
            else
            {
                bRetVal = DialogResult.Cancel;
                lb_ret.ForeColor = Color.Red;
            }
            lb_ret.Text = szRetTip;
            Update();
            Thread.Sleep(3000);
            DialogResult = bRetVal;
            Close();
        }
        
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
