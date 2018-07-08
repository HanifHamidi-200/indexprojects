using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmicRaysIncoming
{
    public partial class Form1 : Form
    {
        private static List<int> _col1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col5 =new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };

        private static List<int> _rotate1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _rotate2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _rotate3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _rotate4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _rotate5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _rotate6 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _rotate7 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _rotate8 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };


        private void fStick(int nCol,int nRow,int nType)
        {
            Random rnd1 = new Random();

            switch (nCol)
            {
                case 1:
                    _col1[nRow - 1] = nType;
                    _rotate1[nRow - 1] = rnd1.Next(1, 5);
                    break;
                case 2:
                    _col2[nRow - 1] = nType;
                    _rotate2[nRow - 1] = rnd1.Next(1, 5);
                    break;
                case 3:
                    _col3[nRow - 1] = nType;
                    _rotate3[nRow - 1] = rnd1.Next(1, 5);
                    break;
                case 4:
                    _col4[nRow - 1] = nType;
                    _rotate4[nRow - 1] = rnd1.Next(1, 5);
                    break;
                case 5:
                    _col5[nRow - 1] = nType;
                    _rotate5[nRow - 1] = rnd1.Next(1, 5);
                    break;
                case 6:
                    _col6[nRow - 1] = nType;
                    _rotate6[nRow - 1] = rnd1.Next(1, 5);
                    break;
                case 7:
                    _col7[nRow - 1] = nType;
                    _rotate7[nRow - 1] = rnd1.Next(1, 5);
                    break;
                default:
                    _col8[nRow - 1] = nType;
                    _rotate8[nRow - 1] = rnd1.Next(1, 5);
                    break;
            }
        }
        private void fReposition()
        {
            Random rnd1 = new Random();
            int nTries = rnd1.Next(5, 13);
            int nMode;

            for(int i = 1; i <= 8; i++)
            {
                _col1[i - 1] = 6;
                _col2[i - 1] = 6;
                _col3[i - 1] = 6;
                _col4[i - 1] = 6;
                _col5[i - 1] = 6;
                _col6[i - 1] = 6;
                _col7[i - 1] = 6;
                _col8[i - 1] = 6;
                _rotate1[i - 1] = 1;
                _rotate2[i - 1] = 1;
                _rotate3[i - 1] = 1;
                _rotate4[i - 1] = 1;
                _rotate5[i - 1] = 1;
                _rotate6[i - 1] = 1;
                _rotate7[i - 1] = 1;
                _rotate8[i - 1] = 1;
            }

            int nStart,nDirection,nCount;
            int nCol, nRow, nType;
            bool bFound = false;

            for (int i = 1; i <= nTries; i++)
            {
                nMode = rnd1.Next(1, 6);
                switch (nMode)
                {
                    case 1:
                        nStart = rnd1.Next(1, 5);
                        switch (nStart)
                        {
                            case 1:
                                nCol = rnd1.Next(1, 9);
                                nRow = 1;
                                nType = 1;
                                break;
                            default:
                                nCol = 1;
                                nRow = rnd1.Next(1, 9);
                                nType = 1;
                                break;
                        }
                        fStick(nCol, nRow, nType);
                        do
                        {
                            nCol += 1;
                            nRow += 1;
                            if (nCol == 9)
                            {
                                bFound = true;
                            }
                            if (nRow == 9)
                            {
                                bFound = true;
                            }
                            if (bFound == false)
                            {
                                fStick(nCol, nRow, nType);
                            }
                        } while (bFound == false);
                        break;
                    case 2:
                        nCol = rnd1.Next(1, 9);
                        nRow = rnd1.Next(1, 9);
                        nType = 2;
                        fStick(nCol, nRow, nType);
                        nDirection = rnd1.Next(1, 5);
                        bFound = false;
                        do
                        {
                            switch (nDirection)
                            {
                                case 1:
                                    nCol = nCol - 1;
                                    break;
                                case 2:
                                    nRow = nRow + 1;
                                    break;
                                case 3:
                                    nCol = nCol + 1;
                                    break;
                                case 4:
                                    nRow = nRow - 1;
                                    break;
                            }
                            if (nCol == 9)
                            {
                                bFound = true;
                            }
                            if (nRow == 9)
                            {
                                bFound = true;
                            }
                            if (nCol == 0)
                            {
                                bFound = true;
                            }
                            if (nRow == 0)
                            {
                                bFound = true;
                            }
                            if (bFound == false)
                            {
                                fStick(nCol, nRow, nType);
                            }
                        } while (bFound == false);
                        nDirection += 1;
                        if (nDirection == 5)
                        {
                            nDirection = 1;
                        }
                        bFound = false;
                        do
                        {
                            switch (nDirection)
                            {
                                case 1:
                                    nCol = nCol - 1;
                                    break;
                                case 2:
                                    nRow = nRow + 1;
                                    break;
                                case 3:
                                    nCol = nCol + 1;
                                    break;
                                case 4:
                                    nRow = nRow - 1;
                                    break;
                            }
                            if (nCol == 9)
                            {
                                bFound = true;
                            }
                            if (nRow == 9)
                            {
                                bFound = true;
                            }
                            if (nCol == 0)
                            {
                                bFound = true;
                            }
                            if (nRow == 0)
                            {
                                bFound = true;
                            }
                            if (bFound == false)
                            {
                                fStick(nCol, nRow, nType);
                            }
                        } while (bFound == false);
                
                        break;
                    case 3:
                        nCount = rnd1.Next(1, 5);
                        for (int j = 1; j <= nCount; j++)
                        {
                            nCol = rnd1.Next(1, 9);
                            nRow = rnd1.Next(1, 9);
                            nType = 3;
                            fStick(nCol, nRow, nType);
                        }
                        break;
                    case 4:
                        nStart = rnd1.Next(1, 5);
                        switch (nStart)
                        {
                            case 1:
                                nCol = 1;
                                nRow = 1;
                                nType = 4;
                                break;
                            case 2:
                                nCol = 8;
                                nRow = 1;
                                nType = 4;
                                break;
                            case 3:
                                nCol = 8;
                                nRow = 8;
                                nType = 4;
                                break;
                            default:
                                nCol = 1;
                                nRow = 8;
                                nType = 4;
                                break;

                        }
                        fStick(nCol, nRow, nType);
                        break;
                    default:
                        nCol = rnd1.Next(1, 9);
                        nRow = rnd1.Next(1, 9);
                        nType = 5;
                        bFound = false;
                        fStick(nCol, nRow, nType);
                        nTries = rnd1.Next(2, 9);
                        for (int j = 1; j <= nTries; j++)
                        {
                            nDirection = rnd1.Next(1, 5);
                            switch (nDirection)
                            {
                                case 1:
                                    nRow -= 1;
                                    break;
                                case 2:
                                    nCol += 1;
                                    break;
                                case 3:
                                    nRow += 1;
                                    break;
                                default:
                                    nCol -= 1;
                                    break;

                            }
                            if (nRow == 9)
                            {
                                bFound = true;
                            }
                            if (nRow == 0)
                            {
                                bFound = true;
                            }
                            if (nCol == 9)
                            {
                                bFound = true;
                            }
                            if (nCol == 0)
                            {
                                bFound = true;
                            }
                            if (bFound == false)
                            {
                                fStick(nCol, nRow, nType);

                            }
                            else
                            {
                                j = nTries + 1;
                            }
                        }
                        break;
                }
            }
        }

        private void fUpdateDisplay()
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dellend.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F devrent.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F ecute.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F factored.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F followup.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F NightSky.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
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
                default:
                    pic11.Image = picture7.Image;
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
                default:
                    pic12.Image = picture7.Image;
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
                default:
                    pic13.Image = picture7.Image;
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
                default:
                    pic14.Image = picture7.Image;
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
                default:
                    pic15.Image = picture7.Image;
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
                default:
                    pic16.Image = picture7.Image;
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
                default:
                    pic17.Image = picture7.Image;
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
                default:
                    pic18.Image = picture7.Image;
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
                default:
                    pic21.Image = picture7.Image;
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
                default:
                    pic22.Image = picture7.Image;
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
                default:
                    pic23.Image = picture7.Image;
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
                default:
                    pic24.Image = picture7.Image;
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
                default:
                    pic25.Image = picture7.Image;
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
                default:
                    pic26.Image = picture7.Image;
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
                default:
                    pic27.Image = picture7.Image;
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
                default:
                    pic28.Image = picture7.Image;
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
                default:
                    pic31.Image = picture7.Image;
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
                default:
                    pic32.Image = picture7.Image;
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
                default:
                    pic33.Image = picture7.Image;
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
                default:
                    pic34.Image = picture7.Image;
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
                default:
                    pic35.Image = picture7.Image;
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
                default:
                    pic36.Image = picture7.Image;
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
                default:
                    pic37.Image = picture7.Image;
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
                default:
                    pic38.Image = picture7.Image;
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
                default:
                    pic41.Image = picture7.Image;
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
                default:
                    pic42.Image = picture7.Image;
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
                default:
                    pic43.Image = picture7.Image;
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
                default:
                    pic44.Image = picture7.Image;
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
                default:
                    pic45.Image = picture7.Image;
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
                default:
                    pic46.Image = picture7.Image;
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
                default:
                    pic47.Image = picture7.Image;
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
                default:
                    pic48.Image = picture7.Image;
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
                default:
                    pic51.Image = picture7.Image;
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
                default:
                    pic52.Image = picture7.Image;
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
                default:
                    pic53.Image = picture7.Image;
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
                default:
                    pic54.Image = picture7.Image;
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
                default:
                    pic55.Image = picture7.Image;
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
                default:
                    pic56.Image = picture7.Image;
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
                default:
                    pic57.Image = picture7.Image;
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
                default:
                    pic58.Image = picture7.Image;
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
                default:
                    pic61.Image = picture7.Image;
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
                default:
                    pic62.Image = picture7.Image;
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
                default:
                    pic63.Image = picture7.Image;
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
                default:
                    pic64.Image = picture7.Image;
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
                default:
                    pic65.Image = picture7.Image;
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
                default:
                    pic66.Image = picture7.Image;
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
                default:
                    pic67.Image = picture7.Image;
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
                default:
                    pic68.Image = picture7.Image;
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
                default:
                    pic71.Image = picture7.Image;
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
                default:
                    pic72.Image = picture7.Image;
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
                default:
                    pic73.Image = picture7.Image;
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
                default:
                    pic74.Image = picture7.Image;
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
                default:
                    pic75.Image = picture7.Image;
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
                default:
                    pic76.Image = picture7.Image;
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
                default:
                    pic77.Image = picture7.Image;
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
                default:
                    pic78.Image = picture7.Image;
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
                default:
                    pic81.Image = picture7.Image;
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
                default:
                    pic82.Image = picture7.Image;
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
                default:
                    pic83.Image = picture7.Image;
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
                default:
                    pic84.Image = picture7.Image;
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
                default:
                    pic85.Image = picture7.Image;
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
                default:
                    pic86.Image = picture7.Image;
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
                default:
                    pic87.Image = picture7.Image;
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
                default:
                    pic88.Image = picture7.Image;
                    break;
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReposition();
            fUpdateDisplay();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReposition();
            fUpdateDisplay();
        }
    }
}
