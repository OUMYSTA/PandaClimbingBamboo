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
    public partial class Survival : Form
    {
        public Survival()
        {
            InitializeComponent();
            label3.Visible = false;
            label2.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            enemy(20);
            gameover();
            movement();
            bamboo(20);
            getpoint();
        }

        bool right, left, pause, resume;

        private void Survival_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            else if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            else if (e.KeyCode == Keys.Space)
            {
                pause = false;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                resume = false;
            }
        }

        private void Survival_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
            else if (e.KeyCode == Keys.Space)
            {
                pause = true;
                label2.Visible = true;
                timer1.Enabled = false;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                resume = true;
                label2.Visible = false;
                timer1.Enabled = true;

            }
        }


        void movement()
        {

            if (right == true)
            {
                Options.wplayermove.controls.play();
                if (panda.Right < 670)
                {
                    panda.Image = Properties.Resources.pr1;
                    panda.Left += 120;
                    if (panda.Right == 310)
                    {
                        panda.Image = Properties.Resources.pl1;
                    }
                    else if (panda.Right == 390)
                    {
                        panda.Image = Properties.Resources.pl1;
                    }
                    else if (panda.Right == 430)
                    {
                        panda.Image = Properties.Resources.pr1;
                    }
                    else if (panda.Right == 630)
                    {
                        panda.Image = Properties.Resources.pl1;
                    }
                    else if (panda.Right == 670)
                    {
                        panda.Image = Properties.Resources.pr1;
                    }
                }

            }
            else if (left == true)
            {
                Options.wplayermove.controls.play();
                if (panda.Left > 70)
                {
                    panda.Image = Properties.Resources.pr1;
                    panda.Left -= 120;
                    if (panda.Left == 70)
                    {
                        panda.Image = Properties.Resources.pl1;
                    }
                    else if (panda.Left == 190)
                    {
                        panda.Image = Properties.Resources.pr1;
                    }
                    else if (panda.Left == 310)
                    {
                        panda.Image = Properties.Resources.pl1;
                    }
                    else if (panda.Left == 430)
                    {
                        panda.Image = Properties.Resources.pr1;
                    }
                    else if (panda.Left == 550)
                    {
                        panda.Image = Properties.Resources.pl1;
                    }
                }
            }
            else if (pause == true)
            {
                timer1.Enabled = false;
            }
            else if (resume == true)
            {
                timer1.Enabled = true;
            }
        }

        int heart;
        void lost_heart()
        {
            if (heart == 1)
            {
                heart1.Image = Properties.Resources.white;
            }
            if (heart == 2)
            {
                heart2.Image = Properties.Resources.white;
            }
            if (heart == 3)
            {
                heart3.Image = Properties.Resources.white;
                timer1.Enabled = false;
                label3.Visible = true;
                Options.wplayerover.controls.play();
                GameOver form3 = new GameOver(this);
                form3.ShowDialog();
                form3.label4.Text = lblSc.Text;
                this.Close();
            }
        }

        

        public int score = 0;
        public void getpoint()
        {
            if (panda.Bounds.IntersectsWith(bamboo1.Bounds))
            {
                score++;
                lblSc.Text = score.ToString();
                Options.wplayereat.controls.play();
                bamboo1.Top -= 500;
            }
            else if (panda.Bounds.IntersectsWith(bamboo2.Bounds))
            {
                score++;
                lblSc.Text = score.ToString();
                Options.wplayereat.controls.play();
                bamboo2.Top -= 500;
            }
            else if (panda.Bounds.IntersectsWith(bamboo3.Bounds))
            {
                score++;
                lblSc.Text = score.ToString();
                Options.wplayereat.controls.play();
                bamboo3.Top -= 500;
            }
        }

        void bamboo(int speed)
        {
            if (bamboo1.Top >= 500)
            {
                bamboo1.Top = 0;
            }
            else
            {
                bamboo1.Top += speed;
            }
            if (bamboo2.Top >= 500)
            {
                bamboo2.Top = 0;
            }
            else
            {
                bamboo2.Top += speed;
            }
            if (bamboo3.Top >= 500)
            {
                bamboo3.Top = 0;
            }
            else
            {
                bamboo3.Top += speed;
            }
        }

        void gameover()
        {
            if (panda.Bounds.IntersectsWith(enemy2.Bounds))
            {
                heart += 1;
                enemy2.Top -= 500;
                Options.wplayerattack.controls.play();
                lost_heart();
            }
            else if (panda.Bounds.IntersectsWith(enemy1.Bounds))
            {
                heart += 1;
                enemy1.Top -= 500;
                Options.wplayerattack.controls.play();
                lost_heart();
            }
            else if (panda.Bounds.IntersectsWith(enemy3.Bounds))
            {
                heart += 1;
                enemy3.Top -= 500;
                Options.wplayerattack.controls.play();
                lost_heart();
            }
            else if (panda.Bounds.IntersectsWith(enemy4.Bounds))
            {
                heart += 1;
                enemy4.Top -= 500;
                Options.wplayerattack.controls.play();
                lost_heart();
            }
            else if (panda.Bounds.IntersectsWith(enemy5.Bounds))
            {
                heart += 1;
                enemy5.Top -= 500;
                Options.wplayerattack.controls.play();
                lost_heart();
            }
            else if (panda.Bounds.IntersectsWith(enemy6.Bounds))
            {
                heart += 1;
                enemy6.Top -= 500;
                Options.wplayerattack.controls.play();
                lost_heart();
            }
        }

        void enemy(int speed)
        {
            if (enemy1.Top >= 500)
            {
                enemy1.Location = new Point(99, 0);
            }
            else
            {
                enemy1.Top += speed;
            }

            if (enemy2.Top >= 500)
            {
                enemy2.Location = new Point(190, 0);
            }
            else
            {
                enemy2.Top += speed;
            }

            if (enemy3.Top >= 500)
            {
                enemy3.Location = new Point(340, 0);
            }
            else
            {
                enemy3.Top += speed;
            }

            if (enemy4.Top >= 500)
            {
                enemy4.Location = new Point(432, 0);
            }
            else
            {
                enemy4.Top += speed;
            }

            if (enemy5.Top >= 500)
            {
                enemy5.Location = new Point(581, 0);
            }
            else
            {
                enemy5.Top += speed;
            }

            if (enemy6.Top >= 500)
            {
                enemy6.Location = new Point(670, 0);
            }
            else
            {
                enemy6.Top += speed;
            }
        }
    }
}
