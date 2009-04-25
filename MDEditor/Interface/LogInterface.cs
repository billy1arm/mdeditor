using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MDEditor.Interface
{
    public partial class LogInterface : Form
    {
        public LogInterface()
        {
            InitializeComponent();
        }

        public void Log(string text, bool addTimeStamp, params object[] param)
        {
            Log(String.Format(text, param), addTimeStamp);
        }

        public void Log(string text, params object[] param)
        {
            Log(String.Format(text, param), true);
        }

        public void Log(string text)
        {
            Log(text, true);
        }

        public void Log(string text, bool addTimeStamp)
        {
            if (addTimeStamp)
            {
                string time = DateTime.Now.ToShortTimeString();
                i_logWindow.AppendText(String.Format("[{0}] {1}", time, text));
            }
            else
            {
                i_logWindow.AppendText(text);
            }
        }

        private void LogInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sender == this && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
