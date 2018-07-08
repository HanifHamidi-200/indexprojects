using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialHome
{
    public partial class Form1 : Form
    {
        private static List<int> _col1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0};
        private static List<int> _col2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0};
        private static List<int> _col6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0};
        private static List<int> _station1 = new List<int> { 0, 0 };
        private static List<int> _station2 = new List<int> { 0, 0 };
        private int nNumber;
        private int mnCol, mnRow;
        private int mnMode, mnSubmode;
        private int mnPercentageChange;
        private int mnWhat1, mnWhat2;
        private int nScore;
        private int mnTransportCol, mnTransportRow;

        private void fDial()
        {
            Random rnd1 = new Random();

            nNumber = rnd1.Next(1, 101);
            nScore += 10;
            lblScore.Text = "Score = " + Convert.ToString(nScore);
            if (nNumber > mnPercentageChange)
            {
                mnMode = rnd1.Next(1, 4);
                mnSubmode = 1;
                mnCol = rnd1.Next(1, 9);
                mnRow = rnd1.Next(1, 9);
                lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

                fRedrawMode();
                fUpdateDisplay();

            }
        }
        private bool fTransport(int nCol,int nRow)
        {
            switch (nCol)
            {
                case 1:
                    if (_col1[nRow - 1] == 18)
                    {
                        return true;
                    }
                    break;
                case 2:
                    if (_col2[nRow - 1] == 18)
                    {
                        return true;
                    }
                    break;
                case 3:
                    if (_col3[nRow - 1] == 18)
                    {
                        return true;
                    }
                    break;
                case 4:
                    if (_col4[nRow - 1] == 18)
                    {
                        return true;
                    }
                    break;
                case 5:
                    if (_col5[nRow - 1] == 18)
                    {
                        return true;
                    }
                    break;
                case 6:
                    if (_col6[nRow - 1] == 18)
                    {
                        return true;
                    }
                    break;
                case 7:
                    if (_col7[nRow - 1] == 18)
                    {
                        return true;
                    }
                    break;
                default:
                    if (_col8[nRow - 1] == 18)
                    {
                        return true;
                    }
                    break;
            }
            return false;
        }
        private bool fMeadow(int nCol, int nRow)
        {
            switch (nCol)
            {
                case 1:
                    if (_col1[nRow - 1] == 12)
                    {
                        return true;
                    }
                    break;
                case 2:
                    if (_col2[nRow - 1] == 12)
                    {
                        return true;
                    }
                    break;
                case 3:
                    if (_col3[nRow - 1] == 12)
                    {
                        return true;
                    }
                    break;
                case 4:
                    if (_col4[nRow - 1] == 12)
                    {
                        return true;
                    }
                    break;
                case 5:
                    if (_col5[nRow - 1] == 12)
                    {
                        return true;
                    }
                    break;
                case 6:
                    if (_col6[nRow - 1] == 12)
                    {
                        return true;
                    }
                    break;
                case 7:
                    if (_col7[nRow - 1] == 12)
                    {
                        return true;
                    }
                    break;
                default:
                    if (_col8[nRow - 1] == 12)
                    {
                        return true;
                    }
                    break;
            }
            return false;
        }
        private void fStick(int nCol,int nRow,int nType)
        {
            switch (nCol)
            {
                case 1:
                    _col1[nRow - 1] = nType;
                    break;
                case 2:
                    _col2[nRow - 1] = nType;
                    break;
                case 3:
                    _col3[nRow - 1] = nType;
                    break;
                case 4:
                    _col4[nRow - 1] = nType;
                    break;
                case 5:
                    _col5[nRow - 1] = nType;
                    break;
                case 6:
                    _col6[nRow - 1] = nType;
                    break;
                case 7:
                    _col7[nRow - 1] = nType;
                    break;
                default:
                    _col8[nRow - 1] = nType;
                    break;
            }
        }

        private void fUpdate1()
        {
            String sText = null;

            switch (mnWhat1)
            {
                case 15:
                    sText = "OIL = ";
                    break;
                case 17:
                    sText = "ROCKS = ";
                    break;
                case 11:
                    sText = "GEMS = ";
                    break;
                case 0:
                    sText = "WHAT = ";
                    break;
                default:
                    sText = "WHAT = ";
                    break;
            }
            switch (mnWhat2)
            {
                case 14:
                    sText = sText+"OIL";
                    break;
                case 16:
                    sText = sText + "ROCKS";
                    break;
                case 10:
                    sText = sText + "GEMS";
                    break;
                case 0:
                    sText = sText + "WHAT";
                    break;
                default:
                    sText = sText + "WHAT";
                    break;
            }
            lblWhat1.Text = sText;
        }

        private void fUpdateDisplay()
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F tile1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F tile2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F build1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F build2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F build3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F build4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F build5.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F build6.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F Exit.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F gems1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F gems2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F meadow.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"F observatory.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"F oil1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"F oil2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"F rocks1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
                Image = Image.FromFile(@"F rocks2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture18 = new PictureBox
            {
                Name = "pictureBox18",
                Image = Image.FromFile(@"F transporter.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture19 = new PictureBox
            {
                Name = "pictureBox19",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            switch (_col1[0])
            {
                case 1:
                    pic11.Image = picture1.Image;
                    break;
                case 2:
                    pic11.Image = picture2.Image;
                    break;
                case 3:
                    pic11.Image = picture3.Image;
                    break;
                case 4:
                    pic11.Image = picture4.Image;
                    break;
                case 5:
                    pic11.Image = picture5.Image;
                    break;
                case 6:
                    pic11.Image = picture6.Image;
                    break;
                case 7:
                    pic11.Image = picture7.Image;
                    break;
                case 8:
                    pic11.Image = picture8.Image;
                    break;
                case 9:
                    pic11.Image = picture9.Image;
                    break;
                case 10:
                    pic11.Image = picture10.Image;
                    break;
                case 11:
                    pic11.Image = picture11.Image;
                    break;
                case 12:
                    pic11.Image = picture12.Image;
                    break;
                case 13:
                    pic11.Image = picture13.Image;
                    break;
                case 14:
                    pic11.Image = picture14.Image;
                    break;
                case 15:
                    pic11.Image = picture15.Image;
                    break;
                case 16:
                    pic11.Image = picture16.Image;
                    break;
                case 17:
                    pic11.Image = picture17.Image;
                    break;
                case 18:
                    pic11.Image = picture18.Image;
                    break;
                default:
                    pic11.Image = picture19.Image;
                    break;
            }
            switch (_col1[1])
            {
                case 1:
                    pic12.Image = picture1.Image;
                    break;
                case 2:
                    pic12.Image = picture2.Image;
                    break;
                case 3:
                    pic12.Image = picture3.Image;
                    break;
                case 4:
                    pic12.Image = picture4.Image;
                    break;
                case 5:
                    pic12.Image = picture5.Image;
                    break;
                case 6:
                    pic12.Image = picture6.Image;
                    break;
                case 7:
                    pic12.Image = picture7.Image;
                    break;
                case 8:
                    pic12.Image = picture8.Image;
                    break;
                case 9:
                    pic12.Image = picture9.Image;
                    break;
                case 10:
                    pic12.Image = picture10.Image;
                    break;
                case 11:
                    pic12.Image = picture11.Image;
                    break;
                case 12:
                    pic12.Image = picture12.Image;
                    break;
                case 13:
                    pic12.Image = picture13.Image;
                    break;
                case 14:
                    pic12.Image = picture14.Image;
                    break;
                case 15:
                    pic12.Image = picture15.Image;
                    break;
                case 16:
                    pic12.Image = picture16.Image;
                    break;
                case 17:
                    pic12.Image = picture17.Image;
                    break;
                case 18:
                    pic12.Image = picture18.Image;
                    break;
                default:
                    pic12.Image = picture19.Image;
                    break;
            }
            switch (_col1[2])
            {
                case 1:
                    pic13.Image = picture1.Image;
                    break;
                case 2:
                    pic13.Image = picture2.Image;
                    break;
                case 3:
                    pic13.Image = picture3.Image;
                    break;
                case 4:
                    pic13.Image = picture4.Image;
                    break;
                case 5:
                    pic13.Image = picture5.Image;
                    break;
                case 6:
                    pic13.Image = picture6.Image;
                    break;
                case 7:
                    pic13.Image = picture7.Image;
                    break;
                case 8:
                    pic13.Image = picture8.Image;
                    break;
                case 9:
                    pic13.Image = picture9.Image;
                    break;
                case 10:
                    pic13.Image = picture10.Image;
                    break;
                case 11:
                    pic13.Image = picture11.Image;
                    break;
                case 12:
                    pic13.Image = picture12.Image;
                    break;
                case 13:
                    pic13.Image = picture13.Image;
                    break;
                case 14:
                    pic13.Image = picture14.Image;
                    break;
                case 15:
                    pic13.Image = picture15.Image;
                    break;
                case 16:
                    pic13.Image = picture16.Image;
                    break;
                case 17:
                    pic13.Image = picture17.Image;
                    break;
                case 18:
                    pic13.Image = picture18.Image;
                    break;
                default:
                    pic13.Image = picture19.Image;
                    break;
            }
            switch (_col1[3])
            {
                case 1:
                    pic14.Image = picture1.Image;
                    break;
                case 2:
                    pic14.Image = picture2.Image;
                    break;
                case 3:
                    pic14.Image = picture3.Image;
                    break;
                case 4:
                    pic14.Image = picture4.Image;
                    break;
                case 5:
                    pic14.Image = picture5.Image;
                    break;
                case 6:
                    pic14.Image = picture6.Image;
                    break;
                case 7:
                    pic14.Image = picture7.Image;
                    break;
                case 8:
                    pic14.Image = picture8.Image;
                    break;
                case 9:
                    pic14.Image = picture9.Image;
                    break;
                case 10:
                    pic14.Image = picture10.Image;
                    break;
                case 11:
                    pic14.Image = picture11.Image;
                    break;
                case 12:
                    pic14.Image = picture12.Image;
                    break;
                case 13:
                    pic14.Image = picture13.Image;
                    break;
                case 14:
                    pic14.Image = picture14.Image;
                    break;
                case 15:
                    pic14.Image = picture15.Image;
                    break;
                case 16:
                    pic14.Image = picture16.Image;
                    break;
                case 17:
                    pic14.Image = picture17.Image;
                    break;
                case 18:
                    pic14.Image = picture18.Image;
                    break;
                default:
                    pic14.Image = picture19.Image;
                    break;
            }
            switch (_col1[4])
            {
                case 1:
                    pic15.Image = picture1.Image;
                    break;
                case 2:
                    pic15.Image = picture2.Image;
                    break;
                case 3:
                    pic15.Image = picture3.Image;
                    break;
                case 4:
                    pic15.Image = picture4.Image;
                    break;
                case 5:
                    pic15.Image = picture5.Image;
                    break;
                case 6:
                    pic15.Image = picture6.Image;
                    break;
                case 7:
                    pic15.Image = picture7.Image;
                    break;
                case 8:
                    pic15.Image = picture8.Image;
                    break;
                case 9:
                    pic15.Image = picture9.Image;
                    break;
                case 10:
                    pic15.Image = picture10.Image;
                    break;
                case 11:
                    pic15.Image = picture11.Image;
                    break;
                case 12:
                    pic15.Image = picture12.Image;
                    break;
                case 13:
                    pic15.Image = picture13.Image;
                    break;
                case 14:
                    pic15.Image = picture14.Image;
                    break;
                case 15:
                    pic15.Image = picture15.Image;
                    break;
                case 16:
                    pic15.Image = picture16.Image;
                    break;
                case 17:
                    pic15.Image = picture17.Image;
                    break;
                case 18:
                    pic15.Image = picture18.Image;
                    break;
                default:
                    pic15.Image = picture19.Image;
                    break;
            }
            switch (_col1[5])
            {
                case 1:
                    pic16.Image = picture1.Image;
                    break;
                case 2:
                    pic16.Image = picture2.Image;
                    break;
                case 3:
                    pic16.Image = picture3.Image;
                    break;
                case 4:
                    pic16.Image = picture4.Image;
                    break;
                case 5:
                    pic16.Image = picture5.Image;
                    break;
                case 6:
                    pic16.Image = picture6.Image;
                    break;
                case 7:
                    pic16.Image = picture7.Image;
                    break;
                case 8:
                    pic16.Image = picture8.Image;
                    break;
                case 9:
                    pic16.Image = picture9.Image;
                    break;
                case 10:
                    pic16.Image = picture10.Image;
                    break;
                case 11:
                    pic16.Image = picture11.Image;
                    break;
                case 12:
                    pic16.Image = picture12.Image;
                    break;
                case 13:
                    pic16.Image = picture13.Image;
                    break;
                case 14:
                    pic16.Image = picture14.Image;
                    break;
                case 15:
                    pic16.Image = picture15.Image;
                    break;
                case 16:
                    pic16.Image = picture16.Image;
                    break;
                case 17:
                    pic16.Image = picture17.Image;
                    break;
                case 18:
                    pic16.Image = picture18.Image;
                    break;
                default:
                    pic16.Image = picture19.Image;
                    break;
            }
            switch (_col1[6])
            {
                case 1:
                    pic17.Image = picture1.Image;
                    break;
                case 2:
                    pic17.Image = picture2.Image;
                    break;
                case 3:
                    pic17.Image = picture3.Image;
                    break;
                case 4:
                    pic17.Image = picture4.Image;
                    break;
                case 5:
                    pic17.Image = picture5.Image;
                    break;
                case 6:
                    pic17.Image = picture6.Image;
                    break;
                case 7:
                    pic17.Image = picture7.Image;
                    break;
                case 8:
                    pic17.Image = picture8.Image;
                    break;
                case 9:
                    pic17.Image = picture9.Image;
                    break;
                case 10:
                    pic17.Image = picture10.Image;
                    break;
                case 11:
                    pic17.Image = picture11.Image;
                    break;
                case 12:
                    pic17.Image = picture12.Image;
                    break;
                case 13:
                    pic17.Image = picture13.Image;
                    break;
                case 14:
                    pic17.Image = picture14.Image;
                    break;
                case 15:
                    pic17.Image = picture15.Image;
                    break;
                case 16:
                    pic17.Image = picture16.Image;
                    break;
                case 17:
                    pic17.Image = picture17.Image;
                    break;
                case 18:
                    pic17.Image = picture18.Image;
                    break;
                default:
                    pic17.Image = picture19.Image;
                    break;
            }
            switch (_col1[7])
            {
                case 1:
                    pic18.Image = picture1.Image;
                    break;
                case 2:
                    pic18.Image = picture2.Image;
                    break;
                case 3:
                    pic18.Image = picture3.Image;
                    break;
                case 4:
                    pic18.Image = picture4.Image;
                    break;
                case 5:
                    pic18.Image = picture5.Image;
                    break;
                case 6:
                    pic18.Image = picture6.Image;
                    break;
                case 7:
                    pic18.Image = picture7.Image;
                    break;
                case 8:
                    pic18.Image = picture8.Image;
                    break;
                case 9:
                    pic18.Image = picture9.Image;
                    break;
                case 10:
                    pic18.Image = picture10.Image;
                    break;
                case 11:
                    pic18.Image = picture11.Image;
                    break;
                case 12:
                    pic18.Image = picture12.Image;
                    break;
                case 13:
                    pic18.Image = picture13.Image;
                    break;
                case 14:
                    pic18.Image = picture14.Image;
                    break;
                case 15:
                    pic18.Image = picture15.Image;
                    break;
                case 16:
                    pic18.Image = picture16.Image;
                    break;
                case 17:
                    pic18.Image = picture17.Image;
                    break;
                case 18:
                    pic18.Image = picture18.Image;
                    break;
                default:
                    pic18.Image = picture19.Image;
                    break;
            }

            //col2 now
            switch (_col2[0])
            {
                case 1:
                    pic21.Image = picture1.Image;
                    break;
                case 2:
                    pic21.Image = picture2.Image;
                    break;
                case 3:
                    pic21.Image = picture3.Image;
                    break;
                case 4:
                    pic21.Image = picture4.Image;
                    break;
                case 5:
                    pic21.Image = picture5.Image;
                    break;
                case 6:
                    pic21.Image = picture6.Image;
                    break;
                case 7:
                    pic21.Image = picture7.Image;
                    break;
                case 8:
                    pic21.Image = picture8.Image;
                    break;
                case 9:
                    pic21.Image = picture9.Image;
                    break;
                case 10:
                    pic21.Image = picture10.Image;
                    break;
                case 11:
                    pic21.Image = picture11.Image;
                    break;
                case 12:
                    pic21.Image = picture12.Image;
                    break;
                case 13:
                    pic21.Image = picture13.Image;
                    break;
                case 14:
                    pic21.Image = picture14.Image;
                    break;
                case 15:
                    pic21.Image = picture15.Image;
                    break;
                case 16:
                    pic21.Image = picture16.Image;
                    break;
                case 17:
                    pic21.Image = picture17.Image;
                    break;
                case 18:
                    pic21.Image = picture18.Image;
                    break;
                default:
                    pic21.Image = picture19.Image;
                    break;
            }
            switch (_col2[1])
            {
                case 1:
                    pic22.Image = picture1.Image;
                    break;
                case 2:
                    pic22.Image = picture2.Image;
                    break;
                case 3:
                    pic22.Image = picture3.Image;
                    break;
                case 4:
                    pic22.Image = picture4.Image;
                    break;
                case 5:
                    pic22.Image = picture5.Image;
                    break;
                case 6:
                    pic22.Image = picture6.Image;
                    break;
                case 7:
                    pic22.Image = picture7.Image;
                    break;
                case 8:
                    pic22.Image = picture8.Image;
                    break;
                case 9:
                    pic22.Image = picture9.Image;
                    break;
                case 10:
                    pic22.Image = picture10.Image;
                    break;
                case 11:
                    pic22.Image = picture11.Image;
                    break;
                case 12:
                    pic22.Image = picture12.Image;
                    break;
                case 13:
                    pic22.Image = picture13.Image;
                    break;
                case 14:
                    pic22.Image = picture14.Image;
                    break;
                case 15:
                    pic22.Image = picture15.Image;
                    break;
                case 16:
                    pic22.Image = picture16.Image;
                    break;
                case 17:
                    pic22.Image = picture17.Image;
                    break;
                case 18:
                    pic22.Image = picture18.Image;
                    break;
                default:
                    pic22.Image = picture19.Image;
                    break;
            }
            switch (_col2[2])
            {
                case 1:
                    pic23.Image = picture1.Image;
                    break;
                case 2:
                    pic23.Image = picture2.Image;
                    break;
                case 3:
                    pic23.Image = picture3.Image;
                    break;
                case 4:
                    pic23.Image = picture4.Image;
                    break;
                case 5:
                    pic23.Image = picture5.Image;
                    break;
                case 6:
                    pic23.Image = picture6.Image;
                    break;
                case 7:
                    pic23.Image = picture7.Image;
                    break;
                case 8:
                    pic23.Image = picture8.Image;
                    break;
                case 9:
                    pic23.Image = picture9.Image;
                    break;
                case 10:
                    pic23.Image = picture10.Image;
                    break;
                case 11:
                    pic23.Image = picture11.Image;
                    break;
                case 12:
                    pic23.Image = picture12.Image;
                    break;
                case 13:
                    pic23.Image = picture13.Image;
                    break;
                case 14:
                    pic23.Image = picture14.Image;
                    break;
                case 15:
                    pic23.Image = picture15.Image;
                    break;
                case 16:
                    pic23.Image = picture16.Image;
                    break;
                case 17:
                    pic23.Image = picture17.Image;
                    break;
                case 18:
                    pic23.Image = picture18.Image;
                    break;
                default:
                    pic23.Image = picture19.Image;
                    break;
            }
            switch (_col2[3])
            {
                case 1:
                    pic24.Image = picture1.Image;
                    break;
                case 2:
                    pic24.Image = picture2.Image;
                    break;
                case 3:
                    pic24.Image = picture3.Image;
                    break;
                case 4:
                    pic24.Image = picture4.Image;
                    break;
                case 5:
                    pic24.Image = picture5.Image;
                    break;
                case 6:
                    pic24.Image = picture6.Image;
                    break;
                case 7:
                    pic24.Image = picture7.Image;
                    break;
                case 8:
                    pic24.Image = picture8.Image;
                    break;
                case 9:
                    pic24.Image = picture9.Image;
                    break;
                case 10:
                    pic24.Image = picture10.Image;
                    break;
                case 11:
                    pic24.Image = picture11.Image;
                    break;
                case 12:
                    pic24.Image = picture12.Image;
                    break;
                case 13:
                    pic24.Image = picture13.Image;
                    break;
                case 14:
                    pic24.Image = picture14.Image;
                    break;
                case 15:
                    pic24.Image = picture15.Image;
                    break;
                case 16:
                    pic24.Image = picture16.Image;
                    break;
                case 17:
                    pic24.Image = picture17.Image;
                    break;
                case 18:
                    pic24.Image = picture18.Image;
                    break;
                default:
                    pic24.Image = picture19.Image;
                    break;
            }
            switch (_col2[4])
            {
                case 1:
                    pic25.Image = picture1.Image;
                    break;
                case 2:
                    pic25.Image = picture2.Image;
                    break;
                case 3:
                    pic25.Image = picture3.Image;
                    break;
                case 4:
                    pic25.Image = picture4.Image;
                    break;
                case 5:
                    pic25.Image = picture5.Image;
                    break;
                case 6:
                    pic25.Image = picture6.Image;
                    break;
                case 7:
                    pic25.Image = picture7.Image;
                    break;
                case 8:
                    pic25.Image = picture8.Image;
                    break;
                case 9:
                    pic25.Image = picture9.Image;
                    break;
                case 10:
                    pic25.Image = picture10.Image;
                    break;
                case 11:
                    pic25.Image = picture11.Image;
                    break;
                case 12:
                    pic25.Image = picture12.Image;
                    break;
                case 13:
                    pic25.Image = picture13.Image;
                    break;
                case 14:
                    pic25.Image = picture14.Image;
                    break;
                case 15:
                    pic25.Image = picture15.Image;
                    break;
                case 16:
                    pic25.Image = picture16.Image;
                    break;
                case 17:
                    pic25.Image = picture17.Image;
                    break;
                case 18:
                    pic25.Image = picture18.Image;
                    break;
                default:
                    pic25.Image = picture19.Image;
                    break;
            }
            switch (_col2[5])
            {
                case 1:
                    pic26.Image = picture1.Image;
                    break;
                case 2:
                    pic26.Image = picture2.Image;
                    break;
                case 3:
                    pic26.Image = picture3.Image;
                    break;
                case 4:
                    pic26.Image = picture4.Image;
                    break;
                case 5:
                    pic26.Image = picture5.Image;
                    break;
                case 6:
                    pic26.Image = picture6.Image;
                    break;
                case 7:
                    pic26.Image = picture7.Image;
                    break;
                case 8:
                    pic26.Image = picture8.Image;
                    break;
                case 9:
                    pic26.Image = picture9.Image;
                    break;
                case 10:
                    pic26.Image = picture10.Image;
                    break;
                case 11:
                    pic26.Image = picture11.Image;
                    break;
                case 12:
                    pic26.Image = picture12.Image;
                    break;
                case 13:
                    pic26.Image = picture13.Image;
                    break;
                case 14:
                    pic26.Image = picture14.Image;
                    break;
                case 15:
                    pic26.Image = picture15.Image;
                    break;
                case 16:
                    pic26.Image = picture16.Image;
                    break;
                case 17:
                    pic26.Image = picture17.Image;
                    break;
                case 18:
                    pic26.Image = picture18.Image;
                    break;
                default:
                    pic26.Image = picture19.Image;
                    break;
            }
            switch (_col2[6])
            {
                case 1:
                    pic27.Image = picture1.Image;
                    break;
                case 2:
                    pic27.Image = picture2.Image;
                    break;
                case 3:
                    pic27.Image = picture3.Image;
                    break;
                case 4:
                    pic27.Image = picture4.Image;
                    break;
                case 5:
                    pic27.Image = picture5.Image;
                    break;
                case 6:
                    pic27.Image = picture6.Image;
                    break;
                case 7:
                    pic27.Image = picture7.Image;
                    break;
                case 8:
                    pic27.Image = picture8.Image;
                    break;
                case 9:
                    pic27.Image = picture9.Image;
                    break;
                case 10:
                    pic27.Image = picture10.Image;
                    break;
                case 11:
                    pic27.Image = picture11.Image;
                    break;
                case 12:
                    pic27.Image = picture12.Image;
                    break;
                case 13:
                    pic27.Image = picture13.Image;
                    break;
                case 14:
                    pic27.Image = picture14.Image;
                    break;
                case 15:
                    pic27.Image = picture15.Image;
                    break;
                case 16:
                    pic27.Image = picture16.Image;
                    break;
                case 17:
                    pic27.Image = picture17.Image;
                    break;
                case 18:
                    pic27.Image = picture18.Image;
                    break;
                default:
                    pic27.Image = picture19.Image;
                    break;
            }
            switch (_col2[7])
            {
                case 1:
                    pic28.Image = picture1.Image;
                    break;
                case 2:
                    pic28.Image = picture2.Image;
                    break;
                case 3:
                    pic28.Image = picture3.Image;
                    break;
                case 4:
                    pic28.Image = picture4.Image;
                    break;
                case 5:
                    pic28.Image = picture5.Image;
                    break;
                case 6:
                    pic28.Image = picture6.Image;
                    break;
                case 7:
                    pic28.Image = picture7.Image;
                    break;
                case 8:
                    pic28.Image = picture8.Image;
                    break;
                case 9:
                    pic28.Image = picture9.Image;
                    break;
                case 10:
                    pic28.Image = picture10.Image;
                    break;
                case 11:
                    pic28.Image = picture11.Image;
                    break;
                case 12:
                    pic28.Image = picture12.Image;
                    break;
                case 13:
                    pic28.Image = picture13.Image;
                    break;
                case 14:
                    pic28.Image = picture14.Image;
                    break;
                case 15:
                    pic28.Image = picture15.Image;
                    break;
                case 16:
                    pic28.Image = picture16.Image;
                    break;
                case 17:
                    pic28.Image = picture17.Image;
                    break;
                case 18:
                    pic28.Image = picture18.Image;
                    break;
                default:
                    pic28.Image = picture19.Image;
                    break;
            }


            //col3 now
            switch (_col3[0])
            {
                case 1:
                    pic31.Image = picture1.Image;
                    break;
                case 2:
                    pic31.Image = picture2.Image;
                    break;
                case 3:
                    pic31.Image = picture3.Image;
                    break;
                case 4:
                    pic31.Image = picture4.Image;
                    break;
                case 5:
                    pic31.Image = picture5.Image;
                    break;
                case 6:
                    pic31.Image = picture6.Image;
                    break;
                case 7:
                    pic31.Image = picture7.Image;
                    break;
                case 8:
                    pic31.Image = picture8.Image;
                    break;
                case 9:
                    pic31.Image = picture9.Image;
                    break;
                case 10:
                    pic31.Image = picture10.Image;
                    break;
                case 11:
                    pic31.Image = picture11.Image;
                    break;
                case 12:
                    pic31.Image = picture12.Image;
                    break;
                case 13:
                    pic31.Image = picture13.Image;
                    break;
                case 14:
                    pic31.Image = picture14.Image;
                    break;
                case 15:
                    pic31.Image = picture15.Image;
                    break;
                case 16:
                    pic31.Image = picture16.Image;
                    break;
                case 17:
                    pic31.Image = picture17.Image;
                    break;
                case 18:
                    pic31.Image = picture18.Image;
                    break;
                default:
                    pic31.Image = picture19.Image;
                    break;
            }
            switch (_col3[1])
            {
                case 1:
                    pic32.Image = picture1.Image;
                    break;
                case 2:
                    pic32.Image = picture2.Image;
                    break;
                case 3:
                    pic32.Image = picture3.Image;
                    break;
                case 4:
                    pic32.Image = picture4.Image;
                    break;
                case 5:
                    pic32.Image = picture5.Image;
                    break;
                case 6:
                    pic32.Image = picture6.Image;
                    break;
                case 7:
                    pic32.Image = picture7.Image;
                    break;
                case 8:
                    pic32.Image = picture8.Image;
                    break;
                case 9:
                    pic32.Image = picture9.Image;
                    break;
                case 10:
                    pic32.Image = picture10.Image;
                    break;
                case 11:
                    pic32.Image = picture11.Image;
                    break;
                case 12:
                    pic32.Image = picture12.Image;
                    break;
                case 13:
                    pic32.Image = picture13.Image;
                    break;
                case 14:
                    pic32.Image = picture14.Image;
                    break;
                case 15:
                    pic32.Image = picture15.Image;
                    break;
                case 16:
                    pic32.Image = picture16.Image;
                    break;
                case 17:
                    pic32.Image = picture17.Image;
                    break;
                case 18:
                    pic32.Image = picture18.Image;
                    break;
                default:
                    pic32.Image = picture19.Image;
                    break;
            }
            switch (_col3[2])
            {
                case 1:
                    pic33.Image = picture1.Image;
                    break;
                case 2:
                    pic33.Image = picture2.Image;
                    break;
                case 3:
                    pic33.Image = picture3.Image;
                    break;
                case 4:
                    pic33.Image = picture4.Image;
                    break;
                case 5:
                    pic33.Image = picture5.Image;
                    break;
                case 6:
                    pic33.Image = picture6.Image;
                    break;
                case 7:
                    pic33.Image = picture7.Image;
                    break;
                case 8:
                    pic33.Image = picture8.Image;
                    break;
                case 9:
                    pic33.Image = picture9.Image;
                    break;
                case 10:
                    pic33.Image = picture10.Image;
                    break;
                case 11:
                    pic33.Image = picture11.Image;
                    break;
                case 12:
                    pic33.Image = picture12.Image;
                    break;
                case 13:
                    pic33.Image = picture13.Image;
                    break;
                case 14:
                    pic33.Image = picture14.Image;
                    break;
                case 15:
                    pic33.Image = picture15.Image;
                    break;
                case 16:
                    pic33.Image = picture16.Image;
                    break;
                case 17:
                    pic33.Image = picture17.Image;
                    break;
                case 18:
                    pic33.Image = picture18.Image;
                    break;
                default:
                    pic33.Image = picture19.Image;
                    break;
            }
            switch (_col3[3])
            {
                case 1:
                    pic34.Image = picture1.Image;
                    break;
                case 2:
                    pic34.Image = picture2.Image;
                    break;
                case 3:
                    pic34.Image = picture3.Image;
                    break;
                case 4:
                    pic34.Image = picture4.Image;
                    break;
                case 5:
                    pic34.Image = picture5.Image;
                    break;
                case 6:
                    pic34.Image = picture6.Image;
                    break;
                case 7:
                    pic34.Image = picture7.Image;
                    break;
                case 8:
                    pic34.Image = picture8.Image;
                    break;
                case 9:
                    pic34.Image = picture9.Image;
                    break;
                case 10:
                    pic34.Image = picture10.Image;
                    break;
                case 11:
                    pic34.Image = picture11.Image;
                    break;
                case 12:
                    pic34.Image = picture12.Image;
                    break;
                case 13:
                    pic34.Image = picture13.Image;
                    break;
                case 14:
                    pic34.Image = picture14.Image;
                    break;
                case 15:
                    pic34.Image = picture15.Image;
                    break;
                case 16:
                    pic34.Image = picture16.Image;
                    break;
                case 17:
                    pic34.Image = picture17.Image;
                    break;
                case 18:
                    pic34.Image = picture18.Image;
                    break;
                default:
                    pic34.Image = picture19.Image;
                    break;
            }
            switch (_col3[4])
            {
                case 1:
                    pic35.Image = picture1.Image;
                    break;
                case 2:
                    pic35.Image = picture2.Image;
                    break;
                case 3:
                    pic35.Image = picture3.Image;
                    break;
                case 4:
                    pic35.Image = picture4.Image;
                    break;
                case 5:
                    pic35.Image = picture5.Image;
                    break;
                case 6:
                    pic35.Image = picture6.Image;
                    break;
                case 7:
                    pic35.Image = picture7.Image;
                    break;
                case 8:
                    pic35.Image = picture8.Image;
                    break;
                case 9:
                    pic35.Image = picture9.Image;
                    break;
                case 10:
                    pic35.Image = picture10.Image;
                    break;
                case 11:
                    pic35.Image = picture11.Image;
                    break;
                case 12:
                    pic35.Image = picture12.Image;
                    break;
                case 13:
                    pic35.Image = picture13.Image;
                    break;
                case 14:
                    pic35.Image = picture14.Image;
                    break;
                case 15:
                    pic35.Image = picture15.Image;
                    break;
                case 16:
                    pic35.Image = picture16.Image;
                    break;
                case 17:
                    pic35.Image = picture17.Image;
                    break;
                case 18:
                    pic35.Image = picture18.Image;
                    break;
                default:
                    pic35.Image = picture19.Image;
                    break;
            }
            switch (_col3[5])
            {
                case 1:
                    pic36.Image = picture1.Image;
                    break;
                case 2:
                    pic36.Image = picture2.Image;
                    break;
                case 3:
                    pic36.Image = picture3.Image;
                    break;
                case 4:
                    pic36.Image = picture4.Image;
                    break;
                case 5:
                    pic36.Image = picture5.Image;
                    break;
                case 6:
                    pic36.Image = picture6.Image;
                    break;
                case 7:
                    pic36.Image = picture7.Image;
                    break;
                case 8:
                    pic36.Image = picture8.Image;
                    break;
                case 9:
                    pic36.Image = picture9.Image;
                    break;
                case 10:
                    pic36.Image = picture10.Image;
                    break;
                case 11:
                    pic36.Image = picture11.Image;
                    break;
                case 12:
                    pic36.Image = picture12.Image;
                    break;
                case 13:
                    pic36.Image = picture13.Image;
                    break;
                case 14:
                    pic36.Image = picture14.Image;
                    break;
                case 15:
                    pic36.Image = picture15.Image;
                    break;
                case 16:
                    pic36.Image = picture16.Image;
                    break;
                case 17:
                    pic36.Image = picture17.Image;
                    break;
                case 18:
                    pic36.Image = picture18.Image;
                    break;
                default:
                    pic36.Image = picture19.Image;
                    break;
            }
            switch (_col3[6])
            {
                case 1:
                    pic37.Image = picture1.Image;
                    break;
                case 2:
                    pic37.Image = picture2.Image;
                    break;
                case 3:
                    pic37.Image = picture3.Image;
                    break;
                case 4:
                    pic37.Image = picture4.Image;
                    break;
                case 5:
                    pic37.Image = picture5.Image;
                    break;
                case 6:
                    pic37.Image = picture6.Image;
                    break;
                case 7:
                    pic37.Image = picture7.Image;
                    break;
                case 8:
                    pic37.Image = picture8.Image;
                    break;
                case 9:
                    pic37.Image = picture9.Image;
                    break;
                case 10:
                    pic37.Image = picture10.Image;
                    break;
                case 11:
                    pic37.Image = picture11.Image;
                    break;
                case 12:
                    pic37.Image = picture12.Image;
                    break;
                case 13:
                    pic37.Image = picture13.Image;
                    break;
                case 14:
                    pic37.Image = picture14.Image;
                    break;
                case 15:
                    pic37.Image = picture15.Image;
                    break;
                case 16:
                    pic37.Image = picture16.Image;
                    break;
                case 17:
                    pic37.Image = picture17.Image;
                    break;
                case 18:
                    pic37.Image = picture18.Image;
                    break;
                default:
                    pic37.Image = picture19.Image;
                    break;
            }
            switch (_col3[7])
            {
                case 1:
                    pic38.Image = picture1.Image;
                    break;
                case 2:
                    pic38.Image = picture2.Image;
                    break;
                case 3:
                    pic38.Image = picture3.Image;
                    break;
                case 4:
                    pic38.Image = picture4.Image;
                    break;
                case 5:
                    pic38.Image = picture5.Image;
                    break;
                case 6:
                    pic38.Image = picture6.Image;
                    break;
                case 7:
                    pic38.Image = picture7.Image;
                    break;
                case 8:
                    pic38.Image = picture8.Image;
                    break;
                case 9:
                    pic38.Image = picture9.Image;
                    break;
                case 10:
                    pic38.Image = picture10.Image;
                    break;
                case 11:
                    pic38.Image = picture11.Image;
                    break;
                case 12:
                    pic38.Image = picture12.Image;
                    break;
                case 13:
                    pic38.Image = picture13.Image;
                    break;
                case 14:
                    pic38.Image = picture14.Image;
                    break;
                case 15:
                    pic38.Image = picture15.Image;
                    break;
                case 16:
                    pic38.Image = picture16.Image;
                    break;
                case 17:
                    pic38.Image = picture17.Image;
                    break;
                case 18:
                    pic38.Image = picture18.Image;
                    break;
                default:
                    pic38.Image = picture19.Image;
                    break;
            }

            //col4 now

            switch (_col4[0])
            {
                case 1:
                    pic41.Image = picture1.Image;
                    break;
                case 2:
                    pic41.Image = picture2.Image;
                    break;
                case 3:
                    pic41.Image = picture3.Image;
                    break;
                case 4:
                    pic41.Image = picture4.Image;
                    break;
                case 5:
                    pic41.Image = picture5.Image;
                    break;
                case 6:
                    pic41.Image = picture6.Image;
                    break;
                case 7:
                    pic41.Image = picture7.Image;
                    break;
                case 8:
                    pic41.Image = picture8.Image;
                    break;
                case 9:
                    pic41.Image = picture9.Image;
                    break;
                case 10:
                    pic41.Image = picture10.Image;
                    break;
                case 11:
                    pic41.Image = picture11.Image;
                    break;
                case 12:
                    pic41.Image = picture12.Image;
                    break;
                case 13:
                    pic41.Image = picture13.Image;
                    break;
                case 14:
                    pic41.Image = picture14.Image;
                    break;
                case 15:
                    pic41.Image = picture15.Image;
                    break;
                case 16:
                    pic41.Image = picture16.Image;
                    break;
                case 17:
                    pic41.Image = picture17.Image;
                    break;
                case 18:
                    pic41.Image = picture18.Image;
                    break;
                default:
                    pic41.Image = picture19.Image;
                    break;
            }
            switch (_col4[1])
            {
                case 1:
                    pic42.Image = picture1.Image;
                    break;
                case 2:
                    pic42.Image = picture2.Image;
                    break;
                case 3:
                    pic42.Image = picture3.Image;
                    break;
                case 4:
                    pic42.Image = picture4.Image;
                    break;
                case 5:
                    pic42.Image = picture5.Image;
                    break;
                case 6:
                    pic42.Image = picture6.Image;
                    break;
                case 7:
                    pic42.Image = picture7.Image;
                    break;
                case 8:
                    pic42.Image = picture8.Image;
                    break;
                case 9:
                    pic42.Image = picture9.Image;
                    break;
                case 10:
                    pic42.Image = picture10.Image;
                    break;
                case 11:
                    pic42.Image = picture11.Image;
                    break;
                case 12:
                    pic42.Image = picture12.Image;
                    break;
                case 13:
                    pic42.Image = picture13.Image;
                    break;
                case 14:
                    pic42.Image = picture14.Image;
                    break;
                case 15:
                    pic42.Image = picture15.Image;
                    break;
                case 16:
                    pic42.Image = picture16.Image;
                    break;
                case 17:
                    pic42.Image = picture17.Image;
                    break;
                case 18:
                    pic42.Image = picture18.Image;
                    break;
                default:
                    pic42.Image = picture19.Image;
                    break;
            }
            switch (_col4[2])
            {
                case 1:
                    pic43.Image = picture1.Image;
                    break;
                case 2:
                    pic43.Image = picture2.Image;
                    break;
                case 3:
                    pic43.Image = picture3.Image;
                    break;
                case 4:
                    pic43.Image = picture4.Image;
                    break;
                case 5:
                    pic43.Image = picture5.Image;
                    break;
                case 6:
                    pic43.Image = picture6.Image;
                    break;
                case 7:
                    pic43.Image = picture7.Image;
                    break;
                case 8:
                    pic43.Image = picture8.Image;
                    break;
                case 9:
                    pic43.Image = picture9.Image;
                    break;
                case 10:
                    pic43.Image = picture10.Image;
                    break;
                case 11:
                    pic43.Image = picture11.Image;
                    break;
                case 12:
                    pic43.Image = picture12.Image;
                    break;
                case 13:
                    pic43.Image = picture13.Image;
                    break;
                case 14:
                    pic43.Image = picture14.Image;
                    break;
                case 15:
                    pic43.Image = picture15.Image;
                    break;
                case 16:
                    pic43.Image = picture16.Image;
                    break;
                case 17:
                    pic43.Image = picture17.Image;
                    break;
                case 18:
                    pic43.Image = picture18.Image;
                    break;
                default:
                    pic43.Image = picture19.Image;
                    break;
            }
            switch (_col4[3])
            {
                case 1:
                    pic44.Image = picture1.Image;
                    break;
                case 2:
                    pic44.Image = picture2.Image;
                    break;
                case 3:
                    pic44.Image = picture3.Image;
                    break;
                case 4:
                    pic44.Image = picture4.Image;
                    break;
                case 5:
                    pic44.Image = picture5.Image;
                    break;
                case 6:
                    pic44.Image = picture6.Image;
                    break;
                case 7:
                    pic44.Image = picture7.Image;
                    break;
                case 8:
                    pic44.Image = picture8.Image;
                    break;
                case 9:
                    pic44.Image = picture9.Image;
                    break;
                case 10:
                    pic44.Image = picture10.Image;
                    break;
                case 11:
                    pic44.Image = picture11.Image;
                    break;
                case 12:
                    pic44.Image = picture12.Image;
                    break;
                case 13:
                    pic44.Image = picture13.Image;
                    break;
                case 14:
                    pic44.Image = picture14.Image;
                    break;
                case 15:
                    pic44.Image = picture15.Image;
                    break;
                case 16:
                    pic44.Image = picture16.Image;
                    break;
                case 17:
                    pic44.Image = picture17.Image;
                    break;
                case 18:
                    pic44.Image = picture18.Image;
                    break;
                default:
                    pic44.Image = picture19.Image;
                    break;
            }
            switch (_col4[4])
            {
                case 1:
                    pic45.Image = picture1.Image;
                    break;
                case 2:
                    pic45.Image = picture2.Image;
                    break;
                case 3:
                    pic45.Image = picture3.Image;
                    break;
                case 4:
                    pic45.Image = picture4.Image;
                    break;
                case 5:
                    pic45.Image = picture5.Image;
                    break;
                case 6:
                    pic45.Image = picture6.Image;
                    break;
                case 7:
                    pic45.Image = picture7.Image;
                    break;
                case 8:
                    pic45.Image = picture8.Image;
                    break;
                case 9:
                    pic45.Image = picture9.Image;
                    break;
                case 10:
                    pic45.Image = picture10.Image;
                    break;
                case 11:
                    pic45.Image = picture11.Image;
                    break;
                case 12:
                    pic45.Image = picture12.Image;
                    break;
                case 13:
                    pic45.Image = picture13.Image;
                    break;
                case 14:
                    pic45.Image = picture14.Image;
                    break;
                case 15:
                    pic45.Image = picture15.Image;
                    break;
                case 16:
                    pic45.Image = picture16.Image;
                    break;
                case 17:
                    pic45.Image = picture17.Image;
                    break;
                case 18:
                    pic45.Image = picture18.Image;
                    break;
                default:
                    pic45.Image = picture19.Image;
                    break;
            }
            switch (_col4[5])
            {
                case 1:
                    pic46.Image = picture1.Image;
                    break;
                case 2:
                    pic46.Image = picture2.Image;
                    break;
                case 3:
                    pic46.Image = picture3.Image;
                    break;
                case 4:
                    pic46.Image = picture4.Image;
                    break;
                case 5:
                    pic46.Image = picture5.Image;
                    break;
                case 6:
                    pic46.Image = picture6.Image;
                    break;
                case 7:
                    pic46.Image = picture7.Image;
                    break;
                case 8:
                    pic46.Image = picture8.Image;
                    break;
                case 9:
                    pic46.Image = picture9.Image;
                    break;
                case 10:
                    pic46.Image = picture10.Image;
                    break;
                case 11:
                    pic46.Image = picture11.Image;
                    break;
                case 12:
                    pic46.Image = picture12.Image;
                    break;
                case 13:
                    pic46.Image = picture13.Image;
                    break;
                case 14:
                    pic46.Image = picture14.Image;
                    break;
                case 15:
                    pic46.Image = picture15.Image;
                    break;
                case 16:
                    pic46.Image = picture16.Image;
                    break;
                case 17:
                    pic46.Image = picture17.Image;
                    break;
                case 18:
                    pic46.Image = picture18.Image;
                    break;
                default:
                    pic46.Image = picture19.Image;
                    break;
            }
            switch (_col4[6])
            {
                case 1:
                    pic47.Image = picture1.Image;
                    break;
                case 2:
                    pic47.Image = picture2.Image;
                    break;
                case 3:
                    pic47.Image = picture3.Image;
                    break;
                case 4:
                    pic47.Image = picture4.Image;
                    break;
                case 5:
                    pic47.Image = picture5.Image;
                    break;
                case 6:
                    pic47.Image = picture6.Image;
                    break;
                case 7:
                    pic47.Image = picture7.Image;
                    break;
                case 8:
                    pic47.Image = picture8.Image;
                    break;
                case 9:
                    pic47.Image = picture9.Image;
                    break;
                case 10:
                    pic47.Image = picture10.Image;
                    break;
                case 11:
                    pic47.Image = picture11.Image;
                    break;
                case 12:
                    pic47.Image = picture12.Image;
                    break;
                case 13:
                    pic47.Image = picture13.Image;
                    break;
                case 14:
                    pic47.Image = picture14.Image;
                    break;
                case 15:
                    pic47.Image = picture15.Image;
                    break;
                case 16:
                    pic47.Image = picture16.Image;
                    break;
                case 17:
                    pic47.Image = picture17.Image;
                    break;
                case 18:
                    pic47.Image = picture18.Image;
                    break;
                default:
                    pic47.Image = picture19.Image;
                    break;
            }
            switch (_col4[7])
            {
                case 1:
                    pic48.Image = picture1.Image;
                    break;
                case 2:
                    pic48.Image = picture2.Image;
                    break;
                case 3:
                    pic48.Image = picture3.Image;
                    break;
                case 4:
                    pic48.Image = picture4.Image;
                    break;
                case 5:
                    pic48.Image = picture5.Image;
                    break;
                case 6:
                    pic48.Image = picture6.Image;
                    break;
                case 7:
                    pic48.Image = picture7.Image;
                    break;
                case 8:
                    pic48.Image = picture8.Image;
                    break;
                case 9:
                    pic48.Image = picture9.Image;
                    break;
                case 10:
                    pic48.Image = picture10.Image;
                    break;
                case 11:
                    pic48.Image = picture11.Image;
                    break;
                case 12:
                    pic48.Image = picture12.Image;
                    break;
                case 13:
                    pic48.Image = picture13.Image;
                    break;
                case 14:
                    pic48.Image = picture14.Image;
                    break;
                case 15:
                    pic48.Image = picture15.Image;
                    break;
                case 16:
                    pic48.Image = picture16.Image;
                    break;
                case 17:
                    pic48.Image = picture17.Image;
                    break;
                case 18:
                    pic48.Image = picture18.Image;
                    break;
                default:
                    pic48.Image = picture19.Image;
                    break;
            }

            //col5 now
            switch (_col5[0])
            {
                case 1:
                    pic51.Image = picture1.Image;
                    break;
                case 2:
                    pic51.Image = picture2.Image;
                    break;
                case 3:
                    pic51.Image = picture3.Image;
                    break;
                case 4:
                    pic51.Image = picture4.Image;
                    break;
                case 5:
                    pic51.Image = picture5.Image;
                    break;
                case 6:
                    pic51.Image = picture6.Image;
                    break;
                case 7:
                    pic51.Image = picture7.Image;
                    break;
                case 8:
                    pic51.Image = picture8.Image;
                    break;
                case 9:
                    pic51.Image = picture9.Image;
                    break;
                case 10:
                    pic51.Image = picture10.Image;
                    break;
                case 11:
                    pic51.Image = picture11.Image;
                    break;
                case 12:
                    pic51.Image = picture12.Image;
                    break;
                case 13:
                    pic51.Image = picture13.Image;
                    break;
                case 14:
                    pic51.Image = picture14.Image;
                    break;
                case 15:
                    pic51.Image = picture15.Image;
                    break;
                case 16:
                    pic51.Image = picture16.Image;
                    break;
                case 17:
                    pic51.Image = picture17.Image;
                    break;
                case 18:
                    pic51.Image = picture18.Image;
                    break;
                default:
                    pic51.Image = picture19.Image;
                    break;
            }
            switch (_col5[1])
            {
                case 1:
                    pic52.Image = picture1.Image;
                    break;
                case 2:
                    pic52.Image = picture2.Image;
                    break;
                case 3:
                    pic52.Image = picture3.Image;
                    break;
                case 4:
                    pic52.Image = picture4.Image;
                    break;
                case 5:
                    pic52.Image = picture5.Image;
                    break;
                case 6:
                    pic52.Image = picture6.Image;
                    break;
                case 7:
                    pic52.Image = picture7.Image;
                    break;
                case 8:
                    pic52.Image = picture8.Image;
                    break;
                case 9:
                    pic52.Image = picture9.Image;
                    break;
                case 10:
                    pic52.Image = picture10.Image;
                    break;
                case 11:
                    pic52.Image = picture11.Image;
                    break;
                case 12:
                    pic52.Image = picture12.Image;
                    break;
                case 13:
                    pic52.Image = picture13.Image;
                    break;
                case 14:
                    pic52.Image = picture14.Image;
                    break;
                case 15:
                    pic52.Image = picture15.Image;
                    break;
                case 16:
                    pic52.Image = picture16.Image;
                    break;
                case 17:
                    pic52.Image = picture17.Image;
                    break;
                case 18:
                    pic52.Image = picture18.Image;
                    break;
                default:
                    pic52.Image = picture19.Image;
                    break;
            }
            switch (_col5[2])
            {
                case 1:
                    pic53.Image = picture1.Image;
                    break;
                case 2:
                    pic53.Image = picture2.Image;
                    break;
                case 3:
                    pic53.Image = picture3.Image;
                    break;
                case 4:
                    pic53.Image = picture4.Image;
                    break;
                case 5:
                    pic53.Image = picture5.Image;
                    break;
                case 6:
                    pic53.Image = picture6.Image;
                    break;
                case 7:
                    pic53.Image = picture7.Image;
                    break;
                case 8:
                    pic53.Image = picture8.Image;
                    break;
                case 9:
                    pic53.Image = picture9.Image;
                    break;
                case 10:
                    pic53.Image = picture10.Image;
                    break;
                case 11:
                    pic53.Image = picture11.Image;
                    break;
                case 12:
                    pic53.Image = picture12.Image;
                    break;
                case 13:
                    pic53.Image = picture13.Image;
                    break;
                case 14:
                    pic53.Image = picture14.Image;
                    break;
                case 15:
                    pic53.Image = picture15.Image;
                    break;
                case 16:
                    pic53.Image = picture16.Image;
                    break;
                case 17:
                    pic53.Image = picture17.Image;
                    break;
                case 18:
                    pic53.Image = picture18.Image;
                    break;
                default:
                    pic53.Image = picture19.Image;
                    break;
            }
            switch (_col5[3])
            {
                case 1:
                    pic54.Image = picture1.Image;
                    break;
                case 2:
                    pic54.Image = picture2.Image;
                    break;
                case 3:
                    pic54.Image = picture3.Image;
                    break;
                case 4:
                    pic54.Image = picture4.Image;
                    break;
                case 5:
                    pic54.Image = picture5.Image;
                    break;
                case 6:
                    pic54.Image = picture6.Image;
                    break;
                case 7:
                    pic54.Image = picture7.Image;
                    break;
                case 8:
                    pic54.Image = picture8.Image;
                    break;
                case 9:
                    pic54.Image = picture9.Image;
                    break;
                case 10:
                    pic54.Image = picture10.Image;
                    break;
                case 11:
                    pic54.Image = picture11.Image;
                    break;
                case 12:
                    pic54.Image = picture12.Image;
                    break;
                case 13:
                    pic54.Image = picture13.Image;
                    break;
                case 14:
                    pic54.Image = picture14.Image;
                    break;
                case 15:
                    pic54.Image = picture15.Image;
                    break;
                case 16:
                    pic54.Image = picture16.Image;
                    break;
                case 17:
                    pic54.Image = picture17.Image;
                    break;
                case 18:
                    pic54.Image = picture18.Image;
                    break;
                default:
                    pic54.Image = picture19.Image;
                    break;
            }
            switch (_col5[4])
            {
                case 1:
                    pic55.Image = picture1.Image;
                    break;
                case 2:
                    pic55.Image = picture2.Image;
                    break;
                case 3:
                    pic55.Image = picture3.Image;
                    break;
                case 4:
                    pic55.Image = picture4.Image;
                    break;
                case 5:
                    pic55.Image = picture5.Image;
                    break;
                case 6:
                    pic55.Image = picture6.Image;
                    break;
                case 7:
                    pic55.Image = picture7.Image;
                    break;
                case 8:
                    pic55.Image = picture8.Image;
                    break;
                case 9:
                    pic55.Image = picture9.Image;
                    break;
                case 10:
                    pic55.Image = picture10.Image;
                    break;
                case 11:
                    pic55.Image = picture11.Image;
                    break;
                case 12:
                    pic55.Image = picture12.Image;
                    break;
                case 13:
                    pic55.Image = picture13.Image;
                    break;
                case 14:
                    pic55.Image = picture14.Image;
                    break;
                case 15:
                    pic55.Image = picture15.Image;
                    break;
                case 16:
                    pic55.Image = picture16.Image;
                    break;
                case 17:
                    pic55.Image = picture17.Image;
                    break;
                case 18:
                    pic55.Image = picture18.Image;
                    break;
                default:
                    pic55.Image = picture19.Image;
                    break;
            }
            switch (_col5[5])
            {
                case 1:
                    pic56.Image = picture1.Image;
                    break;
                case 2:
                    pic56.Image = picture2.Image;
                    break;
                case 3:
                    pic56.Image = picture3.Image;
                    break;
                case 4:
                    pic56.Image = picture4.Image;
                    break;
                case 5:
                    pic56.Image = picture5.Image;
                    break;
                case 6:
                    pic56.Image = picture6.Image;
                    break;
                case 7:
                    pic56.Image = picture7.Image;
                    break;
                case 8:
                    pic56.Image = picture8.Image;
                    break;
                case 9:
                    pic56.Image = picture9.Image;
                    break;
                case 10:
                    pic56.Image = picture10.Image;
                    break;
                case 11:
                    pic56.Image = picture11.Image;
                    break;
                case 12:
                    pic56.Image = picture12.Image;
                    break;
                case 13:
                    pic56.Image = picture13.Image;
                    break;
                case 14:
                    pic56.Image = picture14.Image;
                    break;
                case 15:
                    pic56.Image = picture15.Image;
                    break;
                case 16:
                    pic56.Image = picture16.Image;
                    break;
                case 17:
                    pic56.Image = picture17.Image;
                    break;
                case 18:
                    pic56.Image = picture18.Image;
                    break;
                default:
                    pic56.Image = picture19.Image;
                    break;
            }
            switch (_col5[6])
            {
                case 1:
                    pic57.Image = picture1.Image;
                    break;
                case 2:
                    pic57.Image = picture2.Image;
                    break;
                case 3:
                    pic57.Image = picture3.Image;
                    break;
                case 4:
                    pic57.Image = picture4.Image;
                    break;
                case 5:
                    pic57.Image = picture5.Image;
                    break;
                case 6:
                    pic57.Image = picture6.Image;
                    break;
                case 7:
                    pic57.Image = picture7.Image;
                    break;
                case 8:
                    pic57.Image = picture8.Image;
                    break;
                case 9:
                    pic57.Image = picture9.Image;
                    break;
                case 10:
                    pic57.Image = picture10.Image;
                    break;
                case 11:
                    pic57.Image = picture11.Image;
                    break;
                case 12:
                    pic57.Image = picture12.Image;
                    break;
                case 13:
                    pic57.Image = picture13.Image;
                    break;
                case 14:
                    pic57.Image = picture14.Image;
                    break;
                case 15:
                    pic57.Image = picture15.Image;
                    break;
                case 16:
                    pic57.Image = picture16.Image;
                    break;
                case 17:
                    pic57.Image = picture17.Image;
                    break;
                case 18:
                    pic57.Image = picture18.Image;
                    break;
                default:
                    pic57.Image = picture19.Image;
                    break;
            }
            switch (_col5[7])
            {
                case 1:
                    pic58.Image = picture1.Image;
                    break;
                case 2:
                    pic58.Image = picture2.Image;
                    break;
                case 3:
                    pic58.Image = picture3.Image;
                    break;
                case 4:
                    pic58.Image = picture4.Image;
                    break;
                case 5:
                    pic58.Image = picture5.Image;
                    break;
                case 6:
                    pic58.Image = picture6.Image;
                    break;
                case 7:
                    pic58.Image = picture7.Image;
                    break;
                case 8:
                    pic58.Image = picture8.Image;
                    break;
                case 9:
                    pic58.Image = picture9.Image;
                    break;
                case 10:
                    pic58.Image = picture10.Image;
                    break;
                case 11:
                    pic58.Image = picture11.Image;
                    break;
                case 12:
                    pic58.Image = picture12.Image;
                    break;
                case 13:
                    pic58.Image = picture13.Image;
                    break;
                case 14:
                    pic58.Image = picture14.Image;
                    break;
                case 15:
                    pic58.Image = picture15.Image;
                    break;
                case 16:
                    pic58.Image = picture16.Image;
                    break;
                case 17:
                    pic58.Image = picture17.Image;
                    break;
                case 18:
                    pic58.Image = picture18.Image;
                    break;
                default:
                    pic58.Image = picture19.Image;
                    break;
            }

            //col6 now
            switch (_col6[0])
            {
                case 1:
                    pic61.Image = picture1.Image;
                    break;
                case 2:
                    pic61.Image = picture2.Image;
                    break;
                case 3:
                    pic61.Image = picture3.Image;
                    break;
                case 4:
                    pic61.Image = picture4.Image;
                    break;
                case 5:
                    pic61.Image = picture5.Image;
                    break;
                case 6:
                    pic61.Image = picture6.Image;
                    break;
                case 7:
                    pic61.Image = picture7.Image;
                    break;
                case 8:
                    pic61.Image = picture8.Image;
                    break;
                case 9:
                    pic61.Image = picture9.Image;
                    break;
                case 10:
                    pic61.Image = picture10.Image;
                    break;
                case 11:
                    pic61.Image = picture11.Image;
                    break;
                case 12:
                    pic61.Image = picture12.Image;
                    break;
                case 13:
                    pic61.Image = picture13.Image;
                    break;
                case 14:
                    pic61.Image = picture14.Image;
                    break;
                case 15:
                    pic61.Image = picture15.Image;
                    break;
                case 16:
                    pic61.Image = picture16.Image;
                    break;
                case 17:
                    pic61.Image = picture17.Image;
                    break;
                case 18:
                    pic61.Image = picture18.Image;
                    break;
                default:
                    pic61.Image = picture19.Image;
                    break;
            }
            switch (_col6[1])
            {
                case 1:
                    pic62.Image = picture1.Image;
                    break;
                case 2:
                    pic62.Image = picture2.Image;
                    break;
                case 3:
                    pic62.Image = picture3.Image;
                    break;
                case 4:
                    pic62.Image = picture4.Image;
                    break;
                case 5:
                    pic62.Image = picture5.Image;
                    break;
                case 6:
                    pic62.Image = picture6.Image;
                    break;
                case 7:
                    pic62.Image = picture7.Image;
                    break;
                case 8:
                    pic62.Image = picture8.Image;
                    break;
                case 9:
                    pic62.Image = picture9.Image;
                    break;
                case 10:
                    pic62.Image = picture10.Image;
                    break;
                case 11:
                    pic62.Image = picture11.Image;
                    break;
                case 12:
                    pic62.Image = picture12.Image;
                    break;
                case 13:
                    pic62.Image = picture13.Image;
                    break;
                case 14:
                    pic62.Image = picture14.Image;
                    break;
                case 15:
                    pic62.Image = picture15.Image;
                    break;
                case 16:
                    pic62.Image = picture16.Image;
                    break;
                case 17:
                    pic62.Image = picture17.Image;
                    break;
                case 18:
                    pic62.Image = picture18.Image;
                    break;
                default:
                    pic62.Image = picture19.Image;
                    break;
            }
            switch (_col6[2])
            {
                case 1:
                    pic63.Image = picture1.Image;
                    break;
                case 2:
                    pic63.Image = picture2.Image;
                    break;
                case 3:
                    pic63.Image = picture3.Image;
                    break;
                case 4:
                    pic63.Image = picture4.Image;
                    break;
                case 5:
                    pic63.Image = picture5.Image;
                    break;
                case 6:
                    pic63.Image = picture6.Image;
                    break;
                case 7:
                    pic63.Image = picture7.Image;
                    break;
                case 8:
                    pic63.Image = picture8.Image;
                    break;
                case 9:
                    pic63.Image = picture9.Image;
                    break;
                case 10:
                    pic63.Image = picture10.Image;
                    break;
                case 11:
                    pic63.Image = picture11.Image;
                    break;
                case 12:
                    pic63.Image = picture12.Image;
                    break;
                case 13:
                    pic63.Image = picture13.Image;
                    break;
                case 14:
                    pic63.Image = picture14.Image;
                    break;
                case 15:
                    pic63.Image = picture15.Image;
                    break;
                case 16:
                    pic63.Image = picture16.Image;
                    break;
                case 17:
                    pic63.Image = picture17.Image;
                    break;
                case 18:
                    pic63.Image = picture18.Image;
                    break;
                default:
                    pic63.Image = picture19.Image;
                    break;
            }
            switch (_col6[3])
            {
                case 1:
                    pic64.Image = picture1.Image;
                    break;
                case 2:
                    pic64.Image = picture2.Image;
                    break;
                case 3:
                    pic64.Image = picture3.Image;
                    break;
                case 4:
                    pic64.Image = picture4.Image;
                    break;
                case 5:
                    pic64.Image = picture5.Image;
                    break;
                case 6:
                    pic64.Image = picture6.Image;
                    break;
                case 7:
                    pic64.Image = picture7.Image;
                    break;
                case 8:
                    pic64.Image = picture8.Image;
                    break;
                case 9:
                    pic64.Image = picture9.Image;
                    break;
                case 10:
                    pic64.Image = picture10.Image;
                    break;
                case 11:
                    pic64.Image = picture11.Image;
                    break;
                case 12:
                    pic64.Image = picture12.Image;
                    break;
                case 13:
                    pic64.Image = picture13.Image;
                    break;
                case 14:
                    pic64.Image = picture14.Image;
                    break;
                case 15:
                    pic64.Image = picture15.Image;
                    break;
                case 16:
                    pic64.Image = picture16.Image;
                    break;
                case 17:
                    pic64.Image = picture17.Image;
                    break;
                case 18:
                    pic64.Image = picture18.Image;
                    break;
                default:
                    pic64.Image = picture19.Image;
                    break;
            }
            switch (_col6[4])
            {
                case 1:
                    pic65.Image = picture1.Image;
                    break;
                case 2:
                    pic65.Image = picture2.Image;
                    break;
                case 3:
                    pic65.Image = picture3.Image;
                    break;
                case 4:
                    pic65.Image = picture4.Image;
                    break;
                case 5:
                    pic65.Image = picture5.Image;
                    break;
                case 6:
                    pic65.Image = picture6.Image;
                    break;
                case 7:
                    pic65.Image = picture7.Image;
                    break;
                case 8:
                    pic65.Image = picture8.Image;
                    break;
                case 9:
                    pic65.Image = picture9.Image;
                    break;
                case 10:
                    pic65.Image = picture10.Image;
                    break;
                case 11:
                    pic65.Image = picture11.Image;
                    break;
                case 12:
                    pic65.Image = picture12.Image;
                    break;
                case 13:
                    pic65.Image = picture13.Image;
                    break;
                case 14:
                    pic65.Image = picture14.Image;
                    break;
                case 15:
                    pic65.Image = picture15.Image;
                    break;
                case 16:
                    pic65.Image = picture16.Image;
                    break;
                case 17:
                    pic65.Image = picture17.Image;
                    break;
                case 18:
                    pic65.Image = picture18.Image;
                    break;
                default:
                    pic65.Image = picture19.Image;
                    break;
            }
            switch (_col6[5])
            {
                case 1:
                    pic66.Image = picture1.Image;
                    break;
                case 2:
                    pic66.Image = picture2.Image;
                    break;
                case 3:
                    pic66.Image = picture3.Image;
                    break;
                case 4:
                    pic66.Image = picture4.Image;
                    break;
                case 5:
                    pic66.Image = picture5.Image;
                    break;
                case 6:
                    pic66.Image = picture6.Image;
                    break;
                case 7:
                    pic66.Image = picture7.Image;
                    break;
                case 8:
                    pic66.Image = picture8.Image;
                    break;
                case 9:
                    pic66.Image = picture9.Image;
                    break;
                case 10:
                    pic66.Image = picture10.Image;
                    break;
                case 11:
                    pic66.Image = picture11.Image;
                    break;
                case 12:
                    pic66.Image = picture12.Image;
                    break;
                case 13:
                    pic66.Image = picture13.Image;
                    break;
                case 14:
                    pic66.Image = picture14.Image;
                    break;
                case 15:
                    pic66.Image = picture15.Image;
                    break;
                case 16:
                    pic66.Image = picture16.Image;
                    break;
                case 17:
                    pic66.Image = picture17.Image;
                    break;
                case 18:
                    pic66.Image = picture18.Image;
                    break;
                default:
                    pic66.Image = picture19.Image;
                    break;
            }
            switch (_col6[6])
            {
                case 1:
                    pic67.Image = picture1.Image;
                    break;
                case 2:
                    pic67.Image = picture2.Image;
                    break;
                case 3:
                    pic67.Image = picture3.Image;
                    break;
                case 4:
                    pic67.Image = picture4.Image;
                    break;
                case 5:
                    pic67.Image = picture5.Image;
                    break;
                case 6:
                    pic67.Image = picture6.Image;
                    break;
                case 7:
                    pic67.Image = picture7.Image;
                    break;
                case 8:
                    pic67.Image = picture8.Image;
                    break;
                case 9:
                    pic67.Image = picture9.Image;
                    break;
                case 10:
                    pic67.Image = picture10.Image;
                    break;
                case 11:
                    pic67.Image = picture11.Image;
                    break;
                case 12:
                    pic67.Image = picture12.Image;
                    break;
                case 13:
                    pic67.Image = picture13.Image;
                    break;
                case 14:
                    pic67.Image = picture14.Image;
                    break;
                case 15:
                    pic67.Image = picture15.Image;
                    break;
                case 16:
                    pic67.Image = picture16.Image;
                    break;
                case 17:
                    pic67.Image = picture17.Image;
                    break;
                case 18:
                    pic67.Image = picture18.Image;
                    break;
                default:
                    pic67.Image = picture19.Image;
                    break;
            }
            switch (_col6[7])
            {
                case 1:
                    pic68.Image = picture1.Image;
                    break;
                case 2:
                    pic68.Image = picture2.Image;
                    break;
                case 3:
                    pic68.Image = picture3.Image;
                    break;
                case 4:
                    pic68.Image = picture4.Image;
                    break;
                case 5:
                    pic68.Image = picture5.Image;
                    break;
                case 6:
                    pic68.Image = picture6.Image;
                    break;
                case 7:
                    pic68.Image = picture7.Image;
                    break;
                case 8:
                    pic68.Image = picture8.Image;
                    break;
                case 9:
                    pic68.Image = picture9.Image;
                    break;
                case 10:
                    pic68.Image = picture10.Image;
                    break;
                case 11:
                    pic68.Image = picture11.Image;
                    break;
                case 12:
                    pic68.Image = picture12.Image;
                    break;
                case 13:
                    pic68.Image = picture13.Image;
                    break;
                case 14:
                    pic68.Image = picture14.Image;
                    break;
                case 15:
                    pic68.Image = picture15.Image;
                    break;
                case 16:
                    pic68.Image = picture16.Image;
                    break;
                case 17:
                    pic68.Image = picture17.Image;
                    break;
                case 18:
                    pic68.Image = picture18.Image;
                    break;
                default:
                    pic68.Image = picture19.Image;
                    break;
            }

            //col7 now
            switch (_col7[0])
            {
                case 1:
                    pic71.Image = picture1.Image;
                    break;
                case 2:
                    pic71.Image = picture2.Image;
                    break;
                case 3:
                    pic71.Image = picture3.Image;
                    break;
                case 4:
                    pic71.Image = picture4.Image;
                    break;
                case 5:
                    pic71.Image = picture5.Image;
                    break;
                case 6:
                    pic71.Image = picture6.Image;
                    break;
                case 7:
                    pic71.Image = picture7.Image;
                    break;
                case 8:
                    pic71.Image = picture8.Image;
                    break;
                case 9:
                    pic71.Image = picture9.Image;
                    break;
                case 10:
                    pic71.Image = picture10.Image;
                    break;
                case 11:
                    pic71.Image = picture11.Image;
                    break;
                case 12:
                    pic71.Image = picture12.Image;
                    break;
                case 13:
                    pic71.Image = picture13.Image;
                    break;
                case 14:
                    pic71.Image = picture14.Image;
                    break;
                case 15:
                    pic71.Image = picture15.Image;
                    break;
                case 16:
                    pic71.Image = picture16.Image;
                    break;
                case 17:
                    pic71.Image = picture17.Image;
                    break;
                case 18:
                    pic71.Image = picture18.Image;
                    break;
                default:
                    pic71.Image = picture19.Image;
                    break;
            }
            switch (_col7[1])
            {
                case 1:
                    pic72.Image = picture1.Image;
                    break;
                case 2:
                    pic72.Image = picture2.Image;
                    break;
                case 3:
                    pic72.Image = picture3.Image;
                    break;
                case 4:
                    pic72.Image = picture4.Image;
                    break;
                case 5:
                    pic72.Image = picture5.Image;
                    break;
                case 6:
                    pic72.Image = picture6.Image;
                    break;
                case 7:
                    pic72.Image = picture7.Image;
                    break;
                case 8:
                    pic72.Image = picture8.Image;
                    break;
                case 9:
                    pic72.Image = picture9.Image;
                    break;
                case 10:
                    pic72.Image = picture10.Image;
                    break;
                case 11:
                    pic72.Image = picture11.Image;
                    break;
                case 12:
                    pic72.Image = picture12.Image;
                    break;
                case 13:
                    pic72.Image = picture13.Image;
                    break;
                case 14:
                    pic72.Image = picture14.Image;
                    break;
                case 15:
                    pic72.Image = picture15.Image;
                    break;
                case 16:
                    pic72.Image = picture16.Image;
                    break;
                case 17:
                    pic72.Image = picture17.Image;
                    break;
                case 18:
                    pic72.Image = picture18.Image;
                    break;
                default:
                    pic72.Image = picture19.Image;
                    break;
            }
            switch (_col7[2])
            {
                case 1:
                    pic73.Image = picture1.Image;
                    break;
                case 2:
                    pic73.Image = picture2.Image;
                    break;
                case 3:
                    pic73.Image = picture3.Image;
                    break;
                case 4:
                    pic73.Image = picture4.Image;
                    break;
                case 5:
                    pic73.Image = picture5.Image;
                    break;
                case 6:
                    pic73.Image = picture6.Image;
                    break;
                case 7:
                    pic73.Image = picture7.Image;
                    break;
                case 8:
                    pic73.Image = picture8.Image;
                    break;
                case 9:
                    pic73.Image = picture9.Image;
                    break;
                case 10:
                    pic73.Image = picture10.Image;
                    break;
                case 11:
                    pic73.Image = picture11.Image;
                    break;
                case 12:
                    pic73.Image = picture12.Image;
                    break;
                case 13:
                    pic73.Image = picture13.Image;
                    break;
                case 14:
                    pic73.Image = picture14.Image;
                    break;
                case 15:
                    pic73.Image = picture15.Image;
                    break;
                case 16:
                    pic73.Image = picture16.Image;
                    break;
                case 17:
                    pic73.Image = picture17.Image;
                    break;
                case 18:
                    pic73.Image = picture18.Image;
                    break;
                default:
                    pic73.Image = picture19.Image;
                    break;
            }
            switch (_col7[3])
            {
                case 1:
                    pic74.Image = picture1.Image;
                    break;
                case 2:
                    pic74.Image = picture2.Image;
                    break;
                case 3:
                    pic74.Image = picture3.Image;
                    break;
                case 4:
                    pic74.Image = picture4.Image;
                    break;
                case 5:
                    pic74.Image = picture5.Image;
                    break;
                case 6:
                    pic74.Image = picture6.Image;
                    break;
                case 7:
                    pic74.Image = picture7.Image;
                    break;
                case 8:
                    pic74.Image = picture8.Image;
                    break;
                case 9:
                    pic74.Image = picture9.Image;
                    break;
                case 10:
                    pic74.Image = picture10.Image;
                    break;
                case 11:
                    pic74.Image = picture11.Image;
                    break;
                case 12:
                    pic74.Image = picture12.Image;
                    break;
                case 13:
                    pic74.Image = picture13.Image;
                    break;
                case 14:
                    pic74.Image = picture14.Image;
                    break;
                case 15:
                    pic74.Image = picture15.Image;
                    break;
                case 16:
                    pic74.Image = picture16.Image;
                    break;
                case 17:
                    pic74.Image = picture17.Image;
                    break;
                case 18:
                    pic74.Image = picture18.Image;
                    break;
                default:
                    pic74.Image = picture19.Image;
                    break;
            }
            switch (_col7[4])
            {
                case 1:
                    pic75.Image = picture1.Image;
                    break;
                case 2:
                    pic75.Image = picture2.Image;
                    break;
                case 3:
                    pic75.Image = picture3.Image;
                    break;
                case 4:
                    pic75.Image = picture4.Image;
                    break;
                case 5:
                    pic75.Image = picture5.Image;
                    break;
                case 6:
                    pic75.Image = picture6.Image;
                    break;
                case 7:
                    pic75.Image = picture7.Image;
                    break;
                case 8:
                    pic75.Image = picture8.Image;
                    break;
                case 9:
                    pic75.Image = picture9.Image;
                    break;
                case 10:
                    pic75.Image = picture10.Image;
                    break;
                case 11:
                    pic75.Image = picture11.Image;
                    break;
                case 12:
                    pic75.Image = picture12.Image;
                    break;
                case 13:
                    pic75.Image = picture13.Image;
                    break;
                case 14:
                    pic75.Image = picture14.Image;
                    break;
                case 15:
                    pic75.Image = picture15.Image;
                    break;
                case 16:
                    pic75.Image = picture16.Image;
                    break;
                case 17:
                    pic75.Image = picture17.Image;
                    break;
                case 18:
                    pic75.Image = picture18.Image;
                    break;
                default:
                    pic75.Image = picture19.Image;
                    break;
            }
            switch (_col7[5])
            {
                case 1:
                    pic76.Image = picture1.Image;
                    break;
                case 2:
                    pic76.Image = picture2.Image;
                    break;
                case 3:
                    pic76.Image = picture3.Image;
                    break;
                case 4:
                    pic76.Image = picture4.Image;
                    break;
                case 5:
                    pic76.Image = picture5.Image;
                    break;
                case 6:
                    pic76.Image = picture6.Image;
                    break;
                case 7:
                    pic76.Image = picture7.Image;
                    break;
                case 8:
                    pic76.Image = picture8.Image;
                    break;
                case 9:
                    pic76.Image = picture9.Image;
                    break;
                case 10:
                    pic76.Image = picture10.Image;
                    break;
                case 11:
                    pic76.Image = picture11.Image;
                    break;
                case 12:
                    pic76.Image = picture12.Image;
                    break;
                case 13:
                    pic76.Image = picture13.Image;
                    break;
                case 14:
                    pic76.Image = picture14.Image;
                    break;
                case 15:
                    pic76.Image = picture15.Image;
                    break;
                case 16:
                    pic76.Image = picture16.Image;
                    break;
                case 17:
                    pic76.Image = picture17.Image;
                    break;
                case 18:
                    pic76.Image = picture18.Image;
                    break;
                default:
                    pic76.Image = picture19.Image;
                    break;
            }
            switch (_col7[6])
            {
                case 1:
                    pic77.Image = picture1.Image;
                    break;
                case 2:
                    pic77.Image = picture2.Image;
                    break;
                case 3:
                    pic77.Image = picture3.Image;
                    break;
                case 4:
                    pic77.Image = picture4.Image;
                    break;
                case 5:
                    pic77.Image = picture5.Image;
                    break;
                case 6:
                    pic77.Image = picture6.Image;
                    break;
                case 7:
                    pic77.Image = picture7.Image;
                    break;
                case 8:
                    pic77.Image = picture8.Image;
                    break;
                case 9:
                    pic77.Image = picture9.Image;
                    break;
                case 10:
                    pic77.Image = picture10.Image;
                    break;
                case 11:
                    pic77.Image = picture11.Image;
                    break;
                case 12:
                    pic77.Image = picture12.Image;
                    break;
                case 13:
                    pic77.Image = picture13.Image;
                    break;
                case 14:
                    pic77.Image = picture14.Image;
                    break;
                case 15:
                    pic77.Image = picture15.Image;
                    break;
                case 16:
                    pic77.Image = picture16.Image;
                    break;
                case 17:
                    pic77.Image = picture17.Image;
                    break;
                case 18:
                    pic77.Image = picture18.Image;
                    break;
                default:
                    pic77.Image = picture19.Image;
                    break;
            }
            switch (_col7[7])
            {
                case 1:
                    pic78.Image = picture1.Image;
                    break;
                case 2:
                    pic78.Image = picture2.Image;
                    break;
                case 3:
                    pic78.Image = picture3.Image;
                    break;
                case 4:
                    pic78.Image = picture4.Image;
                    break;
                case 5:
                    pic78.Image = picture5.Image;
                    break;
                case 6:
                    pic78.Image = picture6.Image;
                    break;
                case 7:
                    pic78.Image = picture7.Image;
                    break;
                case 8:
                    pic78.Image = picture8.Image;
                    break;
                case 9:
                    pic78.Image = picture9.Image;
                    break;
                case 10:
                    pic78.Image = picture10.Image;
                    break;
                case 11:
                    pic78.Image = picture11.Image;
                    break;
                case 12:
                    pic78.Image = picture12.Image;
                    break;
                case 13:
                    pic78.Image = picture13.Image;
                    break;
                case 14:
                    pic78.Image = picture14.Image;
                    break;
                case 15:
                    pic78.Image = picture15.Image;
                    break;
                case 16:
                    pic78.Image = picture16.Image;
                    break;
                case 17:
                    pic78.Image = picture17.Image;
                    break;
                case 18:
                    pic78.Image = picture18.Image;
                    break;
                default:
                    pic78.Image = picture19.Image;
                    break;
            }

            //col8 now
            switch (_col8[0])
            {
                case 1:
                    pic81.Image = picture1.Image;
                    break;
                case 2:
                    pic81.Image = picture2.Image;
                    break;
                case 3:
                    pic81.Image = picture3.Image;
                    break;
                case 4:
                    pic81.Image = picture4.Image;
                    break;
                case 5:
                    pic81.Image = picture5.Image;
                    break;
                case 6:
                    pic81.Image = picture6.Image;
                    break;
                case 7:
                    pic81.Image = picture7.Image;
                    break;
                case 8:
                    pic81.Image = picture8.Image;
                    break;
                case 9:
                    pic81.Image = picture9.Image;
                    break;
                case 10:
                    pic81.Image = picture10.Image;
                    break;
                case 11:
                    pic81.Image = picture11.Image;
                    break;
                case 12:
                    pic81.Image = picture12.Image;
                    break;
                case 13:
                    pic81.Image = picture13.Image;
                    break;
                case 14:
                    pic81.Image = picture14.Image;
                    break;
                case 15:
                    pic81.Image = picture15.Image;
                    break;
                case 16:
                    pic81.Image = picture16.Image;
                    break;
                case 17:
                    pic81.Image = picture17.Image;
                    break;
                case 18:
                    pic81.Image = picture18.Image;
                    break;
                default:
                    pic81.Image = picture19.Image;
                    break;
            }
            switch (_col8[1])
            {
                case 1:
                    pic82.Image = picture1.Image;
                    break;
                case 2:
                    pic82.Image = picture2.Image;
                    break;
                case 3:
                    pic82.Image = picture3.Image;
                    break;
                case 4:
                    pic82.Image = picture4.Image;
                    break;
                case 5:
                    pic82.Image = picture5.Image;
                    break;
                case 6:
                    pic82.Image = picture6.Image;
                    break;
                case 7:
                    pic82.Image = picture7.Image;
                    break;
                case 8:
                    pic82.Image = picture8.Image;
                    break;
                case 9:
                    pic82.Image = picture9.Image;
                    break;
                case 10:
                    pic82.Image = picture10.Image;
                    break;
                case 11:
                    pic82.Image = picture11.Image;
                    break;
                case 12:
                    pic82.Image = picture12.Image;
                    break;
                case 13:
                    pic82.Image = picture13.Image;
                    break;
                case 14:
                    pic82.Image = picture14.Image;
                    break;
                case 15:
                    pic82.Image = picture15.Image;
                    break;
                case 16:
                    pic82.Image = picture16.Image;
                    break;
                case 17:
                    pic82.Image = picture17.Image;
                    break;
                case 18:
                    pic82.Image = picture18.Image;
                    break;
                default:
                    pic82.Image = picture19.Image;
                    break;
            }
            switch (_col8[2])
            {
                case 1:
                    pic83.Image = picture1.Image;
                    break;
                case 2:
                    pic83.Image = picture2.Image;
                    break;
                case 3:
                    pic83.Image = picture3.Image;
                    break;
                case 4:
                    pic83.Image = picture4.Image;
                    break;
                case 5:
                    pic83.Image = picture5.Image;
                    break;
                case 6:
                    pic83.Image = picture6.Image;
                    break;
                case 7:
                    pic83.Image = picture7.Image;
                    break;
                case 8:
                    pic83.Image = picture8.Image;
                    break;
                case 9:
                    pic83.Image = picture9.Image;
                    break;
                case 10:
                    pic83.Image = picture10.Image;
                    break;
                case 11:
                    pic83.Image = picture11.Image;
                    break;
                case 12:
                    pic83.Image = picture12.Image;
                    break;
                case 13:
                    pic83.Image = picture13.Image;
                    break;
                case 14:
                    pic83.Image = picture14.Image;
                    break;
                case 15:
                    pic83.Image = picture15.Image;
                    break;
                case 16:
                    pic83.Image = picture16.Image;
                    break;
                case 17:
                    pic83.Image = picture17.Image;
                    break;
                case 18:
                    pic83.Image = picture18.Image;
                    break;
                default:
                    pic83.Image = picture19.Image;
                    break;
            }
            switch (_col8[3])
            {
                case 1:
                    pic84.Image = picture1.Image;
                    break;
                case 2:
                    pic84.Image = picture2.Image;
                    break;
                case 3:
                    pic84.Image = picture3.Image;
                    break;
                case 4:
                    pic84.Image = picture4.Image;
                    break;
                case 5:
                    pic84.Image = picture5.Image;
                    break;
                case 6:
                    pic84.Image = picture6.Image;
                    break;
                case 7:
                    pic84.Image = picture7.Image;
                    break;
                case 8:
                    pic84.Image = picture8.Image;
                    break;
                case 9:
                    pic84.Image = picture9.Image;
                    break;
                case 10:
                    pic84.Image = picture10.Image;
                    break;
                case 11:
                    pic84.Image = picture11.Image;
                    break;
                case 12:
                    pic84.Image = picture12.Image;
                    break;
                case 13:
                    pic84.Image = picture13.Image;
                    break;
                case 14:
                    pic84.Image = picture14.Image;
                    break;
                case 15:
                    pic84.Image = picture15.Image;
                    break;
                case 16:
                    pic84.Image = picture16.Image;
                    break;
                case 17:
                    pic84.Image = picture17.Image;
                    break;
                case 18:
                    pic84.Image = picture18.Image;
                    break;
                default:
                    pic84.Image = picture19.Image;
                    break;
            }
            switch (_col8[4])
            {
                case 1:
                    pic85.Image = picture1.Image;
                    break;
                case 2:
                    pic85.Image = picture2.Image;
                    break;
                case 3:
                    pic85.Image = picture3.Image;
                    break;
                case 4:
                    pic85.Image = picture4.Image;
                    break;
                case 5:
                    pic85.Image = picture5.Image;
                    break;
                case 6:
                    pic85.Image = picture6.Image;
                    break;
                case 7:
                    pic85.Image = picture7.Image;
                    break;
                case 8:
                    pic85.Image = picture8.Image;
                    break;
                case 9:
                    pic85.Image = picture9.Image;
                    break;
                case 10:
                    pic85.Image = picture10.Image;
                    break;
                case 11:
                    pic85.Image = picture11.Image;
                    break;
                case 12:
                    pic85.Image = picture12.Image;
                    break;
                case 13:
                    pic85.Image = picture13.Image;
                    break;
                case 14:
                    pic85.Image = picture14.Image;
                    break;
                case 15:
                    pic85.Image = picture15.Image;
                    break;
                case 16:
                    pic85.Image = picture16.Image;
                    break;
                case 17:
                    pic85.Image = picture17.Image;
                    break;
                case 18:
                    pic85.Image = picture18.Image;
                    break;
                default:
                    pic85.Image = picture19.Image;
                    break;
            }
            switch (_col8[5])
            {
                case 1:
                    pic86.Image = picture1.Image;
                    break;
                case 2:
                    pic86.Image = picture2.Image;
                    break;
                case 3:
                    pic86.Image = picture3.Image;
                    break;
                case 4:
                    pic86.Image = picture4.Image;
                    break;
                case 5:
                    pic86.Image = picture5.Image;
                    break;
                case 6:
                    pic86.Image = picture6.Image;
                    break;
                case 7:
                    pic86.Image = picture7.Image;
                    break;
                case 8:
                    pic86.Image = picture8.Image;
                    break;
                case 9:
                    pic86.Image = picture9.Image;
                    break;
                case 10:
                    pic86.Image = picture10.Image;
                    break;
                case 11:
                    pic86.Image = picture11.Image;
                    break;
                case 12:
                    pic86.Image = picture12.Image;
                    break;
                case 13:
                    pic86.Image = picture13.Image;
                    break;
                case 14:
                    pic86.Image = picture14.Image;
                    break;
                case 15:
                    pic86.Image = picture15.Image;
                    break;
                case 16:
                    pic86.Image = picture16.Image;
                    break;
                case 17:
                    pic86.Image = picture17.Image;
                    break;
                case 18:
                    pic86.Image = picture18.Image;
                    break;
                default:
                    pic86.Image = picture19.Image;
                    break;
            }
            switch (_col8[6])
            {
                case 1:
                    pic87.Image = picture1.Image;
                    break;
                case 2:
                    pic87.Image = picture2.Image;
                    break;
                case 3:
                    pic87.Image = picture3.Image;
                    break;
                case 4:
                    pic87.Image = picture4.Image;
                    break;
                case 5:
                    pic87.Image = picture5.Image;
                    break;
                case 6:
                    pic87.Image = picture6.Image;
                    break;
                case 7:
                    pic87.Image = picture7.Image;
                    break;
                case 8:
                    pic87.Image = picture8.Image;
                    break;
                case 9:
                    pic87.Image = picture9.Image;
                    break;
                case 10:
                    pic87.Image = picture10.Image;
                    break;
                case 11:
                    pic87.Image = picture11.Image;
                    break;
                case 12:
                    pic87.Image = picture12.Image;
                    break;
                case 13:
                    pic87.Image = picture13.Image;
                    break;
                case 14:
                    pic87.Image = picture14.Image;
                    break;
                case 15:
                    pic87.Image = picture15.Image;
                    break;
                case 16:
                    pic87.Image = picture16.Image;
                    break;
                case 17:
                    pic87.Image = picture17.Image;
                    break;
                case 18:
                    pic87.Image = picture18.Image;
                    break;
                default:
                    pic87.Image = picture19.Image;
                    break;
            }
            switch (_col8[7])
            {
                case 1:
                    pic88.Image = picture1.Image;
                    break;
                case 2:
                    pic88.Image = picture2.Image;
                    break;
                case 3:
                    pic88.Image = picture3.Image;
                    break;
                case 4:
                    pic88.Image = picture4.Image;
                    break;
                case 5:
                    pic88.Image = picture5.Image;
                    break;
                case 6:
                    pic88.Image = picture6.Image;
                    break;
                case 7:
                    pic88.Image = picture7.Image;
                    break;
                case 8:
                    pic88.Image = picture8.Image;
                    break;
                case 9:
                    pic88.Image = picture9.Image;
                    break;
                case 10:
                    pic88.Image = picture10.Image;
                    break;
                case 11:
                    pic88.Image = picture11.Image;
                    break;
                case 12:
                    pic88.Image = picture12.Image;
                    break;
                case 13:
                    pic88.Image = picture13.Image;
                    break;
                case 14:
                    pic88.Image = picture14.Image;
                    break;
                case 15:
                    pic88.Image = picture15.Image;
                    break;
                case 16:
                    pic88.Image = picture16.Image;
                    break;
                case 17:
                    pic88.Image = picture17.Image;
                    break;
                case 18:
                    pic88.Image = picture18.Image;
                    break;
                default:
                    pic88.Image = picture19.Image;
                    break;
            }

        }

        private int fType(int nCol,int nRow)
        {
            switch (nCol)
            {
                case 1:
                    return _col1[nRow - 1];
                case 2:
                    return _col2[nRow - 1];
                case 3:
                    return _col3[nRow - 1];
                case 4:
                    return _col4[nRow - 1];
                case 5:
                    return _col5[nRow - 1];
                case 6:
                    return _col6[nRow - 1];
                case 7:
                    return _col7[nRow - 1];
                default:
                    return _col8[nRow - 1];

            }
        }
        private bool fValidSquare(int nCol,int nRow)
        {
            Random rnd1 = new Random();
            int nType;
            bool bValid = true;
            int nDirection;
            bool bValid2 = true;

            switch (mnMode)
            {
                case 1:
                    switch (mnSubmode)
                    {
                        case 1:
                            nType = fType(nCol, nRow);
                            switch (nType)
                            {
                                case 15:
                                    mnWhat1 = 15;
                                    mnWhat2 = 0;
                                    mnSubmode = 2;
                                    fUpdate1();
                                    break;
                                case 17:
                                    mnWhat1 = 17;
                                    mnWhat2 = 0;
                                    mnSubmode = 2;
                                    fUpdate1();
                                    break;
                                case 11:
                                    mnWhat1 = 11;
                                    mnWhat2 = 0;
                                    mnSubmode = 2;
                                    fUpdate1();
                                    break;
                                default:
                                    bValid = false;
                                    MessageBox.Show("Invalid square");
                                    break;
                            }
                            break;
                        default:
                            nType = fType(nCol, nRow);
                            switch (nType)
                            {
                                case 14:
                                    mnWhat2 = 14;
                                    mnSubmode = 2;
                                     mnSubmode = 1;
                                    fUpdate1();
                                    fDial();
                                    break;
                                case 16:
                                    mnWhat2 = 16;
                                    mnSubmode = 2;
                                     mnSubmode = 1;
                                    fUpdate1();
                                    fDial();
                                    break;
                                case 10:
                                    mnWhat2 = 10;
                                    mnSubmode = 2;
                                     mnSubmode = 1;
                                    fUpdate1();
                                    fDial();
                                    break;
                                default:
                                    bValid = false;
                                    MessageBox.Show("Invalid square");
                                    break;
                            }
                            break;
                    }
                    break;
                case 2:
                    nType = fType(nCol, nRow);
                    switch (nType)
                    {
                        case 13:
                            nDirection = rnd1.Next(1, 5);
                            bValid2 = true;
                            switch (nDirection)
                            {
                                case 1:
                                    nRow -= 1;
                                    break;
                                case 2:
                                    nCol += 1;
                                    break;
                                case 3:
                                    nRow -= 1;
                                    break;
                                case 4:
                                    nCol += 1;
                                    break;
                            }
                            if (nRow == 9)
                            {
                                bValid2 = false;
                            }
                            if (nCol == 9)
                            {
                                bValid2 = false;
                            }
                            if (nRow == 0)
                            {
                                bValid2 = false;
                            }
                            if (nCol == 0)
                            {
                                bValid2 = false;
                            }
                            if (bValid2 == false)
                            {
                                MessageBox.Show("Invalid square");
                                bValid = false;
                            }
                            else
                            {
                                mnTransportCol = nCol;
                                mnTransportRow = nRow;
                                fStick(nCol, nRow, 18);
                                fUpdateDisplay();
                            }
                            break;
                        case 12:
                            mnTransportCol = nCol;
                            mnTransportRow = nRow;
                            break;
                        default:
                            bValid = false;
                            MessageBox.Show("Invalid square");
                            break;
                    }
                    break;
                default:
                    nType = fType(nCol, nRow);
                    switch (nType)
                    {
                        case 1:
                            fStick(nCol, nRow, 3);
                            fUpdateDisplay();
                            break;
                        case 2:
                            fStick(nCol, nRow, 3);
                            fUpdateDisplay();
                            break;
                        case 3:
                            fStick(nCol, nRow, 4);
                            fUpdateDisplay();
                             break;
                        case 4:
                            fStick(nCol, nRow, 5);
                            fUpdateDisplay();
                            fDial();
                            break;
                        case 5:
                            fStick(nCol, nRow, 6);
                            fUpdateDisplay();
                            fDial();
                            break;
                        case 6:
                            fStick(nCol, nRow, 7);
                            fUpdateDisplay();
                            break;
                        case 7:
                            fStick(nCol, nRow, 8);
                            fUpdateDisplay();
                            fDial();
                            break;
                        case 8:
                            break;
                        default:
                            bValid = false;
                            MessageBox.Show("Invalid square");
                            break;
                    }
                    break;

            }
            return bValid;
        }
        private void fRedrawMode()
        {

            Random rnd1 = new Random();
            int nCol, nRow, nType;

            nCol = rnd1.Next(1, 9);
            nRow = rnd1.Next(1, 9);
            _station1[0] = nCol;
            _station1[1] = nRow;
            nCol = rnd1.Next(1, 9);
            nRow = rnd1.Next(1, 9);
            _station2[0] = nCol;
            _station2[1] = nRow;
            mnMode = rnd1.Next(1, 4);
            mnSubmode = 1;
            mnPercentageChange = rnd1.Next(20, 70);

            switch (mnMode)
            {
                case 1:
                    lblDial.Text = "DIAL = Mining";
                    break;
                case 2:
                    lblDial.Text = "DIAL = Farming";
                    break;
                default:
                    lblDial.Text = "DIAL = Construction";
                    break;
            }

            for (int i = 1; i <= 8; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col1[i - 1] = 1;
                }
                else
                {
                    _col1[i - 1] = 2;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col2[i - 1] = 1;
                }
                else
                {
                    _col2[i - 1] = 2;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col3[i - 1] = 1;
                }
                else
                {
                    _col3[i - 1] = 2;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col4[i - 1] = 1;
                }
                else
                {
                    _col4[i - 1] = 2;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col5[i - 1] = 1;
                }
                else
                {
                    _col5[i - 1] = 2;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col6[i - 1] = 1;
                }
                else
                {
                    _col6[i - 1] = 2;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col7[i - 1] = 1;
                }
                else
                {
                    _col7[i - 1] = 2;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col8[i - 1] = 1;
                }
                else
                {
                    _col8[i - 1] = 2;
                }
            }

            switch (mnMode)
            {
                case 1:
                    for (int i = 1; i <= 8; i++)
                    {
                        nNumber = rnd1.Next(1, 10);
                        if (nNumber <= 5)
                        {
                            nType = rnd1.Next(1, 4);
                            switch (nType)
                            {
                                case 1:
                                    nType = 14;
                                    break;
                                case 2:
                                    nType = 16;
                                    break;
                                case 3:
                                    nType = 10;
                                    break;
                            }
                            switch (i)
                            {
                                case 1:
                                    _col1[0] = nType;
                                    break;
                                case 2:
                                    _col2[0] = nType;
                                    break;
                                case 3:
                                    _col3[0] = nType;
                                    break;
                                case 4:
                                    _col4[0] = nType;
                                    break;
                                case 5:
                                    _col5[0] = nType;
                                    break;
                                case 6:
                                    _col6[0] = nType;
                                    break;
                                case 7:
                                    _col7[0] = nType;
                                    break;
                                default:
                                    _col8[0] = nType;
                                    break;
                            }
                        }
                        nNumber = rnd1.Next(1, 10);
                        if (nNumber <= 5)
                        {
                            nType = rnd1.Next(1, 4);
                            switch (nType)
                            {
                                case 1:
                                    nType = 15;
                                    break;
                                case 2:
                                    nType = 17;
                                    break;
                                case 3:
                                    nType = 11;
                                    break;
                            }
                            switch (i)
                            {
                                case 1:
                                    _col1[1] = nType;
                                    break;
                                case 2:
                                    _col2[1] = nType;
                                    break;
                                case 3:
                                    _col3[1] = nType;
                                    break;
                                case 4:
                                    _col4[1] = nType;
                                    break;
                                case 5:
                                    _col5[1] = nType;
                                    break;
                                case 6:
                                    _col6[1] = nType;
                                    break;
                                case 7:
                                    _col7[1] = nType;
                                    break;
                                default:
                                    _col8[1] = nType;
                                    break;
                            }
                        }
                    }
                    break;
                case 2:
                    nNumber = rnd1.Next(4, 13);
                    for (int i = 1; i <= nNumber; i++)
                    {
                        nCol = rnd1.Next(1, 9);
                        nRow = rnd1.Next(1, 9);
                        switch (nCol)
                        {
                            case 1:
                                if (_col1[nRow - 1] <= 2)
                                {
                                    _col1[nRow - 1] = 12;
                                }
                                break;
                            case 2:
                                if (_col2[nRow - 1] <= 2)
                                {
                                    _col2[nRow - 1] = 12;
                                }
                                break;
                            case 3:
                                if (_col3[nRow - 1] <= 2)
                                {
                                    _col3[nRow - 1] = 12;
                                }
                                break;
                            case 4:
                                if (_col4[nRow - 1] <= 2)
                                {
                                    _col4[nRow - 1] = 12;
                                }
                                break;
                            case 5:
                                if (_col5[nRow - 1] <= 2)
                                {
                                    _col5[nRow - 1] = 12;
                                }
                                break;
                            case 6:
                                if (_col6[nRow - 1] <= 2)
                                {
                                    _col6[nRow - 1] = 12;
                                }
                                break;
                            case 7:
                                if (_col7[nRow - 1] <= 2)
                                {
                                    _col7[nRow - 1] = 12;
                                }
                                break;
                            default:
                                if (_col8[nRow - 1] <= 2)
                                {
                                    _col8[nRow - 1] = 12;
                                }
                                break;
                        }
                    }
                    break;
                default:
                    nNumber = rnd1.Next(2, 9);
                    for (int i = 1; i <= nNumber; i++)
                    {
                        nCol = rnd1.Next(1, 9);
                        nRow = rnd1.Next(1, 9);
                        switch (nCol)
                        {
                            case 1:
                                if (_col1[nRow - 1] <= 2)
                                {
                                    _col1[nRow - 1] = rnd1.Next(3, 9);
                                }
                                break;
                            case 2:
                                if (_col2[nRow - 1] <= 2)
                                {
                                    _col2[nRow - 1] = rnd1.Next(3, 9);
                                }
                                break;
                            case 3:
                                if (_col3[nRow - 1] <= 2)
                                {
                                    _col3[nRow - 1] = rnd1.Next(3, 9);
                                }
                                break;
                            case 4:
                                if (_col4[nRow - 1] <= 2)
                                {
                                    _col4[nRow - 1] = rnd1.Next(3, 9);
                                }
                                break;
                            case 5:
                                if (_col5[nRow - 1] <= 2)
                                {
                                    _col5[nRow - 1] = rnd1.Next(3, 9);
                                }
                                break;
                            case 6:
                                if (_col6[nRow - 1] <= 2)
                                {
                                    _col6[nRow - 1] = rnd1.Next(3, 9);
                                }
                                break;
                            case 7:
                                if (_col7[nRow - 1] <= 2)
                                {
                                    _col7[nRow - 1] = rnd1.Next(3, 9);
                                }
                                break;
                            default:
                                if (_col8[nRow - 1] <= 2)
                                {
                                    _col8[nRow - 1] = rnd1.Next(3, 9);
                                }
                                break;
                        }
                    }
                    break;
            }
            switch (_station1[0])
            {
                case 1:
                    _col1[_station1[1] - 1] = 13;
                    break;
                case 2:
                    _col2[_station1[1] - 1] = 13;
                    break;
                case 3:
                    _col3[_station1[1] - 1] = 13;
                    break;
                case 4:
                    _col4[_station1[1] - 1] = 13;
                    break;
                case 5:
                    _col5[_station1[1] - 1] = 13;
                    break;
                case 6:
                    _col6[_station1[1] - 1] = 13;
                    break;
                case 7:
                    _col7[_station1[1] - 1] = 13;
                    break;
                default:
                    _col8[_station1[1] - 1] = 13;
                    break;
            }
            switch (_station2[0])
            {
                case 1:
                    _col1[_station2[1] - 1] = 13;
                    break;
                case 2:
                    _col2[_station2[1] - 1] = 13;
                    break;
                case 3:
                    _col3[_station2[1] - 1] = 13;
                    break;
                case 4:
                    _col4[_station2[1] - 1] = 13;
                    break;
                case 5:
                    _col5[_station2[1] - 1] = 13;
                    break;
                case 6:
                    _col6[_station2[1] - 1] = 13;
                    break;
                case 7:
                    _col7[_station2[1] - 1] = 13;
                    break;
                default:
                    _col8[_station2[1] - 1] = 13;
                    break;
            }
        }
        public Form1()
        {
            InitializeComponent();
            nScore = 0;
            lblScore.Text = "Score = 0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
         
            mnCol = rnd1.Next(1, 9);
            mnRow = rnd1.Next(1, 9);
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

            fRedrawMode();
            fUpdateDisplay();
        }

        private void pic11_Click(object sender, EventArgs e)
        {
            mnCol = 1;
            mnRow = 1;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

            bool bValid = fValidSquare(mnCol, mnRow);
        }

        private void pic12_Click(object sender, EventArgs e)
        {
            mnCol = 1;
            mnRow = 2;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic13_Click(object sender, EventArgs e)
        {
            mnCol = 1;
            mnRow = 3;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic14_Click(object sender, EventArgs e)
        {
            mnCol = 1;
            mnRow = 4;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic15_Click(object sender, EventArgs e)
        {
            mnCol = 1;
            mnRow = 5;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic16_Click(object sender, EventArgs e)
        {
            mnCol = 1;
            mnRow = 6;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic17_Click(object sender, EventArgs e)
        {
            mnCol = 1;
            mnRow = 7;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic18_Click(object sender, EventArgs e)
        {
            mnCol = 1;
            mnRow = 8;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic21_Click(object sender, EventArgs e)
        {
            mnCol = 2;
            mnRow = 1;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic22_Click(object sender, EventArgs e)
        {
            mnCol = 2;
            mnRow = 2;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic23_Click(object sender, EventArgs e)
        {
            mnCol = 2;
            mnRow = 3;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic24_Click(object sender, EventArgs e)
        {
            mnCol = 2;
            mnRow = 4;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic25_Click(object sender, EventArgs e)
        {
            mnCol = 2;
            mnRow = 5;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic26_Click(object sender, EventArgs e)
        {
            mnCol = 2;
            mnRow = 6;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic27_Click(object sender, EventArgs e)
        {
            mnCol = 2;
            mnRow = 7;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic28_Click(object sender, EventArgs e)
        {
            mnCol = 2;
            mnRow = 8;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic31_Click(object sender, EventArgs e)
        {
            mnCol = 3;
            mnRow = 1;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic32_Click(object sender, EventArgs e)
        {
            mnCol = 3;
            mnRow = 2;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic33_Click(object sender, EventArgs e)
        {
            mnCol = 3;
            mnRow = 3;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic34_Click(object sender, EventArgs e)
        {
            mnCol = 3;
            mnRow = 4;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic35_Click(object sender, EventArgs e)
        {
            mnCol = 3;
            mnRow = 5;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic36_Click(object sender, EventArgs e)
        {
            mnCol = 3;
            mnRow = 6;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic37_Click(object sender, EventArgs e)
        {
            mnCol = 3;
            mnRow = 7;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic38_Click(object sender, EventArgs e)
        {
            mnCol = 3;
            mnRow = 8;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic41_Click(object sender, EventArgs e)
        {
            mnCol = 4;
            mnRow = 1;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic42_Click(object sender, EventArgs e)
        {
            mnCol = 4;
            mnRow = 2;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic43_Click(object sender, EventArgs e)
        {
            mnCol = 4;
            mnRow = 3;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic44_Click(object sender, EventArgs e)
        {
            mnCol = 4;
            mnRow = 4;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic45_Click(object sender, EventArgs e)
        {
            mnCol = 4;
            mnRow = 5;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic46_Click(object sender, EventArgs e)
        {
            mnCol = 4;
            mnRow = 6;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic47_Click(object sender, EventArgs e)
        {
            mnCol = 4;
            mnRow = 7;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic48_Click(object sender, EventArgs e)
        {
            mnCol = 4;
            mnRow = 8;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic51_Click(object sender, EventArgs e)
        {
            mnCol = 5;
            mnRow = 1;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic52_Click(object sender, EventArgs e)
        {
            mnCol = 5;
            mnRow = 2;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic53_Click(object sender, EventArgs e)
        {
            mnCol = 5;
            mnRow = 3;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic54_Click(object sender, EventArgs e)
        {
            mnCol = 5;
            mnRow = 4;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic55_Click(object sender, EventArgs e)
        {
            mnCol = 5;
            mnRow = 5;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic56_Click(object sender, EventArgs e)
        {
            mnCol = 5;
            mnRow = 6;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic57_Click(object sender, EventArgs e)
        {
            mnCol = 5;
            mnRow = 7;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic58_Click(object sender, EventArgs e)
        {
            mnCol = 5;
            mnRow = 8;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic61_Click(object sender, EventArgs e)
        {
            mnCol = 6;
            mnRow = 1;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic62_Click(object sender, EventArgs e)
        {
            mnCol = 6;
            mnRow = 2;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic63_Click(object sender, EventArgs e)
        {
            mnCol = 6;
            mnRow = 3;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic64_Click(object sender, EventArgs e)
        {
            mnCol = 6;
            mnRow = 4;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic65_Click(object sender, EventArgs e)
        {
            mnCol = 6;
            mnRow = 5;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic66_Click(object sender, EventArgs e)
        {
            mnCol = 6;
            mnRow = 6;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic67_Click(object sender, EventArgs e)
        {
            mnCol = 6;
            mnRow = 7;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic68_Click(object sender, EventArgs e)
        {
            mnCol = 6;
            mnRow = 8;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic71_Click(object sender, EventArgs e)
        {
            mnCol = 7;
            mnRow = 1;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic72_Click(object sender, EventArgs e)
        {
            mnCol = 7;
            mnRow = 2;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic73_Click(object sender, EventArgs e)
        {
            mnCol = 7;
            mnRow = 3;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic74_Click(object sender, EventArgs e)
        {
            mnCol = 7;
            mnRow = 4;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic75_Click(object sender, EventArgs e)
        {
            mnCol = 7;
            mnRow = 5;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic76_Click(object sender, EventArgs e)
        {
            mnCol = 7;
            mnRow = 6;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic77_Click(object sender, EventArgs e)
        {
            mnCol = 7;
            mnRow = 7;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic78_Click(object sender, EventArgs e)
        {
            mnCol = 7;
            mnRow = 8;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic81_Click(object sender, EventArgs e)
        {
            mnCol = 8;
            mnRow = 1;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic82_Click(object sender, EventArgs e)
        {
            mnCol = 8;
            mnRow = 2;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic83_Click(object sender, EventArgs e)
        {
            mnCol = 8;
            mnRow = 3;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic84_Click(object sender, EventArgs e)
        {
            mnCol = 8;
            mnRow = 4;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic85_Click(object sender, EventArgs e)
        {
            mnCol = 8;
            mnRow = 5;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void btnNav1_Click(object sender, EventArgs e)
        {
            bool bValid = fTransport(mnTransportCol, mnTransportRow);
            int nSavecol = mnTransportCol;
            int nSaverow = mnTransportRow;

            if (bValid == false)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                mnTransportRow -= 1;
                if (mnTransportRow == 0)
                {
                    MessageBox.Show("Error!");
                }
                if (fMeadow(mnTransportCol, mnTransportRow))
                {
                    fStick(nSavecol, nSaverow, 1);
                    fUpdateDisplay();
                    fDial();

                }
                else
                {
                    fStick(nSavecol, nSaverow, 1);
                    fStick(mnTransportCol, mnTransportRow, 18);
                    fUpdateDisplay();

                }
            }
        }

        private void btnNav2_Click(object sender, EventArgs e)
        {
            bool bValid = fTransport(mnTransportCol, mnTransportRow);
            int nSavecol = mnTransportCol;
            int nSaverow = mnTransportRow;

            if (bValid == false)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                mnTransportCol += 1;
                if (mnTransportCol == 9)
                {
                    MessageBox.Show("Error!");
                }
                if (fMeadow(mnTransportCol, mnTransportRow))
                {
                    fStick(nSavecol, nSaverow, 1);
                    fUpdateDisplay();
                    fDial();

                }
                else
                {
                    fStick(nSavecol, nSaverow, 1);
                    fStick(mnTransportCol, mnTransportRow, 18);
                    fUpdateDisplay();

                }
            }
        }

        private void btnNav3_Click(object sender, EventArgs e)
        {
            bool bValid = fTransport(mnTransportCol, mnTransportRow);
            int nSavecol = mnTransportCol;
            int nSaverow = mnTransportRow;

            if (bValid == false)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                mnTransportRow += 1;
                if (mnTransportRow == 9)
                {
                    MessageBox.Show("Error!");
                }
                if (fMeadow(mnTransportCol, mnTransportRow))
                {
                    fStick(nSavecol, nSaverow, 1);
                    fUpdateDisplay();
                    fDial();

                }
                else
                {
                    fStick(nSavecol, nSaverow, 1);
                    fStick(mnTransportCol, mnTransportRow, 18);
                    fUpdateDisplay();

                }
            }
        }

        private void btnNav4_Click(object sender, EventArgs e)
        {
            bool bValid = fTransport(mnTransportCol, mnTransportRow);
            int nSavecol = mnTransportCol;
            int nSaverow = mnTransportRow;

            if (bValid == false)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                mnTransportCol -= 1;
                if (mnTransportCol == 0)
                {
                    MessageBox.Show("Error!");
                }
                if (fMeadow(mnTransportCol, mnTransportRow))
                {
                    fStick(nSavecol, nSaverow, 1);
                    fUpdateDisplay();
                    fDial();

                }
                else
                {
                    fStick(nSavecol, nSaverow, 1);
                    fStick(mnTransportCol, mnTransportRow, 18);
                    fUpdateDisplay();

                }
            }
        }

        private void pic86_Click(object sender, EventArgs e)
        {
            mnCol = 8;
            mnRow = 6;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic87_Click(object sender, EventArgs e)
        {
            mnCol = 8;
            mnRow = 7;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void pic88_Click(object sender, EventArgs e)
        {
            mnCol = 8;
            mnRow = 8;
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);
            bool bValid = fValidSquare(mnCol, mnRow);

        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();

            mnCol = rnd1.Next(1, 9);
            mnRow = rnd1.Next(1, 9);
            lblWhat3.Text = "SELECTED = " + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow);

            fRedrawMode();
            fUpdateDisplay();
        }

    }
}

