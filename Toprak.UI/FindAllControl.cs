using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toprak.UI
{
    public static class FindAllControl
    {

        public static IEnumerable<Control> All(this Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                foreach (Control grandChild in control.Controls.All())
                    yield return grandChild;

                yield return control;
            }
        }

    }
}
