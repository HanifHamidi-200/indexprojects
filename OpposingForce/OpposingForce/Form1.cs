using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpposingForce
{
    public partial class Form1 : Form
    {
        private static List<int> _count = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<String> _db = new List<String> {"Equals","Eye","Paddle","Star","Steel","Triangle"};
        private static List<int> _dbkey = new List<int> {0,0,0,0,0,0 };
        private Random rnd1 = new Random();
        private int nScore = 0;
        private int nNumber;
        private int mnGet;
        private int mnStump = 7;

        public Form1()
        {
            InitializeComponent();
            mnGet = rnd1.Next(1, 7);
            mnStump = 7;
            lblScore.Text = "Score = 0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String sWord = null;

            for (int i = 1; i <= 6; i++)
            {
                _dbkey[i - 1] = rnd1.Next(1, 7);
            }
            for (int i = 1; i <= 12; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _count[i - 1] = 7;
                }
                else
                {
                    _count[i - 1] = rnd1.Next(1, 7);
                }
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

            if (lstKey.Items.Count > 0)
            {
                do
                {
                    lstKey.Items.RemoveAt(0);
                } while (lstKey.Items.Count > 0);
            }
            for (int i = 1; i <= 6; i++)
            {
                sWord = _db[i - 1] + " = " + _db[_dbkey[i - 1]-1];
                lstKey.Items.Add(sWord);
            }
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            String sWord = null;

            for (int i = 1; i <= 6; i++)
            {
                _dbkey[i - 1] = rnd1.Next(1, 7);
            }
            for (int i = 1; i <= 12; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _count[i - 1] = 7;
                }
                else
                {
                    _count[i - 1] = rnd1.Next(1, 7);
                }
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

            if (lstKey.Items.Count > 0)
            {
                do
                {
                    lstKey.Items.RemoveAt(0);
                } while (lstKey.Items.Count > 0);
            }
            for (int i = 1; i <= 6; i++)
            {
                sWord = _db[i - 1] + " = " + _db[_dbkey[i - 1]-1];
                lstKey.Items.Add(sWord);
            }
        }

        private void picGet1_Click(object sender, EventArgs e)
        {
            mnGet = 1;
        }
        private void picGet2_Click(object sender, EventArgs e)
        {
            mnGet = 2;
        }
        private void picGet3_Click(object sender, EventArgs e)
        {
            mnGet = 3;
        }
        private void picGet4_Click(object sender, EventArgs e)
        {
            mnGet = 4;
        }
        private void picGet5_Click(object sender, EventArgs e)
        {
            mnGet = 5;
        }
        private void picGet6_Click(object sender, EventArgs e)
        {
            mnGet = 6;
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            int nNeeded = 7;

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

            mnStump = _count[0];

            if (mnStump == 7)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                nNeeded = _dbkey[mnStump - 1];
                if (mnGet == nNeeded)
                {
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
                else
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            int nNeeded = 7;

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

            mnStump = _count[1];

            if (mnStump == 7)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                nNeeded = _dbkey[mnStump - 1];
                if (mnGet == nNeeded)
                {
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
                else
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            int nNeeded = 7;

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

            mnStump = _count[2];

            if (mnStump == 7)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                nNeeded = _dbkey[mnStump - 1];
                if (mnGet == nNeeded)
                {
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
                else
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            int nNeeded = 7;

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

            mnStump = _count[3];

            if (mnStump == 7)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                nNeeded = _dbkey[mnStump - 1];
                if (mnGet == nNeeded)
                {
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
                else
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            int nNeeded = 7;

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

            mnStump = _count[4];

            if (mnStump == 7)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                nNeeded = _dbkey[mnStump - 1];
                if (mnGet == nNeeded)
                {
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
                else
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            int nNeeded = 7;

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

            mnStump = _count[5];

            if (mnStump == 7)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                nNeeded = _dbkey[mnStump - 1];
                if (mnGet == nNeeded)
                {
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
                else
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        private void pic7_Click(object sender, EventArgs e)
        {
            int nNeeded = 7;

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

            mnStump = _count[6];

            if (mnStump == 7)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                nNeeded = _dbkey[mnStump - 1];
                if (mnGet == nNeeded)
                {
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
                else
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        private void pic8_Click(object sender, EventArgs e)
        {
            int nNeeded = 7;

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

            mnStump = _count[7];

            if (mnStump == 7)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                nNeeded = _dbkey[mnStump - 1];
                if (mnGet == nNeeded)
                {
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
                else
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        private void pic9_Click(object sender, EventArgs e)
        {
            int nNeeded = 7;

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

            mnStump = _count[8];

            if (mnStump == 7)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                nNeeded = _dbkey[mnStump - 1];
                if (mnGet == nNeeded)
                {
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
                else
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        private void pica_Click(object sender, EventArgs e)
        {
            int nNeeded = 7;

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

            mnStump = _count[9];

            if (mnStump == 7)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                nNeeded = _dbkey[mnStump - 1];
                if (mnGet == nNeeded)
                {
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
                else
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        private void picb_Click(object sender, EventArgs e)
        {
            int nNeeded = 7;

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

            mnStump = _count[10];

            if (mnStump == 7)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                nNeeded = _dbkey[mnStump - 1];
                if (mnGet == nNeeded)
                {
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
                else
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        private void picc_Click(object sender, EventArgs e)
        {
            int nNeeded = 7;

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

            mnStump = _count[11];

            if (mnStump == 7)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                nNeeded = _dbkey[mnStump - 1];
                if (mnGet == nNeeded)
                {
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
                else
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        private void btnComply_Click(object sender, EventArgs e)
        {
            bool bFound = false;

            for (int i = 1; i <= 12; i++)
            {
                if (_count[i - 1] < 7)
                {
                    bFound = true;
                }
            }

            if (bFound == true)
            {
                MessageBox.Show("Not finished yet!");
            }
            else
            {
                nScore = nScore + 10;
                lblScore.Text = "Score = " + Convert.ToString(nScore);
            }
        }
    }
}
