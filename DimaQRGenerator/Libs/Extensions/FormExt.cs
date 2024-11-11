using System;
using System.Linq;
using System.Windows.Forms;

namespace DimaQRGenerator.Libs.Extensions
{
    public static class FormExt
    {
        public static Form SetConfForm(this Form f)
        {
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            return f;
        }

        public static void AddItemsCombobox<T>(ComboBox cb) where T : Enum
        {
            using (var enumer = Enum.GetValues(typeof(T)).Cast<T>().GetEnumerator())
            {
                while (enumer.MoveNext()) {
                    if (enumer.Current == null)
                        continue;
                    cb.Items.Add(enumer.Current);
                }
            }
        }
    }
}
