using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoinDots
{
    public partial class Form1 : Form
    {
        private static List<int> _col1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col9 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _cola = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _type1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _type2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _type3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _type4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _type5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _type6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _type7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _type8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _type9 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _typea = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _HolderACol = new List<int> { 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _HolderARow = new List<int> { 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _HolderFCol = new List<int> { 0, 0, 0 };
        private static List<int> _HolderFRow = new List<int> { 0, 0, 0 };
        private int CounterCol, CounterRow, CounterDirection;
        private int nScore = 0;
        private int mnOil, mnDam, mnFactory;

        private void btnForward_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nCol, nRow, nType;

            switch (CounterDirection)
            {
                case 1:
                    CounterRow -= 1;
                    if (CounterRow == 0)
                    {
                        CounterRow = 10;
                    }
                    break;
                case 2:
                    CounterCol += 1;
                    if (CounterCol == 11)
                    {
                        CounterCol = 1;
                    }
                    break;
                case 3:
                    CounterRow += 1;
                    if (CounterRow == 11)
                    {
                        CounterRow = 1;
                        CounterRow = 1;
                    }
                    break;
                default:
                    CounterCol -= 1;
                    if (CounterCol == 0)
                    {
                        CounterCol = 10;
                    }
                    break;
            }
            switch (CounterDirection)
            {
                case 1:
                    _HolderACol[0] = CounterCol - 3;
                    if (_HolderACol[0] < 1)
                    {
                        _HolderACol[0] = _HolderACol[0] + 10;
                    }
                    _HolderARow[0] = CounterRow;
                    _HolderACol[1] = CounterCol - 2;
                    if (_HolderACol[1] < 1)
                    {
                        _HolderACol[1] = _HolderACol[1] + 10;
                    }
                    _HolderARow[1] = CounterRow;
                    _HolderACol[2] = CounterCol - 1;
                    if (_HolderACol[2] < 1)
                    {
                        _HolderACol[2] = _HolderACol[2] + 10;
                    }
                    _HolderARow[2] = CounterRow;
                    _HolderACol[3] = CounterCol;
                    _HolderARow[3] = CounterRow;
                    _HolderACol[4] = CounterCol + 1;
                    if (_HolderACol[4] > 10)
                    {
                        _HolderACol[4] = _HolderACol[4] - 10;
                    }
                    _HolderARow[4] = CounterRow;
                    _HolderACol[5] = CounterCol + 2;
                    if (_HolderACol[5] > 10)
                    {
                        _HolderACol[5] = _HolderACol[5] - 10;
                    }
                    _HolderARow[5] = CounterRow;
                    _HolderACol[6] = CounterCol + 3;
                    if (_HolderACol[6] > 10)
                    {
                        _HolderACol[6] = _HolderACol[6] - 10;
                    }
                    _HolderARow[6] = CounterRow;
                    _HolderFCol[0] = CounterCol;
                    _HolderFRow[0] = CounterRow - 3;
                    if (_HolderFRow[0] < 1)
                    {
                        _HolderFRow[0] = _HolderFRow[0] + 10;
                    }
                    _HolderFCol[1] = CounterCol;
                    _HolderFRow[1] = CounterRow - 2;
                    if (_HolderFRow[1] < 1)
                    {
                        _HolderFRow[1] = _HolderFRow[1] + 10;
                    }
                    _HolderFCol[2] = CounterCol;
                    _HolderFRow[2] = CounterRow - 1;
                    if (_HolderFRow[2] < 1)
                    {
                        _HolderFRow[2] = _HolderFRow[2] + 10;
                    }

                    break;
                case 2:
                    _HolderACol[0] = CounterCol;
                    _HolderARow[0] = CounterRow - 3;
                    if (_HolderARow[0] < 1)
                    {
                        _HolderARow[0] = _HolderARow[0] + 10;
                    }
                    _HolderACol[1] = CounterCol;
                    _HolderARow[1] = CounterRow - 2;
                    if (_HolderARow[1] < 1)
                    {
                        _HolderARow[1] = _HolderARow[1] + 10;
                    }
                    _HolderACol[2] = CounterCol;
                    _HolderARow[2] = CounterRow - 1;
                    if (_HolderARow[2] < 1)
                    {
                        _HolderARow[2] = _HolderARow[2] + 10;
                    }
                    _HolderACol[3] = CounterCol;
                    _HolderARow[3] = CounterRow;
                    _HolderACol[4] = CounterCol;
                    _HolderARow[4] = CounterRow + 1;
                    if (_HolderARow[4] > 10)
                    {
                        _HolderARow[4] = _HolderARow[4] - 10;
                    }
                    _HolderACol[5] = CounterCol;
                    _HolderARow[5] = CounterRow + 2;
                    if (_HolderARow[5] > 10)
                    {
                        _HolderARow[5] = _HolderARow[5] - 10;
                    }
                    _HolderACol[6] = CounterCol;
                    _HolderARow[6] = CounterRow + 3;
                    if (_HolderARow[6] > 10)
                    {
                        _HolderARow[6] = _HolderARow[6] - 10;
                    }
                    _HolderFCol[0] = CounterCol + 3;
                    if (_HolderFCol[0] > 10)
                    {
                        _HolderFCol[0] = _HolderFCol[0] - 10;
                    }
                    _HolderFRow[0] = CounterRow;
                    _HolderFCol[1] = CounterCol + 2;
                    if (_HolderFCol[1] > 10)
                    {
                        _HolderFCol[1] = _HolderFCol[1] - 10;
                    }
                    _HolderFRow[1] = CounterRow;
                    _HolderFCol[2] = CounterCol + 1;
                    if (_HolderFCol[2] > 10)
                    {
                        _HolderFCol[2] = _HolderFCol[2] - 10;
                    }
                    _HolderFRow[2] = CounterRow;

                    break;
                case 3:
                    _HolderACol[0] = CounterCol + 3;
                    if (_HolderACol[0] > 10)
                    {
                        _HolderACol[0] = _HolderACol[0] - 10;
                    }
                    _HolderARow[0] = CounterRow;
                    _HolderACol[1] = CounterCol + 2;
                    if (_HolderACol[1] > 10)
                    {
                        _HolderACol[1] = _HolderACol[1] - 10;
                    }
                    _HolderARow[1] = CounterRow;
                    _HolderACol[2] = CounterCol + 1;
                    if (_HolderACol[2] > 10)
                    {
                        _HolderACol[2] = _HolderACol[2] - 10;
                    }
                    _HolderARow[2] = CounterRow;
                    _HolderACol[3] = CounterCol;
                    _HolderARow[3] = CounterRow;
                    _HolderACol[4] = CounterCol - 1;
                    if (_HolderACol[4] < 1)
                    {
                        _HolderACol[4] = _HolderACol[4] + 10;
                    }
                    _HolderARow[4] = CounterRow;
                    _HolderACol[5] = CounterCol - 2;
                    if (_HolderACol[5] < 2)
                    {
                        _HolderACol[5] = _HolderACol[5] + 10;
                    }
                    _HolderARow[5] = CounterRow;
                    _HolderACol[6] = CounterCol - 3;
                    if (_HolderACol[6] < 3)
                    {
                        _HolderACol[6] = _HolderACol[6] + 10;
                    }
                    _HolderARow[6] = CounterRow;
                    _HolderFCol[0] = CounterCol;
                    _HolderFRow[0] = CounterRow + 3;
                    if (_HolderFRow[0] > 10)
                    {
                        _HolderFRow[0] = _HolderFRow[0] - 10;
                    }
                    _HolderFCol[1] = CounterCol;
                    _HolderFRow[1] = CounterRow + 2;
                    if (_HolderFRow[1] > 10)
                    {
                        _HolderFRow[1] = _HolderFRow[1] - 10;
                    }
                    _HolderFCol[2] = CounterCol;
                    _HolderFRow[2] = CounterRow + 1;
                    if (_HolderFRow[2] > 10)
                    {
                        _HolderFRow[2] = _HolderFRow[2] - 10;
                    }

                    break;
                default:
                    _HolderACol[0] = CounterCol;
                    _HolderARow[0] = CounterRow + 3;
                    if (_HolderARow[0] > 10)
                    {
                        _HolderARow[0] = _HolderARow[0] - 10;
                    }
                    _HolderACol[1] = CounterCol;
                    _HolderARow[1] = CounterRow + 2;
                    if (_HolderARow[1] > 10)
                    {
                        _HolderARow[1] = _HolderARow[1] - 10;
                    }
                    _HolderACol[2] = CounterCol;
                    _HolderARow[2] = CounterRow + 1;
                    if (_HolderARow[2] > 10)
                    {
                        _HolderARow[2] = _HolderARow[2] - 10;
                    }
                    _HolderACol[3] = CounterCol;
                    _HolderARow[3] = CounterRow;
                    _HolderACol[4] = CounterCol;
                    _HolderARow[4] = CounterRow - 1;
                    if (_HolderARow[4] < 1)
                    {
                        _HolderARow[4] = _HolderARow[4] + 10;
                    }
                    _HolderACol[5] = CounterCol;
                    _HolderARow[5] = CounterRow - 2;
                    if (_HolderARow[5] < 1)
                    {
                        _HolderARow[5] = _HolderARow[5] + 10;
                    }
                    _HolderACol[6] = CounterCol;
                    _HolderARow[6] = CounterRow - 3;
                    if (_HolderARow[6] < 1)
                    {
                        _HolderARow[6] = _HolderARow[6] + 10;
                    }
                    _HolderFCol[0] = CounterCol - 3;
                    if (_HolderFCol[0] < 1)
                    {
                        _HolderFCol[0] = _HolderFCol[0] + 10;
                    }
                    _HolderFRow[0] = CounterRow;
                    _HolderFCol[1] = CounterCol - 2;
                    if (_HolderFCol[1] < 1)
                    {
                        _HolderFCol[1] = _HolderFCol[1] + 10;
                    }
                    _HolderFRow[1] = CounterRow;
                    _HolderFCol[2] = CounterCol - 1;
                    if (_HolderFCol[2] < 1)
                    {
                        _HolderFCol[2] = _HolderFCol[2] + 10;
                    }
                    _HolderFRow[2] = CounterRow;

                    break;
            }
            lblLocation.Text = "Location = (" + Convert.ToString(CounterCol) + "," + Convert.ToString(CounterRow) + ")";
            switch (CounterDirection)
            {
                case 1:
                    lblDirection.Text = "Direction = (N)";
                    break;
                case 2:
                    lblDirection.Text = "Direction = (E)";
                    break;
                case 3:
                    lblDirection.Text = "Direction = (S)";
                    break;
                default:
                    lblDirection.Text = "Direction = (W)";
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F blank.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F Exit.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F found1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F found2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F found3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F type11.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F type12.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F type13.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F type14.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F type21.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F type22.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F type23.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"F type24.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"F type25.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"F type26.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"F type31.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
                Image = Image.FromFile(@"F type32.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture18 = new PictureBox
            {
                Name = "pictureBox18",
                Image = Image.FromFile(@"F type33.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture19 = new PictureBox
            {
                Name = "pictureBox19",
                Image = Image.FromFile(@"F type34.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture20 = new PictureBox
            {
                Name = "pictureBox20",
                Image = Image.FromFile(@"F Nullgate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nCol = _HolderACol[0];
            nRow = _HolderARow[0];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picAcross1.Image = picture1.Image;
                    break;
                case 2:
                    picAcross1.Image = picture2.Image;
                    break;
                case 3:
                    picAcross1.Image = picture3.Image;
                    break;
                case 4:
                    picAcross1.Image = picture4.Image;
                    break;
                case 5:
                    picAcross1.Image = picture5.Image;
                    break;
                case 6:
                    picAcross1.Image = picture6.Image;
                    break;
                case 7:
                    picAcross1.Image = picture7.Image;
                    break;
                case 8:
                    picAcross1.Image = picture8.Image;
                    break;
                case 9:
                    picAcross1.Image = picture9.Image;
                    break;
                case 10:
                    picAcross1.Image = picture10.Image;
                    break;
                case 11:
                    picAcross1.Image = picture11.Image;
                    break;
                case 12:
                    picAcross1.Image = picture12.Image;
                    break;
                case 13:
                    picAcross1.Image = picture13.Image;
                    break;
                case 14:
                    picAcross1.Image = picture14.Image;
                    break;
                case 15:
                    picAcross1.Image = picture15.Image;
                    break;
                case 16:
                    picAcross1.Image = picture16.Image;
                    break;
                case 17:
                    picAcross1.Image = picture17.Image;
                    break;
                case 18:
                    picAcross1.Image = picture18.Image;
                    break;
                case 19:
                    picAcross1.Image = picture19.Image;
                    break;
                default:
                    picAcross1.Image = picture20.Image;
                    break;
            }
            nCol = _HolderACol[1];
            nRow = _HolderARow[1];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picAcross2.Image = picture1.Image;
                    break;
                case 2:
                    picAcross2.Image = picture2.Image;
                    break;
                case 3:
                    picAcross2.Image = picture3.Image;
                    break;
                case 4:
                    picAcross2.Image = picture4.Image;
                    break;
                case 5:
                    picAcross2.Image = picture5.Image;
                    break;
                case 6:
                    picAcross2.Image = picture6.Image;
                    break;
                case 7:
                    picAcross2.Image = picture7.Image;
                    break;
                case 8:
                    picAcross2.Image = picture8.Image;
                    break;
                case 9:
                    picAcross2.Image = picture9.Image;
                    break;
                case 10:
                    picAcross2.Image = picture10.Image;
                    break;
                case 11:
                    picAcross2.Image = picture11.Image;
                    break;
                case 12:
                    picAcross2.Image = picture12.Image;
                    break;
                case 13:
                    picAcross2.Image = picture13.Image;
                    break;
                case 14:
                    picAcross2.Image = picture14.Image;
                    break;
                case 15:
                    picAcross2.Image = picture15.Image;
                    break;
                case 16:
                    picAcross2.Image = picture16.Image;
                    break;
                case 17:
                    picAcross2.Image = picture17.Image;
                    break;
                case 18:
                    picAcross2.Image = picture18.Image;
                    break;
                case 19:
                    picAcross2.Image = picture19.Image;
                    break;
                default:
                    picAcross2.Image = picture20.Image;
                    break;
            }
            nCol = _HolderACol[2];
            nRow = _HolderARow[2];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picAcross3.Image = picture1.Image;
                    break;
                case 2:
                    picAcross3.Image = picture2.Image;
                    break;
                case 3:
                    picAcross3.Image = picture3.Image;
                    break;
                case 4:
                    picAcross3.Image = picture4.Image;
                    break;
                case 5:
                    picAcross3.Image = picture5.Image;
                    break;
                case 6:
                    picAcross3.Image = picture6.Image;
                    break;
                case 7:
                    picAcross3.Image = picture7.Image;
                    break;
                case 8:
                    picAcross3.Image = picture8.Image;
                    break;
                case 9:
                    picAcross3.Image = picture9.Image;
                    break;
                case 10:
                    picAcross3.Image = picture10.Image;
                    break;
                case 11:
                    picAcross3.Image = picture11.Image;
                    break;
                case 12:
                    picAcross3.Image = picture12.Image;
                    break;
                case 13:
                    picAcross3.Image = picture13.Image;
                    break;
                case 14:
                    picAcross3.Image = picture14.Image;
                    break;
                case 15:
                    picAcross3.Image = picture15.Image;
                    break;
                case 16:
                    picAcross3.Image = picture16.Image;
                    break;
                case 17:
                    picAcross3.Image = picture17.Image;
                    break;
                case 18:
                    picAcross3.Image = picture18.Image;
                    break;
                case 19:
                    picAcross3.Image = picture19.Image;
                    break;
                default:
                    picAcross3.Image = picture20.Image;
                    break;
            }
            nCol = _HolderACol[3];
            nRow = _HolderARow[3];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picAcross4.Image = picture1.Image;
                    break;
                case 2:
                    picAcross4.Image = picture2.Image;
                    break;
                case 3:
                    picAcross4.Image = picture3.Image;
                    break;
                case 4:
                    picAcross4.Image = picture4.Image;
                    break;
                case 5:
                    picAcross4.Image = picture5.Image;
                    break;
                case 6:
                    picAcross4.Image = picture6.Image;
                    break;
                case 7:
                    picAcross4.Image = picture7.Image;
                    break;
                case 8:
                    picAcross4.Image = picture8.Image;
                    break;
                case 9:
                    picAcross4.Image = picture9.Image;
                    break;
                case 10:
                    picAcross4.Image = picture10.Image;
                    break;
                case 11:
                    picAcross4.Image = picture11.Image;
                    break;
                case 12:
                    picAcross4.Image = picture12.Image;
                    break;
                case 13:
                    picAcross4.Image = picture13.Image;
                    break;
                case 14:
                    picAcross4.Image = picture14.Image;
                    break;
                case 15:
                    picAcross4.Image = picture15.Image;
                    break;
                case 16:
                    picAcross4.Image = picture16.Image;
                    break;
                case 17:
                    picAcross4.Image = picture17.Image;
                    break;
                case 18:
                    picAcross4.Image = picture18.Image;
                    break;
                case 19:
                    picAcross4.Image = picture19.Image;
                    break;
                default:
                    picAcross4.Image = picture20.Image;
                    break;
            }
            nCol = _HolderACol[4];
            nRow = _HolderARow[4];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picAcross5.Image = picture1.Image;
                    break;
                case 2:
                    picAcross5.Image = picture2.Image;
                    break;
                case 3:
                    picAcross5.Image = picture3.Image;
                    break;
                case 4:
                    picAcross5.Image = picture4.Image;
                    break;
                case 5:
                    picAcross5.Image = picture5.Image;
                    break;
                case 6:
                    picAcross5.Image = picture6.Image;
                    break;
                case 7:
                    picAcross5.Image = picture7.Image;
                    break;
                case 8:
                    picAcross5.Image = picture8.Image;
                    break;
                case 9:
                    picAcross5.Image = picture9.Image;
                    break;
                case 10:
                    picAcross5.Image = picture10.Image;
                    break;
                case 11:
                    picAcross5.Image = picture11.Image;
                    break;
                case 12:
                    picAcross5.Image = picture12.Image;
                    break;
                case 13:
                    picAcross5.Image = picture13.Image;
                    break;
                case 14:
                    picAcross5.Image = picture14.Image;
                    break;
                case 15:
                    picAcross5.Image = picture15.Image;
                    break;
                case 16:
                    picAcross5.Image = picture16.Image;
                    break;
                case 17:
                    picAcross5.Image = picture17.Image;
                    break;
                case 18:
                    picAcross5.Image = picture18.Image;
                    break;
                case 19:
                    picAcross5.Image = picture19.Image;
                    break;
                default:
                    picAcross5.Image = picture20.Image;
                    break;
            }
            nCol = _HolderACol[5];
            nRow = _HolderARow[5];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picAcross6.Image = picture1.Image;
                    break;
                case 2:
                    picAcross6.Image = picture2.Image;
                    break;
                case 3:
                    picAcross6.Image = picture3.Image;
                    break;
                case 4:
                    picAcross6.Image = picture4.Image;
                    break;
                case 5:
                    picAcross6.Image = picture5.Image;
                    break;
                case 6:
                    picAcross6.Image = picture6.Image;
                    break;
                case 7:
                    picAcross6.Image = picture7.Image;
                    break;
                case 8:
                    picAcross6.Image = picture8.Image;
                    break;
                case 9:
                    picAcross6.Image = picture9.Image;
                    break;
                case 10:
                    picAcross6.Image = picture10.Image;
                    break;
                case 11:
                    picAcross6.Image = picture11.Image;
                    break;
                case 12:
                    picAcross6.Image = picture12.Image;
                    break;
                case 13:
                    picAcross6.Image = picture13.Image;
                    break;
                case 14:
                    picAcross6.Image = picture14.Image;
                    break;
                case 15:
                    picAcross6.Image = picture15.Image;
                    break;
                case 16:
                    picAcross6.Image = picture16.Image;
                    break;
                case 17:
                    picAcross6.Image = picture17.Image;
                    break;
                case 18:
                    picAcross6.Image = picture18.Image;
                    break;
                case 19:
                    picAcross6.Image = picture19.Image;
                    break;
                default:
                    picAcross6.Image = picture20.Image;
                    break;
            }
            nCol = _HolderACol[6];
            nRow = _HolderARow[6];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picAcross7.Image = picture1.Image;
                    break;
                case 2:
                    picAcross7.Image = picture2.Image;
                    break;
                case 3:
                    picAcross7.Image = picture3.Image;
                    break;
                case 4:
                    picAcross7.Image = picture4.Image;
                    break;
                case 5:
                    picAcross7.Image = picture5.Image;
                    break;
                case 6:
                    picAcross7.Image = picture6.Image;
                    break;
                case 7:
                    picAcross7.Image = picture7.Image;
                    break;
                case 8:
                    picAcross7.Image = picture8.Image;
                    break;
                case 9:
                    picAcross7.Image = picture9.Image;
                    break;
                case 10:
                    picAcross7.Image = picture10.Image;
                    break;
                case 11:
                    picAcross7.Image = picture11.Image;
                    break;
                case 12:
                    picAcross7.Image = picture12.Image;
                    break;
                case 13:
                    picAcross7.Image = picture13.Image;
                    break;
                case 14:
                    picAcross7.Image = picture14.Image;
                    break;
                case 15:
                    picAcross7.Image = picture15.Image;
                    break;
                case 16:
                    picAcross7.Image = picture16.Image;
                    break;
                case 17:
                    picAcross7.Image = picture17.Image;
                    break;
                case 18:
                    picAcross7.Image = picture18.Image;
                    break;
                case 19:
                    picAcross7.Image = picture19.Image;
                    break;
                default:
                    picAcross7.Image = picture20.Image;
                    break;
            }

            nCol = _HolderFCol[0];
            nRow = _HolderFRow[0];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picForward1.Image = picture1.Image;
                    break;
                case 2:
                    picForward1.Image = picture2.Image;
                    break;
                case 3:
                    picForward1.Image = picture3.Image;
                    break;
                case 4:
                    picForward1.Image = picture4.Image;
                    break;
                case 5:
                    picForward1.Image = picture5.Image;
                    break;
                case 6:
                    picForward1.Image = picture6.Image;
                    break;
                case 7:
                    picForward1.Image = picture7.Image;
                    break;
                case 8:
                    picForward1.Image = picture8.Image;
                    break;
                case 9:
                    picForward1.Image = picture9.Image;
                    break;
                case 10:
                    picForward1.Image = picture10.Image;
                    break;
                case 11:
                    picForward1.Image = picture11.Image;
                    break;
                case 12:
                    picForward1.Image = picture12.Image;
                    break;
                case 13:
                    picForward1.Image = picture13.Image;
                    break;
                case 14:
                    picForward1.Image = picture14.Image;
                    break;
                case 15:
                    picForward1.Image = picture15.Image;
                    break;
                case 16:
                    picForward1.Image = picture16.Image;
                    break;
                case 17:
                    picForward1.Image = picture17.Image;
                    break;
                case 18:
                    picForward1.Image = picture18.Image;
                    break;
                case 19:
                    picForward1.Image = picture19.Image;
                    break;
                default:
                    picForward1.Image = picture20.Image;
                    break;
            }
            nCol = _HolderFCol[1];
            nRow = _HolderFRow[1];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picForward2.Image = picture1.Image;
                    break;
                case 2:
                    picForward2.Image = picture2.Image;
                    break;
                case 3:
                    picForward2.Image = picture3.Image;
                    break;
                case 4:
                    picForward2.Image = picture4.Image;
                    break;
                case 5:
                    picForward2.Image = picture5.Image;
                    break;
                case 6:
                    picForward2.Image = picture6.Image;
                    break;
                case 7:
                    picForward2.Image = picture7.Image;
                    break;
                case 8:
                    picForward2.Image = picture8.Image;
                    break;
                case 9:
                    picForward2.Image = picture9.Image;
                    break;
                case 10:
                    picForward2.Image = picture10.Image;
                    break;
                case 11:
                    picForward2.Image = picture11.Image;
                    break;
                case 12:
                    picForward2.Image = picture12.Image;
                    break;
                case 13:
                    picForward2.Image = picture13.Image;
                    break;
                case 14:
                    picForward2.Image = picture14.Image;
                    break;
                case 15:
                    picForward2.Image = picture15.Image;
                    break;
                case 16:
                    picForward2.Image = picture16.Image;
                    break;
                case 17:
                    picForward2.Image = picture17.Image;
                    break;
                case 18:
                    picForward2.Image = picture18.Image;
                    break;
                case 19:
                    picForward2.Image = picture19.Image;
                    break;
                default:
                    picForward2.Image = picture20.Image;
                    break;
            }
            nCol = _HolderFCol[2];
            nRow = _HolderFRow[2];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picForward3.Image = picture1.Image;
                    break;
                case 2:
                    picForward3.Image = picture2.Image;
                    break;
                case 3:
                    picForward3.Image = picture3.Image;
                    break;
                case 4:
                    picForward3.Image = picture4.Image;
                    break;
                case 5:
                    picForward3.Image = picture5.Image;
                    break;
                case 6:
                    picForward3.Image = picture6.Image;
                    break;
                case 7:
                    picForward3.Image = picture7.Image;
                    break;
                case 8:
                    picForward3.Image = picture8.Image;
                    break;
                case 9:
                    picForward3.Image = picture9.Image;
                    break;
                case 10:
                    picForward3.Image = picture10.Image;
                    break;
                case 11:
                    picForward3.Image = picture11.Image;
                    break;
                case 12:
                    picForward3.Image = picture12.Image;
                    break;
                case 13:
                    picForward3.Image = picture13.Image;
                    break;
                case 14:
                    picForward3.Image = picture14.Image;
                    break;
                case 15:
                    picForward3.Image = picture15.Image;
                    break;
                case 16:
                    picForward3.Image = picture16.Image;
                    break;
                case 17:
                    picForward3.Image = picture17.Image;
                    break;
                case 18:
                    picForward3.Image = picture18.Image;
                    break;
                case 19:
                    picForward3.Image = picture19.Image;
                    break;
                default:
                    picForward3.Image = picture20.Image;
                    break;
            }


        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            int nCol, nRow, nType;

            CounterDirection += 1;
            if (CounterDirection == 5)
            {
                CounterDirection = 1;
            }
            switch (CounterDirection)
            {
                case 1:
                    _HolderACol[0] = CounterCol - 3;
                    if (_HolderACol[0] < 1)
                    {
                        _HolderACol[0] = _HolderACol[0] + 10;
                    }
                    _HolderARow[0] = CounterRow;
                    _HolderACol[1] = CounterCol - 2;
                    if (_HolderACol[1] < 1)
                    {
                        _HolderACol[1] = _HolderACol[1] + 10;
                    }
                    _HolderARow[1] = CounterRow;
                    _HolderACol[2] = CounterCol - 1;
                    if (_HolderACol[2] < 1)
                    {
                        _HolderACol[2] = _HolderACol[2] + 10;
                    }
                    _HolderARow[2] = CounterRow;
                    _HolderACol[3] = CounterCol;
                    _HolderARow[3] = CounterRow;
                    _HolderACol[4] = CounterCol + 1;
                    if (_HolderACol[4] > 10)
                    {
                        _HolderACol[4] = _HolderACol[4] - 10;
                    }
                    _HolderARow[4] = CounterRow;
                    _HolderACol[5] = CounterCol + 2;
                    if (_HolderACol[5] > 10)
                    {
                        _HolderACol[5] = _HolderACol[5] - 10;
                    }
                    _HolderARow[5] = CounterRow;
                    _HolderACol[6] = CounterCol + 3;
                    if (_HolderACol[6] > 10)
                    {
                        _HolderACol[6] = _HolderACol[6] - 10;
                    }
                    _HolderARow[6] = CounterRow;
                    _HolderFCol[0] = CounterCol;
                    _HolderFRow[0] = CounterRow - 3;
                    if (_HolderFRow[0] < 1)
                    {
                        _HolderFRow[0] = _HolderFRow[0] + 10;
                    }
                    _HolderFCol[1] = CounterCol;
                    _HolderFRow[1] = CounterRow - 2;
                    if (_HolderFRow[1] < 1)
                    {
                        _HolderFRow[1] = _HolderFRow[1] + 10;
                    }
                    _HolderFCol[2] = CounterCol;
                    _HolderFRow[2] = CounterRow - 1;
                    if (_HolderFRow[2] < 1)
                    {
                        _HolderFRow[2] = _HolderFRow[2] + 10;
                    }

                    break;
                case 2:
                    _HolderACol[0] = CounterCol;
                    _HolderARow[0] = CounterRow - 3;
                    if (_HolderARow[0] < 1)
                    {
                        _HolderARow[0] = _HolderARow[0] + 10;
                    }
                    _HolderACol[1] = CounterCol;
                    _HolderARow[1] = CounterRow - 2;
                    if (_HolderARow[1] < 1)
                    {
                        _HolderARow[1] = _HolderARow[1] + 10;
                    }
                    _HolderACol[2] = CounterCol;
                    _HolderARow[2] = CounterRow - 1;
                    if (_HolderARow[2] < 1)
                    {
                        _HolderARow[2] = _HolderARow[2] + 10;
                    }
                    _HolderACol[3] = CounterCol;
                    _HolderARow[3] = CounterRow;
                    _HolderACol[4] = CounterCol;
                    _HolderARow[4] = CounterRow + 1;
                    if (_HolderARow[4] > 10)
                    {
                        _HolderARow[4] = _HolderARow[4] - 10;
                    }
                    _HolderACol[5] = CounterCol;
                    _HolderARow[5] = CounterRow + 2;
                    if (_HolderARow[5] > 10)
                    {
                        _HolderARow[5] = _HolderARow[5] - 10;
                    }
                    _HolderACol[6] = CounterCol;
                    _HolderARow[6] = CounterRow + 3;
                    if (_HolderARow[6] > 10)
                    {
                        _HolderARow[6] = _HolderARow[6] - 10;
                    }
                    _HolderFCol[0] = CounterCol + 3;
                    if (_HolderFCol[0] > 10)
                    {
                        _HolderFCol[0] = _HolderFCol[0] - 10;
                    }
                    _HolderFRow[0] = CounterRow;
                    _HolderFCol[1] = CounterCol + 2;
                    if (_HolderFCol[1] > 10)
                    {
                        _HolderFCol[1] = _HolderFCol[1] - 10;
                    }
                    _HolderFRow[1] = CounterRow;
                    _HolderFCol[2] = CounterCol + 1;
                    if (_HolderFCol[2] > 10)
                    {
                        _HolderFCol[2] = _HolderFCol[2] - 10;
                    }
                    _HolderFRow[2] = CounterRow;

                    break;
                case 3:
                    _HolderACol[0] = CounterCol + 3;
                    if (_HolderACol[0] > 10)
                    {
                        _HolderACol[0] = _HolderACol[0] - 10;
                    }
                    _HolderARow[0] = CounterRow;
                    _HolderACol[1] = CounterCol + 2;
                    if (_HolderACol[1] > 10)
                    {
                        _HolderACol[1] = _HolderACol[1] - 10;
                    }
                    _HolderARow[1] = CounterRow;
                    _HolderACol[2] = CounterCol + 1;
                    if (_HolderACol[2] > 10)
                    {
                        _HolderACol[2] = _HolderACol[2] - 10;
                    }
                    _HolderARow[2] = CounterRow;
                    _HolderACol[3] = CounterCol;
                    _HolderARow[3] = CounterRow;
                    _HolderACol[4] = CounterCol - 1;
                    if (_HolderACol[4] < 1)
                    {
                        _HolderACol[4] = _HolderACol[4] + 10;
                    }
                    _HolderARow[4] = CounterRow;
                    _HolderACol[5] = CounterCol - 2;
                    if (_HolderACol[5] < 2)
                    {
                        _HolderACol[5] = _HolderACol[5] + 10;
                    }
                    _HolderARow[5] = CounterRow;
                    _HolderACol[6] = CounterCol - 3;
                    if (_HolderACol[6] < 3)
                    {
                        _HolderACol[6] = _HolderACol[6] + 10;
                    }
                    _HolderARow[6] = CounterRow;
                    _HolderFCol[0] = CounterCol;
                    _HolderFRow[0] = CounterRow + 3;
                    if (_HolderFRow[0] > 10)
                    {
                        _HolderFRow[0] = _HolderFRow[0] - 10;
                    }
                    _HolderFCol[1] = CounterCol;
                    _HolderFRow[1] = CounterRow + 2;
                    if (_HolderFRow[1] > 10)
                    {
                        _HolderFRow[1] = _HolderFRow[1] - 10;
                    }
                    _HolderFCol[2] = CounterCol;
                    _HolderFRow[2] = CounterRow + 1;
                    if (_HolderFRow[2] > 10)
                    {
                        _HolderFRow[2] = _HolderFRow[2] - 10;
                    }

                    break;
                default:
                    _HolderACol[0] = CounterCol;
                    _HolderARow[0] = CounterRow + 3;
                    if (_HolderARow[0] > 10)
                    {
                        _HolderARow[0] = _HolderARow[0] - 10;
                    }
                    _HolderACol[1] = CounterCol;
                    _HolderARow[1] = CounterRow + 2;
                    if (_HolderARow[1] > 10)
                    {
                        _HolderARow[1] = _HolderARow[1] - 10;
                    }
                    _HolderACol[2] = CounterCol;
                    _HolderARow[2] = CounterRow + 1;
                    if (_HolderARow[2] > 10)
                    {
                        _HolderARow[2] = _HolderARow[2] - 10;
                    }
                    _HolderACol[3] = CounterCol;
                    _HolderARow[3] = CounterRow;
                    _HolderACol[4] = CounterCol;
                    _HolderARow[4] = CounterRow - 1;
                    if (_HolderARow[4] < 1)
                    {
                        _HolderARow[4] = _HolderARow[4] + 10;
                    }
                    _HolderACol[5] = CounterCol;
                    _HolderARow[5] = CounterRow - 2;
                    if (_HolderARow[5] < 1)
                    {
                        _HolderARow[5] = _HolderARow[5] + 10;
                    }
                    _HolderACol[6] = CounterCol;
                    _HolderARow[6] = CounterRow - 3;
                    if (_HolderARow[6] < 1)
                    {
                        _HolderARow[6] = _HolderARow[6] + 10;
                    }
                    _HolderFCol[0] = CounterCol - 3;
                    if (_HolderFCol[0] < 1)
                    {
                        _HolderFCol[0] = _HolderFCol[0] + 10;
                    }
                    _HolderFRow[0] = CounterRow;
                    _HolderFCol[1] = CounterCol - 2;
                    if (_HolderFCol[1] < 1)
                    {
                        _HolderFCol[1] = _HolderFCol[1] + 10;
                    }
                    _HolderFRow[1] = CounterRow;
                    _HolderFCol[2] = CounterCol - 1;
                    if (_HolderFCol[2] < 1)
                    {
                        _HolderFCol[2] = _HolderFCol[2] + 10;
                    }
                    _HolderFRow[2] = CounterRow;

                    break;
            }
            lblLocation.Text = "Location = (" + Convert.ToString(CounterCol) + "," + Convert.ToString(CounterRow) + ")";
            switch (CounterDirection)
            {
                case 1:
                    lblDirection.Text = "Direction = (N)";
                    break;
                case 2:
                    lblDirection.Text = "Direction = (E)";
                    break;
                case 3:
                    lblDirection.Text = "Direction = (S)";
                    break;
                default:
                    lblDirection.Text = "Direction = (W)";
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F blank.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F Exit.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F found1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F found2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F found3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F type11.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F type12.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F type13.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F type14.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F type21.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F type22.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F type23.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"F type24.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"F type25.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"F type26.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"F type31.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
                Image = Image.FromFile(@"F type32.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture18 = new PictureBox
            {
                Name = "pictureBox18",
                Image = Image.FromFile(@"F type33.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture19 = new PictureBox
            {
                Name = "pictureBox19",
                Image = Image.FromFile(@"F type34.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture20 = new PictureBox
            {
                Name = "pictureBox20",
                Image = Image.FromFile(@"F Nullgate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nCol = _HolderACol[0];
            nRow = _HolderARow[0];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picAcross1.Image = picture1.Image;
                    break;
                case 2:
                    picAcross1.Image = picture2.Image;
                    break;
                case 3:
                    picAcross1.Image = picture3.Image;
                    break;
                case 4:
                    picAcross1.Image = picture4.Image;
                    break;
                case 5:
                    picAcross1.Image = picture5.Image;
                    break;
                case 6:
                    picAcross1.Image = picture6.Image;
                    break;
                case 7:
                    picAcross1.Image = picture7.Image;
                    break;
                case 8:
                    picAcross1.Image = picture8.Image;
                    break;
                case 9:
                    picAcross1.Image = picture9.Image;
                    break;
                case 10:
                    picAcross1.Image = picture10.Image;
                    break;
                case 11:
                    picAcross1.Image = picture11.Image;
                    break;
                case 12:
                    picAcross1.Image = picture12.Image;
                    break;
                case 13:
                    picAcross1.Image = picture13.Image;
                    break;
                case 14:
                    picAcross1.Image = picture14.Image;
                    break;
                case 15:
                    picAcross1.Image = picture15.Image;
                    break;
                case 16:
                    picAcross1.Image = picture16.Image;
                    break;
                case 17:
                    picAcross1.Image = picture17.Image;
                    break;
                case 18:
                    picAcross1.Image = picture18.Image;
                    break;
                case 19:
                    picAcross1.Image = picture19.Image;
                    break;
                default:
                    picAcross1.Image = picture20.Image;
                    break;
            }
            nCol = _HolderACol[1];
            nRow = _HolderARow[1];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picAcross2.Image = picture1.Image;
                    break;
                case 2:
                    picAcross2.Image = picture2.Image;
                    break;
                case 3:
                    picAcross2.Image = picture3.Image;
                    break;
                case 4:
                    picAcross2.Image = picture4.Image;
                    break;
                case 5:
                    picAcross2.Image = picture5.Image;
                    break;
                case 6:
                    picAcross2.Image = picture6.Image;
                    break;
                case 7:
                    picAcross2.Image = picture7.Image;
                    break;
                case 8:
                    picAcross2.Image = picture8.Image;
                    break;
                case 9:
                    picAcross2.Image = picture9.Image;
                    break;
                case 10:
                    picAcross2.Image = picture10.Image;
                    break;
                case 11:
                    picAcross2.Image = picture11.Image;
                    break;
                case 12:
                    picAcross2.Image = picture12.Image;
                    break;
                case 13:
                    picAcross2.Image = picture13.Image;
                    break;
                case 14:
                    picAcross2.Image = picture14.Image;
                    break;
                case 15:
                    picAcross2.Image = picture15.Image;
                    break;
                case 16:
                    picAcross2.Image = picture16.Image;
                    break;
                case 17:
                    picAcross2.Image = picture17.Image;
                    break;
                case 18:
                    picAcross2.Image = picture18.Image;
                    break;
                case 19:
                    picAcross2.Image = picture19.Image;
                    break;
                default:
                    picAcross2.Image = picture20.Image;
                    break;
            }
            nCol = _HolderACol[2];
            nRow = _HolderARow[2];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picAcross3.Image = picture1.Image;
                    break;
                case 2:
                    picAcross3.Image = picture2.Image;
                    break;
                case 3:
                    picAcross3.Image = picture3.Image;
                    break;
                case 4:
                    picAcross3.Image = picture4.Image;
                    break;
                case 5:
                    picAcross3.Image = picture5.Image;
                    break;
                case 6:
                    picAcross3.Image = picture6.Image;
                    break;
                case 7:
                    picAcross3.Image = picture7.Image;
                    break;
                case 8:
                    picAcross3.Image = picture8.Image;
                    break;
                case 9:
                    picAcross3.Image = picture9.Image;
                    break;
                case 10:
                    picAcross3.Image = picture10.Image;
                    break;
                case 11:
                    picAcross3.Image = picture11.Image;
                    break;
                case 12:
                    picAcross3.Image = picture12.Image;
                    break;
                case 13:
                    picAcross3.Image = picture13.Image;
                    break;
                case 14:
                    picAcross3.Image = picture14.Image;
                    break;
                case 15:
                    picAcross3.Image = picture15.Image;
                    break;
                case 16:
                    picAcross3.Image = picture16.Image;
                    break;
                case 17:
                    picAcross3.Image = picture17.Image;
                    break;
                case 18:
                    picAcross3.Image = picture18.Image;
                    break;
                case 19:
                    picAcross3.Image = picture19.Image;
                    break;
                default:
                    picAcross3.Image = picture20.Image;
                    break;
            }
            nCol = _HolderACol[3];
            nRow = _HolderARow[3];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picAcross4.Image = picture1.Image;
                    break;
                case 2:
                    picAcross4.Image = picture2.Image;
                    break;
                case 3:
                    picAcross4.Image = picture3.Image;
                    break;
                case 4:
                    picAcross4.Image = picture4.Image;
                    break;
                case 5:
                    picAcross4.Image = picture5.Image;
                    break;
                case 6:
                    picAcross4.Image = picture6.Image;
                    break;
                case 7:
                    picAcross4.Image = picture7.Image;
                    break;
                case 8:
                    picAcross4.Image = picture8.Image;
                    break;
                case 9:
                    picAcross4.Image = picture9.Image;
                    break;
                case 10:
                    picAcross4.Image = picture10.Image;
                    break;
                case 11:
                    picAcross4.Image = picture11.Image;
                    break;
                case 12:
                    picAcross4.Image = picture12.Image;
                    break;
                case 13:
                    picAcross4.Image = picture13.Image;
                    break;
                case 14:
                    picAcross4.Image = picture14.Image;
                    break;
                case 15:
                    picAcross4.Image = picture15.Image;
                    break;
                case 16:
                    picAcross4.Image = picture16.Image;
                    break;
                case 17:
                    picAcross4.Image = picture17.Image;
                    break;
                case 18:
                    picAcross4.Image = picture18.Image;
                    break;
                case 19:
                    picAcross4.Image = picture19.Image;
                    break;
                default:
                    picAcross4.Image = picture20.Image;
                    break;
            }
            nCol = _HolderACol[4];
            nRow = _HolderARow[4];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picAcross5.Image = picture1.Image;
                    break;
                case 2:
                    picAcross5.Image = picture2.Image;
                    break;
                case 3:
                    picAcross5.Image = picture3.Image;
                    break;
                case 4:
                    picAcross5.Image = picture4.Image;
                    break;
                case 5:
                    picAcross5.Image = picture5.Image;
                    break;
                case 6:
                    picAcross5.Image = picture6.Image;
                    break;
                case 7:
                    picAcross5.Image = picture7.Image;
                    break;
                case 8:
                    picAcross5.Image = picture8.Image;
                    break;
                case 9:
                    picAcross5.Image = picture9.Image;
                    break;
                case 10:
                    picAcross5.Image = picture10.Image;
                    break;
                case 11:
                    picAcross5.Image = picture11.Image;
                    break;
                case 12:
                    picAcross5.Image = picture12.Image;
                    break;
                case 13:
                    picAcross5.Image = picture13.Image;
                    break;
                case 14:
                    picAcross5.Image = picture14.Image;
                    break;
                case 15:
                    picAcross5.Image = picture15.Image;
                    break;
                case 16:
                    picAcross5.Image = picture16.Image;
                    break;
                case 17:
                    picAcross5.Image = picture17.Image;
                    break;
                case 18:
                    picAcross5.Image = picture18.Image;
                    break;
                case 19:
                    picAcross5.Image = picture19.Image;
                    break;
                default:
                    picAcross5.Image = picture20.Image;
                    break;
            }
            nCol = _HolderACol[5];
            nRow = _HolderARow[5];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picAcross6.Image = picture1.Image;
                    break;
                case 2:
                    picAcross6.Image = picture2.Image;
                    break;
                case 3:
                    picAcross6.Image = picture3.Image;
                    break;
                case 4:
                    picAcross6.Image = picture4.Image;
                    break;
                case 5:
                    picAcross6.Image = picture5.Image;
                    break;
                case 6:
                    picAcross6.Image = picture6.Image;
                    break;
                case 7:
                    picAcross6.Image = picture7.Image;
                    break;
                case 8:
                    picAcross6.Image = picture8.Image;
                    break;
                case 9:
                    picAcross6.Image = picture9.Image;
                    break;
                case 10:
                    picAcross6.Image = picture10.Image;
                    break;
                case 11:
                    picAcross6.Image = picture11.Image;
                    break;
                case 12:
                    picAcross6.Image = picture12.Image;
                    break;
                case 13:
                    picAcross6.Image = picture13.Image;
                    break;
                case 14:
                    picAcross6.Image = picture14.Image;
                    break;
                case 15:
                    picAcross6.Image = picture15.Image;
                    break;
                case 16:
                    picAcross6.Image = picture16.Image;
                    break;
                case 17:
                    picAcross6.Image = picture17.Image;
                    break;
                case 18:
                    picAcross6.Image = picture18.Image;
                    break;
                case 19:
                    picAcross6.Image = picture19.Image;
                    break;
                default:
                    picAcross6.Image = picture20.Image;
                    break;
            }
            nCol = _HolderACol[6];
            nRow = _HolderARow[6];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picAcross7.Image = picture1.Image;
                    break;
                case 2:
                    picAcross7.Image = picture2.Image;
                    break;
                case 3:
                    picAcross7.Image = picture3.Image;
                    break;
                case 4:
                    picAcross7.Image = picture4.Image;
                    break;
                case 5:
                    picAcross7.Image = picture5.Image;
                    break;
                case 6:
                    picAcross7.Image = picture6.Image;
                    break;
                case 7:
                    picAcross7.Image = picture7.Image;
                    break;
                case 8:
                    picAcross7.Image = picture8.Image;
                    break;
                case 9:
                    picAcross7.Image = picture9.Image;
                    break;
                case 10:
                    picAcross7.Image = picture10.Image;
                    break;
                case 11:
                    picAcross7.Image = picture11.Image;
                    break;
                case 12:
                    picAcross7.Image = picture12.Image;
                    break;
                case 13:
                    picAcross7.Image = picture13.Image;
                    break;
                case 14:
                    picAcross7.Image = picture14.Image;
                    break;
                case 15:
                    picAcross7.Image = picture15.Image;
                    break;
                case 16:
                    picAcross7.Image = picture16.Image;
                    break;
                case 17:
                    picAcross7.Image = picture17.Image;
                    break;
                case 18:
                    picAcross7.Image = picture18.Image;
                    break;
                case 19:
                    picAcross7.Image = picture19.Image;
                    break;
                default:
                    picAcross7.Image = picture20.Image;
                    break;
            }

            nCol = _HolderFCol[0];
            nRow = _HolderFRow[0];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picForward1.Image = picture1.Image;
                    break;
                case 2:
                    picForward1.Image = picture2.Image;
                    break;
                case 3:
                    picForward1.Image = picture3.Image;
                    break;
                case 4:
                    picForward1.Image = picture4.Image;
                    break;
                case 5:
                    picForward1.Image = picture5.Image;
                    break;
                case 6:
                    picForward1.Image = picture6.Image;
                    break;
                case 7:
                    picForward1.Image = picture7.Image;
                    break;
                case 8:
                    picForward1.Image = picture8.Image;
                    break;
                case 9:
                    picForward1.Image = picture9.Image;
                    break;
                case 10:
                    picForward1.Image = picture10.Image;
                    break;
                case 11:
                    picForward1.Image = picture11.Image;
                    break;
                case 12:
                    picForward1.Image = picture12.Image;
                    break;
                case 13:
                    picForward1.Image = picture13.Image;
                    break;
                case 14:
                    picForward1.Image = picture14.Image;
                    break;
                case 15:
                    picForward1.Image = picture15.Image;
                    break;
                case 16:
                    picForward1.Image = picture16.Image;
                    break;
                case 17:
                    picForward1.Image = picture17.Image;
                    break;
                case 18:
                    picForward1.Image = picture18.Image;
                    break;
                case 19:
                    picForward1.Image = picture19.Image;
                    break;
                default:
                    picForward1.Image = picture20.Image;
                    break;
            }
            nCol = _HolderFCol[1];
            nRow = _HolderFRow[1];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picForward2.Image = picture1.Image;
                    break;
                case 2:
                    picForward2.Image = picture2.Image;
                    break;
                case 3:
                    picForward2.Image = picture3.Image;
                    break;
                case 4:
                    picForward2.Image = picture4.Image;
                    break;
                case 5:
                    picForward2.Image = picture5.Image;
                    break;
                case 6:
                    picForward2.Image = picture6.Image;
                    break;
                case 7:
                    picForward2.Image = picture7.Image;
                    break;
                case 8:
                    picForward2.Image = picture8.Image;
                    break;
                case 9:
                    picForward2.Image = picture9.Image;
                    break;
                case 10:
                    picForward2.Image = picture10.Image;
                    break;
                case 11:
                    picForward2.Image = picture11.Image;
                    break;
                case 12:
                    picForward2.Image = picture12.Image;
                    break;
                case 13:
                    picForward2.Image = picture13.Image;
                    break;
                case 14:
                    picForward2.Image = picture14.Image;
                    break;
                case 15:
                    picForward2.Image = picture15.Image;
                    break;
                case 16:
                    picForward2.Image = picture16.Image;
                    break;
                case 17:
                    picForward2.Image = picture17.Image;
                    break;
                case 18:
                    picForward2.Image = picture18.Image;
                    break;
                case 19:
                    picForward2.Image = picture19.Image;
                    break;
                default:
                    picForward2.Image = picture20.Image;
                    break;
            }
            nCol = _HolderFCol[2];
            nRow = _HolderFRow[2];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picForward3.Image = picture1.Image;
                    break;
                case 2:
                    picForward3.Image = picture2.Image;
                    break;
                case 3:
                    picForward3.Image = picture3.Image;
                    break;
                case 4:
                    picForward3.Image = picture4.Image;
                    break;
                case 5:
                    picForward3.Image = picture5.Image;
                    break;
                case 6:
                    picForward3.Image = picture6.Image;
                    break;
                case 7:
                    picForward3.Image = picture7.Image;
                    break;
                case 8:
                    picForward3.Image = picture8.Image;
                    break;
                case 9:
                    picForward3.Image = picture9.Image;
                    break;
                case 10:
                    picForward3.Image = picture10.Image;
                    break;
                case 11:
                    picForward3.Image = picture11.Image;
                    break;
                case 12:
                    picForward3.Image = picture12.Image;
                    break;
                case 13:
                    picForward3.Image = picture13.Image;
                    break;
                case 14:
                    picForward3.Image = picture14.Image;
                    break;
                case 15:
                    picForward3.Image = picture15.Image;
                    break;
                case 16:
                    picForward3.Image = picture16.Image;
                    break;
                case 17:
                    picForward3.Image = picture17.Image;
                    break;
                case 18:
                    picForward3.Image = picture18.Image;
                    break;
                case 19:
                    picForward3.Image = picture19.Image;
                    break;
                default:
                    picForward3.Image = picture20.Image;
                    break;
            }


        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            int nCol, nRow, nType;

            CounterDirection -= 1;
            if (CounterDirection == 0)
            {
                CounterDirection = 4;
            }
            switch (CounterDirection)
            {
                case 1:
                    _HolderACol[0] = CounterCol - 3;
                    if (_HolderACol[0] < 1)
                    {
                        _HolderACol[0] = _HolderACol[0] + 10;
                    }
                    _HolderARow[0] = CounterRow;
                    _HolderACol[1] = CounterCol - 2;
                    if (_HolderACol[1] < 1)
                    {
                        _HolderACol[1] = _HolderACol[1] + 10;
                    }
                    _HolderARow[1] = CounterRow;
                    _HolderACol[2] = CounterCol - 1;
                    if (_HolderACol[2] < 1)
                    {
                        _HolderACol[2] = _HolderACol[2] + 10;
                    }
                    _HolderARow[2] = CounterRow;
                    _HolderACol[3] = CounterCol;
                    _HolderARow[3] = CounterRow;
                    _HolderACol[4] = CounterCol + 1;
                    if (_HolderACol[4] > 10)
                    {
                        _HolderACol[4] = _HolderACol[4] - 10;
                    }
                    _HolderARow[4] = CounterRow;
                    _HolderACol[5] = CounterCol + 2;
                    if (_HolderACol[5] > 10)
                    {
                        _HolderACol[5] = _HolderACol[5] - 10;
                    }
                    _HolderARow[5] = CounterRow;
                    _HolderACol[6] = CounterCol + 3;
                    if (_HolderACol[6] > 10)
                    {
                        _HolderACol[6] = _HolderACol[6] - 10;
                    }
                    _HolderARow[6] = CounterRow;
                    _HolderFCol[0] = CounterCol;
                    _HolderFRow[0] = CounterRow - 3;
                    if (_HolderFRow[0] < 1)
                    {
                        _HolderFRow[0] = _HolderFRow[0] + 10;
                    }
                    _HolderFCol[1] = CounterCol;
                    _HolderFRow[1] = CounterRow - 2;
                    if (_HolderFRow[1] < 1)
                    {
                        _HolderFRow[1] = _HolderFRow[1] + 10;
                    }
                    _HolderFCol[2] = CounterCol;
                    _HolderFRow[2] = CounterRow - 1;
                    if (_HolderFRow[2] < 1)
                    {
                        _HolderFRow[2] = _HolderFRow[2] + 10;
                    }

                    break;
                case 2:
                    _HolderACol[0] = CounterCol;
                    _HolderARow[0] = CounterRow - 3;
                    if (_HolderARow[0] < 1)
                    {
                        _HolderARow[0] = _HolderARow[0] + 10;
                    }
                    _HolderACol[1] = CounterCol;
                    _HolderARow[1] = CounterRow - 2;
                    if (_HolderARow[1] < 1)
                    {
                        _HolderARow[1] = _HolderARow[1] + 10;
                    }
                    _HolderACol[2] = CounterCol;
                    _HolderARow[2] = CounterRow - 1;
                    if (_HolderARow[2] < 1)
                    {
                        _HolderARow[2] = _HolderARow[2] + 10;
                    }
                    _HolderACol[3] = CounterCol;
                    _HolderARow[3] = CounterRow;
                    _HolderACol[4] = CounterCol;
                    _HolderARow[4] = CounterRow + 1;
                    if (_HolderARow[4] > 10)
                    {
                        _HolderARow[4] = _HolderARow[4] - 10;
                    }
                    _HolderACol[5] = CounterCol;
                    _HolderARow[5] = CounterRow + 2;
                    if (_HolderARow[5] > 10)
                    {
                        _HolderARow[5] = _HolderARow[5] - 10;
                    }
                    _HolderACol[6] = CounterCol;
                    _HolderARow[6] = CounterRow + 3;
                    if (_HolderARow[6] > 10)
                    {
                        _HolderARow[6] = _HolderARow[6] - 10;
                    }
                    _HolderFCol[0] = CounterCol + 3;
                    if (_HolderFCol[0] > 10)
                    {
                        _HolderFCol[0] = _HolderFCol[0] - 10;
                    }
                    _HolderFRow[0] = CounterRow;
                    _HolderFCol[1] = CounterCol + 2;
                    if (_HolderFCol[1] > 10)
                    {
                        _HolderFCol[1] = _HolderFCol[1] - 10;
                    }
                    _HolderFRow[1] = CounterRow;
                    _HolderFCol[2] = CounterCol + 1;
                    if (_HolderFCol[2] > 10)
                    {
                        _HolderFCol[2] = _HolderFCol[2] - 10;
                    }
                    _HolderFRow[2] = CounterRow;

                    break;
                case 3:
                    _HolderACol[0] = CounterCol + 3;
                    if (_HolderACol[0] > 10)
                    {
                        _HolderACol[0] = _HolderACol[0] - 10;
                    }
                    _HolderARow[0] = CounterRow;
                    _HolderACol[1] = CounterCol + 2;
                    if (_HolderACol[1] > 10)
                    {
                        _HolderACol[1] = _HolderACol[1] - 10;
                    }
                    _HolderARow[1] = CounterRow;
                    _HolderACol[2] = CounterCol + 1;
                    if (_HolderACol[2] > 10)
                    {
                        _HolderACol[2] = _HolderACol[2] - 10;
                    }
                    _HolderARow[2] = CounterRow;
                    _HolderACol[3] = CounterCol;
                    _HolderARow[3] = CounterRow;
                    _HolderACol[4] = CounterCol - 1;
                    if (_HolderACol[4] < 1)
                    {
                        _HolderACol[4] = _HolderACol[4] + 10;
                    }
                    _HolderARow[4] = CounterRow;
                    _HolderACol[5] = CounterCol - 2;
                    if (_HolderACol[5] < 2)
                    {
                        _HolderACol[5] = _HolderACol[5] + 10;
                    }
                    _HolderARow[5] = CounterRow;
                    _HolderACol[6] = CounterCol - 3;
                    if (_HolderACol[6] < 3)
                    {
                        _HolderACol[6] = _HolderACol[6] + 10;
                    }
                    _HolderARow[6] = CounterRow;
                    _HolderFCol[0] = CounterCol;
                    _HolderFRow[0] = CounterRow + 3;
                    if (_HolderFRow[0] > 10)
                    {
                        _HolderFRow[0] = _HolderFRow[0] - 10;
                    }
                    _HolderFCol[1] = CounterCol;
                    _HolderFRow[1] = CounterRow + 2;
                    if (_HolderFRow[1] > 10)
                    {
                        _HolderFRow[1] = _HolderFRow[1] - 10;
                    }
                    _HolderFCol[2] = CounterCol;
                    _HolderFRow[2] = CounterRow + 1;
                    if (_HolderFRow[2] > 10)
                    {
                        _HolderFRow[2] = _HolderFRow[2] - 10;
                    }

                    break;
                default:
                    _HolderACol[0] = CounterCol;
                    _HolderARow[0] = CounterRow + 3;
                    if (_HolderARow[0] > 10)
                    {
                        _HolderARow[0] = _HolderARow[0] - 10;
                    }
                    _HolderACol[1] = CounterCol;
                    _HolderARow[1] = CounterRow + 2;
                    if (_HolderARow[1] > 10)
                    {
                        _HolderARow[1] = _HolderARow[1] - 10;
                    }
                    _HolderACol[2] = CounterCol;
                    _HolderARow[2] = CounterRow + 1;
                    if (_HolderARow[2] > 10)
                    {
                        _HolderARow[2] = _HolderARow[2] - 10;
                    }
                    _HolderACol[3] = CounterCol;
                    _HolderARow[3] = CounterRow;
                    _HolderACol[4] = CounterCol;
                    _HolderARow[4] = CounterRow - 1;
                    if (_HolderARow[4] < 1)
                    {
                        _HolderARow[4] = _HolderARow[4] + 10;
                    }
                    _HolderACol[5] = CounterCol;
                    _HolderARow[5] = CounterRow - 2;
                    if (_HolderARow[5] < 1)
                    {
                        _HolderARow[5] = _HolderARow[5] + 10;
                    }
                    _HolderACol[6] = CounterCol;
                    _HolderARow[6] = CounterRow - 3;
                    if (_HolderARow[6] < 1)
                    {
                        _HolderARow[6] = _HolderARow[6] + 10;
                    }
                    _HolderFCol[0] = CounterCol - 3;
                    if (_HolderFCol[0] < 1)
                    {
                        _HolderFCol[0] = _HolderFCol[0] + 10;
                    }
                    _HolderFRow[0] = CounterRow;
                    _HolderFCol[1] = CounterCol - 2;
                    if (_HolderFCol[1] < 1)
                    {
                        _HolderFCol[1] = _HolderFCol[1] + 10;
                    }
                    _HolderFRow[1] = CounterRow;
                    _HolderFCol[2] = CounterCol - 1;
                    if (_HolderFCol[2] < 1)
                    {
                        _HolderFCol[2] = _HolderFCol[2] + 10;
                    }
                    _HolderFRow[2] = CounterRow;

                    break;
            }
            lblLocation.Text = "Location = (" + Convert.ToString(CounterCol) + "," + Convert.ToString(CounterRow) + ")";
            switch (CounterDirection)
            {
                case 1:
                    lblDirection.Text = "Direction = (N)";
                    break;
                case 2:
                    lblDirection.Text = "Direction = (E)";
                    break;
                case 3:
                    lblDirection.Text = "Direction = (S)";
                    break;
                default:
                    lblDirection.Text = "Direction = (W)";
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F blank.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F Exit.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F found1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F found2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F found3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F type11.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F type12.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F type13.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F type14.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F type21.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F type22.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F type23.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"F type24.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"F type25.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"F type26.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"F type31.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
                Image = Image.FromFile(@"F type32.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture18 = new PictureBox
            {
                Name = "pictureBox18",
                Image = Image.FromFile(@"F type33.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture19 = new PictureBox
            {
                Name = "pictureBox19",
                Image = Image.FromFile(@"F type34.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture20 = new PictureBox
            {
                Name = "pictureBox20",
                Image = Image.FromFile(@"F Nullgate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nCol = _HolderACol[0];
            nRow = _HolderARow[0];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picAcross1.Image = picture1.Image;
                    break;
                case 2:
                    picAcross1.Image = picture2.Image;
                    break;
                case 3:
                    picAcross1.Image = picture3.Image;
                    break;
                case 4:
                    picAcross1.Image = picture4.Image;
                    break;
                case 5:
                    picAcross1.Image = picture5.Image;
                    break;
                case 6:
                    picAcross1.Image = picture6.Image;
                    break;
                case 7:
                    picAcross1.Image = picture7.Image;
                    break;
                case 8:
                    picAcross1.Image = picture8.Image;
                    break;
                case 9:
                    picAcross1.Image = picture9.Image;
                    break;
                case 10:
                    picAcross1.Image = picture10.Image;
                    break;
                case 11:
                    picAcross1.Image = picture11.Image;
                    break;
                case 12:
                    picAcross1.Image = picture12.Image;
                    break;
                case 13:
                    picAcross1.Image = picture13.Image;
                    break;
                case 14:
                    picAcross1.Image = picture14.Image;
                    break;
                case 15:
                    picAcross1.Image = picture15.Image;
                    break;
                case 16:
                    picAcross1.Image = picture16.Image;
                    break;
                case 17:
                    picAcross1.Image = picture17.Image;
                    break;
                case 18:
                    picAcross1.Image = picture18.Image;
                    break;
                case 19:
                    picAcross1.Image = picture19.Image;
                    break;
                default:
                    picAcross1.Image = picture20.Image;
                    break;
            }
            nCol = _HolderACol[1];
            nRow = _HolderARow[1];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picAcross2.Image = picture1.Image;
                    break;
                case 2:
                    picAcross2.Image = picture2.Image;
                    break;
                case 3:
                    picAcross2.Image = picture3.Image;
                    break;
                case 4:
                    picAcross2.Image = picture4.Image;
                    break;
                case 5:
                    picAcross2.Image = picture5.Image;
                    break;
                case 6:
                    picAcross2.Image = picture6.Image;
                    break;
                case 7:
                    picAcross2.Image = picture7.Image;
                    break;
                case 8:
                    picAcross2.Image = picture8.Image;
                    break;
                case 9:
                    picAcross2.Image = picture9.Image;
                    break;
                case 10:
                    picAcross2.Image = picture10.Image;
                    break;
                case 11:
                    picAcross2.Image = picture11.Image;
                    break;
                case 12:
                    picAcross2.Image = picture12.Image;
                    break;
                case 13:
                    picAcross2.Image = picture13.Image;
                    break;
                case 14:
                    picAcross2.Image = picture14.Image;
                    break;
                case 15:
                    picAcross2.Image = picture15.Image;
                    break;
                case 16:
                    picAcross2.Image = picture16.Image;
                    break;
                case 17:
                    picAcross2.Image = picture17.Image;
                    break;
                case 18:
                    picAcross2.Image = picture18.Image;
                    break;
                case 19:
                    picAcross2.Image = picture19.Image;
                    break;
                default:
                    picAcross2.Image = picture20.Image;
                    break;
            }
            nCol = _HolderACol[2];
            nRow = _HolderARow[2];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picAcross3.Image = picture1.Image;
                    break;
                case 2:
                    picAcross3.Image = picture2.Image;
                    break;
                case 3:
                    picAcross3.Image = picture3.Image;
                    break;
                case 4:
                    picAcross3.Image = picture4.Image;
                    break;
                case 5:
                    picAcross3.Image = picture5.Image;
                    break;
                case 6:
                    picAcross3.Image = picture6.Image;
                    break;
                case 7:
                    picAcross3.Image = picture7.Image;
                    break;
                case 8:
                    picAcross3.Image = picture8.Image;
                    break;
                case 9:
                    picAcross3.Image = picture9.Image;
                    break;
                case 10:
                    picAcross3.Image = picture10.Image;
                    break;
                case 11:
                    picAcross3.Image = picture11.Image;
                    break;
                case 12:
                    picAcross3.Image = picture12.Image;
                    break;
                case 13:
                    picAcross3.Image = picture13.Image;
                    break;
                case 14:
                    picAcross3.Image = picture14.Image;
                    break;
                case 15:
                    picAcross3.Image = picture15.Image;
                    break;
                case 16:
                    picAcross3.Image = picture16.Image;
                    break;
                case 17:
                    picAcross3.Image = picture17.Image;
                    break;
                case 18:
                    picAcross3.Image = picture18.Image;
                    break;
                case 19:
                    picAcross3.Image = picture19.Image;
                    break;
                default:
                    picAcross3.Image = picture20.Image;
                    break;
            }
            nCol = _HolderACol[3];
            nRow = _HolderARow[3];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picAcross4.Image = picture1.Image;
                    break;
                case 2:
                    picAcross4.Image = picture2.Image;
                    break;
                case 3:
                    picAcross4.Image = picture3.Image;
                    break;
                case 4:
                    picAcross4.Image = picture4.Image;
                    break;
                case 5:
                    picAcross4.Image = picture5.Image;
                    break;
                case 6:
                    picAcross4.Image = picture6.Image;
                    break;
                case 7:
                    picAcross4.Image = picture7.Image;
                    break;
                case 8:
                    picAcross4.Image = picture8.Image;
                    break;
                case 9:
                    picAcross4.Image = picture9.Image;
                    break;
                case 10:
                    picAcross4.Image = picture10.Image;
                    break;
                case 11:
                    picAcross4.Image = picture11.Image;
                    break;
                case 12:
                    picAcross4.Image = picture12.Image;
                    break;
                case 13:
                    picAcross4.Image = picture13.Image;
                    break;
                case 14:
                    picAcross4.Image = picture14.Image;
                    break;
                case 15:
                    picAcross4.Image = picture15.Image;
                    break;
                case 16:
                    picAcross4.Image = picture16.Image;
                    break;
                case 17:
                    picAcross4.Image = picture17.Image;
                    break;
                case 18:
                    picAcross4.Image = picture18.Image;
                    break;
                case 19:
                    picAcross4.Image = picture19.Image;
                    break;
                default:
                    picAcross4.Image = picture20.Image;
                    break;
            }
            nCol = _HolderACol[4];
            nRow = _HolderARow[4];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picAcross5.Image = picture1.Image;
                    break;
                case 2:
                    picAcross5.Image = picture2.Image;
                    break;
                case 3:
                    picAcross5.Image = picture3.Image;
                    break;
                case 4:
                    picAcross5.Image = picture4.Image;
                    break;
                case 5:
                    picAcross5.Image = picture5.Image;
                    break;
                case 6:
                    picAcross5.Image = picture6.Image;
                    break;
                case 7:
                    picAcross5.Image = picture7.Image;
                    break;
                case 8:
                    picAcross5.Image = picture8.Image;
                    break;
                case 9:
                    picAcross5.Image = picture9.Image;
                    break;
                case 10:
                    picAcross5.Image = picture10.Image;
                    break;
                case 11:
                    picAcross5.Image = picture11.Image;
                    break;
                case 12:
                    picAcross5.Image = picture12.Image;
                    break;
                case 13:
                    picAcross5.Image = picture13.Image;
                    break;
                case 14:
                    picAcross5.Image = picture14.Image;
                    break;
                case 15:
                    picAcross5.Image = picture15.Image;
                    break;
                case 16:
                    picAcross5.Image = picture16.Image;
                    break;
                case 17:
                    picAcross5.Image = picture17.Image;
                    break;
                case 18:
                    picAcross5.Image = picture18.Image;
                    break;
                case 19:
                    picAcross5.Image = picture19.Image;
                    break;
                default:
                    picAcross5.Image = picture20.Image;
                    break;
            }
            nCol = _HolderACol[5];
            nRow = _HolderARow[5];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picAcross6.Image = picture1.Image;
                    break;
                case 2:
                    picAcross6.Image = picture2.Image;
                    break;
                case 3:
                    picAcross6.Image = picture3.Image;
                    break;
                case 4:
                    picAcross6.Image = picture4.Image;
                    break;
                case 5:
                    picAcross6.Image = picture5.Image;
                    break;
                case 6:
                    picAcross6.Image = picture6.Image;
                    break;
                case 7:
                    picAcross6.Image = picture7.Image;
                    break;
                case 8:
                    picAcross6.Image = picture8.Image;
                    break;
                case 9:
                    picAcross6.Image = picture9.Image;
                    break;
                case 10:
                    picAcross6.Image = picture10.Image;
                    break;
                case 11:
                    picAcross6.Image = picture11.Image;
                    break;
                case 12:
                    picAcross6.Image = picture12.Image;
                    break;
                case 13:
                    picAcross6.Image = picture13.Image;
                    break;
                case 14:
                    picAcross6.Image = picture14.Image;
                    break;
                case 15:
                    picAcross6.Image = picture15.Image;
                    break;
                case 16:
                    picAcross6.Image = picture16.Image;
                    break;
                case 17:
                    picAcross6.Image = picture17.Image;
                    break;
                case 18:
                    picAcross6.Image = picture18.Image;
                    break;
                case 19:
                    picAcross6.Image = picture19.Image;
                    break;
                default:
                    picAcross6.Image = picture20.Image;
                    break;
            }
            nCol = _HolderACol[6];
            nRow = _HolderARow[6];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picAcross7.Image = picture1.Image;
                    break;
                case 2:
                    picAcross7.Image = picture2.Image;
                    break;
                case 3:
                    picAcross7.Image = picture3.Image;
                    break;
                case 4:
                    picAcross7.Image = picture4.Image;
                    break;
                case 5:
                    picAcross7.Image = picture5.Image;
                    break;
                case 6:
                    picAcross7.Image = picture6.Image;
                    break;
                case 7:
                    picAcross7.Image = picture7.Image;
                    break;
                case 8:
                    picAcross7.Image = picture8.Image;
                    break;
                case 9:
                    picAcross7.Image = picture9.Image;
                    break;
                case 10:
                    picAcross7.Image = picture10.Image;
                    break;
                case 11:
                    picAcross7.Image = picture11.Image;
                    break;
                case 12:
                    picAcross7.Image = picture12.Image;
                    break;
                case 13:
                    picAcross7.Image = picture13.Image;
                    break;
                case 14:
                    picAcross7.Image = picture14.Image;
                    break;
                case 15:
                    picAcross7.Image = picture15.Image;
                    break;
                case 16:
                    picAcross7.Image = picture16.Image;
                    break;
                case 17:
                    picAcross7.Image = picture17.Image;
                    break;
                case 18:
                    picAcross7.Image = picture18.Image;
                    break;
                case 19:
                    picAcross7.Image = picture19.Image;
                    break;
                default:
                    picAcross7.Image = picture20.Image;
                    break;
            }

            nCol = _HolderFCol[0];
            nRow = _HolderFRow[0];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picForward1.Image = picture1.Image;
                    break;
                case 2:
                    picForward1.Image = picture2.Image;
                    break;
                case 3:
                    picForward1.Image = picture3.Image;
                    break;
                case 4:
                    picForward1.Image = picture4.Image;
                    break;
                case 5:
                    picForward1.Image = picture5.Image;
                    break;
                case 6:
                    picForward1.Image = picture6.Image;
                    break;
                case 7:
                    picForward1.Image = picture7.Image;
                    break;
                case 8:
                    picForward1.Image = picture8.Image;
                    break;
                case 9:
                    picForward1.Image = picture9.Image;
                    break;
                case 10:
                    picForward1.Image = picture10.Image;
                    break;
                case 11:
                    picForward1.Image = picture11.Image;
                    break;
                case 12:
                    picForward1.Image = picture12.Image;
                    break;
                case 13:
                    picForward1.Image = picture13.Image;
                    break;
                case 14:
                    picForward1.Image = picture14.Image;
                    break;
                case 15:
                    picForward1.Image = picture15.Image;
                    break;
                case 16:
                    picForward1.Image = picture16.Image;
                    break;
                case 17:
                    picForward1.Image = picture17.Image;
                    break;
                case 18:
                    picForward1.Image = picture18.Image;
                    break;
                case 19:
                    picForward1.Image = picture19.Image;
                    break;
                default:
                    picForward1.Image = picture20.Image;
                    break;
            }
            nCol = _HolderFCol[1];
            nRow = _HolderFRow[1];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picForward2.Image = picture1.Image;
                    break;
                case 2:
                    picForward2.Image = picture2.Image;
                    break;
                case 3:
                    picForward2.Image = picture3.Image;
                    break;
                case 4:
                    picForward2.Image = picture4.Image;
                    break;
                case 5:
                    picForward2.Image = picture5.Image;
                    break;
                case 6:
                    picForward2.Image = picture6.Image;
                    break;
                case 7:
                    picForward2.Image = picture7.Image;
                    break;
                case 8:
                    picForward2.Image = picture8.Image;
                    break;
                case 9:
                    picForward2.Image = picture9.Image;
                    break;
                case 10:
                    picForward2.Image = picture10.Image;
                    break;
                case 11:
                    picForward2.Image = picture11.Image;
                    break;
                case 12:
                    picForward2.Image = picture12.Image;
                    break;
                case 13:
                    picForward2.Image = picture13.Image;
                    break;
                case 14:
                    picForward2.Image = picture14.Image;
                    break;
                case 15:
                    picForward2.Image = picture15.Image;
                    break;
                case 16:
                    picForward2.Image = picture16.Image;
                    break;
                case 17:
                    picForward2.Image = picture17.Image;
                    break;
                case 18:
                    picForward2.Image = picture18.Image;
                    break;
                case 19:
                    picForward2.Image = picture19.Image;
                    break;
                default:
                    picForward2.Image = picture20.Image;
                    break;
            }
            nCol = _HolderFCol[2];
            nRow = _HolderFRow[2];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picForward3.Image = picture1.Image;
                    break;
                case 2:
                    picForward3.Image = picture2.Image;
                    break;
                case 3:
                    picForward3.Image = picture3.Image;
                    break;
                case 4:
                    picForward3.Image = picture4.Image;
                    break;
                case 5:
                    picForward3.Image = picture5.Image;
                    break;
                case 6:
                    picForward3.Image = picture6.Image;
                    break;
                case 7:
                    picForward3.Image = picture7.Image;
                    break;
                case 8:
                    picForward3.Image = picture8.Image;
                    break;
                case 9:
                    picForward3.Image = picture9.Image;
                    break;
                case 10:
                    picForward3.Image = picture10.Image;
                    break;
                case 11:
                    picForward3.Image = picture11.Image;
                    break;
                case 12:
                    picForward3.Image = picture12.Image;
                    break;
                case 13:
                    picForward3.Image = picture13.Image;
                    break;
                case 14:
                    picForward3.Image = picture14.Image;
                    break;
                case 15:
                    picForward3.Image = picture15.Image;
                    break;
                case 16:
                    picForward3.Image = picture16.Image;
                    break;
                case 17:
                    picForward3.Image = picture17.Image;
                    break;
                case 18:
                    picForward3.Image = picture18.Image;
                    break;
                case 19:
                    picForward3.Image = picture19.Image;
                    break;
                default:
                    picForward3.Image = picture20.Image;
                    break;
            }


        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            int nCol, nRow, nType;
            int nSavecol, nSaverow;
            String sCode = null;
            int nNew = 1;
            int nSame;
            String sWord;

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F blank.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F Exit.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F found1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F found2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F found3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F type11.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F type12.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F type13.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F type14.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F type21.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F type22.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F type23.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"F type24.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"F type25.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"F type26.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"F type31.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
                Image = Image.FromFile(@"F type32.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture18 = new PictureBox
            {
                Name = "pictureBox18",
                Image = Image.FromFile(@"F type33.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture19 = new PictureBox
            {
                Name = "pictureBox19",
                Image = Image.FromFile(@"F type34.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture20 = new PictureBox
            {
                Name = "pictureBox20",
                Image = Image.FromFile(@"F Nullgate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nCol = _HolderACol[3];
            nRow = _HolderARow[3];
            nSavecol = nCol;
            nSaverow = nRow;
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 3:
                    return;
                case 4:
                    return;
                case 5:
                    return;
                case 6:
                    sCode = "1000";
                    break;
                case 7:
                    sCode = "0100";
                    break;
                case 8:
                    sCode = "0010";
                    break;
                case 9:
                    sCode = "0001";
                    break;
                case 10:
                    sCode = "1100";
                    break;
                case 11:
                    sCode = "0110";
                    break;
                case 12:
                    sCode = "0011";
                    break;
                case 13:
                    sCode = "1001";
                    break;
                case 14:
                    sCode = "1010";
                    break;
                case 15:
                    sCode = "0101";
                    break;
                case 16:
                    sCode = "1110";
                    break;
                case 17:
                    sCode = "0111";
                    break;
                case 18:
                    sCode = "1011";
                    break;
                case 19:
                    sCode = "1101";
                    break;

            }
            nCol = nSavecol;
            nRow = nSaverow - 1;
            if (nRow == 0)
            {
                nRow = 10;
            }
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 8:
                    nSame = 1;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 11:
                    nSame = 1;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 12:
                    nSame = 1;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 14:
                    nSame = 1;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 16:
                    nSame = 1;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 17:
                    nSame = 1;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 18:
                    nSame = 1;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
            }
            nCol = nSavecol + 1;
            nRow = nSaverow;
            if (nCol == 11)
            {
                nCol = 1;
            }
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 9:
                    nSame = 2;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 12:
                    nSame = 2;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 13:
                    nSame = 2;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 15:
                    nSame = 2;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 17:
                    nSame = 2;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 18:
                    nSame = 2;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 19:
                    nSame = 2;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
            }

            nCol = nSavecol;
            nRow = nSaverow + 1;
            if (nRow == 11)
            {
                nRow = 1;
            }
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 6:
                    nSame = 3;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 10:
                    nSame = 3;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 13:
                    nSame = 3;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 14:
                    nSame = 3;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 16:
                    nSame = 3;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 18:
                    nSame = 3;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 19:
                    nSame = 3;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
            }
            nCol = nSavecol - 1;
            nRow = nSaverow;
            if (nCol == 0)
            {
                nCol = 10;
            }
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 7:
                    nSame = 4;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 10:
                    nSame = 4;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 11:
                    nSame = 4;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 15:
                    nSame = 4;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 16:
                    nSame = 4;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 17:
                    nSame = 4;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 19:
                    nSame = 4;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
            }
            sCode = sCode.Substring(0, nNew - 1) + "1" + sCode.Substring(nNew, 4 - nNew);

            switch (sCode)
            {
                case "1000":
                    nType = 6;
                    break;
                case "0100":
                    nType = 7;
                    break;
                case "0010":
                    nType = 8;
                    break;
                case "0001":
                    nType = 9;
                    break;
                case "1100":
                    nType = 10;
                    break;
                case "0110":
                    nType = 11;
                    break;
                case "0011":
                    nType = 12;
                    break;
                case "1001":
                    nType = 13;
                    break;
                case "1010":
                    nType = 14;
                    break;
                case "0101":
                    nType = 15;
                    break;
                case "1110":
                    nType = 16;
                    break;
                case "0111":
                    nType = 17;
                    break;
                case "1011":
                    nType = 18;
                    break;
                case "1101":
                    nType = 19;
                    break;
                case "1111":
                    switch (nCol)
                    {
                        case 1:
                            nType=_type1[nRow - 1];
                            break;
                        case 2:
                            nType = _type2[nRow - 1];
                            break;
                        case 3:
                            nType = _type3[nRow - 1];
                            break;
                        case 4:
                            nType = _type4[nRow - 1];
                            break;
                        case 5:
                            nType = _type5[nRow - 1];
                            break;
                        case 6:
                            nType = _type6[nRow - 1];
                            break;
                        case 7:
                            nType = _type7[nRow - 1];
                            break;
                        case 8:
                            nType = _type8[nRow - 1];
                            break;
                        case 9:
                            nType = _type9[nRow - 1];
                            break;
                        default:
                            nType = _typea[nRow - 1];
                            break;
                    }
                    switch (nType)
                    {
                        case 3:
                            mnOil+=1;
                            break;
                        case 4:
                            mnDam +=1;
                            break;
                        case 5:
                            mnFactory+=1;
                            break;
                    }
                    break;
            }
            nCol = _HolderACol[3];
            nRow = _HolderARow[3];
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
                case 8:
                    _col8[nRow - 1] = nType;
                    break;
                case 9:
                    _col9[nRow - 1] = nType;
                    break;
                default:
                    _cola[nRow - 1] = nType;
                    break;
            }
            switch (nType)
            {
                case 1:
                    picAcross4.Image = picture1.Image;
                    break;
                case 2:
                    picAcross4.Image = picture2.Image;
                    break;
                case 3:
                    picAcross4.Image = picture3.Image;
                    break;
                case 4:
                    picAcross4.Image = picture4.Image;
                    break;
                case 5:
                    picAcross4.Image = picture5.Image;
                    break;
                case 6:
                    picAcross4.Image = picture6.Image;
                    break;
                case 7:
                    picAcross4.Image = picture7.Image;
                    break;
                case 8:
                    picAcross4.Image = picture8.Image;
                    break;
                case 9:
                    picAcross4.Image = picture9.Image;
                    break;
                case 10:
                    picAcross4.Image = picture10.Image;
                    break;
                case 11:
                    picAcross4.Image = picture11.Image;
                    break;
                case 12:
                    picAcross4.Image = picture12.Image;
                    break;
                case 13:
                    picAcross4.Image = picture13.Image;
                    break;
                case 14:
                    picAcross4.Image = picture14.Image;
                    break;
                case 15:
                    picAcross4.Image = picture15.Image;
                    break;
                case 16:
                    picAcross4.Image = picture16.Image;
                    break;
                case 17:
                    picAcross4.Image = picture17.Image;
                    break;
                case 18:
                    picAcross4.Image = picture18.Image;
                    break;
                case 19:
                    picAcross4.Image = picture19.Image;
                    break;
                default:
                    picAcross4.Image = picture20.Image;
                    break;
            }
            if (lst1.Items.Count > 0)
            {

                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }
            sWord = "Oil = " + Convert.ToString(mnOil);
            lst1.Items.Add(sWord);
            sWord = "Dam = " + Convert.ToString(mnDam);
            lst1.Items.Add(sWord);
            sWord = "Factory = " + Convert.ToString(mnFactory);
            lst1.Items.Add(sWord);

            bool bEnded = false;

            if (mnOil == 5)
            {
                bEnded = true;
            }
            else
            {
                if (mnDam == 5)
                {
                    bEnded = true;
                }
                else
                {
                    if (mnFactory == 5)
                    {
                        bEnded = true;
                    }
                }
            }
            if (bEnded == true)
            {
                nScore += 10;
                lblScore.Text = "Score = " + Convert.ToString(nScore);
                MessageBox.Show("You've won", "GameEnded");
            }
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            int nCol, nRow, nType;
            int nSavecol, nSaverow;
            String sCode = null;
            int nNew = 2;
            int nSame;
            String sWord;

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F blank.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F Exit.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F found1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F found2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F found3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F type11.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F type12.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F type13.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F type14.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F type21.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F type22.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F type23.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"F type24.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"F type25.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"F type26.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"F type31.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
                Image = Image.FromFile(@"F type32.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture18 = new PictureBox
            {
                Name = "pictureBox18",
                Image = Image.FromFile(@"F type33.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture19 = new PictureBox
            {
                Name = "pictureBox19",
                Image = Image.FromFile(@"F type34.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture20 = new PictureBox
            {
                Name = "pictureBox20",
                Image = Image.FromFile(@"F Nullgate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nCol = _HolderACol[3];
            nRow = _HolderARow[3];
            nSavecol = nCol;
            nSaverow = nRow;
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 3:
                    return;
                case 4:
                    return;
                case 5:
                    return;
                case 6:
                    sCode = "1000";
                    break;
                case 7:
                    sCode = "0100";
                    break;
                case 8:
                    sCode = "0010";
                    break;
                case 9:
                    sCode = "0001";
                    break;
                case 10:
                    sCode = "1100";
                    break;
                case 11:
                    sCode = "0110";
                    break;
                case 12:
                    sCode = "0011";
                    break;
                case 13:
                    sCode = "1001";
                    break;
                case 14:
                    sCode = "1010";
                    break;
                case 15:
                    sCode = "0101";
                    break;
                case 16:
                    sCode = "1110";
                    break;
                case 17:
                    sCode = "0111";
                    break;
                case 18:
                    sCode = "1011";
                    break;
                case 19:
                    sCode = "1101";
                    break;

            }
            nCol = nSavecol;
            nRow = nSaverow - 1;
            if (nRow == 0)
            {
                nRow = 10;
            }
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 8:
                    nSame = 1;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 11:
                    nSame = 1;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 12:
                    nSame = 1;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 14:
                    nSame = 1;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 16:
                    nSame = 1;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 17:
                    nSame = 1;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 18:
                    nSame = 1;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
            }
            nCol = nSavecol + 1;
            nRow = nSaverow;
            if (nCol == 11)
            {
                nCol = 1;
            }
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 9:
                    nSame = 2;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 12:
                    nSame = 2;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 13:
                    nSame = 2;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 15:
                    nSame = 2;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 17:
                    nSame = 2;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 18:
                    nSame = 2;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 19:
                    nSame = 2;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
            }

            nCol = nSavecol;
            nRow = nSaverow + 1;
            if (nRow == 11)
            {
                nRow = 1;
            }
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 6:
                    nSame = 3;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 10:
                    nSame = 3;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 13:
                    nSame = 3;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 14:
                    nSame = 3;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 16:
                    nSame = 3;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 18:
                    nSame = 3;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 19:
                    nSame = 3;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
            }
            nCol = nSavecol - 1;
            nRow = nSaverow;
            if (nCol == 0)
            {
                nCol = 10;
            }
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 7:
                    nSame = 4;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 10:
                    nSame = 4;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 11:
                    nSame = 4;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 15:
                    nSame = 4;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 16:
                    nSame = 4;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 17:
                    nSame = 4;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 19:
                    nSame = 4;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
            }
            sCode = sCode.Substring(0, nNew - 1) + "1" + sCode.Substring(nNew, 4 - nNew);

            switch (sCode)
            {
                case "1000":
                    nType = 6;
                    break;
                case "0100":
                    nType = 7;
                    break;
                case "0010":
                    nType = 8;
                    break;
                case "0001":
                    nType = 9;
                    break;
                case "1100":
                    nType = 10;
                    break;
                case "0110":
                    nType = 11;
                    break;
                case "0011":
                    nType = 12;
                    break;
                case "1001":
                    nType = 13;
                    break;
                case "1010":
                    nType = 14;
                    break;
                case "0101":
                    nType = 15;
                    break;
                case "1110":
                    nType = 16;
                    break;
                case "0111":
                    nType = 17;
                    break;
                case "1011":
                    nType = 18;
                    break;
                case "1101":
                    nType = 19;
                    break;
                case "1111":
                    switch (nCol)
                    {
                        case 1:
                            nType = _type1[nRow - 1];
                            break;
                        case 2:
                            nType = _type2[nRow - 1];
                            break;
                        case 3:
                            nType = _type3[nRow - 1];
                            break;
                        case 4:
                            nType = _type4[nRow - 1];
                            break;
                        case 5:
                            nType = _type5[nRow - 1];
                            break;
                        case 6:
                            nType = _type6[nRow - 1];
                            break;
                        case 7:
                            nType = _type7[nRow - 1];
                            break;
                        case 8:
                            nType = _type8[nRow - 1];
                            break;
                        case 9:
                            nType = _type9[nRow - 1];
                            break;
                        default:
                            nType = _typea[nRow - 1];
                            break;
                    }
                    switch (nType)
                    {
                        case 3:
                            mnOil =+1;
                            break;
                        case 4:
                            mnDam +=1;
                            break;
                        case 5:
                            mnFactory +=1;
                            break;
                    }
                    break;
            }
            nCol = _HolderACol[3];
            nRow = _HolderARow[3];
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
                case 8:
                    _col8[nRow - 1] = nType;
                    break;
                case 9:
                    _col9[nRow - 1] = nType;
                    break;
                default:
                    _cola[nRow - 1] = nType;
                    break;
            }
            switch (nType)
            {
                case 1:
                    picAcross4.Image = picture1.Image;
                    break;
                case 2:
                    picAcross4.Image = picture2.Image;
                    break;
                case 3:
                    picAcross4.Image = picture3.Image;
                    break;
                case 4:
                    picAcross4.Image = picture4.Image;
                    break;
                case 5:
                    picAcross4.Image = picture5.Image;
                    break;
                case 6:
                    picAcross4.Image = picture6.Image;
                    break;
                case 7:
                    picAcross4.Image = picture7.Image;
                    break;
                case 8:
                    picAcross4.Image = picture8.Image;
                    break;
                case 9:
                    picAcross4.Image = picture9.Image;
                    break;
                case 10:
                    picAcross4.Image = picture10.Image;
                    break;
                case 11:
                    picAcross4.Image = picture11.Image;
                    break;
                case 12:
                    picAcross4.Image = picture12.Image;
                    break;
                case 13:
                    picAcross4.Image = picture13.Image;
                    break;
                case 14:
                    picAcross4.Image = picture14.Image;
                    break;
                case 15:
                    picAcross4.Image = picture15.Image;
                    break;
                case 16:
                    picAcross4.Image = picture16.Image;
                    break;
                case 17:
                    picAcross4.Image = picture17.Image;
                    break;
                case 18:
                    picAcross4.Image = picture18.Image;
                    break;
                case 19:
                    picAcross4.Image = picture19.Image;
                    break;
                default:
                    picAcross4.Image = picture20.Image;
                    break;
            }

            if (lst1.Items.Count > 0)
            {

                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }
            sWord = "Oil = " + Convert.ToString(mnOil);
            lst1.Items.Add(sWord);
            sWord = "Dam = " + Convert.ToString(mnDam);
            lst1.Items.Add(sWord);
            sWord = "Factory = " + Convert.ToString(mnFactory);
            lst1.Items.Add(sWord);


            bool bEnded = false;

            if (mnOil == 5)
            {
                bEnded = true;
            }
            else
            {
                if (mnDam == 5)
                {
                    bEnded = true;
                }
                else
                {
                    if (mnFactory == 5)
                    {
                        bEnded = true;
                    }
                }
            }
            if (bEnded == true)
            {
                nScore += 10;
                lblScore.Text = "Score = " + Convert.ToString(nScore);
                MessageBox.Show("You've won", "GameEnded");
            }
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nCol, nRow, nType;
            String sWord;

            mnOil = 0;
            mnDam = 0;
            mnFactory = 0;

            CounterCol = rnd1.Next(1, 11);
            CounterRow = rnd1.Next(1, 11);
            CounterDirection = rnd1.Next(1, 5);
            for (int i = 1; i <= 10; i++)
            {
                _col1[i - 1] = rnd1.Next(6, 16);
                _col2[i - 1] = rnd1.Next(6, 16);
                _col3[i - 1] = rnd1.Next(6, 16);
                _col4[i - 1] = rnd1.Next(6, 16);
                _col5[i - 1] = rnd1.Next(6, 16);
                _col6[i - 1] = rnd1.Next(6, 16);
                _col7[i - 1] = rnd1.Next(6, 16);
                _col8[i - 1] = rnd1.Next(6, 16);
                _col9[i - 1] = rnd1.Next(6, 16);
                _cola[i - 1] = rnd1.Next(6, 16);
            }
            for (int i = 1; i <= 10; i++)
            {
                _type1[i - 1] = rnd1.Next(3, 6);
                _type2[i - 1] = rnd1.Next(3, 6);
                _type3[i - 1] = rnd1.Next(3, 6);
                _type4[i - 1] = rnd1.Next(3, 6);
                _type5[i - 1] = rnd1.Next(3, 6);
                _type6[i - 1] = rnd1.Next(3, 6);
                _type7[i - 1] = rnd1.Next(3, 6);
                _type8[i - 1] = rnd1.Next(3, 6);
                _type9[i - 1] = rnd1.Next(3, 6);
                _typea[i - 1] = rnd1.Next(3, 6);
            }

            switch (CounterDirection)
            {
                case 1:
                    _HolderACol[0] = CounterCol - 3;
                    if (_HolderACol[0] < 1)
                    {
                        _HolderACol[0] = _HolderACol[0] + 10;
                    }
                    _HolderARow[0] = CounterRow;
                    _HolderACol[1] = CounterCol - 2;
                    if (_HolderACol[1] < 1)
                    {
                        _HolderACol[1] = _HolderACol[1] + 10;
                    }
                    _HolderARow[1] = CounterRow;
                    _HolderACol[2] = CounterCol - 1;
                    if (_HolderACol[2] < 1)
                    {
                        _HolderACol[2] = _HolderACol[2] + 10;
                    }
                    _HolderARow[2] = CounterRow;
                    _HolderACol[3] = CounterCol;
                    _HolderARow[3] = CounterRow;
                    _HolderACol[4] = CounterCol + 1;
                    if (_HolderACol[4] > 10)
                    {
                        _HolderACol[4] = _HolderACol[4] - 10;
                    }
                    _HolderARow[4] = CounterRow;
                    _HolderACol[5] = CounterCol + 2;
                    if (_HolderACol[5] > 10)
                    {
                        _HolderACol[5] = _HolderACol[5] - 10;
                    }
                    _HolderARow[5] = CounterRow;
                    _HolderACol[6] = CounterCol + 3;
                    if (_HolderACol[6] > 10)
                    {
                        _HolderACol[6] = _HolderACol[6] - 10;
                    }
                    _HolderARow[6] = CounterRow;
                    _HolderFCol[0] = CounterCol;
                    _HolderFRow[0] = CounterRow - 3;
                    if (_HolderFRow[0] < 1)
                    {
                        _HolderFRow[0] = _HolderFRow[0] + 10;
                    }
                    _HolderFCol[1] = CounterCol;
                    _HolderFRow[1] = CounterRow - 2;
                    if (_HolderFRow[1] < 1)
                    {
                        _HolderFRow[1] = _HolderFRow[1] + 10;
                    }
                    _HolderFCol[2] = CounterCol;
                    _HolderFRow[2] = CounterRow - 1;
                    if (_HolderFRow[2] < 1)
                    {
                        _HolderFRow[2] = _HolderFRow[2] + 10;
                    }

                    break;
                case 2:
                    _HolderACol[0] = CounterCol;
                    _HolderARow[0] = CounterRow - 3;
                    if (_HolderARow[0] < 1)
                    {
                        _HolderARow[0] = _HolderARow[0] + 10;
                    }
                    _HolderACol[1] = CounterCol;
                    _HolderARow[1] = CounterRow - 2;
                    if (_HolderARow[1] < 1)
                    {
                        _HolderARow[1] = _HolderARow[1] + 10;
                    }
                    _HolderACol[2] = CounterCol;
                    _HolderARow[2] = CounterRow - 1;
                    if (_HolderARow[2] < 1)
                    {
                        _HolderARow[2] = _HolderARow[2] + 10;
                    }
                    _HolderACol[3] = CounterCol;
                    _HolderARow[3] = CounterRow;
                    _HolderACol[4] = CounterCol;
                    _HolderARow[4] = CounterRow + 1;
                    if (_HolderARow[4] > 10)
                    {
                        _HolderARow[4] = _HolderARow[4] - 10;
                    }
                    _HolderACol[5] = CounterCol;
                    _HolderARow[5] = CounterRow + 2;
                    if (_HolderARow[5] > 10)
                    {
                        _HolderARow[5] = _HolderARow[5] - 10;
                    }
                    _HolderACol[6] = CounterCol;
                    _HolderARow[6] = CounterRow + 3;
                    if (_HolderARow[6] > 10)
                    {
                        _HolderARow[6] = _HolderARow[6] - 10;
                    }
                    _HolderFCol[0] = CounterCol + 3;
                    if (_HolderFCol[0] > 10)
                    {
                        _HolderFCol[0] = _HolderFCol[0] - 10;
                    }
                    _HolderFRow[0] = CounterRow;
                    _HolderFCol[1] = CounterCol + 2;
                    if (_HolderFCol[1] > 10)
                    {
                        _HolderFCol[1] = _HolderFCol[1] - 10;
                    }
                    _HolderFRow[1] = CounterRow;
                    _HolderFCol[2] = CounterCol + 1;
                    if (_HolderFCol[2] > 10)
                    {
                        _HolderFCol[2] = _HolderFCol[2] - 10;
                    }
                    _HolderFRow[2] = CounterRow;

                    break;
                case 3:
                    _HolderACol[0] = CounterCol + 3;
                    if (_HolderACol[0] > 10)
                    {
                        _HolderACol[0] = _HolderACol[0] - 10;
                    }
                    _HolderARow[0] = CounterRow;
                    _HolderACol[1] = CounterCol + 2;
                    if (_HolderACol[1] > 10)
                    {
                        _HolderACol[1] = _HolderACol[1] - 10;
                    }
                    _HolderARow[1] = CounterRow;
                    _HolderACol[2] = CounterCol + 1;
                    if (_HolderACol[2] > 10)
                    {
                        _HolderACol[2] = _HolderACol[2] - 10;
                    }
                    _HolderARow[2] = CounterRow;
                    _HolderACol[3] = CounterCol;
                    _HolderARow[3] = CounterRow;
                    _HolderACol[4] = CounterCol - 1;
                    if (_HolderACol[4] < 1)
                    {
                        _HolderACol[4] = _HolderACol[4] + 10;
                    }
                    _HolderARow[4] = CounterRow;
                    _HolderACol[5] = CounterCol - 2;
                    if (_HolderACol[5] < 2)
                    {
                        _HolderACol[5] = _HolderACol[5] + 10;
                    }
                    _HolderARow[5] = CounterRow;
                    _HolderACol[6] = CounterCol - 3;
                    if (_HolderACol[6] < 3)
                    {
                        _HolderACol[6] = _HolderACol[6] + 10;
                    }
                    _HolderARow[6] = CounterRow;
                    _HolderFCol[0] = CounterCol;
                    _HolderFRow[0] = CounterRow + 3;
                    if (_HolderFRow[0] > 10)
                    {
                        _HolderFRow[0] = _HolderFRow[0] - 10;
                    }
                    _HolderFCol[1] = CounterCol;
                    _HolderFRow[1] = CounterRow + 2;
                    if (_HolderFRow[1] > 10)
                    {
                        _HolderFRow[1] = _HolderFRow[1] - 10;
                    }
                    _HolderFCol[2] = CounterCol;
                    _HolderFRow[2] = CounterRow + 1;
                    if (_HolderFRow[2] > 10)
                    {
                        _HolderFRow[2] = _HolderFRow[2] - 10;
                    }

                    break;
                default:
                    _HolderACol[0] = CounterCol;
                    _HolderARow[0] = CounterRow + 3;
                    if (_HolderARow[0] > 10)
                    {
                        _HolderARow[0] = _HolderARow[0] - 10;
                    }
                    _HolderACol[1] = CounterCol;
                    _HolderARow[1] = CounterRow + 2;
                    if (_HolderARow[1] > 10)
                    {
                        _HolderARow[1] = _HolderARow[1] - 10;
                    }
                    _HolderACol[2] = CounterCol;
                    _HolderARow[2] = CounterRow + 1;
                    if (_HolderARow[2] > 10)
                    {
                        _HolderARow[2] = _HolderARow[2] - 10;
                    }
                    _HolderACol[3] = CounterCol;
                    _HolderARow[3] = CounterRow;
                    _HolderACol[4] = CounterCol;
                    _HolderARow[4] = CounterRow - 1;
                    if (_HolderARow[4] < 1)
                    {
                        _HolderARow[4] = _HolderARow[4] + 10;
                    }
                    _HolderACol[5] = CounterCol;
                    _HolderARow[5] = CounterRow - 2;
                    if (_HolderARow[5] < 1)
                    {
                        _HolderARow[5] = _HolderARow[5] + 10;
                    }
                    _HolderACol[6] = CounterCol;
                    _HolderARow[6] = CounterRow - 3;
                    if (_HolderARow[6] < 1)
                    {
                        _HolderARow[6] = _HolderARow[6] + 10;
                    }
                    _HolderFCol[0] = CounterCol - 3;
                    if (_HolderFCol[0] < 1)
                    {
                        _HolderFCol[0] = _HolderFCol[0] + 10;
                    }
                    _HolderFRow[0] = CounterRow;
                    _HolderFCol[1] = CounterCol - 2;
                    if (_HolderFCol[1] < 1)
                    {
                        _HolderFCol[1] = _HolderFCol[1] + 10;
                    }
                    _HolderFRow[1] = CounterRow;
                    _HolderFCol[2] = CounterCol - 1;
                    if (_HolderFCol[2] < 1)
                    {
                        _HolderFCol[2] = _HolderFCol[2] + 10;
                    }
                    _HolderFRow[2] = CounterRow;

                    break;
            }
            lblLocation.Text = "Location = (" + Convert.ToString(CounterCol) + "," + Convert.ToString(CounterRow) + ")";
            switch (CounterDirection)
            {
                case 1:
                    lblDirection.Text = "Direction = (N)";
                    break;
                case 2:
                    lblDirection.Text = "Direction = (E)";
                    break;
                case 3:
                    lblDirection.Text = "Direction = (S)";
                    break;
                default:
                    lblDirection.Text = "Direction = (W)";
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F blank.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F Exit.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F found1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F found2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F found3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F type11.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F type12.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F type13.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F type14.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F type21.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F type22.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F type23.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"F type24.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"F type25.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"F type26.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"F type31.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
                Image = Image.FromFile(@"F type32.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture18 = new PictureBox
            {
                Name = "pictureBox18",
                Image = Image.FromFile(@"F type33.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture19 = new PictureBox
            {
                Name = "pictureBox19",
                Image = Image.FromFile(@"F type34.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture20 = new PictureBox
            {
                Name = "pictureBox20",
                Image = Image.FromFile(@"F Nullgate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nCol = _HolderACol[0];
            nRow = _HolderARow[0];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picAcross1.Image = picture1.Image;
                    break;
                case 2:
                    picAcross1.Image = picture2.Image;
                    break;
                case 3:
                    picAcross1.Image = picture3.Image;
                    break;
                case 4:
                    picAcross1.Image = picture4.Image;
                    break;
                case 5:
                    picAcross1.Image = picture5.Image;
                    break;
                case 6:
                    picAcross1.Image = picture6.Image;
                    break;
                case 7:
                    picAcross1.Image = picture7.Image;
                    break;
                case 8:
                    picAcross1.Image = picture8.Image;
                    break;
                case 9:
                    picAcross1.Image = picture9.Image;
                    break;
                case 10:
                    picAcross1.Image = picture10.Image;
                    break;
                case 11:
                    picAcross1.Image = picture11.Image;
                    break;
                case 12:
                    picAcross1.Image = picture12.Image;
                    break;
                case 13:
                    picAcross1.Image = picture13.Image;
                    break;
                case 14:
                    picAcross1.Image = picture14.Image;
                    break;
                case 15:
                    picAcross1.Image = picture15.Image;
                    break;
                case 16:
                    picAcross1.Image = picture16.Image;
                    break;
                case 17:
                    picAcross1.Image = picture17.Image;
                    break;
                case 18:
                    picAcross1.Image = picture18.Image;
                    break;
                case 19:
                    picAcross1.Image = picture19.Image;
                    break;
                default:
                    picAcross1.Image = picture20.Image;
                    break;
            }
            nCol = _HolderACol[1];
            nRow = _HolderARow[1];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picAcross2.Image = picture1.Image;
                    break;
                case 2:
                    picAcross2.Image = picture2.Image;
                    break;
                case 3:
                    picAcross2.Image = picture3.Image;
                    break;
                case 4:
                    picAcross2.Image = picture4.Image;
                    break;
                case 5:
                    picAcross2.Image = picture5.Image;
                    break;
                case 6:
                    picAcross2.Image = picture6.Image;
                    break;
                case 7:
                    picAcross2.Image = picture7.Image;
                    break;
                case 8:
                    picAcross2.Image = picture8.Image;
                    break;
                case 9:
                    picAcross2.Image = picture9.Image;
                    break;
                case 10:
                    picAcross2.Image = picture10.Image;
                    break;
                case 11:
                    picAcross2.Image = picture11.Image;
                    break;
                case 12:
                    picAcross2.Image = picture12.Image;
                    break;
                case 13:
                    picAcross2.Image = picture13.Image;
                    break;
                case 14:
                    picAcross2.Image = picture14.Image;
                    break;
                case 15:
                    picAcross2.Image = picture15.Image;
                    break;
                case 16:
                    picAcross2.Image = picture16.Image;
                    break;
                case 17:
                    picAcross2.Image = picture17.Image;
                    break;
                case 18:
                    picAcross2.Image = picture18.Image;
                    break;
                case 19:
                    picAcross2.Image = picture19.Image;
                    break;
                default:
                    picAcross2.Image = picture20.Image;
                    break;
            }
            nCol = _HolderACol[2];
            nRow = _HolderARow[2];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picAcross3.Image = picture1.Image;
                    break;
                case 2:
                    picAcross3.Image = picture2.Image;
                    break;
                case 3:
                    picAcross3.Image = picture3.Image;
                    break;
                case 4:
                    picAcross3.Image = picture4.Image;
                    break;
                case 5:
                    picAcross3.Image = picture5.Image;
                    break;
                case 6:
                    picAcross3.Image = picture6.Image;
                    break;
                case 7:
                    picAcross3.Image = picture7.Image;
                    break;
                case 8:
                    picAcross3.Image = picture8.Image;
                    break;
                case 9:
                    picAcross3.Image = picture9.Image;
                    break;
                case 10:
                    picAcross3.Image = picture10.Image;
                    break;
                case 11:
                    picAcross3.Image = picture11.Image;
                    break;
                case 12:
                    picAcross3.Image = picture12.Image;
                    break;
                case 13:
                    picAcross3.Image = picture13.Image;
                    break;
                case 14:
                    picAcross3.Image = picture14.Image;
                    break;
                case 15:
                    picAcross3.Image = picture15.Image;
                    break;
                case 16:
                    picAcross3.Image = picture16.Image;
                    break;
                case 17:
                    picAcross3.Image = picture17.Image;
                    break;
                case 18:
                    picAcross3.Image = picture18.Image;
                    break;
                case 19:
                    picAcross3.Image = picture19.Image;
                    break;
                default:
                    picAcross3.Image = picture20.Image;
                    break;
            }
            nCol = _HolderACol[3];
            nRow = _HolderARow[3];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picAcross4.Image = picture1.Image;
                    break;
                case 2:
                    picAcross4.Image = picture2.Image;
                    break;
                case 3:
                    picAcross4.Image = picture3.Image;
                    break;
                case 4:
                    picAcross4.Image = picture4.Image;
                    break;
                case 5:
                    picAcross4.Image = picture5.Image;
                    break;
                case 6:
                    picAcross4.Image = picture6.Image;
                    break;
                case 7:
                    picAcross4.Image = picture7.Image;
                    break;
                case 8:
                    picAcross4.Image = picture8.Image;
                    break;
                case 9:
                    picAcross4.Image = picture9.Image;
                    break;
                case 10:
                    picAcross4.Image = picture10.Image;
                    break;
                case 11:
                    picAcross4.Image = picture11.Image;
                    break;
                case 12:
                    picAcross4.Image = picture12.Image;
                    break;
                case 13:
                    picAcross4.Image = picture13.Image;
                    break;
                case 14:
                    picAcross4.Image = picture14.Image;
                    break;
                case 15:
                    picAcross4.Image = picture15.Image;
                    break;
                case 16:
                    picAcross4.Image = picture16.Image;
                    break;
                case 17:
                    picAcross4.Image = picture17.Image;
                    break;
                case 18:
                    picAcross4.Image = picture18.Image;
                    break;
                case 19:
                    picAcross4.Image = picture19.Image;
                    break;
                default:
                    picAcross4.Image = picture20.Image;
                    break;
            }
            nCol = _HolderACol[4];
            nRow = _HolderARow[4];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picAcross5.Image = picture1.Image;
                    break;
                case 2:
                    picAcross5.Image = picture2.Image;
                    break;
                case 3:
                    picAcross5.Image = picture3.Image;
                    break;
                case 4:
                    picAcross5.Image = picture4.Image;
                    break;
                case 5:
                    picAcross5.Image = picture5.Image;
                    break;
                case 6:
                    picAcross5.Image = picture6.Image;
                    break;
                case 7:
                    picAcross5.Image = picture7.Image;
                    break;
                case 8:
                    picAcross5.Image = picture8.Image;
                    break;
                case 9:
                    picAcross5.Image = picture9.Image;
                    break;
                case 10:
                    picAcross5.Image = picture10.Image;
                    break;
                case 11:
                    picAcross5.Image = picture11.Image;
                    break;
                case 12:
                    picAcross5.Image = picture12.Image;
                    break;
                case 13:
                    picAcross5.Image = picture13.Image;
                    break;
                case 14:
                    picAcross5.Image = picture14.Image;
                    break;
                case 15:
                    picAcross5.Image = picture15.Image;
                    break;
                case 16:
                    picAcross5.Image = picture16.Image;
                    break;
                case 17:
                    picAcross5.Image = picture17.Image;
                    break;
                case 18:
                    picAcross5.Image = picture18.Image;
                    break;
                case 19:
                    picAcross5.Image = picture19.Image;
                    break;
                default:
                    picAcross5.Image = picture20.Image;
                    break;
            }
            nCol = _HolderACol[5];
            nRow = _HolderARow[5];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picAcross6.Image = picture1.Image;
                    break;
                case 2:
                    picAcross6.Image = picture2.Image;
                    break;
                case 3:
                    picAcross6.Image = picture3.Image;
                    break;
                case 4:
                    picAcross6.Image = picture4.Image;
                    break;
                case 5:
                    picAcross6.Image = picture5.Image;
                    break;
                case 6:
                    picAcross6.Image = picture6.Image;
                    break;
                case 7:
                    picAcross6.Image = picture7.Image;
                    break;
                case 8:
                    picAcross6.Image = picture8.Image;
                    break;
                case 9:
                    picAcross6.Image = picture9.Image;
                    break;
                case 10:
                    picAcross6.Image = picture10.Image;
                    break;
                case 11:
                    picAcross6.Image = picture11.Image;
                    break;
                case 12:
                    picAcross6.Image = picture12.Image;
                    break;
                case 13:
                    picAcross6.Image = picture13.Image;
                    break;
                case 14:
                    picAcross6.Image = picture14.Image;
                    break;
                case 15:
                    picAcross6.Image = picture15.Image;
                    break;
                case 16:
                    picAcross6.Image = picture16.Image;
                    break;
                case 17:
                    picAcross6.Image = picture17.Image;
                    break;
                case 18:
                    picAcross6.Image = picture18.Image;
                    break;
                case 19:
                    picAcross6.Image = picture19.Image;
                    break;
                default:
                    picAcross6.Image = picture20.Image;
                    break;
            }
            nCol = _HolderACol[6];
            nRow = _HolderARow[6];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picAcross7.Image = picture1.Image;
                    break;
                case 2:
                    picAcross7.Image = picture2.Image;
                    break;
                case 3:
                    picAcross7.Image = picture3.Image;
                    break;
                case 4:
                    picAcross7.Image = picture4.Image;
                    break;
                case 5:
                    picAcross7.Image = picture5.Image;
                    break;
                case 6:
                    picAcross7.Image = picture6.Image;
                    break;
                case 7:
                    picAcross7.Image = picture7.Image;
                    break;
                case 8:
                    picAcross7.Image = picture8.Image;
                    break;
                case 9:
                    picAcross7.Image = picture9.Image;
                    break;
                case 10:
                    picAcross7.Image = picture10.Image;
                    break;
                case 11:
                    picAcross7.Image = picture11.Image;
                    break;
                case 12:
                    picAcross7.Image = picture12.Image;
                    break;
                case 13:
                    picAcross7.Image = picture13.Image;
                    break;
                case 14:
                    picAcross7.Image = picture14.Image;
                    break;
                case 15:
                    picAcross7.Image = picture15.Image;
                    break;
                case 16:
                    picAcross7.Image = picture16.Image;
                    break;
                case 17:
                    picAcross7.Image = picture17.Image;
                    break;
                case 18:
                    picAcross7.Image = picture18.Image;
                    break;
                case 19:
                    picAcross7.Image = picture19.Image;
                    break;
                default:
                    picAcross7.Image = picture20.Image;
                    break;
            }

            nCol = _HolderFCol[0];
            nRow = _HolderFRow[0];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picForward1.Image = picture1.Image;
                    break;
                case 2:
                    picForward1.Image = picture2.Image;
                    break;
                case 3:
                    picForward1.Image = picture3.Image;
                    break;
                case 4:
                    picForward1.Image = picture4.Image;
                    break;
                case 5:
                    picForward1.Image = picture5.Image;
                    break;
                case 6:
                    picForward1.Image = picture6.Image;
                    break;
                case 7:
                    picForward1.Image = picture7.Image;
                    break;
                case 8:
                    picForward1.Image = picture8.Image;
                    break;
                case 9:
                    picForward1.Image = picture9.Image;
                    break;
                case 10:
                    picForward1.Image = picture10.Image;
                    break;
                case 11:
                    picForward1.Image = picture11.Image;
                    break;
                case 12:
                    picForward1.Image = picture12.Image;
                    break;
                case 13:
                    picForward1.Image = picture13.Image;
                    break;
                case 14:
                    picForward1.Image = picture14.Image;
                    break;
                case 15:
                    picForward1.Image = picture15.Image;
                    break;
                case 16:
                    picForward1.Image = picture16.Image;
                    break;
                case 17:
                    picForward1.Image = picture17.Image;
                    break;
                case 18:
                    picForward1.Image = picture18.Image;
                    break;
                case 19:
                    picForward1.Image = picture19.Image;
                    break;
                default:
                    picForward1.Image = picture20.Image;
                    break;
            }
            nCol = _HolderFCol[1];
            nRow = _HolderFRow[1];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picForward2.Image = picture1.Image;
                    break;
                case 2:
                    picForward2.Image = picture2.Image;
                    break;
                case 3:
                    picForward2.Image = picture3.Image;
                    break;
                case 4:
                    picForward2.Image = picture4.Image;
                    break;
                case 5:
                    picForward2.Image = picture5.Image;
                    break;
                case 6:
                    picForward2.Image = picture6.Image;
                    break;
                case 7:
                    picForward2.Image = picture7.Image;
                    break;
                case 8:
                    picForward2.Image = picture8.Image;
                    break;
                case 9:
                    picForward2.Image = picture9.Image;
                    break;
                case 10:
                    picForward2.Image = picture10.Image;
                    break;
                case 11:
                    picForward2.Image = picture11.Image;
                    break;
                case 12:
                    picForward2.Image = picture12.Image;
                    break;
                case 13:
                    picForward2.Image = picture13.Image;
                    break;
                case 14:
                    picForward2.Image = picture14.Image;
                    break;
                case 15:
                    picForward2.Image = picture15.Image;
                    break;
                case 16:
                    picForward2.Image = picture16.Image;
                    break;
                case 17:
                    picForward2.Image = picture17.Image;
                    break;
                case 18:
                    picForward2.Image = picture18.Image;
                    break;
                case 19:
                    picForward2.Image = picture19.Image;
                    break;
                default:
                    picForward2.Image = picture20.Image;
                    break;
            }
            nCol = _HolderFCol[2];
            nRow = _HolderFRow[2];
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 1:
                    picForward3.Image = picture1.Image;
                    break;
                case 2:
                    picForward3.Image = picture2.Image;
                    break;
                case 3:
                    picForward3.Image = picture3.Image;
                    break;
                case 4:
                    picForward3.Image = picture4.Image;
                    break;
                case 5:
                    picForward3.Image = picture5.Image;
                    break;
                case 6:
                    picForward3.Image = picture6.Image;
                    break;
                case 7:
                    picForward3.Image = picture7.Image;
                    break;
                case 8:
                    picForward3.Image = picture8.Image;
                    break;
                case 9:
                    picForward3.Image = picture9.Image;
                    break;
                case 10:
                    picForward3.Image = picture10.Image;
                    break;
                case 11:
                    picForward3.Image = picture11.Image;
                    break;
                case 12:
                    picForward3.Image = picture12.Image;
                    break;
                case 13:
                    picForward3.Image = picture13.Image;
                    break;
                case 14:
                    picForward3.Image = picture14.Image;
                    break;
                case 15:
                    picForward3.Image = picture15.Image;
                    break;
                case 16:
                    picForward3.Image = picture16.Image;
                    break;
                case 17:
                    picForward3.Image = picture17.Image;
                    break;
                case 18:
                    picForward3.Image = picture18.Image;
                    break;
                case 19:
                    picForward3.Image = picture19.Image;
                    break;
                default:
                    picForward3.Image = picture20.Image;
                    break;
            }

            if (lst1.Items.Count > 0)
            {

                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }
            sWord = "Oil = " + Convert.ToString(mnOil);
            lst1.Items.Add(sWord);
            sWord = "Dam = " + Convert.ToString(mnDam);
            lst1.Items.Add(sWord);
            sWord = "Factory = " + Convert.ToString(mnFactory);
            lst1.Items.Add(sWord);

        

    }

    private void btnAdd3_Click(object sender, EventArgs e)
        {
            int nCol, nRow, nType;
            int nSavecol, nSaverow;
            String sCode = null;
            int nNew = 3;
            int nSame;
            String sWord;

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F blank.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F Exit.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F found1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F found2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F found3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F type11.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F type12.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F type13.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F type14.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F type21.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F type22.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F type23.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"F type24.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"F type25.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"F type26.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"F type31.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
                Image = Image.FromFile(@"F type32.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture18 = new PictureBox
            {
                Name = "pictureBox18",
                Image = Image.FromFile(@"F type33.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture19 = new PictureBox
            {
                Name = "pictureBox19",
                Image = Image.FromFile(@"F type34.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture20 = new PictureBox
            {
                Name = "pictureBox20",
                Image = Image.FromFile(@"F Nullgate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nCol = _HolderACol[3];
            nRow = _HolderARow[3];
            nSavecol = nCol;
            nSaverow = nRow;
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 3:
                    return;
                case 4:
                    return;
                case 5:
                    return;
                case 6:
                    sCode = "1000";
                    break;
                case 7:
                    sCode = "0100";
                    break;
                case 8:
                    sCode = "0010";
                    break;
                case 9:
                    sCode = "0001";
                    break;
                case 10:
                    sCode = "1100";
                    break;
                case 11:
                    sCode = "0110";
                    break;
                case 12:
                    sCode = "0011";
                    break;
                case 13:
                    sCode = "1001";
                    break;
                case 14:
                    sCode = "1010";
                    break;
                case 15:
                    sCode = "0101";
                    break;
                case 16:
                    sCode = "1110";
                    break;
                case 17:
                    sCode = "0111";
                    break;
                case 18:
                    sCode = "1011";
                    break;
                case 19:
                    sCode = "1101";
                    break;

            }
            nCol = nSavecol;
            nRow = nSaverow - 1;
            if (nRow == 0)
            {
                nRow = 10;
            }
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 8:
                    nSame = 1;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 11:
                    nSame = 1;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 12:
                    nSame = 1;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 14:
                    nSame = 1;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 16:
                    nSame = 1;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 17:
                    nSame = 1;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 18:
                    nSame = 1;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
            }
            nCol = nSavecol + 1;
            nRow = nSaverow;
            if (nCol == 11)
            {
                nCol = 1;
            }
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 9:
                    nSame = 2;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 12:
                    nSame = 2;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 13:
                    nSame = 2;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 15:
                    nSame = 2;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 17:
                    nSame = 2;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 18:
                    nSame = 2;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 19:
                    nSame = 2;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
            }

            nCol = nSavecol;
            nRow = nSaverow + 1;
            if (nRow == 11)
            {
                nRow = 1;
            }
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 6:
                    nSame = 3;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 10:
                    nSame = 3;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 13:
                    nSame = 3;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 14:
                    nSame = 3;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 16:
                    nSame = 3;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 18:
                    nSame = 3;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 19:
                    nSame = 3;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
            }
            nCol = nSavecol - 1;
            nRow = nSaverow;
            if (nCol == 0)
            {
                nCol = 10;
            }
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 7:
                    nSame = 4;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 10:
                    nSame = 4;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 11:
                    nSame = 4;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 15:
                    nSame = 4;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 16:
                    nSame = 4;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 17:
                    nSame = 4;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 19:
                    nSame = 4;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
            }
            sCode = sCode.Substring(0, nNew - 1) + "1" + sCode.Substring(nNew, 4 - nNew);

            switch (sCode)
            {
                case "1000":
                    nType = 6;
                    break;
                case "0100":
                    nType = 7;
                    break;
                case "0010":
                    nType = 8;
                    break;
                case "0001":
                    nType = 9;
                    break;
                case "1100":
                    nType = 10;
                    break;
                case "0110":
                    nType = 11;
                    break;
                case "0011":
                    nType = 12;
                    break;
                case "1001":
                    nType = 13;
                    break;
                case "1010":
                    nType = 14;
                    break;
                case "0101":
                    nType = 15;
                    break;
                case "1110":
                    nType = 16;
                    break;
                case "0111":
                    nType = 17;
                    break;
                case "1011":
                    nType = 18;
                    break;
                case "1101":
                    nType = 19;
                    break;
                case "1111":
                    switch (nCol)
                    {
                        case 1:
                            nType = _type1[nRow - 1];
                            break;
                        case 2:
                            nType = _type2[nRow - 1];
                            break;
                        case 3:
                            nType = _type3[nRow - 1];
                            break;
                        case 4:
                            nType = _type4[nRow - 1];
                            break;
                        case 5:
                            nType = _type5[nRow - 1];
                            break;
                        case 6:
                            nType = _type6[nRow - 1];
                            break;
                        case 7:
                            nType = _type7[nRow - 1];
                            break;
                        case 8:
                            nType = _type8[nRow - 1];
                            break;
                        case 9:
                            nType = _type9[nRow - 1];
                            break;
                        default:
                            nType = _typea[nRow - 1];
                            break;
                    }
                    switch (nType)
                    {
                        case 3:
                            mnOil+=1;
                            break;
                        case 4:
                            mnDam +=1;
                            break;
                        case 5:
                            mnFactory +=1;
                            break;
                    }
                    break;
            }
            nCol = _HolderACol[3];
            nRow = _HolderARow[3];
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
                case 8:
                    _col8[nRow - 1] = nType;
                    break;
                case 9:
                    _col9[nRow - 1] = nType;
                    break;
                default:
                    _cola[nRow - 1] = nType;
                    break;
            }
            switch (nType)
            {
                case 1:
                    picAcross4.Image = picture1.Image;
                    break;
                case 2:
                    picAcross4.Image = picture2.Image;
                    break;
                case 3:
                    picAcross4.Image = picture3.Image;
                    break;
                case 4:
                    picAcross4.Image = picture4.Image;
                    break;
                case 5:
                    picAcross4.Image = picture5.Image;
                    break;
                case 6:
                    picAcross4.Image = picture6.Image;
                    break;
                case 7:
                    picAcross4.Image = picture7.Image;
                    break;
                case 8:
                    picAcross4.Image = picture8.Image;
                    break;
                case 9:
                    picAcross4.Image = picture9.Image;
                    break;
                case 10:
                    picAcross4.Image = picture10.Image;
                    break;
                case 11:
                    picAcross4.Image = picture11.Image;
                    break;
                case 12:
                    picAcross4.Image = picture12.Image;
                    break;
                case 13:
                    picAcross4.Image = picture13.Image;
                    break;
                case 14:
                    picAcross4.Image = picture14.Image;
                    break;
                case 15:
                    picAcross4.Image = picture15.Image;
                    break;
                case 16:
                    picAcross4.Image = picture16.Image;
                    break;
                case 17:
                    picAcross4.Image = picture17.Image;
                    break;
                case 18:
                    picAcross4.Image = picture18.Image;
                    break;
                case 19:
                    picAcross4.Image = picture19.Image;
                    break;
                default:
                    picAcross4.Image = picture20.Image;
                    break;
            }

            if (lst1.Items.Count > 0)
            {

                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }
            sWord = "Oil = " + Convert.ToString(mnOil);
            lst1.Items.Add(sWord);
            sWord = "Dam = " + Convert.ToString(mnDam);
            lst1.Items.Add(sWord);
            sWord = "Factory = " + Convert.ToString(mnFactory);
            lst1.Items.Add(sWord);

            bool bEnded = false;

            if (mnOil == 5)
            {
                bEnded = true;
            }
            else
            {
                if (mnDam == 5)
                {
                    bEnded = true;
                }
                else
                {
                    if (mnFactory == 5)
                    {
                        bEnded = true;
                    }
                }
            }
            if (bEnded == true)
            {
                nScore += 10;
                lblScore.Text = "Score = " + Convert.ToString(nScore);
                MessageBox.Show("You've won", "GameEnded");
            }
        }

        private void btnAdd4_Click(object sender, EventArgs e)
        {
            int nCol, nRow, nType;
            int nSavecol, nSaverow;
            String sCode = null;
            int nNew = 4;
            int nSame;
            String sWord;

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F blank.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F Exit.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F found1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F found2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F found3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F type11.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F type12.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F type13.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F type14.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F type21.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F type22.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F type23.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"F type24.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"F type25.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"F type26.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"F type31.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
                Image = Image.FromFile(@"F type32.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture18 = new PictureBox
            {
                Name = "pictureBox18",
                Image = Image.FromFile(@"F type33.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture19 = new PictureBox
            {
                Name = "pictureBox19",
                Image = Image.FromFile(@"F type34.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture20 = new PictureBox
            {
                Name = "pictureBox20",
                Image = Image.FromFile(@"F Nullgate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nCol = _HolderACol[3];
            nRow = _HolderARow[3];
            nSavecol = nCol;
            nSaverow = nRow;
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 3:
                    return;
                case 4:
                    return;
                case 5:
                    return;
                case 6:
                    sCode = "1000";
                    break;
                case 7:
                    sCode = "0100";
                    break;
                case 8:
                    sCode = "0010";
                    break;
                case 9:
                    sCode = "0001";
                    break;
                case 10:
                    sCode = "1100";
                    break;
                case 11:
                    sCode = "0110";
                    break;
                case 12:
                    sCode = "0011";
                    break;
                case 13:
                    sCode = "1001";
                    break;
                case 14:
                    sCode = "1010";
                    break;
                case 15:
                    sCode = "0101";
                    break;
                case 16:
                    sCode = "1110";
                    break;
                case 17:
                    sCode = "0111";
                    break;
                case 18:
                    sCode = "1011";
                    break;
                case 19:
                    sCode = "1101";
                    break;
           
           }
            nCol = nSavecol;
            nRow = nSaverow - 1;
            if (nRow == 0)
            {
                nRow = 10;
            }
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 8:
                    nSame = 1;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 11:
                    nSame = 1;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 12:
                    nSame = 1;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 14:
                    nSame = 1;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 16:
                    nSame = 1;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 17:
                    nSame = 1;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 18:
                    nSame = 1;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
            }
            nCol = nSavecol + 1;
            nRow = nSaverow;
            if (nCol == 11)
            {
                nCol = 1;
            }
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 9:
                    nSame = 2;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 12:
                    nSame = 2;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 13:
                    nSame = 2;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 15:
                    nSame = 2;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 17:
                    nSame = 2;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 18:
                    nSame = 2;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 19:
                    nSame = 2;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
            }

            nCol = nSavecol;
            nRow = nSaverow + 1;
            if (nRow == 11)
            {
                nRow = 1;
            }
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 6:
                    nSame = 3;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 10:
                    nSame = 3;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 13:
                    nSame = 3;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 14:
                    nSame = 3;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 16:
                    nSame = 3;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 18:
                    nSame = 3;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 19:
                    nSame = 3;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
            }
            nCol = nSavecol - 1;
            nRow = nSaverow;
            if (nCol == 0)
            {
                nCol = 10;
            }
            switch (nCol)
            {
                case 1:
                    nType = _col1[nRow - 1];
                    break;
                case 2:
                    nType = _col2[nRow - 1];
                    break;
                case 3:
                    nType = _col3[nRow - 1];
                    break;
                case 4:
                    nType = _col4[nRow - 1];
                    break;
                case 5:
                    nType = _col5[nRow - 1];
                    break;
                case 6:
                    nType = _col6[nRow - 1];
                    break;
                case 7:
                    nType = _col7[nRow - 1];
                    break;
                case 8:
                    nType = _col8[nRow - 1];
                    break;
                case 9:
                    nType = _col9[nRow - 1];
                    break;
                default:
                    nType = _cola[nRow - 1];
                    break;
            }
            switch (nType)
            {
                case 7:
                    nSame = 4;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 10:
                    nSame = 4;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 11:
                    nSame = 4;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 15:
                    nSame = 4;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 16:
                    nSame = 4;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 17:
                    nSame = 4;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
                case 19:
                    nSame = 4;
                    sCode = sCode.Substring(0, nSame - 1) + "1" + sCode.Substring(nSame, 4 - nSame);
                    break;
            }
            sCode = sCode.Substring(0, nNew - 1) + "1" + sCode.Substring(nNew, 4 - nNew);

            switch (sCode)
            {
                case "1000":
                    nType = 6;
                    break;
                case "0100":
                    nType = 7;
                    break;
                case "0010":
                    nType = 8;
                    break;
                case "0001":
                    nType = 9;
                    break;
                case "1100":
                    nType = 10;
                    break;
                case "0110":
                    nType = 11;
                    break;
                case "0011":
                    nType = 12;
                    break;
                case "1001":
                    nType = 13;
                    break;
                case "1010":
                    nType = 14;
                    break;
                case "0101":
                    nType = 15;
                    break;
                case "1110":
                    nType = 16;
                    break;
                case "0111":
                    nType = 17;
                    break;
                case "1011":
                    nType = 18;
                    break;
                case "1101":
                    nType = 19;
                    break;
                case "1111":
                    switch (nCol)
                    {
                        case 1:
                            nType = _type1[nRow - 1];
                            break;
                        case 2:
                            nType = _type2[nRow - 1];
                            break;
                        case 3:
                            nType = _type3[nRow - 1];
                            break;
                        case 4:
                            nType = _type4[nRow - 1];
                            break;
                        case 5:
                            nType = _type5[nRow - 1];
                            break;
                        case 6:
                            nType = _type6[nRow - 1];
                            break;
                        case 7:
                            nType = _type7[nRow - 1];
                            break;
                        case 8:
                            nType = _type8[nRow - 1];
                            break;
                        case 9:
                            nType = _type9[nRow - 1];
                            break;
                        default:
                            nType = _typea[nRow - 1];
                            break;
                    }
                    switch (nType)
                    {
                        case 3:
                            mnOil +=1;
                            break;
                        case 4:
                            mnDam +=1;
                            break;
                        case 5:
                            mnFactory +=1;
                            break;
                    }
                    break;

            }
            nCol = _HolderACol[3];
            nRow = _HolderARow[3];
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
                case 8:
                    _col8[nRow - 1] = nType;
                    break;
                case 9:
                    _col9[nRow - 1] = nType;
                    break;
                default:
                    _cola[nRow - 1] = nType;
                    break;
            }
            switch (nType)
            {
                case 1:
                    picAcross4.Image = picture1.Image;
                    break;
                case 2:
                    picAcross4.Image = picture2.Image;
                    break;
                case 3:
                    picAcross4.Image = picture3.Image;
                    break;
                case 4:
                    picAcross4.Image = picture4.Image;
                    break;
                case 5:
                    picAcross4.Image = picture5.Image;
                    break;
                case 6:
                    picAcross4.Image = picture6.Image;
                    break;
                case 7:
                    picAcross4.Image = picture7.Image;
                    break;
                case 8:
                    picAcross4.Image = picture8.Image;
                    break;
                case 9:
                    picAcross4.Image = picture9.Image;
                    break;
                case 10:
                    picAcross4.Image = picture10.Image;
                    break;
                case 11:
                    picAcross4.Image = picture11.Image;
                    break;
                case 12:
                    picAcross4.Image = picture12.Image;
                    break;
                case 13:
                    picAcross4.Image = picture13.Image;
                    break;
                case 14:
                    picAcross4.Image = picture14.Image;
                    break;
                case 15:
                    picAcross4.Image = picture15.Image;
                    break;
                case 16:
                    picAcross4.Image = picture16.Image;
                    break;
                case 17:
                    picAcross4.Image = picture17.Image;
                    break;
                case 18:
                    picAcross4.Image = picture18.Image;
                    break;
                case 19:
                    picAcross4.Image = picture19.Image;
                    break;
                default:
                    picAcross4.Image = picture20.Image;
                    break;
            }

            if (lst1.Items.Count > 0)
            {

                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }
            sWord = "Oil = " + Convert.ToString(mnOil);
            lst1.Items.Add(sWord);
            sWord = "Dam = " + Convert.ToString(mnDam);
            lst1.Items.Add(sWord);
            sWord = "Factory = " + Convert.ToString(mnFactory);
            lst1.Items.Add(sWord);

            bool bEnded = false;

            if (mnOil == 5)
            {
                bEnded = true;
            }
            else
            {
                if (mnDam == 5)
                {
                    bEnded = true;
                }
                else
                {
                    if (mnFactory == 5)
                    {
                        bEnded = true;
                    }
                }
            }
            if (bEnded == true)
            {
                nScore += 10;
                lblScore.Text = "Score = " + Convert.ToString(nScore);
                MessageBox.Show("You've won", "GameEnded");
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
        int nCol, nRow, nType;
        String sWord;

        mnOil = 0;
        mnDam = 0;
        mnFactory = 0;

        CounterCol = rnd1.Next(1, 11);
        CounterRow = rnd1.Next(1, 11);
        CounterDirection = rnd1.Next(1, 5);
        for (int i = 1; i <= 10; i++)
        {
            _col1[i - 1] = rnd1.Next(6, 16);
            _col2[i - 1] = rnd1.Next(6, 16);
            _col3[i - 1] = rnd1.Next(6, 16);
            _col4[i - 1] = rnd1.Next(6, 16);
            _col5[i - 1] = rnd1.Next(6, 16);
            _col6[i - 1] = rnd1.Next(6, 16);
            _col7[i - 1] = rnd1.Next(6, 16);
            _col8[i - 1] = rnd1.Next(6, 16);
            _col9[i - 1] = rnd1.Next(6, 16);
            _cola[i - 1] = rnd1.Next(6, 16);
        }
        for (int i = 1; i <= 10; i++)
        {
            _type1[i - 1] = rnd1.Next(3, 6);
            _type2[i - 1] = rnd1.Next(3, 6);
            _type3[i - 1] = rnd1.Next(3, 6);
            _type4[i - 1] = rnd1.Next(3, 6);
            _type5[i - 1] = rnd1.Next(3, 6);
            _type6[i - 1] = rnd1.Next(3, 6);
            _type7[i - 1] = rnd1.Next(3, 6);
            _type8[i - 1] = rnd1.Next(3, 6);
            _type9[i - 1] = rnd1.Next(3, 6);
            _typea[i - 1] = rnd1.Next(3, 6);
        }

        switch (CounterDirection)
        {
            case 1:
                _HolderACol[0] = CounterCol - 3;
                if (_HolderACol[0] < 1)
                {
                    _HolderACol[0] = _HolderACol[0] + 10;
                }
                _HolderARow[0] = CounterRow;
                _HolderACol[1] = CounterCol - 2;
                if (_HolderACol[1] < 1)
                {
                    _HolderACol[1] = _HolderACol[1] + 10;
                }
                _HolderARow[1] = CounterRow;
                _HolderACol[2] = CounterCol - 1;
                if (_HolderACol[2] < 1)
                {
                    _HolderACol[2] = _HolderACol[2] + 10;
                }
                _HolderARow[2] = CounterRow;
                _HolderACol[3] = CounterCol;
                _HolderARow[3] = CounterRow;
                _HolderACol[4] = CounterCol + 1;
                if (_HolderACol[4] > 10)
                {
                    _HolderACol[4] = _HolderACol[4] - 10;
                }
                _HolderARow[4] = CounterRow;
                _HolderACol[5] = CounterCol + 2;
                if (_HolderACol[5] > 10)
                {
                    _HolderACol[5] = _HolderACol[5] - 10;
                }
                _HolderARow[5] = CounterRow;
                _HolderACol[6] = CounterCol + 3;
                if (_HolderACol[6] > 10)
                {
                    _HolderACol[6] = _HolderACol[6] - 10;
                }
                _HolderARow[6] = CounterRow;
                _HolderFCol[0] = CounterCol;
                _HolderFRow[0] = CounterRow - 3;
                if (_HolderFRow[0] < 1)
                {
                    _HolderFRow[0] = _HolderFRow[0] + 10;
                }
                _HolderFCol[1] = CounterCol;
                _HolderFRow[1] = CounterRow - 2;
                if (_HolderFRow[1] < 1)
                {
                    _HolderFRow[1] = _HolderFRow[1] + 10;
                }
                _HolderFCol[2] = CounterCol;
                _HolderFRow[2] = CounterRow - 1;
                if (_HolderFRow[2] < 1)
                {
                    _HolderFRow[2] = _HolderFRow[2] + 10;
                }

                break;
            case 2:
                _HolderACol[0] = CounterCol;
                _HolderARow[0] = CounterRow - 3;
                if (_HolderARow[0] < 1)
                {
                    _HolderARow[0] = _HolderARow[0] + 10;
                }
                _HolderACol[1] = CounterCol;
                _HolderARow[1] = CounterRow - 2;
                if (_HolderARow[1] < 1)
                {
                    _HolderARow[1] = _HolderARow[1] + 10;
                }
                _HolderACol[2] = CounterCol;
                _HolderARow[2] = CounterRow - 1;
                if (_HolderARow[2] < 1)
                {
                    _HolderARow[2] = _HolderARow[2] + 10;
                }
                _HolderACol[3] = CounterCol;
                _HolderARow[3] = CounterRow;
                _HolderACol[4] = CounterCol;
                _HolderARow[4] = CounterRow + 1;
                if (_HolderARow[4] > 10)
                {
                    _HolderARow[4] = _HolderARow[4] - 10;
                }
                _HolderACol[5] = CounterCol;
                _HolderARow[5] = CounterRow + 2;
                if (_HolderARow[5] > 10)
                {
                    _HolderARow[5] = _HolderARow[5] - 10;
                }
                _HolderACol[6] = CounterCol;
                _HolderARow[6] = CounterRow + 3;
                if (_HolderARow[6] > 10)
                {
                    _HolderARow[6] = _HolderARow[6] - 10;
                }
                _HolderFCol[0] = CounterCol + 3;
                if (_HolderFCol[0] > 10)
                {
                    _HolderFCol[0] = _HolderFCol[0] - 10;
                }
                _HolderFRow[0] = CounterRow;
                _HolderFCol[1] = CounterCol + 2;
                if (_HolderFCol[1] > 10)
                {
                    _HolderFCol[1] = _HolderFCol[1] - 10;
                }
                _HolderFRow[1] = CounterRow;
                _HolderFCol[2] = CounterCol + 1;
                if (_HolderFCol[2] > 10)
                {
                    _HolderFCol[2] = _HolderFCol[2] - 10;
                }
                _HolderFRow[2] = CounterRow;

                break;
            case 3:
                _HolderACol[0] = CounterCol + 3;
                if (_HolderACol[0] > 10)
                {
                    _HolderACol[0] = _HolderACol[0] - 10;
                }
                _HolderARow[0] = CounterRow;
                _HolderACol[1] = CounterCol + 2;
                if (_HolderACol[1] > 10)
                {
                    _HolderACol[1] = _HolderACol[1] - 10;
                }
                _HolderARow[1] = CounterRow;
                _HolderACol[2] = CounterCol + 1;
                if (_HolderACol[2] > 10)
                {
                    _HolderACol[2] = _HolderACol[2] - 10;
                }
                _HolderARow[2] = CounterRow;
                _HolderACol[3] = CounterCol;
                _HolderARow[3] = CounterRow;
                _HolderACol[4] = CounterCol - 1;
                if (_HolderACol[4] < 1)
                {
                    _HolderACol[4] = _HolderACol[4] + 10;
                }
                _HolderARow[4] = CounterRow;
                _HolderACol[5] = CounterCol - 2;
                if (_HolderACol[5] < 2)
                {
                    _HolderACol[5] = _HolderACol[5] + 10;
                }
                _HolderARow[5] = CounterRow;
                _HolderACol[6] = CounterCol - 3;
                if (_HolderACol[6] < 3)
                {
                    _HolderACol[6] = _HolderACol[6] + 10;
                }
                _HolderARow[6] = CounterRow;
                _HolderFCol[0] = CounterCol;
                _HolderFRow[0] = CounterRow + 3;
                if (_HolderFRow[0] > 10)
                {
                    _HolderFRow[0] = _HolderFRow[0] - 10;
                }
                _HolderFCol[1] = CounterCol;
                _HolderFRow[1] = CounterRow + 2;
                if (_HolderFRow[1] > 10)
                {
                    _HolderFRow[1] = _HolderFRow[1] - 10;
                }
                _HolderFCol[2] = CounterCol;
                _HolderFRow[2] = CounterRow + 1;
                if (_HolderFRow[2] > 10)
                {
                    _HolderFRow[2] = _HolderFRow[2] - 10;
                }

                break;
            default:
                _HolderACol[0] = CounterCol;
                _HolderARow[0] = CounterRow + 3;
                if (_HolderARow[0] > 10)
                {
                    _HolderARow[0] = _HolderARow[0] - 10;
                }
                _HolderACol[1] = CounterCol;
                _HolderARow[1] = CounterRow + 2;
                if (_HolderARow[1] > 10)
                {
                    _HolderARow[1] = _HolderARow[1] - 10;
                }
                _HolderACol[2] = CounterCol;
                _HolderARow[2] = CounterRow + 1;
                if (_HolderARow[2] > 10)
                {
                    _HolderARow[2] = _HolderARow[2] - 10;
                }
                _HolderACol[3] = CounterCol;
                _HolderARow[3] = CounterRow;
                _HolderACol[4] = CounterCol;
                _HolderARow[4] = CounterRow - 1;
                if (_HolderARow[4] < 1)
                {
                    _HolderARow[4] = _HolderARow[4] + 10;
                }
                _HolderACol[5] = CounterCol;
                _HolderARow[5] = CounterRow - 2;
                if (_HolderARow[5] < 1)
                {
                    _HolderARow[5] = _HolderARow[5] + 10;
                }
                _HolderACol[6] = CounterCol;
                _HolderARow[6] = CounterRow - 3;
                if (_HolderARow[6] < 1)
                {
                    _HolderARow[6] = _HolderARow[6] + 10;
                }
                _HolderFCol[0] = CounterCol - 3;
                if (_HolderFCol[0] < 1)
                {
                    _HolderFCol[0] = _HolderFCol[0] + 10;
                }
                _HolderFRow[0] = CounterRow;
                _HolderFCol[1] = CounterCol - 2;
                if (_HolderFCol[1] < 1)
                {
                    _HolderFCol[1] = _HolderFCol[1] + 10;
                }
                _HolderFRow[1] = CounterRow;
                _HolderFCol[2] = CounterCol - 1;
                if (_HolderFCol[2] < 1)
                {
                    _HolderFCol[2] = _HolderFCol[2] + 10;
                }
                _HolderFRow[2] = CounterRow;

                break;
        }
        lblLocation.Text = "Location = (" + Convert.ToString(CounterCol) + "," + Convert.ToString(CounterRow) + ")";
        switch (CounterDirection)
        {
            case 1:
                lblDirection.Text = "Direction = (N)";
                break;
            case 2:
                lblDirection.Text = "Direction = (E)";
                break;
            case 3:
                lblDirection.Text = "Direction = (S)";
                break;
            default:
                lblDirection.Text = "Direction = (W)";
                break;
        }

        PictureBox picture1 = new PictureBox
        {
            Name = "pictureBox1",
            Image = Image.FromFile(@"F blank.png"),
            SizeMode = PictureBoxSizeMode.StretchImage
        };
        PictureBox picture2 = new PictureBox
        {
            Name = "pictureBox2",
            Image = Image.FromFile(@"F Exit.png"),
            SizeMode = PictureBoxSizeMode.StretchImage
        };
        PictureBox picture3 = new PictureBox
        {
            Name = "pictureBox3",
            Image = Image.FromFile(@"F found1.png"),
            SizeMode = PictureBoxSizeMode.StretchImage
        };
        PictureBox picture4 = new PictureBox
        {
            Name = "pictureBox4",
            Image = Image.FromFile(@"F found2.png"),
            SizeMode = PictureBoxSizeMode.StretchImage
        };
        PictureBox picture5 = new PictureBox
        {
            Name = "pictureBox5",
            Image = Image.FromFile(@"F found3.png"),
            SizeMode = PictureBoxSizeMode.StretchImage
        };
        PictureBox picture6 = new PictureBox
        {
            Name = "pictureBox6",
            Image = Image.FromFile(@"F type11.png"),
            SizeMode = PictureBoxSizeMode.StretchImage
        };
        PictureBox picture7 = new PictureBox
        {
            Name = "pictureBox7",
            Image = Image.FromFile(@"F type12.png"),
            SizeMode = PictureBoxSizeMode.StretchImage
        };
        PictureBox picture8 = new PictureBox
        {
            Name = "pictureBox8",
            Image = Image.FromFile(@"F type13.png"),
            SizeMode = PictureBoxSizeMode.StretchImage
        };
        PictureBox picture9 = new PictureBox
        {
            Name = "pictureBox9",
            Image = Image.FromFile(@"F type14.png"),
            SizeMode = PictureBoxSizeMode.StretchImage
        };
        PictureBox picture10 = new PictureBox
        {
            Name = "pictureBox10",
            Image = Image.FromFile(@"F type21.png"),
            SizeMode = PictureBoxSizeMode.StretchImage
        };
        PictureBox picture11 = new PictureBox
        {
            Name = "pictureBox11",
            Image = Image.FromFile(@"F type22.png"),
            SizeMode = PictureBoxSizeMode.StretchImage
        };
        PictureBox picture12 = new PictureBox
        {
            Name = "pictureBox12",
            Image = Image.FromFile(@"F type23.png"),
            SizeMode = PictureBoxSizeMode.StretchImage
        };
        PictureBox picture13 = new PictureBox
        {
            Name = "pictureBox13",
            Image = Image.FromFile(@"F type24.png"),
            SizeMode = PictureBoxSizeMode.StretchImage
        };
        PictureBox picture14 = new PictureBox
        {
            Name = "pictureBox14",
            Image = Image.FromFile(@"F type25.png"),
            SizeMode = PictureBoxSizeMode.StretchImage
        };
        PictureBox picture15 = new PictureBox
        {
            Name = "pictureBox15",
            Image = Image.FromFile(@"F type26.png"),
            SizeMode = PictureBoxSizeMode.StretchImage
        };
        PictureBox picture16 = new PictureBox
        {
            Name = "pictureBox16",
            Image = Image.FromFile(@"F type31.png"),
            SizeMode = PictureBoxSizeMode.StretchImage
        };
        PictureBox picture17 = new PictureBox
        {
            Name = "pictureBox17",
            Image = Image.FromFile(@"F type32.png"),
            SizeMode = PictureBoxSizeMode.StretchImage
        };
        PictureBox picture18 = new PictureBox
        {
            Name = "pictureBox18",
            Image = Image.FromFile(@"F type33.png"),
            SizeMode = PictureBoxSizeMode.StretchImage
        };
        PictureBox picture19 = new PictureBox
        {
            Name = "pictureBox19",
            Image = Image.FromFile(@"F type34.png"),
            SizeMode = PictureBoxSizeMode.StretchImage
        };
        PictureBox picture20 = new PictureBox
        {
            Name = "pictureBox20",
            Image = Image.FromFile(@"F Nullgate.png"),
            SizeMode = PictureBoxSizeMode.StretchImage
        };

        nCol = _HolderACol[0];
        nRow = _HolderARow[0];
        switch (nCol)
        {
            case 1:
                nType = _col1[nRow - 1];
                break;
            case 2:
                nType = _col2[nRow - 1];
                break;
            case 3:
                nType = _col3[nRow - 1];
                break;
            case 4:
                nType = _col4[nRow - 1];
                break;
            case 5:
                nType = _col5[nRow - 1];
                break;
            case 6:
                nType = _col6[nRow - 1];
                break;
            case 7:
                nType = _col7[nRow - 1];
                break;
            case 8:
                nType = _col8[nRow - 1];
                break;
            case 9:
                nType = _col9[nRow - 1];
                break;
            default:
                nType = _cola[nRow - 1];
                break;
        }
        switch (nType)
        {
            case 1:
                picAcross1.Image = picture1.Image;
                break;
            case 2:
                picAcross1.Image = picture2.Image;
                break;
            case 3:
                picAcross1.Image = picture3.Image;
                break;
            case 4:
                picAcross1.Image = picture4.Image;
                break;
            case 5:
                picAcross1.Image = picture5.Image;
                break;
            case 6:
                picAcross1.Image = picture6.Image;
                break;
            case 7:
                picAcross1.Image = picture7.Image;
                break;
            case 8:
                picAcross1.Image = picture8.Image;
                break;
            case 9:
                picAcross1.Image = picture9.Image;
                break;
            case 10:
                picAcross1.Image = picture10.Image;
                break;
            case 11:
                picAcross1.Image = picture11.Image;
                break;
            case 12:
                picAcross1.Image = picture12.Image;
                break;
            case 13:
                picAcross1.Image = picture13.Image;
                break;
            case 14:
                picAcross1.Image = picture14.Image;
                break;
            case 15:
                picAcross1.Image = picture15.Image;
                break;
            case 16:
                picAcross1.Image = picture16.Image;
                break;
            case 17:
                picAcross1.Image = picture17.Image;
                break;
            case 18:
                picAcross1.Image = picture18.Image;
                break;
            case 19:
                picAcross1.Image = picture19.Image;
                break;
            default:
                picAcross1.Image = picture20.Image;
                break;
        }
        nCol = _HolderACol[1];
        nRow = _HolderARow[1];
        switch (nCol)
        {
            case 1:
                nType = _col1[nRow - 1];
                break;
            case 2:
                nType = _col2[nRow - 1];
                break;
            case 3:
                nType = _col3[nRow - 1];
                break;
            case 4:
                nType = _col4[nRow - 1];
                break;
            case 5:
                nType = _col5[nRow - 1];
                break;
            case 6:
                nType = _col6[nRow - 1];
                break;
            case 7:
                nType = _col7[nRow - 1];
                break;
            case 8:
                nType = _col8[nRow - 1];
                break;
            case 9:
                nType = _col9[nRow - 1];
                break;
            default:
                nType = _cola[nRow - 1];
                break;
        }
        switch (nType)
        {
            case 1:
                picAcross2.Image = picture1.Image;
                break;
            case 2:
                picAcross2.Image = picture2.Image;
                break;
            case 3:
                picAcross2.Image = picture3.Image;
                break;
            case 4:
                picAcross2.Image = picture4.Image;
                break;
            case 5:
                picAcross2.Image = picture5.Image;
                break;
            case 6:
                picAcross2.Image = picture6.Image;
                break;
            case 7:
                picAcross2.Image = picture7.Image;
                break;
            case 8:
                picAcross2.Image = picture8.Image;
                break;
            case 9:
                picAcross2.Image = picture9.Image;
                break;
            case 10:
                picAcross2.Image = picture10.Image;
                break;
            case 11:
                picAcross2.Image = picture11.Image;
                break;
            case 12:
                picAcross2.Image = picture12.Image;
                break;
            case 13:
                picAcross2.Image = picture13.Image;
                break;
            case 14:
                picAcross2.Image = picture14.Image;
                break;
            case 15:
                picAcross2.Image = picture15.Image;
                break;
            case 16:
                picAcross2.Image = picture16.Image;
                break;
            case 17:
                picAcross2.Image = picture17.Image;
                break;
            case 18:
                picAcross2.Image = picture18.Image;
                break;
            case 19:
                picAcross2.Image = picture19.Image;
                break;
            default:
                picAcross2.Image = picture20.Image;
                break;
        }
        nCol = _HolderACol[2];
        nRow = _HolderARow[2];
        switch (nCol)
        {
            case 1:
                nType = _col1[nRow - 1];
                break;
            case 2:
                nType = _col2[nRow - 1];
                break;
            case 3:
                nType = _col3[nRow - 1];
                break;
            case 4:
                nType = _col4[nRow - 1];
                break;
            case 5:
                nType = _col5[nRow - 1];
                break;
            case 6:
                nType = _col6[nRow - 1];
                break;
            case 7:
                nType = _col7[nRow - 1];
                break;
            case 8:
                nType = _col8[nRow - 1];
                break;
            case 9:
                nType = _col9[nRow - 1];
                break;
            default:
                nType = _cola[nRow - 1];
                break;
        }
        switch (nType)
        {
            case 1:
                picAcross3.Image = picture1.Image;
                break;
            case 2:
                picAcross3.Image = picture2.Image;
                break;
            case 3:
                picAcross3.Image = picture3.Image;
                break;
            case 4:
                picAcross3.Image = picture4.Image;
                break;
            case 5:
                picAcross3.Image = picture5.Image;
                break;
            case 6:
                picAcross3.Image = picture6.Image;
                break;
            case 7:
                picAcross3.Image = picture7.Image;
                break;
            case 8:
                picAcross3.Image = picture8.Image;
                break;
            case 9:
                picAcross3.Image = picture9.Image;
                break;
            case 10:
                picAcross3.Image = picture10.Image;
                break;
            case 11:
                picAcross3.Image = picture11.Image;
                break;
            case 12:
                picAcross3.Image = picture12.Image;
                break;
            case 13:
                picAcross3.Image = picture13.Image;
                break;
            case 14:
                picAcross3.Image = picture14.Image;
                break;
            case 15:
                picAcross3.Image = picture15.Image;
                break;
            case 16:
                picAcross3.Image = picture16.Image;
                break;
            case 17:
                picAcross3.Image = picture17.Image;
                break;
            case 18:
                picAcross3.Image = picture18.Image;
                break;
            case 19:
                picAcross3.Image = picture19.Image;
                break;
            default:
                picAcross3.Image = picture20.Image;
                break;
        }
        nCol = _HolderACol[3];
        nRow = _HolderARow[3];
        switch (nCol)
        {
            case 1:
                nType = _col1[nRow - 1];
                break;
            case 2:
                nType = _col2[nRow - 1];
                break;
            case 3:
                nType = _col3[nRow - 1];
                break;
            case 4:
                nType = _col4[nRow - 1];
                break;
            case 5:
                nType = _col5[nRow - 1];
                break;
            case 6:
                nType = _col6[nRow - 1];
                break;
            case 7:
                nType = _col7[nRow - 1];
                break;
            case 8:
                nType = _col8[nRow - 1];
                break;
            case 9:
                nType = _col9[nRow - 1];
                break;
            default:
                nType = _cola[nRow - 1];
                break;
        }
        switch (nType)
        {
            case 1:
                picAcross4.Image = picture1.Image;
                break;
            case 2:
                picAcross4.Image = picture2.Image;
                break;
            case 3:
                picAcross4.Image = picture3.Image;
                break;
            case 4:
                picAcross4.Image = picture4.Image;
                break;
            case 5:
                picAcross4.Image = picture5.Image;
                break;
            case 6:
                picAcross4.Image = picture6.Image;
                break;
            case 7:
                picAcross4.Image = picture7.Image;
                break;
            case 8:
                picAcross4.Image = picture8.Image;
                break;
            case 9:
                picAcross4.Image = picture9.Image;
                break;
            case 10:
                picAcross4.Image = picture10.Image;
                break;
            case 11:
                picAcross4.Image = picture11.Image;
                break;
            case 12:
                picAcross4.Image = picture12.Image;
                break;
            case 13:
                picAcross4.Image = picture13.Image;
                break;
            case 14:
                picAcross4.Image = picture14.Image;
                break;
            case 15:
                picAcross4.Image = picture15.Image;
                break;
            case 16:
                picAcross4.Image = picture16.Image;
                break;
            case 17:
                picAcross4.Image = picture17.Image;
                break;
            case 18:
                picAcross4.Image = picture18.Image;
                break;
            case 19:
                picAcross4.Image = picture19.Image;
                break;
            default:
                picAcross4.Image = picture20.Image;
                break;
        }
        nCol = _HolderACol[4];
        nRow = _HolderARow[4];
        switch (nCol)
        {
            case 1:
                nType = _col1[nRow - 1];
                break;
            case 2:
                nType = _col2[nRow - 1];
                break;
            case 3:
                nType = _col3[nRow - 1];
                break;
            case 4:
                nType = _col4[nRow - 1];
                break;
            case 5:
                nType = _col5[nRow - 1];
                break;
            case 6:
                nType = _col6[nRow - 1];
                break;
            case 7:
                nType = _col7[nRow - 1];
                break;
            case 8:
                nType = _col8[nRow - 1];
                break;
            case 9:
                nType = _col9[nRow - 1];
                break;
            default:
                nType = _cola[nRow - 1];
                break;
        }
        switch (nType)
        {
            case 1:
                picAcross5.Image = picture1.Image;
                break;
            case 2:
                picAcross5.Image = picture2.Image;
                break;
            case 3:
                picAcross5.Image = picture3.Image;
                break;
            case 4:
                picAcross5.Image = picture4.Image;
                break;
            case 5:
                picAcross5.Image = picture5.Image;
                break;
            case 6:
                picAcross5.Image = picture6.Image;
                break;
            case 7:
                picAcross5.Image = picture7.Image;
                break;
            case 8:
                picAcross5.Image = picture8.Image;
                break;
            case 9:
                picAcross5.Image = picture9.Image;
                break;
            case 10:
                picAcross5.Image = picture10.Image;
                break;
            case 11:
                picAcross5.Image = picture11.Image;
                break;
            case 12:
                picAcross5.Image = picture12.Image;
                break;
            case 13:
                picAcross5.Image = picture13.Image;
                break;
            case 14:
                picAcross5.Image = picture14.Image;
                break;
            case 15:
                picAcross5.Image = picture15.Image;
                break;
            case 16:
                picAcross5.Image = picture16.Image;
                break;
            case 17:
                picAcross5.Image = picture17.Image;
                break;
            case 18:
                picAcross5.Image = picture18.Image;
                break;
            case 19:
                picAcross5.Image = picture19.Image;
                break;
            default:
                picAcross5.Image = picture20.Image;
                break;
        }
        nCol = _HolderACol[5];
        nRow = _HolderARow[5];
        switch (nCol)
        {
            case 1:
                nType = _col1[nRow - 1];
                break;
            case 2:
                nType = _col2[nRow - 1];
                break;
            case 3:
                nType = _col3[nRow - 1];
                break;
            case 4:
                nType = _col4[nRow - 1];
                break;
            case 5:
                nType = _col5[nRow - 1];
                break;
            case 6:
                nType = _col6[nRow - 1];
                break;
            case 7:
                nType = _col7[nRow - 1];
                break;
            case 8:
                nType = _col8[nRow - 1];
                break;
            case 9:
                nType = _col9[nRow - 1];
                break;
            default:
                nType = _cola[nRow - 1];
                break;
        }
        switch (nType)
        {
            case 1:
                picAcross6.Image = picture1.Image;
                break;
            case 2:
                picAcross6.Image = picture2.Image;
                break;
            case 3:
                picAcross6.Image = picture3.Image;
                break;
            case 4:
                picAcross6.Image = picture4.Image;
                break;
            case 5:
                picAcross6.Image = picture5.Image;
                break;
            case 6:
                picAcross6.Image = picture6.Image;
                break;
            case 7:
                picAcross6.Image = picture7.Image;
                break;
            case 8:
                picAcross6.Image = picture8.Image;
                break;
            case 9:
                picAcross6.Image = picture9.Image;
                break;
            case 10:
                picAcross6.Image = picture10.Image;
                break;
            case 11:
                picAcross6.Image = picture11.Image;
                break;
            case 12:
                picAcross6.Image = picture12.Image;
                break;
            case 13:
                picAcross6.Image = picture13.Image;
                break;
            case 14:
                picAcross6.Image = picture14.Image;
                break;
            case 15:
                picAcross6.Image = picture15.Image;
                break;
            case 16:
                picAcross6.Image = picture16.Image;
                break;
            case 17:
                picAcross6.Image = picture17.Image;
                break;
            case 18:
                picAcross6.Image = picture18.Image;
                break;
            case 19:
                picAcross6.Image = picture19.Image;
                break;
            default:
                picAcross6.Image = picture20.Image;
                break;
        }
        nCol = _HolderACol[6];
        nRow = _HolderARow[6];
        switch (nCol)
        {
            case 1:
                nType = _col1[nRow - 1];
                break;
            case 2:
                nType = _col2[nRow - 1];
                break;
            case 3:
                nType = _col3[nRow - 1];
                break;
            case 4:
                nType = _col4[nRow - 1];
                break;
            case 5:
                nType = _col5[nRow - 1];
                break;
            case 6:
                nType = _col6[nRow - 1];
                break;
            case 7:
                nType = _col7[nRow - 1];
                break;
            case 8:
                nType = _col8[nRow - 1];
                break;
            case 9:
                nType = _col9[nRow - 1];
                break;
            default:
                nType = _cola[nRow - 1];
                break;
        }
        switch (nType)
        {
            case 1:
                picAcross7.Image = picture1.Image;
                break;
            case 2:
                picAcross7.Image = picture2.Image;
                break;
            case 3:
                picAcross7.Image = picture3.Image;
                break;
            case 4:
                picAcross7.Image = picture4.Image;
                break;
            case 5:
                picAcross7.Image = picture5.Image;
                break;
            case 6:
                picAcross7.Image = picture6.Image;
                break;
            case 7:
                picAcross7.Image = picture7.Image;
                break;
            case 8:
                picAcross7.Image = picture8.Image;
                break;
            case 9:
                picAcross7.Image = picture9.Image;
                break;
            case 10:
                picAcross7.Image = picture10.Image;
                break;
            case 11:
                picAcross7.Image = picture11.Image;
                break;
            case 12:
                picAcross7.Image = picture12.Image;
                break;
            case 13:
                picAcross7.Image = picture13.Image;
                break;
            case 14:
                picAcross7.Image = picture14.Image;
                break;
            case 15:
                picAcross7.Image = picture15.Image;
                break;
            case 16:
                picAcross7.Image = picture16.Image;
                break;
            case 17:
                picAcross7.Image = picture17.Image;
                break;
            case 18:
                picAcross7.Image = picture18.Image;
                break;
            case 19:
                picAcross7.Image = picture19.Image;
                break;
            default:
                picAcross7.Image = picture20.Image;
                break;
        }

        nCol = _HolderFCol[0];
        nRow = _HolderFRow[0];
        switch (nCol)
        {
            case 1:
                nType = _col1[nRow - 1];
                break;
            case 2:
                nType = _col2[nRow - 1];
                break;
            case 3:
                nType = _col3[nRow - 1];
                break;
            case 4:
                nType = _col4[nRow - 1];
                break;
            case 5:
                nType = _col5[nRow - 1];
                break;
            case 6:
                nType = _col6[nRow - 1];
                break;
            case 7:
                nType = _col7[nRow - 1];
                break;
            case 8:
                nType = _col8[nRow - 1];
                break;
            case 9:
                nType = _col9[nRow - 1];
                break;
            default:
                nType = _cola[nRow - 1];
                break;
        }
        switch (nType)
        {
            case 1:
                picForward1.Image = picture1.Image;
                break;
            case 2:
                picForward1.Image = picture2.Image;
                break;
            case 3:
                picForward1.Image = picture3.Image;
                break;
            case 4:
                picForward1.Image = picture4.Image;
                break;
            case 5:
                picForward1.Image = picture5.Image;
                break;
            case 6:
                picForward1.Image = picture6.Image;
                break;
            case 7:
                picForward1.Image = picture7.Image;
                break;
            case 8:
                picForward1.Image = picture8.Image;
                break;
            case 9:
                picForward1.Image = picture9.Image;
                break;
            case 10:
                picForward1.Image = picture10.Image;
                break;
            case 11:
                picForward1.Image = picture11.Image;
                break;
            case 12:
                picForward1.Image = picture12.Image;
                break;
            case 13:
                picForward1.Image = picture13.Image;
                break;
            case 14:
                picForward1.Image = picture14.Image;
                break;
            case 15:
                picForward1.Image = picture15.Image;
                break;
            case 16:
                picForward1.Image = picture16.Image;
                break;
            case 17:
                picForward1.Image = picture17.Image;
                break;
            case 18:
                picForward1.Image = picture18.Image;
                break;
            case 19:
                picForward1.Image = picture19.Image;
                break;
            default:
                picForward1.Image = picture20.Image;
                break;
        }
        nCol = _HolderFCol[1];
        nRow = _HolderFRow[1];
        switch (nCol)
        {
            case 1:
                nType = _col1[nRow - 1];
                break;
            case 2:
                nType = _col2[nRow - 1];
                break;
            case 3:
                nType = _col3[nRow - 1];
                break;
            case 4:
                nType = _col4[nRow - 1];
                break;
            case 5:
                nType = _col5[nRow - 1];
                break;
            case 6:
                nType = _col6[nRow - 1];
                break;
            case 7:
                nType = _col7[nRow - 1];
                break;
            case 8:
                nType = _col8[nRow - 1];
                break;
            case 9:
                nType = _col9[nRow - 1];
                break;
            default:
                nType = _cola[nRow - 1];
                break;
        }
        switch (nType)
        {
            case 1:
                picForward2.Image = picture1.Image;
                break;
            case 2:
                picForward2.Image = picture2.Image;
                break;
            case 3:
                picForward2.Image = picture3.Image;
                break;
            case 4:
                picForward2.Image = picture4.Image;
                break;
            case 5:
                picForward2.Image = picture5.Image;
                break;
            case 6:
                picForward2.Image = picture6.Image;
                break;
            case 7:
                picForward2.Image = picture7.Image;
                break;
            case 8:
                picForward2.Image = picture8.Image;
                break;
            case 9:
                picForward2.Image = picture9.Image;
                break;
            case 10:
                picForward2.Image = picture10.Image;
                break;
            case 11:
                picForward2.Image = picture11.Image;
                break;
            case 12:
                picForward2.Image = picture12.Image;
                break;
            case 13:
                picForward2.Image = picture13.Image;
                break;
            case 14:
                picForward2.Image = picture14.Image;
                break;
            case 15:
                picForward2.Image = picture15.Image;
                break;
            case 16:
                picForward2.Image = picture16.Image;
                break;
            case 17:
                picForward2.Image = picture17.Image;
                break;
            case 18:
                picForward2.Image = picture18.Image;
                break;
            case 19:
                picForward2.Image = picture19.Image;
                break;
            default:
                picForward2.Image = picture20.Image;
                break;
        }
        nCol = _HolderFCol[2];
        nRow = _HolderFRow[2];
        switch (nCol)
        {
            case 1:
                nType = _col1[nRow - 1];
                break;
            case 2:
                nType = _col2[nRow - 1];
                break;
            case 3:
                nType = _col3[nRow - 1];
                break;
            case 4:
                nType = _col4[nRow - 1];
                break;
            case 5:
                nType = _col5[nRow - 1];
                break;
            case 6:
                nType = _col6[nRow - 1];
                break;
            case 7:
                nType = _col7[nRow - 1];
                break;
            case 8:
                nType = _col8[nRow - 1];
                break;
            case 9:
                nType = _col9[nRow - 1];
                break;
            default:
                nType = _cola[nRow - 1];
                break;
        }
        switch (nType)
        {
            case 1:
                picForward3.Image = picture1.Image;
                break;
            case 2:
                picForward3.Image = picture2.Image;
                break;
            case 3:
                picForward3.Image = picture3.Image;
                break;
            case 4:
                picForward3.Image = picture4.Image;
                break;
            case 5:
                picForward3.Image = picture5.Image;
                break;
            case 6:
                picForward3.Image = picture6.Image;
                break;
            case 7:
                picForward3.Image = picture7.Image;
                break;
            case 8:
                picForward3.Image = picture8.Image;
                break;
            case 9:
                picForward3.Image = picture9.Image;
                break;
            case 10:
                picForward3.Image = picture10.Image;
                break;
            case 11:
                picForward3.Image = picture11.Image;
                break;
            case 12:
                picForward3.Image = picture12.Image;
                break;
            case 13:
                picForward3.Image = picture13.Image;
                break;
            case 14:
                picForward3.Image = picture14.Image;
                break;
            case 15:
                picForward3.Image = picture15.Image;
                break;
            case 16:
                picForward3.Image = picture16.Image;
                break;
            case 17:
                picForward3.Image = picture17.Image;
                break;
            case 18:
                picForward3.Image = picture18.Image;
                break;
            case 19:
                picForward3.Image = picture19.Image;
                break;
            default:
                picForward3.Image = picture20.Image;
                break;
        }

        if (lst1.Items.Count > 0)
        {

            do
            {
                lst1.Items.RemoveAt(0);
            } while (lst1.Items.Count > 0);
        }
        sWord = "Oil = " + Convert.ToString(mnOil);
        lst1.Items.Add(sWord);
        sWord = "Dam = " + Convert.ToString(mnOil);
        lst1.Items.Add(sWord);
        sWord = "Factory = " + Convert.ToString(mnOil);
        lst1.Items.Add(sWord);

    }
    }
}
