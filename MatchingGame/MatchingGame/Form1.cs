using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class Form1 : Form
    {
        private static List<int> _count = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private Random rnd1 = new Random();
        private bool bLarge = false;
        private int nNumber,nNumber2;
        private bool bLeft = true;
        private int nLeftCount, nRightCount;
        private int nScore = 0;

        public Form1()
        {
            InitializeComponent();
            lblScore.Text = "Score = 0";
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F Equals.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F Eye.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F Paddle.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F Star.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F Steel.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F Triangle.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F Nullgate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            if (bLeft)
            {
                nLeftCount = _count[0];
                bLeft = false;
                switch (nLeftCount)
                {
                    case 1:
                        picLeft.Image = picture1.Image;
                        break;
                    case 2:
                        picLeft.Image = picture2.Image;
                        break;
                    case 3:
                        picLeft.Image = picture3.Image;
                        break;
                    case 4:
                        picLeft.Image = picture4.Image;
                        break;
                    case 5:
                        picLeft.Image = picture5.Image;
                        break;
                    case 6:
                        picLeft.Image = picture6.Image;
                        break;
                    default:
                        picLeft.Image = picture7.Image;
                        break;
                }
            }
            else
            {
                nRightCount = _count[0];
                bLeft = true;
                switch (nRightCount)
                {
                    case 1:
                        picRight.Image = picture1.Image;
                        break;
                    case 2:
                        picRight.Image = picture2.Image;
                        break;
                    case 3:
                        picRight.Image = picture3.Image;
                        break;
                    case 4:
                        picRight.Image = picture4.Image;
                        break;
                    case 5:
                        picRight.Image = picture5.Image;
                        break;
                    case 6:
                        picRight.Image = picture6.Image;
                        break;
                    default:
                        picRight.Image = picture7.Image;
                        break;
                }
            }

            _count[0] = 7;
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
                default:
                    pic1.Image = picture7.Image;
                    break;
            }
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F Equals.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F Eye.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F Paddle.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F Star.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F Steel.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F Triangle.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F Nullgate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            if (bLeft)
            {
                nLeftCount = _count[1];
                bLeft = false;
                switch (nLeftCount)
                {
                    case 1:
                        picLeft.Image = picture1.Image;
                        break;
                    case 2:
                        picLeft.Image = picture2.Image;
                        break;
                    case 3:
                        picLeft.Image = picture3.Image;
                        break;
                    case 4:
                        picLeft.Image = picture4.Image;
                        break;
                    case 5:
                        picLeft.Image = picture5.Image;
                        break;
                    case 6:
                        picLeft.Image = picture6.Image;
                        break;
                    default:
                        picLeft.Image = picture7.Image;
                        break;
                }
            }
            else
            {
                nRightCount = _count[1];
                bLeft = true;
                switch (nRightCount)
                {
                    case 1:
                        picRight.Image = picture1.Image;
                        break;
                    case 2:
                        picRight.Image = picture2.Image;
                        break;
                    case 3:
                        picRight.Image = picture3.Image;
                        break;
                    case 4:
                        picRight.Image = picture4.Image;
                        break;
                    case 5:
                        picRight.Image = picture5.Image;
                        break;
                    case 6:
                        picRight.Image = picture6.Image;
                        break;
                    default:
                        picRight.Image = picture7.Image;
                        break;
                }
            }

            _count[1] = 7;
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
                default:
                    pic2.Image = picture7.Image;
                    break;
            }

        }

        private void pic3_Click(object sender, EventArgs e)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F Equals.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F Eye.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F Paddle.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F Star.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F Steel.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F Triangle.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F Nullgate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            if (bLeft)
            {
                nLeftCount = _count[2];
                bLeft = false;
                switch (nLeftCount)
                {
                    case 1:
                        picLeft.Image = picture1.Image;
                        break;
                    case 2:
                        picLeft.Image = picture2.Image;
                        break;
                    case 3:
                        picLeft.Image = picture3.Image;
                        break;
                    case 4:
                        picLeft.Image = picture4.Image;
                        break;
                    case 5:
                        picLeft.Image = picture5.Image;
                        break;
                    case 6:
                        picLeft.Image = picture6.Image;
                        break;
                    default:
                        picLeft.Image = picture7.Image;
                        break;
                }
            }
            else
            {
                nRightCount = _count[2];
                bLeft = true;
                switch (nRightCount)
                {
                    case 1:
                        picRight.Image = picture1.Image;
                        break;
                    case 2:
                        picRight.Image = picture2.Image;
                        break;
                    case 3:
                        picRight.Image = picture3.Image;
                        break;
                    case 4:
                        picRight.Image = picture4.Image;
                        break;
                    case 5:
                        picRight.Image = picture5.Image;
                        break;
                    case 6:
                        picRight.Image = picture6.Image;
                        break;
                    default:
                        picRight.Image = picture7.Image;
                        break;
                }
            }

            _count[2] = 7;
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
                default:
                    pic3.Image = picture7.Image;
                    break;
            }

        }

        private void pic4_Click(object sender, EventArgs e)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F Equals.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F Eye.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F Paddle.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F Star.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F Steel.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F Triangle.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F Nullgate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            if (bLeft)
            {
                nLeftCount = _count[3];
                bLeft = false;
                switch (nLeftCount)
                {
                    case 1:
                        picLeft.Image = picture1.Image;
                        break;
                    case 2:
                        picLeft.Image = picture2.Image;
                        break;
                    case 3:
                        picLeft.Image = picture3.Image;
                        break;
                    case 4:
                        picLeft.Image = picture4.Image;
                        break;
                    case 5:
                        picLeft.Image = picture5.Image;
                        break;
                    case 6:
                        picLeft.Image = picture6.Image;
                        break;
                    default:
                        picLeft.Image = picture7.Image;
                        break;
                }
            }
            else
            {
                nRightCount = _count[3];
                bLeft = true;
                switch (nRightCount)
                {
                    case 1:
                        picRight.Image = picture1.Image;
                        break;
                    case 2:
                        picRight.Image = picture2.Image;
                        break;
                    case 3:
                        picRight.Image = picture3.Image;
                        break;
                    case 4:
                        picRight.Image = picture4.Image;
                        break;
                    case 5:
                        picRight.Image = picture5.Image;
                        break;
                    case 6:
                        picRight.Image = picture6.Image;
                        break;
                    default:
                        picRight.Image = picture7.Image;
                        break;
                }
            }

            _count[3] = 7;
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
                default:
                    pic4.Image = picture7.Image;
                    break;
            }

        }

        private void pic5_Click(object sender, EventArgs e)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F Equals.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F Eye.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F Paddle.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F Star.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F Steel.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F Triangle.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F Nullgate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            if (bLeft)
            {
                nLeftCount = _count[4];
                bLeft = false;
                switch (nLeftCount)
                {
                    case 1:
                        picLeft.Image = picture1.Image;
                        break;
                    case 2:
                        picLeft.Image = picture2.Image;
                        break;
                    case 3:
                        picLeft.Image = picture3.Image;
                        break;
                    case 4:
                        picLeft.Image = picture4.Image;
                        break;
                    case 5:
                        picLeft.Image = picture5.Image;
                        break;
                    case 6:
                        picLeft.Image = picture6.Image;
                        break;
                    default:
                        picLeft.Image = picture7.Image;
                        break;
                }
            }
            else
            {
                nRightCount = _count[4];
                bLeft = true;
                switch (nRightCount)
                {
                    case 1:
                        picRight.Image = picture1.Image;
                        break;
                    case 2:
                        picRight.Image = picture2.Image;
                        break;
                    case 3:
                        picRight.Image = picture3.Image;
                        break;
                    case 4:
                        picRight.Image = picture4.Image;
                        break;
                    case 5:
                        picRight.Image = picture5.Image;
                        break;
                    case 6:
                        picRight.Image = picture6.Image;
                        break;
                    default:
                        picRight.Image = picture7.Image;
                        break;
                }
            }

            _count[4] = 7;
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
                default:
                    pic5.Image = picture7.Image;
                    break;
            }

        }

        private void pic6_Click(object sender, EventArgs e)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F Equals.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F Eye.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F Paddle.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F Star.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F Steel.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F Triangle.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F Nullgate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            if (bLeft)
            {
                nLeftCount = _count[5];
                bLeft = false;
                switch (nLeftCount)
                {
                    case 1:
                        picLeft.Image = picture1.Image;
                        break;
                    case 2:
                        picLeft.Image = picture2.Image;
                        break;
                    case 3:
                        picLeft.Image = picture3.Image;
                        break;
                    case 4:
                        picLeft.Image = picture4.Image;
                        break;
                    case 5:
                        picLeft.Image = picture5.Image;
                        break;
                    case 6:
                        picLeft.Image = picture6.Image;
                        break;
                    default:
                        picLeft.Image = picture7.Image;
                        break;
                }
            }
            else
            {
                nRightCount = _count[5];
                bLeft = true;
                switch (nRightCount)
                {
                    case 1:
                        picRight.Image = picture1.Image;
                        break;
                    case 2:
                        picRight.Image = picture2.Image;
                        break;
                    case 3:
                        picRight.Image = picture3.Image;
                        break;
                    case 4:
                        picRight.Image = picture4.Image;
                        break;
                    case 5:
                        picRight.Image = picture5.Image;
                        break;
                    case 6:
                        picRight.Image = picture6.Image;
                        break;
                    default:
                        picRight.Image = picture7.Image;
                        break;
                }
            }

            _count[5] = 7;
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
                default:
                    pic6.Image = picture7.Image;
                    break;
            }

        }

        private void pic7_Click(object sender, EventArgs e)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F Equals.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F Eye.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F Paddle.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F Star.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F Steel.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F Triangle.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F Nullgate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            if (bLeft)
            {
                nLeftCount = _count[6];
                bLeft = false;
                switch (nLeftCount)
                {
                    case 1:
                        picLeft.Image = picture1.Image;
                        break;
                    case 2:
                        picLeft.Image = picture2.Image;
                        break;
                    case 3:
                        picLeft.Image = picture3.Image;
                        break;
                    case 4:
                        picLeft.Image = picture4.Image;
                        break;
                    case 5:
                        picLeft.Image = picture5.Image;
                        break;
                    case 6:
                        picLeft.Image = picture6.Image;
                        break;
                    default:
                        picLeft.Image = picture7.Image;
                        break;
                }
            }
            else
            {
                nRightCount = _count[6];
                bLeft = true;
                switch (nRightCount)
                {
                    case 1:
                        picRight.Image = picture1.Image;
                        break;
                    case 2:
                        picRight.Image = picture2.Image;
                        break;
                    case 3:
                        picRight.Image = picture3.Image;
                        break;
                    case 4:
                        picRight.Image = picture4.Image;
                        break;
                    case 5:
                        picRight.Image = picture5.Image;
                        break;
                    case 6:
                        picRight.Image = picture6.Image;
                        break;
                    default:
                        picRight.Image = picture7.Image;
                        break;
                }
            }

            _count[6] = 7;
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
                default:
                    pic7.Image = picture7.Image;
                    break;
            }

        }

        private void pic8_Click(object sender, EventArgs e)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F Equals.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F Eye.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F Paddle.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F Star.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F Steel.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F Triangle.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F Nullgate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            if (bLeft)
            {
                nLeftCount = _count[7];
                bLeft = false;
                switch (nLeftCount)
                {
                    case 1:
                        picLeft.Image = picture1.Image;
                        break;
                    case 2:
                        picLeft.Image = picture2.Image;
                        break;
                    case 3:
                        picLeft.Image = picture3.Image;
                        break;
                    case 4:
                        picLeft.Image = picture4.Image;
                        break;
                    case 5:
                        picLeft.Image = picture5.Image;
                        break;
                    case 6:
                        picLeft.Image = picture6.Image;
                        break;
                    default:
                        picLeft.Image = picture7.Image;
                        break;
                }
            }
            else
            {
                nRightCount = _count[7];
                bLeft = true;
                switch (nRightCount)
                {
                    case 1:
                        picRight.Image = picture1.Image;
                        break;
                    case 2:
                        picRight.Image = picture2.Image;
                        break;
                    case 3:
                        picRight.Image = picture3.Image;
                        break;
                    case 4:
                        picRight.Image = picture4.Image;
                        break;
                    case 5:
                        picRight.Image = picture5.Image;
                        break;
                    case 6:
                        picRight.Image = picture6.Image;
                        break;
                    default:
                        picRight.Image = picture7.Image;
                        break;
                }
            }

            _count[7] = 7;
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
                default:
                    pic8.Image = picture7.Image;
                    break;
            }

        }

        private void pic9_Click(object sender, EventArgs e)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F Equals.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F Eye.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F Paddle.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F Star.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F Steel.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F Triangle.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F Nullgate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            if (bLeft)
            {
                nLeftCount = _count[8];
                bLeft = false;
                switch (nLeftCount)
                {
                    case 1:
                        picLeft.Image = picture1.Image;
                        break;
                    case 2:
                        picLeft.Image = picture2.Image;
                        break;
                    case 3:
                        picLeft.Image = picture3.Image;
                        break;
                    case 4:
                        picLeft.Image = picture4.Image;
                        break;
                    case 5:
                        picLeft.Image = picture5.Image;
                        break;
                    case 6:
                        picLeft.Image = picture6.Image;
                        break;
                    default:
                        picLeft.Image = picture7.Image;
                        break;
                }
            }
            else
            {
                nRightCount = _count[8];
                bLeft = true;
                switch (nRightCount)
                {
                    case 1:
                        picRight.Image = picture1.Image;
                        break;
                    case 2:
                        picRight.Image = picture2.Image;
                        break;
                    case 3:
                        picRight.Image = picture3.Image;
                        break;
                    case 4:
                        picRight.Image = picture4.Image;
                        break;
                    case 5:
                        picRight.Image = picture5.Image;
                        break;
                    case 6:
                        picRight.Image = picture6.Image;
                        break;
                    default:
                        picRight.Image = picture7.Image;
                        break;
                }
            }

            _count[8] = 7;
            switch (_count[8])
            {
                case 1:
                    pic9.Image = picture1.Image;
                    break;
                case 2:
                    pic9.Image = picture2.Image;
                    break;
                case 3:
                    pic9.Image = picture3.Image;
                    break;
                case 4:
                    pic9.Image = picture4.Image;
                    break;
                case 5:
                    pic9.Image = picture5.Image;
                    break;
                case 6:
                    pic9.Image = picture6.Image;
                    break;
                default:
                    pic9.Image = picture7.Image;
                    break;
            }

        }

        private void pica_Click(object sender, EventArgs e)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F Equals.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F Eye.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F Paddle.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F Star.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F Steel.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F Triangle.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F Nullgate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            if (bLeft)
            {
                nLeftCount = _count[9];
                bLeft = false;
                switch (nLeftCount)
                {
                    case 1:
                        picLeft.Image = picture1.Image;
                        break;
                    case 2:
                        picLeft.Image = picture2.Image;
                        break;
                    case 3:
                        picLeft.Image = picture3.Image;
                        break;
                    case 4:
                        picLeft.Image = picture4.Image;
                        break;
                    case 5:
                        picLeft.Image = picture5.Image;
                        break;
                    case 6:
                        picLeft.Image = picture6.Image;
                        break;
                    default:
                        picLeft.Image = picture7.Image;
                        break;
                }
            }
            else
            {
                nRightCount = _count[9];
                bLeft = true;
                switch (nRightCount)
                {
                    case 1:
                        picRight.Image = picture1.Image;
                        break;
                    case 2:
                        picRight.Image = picture2.Image;
                        break;
                    case 3:
                        picRight.Image = picture3.Image;
                        break;
                    case 4:
                        picRight.Image = picture4.Image;
                        break;
                    case 5:
                        picRight.Image = picture5.Image;
                        break;
                    case 6:
                        picRight.Image = picture6.Image;
                        break;
                    default:
                        picRight.Image = picture7.Image;
                        break;
                }
            }

            _count[9] = 7;
            switch (_count[9])
            {
                case 1:
                    pica.Image = picture1.Image;
                    break;
                case 2:
                    pica.Image = picture2.Image;
                    break;
                case 3:
                    pica.Image = picture3.Image;
                    break;
                case 4:
                    pica.Image = picture4.Image;
                    break;
                case 5:
                    pica.Image = picture5.Image;
                    break;
                case 6:
                    pica.Image = picture6.Image;
                    break;
                default:
                    pica.Image = picture7.Image;
                    break;
            }

        }

        private void picb_Click(object sender, EventArgs e)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F Equals.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F Eye.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F Paddle.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F Star.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F Steel.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F Triangle.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F Nullgate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            if (bLeft)
            {
                nLeftCount = _count[10];
                bLeft = false;
                switch (nLeftCount)
                {
                    case 1:
                        picLeft.Image = picture1.Image;
                        break;
                    case 2:
                        picLeft.Image = picture2.Image;
                        break;
                    case 3:
                        picLeft.Image = picture3.Image;
                        break;
                    case 4:
                        picLeft.Image = picture4.Image;
                        break;
                    case 5:
                        picLeft.Image = picture5.Image;
                        break;
                    case 6:
                        picLeft.Image = picture6.Image;
                        break;
                    default:
                        picLeft.Image = picture7.Image;
                        break;
                }
            }
            else
            {
                nRightCount = _count[10];
                bLeft = true;
                switch (nRightCount)
                {
                    case 1:
                        picRight.Image = picture1.Image;
                        break;
                    case 2:
                        picRight.Image = picture2.Image;
                        break;
                    case 3:
                        picRight.Image = picture3.Image;
                        break;
                    case 4:
                        picRight.Image = picture4.Image;
                        break;
                    case 5:
                        picRight.Image = picture5.Image;
                        break;
                    case 6:
                        picRight.Image = picture6.Image;
                        break;
                    default:
                        picRight.Image = picture7.Image;
                        break;
                }
            }

            _count[10] = 7;
            switch (_count[10])
            {
                case 1:
                    picb.Image = picture1.Image;
                    break;
                case 2:
                    picb.Image = picture2.Image;
                    break;
                case 3:
                    picb.Image = picture3.Image;
                    break;
                case 4:
                    picb.Image = picture4.Image;
                    break;
                case 5:
                    picb.Image = picture5.Image;
                    break;
                case 6:
                    picb.Image = picture6.Image;
                    break;
                default:
                    picb.Image = picture7.Image;
                    break;
            }

        }

        private void picc_Click(object sender, EventArgs e)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F Equals.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F Eye.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F Paddle.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F Star.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F Steel.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F Triangle.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F Nullgate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            if (bLeft)
            {
                nLeftCount = _count[11];
                bLeft = false;
                switch (nLeftCount)
                {
                    case 1:
                        picLeft.Image = picture1.Image;
                        break;
                    case 2:
                        picLeft.Image = picture2.Image;
                        break;
                    case 3:
                        picLeft.Image = picture3.Image;
                        break;
                    case 4:
                        picLeft.Image = picture4.Image;
                        break;
                    case 5:
                        picLeft.Image = picture5.Image;
                        break;
                    case 6:
                        picLeft.Image = picture6.Image;
                        break;
                    default:
                        picLeft.Image = picture7.Image;
                        break;
                }
            }
            else
            {
                nRightCount = _count[11];
                bLeft = true;
                switch (nRightCount)
                {
                    case 1:
                        picRight.Image = picture1.Image;
                        break;
                    case 2:
                        picRight.Image = picture2.Image;
                        break;
                    case 3:
                        picRight.Image = picture3.Image;
                        break;
                    case 4:
                        picRight.Image = picture4.Image;
                        break;
                    case 5:
                        picRight.Image = picture5.Image;
                        break;
                    case 6:
                        picRight.Image = picture6.Image;
                        break;
                    default:
                        picRight.Image = picture7.Image;
                        break;
                }
            }

            _count[11] = 7;
            switch (_count[11])
            {
                case 1:
                    picc.Image = picture1.Image;
                    break;
                case 2:
                    picc.Image = picture2.Image;
                    break;
                case 3:
                    picc.Image = picture3.Image;
                    break;
                case 4:
                    picc.Image = picture4.Image;
                    break;
                case 5:
                    picc.Image = picture5.Image;
                    break;
                case 6:
                    picc.Image = picture6.Image;
                    break;
                default:
                    picc.Image = picture7.Image;
                    break;
            }

        }

        private void btnComply_Click(object sender, EventArgs e)
        {
            if (nLeftCount == nRightCount)
            {
                PictureBox picture1 = new PictureBox
                {
                    Name = "pictureBox1",
                    Image = Image.FromFile(@"F Equals.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                PictureBox picture2 = new PictureBox
                {
                    Name = "pictureBox2",
                    Image = Image.FromFile(@"F Eye.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                PictureBox picture3 = new PictureBox
                {
                    Name = "pictureBox3",
                    Image = Image.FromFile(@"F Paddle.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                PictureBox picture4 = new PictureBox
                {
                    Name = "pictureBox4",
                    Image = Image.FromFile(@"F Star.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                PictureBox picture5 = new PictureBox
                {
                    Name = "pictureBox5",
                    Image = Image.FromFile(@"F Steel.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                PictureBox picture6 = new PictureBox
                {
                    Name = "pictureBox6",
                    Image = Image.FromFile(@"F Triangle.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                PictureBox picture7 = new PictureBox
                {
                    Name = "pictureBox7",
                    Image = Image.FromFile(@"F Nullgate.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                nScore = nScore+ 10;
                lblScore.Text = "Score = " + Convert.ToString(nScore);
                bLeft = true;
                nLeftCount = 7;
                nRightCount = 7;
                picLeft.Image = picture7.Image;
                picRight.Image = picture7.Image;
            }
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            int nChosen = rnd1.Next(1, 7);
            bool bValid = false;
            bLeft = true;
            nLeftCount = 7;
            nRightCount = 7;

            for (int i = 1; i <= 12; i++)
            {
                _count[i - 1] = rnd1.Next(1, 7);
            }
            nNumber = rnd1.Next(1, 10);
            if (nNumber <= 5)
            {
                pnl2.Visible = true;
                nNumber = rnd1.Next(1, 13);
                _count[nNumber - 1] = nChosen;
                do
                {
                    nNumber2 = rnd1.Next(1, 13);
                    if (nNumber2 != nNumber)
                    {
                        bValid = true;
                    }
                } while (bValid == false);
                _count[nNumber2 - 1] = nChosen;
            }
            else
            {
                pnl2.Visible = false;
                nNumber = rnd1.Next(1, 7);
                _count[nNumber - 1] = nChosen;
                do
                {
                    nNumber2 = rnd1.Next(1, 7);
                    if (nNumber2 != nNumber)
                    {
                        bValid = true;
                    }
                } while (bValid == false);
                _count[nNumber2 - 1] = nChosen;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F Equals.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F Eye.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F Paddle.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F Star.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F Steel.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F Triangle.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F Nullgate.png"),
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
                default:
                    pic1.Image = picture7.Image;
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
                default:
                    pic2.Image = picture7.Image;
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
                default:
                    pic3.Image = picture7.Image;
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
                default:
                    pic4.Image = picture7.Image;
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
                default:
                    pic5.Image = picture7.Image;
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
                default:
                    pic6.Image = picture7.Image;
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
                default:
                    pic7.Image = picture7.Image;
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
                default:
                    pic8.Image = picture7.Image;
                    break;
            }
            switch (_count[8])
            {
                case 1:
                    pic9.Image = picture1.Image;
                    break;
                case 2:
                    pic9.Image = picture2.Image;
                    break;
                case 3:
                    pic9.Image = picture3.Image;
                    break;
                case 4:
                    pic9.Image = picture4.Image;
                    break;
                case 5:
                    pic9.Image = picture5.Image;
                    break;
                case 6:
                    pic9.Image = picture6.Image;
                    break;
                default:
                    pic9.Image = picture7.Image;
                    break;
            }
            switch (_count[9])
            {
                case 1:
                    pica.Image = picture1.Image;
                    break;
                case 2:
                    pica.Image = picture2.Image;
                    break;
                case 3:
                    pica.Image = picture3.Image;
                    break;
                case 4:
                    pica.Image = picture4.Image;
                    break;
                case 5:
                    pica.Image = picture5.Image;
                    break;
                case 6:
                    pica.Image = picture6.Image;
                    break;
                default:
                    pica.Image = picture7.Image;
                    break;
            }
            switch (_count[10])
            {
                case 1:
                    picb.Image = picture1.Image;
                    break;
                case 2:
                    picb.Image = picture2.Image;
                    break;
                case 3:
                    picb.Image = picture3.Image;
                    break;
                case 4:
                    picb.Image = picture4.Image;
                    break;
                case 5:
                    picb.Image = picture5.Image;
                    break;
                case 6:
                    picb.Image = picture6.Image;
                    break;
                default:
                    picb.Image = picture7.Image;
                    break;
            }
            switch (_count[11])
            {
                case 1:
                    picc.Image = picture1.Image;
                    break;
                case 2:
                    picc.Image = picture2.Image;
                    break;
                case 3:
                    picc.Image = picture3.Image;
                    break;
                case 4:
                    picc.Image = picture4.Image;
                    break;
                case 5:
                    picc.Image = picture5.Image;
                    break;
                case 6:
                    picc.Image = picture6.Image;
                    break;
                default:
                    picc.Image = picture7.Image;
                    break;
            }

            switch (nLeftCount)
            {
                case 1:
                    picLeft.Image = picture1.Image;
                    break;
                case 2:
                    picLeft.Image = picture2.Image;
                    break;
                case 3:
                    picLeft.Image = picture3.Image;
                    break;
                case 4:
                    picLeft.Image = picture4.Image;
                    break;
                case 5:
                    picLeft.Image = picture5.Image;
                    break;
                case 6:
                    picLeft.Image = picture6.Image;
                    break;
                default:
                    picLeft.Image = picture7.Image;
                    break;
            }
            switch (nRightCount)
            {
                case 1:
                    picRight.Image = picture1.Image;
                    break;
                case 2:
                    picRight.Image = picture2.Image;
                    break;
                case 3:
                    picRight.Image = picture3.Image;
                    break;
                case 4:
                    picRight.Image = picture4.Image;
                    break;
                case 5:
                    picRight.Image = picture5.Image;
                    break;
                case 6:
                    picRight.Image = picture6.Image;
                    break;
                default:
                    picRight.Image = picture7.Image;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int nChosen = rnd1.Next(1, 7);
            bool bValid = false;
            bLeft = true;
            nLeftCount = 7;
            nRightCount = 7;

            for (int i = 1; i <= 12; i++)
            {
                _count[i - 1] = rnd1.Next(1, 7);
            }
            nNumber = rnd1.Next(1, 10);
            if (nNumber <= 5)
            {
                pnl2.Visible = true;
                nNumber = rnd1.Next(1, 13);
                _count[nNumber - 1] = nChosen;
                do
                {
                    nNumber2 = rnd1.Next(1, 13);
                    if (nNumber2 != nNumber) {
                        bValid = true;
                    }
                } while (bValid == false);
                _count[nNumber2 - 1] = nChosen;
            }
            else
            {
                pnl2.Visible = false;
                nNumber = rnd1.Next(1, 7);
                _count[nNumber - 1] = nChosen;
                do
                {
                    nNumber2 = rnd1.Next(1, 7);
                    if (nNumber2 != nNumber)
                    {
                        bValid = true;
                    }
                } while (bValid == false);
                _count[nNumber2 - 1] = nChosen;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F Equals.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F Eye.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F Paddle.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F Star.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F Steel.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F Triangle.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F Nullgate.png"),
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
                default:
                    pic1.Image = picture7.Image;
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
                default:
                    pic2.Image = picture7.Image;
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
                default:
                    pic3.Image = picture7.Image;
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
                default:
                    pic4.Image = picture7.Image;
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
                default:
                    pic5.Image = picture7.Image;
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
                default:
                    pic6.Image = picture7.Image;
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
                default:
                    pic7.Image = picture7.Image;
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
                default:
                    pic8.Image = picture7.Image;
                    break;
            }
            switch (_count[8])
            {
                case 1:
                    pic9.Image = picture1.Image;
                    break;
                case 2:
                    pic9.Image = picture2.Image;
                    break;
                case 3:
                    pic9.Image = picture3.Image;
                    break;
                case 4:
                    pic9.Image = picture4.Image;
                    break;
                case 5:
                    pic9.Image = picture5.Image;
                    break;
                case 6:
                    pic9.Image = picture6.Image;
                    break;
                default:
                    pic9.Image = picture7.Image;
                    break;
            }
            switch (_count[9])
            {
                case 1:
                    pica.Image = picture1.Image;
                    break;
                case 2:
                    pica.Image = picture2.Image;
                    break;
                case 3:
                    pica.Image = picture3.Image;
                    break;
                case 4:
                    pica.Image = picture4.Image;
                    break;
                case 5:
                    pica.Image = picture5.Image;
                    break;
                case 6:
                    pica.Image = picture6.Image;
                    break;
                default:
                    pica.Image = picture7.Image;
                    break;
            }
            switch (_count[10])
            {
                case 1:
                    picb.Image = picture1.Image;
                    break;
                case 2:
                    picb.Image = picture2.Image;
                    break;
                case 3:
                    picb.Image = picture3.Image;
                    break;
                case 4:
                    picb.Image = picture4.Image;
                    break;
                case 5:
                    picb.Image = picture5.Image;
                    break;
                case 6:
                    picb.Image = picture6.Image;
                    break;
                default:
                    picb.Image = picture7.Image;
                    break;
            }
            switch (_count[11])
            {
                case 1:
                    picc.Image = picture1.Image;
                    break;
                case 2:
                    picc.Image = picture2.Image;
                    break;
                case 3:
                    picc.Image = picture3.Image;
                    break;
                case 4:
                    picc.Image = picture4.Image;
                    break;
                case 5:
                    picc.Image = picture5.Image;
                    break;
                case 6:
                    picc.Image = picture6.Image;
                    break;
                default:
                    picc.Image = picture7.Image;
                    break;
            }

            switch (nLeftCount)
            {
                case 1:
                    picLeft.Image = picture1.Image;
                    break;
                case 2:
                    picLeft.Image = picture2.Image;
                    break;
                case 3:
                    picLeft.Image = picture3.Image;
                    break;
                case 4:
                    picLeft.Image = picture4.Image;
                    break;
                case 5:
                    picLeft.Image = picture5.Image;
                    break;
                case 6:
                    picLeft.Image = picture6.Image;
                    break;
                default:
                    picLeft.Image = picture7.Image;
                    break;
            }
            switch (nRightCount)
            {
                case 1:
                    picRight.Image = picture1.Image;
                    break;
                case 2:
                    picRight.Image = picture2.Image;
                    break;
                case 3:
                    picRight.Image = picture3.Image;
                    break;
                case 4:
                    picRight.Image = picture4.Image;
                    break;
                case 5:
                    picRight.Image = picture5.Image;
                    break;
                case 6:
                    picRight.Image = picture6.Image;
                    break;
                default:
                    picRight.Image = picture7.Image;
                    break;
            }

        }
    }
}
