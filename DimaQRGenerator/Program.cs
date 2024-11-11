using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace DimaQRGenerator
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ExtractEmbedding();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        private static void ExtractEmbedding()
        {
            var asse = Assembly.GetEntryAssembly();
            var names = asse?.GetManifestResourceNames();
            if (names == null)
                return;
            foreach (var name in names)
            {
                if (!name.EndsWith(".dll"))
                    continue;
                var spl = string.Join(".", name.Split('.').Skip(2));
                var file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, spl);
                if (File.Exists(file))
                    continue;
                using(var fs = new FileStream(file, FileMode.Create, FileAccess.Write))
                using (Stream st = asse.GetManifestResourceStream(name))
                {
                    if (st == null)
                        continue;
                    
                    byte[] data = new byte[st.Length];
                    if (st.Read(data, 0, data.Length) > 0)
                        fs.Write(data, 0, data.Length);
                }
            }
        }

        /*private static void LoadEmbedded()
        {
            var asse = Assembly.GetEntryAssembly();
            var names = asse?.GetManifestResourceNames();
            foreach (var name in names)
            {
                if (!name.EndsWith(".dll"))
                    continue;
                using(System.IO.Stream st = asse.GetManifestResourceStream(name))
                {
                    if (st == null)
                        continue;
                    byte[] data = new byte[st.Length];
                    if (st.Read(data, 0, data.Length) > 0)
                    {
                        var spl = string.Join(".",name.Split('.').Skip(2));
                        asse.LoadModule(spl, data);
                        Assembly.Load(data);
                    }

                }
            }
        }*/
    }
}
