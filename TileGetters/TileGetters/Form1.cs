using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TileGetters
{
 
    public partial class Form1 : Form
    {
        private static List<int> _count = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private String sAnswer1=null, sAnswer2=null,sAnswer3=null;
        private String msPopup1;
        private int mnItem;

        public Form1()
        {
            InitializeComponent();
            sAnswer1 = null;
            sAnswer2 = null;
            sAnswer3 = null;
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            String sLetter=txtLetter.Text.Substring(0,1);
            int i = 1;
            sAnswer1 = sAnswer1.Substring(0, i-1) + sLetter + sAnswer1.Substring(i , 16 - i);
            if (sAnswer1.Substring(i-1,1) == sAnswer2.Substring(i - 1, 1))
            {
                sAnswer3 = sAnswer3.Substring(0, i - 1) + sLetter + sAnswer3.Substring(i , 16 - i);
            }
            lblAnswer1.Text = sAnswer1;
            lblAnswer2.Text = sAnswer3;
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            String sLetter = txtLetter.Text.Substring(0, 1);
            int i = 3;
            sAnswer1 = sAnswer1.Substring(0, i-1) + sLetter + sAnswer1.Substring(i , 16 - i);
            if (sAnswer1.Substring(i - 1, 1) == sAnswer2.Substring(i - 1, 1))
            {
                sAnswer3 = sAnswer3.Substring(0, i-1) + sLetter + sAnswer3.Substring(i , 16 - i);
            }
            lblAnswer1.Text = sAnswer1;
            lblAnswer2.Text = sAnswer3;
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            String sLetter = txtLetter.Text.Substring(0, 1);
            int i = 4;
            sAnswer1 = sAnswer1.Substring(0, i-1) + sLetter + sAnswer1.Substring(i , 16 - i);
            if (sAnswer1.Substring(i - 1, 1) == sAnswer2.Substring(i - 1, 1))
            {
                sAnswer3 = sAnswer3.Substring(0, i-1) + sLetter + sAnswer3.Substring(i , 16 - i);
            }
            lblAnswer1.Text = sAnswer1;
            lblAnswer2.Text = sAnswer3;
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            String sLetter = txtLetter.Text.Substring(0, 1);
            int i = 5;
            sAnswer1 = sAnswer1.Substring(0, i-1) + sLetter + sAnswer1.Substring(i , 16 - i);
            if (sAnswer1.Substring(i - 1, 1) == sAnswer2.Substring(i - 1, 1))
            {
                sAnswer3 = sAnswer3.Substring(0, i-1) + sLetter + sAnswer3.Substring(i , 16 - i);
            }
            lblAnswer1.Text = sAnswer1;
            lblAnswer2.Text = sAnswer3;
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            String sLetter = txtLetter.Text.Substring(0, 1);
            int i = 6;
            sAnswer1 = sAnswer1.Substring(0, i-1) + sLetter + sAnswer1.Substring(i , 16 - i);
            if (sAnswer1.Substring(i - 1, 1) == sAnswer2.Substring(i - 1, 1))
            {
                sAnswer3 = sAnswer3.Substring(0, i-1) + sLetter + sAnswer3.Substring(i , 16 - i);
            }
            lblAnswer1.Text = sAnswer1;
            lblAnswer2.Text = sAnswer3;
        }

        private void pic7_Click(object sender, EventArgs e)
        {
            String sLetter = txtLetter.Text.Substring(0, 1);
            int i = 7;
            sAnswer1 = sAnswer1.Substring(0, i-1) + sLetter + sAnswer1.Substring(i , 16 - i);
            if (sAnswer1.Substring(i - 1, 1) == sAnswer2.Substring(i - 1, 1))
            {
                sAnswer3 = sAnswer3.Substring(0, i-1) + sLetter + sAnswer3.Substring(i , 16 - i);
            }
            lblAnswer1.Text = sAnswer1;
            lblAnswer2.Text = sAnswer3;
        }

        private void pic8_Click(object sender, EventArgs e)
        {
            String sLetter = txtLetter.Text.Substring(0, 1);
            int i = 8;
            sAnswer1 = sAnswer1.Substring(0, i-1) + sLetter + sAnswer1.Substring(i , 16 - i);
            if (sAnswer1.Substring(i - 1, 1) == sAnswer2.Substring(i - 1, 1))
            {
                sAnswer3 = sAnswer3.Substring(0, i-1) + sLetter + sAnswer3.Substring(i , 16 - i);
            }
            lblAnswer1.Text = sAnswer1;
            lblAnswer2.Text = sAnswer3;
        }

        private void pic9_Click(object sender, EventArgs e)
        {
            String sLetter = txtLetter.Text.Substring(0, 1);
            int i = 9;
            sAnswer1 = sAnswer1.Substring(0, i-1) + sLetter + sAnswer1.Substring(i , 16 - i);
            if (sAnswer1.Substring(i - 1, 1) == sAnswer2.Substring(i - 1, 1))
            {
                sAnswer3 = sAnswer3.Substring(0, i-1) + sLetter + sAnswer3.Substring(i , 16 - i);
            }
            lblAnswer1.Text = sAnswer1;
            lblAnswer2.Text = sAnswer3;
        }

        private void pica_Click(object sender, EventArgs e)
        {
            String sLetter = txtLetter.Text.Substring(0, 1);
            int i = 10;
            sAnswer1 = sAnswer1.Substring(0, i-1) + sLetter + sAnswer1.Substring(i , 16 - i);
            if (sAnswer1.Substring(i - 1, 1) == sAnswer2.Substring(i - 1, 1))
            {
                sAnswer3 = sAnswer3.Substring(0, i-1) + sLetter + sAnswer3.Substring(i , 16 - i);
            }
            lblAnswer1.Text = sAnswer1;
            lblAnswer2.Text = sAnswer3;
        }

        private void picb_Click(object sender, EventArgs e)
        {
            String sLetter = txtLetter.Text.Substring(0, 1);
            int i = 11;
            sAnswer1 = sAnswer1.Substring(0, i-1) + sLetter + sAnswer1.Substring(i , 16 - i);
            if (sAnswer1.Substring(i - 1, 1) == sAnswer2.Substring(i - 1, 1))
            {
                sAnswer3 = sAnswer3.Substring(0, i-1) + sLetter + sAnswer3.Substring(i , 16 - i);
            }
            lblAnswer1.Text = sAnswer1;
            lblAnswer2.Text = sAnswer3;
        }

        private void picc_Click(object sender, EventArgs e)
        {
            String sLetter = txtLetter.Text.Substring(0, 1);
            int i = 12;
            sAnswer1 = sAnswer1.Substring(0, i-1) + sLetter + sAnswer1.Substring(i , 16 - i);
            if (sAnswer1.Substring(i - 1, 1) == sAnswer2.Substring(i - 1, 1))
            {
                sAnswer3 = sAnswer3.Substring(0, i-1) + sLetter + sAnswer3.Substring(i , 16 - i);
            }
            lblAnswer1.Text = sAnswer1;
            lblAnswer2.Text = sAnswer3;
        }

        private void picd_Click(object sender, EventArgs e)
        {
            String sLetter = txtLetter.Text.Substring(0, 1);
            int i = 13;
            sAnswer1 = sAnswer1.Substring(0, i-1) + sLetter + sAnswer1.Substring(i , 16 - i);
            if (sAnswer1.Substring(i - 1, 1) == sAnswer2.Substring(i - 1, 1))
            {
                sAnswer3 = sAnswer3.Substring(0, i-1) + sLetter + sAnswer3.Substring(i , 16 - i);
            }
            lblAnswer1.Text = sAnswer1;
            lblAnswer2.Text = sAnswer3;
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            char sLetter;

            sAnswer1 = null;
            sAnswer2 = null;
            sAnswer3 = null;
            for (int i = 1; i <= 16; i++)
            {
                sAnswer1 = sAnswer1 + " ";
                sAnswer2 = sAnswer2 + "-";
                sAnswer3 = sAnswer3 + "-";
            }
            for (int i = 1; i <= 16; i++)
            {
                _count[i - 1] = rnd1.Next(1, 105);
            }
            for (int i = 1; i <= 16; i++)
            {
                if (_count[i - 1] <= 26)
                {
                    sLetter = (char)(_count[i - 1] + 64);
                    sAnswer2 = sAnswer2.Substring(0, i - 1) + sLetter + sAnswer2.Substring(i, 16 - i);
                }
                else
                {
                    if (_count[i - 1] <= 26 + 26)
                    {
                        sLetter = (char)(_count[i - 1] + 64 - 26);
                        sAnswer2 = sAnswer2.Substring(0, i - 1) + sLetter + sAnswer2.Substring(i, 16 - i);
                    }
                    else
                    {
                        if (_count[i - 1] <= 26 + 26 + 26)
                        {
                            sLetter = (char)(_count[i - 1] + 64 - 26 - 26);
                            sAnswer2 = sAnswer2.Substring(0, i - 1) + sLetter + sAnswer2.Substring(i, 16 - i);
                        }
                        else
                        {
                            sLetter = (char)(_count[i - 1] + 64 - 26 - 26 - 26);
                            sAnswer2 = sAnswer2.Substring(0, i - 1) + sLetter + sAnswer2.Substring(i, 16 - i);
                        }
                    }
                }
            }
            lblAnswer1.Text = sAnswer1;
            lblAnswer2.Text = sAnswer3;


            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F B1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F B2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F B3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F B4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F B5.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F B6.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F B7.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F B8.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F B9.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F B10.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F B11.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F B12.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"F B13.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"F B14.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"F B15.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"F B16.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
                Image = Image.FromFile(@"F B17.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture18 = new PictureBox
            {
                Name = "pictureBox18",
                Image = Image.FromFile(@"F B18.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture19 = new PictureBox
            {
                Name = "pictureBox19",
                Image = Image.FromFile(@"F B19.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture20 = new PictureBox
            {
                Name = "pictureBox20",
                Image = Image.FromFile(@"F B20.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture21 = new PictureBox
            {
                Name = "pictureBox21",
                Image = Image.FromFile(@"F B21.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture22 = new PictureBox
            {
                Name = "pictureBox22",
                Image = Image.FromFile(@"F B22.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture23 = new PictureBox
            {
                Name = "pictureBox23",
                Image = Image.FromFile(@"F B23.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture24 = new PictureBox
            {
                Name = "pictureBox24",
                Image = Image.FromFile(@"F B24.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture25 = new PictureBox
            {
                Name = "pictureBox25",
                Image = Image.FromFile(@"F B25.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture26 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F B26.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture27 = new PictureBox
            {
                Name = "pictureBox27",
                Image = Image.FromFile(@"F L1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture28 = new PictureBox
            {
                Name = "pictureBox28",
                Image = Image.FromFile(@"F L2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture29 = new PictureBox
            {
                Name = "pictureBox29",
                Image = Image.FromFile(@"F L3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture30 = new PictureBox
            {
                Name = "pictureBox30",
                Image = Image.FromFile(@"F L4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture31 = new PictureBox
            {
                Name = "pictureBox31",
                Image = Image.FromFile(@"F L5.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture32 = new PictureBox
            {
                Name = "pictureBox32",
                Image = Image.FromFile(@"F L6.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture33 = new PictureBox
            {
                Name = "pictureBox33",
                Image = Image.FromFile(@"F L7.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture34 = new PictureBox
            {
                Name = "pictureBox34",
                Image = Image.FromFile(@"F L8.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture35 = new PictureBox
            {
                Name = "pictureBox35",
                Image = Image.FromFile(@"F L9.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture36 = new PictureBox
            {
                Name = "pictureBox36",
                Image = Image.FromFile(@"F L10.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture37 = new PictureBox
            {
                Name = "pictureBox37",
                Image = Image.FromFile(@"F L11.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture38 = new PictureBox
            {
                Name = "pictureBox38",
                Image = Image.FromFile(@"F L12.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture39 = new PictureBox
            {
                Name = "pictureBox39",
                Image = Image.FromFile(@"F L13.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture40 = new PictureBox
            {
                Name = "pictureBox40",
                Image = Image.FromFile(@"F L14.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture41 = new PictureBox
            {
                Name = "pictureBox41",
                Image = Image.FromFile(@"F L15.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture42 = new PictureBox
            {
                Name = "pictureBox42",
                Image = Image.FromFile(@"F L16.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture43 = new PictureBox
            {
                Name = "pictureBox43",
                Image = Image.FromFile(@"F L17.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture44 = new PictureBox
            {
                Name = "pictureBox44",
                Image = Image.FromFile(@"F L18.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture45 = new PictureBox
            {
                Name = "pictureBox45",
                Image = Image.FromFile(@"F L19.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture46 = new PictureBox
            {
                Name = "pictureBox46",
                Image = Image.FromFile(@"F L20.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture47 = new PictureBox
            {
                Name = "pictureBox47",
                Image = Image.FromFile(@"F L21.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture48 = new PictureBox
            {
                Name = "pictureBox48",
                Image = Image.FromFile(@"F L22.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture49 = new PictureBox
            {
                Name = "pictureBox49",
                Image = Image.FromFile(@"F L23.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture50 = new PictureBox
            {
                Name = "pictureBox50",
                Image = Image.FromFile(@"F L24.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture51 = new PictureBox
            {
                Name = "pictureBox51",
                Image = Image.FromFile(@"F L25.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture52 = new PictureBox
            {
                Name = "pictureBox52",
                Image = Image.FromFile(@"F L26.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture53 = new PictureBox
            {
                Name = "pictureBox53",
                Image = Image.FromFile(@"F M1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture54 = new PictureBox
            {
                Name = "pictureBox54",
                Image = Image.FromFile(@"F M2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture55 = new PictureBox
            {
                Name = "pictureBox55",
                Image = Image.FromFile(@"F M3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture56 = new PictureBox
            {
                Name = "pictureBox56",
                Image = Image.FromFile(@"F M4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture57 = new PictureBox
            {
                Name = "pictureBox57",
                Image = Image.FromFile(@"F M5.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture58 = new PictureBox
            {
                Name = "pictureBox58",
                Image = Image.FromFile(@"F M6.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture59 = new PictureBox
            {
                Name = "pictureBox59",
                Image = Image.FromFile(@"F M7.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture60 = new PictureBox
            {
                Name = "pictureBox60",
                Image = Image.FromFile(@"F M8.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture61 = new PictureBox
            {
                Name = "pictureBox61",
                Image = Image.FromFile(@"F M9.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture62 = new PictureBox
            {
                Name = "pictureBox62",
                Image = Image.FromFile(@"F M10.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture63 = new PictureBox
            {
                Name = "pictureBox63",
                Image = Image.FromFile(@"F M11.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture64 = new PictureBox
            {
                Name = "pictureBox64",
                Image = Image.FromFile(@"F M12.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture65 = new PictureBox
            {
                Name = "pictureBox65",
                Image = Image.FromFile(@"F M13.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture66 = new PictureBox
            {
                Name = "pictureBox66",
                Image = Image.FromFile(@"F M14.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture67 = new PictureBox
            {
                Name = "pictureBox67",
                Image = Image.FromFile(@"F M15.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture68 = new PictureBox
            {
                Name = "pictureBox68",
                Image = Image.FromFile(@"F M16.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture69 = new PictureBox
            {
                Name = "pictureBox69",
                Image = Image.FromFile(@"F M17.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture70 = new PictureBox
            {
                Name = "pictureBox70",
                Image = Image.FromFile(@"F M18.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture71 = new PictureBox
            {
                Name = "pictureBox71",
                Image = Image.FromFile(@"F M19.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture72 = new PictureBox
            {
                Name = "pictureBox72",
                Image = Image.FromFile(@"F M20.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture73 = new PictureBox
            {
                Name = "pictureBox73",
                Image = Image.FromFile(@"F M21.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture74 = new PictureBox
            {
                Name = "pictureBox74",
                Image = Image.FromFile(@"F M22.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture75 = new PictureBox
            {
                Name = "pictureBox75",
                Image = Image.FromFile(@"F M23.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture76 = new PictureBox
            {
                Name = "pictureBox76",
                Image = Image.FromFile(@"F M24.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture77 = new PictureBox
            {
                Name = "pictureBox77",
                Image = Image.FromFile(@"F M25.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture78 = new PictureBox
            {
                Name = "pictureBox78",
                Image = Image.FromFile(@"F M26.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture79 = new PictureBox
            {
                Name = "pictureBox79",
                Image = Image.FromFile(@"F S1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture80 = new PictureBox
            {
                Name = "pictureBox80",
                Image = Image.FromFile(@"F S2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture81 = new PictureBox
            {
                Name = "pictureBox81",
                Image = Image.FromFile(@"F S3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture82 = new PictureBox
            {
                Name = "pictureBox82",
                Image = Image.FromFile(@"F S4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture83 = new PictureBox
            {
                Name = "pictureBox83",
                Image = Image.FromFile(@"F S5.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture84 = new PictureBox
            {
                Name = "pictureBox84",
                Image = Image.FromFile(@"F S6.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture85 = new PictureBox
            {
                Name = "pictureBox85",
                Image = Image.FromFile(@"F S7.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture86 = new PictureBox
            {
                Name = "pictureBox86",
                Image = Image.FromFile(@"F S8.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture87 = new PictureBox
            {
                Name = "pictureBox87",
                Image = Image.FromFile(@"F S9.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture88 = new PictureBox
            {
                Name = "pictureBox88",
                Image = Image.FromFile(@"F S10.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture89 = new PictureBox
            {
                Name = "pictureBox89",
                Image = Image.FromFile(@"F S11.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture90 = new PictureBox
            {
                Name = "pictureBox90",
                Image = Image.FromFile(@"F S12.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture91 = new PictureBox
            {
                Name = "pictureBox91",
                Image = Image.FromFile(@"F S13.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture92 = new PictureBox
            {
                Name = "pictureBox92",
                Image = Image.FromFile(@"F S14.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture93 = new PictureBox
            {
                Name = "pictureBox93",
                Image = Image.FromFile(@"F S15.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture94 = new PictureBox
            {
                Name = "pictureBox94",
                Image = Image.FromFile(@"F S16.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture95 = new PictureBox
            {
                Name = "pictureBox95",
                Image = Image.FromFile(@"F S17.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture96 = new PictureBox
            {
                Name = "pictureBo9x6",
                Image = Image.FromFile(@"F S18.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture97 = new PictureBox
            {
                Name = "pictureBox97",
                Image = Image.FromFile(@"F S19.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture98 = new PictureBox
            {
                Name = "pictureBox98",
                Image = Image.FromFile(@"F S20.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture99 = new PictureBox
            {
                Name = "pictureBox99",
                Image = Image.FromFile(@"F S21.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture100 = new PictureBox
            {
                Name = "pictureBox100",
                Image = Image.FromFile(@"F S22.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture101 = new PictureBox
            {
                Name = "pictureBox101",
                Image = Image.FromFile(@"F S23.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture102 = new PictureBox
            {
                Name = "pictureBox102",
                Image = Image.FromFile(@"F S24.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture103 = new PictureBox
            {
                Name = "pictureBox103",
                Image = Image.FromFile(@"F S25.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture104 = new PictureBox
            {
                Name = "pictureBox104",
                Image = Image.FromFile(@"F S26.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture105 = new PictureBox
            {
                Name = "pictureBox105",
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
                case 12:
                    pic1.Image = picture12.Image;
                    break;
                case 13:
                    pic1.Image = picture13.Image;
                    break;
                case 14:
                    pic1.Image = picture14.Image;
                    break;
                case 15:
                    pic1.Image = picture15.Image;
                    break;
                case 16:
                    pic1.Image = picture16.Image;
                    break;
                case 17:
                    pic1.Image = picture17.Image;
                    break;
                case 18:
                    pic1.Image = picture18.Image;
                    break;
                case 19:
                    pic1.Image = picture19.Image;
                    break;
                case 20:
                    pic1.Image = picture20.Image;
                    break;
                case 21:
                    pic1.Image = picture21.Image;
                    break;
                case 22:
                    pic1.Image = picture22.Image;
                    break;
                case 23:
                    pic1.Image = picture23.Image;
                    break;
                case 24:
                    pic1.Image = picture24.Image;
                    break;
                case 25:
                    pic1.Image = picture25.Image;
                    break;
                case 26:
                    pic1.Image = picture26.Image;
                    break;
                case 27:
                    pic1.Image = picture27.Image;
                    break;
                case 28:
                    pic1.Image = picture28.Image;
                    break;
                case 29:
                    pic1.Image = picture29.Image;
                    break;
                case 30:
                    pic1.Image = picture30.Image;
                    break;
                case 31:
                    pic1.Image = picture31.Image;
                    break;
                case 32:
                    pic1.Image = picture32.Image;
                    break;
                case 33:
                    pic1.Image = picture33.Image;
                    break;
                case 34:
                    pic1.Image = picture34.Image;
                    break;
                case 35:
                    pic1.Image = picture35.Image;
                    break;
                case 36:
                    pic1.Image = picture36.Image;
                    break;
                case 37:
                    pic1.Image = picture37.Image;
                    break;
                case 38:
                    pic1.Image = picture38.Image;
                    break;
                case 39:
                    pic1.Image = picture39.Image;
                    break;
                case 40:
                    pic1.Image = picture40.Image;
                    break;
                case 41:
                    pic1.Image = picture41.Image;
                    break;
                case 42:
                    pic1.Image = picture42.Image;
                    break;
                case 43:
                    pic1.Image = picture43.Image;
                    break;
                case 44:
                    pic1.Image = picture44.Image;
                    break;
                case 45:
                    pic1.Image = picture45.Image;
                    break;
                case 46:
                    pic1.Image = picture46.Image;
                    break;
                case 47:
                    pic1.Image = picture47.Image;
                    break;
                case 48:
                    pic1.Image = picture48.Image;
                    break;
                case 49:
                    pic1.Image = picture49.Image;
                    break;
                case 50:
                    pic1.Image = picture50.Image;
                    break;
                case 51:
                    pic1.Image = picture51.Image;
                    break;
                case 52:
                    pic1.Image = picture52.Image;
                    break;
                case 53:
                    pic1.Image = picture53.Image;
                    break;
                case 54:
                    pic1.Image = picture54.Image;
                    break;
                case 55:
                    pic1.Image = picture55.Image;
                    break;
                case 56:
                    pic1.Image = picture56.Image;
                    break;
                case 57:
                    pic1.Image = picture57.Image;
                    break;
                case 58:
                    pic1.Image = picture58.Image;
                    break;
                case 59:
                    pic1.Image = picture59.Image;
                    break;
                case 60:
                    pic1.Image = picture60.Image;
                    break;
                case 61:
                    pic1.Image = picture61.Image;
                    break;
                case 62:
                    pic1.Image = picture62.Image;
                    break;
                case 63:
                    pic1.Image = picture63.Image;
                    break;
                case 64:
                    pic1.Image = picture64.Image;
                    break;
                case 65:
                    pic1.Image = picture65.Image;
                    break;
                case 66:
                    pic1.Image = picture66.Image;
                    break;
                case 67:
                    pic1.Image = picture67.Image;
                    break;
                case 68:
                    pic1.Image = picture68.Image;
                    break;
                case 69:
                    pic1.Image = picture69.Image;
                    break;
                case 70:
                    pic1.Image = picture70.Image;
                    break;
                case 71:
                    pic1.Image = picture71.Image;
                    break;
                case 72:
                    pic1.Image = picture72.Image;
                    break;
                case 73:
                    pic1.Image = picture73.Image;
                    break;
                case 74:
                    pic1.Image = picture74.Image;
                    break;
                case 75:
                    pic1.Image = picture75.Image;
                    break;
                case 76:
                    pic1.Image = picture76.Image;
                    break;
                case 77:
                    pic1.Image = picture77.Image;
                    break;
                case 78:
                    pic1.Image = picture78.Image;
                    break;
                case 79:
                    pic1.Image = picture79.Image;
                    break;
                case 80:
                    pic1.Image = picture80.Image;
                    break;
                case 81:
                    pic1.Image = picture81.Image;
                    break;
                case 82:
                    pic1.Image = picture82.Image;
                    break;
                case 83:
                    pic1.Image = picture83.Image;
                    break;
                case 84:
                    pic1.Image = picture84.Image;
                    break;
                case 85:
                    pic1.Image = picture85.Image;
                    break;
                case 86:
                    pic1.Image = picture86.Image;
                    break;
                case 87:
                    pic1.Image = picture87.Image;
                    break;
                case 88:
                    pic1.Image = picture88.Image;
                    break;
                case 89:
                    pic1.Image = picture89.Image;
                    break;
                case 90:
                    pic1.Image = picture90.Image;
                    break;
                case 91:
                    pic1.Image = picture91.Image;
                    break;
                case 92:
                    pic1.Image = picture92.Image;
                    break;
                case 93:
                    pic1.Image = picture93.Image;
                    break;
                case 94:
                    pic1.Image = picture94.Image;
                    break;
                case 95:
                    pic1.Image = picture95.Image;
                    break;
                case 96:
                    pic1.Image = picture96.Image;
                    break;
                case 97:
                    pic1.Image = picture97.Image;
                    break;
                case 98:
                    pic1.Image = picture98.Image;
                    break;
                case 99:
                    pic1.Image = picture99.Image;
                    break;
                case 100:
                    pic1.Image = picture100.Image;
                    break;
                case 101:
                    pic1.Image = picture101.Image;
                    break;
                case 102:
                    pic1.Image = picture102.Image;
                    break;
                case 103:
                    pic1.Image = picture103.Image;
                    break;
                case 104:
                    pic1.Image = picture104.Image;
                    break;
                default:
                    pic1.Image = picture105.Image;
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
                case 12:
                    pic2.Image = picture12.Image;
                    break;
                case 13:
                    pic2.Image = picture13.Image;
                    break;
                case 14:
                    pic2.Image = picture14.Image;
                    break;
                case 15:
                    pic2.Image = picture15.Image;
                    break;
                case 16:
                    pic2.Image = picture16.Image;
                    break;
                case 17:
                    pic2.Image = picture17.Image;
                    break;
                case 18:
                    pic2.Image = picture18.Image;
                    break;
                case 19:
                    pic2.Image = picture19.Image;
                    break;
                case 20:
                    pic2.Image = picture20.Image;
                    break;
                case 21:
                    pic2.Image = picture21.Image;
                    break;
                case 22:
                    pic2.Image = picture22.Image;
                    break;
                case 23:
                    pic2.Image = picture23.Image;
                    break;
                case 24:
                    pic2.Image = picture24.Image;
                    break;
                case 25:
                    pic2.Image = picture25.Image;
                    break;
                case 26:
                    pic2.Image = picture26.Image;
                    break;
                case 27:
                    pic2.Image = picture27.Image;
                    break;
                case 28:
                    pic2.Image = picture28.Image;
                    break;
                case 29:
                    pic2.Image = picture29.Image;
                    break;
                case 30:
                    pic2.Image = picture30.Image;
                    break;
                case 31:
                    pic2.Image = picture31.Image;
                    break;
                case 32:
                    pic2.Image = picture32.Image;
                    break;
                case 33:
                    pic2.Image = picture33.Image;
                    break;
                case 34:
                    pic2.Image = picture34.Image;
                    break;
                case 35:
                    pic2.Image = picture35.Image;
                    break;
                case 36:
                    pic2.Image = picture36.Image;
                    break;
                case 37:
                    pic2.Image = picture37.Image;
                    break;
                case 38:
                    pic2.Image = picture38.Image;
                    break;
                case 39:
                    pic2.Image = picture39.Image;
                    break;
                case 40:
                    pic2.Image = picture40.Image;
                    break;
                case 41:
                    pic2.Image = picture41.Image;
                    break;
                case 42:
                    pic2.Image = picture42.Image;
                    break;
                case 43:
                    pic2.Image = picture43.Image;
                    break;
                case 44:
                    pic2.Image = picture44.Image;
                    break;
                case 45:
                    pic2.Image = picture45.Image;
                    break;
                case 46:
                    pic2.Image = picture46.Image;
                    break;
                case 47:
                    pic2.Image = picture47.Image;
                    break;
                case 48:
                    pic2.Image = picture48.Image;
                    break;
                case 49:
                    pic2.Image = picture49.Image;
                    break;
                case 50:
                    pic2.Image = picture50.Image;
                    break;
                case 51:
                    pic2.Image = picture51.Image;
                    break;
                case 52:
                    pic2.Image = picture52.Image;
                    break;
                case 53:
                    pic2.Image = picture53.Image;
                    break;
                case 54:
                    pic2.Image = picture54.Image;
                    break;
                case 55:
                    pic2.Image = picture55.Image;
                    break;
                case 56:
                    pic2.Image = picture56.Image;
                    break;
                case 57:
                    pic2.Image = picture57.Image;
                    break;
                case 58:
                    pic2.Image = picture58.Image;
                    break;
                case 59:
                    pic2.Image = picture59.Image;
                    break;
                case 60:
                    pic2.Image = picture60.Image;
                    break;
                case 61:
                    pic2.Image = picture61.Image;
                    break;
                case 62:
                    pic2.Image = picture62.Image;
                    break;
                case 63:
                    pic2.Image = picture63.Image;
                    break;
                case 64:
                    pic2.Image = picture64.Image;
                    break;
                case 65:
                    pic2.Image = picture65.Image;
                    break;
                case 66:
                    pic2.Image = picture66.Image;
                    break;
                case 67:
                    pic2.Image = picture67.Image;
                    break;
                case 68:
                    pic2.Image = picture68.Image;
                    break;
                case 69:
                    pic2.Image = picture69.Image;
                    break;
                case 70:
                    pic2.Image = picture70.Image;
                    break;
                case 71:
                    pic2.Image = picture71.Image;
                    break;
                case 72:
                    pic2.Image = picture72.Image;
                    break;
                case 73:
                    pic2.Image = picture73.Image;
                    break;
                case 74:
                    pic2.Image = picture74.Image;
                    break;
                case 75:
                    pic2.Image = picture75.Image;
                    break;
                case 76:
                    pic2.Image = picture76.Image;
                    break;
                case 77:
                    pic2.Image = picture77.Image;
                    break;
                case 78:
                    pic2.Image = picture78.Image;
                    break;
                case 79:
                    pic2.Image = picture79.Image;
                    break;
                case 80:
                    pic2.Image = picture80.Image;
                    break;
                case 81:
                    pic2.Image = picture81.Image;
                    break;
                case 82:
                    pic2.Image = picture82.Image;
                    break;
                case 83:
                    pic2.Image = picture83.Image;
                    break;
                case 84:
                    pic2.Image = picture84.Image;
                    break;
                case 85:
                    pic2.Image = picture85.Image;
                    break;
                case 86:
                    pic2.Image = picture86.Image;
                    break;
                case 87:
                    pic2.Image = picture87.Image;
                    break;
                case 88:
                    pic2.Image = picture88.Image;
                    break;
                case 89:
                    pic2.Image = picture89.Image;
                    break;
                case 90:
                    pic2.Image = picture90.Image;
                    break;
                case 91:
                    pic2.Image = picture91.Image;
                    break;
                case 92:
                    pic2.Image = picture92.Image;
                    break;
                case 93:
                    pic2.Image = picture93.Image;
                    break;
                case 94:
                    pic2.Image = picture94.Image;
                    break;
                case 95:
                    pic2.Image = picture95.Image;
                    break;
                case 96:
                    pic2.Image = picture96.Image;
                    break;
                case 97:
                    pic2.Image = picture97.Image;
                    break;
                case 98:
                    pic2.Image = picture98.Image;
                    break;
                case 99:
                    pic2.Image = picture99.Image;
                    break;
                case 100:
                    pic2.Image = picture100.Image;
                    break;
                case 101:
                    pic2.Image = picture101.Image;
                    break;
                case 102:
                    pic2.Image = picture102.Image;
                    break;
                case 103:
                    pic2.Image = picture103.Image;
                    break;
                case 104:
                    pic2.Image = picture104.Image;
                    break;
                default:
                    pic2.Image = picture105.Image;
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
                case 12:
                    pic3.Image = picture12.Image;
                    break;
                case 13:
                    pic3.Image = picture13.Image;
                    break;
                case 14:
                    pic3.Image = picture14.Image;
                    break;
                case 15:
                    pic3.Image = picture15.Image;
                    break;
                case 16:
                    pic3.Image = picture16.Image;
                    break;
                case 17:
                    pic3.Image = picture17.Image;
                    break;
                case 18:
                    pic3.Image = picture18.Image;
                    break;
                case 19:
                    pic3.Image = picture19.Image;
                    break;
                case 20:
                    pic3.Image = picture20.Image;
                    break;
                case 21:
                    pic3.Image = picture21.Image;
                    break;
                case 22:
                    pic3.Image = picture22.Image;
                    break;
                case 23:
                    pic3.Image = picture23.Image;
                    break;
                case 24:
                    pic3.Image = picture24.Image;
                    break;
                case 25:
                    pic3.Image = picture25.Image;
                    break;
                case 26:
                    pic3.Image = picture26.Image;
                    break;
                case 27:
                    pic3.Image = picture27.Image;
                    break;
                case 28:
                    pic3.Image = picture28.Image;
                    break;
                case 29:
                    pic3.Image = picture29.Image;
                    break;
                case 30:
                    pic3.Image = picture30.Image;
                    break;
                case 31:
                    pic3.Image = picture31.Image;
                    break;
                case 32:
                    pic3.Image = picture32.Image;
                    break;
                case 33:
                    pic3.Image = picture33.Image;
                    break;
                case 34:
                    pic3.Image = picture34.Image;
                    break;
                case 35:
                    pic3.Image = picture35.Image;
                    break;
                case 36:
                    pic3.Image = picture36.Image;
                    break;
                case 37:
                    pic3.Image = picture37.Image;
                    break;
                case 38:
                    pic3.Image = picture38.Image;
                    break;
                case 39:
                    pic3.Image = picture39.Image;
                    break;
                case 40:
                    pic3.Image = picture40.Image;
                    break;
                case 41:
                    pic3.Image = picture41.Image;
                    break;
                case 42:
                    pic3.Image = picture42.Image;
                    break;
                case 43:
                    pic3.Image = picture43.Image;
                    break;
                case 44:
                    pic3.Image = picture44.Image;
                    break;
                case 45:
                    pic3.Image = picture45.Image;
                    break;
                case 46:
                    pic3.Image = picture46.Image;
                    break;
                case 47:
                    pic3.Image = picture47.Image;
                    break;
                case 48:
                    pic3.Image = picture48.Image;
                    break;
                case 49:
                    pic3.Image = picture49.Image;
                    break;
                case 50:
                    pic3.Image = picture50.Image;
                    break;
                case 51:
                    pic3.Image = picture51.Image;
                    break;
                case 52:
                    pic3.Image = picture52.Image;
                    break;
                case 53:
                    pic3.Image = picture53.Image;
                    break;
                case 54:
                    pic3.Image = picture54.Image;
                    break;
                case 55:
                    pic3.Image = picture55.Image;
                    break;
                case 56:
                    pic3.Image = picture56.Image;
                    break;
                case 57:
                    pic3.Image = picture57.Image;
                    break;
                case 58:
                    pic3.Image = picture58.Image;
                    break;
                case 59:
                    pic3.Image = picture59.Image;
                    break;
                case 60:
                    pic3.Image = picture60.Image;
                    break;
                case 61:
                    pic3.Image = picture61.Image;
                    break;
                case 62:
                    pic3.Image = picture62.Image;
                    break;
                case 63:
                    pic3.Image = picture63.Image;
                    break;
                case 64:
                    pic3.Image = picture64.Image;
                    break;
                case 65:
                    pic3.Image = picture65.Image;
                    break;
                case 66:
                    pic3.Image = picture66.Image;
                    break;
                case 67:
                    pic3.Image = picture67.Image;
                    break;
                case 68:
                    pic3.Image = picture68.Image;
                    break;
                case 69:
                    pic3.Image = picture69.Image;
                    break;
                case 70:
                    pic3.Image = picture70.Image;
                    break;
                case 71:
                    pic3.Image = picture71.Image;
                    break;
                case 72:
                    pic3.Image = picture72.Image;
                    break;
                case 73:
                    pic3.Image = picture73.Image;
                    break;
                case 74:
                    pic3.Image = picture74.Image;
                    break;
                case 75:
                    pic3.Image = picture75.Image;
                    break;
                case 76:
                    pic3.Image = picture76.Image;
                    break;
                case 77:
                    pic3.Image = picture77.Image;
                    break;
                case 78:
                    pic3.Image = picture78.Image;
                    break;
                case 79:
                    pic3.Image = picture79.Image;
                    break;
                case 80:
                    pic3.Image = picture80.Image;
                    break;
                case 81:
                    pic3.Image = picture81.Image;
                    break;
                case 82:
                    pic3.Image = picture82.Image;
                    break;
                case 83:
                    pic3.Image = picture83.Image;
                    break;
                case 84:
                    pic3.Image = picture84.Image;
                    break;
                case 85:
                    pic3.Image = picture85.Image;
                    break;
                case 86:
                    pic3.Image = picture86.Image;
                    break;
                case 87:
                    pic3.Image = picture87.Image;
                    break;
                case 88:
                    pic3.Image = picture88.Image;
                    break;
                case 89:
                    pic3.Image = picture89.Image;
                    break;
                case 90:
                    pic3.Image = picture90.Image;
                    break;
                case 91:
                    pic3.Image = picture91.Image;
                    break;
                case 92:
                    pic3.Image = picture92.Image;
                    break;
                case 93:
                    pic3.Image = picture93.Image;
                    break;
                case 94:
                    pic3.Image = picture94.Image;
                    break;
                case 95:
                    pic3.Image = picture95.Image;
                    break;
                case 96:
                    pic3.Image = picture96.Image;
                    break;
                case 97:
                    pic3.Image = picture97.Image;
                    break;
                case 98:
                    pic3.Image = picture98.Image;
                    break;
                case 99:
                    pic3.Image = picture99.Image;
                    break;
                case 100:
                    pic3.Image = picture100.Image;
                    break;
                case 101:
                    pic3.Image = picture101.Image;
                    break;
                case 102:
                    pic3.Image = picture102.Image;
                    break;
                case 103:
                    pic3.Image = picture103.Image;
                    break;
                case 104:
                    pic3.Image = picture104.Image;
                    break;
                default:
                    pic3.Image = picture105.Image;
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
                case 12:
                    pic4.Image = picture12.Image;
                    break;
                case 13:
                    pic4.Image = picture13.Image;
                    break;
                case 14:
                    pic4.Image = picture14.Image;
                    break;
                case 15:
                    pic4.Image = picture15.Image;
                    break;
                case 16:
                    pic4.Image = picture16.Image;
                    break;
                case 17:
                    pic4.Image = picture17.Image;
                    break;
                case 18:
                    pic4.Image = picture18.Image;
                    break;
                case 19:
                    pic4.Image = picture19.Image;
                    break;
                case 20:
                    pic4.Image = picture20.Image;
                    break;
                case 21:
                    pic4.Image = picture21.Image;
                    break;
                case 22:
                    pic4.Image = picture22.Image;
                    break;
                case 23:
                    pic4.Image = picture23.Image;
                    break;
                case 24:
                    pic4.Image = picture24.Image;
                    break;
                case 25:
                    pic4.Image = picture25.Image;
                    break;
                case 26:
                    pic4.Image = picture26.Image;
                    break;
                case 27:
                    pic4.Image = picture27.Image;
                    break;
                case 28:
                    pic4.Image = picture28.Image;
                    break;
                case 29:
                    pic4.Image = picture29.Image;
                    break;
                case 30:
                    pic4.Image = picture30.Image;
                    break;
                case 31:
                    pic4.Image = picture31.Image;
                    break;
                case 32:
                    pic4.Image = picture32.Image;
                    break;
                case 33:
                    pic4.Image = picture33.Image;
                    break;
                case 34:
                    pic4.Image = picture34.Image;
                    break;
                case 35:
                    pic4.Image = picture35.Image;
                    break;
                case 36:
                    pic4.Image = picture36.Image;
                    break;
                case 37:
                    pic4.Image = picture37.Image;
                    break;
                case 38:
                    pic4.Image = picture38.Image;
                    break;
                case 39:
                    pic4.Image = picture39.Image;
                    break;
                case 40:
                    pic4.Image = picture40.Image;
                    break;
                case 41:
                    pic4.Image = picture41.Image;
                    break;
                case 42:
                    pic4.Image = picture42.Image;
                    break;
                case 43:
                    pic4.Image = picture43.Image;
                    break;
                case 44:
                    pic4.Image = picture44.Image;
                    break;
                case 45:
                    pic4.Image = picture45.Image;
                    break;
                case 46:
                    pic4.Image = picture46.Image;
                    break;
                case 47:
                    pic4.Image = picture47.Image;
                    break;
                case 48:
                    pic4.Image = picture48.Image;
                    break;
                case 49:
                    pic4.Image = picture49.Image;
                    break;
                case 50:
                    pic4.Image = picture50.Image;
                    break;
                case 51:
                    pic4.Image = picture51.Image;
                    break;
                case 52:
                    pic4.Image = picture52.Image;
                    break;
                case 53:
                    pic4.Image = picture53.Image;
                    break;
                case 54:
                    pic4.Image = picture54.Image;
                    break;
                case 55:
                    pic4.Image = picture55.Image;
                    break;
                case 56:
                    pic4.Image = picture56.Image;
                    break;
                case 57:
                    pic4.Image = picture57.Image;
                    break;
                case 58:
                    pic4.Image = picture58.Image;
                    break;
                case 59:
                    pic4.Image = picture59.Image;
                    break;
                case 60:
                    pic4.Image = picture60.Image;
                    break;
                case 61:
                    pic4.Image = picture61.Image;
                    break;
                case 62:
                    pic4.Image = picture62.Image;
                    break;
                case 63:
                    pic4.Image = picture63.Image;
                    break;
                case 64:
                    pic4.Image = picture64.Image;
                    break;
                case 65:
                    pic4.Image = picture65.Image;
                    break;
                case 66:
                    pic4.Image = picture66.Image;
                    break;
                case 67:
                    pic4.Image = picture67.Image;
                    break;
                case 68:
                    pic4.Image = picture68.Image;
                    break;
                case 69:
                    pic4.Image = picture69.Image;
                    break;
                case 70:
                    pic4.Image = picture70.Image;
                    break;
                case 71:
                    pic4.Image = picture71.Image;
                    break;
                case 72:
                    pic4.Image = picture72.Image;
                    break;
                case 73:
                    pic4.Image = picture73.Image;
                    break;
                case 74:
                    pic4.Image = picture74.Image;
                    break;
                case 75:
                    pic4.Image = picture75.Image;
                    break;
                case 76:
                    pic4.Image = picture76.Image;
                    break;
                case 77:
                    pic4.Image = picture77.Image;
                    break;
                case 78:
                    pic4.Image = picture78.Image;
                    break;
                case 79:
                    pic4.Image = picture79.Image;
                    break;
                case 80:
                    pic4.Image = picture80.Image;
                    break;
                case 81:
                    pic4.Image = picture81.Image;
                    break;
                case 82:
                    pic4.Image = picture82.Image;
                    break;
                case 83:
                    pic4.Image = picture83.Image;
                    break;
                case 84:
                    pic4.Image = picture84.Image;
                    break;
                case 85:
                    pic4.Image = picture85.Image;
                    break;
                case 86:
                    pic4.Image = picture86.Image;
                    break;
                case 87:
                    pic4.Image = picture87.Image;
                    break;
                case 88:
                    pic4.Image = picture88.Image;
                    break;
                case 89:
                    pic4.Image = picture89.Image;
                    break;
                case 90:
                    pic4.Image = picture90.Image;
                    break;
                case 91:
                    pic4.Image = picture91.Image;
                    break;
                case 92:
                    pic4.Image = picture92.Image;
                    break;
                case 93:
                    pic4.Image = picture93.Image;
                    break;
                case 94:
                    pic4.Image = picture94.Image;
                    break;
                case 95:
                    pic4.Image = picture95.Image;
                    break;
                case 96:
                    pic4.Image = picture96.Image;
                    break;
                case 97:
                    pic4.Image = picture97.Image;
                    break;
                case 98:
                    pic4.Image = picture98.Image;
                    break;
                case 99:
                    pic4.Image = picture99.Image;
                    break;
                case 100:
                    pic4.Image = picture100.Image;
                    break;
                case 101:
                    pic4.Image = picture101.Image;
                    break;
                case 102:
                    pic4.Image = picture102.Image;
                    break;
                case 103:
                    pic4.Image = picture103.Image;
                    break;
                case 104:
                    pic4.Image = picture104.Image;
                    break;
                default:
                    pic4.Image = picture105.Image;
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
                case 12:
                    pic5.Image = picture12.Image;
                    break;
                case 13:
                    pic5.Image = picture13.Image;
                    break;
                case 14:
                    pic5.Image = picture14.Image;
                    break;
                case 15:
                    pic5.Image = picture15.Image;
                    break;
                case 16:
                    pic5.Image = picture16.Image;
                    break;
                case 17:
                    pic5.Image = picture17.Image;
                    break;
                case 18:
                    pic5.Image = picture18.Image;
                    break;
                case 19:
                    pic5.Image = picture19.Image;
                    break;
                case 20:
                    pic5.Image = picture20.Image;
                    break;
                case 21:
                    pic5.Image = picture21.Image;
                    break;
                case 22:
                    pic5.Image = picture22.Image;
                    break;
                case 23:
                    pic5.Image = picture23.Image;
                    break;
                case 24:
                    pic5.Image = picture24.Image;
                    break;
                case 25:
                    pic5.Image = picture25.Image;
                    break;
                case 26:
                    pic5.Image = picture26.Image;
                    break;
                case 27:
                    pic5.Image = picture27.Image;
                    break;
                case 28:
                    pic5.Image = picture28.Image;
                    break;
                case 29:
                    pic5.Image = picture29.Image;
                    break;
                case 30:
                    pic5.Image = picture30.Image;
                    break;
                case 31:
                    pic5.Image = picture31.Image;
                    break;
                case 32:
                    pic5.Image = picture32.Image;
                    break;
                case 33:
                    pic5.Image = picture33.Image;
                    break;
                case 34:
                    pic5.Image = picture34.Image;
                    break;
                case 35:
                    pic5.Image = picture35.Image;
                    break;
                case 36:
                    pic5.Image = picture36.Image;
                    break;
                case 37:
                    pic5.Image = picture37.Image;
                    break;
                case 38:
                    pic5.Image = picture38.Image;
                    break;
                case 39:
                    pic5.Image = picture39.Image;
                    break;
                case 40:
                    pic5.Image = picture40.Image;
                    break;
                case 41:
                    pic5.Image = picture41.Image;
                    break;
                case 42:
                    pic5.Image = picture42.Image;
                    break;
                case 43:
                    pic5.Image = picture43.Image;
                    break;
                case 44:
                    pic5.Image = picture44.Image;
                    break;
                case 45:
                    pic5.Image = picture45.Image;
                    break;
                case 46:
                    pic5.Image = picture46.Image;
                    break;
                case 47:
                    pic5.Image = picture47.Image;
                    break;
                case 48:
                    pic5.Image = picture48.Image;
                    break;
                case 49:
                    pic5.Image = picture49.Image;
                    break;
                case 50:
                    pic5.Image = picture50.Image;
                    break;
                case 51:
                    pic5.Image = picture51.Image;
                    break;
                case 52:
                    pic5.Image = picture52.Image;
                    break;
                case 53:
                    pic5.Image = picture53.Image;
                    break;
                case 54:
                    pic5.Image = picture54.Image;
                    break;
                case 55:
                    pic5.Image = picture55.Image;
                    break;
                case 56:
                    pic5.Image = picture56.Image;
                    break;
                case 57:
                    pic5.Image = picture57.Image;
                    break;
                case 58:
                    pic5.Image = picture58.Image;
                    break;
                case 59:
                    pic5.Image = picture59.Image;
                    break;
                case 60:
                    pic5.Image = picture60.Image;
                    break;
                case 61:
                    pic5.Image = picture61.Image;
                    break;
                case 62:
                    pic5.Image = picture62.Image;
                    break;
                case 63:
                    pic5.Image = picture63.Image;
                    break;
                case 64:
                    pic5.Image = picture64.Image;
                    break;
                case 65:
                    pic5.Image = picture65.Image;
                    break;
                case 66:
                    pic5.Image = picture66.Image;
                    break;
                case 67:
                    pic5.Image = picture67.Image;
                    break;
                case 68:
                    pic5.Image = picture68.Image;
                    break;
                case 69:
                    pic5.Image = picture69.Image;
                    break;
                case 70:
                    pic5.Image = picture70.Image;
                    break;
                case 71:
                    pic5.Image = picture71.Image;
                    break;
                case 72:
                    pic5.Image = picture72.Image;
                    break;
                case 73:
                    pic5.Image = picture73.Image;
                    break;
                case 74:
                    pic5.Image = picture74.Image;
                    break;
                case 75:
                    pic5.Image = picture75.Image;
                    break;
                case 76:
                    pic5.Image = picture76.Image;
                    break;
                case 77:
                    pic5.Image = picture77.Image;
                    break;
                case 78:
                    pic5.Image = picture78.Image;
                    break;
                case 79:
                    pic5.Image = picture79.Image;
                    break;
                case 80:
                    pic5.Image = picture80.Image;
                    break;
                case 81:
                    pic5.Image = picture81.Image;
                    break;
                case 82:
                    pic5.Image = picture82.Image;
                    break;
                case 83:
                    pic5.Image = picture83.Image;
                    break;
                case 84:
                    pic5.Image = picture84.Image;
                    break;
                case 85:
                    pic5.Image = picture85.Image;
                    break;
                case 86:
                    pic5.Image = picture86.Image;
                    break;
                case 87:
                    pic5.Image = picture87.Image;
                    break;
                case 88:
                    pic5.Image = picture88.Image;
                    break;
                case 89:
                    pic5.Image = picture89.Image;
                    break;
                case 90:
                    pic5.Image = picture90.Image;
                    break;
                case 91:
                    pic5.Image = picture91.Image;
                    break;
                case 92:
                    pic5.Image = picture92.Image;
                    break;
                case 93:
                    pic5.Image = picture93.Image;
                    break;
                case 94:
                    pic5.Image = picture94.Image;
                    break;
                case 95:
                    pic5.Image = picture95.Image;
                    break;
                case 96:
                    pic5.Image = picture96.Image;
                    break;
                case 97:
                    pic5.Image = picture97.Image;
                    break;
                case 98:
                    pic5.Image = picture98.Image;
                    break;
                case 99:
                    pic5.Image = picture99.Image;
                    break;
                case 100:
                    pic5.Image = picture100.Image;
                    break;
                case 101:
                    pic5.Image = picture101.Image;
                    break;
                case 102:
                    pic5.Image = picture102.Image;
                    break;
                case 103:
                    pic5.Image = picture103.Image;
                    break;
                case 104:
                    pic5.Image = picture104.Image;
                    break;
                default:
                    pic5.Image = picture105.Image;
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
                case 12:
                    pic6.Image = picture12.Image;
                    break;
                case 13:
                    pic6.Image = picture13.Image;
                    break;
                case 14:
                    pic6.Image = picture14.Image;
                    break;
                case 15:
                    pic6.Image = picture15.Image;
                    break;
                case 16:
                    pic6.Image = picture16.Image;
                    break;
                case 17:
                    pic6.Image = picture17.Image;
                    break;
                case 18:
                    pic6.Image = picture18.Image;
                    break;
                case 19:
                    pic6.Image = picture19.Image;
                    break;
                case 20:
                    pic6.Image = picture20.Image;
                    break;
                case 21:
                    pic6.Image = picture21.Image;
                    break;
                case 22:
                    pic6.Image = picture22.Image;
                    break;
                case 23:
                    pic6.Image = picture23.Image;
                    break;
                case 24:
                    pic6.Image = picture24.Image;
                    break;
                case 25:
                    pic6.Image = picture25.Image;
                    break;
                case 26:
                    pic6.Image = picture26.Image;
                    break;
                case 27:
                    pic6.Image = picture27.Image;
                    break;
                case 28:
                    pic6.Image = picture28.Image;
                    break;
                case 29:
                    pic6.Image = picture29.Image;
                    break;
                case 30:
                    pic6.Image = picture30.Image;
                    break;
                case 31:
                    pic6.Image = picture31.Image;
                    break;
                case 32:
                    pic6.Image = picture32.Image;
                    break;
                case 33:
                    pic6.Image = picture33.Image;
                    break;
                case 34:
                    pic6.Image = picture34.Image;
                    break;
                case 35:
                    pic6.Image = picture35.Image;
                    break;
                case 36:
                    pic6.Image = picture36.Image;
                    break;
                case 37:
                    pic6.Image = picture37.Image;
                    break;
                case 38:
                    pic6.Image = picture38.Image;
                    break;
                case 39:
                    pic6.Image = picture39.Image;
                    break;
                case 40:
                    pic6.Image = picture40.Image;
                    break;
                case 41:
                    pic6.Image = picture41.Image;
                    break;
                case 42:
                    pic6.Image = picture42.Image;
                    break;
                case 43:
                    pic6.Image = picture43.Image;
                    break;
                case 44:
                    pic6.Image = picture44.Image;
                    break;
                case 45:
                    pic6.Image = picture45.Image;
                    break;
                case 46:
                    pic6.Image = picture46.Image;
                    break;
                case 47:
                    pic6.Image = picture47.Image;
                    break;
                case 48:
                    pic6.Image = picture48.Image;
                    break;
                case 49:
                    pic6.Image = picture49.Image;
                    break;
                case 50:
                    pic6.Image = picture50.Image;
                    break;
                case 51:
                    pic6.Image = picture51.Image;
                    break;
                case 52:
                    pic6.Image = picture52.Image;
                    break;
                case 53:
                    pic6.Image = picture53.Image;
                    break;
                case 54:
                    pic6.Image = picture54.Image;
                    break;
                case 55:
                    pic6.Image = picture55.Image;
                    break;
                case 56:
                    pic6.Image = picture56.Image;
                    break;
                case 57:
                    pic6.Image = picture57.Image;
                    break;
                case 58:
                    pic6.Image = picture58.Image;
                    break;
                case 59:
                    pic6.Image = picture59.Image;
                    break;
                case 60:
                    pic6.Image = picture60.Image;
                    break;
                case 61:
                    pic6.Image = picture61.Image;
                    break;
                case 62:
                    pic6.Image = picture62.Image;
                    break;
                case 63:
                    pic6.Image = picture63.Image;
                    break;
                case 64:
                    pic6.Image = picture64.Image;
                    break;
                case 65:
                    pic6.Image = picture65.Image;
                    break;
                case 66:
                    pic6.Image = picture66.Image;
                    break;
                case 67:
                    pic6.Image = picture67.Image;
                    break;
                case 68:
                    pic6.Image = picture68.Image;
                    break;
                case 69:
                    pic6.Image = picture69.Image;
                    break;
                case 70:
                    pic6.Image = picture70.Image;
                    break;
                case 71:
                    pic6.Image = picture71.Image;
                    break;
                case 72:
                    pic6.Image = picture72.Image;
                    break;
                case 73:
                    pic6.Image = picture73.Image;
                    break;
                case 74:
                    pic6.Image = picture74.Image;
                    break;
                case 75:
                    pic6.Image = picture75.Image;
                    break;
                case 76:
                    pic6.Image = picture76.Image;
                    break;
                case 77:
                    pic6.Image = picture77.Image;
                    break;
                case 78:
                    pic6.Image = picture78.Image;
                    break;
                case 79:
                    pic6.Image = picture79.Image;
                    break;
                case 80:
                    pic6.Image = picture80.Image;
                    break;
                case 81:
                    pic6.Image = picture81.Image;
                    break;
                case 82:
                    pic6.Image = picture82.Image;
                    break;
                case 83:
                    pic6.Image = picture83.Image;
                    break;
                case 84:
                    pic6.Image = picture84.Image;
                    break;
                case 85:
                    pic6.Image = picture85.Image;
                    break;
                case 86:
                    pic6.Image = picture86.Image;
                    break;
                case 87:
                    pic6.Image = picture87.Image;
                    break;
                case 88:
                    pic6.Image = picture88.Image;
                    break;
                case 89:
                    pic6.Image = picture89.Image;
                    break;
                case 90:
                    pic6.Image = picture90.Image;
                    break;
                case 91:
                    pic6.Image = picture91.Image;
                    break;
                case 92:
                    pic6.Image = picture92.Image;
                    break;
                case 93:
                    pic6.Image = picture93.Image;
                    break;
                case 94:
                    pic6.Image = picture94.Image;
                    break;
                case 95:
                    pic6.Image = picture95.Image;
                    break;
                case 96:
                    pic6.Image = picture96.Image;
                    break;
                case 97:
                    pic6.Image = picture97.Image;
                    break;
                case 98:
                    pic6.Image = picture98.Image;
                    break;
                case 99:
                    pic6.Image = picture99.Image;
                    break;
                case 100:
                    pic6.Image = picture100.Image;
                    break;
                case 101:
                    pic6.Image = picture101.Image;
                    break;
                case 102:
                    pic6.Image = picture102.Image;
                    break;
                case 103:
                    pic6.Image = picture103.Image;
                    break;
                case 104:
                    pic6.Image = picture104.Image;
                    break;
                default:
                    pic6.Image = picture105.Image;
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
                case 12:
                    pic7.Image = picture12.Image;
                    break;
                case 13:
                    pic7.Image = picture13.Image;
                    break;
                case 14:
                    pic7.Image = picture14.Image;
                    break;
                case 15:
                    pic7.Image = picture15.Image;
                    break;
                case 16:
                    pic7.Image = picture16.Image;
                    break;
                case 17:
                    pic7.Image = picture17.Image;
                    break;
                case 18:
                    pic7.Image = picture18.Image;
                    break;
                case 19:
                    pic7.Image = picture19.Image;
                    break;
                case 20:
                    pic7.Image = picture20.Image;
                    break;
                case 21:
                    pic7.Image = picture21.Image;
                    break;
                case 22:
                    pic7.Image = picture22.Image;
                    break;
                case 23:
                    pic7.Image = picture23.Image;
                    break;
                case 24:
                    pic7.Image = picture24.Image;
                    break;
                case 25:
                    pic7.Image = picture25.Image;
                    break;
                case 26:
                    pic7.Image = picture26.Image;
                    break;
                case 27:
                    pic7.Image = picture27.Image;
                    break;
                case 28:
                    pic7.Image = picture28.Image;
                    break;
                case 29:
                    pic7.Image = picture29.Image;
                    break;
                case 30:
                    pic7.Image = picture30.Image;
                    break;
                case 31:
                    pic7.Image = picture31.Image;
                    break;
                case 32:
                    pic7.Image = picture32.Image;
                    break;
                case 33:
                    pic7.Image = picture33.Image;
                    break;
                case 34:
                    pic7.Image = picture34.Image;
                    break;
                case 35:
                    pic7.Image = picture35.Image;
                    break;
                case 36:
                    pic7.Image = picture36.Image;
                    break;
                case 37:
                    pic7.Image = picture37.Image;
                    break;
                case 38:
                    pic7.Image = picture38.Image;
                    break;
                case 39:
                    pic7.Image = picture39.Image;
                    break;
                case 40:
                    pic7.Image = picture40.Image;
                    break;
                case 41:
                    pic7.Image = picture41.Image;
                    break;
                case 42:
                    pic7.Image = picture42.Image;
                    break;
                case 43:
                    pic7.Image = picture43.Image;
                    break;
                case 44:
                    pic7.Image = picture44.Image;
                    break;
                case 45:
                    pic7.Image = picture45.Image;
                    break;
                case 46:
                    pic7.Image = picture46.Image;
                    break;
                case 47:
                    pic7.Image = picture47.Image;
                    break;
                case 48:
                    pic7.Image = picture48.Image;
                    break;
                case 49:
                    pic7.Image = picture49.Image;
                    break;
                case 50:
                    pic7.Image = picture50.Image;
                    break;
                case 51:
                    pic7.Image = picture51.Image;
                    break;
                case 52:
                    pic7.Image = picture52.Image;
                    break;
                case 53:
                    pic7.Image = picture53.Image;
                    break;
                case 54:
                    pic7.Image = picture54.Image;
                    break;
                case 55:
                    pic7.Image = picture55.Image;
                    break;
                case 56:
                    pic7.Image = picture56.Image;
                    break;
                case 57:
                    pic7.Image = picture57.Image;
                    break;
                case 58:
                    pic7.Image = picture58.Image;
                    break;
                case 59:
                    pic7.Image = picture59.Image;
                    break;
                case 60:
                    pic7.Image = picture60.Image;
                    break;
                case 61:
                    pic7.Image = picture61.Image;
                    break;
                case 62:
                    pic7.Image = picture62.Image;
                    break;
                case 63:
                    pic7.Image = picture63.Image;
                    break;
                case 64:
                    pic7.Image = picture64.Image;
                    break;
                case 65:
                    pic7.Image = picture65.Image;
                    break;
                case 66:
                    pic7.Image = picture66.Image;
                    break;
                case 67:
                    pic7.Image = picture67.Image;
                    break;
                case 68:
                    pic7.Image = picture68.Image;
                    break;
                case 69:
                    pic7.Image = picture69.Image;
                    break;
                case 70:
                    pic7.Image = picture70.Image;
                    break;
                case 71:
                    pic7.Image = picture71.Image;
                    break;
                case 72:
                    pic7.Image = picture72.Image;
                    break;
                case 73:
                    pic7.Image = picture73.Image;
                    break;
                case 74:
                    pic7.Image = picture74.Image;
                    break;
                case 75:
                    pic7.Image = picture75.Image;
                    break;
                case 76:
                    pic7.Image = picture76.Image;
                    break;
                case 77:
                    pic7.Image = picture77.Image;
                    break;
                case 78:
                    pic7.Image = picture78.Image;
                    break;
                case 79:
                    pic7.Image = picture79.Image;
                    break;
                case 80:
                    pic7.Image = picture80.Image;
                    break;
                case 81:
                    pic7.Image = picture81.Image;
                    break;
                case 82:
                    pic7.Image = picture82.Image;
                    break;
                case 83:
                    pic7.Image = picture83.Image;
                    break;
                case 84:
                    pic7.Image = picture84.Image;
                    break;
                case 85:
                    pic7.Image = picture85.Image;
                    break;
                case 86:
                    pic7.Image = picture86.Image;
                    break;
                case 87:
                    pic7.Image = picture87.Image;
                    break;
                case 88:
                    pic7.Image = picture88.Image;
                    break;
                case 89:
                    pic7.Image = picture89.Image;
                    break;
                case 90:
                    pic7.Image = picture90.Image;
                    break;
                case 91:
                    pic7.Image = picture91.Image;
                    break;
                case 92:
                    pic7.Image = picture92.Image;
                    break;
                case 93:
                    pic7.Image = picture93.Image;
                    break;
                case 94:
                    pic7.Image = picture94.Image;
                    break;
                case 95:
                    pic7.Image = picture95.Image;
                    break;
                case 96:
                    pic7.Image = picture96.Image;
                    break;
                case 97:
                    pic7.Image = picture97.Image;
                    break;
                case 98:
                    pic7.Image = picture98.Image;
                    break;
                case 99:
                    pic7.Image = picture99.Image;
                    break;
                case 100:
                    pic7.Image = picture100.Image;
                    break;
                case 101:
                    pic7.Image = picture101.Image;
                    break;
                case 102:
                    pic7.Image = picture102.Image;
                    break;
                case 103:
                    pic7.Image = picture103.Image;
                    break;
                case 104:
                    pic7.Image = picture104.Image;
                    break;
                default:
                    pic7.Image = picture105.Image;
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
                case 12:
                    pic8.Image = picture12.Image;
                    break;
                case 13:
                    pic8.Image = picture13.Image;
                    break;
                case 14:
                    pic8.Image = picture14.Image;
                    break;
                case 15:
                    pic8.Image = picture15.Image;
                    break;
                case 16:
                    pic8.Image = picture16.Image;
                    break;
                case 17:
                    pic8.Image = picture17.Image;
                    break;
                case 18:
                    pic8.Image = picture18.Image;
                    break;
                case 19:
                    pic8.Image = picture19.Image;
                    break;
                case 20:
                    pic8.Image = picture20.Image;
                    break;
                case 21:
                    pic8.Image = picture21.Image;
                    break;
                case 22:
                    pic8.Image = picture22.Image;
                    break;
                case 23:
                    pic8.Image = picture23.Image;
                    break;
                case 24:
                    pic8.Image = picture24.Image;
                    break;
                case 25:
                    pic8.Image = picture25.Image;
                    break;
                case 26:
                    pic8.Image = picture26.Image;
                    break;
                case 27:
                    pic8.Image = picture27.Image;
                    break;
                case 28:
                    pic8.Image = picture28.Image;
                    break;
                case 29:
                    pic8.Image = picture29.Image;
                    break;
                case 30:
                    pic8.Image = picture30.Image;
                    break;
                case 31:
                    pic8.Image = picture31.Image;
                    break;
                case 32:
                    pic8.Image = picture32.Image;
                    break;
                case 33:
                    pic8.Image = picture33.Image;
                    break;
                case 34:
                    pic8.Image = picture34.Image;
                    break;
                case 35:
                    pic8.Image = picture35.Image;
                    break;
                case 36:
                    pic8.Image = picture36.Image;
                    break;
                case 37:
                    pic8.Image = picture37.Image;
                    break;
                case 38:
                    pic8.Image = picture38.Image;
                    break;
                case 39:
                    pic8.Image = picture39.Image;
                    break;
                case 40:
                    pic8.Image = picture40.Image;
                    break;
                case 41:
                    pic8.Image = picture41.Image;
                    break;
                case 42:
                    pic8.Image = picture42.Image;
                    break;
                case 43:
                    pic8.Image = picture43.Image;
                    break;
                case 44:
                    pic8.Image = picture44.Image;
                    break;
                case 45:
                    pic8.Image = picture45.Image;
                    break;
                case 46:
                    pic8.Image = picture46.Image;
                    break;
                case 47:
                    pic8.Image = picture47.Image;
                    break;
                case 48:
                    pic8.Image = picture48.Image;
                    break;
                case 49:
                    pic8.Image = picture49.Image;
                    break;
                case 50:
                    pic8.Image = picture50.Image;
                    break;
                case 51:
                    pic8.Image = picture51.Image;
                    break;
                case 52:
                    pic8.Image = picture52.Image;
                    break;
                case 53:
                    pic8.Image = picture53.Image;
                    break;
                case 54:
                    pic8.Image = picture54.Image;
                    break;
                case 55:
                    pic8.Image = picture55.Image;
                    break;
                case 56:
                    pic8.Image = picture56.Image;
                    break;
                case 57:
                    pic8.Image = picture57.Image;
                    break;
                case 58:
                    pic8.Image = picture58.Image;
                    break;
                case 59:
                    pic8.Image = picture59.Image;
                    break;
                case 60:
                    pic8.Image = picture60.Image;
                    break;
                case 61:
                    pic8.Image = picture61.Image;
                    break;
                case 62:
                    pic8.Image = picture62.Image;
                    break;
                case 63:
                    pic8.Image = picture63.Image;
                    break;
                case 64:
                    pic8.Image = picture64.Image;
                    break;
                case 65:
                    pic8.Image = picture65.Image;
                    break;
                case 66:
                    pic8.Image = picture66.Image;
                    break;
                case 67:
                    pic8.Image = picture67.Image;
                    break;
                case 68:
                    pic8.Image = picture68.Image;
                    break;
                case 69:
                    pic8.Image = picture69.Image;
                    break;
                case 70:
                    pic8.Image = picture70.Image;
                    break;
                case 71:
                    pic8.Image = picture71.Image;
                    break;
                case 72:
                    pic8.Image = picture72.Image;
                    break;
                case 73:
                    pic8.Image = picture73.Image;
                    break;
                case 74:
                    pic8.Image = picture74.Image;
                    break;
                case 75:
                    pic8.Image = picture75.Image;
                    break;
                case 76:
                    pic8.Image = picture76.Image;
                    break;
                case 77:
                    pic8.Image = picture77.Image;
                    break;
                case 78:
                    pic8.Image = picture78.Image;
                    break;
                case 79:
                    pic8.Image = picture79.Image;
                    break;
                case 80:
                    pic8.Image = picture80.Image;
                    break;
                case 81:
                    pic8.Image = picture81.Image;
                    break;
                case 82:
                    pic8.Image = picture82.Image;
                    break;
                case 83:
                    pic8.Image = picture83.Image;
                    break;
                case 84:
                    pic8.Image = picture84.Image;
                    break;
                case 85:
                    pic8.Image = picture85.Image;
                    break;
                case 86:
                    pic8.Image = picture86.Image;
                    break;
                case 87:
                    pic8.Image = picture87.Image;
                    break;
                case 88:
                    pic8.Image = picture88.Image;
                    break;
                case 89:
                    pic8.Image = picture89.Image;
                    break;
                case 90:
                    pic8.Image = picture90.Image;
                    break;
                case 91:
                    pic8.Image = picture91.Image;
                    break;
                case 92:
                    pic8.Image = picture92.Image;
                    break;
                case 93:
                    pic8.Image = picture93.Image;
                    break;
                case 94:
                    pic8.Image = picture94.Image;
                    break;
                case 95:
                    pic8.Image = picture95.Image;
                    break;
                case 96:
                    pic8.Image = picture96.Image;
                    break;
                case 97:
                    pic8.Image = picture97.Image;
                    break;
                case 98:
                    pic8.Image = picture98.Image;
                    break;
                case 99:
                    pic8.Image = picture99.Image;
                    break;
                case 100:
                    pic8.Image = picture100.Image;
                    break;
                case 101:
                    pic8.Image = picture101.Image;
                    break;
                case 102:
                    pic8.Image = picture102.Image;
                    break;
                case 103:
                    pic8.Image = picture103.Image;
                    break;
                case 104:
                    pic8.Image = picture104.Image;
                    break;
                default:
                    pic8.Image = picture105.Image;
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
                case 7:
                    pic9.Image = picture7.Image;
                    break;
                case 8:
                    pic9.Image = picture8.Image;
                    break;
                case 9:
                    pic9.Image = picture9.Image;
                    break;
                case 10:
                    pic9.Image = picture10.Image;
                    break;
                case 11:
                    pic9.Image = picture11.Image;
                    break;
                case 12:
                    pic9.Image = picture12.Image;
                    break;
                case 13:
                    pic9.Image = picture13.Image;
                    break;
                case 14:
                    pic9.Image = picture14.Image;
                    break;
                case 15:
                    pic9.Image = picture15.Image;
                    break;
                case 16:
                    pic9.Image = picture16.Image;
                    break;
                case 17:
                    pic9.Image = picture17.Image;
                    break;
                case 18:
                    pic9.Image = picture18.Image;
                    break;
                case 19:
                    pic9.Image = picture19.Image;
                    break;
                case 20:
                    pic9.Image = picture20.Image;
                    break;
                case 21:
                    pic9.Image = picture21.Image;
                    break;
                case 22:
                    pic9.Image = picture22.Image;
                    break;
                case 23:
                    pic9.Image = picture23.Image;
                    break;
                case 24:
                    pic9.Image = picture24.Image;
                    break;
                case 25:
                    pic9.Image = picture25.Image;
                    break;
                case 26:
                    pic9.Image = picture26.Image;
                    break;
                case 27:
                    pic9.Image = picture27.Image;
                    break;
                case 28:
                    pic9.Image = picture28.Image;
                    break;
                case 29:
                    pic9.Image = picture29.Image;
                    break;
                case 30:
                    pic9.Image = picture30.Image;
                    break;
                case 31:
                    pic9.Image = picture31.Image;
                    break;
                case 32:
                    pic9.Image = picture32.Image;
                    break;
                case 33:
                    pic9.Image = picture33.Image;
                    break;
                case 34:
                    pic9.Image = picture34.Image;
                    break;
                case 35:
                    pic9.Image = picture35.Image;
                    break;
                case 36:
                    pic9.Image = picture36.Image;
                    break;
                case 37:
                    pic9.Image = picture37.Image;
                    break;
                case 38:
                    pic9.Image = picture38.Image;
                    break;
                case 39:
                    pic9.Image = picture39.Image;
                    break;
                case 40:
                    pic9.Image = picture40.Image;
                    break;
                case 41:
                    pic9.Image = picture41.Image;
                    break;
                case 42:
                    pic9.Image = picture42.Image;
                    break;
                case 43:
                    pic9.Image = picture43.Image;
                    break;
                case 44:
                    pic9.Image = picture44.Image;
                    break;
                case 45:
                    pic9.Image = picture45.Image;
                    break;
                case 46:
                    pic9.Image = picture46.Image;
                    break;
                case 47:
                    pic9.Image = picture47.Image;
                    break;
                case 48:
                    pic9.Image = picture48.Image;
                    break;
                case 49:
                    pic9.Image = picture49.Image;
                    break;
                case 50:
                    pic9.Image = picture50.Image;
                    break;
                case 51:
                    pic9.Image = picture51.Image;
                    break;
                case 52:
                    pic9.Image = picture52.Image;
                    break;
                case 53:
                    pic9.Image = picture53.Image;
                    break;
                case 54:
                    pic9.Image = picture54.Image;
                    break;
                case 55:
                    pic9.Image = picture55.Image;
                    break;
                case 56:
                    pic9.Image = picture56.Image;
                    break;
                case 57:
                    pic9.Image = picture57.Image;
                    break;
                case 58:
                    pic9.Image = picture58.Image;
                    break;
                case 59:
                    pic9.Image = picture59.Image;
                    break;
                case 60:
                    pic9.Image = picture60.Image;
                    break;
                case 61:
                    pic9.Image = picture61.Image;
                    break;
                case 62:
                    pic9.Image = picture62.Image;
                    break;
                case 63:
                    pic9.Image = picture63.Image;
                    break;
                case 64:
                    pic9.Image = picture64.Image;
                    break;
                case 65:
                    pic9.Image = picture65.Image;
                    break;
                case 66:
                    pic9.Image = picture66.Image;
                    break;
                case 67:
                    pic9.Image = picture67.Image;
                    break;
                case 68:
                    pic9.Image = picture68.Image;
                    break;
                case 69:
                    pic9.Image = picture69.Image;
                    break;
                case 70:
                    pic9.Image = picture70.Image;
                    break;
                case 71:
                    pic9.Image = picture71.Image;
                    break;
                case 72:
                    pic9.Image = picture72.Image;
                    break;
                case 73:
                    pic9.Image = picture73.Image;
                    break;
                case 74:
                    pic9.Image = picture74.Image;
                    break;
                case 75:
                    pic9.Image = picture75.Image;
                    break;
                case 76:
                    pic9.Image = picture76.Image;
                    break;
                case 77:
                    pic9.Image = picture77.Image;
                    break;
                case 78:
                    pic9.Image = picture78.Image;
                    break;
                case 79:
                    pic9.Image = picture79.Image;
                    break;
                case 80:
                    pic9.Image = picture80.Image;
                    break;
                case 81:
                    pic9.Image = picture81.Image;
                    break;
                case 82:
                    pic9.Image = picture82.Image;
                    break;
                case 83:
                    pic9.Image = picture83.Image;
                    break;
                case 84:
                    pic9.Image = picture84.Image;
                    break;
                case 85:
                    pic9.Image = picture85.Image;
                    break;
                case 86:
                    pic9.Image = picture86.Image;
                    break;
                case 87:
                    pic9.Image = picture87.Image;
                    break;
                case 88:
                    pic9.Image = picture88.Image;
                    break;
                case 89:
                    pic9.Image = picture89.Image;
                    break;
                case 90:
                    pic9.Image = picture90.Image;
                    break;
                case 91:
                    pic9.Image = picture91.Image;
                    break;
                case 92:
                    pic9.Image = picture92.Image;
                    break;
                case 93:
                    pic9.Image = picture93.Image;
                    break;
                case 94:
                    pic9.Image = picture94.Image;
                    break;
                case 95:
                    pic9.Image = picture95.Image;
                    break;
                case 96:
                    pic9.Image = picture96.Image;
                    break;
                case 97:
                    pic9.Image = picture97.Image;
                    break;
                case 98:
                    pic9.Image = picture98.Image;
                    break;
                case 99:
                    pic9.Image = picture99.Image;
                    break;
                case 100:
                    pic9.Image = picture100.Image;
                    break;
                case 101:
                    pic9.Image = picture101.Image;
                    break;
                case 102:
                    pic9.Image = picture102.Image;
                    break;
                case 103:
                    pic9.Image = picture103.Image;
                    break;
                case 104:
                    pic9.Image = picture104.Image;
                    break;
                default:
                    pic9.Image = picture105.Image;
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
                case 7:
                    pica.Image = picture7.Image;
                    break;
                case 8:
                    pica.Image = picture8.Image;
                    break;
                case 9:
                    pica.Image = picture9.Image;
                    break;
                case 10:
                    pica.Image = picture10.Image;
                    break;
                case 11:
                    pica.Image = picture11.Image;
                    break;
                case 12:
                    pica.Image = picture12.Image;
                    break;
                case 13:
                    pica.Image = picture13.Image;
                    break;
                case 14:
                    pica.Image = picture14.Image;
                    break;
                case 15:
                    pica.Image = picture15.Image;
                    break;
                case 16:
                    pica.Image = picture16.Image;
                    break;
                case 17:
                    pica.Image = picture17.Image;
                    break;
                case 18:
                    pica.Image = picture18.Image;
                    break;
                case 19:
                    pica.Image = picture19.Image;
                    break;
                case 20:
                    pica.Image = picture20.Image;
                    break;
                case 21:
                    pica.Image = picture21.Image;
                    break;
                case 22:
                    pica.Image = picture22.Image;
                    break;
                case 23:
                    pica.Image = picture23.Image;
                    break;
                case 24:
                    pica.Image = picture24.Image;
                    break;
                case 25:
                    pica.Image = picture25.Image;
                    break;
                case 26:
                    pica.Image = picture26.Image;
                    break;
                case 27:
                    pica.Image = picture27.Image;
                    break;
                case 28:
                    pica.Image = picture28.Image;
                    break;
                case 29:
                    pica.Image = picture29.Image;
                    break;
                case 30:
                    pica.Image = picture30.Image;
                    break;
                case 31:
                    pica.Image = picture31.Image;
                    break;
                case 32:
                    pica.Image = picture32.Image;
                    break;
                case 33:
                    pica.Image = picture33.Image;
                    break;
                case 34:
                    pica.Image = picture34.Image;
                    break;
                case 35:
                    pica.Image = picture35.Image;
                    break;
                case 36:
                    pica.Image = picture36.Image;
                    break;
                case 37:
                    pica.Image = picture37.Image;
                    break;
                case 38:
                    pica.Image = picture38.Image;
                    break;
                case 39:
                    pica.Image = picture39.Image;
                    break;
                case 40:
                    pica.Image = picture40.Image;
                    break;
                case 41:
                    pica.Image = picture41.Image;
                    break;
                case 42:
                    pica.Image = picture42.Image;
                    break;
                case 43:
                    pica.Image = picture43.Image;
                    break;
                case 44:
                    pica.Image = picture44.Image;
                    break;
                case 45:
                    pica.Image = picture45.Image;
                    break;
                case 46:
                    pica.Image = picture46.Image;
                    break;
                case 47:
                    pica.Image = picture47.Image;
                    break;
                case 48:
                    pica.Image = picture48.Image;
                    break;
                case 49:
                    pica.Image = picture49.Image;
                    break;
                case 50:
                    pica.Image = picture50.Image;
                    break;
                case 51:
                    pica.Image = picture51.Image;
                    break;
                case 52:
                    pica.Image = picture52.Image;
                    break;
                case 53:
                    pica.Image = picture53.Image;
                    break;
                case 54:
                    pica.Image = picture54.Image;
                    break;
                case 55:
                    pica.Image = picture55.Image;
                    break;
                case 56:
                    pica.Image = picture56.Image;
                    break;
                case 57:
                    pica.Image = picture57.Image;
                    break;
                case 58:
                    pica.Image = picture58.Image;
                    break;
                case 59:
                    pica.Image = picture59.Image;
                    break;
                case 60:
                    pica.Image = picture60.Image;
                    break;
                case 61:
                    pica.Image = picture61.Image;
                    break;
                case 62:
                    pica.Image = picture62.Image;
                    break;
                case 63:
                    pica.Image = picture63.Image;
                    break;
                case 64:
                    pica.Image = picture64.Image;
                    break;
                case 65:
                    pica.Image = picture65.Image;
                    break;
                case 66:
                    pica.Image = picture66.Image;
                    break;
                case 67:
                    pica.Image = picture67.Image;
                    break;
                case 68:
                    pica.Image = picture68.Image;
                    break;
                case 69:
                    pica.Image = picture69.Image;
                    break;
                case 70:
                    pica.Image = picture70.Image;
                    break;
                case 71:
                    pica.Image = picture71.Image;
                    break;
                case 72:
                    pica.Image = picture72.Image;
                    break;
                case 73:
                    pica.Image = picture73.Image;
                    break;
                case 74:
                    pica.Image = picture74.Image;
                    break;
                case 75:
                    pica.Image = picture75.Image;
                    break;
                case 76:
                    pica.Image = picture76.Image;
                    break;
                case 77:
                    pica.Image = picture77.Image;
                    break;
                case 78:
                    pica.Image = picture78.Image;
                    break;
                case 79:
                    pica.Image = picture79.Image;
                    break;
                case 80:
                    pica.Image = picture80.Image;
                    break;
                case 81:
                    pica.Image = picture81.Image;
                    break;
                case 82:
                    pica.Image = picture82.Image;
                    break;
                case 83:
                    pica.Image = picture83.Image;
                    break;
                case 84:
                    pica.Image = picture84.Image;
                    break;
                case 85:
                    pica.Image = picture85.Image;
                    break;
                case 86:
                    pica.Image = picture86.Image;
                    break;
                case 87:
                    pica.Image = picture87.Image;
                    break;
                case 88:
                    pica.Image = picture88.Image;
                    break;
                case 89:
                    pica.Image = picture89.Image;
                    break;
                case 90:
                    pica.Image = picture90.Image;
                    break;
                case 91:
                    pica.Image = picture91.Image;
                    break;
                case 92:
                    pica.Image = picture92.Image;
                    break;
                case 93:
                    pica.Image = picture93.Image;
                    break;
                case 94:
                    pica.Image = picture94.Image;
                    break;
                case 95:
                    pica.Image = picture95.Image;
                    break;
                case 96:
                    pica.Image = picture96.Image;
                    break;
                case 97:
                    pica.Image = picture97.Image;
                    break;
                case 98:
                    pica.Image = picture98.Image;
                    break;
                case 99:
                    pica.Image = picture99.Image;
                    break;
                case 100:
                    pica.Image = picture100.Image;
                    break;
                case 101:
                    pica.Image = picture101.Image;
                    break;
                case 102:
                    pica.Image = picture102.Image;
                    break;
                case 103:
                    pica.Image = picture103.Image;
                    break;
                case 104:
                    pica.Image = picture104.Image;
                    break;
                default:
                    pica.Image = picture105.Image;
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
                case 7:
                    picb.Image = picture7.Image;
                    break;
                case 8:
                    picb.Image = picture8.Image;
                    break;
                case 9:
                    picb.Image = picture9.Image;
                    break;
                case 10:
                    picb.Image = picture10.Image;
                    break;
                case 11:
                    picb.Image = picture11.Image;
                    break;
                case 12:
                    picb.Image = picture12.Image;
                    break;
                case 13:
                    picb.Image = picture13.Image;
                    break;
                case 14:
                    picb.Image = picture14.Image;
                    break;
                case 15:
                    picb.Image = picture15.Image;
                    break;
                case 16:
                    picb.Image = picture16.Image;
                    break;
                case 17:
                    picb.Image = picture17.Image;
                    break;
                case 18:
                    picb.Image = picture18.Image;
                    break;
                case 19:
                    picb.Image = picture19.Image;
                    break;
                case 20:
                    picb.Image = picture20.Image;
                    break;
                case 21:
                    picb.Image = picture21.Image;
                    break;
                case 22:
                    picb.Image = picture22.Image;
                    break;
                case 23:
                    picb.Image = picture23.Image;
                    break;
                case 24:
                    picb.Image = picture24.Image;
                    break;
                case 25:
                    picb.Image = picture25.Image;
                    break;
                case 26:
                    picb.Image = picture26.Image;
                    break;
                case 27:
                    picb.Image = picture27.Image;
                    break;
                case 28:
                    picb.Image = picture28.Image;
                    break;
                case 29:
                    picb.Image = picture29.Image;
                    break;
                case 30:
                    picb.Image = picture30.Image;
                    break;
                case 31:
                    picb.Image = picture31.Image;
                    break;
                case 32:
                    picb.Image = picture32.Image;
                    break;
                case 33:
                    picb.Image = picture33.Image;
                    break;
                case 34:
                    picb.Image = picture34.Image;
                    break;
                case 35:
                    picb.Image = picture35.Image;
                    break;
                case 36:
                    picb.Image = picture36.Image;
                    break;
                case 37:
                    picb.Image = picture37.Image;
                    break;
                case 38:
                    picb.Image = picture38.Image;
                    break;
                case 39:
                    picb.Image = picture39.Image;
                    break;
                case 40:
                    picb.Image = picture40.Image;
                    break;
                case 41:
                    picb.Image = picture41.Image;
                    break;
                case 42:
                    picb.Image = picture42.Image;
                    break;
                case 43:
                    picb.Image = picture43.Image;
                    break;
                case 44:
                    picb.Image = picture44.Image;
                    break;
                case 45:
                    picb.Image = picture45.Image;
                    break;
                case 46:
                    picb.Image = picture46.Image;
                    break;
                case 47:
                    picb.Image = picture47.Image;
                    break;
                case 48:
                    picb.Image = picture48.Image;
                    break;
                case 49:
                    picb.Image = picture49.Image;
                    break;
                case 50:
                    picb.Image = picture50.Image;
                    break;
                case 51:
                    picb.Image = picture51.Image;
                    break;
                case 52:
                    picb.Image = picture52.Image;
                    break;
                case 53:
                    picb.Image = picture53.Image;
                    break;
                case 54:
                    picb.Image = picture54.Image;
                    break;
                case 55:
                    picb.Image = picture55.Image;
                    break;
                case 56:
                    picb.Image = picture56.Image;
                    break;
                case 57:
                    picb.Image = picture57.Image;
                    break;
                case 58:
                    picb.Image = picture58.Image;
                    break;
                case 59:
                    picb.Image = picture59.Image;
                    break;
                case 60:
                    picb.Image = picture60.Image;
                    break;
                case 61:
                    picb.Image = picture61.Image;
                    break;
                case 62:
                    picb.Image = picture62.Image;
                    break;
                case 63:
                    picb.Image = picture63.Image;
                    break;
                case 64:
                    picb.Image = picture64.Image;
                    break;
                case 65:
                    picb.Image = picture65.Image;
                    break;
                case 66:
                    picb.Image = picture66.Image;
                    break;
                case 67:
                    picb.Image = picture67.Image;
                    break;
                case 68:
                    picb.Image = picture68.Image;
                    break;
                case 69:
                    picb.Image = picture69.Image;
                    break;
                case 70:
                    picb.Image = picture70.Image;
                    break;
                case 71:
                    picb.Image = picture71.Image;
                    break;
                case 72:
                    picb.Image = picture72.Image;
                    break;
                case 73:
                    picb.Image = picture73.Image;
                    break;
                case 74:
                    picb.Image = picture74.Image;
                    break;
                case 75:
                    picb.Image = picture75.Image;
                    break;
                case 76:
                    picb.Image = picture76.Image;
                    break;
                case 77:
                    picb.Image = picture77.Image;
                    break;
                case 78:
                    picb.Image = picture78.Image;
                    break;
                case 79:
                    picb.Image = picture79.Image;
                    break;
                case 80:
                    picb.Image = picture80.Image;
                    break;
                case 81:
                    picb.Image = picture81.Image;
                    break;
                case 82:
                    picb.Image = picture82.Image;
                    break;
                case 83:
                    picb.Image = picture83.Image;
                    break;
                case 84:
                    picb.Image = picture84.Image;
                    break;
                case 85:
                    picb.Image = picture85.Image;
                    break;
                case 86:
                    picb.Image = picture86.Image;
                    break;
                case 87:
                    picb.Image = picture87.Image;
                    break;
                case 88:
                    picb.Image = picture88.Image;
                    break;
                case 89:
                    picb.Image = picture89.Image;
                    break;
                case 90:
                    picb.Image = picture90.Image;
                    break;
                case 91:
                    picb.Image = picture91.Image;
                    break;
                case 92:
                    picb.Image = picture92.Image;
                    break;
                case 93:
                    picb.Image = picture93.Image;
                    break;
                case 94:
                    picb.Image = picture94.Image;
                    break;
                case 95:
                    picb.Image = picture95.Image;
                    break;
                case 96:
                    picb.Image = picture96.Image;
                    break;
                case 97:
                    picb.Image = picture97.Image;
                    break;
                case 98:
                    picb.Image = picture98.Image;
                    break;
                case 99:
                    picb.Image = picture99.Image;
                    break;
                case 100:
                    picb.Image = picture100.Image;
                    break;
                case 101:
                    picb.Image = picture101.Image;
                    break;
                case 102:
                    picb.Image = picture102.Image;
                    break;
                case 103:
                    picb.Image = picture103.Image;
                    break;
                case 104:
                    picb.Image = picture104.Image;
                    break;
                default:
                    picb.Image = picture105.Image;
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
                case 7:
                    picc.Image = picture7.Image;
                    break;
                case 8:
                    picc.Image = picture8.Image;
                    break;
                case 9:
                    picc.Image = picture9.Image;
                    break;
                case 10:
                    picc.Image = picture10.Image;
                    break;
                case 11:
                    picc.Image = picture11.Image;
                    break;
                case 12:
                    picc.Image = picture12.Image;
                    break;
                case 13:
                    picc.Image = picture13.Image;
                    break;
                case 14:
                    picc.Image = picture14.Image;
                    break;
                case 15:
                    picc.Image = picture15.Image;
                    break;
                case 16:
                    picc.Image = picture16.Image;
                    break;
                case 17:
                    picc.Image = picture17.Image;
                    break;
                case 18:
                    picc.Image = picture18.Image;
                    break;
                case 19:
                    picc.Image = picture19.Image;
                    break;
                case 20:
                    picc.Image = picture20.Image;
                    break;
                case 21:
                    picc.Image = picture21.Image;
                    break;
                case 22:
                    picc.Image = picture22.Image;
                    break;
                case 23:
                    picc.Image = picture23.Image;
                    break;
                case 24:
                    picc.Image = picture24.Image;
                    break;
                case 25:
                    picc.Image = picture25.Image;
                    break;
                case 26:
                    picc.Image = picture26.Image;
                    break;
                case 27:
                    picc.Image = picture27.Image;
                    break;
                case 28:
                    picc.Image = picture28.Image;
                    break;
                case 29:
                    picc.Image = picture29.Image;
                    break;
                case 30:
                    picc.Image = picture30.Image;
                    break;
                case 31:
                    picc.Image = picture31.Image;
                    break;
                case 32:
                    picc.Image = picture32.Image;
                    break;
                case 33:
                    picc.Image = picture33.Image;
                    break;
                case 34:
                    picc.Image = picture34.Image;
                    break;
                case 35:
                    picc.Image = picture35.Image;
                    break;
                case 36:
                    picc.Image = picture36.Image;
                    break;
                case 37:
                    picc.Image = picture37.Image;
                    break;
                case 38:
                    picc.Image = picture38.Image;
                    break;
                case 39:
                    picc.Image = picture39.Image;
                    break;
                case 40:
                    picc.Image = picture40.Image;
                    break;
                case 41:
                    picc.Image = picture41.Image;
                    break;
                case 42:
                    picc.Image = picture42.Image;
                    break;
                case 43:
                    picc.Image = picture43.Image;
                    break;
                case 44:
                    picc.Image = picture44.Image;
                    break;
                case 45:
                    picc.Image = picture45.Image;
                    break;
                case 46:
                    picc.Image = picture46.Image;
                    break;
                case 47:
                    picc.Image = picture47.Image;
                    break;
                case 48:
                    picc.Image = picture48.Image;
                    break;
                case 49:
                    picc.Image = picture49.Image;
                    break;
                case 50:
                    picc.Image = picture50.Image;
                    break;
                case 51:
                    picc.Image = picture51.Image;
                    break;
                case 52:
                    picc.Image = picture52.Image;
                    break;
                case 53:
                    picc.Image = picture53.Image;
                    break;
                case 54:
                    picc.Image = picture54.Image;
                    break;
                case 55:
                    picc.Image = picture55.Image;
                    break;
                case 56:
                    picc.Image = picture56.Image;
                    break;
                case 57:
                    picc.Image = picture57.Image;
                    break;
                case 58:
                    picc.Image = picture58.Image;
                    break;
                case 59:
                    picc.Image = picture59.Image;
                    break;
                case 60:
                    picc.Image = picture60.Image;
                    break;
                case 61:
                    picc.Image = picture61.Image;
                    break;
                case 62:
                    picc.Image = picture62.Image;
                    break;
                case 63:
                    picc.Image = picture63.Image;
                    break;
                case 64:
                    picc.Image = picture64.Image;
                    break;
                case 65:
                    picc.Image = picture65.Image;
                    break;
                case 66:
                    picc.Image = picture66.Image;
                    break;
                case 67:
                    picc.Image = picture67.Image;
                    break;
                case 68:
                    picc.Image = picture68.Image;
                    break;
                case 69:
                    picc.Image = picture69.Image;
                    break;
                case 70:
                    picc.Image = picture70.Image;
                    break;
                case 71:
                    picc.Image = picture71.Image;
                    break;
                case 72:
                    picc.Image = picture72.Image;
                    break;
                case 73:
                    picc.Image = picture73.Image;
                    break;
                case 74:
                    picc.Image = picture74.Image;
                    break;
                case 75:
                    picc.Image = picture75.Image;
                    break;
                case 76:
                    picc.Image = picture76.Image;
                    break;
                case 77:
                    picc.Image = picture77.Image;
                    break;
                case 78:
                    picc.Image = picture78.Image;
                    break;
                case 79:
                    picc.Image = picture79.Image;
                    break;
                case 80:
                    picc.Image = picture80.Image;
                    break;
                case 81:
                    picc.Image = picture81.Image;
                    break;
                case 82:
                    picc.Image = picture82.Image;
                    break;
                case 83:
                    picc.Image = picture83.Image;
                    break;
                case 84:
                    picc.Image = picture84.Image;
                    break;
                case 85:
                    picc.Image = picture85.Image;
                    break;
                case 86:
                    picc.Image = picture86.Image;
                    break;
                case 87:
                    picc.Image = picture87.Image;
                    break;
                case 88:
                    picc.Image = picture88.Image;
                    break;
                case 89:
                    picc.Image = picture89.Image;
                    break;
                case 90:
                    picc.Image = picture90.Image;
                    break;
                case 91:
                    picc.Image = picture91.Image;
                    break;
                case 92:
                    picc.Image = picture92.Image;
                    break;
                case 93:
                    picc.Image = picture93.Image;
                    break;
                case 94:
                    picc.Image = picture94.Image;
                    break;
                case 95:
                    picc.Image = picture95.Image;
                    break;
                case 96:
                    picc.Image = picture96.Image;
                    break;
                case 97:
                    picc.Image = picture97.Image;
                    break;
                case 98:
                    picc.Image = picture98.Image;
                    break;
                case 99:
                    picc.Image = picture99.Image;
                    break;
                case 100:
                    picc.Image = picture100.Image;
                    break;
                case 101:
                    picc.Image = picture101.Image;
                    break;
                case 102:
                    picc.Image = picture102.Image;
                    break;
                case 103:
                    picc.Image = picture103.Image;
                    break;
                case 104:
                    picc.Image = picture104.Image;
                    break;
                default:
                    picc.Image = picture105.Image;
                    break;
            }
            switch (_count[12])
            {
                case 1:
                    picd.Image = picture1.Image;
                    break;
                case 2:
                    picd.Image = picture2.Image;
                    break;
                case 3:
                    picd.Image = picture3.Image;
                    break;
                case 4:
                    picd.Image = picture4.Image;
                    break;
                case 5:
                    picd.Image = picture5.Image;
                    break;
                case 6:
                    picd.Image = picture6.Image;
                    break;
                case 7:
                    picd.Image = picture7.Image;
                    break;
                case 8:
                    picd.Image = picture8.Image;
                    break;
                case 9:
                    picd.Image = picture9.Image;
                    break;
                case 10:
                    picd.Image = picture10.Image;
                    break;
                case 11:
                    picd.Image = picture11.Image;
                    break;
                case 12:
                    picd.Image = picture12.Image;
                    break;
                case 13:
                    picd.Image = picture13.Image;
                    break;
                case 14:
                    picd.Image = picture14.Image;
                    break;
                case 15:
                    picd.Image = picture15.Image;
                    break;
                case 16:
                    picd.Image = picture16.Image;
                    break;
                case 17:
                    picd.Image = picture17.Image;
                    break;
                case 18:
                    picd.Image = picture18.Image;
                    break;
                case 19:
                    picd.Image = picture19.Image;
                    break;
                case 20:
                    picd.Image = picture20.Image;
                    break;
                case 21:
                    picd.Image = picture21.Image;
                    break;
                case 22:
                    picd.Image = picture22.Image;
                    break;
                case 23:
                    picd.Image = picture23.Image;
                    break;
                case 24:
                    picd.Image = picture24.Image;
                    break;
                case 25:
                    picd.Image = picture25.Image;
                    break;
                case 26:
                    picd.Image = picture26.Image;
                    break;
                case 27:
                    picd.Image = picture27.Image;
                    break;
                case 28:
                    picd.Image = picture28.Image;
                    break;
                case 29:
                    picd.Image = picture29.Image;
                    break;
                case 30:
                    picd.Image = picture30.Image;
                    break;
                case 31:
                    picd.Image = picture31.Image;
                    break;
                case 32:
                    picd.Image = picture32.Image;
                    break;
                case 33:
                    picd.Image = picture33.Image;
                    break;
                case 34:
                    picd.Image = picture34.Image;
                    break;
                case 35:
                    picd.Image = picture35.Image;
                    break;
                case 36:
                    picd.Image = picture36.Image;
                    break;
                case 37:
                    picd.Image = picture37.Image;
                    break;
                case 38:
                    picd.Image = picture38.Image;
                    break;
                case 39:
                    picd.Image = picture39.Image;
                    break;
                case 40:
                    picd.Image = picture40.Image;
                    break;
                case 41:
                    picd.Image = picture41.Image;
                    break;
                case 42:
                    picd.Image = picture42.Image;
                    break;
                case 43:
                    picd.Image = picture43.Image;
                    break;
                case 44:
                    picd.Image = picture44.Image;
                    break;
                case 45:
                    picd.Image = picture45.Image;
                    break;
                case 46:
                    picd.Image = picture46.Image;
                    break;
                case 47:
                    picd.Image = picture47.Image;
                    break;
                case 48:
                    picd.Image = picture48.Image;
                    break;
                case 49:
                    picd.Image = picture49.Image;
                    break;
                case 50:
                    picd.Image = picture50.Image;
                    break;
                case 51:
                    picd.Image = picture51.Image;
                    break;
                case 52:
                    picd.Image = picture52.Image;
                    break;
                case 53:
                    picd.Image = picture53.Image;
                    break;
                case 54:
                    picd.Image = picture54.Image;
                    break;
                case 55:
                    picd.Image = picture55.Image;
                    break;
                case 56:
                    picd.Image = picture56.Image;
                    break;
                case 57:
                    picd.Image = picture57.Image;
                    break;
                case 58:
                    picd.Image = picture58.Image;
                    break;
                case 59:
                    picd.Image = picture59.Image;
                    break;
                case 60:
                    picd.Image = picture60.Image;
                    break;
                case 61:
                    picd.Image = picture61.Image;
                    break;
                case 62:
                    picd.Image = picture62.Image;
                    break;
                case 63:
                    picd.Image = picture63.Image;
                    break;
                case 64:
                    picd.Image = picture64.Image;
                    break;
                case 65:
                    picd.Image = picture65.Image;
                    break;
                case 66:
                    picd.Image = picture66.Image;
                    break;
                case 67:
                    picd.Image = picture67.Image;
                    break;
                case 68:
                    picd.Image = picture68.Image;
                    break;
                case 69:
                    picd.Image = picture69.Image;
                    break;
                case 70:
                    picd.Image = picture70.Image;
                    break;
                case 71:
                    picd.Image = picture71.Image;
                    break;
                case 72:
                    picd.Image = picture72.Image;
                    break;
                case 73:
                    picd.Image = picture73.Image;
                    break;
                case 74:
                    picd.Image = picture74.Image;
                    break;
                case 75:
                    picd.Image = picture75.Image;
                    break;
                case 76:
                    picd.Image = picture76.Image;
                    break;
                case 77:
                    picd.Image = picture77.Image;
                    break;
                case 78:
                    picd.Image = picture78.Image;
                    break;
                case 79:
                    picd.Image = picture79.Image;
                    break;
                case 80:
                    picd.Image = picture80.Image;
                    break;
                case 81:
                    picd.Image = picture81.Image;
                    break;
                case 82:
                    picd.Image = picture82.Image;
                    break;
                case 83:
                    picd.Image = picture83.Image;
                    break;
                case 84:
                    picd.Image = picture84.Image;
                    break;
                case 85:
                    picd.Image = picture85.Image;
                    break;
                case 86:
                    picd.Image = picture86.Image;
                    break;
                case 87:
                    picd.Image = picture87.Image;
                    break;
                case 88:
                    picd.Image = picture88.Image;
                    break;
                case 89:
                    picd.Image = picture89.Image;
                    break;
                case 90:
                    picd.Image = picture90.Image;
                    break;
                case 91:
                    picd.Image = picture91.Image;
                    break;
                case 92:
                    picd.Image = picture92.Image;
                    break;
                case 93:
                    picd.Image = picture93.Image;
                    break;
                case 94:
                    picd.Image = picture94.Image;
                    break;
                case 95:
                    picd.Image = picture95.Image;
                    break;
                case 96:
                    picd.Image = picture96.Image;
                    break;
                case 97:
                    picd.Image = picture97.Image;
                    break;
                case 98:
                    picd.Image = picture98.Image;
                    break;
                case 99:
                    picd.Image = picture99.Image;
                    break;
                case 100:
                    picd.Image = picture100.Image;
                    break;
                case 101:
                    picd.Image = picture101.Image;
                    break;
                case 102:
                    picd.Image = picture102.Image;
                    break;
                case 103:
                    picd.Image = picture103.Image;
                    break;
                case 104:
                    picd.Image = picture104.Image;
                    break;
                default:
                    picd.Image = picture105.Image;
                    break;
            }
            switch (_count[13])
            {
                case 1:
                    pice.Image = picture1.Image;
                    break;
                case 2:
                    pice.Image = picture2.Image;
                    break;
                case 3:
                    pice.Image = picture3.Image;
                    break;
                case 4:
                    pice.Image = picture4.Image;
                    break;
                case 5:
                    pice.Image = picture5.Image;
                    break;
                case 6:
                    pice.Image = picture6.Image;
                    break;
                case 7:
                    pice.Image = picture7.Image;
                    break;
                case 8:
                    pice.Image = picture8.Image;
                    break;
                case 9:
                    pice.Image = picture9.Image;
                    break;
                case 10:
                    pice.Image = picture10.Image;
                    break;
                case 11:
                    pice.Image = picture11.Image;
                    break;
                case 12:
                    pice.Image = picture12.Image;
                    break;
                case 13:
                    pice.Image = picture13.Image;
                    break;
                case 14:
                    pice.Image = picture14.Image;
                    break;
                case 15:
                    pice.Image = picture15.Image;
                    break;
                case 16:
                    pice.Image = picture16.Image;
                    break;
                case 17:
                    pice.Image = picture17.Image;
                    break;
                case 18:
                    pice.Image = picture18.Image;
                    break;
                case 19:
                    pice.Image = picture19.Image;
                    break;
                case 20:
                    pice.Image = picture20.Image;
                    break;
                case 21:
                    pice.Image = picture21.Image;
                    break;
                case 22:
                    pice.Image = picture22.Image;
                    break;
                case 23:
                    pice.Image = picture23.Image;
                    break;
                case 24:
                    pice.Image = picture24.Image;
                    break;
                case 25:
                    pice.Image = picture25.Image;
                    break;
                case 26:
                    pice.Image = picture26.Image;
                    break;
                case 27:
                    pice.Image = picture27.Image;
                    break;
                case 28:
                    pice.Image = picture28.Image;
                    break;
                case 29:
                    pice.Image = picture29.Image;
                    break;
                case 30:
                    pice.Image = picture30.Image;
                    break;
                case 31:
                    pice.Image = picture31.Image;
                    break;
                case 32:
                    pice.Image = picture32.Image;
                    break;
                case 33:
                    pice.Image = picture33.Image;
                    break;
                case 34:
                    pice.Image = picture34.Image;
                    break;
                case 35:
                    pice.Image = picture35.Image;
                    break;
                case 36:
                    pice.Image = picture36.Image;
                    break;
                case 37:
                    pice.Image = picture37.Image;
                    break;
                case 38:
                    pice.Image = picture38.Image;
                    break;
                case 39:
                    pice.Image = picture39.Image;
                    break;
                case 40:
                    pice.Image = picture40.Image;
                    break;
                case 41:
                    pice.Image = picture41.Image;
                    break;
                case 42:
                    pice.Image = picture42.Image;
                    break;
                case 43:
                    pice.Image = picture43.Image;
                    break;
                case 44:
                    pice.Image = picture44.Image;
                    break;
                case 45:
                    pice.Image = picture45.Image;
                    break;
                case 46:
                    pice.Image = picture46.Image;
                    break;
                case 47:
                    pice.Image = picture47.Image;
                    break;
                case 48:
                    pice.Image = picture48.Image;
                    break;
                case 49:
                    pice.Image = picture49.Image;
                    break;
                case 50:
                    pice.Image = picture50.Image;
                    break;
                case 51:
                    pice.Image = picture51.Image;
                    break;
                case 52:
                    pice.Image = picture52.Image;
                    break;
                case 53:
                    pice.Image = picture53.Image;
                    break;
                case 54:
                    pice.Image = picture54.Image;
                    break;
                case 55:
                    pice.Image = picture55.Image;
                    break;
                case 56:
                    pice.Image = picture56.Image;
                    break;
                case 57:
                    pice.Image = picture57.Image;
                    break;
                case 58:
                    pice.Image = picture58.Image;
                    break;
                case 59:
                    pice.Image = picture59.Image;
                    break;
                case 60:
                    pice.Image = picture60.Image;
                    break;
                case 61:
                    pice.Image = picture61.Image;
                    break;
                case 62:
                    pice.Image = picture62.Image;
                    break;
                case 63:
                    pice.Image = picture63.Image;
                    break;
                case 64:
                    pice.Image = picture64.Image;
                    break;
                case 65:
                    pice.Image = picture65.Image;
                    break;
                case 66:
                    pice.Image = picture66.Image;
                    break;
                case 67:
                    pice.Image = picture67.Image;
                    break;
                case 68:
                    pice.Image = picture68.Image;
                    break;
                case 69:
                    pice.Image = picture69.Image;
                    break;
                case 70:
                    pice.Image = picture70.Image;
                    break;
                case 71:
                    pice.Image = picture71.Image;
                    break;
                case 72:
                    pice.Image = picture72.Image;
                    break;
                case 73:
                    pice.Image = picture73.Image;
                    break;
                case 74:
                    pice.Image = picture74.Image;
                    break;
                case 75:
                    pice.Image = picture75.Image;
                    break;
                case 76:
                    pice.Image = picture76.Image;
                    break;
                case 77:
                    pice.Image = picture77.Image;
                    break;
                case 78:
                    pice.Image = picture78.Image;
                    break;
                case 79:
                    pice.Image = picture79.Image;
                    break;
                case 80:
                    pice.Image = picture80.Image;
                    break;
                case 81:
                    pice.Image = picture81.Image;
                    break;
                case 82:
                    pice.Image = picture82.Image;
                    break;
                case 83:
                    pice.Image = picture83.Image;
                    break;
                case 84:
                    pice.Image = picture84.Image;
                    break;
                case 85:
                    pice.Image = picture85.Image;
                    break;
                case 86:
                    pice.Image = picture86.Image;
                    break;
                case 87:
                    pice.Image = picture87.Image;
                    break;
                case 88:
                    pice.Image = picture88.Image;
                    break;
                case 89:
                    pice.Image = picture89.Image;
                    break;
                case 90:
                    pice.Image = picture90.Image;
                    break;
                case 91:
                    pice.Image = picture91.Image;
                    break;
                case 92:
                    pice.Image = picture92.Image;
                    break;
                case 93:
                    pice.Image = picture93.Image;
                    break;
                case 94:
                    pice.Image = picture94.Image;
                    break;
                case 95:
                    pice.Image = picture95.Image;
                    break;
                case 96:
                    pice.Image = picture96.Image;
                    break;
                case 97:
                    pice.Image = picture97.Image;
                    break;
                case 98:
                    pice.Image = picture98.Image;
                    break;
                case 99:
                    pice.Image = picture99.Image;
                    break;
                case 100:
                    pice.Image = picture100.Image;
                    break;
                case 101:
                    pice.Image = picture101.Image;
                    break;
                case 102:
                    pice.Image = picture102.Image;
                    break;
                case 103:
                    pice.Image = picture103.Image;
                    break;
                case 104:
                    pice.Image = picture104.Image;
                    break;
                default:
                    pice.Image = picture105.Image;
                    break;
            }
            switch (_count[14])
            {
                case 1:
                    picf.Image = picture1.Image;
                    break;
                case 2:
                    picf.Image = picture2.Image;
                    break;
                case 3:
                    picf.Image = picture3.Image;
                    break;
                case 4:
                    picf.Image = picture4.Image;
                    break;
                case 5:
                    picf.Image = picture5.Image;
                    break;
                case 6:
                    picf.Image = picture6.Image;
                    break;
                case 7:
                    picf.Image = picture7.Image;
                    break;
                case 8:
                    picf.Image = picture8.Image;
                    break;
                case 9:
                    picf.Image = picture9.Image;
                    break;
                case 10:
                    picf.Image = picture10.Image;
                    break;
                case 11:
                    picf.Image = picture11.Image;
                    break;
                case 12:
                    picf.Image = picture12.Image;
                    break;
                case 13:
                    picf.Image = picture13.Image;
                    break;
                case 14:
                    picf.Image = picture14.Image;
                    break;
                case 15:
                    picf.Image = picture15.Image;
                    break;
                case 16:
                    picf.Image = picture16.Image;
                    break;
                case 17:
                    picf.Image = picture17.Image;
                    break;
                case 18:
                    picf.Image = picture18.Image;
                    break;
                case 19:
                    picf.Image = picture19.Image;
                    break;
                case 20:
                    picf.Image = picture20.Image;
                    break;
                case 21:
                    picf.Image = picture21.Image;
                    break;
                case 22:
                    picf.Image = picture22.Image;
                    break;
                case 23:
                    picf.Image = picture23.Image;
                    break;
                case 24:
                    picf.Image = picture24.Image;
                    break;
                case 25:
                    picf.Image = picture25.Image;
                    break;
                case 26:
                    picf.Image = picture26.Image;
                    break;
                case 27:
                    picf.Image = picture27.Image;
                    break;
                case 28:
                    picf.Image = picture28.Image;
                    break;
                case 29:
                    picf.Image = picture29.Image;
                    break;
                case 30:
                    picf.Image = picture30.Image;
                    break;
                case 31:
                    picf.Image = picture31.Image;
                    break;
                case 32:
                    picf.Image = picture32.Image;
                    break;
                case 33:
                    picf.Image = picture33.Image;
                    break;
                case 34:
                    picf.Image = picture34.Image;
                    break;
                case 35:
                    picf.Image = picture35.Image;
                    break;
                case 36:
                    picf.Image = picture36.Image;
                    break;
                case 37:
                    picf.Image = picture37.Image;
                    break;
                case 38:
                    picf.Image = picture38.Image;
                    break;
                case 39:
                    picf.Image = picture39.Image;
                    break;
                case 40:
                    picf.Image = picture40.Image;
                    break;
                case 41:
                    picf.Image = picture41.Image;
                    break;
                case 42:
                    picf.Image = picture42.Image;
                    break;
                case 43:
                    picf.Image = picture43.Image;
                    break;
                case 44:
                    picf.Image = picture44.Image;
                    break;
                case 45:
                    picf.Image = picture45.Image;
                    break;
                case 46:
                    picf.Image = picture46.Image;
                    break;
                case 47:
                    picf.Image = picture47.Image;
                    break;
                case 48:
                    picf.Image = picture48.Image;
                    break;
                case 49:
                    picf.Image = picture49.Image;
                    break;
                case 50:
                    picf.Image = picture50.Image;
                    break;
                case 51:
                    picf.Image = picture51.Image;
                    break;
                case 52:
                    picf.Image = picture52.Image;
                    break;
                case 53:
                    picf.Image = picture53.Image;
                    break;
                case 54:
                    picf.Image = picture54.Image;
                    break;
                case 55:
                    picf.Image = picture55.Image;
                    break;
                case 56:
                    picf.Image = picture56.Image;
                    break;
                case 57:
                    picf.Image = picture57.Image;
                    break;
                case 58:
                    picf.Image = picture58.Image;
                    break;
                case 59:
                    picf.Image = picture59.Image;
                    break;
                case 60:
                    picf.Image = picture60.Image;
                    break;
                case 61:
                    picf.Image = picture61.Image;
                    break;
                case 62:
                    picf.Image = picture62.Image;
                    break;
                case 63:
                    picf.Image = picture63.Image;
                    break;
                case 64:
                    picf.Image = picture64.Image;
                    break;
                case 65:
                    picf.Image = picture65.Image;
                    break;
                case 66:
                    picf.Image = picture66.Image;
                    break;
                case 67:
                    picf.Image = picture67.Image;
                    break;
                case 68:
                    picf.Image = picture68.Image;
                    break;
                case 69:
                    picf.Image = picture69.Image;
                    break;
                case 70:
                    picf.Image = picture70.Image;
                    break;
                case 71:
                    picf.Image = picture71.Image;
                    break;
                case 72:
                    picf.Image = picture72.Image;
                    break;
                case 73:
                    picf.Image = picture73.Image;
                    break;
                case 74:
                    picf.Image = picture74.Image;
                    break;
                case 75:
                    picf.Image = picture75.Image;
                    break;
                case 76:
                    picf.Image = picture76.Image;
                    break;
                case 77:
                    picf.Image = picture77.Image;
                    break;
                case 78:
                    picf.Image = picture78.Image;
                    break;
                case 79:
                    picf.Image = picture79.Image;
                    break;
                case 80:
                    picf.Image = picture80.Image;
                    break;
                case 81:
                    picf.Image = picture81.Image;
                    break;
                case 82:
                    picf.Image = picture82.Image;
                    break;
                case 83:
                    picf.Image = picture83.Image;
                    break;
                case 84:
                    picf.Image = picture84.Image;
                    break;
                case 85:
                    picf.Image = picture85.Image;
                    break;
                case 86:
                    picf.Image = picture86.Image;
                    break;
                case 87:
                    picf.Image = picture87.Image;
                    break;
                case 88:
                    picf.Image = picture88.Image;
                    break;
                case 89:
                    picf.Image = picture89.Image;
                    break;
                case 90:
                    picf.Image = picture90.Image;
                    break;
                case 91:
                    picf.Image = picture91.Image;
                    break;
                case 92:
                    picf.Image = picture92.Image;
                    break;
                case 93:
                    picf.Image = picture93.Image;
                    break;
                case 94:
                    picf.Image = picture94.Image;
                    break;
                case 95:
                    picf.Image = picture95.Image;
                    break;
                case 96:
                    picf.Image = picture96.Image;
                    break;
                case 97:
                    picf.Image = picture97.Image;
                    break;
                case 98:
                    picf.Image = picture98.Image;
                    break;
                case 99:
                    picf.Image = picture99.Image;
                    break;
                case 100:
                    picf.Image = picture100.Image;
                    break;
                case 101:
                    picf.Image = picture101.Image;
                    break;
                case 102:
                    picf.Image = picture102.Image;
                    break;
                case 103:
                    picf.Image = picture103.Image;
                    break;
                case 104:
                    picf.Image = picture104.Image;
                    break;
                default:
                    picf.Image = picture105.Image;
                    break;
            }
            switch (_count[15])
            {
                case 1:
                    picg.Image = picture1.Image;
                    break;
                case 2:
                    picg.Image = picture2.Image;
                    break;
                case 3:
                    picg.Image = picture3.Image;
                    break;
                case 4:
                    picg.Image = picture4.Image;
                    break;
                case 5:
                    picg.Image = picture5.Image;
                    break;
                case 6:
                    picg.Image = picture6.Image;
                    break;
                case 7:
                    picg.Image = picture7.Image;
                    break;
                case 8:
                    picg.Image = picture8.Image;
                    break;
                case 9:
                    picg.Image = picture9.Image;
                    break;
                case 10:
                    picg.Image = picture10.Image;
                    break;
                case 11:
                    picg.Image = picture11.Image;
                    break;
                case 12:
                    picg.Image = picture12.Image;
                    break;
                case 13:
                    picg.Image = picture13.Image;
                    break;
                case 14:
                    picg.Image = picture14.Image;
                    break;
                case 15:
                    picg.Image = picture15.Image;
                    break;
                case 16:
                    picg.Image = picture16.Image;
                    break;
                case 17:
                    picg.Image = picture17.Image;
                    break;
                case 18:
                    picg.Image = picture18.Image;
                    break;
                case 19:
                    picg.Image = picture19.Image;
                    break;
                case 20:
                    picg.Image = picture20.Image;
                    break;
                case 21:
                    picg.Image = picture21.Image;
                    break;
                case 22:
                    picg.Image = picture22.Image;
                    break;
                case 23:
                    picg.Image = picture23.Image;
                    break;
                case 24:
                    picg.Image = picture24.Image;
                    break;
                case 25:
                    picg.Image = picture25.Image;
                    break;
                case 26:
                    picg.Image = picture26.Image;
                    break;
                case 27:
                    picg.Image = picture27.Image;
                    break;
                case 28:
                    picg.Image = picture28.Image;
                    break;
                case 29:
                    picg.Image = picture29.Image;
                    break;
                case 30:
                    picg.Image = picture30.Image;
                    break;
                case 31:
                    picg.Image = picture31.Image;
                    break;
                case 32:
                    picg.Image = picture32.Image;
                    break;
                case 33:
                    picg.Image = picture33.Image;
                    break;
                case 34:
                    picg.Image = picture34.Image;
                    break;
                case 35:
                    picg.Image = picture35.Image;
                    break;
                case 36:
                    picg.Image = picture36.Image;
                    break;
                case 37:
                    picg.Image = picture37.Image;
                    break;
                case 38:
                    picg.Image = picture38.Image;
                    break;
                case 39:
                    picg.Image = picture39.Image;
                    break;
                case 40:
                    picg.Image = picture40.Image;
                    break;
                case 41:
                    picg.Image = picture41.Image;
                    break;
                case 42:
                    picg.Image = picture42.Image;
                    break;
                case 43:
                    picg.Image = picture43.Image;
                    break;
                case 44:
                    picg.Image = picture44.Image;
                    break;
                case 45:
                    picg.Image = picture45.Image;
                    break;
                case 46:
                    picg.Image = picture46.Image;
                    break;
                case 47:
                    picg.Image = picture47.Image;
                    break;
                case 48:
                    picg.Image = picture48.Image;
                    break;
                case 49:
                    picg.Image = picture49.Image;
                    break;
                case 50:
                    picg.Image = picture50.Image;
                    break;
                case 51:
                    picg.Image = picture51.Image;
                    break;
                case 52:
                    picg.Image = picture52.Image;
                    break;
                case 53:
                    picg.Image = picture53.Image;
                    break;
                case 54:
                    picg.Image = picture54.Image;
                    break;
                case 55:
                    picg.Image = picture55.Image;
                    break;
                case 56:
                    picg.Image = picture56.Image;
                    break;
                case 57:
                    picg.Image = picture57.Image;
                    break;
                case 58:
                    picg.Image = picture58.Image;
                    break;
                case 59:
                    picg.Image = picture59.Image;
                    break;
                case 60:
                    picg.Image = picture60.Image;
                    break;
                case 61:
                    picg.Image = picture61.Image;
                    break;
                case 62:
                    picg.Image = picture62.Image;
                    break;
                case 63:
                    picg.Image = picture63.Image;
                    break;
                case 64:
                    picg.Image = picture64.Image;
                    break;
                case 65:
                    picg.Image = picture65.Image;
                    break;
                case 66:
                    picg.Image = picture66.Image;
                    break;
                case 67:
                    picg.Image = picture67.Image;
                    break;
                case 68:
                    picg.Image = picture68.Image;
                    break;
                case 69:
                    picg.Image = picture69.Image;
                    break;
                case 70:
                    picg.Image = picture70.Image;
                    break;
                case 71:
                    picg.Image = picture71.Image;
                    break;
                case 72:
                    picg.Image = picture72.Image;
                    break;
                case 73:
                    picg.Image = picture73.Image;
                    break;
                case 74:
                    picg.Image = picture74.Image;
                    break;
                case 75:
                    picg.Image = picture75.Image;
                    break;
                case 76:
                    picg.Image = picture76.Image;
                    break;
                case 77:
                    picg.Image = picture77.Image;
                    break;
                case 78:
                    picg.Image = picture78.Image;
                    break;
                case 79:
                    picg.Image = picture79.Image;
                    break;
                case 80:
                    picg.Image = picture80.Image;
                    break;
                case 81:
                    picg.Image = picture81.Image;
                    break;
                case 82:
                    picg.Image = picture82.Image;
                    break;
                case 83:
                    picg.Image = picture83.Image;
                    break;
                case 84:
                    picg.Image = picture84.Image;
                    break;
                case 85:
                    picg.Image = picture85.Image;
                    break;
                case 86:
                    picg.Image = picture86.Image;
                    break;
                case 87:
                    picg.Image = picture87.Image;
                    break;
                case 88:
                    picg.Image = picture88.Image;
                    break;
                case 89:
                    picg.Image = picture89.Image;
                    break;
                case 90:
                    picg.Image = picture90.Image;
                    break;
                case 91:
                    picg.Image = picture91.Image;
                    break;
                case 92:
                    picg.Image = picture92.Image;
                    break;
                case 93:
                    picg.Image = picture93.Image;
                    break;
                case 94:
                    picg.Image = picture94.Image;
                    break;
                case 95:
                    picg.Image = picture95.Image;
                    break;
                case 96:
                    picg.Image = picture96.Image;
                    break;
                case 97:
                    picg.Image = picture97.Image;
                    break;
                case 98:
                    picg.Image = picture98.Image;
                    break;
                case 99:
                    picg.Image = picture99.Image;
                    break;
                case 100:
                    picg.Image = picture100.Image;
                    break;
                case 101:
                    picg.Image = picture101.Image;
                    break;
                case 102:
                    picg.Image = picture102.Image;
                    break;
                case 103:
                    picg.Image = picture103.Image;
                    break;
                case 104:
                    picg.Image = picture104.Image;
                    break;
                default:
                    picg.Image = picture105.Image;
                    break;
            }

        }

        private void lstPopup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mnItem = lstPopup1.SelectedIndex + 1;
        }

        private void pice_Click(object sender, EventArgs e)
        {
            String sLetter = txtLetter.Text.Substring(0, 1);
            int i = 14;
            sAnswer1 = sAnswer1.Substring(0, i-1) + sLetter + sAnswer1.Substring(i , 16 - i);
            if (sAnswer1.Substring(i - 1, 1) == sAnswer2.Substring(i - 1, 1))
            {
                sAnswer3 = sAnswer3.Substring(0, i-1) + sLetter + sAnswer3.Substring(i , 16 - i);
            }
            lblAnswer1.Text = sAnswer1;
            lblAnswer2.Text = sAnswer3;
        }

        private void picf_Click(object sender, EventArgs e)
        {
            String sLetter = txtLetter.Text.Substring(0, 1);
            int i = 15;
            sAnswer1 = sAnswer1.Substring(0, i-1) + sLetter + sAnswer1.Substring(i , 16 - i);
            if (sAnswer1.Substring(i - 1, 1) == sAnswer2.Substring(i - 1, 1))
            {
                sAnswer3 = sAnswer3.Substring(0, i-1) + sLetter + sAnswer3.Substring(i , 16 - i);
            }
            lblAnswer1.Text = sAnswer1;
            lblAnswer2.Text = sAnswer3;
        }

        private void picg_Click(object sender, EventArgs e)
        {
            String sLetter = txtLetter.Text.Substring(0, 1);
            int i = 16;
            sAnswer1 = sAnswer1.Substring(0, i-1) + sLetter + sAnswer1.Substring(i , 16 - i);
            if (sAnswer1.Substring(i - 1, 1) == sAnswer2.Substring(i - 1, 1))
            {
                sAnswer3 = sAnswer3.Substring(0, i - 1) + sLetter + sAnswer3.Substring(i , 16 - i);
            }
            lblAnswer1.Text = sAnswer1;
            lblAnswer2.Text = sAnswer3;
        }

        private void btnPopup1_Click(object sender, EventArgs e)
        {
            fPopup testdialog = new fPopup();

            switch (mnItem)
            {
                case 1:
                    msPopup1 = "B";
                    break;
                case 2:
                    msPopup1 = "L";
                    break;
                case 3:
                    msPopup1 = "M";
                    break;
                default:
                    msPopup1 = "S";
                    break;
            }

            String sName ="data.txt";

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@sName))
            {
                file.WriteLine(msPopup1);
            }

           
        


        testdialog.ShowDialog();
            testdialog.Dispose();

        }

        private void txtLetter_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtLetter_KeyUp(object sender, KeyEventArgs e)
        {
            char sLetter = (char)e.KeyCode;
            txtLetter.Text = Convert.ToString(sLetter);
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            String sLetter = txtLetter.Text.Substring(0, 1);
            int i = 2;
            sAnswer1 = sAnswer1.Substring(0, i-1) + sLetter + sAnswer1.Substring(i , 16 - i);
            if (sAnswer1.Substring(i-1,1) == sAnswer2.Substring(i-1,1))
            {
                sAnswer3 = sAnswer3.Substring(0, i - 1) + sLetter + sAnswer3.Substring(i , 16 - i);
            }
            lblAnswer1.Text = sAnswer1;
            lblAnswer2.Text = sAnswer3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            char sLetter;

            sAnswer1 = null;
            sAnswer2 = null;
            sAnswer3 = null;
            for (int i = 1; i <= 16; i++)
            {
                sAnswer1 = sAnswer1 + " ";
                sAnswer2 = sAnswer2 + "-";
                sAnswer3 = sAnswer3 + "-";
            }
            for (int i = 1; i <= 16; i++)
            {
                _count[i - 1] = rnd1.Next(1, 105);
            }
            for (int i = 1; i <= 16; i++)
            {
                if (_count[i - 1] <= 26)
                {
                    sLetter = (char)(_count[i - 1] + 64);
                    sAnswer2 = sAnswer2.Substring(0, i - 1) + sLetter + sAnswer2.Substring(i, 16-i);
                }
                else
                {
                    if (_count[i - 1] <= 26+26)
                    {
                        sLetter = (char)(_count[i - 1] + 64-26);
                        sAnswer2 = sAnswer2.Substring(0, i - 1) + sLetter + sAnswer2.Substring(i , 16 - i);
                    }
                    else
                    {
                        if (_count[i - 1] <= 26 + 26+26)
                        {
                            sLetter = (char)(_count[i - 1] + 64 - 26-26);
                            sAnswer2 = sAnswer2.Substring(0, i-1) + sLetter + sAnswer2.Substring(i, 16 - i);
                        }
                        else
                        {
                            sLetter = (char)(_count[i - 1] + 64 - 26 - 26-26);
                            sAnswer2 = sAnswer2.Substring(0, i - 1) + sLetter + sAnswer2.Substring(i, 16 - i);
                        }
                    }
                }
            }
            lblAnswer1.Text = sAnswer1;
            lblAnswer2.Text = sAnswer3;


            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F B1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F B2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F B3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F B4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F B5.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F B6.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F B7.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F B8.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F B9.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F B10.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F B11.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F B12.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"F B13.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"F B14.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"F B15.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"F B16.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
                Image = Image.FromFile(@"F B17.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture18 = new PictureBox
            {
                Name = "pictureBox18",
                Image = Image.FromFile(@"F B18.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture19 = new PictureBox
            {
                Name = "pictureBox19",
                Image = Image.FromFile(@"F B19.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture20 = new PictureBox
            {
                Name = "pictureBox20",
                Image = Image.FromFile(@"F B20.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture21 = new PictureBox
            {
                Name = "pictureBox21",
                Image = Image.FromFile(@"F B21.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture22 = new PictureBox
            {
                Name = "pictureBox22",
                Image = Image.FromFile(@"F B22.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture23 = new PictureBox
            {
                Name = "pictureBox23",
                Image = Image.FromFile(@"F B23.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture24 = new PictureBox
            {
                Name = "pictureBox24",
                Image = Image.FromFile(@"F B24.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture25 = new PictureBox
            {
                Name = "pictureBox25",
                Image = Image.FromFile(@"F B25.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture26 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F B26.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture27 = new PictureBox
            {
                Name = "pictureBox27",
                Image = Image.FromFile(@"F L1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture28 = new PictureBox
            {
                Name = "pictureBox28",
                Image = Image.FromFile(@"F L2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture29 = new PictureBox
            {
                Name = "pictureBox29",
                Image = Image.FromFile(@"F L3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture30 = new PictureBox
            {
                Name = "pictureBox30",
                Image = Image.FromFile(@"F L4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture31 = new PictureBox
            {
                Name = "pictureBox31",
                Image = Image.FromFile(@"F L5.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture32 = new PictureBox
            {
                Name = "pictureBox32",
                Image = Image.FromFile(@"F L6.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture33 = new PictureBox
            {
                Name = "pictureBox33",
                Image = Image.FromFile(@"F L7.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture34 = new PictureBox
            {
                Name = "pictureBox34",
                Image = Image.FromFile(@"F L8.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture35 = new PictureBox
            {
                Name = "pictureBox35",
                Image = Image.FromFile(@"F L9.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture36 = new PictureBox
            {
                Name = "pictureBox36",
                Image = Image.FromFile(@"F L10.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture37 = new PictureBox
            {
                Name = "pictureBox37",
                Image = Image.FromFile(@"F L11.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture38 = new PictureBox
            {
                Name = "pictureBox38",
                Image = Image.FromFile(@"F L12.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture39 = new PictureBox
            {
                Name = "pictureBox39",
                Image = Image.FromFile(@"F L13.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture40 = new PictureBox
            {
                Name = "pictureBox40",
                Image = Image.FromFile(@"F L14.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture41 = new PictureBox
            {
                Name = "pictureBox41",
                Image = Image.FromFile(@"F L15.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture42 = new PictureBox
            { 
                Name = "pictureBox42",
                Image = Image.FromFile(@"F L16.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture43 = new PictureBox
            {
                Name = "pictureBox43",
                Image = Image.FromFile(@"F L17.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture44 = new PictureBox
            {
                Name = "pictureBox44",
                Image = Image.FromFile(@"F L18.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture45 = new PictureBox
            {
                Name = "pictureBox45",
                Image = Image.FromFile(@"F L19.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture46 = new PictureBox
            {
                Name = "pictureBox46",
                Image = Image.FromFile(@"F L20.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture47 = new PictureBox
            {
                Name = "pictureBox47",
                Image = Image.FromFile(@"F L21.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture48 = new PictureBox
            {
                Name = "pictureBox48",
                Image = Image.FromFile(@"F L22.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture49 = new PictureBox
            {
                Name = "pictureBox49",
                Image = Image.FromFile(@"F L23.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture50 = new PictureBox
            {
                Name = "pictureBox50",
                Image = Image.FromFile(@"F L24.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture51 = new PictureBox
            {
                Name = "pictureBox51",
                Image = Image.FromFile(@"F L25.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture52 = new PictureBox
            {
                Name = "pictureBox52",
                Image = Image.FromFile(@"F L26.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture53 = new PictureBox
            {
                Name = "pictureBox53",
                Image = Image.FromFile(@"F M1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture54 = new PictureBox
            {
                Name = "pictureBox54",
                Image = Image.FromFile(@"F M2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture55 = new PictureBox
            {
                Name = "pictureBox55",
                Image = Image.FromFile(@"F M3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture56 = new PictureBox
            {
                Name = "pictureBox56",
                Image = Image.FromFile(@"F M4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture57 = new PictureBox
            {
                Name = "pictureBox57",
                Image = Image.FromFile(@"F M5.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture58 = new PictureBox
            {
                Name = "pictureBox58",
                Image = Image.FromFile(@"F M6.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture59 = new PictureBox
            {
                Name = "pictureBox59",
                Image = Image.FromFile(@"F M7.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture60 = new PictureBox
            {
                Name = "pictureBox60",
                Image = Image.FromFile(@"F M8.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture61 = new PictureBox
            {
                Name = "pictureBox61",
                Image = Image.FromFile(@"F M9.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture62 = new PictureBox
            {
                Name = "pictureBox62",
                Image = Image.FromFile(@"F M10.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture63 = new PictureBox
            {
                Name = "pictureBox63",
                Image = Image.FromFile(@"F M11.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture64 = new PictureBox
            {
                Name = "pictureBox64",
                Image = Image.FromFile(@"F M12.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture65 = new PictureBox
            {
                Name = "pictureBox65",
                Image = Image.FromFile(@"F M13.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture66 = new PictureBox
            {
                Name = "pictureBox66",
                Image = Image.FromFile(@"F M14.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture67 = new PictureBox
            {
                Name = "pictureBox67",
                Image = Image.FromFile(@"F M15.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture68 = new PictureBox
            {
                Name = "pictureBox68",
                Image = Image.FromFile(@"F M16.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture69 = new PictureBox
            {
                Name = "pictureBox69",
                Image = Image.FromFile(@"F M17.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture70 = new PictureBox
            {
                Name = "pictureBox70",
                Image = Image.FromFile(@"F M18.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture71 = new PictureBox
            {
                Name = "pictureBox71",
                Image = Image.FromFile(@"F M19.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture72 = new PictureBox
            {
                Name = "pictureBox72",
                Image = Image.FromFile(@"F M20.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture73 = new PictureBox
            {
                Name = "pictureBox73",
                Image = Image.FromFile(@"F M21.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture74 = new PictureBox
            {
                Name = "pictureBox74",
                Image = Image.FromFile(@"F M22.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture75 = new PictureBox
            {
                Name = "pictureBox75",
                Image = Image.FromFile(@"F M23.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture76 = new PictureBox
            {
                Name = "pictureBox76",
                Image = Image.FromFile(@"F M24.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture77 = new PictureBox
            {
                Name = "pictureBox77",
                Image = Image.FromFile(@"F M25.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture78 = new PictureBox
            {
                Name = "pictureBox78",
                Image = Image.FromFile(@"F M26.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture79 = new PictureBox
            {
                Name = "pictureBox79",
                Image = Image.FromFile(@"F S1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture80 = new PictureBox
            {
                Name = "pictureBox80",
                Image = Image.FromFile(@"F S2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture81 = new PictureBox
            {
                Name = "pictureBox81",
                Image = Image.FromFile(@"F S3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture82 = new PictureBox
            {
                Name = "pictureBox82",
                Image = Image.FromFile(@"F S4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture83 = new PictureBox
            {
                Name = "pictureBox83",
                Image = Image.FromFile(@"F S5.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture84 = new PictureBox
            {
                Name = "pictureBox84",
                Image = Image.FromFile(@"F S6.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture85 = new PictureBox
            {
                Name = "pictureBox85",
                Image = Image.FromFile(@"F S7.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture86 = new PictureBox
            {
                Name = "pictureBox86",
                Image = Image.FromFile(@"F S8.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture87 = new PictureBox
            {
                Name = "pictureBox87",
                Image = Image.FromFile(@"F S9.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture88 = new PictureBox
            {
                Name = "pictureBox88",
                Image = Image.FromFile(@"F S10.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture89 = new PictureBox
            {
                Name = "pictureBox89",
                Image = Image.FromFile(@"F S11.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture90 = new PictureBox
            {
                Name = "pictureBox90",
                Image = Image.FromFile(@"F S12.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture91 = new PictureBox
            {
                Name = "pictureBox91",
                Image = Image.FromFile(@"F S13.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
             };
            PictureBox picture92 = new PictureBox
            {
                Name = "pictureBox92",
                Image = Image.FromFile(@"F S14.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture93 = new PictureBox
            {
                Name = "pictureBox93",
                Image = Image.FromFile(@"F S15.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture94 = new PictureBox
            {
                Name = "pictureBox94",
                Image = Image.FromFile(@"F S16.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture95 = new PictureBox
            {
                Name = "pictureBox95",
                Image = Image.FromFile(@"F S17.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture96 = new PictureBox
            {
                Name = "pictureBo9x6",
                Image = Image.FromFile(@"F S18.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture97 = new PictureBox
            {
                Name = "pictureBox97",
                Image = Image.FromFile(@"F S19.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture98 = new PictureBox
            {
                Name = "pictureBox98",
                Image = Image.FromFile(@"F S20.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture99 = new PictureBox
            {
                Name = "pictureBox99",
                Image = Image.FromFile(@"F S21.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture100 = new PictureBox
            {
                Name = "pictureBox100",
                Image = Image.FromFile(@"F S22.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture101 = new PictureBox
            {
                Name = "pictureBox101",
                Image = Image.FromFile(@"F S23.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture102 = new PictureBox
            {
                Name = "pictureBox102",
                Image = Image.FromFile(@"F S24.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture103 = new PictureBox
            {
                Name = "pictureBox103",
                Image = Image.FromFile(@"F S25.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture104 = new PictureBox
            {
                Name = "pictureBox104",
                Image = Image.FromFile(@"F S26.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture105 = new PictureBox
            {
                Name = "pictureBox105",
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
                case 12:
                    pic1.Image = picture12.Image;
                    break;
                case 13:
                    pic1.Image = picture13.Image;
                    break;
                case 14:
                    pic1.Image = picture14.Image;
                    break;
                case 15:
                    pic1.Image = picture15.Image;
                    break;
                case 16:
                    pic1.Image = picture16.Image;
                    break;
                case 17:
                    pic1.Image = picture17.Image;
                    break;
                case 18:
                    pic1.Image = picture18.Image;
                    break;
                case 19:
                    pic1.Image = picture19.Image;
                    break;
                case 20:
                    pic1.Image = picture20.Image;
                    break;
                case 21:
                    pic1.Image = picture21.Image;
                    break;
                case 22:
                    pic1.Image = picture22.Image;
                    break;
                case 23:
                    pic1.Image = picture23.Image;
                    break;
                case 24:
                    pic1.Image = picture24.Image;
                    break;
                case 25:
                    pic1.Image = picture25.Image;
                    break;
                case 26:
                    pic1.Image = picture26.Image;
                    break;
                case 27:
                    pic1.Image = picture27.Image;
                    break;
                case 28:
                    pic1.Image = picture28.Image;
                    break;
                case 29:
                    pic1.Image = picture29.Image;
                    break;
                case 30:
                    pic1.Image = picture30.Image;
                    break;
                case 31:
                    pic1.Image = picture31.Image;
                    break;
                case 32:
                    pic1.Image = picture32.Image;
                    break;
                case 33:
                    pic1.Image = picture33.Image;
                    break;
                case 34:
                    pic1.Image = picture34.Image;
                    break;
                case 35:
                    pic1.Image = picture35.Image;
                    break;
                case 36:
                    pic1.Image = picture36.Image;
                    break;
                case 37:
                    pic1.Image = picture37.Image;
                    break;
                case 38:
                    pic1.Image = picture38.Image;
                    break;
                case 39:
                    pic1.Image = picture39.Image;
                    break;
                case 40:
                    pic1.Image = picture40.Image;
                    break;
                case 41:
                    pic1.Image = picture41.Image;
                    break;
                case 42:
                    pic1.Image = picture42.Image;
                    break;
                case 43:
                    pic1.Image = picture43.Image;
                    break;
                case 44:
                    pic1.Image = picture44.Image;
                    break;
                case 45:
                    pic1.Image = picture45.Image;
                    break;
                case 46:
                    pic1.Image = picture46.Image;
                    break;
                case 47:
                    pic1.Image = picture47.Image;
                    break;
                case 48:
                    pic1.Image = picture48.Image;
                    break;
                case 49:
                    pic1.Image = picture49.Image;
                    break;
                case 50:
                    pic1.Image = picture50.Image;
                    break;
                case 51:
                    pic1.Image = picture51.Image;
                    break;
                case 52:
                    pic1.Image = picture52.Image;
                    break;
                case 53:
                    pic1.Image = picture53.Image;
                    break;
                case 54:
                    pic1.Image = picture54.Image;
                    break;
                case 55:
                    pic1.Image = picture55.Image;
                    break;
                case 56:
                    pic1.Image = picture56.Image;
                    break;
                case 57:
                    pic1.Image = picture57.Image;
                    break;
                case 58:
                    pic1.Image = picture58.Image;
                    break;
                case 59:
                    pic1.Image = picture59.Image;
                    break;
                case 60:
                    pic1.Image = picture60.Image;
                    break;
                case 61:
                    pic1.Image = picture61.Image;
                    break;
                case 62:
                    pic1.Image = picture62.Image;
                    break;
                case 63:
                    pic1.Image = picture63.Image;
                    break;
                case 64:
                    pic1.Image = picture64.Image;
                    break;
                case 65:
                    pic1.Image = picture65.Image;
                    break;
                case 66:
                    pic1.Image = picture66.Image;
                    break;
                case 67:
                    pic1.Image = picture67.Image;
                    break;
                case 68:
                    pic1.Image = picture68.Image;
                    break;
                case 69:
                    pic1.Image = picture69.Image;
                    break;
                case 70:
                    pic1.Image = picture70.Image;
                    break;
                case 71:
                    pic1.Image = picture71.Image;
                    break;
                case 72:
                    pic1.Image = picture72.Image;
                    break;
                case 73:
                    pic1.Image = picture73.Image;
                    break;
                case 74:
                    pic1.Image = picture74.Image;
                    break;
                case 75:
                    pic1.Image = picture75.Image;
                    break;
                case 76:
                    pic1.Image = picture76.Image;
                    break;
                case 77:
                    pic1.Image = picture77.Image;
                    break;
                case 78:
                    pic1.Image = picture78.Image;
                    break;
                case 79:
                    pic1.Image = picture79.Image;
                    break;
                case 80:
                    pic1.Image = picture80.Image;
                    break;
                case 81:
                    pic1.Image = picture81.Image;
                    break;
                case 82:
                    pic1.Image = picture82.Image;
                    break;
                case 83:
                    pic1.Image = picture83.Image;
                    break;
                case 84:
                    pic1.Image = picture84.Image;
                    break;
                case 85:
                    pic1.Image = picture85.Image;
                    break;
                case 86:
                    pic1.Image = picture86.Image;
                    break;
                case 87:
                    pic1.Image = picture87.Image;
                    break;
                case 88:
                    pic1.Image = picture88.Image;
                    break;
                case 89:
                    pic1.Image = picture89.Image;
                    break;
                case 90:
                    pic1.Image = picture90.Image;
                    break;
                case 91:
                    pic1.Image = picture91.Image;
                    break;
                case 92:
                    pic1.Image = picture92.Image;
                    break;
                case 93:
                    pic1.Image = picture93.Image;
                    break;
                case 94:
                    pic1.Image = picture94.Image;
                    break;
                case 95:
                    pic1.Image = picture95.Image;
                    break;
                case 96:
                    pic1.Image = picture96.Image;
                    break;
                case 97:
                    pic1.Image = picture97.Image;
                    break;
                case 98:
                    pic1.Image = picture98.Image;
                    break;
                case 99:
                    pic1.Image = picture99.Image;
                    break;
                case 100:
                    pic1.Image = picture100.Image;
                    break;
                case 101:
                    pic1.Image = picture101.Image;
                    break;
                case 102:
                    pic1.Image = picture102.Image;
                    break;
                case 103:
                    pic1.Image = picture103.Image;
                    break;
                case 104:
                    pic1.Image = picture104.Image;
                    break;
                default:
                    pic1.Image = picture105.Image;
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
                case 12:
                    pic2.Image = picture12.Image;
                    break;
                case 13:
                    pic2.Image = picture13.Image;
                    break;
                case 14:
                    pic2.Image = picture14.Image;
                    break;
                case 15:
                    pic2.Image = picture15.Image;
                    break;
                case 16:
                    pic2.Image = picture16.Image;
                    break;
                case 17:
                    pic2.Image = picture17.Image;
                    break;
                case 18:
                    pic2.Image = picture18.Image;
                    break;
                case 19:
                    pic2.Image = picture19.Image;
                    break;
                case 20:
                    pic2.Image = picture20.Image;
                    break;
                case 21:
                    pic2.Image = picture21.Image;
                    break;
                case 22:
                    pic2.Image = picture22.Image;
                    break;
                case 23:
                    pic2.Image = picture23.Image;
                    break;
                case 24:
                    pic2.Image = picture24.Image;
                    break;
                case 25:
                    pic2.Image = picture25.Image;
                    break;
                case 26:
                    pic2.Image = picture26.Image;
                    break;
                case 27:
                    pic2.Image = picture27.Image;
                    break;
                case 28:
                    pic2.Image = picture28.Image;
                    break;
                case 29:
                    pic2.Image = picture29.Image;
                    break;
                case 30:
                    pic2.Image = picture30.Image;
                    break;
                case 31:
                    pic2.Image = picture31.Image;
                    break;
                case 32:
                    pic2.Image = picture32.Image;
                    break;
                case 33:
                    pic2.Image = picture33.Image;
                    break;
                case 34:
                    pic2.Image = picture34.Image;
                    break;
                case 35:
                    pic2.Image = picture35.Image;
                    break;
                case 36:
                    pic2.Image = picture36.Image;
                    break;
                case 37:
                    pic2.Image = picture37.Image;
                    break;
                case 38:
                    pic2.Image = picture38.Image;
                    break;
                case 39:
                    pic2.Image = picture39.Image;
                    break;
                case 40:
                    pic2.Image = picture40.Image;
                    break;
                case 41:
                    pic2.Image = picture41.Image;
                    break;
                case 42:
                    pic2.Image = picture42.Image;
                    break;
                case 43:
                    pic2.Image = picture43.Image;
                    break;
                case 44:
                    pic2.Image = picture44.Image;
                    break;
                case 45:
                    pic2.Image = picture45.Image;
                    break;
                case 46:
                    pic2.Image = picture46.Image;
                    break;
                case 47:
                    pic2.Image = picture47.Image;
                    break;
                case 48:
                    pic2.Image = picture48.Image;
                    break;
                case 49:
                    pic2.Image = picture49.Image;
                    break;
                case 50:
                    pic2.Image = picture50.Image;
                    break;
                case 51:
                    pic2.Image = picture51.Image;
                    break;
                case 52:
                    pic2.Image = picture52.Image;
                    break;
                case 53:
                    pic2.Image = picture53.Image;
                    break;
                case 54:
                    pic2.Image = picture54.Image;
                    break;
                case 55:
                    pic2.Image = picture55.Image;
                    break;
                case 56:
                    pic2.Image = picture56.Image;
                    break;
                case 57:
                    pic2.Image = picture57.Image;
                    break;
                case 58:
                    pic2.Image = picture58.Image;
                    break;
                case 59:
                    pic2.Image = picture59.Image;
                    break;
                case 60:
                    pic2.Image = picture60.Image;
                    break;
                case 61:
                    pic2.Image = picture61.Image;
                    break;
                case 62:
                    pic2.Image = picture62.Image;
                    break;
                case 63:
                    pic2.Image = picture63.Image;
                    break;
                case 64:
                    pic2.Image = picture64.Image;
                    break;
                case 65:
                    pic2.Image = picture65.Image;
                    break;
                case 66:
                    pic2.Image = picture66.Image;
                    break;
                case 67:
                    pic2.Image = picture67.Image;
                    break;
                case 68:
                    pic2.Image = picture68.Image;
                    break;
                case 69:
                    pic2.Image = picture69.Image;
                    break;
                case 70:
                    pic2.Image = picture70.Image;
                    break;
                case 71:
                    pic2.Image = picture71.Image;
                    break;
                case 72:
                    pic2.Image = picture72.Image;
                    break;
                case 73:
                    pic2.Image = picture73.Image;
                    break;
                case 74:
                    pic2.Image = picture74.Image;
                    break;
                case 75:
                    pic2.Image = picture75.Image;
                    break;
                case 76:
                    pic2.Image = picture76.Image;
                    break;
                case 77:
                    pic2.Image = picture77.Image;
                    break;
                case 78:
                    pic2.Image = picture78.Image;
                    break;
                case 79:
                    pic2.Image = picture79.Image;
                    break;
                case 80:
                    pic2.Image = picture80.Image;
                    break;
                case 81:
                    pic2.Image = picture81.Image;
                    break;
                case 82:
                    pic2.Image = picture82.Image;
                    break;
                case 83:
                    pic2.Image = picture83.Image;
                    break;
                case 84:
                    pic2.Image = picture84.Image;
                    break;
                case 85:
                    pic2.Image = picture85.Image;
                    break;
                case 86:
                    pic2.Image = picture86.Image;
                    break;
                case 87:
                    pic2.Image = picture87.Image;
                    break;
                case 88:
                    pic2.Image = picture88.Image;
                    break;
                case 89:
                    pic2.Image = picture89.Image;
                    break;
                case 90:
                    pic2.Image = picture90.Image;
                    break;
                case 91:
                    pic2.Image = picture91.Image;
                    break;
                case 92:
                    pic2.Image = picture92.Image;
                    break;
                case 93:
                    pic2.Image = picture93.Image;
                    break;
                case 94:
                    pic2.Image = picture94.Image;
                    break;
                case 95:
                    pic2.Image = picture95.Image;
                    break;
                case 96:
                    pic2.Image = picture96.Image;
                    break;
                case 97:
                    pic2.Image = picture97.Image;
                    break;
                case 98:
                    pic2.Image = picture98.Image;
                    break;
                case 99:
                    pic2.Image = picture99.Image;
                    break;
                case 100:
                    pic2.Image = picture100.Image;
                    break;
                case 101:
                    pic2.Image = picture101.Image;
                    break;
                case 102:
                    pic2.Image = picture102.Image;
                    break;
                case 103:
                    pic2.Image = picture103.Image;
                    break;
                case 104:
                    pic2.Image = picture104.Image;
                    break;
                default:
                    pic2.Image = picture105.Image;
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
                case 12:
                    pic3.Image = picture12.Image;
                    break;
                case 13:
                    pic3.Image = picture13.Image;
                    break;
                case 14:
                    pic3.Image = picture14.Image;
                    break;
                case 15:
                    pic3.Image = picture15.Image;
                    break;
                case 16:
                    pic3.Image = picture16.Image;
                    break;
                case 17:
                    pic3.Image = picture17.Image;
                    break;
                case 18:
                    pic3.Image = picture18.Image;
                    break;
                case 19:
                    pic3.Image = picture19.Image;
                    break;
                case 20:
                    pic3.Image = picture20.Image;
                    break;
                case 21:
                    pic3.Image = picture21.Image;
                    break;
                case 22:
                    pic3.Image = picture22.Image;
                    break;
                case 23:
                    pic3.Image = picture23.Image;
                    break;
                case 24:
                    pic3.Image = picture24.Image;
                    break;
                case 25:
                    pic3.Image = picture25.Image;
                    break;
                case 26:
                    pic3.Image = picture26.Image;
                    break;
                case 27:
                    pic3.Image = picture27.Image;
                    break;
                case 28:
                    pic3.Image = picture28.Image;
                    break;
                case 29:
                    pic3.Image = picture29.Image;
                    break;
                case 30:
                    pic3.Image = picture30.Image;
                    break;
                case 31:
                    pic3.Image = picture31.Image;
                    break;
                case 32:
                    pic3.Image = picture32.Image;
                    break;
                case 33:
                    pic3.Image = picture33.Image;
                    break;
                case 34:
                    pic3.Image = picture34.Image;
                    break;
                case 35:
                    pic3.Image = picture35.Image;
                    break;
                case 36:
                    pic3.Image = picture36.Image;
                    break;
                case 37:
                    pic3.Image = picture37.Image;
                    break;
                case 38:
                    pic3.Image = picture38.Image;
                    break;
                case 39:
                    pic3.Image = picture39.Image;
                    break;
                case 40:
                    pic3.Image = picture40.Image;
                    break;
                case 41:
                    pic3.Image = picture41.Image;
                    break;
                case 42:
                    pic3.Image = picture42.Image;
                    break;
                case 43:
                    pic3.Image = picture43.Image;
                    break;
                case 44:
                    pic3.Image = picture44.Image;
                    break;
                case 45:
                    pic3.Image = picture45.Image;
                    break;
                case 46:
                    pic3.Image = picture46.Image;
                    break;
                case 47:
                    pic3.Image = picture47.Image;
                    break;
                case 48:
                    pic3.Image = picture48.Image;
                    break;
                case 49:
                    pic3.Image = picture49.Image;
                    break;
                case 50:
                    pic3.Image = picture50.Image;
                    break;
                case 51:
                    pic3.Image = picture51.Image;
                    break;
                case 52:
                    pic3.Image = picture52.Image;
                    break;
                case 53:
                    pic3.Image = picture53.Image;
                    break;
                case 54:
                    pic3.Image = picture54.Image;
                    break;
                case 55:
                    pic3.Image = picture55.Image;
                    break;
                case 56:
                    pic3.Image = picture56.Image;
                    break;
                case 57:
                    pic3.Image = picture57.Image;
                    break;
                case 58:
                    pic3.Image = picture58.Image;
                    break;
                case 59:
                    pic3.Image = picture59.Image;
                    break;
                case 60:
                    pic3.Image = picture60.Image;
                    break;
                case 61:
                    pic3.Image = picture61.Image;
                    break;
                case 62:
                    pic3.Image = picture62.Image;
                    break;
                case 63:
                    pic3.Image = picture63.Image;
                    break;
                case 64:
                    pic3.Image = picture64.Image;
                    break;
                case 65:
                    pic3.Image = picture65.Image;
                    break;
                case 66:
                    pic3.Image = picture66.Image;
                    break;
                case 67:
                    pic3.Image = picture67.Image;
                    break;
                case 68:
                    pic3.Image = picture68.Image;
                    break;
                case 69:
                    pic3.Image = picture69.Image;
                    break;
                case 70:
                    pic3.Image = picture70.Image;
                    break;
                case 71:
                    pic3.Image = picture71.Image;
                    break;
                case 72:
                    pic3.Image = picture72.Image;
                    break;
                case 73:
                    pic3.Image = picture73.Image;
                    break;
                case 74:
                    pic3.Image = picture74.Image;
                    break;
                case 75:
                    pic3.Image = picture75.Image;
                    break;
                case 76:
                    pic3.Image = picture76.Image;
                    break;
                case 77:
                    pic3.Image = picture77.Image;
                    break;
                case 78:
                    pic3.Image = picture78.Image;
                    break;
                case 79:
                    pic3.Image = picture79.Image;
                    break;
                case 80:
                    pic3.Image = picture80.Image;
                    break;
                case 81:
                    pic3.Image = picture81.Image;
                    break;
                case 82:
                    pic3.Image = picture82.Image;
                    break;
                case 83:
                    pic3.Image = picture83.Image;
                    break;
                case 84:
                    pic3.Image = picture84.Image;
                    break;
                case 85:
                    pic3.Image = picture85.Image;
                    break;
                case 86:
                    pic3.Image = picture86.Image;
                    break;
                case 87:
                    pic3.Image = picture87.Image;
                    break;
                case 88:
                    pic3.Image = picture88.Image;
                    break;
                case 89:
                    pic3.Image = picture89.Image;
                    break;
                case 90:
                    pic3.Image = picture90.Image;
                    break;
                case 91:
                    pic3.Image = picture91.Image;
                    break;
                case 92:
                    pic3.Image = picture92.Image;
                    break;
                case 93:
                    pic3.Image = picture93.Image;
                    break;
                case 94:
                    pic3.Image = picture94.Image;
                    break;
                case 95:
                    pic3.Image = picture95.Image;
                    break;
                case 96:
                    pic3.Image = picture96.Image;
                    break;
                case 97:
                    pic3.Image = picture97.Image;
                    break;
                case 98:
                    pic3.Image = picture98.Image;
                    break;
                case 99:
                    pic3.Image = picture99.Image;
                    break;
                case 100:
                    pic3.Image = picture100.Image;
                    break;
                case 101:
                    pic3.Image = picture101.Image;
                    break;
                case 102:
                    pic3.Image = picture102.Image;
                    break;
                case 103:
                    pic3.Image = picture103.Image;
                    break;
                case 104:
                    pic3.Image = picture104.Image;
                    break;
                default:
                    pic3.Image = picture105.Image;
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
                case 12:
                    pic4.Image = picture12.Image;
                    break;
                case 13:
                    pic4.Image = picture13.Image;
                    break;
                case 14:
                    pic4.Image = picture14.Image;
                    break;
                case 15:
                    pic4.Image = picture15.Image;
                    break;
                case 16:
                    pic4.Image = picture16.Image;
                    break;
                case 17:
                    pic4.Image = picture17.Image;
                    break;
                case 18:
                    pic4.Image = picture18.Image;
                    break;
                case 19:
                    pic4.Image = picture19.Image;
                    break;
                case 20:
                    pic4.Image = picture20.Image;
                    break;
                case 21:
                    pic4.Image = picture21.Image;
                    break;
                case 22:
                    pic4.Image = picture22.Image;
                    break;
                case 23:
                    pic4.Image = picture23.Image;
                    break;
                case 24:
                    pic4.Image = picture24.Image;
                    break;
                case 25:
                    pic4.Image = picture25.Image;
                    break;
                case 26:
                    pic4.Image = picture26.Image;
                    break;
                case 27:
                    pic4.Image = picture27.Image;
                    break;
                case 28:
                    pic4.Image = picture28.Image;
                    break;
                case 29:
                    pic4.Image = picture29.Image;
                    break;
                case 30:
                    pic4.Image = picture30.Image;
                    break;
                case 31:
                    pic4.Image = picture31.Image;
                    break;
                case 32:
                    pic4.Image = picture32.Image;
                    break;
                case 33:
                    pic4.Image = picture33.Image;
                    break;
                case 34:
                    pic4.Image = picture34.Image;
                    break;
                case 35:
                    pic4.Image = picture35.Image;
                    break;
                case 36:
                    pic4.Image = picture36.Image;
                    break;
                case 37:
                    pic4.Image = picture37.Image;
                    break;
                case 38:
                    pic4.Image = picture38.Image;
                    break;
                case 39:
                    pic4.Image = picture39.Image;
                    break;
                case 40:
                    pic4.Image = picture40.Image;
                    break;
                case 41:
                    pic4.Image = picture41.Image;
                    break;
                case 42:
                    pic4.Image = picture42.Image;
                    break;
                case 43:
                    pic4.Image = picture43.Image;
                    break;
                case 44:
                    pic4.Image = picture44.Image;
                    break;
                case 45:
                    pic4.Image = picture45.Image;
                    break;
                case 46:
                    pic4.Image = picture46.Image;
                    break;
                case 47:
                    pic4.Image = picture47.Image;
                    break;
                case 48:
                    pic4.Image = picture48.Image;
                    break;
                case 49:
                    pic4.Image = picture49.Image;
                    break;
                case 50:
                    pic4.Image = picture50.Image;
                    break;
                case 51:
                    pic4.Image = picture51.Image;
                    break;
                case 52:
                    pic4.Image = picture52.Image;
                    break;
                case 53:
                    pic4.Image = picture53.Image;
                    break;
                case 54:
                    pic4.Image = picture54.Image;
                    break;
                case 55:
                    pic4.Image = picture55.Image;
                    break;
                case 56:
                    pic4.Image = picture56.Image;
                    break;
                case 57:
                    pic4.Image = picture57.Image;
                    break;
                case 58:
                    pic4.Image = picture58.Image;
                    break;
                case 59:
                    pic4.Image = picture59.Image;
                    break;
                case 60:
                    pic4.Image = picture60.Image;
                    break;
                case 61:
                    pic4.Image = picture61.Image;
                    break;
                case 62:
                    pic4.Image = picture62.Image;
                    break;
                case 63:
                    pic4.Image = picture63.Image;
                    break;
                case 64:
                    pic4.Image = picture64.Image;
                    break;
                case 65:
                    pic4.Image = picture65.Image;
                    break;
                case 66:
                    pic4.Image = picture66.Image;
                    break;
                case 67:
                    pic4.Image = picture67.Image;
                    break;
                case 68:
                    pic4.Image = picture68.Image;
                    break;
                case 69:
                    pic4.Image = picture69.Image;
                    break;
                case 70:
                    pic4.Image = picture70.Image;
                    break;
                case 71:
                    pic4.Image = picture71.Image;
                    break;
                case 72:
                    pic4.Image = picture72.Image;
                    break;
                case 73:
                    pic4.Image = picture73.Image;
                    break;
                case 74:
                    pic4.Image = picture74.Image;
                    break;
                case 75:
                    pic4.Image = picture75.Image;
                    break;
                case 76:
                    pic4.Image = picture76.Image;
                    break;
                case 77:
                    pic4.Image = picture77.Image;
                    break;
                case 78:
                    pic4.Image = picture78.Image;
                    break;
                case 79:
                    pic4.Image = picture79.Image;
                    break;
                case 80:
                    pic4.Image = picture80.Image;
                    break;
                case 81:
                    pic4.Image = picture81.Image;
                    break;
                case 82:
                    pic4.Image = picture82.Image;
                    break;
                case 83:
                    pic4.Image = picture83.Image;
                    break;
                case 84:
                    pic4.Image = picture84.Image;
                    break;
                case 85:
                    pic4.Image = picture85.Image;
                    break;
                case 86:
                    pic4.Image = picture86.Image;
                    break;
                case 87:
                    pic4.Image = picture87.Image;
                    break;
                case 88:
                    pic4.Image = picture88.Image;
                    break;
                case 89:
                    pic4.Image = picture89.Image;
                    break;
                case 90:
                    pic4.Image = picture90.Image;
                    break;
                case 91:
                    pic4.Image = picture91.Image;
                    break;
                case 92:
                    pic4.Image = picture92.Image;
                    break;
                case 93:
                    pic4.Image = picture93.Image;
                    break;
                case 94:
                    pic4.Image = picture94.Image;
                    break;
                case 95:
                    pic4.Image = picture95.Image;
                    break;
                case 96:
                    pic4.Image = picture96.Image;
                    break;
                case 97:
                    pic4.Image = picture97.Image;
                    break;
                case 98:
                    pic4.Image = picture98.Image;
                    break;
                case 99:
                    pic4.Image = picture99.Image;
                    break;
                case 100:
                    pic4.Image = picture100.Image;
                    break;
                case 101:
                    pic4.Image = picture101.Image;
                    break;
                case 102:
                    pic4.Image = picture102.Image;
                    break;
                case 103:
                    pic4.Image = picture103.Image;
                    break;
                case 104:
                    pic4.Image = picture104.Image;
                    break;
                default:
                    pic4.Image = picture105.Image;
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
                case 12:
                    pic5.Image = picture12.Image;
                    break;
                case 13:
                    pic5.Image = picture13.Image;
                    break;
                case 14:
                    pic5.Image = picture14.Image;
                    break;
                case 15:
                    pic5.Image = picture15.Image;
                    break;
                case 16:
                    pic5.Image = picture16.Image;
                    break;
                case 17:
                    pic5.Image = picture17.Image;
                    break;
                case 18:
                    pic5.Image = picture18.Image;
                    break;
                case 19:
                    pic5.Image = picture19.Image;
                    break;
                case 20:
                    pic5.Image = picture20.Image;
                    break;
                case 21:
                    pic5.Image = picture21.Image;
                    break;
                case 22:
                    pic5.Image = picture22.Image;
                    break;
                case 23:
                    pic5.Image = picture23.Image;
                    break;
                case 24:
                    pic5.Image = picture24.Image;
                    break;
                case 25:
                    pic5.Image = picture25.Image;
                    break;
                case 26:
                    pic5.Image = picture26.Image;
                    break;
                case 27:
                    pic5.Image = picture27.Image;
                    break;
                case 28:
                    pic5.Image = picture28.Image;
                    break;
                case 29:
                    pic5.Image = picture29.Image;
                    break;
                case 30:
                    pic5.Image = picture30.Image;
                    break;
                case 31:
                    pic5.Image = picture31.Image;
                    break;
                case 32:
                    pic5.Image = picture32.Image;
                    break;
                case 33:
                    pic5.Image = picture33.Image;
                    break;
                case 34:
                    pic5.Image = picture34.Image;
                    break;
                case 35:
                    pic5.Image = picture35.Image;
                    break;
                case 36:
                    pic5.Image = picture36.Image;
                    break;
                case 37:
                    pic5.Image = picture37.Image;
                    break;
                case 38:
                    pic5.Image = picture38.Image;
                    break;
                case 39:
                    pic5.Image = picture39.Image;
                    break;
                case 40:
                    pic5.Image = picture40.Image;
                    break;
                case 41:
                    pic5.Image = picture41.Image;
                    break;
                case 42:
                    pic5.Image = picture42.Image;
                    break;
                case 43:
                    pic5.Image = picture43.Image;
                    break;
                case 44:
                    pic5.Image = picture44.Image;
                    break;
                case 45:
                    pic5.Image = picture45.Image;
                    break;
                case 46:
                    pic5.Image = picture46.Image;
                    break;
                case 47:
                    pic5.Image = picture47.Image;
                    break;
                case 48:
                    pic5.Image = picture48.Image;
                    break;
                case 49:
                    pic5.Image = picture49.Image;
                    break;
                case 50:
                    pic5.Image = picture50.Image;
                    break;
                case 51:
                    pic5.Image = picture51.Image;
                    break;
                case 52:
                    pic5.Image = picture52.Image;
                    break;
                case 53:
                    pic5.Image = picture53.Image;
                    break;
                case 54:
                    pic5.Image = picture54.Image;
                    break;
                case 55:
                    pic5.Image = picture55.Image;
                    break;
                case 56:
                    pic5.Image = picture56.Image;
                    break;
                case 57:
                    pic5.Image = picture57.Image;
                    break;
                case 58:
                    pic5.Image = picture58.Image;
                    break;
                case 59:
                    pic5.Image = picture59.Image;
                    break;
                case 60:
                    pic5.Image = picture60.Image;
                    break;
                case 61:
                    pic5.Image = picture61.Image;
                    break;
                case 62:
                    pic5.Image = picture62.Image;
                    break;
                case 63:
                    pic5.Image = picture63.Image;
                    break;
                case 64:
                    pic5.Image = picture64.Image;
                    break;
                case 65:
                    pic5.Image = picture65.Image;
                    break;
                case 66:
                    pic5.Image = picture66.Image;
                    break;
                case 67:
                    pic5.Image = picture67.Image;
                    break;
                case 68:
                    pic5.Image = picture68.Image;
                    break;
                case 69:
                    pic5.Image = picture69.Image;
                    break;
                case 70:
                    pic5.Image = picture70.Image;
                    break;
                case 71:
                    pic5.Image = picture71.Image;
                    break;
                case 72:
                    pic5.Image = picture72.Image;
                    break;
                case 73:
                    pic5.Image = picture73.Image;
                    break;
                case 74:
                    pic5.Image = picture74.Image;
                    break;
                case 75:
                    pic5.Image = picture75.Image;
                    break;
                case 76:
                    pic5.Image = picture76.Image;
                    break;
                case 77:
                    pic5.Image = picture77.Image;
                    break;
                case 78:
                    pic5.Image = picture78.Image;
                    break;
                case 79:
                    pic5.Image = picture79.Image;
                    break;
                case 80:
                    pic5.Image = picture80.Image;
                    break;
                case 81:
                    pic5.Image = picture81.Image;
                    break;
                case 82:
                    pic5.Image = picture82.Image;
                    break;
                case 83:
                    pic5.Image = picture83.Image;
                    break;
                case 84:
                    pic5.Image = picture84.Image;
                    break;
                case 85:
                    pic5.Image = picture85.Image;
                    break;
                case 86:
                    pic5.Image = picture86.Image;
                    break;
                case 87:
                    pic5.Image = picture87.Image;
                    break;
                case 88:
                    pic5.Image = picture88.Image;
                    break;
                case 89:
                    pic5.Image = picture89.Image;
                    break;
                case 90:
                    pic5.Image = picture90.Image;
                    break;
                case 91:
                    pic5.Image = picture91.Image;
                    break;
                case 92:
                    pic5.Image = picture92.Image;
                    break;
                case 93:
                    pic5.Image = picture93.Image;
                    break;
                case 94:
                    pic5.Image = picture94.Image;
                    break;
                case 95:
                    pic5.Image = picture95.Image;
                    break;
                case 96:
                    pic5.Image = picture96.Image;
                    break;
                case 97:
                    pic5.Image = picture97.Image;
                    break;
                case 98:
                    pic5.Image = picture98.Image;
                    break;
                case 99:
                    pic5.Image = picture99.Image;
                    break;
                case 100:
                    pic5.Image = picture100.Image;
                    break;
                case 101:
                    pic5.Image = picture101.Image;
                    break;
                case 102:
                    pic5.Image = picture102.Image;
                    break;
                case 103:
                    pic5.Image = picture103.Image;
                    break;
                case 104:
                    pic5.Image = picture104.Image;
                    break;
                default:
                    pic5.Image = picture105.Image;
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
                case 12:
                    pic6.Image = picture12.Image;
                    break;
                case 13:
                    pic6.Image = picture13.Image;
                    break;
                case 14:
                    pic6.Image = picture14.Image;
                    break;
                case 15:
                    pic6.Image = picture15.Image;
                    break;
                case 16:
                    pic6.Image = picture16.Image;
                    break;
                case 17:
                    pic6.Image = picture17.Image;
                    break;
                case 18:
                    pic6.Image = picture18.Image;
                    break;
                case 19:
                    pic6.Image = picture19.Image;
                    break;
                case 20:
                    pic6.Image = picture20.Image;
                    break;
                case 21:
                    pic6.Image = picture21.Image;
                    break;
                case 22:
                    pic6.Image = picture22.Image;
                    break;
                case 23:
                    pic6.Image = picture23.Image;
                    break;
                case 24:
                    pic6.Image = picture24.Image;
                    break;
                case 25:
                    pic6.Image = picture25.Image;
                    break;
                case 26:
                    pic6.Image = picture26.Image;
                    break;
                case 27:
                    pic6.Image = picture27.Image;
                    break;
                case 28:
                    pic6.Image = picture28.Image;
                    break;
                case 29:
                    pic6.Image = picture29.Image;
                    break;
                case 30:
                    pic6.Image = picture30.Image;
                    break;
                case 31:
                    pic6.Image = picture31.Image;
                    break;
                case 32:
                    pic6.Image = picture32.Image;
                    break;
                case 33:
                    pic6.Image = picture33.Image;
                    break;
                case 34:
                    pic6.Image = picture34.Image;
                    break;
                case 35:
                    pic6.Image = picture35.Image;
                    break;
                case 36:
                    pic6.Image = picture36.Image;
                    break;
                case 37:
                    pic6.Image = picture37.Image;
                    break;
                case 38:
                    pic6.Image = picture38.Image;
                    break;
                case 39:
                    pic6.Image = picture39.Image;
                    break;
                case 40:
                    pic6.Image = picture40.Image;
                    break;
                case 41:
                    pic6.Image = picture41.Image;
                    break;
                case 42:
                    pic6.Image = picture42.Image;
                    break;
                case 43:
                    pic6.Image = picture43.Image;
                    break;
                case 44:
                    pic6.Image = picture44.Image;
                    break;
                case 45:
                    pic6.Image = picture45.Image;
                    break;
                case 46:
                    pic6.Image = picture46.Image;
                    break;
                case 47:
                    pic6.Image = picture47.Image;
                    break;
                case 48:
                    pic6.Image = picture48.Image;
                    break;
                case 49:
                    pic6.Image = picture49.Image;
                    break;
                case 50:
                    pic6.Image = picture50.Image;
                    break;
                case 51:
                    pic6.Image = picture51.Image;
                    break;
                case 52:
                    pic6.Image = picture52.Image;
                    break;
                case 53:
                    pic6.Image = picture53.Image;
                    break;
                case 54:
                    pic6.Image = picture54.Image;
                    break;
                case 55:
                    pic6.Image = picture55.Image;
                    break;
                case 56:
                    pic6.Image = picture56.Image;
                    break;
                case 57:
                    pic6.Image = picture57.Image;
                    break;
                case 58:
                    pic6.Image = picture58.Image;
                    break;
                case 59:
                    pic6.Image = picture59.Image;
                    break;
                case 60:
                    pic6.Image = picture60.Image;
                    break;
                case 61:
                    pic6.Image = picture61.Image;
                    break;
                case 62:
                    pic6.Image = picture62.Image;
                    break;
                case 63:
                    pic6.Image = picture63.Image;
                    break;
                case 64:
                    pic6.Image = picture64.Image;
                    break;
                case 65:
                    pic6.Image = picture65.Image;
                    break;
                case 66:
                    pic6.Image = picture66.Image;
                    break;
                case 67:
                    pic6.Image = picture67.Image;
                    break;
                case 68:
                    pic6.Image = picture68.Image;
                    break;
                case 69:
                    pic6.Image = picture69.Image;
                    break;
                case 70:
                    pic6.Image = picture70.Image;
                    break;
                case 71:
                    pic6.Image = picture71.Image;
                    break;
                case 72:
                    pic6.Image = picture72.Image;
                    break;
                case 73:
                    pic6.Image = picture73.Image;
                    break;
                case 74:
                    pic6.Image = picture74.Image;
                    break;
                case 75:
                    pic6.Image = picture75.Image;
                    break;
                case 76:
                    pic6.Image = picture76.Image;
                    break;
                case 77:
                    pic6.Image = picture77.Image;
                    break;
                case 78:
                    pic6.Image = picture78.Image;
                    break;
                case 79:
                    pic6.Image = picture79.Image;
                    break;
                case 80:
                    pic6.Image = picture80.Image;
                    break;
                case 81:
                    pic6.Image = picture81.Image;
                    break;
                case 82:
                    pic6.Image = picture82.Image;
                    break;
                case 83:
                    pic6.Image = picture83.Image;
                    break;
                case 84:
                    pic6.Image = picture84.Image;
                    break;
                case 85:
                    pic6.Image = picture85.Image;
                    break;
                case 86:
                    pic6.Image = picture86.Image;
                    break;
                case 87:
                    pic6.Image = picture87.Image;
                    break;
                case 88:
                    pic6.Image = picture88.Image;
                    break;
                case 89:
                    pic6.Image = picture89.Image;
                    break;
                case 90:
                    pic6.Image = picture90.Image;
                    break;
                case 91:
                    pic6.Image = picture91.Image;
                    break;
                case 92:
                    pic6.Image = picture92.Image;
                    break;
                case 93:
                    pic6.Image = picture93.Image;
                    break;
                case 94:
                    pic6.Image = picture94.Image;
                    break;
                case 95:
                    pic6.Image = picture95.Image;
                    break;
                case 96:
                    pic6.Image = picture96.Image;
                    break;
                case 97:
                    pic6.Image = picture97.Image;
                    break;
                case 98:
                    pic6.Image = picture98.Image;
                    break;
                case 99:
                    pic6.Image = picture99.Image;
                    break;
                case 100:
                    pic6.Image = picture100.Image;
                    break;
                case 101:
                    pic6.Image = picture101.Image;
                    break;
                case 102:
                    pic6.Image = picture102.Image;
                    break;
                case 103:
                    pic6.Image = picture103.Image;
                    break;
                case 104:
                    pic6.Image = picture104.Image;
                    break;
                default:
                    pic6.Image = picture105.Image;
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
                case 12:
                    pic7.Image = picture12.Image;
                    break;
                case 13:
                    pic7.Image = picture13.Image;
                    break;
                case 14:
                    pic7.Image = picture14.Image;
                    break;
                case 15:
                    pic7.Image = picture15.Image;
                    break;
                case 16:
                    pic7.Image = picture16.Image;
                    break;
                case 17:
                    pic7.Image = picture17.Image;
                    break;
                case 18:
                    pic7.Image = picture18.Image;
                    break;
                case 19:
                    pic7.Image = picture19.Image;
                    break;
                case 20:
                    pic7.Image = picture20.Image;
                    break;
                case 21:
                    pic7.Image = picture21.Image;
                    break;
                case 22:
                    pic7.Image = picture22.Image;
                    break;
                case 23:
                    pic7.Image = picture23.Image;
                    break;
                case 24:
                    pic7.Image = picture24.Image;
                    break;
                case 25:
                    pic7.Image = picture25.Image;
                    break;
                case 26:
                    pic7.Image = picture26.Image;
                    break;
                case 27:
                    pic7.Image = picture27.Image;
                    break;
                case 28:
                    pic7.Image = picture28.Image;
                    break;
                case 29:
                    pic7.Image = picture29.Image;
                    break;
                case 30:
                    pic7.Image = picture30.Image;
                    break;
                case 31:
                    pic7.Image = picture31.Image;
                    break;
                case 32:
                    pic7.Image = picture32.Image;
                    break;
                case 33:
                    pic7.Image = picture33.Image;
                    break;
                case 34:
                    pic7.Image = picture34.Image;
                    break;
                case 35:
                    pic7.Image = picture35.Image;
                    break;
                case 36:
                    pic7.Image = picture36.Image;
                    break;
                case 37:
                    pic7.Image = picture37.Image;
                    break;
                case 38:
                    pic7.Image = picture38.Image;
                    break;
                case 39:
                    pic7.Image = picture39.Image;
                    break;
                case 40:
                    pic7.Image = picture40.Image;
                    break;
                case 41:
                    pic7.Image = picture41.Image;
                    break;
                case 42:
                    pic7.Image = picture42.Image;
                    break;
                case 43:
                    pic7.Image = picture43.Image;
                    break;
                case 44:
                    pic7.Image = picture44.Image;
                    break;
                case 45:
                    pic7.Image = picture45.Image;
                    break;
                case 46:
                    pic7.Image = picture46.Image;
                    break;
                case 47:
                    pic7.Image = picture47.Image;
                    break;
                case 48:
                    pic7.Image = picture48.Image;
                    break;
                case 49:
                    pic7.Image = picture49.Image;
                    break;
                case 50:
                    pic7.Image = picture50.Image;
                    break;
                case 51:
                    pic7.Image = picture51.Image;
                    break;
                case 52:
                    pic7.Image = picture52.Image;
                    break;
                case 53:
                    pic7.Image = picture53.Image;
                    break;
                case 54:
                    pic7.Image = picture54.Image;
                    break;
                case 55:
                    pic7.Image = picture55.Image;
                    break;
                case 56:
                    pic7.Image = picture56.Image;
                    break;
                case 57:
                    pic7.Image = picture57.Image;
                    break;
                case 58:
                    pic7.Image = picture58.Image;
                    break;
                case 59:
                    pic7.Image = picture59.Image;
                    break;
                case 60:
                    pic7.Image = picture60.Image;
                    break;
                case 61:
                    pic7.Image = picture61.Image;
                    break;
                case 62:
                    pic7.Image = picture62.Image;
                    break;
                case 63:
                    pic7.Image = picture63.Image;
                    break;
                case 64:
                    pic7.Image = picture64.Image;
                    break;
                case 65:
                    pic7.Image = picture65.Image;
                    break;
                case 66:
                    pic7.Image = picture66.Image;
                    break;
                case 67:
                    pic7.Image = picture67.Image;
                    break;
                case 68:
                    pic7.Image = picture68.Image;
                    break;
                case 69:
                    pic7.Image = picture69.Image;
                    break;
                case 70:
                    pic7.Image = picture70.Image;
                    break;
                case 71:
                    pic7.Image = picture71.Image;
                    break;
                case 72:
                    pic7.Image = picture72.Image;
                    break;
                case 73:
                    pic7.Image = picture73.Image;
                    break;
                case 74:
                    pic7.Image = picture74.Image;
                    break;
                case 75:
                    pic7.Image = picture75.Image;
                    break;
                case 76:
                    pic7.Image = picture76.Image;
                    break;
                case 77:
                    pic7.Image = picture77.Image;
                    break;
                case 78:
                    pic7.Image = picture78.Image;
                    break;
                case 79:
                    pic7.Image = picture79.Image;
                    break;
                case 80:
                    pic7.Image = picture80.Image;
                    break;
                case 81:
                    pic7.Image = picture81.Image;
                    break;
                case 82:
                    pic7.Image = picture82.Image;
                    break;
                case 83:
                    pic7.Image = picture83.Image;
                    break;
                case 84:
                    pic7.Image = picture84.Image;
                    break;
                case 85:
                    pic7.Image = picture85.Image;
                    break;
                case 86:
                    pic7.Image = picture86.Image;
                    break;
                case 87:
                    pic7.Image = picture87.Image;
                    break;
                case 88:
                    pic7.Image = picture88.Image;
                    break;
                case 89:
                    pic7.Image = picture89.Image;
                    break;
                case 90:
                    pic7.Image = picture90.Image;
                    break;
                case 91:
                    pic7.Image = picture91.Image;
                    break;
                case 92:
                    pic7.Image = picture92.Image;
                    break;
                case 93:
                    pic7.Image = picture93.Image;
                    break;
                case 94:
                    pic7.Image = picture94.Image;
                    break;
                case 95:
                    pic7.Image = picture95.Image;
                    break;
                case 96:
                    pic7.Image = picture96.Image;
                    break;
                case 97:
                    pic7.Image = picture97.Image;
                    break;
                case 98:
                    pic7.Image = picture98.Image;
                    break;
                case 99:
                    pic7.Image = picture99.Image;
                    break;
                case 100:
                    pic7.Image = picture100.Image;
                    break;
                case 101:
                    pic7.Image = picture101.Image;
                    break;
                case 102:
                    pic7.Image = picture102.Image;
                    break;
                case 103:
                    pic7.Image = picture103.Image;
                    break;
                case 104:
                    pic7.Image = picture104.Image;
                    break;
                default:
                    pic7.Image = picture105.Image;
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
                case 12:
                    pic8.Image = picture12.Image;
                    break;
                case 13:
                    pic8.Image = picture13.Image;
                    break;
                case 14:
                    pic8.Image = picture14.Image;
                    break;
                case 15:
                    pic8.Image = picture15.Image;
                    break;
                case 16:
                    pic8.Image = picture16.Image;
                    break;
                case 17:
                    pic8.Image = picture17.Image;
                    break;
                case 18:
                    pic8.Image = picture18.Image;
                    break;
                case 19:
                    pic8.Image = picture19.Image;
                    break;
                case 20:
                    pic8.Image = picture20.Image;
                    break;
                case 21:
                    pic8.Image = picture21.Image;
                    break;
                case 22:
                    pic8.Image = picture22.Image;
                    break;
                case 23:
                    pic8.Image = picture23.Image;
                    break;
                case 24:
                    pic8.Image = picture24.Image;
                    break;
                case 25:
                    pic8.Image = picture25.Image;
                    break;
                case 26:
                    pic8.Image = picture26.Image;
                    break;
                case 27:
                    pic8.Image = picture27.Image;
                    break;
                case 28:
                    pic8.Image = picture28.Image;
                    break;
                case 29:
                    pic8.Image = picture29.Image;
                    break;
                case 30:
                    pic8.Image = picture30.Image;
                    break;
                case 31:
                    pic8.Image = picture31.Image;
                    break;
                case 32:
                    pic8.Image = picture32.Image;
                    break;
                case 33:
                    pic8.Image = picture33.Image;
                    break;
                case 34:
                    pic8.Image = picture34.Image;
                    break;
                case 35:
                    pic8.Image = picture35.Image;
                    break;
                case 36:
                    pic8.Image = picture36.Image;
                    break;
                case 37:
                    pic8.Image = picture37.Image;
                    break;
                case 38:
                    pic8.Image = picture38.Image;
                    break;
                case 39:
                    pic8.Image = picture39.Image;
                    break;
                case 40:
                    pic8.Image = picture40.Image;
                    break;
                case 41:
                    pic8.Image = picture41.Image;
                    break;
                case 42:
                    pic8.Image = picture42.Image;
                    break;
                case 43:
                    pic8.Image = picture43.Image;
                    break;
                case 44:
                    pic8.Image = picture44.Image;
                    break;
                case 45:
                    pic8.Image = picture45.Image;
                    break;
                case 46:
                    pic8.Image = picture46.Image;
                    break;
                case 47:
                    pic8.Image = picture47.Image;
                    break;
                case 48:
                    pic8.Image = picture48.Image;
                    break;
                case 49:
                    pic8.Image = picture49.Image;
                    break;
                case 50:
                    pic8.Image = picture50.Image;
                    break;
                case 51:
                    pic8.Image = picture51.Image;
                    break;
                case 52:
                    pic8.Image = picture52.Image;
                    break;
                case 53:
                    pic8.Image = picture53.Image;
                    break;
                case 54:
                    pic8.Image = picture54.Image;
                    break;
                case 55:
                    pic8.Image = picture55.Image;
                    break;
                case 56:
                    pic8.Image = picture56.Image;
                    break;
                case 57:
                    pic8.Image = picture57.Image;
                    break;
                case 58:
                    pic8.Image = picture58.Image;
                    break;
                case 59:
                    pic8.Image = picture59.Image;
                    break;
                case 60:
                    pic8.Image = picture60.Image;
                    break;
                case 61:
                    pic8.Image = picture61.Image;
                    break;
                case 62:
                    pic8.Image = picture62.Image;
                    break;
                case 63:
                    pic8.Image = picture63.Image;
                    break;
                case 64:
                    pic8.Image = picture64.Image;
                    break;
                case 65:
                    pic8.Image = picture65.Image;
                    break;
                case 66:
                    pic8.Image = picture66.Image;
                    break;
                case 67:
                    pic8.Image = picture67.Image;
                    break;
                case 68:
                    pic8.Image = picture68.Image;
                    break;
                case 69:
                    pic8.Image = picture69.Image;
                    break;
                case 70:
                    pic8.Image = picture70.Image;
                    break;
                case 71:
                    pic8.Image = picture71.Image;
                    break;
                case 72:
                    pic8.Image = picture72.Image;
                    break;
                case 73:
                    pic8.Image = picture73.Image;
                    break;
                case 74:
                    pic8.Image = picture74.Image;
                    break;
                case 75:
                    pic8.Image = picture75.Image;
                    break;
                case 76:
                    pic8.Image = picture76.Image;
                    break;
                case 77:
                    pic8.Image = picture77.Image;
                    break;
                case 78:
                    pic8.Image = picture78.Image;
                    break;
                case 79:
                    pic8.Image = picture79.Image;
                    break;
                case 80:
                    pic8.Image = picture80.Image;
                    break;
                case 81:
                    pic8.Image = picture81.Image;
                    break;
                case 82:
                    pic8.Image = picture82.Image;
                    break;
                case 83:
                    pic8.Image = picture83.Image;
                    break;
                case 84:
                    pic8.Image = picture84.Image;
                    break;
                case 85:
                    pic8.Image = picture85.Image;
                    break;
                case 86:
                    pic8.Image = picture86.Image;
                    break;
                case 87:
                    pic8.Image = picture87.Image;
                    break;
                case 88:
                    pic8.Image = picture88.Image;
                    break;
                case 89:
                    pic8.Image = picture89.Image;
                    break;
                case 90:
                    pic8.Image = picture90.Image;
                    break;
                case 91:
                    pic8.Image = picture91.Image;
                    break;
                case 92:
                    pic8.Image = picture92.Image;
                    break;
                case 93:
                    pic8.Image = picture93.Image;
                    break;
                case 94:
                    pic8.Image = picture94.Image;
                    break;
                case 95:
                    pic8.Image = picture95.Image;
                    break;
                case 96:
                    pic8.Image = picture96.Image;
                    break;
                case 97:
                    pic8.Image = picture97.Image;
                    break;
                case 98:
                    pic8.Image = picture98.Image;
                    break;
                case 99:
                    pic8.Image = picture99.Image;
                    break;
                case 100:
                    pic8.Image = picture100.Image;
                    break;
                case 101:
                    pic8.Image = picture101.Image;
                    break;
                case 102:
                    pic8.Image = picture102.Image;
                    break;
                case 103:
                    pic8.Image = picture103.Image;
                    break;
                case 104:
                    pic8.Image = picture104.Image;
                    break;
                default:
                    pic8.Image = picture105.Image;
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
                case 7:
                    pic9.Image = picture7.Image;
                    break;
                case 8:
                    pic9.Image = picture8.Image;
                    break;
                case 9:
                    pic9.Image = picture9.Image;
                    break;
                case 10:
                    pic9.Image = picture10.Image;
                    break;
                case 11:
                    pic9.Image = picture11.Image;
                    break;
                case 12:
                    pic9.Image = picture12.Image;
                    break;
                case 13:
                    pic9.Image = picture13.Image;
                    break;
                case 14:
                    pic9.Image = picture14.Image;
                    break;
                case 15:
                    pic9.Image = picture15.Image;
                    break;
                case 16:
                    pic9.Image = picture16.Image;
                    break;
                case 17:
                    pic9.Image = picture17.Image;
                    break;
                case 18:
                    pic9.Image = picture18.Image;
                    break;
                case 19:
                    pic9.Image = picture19.Image;
                    break;
                case 20:
                    pic9.Image = picture20.Image;
                    break;
                case 21:
                    pic9.Image = picture21.Image;
                    break;
                case 22:
                    pic9.Image = picture22.Image;
                    break;
                case 23:
                    pic9.Image = picture23.Image;
                    break;
                case 24:
                    pic9.Image = picture24.Image;
                    break;
                case 25:
                    pic9.Image = picture25.Image;
                    break;
                case 26:
                    pic9.Image = picture26.Image;
                    break;
                case 27:
                    pic9.Image = picture27.Image;
                    break;
                case 28:
                    pic9.Image = picture28.Image;
                    break;
                case 29:
                    pic9.Image = picture29.Image;
                    break;
                case 30:
                    pic9.Image = picture30.Image;
                    break;
                case 31:
                    pic9.Image = picture31.Image;
                    break;
                case 32:
                    pic9.Image = picture32.Image;
                    break;
                case 33:
                    pic9.Image = picture33.Image;
                    break;
                case 34:
                    pic9.Image = picture34.Image;
                    break;
                case 35:
                    pic9.Image = picture35.Image;
                    break;
                case 36:
                    pic9.Image = picture36.Image;
                    break;
                case 37:
                    pic9.Image = picture37.Image;
                    break;
                case 38:
                    pic9.Image = picture38.Image;
                    break;
                case 39:
                    pic9.Image = picture39.Image;
                    break;
                case 40:
                    pic9.Image = picture40.Image;
                    break;
                case 41:
                    pic9.Image = picture41.Image;
                    break;
                case 42:
                    pic9.Image = picture42.Image;
                    break;
                case 43:
                    pic9.Image = picture43.Image;
                    break;
                case 44:
                    pic9.Image = picture44.Image;
                    break;
                case 45:
                    pic9.Image = picture45.Image;
                    break;
                case 46:
                    pic9.Image = picture46.Image;
                    break;
                case 47:
                    pic9.Image = picture47.Image;
                    break;
                case 48:
                    pic9.Image = picture48.Image;
                    break;
                case 49:
                    pic9.Image = picture49.Image;
                    break;
                case 50:
                    pic9.Image = picture50.Image;
                    break;
                case 51:
                    pic9.Image = picture51.Image;
                    break;
                case 52:
                    pic9.Image = picture52.Image;
                    break;
                case 53:
                    pic9.Image = picture53.Image;
                    break;
                case 54:
                    pic9.Image = picture54.Image;
                    break;
                case 55:
                    pic9.Image = picture55.Image;
                    break;
                case 56:
                    pic9.Image = picture56.Image;
                    break;
                case 57:
                    pic9.Image = picture57.Image;
                    break;
                case 58:
                    pic9.Image = picture58.Image;
                    break;
                case 59:
                    pic9.Image = picture59.Image;
                    break;
                case 60:
                    pic9.Image = picture60.Image;
                    break;
                case 61:
                    pic9.Image = picture61.Image;
                    break;
                case 62:
                    pic9.Image = picture62.Image;
                    break;
                case 63:
                    pic9.Image = picture63.Image;
                    break;
                case 64:
                    pic9.Image = picture64.Image;
                    break;
                case 65:
                    pic9.Image = picture65.Image;
                    break;
                case 66:
                    pic9.Image = picture66.Image;
                    break;
                case 67:
                    pic9.Image = picture67.Image;
                    break;
                case 68:
                    pic9.Image = picture68.Image;
                    break;
                case 69:
                    pic9.Image = picture69.Image;
                    break;
                case 70:
                    pic9.Image = picture70.Image;
                    break;
                case 71:
                    pic9.Image = picture71.Image;
                    break;
                case 72:
                    pic9.Image = picture72.Image;
                    break;
                case 73:
                    pic9.Image = picture73.Image;
                    break;
                case 74:
                    pic9.Image = picture74.Image;
                    break;
                case 75:
                    pic9.Image = picture75.Image;
                    break;
                case 76:
                    pic9.Image = picture76.Image;
                    break;
                case 77:
                    pic9.Image = picture77.Image;
                    break;
                case 78:
                    pic9.Image = picture78.Image;
                    break;
                case 79:
                    pic9.Image = picture79.Image;
                    break;
                case 80:
                    pic9.Image = picture80.Image;
                    break;
                case 81:
                    pic9.Image = picture81.Image;
                    break;
                case 82:
                    pic9.Image = picture82.Image;
                    break;
                case 83:
                    pic9.Image = picture83.Image;
                    break;
                case 84:
                    pic9.Image = picture84.Image;
                    break;
                case 85:
                    pic9.Image = picture85.Image;
                    break;
                case 86:
                    pic9.Image = picture86.Image;
                    break;
                case 87:
                    pic9.Image = picture87.Image;
                    break;
                case 88:
                    pic9.Image = picture88.Image;
                    break;
                case 89:
                    pic9.Image = picture89.Image;
                    break;
                case 90:
                    pic9.Image = picture90.Image;
                    break;
                case 91:
                    pic9.Image = picture91.Image;
                    break;
                case 92:
                    pic9.Image = picture92.Image;
                    break;
                case 93:
                    pic9.Image = picture93.Image;
                    break;
                case 94:
                    pic9.Image = picture94.Image;
                    break;
                case 95:
                    pic9.Image = picture95.Image;
                    break;
                case 96:
                    pic9.Image = picture96.Image;
                    break;
                case 97:
                    pic9.Image = picture97.Image;
                    break;
                case 98:
                    pic9.Image = picture98.Image;
                    break;
                case 99:
                    pic9.Image = picture99.Image;
                    break;
                case 100:
                    pic9.Image = picture100.Image;
                    break;
                case 101:
                    pic9.Image = picture101.Image;
                    break;
                case 102:
                    pic9.Image = picture102.Image;
                    break;
                case 103:
                    pic9.Image = picture103.Image;
                    break;
                case 104:
                    pic9.Image = picture104.Image;
                    break;
                default:
                    pic9.Image = picture105.Image;
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
                case 7:
                    pica.Image = picture7.Image;
                    break;
                case 8:
                    pica.Image = picture8.Image;
                    break;
                case 9:
                    pica.Image = picture9.Image;
                    break;
                case 10:
                    pica.Image = picture10.Image;
                    break;
                case 11:
                    pica.Image = picture11.Image;
                    break;
                case 12:
                    pica.Image = picture12.Image;
                    break;
                case 13:
                    pica.Image = picture13.Image;
                    break;
                case 14:
                    pica.Image = picture14.Image;
                    break;
                case 15:
                    pica.Image = picture15.Image;
                    break;
                case 16:
                    pica.Image = picture16.Image;
                    break;
                case 17:
                    pica.Image = picture17.Image;
                    break;
                case 18:
                    pica.Image = picture18.Image;
                    break;
                case 19:
                    pica.Image = picture19.Image;
                    break;
                case 20:
                    pica.Image = picture20.Image;
                    break;
                case 21:
                    pica.Image = picture21.Image;
                    break;
                case 22:
                    pica.Image = picture22.Image;
                    break;
                case 23:
                    pica.Image = picture23.Image;
                    break;
                case 24:
                    pica.Image = picture24.Image;
                    break;
                case 25:
                    pica.Image = picture25.Image;
                    break;
                case 26:
                    pica.Image = picture26.Image;
                    break;
                case 27:
                    pica.Image = picture27.Image;
                    break;
                case 28:
                    pica.Image = picture28.Image;
                    break;
                case 29:
                    pica.Image = picture29.Image;
                    break;
                case 30:
                    pica.Image = picture30.Image;
                    break;
                case 31:
                    pica.Image = picture31.Image;
                    break;
                case 32:
                    pica.Image = picture32.Image;
                    break;
                case 33:
                    pica.Image = picture33.Image;
                    break;
                case 34:
                    pica.Image = picture34.Image;
                    break;
                case 35:
                    pica.Image = picture35.Image;
                    break;
                case 36:
                    pica.Image = picture36.Image;
                    break;
                case 37:
                    pica.Image = picture37.Image;
                    break;
                case 38:
                    pica.Image = picture38.Image;
                    break;
                case 39:
                    pica.Image = picture39.Image;
                    break;
                case 40:
                    pica.Image = picture40.Image;
                    break;
                case 41:
                    pica.Image = picture41.Image;
                    break;
                case 42:
                    pica.Image = picture42.Image;
                    break;
                case 43:
                    pica.Image = picture43.Image;
                    break;
                case 44:
                    pica.Image = picture44.Image;
                    break;
                case 45:
                    pica.Image = picture45.Image;
                    break;
                case 46:
                    pica.Image = picture46.Image;
                    break;
                case 47:
                    pica.Image = picture47.Image;
                    break;
                case 48:
                    pica.Image = picture48.Image;
                    break;
                case 49:
                    pica.Image = picture49.Image;
                    break;
                case 50:
                    pica.Image = picture50.Image;
                    break;
                case 51:
                    pica.Image = picture51.Image;
                    break;
                case 52:
                    pica.Image = picture52.Image;
                    break;
                case 53:
                    pica.Image = picture53.Image;
                    break;
                case 54:
                    pica.Image = picture54.Image;
                    break;
                case 55:
                    pica.Image = picture55.Image;
                    break;
                case 56:
                    pica.Image = picture56.Image;
                    break;
                case 57:
                    pica.Image = picture57.Image;
                    break;
                case 58:
                    pica.Image = picture58.Image;
                    break;
                case 59:
                    pica.Image = picture59.Image;
                    break;
                case 60:
                    pica.Image = picture60.Image;
                    break;
                case 61:
                    pica.Image = picture61.Image;
                    break;
                case 62:
                    pica.Image = picture62.Image;
                    break;
                case 63:
                    pica.Image = picture63.Image;
                    break;
                case 64:
                    pica.Image = picture64.Image;
                    break;
                case 65:
                    pica.Image = picture65.Image;
                    break;
                case 66:
                    pica.Image = picture66.Image;
                    break;
                case 67:
                    pica.Image = picture67.Image;
                    break;
                case 68:
                    pica.Image = picture68.Image;
                    break;
                case 69:
                    pica.Image = picture69.Image;
                    break;
                case 70:
                    pica.Image = picture70.Image;
                    break;
                case 71:
                    pica.Image = picture71.Image;
                    break;
                case 72:
                    pica.Image = picture72.Image;
                    break;
                case 73:
                    pica.Image = picture73.Image;
                    break;
                case 74:
                    pica.Image = picture74.Image;
                    break;
                case 75:
                    pica.Image = picture75.Image;
                    break;
                case 76:
                    pica.Image = picture76.Image;
                    break;
                case 77:
                    pica.Image = picture77.Image;
                    break;
                case 78:
                    pica.Image = picture78.Image;
                    break;
                case 79:
                    pica.Image = picture79.Image;
                    break;
                case 80:
                    pica.Image = picture80.Image;
                    break;
                case 81:
                    pica.Image = picture81.Image;
                    break;
                case 82:
                    pica.Image = picture82.Image;
                    break;
                case 83:
                    pica.Image = picture83.Image;
                    break;
                case 84:
                    pica.Image = picture84.Image;
                    break;
                case 85:
                    pica.Image = picture85.Image;
                    break;
                case 86:
                    pica.Image = picture86.Image;
                    break;
                case 87:
                    pica.Image = picture87.Image;
                    break;
                case 88:
                    pica.Image = picture88.Image;
                    break;
                case 89:
                    pica.Image = picture89.Image;
                    break;
                case 90:
                    pica.Image = picture90.Image;
                    break;
                case 91:
                    pica.Image = picture91.Image;
                    break;
                case 92:
                    pica.Image = picture92.Image;
                    break;
                case 93:
                    pica.Image = picture93.Image;
                    break;
                case 94:
                    pica.Image = picture94.Image;
                    break;
                case 95:
                    pica.Image = picture95.Image;
                    break;
                case 96:
                    pica.Image = picture96.Image;
                    break;
                case 97:
                    pica.Image = picture97.Image;
                    break;
                case 98:
                    pica.Image = picture98.Image;
                    break;
                case 99:
                    pica.Image = picture99.Image;
                    break;
                case 100:
                    pica.Image = picture100.Image;
                    break;
                case 101:
                    pica.Image = picture101.Image;
                    break;
                case 102:
                    pica.Image = picture102.Image;
                    break;
                case 103:
                    pica.Image = picture103.Image;
                    break;
                case 104:
                    pica.Image = picture104.Image;
                    break;
                default:
                    pica.Image = picture105.Image;
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
                case 7:
                    picb.Image = picture7.Image;
                    break;
                case 8:
                    picb.Image = picture8.Image;
                    break;
                case 9:
                    picb.Image = picture9.Image;
                    break;
                case 10:
                    picb.Image = picture10.Image;
                    break;
                case 11:
                    picb.Image = picture11.Image;
                    break;
                case 12:
                    picb.Image = picture12.Image;
                    break;
                case 13:
                    picb.Image = picture13.Image;
                    break;
                case 14:
                    picb.Image = picture14.Image;
                    break;
                case 15:
                    picb.Image = picture15.Image;
                    break;
                case 16:
                    picb.Image = picture16.Image;
                    break;
                case 17:
                    picb.Image = picture17.Image;
                    break;
                case 18:
                    picb.Image = picture18.Image;
                    break;
                case 19:
                    picb.Image = picture19.Image;
                    break;
                case 20:
                    picb.Image = picture20.Image;
                    break;
                case 21:
                    picb.Image = picture21.Image;
                    break;
                case 22:
                    picb.Image = picture22.Image;
                    break;
                case 23:
                    picb.Image = picture23.Image;
                    break;
                case 24:
                    picb.Image = picture24.Image;
                    break;
                case 25:
                    picb.Image = picture25.Image;
                    break;
                case 26:
                    picb.Image = picture26.Image;
                    break;
                case 27:
                    picb.Image = picture27.Image;
                    break;
                case 28:
                    picb.Image = picture28.Image;
                    break;
                case 29:
                    picb.Image = picture29.Image;
                    break;
                case 30:
                    picb.Image = picture30.Image;
                    break;
                case 31:
                    picb.Image = picture31.Image;
                    break;
                case 32:
                    picb.Image = picture32.Image;
                    break;
                case 33:
                    picb.Image = picture33.Image;
                    break;
                case 34:
                    picb.Image = picture34.Image;
                    break;
                case 35:
                    picb.Image = picture35.Image;
                    break;
                case 36:
                    picb.Image = picture36.Image;
                    break;
                case 37:
                    picb.Image = picture37.Image;
                    break;
                case 38:
                    picb.Image = picture38.Image;
                    break;
                case 39:
                    picb.Image = picture39.Image;
                    break;
                case 40:
                    picb.Image = picture40.Image;
                    break;
                case 41:
                    picb.Image = picture41.Image;
                    break;
                case 42:
                    picb.Image = picture42.Image;
                    break;
                case 43:
                    picb.Image = picture43.Image;
                    break;
                case 44:
                    picb.Image = picture44.Image;
                    break;
                case 45:
                    picb.Image = picture45.Image;
                    break;
                case 46:
                    picb.Image = picture46.Image;
                    break;
                case 47:
                    picb.Image = picture47.Image;
                    break;
                case 48:
                    picb.Image = picture48.Image;
                    break;
                case 49:
                    picb.Image = picture49.Image;
                    break;
                case 50:
                    picb.Image = picture50.Image;
                    break;
                case 51:
                    picb.Image = picture51.Image;
                    break;
                case 52:
                    picb.Image = picture52.Image;
                    break;
                case 53:
                    picb.Image = picture53.Image;
                    break;
                case 54:
                    picb.Image = picture54.Image;
                    break;
                case 55:
                    picb.Image = picture55.Image;
                    break;
                case 56:
                    picb.Image = picture56.Image;
                    break;
                case 57:
                    picb.Image = picture57.Image;
                    break;
                case 58:
                    picb.Image = picture58.Image;
                    break;
                case 59:
                    picb.Image = picture59.Image;
                    break;
                case 60:
                    picb.Image = picture60.Image;
                    break;
                case 61:
                    picb.Image = picture61.Image;
                    break;
                case 62:
                    picb.Image = picture62.Image;
                    break;
                case 63:
                    picb.Image = picture63.Image;
                    break;
                case 64:
                    picb.Image = picture64.Image;
                    break;
                case 65:
                    picb.Image = picture65.Image;
                    break;
                case 66:
                    picb.Image = picture66.Image;
                    break;
                case 67:
                    picb.Image = picture67.Image;
                    break;
                case 68:
                    picb.Image = picture68.Image;
                    break;
                case 69:
                    picb.Image = picture69.Image;
                    break;
                case 70:
                    picb.Image = picture70.Image;
                    break;
                case 71:
                    picb.Image = picture71.Image;
                    break;
                case 72:
                    picb.Image = picture72.Image;
                    break;
                case 73:
                    picb.Image = picture73.Image;
                    break;
                case 74:
                    picb.Image = picture74.Image;
                    break;
                case 75:
                    picb.Image = picture75.Image;
                    break;
                case 76:
                    picb.Image = picture76.Image;
                    break;
                case 77:
                    picb.Image = picture77.Image;
                    break;
                case 78:
                    picb.Image = picture78.Image;
                    break;
                case 79:
                    picb.Image = picture79.Image;
                    break;
                case 80:
                    picb.Image = picture80.Image;
                    break;
                case 81:
                    picb.Image = picture81.Image;
                    break;
                case 82:
                    picb.Image = picture82.Image;
                    break;
                case 83:
                    picb.Image = picture83.Image;
                    break;
                case 84:
                    picb.Image = picture84.Image;
                    break;
                case 85:
                    picb.Image = picture85.Image;
                    break;
                case 86:
                    picb.Image = picture86.Image;
                    break;
                case 87:
                    picb.Image = picture87.Image;
                    break;
                case 88:
                    picb.Image = picture88.Image;
                    break;
                case 89:
                    picb.Image = picture89.Image;
                    break;
                case 90:
                    picb.Image = picture90.Image;
                    break;
                case 91:
                    picb.Image = picture91.Image;
                    break;
                case 92:
                    picb.Image = picture92.Image;
                    break;
                case 93:
                    picb.Image = picture93.Image;
                    break;
                case 94:
                    picb.Image = picture94.Image;
                    break;
                case 95:
                    picb.Image = picture95.Image;
                    break;
                case 96:
                    picb.Image = picture96.Image;
                    break;
                case 97:
                    picb.Image = picture97.Image;
                    break;
                case 98:
                    picb.Image = picture98.Image;
                    break;
                case 99:
                    picb.Image = picture99.Image;
                    break;
                case 100:
                    picb.Image = picture100.Image;
                    break;
                case 101:
                    picb.Image = picture101.Image;
                    break;
                case 102:
                    picb.Image = picture102.Image;
                    break;
                case 103:
                    picb.Image = picture103.Image;
                    break;
                case 104:
                    picb.Image = picture104.Image;
                    break;
                default:
                    picb.Image = picture105.Image;
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
                case 7:
                    picc.Image = picture7.Image;
                    break;
                case 8:
                    picc.Image = picture8.Image;
                    break;
                case 9:
                    picc.Image = picture9.Image;
                    break;
                case 10:
                    picc.Image = picture10.Image;
                    break;
                case 11:
                    picc.Image = picture11.Image;
                    break;
                case 12:
                    picc.Image = picture12.Image;
                    break;
                case 13:
                    picc.Image = picture13.Image;
                    break;
                case 14:
                    picc.Image = picture14.Image;
                    break;
                case 15:
                    picc.Image = picture15.Image;
                    break;
                case 16:
                    picc.Image = picture16.Image;
                    break;
                case 17:
                    picc.Image = picture17.Image;
                    break;
                case 18:
                    picc.Image = picture18.Image;
                    break;
                case 19:
                    picc.Image = picture19.Image;
                    break;
                case 20:
                    picc.Image = picture20.Image;
                    break;
                case 21:
                    picc.Image = picture21.Image;
                    break;
                case 22:
                    picc.Image = picture22.Image;
                    break;
                case 23:
                    picc.Image = picture23.Image;
                    break;
                case 24:
                    picc.Image = picture24.Image;
                    break;
                case 25:
                    picc.Image = picture25.Image;
                    break;
                case 26:
                    picc.Image = picture26.Image;
                    break;
                case 27:
                    picc.Image = picture27.Image;
                    break;
                case 28:
                    picc.Image = picture28.Image;
                    break;
                case 29:
                    picc.Image = picture29.Image;
                    break;
                case 30:
                    picc.Image = picture30.Image;
                    break;
                case 31:
                    picc.Image = picture31.Image;
                    break;
                case 32:
                    picc.Image = picture32.Image;
                    break;
                case 33:
                    picc.Image = picture33.Image;
                    break;
                case 34:
                    picc.Image = picture34.Image;
                    break;
                case 35:
                    picc.Image = picture35.Image;
                    break;
                case 36:
                    picc.Image = picture36.Image;
                    break;
                case 37:
                    picc.Image = picture37.Image;
                    break;
                case 38:
                    picc.Image = picture38.Image;
                    break;
                case 39:
                    picc.Image = picture39.Image;
                    break;
                case 40:
                    picc.Image = picture40.Image;
                    break;
                case 41:
                    picc.Image = picture41.Image;
                    break;
                case 42:
                    picc.Image = picture42.Image;
                    break;
                case 43:
                    picc.Image = picture43.Image;
                    break;
                case 44:
                    picc.Image = picture44.Image;
                    break;
                case 45:
                    picc.Image = picture45.Image;
                    break;
                case 46:
                    picc.Image = picture46.Image;
                    break;
                case 47:
                    picc.Image = picture47.Image;
                    break;
                case 48:
                    picc.Image = picture48.Image;
                    break;
                case 49:
                    picc.Image = picture49.Image;
                    break;
                case 50:
                    picc.Image = picture50.Image;
                    break;
                case 51:
                    picc.Image = picture51.Image;
                    break;
                case 52:
                    picc.Image = picture52.Image;
                    break;
                case 53:
                    picc.Image = picture53.Image;
                    break;
                case 54:
                    picc.Image = picture54.Image;
                    break;
                case 55:
                    picc.Image = picture55.Image;
                    break;
                case 56:
                    picc.Image = picture56.Image;
                    break;
                case 57:
                    picc.Image = picture57.Image;
                    break;
                case 58:
                    picc.Image = picture58.Image;
                    break;
                case 59:
                    picc.Image = picture59.Image;
                    break;
                case 60:
                    picc.Image = picture60.Image;
                    break;
                case 61:
                    picc.Image = picture61.Image;
                    break;
                case 62:
                    picc.Image = picture62.Image;
                    break;
                case 63:
                    picc.Image = picture63.Image;
                    break;
                case 64:
                    picc.Image = picture64.Image;
                    break;
                case 65:
                    picc.Image = picture65.Image;
                    break;
                case 66:
                    picc.Image = picture66.Image;
                    break;
                case 67:
                    picc.Image = picture67.Image;
                    break;
                case 68:
                    picc.Image = picture68.Image;
                    break;
                case 69:
                    picc.Image = picture69.Image;
                    break;
                case 70:
                    picc.Image = picture70.Image;
                    break;
                case 71:
                    picc.Image = picture71.Image;
                    break;
                case 72:
                    picc.Image = picture72.Image;
                    break;
                case 73:
                    picc.Image = picture73.Image;
                    break;
                case 74:
                    picc.Image = picture74.Image;
                    break;
                case 75:
                    picc.Image = picture75.Image;
                    break;
                case 76:
                    picc.Image = picture76.Image;
                    break;
                case 77:
                    picc.Image = picture77.Image;
                    break;
                case 78:
                    picc.Image = picture78.Image;
                    break;
                case 79:
                    picc.Image = picture79.Image;
                    break;
                case 80:
                    picc.Image = picture80.Image;
                    break;
                case 81:
                    picc.Image = picture81.Image;
                    break;
                case 82:
                    picc.Image = picture82.Image;
                    break;
                case 83:
                    picc.Image = picture83.Image;
                    break;
                case 84:
                    picc.Image = picture84.Image;
                    break;
                case 85:
                    picc.Image = picture85.Image;
                    break;
                case 86:
                    picc.Image = picture86.Image;
                    break;
                case 87:
                    picc.Image = picture87.Image;
                    break;
                case 88:
                    picc.Image = picture88.Image;
                    break;
                case 89:
                    picc.Image = picture89.Image;
                    break;
                case 90:
                    picc.Image = picture90.Image;
                    break;
                case 91:
                    picc.Image = picture91.Image;
                    break;
                case 92:
                    picc.Image = picture92.Image;
                    break;
                case 93:
                    picc.Image = picture93.Image;
                    break;
                case 94:
                    picc.Image = picture94.Image;
                    break;
                case 95:
                    picc.Image = picture95.Image;
                    break;
                case 96:
                    picc.Image = picture96.Image;
                    break;
                case 97:
                    picc.Image = picture97.Image;
                    break;
                case 98:
                    picc.Image = picture98.Image;
                    break;
                case 99:
                    picc.Image = picture99.Image;
                    break;
                case 100:
                    picc.Image = picture100.Image;
                    break;
                case 101:
                    picc.Image = picture101.Image;
                    break;
                case 102:
                    picc.Image = picture102.Image;
                    break;
                case 103:
                    picc.Image = picture103.Image;
                    break;
                case 104:
                    picc.Image = picture104.Image;
                    break;
                default:
                    picc.Image = picture105.Image;
                    break;
            }
            switch (_count[12])
            {
                case 1:
                    picd.Image = picture1.Image;
                    break;
                case 2:
                    picd.Image = picture2.Image;
                    break;
                case 3:
                    picd.Image = picture3.Image;
                    break;
                case 4:
                    picd.Image = picture4.Image;
                    break;
                case 5:
                    picd.Image = picture5.Image;
                    break;
                case 6:
                    picd.Image = picture6.Image;
                    break;
                case 7:
                    picd.Image = picture7.Image;
                    break;
                case 8:
                    picd.Image = picture8.Image;
                    break;
                case 9:
                    picd.Image = picture9.Image;
                    break;
                case 10:
                    picd.Image = picture10.Image;
                    break;
                case 11:
                    picd.Image = picture11.Image;
                    break;
                case 12:
                    picd.Image = picture12.Image;
                    break;
                case 13:
                    picd.Image = picture13.Image;
                    break;
                case 14:
                    picd.Image = picture14.Image;
                    break;
                case 15:
                    picd.Image = picture15.Image;
                    break;
                case 16:
                    picd.Image = picture16.Image;
                    break;
                case 17:
                    picd.Image = picture17.Image;
                    break;
                case 18:
                    picd.Image = picture18.Image;
                    break;
                case 19:
                    picd.Image = picture19.Image;
                    break;
                case 20:
                    picd.Image = picture20.Image;
                    break;
                case 21:
                    picd.Image = picture21.Image;
                    break;
                case 22:
                    picd.Image = picture22.Image;
                    break;
                case 23:
                    picd.Image = picture23.Image;
                    break;
                case 24:
                    picd.Image = picture24.Image;
                    break;
                case 25:
                    picd.Image = picture25.Image;
                    break;
                case 26:
                    picd.Image = picture26.Image;
                    break;
                case 27:
                    picd.Image = picture27.Image;
                    break;
                case 28:
                    picd.Image = picture28.Image;
                    break;
                case 29:
                    picd.Image = picture29.Image;
                    break;
                case 30:
                    picd.Image = picture30.Image;
                    break;
                case 31:
                    picd.Image = picture31.Image;
                    break;
                case 32:
                    picd.Image = picture32.Image;
                    break;
                case 33:
                    picd.Image = picture33.Image;
                    break;
                case 34:
                    picd.Image = picture34.Image;
                    break;
                case 35:
                    picd.Image = picture35.Image;
                    break;
                case 36:
                    picd.Image = picture36.Image;
                    break;
                case 37:
                    picd.Image = picture37.Image;
                    break;
                case 38:
                    picd.Image = picture38.Image;
                    break;
                case 39:
                    picd.Image = picture39.Image;
                    break;
                case 40:
                    picd.Image = picture40.Image;
                    break;
                case 41:
                    picd.Image = picture41.Image;
                    break;
                case 42:
                    picd.Image = picture42.Image;
                    break;
                case 43:
                    picd.Image = picture43.Image;
                    break;
                case 44:
                    picd.Image = picture44.Image;
                    break;
                case 45:
                    picd.Image = picture45.Image;
                    break;
                case 46:
                    picd.Image = picture46.Image;
                    break;
                case 47:
                    picd.Image = picture47.Image;
                    break;
                case 48:
                    picd.Image = picture48.Image;
                    break;
                case 49:
                    picd.Image = picture49.Image;
                    break;
                case 50:
                    picd.Image = picture50.Image;
                    break;
                case 51:
                    picd.Image = picture51.Image;
                    break;
                case 52:
                    picd.Image = picture52.Image;
                    break;
                case 53:
                    picd.Image = picture53.Image;
                    break;
                case 54:
                    picd.Image = picture54.Image;
                    break;
                case 55:
                    picd.Image = picture55.Image;
                    break;
                case 56:
                    picd.Image = picture56.Image;
                    break;
                case 57:
                    picd.Image = picture57.Image;
                    break;
                case 58:
                    picd.Image = picture58.Image;
                    break;
                case 59:
                    picd.Image = picture59.Image;
                    break;
                case 60:
                    picd.Image = picture60.Image;
                    break;
                case 61:
                    picd.Image = picture61.Image;
                    break;
                case 62:
                    picd.Image = picture62.Image;
                    break;
                case 63:
                    picd.Image = picture63.Image;
                    break;
                case 64:
                    picd.Image = picture64.Image;
                    break;
                case 65:
                    picd.Image = picture65.Image;
                    break;
                case 66:
                    picd.Image = picture66.Image;
                    break;
                case 67:
                    picd.Image = picture67.Image;
                    break;
                case 68:
                    picd.Image = picture68.Image;
                    break;
                case 69:
                    picd.Image = picture69.Image;
                    break;
                case 70:
                    picd.Image = picture70.Image;
                    break;
                case 71:
                    picd.Image = picture71.Image;
                    break;
                case 72:
                    picd.Image = picture72.Image;
                    break;
                case 73:
                    picd.Image = picture73.Image;
                    break;
                case 74:
                    picd.Image = picture74.Image;
                    break;
                case 75:
                    picd.Image = picture75.Image;
                    break;
                case 76:
                    picd.Image = picture76.Image;
                    break;
                case 77:
                    picd.Image = picture77.Image;
                    break;
                case 78:
                    picd.Image = picture78.Image;
                    break;
                case 79:
                    picd.Image = picture79.Image;
                    break;
                case 80:
                    picd.Image = picture80.Image;
                    break;
                case 81:
                    picd.Image = picture81.Image;
                    break;
                case 82:
                    picd.Image = picture82.Image;
                    break;
                case 83:
                    picd.Image = picture83.Image;
                    break;
                case 84:
                    picd.Image = picture84.Image;
                    break;
                case 85:
                    picd.Image = picture85.Image;
                    break;
                case 86:
                    picd.Image = picture86.Image;
                    break;
                case 87:
                    picd.Image = picture87.Image;
                    break;
                case 88:
                    picd.Image = picture88.Image;
                    break;
                case 89:
                    picd.Image = picture89.Image;
                    break;
                case 90:
                    picd.Image = picture90.Image;
                    break;
                case 91:
                    picd.Image = picture91.Image;
                    break;
                case 92:
                    picd.Image = picture92.Image;
                    break;
                case 93:
                    picd.Image = picture93.Image;
                    break;
                case 94:
                    picd.Image = picture94.Image;
                    break;
                case 95:
                    picd.Image = picture95.Image;
                    break;
                case 96:
                    picd.Image = picture96.Image;
                    break;
                case 97:
                    picd.Image = picture97.Image;
                    break;
                case 98:
                    picd.Image = picture98.Image;
                    break;
                case 99:
                    picd.Image = picture99.Image;
                    break;
                case 100:
                    picd.Image = picture100.Image;
                    break;
                case 101:
                    picd.Image = picture101.Image;
                    break;
                case 102:
                    picd.Image = picture102.Image;
                    break;
                case 103:
                    picd.Image = picture103.Image;
                    break;
                case 104:
                    picd.Image = picture104.Image;
                    break;
                default:
                    picd.Image = picture105.Image;
                    break;
            }
            switch (_count[13])
            {
                case 1:
                    pice.Image = picture1.Image;
                    break;
                case 2:
                    pice.Image = picture2.Image;
                    break;
                case 3:
                    pice.Image = picture3.Image;
                    break;
                case 4:
                    pice.Image = picture4.Image;
                    break;
                case 5:
                    pice.Image = picture5.Image;
                    break;
                case 6:
                    pice.Image = picture6.Image;
                    break;
                case 7:
                    pice.Image = picture7.Image;
                    break;
                case 8:
                    pice.Image = picture8.Image;
                    break;
                case 9:
                    pice.Image = picture9.Image;
                    break;
                case 10:
                    pice.Image = picture10.Image;
                    break;
                case 11:
                    pice.Image = picture11.Image;
                    break;
                case 12:
                    pice.Image = picture12.Image;
                    break;
                case 13:
                    pice.Image = picture13.Image;
                    break;
                case 14:
                    pice.Image = picture14.Image;
                    break;
                case 15:
                    pice.Image = picture15.Image;
                    break;
                case 16:
                    pice.Image = picture16.Image;
                    break;
                case 17:
                    pice.Image = picture17.Image;
                    break;
                case 18:
                    pice.Image = picture18.Image;
                    break;
                case 19:
                    pice.Image = picture19.Image;
                    break;
                case 20:
                    pice.Image = picture20.Image;
                    break;
                case 21:
                    pice.Image = picture21.Image;
                    break;
                case 22:
                    pice.Image = picture22.Image;
                    break;
                case 23:
                    pice.Image = picture23.Image;
                    break;
                case 24:
                    pice.Image = picture24.Image;
                    break;
                case 25:
                    pice.Image = picture25.Image;
                    break;
                case 26:
                    pice.Image = picture26.Image;
                    break;
                case 27:
                    pice.Image = picture27.Image;
                    break;
                case 28:
                    pice.Image = picture28.Image;
                    break;
                case 29:
                    pice.Image = picture29.Image;
                    break;
                case 30:
                    pice.Image = picture30.Image;
                    break;
                case 31:
                    pice.Image = picture31.Image;
                    break;
                case 32:
                    pice.Image = picture32.Image;
                    break;
                case 33:
                    pice.Image = picture33.Image;
                    break;
                case 34:
                    pice.Image = picture34.Image;
                    break;
                case 35:
                    pice.Image = picture35.Image;
                    break;
                case 36:
                    pice.Image = picture36.Image;
                    break;
                case 37:
                    pice.Image = picture37.Image;
                    break;
                case 38:
                    pice.Image = picture38.Image;
                    break;
                case 39:
                    pice.Image = picture39.Image;
                    break;
                case 40:
                    pice.Image = picture40.Image;
                    break;
                case 41:
                    pice.Image = picture41.Image;
                    break;
                case 42:
                    pice.Image = picture42.Image;
                    break;
                case 43:
                    pice.Image = picture43.Image;
                    break;
                case 44:
                    pice.Image = picture44.Image;
                    break;
                case 45:
                    pice.Image = picture45.Image;
                    break;
                case 46:
                    pice.Image = picture46.Image;
                    break;
                case 47:
                    pice.Image = picture47.Image;
                    break;
                case 48:
                    pice.Image = picture48.Image;
                    break;
                case 49:
                    pice.Image = picture49.Image;
                    break;
                case 50:
                    pice.Image = picture50.Image;
                    break;
                case 51:
                    pice.Image = picture51.Image;
                    break;
                case 52:
                    pice.Image = picture52.Image;
                    break;
                case 53:
                    pice.Image = picture53.Image;
                    break;
                case 54:
                    pice.Image = picture54.Image;
                    break;
                case 55:
                    pice.Image = picture55.Image;
                    break;
                case 56:
                    pice.Image = picture56.Image;
                    break;
                case 57:
                    pice.Image = picture57.Image;
                    break;
                case 58:
                    pice.Image = picture58.Image;
                    break;
                case 59:
                    pice.Image = picture59.Image;
                    break;
                case 60:
                    pice.Image = picture60.Image;
                    break;
                case 61:
                    pice.Image = picture61.Image;
                    break;
                case 62:
                    pice.Image = picture62.Image;
                    break;
                case 63:
                    pice.Image = picture63.Image;
                    break;
                case 64:
                    pice.Image = picture64.Image;
                    break;
                case 65:
                    pice.Image = picture65.Image;
                    break;
                case 66:
                    pice.Image = picture66.Image;
                    break;
                case 67:
                    pice.Image = picture67.Image;
                    break;
                case 68:
                    pice.Image = picture68.Image;
                    break;
                case 69:
                    pice.Image = picture69.Image;
                    break;
                case 70:
                    pice.Image = picture70.Image;
                    break;
                case 71:
                    pice.Image = picture71.Image;
                    break;
                case 72:
                    pice.Image = picture72.Image;
                    break;
                case 73:
                    pice.Image = picture73.Image;
                    break;
                case 74:
                    pice.Image = picture74.Image;
                    break;
                case 75:
                    pice.Image = picture75.Image;
                    break;
                case 76:
                    pice.Image = picture76.Image;
                    break;
                case 77:
                    pice.Image = picture77.Image;
                    break;
                case 78:
                    pice.Image = picture78.Image;
                    break;
                case 79:
                    pice.Image = picture79.Image;
                    break;
                case 80:
                    pice.Image = picture80.Image;
                    break;
                case 81:
                    pice.Image = picture81.Image;
                    break;
                case 82:
                    pice.Image = picture82.Image;
                    break;
                case 83:
                    pice.Image = picture83.Image;
                    break;
                case 84:
                    pice.Image = picture84.Image;
                    break;
                case 85:
                    pice.Image = picture85.Image;
                    break;
                case 86:
                    pice.Image = picture86.Image;
                    break;
                case 87:
                    pice.Image = picture87.Image;
                    break;
                case 88:
                    pice.Image = picture88.Image;
                    break;
                case 89:
                    pice.Image = picture89.Image;
                    break;
                case 90:
                    pice.Image = picture90.Image;
                    break;
                case 91:
                    pice.Image = picture91.Image;
                    break;
                case 92:
                    pice.Image = picture92.Image;
                    break;
                case 93:
                    pice.Image = picture93.Image;
                    break;
                case 94:
                    pice.Image = picture94.Image;
                    break;
                case 95:
                    pice.Image = picture95.Image;
                    break;
                case 96:
                    pice.Image = picture96.Image;
                    break;
                case 97:
                    pice.Image = picture97.Image;
                    break;
                case 98:
                    pice.Image = picture98.Image;
                    break;
                case 99:
                    pice.Image = picture99.Image;
                    break;
                case 100:
                    pice.Image = picture100.Image;
                    break;
                case 101:
                    pice.Image = picture101.Image;
                    break;
                case 102:
                    pice.Image = picture102.Image;
                    break;
                case 103:
                    pice.Image = picture103.Image;
                    break;
                case 104:
                    pice.Image = picture104.Image;
                    break;
                default:
                    pice.Image = picture105.Image;
                    break;
            }
            switch (_count[14])
            {
                case 1:
                    picf.Image = picture1.Image;
                    break;
                case 2:
                    picf.Image = picture2.Image;
                    break;
                case 3:
                    picf.Image = picture3.Image;
                    break;
                case 4:
                    picf.Image = picture4.Image;
                    break;
                case 5:
                    picf.Image = picture5.Image;
                    break;
                case 6:
                    picf.Image = picture6.Image;
                    break;
                case 7:
                    picf.Image = picture7.Image;
                    break;
                case 8:
                    picf.Image = picture8.Image;
                    break;
                case 9:
                    picf.Image = picture9.Image;
                    break;
                case 10:
                    picf.Image = picture10.Image;
                    break;
                case 11:
                    picf.Image = picture11.Image;
                    break;
                case 12:
                    picf.Image = picture12.Image;
                    break;
                case 13:
                    picf.Image = picture13.Image;
                    break;
                case 14:
                    picf.Image = picture14.Image;
                    break;
                case 15:
                    picf.Image = picture15.Image;
                    break;
                case 16:
                    picf.Image = picture16.Image;
                    break;
                case 17:
                    picf.Image = picture17.Image;
                    break;
                case 18:
                    picf.Image = picture18.Image;
                    break;
                case 19:
                    picf.Image = picture19.Image;
                    break;
                case 20:
                    picf.Image = picture20.Image;
                    break;
                case 21:
                    picf.Image = picture21.Image;
                    break;
                case 22:
                    picf.Image = picture22.Image;
                    break;
                case 23:
                    picf.Image = picture23.Image;
                    break;
                case 24:
                    picf.Image = picture24.Image;
                    break;
                case 25:
                    picf.Image = picture25.Image;
                    break;
                case 26:
                    picf.Image = picture26.Image;
                    break;
                case 27:
                    picf.Image = picture27.Image;
                    break;
                case 28:
                    picf.Image = picture28.Image;
                    break;
                case 29:
                    picf.Image = picture29.Image;
                    break;
                case 30:
                    picf.Image = picture30.Image;
                    break;
                case 31:
                    picf.Image = picture31.Image;
                    break;
                case 32:
                    picf.Image = picture32.Image;
                    break;
                case 33:
                    picf.Image = picture33.Image;
                    break;
                case 34:
                    picf.Image = picture34.Image;
                    break;
                case 35:
                    picf.Image = picture35.Image;
                    break;
                case 36:
                    picf.Image = picture36.Image;
                    break;
                case 37:
                    picf.Image = picture37.Image;
                    break;
                case 38:
                    picf.Image = picture38.Image;
                    break;
                case 39:
                    picf.Image = picture39.Image;
                    break;
                case 40:
                    picf.Image = picture40.Image;
                    break;
                case 41:
                    picf.Image = picture41.Image;
                    break;
                case 42:
                    picf.Image = picture42.Image;
                    break;
                case 43:
                    picf.Image = picture43.Image;
                    break;
                case 44:
                    picf.Image = picture44.Image;
                    break;
                case 45:
                    picf.Image = picture45.Image;
                    break;
                case 46:
                    picf.Image = picture46.Image;
                    break;
                case 47:
                    picf.Image = picture47.Image;
                    break;
                case 48:
                    picf.Image = picture48.Image;
                    break;
                case 49:
                    picf.Image = picture49.Image;
                    break;
                case 50:
                    picf.Image = picture50.Image;
                    break;
                case 51:
                    picf.Image = picture51.Image;
                    break;
                case 52:
                    picf.Image = picture52.Image;
                    break;
                case 53:
                    picf.Image = picture53.Image;
                    break;
                case 54:
                    picf.Image = picture54.Image;
                    break;
                case 55:
                    picf.Image = picture55.Image;
                    break;
                case 56:
                    picf.Image = picture56.Image;
                    break;
                case 57:
                    picf.Image = picture57.Image;
                    break;
                case 58:
                    picf.Image = picture58.Image;
                    break;
                case 59:
                    picf.Image = picture59.Image;
                    break;
                case 60:
                    picf.Image = picture60.Image;
                    break;
                case 61:
                    picf.Image = picture61.Image;
                    break;
                case 62:
                    picf.Image = picture62.Image;
                    break;
                case 63:
                    picf.Image = picture63.Image;
                    break;
                case 64:
                    picf.Image = picture64.Image;
                    break;
                case 65:
                    picf.Image = picture65.Image;
                    break;
                case 66:
                    picf.Image = picture66.Image;
                    break;
                case 67:
                    picf.Image = picture67.Image;
                    break;
                case 68:
                    picf.Image = picture68.Image;
                    break;
                case 69:
                    picf.Image = picture69.Image;
                    break;
                case 70:
                    picf.Image = picture70.Image;
                    break;
                case 71:
                    picf.Image = picture71.Image;
                    break;
                case 72:
                    picf.Image = picture72.Image;
                    break;
                case 73:
                    picf.Image = picture73.Image;
                    break;
                case 74:
                    picf.Image = picture74.Image;
                    break;
                case 75:
                    picf.Image = picture75.Image;
                    break;
                case 76:
                    picf.Image = picture76.Image;
                    break;
                case 77:
                    picf.Image = picture77.Image;
                    break;
                case 78:
                    picf.Image = picture78.Image;
                    break;
                case 79:
                    picf.Image = picture79.Image;
                    break;
                case 80:
                    picf.Image = picture80.Image;
                    break;
                case 81:
                    picf.Image = picture81.Image;
                    break;
                case 82:
                    picf.Image = picture82.Image;
                    break;
                case 83:
                    picf.Image = picture83.Image;
                    break;
                case 84:
                    picf.Image = picture84.Image;
                    break;
                case 85:
                    picf.Image = picture85.Image;
                    break;
                case 86:
                    picf.Image = picture86.Image;
                    break;
                case 87:
                    picf.Image = picture87.Image;
                    break;
                case 88:
                    picf.Image = picture88.Image;
                    break;
                case 89:
                    picf.Image = picture89.Image;
                    break;
                case 90:
                    picf.Image = picture90.Image;
                    break;
                case 91:
                    picf.Image = picture91.Image;
                    break;
                case 92:
                    picf.Image = picture92.Image;
                    break;
                case 93:
                    picf.Image = picture93.Image;
                    break;
                case 94:
                    picf.Image = picture94.Image;
                    break;
                case 95:
                    picf.Image = picture95.Image;
                    break;
                case 96:
                    picf.Image = picture96.Image;
                    break;
                case 97:
                    picf.Image = picture97.Image;
                    break;
                case 98:
                    picf.Image = picture98.Image;
                    break;
                case 99:
                    picf.Image = picture99.Image;
                    break;
                case 100:
                    picf.Image = picture100.Image;
                    break;
                case 101:
                    picf.Image = picture101.Image;
                    break;
                case 102:
                    picf.Image = picture102.Image;
                    break;
                case 103:
                    picf.Image = picture103.Image;
                    break;
                case 104:
                    picf.Image = picture104.Image;
                    break;
                default:
                    picf.Image = picture105.Image;
                    break;
            }
            switch (_count[15])
            {
                case 1:
                    picg.Image = picture1.Image;
                    break;
                case 2:
                    picg.Image = picture2.Image;
                    break;
                case 3:
                    picg.Image = picture3.Image;
                    break;
                case 4:
                    picg.Image = picture4.Image;
                    break;
                case 5:
                    picg.Image = picture5.Image;
                    break;
                case 6:
                    picg.Image = picture6.Image;
                    break;
                case 7:
                    picg.Image = picture7.Image;
                    break;
                case 8:
                    picg.Image = picture8.Image;
                    break;
                case 9:
                    picg.Image = picture9.Image;
                    break;
                case 10:
                    picg.Image = picture10.Image;
                    break;
                case 11:
                    picg.Image = picture11.Image;
                    break;
                case 12:
                    picg.Image = picture12.Image;
                    break;
                case 13:
                    picg.Image = picture13.Image;
                    break;
                case 14:
                    picg.Image = picture14.Image;
                    break;
                case 15:
                    picg.Image = picture15.Image;
                    break;
                case 16:
                    picg.Image = picture16.Image;
                    break;
                case 17:
                    picg.Image = picture17.Image;
                    break;
                case 18:
                    picg.Image = picture18.Image;
                    break;
                case 19:
                    picg.Image = picture19.Image;
                    break;
                case 20:
                    picg.Image = picture20.Image;
                    break;
                case 21:
                    picg.Image = picture21.Image;
                    break;
                case 22:
                    picg.Image = picture22.Image;
                    break;
                case 23:
                    picg.Image = picture23.Image;
                    break;
                case 24:
                    picg.Image = picture24.Image;
                    break;
                case 25:
                    picg.Image = picture25.Image;
                    break;
                case 26:
                    picg.Image = picture26.Image;
                    break;
                case 27:
                    picg.Image = picture27.Image;
                    break;
                case 28:
                    picg.Image = picture28.Image;
                    break;
                case 29:
                    picg.Image = picture29.Image;
                    break;
                case 30:
                    picg.Image = picture30.Image;
                    break;
                case 31:
                    picg.Image = picture31.Image;
                    break;
                case 32:
                    picg.Image = picture32.Image;
                    break;
                case 33:
                    picg.Image = picture33.Image;
                    break;
                case 34:
                    picg.Image = picture34.Image;
                    break;
                case 35:
                    picg.Image = picture35.Image;
                    break;
                case 36:
                    picg.Image = picture36.Image;
                    break;
                case 37:
                    picg.Image = picture37.Image;
                    break;
                case 38:
                    picg.Image = picture38.Image;
                    break;
                case 39:
                    picg.Image = picture39.Image;
                    break;
                case 40:
                    picg.Image = picture40.Image;
                    break;
                case 41:
                    picg.Image = picture41.Image;
                    break;
                case 42:
                    picg.Image = picture42.Image;
                    break;
                case 43:
                    picg.Image = picture43.Image;
                    break;
                case 44:
                    picg.Image = picture44.Image;
                    break;
                case 45:
                    picg.Image = picture45.Image;
                    break;
                case 46:
                    picg.Image = picture46.Image;
                    break;
                case 47:
                    picg.Image = picture47.Image;
                    break;
                case 48:
                    picg.Image = picture48.Image;
                    break;
                case 49:
                    picg.Image = picture49.Image;
                    break;
                case 50:
                    picg.Image = picture50.Image;
                    break;
                case 51:
                    picg.Image = picture51.Image;
                    break;
                case 52:
                    picg.Image = picture52.Image;
                    break;
                case 53:
                    picg.Image = picture53.Image;
                    break;
                case 54:
                    picg.Image = picture54.Image;
                    break;
                case 55:
                    picg.Image = picture55.Image;
                    break;
                case 56:
                    picg.Image = picture56.Image;
                    break;
                case 57:
                    picg.Image = picture57.Image;
                    break;
                case 58:
                    picg.Image = picture58.Image;
                    break;
                case 59:
                    picg.Image = picture59.Image;
                    break;
                case 60:
                    picg.Image = picture60.Image;
                    break;
                case 61:
                    picg.Image = picture61.Image;
                    break;
                case 62:
                    picg.Image = picture62.Image;
                    break;
                case 63:
                    picg.Image = picture63.Image;
                    break;
                case 64:
                    picg.Image = picture64.Image;
                    break;
                case 65:
                    picg.Image = picture65.Image;
                    break;
                case 66:
                    picg.Image = picture66.Image;
                    break;
                case 67:
                    picg.Image = picture67.Image;
                    break;
                case 68:
                    picg.Image = picture68.Image;
                    break;
                case 69:
                    picg.Image = picture69.Image;
                    break;
                case 70:
                    picg.Image = picture70.Image;
                    break;
                case 71:
                    picg.Image = picture71.Image;
                    break;
                case 72:
                    picg.Image = picture72.Image;
                    break;
                case 73:
                    picg.Image = picture73.Image;
                    break;
                case 74:
                    picg.Image = picture74.Image;
                    break;
                case 75:
                    picg.Image = picture75.Image;
                    break;
                case 76:
                    picg.Image = picture76.Image;
                    break;
                case 77:
                    picg.Image = picture77.Image;
                    break;
                case 78:
                    picg.Image = picture78.Image;
                    break;
                case 79:
                    picg.Image = picture79.Image;
                    break;
                case 80:
                    picg.Image = picture80.Image;
                    break;
                case 81:
                    picg.Image = picture81.Image;
                    break;
                case 82:
                    picg.Image = picture82.Image;
                    break;
                case 83:
                    picg.Image = picture83.Image;
                    break;
                case 84:
                    picg.Image = picture84.Image;
                    break;
                case 85:
                    picg.Image = picture85.Image;
                    break;
                case 86:
                    picg.Image = picture86.Image;
                    break;
                case 87:
                    picg.Image = picture87.Image;
                    break;
                case 88:
                    picg.Image = picture88.Image;
                    break;
                case 89:
                    picg.Image = picture89.Image;
                    break;
                case 90:
                    picg.Image = picture90.Image;
                    break;
                case 91:
                    picg.Image = picture91.Image;
                    break;
                case 92:
                    picg.Image = picture92.Image;
                    break;
                case 93:
                    picg.Image = picture93.Image;
                    break;
                case 94:
                    picg.Image = picture94.Image;
                    break;
                case 95:
                    picg.Image = picture95.Image;
                    break;
                case 96:
                    picg.Image = picture96.Image;
                    break;
                case 97:
                    picg.Image = picture97.Image;
                    break;
                case 98:
                    picg.Image = picture98.Image;
                    break;
                case 99:
                    picg.Image = picture99.Image;
                    break;
                case 100:
                    picg.Image = picture100.Image;
                    break;
                case 101:
                    picg.Image = picture101.Image;
                    break;
                case 102:
                    picg.Image = picture102.Image;
                    break;
                case 103:
                    picg.Image = picture103.Image;
                    break;
                case 104:
                    picg.Image = picture104.Image;
                    break;
                default:
                    picg.Image = picture105.Image;
                    break;
            }
        }
    }
}
