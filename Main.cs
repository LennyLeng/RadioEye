using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using CSHexStringByteArrayConverter;
using CSProcessLayer;
using CSFileLayer;
using CSRegexStringLayer;

namespace RadioEye
{
    public partial class Main : Form
    {
        private delegate void InvokeInsertItemDelegate(byte[] btBuf);
        
        private ProcessLayer pl;
        private string[] KeyList;
        private string Uid;

        public Main(string szDevice)
        {
            CheckForIllegalCrossThreadCalls = false; 
            InitializeComponent();
            Device.Text = "Device Info: " + szDevice;
            pl = new ProcessLayer(ProcStatus, txt_Log);
        }

        private void chk_Mode_CheckedChanged(object sender, EventArgs e)
        {
           if (((CheckBox)sender).Checked)
           {
                txt_Id.ReadOnly = false;
                btn_ReadId.Enabled = false;
                btn_WriteId.Enabled = true;
           }
           else
           {
                txt_Id.ReadOnly = true;
                btn_ReadId.Enabled = true;
                btn_WriteId.Enabled = false;
           }
        }

        private void btn_ReadId_Click(object sender, EventArgs e)
        {
            if (pl.AsyncStart("nfc/nfc-list.exe", "", GetUid) == false)
            {
                MessageBox.Show("已存在工作线程");
                return;
            }
        }

        private void GetUid(string sExecResultTmp, int ExitCode)
        {
            string[] RegexRet = RegexStringLayer.GetSubString(sExecResultTmp, "UID \\(\\S*\\): ((\\S\\S\\s\\s){4})");
            txt_Id.Text = Uid = RegexRet[0].Replace(" ", "").ToString().ToUpper();
        }

        private void GetUidToCrack(string sExecResultTmp, int ExitCode)
        {
            GetUid(sExecResultTmp, ExitCode);
            if (string.IsNullOrEmpty(Uid))
            {
                if (pl.m_RetErrorMsg != null && pl.m_RetErrorMsg.Length != 0)
                {
                    MessageBox.Show(pl.m_RetErrorMsg);
                }
                else
                {
                    MessageBox.Show("Can not get the UID of the card");
                }
                return;
            }

            if (FileLayer.Exists("key/" + Uid + ".dump"))
            {
                byte[] btBuf = FileLayer.Read("key/" + Uid + ".dump");

                if (btBuf == null)
                {
                    if (pl.m_RetErrorMsg != null && pl.m_RetErrorMsg.Length != 0)
                    {
                        MessageBox.Show(pl.m_RetErrorMsg);
                    }
                    else
                    {
                        if (pl.AsyncStart("nfc/mfoc.exe", "-P " + ud_Probe.Value.ToString() + " -T " + ud_distance.Value.ToString() + " -O key/" + Uid + ".dump", GetData) == false)
                        {
                            MessageBox.Show("已存在工作线程");
                            return;
                        }
                    }
                    return;
                }
                
                List<string> KeyListTmp = new List<string>();
                for (int i = 0; i < 64; i++)
                {
                    byte[] btBufTmp = new byte[6];
                    Buffer.BlockCopy(btBuf, 64 * i + 48, btBufTmp, 0, 6);
                    KeyListTmp.Add(HexStringByteArrayConverter.BytesToHexString(btBufTmp));
                    Buffer.BlockCopy(btBuf, 64 * i + 58, btBufTmp, 0, 6);
                    KeyListTmp.Add(HexStringByteArrayConverter.BytesToHexString(btBufTmp));
                }

                KeyListTmp = KeyListTmp.Distinct().ToList();
                
                StringBuilder sbKeyArgv = new StringBuilder();

                foreach (string item in KeyListTmp)
                {
                    sbKeyArgv.Append(" -k ");
                    sbKeyArgv.Append(item);
                }
                if (pl.AsyncStart("nfc/mfoc.exe", sbKeyArgv.ToString() + " -P " + ud_Probe.Value.ToString() + " -T " + ud_distance.Value.ToString() + " -O key/tmp.dump", GetData) == false)
                {
                    MessageBox.Show("已存在工作线程");
                    return;
                }
            }
            else
            {
                if (pl.AsyncStart("nfc/mfoc.exe", "-P " + ud_Probe.Value.ToString() + " -T " + ud_distance.Value.ToString() + " -O key/" + Uid + ".dump", GetData) == false)
                {
                    MessageBox.Show("已存在工作线程");
                    return;
                }
            }
        }

