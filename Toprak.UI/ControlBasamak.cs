using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Toprak.UI.Properties;

namespace Toprak.UI
{
    public partial class ControlBasamak : DevExpress.XtraEditors.XtraUserControl
    {
        private Random rnd;
        private int randomInt = 0;
        public ControlBasamak()
        {
            InitializeComponent();
            rnd = new Random();
            randomInt = rnd.Next(1,5);
        }

        private void CheckChanged(object sender, EventArgs e)
        {
            CheckButton button = (CheckButton) sender;
            if (button.Text==randomInt.ToString())
            {
                if (button.Checked)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.No);
                    player.Play();
                    button.Appearance.BackColor = Color.Red;
                    Enabled = false;
                }
            }
            else
            {
                
                    System.Media.SoundPlayer player2 = new System.Media.SoundPlayer(Resources.Yes);
                    player2.Play();
                    button.Appearance.BackColor = Color.GreenYellow;
                    Enabled = false;
                
            }
        }
    }
}
