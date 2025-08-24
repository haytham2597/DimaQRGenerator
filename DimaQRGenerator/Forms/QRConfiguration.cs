using System;
using System.Windows.Forms;
using DimaQRGenerator.Libs;
using DimaQRGenerator.Libs.Extensions;
using QRCoder;

namespace DimaQRGenerator.Forms
{
    public partial class QRConfiguration : Form
    {
        public QRConfig Config = new QRConfig();
        public QRConfiguration()
        {
            InitializeComponent();

            FormExt.AddItemsCombobox<QRCodeGenerator.ECCLevel>(comboBox_ecc);
            FormExt.AddItemsCombobox<QRCodeGenerator.EciMode>(comboBox_eci_mode);
     
            comboBox_ecc.SelectedItem = QRCodeGenerator.ECCLevel.Default;
            comboBox_eci_mode.SelectedItem = QRCodeGenerator.EciMode.Default;
            button_light_qr.Click += Button_color_picker;
            button_dark_qr.Click += Button_color_picker;
            comboBox_ecc.SelectedIndexChanged += (sender, args) => {
                if (comboBox_ecc.SelectedItem is QRCodeGenerator.ECCLevel ecc)
                    Config.EccLevel = ecc;
            };
            comboBox_eci_mode.SelectedIndexChanged += (sender, args) => {
                if (comboBox_eci_mode.SelectedItem is QRCodeGenerator.EciMode eci)
                    Config.EciMode = eci;
            };
            numericUpDown_pixel_per_module.ValueChanged += (sender, args) => {
                Config.PixelPerModule = Convert.ToInt32(numericUpDown_pixel_per_module.Value);
            };
            checkBox_quiet_zone.CheckedChanged += CheckBox_config_CheckedChanged;
            checkBox1.CheckedChanged += CheckBox_config_CheckedChanged;
        }

        private void CheckBox_config_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender is CheckBox cb))
                return;
            if (cb.Name == checkBox_quiet_zone.Name)
                Config.QuietZone = checkBox_quiet_zone.Checked;
            if (cb.Name == checkBox1.Name)
                Config.ForceUTF8 = checkBox1.Checked;
        }

        private void Button_color_picker(object sender, System.EventArgs e)
        {
            if (!(sender is Button btn))
                return;
        
            using (ColorDialog cld = new ColorDialog())
            {
                if (cld.ShowDialog() != DialogResult.OK) 
                    return;
                if (btn.Name == button_light_qr.Name)
                {
                    Config.LightColor = cld.Color;
                }
                else
                {
                    Config.DarkColor = cld.Color;
                }
            }
        }
    }
}