        private void GetData(string sExecResultTmp, int ExitCode)
        {
            if (ExitCode != 0)
            {
                if (pl.m_RetErrorMsg != null && pl.m_RetErrorMsg.Length != 0)
                {
                    MessageBox.Show(pl.m_RetErrorMsg);
                }
                else
                {
                    MessageBox.Show("Crack Failed");
                }
                return;
            }
            GetUid(sExecResultTmp, ExitCode);

            byte[] btBuf = FileLayer.Read("key/" + Uid + ".dump");
            if (btBuf == null)
            {
                if (pl.m_RetErrorMsg != null && pl.m_RetErrorMsg.Length != 0)
                {
                    MessageBox.Show(pl.m_RetErrorMsg);
                }
                else
                {
                    MessageBox.Show("Crack Failed");
                }
                return;
            }

            InvokeInsertItemDelegate iiid = new InvokeInsertItemDelegate(InvokeInsertItem);
            this.BeginInvoke(iiid, new object[] {btBuf});
            
            lb_source.Text = "Card Reader";
        }

        void InvokeInsertItem(byte[] btBuf)
        {
            dgv_DumpData.Rows.Clear();
            string szBuf = HexStringByteArrayConverter.BytesToHexString(btBuf);
            
            for (int i = 0; i < 64; i++)
            {
                dgv_DumpData.Rows.Add();
                dgv_DumpData.Rows[i].Cells[0].Value = i.ToString();
                dgv_DumpData.Rows[i].Cells[1].Value = szBuf.Substring(128 * i + 0, 32);
                dgv_DumpData.Rows[i].Cells[2].Value = szBuf.Substring(128 * i + 32, 32);
                dgv_DumpData.Rows[i].Cells[3].Value = szBuf.Substring(128 * i + 64, 32);
                dgv_DumpData.Rows[i].Cells[4].Value = szBuf.Substring(128 * i + 96, 12);
                dgv_DumpData.Rows[i].Cells[5].Value = szBuf.Substring(128 * i + 116, 12);
                dgv_DumpData.Rows[i].Cells[6].Value = szBuf.Substring(128 * i + 108, 8);
            }        
        }

        private void GetDataFromFile(string sFilePath)
        {
            byte[] btBuf = FileLayer.ReadWhileFixDump(sFilePath);

            if (btBuf == null)
            {
                MessageBox.Show("不是标准4K/1K.Dump文件");
                return;
            }

            InvokeInsertItem(btBuf);
            
            lb_source.Text = sFilePath;
        }

    
        private void btn_Crack_Click(object sender, EventArgs e)
        {
            if (chk_Key.Checked)
            {
                StringBuilder sbKeyArgv = new StringBuilder();

                foreach (string item in KeyList)
                {
                    sbKeyArgv.Append(" -k ");
                    sbKeyArgv.Append(item);
                }
                if (pl.AsyncStart("nfc/mfoc.exe", sbKeyArgv.ToString() + " -P " + ud_Probe.Value.ToString() + " -T " + ud_distance.Value.ToString() + " -O key/tmp.dump", GetData) == false)
                {
                    MessageBox.Show("已存在工作线程");
                    return;
                }
            }
            else
            {
                if (pl.AsyncStart("nfc/nfc-list.exe", "", GetUidToCrack, false) == false)
                //if (pbl.Start("nfc/mfoc.exe", "-P " + ud_Probe.Value.ToString() + " -T " + ud_distance.Value.ToString() + " -O key/tmp.dump", GetData) == false)
                {
                    MessageBox.Show("已存在工作线程");
                    return;
                }
            }
        }

        private void btn_WriteId_Click(object sender, EventArgs e)
        {
            if (!RegexStringLayer.CheckMatch(txt_Id.Text, @"^[0-9a-fA-F]{8}$"))
            {
                MessageBox.Show("请输入一个8位的16进制UID值！");
                return;
            }

            if (pl.AsyncStart("nfc/nfc-mfsetuid.exe", "-f " + txt_Id.Text) == false)
            {
                MessageBox.Show("已存在工作线程");
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pl.IdleCheck() == false)
            {
                if (MessageBox.Show("存在工作线程，是否强制结束？", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    pl.Kill();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void txt_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar < 'a' || e.KeyChar > 'f') && (e.KeyChar < 'A' || e.KeyChar > 'F') && e.KeyChar != 8) || (e.KeyChar != 8 && ((TextBox)(sender)).Text.Length >= 8))
            {
                e.Handled = true;
            }
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "(*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                GetDataFromFile(FileName);
            }
        }

