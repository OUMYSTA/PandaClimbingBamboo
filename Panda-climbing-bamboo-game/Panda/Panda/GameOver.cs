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
    public partial class GameOver : Form
    {
        private Survival form2;
        public GameOver(Survival module)
        {
            InitializeComponent();
            form2 = module;
            label4.Text = form2.lblSc.Text.ToString();
            lblHc.Text = Properties.Settings.Default.bestSc;
            bestScore();
        }

        public void bestScore()
        {
            int a = Int32.Parse(lblHc.Text);
            if (form2.score > a)
            {
                lblHc.Text = form2.score.ToString();
                Properties.Settings.Default.bestSc = lblHc.Text;
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
            Survival form2 = new Survival();
            Options.wplayerclick.controls.play();
            form2.ShowDialog();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Start form1 = new Start();
            Options.wplayerclick.controls.play();
            form1.ShowDialog();
            this.Close();
        }
    }
}
