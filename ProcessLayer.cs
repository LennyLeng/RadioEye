using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace CSProcessLayer
{
    delegate void EndProcDelegate(string sExecResultTmp, int ExitCode);

    class ProcessLayer
    {
        public string m_RetErrorMsg;
        public StringBuilder m_RetOutputMsg;

        private Process m_Proc;
        private Thread m_Thrd;
        private ToolStripStatusLabel m_lb_Status;
        private TextBox m_txt_Log;
        private bool bIsRun;
        private bool bIsShow;

        public ProcessLayer(ToolStripStatusLabel ProcStatus, TextBox TxtLog)
        {
            m_lb_Status = ProcStatus;
            m_txt_Log = TxtLog;
            bIsRun = false;
            bIsShow = true;
        }

        public ProcessLayer()
        {
            m_lb_Status = null;
            m_txt_Log = null;
            bIsRun = false;
            bIsShow = false;
        }

        public bool SyncStart(string CmdName, string CmdArgv)
        {
            m_Proc = new Process();

            m_Proc.StartInfo.FileName = CmdName;
            m_Proc.StartInfo.Arguments = CmdArgv;
            m_Proc.StartInfo.CreateNoWindow = true;
            m_Proc.StartInfo.UseShellExecute = false;
            m_Proc.StartInfo.RedirectStandardInput = true;//标准输入重定向 
            m_Proc.StartInfo.RedirectStandardOutput = true;//标准输出重定向 
            m_Proc.StartInfo.RedirectStandardError = true;

            m_Proc.Start();

            StreamReader reader = m_Proc.StandardOutput;

            m_Proc.WaitForExit();
            m_RetOutputMsg = new StringBuilder();
            m_RetOutputMsg.Append(reader.ReadToEnd());
            reader = m_Proc.StandardError;
            m_RetErrorMsg = reader.ReadToEnd();

            int RetCode = m_Proc.ExitCode;
            m_Proc.Close();
            reader.Close();
            if (RetCode == 0)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        public bool AsyncStart(string CmdName, string CmdArgv, EndProcDelegate epd = null, bool bIsShow = true)
        {
            if (IdleCheck() == false)
            {
                return false;
            }
            this.bIsShow = bIsShow;
            m_Thrd = new Thread(delegate() { RunProc(CmdName, CmdArgv, epd); });
            m_Thrd.Start();
            return true;
        }

        public bool IdleCheck()
        {
            if (bIsRun)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Kill()
        {
            m_Proc.Kill();
            m_Proc.Close();
            m_Thrd.Abort();
            bIsRun = false;
        }

        private void RunProc(string CmdName, string CmdArgv, EndProcDelegate epd)
        {
            m_Proc = new Process();

            m_Proc.StartInfo.FileName = CmdName;
            m_Proc.StartInfo.Arguments = CmdArgv;
            m_Proc.StartInfo.CreateNoWindow = true;
            m_Proc.StartInfo.UseShellExecute = false;
            m_Proc.StartInfo.RedirectStandardInput = true;//标准输入重定向 
            m_Proc.StartInfo.RedirectStandardOutput = true;//标准输出重定向 
            m_Proc.StartInfo.RedirectStandardError = true;

            m_Proc.OutputDataReceived += new DataReceivedEventHandler(OutputRecv);
            m_Proc.ErrorDataReceived += new DataReceivedEventHandler(ErrorRecv);

            m_Proc.Start();
            bIsRun = true;
            m_lb_Status.Text = "Proc Status: Running";
            m_txt_Log.Clear();

            m_RetOutputMsg = new StringBuilder();
            m_Proc.BeginErrorReadLine();
            m_Proc.BeginOutputReadLine();

            m_Proc.WaitForExit();
            int ExitCode = m_Proc.ExitCode;
            m_Proc.Close();
            bIsRun = false;

            if (epd != null)
            {
                epd(m_RetOutputMsg.ToString(), ExitCode);
            }
            m_lb_Status.Text = "Proc Status: Ready";
        }  

        private void ErrorRecv(object SendProcess, DataReceivedEventArgs Output)
        {
            if (!String.IsNullOrEmpty(Output.Data))
            {
                Trace.WriteLine(Output.Data);
                m_RetErrorMsg = Output.Data;
            }
        }

        private void OutputRecv(object SendProcess, DataReceivedEventArgs Output)
        {
            if (!string.IsNullOrEmpty(Output.Data))
            {
                m_RetOutputMsg.Append(Output.Data + "\n");
                if (bIsShow)
                {
                    m_txt_Log.ScrollToCaret();
                    m_txt_Log.AppendText(Output.Data + "\n");
                }
            }
        }
    }
}
