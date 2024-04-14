using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;

namespace AwesomeAppInstaller
{
    public partial class Form2 : Form
    {
        private SoundPlayer sp = new SoundPlayer();
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/AwesomeLime/Awesome-App-Installer");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sp.Stream = Properties.Resources.ussr;
            sp.Play();
            Sound.Start();
            new Form3().ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sp.Stop();
            Sound.Stop();
        }
    }
}
