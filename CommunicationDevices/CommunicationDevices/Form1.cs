using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunicationDevices
{
    public partial class Form1 : Form
    {
        private static List<int> _count = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0,0,0,0,0 };
        private static List<int> _value = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0,0,0,0,0 };
        private Random rnd1 = new Random();
        private int nScore=0;
        private int mnNeeded=0, mnGot = 0;
        private int mnExit, mnTrueExit;

        private void fUpdateDisplay()
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F Exit.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F Equals.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F Eye.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F Mebbelgrid.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F Paddle.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F Proscient.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F SkinFormula.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F Star.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F Steel.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F Triangle.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F Turquoise.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            switch (_count[0])
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
                case 5:
                    pic1.Image = picture5.Image;
                    break;
                case 6:
                    pic1.Image = picture6.Image;
                    break;
                case 7:
                    pic1.Image = picture7.Image;
                    break;
                case 8:
                    pic1.Image = picture8.Image;
                    break;
                case 9:
                    pic1.Image = picture9.Image;
                    break;
                case 10:
                    pic1.Image = picture10.Image;
                    break;
                case 11:
                    pic1.Image = picture11.Image;
                    break;
                default:
                    pic1.Image = picture12.Image;
                    break;
            }

            switch (_count[1])
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
                case 5:
                    pic2.Image = picture5.Image;
                    break;
                case 6:
                    pic2.Image = picture6.Image;
                    break;
                case 7:
                    pic2.Image = picture7.Image;
                    break;
                case 8:
                    pic2.Image = picture8.Image;
                    break;
                case 9:
                    pic2.Image = picture9.Image;
                    break;
                case 10:
                    pic2.Image = picture10.Image;
                    break;
                case 11:
                    pic2.Image = picture11.Image;
                    break;
                default:
                    pic2.Image = picture12.Image;
                    break;
            }

            switch (_count[2])
            {
                case 1:
                    pic3.Image = picture1.Image;
                    break;
                case 2:
                    pic3.Image = picture2.Image;
                    break;
                case 3:
                    pic3.Image = picture3.Image;
                    break;
                case 4:
                    pic3.Image = picture4.Image;
                    break;
                case 5:
                    pic3.Image = picture5.Image;
                    break;
                case 6:
                    pic3.Image = picture6.Image;
                    break;
                case 7:
                    pic3.Image = picture7.Image;
                    break;
                case 8:
                    pic3.Image = picture8.Image;
                    break;
                case 9:
                    pic3.Image = picture9.Image;
                    break;
                case 10:
                    pic3.Image = picture10.Image;
                    break;
                case 11:
                    pic3.Image = picture11.Image;
                    break;
                default:
                    pic3.Image = picture12.Image;
                    break;
            }

            switch (_count[3])
            {
                case 1:
                    pic4.Image = picture1.Image;
                    break;
                case 2:
                    pic4.Image = picture2.Image;
                    break;
                case 3:
                    pic4.Image = picture3.Image;
                    break;
                case 4:
                    pic4.Image = picture4.Image;
                    break;
                case 5:
                    pic4.Image = picture5.Image;
                    break;
                case 6:
                    pic4.Image = picture6.Image;
                    break;
                case 7:
                    pic4.Image = picture7.Image;
                    break;
                case 8:
                    pic4.Image = picture8.Image;
                    break;
                case 9:
                    pic4.Image = picture9.Image;
                    break;
                case 10:
                    pic4.Image = picture10.Image;
                    break;
                case 11:
                    pic4.Image = picture11.Image;
                    break;
                default:
                    pic4.Image = picture12.Image;
                    break;
            }

            switch (_count[4])
            {
                case 1:
                    pic5.Image = picture1.Image;
                    break;
                case 2:
                    pic5.Image = picture2.Image;
                    break;
                case 3:
                    pic5.Image = picture3.Image;
                    break;
                case 4:
                    pic5.Image = picture4.Image;
                    break;
                case 5:
                    pic5.Image = picture5.Image;
                    break;
                case 6:
                    pic5.Image = picture6.Image;
                    break;
                case 7:
                    pic5.Image = picture7.Image;
                    break;
                case 8:
                    pic5.Image = picture8.Image;
                    break;
                case 9:
                    pic5.Image = picture9.Image;
                    break;
                case 10:
                    pic5.Image = picture10.Image;
                    break;
                case 11:
                    pic5.Image = picture11.Image;
                    break;
                default:
                    pic5.Image = picture12.Image;
                    break;
            }

            switch (_count[5])
            {
                case 1:
                    pic6.Image = picture1.Image;
                    break;
                case 2:
                    pic6.Image = picture2.Image;
                    break;
                case 3:
                    pic6.Image = picture3.Image;
                    break;
                case 4:
                    pic6.Image = picture4.Image;
                    break;
                case 5:
                    pic6.Image = picture5.Image;
                    break;
                case 6:
                    pic6.Image = picture6.Image;
                    break;
                case 7:
                    pic6.Image = picture7.Image;
                    break;
                case 8:
                    pic6.Image = picture8.Image;
                    break;
                case 9:
                    pic6.Image = picture9.Image;
                    break;
                case 10:
                    pic6.Image = picture10.Image;
                    break;
                case 11:
                    pic6.Image = picture11.Image;
                    break;
                default:
                    pic6.Image = picture12.Image;
                    break;
            }

            switch (_count[6])
            {
                case 1:
                    pic7.Image = picture1.Image;
                    break;
                case 2:
                    pic7.Image = picture2.Image;
                    break;
                case 3:
                    pic7.Image = picture3.Image;
                    break;
                case 4:
                    pic7.Image = picture4.Image;
                    break;
                case 5:
                    pic7.Image = picture5.Image;
                    break;
                case 6:
                    pic7.Image = picture6.Image;
                    break;
                case 7:
                    pic7.Image = picture7.Image;
                    break;
                case 8:
                    pic7.Image = picture8.Image;
                    break;
                case 9:
                    pic7.Image = picture9.Image;
                    break;
                case 10:
                    pic7.Image = picture10.Image;
                    break;
                case 11:
                    pic7.Image = picture11.Image;
                    break;
                default:
                    pic7.Image = picture12.Image;
                    break;
            }

            switch (_count[7])
            {
                case 1:
                    pic8.Image = picture1.Image;
                    break;
                case 2:
                    pic8.Image = picture2.Image;
                    break;
                case 3:
                    pic8.Image = picture3.Image;
                    break;
                case 4:
                    pic8.Image = picture4.Image;
                    break;
                case 5:
                    pic8.Image = picture5.Image;
                    break;
                case 6:
                    pic8.Image = picture6.Image;
                    break;
                case 7:
                    pic8.Image = picture7.Image;
                    break;
                case 8:
                    pic8.Image = picture8.Image;
                    break;
                case 9:
                    pic8.Image = picture9.Image;
                    break;
                case 10:
                    pic8.Image = picture10.Image;
                    break;
                case 11:
                    pic8.Image = picture11.Image;
                    break;
                default:
                    pic8.Image = picture12.Image;
                    break;
            }
        }
        public Form1()
        {
            InitializeComponent();
            lblNeeded.Text = "NEEDED = 0";
            lblGot.Text = "GOT = 0";
            lblScore.Text = "Score = 0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int nCount = 0;

            mnExit = 0;
            mnTrueExit = 1;
            for (int i = 1; i <= 12; i++)
            {
                _value[i - 1] = rnd1.Next(4, 11);
            }

            int nTotal = 0;
            for (int i = 1; i <= 8; i++)
            {
                _count[i - 1] = rnd1.Next(2, 12);
                nTotal = nTotal + _value[_count[i - 1] - 1];
            }
            mnGot = nTotal;
            nTotal = 0;
            for (int i = 1; i <= 8; i++)
            {
                nCount = rnd1.Next(2, 12);
                nTotal = nTotal + _value[nCount - 1];
            }
            mnNeeded = nTotal;
            lblNeeded.Text = "NEEDED = " + Convert.ToString(mnNeeded);
            lblGot.Text = "GOT = 0" + Convert.ToString(mnGot);

            fUpdateDisplay();
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            _count[0] = rnd1.Next(2, 12);
            int nTotal = 0;
            for (int i = 1; i <= 8; i++)
            {
                 nTotal = nTotal + _value[_count[i-1] - 1];
            }
            mnGot = nTotal;
            lblGot.Text = "GOT = 0" + Convert.ToString(mnGot);

            fUpdateDisplay();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            _count[1] = rnd1.Next(2, 12);
            int nTotal = 0;
            for (int i = 1; i <= 8; i++)
            {
                nTotal = nTotal + _value[_count[i - 1] - 1];
            }
            mnGot = nTotal;
            lblGot.Text = "GOT = 0" + Convert.ToString(mnGot);

            fUpdateDisplay();
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            _count[2] = rnd1.Next(2, 12);
            int nTotal = 0;
            for (int i = 1; i <= 8; i++)
            {
                nTotal = nTotal + _value[_count[i - 1] - 1];
            }
            mnGot = nTotal;
            lblGot.Text = "GOT = 0" + Convert.ToString(mnGot);

            fUpdateDisplay();
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            _count[3] = rnd1.Next(2, 12);
            int nTotal = 0;
            for (int i = 1; i <= 8; i++)
            {
                nTotal = nTotal + _value[_count[i - 1] - 1];
            }
            mnGot = nTotal;
            lblGot.Text = "GOT = 0" + Convert.ToString(mnGot);

            fUpdateDisplay();
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            _count[4] = rnd1.Next(2, 12);
            int nTotal = 0;
            for (int i = 1; i <= 8; i++)
            {
                nTotal = nTotal + _value[_count[i - 1] - 1];
            }
            mnGot = nTotal;
            lblGot.Text = "GOT = 0" + Convert.ToString(mnGot);

            fUpdateDisplay();
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            _count[5] = rnd1.Next(2, 12);
            int nTotal = 0;
            for (int i = 1; i <= 8; i++)
            {
                nTotal = nTotal + _value[_count[i - 1] - 1];
            }
            mnGot = nTotal;
            lblGot.Text = "GOT = 0" + Convert.ToString(mnGot);

            fUpdateDisplay();
        }

        private void pic7_Click(object sender, EventArgs e)
        {
            _count[6] = rnd1.Next(2, 12);
            int nTotal = 0;
            for (int i = 1; i <= 8; i++)
            {
                nTotal = nTotal + _value[_count[i - 1] - 1];
            }
            mnGot = nTotal;
            lblGot.Text = "GOT = 0" + Convert.ToString(mnGot);

            fUpdateDisplay();
        }

        private void pic8_Click(object sender, EventArgs e)
        {
            _count[7] = rnd1.Next(2, 12);
            int nTotal = 0;
            for (int i = 1; i <= 8; i++)
            {
                nTotal = nTotal + _value[_count[i - 1] - 1];
            }
            mnGot = nTotal;
            lblGot.Text = "GOT = 0" + Convert.ToString(mnGot);

            fUpdateDisplay();
        }

        private void btnComply_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nExit = rnd1.Next(1, 9);
            int nTrueExit = rnd1.Next(1, 9);
            String sText;

        
            if (mnGot == mnNeeded)
            {
                mnExit = nExit;
                mnTrueExit = nTrueExit;
                nScore = nScore + 10;
                lblScore.Text = "Score = " + Convert.ToString(nScore);
                _count[nExit - 1] = 1;
                fUpdateDisplay();
                switch (nTrueExit)
                {
                    case 1:
                        sText = "from the NorthEast";
                        break;
                    case 2:
                        sText = "from the East";
                        break;
                    case 3:
                        sText = "from the SouthEast";
                        break;
                    case 4:
                        sText = "from the South";
                        break;
                    case 5:
                        sText = "from the SouthWest";
                        break;
                    case 6:
                        sText = "from the West";
                        break;
                    case 7:
                        sText = "from the NorthWest";
                        break;
                    default:
                        sText = "from the North";
                        break;
                }
                MessageBox.Show("TrueExit " + sText);
            }
        }

        private void btnComply2_Click(object sender, EventArgs e)
        {
            if (mnExit == mnTrueExit)
            {
                nScore += 20;
                lblScore.Text = "Score = " + Convert.ToString(nScore);

                int nCount = 0;

                mnExit = 0;
                mnTrueExit = 1;

                for (int i = 1; i <= 12; i++)
                {
                    _value[i - 1] = rnd1.Next(4, 11);
                }

                int nTotal = 0;
                for (int i = 1; i <= 8; i++)
                {
                    _count[i - 1] = rnd1.Next(2, 12);
                    nTotal = nTotal + _value[_count[i - 1] - 1];
                }
                mnGot = nTotal;
                nTotal = 0;
                for (int i = 1; i <= 8; i++)
                {
                    nCount = rnd1.Next(2, 12);
                    nTotal = nTotal + _value[nCount - 1];
                }
                mnNeeded = nTotal;
                lblNeeded.Text = "NEEDED = " + Convert.ToString(mnNeeded);
                lblGot.Text = "GOT = 0" + Convert.ToString(mnGot);

                fUpdateDisplay();
            }
        }

        private void btnClockwise_Click(object sender, EventArgs e)
        {
            int nSave = _count[7];
            for (int i = 8; i >=2; i--)
            {
                _count[i-1] = _count[i - 2];
            }
            _count[0] = nSave;

            mnExit += 1;
            if (mnExit == 9)
            {
                mnExit = 1;
            }
            fUpdateDisplay();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            int nCount = 0;

            mnExit = 0;
            mnTrueExit = 1;

            for (int i = 1; i <= 12; i++)
            {
                _value[i - 1] = rnd1.Next(4, 11);
            }

            int nTotal = 0;
            for (int i = 1; i <= 8; i++)
            {
                _count[i - 1] = rnd1.Next(2, 12);
                nTotal = nTotal + _value[_count[i - 1] - 1];
            }
            mnGot = nTotal;
            nTotal = 0;
            for (int i = 1; i <= 8; i++)
            {
                nCount = rnd1.Next(2, 12);
                nTotal = nTotal + _value[nCount - 1];
            }
            mnNeeded = nTotal;
            lblNeeded.Text = "NEEDED = " + Convert.ToString(mnNeeded);
            lblGot.Text = "GOT = 0" + Convert.ToString(mnGot);

            fUpdateDisplay();
        }
    }
}
