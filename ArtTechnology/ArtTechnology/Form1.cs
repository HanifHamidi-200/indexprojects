using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtTechnology
{
    public partial class Form1 : Form
    {
        private static List<int> _col1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<bool> _empty1 = new List<bool> { false,false,false,false, false, false, false, false };
        private static List<bool> _empty2 = new List<bool> { false, false, false, false, false, false, false, false };
        private static List<bool> _empty3 = new List<bool> { false, false, false, false, false, false, false, false };
        private int mnTakemode, mnTake;

        private void fTake(int nCol,int nRow)
        {
            int nNeeded;
            int nType;

            switch (mnTakemode)
            {
                case 1:
                    switch (mnTake)
                    {
                        case 1:
                            nNeeded = 4;
                            break;
                        case 2:
                            nNeeded = 3;
                            break;
                        default:
                            nNeeded = 2;
                            break;
                    }
                    break;
                default:
                    switch (mnTake)
                    {
                        case 1:
                            nNeeded = 2;
                            break;
                        case 2:
                            nNeeded = 3;
                            break;
                        default:
                            nNeeded = 4;
                            break;
                    }
                    break;
            }

            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                default:
                    nType = _col3[nRow - 1];
                    break;
            }

            if (nType == nNeeded)
            {
                switch (nCol)
                {
                    case 1:
                        _col1[nRow - 1] = 1;
                        _empty1[nRow - 1] = true;
                        break;
                    case 2:
                        _col2[nRow - 1]=1;
                        _empty2[nRow - 1] = true;
                        break;
                    default:
                         _col3[nRow - 1]=1;
                        _empty3[nRow - 1] = true;
                        break;
                }
                mnTake += 1;
                if (mnTake == 4)
                {
                    mnTake = 1;
                }
                fShowDisplay();
            }
            else
            {
                MessageBox.Show("Wrong type");
            }
        }

        private void fShowDisplay()
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F empty.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F Doa.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F Generater.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F Wood.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
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
            }


        }

        private int fHeight(int nCol)
        {
            int nHeight = 8;

            switch (nCol)
            {
                case 1:
                    for (int i = 8; i >= 1; i--)
                    {
                        if (_empty1[i - 1] == true)
                        {
                            nHeight -= 1;
                        }
                    }
                    return nHeight;
                case 2:
                    for (int i = 8; i >= 1; i--)
                    {
                        if (_empty2[i - 1] == true)
                        {
                            nHeight -= 1;
                        }
                    }
                    return nHeight;
                default:
                    for (int i = 8; i >= 1; i--)
                    {
                        if (_empty3[i - 1] == true)
                        {
                            nHeight -= 1;
                        }
                    }
                    return nHeight;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            String sList = null;
            String sShuffle = null;
            String sLetter;
            int nLength, nPos;

            mnTakemode = 1;
            mnTake = 1;

            for (int i = 1; i <= 8; i++)
            {
                _empty1[i - 1] = false;
                _empty2[i - 1] = false;
                _empty3[i - 1] = false;
            }
            for (int i = 1; i <= 8; i++)
            {
                sList = sList + "2";
                sList = sList + "3";
                sList = sList + "4";
            }

            do
            {
                nLength = sList.Length;
                nPos = rnd1.Next(1, nLength + 1);
                sLetter = sList.Substring(nPos - 1, 1);
                sShuffle = sShuffle + sLetter;
                sList = sList.Substring(0, nPos - 1) + sList.Substring(nPos, nLength - nPos);
            } while (sList.Length > 0);

            for (int i = 1; i <= 8; i++)
            {
                if (_empty1[i - 1] == false)
                {
                    sLetter = sShuffle.Substring(0, 1);
                    sShuffle = sShuffle.Substring(1, sShuffle.Length - 1);
                    _col1[i - 1] = Convert.ToInt32(sLetter);
                }
                else
                {
                    _col1[i - 1] = 1;
                }
            }
            for (int i = 1; i <= 8; i++)
            {
                if (_empty2[i - 1] == false)
                {
                    sLetter = sShuffle.Substring(0, 1);
                    sShuffle = sShuffle.Substring(1, sShuffle.Length - 1);
                    _col2[i - 1] = Convert.ToInt32(sLetter);
                }
                else
                {
                    _col2[i - 1] = 1;
                }
            }
            for (int i = 1; i <= 8; i++)
            {
                if (_empty3[i - 1] == false)
                {
                    sLetter = sShuffle.Substring(0, 1);
                    sShuffle = sShuffle.Substring(1, sShuffle.Length - 1);
                    _col3[i - 1] = Convert.ToInt32(sLetter);
                }
                else
                {
                    _col3[i - 1] = 1;
                }
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F empty.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F Doa.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F Generater.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F Wood.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
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
            }


        }

        private void btnTake1_Click(object sender, EventArgs e)
        {
            if (mnTake == 1)
            {
                mnTakemode = 1;
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void btnTake2_Click(object sender, EventArgs e)
        {
            if (mnTake == 1)
            {
                mnTakemode = 2;
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void pic11_Click(object sender, EventArgs e)
        {
            if (fHeight(1) == 1)
            {
                fTake(1, 1);
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void pic12_Click(object sender, EventArgs e)
        {
            if (fHeight(1) == 2)
            {
                fTake(1, 2);
            }
            else
            {
                MessageBox.Show("Error!");
            }

        }

        private void pic13_Click(object sender, EventArgs e)
        {
            if (fHeight(1) == 3)
            {
                fTake(1, 3);
            }
            else
            {
                MessageBox.Show("Error!");
            }

        }

        private void pic14_Click(object sender, EventArgs e)
        {
            if (fHeight(1) == 4)
            {
                fTake(1, 4);
            }
            else
            {
                MessageBox.Show("Error!");
            }

        }

        private void pic15_Click(object sender, EventArgs e)
        {
            if (fHeight(1) == 5)
            {
                fTake(1, 5);
            }
            else
            {
                MessageBox.Show("Error!");
            }

        }

        private void pic16_Click(object sender, EventArgs e)
        {
            if (fHeight(1) == 6)
            {
                fTake(1, 6);
            }
            else
            {
                MessageBox.Show("Error!");
            }

        }

        private void pic17_Click(object sender, EventArgs e)
        {
            if (fHeight(1) == 7)
            {
                fTake(1, 7);
            }
            else
            {
                MessageBox.Show("Error!");
            }

        }

        private void pic18_Click(object sender, EventArgs e)
        {
            if (fHeight(1) == 8)
            {
                fTake(1, 8);
            }
            else
            {
                MessageBox.Show("Error!");
            }

        }

        private void pic21_Click(object sender, EventArgs e)
        {
            if (fHeight(2) == 1)
            {
                fTake(2, 1);
            }
            else
            {
                MessageBox.Show("Error!");
            }

        }

        private void pic22_Click(object sender, EventArgs e)
        {
            if (fHeight(2) == 2)
            {
                fTake(2, 2);
            }
            else
            {
                MessageBox.Show("Error!");
            }


        }

        private void pic23_Click(object sender, EventArgs e)
        {
            if (fHeight(2) == 3)
            {
                fTake(2, 3);
            }
            else
            {
                MessageBox.Show("Error!");
            }


        }

        private void pic24_Click(object sender, EventArgs e)
        {
            if (fHeight(2) == 4)
            {
                fTake(2, 4);
            }
            else
            {
                MessageBox.Show("Error!");
            }


        }

        private void pic25_Click(object sender, EventArgs e)
        {
            if (fHeight(2) == 5)
            {
                fTake(2, 5);
            }
            else
            {
                MessageBox.Show("Error!");
            }


        }

        private void pic26_Click(object sender, EventArgs e)
        {
            if (fHeight(2) == 6)
            {
                fTake(2, 6);
            }
            else
            {
                MessageBox.Show("Error!");
            }


        }

        private void pic27_Click(object sender, EventArgs e)
        {
            if (fHeight(2) == 7)
            {
                fTake(2, 7);
            }
            else
            {
                MessageBox.Show("Error!");
            }


        }

        private void pic28_Click(object sender, EventArgs e)
        {
            if (fHeight(2) == 8)
            {
                fTake(2, 8);
            }
            else
            {
                MessageBox.Show("Error!");
            }


        }

        private void pic31_Click(object sender, EventArgs e)
        {
            if (fHeight(3) == 1)
            {
                fTake(3, 1);
            }
            else
            {
                MessageBox.Show("Error!");
            }


        }

        private void pic32_Click(object sender, EventArgs e)
        {
            if (fHeight(3) == 2)
            {
                fTake(3, 2);
            }
            else
            {
                MessageBox.Show("Error!");
            }


        }

        private void pic33_Click(object sender, EventArgs e)
        {
            if (fHeight(3) == 3)
            {
                fTake(3, 3);
            }
            else
            {
                MessageBox.Show("Error!");
            }


        }

        private void pic34_Click(object sender, EventArgs e)
        {
            if (fHeight(3) == 4)
            {
                fTake(3, 4);
            }
            else
            {
                MessageBox.Show("Error!");
            }


        }

        private void pic35_Click(object sender, EventArgs e)
        {
            if (fHeight(3) == 5)
            {
                fTake(3, 5);
            }
            else
            {
                MessageBox.Show("Error!");
            }


        }

        private void pic36_Click(object sender, EventArgs e)
        {
            if (fHeight(3) == 6)
            {
                fTake(3, 6);
            }
            else
            {
                MessageBox.Show("Error!");
            }


        }

        private void pic37_Click(object sender, EventArgs e)
        {
            if (fHeight(3) == 7)
            {
                fTake(3, 7);
            }
            else
            {
                MessageBox.Show("Error!");
            }


        }

        private void pic38_Click(object sender, EventArgs e)
        {
            if (fHeight(3) == 8)
            {
                fTake(3, 8);
            }
            else
            {
                MessageBox.Show("Error!");
            }


        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            String sList = null;
            String sLetter;
            String sShuffle;
            int nLength, nPos;

            for (int i = 1; i <= 8; i++)
            {
                sLetter =Convert.ToString( _col1[i - 1]);
                if (sLetter != "1")
                {
                    sList = sList + sLetter;
                }
                else
                {
                    i=10;
                }
             }
            for (int i = 1; i <= 8; i++)
            {
                sLetter = Convert.ToString(_col2[i - 1]);
                if (sLetter != "1")
                {
                    sList = sList + sLetter;
                }
                else
                {
                    i = 10;
                }
            }
            for (int i = 1; i <= 8; i++)
            {
                sLetter = Convert.ToString(_col3[i - 1]);
                if (sLetter != "1")
                {
                    sList = sList + sLetter;
                }
                else
                {
                    i = 10;
                }
            }

            sShuffle = null;
            do
            {
                nLength = sList.Length;
                nPos = rnd1.Next(1, nLength + 1);
                sLetter = sList.Substring(nPos - 1, 1);
                sShuffle = sShuffle + sLetter;
                sList = sList.Substring(0, nPos - 1) + sList.Substring(nPos, nLength - nPos);
            } while (sList.Length > 0);

            for (int i = 1; i <= 8; i++)
            {
                if (_empty1[i - 1] == false)
                {
                    sLetter = sShuffle.Substring(0, 1);
                    sShuffle = sShuffle.Substring(1, sShuffle.Length - 1);
                    _col1[i - 1] = Convert.ToInt32(sLetter);
                }
                else
                {
                    _col1[i - 1] = 1;
                }
            }
            for (int i = 1; i <= 8; i++)
            {
                if (_empty2[i - 1] == false)
                {
                    sLetter = sShuffle.Substring(0, 1);
                    sShuffle = sShuffle.Substring(1, sShuffle.Length - 1);
                    _col2[i - 1] = Convert.ToInt32(sLetter);
                }
                else
                {
                    _col2[i - 1] = 1;
                }
            }
            for (int i = 1; i <= 8; i++)
            {
                if (_empty3[i - 1] == false)
                {
                    sLetter = sShuffle.Substring(0, 1);
                    sShuffle = sShuffle.Substring(1, sShuffle.Length - 1);
                    _col3[i - 1] = Convert.ToInt32(sLetter);
                }
                else
                {
                    _col3[i - 1] = 1;
                }
            }

            fShowDisplay();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            String sList = null;
            String sShuffle = null;
            String sLetter;
            int nLength, nPos;

            mnTakemode = 1;
            mnTake = 1;

            for (int i = 1; i <= 8; i++)
            {
                _empty1[i - 1] = false;
                _empty2[i - 1] = false;
                _empty3[i - 1] = false;
            }
            for (int i = 1; i <= 8; i++)
            {
                sList = sList + "2";
                sList = sList + "3";
                sList = sList + "4";
            }

            do
            {
                nLength = sList.Length;
                nPos = rnd1.Next(1, nLength + 1);
                sLetter = sList.Substring(nPos - 1, 1);
                sShuffle = sShuffle + sLetter;
                sList = sList.Substring(0, nPos - 1) + sList.Substring(nPos, nLength - nPos);
            } while (sList.Length > 0);

            for (int i = 1; i <= 8; i++)
            {
                if (_empty1[i - 1]==false)
                {
                    sLetter = sShuffle.Substring(0, 1);
                    sShuffle = sShuffle.Substring(1, sShuffle.Length - 1);
                    _col1[i - 1] = Convert.ToInt32(sLetter);
                }
                else
                {
                    _col1[i - 1] = 1;
                }
            }
            for (int i = 1; i <= 8; i++)
            {
                if (_empty2[i - 1] == false)
                {
                    sLetter = sShuffle.Substring(0, 1);
                    sShuffle = sShuffle.Substring(1, sShuffle.Length - 1);
                    _col2[i - 1] = Convert.ToInt32(sLetter);
                }
                else
                {
                    _col2[i - 1] = 1;
                }
            }
            for (int i = 1; i <= 8; i++)
            {
                if (_empty3[i - 1] == false)
                {
                    sLetter = sShuffle.Substring(0, 1);
                    sShuffle = sShuffle.Substring(1, sShuffle.Length - 1);
                    _col3[i - 1] = Convert.ToInt32(sLetter);
                }
                else
                {
                    _col3[i - 1] = 1;
                }
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F empty.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F Doa.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F Generater.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F Wood.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
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
            }

        }
    }
}
