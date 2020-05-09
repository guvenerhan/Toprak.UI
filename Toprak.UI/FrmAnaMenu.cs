using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Toprak.UI
{
    public partial class FrmAnaMenu : DevExpress.XtraEditors.XtraForm
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Form1 form=new Form1(Convert.ToInt32(calcEdit1.Value));
            form.Show();
        }
    }
}