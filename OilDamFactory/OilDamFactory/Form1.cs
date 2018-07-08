using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OilDamFactory
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
        private static List<int> _HolderACol = new List<int> { 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _HolderARow = new List<int> { 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _HolderFCol = new List<int> { 0, 0, 0 };
        private static List<int> _HolderFRow = new List<int> { 0, 0, 0 };
        private static List<int> _TaskType = new List<int> { 0, 0, 0, 0, 0 };
        private static List<int> _TaskMultiple = new List<int> { 0, 0, 0, 0, 0 };
        private static List<bool> _TaskDone = new List<bool> { false, false, false, false, false, false };
        private int CounterCol, CounterRow, CounterDirection;
        private int nScore = 0;
        private int mnTurn, mnTask, mnLeft;

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
                Image = Image.FromFile(@"F Exit.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F player10.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F player11.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F player12.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F player13.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F player20.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F player21.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F player22.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F player23.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F player30.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F player31.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F player32.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"F player33.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"F player40.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"F player41.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"F player42.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
                Image = Image.FromFile(@"F player43.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture18 = new PictureBox
            {
                Name = "pictureBox18",
                Image = Image.FromFile(@"F player50.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture19 = new PictureBox
            {
                Name = "pictureBox19",
                Image = Image.FromFile(@"F player51.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture20 = new PictureBox
            {
                Name = "pictureBox20",
                Image = Image.FromFile(@"F player52.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture21 = new PictureBox
            {
                Name = "pictureBox21",
                Image = Image.FromFile(@"F player53.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture22 = new PictureBox
            {
                Name = "pictureBox22",
                Image = Image.FromFile(@"F player60.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture23 = new PictureBox
            {
                Name = "pictureBox23",
                Image = Image.FromFile(@"F player61.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture24 = new PictureBox
            {
                Name = "pictureBox24",
                Image = Image.FromFile(@"F player62.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture25 = new PictureBox
            {
                Name = "pictureBox25",
                Image = Image.FromFile(@"F player63.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture26 = new PictureBox
            {
                Name = "pictureBox26",
                Image = Image.FromFile(@"F sea.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture27 = new PictureBox
            {
                Name = "pictureBox27",
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
                case 20:
                    picAcross1.Image = picture20.Image;
                    break;
                case 21:
                    picAcross1.Image = picture21.Image;
                    break;
                case 22:
                    picAcross1.Image = picture22.Image;
                    break;
                case 23:
                    picAcross1.Image = picture23.Image;
                    break;
                case 24:
                    picAcross1.Image = picture24.Image;
                    break;
                case 25:
                    picAcross1.Image = picture25.Image;
                    break;
                case 26:
                    picAcross1.Image = picture26.Image;
                    break;
                default:
                    picAcross1.Image = picture27.Image;
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
                case 20:
                    picAcross2.Image = picture20.Image;
                    break;
                case 21:
                    picAcross2.Image = picture21.Image;
                    break;
                case 22:
                    picAcross2.Image = picture22.Image;
                    break;
                case 23:
                    picAcross2.Image = picture23.Image;
                    break;
                case 24:
                    picAcross2.Image = picture24.Image;
                    break;
                case 25:
                    picAcross2.Image = picture25.Image;
                    break;
                case 26:
                    picAcross2.Image = picture26.Image;
                    break;
                default:
                    picAcross2.Image = picture27.Image;
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
                case 20:
                    picAcross3.Image = picture20.Image;
                    break;
                case 21:
                    picAcross3.Image = picture21.Image;
                    break;
                case 22:
                    picAcross3.Image = picture22.Image;
                    break;
                case 23:
                    picAcross3.Image = picture23.Image;
                    break;
                case 24:
                    picAcross3.Image = picture24.Image;
                    break;
                case 25:
                    picAcross3.Image = picture25.Image;
                    break;
                case 26:
                    picAcross3.Image = picture26.Image;
                    break;
                default:
                    picAcross3.Image = picture27.Image;
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
                case 20:
                    picAcross4.Image = picture20.Image;
                    break;
                case 21:
                    picAcross4.Image = picture21.Image;
                    break;
                case 22:
                    picAcross4.Image = picture22.Image;
                    break;
                case 23:
                    picAcross4.Image = picture23.Image;
                    break;
                case 24:
                    picAcross4.Image = picture24.Image;
                    break;
                case 25:
                    picAcross4.Image = picture25.Image;
                    break;
                case 26:
                    picAcross4.Image = picture26.Image;
                    break;
                default:
                    picAcross4.Image = picture27.Image;
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
                case 20:
                    picAcross5.Image = picture20.Image;
                    break;
                case 21:
                    picAcross5.Image = picture21.Image;
                    break;
                case 22:
                    picAcross5.Image = picture22.Image;
                    break;
                case 23:
                    picAcross5.Image = picture23.Image;
                    break;
                case 24:
                    picAcross5.Image = picture24.Image;
                    break;
                case 25:
                    picAcross5.Image = picture25.Image;
                    break;
                case 26:
                    picAcross5.Image = picture26.Image;
                    break;
                default:
                    picAcross5.Image = picture27.Image;
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
                case 20:
                    picAcross6.Image = picture20.Image;
                    break;
                case 21:
                    picAcross6.Image = picture21.Image;
                    break;
                case 22:
                    picAcross6.Image = picture22.Image;
                    break;
                case 23:
                    picAcross6.Image = picture23.Image;
                    break;
                case 24:
                    picAcross6.Image = picture24.Image;
                    break;
                case 25:
                    picAcross6.Image = picture25.Image;
                    break;
                case 26:
                    picAcross6.Image = picture26.Image;
                    break;
                default:
                    picAcross6.Image = picture27.Image;
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
                case 20:
                    picAcross7.Image = picture20.Image;
                    break;
                case 21:
                    picAcross7.Image = picture21.Image;
                    break;
                case 22:
                    picAcross7.Image = picture22.Image;
                    break;
                case 23:
                    picAcross7.Image = picture23.Image;
                    break;
                case 24:
                    picAcross7.Image = picture24.Image;
                    break;
                case 25:
                    picAcross7.Image = picture25.Image;
                    break;
                case 26:
                    picAcross7.Image = picture26.Image;
                    break;
                default:
                    picAcross7.Image = picture27.Image;
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
                case 20:
                    picForward1.Image = picture20.Image;
                    break;
                case 21:
                    picForward1.Image = picture21.Image;
                    break;
                case 22:
                    picForward1.Image = picture22.Image;
                    break;
                case 23:
                    picForward1.Image = picture23.Image;
                    break;
                case 24:
                    picForward1.Image = picture24.Image;
                    break;
                case 25:
                    picForward1.Image = picture25.Image;
                    break;
                case 26:
                    picForward1.Image = picture26.Image;
                    break;
                default:
                    picForward1.Image = picture27.Image;
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
                case 20:
                    picForward2.Image = picture20.Image;
                    break;
                case 21:
                    picForward2.Image = picture21.Image;
                    break;
                case 22:
                    picForward2.Image = picture22.Image;
                    break;
                case 23:
                    picForward2.Image = picture23.Image;
                    break;
                case 24:
                    picForward2.Image = picture24.Image;
                    break;
                case 25:
                    picForward2.Image = picture25.Image;
                    break;
                case 26:
                    picForward2.Image = picture26.Image;
                    break;
                default:
                    picForward2.Image = picture27.Image;
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
                case 20:
                    picForward3.Image = picture20.Image;
                    break;
                case 21:
                    picForward3.Image = picture21.Image;
                    break;
                case 22:
                    picForward3.Image = picture22.Image;
                    break;
                case 23:
                    picForward3.Image = picture23.Image;
                    break;
                case 24:
                    picForward3.Image = picture24.Image;
                    break;
                case 25:
                    picForward3.Image = picture25.Image;
                    break;
                case 26:
                    picForward3.Image = picture26.Image;
                    break;
                default:
                    picForward3.Image = picture27.Image;
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

        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nCol, nRow, nType;
            String sWord;
            bool bEnded = false;

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
            if (nType == mnTurn)
            {
                nScore = nScore + 10;
                lblScore.Text = "Score = " + Convert.ToString(nScore);
                if (mnLeft == 1)
                {
                    mnTask = mnTask + 1;
                    mnLeft = _TaskMultiple[mnTask - 1];
                    if (mnTask == 6)
                    {
                        MessageBox.Show("GameEnd", "YOU WIN!");
                        bEnded = true;
                    }
                }
                else
                {
                    mnLeft = mnLeft - 1;
                }
                if (lstTask.Items.Count > 0)
                {
                    do
                    {
                        lstTask.Items.RemoveAt(0);
                    } while (lstTask.Items.Count > 0);
                }
                for (int i = 1; i <= 5; i++)
                {
                    sWord = "x" + Convert.ToString(_TaskMultiple[i - 1]) + " ";
                    switch (_TaskType[i - 1])
                    {
                        case 1:
                            sWord = sWord + "Oil";
                            break;
                        case 2:
                            sWord = sWord + "Dam";
                            break;
                        default:
                            sWord = sWord + "Factory";
                            break;
                    }
                    if (i < mnTask)
                    {
                        sWord = sWord + " (done)";
                    }
                    lstTask.Items.Add(sWord);
                }
            }
            else
            {
                MessageBox.Show("GameEnd", "You have ruined everything!");
                bEnded = true;
            }

            if (bEnded == false)
            {
                mnTurn = rnd1.Next(1, 7);
                switch (mnTurn)
                {
                    case 1:
                        mnTurn = 2;
                        break;
                    case 2:
                        mnTurn = 6;
                        break;
                    case 3:
                        mnTurn = 10;
                        break;
                    case 4:
                        mnTurn = 14;
                        break;
                    case 5:
                        mnTurn = 18;
                        break;
                    default:
                        mnTurn = 22;
                        break;
                }

                PictureBox picture1 = new PictureBox
                {
                    Name = "pictureBox1",
                    Image = Image.FromFile(@"F Exit.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                PictureBox picture2 = new PictureBox
                {
                    Name = "pictureBox2",
                    Image = Image.FromFile(@"F player10.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                PictureBox picture3 = new PictureBox
                {
                    Name = "pictureBox3",
                    Image = Image.FromFile(@"F player11.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                PictureBox picture4 = new PictureBox
                {
                    Name = "pictureBox4",
                    Image = Image.FromFile(@"F player12.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                PictureBox picture5 = new PictureBox
                {
                    Name = "pictureBox5",
                    Image = Image.FromFile(@"F player13.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                PictureBox picture6 = new PictureBox
                {
                    Name = "pictureBox6",
                    Image = Image.FromFile(@"F player20.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                PictureBox picture7 = new PictureBox
                {
                    Name = "pictureBox7",
                    Image = Image.FromFile(@"F player21.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                PictureBox picture8 = new PictureBox
                {
                    Name = "pictureBox8",
                    Image = Image.FromFile(@"F player22.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                PictureBox picture9 = new PictureBox
                {
                    Name = "pictureBox9",
                    Image = Image.FromFile(@"F player23.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                PictureBox picture10 = new PictureBox
                {
                    Name = "pictureBox10",
                    Image = Image.FromFile(@"F player30.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                PictureBox picture11 = new PictureBox
                {
                    Name = "pictureBox11",
                    Image = Image.FromFile(@"F player31.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                PictureBox picture12 = new PictureBox
                {
                    Name = "pictureBox12",
                    Image = Image.FromFile(@"F player32.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                PictureBox picture13 = new PictureBox
                {
                    Name = "pictureBox13",
                    Image = Image.FromFile(@"F player33.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                PictureBox picture14 = new PictureBox
                {
                    Name = "pictureBox14",
                    Image = Image.FromFile(@"F player40.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                PictureBox picture15 = new PictureBox
                {
                    Name = "pictureBox15",
                    Image = Image.FromFile(@"F player41.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                PictureBox picture16 = new PictureBox
                {
                    Name = "pictureBox16",
                    Image = Image.FromFile(@"F player42.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                PictureBox picture17 = new PictureBox
                {
                    Name = "pictureBox17",
                    Image = Image.FromFile(@"F player43.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                PictureBox picture18 = new PictureBox
                {
                    Name = "pictureBox18",
                    Image = Image.FromFile(@"F player50.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                PictureBox picture19 = new PictureBox
                {
                    Name = "pictureBox19",
                    Image = Image.FromFile(@"F player51.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                PictureBox picture20 = new PictureBox
                {
                    Name = "pictureBox20",
                    Image = Image.FromFile(@"F player52.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                PictureBox picture21 = new PictureBox
                {
                    Name = "pictureBox21",
                    Image = Image.FromFile(@"F player53.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                PictureBox picture22 = new PictureBox
                {
                    Name = "pictureBox22",
                    Image = Image.FromFile(@"F player60.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                PictureBox picture23 = new PictureBox
                {
                    Name = "pictureBox23",
                    Image = Image.FromFile(@"F player61.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                PictureBox picture24 = new PictureBox
                {
                    Name = "pictureBox24",
                    Image = Image.FromFile(@"F player62.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                PictureBox picture25 = new PictureBox
                {
                    Name = "pictureBox25",
                    Image = Image.FromFile(@"F player63.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                PictureBox picture26 = new PictureBox
                {
                    Name = "pictureBox26",
                    Image = Image.FromFile(@"F sea.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                PictureBox picture27 = new PictureBox
                {
                    Name = "pictureBox27",
                    Image = Image.FromFile(@"F Nullgate.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                nCol = _HolderACol[3];
                nRow = _HolderARow[3];
                switch (nCol)
                {
                    case 1:
                        _col1[nRow - 1] = _col1[nRow - 1] + _TaskType[mnTask - 1];
                        nType = _col1[nRow - 1];
                        break;
                    case 2:
                        _col2[nRow - 1] = _col2[nRow - 1] + _TaskType[mnTask - 1];
                        nType = _col2[nRow - 1];
                        break;
                    case 3:
                        _col3[nRow - 1] = _col3[nRow - 1] + _TaskType[mnTask - 1];
                        nType = _col3[nRow - 1];
                        break;
                    case 4:
                        _col4[nRow - 1] = _col4[nRow - 1] + _TaskType[mnTask - 1];
                        nType = _col4[nRow - 1];
                        break;
                    case 5:
                        _col5[nRow - 1] = _col5[nRow - 1] + _TaskType[mnTask - 1];
                        nType = _col5[nRow - 1];
                        break;
                    case 6:
                        _col6[nRow - 1] = _col6[nRow - 1] + _TaskType[mnTask - 1];
                        nType = _col6[nRow - 1];
                        break;
                    case 7:
                        _col7[nRow - 1] = _col7[nRow - 1] + _TaskType[mnTask - 1];
                        nType = _col7[nRow - 1];
                        break;
                    case 8:
                        _col8[nRow - 1] = _col8[nRow - 1] + _TaskType[mnTask - 1];
                        nType = _col8[nRow - 1];
                        break;
                    case 9:
                        _col9[nRow - 1] = _col9[nRow - 1] + _TaskType[mnTask - 1];
                        nType = _col9[nRow - 1];
                        break;
                    default:
                        _cola[nRow - 1] = _cola[nRow - 1] + _TaskType[mnTask - 1];
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
                    case 20:
                        picAcross4.Image = picture20.Image;
                        break;
                    case 21:
                        picAcross4.Image = picture21.Image;
                        break;
                    case 22:
                        picAcross4.Image = picture22.Image;
                        break;
                    case 23:
                        picAcross4.Image = picture23.Image;
                        break;
                    case 24:
                        picAcross4.Image = picture24.Image;
                        break;
                    case 25:
                        picAcross4.Image = picture25.Image;
                        break;
                    case 26:
                        picAcross4.Image = picture26.Image;
                        break;
                    default:
                        picAcross4.Image = picture27.Image;
                        break;
                }

                switch (mnTurn)
                {
                    case 1:
                        picTurn.Image = picture1.Image;
                        break;
                    case 2:
                        picTurn.Image = picture2.Image;
                        break;
                    case 3:
                        picTurn.Image = picture3.Image;
                        break;
                    case 4:
                        picTurn.Image = picture4.Image;
                        break;
                    case 5:
                        picTurn.Image = picture5.Image;
                        break;
                    case 6:
                        picTurn.Image = picture6.Image;
                        break;
                    case 7:
                        picTurn.Image = picture7.Image;
                        break;
                    case 8:
                        picTurn.Image = picture8.Image;
                        break;
                    case 9:
                        picTurn.Image = picture9.Image;
                        break;
                    case 10:
                        picTurn.Image = picture10.Image;
                        break;
                    case 11:
                        picTurn.Image = picture11.Image;
                        break;
                    case 12:
                        picTurn.Image = picture12.Image;
                        break;
                    case 13:
                        picTurn.Image = picture13.Image;
                        break;
                    case 14:
                        picTurn.Image = picture14.Image;
                        break;
                    case 15:
                        picTurn.Image = picture15.Image;
                        break;
                    case 16:
                        picTurn.Image = picture16.Image;
                        break;
                    case 17:
                        picTurn.Image = picture17.Image;
                        break;
                    case 18:
                        picTurn.Image = picture18.Image;
                        break;
                    case 19:
                        picTurn.Image = picture19.Image;
                        break;
                    case 20:
                        picTurn.Image = picture20.Image;
                        break;
                    case 21:
                        picTurn.Image = picture21.Image;
                        break;
                    case 22:
                        picTurn.Image = picture22.Image;
                        break;
                    case 23:
                        picTurn.Image = picture23.Image;
                        break;
                    case 24:
                        picTurn.Image = picture24.Image;
                        break;
                    case 25:
                        picTurn.Image = picture25.Image;
                        break;
                    case 26:
                        picTurn.Image = picture26.Image;
                        break;
                    default:
                        picTurn.Image = picture27.Image;
                        break;
                }

            }
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nCol, nRow, nType;
            int nLength, nDirection;
            String sWord;

            mnTurn = rnd1.Next(1, 7);
            switch (mnTurn)
            {
                case 1:
                    mnTurn = 2;
                    break;
                case 2:
                    mnTurn = 6;
                    break;
                case 3:
                    mnTurn = 10;
                    break;
                case 4:
                    mnTurn = 14;
                    break;
                case 5:
                    mnTurn = 18;
                    break;
                default:
                    mnTurn = 22;
                    break;
            }
            for (int i = 1; i <= 5; i++)
            {
                _TaskType[i - 1] = rnd1.Next(1, 4);
                _TaskMultiple[i - 1] = rnd1.Next(1, 5);
                _TaskDone[i - 1] = false;
            }
            CounterCol = rnd1.Next(1, 11);
            CounterRow = rnd1.Next(1, 11);
            CounterDirection = rnd1.Next(1, 5);
            for (int i = 1; i <= 10; i++)
            {
                _col1[i - 1] = 26;
                _col2[i - 1] = 26;
                _col3[i - 1] = 26;
                _col4[i - 1] = 26;
                _col5[i - 1] = 26;
                _col6[i - 1] = 26;
                _col7[i - 1] = 26;
                _col8[i - 1] = 26;
                _col9[i - 1] = 26;
                _cola[i - 1] = 26;
            }
            for (int i = 1; i <= 10; i++)
            {
                nLength = rnd1.Next(1, 7);
                nCol = rnd1.Next(1, 11);
                nRow = rnd1.Next(1, 11);
                nType = rnd1.Next(1, 7);
                switch (nType)
                {
                    case 1:
                        nType = 2;
                        break;
                    case 2:
                        nType = 6;
                        break;
                    case 3:
                        nType = 10;
                        break;
                    case 4:
                        nType = 14;
                        break;
                    case 5:
                        nType = 18;
                        break;
                    default:
                        nType = 22;
                        break;
                }
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
                    case 10:
                        _cola[nRow - 1] = nType;
                        break;
                }
                for (int j = 1; j <= nLength - 1; j++)
                {
                    nDirection = rnd1.Next(1, 5);
                    switch (nDirection)
                    {
                        case 1:
                            nRow = nRow - 1;
                            if (nRow == 0)
                            {
                                nRow = 10;
                            }
                            break;
                        case 2:
                            nCol = nCol + 1;
                            if (nCol == 11)
                            {
                                nCol = 1;
                            }
                            break;
                        case 3:
                            nRow = nRow + 1;
                            if (nRow == 11)
                            {
                                nRow = 1;
                            }
                            break;
                        default:
                            nCol = nCol - 1;
                            if (nCol == 0)
                            {
                                nCol = 10;
                            }
                            break;
                    }
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
                        case 10:
                            _cola[nRow - 1] = nType;
                            break;
                    }


                }

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
                Image = Image.FromFile(@"F Exit.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F player10.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F player11.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F player12.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F player13.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F player20.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F player21.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F player22.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F player23.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F player30.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F player31.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F player32.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"F player33.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"F player40.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"F player41.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"F player42.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
                Image = Image.FromFile(@"F player43.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture18 = new PictureBox
            {
                Name = "pictureBox18",
                Image = Image.FromFile(@"F player50.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture19 = new PictureBox
            {
                Name = "pictureBox19",
                Image = Image.FromFile(@"F player51.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture20 = new PictureBox
            {
                Name = "pictureBox20",
                Image = Image.FromFile(@"F player52.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture21 = new PictureBox
            {
                Name = "pictureBox21",
                Image = Image.FromFile(@"F player53.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture22 = new PictureBox
            {
                Name = "pictureBox22",
                Image = Image.FromFile(@"F player60.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture23 = new PictureBox
            {
                Name = "pictureBox23",
                Image = Image.FromFile(@"F player61.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture24 = new PictureBox
            {
                Name = "pictureBox24",
                Image = Image.FromFile(@"F player62.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture25 = new PictureBox
            {
                Name = "pictureBox25",
                Image = Image.FromFile(@"F player63.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture26 = new PictureBox
            {
                Name = "pictureBox26",
                Image = Image.FromFile(@"F sea.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture27 = new PictureBox
            {
                Name = "pictureBox27",
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
                case 20:
                    picAcross1.Image = picture20.Image;
                    break;
                case 21:
                    picAcross1.Image = picture21.Image;
                    break;
                case 22:
                    picAcross1.Image = picture22.Image;
                    break;
                case 23:
                    picAcross1.Image = picture23.Image;
                    break;
                case 24:
                    picAcross1.Image = picture24.Image;
                    break;
                case 25:
                    picAcross1.Image = picture25.Image;
                    break;
                case 26:
                    picAcross1.Image = picture26.Image;
                    break;
                default:
                    picAcross1.Image = picture27.Image;
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
                case 20:
                    picAcross2.Image = picture20.Image;
                    break;
                case 21:
                    picAcross2.Image = picture21.Image;
                    break;
                case 22:
                    picAcross2.Image = picture22.Image;
                    break;
                case 23:
                    picAcross2.Image = picture23.Image;
                    break;
                case 24:
                    picAcross2.Image = picture24.Image;
                    break;
                case 25:
                    picAcross2.Image = picture25.Image;
                    break;
                case 26:
                    picAcross2.Image = picture26.Image;
                    break;
                default:
                    picAcross2.Image = picture27.Image;
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
                case 20:
                    picAcross3.Image = picture20.Image;
                    break;
                case 21:
                    picAcross3.Image = picture21.Image;
                    break;
                case 22:
                    picAcross3.Image = picture22.Image;
                    break;
                case 23:
                    picAcross3.Image = picture23.Image;
                    break;
                case 24:
                    picAcross3.Image = picture24.Image;
                    break;
                case 25:
                    picAcross3.Image = picture25.Image;
                    break;
                case 26:
                    picAcross3.Image = picture26.Image;
                    break;
                default:
                    picAcross3.Image = picture27.Image;
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
                case 20:
                    picAcross4.Image = picture20.Image;
                    break;
                case 21:
                    picAcross4.Image = picture21.Image;
                    break;
                case 22:
                    picAcross4.Image = picture22.Image;
                    break;
                case 23:
                    picAcross4.Image = picture23.Image;
                    break;
                case 24:
                    picAcross4.Image = picture24.Image;
                    break;
                case 25:
                    picAcross4.Image = picture25.Image;
                    break;
                case 26:
                    picAcross4.Image = picture26.Image;
                    break;
                default:
                    picAcross4.Image = picture27.Image;
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
                case 20:
                    picAcross5.Image = picture20.Image;
                    break;
                case 21:
                    picAcross5.Image = picture21.Image;
                    break;
                case 22:
                    picAcross5.Image = picture22.Image;
                    break;
                case 23:
                    picAcross5.Image = picture23.Image;
                    break;
                case 24:
                    picAcross5.Image = picture24.Image;
                    break;
                case 25:
                    picAcross5.Image = picture25.Image;
                    break;
                case 26:
                    picAcross5.Image = picture26.Image;
                    break;
                default:
                    picAcross5.Image = picture27.Image;
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
                case 20:
                    picAcross6.Image = picture20.Image;
                    break;
                case 21:
                    picAcross6.Image = picture21.Image;
                    break;
                case 22:
                    picAcross6.Image = picture22.Image;
                    break;
                case 23:
                    picAcross6.Image = picture23.Image;
                    break;
                case 24:
                    picAcross6.Image = picture24.Image;
                    break;
                case 25:
                    picAcross6.Image = picture25.Image;
                    break;
                case 26:
                    picAcross6.Image = picture26.Image;
                    break;
                default:
                    picAcross6.Image = picture27.Image;
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
                case 20:
                    picAcross7.Image = picture20.Image;
                    break;
                case 21:
                    picAcross7.Image = picture21.Image;
                    break;
                case 22:
                    picAcross7.Image = picture22.Image;
                    break;
                case 23:
                    picAcross7.Image = picture23.Image;
                    break;
                case 24:
                    picAcross7.Image = picture24.Image;
                    break;
                case 25:
                    picAcross7.Image = picture25.Image;
                    break;
                case 26:
                    picAcross7.Image = picture26.Image;
                    break;
                default:
                    picAcross7.Image = picture27.Image;
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
                case 20:
                    picForward1.Image = picture20.Image;
                    break;
                case 21:
                    picForward1.Image = picture21.Image;
                    break;
                case 22:
                    picForward1.Image = picture22.Image;
                    break;
                case 23:
                    picForward1.Image = picture23.Image;
                    break;
                case 24:
                    picForward1.Image = picture24.Image;
                    break;
                case 25:
                    picForward1.Image = picture25.Image;
                    break;
                case 26:
                    picForward1.Image = picture26.Image;
                    break;
                default:
                    picForward1.Image = picture27.Image;
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
                case 20:
                    picForward2.Image = picture20.Image;
                    break;
                case 21:
                    picForward2.Image = picture21.Image;
                    break;
                case 22:
                    picForward2.Image = picture22.Image;
                    break;
                case 23:
                    picForward2.Image = picture23.Image;
                    break;
                case 24:
                    picForward2.Image = picture24.Image;
                    break;
                case 25:
                    picForward2.Image = picture25.Image;
                    break;
                case 26:
                    picForward2.Image = picture26.Image;
                    break;
                default:
                    picForward2.Image = picture27.Image;
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
                case 20:
                    picForward3.Image = picture20.Image;
                    break;
                case 21:
                    picForward3.Image = picture21.Image;
                    break;
                case 22:
                    picForward3.Image = picture22.Image;
                    break;
                case 23:
                    picForward3.Image = picture23.Image;
                    break;
                case 24:
                    picForward3.Image = picture24.Image;
                    break;
                case 25:
                    picForward3.Image = picture25.Image;
                    break;
                case 26:
                    picForward3.Image = picture26.Image;
                    break;
                default:
                    picForward3.Image = picture27.Image;
                    break;
            }

            switch (mnTurn)
            {
                case 1:
                    picTurn.Image = picture1.Image;
                    break;
                case 2:
                    picTurn.Image = picture2.Image;
                    break;
                case 3:
                    picTurn.Image = picture3.Image;
                    break;
                case 4:
                    picTurn.Image = picture4.Image;
                    break;
                case 5:
                    picTurn.Image = picture5.Image;
                    break;
                case 6:
                    picTurn.Image = picture6.Image;
                    break;
                case 7:
                    picTurn.Image = picture7.Image;
                    break;
                case 8:
                    picTurn.Image = picture8.Image;
                    break;
                case 9:
                    picTurn.Image = picture9.Image;
                    break;
                case 10:
                    picTurn.Image = picture10.Image;
                    break;
                case 11:
                    picTurn.Image = picture11.Image;
                    break;
                case 12:
                    picTurn.Image = picture12.Image;
                    break;
                case 13:
                    picTurn.Image = picture13.Image;
                    break;
                case 14:
                    picTurn.Image = picture14.Image;
                    break;
                case 15:
                    picTurn.Image = picture15.Image;
                    break;
                case 16:
                    picTurn.Image = picture16.Image;
                    break;
                case 17:
                    picTurn.Image = picture17.Image;
                    break;
                case 18:
                    picTurn.Image = picture18.Image;
                    break;
                case 19:
                    picTurn.Image = picture19.Image;
                    break;
                case 20:
                    picTurn.Image = picture20.Image;
                    break;
                case 21:
                    picTurn.Image = picture21.Image;
                    break;
                case 22:
                    picTurn.Image = picture22.Image;
                    break;
                case 23:
                    picTurn.Image = picture23.Image;
                    break;
                case 24:
                    picTurn.Image = picture24.Image;
                    break;
                case 25:
                    picTurn.Image = picture25.Image;
                    break;
                case 26:
                    picTurn.Image = picture26.Image;
                    break;
                default:
                    picTurn.Image = picture27.Image;
                    break;
            }

            if (lstTask.Items.Count > 0)
            {
                do
                {
                    lstTask.Items.RemoveAt(0);
                } while (lstTask.Items.Count > 0);
            }
            for (int i = 1; i <= 5; i++)
            {
                sWord = "x" + Convert.ToString(_TaskMultiple[i - 1]) + " ";
                switch (_TaskType[i - 1])
                {
                    case 1:
                        sWord = sWord + "Oil";
                        break;
                    case 2:
                        sWord = sWord + "Dam";
                        break;
                    default:
                        sWord = sWord + "Factory";
                        break;
                }
                lstTask.Items.Add(sWord);
            }
            mnTask = 1;
            mnLeft = _TaskMultiple[0];
        }

        private void btnComply_Click(object sender, EventArgs e)
        {
            if (mnTask == 6)
            {
                nScore = nScore + 10;
                lblScore.Text = "Score = " + Convert.ToString(nScore);
            }

        }

        private void btnLeft_Click_1(object sender, EventArgs e)
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
                Image = Image.FromFile(@"F Exit.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F player10.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F player11.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F player12.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F player13.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F player20.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F player21.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F player22.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F player23.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F player30.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F player31.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F player32.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"F player33.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"F player40.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"F player41.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"F player42.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
                Image = Image.FromFile(@"F player43.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture18 = new PictureBox
            {
                Name = "pictureBox18",
                Image = Image.FromFile(@"F player50.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture19 = new PictureBox
            {
                Name = "pictureBox19",
                Image = Image.FromFile(@"F player51.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture20 = new PictureBox
            {
                Name = "pictureBox20",
                Image = Image.FromFile(@"F player52.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture21 = new PictureBox
            {
                Name = "pictureBox21",
                Image = Image.FromFile(@"F player53.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture22 = new PictureBox
            {
                Name = "pictureBox22",
                Image = Image.FromFile(@"F player60.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture23 = new PictureBox
            {
                Name = "pictureBox23",
                Image = Image.FromFile(@"F player61.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture24 = new PictureBox
            {
                Name = "pictureBox24",
                Image = Image.FromFile(@"F player62.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture25 = new PictureBox
            {
                Name = "pictureBox25",
                Image = Image.FromFile(@"F player63.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture26 = new PictureBox
            {
                Name = "pictureBox26",
                Image = Image.FromFile(@"F sea.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture27 = new PictureBox
            {
                Name = "pictureBox27",
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
                case 20:
                    picAcross1.Image = picture20.Image;
                    break;
                case 21:
                    picAcross1.Image = picture21.Image;
                    break;
                case 22:
                    picAcross1.Image = picture22.Image;
                    break;
                case 23:
                    picAcross1.Image = picture23.Image;
                    break;
                case 24:
                    picAcross1.Image = picture24.Image;
                    break;
                case 25:
                    picAcross1.Image = picture25.Image;
                    break;
                case 26:
                    picAcross1.Image = picture26.Image;
                    break;
                default:
                    picAcross1.Image = picture27.Image;
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
                case 20:
                    picAcross2.Image = picture20.Image;
                    break;
                case 21:
                    picAcross2.Image = picture21.Image;
                    break;
                case 22:
                    picAcross2.Image = picture22.Image;
                    break;
                case 23:
                    picAcross2.Image = picture23.Image;
                    break;
                case 24:
                    picAcross2.Image = picture24.Image;
                    break;
                case 25:
                    picAcross2.Image = picture25.Image;
                    break;
                case 26:
                    picAcross2.Image = picture26.Image;
                    break;
                default:
                    picAcross2.Image = picture27.Image;
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
                case 20:
                    picAcross3.Image = picture20.Image;
                    break;
                case 21:
                    picAcross3.Image = picture21.Image;
                    break;
                case 22:
                    picAcross3.Image = picture22.Image;
                    break;
                case 23:
                    picAcross3.Image = picture23.Image;
                    break;
                case 24:
                    picAcross3.Image = picture24.Image;
                    break;
                case 25:
                    picAcross3.Image = picture25.Image;
                    break;
                case 26:
                    picAcross3.Image = picture26.Image;
                    break;
                default:
                    picAcross3.Image = picture27.Image;
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
                case 20:
                    picAcross4.Image = picture20.Image;
                    break;
                case 21:
                    picAcross4.Image = picture21.Image;
                    break;
                case 22:
                    picAcross4.Image = picture22.Image;
                    break;
                case 23:
                    picAcross4.Image = picture23.Image;
                    break;
                case 24:
                    picAcross4.Image = picture24.Image;
                    break;
                case 25:
                    picAcross4.Image = picture25.Image;
                    break;
                case 26:
                    picAcross4.Image = picture26.Image;
                    break;
                default:
                    picAcross4.Image = picture27.Image;
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
                case 20:
                    picAcross5.Image = picture20.Image;
                    break;
                case 21:
                    picAcross5.Image = picture21.Image;
                    break;
                case 22:
                    picAcross5.Image = picture22.Image;
                    break;
                case 23:
                    picAcross5.Image = picture23.Image;
                    break;
                case 24:
                    picAcross5.Image = picture24.Image;
                    break;
                case 25:
                    picAcross5.Image = picture25.Image;
                    break;
                case 26:
                    picAcross5.Image = picture26.Image;
                    break;
                default:
                    picAcross5.Image = picture27.Image;
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
                case 20:
                    picAcross6.Image = picture20.Image;
                    break;
                case 21:
                    picAcross6.Image = picture21.Image;
                    break;
                case 22:
                    picAcross6.Image = picture22.Image;
                    break;
                case 23:
                    picAcross6.Image = picture23.Image;
                    break;
                case 24:
                    picAcross6.Image = picture24.Image;
                    break;
                case 25:
                    picAcross6.Image = picture25.Image;
                    break;
                case 26:
                    picAcross6.Image = picture26.Image;
                    break;
                default:
                    picAcross6.Image = picture27.Image;
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
                case 20:
                    picAcross7.Image = picture20.Image;
                    break;
                case 21:
                    picAcross7.Image = picture21.Image;
                    break;
                case 22:
                    picAcross7.Image = picture22.Image;
                    break;
                case 23:
                    picAcross7.Image = picture23.Image;
                    break;
                case 24:
                    picAcross7.Image = picture24.Image;
                    break;
                case 25:
                    picAcross7.Image = picture25.Image;
                    break;
                case 26:
                    picAcross7.Image = picture26.Image;
                    break;
                default:
                    picAcross7.Image = picture27.Image;
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
                case 20:
                    picForward1.Image = picture20.Image;
                    break;
                case 21:
                    picForward1.Image = picture21.Image;
                    break;
                case 22:
                    picForward1.Image = picture22.Image;
                    break;
                case 23:
                    picForward1.Image = picture23.Image;
                    break;
                case 24:
                    picForward1.Image = picture24.Image;
                    break;
                case 25:
                    picForward1.Image = picture25.Image;
                    break;
                case 26:
                    picForward1.Image = picture26.Image;
                    break;
                default:
                    picForward1.Image = picture27.Image;
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
                case 20:
                    picForward2.Image = picture20.Image;
                    break;
                case 21:
                    picForward2.Image = picture21.Image;
                    break;
                case 22:
                    picForward2.Image = picture22.Image;
                    break;
                case 23:
                    picForward2.Image = picture23.Image;
                    break;
                case 24:
                    picForward2.Image = picture24.Image;
                    break;
                case 25:
                    picForward2.Image = picture25.Image;
                    break;
                case 26:
                    picForward2.Image = picture26.Image;
                    break;
                default:
                    picForward2.Image = picture27.Image;
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
                case 20:
                    picForward3.Image = picture20.Image;
                    break;
                case 21:
                    picForward3.Image = picture21.Image;
                    break;
                case 22:
                    picForward3.Image = picture22.Image;
                    break;
                case 23:
                    picForward3.Image = picture23.Image;
                    break;
                case 24:
                    picForward3.Image = picture24.Image;
                    break;
                case 25:
                    picForward3.Image = picture25.Image;
                    break;
                case 26:
                    picForward3.Image = picture26.Image;
                    break;
                default:
                    picForward3.Image = picture27.Image;
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
                Image = Image.FromFile(@"F Exit.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F player10.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F player11.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F player12.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F player13.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F player20.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F player21.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F player22.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F player23.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F player30.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F player31.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F player32.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"F player33.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"F player40.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"F player41.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"F player42.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
                Image = Image.FromFile(@"F player43.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture18 = new PictureBox
            {
                Name = "pictureBox18",
                Image = Image.FromFile(@"F player50.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture19 = new PictureBox
            {
                Name = "pictureBox19",
                Image = Image.FromFile(@"F player51.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture20 = new PictureBox
            {
                Name = "pictureBox20",
                Image = Image.FromFile(@"F player52.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture21 = new PictureBox
            {
                Name = "pictureBox21",
                Image = Image.FromFile(@"F player53.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture22 = new PictureBox
            {
                Name = "pictureBox22",
                Image = Image.FromFile(@"F player60.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture23 = new PictureBox
            {
                Name = "pictureBox23",
                Image = Image.FromFile(@"F player61.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture24 = new PictureBox
            {
                Name = "pictureBox24",
                Image = Image.FromFile(@"F player62.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture25 = new PictureBox
            {
                Name = "pictureBox25",
                Image = Image.FromFile(@"F player63.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture26 = new PictureBox
            {
                Name = "pictureBox26",
                Image = Image.FromFile(@"F sea.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture27 = new PictureBox
            {
                Name = "pictureBox27",
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
                case 20:
                    picAcross1.Image = picture20.Image;
                    break;
                case 21:
                    picAcross1.Image = picture21.Image;
                    break;
                case 22:
                    picAcross1.Image = picture22.Image;
                    break;
                case 23:
                    picAcross1.Image = picture23.Image;
                    break;
                case 24:
                    picAcross1.Image = picture24.Image;
                    break;
                case 25:
                    picAcross1.Image = picture25.Image;
                    break;
                case 26:
                    picAcross1.Image = picture26.Image;
                    break;
                default:
                    picAcross1.Image = picture27.Image;
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
                case 20:
                    picAcross2.Image = picture20.Image;
                    break;
                case 21:
                    picAcross2.Image = picture21.Image;
                    break;
                case 22:
                    picAcross2.Image = picture22.Image;
                    break;
                case 23:
                    picAcross2.Image = picture23.Image;
                    break;
                case 24:
                    picAcross2.Image = picture24.Image;
                    break;
                case 25:
                    picAcross2.Image = picture25.Image;
                    break;
                case 26:
                    picAcross2.Image = picture26.Image;
                    break;
                default:
                    picAcross2.Image = picture27.Image;
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
                case 20:
                    picAcross3.Image = picture20.Image;
                    break;
                case 21:
                    picAcross3.Image = picture21.Image;
                    break;
                case 22:
                    picAcross3.Image = picture22.Image;
                    break;
                case 23:
                    picAcross3.Image = picture23.Image;
                    break;
                case 24:
                    picAcross3.Image = picture24.Image;
                    break;
                case 25:
                    picAcross3.Image = picture25.Image;
                    break;
                case 26:
                    picAcross3.Image = picture26.Image;
                    break;
                default:
                    picAcross3.Image = picture27.Image;
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
                case 20:
                    picAcross4.Image = picture20.Image;
                    break;
                case 21:
                    picAcross4.Image = picture21.Image;
                    break;
                case 22:
                    picAcross4.Image = picture22.Image;
                    break;
                case 23:
                    picAcross4.Image = picture23.Image;
                    break;
                case 24:
                    picAcross4.Image = picture24.Image;
                    break;
                case 25:
                    picAcross4.Image = picture25.Image;
                    break;
                case 26:
                    picAcross4.Image = picture26.Image;
                    break;
                default:
                    picAcross4.Image = picture27.Image;
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
                case 20:
                    picAcross5.Image = picture20.Image;
                    break;
                case 21:
                    picAcross5.Image = picture21.Image;
                    break;
                case 22:
                    picAcross5.Image = picture22.Image;
                    break;
                case 23:
                    picAcross5.Image = picture23.Image;
                    break;
                case 24:
                    picAcross5.Image = picture24.Image;
                    break;
                case 25:
                    picAcross5.Image = picture25.Image;
                    break;
                case 26:
                    picAcross5.Image = picture26.Image;
                    break;
                default:
                    picAcross5.Image = picture27.Image;
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
                case 20:
                    picAcross6.Image = picture20.Image;
                    break;
                case 21:
                    picAcross6.Image = picture21.Image;
                    break;
                case 22:
                    picAcross6.Image = picture22.Image;
                    break;
                case 23:
                    picAcross6.Image = picture23.Image;
                    break;
                case 24:
                    picAcross6.Image = picture24.Image;
                    break;
                case 25:
                    picAcross6.Image = picture25.Image;
                    break;
                case 26:
                    picAcross6.Image = picture26.Image;
                    break;
                default:
                    picAcross6.Image = picture27.Image;
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
                case 20:
                    picAcross7.Image = picture20.Image;
                    break;
                case 21:
                    picAcross7.Image = picture21.Image;
                    break;
                case 22:
                    picAcross7.Image = picture22.Image;
                    break;
                case 23:
                    picAcross7.Image = picture23.Image;
                    break;
                case 24:
                    picAcross7.Image = picture24.Image;
                    break;
                case 25:
                    picAcross7.Image = picture25.Image;
                    break;
                case 26:
                    picAcross7.Image = picture26.Image;
                    break;
                default:
                    picAcross7.Image = picture27.Image;
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
                case 20:
                    picForward1.Image = picture20.Image;
                    break;
                case 21:
                    picForward1.Image = picture21.Image;
                    break;
                case 22:
                    picForward1.Image = picture22.Image;
                    break;
                case 23:
                    picForward1.Image = picture23.Image;
                    break;
                case 24:
                    picForward1.Image = picture24.Image;
                    break;
                case 25:
                    picForward1.Image = picture25.Image;
                    break;
                case 26:
                    picForward1.Image = picture26.Image;
                    break;
                default:
                    picForward1.Image = picture27.Image;
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
                case 20:
                    picForward2.Image = picture20.Image;
                    break;
                case 21:
                    picForward2.Image = picture21.Image;
                    break;
                case 22:
                    picForward2.Image = picture22.Image;
                    break;
                case 23:
                    picForward2.Image = picture23.Image;
                    break;
                case 24:
                    picForward2.Image = picture24.Image;
                    break;
                case 25:
                    picForward2.Image = picture25.Image;
                    break;
                case 26:
                    picForward2.Image = picture26.Image;
                    break;
                default:
                    picForward2.Image = picture27.Image;
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
                case 20:
                    picForward3.Image = picture20.Image;
                    break;
                case 21:
                    picForward3.Image = picture21.Image;
                    break;
                case 22:
                    picForward3.Image = picture22.Image;
                    break;
                case 23:
                    picForward3.Image = picture23.Image;
                    break;
                case 24:
                    picForward3.Image = picture24.Image;
                    break;
                case 25:
                    picForward3.Image = picture25.Image;
                    break;
                case 26:
                    picForward3.Image = picture26.Image;
                    break;
                default:
                    picForward3.Image = picture27.Image;
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
            int nCol, nRow, nType;
            int nLength,nDirection;
            String sWord;

            mnTurn = rnd1.Next(1, 7);
            switch (mnTurn)
            {
                case 1:
                    mnTurn = 2;
                    break;
                case 2:
                    mnTurn = 6;
                    break;
                case 3:
                    mnTurn = 10;
                    break;
                case 4:
                    mnTurn = 14;
                    break;
                case 5:
                    mnTurn = 18;
                    break;
                default:
                    mnTurn = 22;
                    break;
            }
            for (int i = 1; i <= 5; i++)
            {
                _TaskType[i-1] = rnd1.Next(1, 4);
                _TaskMultiple[i-1] = rnd1.Next(1, 5);
                _TaskDone[i - 1] = false;
            }
            CounterCol = rnd1.Next(1, 11);
            CounterRow = rnd1.Next(1, 11);
            CounterDirection = rnd1.Next(1, 5);
            for (int i = 1; i <= 10; i++)
            {
                _col1[i - 1] = 26;
                _col2[i - 1] = 26;
                _col3[i - 1] = 26;
                _col4[i - 1] = 26;
                _col5[i - 1] = 26;
                _col6[i - 1] = 26;
                _col7[i - 1] = 26;
                _col8[i - 1] = 26;
                _col9[i - 1] = 26;
                _cola[i - 1] = 26;
            }
            for (int i = 1; i <= 10; i++)
            {
                nLength = rnd1.Next(1, 7);
                nCol = rnd1.Next(1, 11);
                nRow = rnd1.Next(1, 11);
                nType = rnd1.Next(1, 7);
                switch (nType)
                {
                    case 1:
                        nType = 2;
                        break;
                    case 2:
                        nType = 6;
                        break;
                    case 3:
                        nType = 10;
                        break;
                    case 4:
                        nType = 14;
                        break;
                    case 5:
                        nType = 18;
                        break;
                    default:
                        nType = 22;
                        break;
                }
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
                    case 10:
                        _cola[nRow - 1] = nType;
                        break;
                }
                for (int j = 1; j <= nLength-1; j++)
                {
                    nDirection = rnd1.Next(1, 5);
                    switch (nDirection)
                    {
                        case 1:
                            nRow = nRow - 1;
                            if (nRow == 0)
                            {
                                nRow = 10;
                            }
                            break;
                        case 2:
                            nCol = nCol + 1;
                            if (nCol == 11)
                            {
                                nCol = 1;
                            }
                            break;
                        case 3:
                            nRow = nRow + 1;
                            if (nRow == 11)
                            {
                                nRow = 1;
                            }
                            break;
                        default:
                            nCol = nCol - 1;
                            if (nCol == 0)
                            {
                                nCol = 10;
                            }
                            break;
                    }
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
                        case 10:
                            _cola[nRow - 1] = nType;
                            break;
                    }
            

                }

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
                Image = Image.FromFile(@"F Exit.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F player10.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F player11.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F player12.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F player13.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F player20.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F player21.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F player22.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F player23.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F player30.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F player31.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F player32.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"F player33.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"F player40.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"F player41.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"F player42.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
                Image = Image.FromFile(@"F player43.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture18 = new PictureBox
            {
                Name = "pictureBox18",
                Image = Image.FromFile(@"F player50.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture19 = new PictureBox
            {
                Name = "pictureBox19",
                Image = Image.FromFile(@"F player51.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture20 = new PictureBox
            {
                Name = "pictureBox20",
                Image = Image.FromFile(@"F player52.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture21 = new PictureBox
            {
                Name = "pictureBox21",
                Image = Image.FromFile(@"F player53.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture22 = new PictureBox
            {
                Name = "pictureBox22",
                Image = Image.FromFile(@"F player60.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture23 = new PictureBox
            {
                Name = "pictureBox23",
                Image = Image.FromFile(@"F player61.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture24 = new PictureBox
            {
                Name = "pictureBox24",
                Image = Image.FromFile(@"F player62.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture25= new PictureBox
            {
                Name = "pictureBox25",
                Image = Image.FromFile(@"F player63.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture26= new PictureBox
            {
                Name = "pictureBox26",
                Image = Image.FromFile(@"F sea.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture27 = new PictureBox
            {
                Name = "pictureBox27",
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
                case 20:
                    picAcross1.Image = picture20.Image;
                    break;
                case 21:
                    picAcross1.Image = picture21.Image;
                    break;
                case 22:
                    picAcross1.Image = picture22.Image;
                    break;
                case 23:
                    picAcross1.Image = picture23.Image;
                    break;
                case 24:
                    picAcross1.Image = picture24.Image;
                    break;
                case 25:
                    picAcross1.Image = picture25.Image;
                    break;
                case 26:
                    picAcross1.Image = picture26.Image;
                    break;
                default:
                    picAcross1.Image = picture27.Image;
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
                case 20:
                    picAcross2.Image = picture20.Image;
                    break;
                case 21:
                    picAcross2.Image = picture21.Image;
                    break;
                case 22:
                    picAcross2.Image = picture22.Image;
                    break;
                case 23:
                    picAcross2.Image = picture23.Image;
                    break;
                case 24:
                    picAcross2.Image = picture24.Image;
                    break;
                case 25:
                    picAcross2.Image = picture25.Image;
                    break;
                case 26:
                    picAcross2.Image = picture26.Image;
                    break;
                default:
                    picAcross2.Image = picture27.Image;
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
                case 20:
                    picAcross3.Image = picture20.Image;
                    break;
                case 21:
                    picAcross3.Image = picture21.Image;
                    break;
                case 22:
                    picAcross3.Image = picture22.Image;
                    break;
                case 23:
                    picAcross3.Image = picture23.Image;
                    break;
                case 24:
                    picAcross3.Image = picture24.Image;
                    break;
                case 25:
                    picAcross3.Image = picture25.Image;
                    break;
                case 26:
                    picAcross3.Image = picture26.Image;
                    break;
                default:
                    picAcross3.Image = picture27.Image;
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
                case 20:
                    picAcross4.Image = picture20.Image;
                    break;
                case 21:
                    picAcross4.Image = picture21.Image;
                    break;
                case 22:
                    picAcross4.Image = picture22.Image;
                    break;
                case 23:
                    picAcross4.Image = picture23.Image;
                    break;
                case 24:
                    picAcross4.Image = picture24.Image;
                    break;
                case 25:
                    picAcross4.Image = picture25.Image;
                    break;
                case 26:
                    picAcross4.Image = picture26.Image;
                    break;
                default:
                    picAcross4.Image = picture27.Image;
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
                case 20:
                    picAcross5.Image = picture20.Image;
                    break;
                case 21:
                    picAcross5.Image = picture21.Image;
                    break;
                case 22:
                    picAcross5.Image = picture22.Image;
                    break;
                case 23:
                    picAcross5.Image = picture23.Image;
                    break;
                case 24:
                    picAcross5.Image = picture24.Image;
                    break;
                case 25:
                    picAcross5.Image = picture25.Image;
                    break;
                case 26:
                    picAcross5.Image = picture26.Image;
                    break;
                default:
                    picAcross5.Image = picture27.Image;
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
                case 20:
                    picAcross6.Image = picture20.Image;
                    break;
                case 21:
                    picAcross6.Image = picture21.Image;
                    break;
                case 22:
                    picAcross6.Image = picture22.Image;
                    break;
                case 23:
                    picAcross6.Image = picture23.Image;
                    break;
                case 24:
                    picAcross6.Image = picture24.Image;
                    break;
                case 25:
                    picAcross6.Image = picture25.Image;
                    break;
                case 26:
                    picAcross6.Image = picture26.Image;
                    break;
                default:
                    picAcross6.Image = picture27.Image;
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
                case 20:
                    picAcross7.Image = picture20.Image;
                    break;
                case 21:
                    picAcross7.Image = picture21.Image;
                    break;
                case 22:
                    picAcross7.Image = picture22.Image;
                    break;
                case 23:
                    picAcross7.Image = picture23.Image;
                    break;
                case 24:
                    picAcross7.Image = picture24.Image;
                    break;
                case 25:
                    picAcross7.Image = picture25.Image;
                    break;
                case 26:
                    picAcross7.Image = picture26.Image;
                    break;
                default:
                    picAcross7.Image = picture27.Image;
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
                case 20:
                    picForward1.Image = picture20.Image;
                    break;
                case 21:
                    picForward1.Image = picture21.Image;
                    break;
                case 22:
                    picForward1.Image = picture22.Image;
                    break;
                case 23:
                    picForward1.Image = picture23.Image;
                    break;
                case 24:
                    picForward1.Image = picture24.Image;
                    break;
                case 25:
                    picForward1.Image = picture25.Image;
                    break;
                case 26:
                    picForward1.Image = picture26.Image;
                    break;
                default:
                    picForward1.Image = picture27.Image;
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
                case 20:
                    picForward2.Image = picture20.Image;
                    break;
                case 21:
                    picForward2.Image = picture21.Image;
                    break;
                case 22:
                    picForward2.Image = picture22.Image;
                    break;
                case 23:
                    picForward2.Image = picture23.Image;
                    break;
                case 24:
                    picForward2.Image = picture24.Image;
                    break;
                case 25:
                    picForward2.Image = picture25.Image;
                    break;
                case 26:
                    picForward2.Image = picture26.Image;
                    break;
                default:
                    picForward2.Image = picture27.Image;
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
                case 20:
                    picForward3.Image = picture20.Image;
                    break;
                case 21:
                    picForward3.Image = picture21.Image;
                    break;
                case 22:
                    picForward3.Image = picture22.Image;
                    break;
                case 23:
                    picForward3.Image = picture23.Image;
                    break;
                case 24:
                    picForward3.Image = picture24.Image;
                    break;
                case 25:
                    picForward3.Image = picture25.Image;
                    break;
                case 26:
                    picForward3.Image = picture26.Image;
                    break;
                default:
                    picForward3.Image = picture27.Image;
                    break;
            }

            switch (mnTurn)
            {
                case 1:
                    picTurn.Image = picture1.Image;
                    break;
                case 2:
                    picTurn.Image = picture2.Image;
                    break;
                case 3:
                    picTurn.Image = picture3.Image;
                    break;
                case 4:
                    picTurn.Image = picture4.Image;
                    break;
                case 5:
                    picTurn.Image = picture5.Image;
                    break;
                case 6:
                    picTurn.Image = picture6.Image;
                    break;
                case 7:
                    picTurn.Image = picture7.Image;
                    break;
                case 8:
                    picTurn.Image = picture8.Image;
                    break;
                case 9:
                    picTurn.Image = picture9.Image;
                    break;
                case 10:
                    picTurn.Image = picture10.Image;
                    break;
                case 11:
                    picTurn.Image = picture11.Image;
                    break;
                case 12:
                    picTurn.Image = picture12.Image;
                    break;
                case 13:
                    picTurn.Image = picture13.Image;
                    break;
                case 14:
                    picTurn.Image = picture14.Image;
                    break;
                case 15:
                    picTurn.Image = picture15.Image;
                    break;
                case 16:
                    picTurn.Image = picture16.Image;
                    break;
                case 17:
                    picTurn.Image = picture17.Image;
                    break;
                case 18:
                    picTurn.Image = picture18.Image;
                    break;
                case 19:
                    picTurn.Image = picture19.Image;
                    break;
                case 20:
                    picTurn.Image = picture20.Image;
                    break;
                case 21:
                    picTurn.Image = picture21.Image;
                    break;
                case 22:
                    picTurn.Image = picture22.Image;
                    break;
                case 23:
                    picTurn.Image = picture23.Image;
                    break;
                case 24:
                    picTurn.Image = picture24.Image;
                    break;
                case 25:
                    picTurn.Image = picture25.Image;
                    break;
                case 26:
                    picTurn.Image = picture26.Image;
                    break;
                default:
                    picTurn.Image = picture27.Image;
                    break;
            }

            if (lstTask.Items.Count > 0)
            {
                do
                {
                    lstTask.Items.RemoveAt(0);
                } while (lstTask.Items.Count > 0);
            }
            for (int i = 1; i <= 5; i++)
            {
                sWord = "x" + Convert.ToString(_TaskMultiple[i - 1]) + " ";
                switch (_TaskType[i - 1])
                {
                    case 1:
                        sWord = sWord + "Oil";
                        break;
                    case 2:
                        sWord = sWord + "Dam";
                        break;
                    default:
                        sWord = sWord + "Factory";
                        break;
                }
                lstTask.Items.Add(sWord);
            }
            mnTask = 1;
            mnLeft = _TaskMultiple[0];
        }
    }
}
