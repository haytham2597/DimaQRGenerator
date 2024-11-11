using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using DimaQRGenerator.Libs.Mediator;
using QRCoder;

namespace DimaQRGenerator.Libs
{
    public partial class QRConfig : BaseComponent, INotifyPropertyChanged
    {
        private QRCodeGenerator.ECCLevel eccLevel= QRCodeGenerator.ECCLevel.Default;
        public QRCodeGenerator.ECCLevel EccLevel
        {
            set => SetField(ref eccLevel, value, nameof(eccLevel));
            get => eccLevel;
        }
        private int pixelPerModule = 8;
        public int PixelPerModule
        {
            set => SetField(ref pixelPerModule, value, nameof(pixelPerModule));
            get => pixelPerModule;
        }
        private Color darkColor = Color.Black;
        public Color DarkColor
        {
            set => SetField(ref darkColor, value, nameof(darkColor));
            get => darkColor;
        }
        private Color lightColor = Color.White;
        public Color LightColor
        {
            set => SetField(ref lightColor, value, nameof(lightColor));
            get => lightColor;
        }
        private QRCodeGenerator.EciMode eciMode = QRCodeGenerator.EciMode.Default;
        public QRCodeGenerator.EciMode EciMode
        {
            set => SetField(ref eciMode, value, nameof(eciMode));
            get => eciMode;
        }
        private bool forceUTF8;
        public bool ForceUTF8
        {
            set => SetField(ref forceUTF8, value, nameof(forceUTF8));
            get => forceUTF8;
        }
        private bool quietZone=true;
        public bool QuietZone
        {
            set => SetField(ref quietZone, value, nameof(quietZone));
            get => quietZone;
        }
        public byte[] Data;
        public QRConfig()
        {
            this.PropertyChanged += (sender, args) =>
            {
                NotifyAll();
            };
        }

        public void NotifyAll()
        {
            base._mediator.Notify(this, "changed");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
