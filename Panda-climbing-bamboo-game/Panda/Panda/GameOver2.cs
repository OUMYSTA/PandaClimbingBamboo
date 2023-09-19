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
    public partial class GameOver2 : Form
    {
        private speed form2;
        public GameOver2(speed module)
        {
            InitializeComponent();
            form2 = module;
            label4.Text = form2.lblSc.Text.ToString();
            lblBc.Text = Properties.Settings.Default.HighSc;
            highScore();
        }

        public void highScore()
        {
            int a = Int32.Parse(lblBc.Text);
            if (form2.score > a)
            {
                lblBc.Text = form2.score.ToString();
                Properties.Settings.Default.HighSc = lblBc.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void btnRestart_MouseHover(object sender, EventArgs e)
        {
            btnRestart.ForeColor = Color.Gold;
        }

        private void btnRestart_MouseLeave(object sender, EventArgs e)
        {
            btnRestart.ForeColor = Color.White;
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            btnBack.ForeColor = Color.Gold;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.ForeColor = Color.White;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            speed form = new speed();
            Options.wplayerclick.controls.play();
            form.ShowDialog();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Start form = new Start();
            Options.wplayerclick.controls.play();
            form.ShowDialog();
            this.Close();
        }
    }
}
