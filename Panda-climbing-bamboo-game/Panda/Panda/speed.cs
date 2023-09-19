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
    public partial class speed : Form
    {
        int heart;
        int Speed;
        public int score;
        public speed()
        {
            InitializeComponent();
            label2.Visible = false;
            label3.Visible = false;
        }

        public bool right, left, pause, resume;

        private void timer1_Tick(object sender, EventArgs e)
        {
            enemy();
            gameover();
            movement();
            cloud(15);
            score++;
            lblSc.Text = score.ToString();
            if (score >= 0 && score < 50)
            {
                Speed = 20;

            }
            if (score > 50 && score < 150)
            {
                Speed = 30;

            }
            if (score > 150 && score < 300)
            {
                Speed = 50;
            }
            if (score > 300 && score < 500)
            {
                Speed = 80;
            }
            if (score > 500)
            {
                Speed = 100;
            }
        }

        void enemy()
        {
            if (enemy1.Top >= 500)
            {
                enemy1.Location = new Point(99, 0);
            }
            else
            {
                enemy1.Top += Speed;
            }

            if (enemy2.Top >= 500)
            {
                enemy2.Location = new Point(190, 0);
            }
            else
            {
                enemy2.Top += Speed;
            }
            if (enemy3.Top >= 500)
            {
                enemy3.Location = new Point(340, 0);
            }
            else
            {
                enemy3.Top += Speed;
            }

            if (enemy4.Top >= 500)
            {
                enemy4.Location = new Point(432, 0);
            }
            else
            {
                enemy4.Top += Speed;
            }

            if (enemy5.Top >= 500)
            {
                enemy5.Location = new Point(581, 0);
            }
            else
            {
                enemy5.Top += Speed;
            }

            if (enemy6.Top >= 500)
            {
                enemy6.Location = new Point(670, 0);
            }
            else
            {
                enemy6.Top += Speed;
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

        private void speed_KeyDown(object sender, KeyEventArgs e)
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

        private void speed_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            else if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                pause = false;
            }
            if (e.KeyCode == Keys.Enter)
            {
                resume = false;
            }
        }

        void cloud(int speed)
        {
            if (cloud1.Left >= 800)
            {
                cloud1.Left = 0;
                cloud1.Location = new Point(0, 0);
            }
            else
            {
                cloud1.Left += speed;
            }

            if (cloud2.Left >= 800)
            {
                cloud2.Left = 0;
                cloud2.Location = new Point(0, 384);
            }
            else
            {
                cloud2.Left += speed;
            }

            if (cloud3.Left >= 800)
            {
                cloud3.Left = 0;
                cloud3.Location = new Point(0, 219);
            }
            else
            {
                cloud3.Left += speed;
            }

            if (cloud4.Left >= 800)
            {
                cloud4.Left = 0;
                cloud4.Location = new Point(0, 50);
            }
            else
            {
                cloud4.Left += speed;
            }

            if (cloud5.Left >= 800)
            {
                cloud5.Left = 0;
                cloud5.Location = new Point(0, 454);
            }
            else
            {
                cloud5.Left += speed;
            }
        }

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
                GameOver2 form = new GameOver2(this);
                Options.wplayerover.controls.play();
                form.ShowDialog();
                form.label4.Text = lblSc.Text;
                this.Close();
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

    }
}
