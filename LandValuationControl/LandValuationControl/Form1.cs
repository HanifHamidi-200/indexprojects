using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LandValuationControl
{
    public partial class Form1 : Form
    {
        private static List<int> _count = new List<int> { 0, 0, 0, 0, 0, 0 };
        private Random rnd1 = new Random();
        private int mnColour1 = 1;
        private int mnColour2 = 1;
        private int mnPosition;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mnColour1 = rnd1.Next(1, 6);
            mnColour2 = rnd1.Next(1, 6);
            mnPosition = rnd1.Next(1, 5);

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F blank.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F blueland.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F greenland.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F purpleland.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F redland.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            switch (mnColour1)
            {
                case 1:
                    pic1.Image = picture1.Image;
                    break;
                case 2:
                    pic1.Image = picture2.Image;
                    break;
                case 3:
                    pic1.Image = picture3.Image;
                    break;
                case 4:
                    pic1.Image = picture4.Image;
                    break;
                default:
                    pic1.Image = picture5.Image;
                    break;
            }
            switch (mnColour2)
            {
                case 1:
                    pic2.Image = picture1.Image;
                    break;
                case 2:
                    pic2.Image = picture2.Image;
                    break;
                case 3:
                    pic2.Image = picture3.Image;
                    break;
                case 4:
                    pic2.Image = picture4.Image;
                    break;
                default:
                    pic2.Image = picture5.Image;
                    break;
            }

            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            switch (mnPosition)
            {
                case 1:
                    pnl1.Visible = true;
                    break;
                case 2:
                    pnl2.Visible = true;
                    break;
                case 3:
                    pnl3.Visible = true;
                    break;
                default:
                    pnl4.Visible = true;
                    break;
            }

            for(int i = 1; i <= 6; i++)
            {
                _count[i - 1] = rnd1.Next(1, 7);
            }
            switch (mnPosition)
            {
                case 1:
                    lbl11.Text = Convert.ToString(_count[0]);
                    lbl12.Text = Convert.ToString(_count[1]);
                    lbl13.Text = Convert.ToString(_count[2]);
                    lbl14.Text = Convert.ToString(_count[3]);
                    lbl15.Text = Convert.ToString(_count[4]);
                    lbl16.Text = Convert.ToString(_count[5]);
                    break;
                case 2:
                    lbl21.Text = Convert.ToString(_count[0]);
                    lbl22.Text = Convert.ToString(_count[1]);
                    lbl23.Text = Convert.ToString(_count[2]);
                    lbl24.Text = Convert.ToString(_count[3]);
                    lbl25.Text = Convert.ToString(_count[4]);
                    lbl26.Text = Convert.ToString(_count[5]);
                    pnl2.Visible = true;
                    break;
                case 3:
                    lbl31.Text = Convert.ToString(_count[0]);
                    lbl32.Text = Convert.ToString(_count[1]);
                    lbl33.Text = Convert.ToString(_count[2]);
                    lbl34.Text = Convert.ToString(_count[3]);
                    lbl35.Text = Convert.ToString(_count[4]);
                    lbl36.Text = Convert.ToString(_count[5]);
                    pnl3.Visible = true;
                    break;
                default:
                    lbl41.Text = Convert.ToString(_count[0]);
                    lbl42.Text = Convert.ToString(_count[1]);
                    lbl43.Text = Convert.ToString(_count[2]);
                    lbl44.Text = Convert.ToString(_count[3]);
                    lbl45.Text = Convert.ToString(_count[4]);
                    lbl46.Text = Convert.ToString(_count[5]);
                    pnl4.Visible = true;
                    break;
            }
        }

        private void pic1_Click(object sender, EventArgs e)
        {

        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            mnColour1 = rnd1.Next(1, 6);
            mnColour2 = rnd1.Next(1, 6);
            mnPosition = rnd1.Next(1, 5);

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F blank.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F blueland.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F greenland.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F purpleland.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F redland.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            switch (mnColour1)
            {
                case 1:
                    pic1.Image = picture1.Image;
                    break;
                case 2:
                    pic1.Image = picture2.Image;
                    break;
                case 3:
                    pic1.Image = picture3.Image;
                    break;
                case 4:
                    pic1.Image = picture4.Image;
                    break;
                default:
                    pic1.Image = picture5.Image;
                    break;
            }
            switch (mnColour2)
            {
                case 1:
                    pic2.Image = picture1.Image;
                    break;
                case 2:
                    pic2.Image = picture2.Image;
                    break;
                case 3:
                    pic2.Image = picture3.Image;
                    break;
                case 4:
                    pic2.Image = picture4.Image;
                    break;
                default:
                    pic2.Image = picture5.Image;
                    break;
            }

            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            switch (mnPosition)
            {
                case 1:
                    pnl1.Visible = true;
                    break;
                case 2:
                    pnl2.Visible = true;
                    break;
                case 3:
                    pnl3.Visible = true;
                    break;
                default:
                    pnl4.Visible = true;
                    break;
            }

            for (int i = 1; i <= 6; i++)
            {
                _count[i - 1] = rnd1.Next(1, 7);
            }
            switch (mnPosition)
            {
                case 1:
                    lbl11.Text = Convert.ToString(_count[0]);
                    lbl12.Text = Convert.ToString(_count[1]);
                    lbl13.Text = Convert.ToString(_count[2]);
                    lbl14.Text = Convert.ToString(_count[3]);
                    lbl15.Text = Convert.ToString(_count[4]);
                    lbl16.Text = Convert.ToString(_count[5]);
                    break;
                case 2:
                    lbl21.Text = Convert.ToString(_count[0]);
                    lbl22.Text = Convert.ToString(_count[1]);
                    lbl23.Text = Convert.ToString(_count[2]);
                    lbl24.Text = Convert.ToString(_count[3]);
                    lbl25.Text = Convert.ToString(_count[4]);
                    lbl26.Text = Convert.ToString(_count[5]);
                    pnl2.Visible = true;
                    break;
                case 3:
                    lbl31.Text = Convert.ToString(_count[0]);
                    lbl32.Text = Convert.ToString(_count[1]);
                    lbl33.Text = Convert.ToString(_count[2]);
                    lbl34.Text = Convert.ToString(_count[3]);
                    lbl35.Text = Convert.ToString(_count[4]);
                    lbl36.Text = Convert.ToString(_count[5]);
                    pnl3.Visible = true;
                    break;
                default:
                    lbl41.Text = Convert.ToString(_count[0]);
                    lbl42.Text = Convert.ToString(_count[1]);
                    lbl43.Text = Convert.ToString(_count[2]);
                    lbl44.Text = Convert.ToString(_count[3]);
                    lbl45.Text = Convert.ToString(_count[4]);
                    lbl46.Text = Convert.ToString(_count[5]);
                    pnl4.Visible = true;
                    break;
            }
        }

        private void lbl11_Click(object sender, EventArgs e)
        {
            _count[0] = rnd1.Next(1, 7);
            lbl11.Text = Convert.ToString(_count[0]);
        }
        private void lbl12_Click(object sender, EventArgs e)
        {
            _count[1] = rnd1.Next(1, 7);
            lbl12.Text = Convert.ToString(_count[1]);
        }
        private void lbl13_Click(object sender, EventArgs e)
        {
            _count[2] = rnd1.Next(1, 7);
            lbl13.Text = Convert.ToString(_count[2]);
        }
        private void lbl14_Click(object sender, EventArgs e)
        {
            _count[3] = rnd1.Next(1, 7);
            lbl14.Text = Convert.ToString(_count[3]);
        }
        private void lbl15_Click(object sender, EventArgs e)
        {
            _count[4] = rnd1.Next(1, 7);
            lbl15.Text = Convert.ToString(_count[4]);
        }
        private void lbl16_Click(object sender, EventArgs e)
        {
            _count[5] = rnd1.Next(1, 7);
            lbl16.Text = Convert.ToString(_count[5]);
        }

        //2
        private void lbl21_Click_1(object sender, EventArgs e)
        {
            _count[0] = rnd1.Next(1, 7);
            lbl21.Text = Convert.ToString(_count[0]);
        }
        private void lbl22_Click_1(object sender, EventArgs e)
        {
            _count[1] = rnd1.Next(1, 7);
            lbl22.Text = Convert.ToString(_count[1]);
        }
        private void lbl23_Click_1(object sender, EventArgs e)
        {
            _count[2] = rnd1.Next(1, 7);
            lbl23.Text = Convert.ToString(_count[2]);
        }
        private void lbl24_Click_1(object sender, EventArgs e)
        {
            _count[3] = rnd1.Next(1, 7);
            lbl24.Text = Convert.ToString(_count[3]);
        }
        private void lbl25_Click_1(object sender, EventArgs e)
        {
            _count[4] = rnd1.Next(1, 7);
            lbl25.Text = Convert.ToString(_count[4]);
        }
        private void lbl26_Click_1(object sender, EventArgs e)
        {
            _count[5] = rnd1.Next(1, 7);
            lbl26.Text = Convert.ToString(_count[5]);
        }

        //3
        private void lbl31_Click_1(object sender, EventArgs e)
        {
            _count[0] = rnd1.Next(1, 7);
            lbl31.Text = Convert.ToString(_count[0]);
        }
        private void lbl32_Click_1(object sender, EventArgs e)
        {
            _count[1] = rnd1.Next(1, 7);
            lbl32.Text = Convert.ToString(_count[1]);
        }
        private void lbl33_Click_1(object sender, EventArgs e)
        {
            _count[2] = rnd1.Next(1, 7);
            lbl33.Text = Convert.ToString(_count[2]);
        }
        private void lbl34_Click_1(object sender, EventArgs e)
        {
            _count[3] = rnd1.Next(1, 7);
            lbl34.Text = Convert.ToString(_count[3]);
        }
        private void lbl35_Click_1(object sender, EventArgs e)
        {
            _count[4] = rnd1.Next(1, 7);
            lbl35.Text = Convert.ToString(_count[4]);
        }
        private void lbl36_Click_1(object sender, EventArgs e)
        {
            _count[5] = rnd1.Next(1, 7);
            lbl36.Text = Convert.ToString(_count[5]);
        }

        //4
        private void lbl41_Click_1(object sender, EventArgs e)
        {
            _count[0] = rnd1.Next(1, 7);
            lbl41.Text = Convert.ToString(_count[0]);
        }
        private void lbl42_Click_1(object sender, EventArgs e)
        {
            _count[1] = rnd1.Next(1, 7);
            lbl42.Text = Convert.ToString(_count[1]);
        }
        private void lbl43_Click_1(object sender, EventArgs e)
        {
            _count[2] = rnd1.Next(1, 7);
            lbl43.Text = Convert.ToString(_count[2]);
        }
        private void lbl44_Click_1(object sender, EventArgs e)
        {
            _count[3] = rnd1.Next(1, 7);
            lbl44.Text = Convert.ToString(_count[3]);
        }
        private void lbl45_Click_1(object sender, EventArgs e)
        {
            _count[4] = rnd1.Next(1, 7);
            lbl45.Text = Convert.ToString(_count[4]);
        }
        private void lbl46_Click_1(object sender, EventArgs e)
        {
            _count[5] = rnd1.Next(1, 7);
            lbl46.Text = Convert.ToString(_count[5]);
        }
    }
}
