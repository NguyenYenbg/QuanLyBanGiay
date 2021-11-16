using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanGiay.XuLy
{
    class common
    {
        //Drag Form: di chuyển Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public void DragForm(Form f)
        {
            ReleaseCapture();
            SendMessage(f.Handle, 0x112, 0xf012, 0);
        }
       
        //Exit Form
        public void ExitForm(Form f)
        {
            f.Close();
        }

        //Minimum Form
        public void MinimizeForm(Form f)
        {
            f.WindowState = FormWindowState.Minimized;
        }

        //Maximum Form
        public void MaximizeForm(Form f)
        {
            if (f.WindowState == FormWindowState.Normal)
                f.WindowState = FormWindowState.Maximized;
            else
                f.WindowState = FormWindowState.Normal;
        }
    }
}
