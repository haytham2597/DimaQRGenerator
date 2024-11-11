using System;
using System.Diagnostics;
using System.Windows.Forms;
using DimaQRGenerator.Forms;
using DimaQRGenerator.Libs;
using DimaQRGenerator.Libs.Extensions;
using DimaQRGenerator.Libs.Mediator;
using QRCoder;

namespace DimaQRGenerator
{
    public partial class Main : Form, IMediator
    {
        private Utils.D2DControl d2d = new Utils.D2DControl();
        private QRConfig QRC = new QRConfig();
        public Main()
        {
            InitializeComponent();
            this.KeyPreview = true;
            var qrconf = new QRConfiguration();
            panel_configuration.Controls.Add(qrconf.SetConfForm());
            qrconf.Config.SetMediator(this);
            qrconf.Show();
            d2d.Dock = DockStyle.Fill;
            tlp_qr_control.RowStyles[0].Height = qrconf.Height;
            tlp_qr_control.Controls.Add(d2d, 0, tlp_qr_control.RowCount-1);
            textBox_qr_data.TextChanged += TextBox_qr_data_TextChanged;
            this.KeyDown += (sender, args) =>
            {
                if (args.Control && args.KeyCode == Keys.S)
                {
                    using (var sfd = new SaveFileDialog())
                    {
                        if (sfd.ShowDialog() != DialogResult.OK)
                            return;
                        SaveQR(sfd.FileName);
                    }
                }
            };
            button_add_qr.Click += Button_add_qr_Click;
            textBox_qr_data.Select();
            newToolStripMenuItem.Click += NewToolStripMenuItem_Click;
            openToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            saveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
        }

        private void Button_add_qr_Click(object sender, EventArgs e)
        {
            treeView_qrs.Nodes.Add(new TreeNode($"Capa {treeView_qrs.Nodes.Count + 1}") { Tag = QRC });
        }

        private void SaveQR(string path)
        {
            using (var data = QRCodeGenerator.GenerateQrCode(textBox_qr_data.Text, QRC.EccLevel, QRC.ForceUTF8, eciMode: QRC.EciMode))
            using (var m = data.GetQR(QRC.PixelPerModule, QRC.DarkColor, QRC.LightColor, QRC.QuietZone))
                m.Save(path);
        }

        private void RenderQR()
        {
            var start = Stopwatch.GetTimestamp();
            using (var data = QRCodeGenerator.GenerateQrCode(textBox_qr_data.Text, QRC.EccLevel, QRC.ForceUTF8, eciMode: QRC.EciMode))
                d2d.SetImage(data.GetQR(QRC.PixelPerModule, QRC.DarkColor, QRC.LightColor, QRC.QuietZone));
            toolStripStatusLabel_status.Text = $"Estado: Tiempo {new TimeSpan(Stopwatch.GetTimestamp() - start).TotalMilliseconds}ms";
        }
        private void TextBox_qr_data_TextChanged(object sender, EventArgs e)
        {
            RenderQR();
        }

        public void Notify(object sender, string ev)
        {
            if (ev != "changed" || !(sender is QRConfig qrc)) 
                return;

            lock (QRC)
            {
                this.QRC = qrc;
                RenderQR();
            }
        }
    }
}
