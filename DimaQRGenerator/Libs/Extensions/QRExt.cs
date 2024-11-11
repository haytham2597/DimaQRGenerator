using System.Drawing;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using QRCoder;

namespace DimaQRGenerator.Libs.Extensions
{
    public static class QRExt
    {
        public static Mat GetQR(this QRCodeData qrdata)
        {
            return GetQR(qrdata, 16, Color.Black, Color.White);
        }
        public static Mat GetQR(this QRCodeData qrdata, int pixelsPerModule, Color darkColor, Color lightColor, bool drawQuietZones = true)
        {
            var size = (qrdata.ModuleMatrix.Count - (drawQuietZones ? 0 : 8)) * pixelsPerModule;
            var offset = drawQuietZones ? 0 : 4 * pixelsPerModule;
            Mat m = new Mat(new Size(size, size), DepthType.Cv8U, 4);

            for (var x = 0; x < size + offset; x += pixelsPerModule)
            for (var y = 0; y < size + offset; y += pixelsPerModule)
            {
                var module = qrdata.ModuleMatrix[(y + pixelsPerModule) / pixelsPerModule - 1][(x + pixelsPerModule) / pixelsPerModule - 1];
                
                CvInvoke.Rectangle(
                    m, 
                    new Rectangle(x - offset, y - offset, pixelsPerModule, pixelsPerModule), 
                    module ? new MCvScalar(darkColor.B, darkColor.G, darkColor.R,darkColor.A) : new MCvScalar(lightColor.B, lightColor.G, lightColor.R, lightColor.A),
                    -1
                );
            }
            return m;
        } 
    }
}
