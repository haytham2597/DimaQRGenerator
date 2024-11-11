using Emgu.CV;

namespace DimaQRGenerator.Libs.Extensions
{
    public static class MatExt
    {
        public static long Numel(this Mat m)
        {
            return m.Step * m.Rows;
        }
    }
}
