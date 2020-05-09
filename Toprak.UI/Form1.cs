using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Toprak.UI
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1(int basamak)
        {
            InitializeComponent();
            for (int i = 0; i < basamak; i++)
            {
                ControlBasamak control = new ControlBasamak();
                Controls.Add(control);
                control.Dock = DockStyle.Bottom;
            }
        
        }
    }
}