        private byte[] GetGridViewData()
        {
            if (dgv_DumpData.Rows.Count != 64)
            {
                return null;
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 64; i++)
            {
                sb.Append(dgv_DumpData.Rows[i].Cells[1].Value.ToString());
                sb.Append(dgv_DumpData.Rows[i].Cells[2].Value.ToString());
                sb.Append(dgv_DumpData.Rows[i].Cells[3].Value.ToString());
                sb.Append(dgv_DumpData.Rows[i].Cells[4].Value.ToString());
                sb.Append(dgv_DumpData.Rows[i].Cells[6].Value.ToString());
                sb.Append(dgv_DumpData.Rows[i].Cells[5].Value.ToString());
            }
            return HexStringByteArrayConverter.HexStringToBytes(sb.ToString());
        }

        private void btn_Export2File_Click(object sender, EventArgs e)
        {
            if (dgv_DumpData.Rows.Count != 64)
            {
                return;
            }

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            FileLayer.Write(saveFileDialog.FileName, GetGridViewData());
            MessageBox.Show("保存到文件 [" + saveFileDialog.FileName.Substring(saveFileDialog.FileName.LastIndexOf("\\") + 1) + "] 成功！");
        }

        private void btn_DownloadNet_Click(object sender, EventArgs e)
        {
            List DownloadDlg = new List();
            if (DownloadDlg.ShowDialog() == DialogResult.OK)
            {
                InvokeInsertItem(DownloadDlg.RetBytes);
                lb_source.Text = "Net Storage <" + DownloadDlg.szSource + ">";
            }
        }

        private void dgv_DumpData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 1)
            {
                return;
            }

            Modify ModifyDlg = new Modify("Sector" + dgv_DumpData.Rows[e.RowIndex].Cells[0].Value.ToString(), dgv_DumpData.Columns[e.ColumnIndex].HeaderText, dgv_DumpData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());

            if (ModifyDlg.ShowDialog() == DialogResult.OK)
            {
                if (ModifyDlg.szDumpData.Equals(dgv_DumpData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) == false)
                {
                    dgv_DumpData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = ModifyDlg.szDumpData;
                    dgv_DumpData.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Yellow;
                }
            }
        }

        private void btn_UploadNet_Click(object sender, EventArgs e)
        {
            if (dgv_DumpData.Rows.Count != 64)
            {
                return;
            }
            
            Upload UploadDlg = new Upload(dgv_DumpData.Rows[0].Cells[1].Value.ToString().Substring(0, 8), Convert.ToBase64String(GetGridViewData()));

            UploadDlg.ShowDialog();
        }

        private void btn_WriteC_Click(object sender, EventArgs e)
        {
            if (dgv_DumpData.Rows.Count != 64)
            {
                return;
            }

            FileLayer.Write("key/tmp.dump", GetGridViewData());
            StringBuilder szArgv = new StringBuilder();
            szArgv.Append("w ");
            
            if (rb_KeyA.Checked)
            {
                szArgv.Append("a ");
            }
            else
            {
                szArgv.Append("b ");
            }

            szArgv.Append(" key/tmp.dump key/tmp.dump");

            if (pl.AsyncStart("nfc/nfc-mfclassic.exe", szArgv.ToString()) == false)
            {
                MessageBox.Show("已存在工作线程");
                return;
            }
        }

        private void btn_WriteU_Click(object sender, EventArgs e)
        {
            if (dgv_DumpData.Rows.Count != 64)
            {
                return;
            }

            FileLayer.Write("key/tmp.dump", GetGridViewData());
            StringBuilder szArgv = new StringBuilder();
            szArgv.Append("W ");

            if (rb_KeyA.Checked)
            {
                szArgv.Append("a ");
            }
            else
            {
                szArgv.Append("b ");
            }

            szArgv.Append(" key/tmp.dump key/tmp.dump");

            if (pl.AsyncStart("nfc/nfc-mfclassic.exe", szArgv.ToString()) == false)
            {
                MessageBox.Show("已存在工作线程");
                return;
            }
        }

        private void chk_Key_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Key.Checked)
            {
                btn_KeyList.Enabled = true;
            }
            else
            {
                btn_KeyList.Enabled = false;
            }
        }

        private void btn_KeyList_Click(object sender, EventArgs e)
        {
            Key KeyDlg = new Key(KeyList, dgv_DumpData);
            if (KeyDlg.ShowDialog() == DialogResult.OK)
            {
                KeyList = KeyDlg.m_KeyList;
                return;
            }
        }
    }
}
