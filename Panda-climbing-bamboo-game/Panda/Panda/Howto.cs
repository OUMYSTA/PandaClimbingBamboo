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
    public partial class Howto : Form
    {
        public Howto()
        {
            InitializeComponent();
            button1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Start form = new Start();
            Options.wplayerclick.controls.play();
            form.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Options.wplayerclick.controls.play();
            if (pictureBox4.Visible == true)
            {
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox2.Visible = true;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox1.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox1.Visible = true;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                button1.Visible = false;
                button2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Options.wplayerclick.controls.play();
            if (pictureBox1.Visible == true)
            {
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox3.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox4.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                button2.Visible = false;
                button1.Visible = true;
            }
        }
    }
}
