using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimaNota
{
    public class Utils
    {
        public static void ShowWarning(string msg)
        {
            MessageBox.Show(msg, "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
