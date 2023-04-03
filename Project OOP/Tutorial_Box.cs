using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Project_OOP
{
    public partial class Tutorial_Box : Form
    {
        public Tutorial_Box()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.URL = "F:\\Google Drive (Offline)\\Project OOP\\Project OOP\\Images\\CreditsRoll.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void Tutorial_Box_FormClosed(object sender, FormClosedEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
    }
}
