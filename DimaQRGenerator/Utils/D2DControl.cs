using Emgu.CV;
using DimaQRGenerator.Libs.Extensions;
using unvell.D2DLib;

namespace DimaQRGenerator.Utils
{
    public class D2DControl : unvell.D2DLib.WinForm.D2DControl
    {
        public D2DControl()
        {
            base.CreateHandle();
            base.DoubleBuffered = false;
        }

        private D2DBitmap d2dm;
        //private Mat mf = new Mat();
        public void SetImage(Mat m)
        {
            using (m)
            {
                if (m == null || m.IsEmpty)
                    return;
                d2dm = Device.CreateBitmapFromMat(m.Width, m.Height, m.DataPointer, (int)m.Numel());
                base.Invalidate();
            }
        }
        /*protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (mf != null && !mf.IsEmpty)
            {
                SetImage(mf);
                //return;
            }

            base.Invalidate();
        }*/
        /*protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            if (m.Msg != (int)Win32.WMessages.WM_SIZE) 
                return;
            //base.WndProc(ref m);
            Device.Resize();
            Invalidate(false);
        }*/

        protected override void OnRender(D2DGraphics g)
        {
            if (d2dm == null)
                return;
            if (d2dm.IsValid())
            {
                g.DrawBitmap(d2dm, this.ClientRectangle);
                d2dm.Dispose();
            }

        }
    }
}
