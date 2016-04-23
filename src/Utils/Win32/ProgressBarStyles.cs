using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTorrent.Utils.Win32
{
    public static class ProgressBarStyles
    {
        public enum ProgressBarColor : int
        {
            Green = 1,
            Red = 2,
            Yellow = 3,
        }

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);

        public static void SetProgressBarColor(ProgressBar pBar, ProgressBarColor pbColor)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)pbColor, IntPtr.Zero);
        }
    }
}
