using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int hp = 3;
        int ec = 4;
        int count = 3;
        int cycle = 3;
        bool dir1, dir2;
        bool ded = false;
        bool ded2 = false;
        bool ded3 = false;
        bool ded4 = false;
        bool ded5 = false;
        bool ded6 = false;
        bool ded7 = false;
        bool ded8 = false;
        bool ded9 = false;
        bool ded10 = false;
        bool ded11 = false;
        bool ded12 = false;

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (count>1)
            {
                count--;
            }
            else
            {
                pictureBox39.Visible = false;
            }
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox32_MouseMove(object sender, MouseEventArgs e)
        {
            if (dir1 == false)
            {
                hp--; 
                dir1 = true;
                if (hp == 2)
                {
                    pictureBox38.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                }
                if (hp == 1)
                {
                    pictureBox37.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                }
                if (hp == 0)
                {
                    pictureBox36.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                    pictureBox53.Visible = true;
                }
            }
        }

        private void pictureBox32_MouseLeave(object sender, EventArgs e)
        {
            dir1 = false;
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
                timer2.Start();
                pictureBox39.Visible = true;
                pictureBox39.Left = pictureBox31.Left - 64;
                pictureBox39.Top = pictureBox31.Top - 64;


            
            if (cycle == 3)
            {
                if (pictureBox39.Bounds.IntersectsWith(pictureBox32.Bounds) && ded == false)
                {
                    pictureBox32.Visible = false;
                    ded = true;
                    ec--;
                }
                if (pictureBox39.Bounds.IntersectsWith(pictureBox33.Bounds) && ded2 == false)
                {
                    pictureBox33.Visible = false;
                    ded2 = true;
                    ec--;
                }
                if (pictureBox39.Bounds.IntersectsWith(pictureBox34.Bounds) && ded3 == false)
                {
                    pictureBox34.Visible = false;
                    ded3 = true;
                    ec--;
                }
                if (pictureBox39.Bounds.IntersectsWith(pictureBox35.Bounds) && ded4 == false)
                {
                    pictureBox35.Visible = false;
                    ded4 = true;
                    ec--;
                }
            }


            if (cycle == 2)
            {
                if (pictureBox39.Bounds.IntersectsWith(pictureBox44.Bounds) && ded5 == false)
                {
                    pictureBox44.Visible = false;
                    ded5 = true;
                    ec--;
                }
                if (pictureBox39.Bounds.IntersectsWith(pictureBox45.Bounds) && ded6 == false)
                {
                    pictureBox45.Visible = false;
                    ded6 = true;
                    ec--;
                }
                if (pictureBox39.Bounds.IntersectsWith(pictureBox46.Bounds) && ded7 == false)
                {
                    pictureBox46.Visible = false;
                    ded7 = true;
                    ec--;
                }
                if (pictureBox39.Bounds.IntersectsWith(pictureBox47.Bounds) && ded8 == false)
                {
                    pictureBox47.Visible = false;
                    ded8 = true;
                    ec--;
                }
            }


            if (cycle == 1)
            {
                if (pictureBox39.Bounds.IntersectsWith(pictureBox48.Bounds) && ded9 == false)
                {
                    pictureBox48.Visible = false;
                    ded5 = true;
                    ec--;
                }
                if (pictureBox39.Bounds.IntersectsWith(pictureBox49.Bounds) && ded10 == false)
                {
                    pictureBox49.Visible = false;
                    ded6 = true;
                    ec--;
                }
                if (pictureBox39.Bounds.IntersectsWith(pictureBox50.Bounds) && ded11 == false)
                {
                    pictureBox50.Visible = false;
                    ded7 = true;
                    ec--;
                }
                if (pictureBox39.Bounds.IntersectsWith(pictureBox51.Bounds) && ded12 == false)
                {
                    pictureBox51.Visible = false;
                    ded8 = true;
                    ec--;
                }
            }


            if (ec == 0)
            {
                pictureBox22.Visible = true;
                pictureBox28.Visible = true;
                pictureBox29.Visible = true;
                pictureBox30.Visible = true;
            }
        }


        private void pictureBox27_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox33_MouseMove(object sender, MouseEventArgs e)
        {
            if (dir1 == false)
            {
                hp--;
                dir1 = true;
                if (hp == 2)
                {
                    pictureBox38.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                }
                if (hp == 1)
                {
                    pictureBox37.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                }
                if (hp == 0)
                {
                    pictureBox36.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                    pictureBox53.Visible = true;
                }
            }
        }


        private void pictureBox33_MouseLeave(object sender, EventArgs e)
        {
            dir1 = false;
        }

        private void pictureBox35_MouseMove(object sender, MouseEventArgs e)
        {
            if (dir1 == false)
            {
                hp--;
                dir1 = true;
                if (hp == 2)
                {
                    pictureBox38.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                }
                if (hp == 1)
                {
                    pictureBox37.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                }
                if (hp == 0)
                {
                    pictureBox36.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                    pictureBox53.Visible = true;
                }
            }
        }

        private void pictureBox35_MouseLeave(object sender, EventArgs e)
        {
            dir1 = false;
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox34_MouseMove(object sender, MouseEventArgs e)
        {
            if (dir1 == false)
            {
                hp--;
                dir1 = true;
                if (hp == 2)
                {
                    pictureBox38.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                }
                if (hp == 1)
                {
                    pictureBox37.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                }
                if (hp == 0)
                {
                    pictureBox36.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                    pictureBox53.Visible = true;
                }
            }
        }

        private void pictureBox34_MouseLeave(object sender, EventArgs e)
        {
            dir1 = false;
        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            cycle--;
            if (cycle == 2)
            {
                pictureBox44.Visible = true;
                pictureBox45.Visible = true;
                pictureBox46.Visible = true;
                pictureBox47.Visible = true;
            }
            if (cycle == 1)
            {
                pictureBox48.Visible = true;
                pictureBox49.Visible = true;
                pictureBox50.Visible = true;
                pictureBox51.Visible = true;
            }
            if (cycle == 0)
            {
                pictureBox52.Visible = true;
            }
            ec = 4;
            pictureBox22.Visible = false;
            pictureBox28.Visible = false;
            pictureBox29.Visible = false;
            pictureBox30.Visible = false;
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            cycle--;
            if (cycle == 2)
            {
                pictureBox44.Visible = true;
                pictureBox45.Visible = true;
                pictureBox46.Visible = true;
                pictureBox47.Visible = true;
            }
            if (cycle == 1)
            {
                pictureBox48.Visible = true;
                pictureBox49.Visible = true;
                pictureBox50.Visible = true;
                pictureBox51.Visible = true;
            }
            if (cycle == 0)
            {
                pictureBox52.Visible = true;
            }
            ec = 4;
            pictureBox22.Visible = false;
            pictureBox28.Visible = false;
            pictureBox29.Visible = false;
            pictureBox30.Visible = false;
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            cycle--;
            if (cycle == 2)
            {
                pictureBox44.Visible = true;
                pictureBox45.Visible = true;
                pictureBox46.Visible = true;
                pictureBox47.Visible = true;
            }
            if (cycle == 1)
            {
                pictureBox48.Visible = true;
                pictureBox49.Visible = true;
                pictureBox50.Visible = true;
                pictureBox51.Visible = true;
            }
            if (cycle == 0)
            {
                pictureBox52.Visible = true;
            }
            ec = 4;
            pictureBox22.Visible = false;
            pictureBox28.Visible = false;
            pictureBox29.Visible = false;
            pictureBox30.Visible = false;
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            cycle--;
            if (cycle == 2)
            {
                pictureBox44.Visible = true;
                pictureBox45.Visible = true;
                pictureBox46.Visible = true;
                pictureBox47.Visible = true;
            }
            if (cycle == 1)
            {
                pictureBox48.Visible = true;
                pictureBox49.Visible = true;
                pictureBox50.Visible = true;
                pictureBox51.Visible = true;
            }
            if (cycle == 0)
            {
                pictureBox52.Visible = true;
            }
            ec = 4;
            pictureBox22.Visible = false;
            pictureBox28.Visible = false;
            pictureBox29.Visible = false;
            pictureBox30.Visible = false;
        }

        private void pictureBox46_MouseMove(object sender, MouseEventArgs e)
        {
            if (dir1 == false)
            {
                hp--;
                dir1 = true;
                if (hp == 2)
                {
                    pictureBox38.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                }
                if (hp == 1)
                {
                    pictureBox37.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                }
                if (hp == 0)
                {
                    pictureBox36.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                    pictureBox53.Visible = true;
                }
            }
        }

        private void pictureBox46_MouseLeave(object sender, EventArgs e)
        {
            dir1 = false;
        }

        private void pictureBox47_MouseMove(object sender, MouseEventArgs e)
        {
            if (dir1 == false)
            {
                hp--;
                dir1 = true;
                if (hp == 2)
                {
                    pictureBox38.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                }
                if (hp == 1)
                {
                    pictureBox37.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                }
                if (hp == 0)
                {
                    pictureBox36.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                    pictureBox53.Visible = true;
                }
            }
        }

        private void pictureBox47_MouseLeave(object sender, EventArgs e)
        {
            dir1 = false;
        }

        private void pictureBox45_MouseMove(object sender, MouseEventArgs e)
        {
            if (dir1 == false)
            {
                hp--;
                dir1 = true;
                if (hp == 2)
                {
                    pictureBox38.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                }
                if (hp == 1)
                {
                    pictureBox37.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                }
                if (hp == 0)
                {
                    pictureBox36.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                    pictureBox53.Visible = true;
                }
            }
        }

        private void pictureBox45_MouseLeave(object sender, EventArgs e)
        {
            dir1 = false;
        }

        private void pictureBox44_MouseMove(object sender, MouseEventArgs e)
        {
            if (dir1 == false)
            {
                hp--;
                dir1 = true;
                if (hp == 2)
                {
                    pictureBox38.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                }
                if (hp == 1)
                {
                    pictureBox37.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                }
                if (hp == 0)
                {
                    pictureBox36.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                    pictureBox53.Visible = true;
                }
            }
        }

        private void pictureBox44_MouseLeave(object sender, EventArgs e)
        {
            dir1 = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dir2)
            {
                if (pictureBox32.Left < 320)
                {
                    pictureBox32.Left += 16;
                }
                else
                {
                    dir2 = false;
                    pictureBox32.Left -= 16;
                }
            }
            else
            {
                if (pictureBox32.Left > 196)
                {
                    pictureBox32.Left -= 16;
                }
                else
                {
                    dir2 = true;
                    pictureBox32.Left += 16;
                }
            }


            if (dir2)
            {
                if (pictureBox33.Top < 320)
                {
                    pictureBox33.Top += 16;
                }
                else
                {
                    dir2 = false;
                    pictureBox33.Top -= 16;
                }
            }
            else
            {
                if (pictureBox33.Top > 128)
                {
                    pictureBox33.Top -= 16;
                }
                else
                {
                    dir2 = true;
                    pictureBox33.Top += 16;
                }
            }


            if (dir2)
            {
                if (pictureBox34.Left < 860)
                {
                    pictureBox34.Left += 16;
                }
                else
                {
                    dir2 = false;
                    pictureBox34.Left -= 16;
                }
            }
            else
            {
                if (pictureBox34.Left > 708)
                {
                    pictureBox34.Left -= 16;
                }
                else
                {
                    dir2 = true;
                    pictureBox34.Left += 16;
                }
            }


            if (dir2)
            {
                if (pictureBox35.Top < 640)
                {
                    pictureBox35.Top += 16;
                }
                else
                {
                    dir2 = false;
                    pictureBox35.Top -= 16;
                }
            }
            else
            {
                if (pictureBox35.Top > 256)
                {
                    pictureBox35.Top -= 16;
                }
                else
                {
                    dir2 = true;
                    pictureBox35.Top += 16;
                }
            }


            if (dir2)
            {
                if (pictureBox44.Top < 320)
                {
                    pictureBox44.Top += 16;
                }
                else
                {
                    dir2 = false;
                    pictureBox44.Top -= 16;
                }
            }
            else
            {
                if (pictureBox44.Top > 128)
                {
                    pictureBox44.Top -= 16;
                }
                else
                {
                    dir2 = true;
                    pictureBox44.Top += 16;
                }


            if (dir2)
            {
                if (pictureBox45.Top < 320)
                {
                    pictureBox45.Top += 16;
                }
                else
                {
                    dir2 = false;
                    pictureBox45.Top -= 16;
                }
            }
            else
            {
                if (pictureBox45.Top > 128)
                {
                    pictureBox45.Top -= 16;
                }
                else
                {
                     dir2 = true;
                     pictureBox45.Top += 16;
                }
            }


                if (dir2)
                {
                    if (pictureBox46.Left < 320)
                    {
                        pictureBox46.Left += 16;
                    }
                    else
                    {
                        dir2 = false;
                        pictureBox46.Left -= 16;
                    }
                }
                else
                {
                    if (pictureBox46.Left > 196)
                    {
                        pictureBox46.Left -= 16;
                    }
                    else
                    {
                        dir2 = true;
                        pictureBox46.Left += 16;
                    }
                }


                if (dir2)
                {
                    if (pictureBox47.Left < 320)
                    {
                        pictureBox47.Left += 16;
                    }
                    else
                    {
                        dir2 = false;
                        pictureBox47.Left -= 16;
                    }
                }
                else
                {
                    if (pictureBox47.Left > 196)
                    {
                        pictureBox47.Left -= 16;
                    }
                    else
                    {
                        dir2 = true;
                        pictureBox32.Left += 16;
                    }
                }


                if (dir2)
                {
                    if (pictureBox50.Left < 320)
                    {
                        pictureBox50.Left += 16;
                    }
                    else
                    {
                        dir2 = false;
                        pictureBox50.Left -= 16;
                    }
                }
                else
                {
                    if (pictureBox50.Left > 196)
                    {
                        pictureBox50.Left -= 16;
                    }
                    else
                    {
                        dir2 = true;
                        pictureBox50.Left += 16;
                    }
                }


                if (dir2)
                {
                    if (pictureBox48.Top < 320)
                    {
                        pictureBox48.Top += 16;
                    }
                    else
                    {
                        dir2 = false;
                        pictureBox48.Top -= 16;
                    }
                }
                else
                {
                    if (pictureBox48.Top > 128)
                    {
                        pictureBox48.Top -= 16;
                    }
                    else
                    {
                        dir2 = true;
                        pictureBox48.Top += 16;
                    }
                }


                if (dir2)
                {
                    if (pictureBox51.Left < 320)
                    {
                        pictureBox51.Left += 16;
                    }
                    else
                    {
                        dir2 = false;
                        pictureBox51.Left -= 16;
                    }
                }
                else
                {
                    if (pictureBox51.Left > 196)
                    {
                        pictureBox51.Left -= 16;
                    }
                    else
                    {
                        dir2 = true;
                        pictureBox51.Left += 16;
                    }
                }


                if (dir2)
                {
                    if (pictureBox49.Top < 320)
                    {
                        pictureBox49.Top += 16;
                    }
                    else
                    {
                        dir2 = false;
                        pictureBox49.Top -= 16;
                    }
                }
                else
                {
                    if (pictureBox49.Top > 128)
                    {
                        pictureBox49.Top -= 16;
                    }
                    else
                    {
                        dir2 = true;
                        pictureBox49.Top += 16;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox48_MouseLeave(object sender, EventArgs e)
        {
            dir1 = false;
        }

        private void pictureBox48_MouseMove(object sender, MouseEventArgs e)
        {
            if (dir1 == false)
            {
                hp--;
                dir1 = true;
                if (hp == 2)
                {
                    pictureBox38.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                }
                if (hp == 1)
                {
                    pictureBox37.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                }
                if (hp == 0)
                {
                    pictureBox36.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                    pictureBox53.Visible = true;
                }
            }
        }

        private void pictureBox49_MouseLeave(object sender, EventArgs e)
        {
            dir1 = false;
        }

        private void pictureBox49_MouseMove(object sender, MouseEventArgs e)
        {
            if (dir1 == false)
            {
                hp--;
                dir1 = true;
                if (hp == 2)
                {
                    pictureBox38.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                }
                if (hp == 1)
                {
                    pictureBox37.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                }
                if (hp == 0)
                {
                    pictureBox36.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                    pictureBox53.Visible = true;
                }
            }
        }

        private void pictureBox50_MouseLeave(object sender, EventArgs e)
        {
            dir1 = false;
        }

        private void pictureBox50_MouseMove(object sender, MouseEventArgs e)
        {
            if (dir1 == false)
            {
                hp--;
                dir1 = true;
                if (hp == 2)
                {
                    pictureBox38.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                }
                if (hp == 1)
                {
                    pictureBox37.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                }
                if (hp == 0)
                {
                    pictureBox36.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                    pictureBox53.Visible = true;
                }
            }
        }

        private void pictureBox51_MouseLeave(object sender, EventArgs e)
        {
            dir1 = false;
        }

        private void pictureBox51_MouseMove(object sender, MouseEventArgs e)
        {
            if (dir1 == false)
            {
                hp--;
                dir1 = true;
                if (hp == 2)
                {
                    pictureBox38.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                }
                if (hp == 1)
                {
                    pictureBox37.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                }
                if (hp == 0)
                {
                    pictureBox36.BackgroundImage = WindowsFormsApp3.Properties.Resources.DeadBattery;
                    pictureBox53.Visible = true;
                }
            }
        }

        private void pictureBox52_Click(object sender, EventArgs e)
        {
            pictureBox54.Visible = true;
            pictureBox52.Visible = false;
        }

        private void pictureBox27_MouseMove(object sender, MouseEventArgs e)
        {
            {
                pictureBox31.Left = e.X - 64;
                pictureBox31.Top = e.Y - 64;
            }
        }
    }
}