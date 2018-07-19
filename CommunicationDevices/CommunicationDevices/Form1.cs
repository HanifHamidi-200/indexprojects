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
        private static List<int> _value = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0,0,0,0,0,0,0,0,0 };
        private static List<int> _node = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private Random rnd1 = new Random();
        private int nScore=0;
        private int mnNeeded=0, mnGot = 0;
        private int mnExit, mnTrueExit;
        private int mnCount = 16;
        private int mnNodes = 8;

        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
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
                Image = Image.FromFile(@"F anime.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F Equals.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F Eye.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F homingdevice.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F Mebbelgrid.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F Paddle.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F Proscient.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F recharger.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F SkinFormula.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F spatum.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F Star.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"F Steel.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"F Triangle.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"F Turquoise.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };


            switch (nValue)
            {
                case 1:
                    _pic2 = picture1;
                    break;
                case 2:
                    _pic2 = picture2;
                    break;
                case 3:
                    _pic2 = picture3;
                    break;
                case 4:
                    _pic2 = picture4;
                    break;
                case 5:
                    _pic2 = picture5;
                    break;
                case 6:
                    _pic2 = picture6;
                    break;
                case 7:
                    _pic2 = picture7;
                    break;
                case 8:
                    _pic2 = picture8;
                    break;
                case 9:
                    _pic2 = picture9;
                    break;
                case 10:
                    _pic2 = picture10;
                    break;
                case 11:
                    _pic2 = picture11;
                    break;
                case 12:
                    _pic2 = picture12;
                    break;
                case 13:
                    _pic2 = picture13;
                    break;
                case 14:
                    _pic2 = picture14;
                    break;
                case 15:
                    _pic2 = picture15;
                    break;
                  default:
                    _pic2 = picture16;
                    break;
            }
            for (int i = 1; i <= nRotate - 1; i++)
            {
                _pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

        }

        private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate;

            for (int i = 1; i <= 8; i++)
            {
                nType = _node[i - 1];
                nRotate = 1;
                fPeek(nType, nRotate, ref _pic);
                switch (i)
                {
                    case 1:
                        pic1.Image = _pic.Image;
                        break;
                    case 2:
                        pic2.Image = _pic.Image;
                        break;
                    case 3:
                        pic3.Image = _pic.Image;
                        break;
                    case 4:
                        pic4.Image = _pic.Image;
                        break;
                    case 5:
                        pic5.Image = _pic.Image;
                        break;
                    case 6:
                        pic6.Image = _pic.Image;
                        break;
                    case 7:
                        pic7.Image = _pic.Image;
                        break;
                    default:
                        pic8.Image = _pic.Image;
                        break;
                }
            }

        }

        private void fReset()
        {
            int nCount = 0;

            mnExit = 0;
            mnTrueExit = 1;
            for (int i = 1; i <= mnCount; i++)
            {
                _value[i - 1] = rnd1.Next(4, 11);
            }

            int nTotal = 0;
            for (int i = 1; i <= mnNodes; i++)
            {
                _node[i - 1] = rnd1.Next(2, mnCount+1);
                nTotal = nTotal + _value[_node[i - 1] - 1];
            }
            mnGot = nTotal;
            nTotal = 0;
            for (int i = 1; i <= mnNodes; i++)
            {
                nCount = rnd1.Next(2, mnCount+1);
                nTotal = nTotal + _value[nCount - 1];
            }
            mnNeeded = nTotal;
            lblNeeded.Text = "NEEDED = " + Convert.ToString(mnNeeded);
            lblGot.Text = "GOT = 0" + Convert.ToString(mnGot);

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
            fReset();
            fUpdateDisplay();
        }
        
        private void fClick(int nMode)
        {
            Random rnd1 = new Random();

            int nTotal = 0;

            _node[nMode - 1] += 1;
            if (_node[nMode - 1] > mnCount)
            {
                _node[nMode - 1] = 2;
            }

            for (int i = 1; i <= mnNodes; i++)
            {
                nTotal = nTotal + _value[_node[i - 1]-1];
            }
            mnGot = nTotal;
            lblGot.Text = "GOT = 0" + Convert.ToString(mnGot);

            fUpdateDisplay();
        }


        private void pic1_Click(object sender, EventArgs e)
        {
            fClick(1);
        }
        private void pic2_Click(object sender, EventArgs e)
        {
            fClick(2);
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            fClick(3);
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            fClick(4);
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            fClick(5);
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            fClick(6);
        }

        private void pic7_Click(object sender, EventArgs e)
        {
            fClick(7);
        }

        private void pic8_Click(object sender, EventArgs e)
        {
            fClick(8);
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
                _node[nExit - 1] = 1;
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
                nScore += 100;
                lblScore.Text = "Score = " + Convert.ToString(nScore);

                fReset();
                fUpdateDisplay();
            }
        }

        private void btnClockwise_Click(object sender, EventArgs e)
        {
            int nSave = _node[mnNodes-1];
            for (int i = mnNodes; i >=2; i--)
            {
                _node[i-1] = _node[i - 2];
            }
            _node[0] = nSave;

            mnExit += 1;
            if (mnExit == mnNodes+1)
            {
                mnExit = 1;
            }
            fUpdateDisplay();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
            fUpdateDisplay();
        }
    }
}
