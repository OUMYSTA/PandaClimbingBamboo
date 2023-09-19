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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
            wplayerclick.URL = (@"C:\Users\advice\source\repos\Panda\Panda\Resources\click-button-140881.wav");
            wplayermove.URL = (@"C:\Users\advice\source\repos\Panda\Panda\Resources\swinging-staff-whoosh-strong-08-44658.wav");
            wplayerattack.URL = (@"C:\Users\advice\source\repos\Panda\Panda\Resources\weapon-axe-hit-01-153372.wav");
            wplayerover.URL = (@"C:\Users\advice\source\repos\Panda\Panda\Resources\negative_beeps-6008.wav");
            wplayereat.URL = (@"C:\Users\advice\source\repos\Panda\Panda\Resources\eating-sound-effect-36186.wav");
            wplayerover.controls.stop();
            wplayereat.controls.stop();
            wplayerattack.controls.stop();
            wplayermove.controls.stop();
            wplayerclick.controls.stop();
            axWindowsMediaPlayerattack.Hide();
            axWindowsMediaPlayerclick.Hide();
            axWindowsMediaPlayereat.Hide();
            axWindowsMediaPlayermove.Hide();
            axWindowsMediaPlayergameover.Hide();
        }

        public static WMPLib.WindowsMediaPlayer wplayerclick = new WMPLib.WindowsMediaPlayer();
        public static WMPLib.WindowsMediaPlayer wplayermove = new WMPLib.WindowsMediaPlayer();
        public static WMPLib.WindowsMediaPlayer wplayereat = new WMPLib.WindowsMediaPlayer();
        public static WMPLib.WindowsMediaPlayer wplayerover = new WMPLib.WindowsMediaPlayer();
        public static WMPLib.WindowsMediaPlayer wplayerattack = new WMPLib.WindowsMediaPlayer();

        private void btnBack_Click(object sender, EventArgs e)
        {
            Start form = new Start();
            wplayerclick.controls.play();
            form.ShowDialog();
            this.Close();
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            btnBack.ForeColor = Color.Gold;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.ForeColor = Color.White;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Start.wplayer.controls.play();
            Start.wplayer.settings.volume = trackBar1.Value;
            label4.Text = Convert.ToString(trackBar1.Value + "%");
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            wplayerover.controls.play();
            wplayermove.settings.volume = trackBar2.Value;
            wplayereat.settings.volume = trackBar2.Value;
            wplayerattack.settings.volume = trackBar2.Value;
            wplayerclick.settings.volume = trackBar2.Value;
            wplayerover.settings.volume = trackBar2.Value;
            label5.Text = Convert.ToString(trackBar2.Value + "%");
        }
    }
}
