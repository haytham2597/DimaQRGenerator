using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DimaQRGenerator.Libs;

namespace DimaQRGenerator
{
    public partial class Main
    {
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView_qrs.Nodes.Clear();
            this.QRC = new QRConfig();
        }
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            throw new NotImplementedException();
        }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "*.dimaqrproj";
                if (sfd.ShowDialog() != DialogResult.OK)
                    return;
                SaveProject(sfd.FileName);
            }
        }

        private void SaveProject(string path)
        {
            //Serialize all 
        }
    }
}
