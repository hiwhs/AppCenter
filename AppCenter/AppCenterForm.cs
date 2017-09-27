using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace HiWhs.AppCenter.UI
{
    public partial class AppCenterForm : DevExpress.XtraEditors.XtraForm
    {
        public AppCenterForm()
        {
            InitializeComponent();
        }

        private void _notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            var mPosition = MousePosition;

            Top = Screen.PrimaryScreen.WorkingArea.Bottom - Height;
            if (Top < 0)
            {
                Height = Screen.PrimaryScreen.WorkingArea.Bottom;
                Top = 0;
            }
            Left = (Screen.PrimaryScreen.WorkingArea.Width - MousePosition.X < Width)
                ? Screen.PrimaryScreen.WorkingArea.Width - Width : MousePosition.X;
            TopMost = true;
            Show();
        }

        private void XtraForm4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall || e.CloseReason == CloseReason.TaskManagerClosing || e.CloseReason == CloseReason.WindowsShutDown)
            {
                //Logger.Write("程序关闭，关闭原因" + e.CloseReason);
                //CommandStopSystem();
                e.Cancel = false;
                //UtilityHelper.InvokeExecute(this, Close);
            }
            else
            {
                e.Cancel = true;// !AppContext.Instance.UserExist;
                if (e.Cancel)
                {
                    //UtilityHelper.InvokeExecute(this, Hide);
                }
            }
        }

        private void _bbiEmp_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Process.Start("iexplore", @"http://deberp.com");
        }

        private void memoEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void navBarControl1_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {
            Width = e.Group == navBarGroup3 ? 600 : 300;
        }
    }
}