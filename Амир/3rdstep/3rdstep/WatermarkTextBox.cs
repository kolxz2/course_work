using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3rdstep
{
    public class WatermarkTextBox : TextBox
    {
        private string watermark;

        public string Watermark
        {
            get { return watermark; }
            set { watermark = value; SetWatermark(); }
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private void SetWatermark()
        {
            const int EM_SETCUEBANNER = 0x1501;
            if (Handle != null)
                SendMessage(Handle, EM_SETCUEBANNER, 0, watermark);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            SetWatermark();
        }
    }
}
