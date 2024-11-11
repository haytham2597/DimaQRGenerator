using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QRCoder;

namespace DimaQRGenerator.Libs
{
    public partial class QRConfig
    {
        private PayloadGenerator.Payload payload;
        public PayloadGenerator.Payload Payload
        {
            set => SetField(ref payload, value, nameof(payload));
            get => payload;
        }
    }
}
