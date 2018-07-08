using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OriginSays
{
    public partial class Form1 : Form
    {
        private static List<int> _NE1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _NE2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _NE3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _NE4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _NE5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _NE6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _NE7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _NE8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _NE9 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _NEa = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _SE1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _SE2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _SE3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _SE4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _SE5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _SE6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _SE7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _SE8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _SE9 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _SEa = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _SW1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _SW2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _SW3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _SW4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _SW5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _SW6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _SW7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _SW8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _SW9 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _SWa = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _NW1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _NW2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _NW3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _NW4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _NW5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _NW6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _NW7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _NW8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _NW9 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _NWa = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _HolderACol = new List<int> { 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _HolderARow = new List<int> { 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _HolderFCol = new List<int> { 0, 0, 0 };
        private static List<int> _HolderFRow = new List<int> { 0, 0, 0 };
        private static List<int> _qtype = new List<int> { 0, 0, 0, 0 };
        private int CounterCol, CounterRow, CounterDirection;
        private int nScore = 0;
        private int nQuadrant = 1;

        private void fSetExit()
        {
            Random rnd1 = new Random();
            int nCol, nRow;

            nCol = rnd1.Next(1, 9);
            nRow = rnd1.Next(1, 9);
            switch (_qtype[nQuadrant - 1])
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            _NW1[nRow - 1] = 3;
                            break;
                        case 2:
                            _NW2[nRow - 1] = 3;
                            break;
                        case 3:
                            _NW3[nRow - 1] = 3;
                            break;
                        case 4:
                            _NW4[nRow - 1] = 3;
                            break;
                        case 5:
                            _NW5[nRow - 1] = 3;
                            break;
                        case 6:
                            _NW6[nRow - 1] = 3;
                            break;
                        case 7:
                            _NW7[nRow - 1] = 3;
                            break;
                        case 8:
                            _NW8[nRow - 1] = 3;
                            break;
                        case 9:
                            _NW9[nRow - 1] = 3;
                            break;
                        default:
                            _NWa[nRow - 1] = 3;
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            _SW1[nRow - 1] = 3;
                            break;
                        case 2:
                            _SW2[nRow - 1] = 3;
                            break;
                        case 3:
                            _SW3[nRow - 1] = 3;
                            break;
                        case 4:
                            _SW4[nRow - 1] = 3;
                            break;
                        case 5:
                            _SW5[nRow - 1] = 3;
                            break;
                        case 6:
                            _SW6[nRow - 1] = 3;
                            break;
                        case 7:
                            _SW7[nRow - 1] = 3;
                            break;
                        case 8:
                            _SW8[nRow - 1] = 3;
                            break;
                        case 9:
                            _SW9[nRow - 1] = 3;
                            break;
                        default:
                            _SWa[nRow - 1] = 3;
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            _SE1[nRow - 1] = 3;
                            break;
                        case 2:
                            _SE2[nRow - 1] = 3;
                            break;
                        case 3:
                            _SE3[nRow - 1] = 3;
                            break;
                        case 4:
                            _SE4[nRow - 1] = 3;
                            break;
                        case 5:
                            _SE5[nRow - 1] = 3;
                            break;
                        case 6:
                            _SE6[nRow - 1] = 3;
                            break;
                        case 7:
                            _SE7[nRow - 1] = 3;
                            break;
                        case 8:
                            _SE8[nRow - 1] = 3;
                            break;
                        case 9:
                            _SE9[nRow - 1] = 3;
                            break;
                        default:
                            _SEa[nRow - 1] = 3;
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            _NW1[nRow - 1] = 3;
                            break;
                        case 2:
                            _NW2[nRow - 1] = 3;
                            break;
                        case 3:
                            _NW3[nRow - 1] = 3;
                            break;
                        case 4:
                            _NW4[nRow - 1] = 3;
                            break;
                        case 5:
                            _NW5[nRow - 1] = 3;
                            break;
                        case 6:
                            _NW6[nRow - 1] = 3;
                            break;
                        case 7:
                            _NW7[nRow - 1] = 3;
                            break;
                        case 8:
                            _NW8[nRow - 1] = 3;
                            break;
                        case 9:
                            _NW9[nRow - 1] = 3;
                            break;
                        default:
                            _NWa[nRow - 1] = 3;
                            break;
                    }
                    break;
            }
        }

        private void fSyncCounter()
        {
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

            switch (nQuadrant)
            {
                case 1:
                    lblQuadrant.Text = "Quadrant = (NE)";
                    break;
                case 2:
                    lblQuadrant.Text = "Quadrant = (SE)";
                    break;
                case 3:
                    lblQuadrant.Text = "Quadrant = (SW)";
                    break;
                default:
                    lblQuadrant.Text = "Quadrant = (NW)";
                    break;
            }
            switch (_qtype[nQuadrant - 1])
            {
                case 1:
                    lblQuadrant.Text = lblQuadrant.Text + " oftype BoxDoa";
                    break;
                case 2:
                    lblQuadrant.Text = lblQuadrant.Text + " oftype Helpless";
                    break;
                default:
                    lblQuadrant.Text = lblQuadrant.Text + " oftype Roads";
                    break;
            }

        }

        private void fUpdateDisplay()
        {
            int nCol, nRow, nType;

            lblScore.Text = "Score = " + Convert.ToString(nScore);

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F BoxDoa.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F Caves.png"),
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
                Image = Image.FromFile(@"F HelplessPerson.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F house.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F money.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F Nullgate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F road.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F tile1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F tile2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nCol = _HolderACol[0];
            nRow = _HolderARow[0];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picAcross1.Image = picture10.Image;
                    break;
            }

            nCol = _HolderACol[1];
            nRow = _HolderARow[1];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picAcross2.Image = picture10.Image;
                    break;
            }

            nCol = _HolderACol[2];
            nRow = _HolderARow[2];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picAcross3.Image = picture10.Image;
                    break;
            }

            nCol = _HolderACol[3];
            nRow = _HolderARow[3];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picAcross4.Image = picture10.Image;
                    break;
            }

            nCol = _HolderACol[4];
            nRow = _HolderARow[4];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picAcross5.Image = picture10.Image;
                    break;
            }

            nCol = _HolderACol[5];
            nRow = _HolderARow[5];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picAcross6.Image = picture10.Image;
                    break;
            }

            nCol = _HolderACol[6];
            nRow = _HolderARow[6];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picAcross7.Image = picture10.Image;
                    break;
            }

            nCol = _HolderFCol[0];
            nRow = _HolderFRow[0];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picForward1.Image = picture10.Image;
                    break;
            }

            nCol = _HolderFCol[1];
            nRow = _HolderFRow[1];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picForward2.Image = picture10.Image;
                    break;
            }

            nCol = _HolderFCol[2];
            nRow = _HolderFRow[2];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picForward3.Image = picture10.Image;
                    break;
            }

        }
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
                        switch (nQuadrant)
                        {
                            case 1:
                                break;
                            case 2:
                                nQuadrant = 1;
                                break;
                            case 3:
                                nQuadrant = 4;
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case 2:
                    CounterCol += 1;
                    if (CounterCol == 11)
                    {
                        CounterCol = 1;
                        switch (nQuadrant)
                        {
                            case 1:
                                break;
                            case 2:
                                break;
                            case 3:
                                nQuadrant = 2;
                                break;
                            default:
                                nQuadrant = 1;
                                break;
                        }
                    }
                    break;
                case 3:
                    CounterRow += 1;
                    if (CounterRow == 11)
                    {
                        CounterRow = 1;
                        switch (nQuadrant)
                        {
                            case 1:
                                nQuadrant = 2;
                                break;
                            case 2:
                                break;
                            case 3:
                                 break;
                            default:
                                nQuadrant = 3;
                                break;
                        }
                    }
                    break;
                default:
                    CounterCol -= 1;
                    if (CounterCol == 0)
                    {
                        CounterCol = 10;
                        switch (nQuadrant)
                        {
                            case 1:
                                nQuadrant = 4;
                                break;
                            case 2:
                                nQuadrant = 3;
                                break;
                            case 3:
                                break;
                            default:
                                break;
                        }
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

            switch (nQuadrant)
            {
                case 1:
                    lblQuadrant.Text = "Quadrant = (NE)";
                    break;
                case 2:
                    lblQuadrant.Text = "Quadrant = (SE)";
                    break;
                case 3:
                    lblQuadrant.Text = "Quadrant = (SW)";
                    break;
                default:
                    lblQuadrant.Text = "Quadrant = (NW)";
                    break;
            }
            switch (_qtype[nQuadrant - 1])
            {
                case 1:
                    lblQuadrant.Text = lblQuadrant.Text + " oftype BoxDoa";
                    break;
                case 2:
                    lblQuadrant.Text = lblQuadrant.Text + " oftype Helpless";
                    break;
                default:
                    lblQuadrant.Text = lblQuadrant.Text + " oftype Roads";
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F BoxDoa.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F Caves.png"),
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
                Image = Image.FromFile(@"F HelplessPerson.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F house.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F money.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F Nullgate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F road.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F tile1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F tile2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nCol = _HolderACol[0];
            nRow = _HolderARow[0];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picAcross1.Image = picture10.Image;
                    break;
            }

            nCol = _HolderACol[1];
            nRow = _HolderARow[1];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picAcross2.Image = picture10.Image;
                    break;
            }

            nCol = _HolderACol[2];
            nRow = _HolderARow[2];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picAcross3.Image = picture10.Image;
                    break;
            }

            nCol = _HolderACol[3];
            nRow = _HolderARow[3];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picAcross4.Image = picture10.Image;
                    break;
            }

            nCol = _HolderACol[4];
            nRow = _HolderARow[4];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picAcross5.Image = picture10.Image;
                    break;
            }

            nCol = _HolderACol[5];
            nRow = _HolderARow[5];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picAcross6.Image = picture10.Image;
                    break;
            }

            nCol = _HolderACol[6];
            nRow = _HolderARow[6];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picAcross7.Image = picture10.Image;
                    break;
            }

            nCol = _HolderFCol[0];
            nRow = _HolderFRow[0];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picForward1.Image = picture10.Image;
                    break;
            }
            nCol = _HolderFCol[1];
            nRow = _HolderFRow[1];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picForward2.Image = picture10.Image;
                    break;
            }

            nCol = _HolderFCol[2];
            nRow = _HolderFRow[2];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picForward3.Image = picture10.Image;
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
                Image = Image.FromFile(@"F BoxDoa.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F Caves.png"),
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
                Image = Image.FromFile(@"F HelplessPerson.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F house.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F money.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F Nullgate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F road.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F tile1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F tile2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nCol = _HolderACol[0];
            nRow = _HolderARow[0];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picAcross1.Image = picture10.Image;
                    break;
            }

            nCol = _HolderACol[1];
            nRow = _HolderARow[1];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picAcross2.Image = picture10.Image;
                    break;
            }

            nCol = _HolderACol[2];
            nRow = _HolderARow[2];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picAcross3.Image = picture10.Image;
                    break;
            }

            nCol = _HolderACol[3];
            nRow = _HolderARow[3];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picAcross4.Image = picture10.Image;
                    break;
            }

            nCol = _HolderACol[4];
            nRow = _HolderARow[4];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picAcross5.Image = picture10.Image;
                    break;
            }

            nCol = _HolderACol[5];
            nRow = _HolderARow[5];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picAcross6.Image = picture10.Image;
                    break;
            }

            nCol = _HolderACol[6];
            nRow = _HolderARow[6];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picAcross7.Image = picture10.Image;
                    break;
            }

            nCol = _HolderFCol[0];
            nRow = _HolderFRow[0];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picForward1.Image = picture10.Image;
                    break;
            }

            nCol = _HolderFCol[1];
            nRow = _HolderFRow[1];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picForward2.Image = picture10.Image;
                    break;
            }

            nCol = _HolderFCol[2];
            nRow = _HolderFRow[2];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picForward3.Image = picture10.Image;
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
                Image = Image.FromFile(@"F BoxDoa.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F Caves.png"),
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
                Image = Image.FromFile(@"F HelplessPerson.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F house.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F money.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F Nullgate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F road.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F tile1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F tile2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nCol = _HolderACol[0];
            nRow = _HolderARow[0];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picAcross1.Image = picture10.Image;
                    break;
            }

            nCol = _HolderACol[1];
            nRow = _HolderARow[1];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picAcross2.Image = picture10.Image;
                    break;
            }

            nCol = _HolderACol[2];
            nRow = _HolderARow[2];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picAcross3.Image = picture10.Image;
                    break;
            }

            nCol = _HolderACol[3];
            nRow = _HolderARow[3];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picAcross4.Image = picture10.Image;
                    break;
            }

            nCol = _HolderACol[4];
            nRow = _HolderARow[4];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picAcross5.Image = picture10.Image;
                    break;
            }

            nCol = _HolderACol[5];
            nRow = _HolderARow[5];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picAcross6.Image = picture10.Image;
                    break;
            }

            nCol = _HolderACol[6];
            nRow = _HolderARow[6];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picAcross7.Image = picture10.Image;
                    break;
            }

            nCol = _HolderFCol[0];
            nRow = _HolderFRow[0];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picForward1.Image = picture10.Image;
                    break;
            }

            nCol = _HolderFCol[1];
            nRow = _HolderFRow[1];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picForward2.Image = picture10.Image;
                    break;
            }

            nCol = _HolderFCol[2];
            nRow = _HolderFRow[2];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
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
                default:
                    picForward3.Image = picture10.Image;
                    break;
            }


        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            int nCol, nRow, nType;

     
           if (_qtype[nQuadrant - 1] == 1)
            {
                nCol = _HolderACol[3];
                nRow = _HolderARow[3];
                switch (nQuadrant)
                {
                    case 1:
                        switch (nCol)
                        {
                            case 1:
                                nType = _NE1[nRow - 1];
                                break;
                            case 2:
                                nType = _NE2[nRow - 1];
                                break;
                            case 3:
                                nType = _NE3[nRow - 1];
                                break;
                            case 4:
                                nType = _NE4[nRow - 1];
                                break;
                            case 5:
                                nType = _NE5[nRow - 1];
                                break;
                            case 6:
                                nType = _NE6[nRow - 1];
                                break;
                            case 7:
                                nType = _NE7[nRow - 1];
                                break;
                            case 8:
                                nType = _NE8[nRow - 1];
                                break;
                            case 9:
                                nType = _NE9[nRow - 1];
                                break;
                            default:
                                nType = _NEa[nRow - 1];
                                break;
                        }
                        break;
                    case 2:
                        switch (nCol)
                        {
                            case 1:
                                nType = _SE1[nRow - 1];
                                break;
                            case 2:
                                nType = _SE2[nRow - 1];
                                break;
                            case 3:
                                nType = _SE3[nRow - 1];
                                break;
                            case 4:
                                nType = _SE4[nRow - 1];
                                break;
                            case 5:
                                nType = _SE5[nRow - 1];
                                break;
                            case 6:
                                nType = _SE6[nRow - 1];
                                break;
                            case 7:
                                nType = _SE7[nRow - 1];
                                break;
                            case 8:
                                nType = _SE8[nRow - 1];
                                break;
                            case 9:
                                nType = _SE9[nRow - 1];
                                break;
                            default:
                                nType = _SEa[nRow - 1];
                                break;
                        }
                        break;
                    case 3:
                        switch (nCol)
                        {
                            case 1:
                                nType = _SW1[nRow - 1];
                                break;
                            case 2:
                                nType = _SW2[nRow - 1];
                                break;
                            case 3:
                                nType = _SW3[nRow - 1];
                                break;
                            case 4:
                                nType = _SW4[nRow - 1];
                                break;
                            case 5:
                                nType = _SW5[nRow - 1];
                                break;
                            case 6:
                                nType = _SW6[nRow - 1];
                                break;
                            case 7:
                                nType = _SW7[nRow - 1];
                                break;
                            case 8:
                                nType = _SW8[nRow - 1];
                                break;
                            case 9:
                                nType = _SW9[nRow - 1];
                                break;
                            default:
                                nType = _SWa[nRow - 1];
                                break;
                        }
                        break;
                    default:
                        switch (nCol)
                        {
                            case 1:
                                nType = _NW1[nRow - 1];
                                break;
                            case 2:
                                nType = _NW2[nRow - 1];
                                break;
                            case 3:
                                nType = _NW3[nRow - 1];
                                break;
                            case 4:
                                nType = _NW4[nRow - 1];
                                break;
                            case 5:
                                nType = _NW5[nRow - 1];
                                break;
                            case 6:
                                nType = _NW6[nRow - 1];
                                break;
                            case 7:
                                nType = _NW7[nRow - 1];
                                break;
                            case 8:
                                nType = _NW8[nRow - 1];
                                break;
                            case 9:
                                nType = _NW9[nRow - 1];
                                break;
                            default:
                                nType = _NWa[nRow - 1];
                                break;
                        }
                        break;
                }
                if (nType == 1)
                {
                    switch (nQuadrant)
                    {
                        case 1:
                            switch (nCol)
                            {
                                case 1:
                                    _NE1[nRow - 1] = 10; 
                                    break;
                                case 2:
                                    _NE2[nRow - 1] = 10;
                                    break;
                                case 3:
                                    _NE3[nRow - 1] = 10;
                                    break;
                                case 4:
                                    _NE4[nRow - 1] = 10;
                                    break;
                                case 5:
                                    _NE5[nRow - 1] = 10;
                                    break;
                                case 6:
                                    _NE6[nRow - 1] = 10;
                                    break;
                                case 7:
                                    _NE7[nRow - 1] = 10;
                                    break;
                                case 8:
                                    _NE8[nRow - 1] = 10;
                                    break;
                                case 9:
                                    _NE9[nRow - 1] = 10;
                                    break;
                                default:
                                    _NEa[nRow - 1] = 10; ;
                                    break;
                            }
                            break;
                        case 2:
                            switch (nCol)
                            {
                                case 1:
                                    _SE1[nRow - 1] = 10;
                                    break;
                                case 2:
                                    _SE2[nRow - 1] = 10;
                                    break;
                                case 3:
                                    _SE3[nRow - 1] = 10;
                                    break;
                                case 4:
                                    _SE4[nRow - 1] = 10;
                                    break;
                                case 5:
                                    _SE5[nRow - 1] = 10;
                                    break;
                                case 6:
                                    _SE6[nRow - 1] = 10;
                                    break;
                                case 7:
                                    _SE7[nRow - 1] = 10;
                                    break;
                                case 8:
                                    _SE8[nRow - 1] = 10;
                                    break;
                                case 9:
                                    _SE9[nRow - 1] = 10;
                                    break;
                                default:
                                    _SEa[nRow - 1] = 10; ;
                                    break;
                            }
                            break;
                        case 3:
                            switch (nCol)
                            {
                                case 1:
                                    _SW1[nRow - 1] = 10;
                                    break;
                                case 2:
                                    _SW2[nRow - 1] = 10;
                                    break;
                                case 3:
                                    _SW3[nRow - 1] = 10;
                                    break;
                                case 4:
                                    _SW4[nRow - 1] = 10;
                                    break;
                                case 5:
                                    _SW5[nRow - 1] = 10;
                                    break;
                                case 6:
                                    _SW6[nRow - 1] = 10;
                                    break;
                                case 7:
                                    _SW7[nRow - 1] = 10;
                                    break;
                                case 8:
                                    _SW8[nRow - 1] = 10;
                                    break;
                                case 9:
                                    _SW9[nRow - 1] = 10;
                                    break;
                                default:
                                    _SWa[nRow - 1] = 10; ;
                                    break;
                            }
                            break;
                        default:
                            switch (nCol)
                            {
                                case 1:
                                    _NW1[nRow - 1] = 10;
                                    break;
                                case 2:
                                    _NW2[nRow - 1] = 10;
                                    break;
                                case 3:
                                    _NW3[nRow - 1] = 10;
                                    break;
                                case 4:
                                    _NW4[nRow - 1] = 10;
                                    break;
                                case 5:
                                    _NW5[nRow - 1] = 10;
                                    break;
                                case 6:
                                    _NW6[nRow - 1] = 10;
                                    break;
                                case 7:
                                    _NW7[nRow - 1] = 10;
                                    break;
                                case 8:
                                    _NW8[nRow - 1] = 10;
                                    break;
                                case 9:
                                    _NW9[nRow - 1] = 10;
                                    break;
                                default:
                                    _NWa[nRow - 1] = 10; ;
                                    break;
                            }
                            break;
                      }
                    switch (CounterDirection)
                    {
                        case 1:
                            nRow -= 1;
                            if (nRow == 0)
                            {
                                nRow = 10;
                                switch (nQuadrant)
                                {
                                    case 1:
                                        break;
                                    case 2:
                                        nQuadrant = 1;
                                        break;
                                    case 3:
                                        nQuadrant = 4;
                                        break;
                                    default:
                                        break;
                                }
                            }
                            break;
                        case 2:
                            nCol += 1;
                            if (nCol == 11)
                            {
                                nCol = 1;
                                switch (nQuadrant)
                                {
                                    case 1:
                                        break;
                                    case 2:
                                        break;
                                    case 3:
                                        nQuadrant = 2;
                                        break;
                                    default:
                                        nQuadrant = 1;
                                        break;
                                }
                            }
                            break;
                        case 3:
                            nRow += 1;
                            if (nRow == 11)
                            {
                                nRow = 1;
                                switch (nQuadrant)
                                {
                                    case 1:
                                        nQuadrant = 2;
                                        break;
                                    case 2:
                                        break;
                                    case 3:
                                        break;
                                    default:
                                        nQuadrant = 3;
                                        break;
                                }
                            }
                            break;
                        default:
                            nCol -= 1;
                            if (nCol == 0)
                            {
                                nCol = 10;
                                switch (nQuadrant)
                                {
                                    case 1:
                                        nQuadrant = 4;
                                        break;
                                    case 2:
                                        nQuadrant = 3;
                                        break;
                                    case 3:
                                        break;
                                    default:
                                        break;
                                }
                            }
                            break;
                    }
                    switch (nQuadrant)
                    {
                        case 1:
                            switch (nCol)
                            {
                                case 1:
                                    nType = _NE1[nRow - 1];
                                    break;
                                case 2:
                                    nType = _NE2[nRow - 1];
                                    break;
                                case 3:
                                    nType = _NE3[nRow - 1];
                                    break;
                                case 4:
                                    nType = _NE4[nRow - 1];
                                    break;
                                case 5:
                                    nType = _NE5[nRow - 1];
                                    break;
                                case 6:
                                    nType = _NE6[nRow - 1];
                                    break;
                                case 7:
                                    nType = _NE7[nRow - 1];
                                    break;
                                case 8:
                                    nType = _NE8[nRow - 1];
                                    break;
                                case 9:
                                    nType = _NE9[nRow - 1];
                                    break;
                                default:
                                    nType = _NEa[nRow - 1];
                                    break;
                            }
                            break;
                        case 2:
                            switch (nCol)
                            {
                                case 1:
                                    nType = _SE1[nRow - 1];
                                    break;
                                case 2:
                                    nType = _SE2[nRow - 1];
                                    break;
                                case 3:
                                    nType = _SE3[nRow - 1];
                                    break;
                                case 4:
                                    nType = _SE4[nRow - 1];
                                    break;
                                case 5:
                                    nType = _SE5[nRow - 1];
                                    break;
                                case 6:
                                    nType = _SE6[nRow - 1];
                                    break;
                                case 7:
                                    nType = _SE7[nRow - 1];
                                    break;
                                case 8:
                                    nType = _SE8[nRow - 1];
                                    break;
                                case 9:
                                    nType = _SE9[nRow - 1];
                                    break;
                                default:
                                    nType = _SEa[nRow - 1];
                                    break;
                            }
                            break;
                        case 3:
                            switch (nCol)
                            {
                                case 1:
                                    nType = _SW1[nRow - 1];
                                    break;
                                case 2:
                                    nType = _SW2[nRow - 1];
                                    break;
                                case 3:
                                    nType = _SW3[nRow - 1];
                                    break;
                                case 4:
                                    nType = _SW4[nRow - 1];
                                    break;
                                case 5:
                                    nType = _SW5[nRow - 1];
                                    break;
                                case 6:
                                    nType = _SW6[nRow - 1];
                                    break;
                                case 7:
                                    nType = _SW7[nRow - 1];
                                    break;
                                case 8:
                                    nType = _SW8[nRow - 1];
                                    break;
                                case 9:
                                    nType = _SW9[nRow - 1];
                                    break;
                                default:
                                    nType = _SWa[nRow - 1];
                                    break;
                            }
                            break;
                        default:
                            switch (nCol)
                            {
                                case 1:
                                    nType = _NW1[nRow - 1];
                                    break;
                                case 2:
                                    nType = _NW2[nRow - 1];
                                    break;
                                case 3:
                                    nType = _NW3[nRow - 1];
                                    break;
                                case 4:
                                    nType = _NW4[nRow - 1];
                                    break;
                                case 5:
                                    nType = _NW5[nRow - 1];
                                    break;
                                case 6:
                                    nType = _NW6[nRow - 1];
                                    break;
                                case 7:
                                    nType = _NW7[nRow - 1];
                                    break;
                                case 8:
                                    nType = _NW8[nRow - 1];
                                    break;
                                case 9:
                                    nType = _NW9[nRow - 1];
                                    break;
                                default:
                                    nType = _NWa[nRow - 1];
                                    break;
                            }
                            break;
                    }
                    if (nType == 2)
                    {
                        nScore += 10;
                    }
                    else
                    {
                        if (nType >= 9)
                        {
                            switch (nQuadrant)
                            {
                                case 1:
                                    switch (nCol)
                                    {
                                        case 1:
                                            _NE1[nRow - 1] = 1;
                                            break;
                                        case 2:
                                            _NE2[nRow - 1] = 1;
                                            break;
                                        case 3:
                                            _NE3[nRow - 1] = 1;
                                            break;
                                        case 4:
                                            _NE4[nRow - 1] = 1;
                                            break;
                                        case 5:
                                            _NE5[nRow - 1] = 1;
                                            break;
                                        case 6:
                                            _NE6[nRow - 1] = 1;
                                            break;
                                        case 7:
                                            _NE7[nRow - 1] = 1;
                                            break;
                                        case 8:
                                            _NE8[nRow - 1] = 1;
                                            break;
                                        case 9:
                                            _NE9[nRow - 1] = 1;
                                            break;
                                        default:
                                            _NEa[nRow - 1] = 1; ;
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch (nCol)
                                    {
                                        case 1:
                                            _SE1[nRow - 1] = 1;
                                            break;
                                        case 2:
                                            _SE2[nRow - 1] = 1;
                                            break;
                                        case 3:
                                            _SE3[nRow - 1] = 1;
                                            break;
                                        case 4:
                                            _SE4[nRow - 1] = 1;
                                            break;
                                        case 5:
                                            _SE5[nRow - 1] = 1;
                                            break;
                                        case 6:
                                            _SE6[nRow - 1] = 1;
                                            break;
                                        case 7:
                                            _SE7[nRow - 1] = 1;
                                            break;
                                        case 8:
                                            _SE8[nRow - 1] = 1;
                                            break;
                                        case 9:
                                            _SE9[nRow - 1] = 1;
                                            break;
                                        default:
                                            _SEa[nRow - 1] = 1; ;
                                            break;
                                    }
                                    break;
                                case 3:
                                    switch (nCol)
                                    {
                                        case 1:
                                            _SW1[nRow - 1] = 1;
                                            break;
                                        case 2:
                                            _SW2[nRow - 1] = 1;
                                            break;
                                        case 3:
                                            _SW3[nRow - 1] = 1;
                                            break;
                                        case 4:
                                            _SW4[nRow - 1] = 1;
                                            break;
                                        case 5:
                                            _SW5[nRow - 1] = 1;
                                            break;
                                        case 6:
                                            _SW6[nRow - 1] = 1;
                                            break;
                                        case 7:
                                            _SW7[nRow - 1] = 1;
                                            break;
                                        case 8:
                                            _SW8[nRow - 1] = 1;
                                            break;
                                        case 9:
                                            _SW9[nRow - 1] = 1;
                                            break;
                                        default:
                                            _SWa[nRow - 1] = 1; ;
                                            break;
                                    }
                                    break;
                                default:
                                    switch (nCol)
                                    {
                                        case 1:
                                            _NW1[nRow - 1] = 1;
                                            break;
                                        case 2:
                                            _NW2[nRow - 1] = 1;
                                            break;
                                        case 3:
                                            _NW3[nRow - 1] = 1;
                                            break;
                                        case 4:
                                            _NW4[nRow - 1] = 1;
                                            break;
                                        case 5:
                                            _NW5[nRow - 1] = 1;
                                            break;
                                        case 6:
                                            _NW6[nRow - 1] = 1;
                                            break;
                                        case 7:
                                            _NW7[nRow - 1] = 1;
                                            break;
                                        case 8:
                                            _NW8[nRow - 1] = 1;
                                            break;
                                        case 9:
                                            _NW9[nRow - 1] = 1;
                                            break;
                                        default:
                                            _NWa[nRow - 1] = 1; ;
                                            break;
                                    }
                                    break;
                            }

                        }
                    }
                }
                else
                {
                    
                    MessageBox.Show("Error!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Error!");
                return;
            }
            nScore += 10;
            fUpdateDisplay();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nCol, nRow, nType = 0;

            for (int i = 1; i <= 4; i++)
            {
                _qtype[i-1] = rnd1.Next(1, 4);
            }
            for (int i = 1; i <= 10; i++)
            {
                 nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NE1[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NE2[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NE3[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NE4[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NE5[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NE6[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NE7[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NE8[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NE9[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NEa[i - 1] = nType;


                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SE1[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SE2[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SE3[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SE4[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SE5[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SE6[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SE7[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SE8[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SE9[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SEa[i - 1] = nType;

                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SW1[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SW2[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SW3[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SW4[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SW5[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SW6[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SW7[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SW8[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SW9[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SWa[i - 1] = nType;


                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NW1[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NW2[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NW3[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NW4[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NW5[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NW6[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NW7[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NW8[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NW9[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NWa[i - 1] = nType;
            }

            switch (_qtype[0])
            {
                case 1:
                    for (int j = 1; j <= 2; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 2;
                        switch (nCol)
                        {
                            case 1:
                                _NE1[nRow - 1] = nType;
                                break;
                            case 2:
                                _NE2[nRow - 1] = nType;
                                break;
                            case 3:
                                _NE3[nRow - 1] = nType;
                                break;
                            case 4:
                                _NE4[nRow - 1] = nType;
                                break;
                            case 5:
                                _NE5[nRow - 1] = nType;
                                break;
                            case 6:
                                _NE6[nRow - 1] = nType;
                                break;
                            case 7:
                                _NE7[nRow - 1] = nType;
                                break;
                            case 8:
                                _NE8[nRow - 1] = nType;
                                break;
                            case 9:
                                _NE9[nRow - 1] = nType;
                                break;
                            default:
                                _NEa[nRow - 1] = nType;
                                break;
                        }
                    }
                    for (int j = 1; j <= 8; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 1;
                        switch (nCol)
                        {
                            case 1:
                                _NE1[nRow - 1] = nType;
                                break;
                            case 2:
                                _NE2[nRow - 1] = nType;
                                break;
                            case 3:
                                _NE3[nRow - 1] = nType;
                                break;
                            case 4:
                                _NE4[nRow - 1] = nType;
                                break;
                            case 5:
                                _NE5[nRow - 1] = nType;
                                break;
                            case 6:
                                _NE6[nRow - 1] = nType;
                                break;
                            case 7:
                                _NE7[nRow - 1] = nType;
                                break;
                            case 8:
                                _NE8[nRow - 1] = nType;
                                break;
                            case 9:
                                _NE9[nRow - 1] = nType;
                                break;
                            default:
                                _NEa[nRow - 1] = nType;
                                break;
                        }
                    }
                    break;
                case 2:
                    for (int j = 1; j <= 8; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 4;
                        switch (nCol)
                        {
                            case 1:
                                _NE1[nRow - 1] = nType;
                                break;
                            case 2:
                                _NE2[nRow - 1] = nType;
                                break;
                            case 3:
                                _NE3[nRow - 1] = nType;
                                break;
                            case 4:
                                _NE4[nRow - 1] = nType;
                                break;
                            case 5:
                                _NE5[nRow - 1] = nType;
                                break;
                            case 6:
                                _NE6[nRow - 1] = nType;
                                break;
                            case 7:
                                _NE7[nRow - 1] = nType;
                                break;
                            case 8:
                                _NE8[nRow - 1] = nType;
                                break;
                            case 9:
                                _NE9[nRow - 1] = nType;
                                break;
                            default:
                                _NEa[nRow - 1] = nType;
                                break;
                        }
                    }
                    for (int j = 1; j <= 16; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 6;
                        switch (nCol)
                        {
                            case 1:
                                _NE1[nRow - 1] = nType;
                                break;
                            case 2:
                                _NE2[nRow - 1] = nType;
                                break;
                            case 3:
                                _NE3[nRow - 1] = nType;
                                break;
                            case 4:
                                _NE4[nRow - 1] = nType;
                                break;
                            case 5:
                                _NE5[nRow - 1] = nType;
                                break;
                            case 6:
                                _NE6[nRow - 1] = nType;
                                break;
                            case 7:
                                _NE7[nRow - 1] = nType;
                                break;
                            case 8:
                                _NE8[nRow - 1] = nType;
                                break;
                            case 9:
                                _NE9[nRow - 1] = nType;
                                break;
                            default:
                                _NEa[nRow - 1] = nType;
                                break;
                        }
                    }
                    break;
                default:
                    for (int j = 1; j <= 16; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 8;
                        switch (nCol)
                        {
                            case 1:
                                _NE1[nRow - 1] = nType;
                                break;
                            case 2:
                                _NE2[nRow - 1] = nType;
                                break;
                            case 3:
                                _NE3[nRow - 1] = nType;
                                break;
                            case 4:
                                _NE4[nRow - 1] = nType;
                                break;
                            case 5:
                                _NE5[nRow - 1] = nType;
                                break;
                            case 6:
                                _NE6[nRow - 1] = nType;
                                break;
                            case 7:
                                _NE7[nRow - 1] = nType;
                                break;
                            case 8:
                                _NE8[nRow - 1] = nType;
                                break;
                            case 9:
                                _NE9[nRow - 1] = nType;
                                break;
                            default:
                                _NEa[nRow - 1] = nType;
                                break;
                        }
                    }
                    for (int j = 1; j <= 2; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 5;
                        switch (nCol)
                        {
                            case 1:
                                _NE1[nRow - 1] = nType;
                                break;
                            case 2:
                                _NE2[nRow - 1] = nType;
                                break;
                            case 3:
                                _NE3[nRow - 1] = nType;
                                break;
                            case 4:
                                _NE4[nRow - 1] = nType;
                                break;
                            case 5:
                                _NE5[nRow - 1] = nType;
                                break;
                            case 6:
                                _NE6[nRow - 1] = nType;
                                break;
                            case 7:
                                _NE7[nRow - 1] = nType;
                                break;
                            case 8:
                                _NE8[nRow - 1] = nType;
                                break;
                            case 9:
                                _NE9[nRow - 1] = nType;
                                break;
                            default:
                                _NEa[nRow - 1] = nType;
                                break;
                        }
                    }
                    break;
            }
            switch (_qtype[1])
            {
                case 1:
                    for (int j = 1; j <= 2; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 2;
                        switch (nCol)
                        {
                            case 1:
                                _SE1[nRow - 1] = nType;
                                break;
                            case 2:
                                _SE2[nRow - 1] = nType;
                                break;
                            case 3:
                                _SE3[nRow - 1] = nType;
                                break;
                            case 4:
                                _SE4[nRow - 1] = nType;
                                break;
                            case 5:
                                _SE5[nRow - 1] = nType;
                                break;
                            case 6:
                                _SE6[nRow - 1] = nType;
                                break;
                            case 7:
                                _SE7[nRow - 1] = nType;
                                break;
                            case 8:
                                _SE8[nRow - 1] = nType;
                                break;
                            case 9:
                                _SE9[nRow - 1] = nType;
                                break;
                            default:
                                _SEa[nRow - 1] = nType;
                                break;
                        }
                    }
                    for (int j = 1; j <= 8; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 1;
                        switch (nCol)
                        {
                            case 1:
                                _SE1[nRow - 1] = nType;
                                break;
                            case 2:
                                _SE2[nRow - 1] = nType;
                                break;
                            case 3:
                                _SE3[nRow - 1] = nType;
                                break;
                            case 4:
                                _SE4[nRow - 1] = nType;
                                break;
                            case 5:
                                _SE5[nRow - 1] = nType;
                                break;
                            case 6:
                                _SE6[nRow - 1] = nType;
                                break;
                            case 7:
                                _SE7[nRow - 1] = nType;
                                break;
                            case 8:
                                _SE8[nRow - 1] = nType;
                                break;
                            case 9:
                                _SE9[nRow - 1] = nType;
                                break;
                            default:
                                _SEa[nRow - 1] = nType;
                                break;
                        }
                    }
                    break;
                case 2:
                    for (int j = 1; j <= 8; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 4;
                        switch (nCol)
                        {
                            case 1:
                                _SE1[nRow - 1] = nType;
                                break;
                            case 2:
                                _SE2[nRow - 1] = nType;
                                break;
                            case 3:
                                _SE3[nRow - 1] = nType;
                                break;
                            case 4:
                                _SE4[nRow - 1] = nType;
                                break;
                            case 5:
                                _SE5[nRow - 1] = nType;
                                break;
                            case 6:
                                _SE6[nRow - 1] = nType;
                                break;
                            case 7:
                                _SE7[nRow - 1] = nType;
                                break;
                            case 8:
                                _SE8[nRow - 1] = nType;
                                break;
                            case 9:
                                _SE9[nRow - 1] = nType;
                                break;
                            default:
                                _SEa[nRow - 1] = nType;
                                break;
                        }
                    }
                    for (int j = 1; j <= 16; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 6;
                        switch (nCol)
                        {
                            case 1:
                                _SE1[nRow - 1] = nType;
                                break;
                            case 2:
                                _SE2[nRow - 1] = nType;
                                break;
                            case 3:
                                _SE3[nRow - 1] = nType;
                                break;
                            case 4:
                                _SE4[nRow - 1] = nType;
                                break;
                            case 5:
                                _SE5[nRow - 1] = nType;
                                break;
                            case 6:
                                _SE6[nRow - 1] = nType;
                                break;
                            case 7:
                                _SE7[nRow - 1] = nType;
                                break;
                            case 8:
                                _SE8[nRow - 1] = nType;
                                break;
                            case 9:
                                _SE9[nRow - 1] = nType;
                                break;
                            default:
                                _SEa[nRow - 1] = nType;
                                break;
                        }
                    }
                    break;
                default:
                    for (int j = 1; j <= 16; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 8;
                        switch (nCol)
                        {
                            case 1:
                                _SE1[nRow - 1] = nType;
                                break;
                            case 2:
                                _SE2[nRow - 1] = nType;
                                break;
                            case 3:
                                _SE3[nRow - 1] = nType;
                                break;
                            case 4:
                                _SE4[nRow - 1] = nType;
                                break;
                            case 5:
                                _SE5[nRow - 1] = nType;
                                break;
                            case 6:
                                _SE6[nRow - 1] = nType;
                                break;
                            case 7:
                                _SE7[nRow - 1] = nType;
                                break;
                            case 8:
                                _SE8[nRow - 1] = nType;
                                break;
                            case 9:
                                _SE9[nRow - 1] = nType;
                                break;
                            default:
                                _SEa[nRow - 1] = nType;
                                break;
                        }
                    }
                    for (int j = 1; j <= 2; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 5;
                        switch (nCol)
                        {
                            case 1:
                                _SE1[nRow - 1] = nType;
                                break;
                            case 2:
                                _SE2[nRow - 1] = nType;
                                break;
                            case 3:
                                _SE3[nRow - 1] = nType;
                                break;
                            case 4:
                                _SE4[nRow - 1] = nType;
                                break;
                            case 5:
                                _SE5[nRow - 1] = nType;
                                break;
                            case 6:
                                _SE6[nRow - 1] = nType;
                                break;
                            case 7:
                                _SE7[nRow - 1] = nType;
                                break;
                            case 8:
                                _SE8[nRow - 1] = nType;
                                break;
                            case 9:
                                _SE9[nRow - 1] = nType;
                                break;
                            default:
                                _SEa[nRow - 1] = nType;
                                break;
                        }
                    }
                    break;
            }

            switch (_qtype[2])
            {
                case 1:
                    for (int j = 1; j <= 2; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 2;
                        switch (nCol)
                        {
                            case 1:
                                _SW1[nRow - 1] = nType;
                                break;
                            case 2:
                                _SW2[nRow - 1] = nType;
                                break;
                            case 3:
                                _SW3[nRow - 1] = nType;
                                break;
                            case 4:
                                _SW4[nRow - 1] = nType;
                                break;
                            case 5:
                                _SW5[nRow - 1] = nType;
                                break;
                            case 6:
                                _SW6[nRow - 1] = nType;
                                break;
                            case 7:
                                _SW7[nRow - 1] = nType;
                                break;
                            case 8:
                                _SW8[nRow - 1] = nType;
                                break;
                            case 9:
                                _SW9[nRow - 1] = nType;
                                break;
                            default:
                                _SWa[nRow - 1] = nType;
                                break;
                        }
                    }
                    for (int j = 1; j <= 8; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 1;
                        switch (nCol)
                        {
                            case 1:
                                _SW1[nRow - 1] = nType;
                                break;
                            case 2:
                                _SW2[nRow - 1] = nType;
                                break;
                            case 3:
                                _SW3[nRow - 1] = nType;
                                break;
                            case 4:
                                _SW4[nRow - 1] = nType;
                                break;
                            case 5:
                                _SW5[nRow - 1] = nType;
                                break;
                            case 6:
                                _SW6[nRow - 1] = nType;
                                break;
                            case 7:
                                _SW7[nRow - 1] = nType;
                                break;
                            case 8:
                                _SW8[nRow - 1] = nType;
                                break;
                            case 9:
                                _SW9[nRow - 1] = nType;
                                break;
                            default:
                                _SWa[nRow - 1] = nType;
                                break;
                        }
                    }
                    break;
                case 2:
                    for (int j = 1; j <= 8; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 4;
                        switch (nCol)
                        {
                            case 1:
                                _SW1[nRow - 1] = nType;
                                break;
                            case 2:
                                _SW2[nRow - 1] = nType;
                                break;
                            case 3:
                                _SW3[nRow - 1] = nType;
                                break;
                            case 4:
                                _SW4[nRow - 1] = nType;
                                break;
                            case 5:
                                _SW5[nRow - 1] = nType;
                                break;
                            case 6:
                                _SW6[nRow - 1] = nType;
                                break;
                            case 7:
                                _SW7[nRow - 1] = nType;
                                break;
                            case 8:
                                _SW8[nRow - 1] = nType;
                                break;
                            case 9:
                                _SW9[nRow - 1] = nType;
                                break;
                            default:
                                _SWa[nRow - 1] = nType;
                                break;
                        }
                    }
                    for (int j = 1; j <= 16; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 6;
                        switch (nCol)
                        {
                            case 1:
                                _SW1[nRow - 1] = nType;
                                break;
                            case 2:
                                _SW2[nRow - 1] = nType;
                                break;
                            case 3:
                                _SW3[nRow - 1] = nType;
                                break;
                            case 4:
                                _SW4[nRow - 1] = nType;
                                break;
                            case 5:
                                _SW5[nRow - 1] = nType;
                                break;
                            case 6:
                                _SW6[nRow - 1] = nType;
                                break;
                            case 7:
                                _SW7[nRow - 1] = nType;
                                break;
                            case 8:
                                _SW8[nRow - 1] = nType;
                                break;
                            case 9:
                                _SW9[nRow - 1] = nType;
                                break;
                            default:
                                _SWa[nRow - 1] = nType;
                                break;
                        }
                    }
                    break;
                default:
                    for (int j = 1; j <= 16; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 8;
                        switch (nCol)
                        {
                            case 1:
                                _SW1[nRow - 1] = nType;
                                break;
                            case 2:
                                _SW2[nRow - 1] = nType;
                                break;
                            case 3:
                                _SW3[nRow - 1] = nType;
                                break;
                            case 4:
                                _SW4[nRow - 1] = nType;
                                break;
                            case 5:
                                _SW5[nRow - 1] = nType;
                                break;
                            case 6:
                                _SW6[nRow - 1] = nType;
                                break;
                            case 7:
                                _SW7[nRow - 1] = nType;
                                break;
                            case 8:
                                _SW8[nRow - 1] = nType;
                                break;
                            case 9:
                                _SW9[nRow - 1] = nType;
                                break;
                            default:
                                _SWa[nRow - 1] = nType;
                                break;
                        }
                    }
                    for (int j = 1; j <= 2; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 5;
                        switch (nCol)
                        {
                            case 1:
                                _SW1[nRow - 1] = nType;
                                break;
                            case 2:
                                _SW2[nRow - 1] = nType;
                                break;
                            case 3:
                                _SW3[nRow - 1] = nType;
                                break;
                            case 4:
                                _SW4[nRow - 1] = nType;
                                break;
                            case 5:
                                _SW5[nRow - 1] = nType;
                                break;
                            case 6:
                                _SW6[nRow - 1] = nType;
                                break;
                            case 7:
                                _SW7[nRow - 1] = nType;
                                break;
                            case 8:
                                _SW8[nRow - 1] = nType;
                                break;
                            case 9:
                                _SW9[nRow - 1] = nType;
                                break;
                            default:
                                _SWa[nRow - 1] = nType;
                                break;
                        }
                    }
                    break;
            }

            switch (_qtype[3])
            {
                case 1:
                    for (int j = 1; j <= 2; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 2;
                        switch (nCol)
                        {
                            case 1:
                                _NW1[nRow - 1] = nType;
                                break;
                            case 2:
                                _NW2[nRow - 1] = nType;
                                break;
                            case 3:
                                _NW3[nRow - 1] = nType;
                                break;
                            case 4:
                                _NW4[nRow - 1] = nType;
                                break;
                            case 5:
                                _NW5[nRow - 1] = nType;
                                break;
                            case 6:
                                _NW6[nRow - 1] = nType;
                                break;
                            case 7:
                                _NW7[nRow - 1] = nType;
                                break;
                            case 8:
                                _NW8[nRow - 1] = nType;
                                break;
                            case 9:
                                _NW9[nRow - 1] = nType;
                                break;
                            default:
                                _NWa[nRow - 1] = nType;
                                break;
                        }
                    }
                    for (int j = 1; j <= 8; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 1;
                        switch (nCol)
                        {
                            case 1:
                                _NW1[nRow - 1] = nType;
                                break;
                            case 2:
                                _NW2[nRow - 1] = nType;
                                break;
                            case 3:
                                _NW3[nRow - 1] = nType;
                                break;
                            case 4:
                                _NW4[nRow - 1] = nType;
                                break;
                            case 5:
                                _NW5[nRow - 1] = nType;
                                break;
                            case 6:
                                _NW6[nRow - 1] = nType;
                                break;
                            case 7:
                                _NW7[nRow - 1] = nType;
                                break;
                            case 8:
                                _NW8[nRow - 1] = nType;
                                break;
                            case 9:
                                _NW9[nRow - 1] = nType;
                                break;
                            default:
                                _NWa[nRow - 1] = nType;
                                break;
                        }
                    }
                    break;
                case 2:
                    for (int j = 1; j <= 8; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 4;
                        switch (nCol)
                        {
                            case 1:
                                _NW1[nRow - 1] = nType;
                                break;
                            case 2:
                                _NW2[nRow - 1] = nType;
                                break;
                            case 3:
                                _NW3[nRow - 1] = nType;
                                break;
                            case 4:
                                _NW4[nRow - 1] = nType;
                                break;
                            case 5:
                                _NW5[nRow - 1] = nType;
                                break;
                            case 6:
                                _NW6[nRow - 1] = nType;
                                break;
                            case 7:
                                _NW7[nRow - 1] = nType;
                                break;
                            case 8:
                                _NW8[nRow - 1] = nType;
                                break;
                            case 9:
                                _NW9[nRow - 1] = nType;
                                break;
                            default:
                                _NWa[nRow - 1] = nType;
                                break;
                        }
                    }
                    for (int j = 1; j <= 16; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 6;
                        switch (nCol)
                        {
                            case 1:
                                _NW1[nRow - 1] = nType;
                                break;
                            case 2:
                                _NW2[nRow - 1] = nType;
                                break;
                            case 3:
                                _NW3[nRow - 1] = nType;
                                break;
                            case 4:
                                _NW4[nRow - 1] = nType;
                                break;
                            case 5:
                                _NW5[nRow - 1] = nType;
                                break;
                            case 6:
                                _NW6[nRow - 1] = nType;
                                break;
                            case 7:
                                _NW7[nRow - 1] = nType;
                                break;
                            case 8:
                                _NW8[nRow - 1] = nType;
                                break;
                            case 9:
                                _NW9[nRow - 1] = nType;
                                break;
                            default:
                                _NWa[nRow - 1] = nType;
                                break;
                        }
                    }
                    break;
                default:
                    for (int j = 1; j <= 16; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 8;
                        switch (nCol)
                        {
                            case 1:
                                _NW1[nRow - 1] = nType;
                                break;
                            case 2:
                                _NW2[nRow - 1] = nType;
                                break;
                            case 3:
                                _NW3[nRow - 1] = nType;
                                break;
                            case 4:
                                _NW4[nRow - 1] = nType;
                                break;
                            case 5:
                                _NW5[nRow - 1] = nType;
                                break;
                            case 6:
                                _NW6[nRow - 1] = nType;
                                break;
                            case 7:
                                _NW7[nRow - 1] = nType;
                                break;
                            case 8:
                                _NW8[nRow - 1] = nType;
                                break;
                            case 9:
                                _NW9[nRow - 1] = nType;
                                break;
                            default:
                                _NWa[nRow - 1] = nType;
                                break;
                        }
                    }
                    for (int j = 1; j <= 2; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 5;
                        switch (nCol)
                        {
                            case 1:
                                _NW1[nRow - 1] = nType;
                                break;
                            case 2:
                                _NW2[nRow - 1] = nType;
                                break;
                            case 3:
                                _NW3[nRow - 1] = nType;
                                break;
                            case 4:
                                _NW4[nRow - 1] = nType;
                                break;
                            case 5:
                                _NW5[nRow - 1] = nType;
                                break;
                            case 6:
                                _NW6[nRow - 1] = nType;
                                break;
                            case 7:
                                _NW7[nRow - 1] = nType;
                                break;
                            case 8:
                                _NW8[nRow - 1] = nType;
                                break;
                            case 9:
                                _NW9[nRow - 1] = nType;
                                break;
                            default:
                                _NWa[nRow - 1] = nType;
                                break;
                        }
                    }
                    break;
            }

            fSetExit();
            CounterCol = rnd1.Next(1, 11);
            CounterRow = rnd1.Next(1, 11);
            CounterDirection = rnd1.Next(1, 5);
            fSyncCounter();
            fUpdateDisplay();

        }

        private void btnCollect_Click(object sender, EventArgs e)
        {
            int nCol, nRow, nType;


            if (_qtype[nQuadrant - 1] == 2)
            {
                nCol = _HolderACol[3];
                nRow = _HolderARow[3];
                switch (nQuadrant)
                {
                    case 1:
                        switch (nCol)
                        {
                            case 1:
                                nType = _NE1[nRow - 1];
                                break;
                            case 2:
                                nType = _NE2[nRow - 1];
                                break;
                            case 3:
                                nType = _NE3[nRow - 1];
                                break;
                            case 4:
                                nType = _NE4[nRow - 1];
                                break;
                            case 5:
                                nType = _NE5[nRow - 1];
                                break;
                            case 6:
                                nType = _NE6[nRow - 1];
                                break;
                            case 7:
                                nType = _NE7[nRow - 1];
                                break;
                            case 8:
                                nType = _NE8[nRow - 1];
                                break;
                            case 9:
                                nType = _NE9[nRow - 1];
                                break;
                            default:
                                nType = _NEa[nRow - 1];
                                break;
                        }
                        break;
                    case 2:
                        switch (nCol)
                        {
                            case 1:
                                nType = _SE1[nRow - 1];
                                break;
                            case 2:
                                nType = _SE2[nRow - 1];
                                break;
                            case 3:
                                nType = _SE3[nRow - 1];
                                break;
                            case 4:
                                nType = _SE4[nRow - 1];
                                break;
                            case 5:
                                nType = _SE5[nRow - 1];
                                break;
                            case 6:
                                nType = _SE6[nRow - 1];
                                break;
                            case 7:
                                nType = _SE7[nRow - 1];
                                break;
                            case 8:
                                nType = _SE8[nRow - 1];
                                break;
                            case 9:
                                nType = _SE9[nRow - 1];
                                break;
                            default:
                                nType = _SEa[nRow - 1];
                                break;
                        }
                        break;
                    case 3:
                        switch (nCol)
                        {
                            case 1:
                                nType = _SW1[nRow - 1];
                                break;
                            case 2:
                                nType = _SW2[nRow - 1];
                                break;
                            case 3:
                                nType = _SW3[nRow - 1];
                                break;
                            case 4:
                                nType = _SW4[nRow - 1];
                                break;
                            case 5:
                                nType = _SW5[nRow - 1];
                                break;
                            case 6:
                                nType = _SW6[nRow - 1];
                                break;
                            case 7:
                                nType = _SW7[nRow - 1];
                                break;
                            case 8:
                                nType = _SW8[nRow - 1];
                                break;
                            case 9:
                                nType = _SW9[nRow - 1];
                                break;
                            default:
                                nType = _SWa[nRow - 1];
                                break;
                        }
                        break;
                    default:
                        switch (nCol)
                        {
                            case 1:
                                nType = _NW1[nRow - 1];
                                break;
                            case 2:
                                nType = _NW2[nRow - 1];
                                break;
                            case 3:
                                nType = _NW3[nRow - 1];
                                break;
                            case 4:
                                nType = _NW4[nRow - 1];
                                break;
                            case 5:
                                nType = _NW5[nRow - 1];
                                break;
                            case 6:
                                nType = _NW6[nRow - 1];
                                break;
                            case 7:
                                nType = _NW7[nRow - 1];
                                break;
                            case 8:
                                nType = _NW8[nRow - 1];
                                break;
                            case 9:
                                nType = _NW9[nRow - 1];
                                break;
                            default:
                                nType = _NWa[nRow - 1];
                                break;
                        }
                        break;
                }
                switch (nType)
                {
                    case 4:
                        switch (nQuadrant)
                        {
                            case 1:
                                switch (nCol)
                                {
                                    case 1:
                                        _NE1[nRow - 1] = 10;
                                        break;
                                    case 2:
                                        _NE2[nRow - 1] = 10;
                                        break;
                                    case 3:
                                        _NE3[nRow - 1] = 10;
                                        break;
                                    case 4:
                                        _NE4[nRow - 1] = 10;
                                        break;
                                    case 5:
                                        _NE5[nRow - 1] = 10;
                                        break;
                                    case 6:
                                        _NE6[nRow - 1] = 10;
                                        break;
                                    case 7:
                                        _NE7[nRow - 1] = 10;
                                        break;
                                    case 8:
                                        _NE8[nRow - 1] = 10;
                                        break;
                                    case 9:
                                        _NE9[nRow - 1] = 10;
                                        break;
                                    default:
                                        _NEa[nRow - 1] = 10; ;
                                        break;
                                }
                                break;
                            case 2:
                                switch (nCol)
                                {
                                    case 1:
                                        _SE1[nRow - 1] = 10;
                                        break;
                                    case 2:
                                        _SE2[nRow - 1] = 10;
                                        break;
                                    case 3:
                                        _SE3[nRow - 1] = 10;
                                        break;
                                    case 4:
                                        _SE4[nRow - 1] = 10;
                                        break;
                                    case 5:
                                        _SE5[nRow - 1] = 10;
                                        break;
                                    case 6:
                                        _SE6[nRow - 1] = 10;
                                        break;
                                    case 7:
                                        _SE7[nRow - 1] = 10;
                                        break;
                                    case 8:
                                        _SE8[nRow - 1] = 10;
                                        break;
                                    case 9:
                                        _SE9[nRow - 1] = 10;
                                        break;
                                    default:
                                        _SEa[nRow - 1] = 10; ;
                                        break;
                                }
                                break;
                            case 3:
                                switch (nCol)
                                {
                                    case 1:
                                        _SW1[nRow - 1] = 10;
                                        break;
                                    case 2:
                                        _SW2[nRow - 1] = 10;
                                        break;
                                    case 3:
                                        _SW3[nRow - 1] = 10;
                                        break;
                                    case 4:
                                        _SW4[nRow - 1] = 10;
                                        break;
                                    case 5:
                                        _SW5[nRow - 1] = 10;
                                        break;
                                    case 6:
                                        _SW6[nRow - 1] = 10;
                                        break;
                                    case 7:
                                        _SW7[nRow - 1] = 10;
                                        break;
                                    case 8:
                                        _SW8[nRow - 1] = 10;
                                        break;
                                    case 9:
                                        _SW9[nRow - 1] = 10;
                                        break;
                                    default:
                                        _SWa[nRow - 1] = 10; ;
                                        break;
                                }
                                break;
                            default:
                                switch (nCol)
                                {
                                    case 1:
                                        _NW1[nRow - 1] = 10;
                                        break;
                                    case 2:
                                        _NW2[nRow - 1] = 10;
                                        break;
                                    case 3:
                                        _NW3[nRow - 1] = 10;
                                        break;
                                    case 4:
                                        _NW4[nRow - 1] = 10;
                                        break;
                                    case 5:
                                        _NW5[nRow - 1] = 10;
                                        break;
                                    case 6:
                                        _NW6[nRow - 1] = 10;
                                        break;
                                    case 7:
                                        _NW7[nRow - 1] = 10;
                                        break;
                                    case 8:
                                        _NW8[nRow - 1] = 10;
                                        break;
                                    case 9:
                                        _NW9[nRow - 1] = 10;
                                        break;
                                    default:
                                        _NWa[nRow - 1] = 10; ;
                                        break;
                                }
                                break;
                        }
                        break;
                    case 6:
                        switch (nQuadrant)
                        {
                            case 1:
                                switch (nCol)
                                {
                                    case 1:
                                        _NE1[nRow - 1] = 10;
                                        break;
                                    case 2:
                                        _NE2[nRow - 1] = 10;
                                        break;
                                    case 3:
                                        _NE3[nRow - 1] = 10;
                                        break;
                                    case 4:
                                        _NE4[nRow - 1] = 10;
                                        break;
                                    case 5:
                                        _NE5[nRow - 1] = 10;
                                        break;
                                    case 6:
                                        _NE6[nRow - 1] = 10;
                                        break;
                                    case 7:
                                        _NE7[nRow - 1] = 10;
                                        break;
                                    case 8:
                                        _NE8[nRow - 1] = 10;
                                        break;
                                    case 9:
                                        _NE9[nRow - 1] = 10;
                                        break;
                                    default:
                                        _NEa[nRow - 1] = 10; ;
                                        break;
                                }
                                break;
                            case 2:
                                switch (nCol)
                                {
                                    case 1:
                                        _SE1[nRow - 1] = 10;
                                        break;
                                    case 2:
                                        _SE2[nRow - 1] = 10;
                                        break;
                                    case 3:
                                        _SE3[nRow - 1] = 10;
                                        break;
                                    case 4:
                                        _SE4[nRow - 1] = 10;
                                        break;
                                    case 5:
                                        _SE5[nRow - 1] = 10;
                                        break;
                                    case 6:
                                        _SE6[nRow - 1] = 10;
                                        break;
                                    case 7:
                                        _SE7[nRow - 1] = 10;
                                        break;
                                    case 8:
                                        _SE8[nRow - 1] = 10;
                                        break;
                                    case 9:
                                        _SE9[nRow - 1] = 10;
                                        break;
                                    default:
                                        _SEa[nRow - 1] = 10; ;
                                        break;
                                }
                                break;
                            case 3:
                                switch (nCol)
                                {
                                    case 1:
                                        _SW1[nRow - 1] = 10;
                                        break;
                                    case 2:
                                        _SW2[nRow - 1] = 10;
                                        break;
                                    case 3:
                                        _SW3[nRow - 1] = 10;
                                        break;
                                    case 4:
                                        _SW4[nRow - 1] = 10;
                                        break;
                                    case 5:
                                        _SW5[nRow - 1] = 10;
                                        break;
                                    case 6:
                                        _SW6[nRow - 1] = 10;
                                        break;
                                    case 7:
                                        _SW7[nRow - 1] = 10;
                                        break;
                                    case 8:
                                        _SW8[nRow - 1] = 10;
                                        break;
                                    case 9:
                                        _SW9[nRow - 1] = 10;
                                        break;
                                    default:
                                        _SWa[nRow - 1] = 10; ;
                                        break;
                                }
                                break;
                            default:
                                switch (nCol)
                                {
                                    case 1:
                                        _NW1[nRow - 1] = 10;
                                        break;
                                    case 2:
                                        _NW2[nRow - 1] = 10;
                                        break;
                                    case 3:
                                        _NW3[nRow - 1] = 10;
                                        break;
                                    case 4:
                                        _NW4[nRow - 1] = 10;
                                        break;
                                    case 5:
                                        _NW5[nRow - 1] = 10;
                                        break;
                                    case 6:
                                        _NW6[nRow - 1] = 10;
                                        break;
                                    case 7:
                                        _NW7[nRow - 1] = 10;
                                        break;
                                    case 8:
                                        _NW8[nRow - 1] = 10;
                                        break;
                                    case 9:
                                        _NW9[nRow - 1] = 10;
                                        break;
                                    default:
                                        _NWa[nRow - 1] = 10; ;
                                        break;
                                }
                                break;
                        }
                        break;
                    default:
                        MessageBox.Show("Error!");
                        return;
                }
                nScore += 10;
                fUpdateDisplay();
                }
         }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            int nCol, nRow, nType;


            if (_qtype[nQuadrant - 1] == 3)
            {
                nCol = _HolderACol[3];
                nRow = _HolderARow[3];
                switch (nQuadrant)
                {
                    case 1:
                        switch (nCol)
                        {
                            case 1:
                                nType = _NE1[nRow - 1];
                                break;
                            case 2:
                                nType = _NE2[nRow - 1];
                                break;
                            case 3:
                                nType = _NE3[nRow - 1];
                                break;
                            case 4:
                                nType = _NE4[nRow - 1];
                                break;
                            case 5:
                                nType = _NE5[nRow - 1];
                                break;
                            case 6:
                                nType = _NE6[nRow - 1];
                                break;
                            case 7:
                                nType = _NE7[nRow - 1];
                                break;
                            case 8:
                                nType = _NE8[nRow - 1];
                                break;
                            case 9:
                                nType = _NE9[nRow - 1];
                                break;
                            default:
                                nType = _NEa[nRow - 1];
                                break;
                        }
                        break;
                    case 2:
                        switch (nCol)
                        {
                            case 1:
                                nType = _SE1[nRow - 1];
                                break;
                            case 2:
                                nType = _SE2[nRow - 1];
                                break;
                            case 3:
                                nType = _SE3[nRow - 1];
                                break;
                            case 4:
                                nType = _SE4[nRow - 1];
                                break;
                            case 5:
                                nType = _SE5[nRow - 1];
                                break;
                            case 6:
                                nType = _SE6[nRow - 1];
                                break;
                            case 7:
                                nType = _SE7[nRow - 1];
                                break;
                            case 8:
                                nType = _SE8[nRow - 1];
                                break;
                            case 9:
                                nType = _SE9[nRow - 1];
                                break;
                            default:
                                nType = _SEa[nRow - 1];
                                break;
                        }
                        break;
                    case 3:
                        switch (nCol)
                        {
                            case 1:
                                nType = _SW1[nRow - 1];
                                break;
                            case 2:
                                nType = _SW2[nRow - 1];
                                break;
                            case 3:
                                nType = _SW3[nRow - 1];
                                break;
                            case 4:
                                nType = _SW4[nRow - 1];
                                break;
                            case 5:
                                nType = _SW5[nRow - 1];
                                break;
                            case 6:
                                nType = _SW6[nRow - 1];
                                break;
                            case 7:
                                nType = _SW7[nRow - 1];
                                break;
                            case 8:
                                nType = _SW8[nRow - 1];
                                break;
                            case 9:
                                nType = _SW9[nRow - 1];
                                break;
                            default:
                                nType = _SWa[nRow - 1];
                                break;
                        }
                        break;
                    default:
                        switch (nCol)
                        {
                            case 1:
                                nType = _NW1[nRow - 1];
                                break;
                            case 2:
                                nType = _NW2[nRow - 1];
                                break;
                            case 3:
                                nType = _NW3[nRow - 1];
                                break;
                            case 4:
                                nType = _NW4[nRow - 1];
                                break;
                            case 5:
                                nType = _NW5[nRow - 1];
                                break;
                            case 6:
                                nType = _NW6[nRow - 1];
                                break;
                            case 7:
                                nType = _NW7[nRow - 1];
                                break;
                            case 8:
                                nType = _NW8[nRow - 1];
                                break;
                            case 9:
                                nType = _NW9[nRow - 1];
                                break;
                            default:
                                nType = _NWa[nRow - 1];
                                break;
                        }
                        break;
                }
                switch (nType)
                {
                    case 9:
                        switch (nQuadrant)
                        {
                            case 1:
                                switch (nCol)
                                {
                                    case 1:
                                        _NE1[nRow - 1] = 8;
                                        break;
                                    case 2:
                                        _NE2[nRow - 1] = 8;
                                        break;
                                    case 3:
                                        _NE3[nRow - 1] = 8;
                                        break;
                                    case 4:
                                        _NE4[nRow - 1] = 8;
                                        break;
                                    case 5:
                                        _NE5[nRow - 1] = 8;
                                        break;
                                    case 6:
                                        _NE6[nRow - 1] = 8;
                                        break;
                                    case 7:
                                        _NE7[nRow - 1] = 8;
                                        break;
                                    case 8:
                                        _NE8[nRow - 1] = 8;
                                        break;
                                    case 9:
                                        _NE9[nRow - 1] = 8;
                                        break;
                                    default:
                                        _NEa[nRow - 1] = 8; ;
                                        break;
                                }
                                break;
                            case 2:
                                switch (nCol)
                                {
                                    case 1:
                                        _SE1[nRow - 1] = 8;
                                        break;
                                    case 2:
                                        _SE2[nRow - 1] = 8;
                                        break;
                                    case 3:
                                        _SE3[nRow - 1] = 8;
                                        break;
                                    case 4:
                                        _SE4[nRow - 1] = 8;
                                        break;
                                    case 5:
                                        _SE5[nRow - 1] = 8;
                                        break;
                                    case 6:
                                        _SE6[nRow - 1] = 8;
                                        break;
                                    case 7:
                                        _SE7[nRow - 1] = 8;
                                        break;
                                    case 8:
                                        _SE8[nRow - 1] = 8;
                                        break;
                                    case 9:
                                        _SE9[nRow - 1] = 8;
                                        break;
                                    default:
                                        _SEa[nRow - 1] = 8; ;
                                        break;
                                }
                                break;
                            case 3:
                                switch (nCol)
                                {
                                    case 1:
                                        _SW1[nRow - 1] = 8;
                                        break;
                                    case 2:
                                        _SW2[nRow - 1] = 8;
                                        break;
                                    case 3:
                                        _SW3[nRow - 1] = 8;
                                        break;
                                    case 4:
                                        _SW4[nRow - 1] = 8;
                                        break;
                                    case 5:
                                        _SW5[nRow - 1] = 8;
                                        break;
                                    case 6:
                                        _SW6[nRow - 1] = 8;
                                        break;
                                    case 7:
                                        _SW7[nRow - 1] = 8;
                                        break;
                                    case 8:
                                        _SW8[nRow - 1] = 8;
                                        break;
                                    case 9:
                                        _SW9[nRow - 1] = 8;
                                        break;
                                    default:
                                        _SWa[nRow - 1] = 8; ;
                                        break;
                                }
                                break;
                            default:
                                switch (nCol)
                                {
                                    case 1:
                                        _NW1[nRow - 1] = 8;
                                        break;
                                    case 2:
                                        _NW2[nRow - 1] = 8;
                                        break;
                                    case 3:
                                        _NW3[nRow - 1] = 8;
                                        break;
                                    case 4:
                                        _NW4[nRow - 1] = 8;
                                        break;
                                    case 5:
                                        _NW5[nRow - 1] = 8;
                                        break;
                                    case 6:
                                        _NW6[nRow - 1] = 8;
                                        break;
                                    case 7:
                                        _NW7[nRow - 1] = 8;
                                        break;
                                    case 8:
                                        _NW8[nRow - 1] = 8;
                                        break;
                                    case 9:
                                        _NW9[nRow - 1] = 8;
                                        break;
                                    default:
                                        _NWa[nRow - 1] = 8; ;
                                        break;
                                }
                                break;
                        }
                        break;
                    case 10:
                        switch (nQuadrant)
                        {
                            case 1:
                                switch (nCol)
                                {
                                    case 1:
                                        _NE1[nRow - 1] = 8;
                                        break;
                                    case 2:
                                        _NE2[nRow - 1] = 8;
                                        break;
                                    case 3:
                                        _NE3[nRow - 1] = 8;
                                        break;
                                    case 4:
                                        _NE4[nRow - 1] = 8;
                                        break;
                                    case 5:
                                        _NE5[nRow - 1] = 8;
                                        break;
                                    case 6:
                                        _NE6[nRow - 1] = 8;
                                        break;
                                    case 7:
                                        _NE7[nRow - 1] = 8;
                                        break;
                                    case 8:
                                        _NE8[nRow - 1] = 8;
                                        break;
                                    case 9:
                                        _NE9[nRow - 1] = 8;
                                        break;
                                    default:
                                        _NEa[nRow - 1] = 8; ;
                                        break;
                                }
                                break;
                            case 2:
                                switch (nCol)
                                {
                                    case 1:
                                        _SE1[nRow - 1] = 8;
                                        break;
                                    case 2:
                                        _SE2[nRow - 1] = 8;
                                        break;
                                    case 3:
                                        _SE3[nRow - 1] = 8;
                                        break;
                                    case 4:
                                        _SE4[nRow - 1] = 8;
                                        break;
                                    case 5:
                                        _SE5[nRow - 1] = 8;
                                        break;
                                    case 6:
                                        _SE6[nRow - 1] = 8;
                                        break;
                                    case 7:
                                        _SE7[nRow - 1] = 8;
                                        break;
                                    case 8:
                                        _SE8[nRow - 1] = 8;
                                        break;
                                    case 9:
                                        _SE9[nRow - 1] = 8;
                                        break;
                                    default:
                                        _SEa[nRow - 1] = 8; ;
                                        break;
                                }
                                break;
                            case 3:
                                switch (nCol)
                                {
                                    case 1:
                                        _SW1[nRow - 1] = 8;
                                        break;
                                    case 2:
                                        _SW2[nRow - 1] = 8;
                                        break;
                                    case 3:
                                        _SW3[nRow - 1] = 8;
                                        break;
                                    case 4:
                                        _SW4[nRow - 1] = 8;
                                        break;
                                    case 5:
                                        _SW5[nRow - 1] = 8;
                                        break;
                                    case 6:
                                        _SW6[nRow - 1] = 8;
                                        break;
                                    case 7:
                                        _SW7[nRow - 1] = 8;
                                        break;
                                    case 8:
                                        _SW8[nRow - 1] = 8;
                                        break;
                                    case 9:
                                        _SW9[nRow - 1] = 8;
                                        break;
                                    default:
                                        _SWa[nRow - 1] = 8; ;
                                        break;
                                }
                                break;
                            default:
                                switch (nCol)
                                {
                                    case 1:
                                        _NW1[nRow - 1] = 8;
                                        break;
                                    case 2:
                                        _NW2[nRow - 1] = 8;
                                        break;
                                    case 3:
                                        _NW3[nRow - 1] = 8;
                                        break;
                                    case 4:
                                        _NW4[nRow - 1] = 8;
                                        break;
                                    case 5:
                                        _NW5[nRow - 1] = 8;
                                        break;
                                    case 6:
                                        _NW6[nRow - 1] = 8;
                                        break;
                                    case 7:
                                        _NW7[nRow - 1] = 8;
                                        break;
                                    case 8:
                                        _NW8[nRow - 1] = 8;
                                        break;
                                    case 9:
                                        _NW9[nRow - 1] = 8;
                                        break;
                                    default:
                                        _NWa[nRow - 1] = 8; ;
                                        break;
                                }
                                break;
                        }
                        break;
                    case 8:
                        switch (nQuadrant)
                        {
                            case 1:
                                switch (nCol)
                                {
                                    case 1:
                                        _NE1[nRow - 1] = 5;
                                        break;
                                    case 2:
                                        _NE2[nRow - 1] = 5;
                                        break;
                                    case 3:
                                        _NE3[nRow - 1] = 5;
                                        break;
                                    case 4:
                                        _NE4[nRow - 1] = 5;
                                        break;
                                    case 5:
                                        _NE5[nRow - 1] = 5;
                                        break;
                                    case 6:
                                        _NE6[nRow - 1] = 5;
                                        break;
                                    case 7:
                                        _NE7[nRow - 1] = 5;
                                        break;
                                    case 8:
                                        _NE8[nRow - 1] = 5;
                                        break;
                                    case 9:
                                        _NE9[nRow - 1] = 5;
                                        break;
                                    default:
                                        _NEa[nRow - 1] = 5; ;
                                        break;
                                }
                                break;
                            case 2:
                                switch (nCol)
                                {
                                    case 1:
                                        _SE1[nRow - 1] = 5;
                                        break;
                                    case 2:
                                        _SE2[nRow - 1] = 5;
                                        break;
                                    case 3:
                                        _SE3[nRow - 1] = 5;
                                        break;
                                    case 4:
                                        _SE4[nRow - 1] = 5;
                                        break;
                                    case 5:
                                        _SE5[nRow - 1] = 5;
                                        break;
                                    case 6:
                                        _SE6[nRow - 1] = 5;
                                        break;
                                    case 7:
                                        _SE7[nRow - 1] = 5;
                                        break;
                                    case 8:
                                        _SE8[nRow - 1] = 5;
                                        break;
                                    case 9:
                                        _SE9[nRow - 1] = 5;
                                        break;
                                    default:
                                        _SEa[nRow - 1] = 5; ;
                                        break;
                                }
                                break;
                            case 3:
                                switch (nCol)
                                {
                                    case 1:
                                        _SW1[nRow - 1] = 5;
                                        break;
                                    case 2:
                                        _SW2[nRow - 1] = 5;
                                        break;
                                    case 3:
                                        _SW3[nRow - 1] = 5;
                                        break;
                                    case 4:
                                        _SW4[nRow - 1] = 5;
                                        break;
                                    case 5:
                                        _SW5[nRow - 1] = 5;
                                        break;
                                    case 6:
                                        _SW6[nRow - 1] = 5;
                                        break;
                                    case 7:
                                        _SW7[nRow - 1] = 5;
                                        break;
                                    case 8:
                                        _SW8[nRow - 1] = 5;
                                        break;
                                    case 9:
                                        _SW9[nRow - 1] = 5;
                                        break;
                                    default:
                                        _SWa[nRow - 1] = 5; ;
                                        break;
                                }
                                break;
                            default:
                                switch (nCol)
                                {
                                    case 1:
                                        _NW1[nRow - 1] = 5;
                                        break;
                                    case 2:
                                        _NW2[nRow - 1] = 5;
                                        break;
                                    case 3:
                                        _NW3[nRow - 1] = 5;
                                        break;
                                    case 4:
                                        _NW4[nRow - 1] = 5;
                                        break;
                                    case 5:
                                        _NW5[nRow - 1] = 5;
                                        break;
                                    case 6:
                                        _NW6[nRow - 1] = 5;
                                        break;
                                    case 7:
                                        _NW7[nRow - 1] = 5;
                                        break;
                                    case 8:
                                        _NW8[nRow - 1] = 5;
                                        break;
                                    case 9:
                                        _NW9[nRow - 1] = 5;
                                        break;
                                    default:
                                        _NWa[nRow - 1] = 5; ;
                                        break;
                                }
                                break;
                        }
                        break;
                    default:
                        MessageBox.Show("Error!");
                        return;
                }
                nScore += 10;
                fUpdateDisplay();
            }
        }

        private void btnComply_Click(object sender, EventArgs e)
        {
            int nCol, nRow, nType;


                nCol = _HolderACol[3];
                nRow = _HolderARow[3];
            switch (nQuadrant)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NE1[nRow - 1];
                            break;
                        case 2:
                            nType = _NE2[nRow - 1];
                            break;
                        case 3:
                            nType = _NE3[nRow - 1];
                            break;
                        case 4:
                            nType = _NE4[nRow - 1];
                            break;
                        case 5:
                            nType = _NE5[nRow - 1];
                            break;
                        case 6:
                            nType = _NE6[nRow - 1];
                            break;
                        case 7:
                            nType = _NE7[nRow - 1];
                            break;
                        case 8:
                            nType = _NE8[nRow - 1];
                            break;
                        case 9:
                            nType = _NE9[nRow - 1];
                            break;
                        default:
                            nType = _NEa[nRow - 1];
                            break;
                    }
                    break;
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SE1[nRow - 1];
                            break;
                        case 2:
                            nType = _SE2[nRow - 1];
                            break;
                        case 3:
                            nType = _SE3[nRow - 1];
                            break;
                        case 4:
                            nType = _SE4[nRow - 1];
                            break;
                        case 5:
                            nType = _SE5[nRow - 1];
                            break;
                        case 6:
                            nType = _SE6[nRow - 1];
                            break;
                        case 7:
                            nType = _SE7[nRow - 1];
                            break;
                        case 8:
                            nType = _SE8[nRow - 1];
                            break;
                        case 9:
                            nType = _SE9[nRow - 1];
                            break;
                        default:
                            nType = _SEa[nRow - 1];
                            break;
                    }
                    break;
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            nType = _SW1[nRow - 1];
                            break;
                        case 2:
                            nType = _SW2[nRow - 1];
                            break;
                        case 3:
                            nType = _SW3[nRow - 1];
                            break;
                        case 4:
                            nType = _SW4[nRow - 1];
                            break;
                        case 5:
                            nType = _SW5[nRow - 1];
                            break;
                        case 6:
                            nType = _SW6[nRow - 1];
                            break;
                        case 7:
                            nType = _SW7[nRow - 1];
                            break;
                        case 8:
                            nType = _SW8[nRow - 1];
                            break;
                        case 9:
                            nType = _SW9[nRow - 1];
                            break;
                        default:
                            nType = _SWa[nRow - 1];
                            break;
                    }
                    break;
                default:
                    switch (nCol)
                    {
                        case 1:
                            nType = _NW1[nRow - 1];
                            break;
                        case 2:
                            nType = _NW2[nRow - 1];
                            break;
                        case 3:
                            nType = _NW3[nRow - 1];
                            break;
                        case 4:
                            nType = _NW4[nRow - 1];
                            break;
                        case 5:
                            nType = _NW5[nRow - 1];
                            break;
                        case 6:
                            nType = _NW6[nRow - 1];
                            break;
                        case 7:
                            nType = _NW7[nRow - 1];
                            break;
                        case 8:
                            nType = _NW8[nRow - 1];
                            break;
                        case 9:
                            nType = _NW9[nRow - 1];
                            break;
                        default:
                            nType = _NWa[nRow - 1];
                            break;
                    }
                    break;
            }
            if (nType == 3)
            {
                MessageBox.Show("You win!", "GameEnded");
                Random rnd1 = new Random();

                for (int i = 1; i <= 4; i++)
                {
                    _qtype[i - 1] = rnd1.Next(1, 4);
                }
                for (int i = 1; i <= 10; i++)
                {
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _NE1[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _NE2[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _NE3[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _NE4[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _NE5[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _NE6[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _NE7[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _NE8[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _NE9[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _NEa[i - 1] = nType;


                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _SE1[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _SE2[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _SE3[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _SE4[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _SE5[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _SE6[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _SE7[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _SE8[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _SE9[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _SEa[i - 1] = nType;

                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _SW1[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _SW2[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _SW3[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _SW4[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _SW5[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _SW6[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _SW7[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _SW8[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _SW9[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _SWa[i - 1] = nType;


                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _NW1[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _NW2[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _NW3[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _NW4[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _NW5[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _NW6[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _NW7[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _NW8[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _NW9[i - 1] = nType;
                    nType = rnd1.Next(1, 10);
                    if (nType <= 5)
                    {
                        nType = 9;
                    }
                    else
                    {
                        nType = 10;
                    }
                    _NWa[i - 1] = nType;
                }

                switch (_qtype[0])
                {
                    case 1:
                        for (int j = 1; j <= 2; j++)
                        {
                            nCol = rnd1.Next(1, 11);
                            nRow = rnd1.Next(1, 11);
                            nType = 2;
                            switch (nCol)
                            {
                                case 1:
                                    _NE1[nRow - 1] = nType;
                                    break;
                                case 2:
                                    _NE2[nRow - 1] = nType;
                                    break;
                                case 3:
                                    _NE3[nRow - 1] = nType;
                                    break;
                                case 4:
                                    _NE4[nRow - 1] = nType;
                                    break;
                                case 5:
                                    _NE5[nRow - 1] = nType;
                                    break;
                                case 6:
                                    _NE6[nRow - 1] = nType;
                                    break;
                                case 7:
                                    _NE7[nRow - 1] = nType;
                                    break;
                                case 8:
                                    _NE8[nRow - 1] = nType;
                                    break;
                                case 9:
                                    _NE9[nRow - 1] = nType;
                                    break;
                                default:
                                    _NEa[nRow - 1] = nType;
                                    break;
                            }
                        }
                        for (int j = 1; j <= 8; j++)
                        {
                            nCol = rnd1.Next(1, 11);
                            nRow = rnd1.Next(1, 11);
                            nType = 1;
                            switch (nCol)
                            {
                                case 1:
                                    _NE1[nRow - 1] = nType;
                                    break;
                                case 2:
                                    _NE2[nRow - 1] = nType;
                                    break;
                                case 3:
                                    _NE3[nRow - 1] = nType;
                                    break;
                                case 4:
                                    _NE4[nRow - 1] = nType;
                                    break;
                                case 5:
                                    _NE5[nRow - 1] = nType;
                                    break;
                                case 6:
                                    _NE6[nRow - 1] = nType;
                                    break;
                                case 7:
                                    _NE7[nRow - 1] = nType;
                                    break;
                                case 8:
                                    _NE8[nRow - 1] = nType;
                                    break;
                                case 9:
                                    _NE9[nRow - 1] = nType;
                                    break;
                                default:
                                    _NEa[nRow - 1] = nType;
                                    break;
                            }
                        }
                        break;
                    case 2:
                        for (int j = 1; j <= 8; j++)
                        {
                            nCol = rnd1.Next(1, 11);
                            nRow = rnd1.Next(1, 11);
                            nType = 4;
                            switch (nCol)
                            {
                                case 1:
                                    _NE1[nRow - 1] = nType;
                                    break;
                                case 2:
                                    _NE2[nRow - 1] = nType;
                                    break;
                                case 3:
                                    _NE3[nRow - 1] = nType;
                                    break;
                                case 4:
                                    _NE4[nRow - 1] = nType;
                                    break;
                                case 5:
                                    _NE5[nRow - 1] = nType;
                                    break;
                                case 6:
                                    _NE6[nRow - 1] = nType;
                                    break;
                                case 7:
                                    _NE7[nRow - 1] = nType;
                                    break;
                                case 8:
                                    _NE8[nRow - 1] = nType;
                                    break;
                                case 9:
                                    _NE9[nRow - 1] = nType;
                                    break;
                                default:
                                    _NEa[nRow - 1] = nType;
                                    break;
                            }
                        }
                        for (int j = 1; j <= 16; j++)
                        {
                            nCol = rnd1.Next(1, 11);
                            nRow = rnd1.Next(1, 11);
                            nType = 6;
                            switch (nCol)
                            {
                                case 1:
                                    _NE1[nRow - 1] = nType;
                                    break;
                                case 2:
                                    _NE2[nRow - 1] = nType;
                                    break;
                                case 3:
                                    _NE3[nRow - 1] = nType;
                                    break;
                                case 4:
                                    _NE4[nRow - 1] = nType;
                                    break;
                                case 5:
                                    _NE5[nRow - 1] = nType;
                                    break;
                                case 6:
                                    _NE6[nRow - 1] = nType;
                                    break;
                                case 7:
                                    _NE7[nRow - 1] = nType;
                                    break;
                                case 8:
                                    _NE8[nRow - 1] = nType;
                                    break;
                                case 9:
                                    _NE9[nRow - 1] = nType;
                                    break;
                                default:
                                    _NEa[nRow - 1] = nType;
                                    break;
                            }
                        }
                        break;
                    default:
                        for (int j = 1; j <= 16; j++)
                        {
                            nCol = rnd1.Next(1, 11);
                            nRow = rnd1.Next(1, 11);
                            nType = 8;
                            switch (nCol)
                            {
                                case 1:
                                    _NE1[nRow - 1] = nType;
                                    break;
                                case 2:
                                    _NE2[nRow - 1] = nType;
                                    break;
                                case 3:
                                    _NE3[nRow - 1] = nType;
                                    break;
                                case 4:
                                    _NE4[nRow - 1] = nType;
                                    break;
                                case 5:
                                    _NE5[nRow - 1] = nType;
                                    break;
                                case 6:
                                    _NE6[nRow - 1] = nType;
                                    break;
                                case 7:
                                    _NE7[nRow - 1] = nType;
                                    break;
                                case 8:
                                    _NE8[nRow - 1] = nType;
                                    break;
                                case 9:
                                    _NE9[nRow - 1] = nType;
                                    break;
                                default:
                                    _NEa[nRow - 1] = nType;
                                    break;
                            }
                        }
                        for (int j = 1; j <= 2; j++)
                        {
                            nCol = rnd1.Next(1, 11);
                            nRow = rnd1.Next(1, 11);
                            nType = 5;
                            switch (nCol)
                            {
                                case 1:
                                    _NE1[nRow - 1] = nType;
                                    break;
                                case 2:
                                    _NE2[nRow - 1] = nType;
                                    break;
                                case 3:
                                    _NE3[nRow - 1] = nType;
                                    break;
                                case 4:
                                    _NE4[nRow - 1] = nType;
                                    break;
                                case 5:
                                    _NE5[nRow - 1] = nType;
                                    break;
                                case 6:
                                    _NE6[nRow - 1] = nType;
                                    break;
                                case 7:
                                    _NE7[nRow - 1] = nType;
                                    break;
                                case 8:
                                    _NE8[nRow - 1] = nType;
                                    break;
                                case 9:
                                    _NE9[nRow - 1] = nType;
                                    break;
                                default:
                                    _NEa[nRow - 1] = nType;
                                    break;
                            }
                        }
                        break;
                }
                switch (_qtype[1])
                {
                    case 1:
                        for (int j = 1; j <= 2; j++)
                        {
                            nCol = rnd1.Next(1, 11);
                            nRow = rnd1.Next(1, 11);
                            nType = 2;
                            switch (nCol)
                            {
                                case 1:
                                    _SE1[nRow - 1] = nType;
                                    break;
                                case 2:
                                    _SE2[nRow - 1] = nType;
                                    break;
                                case 3:
                                    _SE3[nRow - 1] = nType;
                                    break;
                                case 4:
                                    _SE4[nRow - 1] = nType;
                                    break;
                                case 5:
                                    _SE5[nRow - 1] = nType;
                                    break;
                                case 6:
                                    _SE6[nRow - 1] = nType;
                                    break;
                                case 7:
                                    _SE7[nRow - 1] = nType;
                                    break;
                                case 8:
                                    _SE8[nRow - 1] = nType;
                                    break;
                                case 9:
                                    _SE9[nRow - 1] = nType;
                                    break;
                                default:
                                    _SEa[nRow - 1] = nType;
                                    break;
                            }
                        }
                        for (int j = 1; j <= 8; j++)
                        {
                            nCol = rnd1.Next(1, 11);
                            nRow = rnd1.Next(1, 11);
                            nType = 1;
                            switch (nCol)
                            {
                                case 1:
                                    _SE1[nRow - 1] = nType;
                                    break;
                                case 2:
                                    _SE2[nRow - 1] = nType;
                                    break;
                                case 3:
                                    _SE3[nRow - 1] = nType;
                                    break;
                                case 4:
                                    _SE4[nRow - 1] = nType;
                                    break;
                                case 5:
                                    _SE5[nRow - 1] = nType;
                                    break;
                                case 6:
                                    _SE6[nRow - 1] = nType;
                                    break;
                                case 7:
                                    _SE7[nRow - 1] = nType;
                                    break;
                                case 8:
                                    _SE8[nRow - 1] = nType;
                                    break;
                                case 9:
                                    _SE9[nRow - 1] = nType;
                                    break;
                                default:
                                    _SEa[nRow - 1] = nType;
                                    break;
                            }
                        }
                        break;
                    case 2:
                        for (int j = 1; j <= 8; j++)
                        {
                            nCol = rnd1.Next(1, 11);
                            nRow = rnd1.Next(1, 11);
                            nType = 4;
                            switch (nCol)
                            {
                                case 1:
                                    _SE1[nRow - 1] = nType;
                                    break;
                                case 2:
                                    _SE2[nRow - 1] = nType;
                                    break;
                                case 3:
                                    _SE3[nRow - 1] = nType;
                                    break;
                                case 4:
                                    _SE4[nRow - 1] = nType;
                                    break;
                                case 5:
                                    _SE5[nRow - 1] = nType;
                                    break;
                                case 6:
                                    _SE6[nRow - 1] = nType;
                                    break;
                                case 7:
                                    _SE7[nRow - 1] = nType;
                                    break;
                                case 8:
                                    _SE8[nRow - 1] = nType;
                                    break;
                                case 9:
                                    _SE9[nRow - 1] = nType;
                                    break;
                                default:
                                    _SEa[nRow - 1] = nType;
                                    break;
                            }
                        }
                        for (int j = 1; j <= 16; j++)
                        {
                            nCol = rnd1.Next(1, 11);
                            nRow = rnd1.Next(1, 11);
                            nType = 6;
                            switch (nCol)
                            {
                                case 1:
                                    _SE1[nRow - 1] = nType;
                                    break;
                                case 2:
                                    _SE2[nRow - 1] = nType;
                                    break;
                                case 3:
                                    _SE3[nRow - 1] = nType;
                                    break;
                                case 4:
                                    _SE4[nRow - 1] = nType;
                                    break;
                                case 5:
                                    _SE5[nRow - 1] = nType;
                                    break;
                                case 6:
                                    _SE6[nRow - 1] = nType;
                                    break;
                                case 7:
                                    _SE7[nRow - 1] = nType;
                                    break;
                                case 8:
                                    _SE8[nRow - 1] = nType;
                                    break;
                                case 9:
                                    _SE9[nRow - 1] = nType;
                                    break;
                                default:
                                    _SEa[nRow - 1] = nType;
                                    break;
                            }
                        }
                        break;
                    default:
                        for (int j = 1; j <= 16; j++)
                        {
                            nCol = rnd1.Next(1, 11);
                            nRow = rnd1.Next(1, 11);
                            nType = 8;
                            switch (nCol)
                            {
                                case 1:
                                    _SE1[nRow - 1] = nType;
                                    break;
                                case 2:
                                    _SE2[nRow - 1] = nType;
                                    break;
                                case 3:
                                    _SE3[nRow - 1] = nType;
                                    break;
                                case 4:
                                    _SE4[nRow - 1] = nType;
                                    break;
                                case 5:
                                    _SE5[nRow - 1] = nType;
                                    break;
                                case 6:
                                    _SE6[nRow - 1] = nType;
                                    break;
                                case 7:
                                    _SE7[nRow - 1] = nType;
                                    break;
                                case 8:
                                    _SE8[nRow - 1] = nType;
                                    break;
                                case 9:
                                    _SE9[nRow - 1] = nType;
                                    break;
                                default:
                                    _SEa[nRow - 1] = nType;
                                    break;
                            }
                        }
                        for (int j = 1; j <= 2; j++)
                        {
                            nCol = rnd1.Next(1, 11);
                            nRow = rnd1.Next(1, 11);
                            nType = 5;
                            switch (nCol)
                            {
                                case 1:
                                    _SE1[nRow - 1] = nType;
                                    break;
                                case 2:
                                    _SE2[nRow - 1] = nType;
                                    break;
                                case 3:
                                    _SE3[nRow - 1] = nType;
                                    break;
                                case 4:
                                    _SE4[nRow - 1] = nType;
                                    break;
                                case 5:
                                    _SE5[nRow - 1] = nType;
                                    break;
                                case 6:
                                    _SE6[nRow - 1] = nType;
                                    break;
                                case 7:
                                    _SE7[nRow - 1] = nType;
                                    break;
                                case 8:
                                    _SE8[nRow - 1] = nType;
                                    break;
                                case 9:
                                    _SE9[nRow - 1] = nType;
                                    break;
                                default:
                                    _SEa[nRow - 1] = nType;
                                    break;
                            }
                        }
                        break;
                }

                switch (_qtype[2])
                {
                    case 1:
                        for (int j = 1; j <= 2; j++)
                        {
                            nCol = rnd1.Next(1, 11);
                            nRow = rnd1.Next(1, 11);
                            nType = 2;
                            switch (nCol)
                            {
                                case 1:
                                    _SW1[nRow - 1] = nType;
                                    break;
                                case 2:
                                    _SW2[nRow - 1] = nType;
                                    break;
                                case 3:
                                    _SW3[nRow - 1] = nType;
                                    break;
                                case 4:
                                    _SW4[nRow - 1] = nType;
                                    break;
                                case 5:
                                    _SW5[nRow - 1] = nType;
                                    break;
                                case 6:
                                    _SW6[nRow - 1] = nType;
                                    break;
                                case 7:
                                    _SW7[nRow - 1] = nType;
                                    break;
                                case 8:
                                    _SW8[nRow - 1] = nType;
                                    break;
                                case 9:
                                    _SW9[nRow - 1] = nType;
                                    break;
                                default:
                                    _SWa[nRow - 1] = nType;
                                    break;
                            }
                        }
                        for (int j = 1; j <= 8; j++)
                        {
                            nCol = rnd1.Next(1, 11);
                            nRow = rnd1.Next(1, 11);
                            nType = 1;
                            switch (nCol)
                            {
                                case 1:
                                    _SW1[nRow - 1] = nType;
                                    break;
                                case 2:
                                    _SW2[nRow - 1] = nType;
                                    break;
                                case 3:
                                    _SW3[nRow - 1] = nType;
                                    break;
                                case 4:
                                    _SW4[nRow - 1] = nType;
                                    break;
                                case 5:
                                    _SW5[nRow - 1] = nType;
                                    break;
                                case 6:
                                    _SW6[nRow - 1] = nType;
                                    break;
                                case 7:
                                    _SW7[nRow - 1] = nType;
                                    break;
                                case 8:
                                    _SW8[nRow - 1] = nType;
                                    break;
                                case 9:
                                    _SW9[nRow - 1] = nType;
                                    break;
                                default:
                                    _SWa[nRow - 1] = nType;
                                    break;
                            }
                        }
                        break;
                    case 2:
                        for (int j = 1; j <= 8; j++)
                        {
                            nCol = rnd1.Next(1, 11);
                            nRow = rnd1.Next(1, 11);
                            nType = 4;
                            switch (nCol)
                            {
                                case 1:
                                    _SW1[nRow - 1] = nType;
                                    break;
                                case 2:
                                    _SW2[nRow - 1] = nType;
                                    break;
                                case 3:
                                    _SW3[nRow - 1] = nType;
                                    break;
                                case 4:
                                    _SW4[nRow - 1] = nType;
                                    break;
                                case 5:
                                    _SW5[nRow - 1] = nType;
                                    break;
                                case 6:
                                    _SW6[nRow - 1] = nType;
                                    break;
                                case 7:
                                    _SW7[nRow - 1] = nType;
                                    break;
                                case 8:
                                    _SW8[nRow - 1] = nType;
                                    break;
                                case 9:
                                    _SW9[nRow - 1] = nType;
                                    break;
                                default:
                                    _SWa[nRow - 1] = nType;
                                    break;
                            }
                        }
                        for (int j = 1; j <= 16; j++)
                        {
                            nCol = rnd1.Next(1, 11);
                            nRow = rnd1.Next(1, 11);
                            nType = 6;
                            switch (nCol)
                            {
                                case 1:
                                    _SW1[nRow - 1] = nType;
                                    break;
                                case 2:
                                    _SW2[nRow - 1] = nType;
                                    break;
                                case 3:
                                    _SW3[nRow - 1] = nType;
                                    break;
                                case 4:
                                    _SW4[nRow - 1] = nType;
                                    break;
                                case 5:
                                    _SW5[nRow - 1] = nType;
                                    break;
                                case 6:
                                    _SW6[nRow - 1] = nType;
                                    break;
                                case 7:
                                    _SW7[nRow - 1] = nType;
                                    break;
                                case 8:
                                    _SW8[nRow - 1] = nType;
                                    break;
                                case 9:
                                    _SW9[nRow - 1] = nType;
                                    break;
                                default:
                                    _SWa[nRow - 1] = nType;
                                    break;
                            }
                        }
                        break;
                    default:
                        for (int j = 1; j <= 16; j++)
                        {
                            nCol = rnd1.Next(1, 11);
                            nRow = rnd1.Next(1, 11);
                            nType = 8;
                            switch (nCol)
                            {
                                case 1:
                                    _SW1[nRow - 1] = nType;
                                    break;
                                case 2:
                                    _SW2[nRow - 1] = nType;
                                    break;
                                case 3:
                                    _SW3[nRow - 1] = nType;
                                    break;
                                case 4:
                                    _SW4[nRow - 1] = nType;
                                    break;
                                case 5:
                                    _SW5[nRow - 1] = nType;
                                    break;
                                case 6:
                                    _SW6[nRow - 1] = nType;
                                    break;
                                case 7:
                                    _SW7[nRow - 1] = nType;
                                    break;
                                case 8:
                                    _SW8[nRow - 1] = nType;
                                    break;
                                case 9:
                                    _SW9[nRow - 1] = nType;
                                    break;
                                default:
                                    _SWa[nRow - 1] = nType;
                                    break;
                            }
                        }
                        for (int j = 1; j <= 2; j++)
                        {
                            nCol = rnd1.Next(1, 11);
                            nRow = rnd1.Next(1, 11);
                            nType = 5;
                            switch (nCol)
                            {
                                case 1:
                                    _SW1[nRow - 1] = nType;
                                    break;
                                case 2:
                                    _SW2[nRow - 1] = nType;
                                    break;
                                case 3:
                                    _SW3[nRow - 1] = nType;
                                    break;
                                case 4:
                                    _SW4[nRow - 1] = nType;
                                    break;
                                case 5:
                                    _SW5[nRow - 1] = nType;
                                    break;
                                case 6:
                                    _SW6[nRow - 1] = nType;
                                    break;
                                case 7:
                                    _SW7[nRow - 1] = nType;
                                    break;
                                case 8:
                                    _SW8[nRow - 1] = nType;
                                    break;
                                case 9:
                                    _SW9[nRow - 1] = nType;
                                    break;
                                default:
                                    _SWa[nRow - 1] = nType;
                                    break;
                            }
                        }
                        break;
                }

                switch (_qtype[3])
                {
                    case 1:
                        for (int j = 1; j <= 2; j++)
                        {
                            nCol = rnd1.Next(1, 11);
                            nRow = rnd1.Next(1, 11);
                            nType = 2;
                            switch (nCol)
                            {
                                case 1:
                                    _NW1[nRow - 1] = nType;
                                    break;
                                case 2:
                                    _NW2[nRow - 1] = nType;
                                    break;
                                case 3:
                                    _NW3[nRow - 1] = nType;
                                    break;
                                case 4:
                                    _NW4[nRow - 1] = nType;
                                    break;
                                case 5:
                                    _NW5[nRow - 1] = nType;
                                    break;
                                case 6:
                                    _NW6[nRow - 1] = nType;
                                    break;
                                case 7:
                                    _NW7[nRow - 1] = nType;
                                    break;
                                case 8:
                                    _NW8[nRow - 1] = nType;
                                    break;
                                case 9:
                                    _NW9[nRow - 1] = nType;
                                    break;
                                default:
                                    _NWa[nRow - 1] = nType;
                                    break;
                            }
                        }
                        for (int j = 1; j <= 8; j++)
                        {
                            nCol = rnd1.Next(1, 11);
                            nRow = rnd1.Next(1, 11);
                            nType = 1;
                            switch (nCol)
                            {
                                case 1:
                                    _NW1[nRow - 1] = nType;
                                    break;
                                case 2:
                                    _NW2[nRow - 1] = nType;
                                    break;
                                case 3:
                                    _NW3[nRow - 1] = nType;
                                    break;
                                case 4:
                                    _NW4[nRow - 1] = nType;
                                    break;
                                case 5:
                                    _NW5[nRow - 1] = nType;
                                    break;
                                case 6:
                                    _NW6[nRow - 1] = nType;
                                    break;
                                case 7:
                                    _NW7[nRow - 1] = nType;
                                    break;
                                case 8:
                                    _NW8[nRow - 1] = nType;
                                    break;
                                case 9:
                                    _NW9[nRow - 1] = nType;
                                    break;
                                default:
                                    _NWa[nRow - 1] = nType;
                                    break;
                            }
                        }
                        break;
                    case 2:
                        for (int j = 1; j <= 8; j++)
                        {
                            nCol = rnd1.Next(1, 11);
                            nRow = rnd1.Next(1, 11);
                            nType = 4;
                            switch (nCol)
                            {
                                case 1:
                                    _NW1[nRow - 1] = nType;
                                    break;
                                case 2:
                                    _NW2[nRow - 1] = nType;
                                    break;
                                case 3:
                                    _NW3[nRow - 1] = nType;
                                    break;
                                case 4:
                                    _NW4[nRow - 1] = nType;
                                    break;
                                case 5:
                                    _NW5[nRow - 1] = nType;
                                    break;
                                case 6:
                                    _NW6[nRow - 1] = nType;
                                    break;
                                case 7:
                                    _NW7[nRow - 1] = nType;
                                    break;
                                case 8:
                                    _NW8[nRow - 1] = nType;
                                    break;
                                case 9:
                                    _NW9[nRow - 1] = nType;
                                    break;
                                default:
                                    _NWa[nRow - 1] = nType;
                                    break;
                            }
                        }
                        for (int j = 1; j <= 16; j++)
                        {
                            nCol = rnd1.Next(1, 11);
                            nRow = rnd1.Next(1, 11);
                            nType = 6;
                            switch (nCol)
                            {
                                case 1:
                                    _NW1[nRow - 1] = nType;
                                    break;
                                case 2:
                                    _NW2[nRow - 1] = nType;
                                    break;
                                case 3:
                                    _NW3[nRow - 1] = nType;
                                    break;
                                case 4:
                                    _NW4[nRow - 1] = nType;
                                    break;
                                case 5:
                                    _NW5[nRow - 1] = nType;
                                    break;
                                case 6:
                                    _NW6[nRow - 1] = nType;
                                    break;
                                case 7:
                                    _NW7[nRow - 1] = nType;
                                    break;
                                case 8:
                                    _NW8[nRow - 1] = nType;
                                    break;
                                case 9:
                                    _NW9[nRow - 1] = nType;
                                    break;
                                default:
                                    _NWa[nRow - 1] = nType;
                                    break;
                            }
                        }
                        break;
                    default:
                        for (int j = 1; j <= 16; j++)
                        {
                            nCol = rnd1.Next(1, 11);
                            nRow = rnd1.Next(1, 11);
                            nType = 8;
                            switch (nCol)
                            {
                                case 1:
                                    _NW1[nRow - 1] = nType;
                                    break;
                                case 2:
                                    _NW2[nRow - 1] = nType;
                                    break;
                                case 3:
                                    _NW3[nRow - 1] = nType;
                                    break;
                                case 4:
                                    _NW4[nRow - 1] = nType;
                                    break;
                                case 5:
                                    _NW5[nRow - 1] = nType;
                                    break;
                                case 6:
                                    _NW6[nRow - 1] = nType;
                                    break;
                                case 7:
                                    _NW7[nRow - 1] = nType;
                                    break;
                                case 8:
                                    _NW8[nRow - 1] = nType;
                                    break;
                                case 9:
                                    _NW9[nRow - 1] = nType;
                                    break;
                                default:
                                    _NWa[nRow - 1] = nType;
                                    break;
                            }
                        }
                        for (int j = 1; j <= 2; j++)
                        {
                            nCol = rnd1.Next(1, 11);
                            nRow = rnd1.Next(1, 11);
                            nType = 5;
                            switch (nCol)
                            {
                                case 1:
                                    _NW1[nRow - 1] = nType;
                                    break;
                                case 2:
                                    _NW2[nRow - 1] = nType;
                                    break;
                                case 3:
                                    _NW3[nRow - 1] = nType;
                                    break;
                                case 4:
                                    _NW4[nRow - 1] = nType;
                                    break;
                                case 5:
                                    _NW5[nRow - 1] = nType;
                                    break;
                                case 6:
                                    _NW6[nRow - 1] = nType;
                                    break;
                                case 7:
                                    _NW7[nRow - 1] = nType;
                                    break;
                                case 8:
                                    _NW8[nRow - 1] = nType;
                                    break;
                                case 9:
                                    _NW9[nRow - 1] = nType;
                                    break;
                                default:
                                    _NWa[nRow - 1] = nType;
                                    break;
                            }
                        }
                        break;
                }

                fSetExit();
                CounterCol = rnd1.Next(1, 11);
                CounterRow = rnd1.Next(1, 11);
                CounterDirection = rnd1.Next(1, 5);
                fSyncCounter();
                fUpdateDisplay();

            }

        }

            public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nCol, nRow, nType=0;

            for (int i = 1; i <= 4; i++)
            {
                _qtype[i - 1] = rnd1.Next(1, 4);
            }
            for (int i = 1; i <= 10; i++)
            {
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NE1[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NE2[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NE3[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NE4[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NE5[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NE6[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NE7[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NE8[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NE9[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NEa[i - 1] = nType;


                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SE1[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SE2[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SE3[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SE4[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SE5[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SE6[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SE7[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SE8[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SE9[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SEa[i - 1] = nType;

                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SW1[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SW2[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SW3[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SW4[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SW5[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SW6[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SW7[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SW8[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SW9[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _SWa[i - 1] = nType;


                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NW1[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NW2[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NW3[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NW4[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NW5[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NW6[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NW7[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NW8[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NW9[i - 1] = nType;
                nType = rnd1.Next(1, 10);
                if (nType <= 5)
                {
                    nType = 9;
                }
                else
                {
                    nType = 10;
                }
                _NWa[i - 1] = nType;
            }

            switch (_qtype[0])
            {
                case 1:
                    for (int j = 1; j <= 2; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 2;
                        switch (nCol)
                        {
                            case 1:
                                _NE1[nRow - 1] = nType;
                                break;
                            case 2:
                                _NE2[nRow - 1] = nType;
                                break;
                            case 3:
                                _NE3[nRow - 1] = nType;
                                break;
                            case 4:
                                _NE4[nRow - 1] = nType;
                                break;
                            case 5:
                                _NE5[nRow - 1] = nType;
                                break;
                            case 6:
                                _NE6[nRow - 1] = nType;
                                break;
                            case 7:
                                _NE7[nRow - 1] = nType;
                                break;
                            case 8:
                                _NE8[nRow - 1] = nType;
                                break;
                            case 9:
                                _NE9[nRow - 1] = nType;
                                break;
                            default:
                                _NEa[nRow - 1] = nType;
                                break;
                        }
                    }
                    for (int j = 1; j <= 8; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 1;
                        switch (nCol)
                        {
                            case 1:
                                _NE1[nRow - 1] = nType;
                                break;
                            case 2:
                                _NE2[nRow - 1] = nType;
                                break;
                            case 3:
                                _NE3[nRow - 1] = nType;
                                break;
                            case 4:
                                _NE4[nRow - 1] = nType;
                                break;
                            case 5:
                                _NE5[nRow - 1] = nType;
                                break;
                            case 6:
                                _NE6[nRow - 1] = nType;
                                break;
                            case 7:
                                _NE7[nRow - 1] = nType;
                                break;
                            case 8:
                                _NE8[nRow - 1] = nType;
                                break;
                            case 9:
                                _NE9[nRow - 1] = nType;
                                break;
                            default:
                                _NEa[nRow - 1] = nType;
                                break;
                        }
                    }
                    break;
                case 2:
                    for (int j = 1; j <= 8; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 4;
                        switch (nCol)
                        {
                            case 1:
                                _NE1[nRow - 1] = nType;
                                break;
                            case 2:
                                _NE2[nRow - 1] = nType;
                                break;
                            case 3:
                                _NE3[nRow - 1] = nType;
                                break;
                            case 4:
                                _NE4[nRow - 1] = nType;
                                break;
                            case 5:
                                _NE5[nRow - 1] = nType;
                                break;
                            case 6:
                                _NE6[nRow - 1] = nType;
                                break;
                            case 7:
                                _NE7[nRow - 1] = nType;
                                break;
                            case 8:
                                _NE8[nRow - 1] = nType;
                                break;
                            case 9:
                                _NE9[nRow - 1] = nType;
                                break;
                            default:
                                _NEa[nRow - 1] = nType;
                                break;
                        }
                    }
                    for (int j = 1; j <= 16; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 6;
                        switch (nCol)
                        {
                            case 1:
                                _NE1[nRow - 1] = nType;
                                break;
                            case 2:
                                _NE2[nRow - 1] = nType;
                                break;
                            case 3:
                                _NE3[nRow - 1] = nType;
                                break;
                            case 4:
                                _NE4[nRow - 1] = nType;
                                break;
                            case 5:
                                _NE5[nRow - 1] = nType;
                                break;
                            case 6:
                                _NE6[nRow - 1] = nType;
                                break;
                            case 7:
                                _NE7[nRow - 1] = nType;
                                break;
                            case 8:
                                _NE8[nRow - 1] = nType;
                                break;
                            case 9:
                                _NE9[nRow - 1] = nType;
                                break;
                            default:
                                _NEa[nRow - 1] = nType;
                                break;
                        }
                    }
                    break;
                default:
                    for (int j = 1; j <= 16; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType =8;
                        switch (nCol)
                        {
                            case 1:
                                _NE1[nRow - 1] = nType;
                                break;
                            case 2:
                                _NE2[nRow - 1] = nType;
                                break;
                            case 3:
                                _NE3[nRow - 1] = nType;
                                break;
                            case 4:
                                _NE4[nRow - 1] = nType;
                                break;
                            case 5:
                                _NE5[nRow - 1] = nType;
                                break;
                            case 6:
                                _NE6[nRow - 1] = nType;
                                break;
                            case 7:
                                _NE7[nRow - 1] = nType;
                                break;
                            case 8:
                                _NE8[nRow - 1] = nType;
                                break;
                            case 9:
                                _NE9[nRow - 1] = nType;
                                break;
                            default:
                                _NEa[nRow - 1] = nType;
                                break;
                        }
                    }
                    for (int j = 1; j <= 2; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 5;
                        switch (nCol)
                        {
                            case 1:
                                _NE1[nRow - 1] = nType;
                                break;
                            case 2:
                                _NE2[nRow - 1] = nType;
                                break;
                            case 3:
                                _NE3[nRow - 1] = nType;
                                break;
                            case 4:
                                _NE4[nRow - 1] = nType;
                                break;
                            case 5:
                                _NE5[nRow - 1] = nType;
                                break;
                            case 6:
                                _NE6[nRow - 1] = nType;
                                break;
                            case 7:
                                _NE7[nRow - 1] = nType;
                                break;
                            case 8:
                                _NE8[nRow - 1] = nType;
                                break;
                            case 9:
                                _NE9[nRow - 1] = nType;
                                break;
                            default:
                                _NEa[nRow - 1] = nType;
                                break;
                        }
                    }
                    break;
            }
            switch (_qtype[1])
            {
                case 1:
                    for (int j = 1; j <= 2; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 2;
                        switch (nCol)
                        {
                            case 1:
                                _SE1[nRow - 1] = nType;
                                break;
                            case 2:
                                _SE2[nRow - 1] = nType;
                                break;
                            case 3:
                                _SE3[nRow - 1] = nType;
                                break;
                            case 4:
                                _SE4[nRow - 1] = nType;
                                break;
                            case 5:
                                _SE5[nRow - 1] = nType;
                                break;
                            case 6:
                                _SE6[nRow - 1] = nType;
                                break;
                            case 7:
                                _SE7[nRow - 1] = nType;
                                break;
                            case 8:
                                _SE8[nRow - 1] = nType;
                                break;
                            case 9:
                                _SE9[nRow - 1] = nType;
                                break;
                            default:
                                _SEa[nRow - 1] = nType;
                                break;
                        }
                    }
                    for (int j = 1; j <= 8; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 1;
                        switch (nCol)
                        {
                            case 1:
                                _SE1[nRow - 1] = nType;
                                break;
                            case 2:
                                _SE2[nRow - 1] = nType;
                                break;
                            case 3:
                                _SE3[nRow - 1] = nType;
                                break;
                            case 4:
                                _SE4[nRow - 1] = nType;
                                break;
                            case 5:
                                _SE5[nRow - 1] = nType;
                                break;
                            case 6:
                                _SE6[nRow - 1] = nType;
                                break;
                            case 7:
                                _SE7[nRow - 1] = nType;
                                break;
                            case 8:
                                _SE8[nRow - 1] = nType;
                                break;
                            case 9:
                                _SE9[nRow - 1] = nType;
                                break;
                            default:
                                _SEa[nRow - 1] = nType;
                                break;
                        }
                    }
                    break;
                case 2:
                    for (int j = 1; j <= 8; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 4;
                        switch (nCol)
                        {
                            case 1:
                                _SE1[nRow - 1] = nType;
                                break;
                            case 2:
                                _SE2[nRow - 1] = nType;
                                break;
                            case 3:
                                _SE3[nRow - 1] = nType;
                                break;
                            case 4:
                                _SE4[nRow - 1] = nType;
                                break;
                            case 5:
                                _SE5[nRow - 1] = nType;
                                break;
                            case 6:
                                _SE6[nRow - 1] = nType;
                                break;
                            case 7:
                                _SE7[nRow - 1] = nType;
                                break;
                            case 8:
                                _SE8[nRow - 1] = nType;
                                break;
                            case 9:
                                _SE9[nRow - 1] = nType;
                                break;
                            default:
                                _SEa[nRow - 1] = nType;
                                break;
                        }
                    }
                    for (int j = 1; j <= 16; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 6;
                        switch (nCol)
                        {
                            case 1:
                                _SE1[nRow - 1] = nType;
                                break;
                            case 2:
                                _SE2[nRow - 1] = nType;
                                break;
                            case 3:
                                _SE3[nRow - 1] = nType;
                                break;
                            case 4:
                                _SE4[nRow - 1] = nType;
                                break;
                            case 5:
                                _SE5[nRow - 1] = nType;
                                break;
                            case 6:
                                _SE6[nRow - 1] = nType;
                                break;
                            case 7:
                                _SE7[nRow - 1] = nType;
                                break;
                            case 8:
                                _SE8[nRow - 1] = nType;
                                break;
                            case 9:
                                _SE9[nRow - 1] = nType;
                                break;
                            default:
                                _SEa[nRow - 1] = nType;
                                break;
                        }
                    }
                    break;
                default:
                    for (int j = 1; j <= 16; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 8;
                        switch (nCol)
                        {
                            case 1:
                                _SE1[nRow - 1] = nType;
                                break;
                            case 2:
                                _SE2[nRow - 1] = nType;
                                break;
                            case 3:
                                _SE3[nRow - 1] = nType;
                                break;
                            case 4:
                                _SE4[nRow - 1] = nType;
                                break;
                            case 5:
                                _SE5[nRow - 1] = nType;
                                break;
                            case 6:
                                _SE6[nRow - 1] = nType;
                                break;
                            case 7:
                                _SE7[nRow - 1] = nType;
                                break;
                            case 8:
                                _SE8[nRow - 1] = nType;
                                break;
                            case 9:
                                _SE9[nRow - 1] = nType;
                                break;
                            default:
                                _SEa[nRow - 1] = nType;
                                break;
                        }
                    }
                    for (int j = 1; j <= 2; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 5;
                        switch (nCol)
                        {
                            case 1:
                                _SE1[nRow - 1] = nType;
                                break;
                            case 2:
                                _SE2[nRow - 1] = nType;
                                break;
                            case 3:
                                _SE3[nRow - 1] = nType;
                                break;
                            case 4:
                                _SE4[nRow - 1] = nType;
                                break;
                            case 5:
                                _SE5[nRow - 1] = nType;
                                break;
                            case 6:
                                _SE6[nRow - 1] = nType;
                                break;
                            case 7:
                                _SE7[nRow - 1] = nType;
                                break;
                            case 8:
                                _SE8[nRow - 1] = nType;
                                break;
                            case 9:
                                _SE9[nRow - 1] = nType;
                                break;
                            default:
                                _SEa[nRow - 1] = nType;
                                break;
                        }
                    }
                    break;
            }

            switch (_qtype[2])
            {
                case 1:
                    for (int j = 1; j <= 2; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 2;
                        switch (nCol)
                        {
                            case 1:
                                _SW1[nRow - 1] = nType;
                                break;
                            case 2:
                                _SW2[nRow - 1] = nType;
                                break;
                            case 3:
                                _SW3[nRow - 1] = nType;
                                break;
                            case 4:
                                _SW4[nRow - 1] = nType;
                                break;
                            case 5:
                                _SW5[nRow - 1] = nType;
                                break;
                            case 6:
                                _SW6[nRow - 1] = nType;
                                break;
                            case 7:
                                _SW7[nRow - 1] = nType;
                                break;
                            case 8:
                                _SW8[nRow - 1] = nType;
                                break;
                            case 9:
                                _SW9[nRow - 1] = nType;
                                break;
                            default:
                                _SWa[nRow - 1] = nType;
                                break;
                        }
                    }
                    for (int j = 1; j <= 8; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 1;
                        switch (nCol)
                        {
                            case 1:
                                _SW1[nRow - 1] = nType;
                                break;
                            case 2:
                                _SW2[nRow - 1] = nType;
                                break;
                            case 3:
                                _SW3[nRow - 1] = nType;
                                break;
                            case 4:
                                _SW4[nRow - 1] = nType;
                                break;
                            case 5:
                                _SW5[nRow - 1] = nType;
                                break;
                            case 6:
                                _SW6[nRow - 1] = nType;
                                break;
                            case 7:
                                _SW7[nRow - 1] = nType;
                                break;
                            case 8:
                                _SW8[nRow - 1] = nType;
                                break;
                            case 9:
                                _SW9[nRow - 1] = nType;
                                break;
                            default:
                                _SWa[nRow - 1] = nType;
                                break;
                        }
                    }
                    break;
                case 2:
                    for (int j = 1; j <= 8; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 4;
                        switch (nCol)
                        {
                            case 1:
                                _SW1[nRow - 1] = nType;
                                break;
                            case 2:
                                _SW2[nRow - 1] = nType;
                                break;
                            case 3:
                                _SW3[nRow - 1] = nType;
                                break;
                            case 4:
                                _SW4[nRow - 1] = nType;
                                break;
                            case 5:
                                _SW5[nRow - 1] = nType;
                                break;
                            case 6:
                                _SW6[nRow - 1] = nType;
                                break;
                            case 7:
                                _SW7[nRow - 1] = nType;
                                break;
                            case 8:
                                _SW8[nRow - 1] = nType;
                                break;
                            case 9:
                                _SW9[nRow - 1] = nType;
                                break;
                            default:
                                _SWa[nRow - 1] = nType;
                                break;
                        }
                    }
                    for (int j = 1; j <= 16; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 6;
                        switch (nCol)
                        {
                            case 1:
                                _SW1[nRow - 1] = nType;
                                break;
                            case 2:
                                _SW2[nRow - 1] = nType;
                                break;
                            case 3:
                                _SW3[nRow - 1] = nType;
                                break;
                            case 4:
                                _SW4[nRow - 1] = nType;
                                break;
                            case 5:
                                _SW5[nRow - 1] = nType;
                                break;
                            case 6:
                                _SW6[nRow - 1] = nType;
                                break;
                            case 7:
                                _SW7[nRow - 1] = nType;
                                break;
                            case 8:
                                _SW8[nRow - 1] = nType;
                                break;
                            case 9:
                                _SW9[nRow - 1] = nType;
                                break;
                            default:
                                _SWa[nRow - 1] = nType;
                                break;
                        }
                    }
                    break;
                default:
                    for (int j = 1; j <= 16; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 8;
                        switch (nCol)
                        {
                            case 1:
                                _SW1[nRow - 1] = nType;
                                break;
                            case 2:
                                _SW2[nRow - 1] = nType;
                                break;
                            case 3:
                                _SW3[nRow - 1] = nType;
                                break;
                            case 4:
                                _SW4[nRow - 1] = nType;
                                break;
                            case 5:
                                _SW5[nRow - 1] = nType;
                                break;
                            case 6:
                                _SW6[nRow - 1] = nType;
                                break;
                            case 7:
                                _SW7[nRow - 1] = nType;
                                break;
                            case 8:
                                _SW8[nRow - 1] = nType;
                                break;
                            case 9:
                                _SW9[nRow - 1] = nType;
                                break;
                            default:
                                _SWa[nRow - 1] = nType;
                                break;
                        }
                    }
                    for (int j = 1; j <= 2; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 5;
                        switch (nCol)
                        {
                            case 1:
                                _SW1[nRow - 1] = nType;
                                break;
                            case 2:
                                _SW2[nRow - 1] = nType;
                                break;
                            case 3:
                                _SW3[nRow - 1] = nType;
                                break;
                            case 4:
                                _SW4[nRow - 1] = nType;
                                break;
                            case 5:
                                _SW5[nRow - 1] = nType;
                                break;
                            case 6:
                                _SW6[nRow - 1] = nType;
                                break;
                            case 7:
                                _SW7[nRow - 1] = nType;
                                break;
                            case 8:
                                _SW8[nRow - 1] = nType;
                                break;
                            case 9:
                                _SW9[nRow - 1] = nType;
                                break;
                            default:
                                _SWa[nRow - 1] = nType;
                                break;
                        }
                    }
                    break;
            }

            switch (_qtype[3])
            {
                case 1:
                    for (int j = 1; j <= 2; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 2;
                        switch (nCol)
                        {
                            case 1:
                                _NW1[nRow - 1] = nType;
                                break;
                            case 2:
                                _NW2[nRow - 1] = nType;
                                break;
                            case 3:
                                _NW3[nRow - 1] = nType;
                                break;
                            case 4:
                                _NW4[nRow - 1] = nType;
                                break;
                            case 5:
                                _NW5[nRow - 1] = nType;
                                break;
                            case 6:
                                _NW6[nRow - 1] = nType;
                                break;
                            case 7:
                                _NW7[nRow - 1] = nType;
                                break;
                            case 8:
                                _NW8[nRow - 1] = nType;
                                break;
                            case 9:
                                _NW9[nRow - 1] = nType;
                                break;
                            default:
                                _NWa[nRow - 1] = nType;
                                break;
                        }
                    }
                    for (int j = 1; j <= 8; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 1;
                        switch (nCol)
                        {
                            case 1:
                                _NW1[nRow - 1] = nType;
                                break;
                            case 2:
                                _NW2[nRow - 1] = nType;
                                break;
                            case 3:
                                _NW3[nRow - 1] = nType;
                                break;
                            case 4:
                                _NW4[nRow - 1] = nType;
                                break;
                            case 5:
                                _NW5[nRow - 1] = nType;
                                break;
                            case 6:
                                _NW6[nRow - 1] = nType;
                                break;
                            case 7:
                                _NW7[nRow - 1] = nType;
                                break;
                            case 8:
                                _NW8[nRow - 1] = nType;
                                break;
                            case 9:
                                _NW9[nRow - 1] = nType;
                                break;
                            default:
                                _NWa[nRow - 1] = nType;
                                break;
                        }
                    }
                    break;
                case 2:
                    for (int j = 1; j <= 8; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 4;
                        switch (nCol)
                        {
                            case 1:
                                _NW1[nRow - 1] = nType;
                                break;
                            case 2:
                                _NW2[nRow - 1] = nType;
                                break;
                            case 3:
                                _NW3[nRow - 1] = nType;
                                break;
                            case 4:
                                _NW4[nRow - 1] = nType;
                                break;
                            case 5:
                                _NW5[nRow - 1] = nType;
                                break;
                            case 6:
                                _NW6[nRow - 1] = nType;
                                break;
                            case 7:
                                _NW7[nRow - 1] = nType;
                                break;
                            case 8:
                                _NW8[nRow - 1] = nType;
                                break;
                            case 9:
                                _NW9[nRow - 1] = nType;
                                break;
                            default:
                                _NWa[nRow - 1] = nType;
                                break;
                        }
                    }
                    for (int j = 1; j <= 16; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 6;
                        switch (nCol)
                        {
                            case 1:
                                _NW1[nRow - 1] = nType;
                                break;
                            case 2:
                                _NW2[nRow - 1] = nType;
                                break;
                            case 3:
                                _NW3[nRow - 1] = nType;
                                break;
                            case 4:
                                _NW4[nRow - 1] = nType;
                                break;
                            case 5:
                                _NW5[nRow - 1] = nType;
                                break;
                            case 6:
                                _NW6[nRow - 1] = nType;
                                break;
                            case 7:
                                _NW7[nRow - 1] = nType;
                                break;
                            case 8:
                                _NW8[nRow - 1] = nType;
                                break;
                            case 9:
                                _NW9[nRow - 1] = nType;
                                break;
                            default:
                                _NWa[nRow - 1] = nType;
                                break;
                        }
                    }
                    break;
                default:
                    for (int j = 1; j <= 16; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 8;
                        switch (nCol)
                        {
                            case 1:
                                _NW1[nRow - 1] = nType;
                                break;
                            case 2:
                                _NW2[nRow - 1] = nType;
                                break;
                            case 3:
                                _NW3[nRow - 1] = nType;
                                break;
                            case 4:
                                _NW4[nRow - 1] = nType;
                                break;
                            case 5:
                                _NW5[nRow - 1] = nType;
                                break;
                            case 6:
                                _NW6[nRow - 1] = nType;
                                break;
                            case 7:
                                _NW7[nRow - 1] = nType;
                                break;
                            case 8:
                                _NW8[nRow - 1] = nType;
                                break;
                            case 9:
                                _NW9[nRow - 1] = nType;
                                break;
                            default:
                                _NWa[nRow - 1] = nType;
                                break;
                        }
                    }
                    for (int j = 1; j <= 2; j++)
                    {
                        nCol = rnd1.Next(1, 11);
                        nRow = rnd1.Next(1, 11);
                        nType = 5;
                        switch (nCol)
                        {
                            case 1:
                                _NW1[nRow - 1] = nType;
                                break;
                            case 2:
                                _NW2[nRow - 1] = nType;
                                break;
                            case 3:
                                _NW3[nRow - 1] = nType;
                                break;
                            case 4:
                                _NW4[nRow - 1] = nType;
                                break;
                            case 5:
                                _NW5[nRow - 1] = nType;
                                break;
                            case 6:
                                _NW6[nRow - 1] = nType;
                                break;
                            case 7:
                                _NW7[nRow - 1] = nType;
                                break;
                            case 8:
                                _NW8[nRow - 1] = nType;
                                break;
                            case 9:
                                _NW9[nRow - 1] = nType;
                                break;
                            default:
                                _NWa[nRow - 1] = nType;
                                break;
                        }
                    }
                    break;
            }

            fSetExit();
            CounterCol = rnd1.Next(1, 11);
            CounterRow = rnd1.Next(1, 11);
            CounterDirection = rnd1.Next(1, 5);
            fSyncCounter();
            fUpdateDisplay();       
        }

    }


}


