using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwesomeAppInstaller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.chocoInstalled == false)
            {
                DialogResult chocoFR = MessageBox.Show("Для работы данной программы требуется компонент Chocolatey. Вы хотите его установить?", "AAI - Первый запуск", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(chocoFR == DialogResult.Yes)
                {
                    Process.Start("powershell.exe", "Set-ExecutionPolicy Bypass -Scope Process -Force; [System.Net.ServicePointManager]::SecurityProtocol = [System.Net.ServicePointManager]::SecurityProtocol -bor 3072; iex ((New-Object System.Net.WebClient).DownloadString('https://community.chocolatey.org/install.ps1'))");
                    Properties.Settings.Default.chocoInstalled = true;
                    DialogResult chocoReboot = MessageBox.Show("Для корректной работы Chocolatey необходимо выполнить перезагрузку. Вы хотите выполнить её сейчас?", "AAI - Требуется перезагрузка!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (chocoReboot == DialogResult.Yes)
                    {
                        Process.Start("cmd.exe", "/c shutdown /r /t 0");
                    }
                }
                else if(chocoFR == DialogResult.No)
                {
                    this.Close();
                }
            }
            Properties.Settings.Default.Page = 1;
            Properties.Settings.Default.Save();
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Awesome App Installer\nВерсия AAI: 1.0 Release\nСборка: 100.aaprelease\nДата сборки: 14.04.2024 14:10","AAI - Информация о сборке",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.Page == 1)
            {
                Properties.Settings.Default.Page = 2;
                pageText.Text = "2/2";
                button1.Text = "CPU-Z";
                button2.Text = "AIDA64";
                button3.Text = "AnyDesk";
                button4.Text = "Revo Uninstaller";
                button5.Text = "Mem Reduct";
                button6.Text = "Rufus";
                button7.Text = "LibreOffice";
                button8.Text = "Notepad++";
                button9.Text = "Paint.NET";
                button10.Text = "Media Player Classic";
                button11.Text = "VLC";
                button12.Text = "OBS Studio";
                button13.Text = "Audacity";
            }
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.Page == 1)
            {
                left.Enabled = false;
                right.Enabled = true;
            }
            else if (Properties.Settings.Default.Page == 2)
            {
                right.Enabled = false;
                left.Enabled = true;
            }
        }

        private void left_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Page == 2)
            {
                Properties.Settings.Default.Page = 1;
                pageText.Text = "1/2";
                button1.Text = "Firefox";
                button2.Text = "Google Chrome";
                button3.Text = "Telegram";
                button4.Text = "qBitTorrent";
                button5.Text = "WinRAR";
                button6.Text = "7-Zip";
                button7.Text = "Java";
                button8.Text = "DirectX";
                button9.Text = "Visual C++ Redistributable";
                button10.Text = "Internet Download Manager";
                button11.Text = "Discord";
                button12.Text = "Steam";
                button13.Text = "Spotify";
            }
        }

        private void button14_Click_2(object sender, EventArgs e)
        {
            DialogResult chocoRe = MessageBox.Show("Вы действительно хотите переустановить Chocolatey?", "AAI - Установка Chocolatey", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (chocoRe == DialogResult.Yes)
            {
                Process.Start("powershell.exe", "Set-ExecutionPolicy Bypass -Scope Process -Force; [System.Net.ServicePointManager]::SecurityProtocol = [System.Net.ServicePointManager]::SecurityProtocol -bor 3072; iex ((New-Object System.Net.WebClient).DownloadString('https://community.chocolatey.org/install.ps1'))");
                DialogResult chocoReboot = MessageBox.Show("Для корректной работы Chocolatey необходимо выполнить перезагрузку. Вы хотите выполнить её сейчас?", "AAI - Требуется перезагрузка!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (chocoReboot == DialogResult.Yes)
                {
                    Process.Start("cmd.exe", "/c shutdown /r /t 0");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.Page == 1)
            {
                Status.Text = "Вы начали установку Mozilla Firefox";
                Process.Start("powershell.exe", "choco install firefox -y");
            }
            else if(Properties.Settings.Default.Page == 2)
            {
                Status.Text = "Вы начали установку CPU-Z";
                Process.Start("powershell.exe", "choco install cpu-z -y");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Page == 1)
            {
                Status.Text = "Вы начали установку Google Chrome";
                Process.Start("powershell.exe", "choco install googlechrome -y");
            }
            else if (Properties.Settings.Default.Page == 2)
            {
                Status.Text = "Вы начали установку AIDA64";
                Process.Start("powershell.exe", "choco install aida64-extreme -y");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Page == 1)
            {
                Status.Text = "Вы начали установку Telegram";
                Process.Start("powershell.exe", "choco install telegram -y");
            }
            else if (Properties.Settings.Default.Page == 2)
            {
                Status.Text = "Вы начали установку AnyDesk";
                Process.Start("powershell.exe", "choco install anydesk -y");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Page == 1)
            {
                Status.Text = "Вы начали установку 7-Zip";
                Process.Start("powershell.exe", "choco install 7zip -y");
            }
            else if (Properties.Settings.Default.Page == 2)
            {
                Status.Text = "Вы начали установку Rufus";
                Process.Start("powershell.exe", "choco install rufus -y");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Page == 1)
            {
                Status.Text = "Вы начали установку WinRAR";
                Process.Start("powershell.exe", "choco install winrar -y --ignore-checksums");
            }
            else if (Properties.Settings.Default.Page == 2)
            {
                Status.Text = "Вы начали установку Mem Reduct";
                Process.Start("powershell.exe", "choco install memreduct -y");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Page == 1)
            {
                Status.Text = "Вы начали установку qBitTorrent";
                Process.Start("powershell.exe", "choco install qbittorrent -y");
            }
            else if (Properties.Settings.Default.Page == 2)
            {
                Status.Text = "Вы начали установку Revo Uninstaller";
                Process.Start("powershell.exe", "choco install revo-uninstaller -y");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Page == 1)
            {
                Status.Text = "Вы начали установку Visual C++ Redistributable 2005-2022";
                Process.Start("powershell.exe", "choco install vcredist-all -y");
            }
            else if (Properties.Settings.Default.Page == 2)
            {
                Status.Text = "Вы начали установку Paint.NET";
                Process.Start("powershell.exe", "choco install paint.net -y");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Page == 1)
            {
                Status.Text = "Вы начали установку DirectX";
                Process.Start("powershell.exe", "choco install directx -y");
            }
            else if (Properties.Settings.Default.Page == 2)
            {
                Status.Text = "Вы начали установку Notepad++";
                Process.Start("powershell.exe", "choco install notepadplusplus -y");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Page == 1)
            {
                Status.Text = "Вы начали установку Java";
                Process.Start("powershell.exe", "choco install javaruntime -y");
            }
            else if (Properties.Settings.Default.Page == 2)
            {
                Status.Text = "Вы начали установку LibreOffice";
                Process.Start("powershell.exe", "choco install libreoffice-fresh -y");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Page == 1)
            {
                Status.Text = "Вы начали установку Steam";
                Process.Start("powershell.exe", "choco install steam -y --ignore-checksums");
            }
            else if (Properties.Settings.Default.Page == 2)
            {
                Status.Text = "Вы начали установку OBS Studio";
                Process.Start("powershell.exe", "choco install obs-studio -y");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Page == 1)
            {
                Status.Text = "Вы начали установку Discord";
                Process.Start("powershell.exe", "choco install discord -y");
            }
            else if (Properties.Settings.Default.Page == 2)
            {
                Status.Text = "Вы начали установку VLC";
                Process.Start("powershell.exe", "choco install vlc -y");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Page == 1)
            {
                Status.Text = "Вы начали установку Internet Download Manager";
                Process.Start("powershell.exe", "choco install internet-download-manager -y --ignore-checksums");
            }
            else if (Properties.Settings.Default.Page == 2)
            {
                Status.Text = "Вы начали установку Media Player Classic";
                Process.Start("powershell.exe", "choco install mpc-hc -y");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Page == 1)
            {
                Status.Text = "Вы начали установку Spotify";
                Process.Start("powershell.exe", "choco install spotify -y");
            }
            else if (Properties.Settings.Default.Page == 2)
            {
                Status.Text = "Вы начали установку Audacity";
                Process.Start("powershell.exe", "choco install audacity -y");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }
    }
}
