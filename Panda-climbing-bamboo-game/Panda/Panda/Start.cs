using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panda
{
    public partial class Start : Form
    {
        Options option = new Options();
        public Start()
        {
            InitializeComponent();
            wplayer.URL = (@"C:\Users\advice\source\repos\Panda\Panda\Resources\game-music-loop-7-145285.wav");
            wplayer.controls.play();
            axWindowsMediaPlayer1.Hide();
        }

        public static WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        private void btnExit_Click(object sender, EventArgs e)
        {
            Options.wplayerclick.controls.play();
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            choose form = new choose();
            Options.wplayerclick.controls.play();
            form.ShowDialog();
            this.Close();
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            Options.wplayerclick.controls.play();
            option.ShowDialog();
            this.Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Howto help = new Howto();
            Options.wplayerclick.controls.play();
            help.ShowDialog();
            this.Close();
        }

        private void btnStart_MouseHover(object sender, EventArgs e)
        {
            btnStart.ForeColor = Color.Gold;
        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            btnStart.ForeColor = Color.White;
        }

        private void btnOption_MouseHover(object sender, EventArgs e)
        {
            btnOption.ForeColor = Color.Gold;
        }

        private void btnOption_MouseLeave(object sender, EventArgs e)
        {
            btnOption.ForeColor = Color.White;
        }

        private void btnHelp_MouseHover(object sender, EventArgs e)
        {
            btnHelp.ForeColor = Color.Gold;
        }

        private void btnHelp_MouseLeave(object sender, EventArgs e)
        {
            btnHelp.ForeColor = Color.White;
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.Gold;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.White;
        }
    }
}
