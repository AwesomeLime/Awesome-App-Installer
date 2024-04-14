using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwesomeAppInstaller
{
    public partial class Form3 : Form
    {
        private SoundPlayer sp = new SoundPlayer();
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sp.Stream = Properties.Resources.ussr;
            sp.Play();
            Sound.Start();
        }

        private void Sound_Tick(object sender, EventArgs e)
        {
            sp.Stop();
            Sound.Stop();
        }
    }
}
