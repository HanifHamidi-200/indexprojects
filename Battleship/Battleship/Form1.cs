using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship
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
        private static List<int> _enemy1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _enemy2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _enemy3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _enemy4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _enemy5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _enemy6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _enemy7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _enemy8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _enemy9 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _enemya = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _HolderACol = new List<int> { 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _HolderARow = new List<int> { 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _HolderFCol = new List<int> { 0, 0, 0 };
        private static List<int> _HolderFRow = new List<int> { 0, 0, 0 };
        private int CounterCol, CounterRow, CounterDirection;
        private int nScore = 0;
        private int nNumber;
        public cLookup Lookup = new cLookup();

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
                Image = Image.FromFile(@"F land.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F sea.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F Exit.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F landings1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F landings2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F landings3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F type1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F type2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F type3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F type4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
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
                default:
                    picAcross1.Image = picture11.Image;
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
                default:
                    picAcross2.Image = picture11.Image;
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
                default:
                    picAcross3.Image = picture11.Image;
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
                default:
                    picAcross4.Image = picture11.Image;
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
                default:
                    picAcross5.Image = picture11.Image;
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
                default:
                    picAcross6.Image = picture11.Image;
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
                default:
                    picAcross7.Image = picture11.Image;
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
                default:
                    picForward1.Image = picture11.Image;
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
                default:
                    picForward2.Image = picture11.Image;
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
                default:
                    picForward3.Image = picture11.Image;
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
                Image = Image.FromFile(@"F land.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F sea.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F Exit.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F landings1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F landings2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F landings3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F type1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F type2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F type3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F type4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
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
                default:
                    picAcross1.Image = picture11.Image;
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
                default:
                    picAcross2.Image = picture11.Image;
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
                default:
                    picAcross3.Image = picture11.Image;
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
                default:
                    picAcross4.Image = picture11.Image;
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
                default:
                    picAcross5.Image = picture11.Image;
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
                default:
                    picAcross6.Image = picture11.Image;
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
                default:
                    picAcross7.Image = picture11.Image;
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
                default:
                    picForward1.Image = picture11.Image;
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
                default:
                    picForward2.Image = picture11.Image;
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
                default:
                    picForward3.Image = picture11.Image;
                    break;
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
                Image = Image.FromFile(@"F land.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F sea.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F Exit.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F landings1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F landings2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F landings3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F type1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F type2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F type3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F type4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
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
                default:
                    picAcross1.Image = picture11.Image;
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
                default:
                    picAcross2.Image = picture11.Image;
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
                default:
                    picAcross3.Image = picture11.Image;
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
                default:
                    picAcross4.Image = picture11.Image;
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
                default:
                    picAcross5.Image = picture11.Image;
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
                default:
                    picAcross6.Image = picture11.Image;
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
                default:
                    picAcross7.Image = picture11.Image;
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
                default:
                    picForward1.Image = picture11.Image;
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
                default:
                    picForward2.Image = picture11.Image;
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
                default:
                    picForward3.Image = picture11.Image;
                    break;
            }
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nCol, nRow, nType, nLength;
            int nDirection;
        
            for (int i = 1; i <= 10; i++)
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
            }
            for (int i = 1; i <= 10; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col2[i - 1] = 1;
                }
                else
                {
                    _col2[i - 1] = 2;
                }
            }
            for (int i = 1; i <= 10; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col3[i - 1] = 1;
                }
                else
                {
                    _col3[i - 1] = 2;
                }
            }
            for (int i = 1; i <= 10; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col4[i - 1] = 1;
                }
                else
                {
                    _col4[i - 1] = 2;
                }
            }
            for (int i = 1; i <= 10; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col5[i - 1] = 1;
                }
                else
                {
                    _col5[i - 1] = 2;
                }
            }
            for (int i = 1; i <= 10; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col6[i - 1] = 1;
                }
                else
                {
                    _col6[i - 1] = 2;
                }
            }
            for (int i = 1; i <= 10; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col7[i - 1] = 1;
                }
                else
                {
                    _col7[i - 1] = 2;
                }
            }
            for (int i = 1; i <= 10; i++)
            {
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
            for (int i = 1; i <= 10; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col9[i - 1] = 1;
                }
                else
                {
                    _col9[i - 1] = 2;
                }
            }
            for (int i = 1; i <= 10; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _cola[i - 1] = 1;
                }
                else
                {
                    _cola[i - 1] = 2;
                }
            }

            for (int i = 1; i <= 6; i++)
            {
                nCol = rnd1.Next(1, 11);
                nRow = rnd1.Next(1, 11);
                nType = rnd1.Next(7, 11);
                nLength = nType;
                nDirection = rnd1.Next(1, 5);
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

            for (int i = 1; i <= 10; i++)
            {
                _enemy1[i - 1] = 2;
                _enemy2[i - 1] = 2;
                _enemy3[i - 1] = 2;
                _enemy4[i - 1] = 2;
                _enemy5[i - 1] = 2;
                _enemy6[i - 1] = 2;
                _enemy7[i - 1] = 2;
                _enemy8[i - 1] = 2;
                _enemy9[i - 1] = 2;
                _enemya[i - 1] = 2;
            }

            for (int i = 1; i <= 6; i++)
            {
                nCol = rnd1.Next(1, 11);
                nRow = rnd1.Next(1, 11);
                nType = rnd1.Next(7, 11);
                nLength = nType;
                nDirection = rnd1.Next(1, 5);
                switch (nCol)
                {
                    case 1:
                        _enemy1[nRow - 1] = nType;
                        break;
                    case 2:
                        _enemy2[nRow - 1] = nType;
                        break;
                    case 3:
                        _enemy3[nRow - 1] = nType;
                        break;
                    case 4:
                        _enemy4[nRow - 1] = nType;
                        break;
                    case 5:
                        _enemy5[nRow - 1] = nType;
                        break;
                    case 6:
                        _enemy6[nRow - 1] = nType;
                        break;
                    case 7:
                        _enemy7[nRow - 1] = nType;
                        break;
                    case 8:
                        _enemy8[nRow - 1] = nType;
                        break;
                    case 9:
                        _enemy9[nRow - 1] = nType;
                        break;
                    case 10:
                        _enemya[nRow - 1] = nType;
                        break;
                }
                for (int j = 1; j <= nLength - 1; j++)
                {
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
                            _enemy1[nRow - 1] = nType;
                            break;
                        case 2:
                            _enemy2[nRow - 1] = nType;
                            break;
                        case 3:
                            _enemy3[nRow - 1] = nType;
                            break;
                        case 4:
                            _enemy4[nRow - 1] = nType;
                            break;
                        case 5:
                            _enemy5[nRow - 1] = nType;
                            break;
                        case 6:
                            _enemy6[nRow - 1] = nType;
                            break;
                        case 7:
                            _enemy7[nRow - 1] = nType;
                            break;
                        case 8:
                            _enemy8[nRow - 1] = nType;
                            break;
                        case 9:
                            _enemy9[nRow - 1] = nType;
                            break;
                        case 10:
                            _enemya[nRow - 1] = nType;
                            break;
                    }
                }
            }

            CounterCol = rnd1.Next(1, 11);
            CounterRow = rnd1.Next(1, 11);
            CounterDirection = rnd1.Next(1, 5);

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
                Image = Image.FromFile(@"F land.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F sea.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F Exit.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F landings1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F landings2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F landings3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F type1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F type2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F type3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F type4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
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
                default:
                    picAcross1.Image = picture11.Image;
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
                default:
                    picAcross2.Image = picture11.Image;
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
                default:
                    picAcross3.Image = picture11.Image;
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
                default:
                    picAcross4.Image = picture11.Image;
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
                default:
                    picAcross5.Image = picture11.Image;
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
                default:
                    picAcross6.Image = picture11.Image;
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
                default:
                    picAcross7.Image = picture11.Image;
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
                default:
                    picForward1.Image = picture11.Image;
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
                default:
                    picForward2.Image = picture11.Image;
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
                default:
                    picForward3.Image = picture11.Image;
                    break;
            }


        }

        private void btnDrop1_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nCol, nRow, nType;
            int nDrop = 4;
            bool bEnded = false;
            bool bSkip = false;

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
                    switch (nCol)
                    {
                        case 1:
                            _col1[nRow - 1]=nDrop;
                            break;
                        case 2:
                            _col2[nRow - 1] = nDrop;
                            break;
                        case 3:
                            _col3[nRow - 1] = nDrop;
                            break;
                        case 4:
                            _col4[nRow - 1] = nDrop;
                            break;
                        case 5:
                            _col5[nRow - 1] = nDrop;
                            break;
                        case 6:
                            _col6[nRow - 1] = nDrop;
                            break;
                        case 7:
                            _col7[nRow - 1] = nDrop;
                            break;
                        case 8:
                            _col8[nRow - 1] = nDrop;
                            break;
                        case 9:
                            _col9[nRow - 1] = nDrop;
                            break;
                        default:
                            _cola[nRow - 1] = nDrop;
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            _col1[nRow - 1] = nDrop;
                            break;
                        case 2:
                            _col2[nRow - 1] = nDrop;
                            break;
                        case 3:
                            _col3[nRow - 1] = nDrop;
                            break;
                        case 4:
                            _col4[nRow - 1] = nDrop;
                            break;
                        case 5:
                            _col5[nRow - 1] = nDrop;
                            break;
                        case 6:
                            _col6[nRow - 1] = nDrop;
                            break;
                        case 7:
                            _col7[nRow - 1] = nDrop;
                            break;
                        case 8:
                            _col8[nRow - 1] = nDrop;
                            break;
                        case 9:
                            _col9[nRow - 1] = nDrop;
                            break;
                        default:
                            _cola[nRow - 1] = nDrop;
                            break;
                    }
                    break;
                case 7:
                    bEnded = true;
                    break;
                case 8:
                    bEnded = true;
                    break;
                case 9:
                    bEnded = true;
                    break;
                case 10:
                    bEnded = true;
                    break;
                default:
                    bSkip = true;
                    break;
            }

            if (bEnded == true)
            {
                MessageBox.Show("You've ruined everything", "GameEnded");

            }
            else
            {
                if (bSkip == true)
                {

                }
                else
                {
                    PictureBox picture1 = new PictureBox
                    {
                        Name = "pictureBox1",
                        Image = Image.FromFile(@"F land.png"),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    PictureBox picture2 = new PictureBox
                    {
                        Name = "pictureBox2",
                        Image = Image.FromFile(@"F sea.png"),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    PictureBox picture3 = new PictureBox
                    {
                        Name = "pictureBox3",
                        Image = Image.FromFile(@"F Exit.png"),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    PictureBox picture4 = new PictureBox
                    {
                        Name = "pictureBox4",
                        Image = Image.FromFile(@"F landings1.png"),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    PictureBox picture5 = new PictureBox
                    {
                        Name = "pictureBox5",
                        Image = Image.FromFile(@"F landings2.png"),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    PictureBox picture6 = new PictureBox
                    {
                        Name = "pictureBox6",
                        Image = Image.FromFile(@"F landings3.png"),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    PictureBox picture7 = new PictureBox
                    {
                        Name = "pictureBox7",
                        Image = Image.FromFile(@"F type1.png"),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    PictureBox picture8 = new PictureBox
                    {
                        Name = "pictureBox8",
                        Image = Image.FromFile(@"F type2.png"),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    PictureBox picture9 = new PictureBox
                    {
                        Name = "pictureBox9",
                        Image = Image.FromFile(@"F type3.png"),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    PictureBox picture10 = new PictureBox
                    {
                        Name = "pictureBox10",
                        Image = Image.FromFile(@"F type4.png"),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    PictureBox picture11 = new PictureBox
                    {
                        Name = "pictureBox11",
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
                        default:
                            picAcross1.Image = picture11.Image;
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
                        default:
                            picAcross2.Image = picture11.Image;
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
                        default:
                            picAcross3.Image = picture11.Image;
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
                        default:
                            picAcross4.Image = picture11.Image;
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
                        default:
                            picAcross5.Image = picture11.Image;
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
                        default:
                            picAcross6.Image = picture11.Image;
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
                        default:
                            picAcross7.Image = picture11.Image;
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
                        default:
                            picForward1.Image = picture11.Image;
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
                        default:
                            picForward2.Image = picture11.Image;
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
                        default:
                            picForward3.Image = picture11.Image;
                            break;
                    }

                    switch (nCol)
                    {
                        case 1:
                            nType = _enemy1[nRow - 1];
                            break;
                        case 2:
                            nType = _enemy2[nRow - 1];
                            break;
                        case 3:
                            nType = _enemy3[nRow - 1];
                            break;
                        case 4:
                            nType = _enemy4[nRow - 1];
                            break;
                        case 5:
                            nType = _enemy5[nRow - 1];
                            break;
                        case 6:
                            nType = _enemy6[nRow - 1];
                            break;
                        case 7:
                            nType = _enemy7[nRow - 1];
                            break;
                        case 8:
                            nType = _enemy8[nRow - 1];
                            break;
                        case 9:
                            nType = _enemy9[nRow - 1];
                            break;
                        default:
                            nType = _enemya[nRow - 1];
                            break;
                    }

                    switch (nType)
                    {
                        case 2:
                            switch (nCol)
                            {
                                case 1:
                                    _enemy1[nRow - 1] = nDrop;
                                    break;
                                case 2:
                                    _enemy2[nRow - 1] = nDrop;
                                    break;
                                case 3:
                                    _enemy3[nRow - 1] = nDrop;
                                    break;
                                case 4:
                                    _enemy4[nRow - 1] = nDrop;
                                    break;
                                case 5:
                                    _enemy5[nRow - 1] = nDrop;
                                    break;
                                case 6:
                                    _enemy6[nRow - 1] = nDrop;
                                    break;
                                case 7:
                                    _enemy7[nRow - 1] = nDrop;
                                    break;
                                case 8:
                                    _enemy8[nRow - 1] = nDrop;
                                    break;
                                case 9:
                                    _enemy9[nRow - 1] = nDrop;
                                    break;
                                default:
                                    _enemya[nRow - 1] = nDrop;
                                    break;
                            }
                            break;
                        case 7:
                            bEnded = true;
                            switch (nCol)
                            {
                                case 1:
                                    _enemy1[nRow - 1] = 3;
                                    break;
                                case 2:
                                    _enemy2[nRow - 1] = 3;
                                    break;
                                case 3:
                                    _enemy3[nRow - 1] = 3;
                                    break;
                                case 4:
                                    _enemy4[nRow - 1] = 3;
                                    break;
                                case 5:
                                    _enemy5[nRow - 1] = 3;
                                    break;
                                case 6:
                                    _enemy6[nRow - 1] = 3;
                                    break;
                                case 7:
                                    _enemy7[nRow - 1] = 3;
                                    break;
                                case 8:
                                    _enemy8[nRow - 1] = 3;
                                    break;
                                case 9:
                                    _enemy9[nRow - 1] = 3;
                                    break;
                                default:
                                    _enemya[nRow - 1] = 3;
                                    break;
                            }
                            break;
                        case 8:
                            bEnded = true;
                            switch (nCol)
                            {
                                case 1:
                                    _enemy1[nRow - 1] = 3;
                                    break;
                                case 2:
                                    _enemy2[nRow - 1] = 3;
                                    break;
                                case 3:
                                    _enemy3[nRow - 1] = 3;
                                    break;
                                case 4:
                                    _enemy4[nRow - 1] = 3;
                                    break;
                                case 5:
                                    _enemy5[nRow - 1] = 3;
                                    break;
                                case 6:
                                    _enemy6[nRow - 1] = 3;
                                    break;
                                case 7:
                                    _enemy7[nRow - 1] = 3;
                                    break;
                                case 8:
                                    _enemy8[nRow - 1] = 3;
                                    break;
                                case 9:
                                    _enemy9[nRow - 1] = 3;
                                    break;
                                default:
                                    _enemya[nRow - 1] = 3;
                                    break;
                            }
                            break;
                        case 9:
                            bEnded = true;
                            switch (nCol)
                            {
                                case 1:
                                    _enemy1[nRow - 1] = 3;
                                    break;
                                case 2:
                                    _enemy2[nRow - 1] = 3;
                                    break;
                                case 3:
                                    _enemy3[nRow - 1] = 3;
                                    break;
                                case 4:
                                    _enemy4[nRow - 1] = 3;
                                    break;
                                case 5:
                                    _enemy5[nRow - 1] = 3;
                                    break;
                                case 6:
                                    _enemy6[nRow - 1] = 3;
                                    break;
                                case 7:
                                    _enemy7[nRow - 1] = 3;
                                    break;
                                case 8:
                                    _enemy8[nRow - 1] = 3;
                                    break;
                                case 9:
                                    _enemy9[nRow - 1] = 3;
                                    break;
                                default:
                                    _enemya[nRow - 1] = 3;
                                    break;
                            }
                            break;
                        case 10:
                            bEnded = true;
                            switch (nCol)
                            {
                                case 1:
                                    _enemy1[nRow - 1] = 3;
                                    break;
                                case 2:
                                    _enemy2[nRow - 1] = 3;
                                    break;
                                case 3:
                                    _enemy3[nRow - 1] = 3;
                                    break;
                                case 4:
                                    _enemy4[nRow - 1] = 3;
                                    break;
                                case 5:
                                    _enemy5[nRow - 1] = 3;
                                    break;
                                case 6:
                                    _enemy6[nRow - 1] = 3;
                                    break;
                                case 7:
                                    _enemy7[nRow - 1] = 3;
                                    break;
                                case 8:
                                    _enemy8[nRow - 1] = 3;
                                    break;
                                case 9:
                                    _enemy9[nRow - 1] = 3;
                                    break;
                                default:
                                    _enemya[nRow - 1] = 3;
                                    break;
                            }
                            break;
                        default:
                            bSkip = true;
                            break;
                    }

                    if (bEnded == true)
                    {
                        nScore = nScore + 10;
                        lblScore.Text = "Score = " + Convert.ToString(nScore);
                        MessageBox.Show("YOU WIN!!!", "GameEnded");
                    }
                }
            }
         

        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                Lookup.Column = i;
                Lookup.Row = 1;
                Lookup.Item = _enemy1[0];
                Lookup.Row = 2;
                Lookup.Item = _enemy1[1];
                Lookup.Row = 3;
                Lookup.Item =_enemy1[2];
                Lookup.Row = 4;
                Lookup.Item = _enemy1[3];
                Lookup.Row = 5;
                Lookup.Item = _enemy1[4];
                Lookup.Row = 6;
                Lookup.Item = _enemy1[5];
                Lookup.Row = 7;
                Lookup.Item = _enemy1[6];
                Lookup.Row = 8;
                Lookup.Item = _enemy1[7];
                Lookup.Row = 9;
                Lookup.Item = _enemy1[8];
                Lookup.Row = 10;
                Lookup.Item = _enemy1[9];
            }
            fEnemy _Dialog = new fEnemy();

            _Dialog.ShowDialog();
            _Dialog.Dispose();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nCol, nRow, nType,nLength;
            int nDirection;
        
            for (int i = 1; i <= 10; i++)
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
            }
            for (int i = 1; i <= 10; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col2[i - 1] = 1;
                }
                else
                {
                    _col2[i - 1] = 2;
                }
            }
            for (int i = 1; i <= 10; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col3[i - 1] = 1;
                }
                else
                {
                    _col3[i - 1] = 2;
                }
            }
            for (int i = 1; i <= 10; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col4[i - 1] = 1;
                }
                else
                {
                    _col4[i - 1] = 2;
                }
            }
            for (int i = 1; i <= 10; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col5[i - 1] = 1;
                }
                else
                {
                    _col5[i - 1] = 2;
                }
            }
            for (int i = 1; i <= 10; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col6[i - 1] = 1;
                }
                else
                {
                    _col6[i - 1] = 2;
                }
            }
            for (int i = 1; i <= 10; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col7[i - 1] = 1;
                }
                else
                {
                    _col7[i - 1] = 2;
                }
            }
            for (int i = 1; i <= 10; i++)
            {
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
            for (int i = 1; i <= 10; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _col9[i - 1] = 1;
                }
                else
                {
                    _col9[i - 1] = 2;
                }
            }
            for (int i = 1; i <= 10; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _cola[i - 1] = 1;
                }
                else
                {
                    _cola[i - 1] = 2;
                }
            }

            for (int i = 1; i <= 6; i++)
            {
                nCol = rnd1.Next(1, 11);
                nRow = rnd1.Next(1, 11);
                nType = rnd1.Next(7, 11);
                nLength = nType;
                nDirection = rnd1.Next(1, 5);
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

            for (int i = 1; i <= 10; i++)
            {
                _enemy1[i - 1] = 2;
                _enemy2[i - 1] = 2;
                _enemy3[i - 1] = 2;
                _enemy4[i - 1] = 2;
                _enemy5[i - 1] = 2;
                _enemy6[i - 1] = 2;
                _enemy7[i - 1] = 2;
                _enemy8[i - 1] = 2;
                _enemy9[i - 1] = 2;
                _enemya[i - 1] = 2;
            }

            for (int i = 1; i <= 6; i++)
            {
                nCol = rnd1.Next(1, 11);
                nRow = rnd1.Next(1, 11);
                nType = rnd1.Next(7, 11);
                nLength = nType;
                nDirection = rnd1.Next(1, 5);
                switch (nCol)
                {
                    case 1:
                        _enemy1[nRow - 1] = nType;
                        break;
                    case 2:
                        _enemy2[nRow - 1] = nType;
                        break;
                    case 3:
                        _enemy3[nRow - 1] = nType;
                        break;
                    case 4:
                        _enemy4[nRow - 1] = nType;
                        break;
                    case 5:
                        _enemy5[nRow - 1] = nType;
                        break;
                    case 6:
                        _enemy6[nRow - 1] = nType;
                        break;
                    case 7:
                        _enemy7[nRow - 1] = nType;
                        break;
                    case 8:
                        _enemy8[nRow - 1] = nType;
                        break;
                    case 9:
                        _enemy9[nRow - 1] = nType;
                        break;
                    case 10:
                        _enemya[nRow - 1] = nType;
                        break;
                }
                for (int j = 1; j <= nLength - 1; j++)
                {
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
                            _enemy1[nRow - 1] = nType;
                            break;
                        case 2:
                            _enemy2[nRow - 1] = nType;
                            break;
                        case 3:
                            _enemy3[nRow - 1] = nType;
                            break;
                        case 4:
                            _enemy4[nRow - 1] = nType;
                            break;
                        case 5:
                            _enemy5[nRow - 1] = nType;
                            break;
                        case 6:
                            _enemy6[nRow - 1] = nType;
                            break;
                        case 7:
                            _enemy7[nRow - 1] = nType;
                            break;
                        case 8:
                            _enemy8[nRow - 1] = nType;
                            break;
                        case 9:
                            _enemy9[nRow - 1] = nType;
                            break;
                        case 10:
                            _enemya[nRow - 1] = nType;
                            break;
                    }
                }
            }

            CounterCol = rnd1.Next(1, 11);
            CounterRow = rnd1.Next(1, 11);
            CounterDirection = rnd1.Next(1, 5);

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
                Image = Image.FromFile(@"F land.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F sea.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F Exit.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F landings1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F landings2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F landings3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F type1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F type2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F type3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F type4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
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
                default:
                    picAcross1.Image = picture11.Image;
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
                default:
                    picAcross2.Image = picture11.Image;
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
                default:
                    picAcross3.Image = picture11.Image;
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
                default:
                    picAcross4.Image = picture11.Image;
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
                default:
                    picAcross5.Image = picture11.Image;
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
                default:
                    picAcross6.Image = picture11.Image;
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
                default:
                    picAcross7.Image = picture11.Image;
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
                default:
                    picForward1.Image = picture11.Image;
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
                default:
                    picForward2.Image = picture11.Image;
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
                default:
                    picForward3.Image = picture11.Image;
                    break;
            }

        


         }

    }
}

