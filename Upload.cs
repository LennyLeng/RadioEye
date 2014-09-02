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
    public partial class Upload : Form
    {
        private string uid;
        private string content;

        public Upload(string uid_tmp, string content_tmp)
        {
            InitializeComponent();
            uid = uid_tmp;
            content = content_tmp;
        }

        private void Upload_Load(object sender, EventArgs e)
        {
            string szDateTime = DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss");
            lb_Prefix.Text =uid + "[" + szDateTime + "][";
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            btn_Upload.Visible = false;
            lb_ret.Text = "Processing...";
            lb_ret.Visible = true;
            Update();

            DialogResult bRetVal;
            string szRetTip;
            bool bRetFlag = HttpTransferLayer.AddItem(lb_Prefix.Text + txt_Note.Text + lb_Suffix.Text, content, out szRetTip);

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
    }
}
