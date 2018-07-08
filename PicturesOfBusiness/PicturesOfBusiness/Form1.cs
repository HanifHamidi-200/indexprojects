using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicturesOfBusiness
{
    public partial class Form1 : Form
    {
        private static List<bool> _usebusiness1 = new List<bool> { false,false,false,false, true, false };
        private static List<bool> _usebusiness2= new List<bool> { false, false, false, false, true, false };
        private static List<bool> _usebusiness3 = new List<bool> { false, false, false, false, true, false };
        private static List<bool> _usebusiness4 = new List<bool> { false, false, false, false, true, false };
        private static List<bool> _usebusiness5 = new List<bool> { true, true, true, true, true, true };
        private static List<bool> _usebusiness6 = new List<bool> { true, false, false, false, false, false };
        private static List<bool> _usetechnology1 = new List<bool> { false, true, false, false, false, false };
        private static List<bool> _usetechnology2 = new List<bool> { true, true, false, false, false, false };
        private static List<bool> _usetechnology3 = new List<bool> { false, true, false, false, false, false };
        private static List<bool> _usetechnology4 = new List<bool> { false, true, false, false, false, false };
        private static List<bool> _usetechnology5 = new List<bool> { false, true, false, false, false, false };
        private static List<bool> _usetechnology6 = new List<bool> { false, true, true, true, true, true };
        private static List<bool> _useart1 = new List<bool> { false, false, false, false, false, false };
        private static List<bool> _useart2 = new List<bool> { true, false, false, false, false, false };
        private static List<bool> _useart3 = new List<bool> { true, true ,true, true, true, true };
        private static List<bool> _useart4 = new List<bool> { true, true, true, true, true, true };
        private static List<bool> _useart5 = new List<bool> { true, false, false, false, false, false };
        private static List<bool> _useart6 = new List<bool> { false, false, false, false, false, false };
        private static List<int> _col1 = new List<int> { 0,0,0,0,0,0};
        private static List<int> _col2 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private static List<int> _col3 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private static List<int> _col4 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private static List<int> _col5 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private static List<int> _col6 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private int mnMode;
      
        private void fBusiness()
        {
            Random rnd1 = new Random();
            int nCol, nRow, nType;

            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    nCol = i;
                    nRow = j;
                    switch (nCol)
                    {
                        case 1:
                            if (_usebusiness1[nRow - 1] == false)
                            {
                                nType = 1;
                            }
                            else
                            {
                                nType = rnd1.Next(2, 6);
                            }
                            _col1[nRow - 1] = nType;
                            break;
                        case 2:
                            if (_usebusiness2[nRow - 1] == false)
                            {
                                nType = 1;
                            }
                            else
                            {
                                nType = rnd1.Next(2, 6);
                            }
                            _col2[nRow - 1] = nType;
                            break;
                        case 3:
                            if (_usebusiness3[nRow - 1] == false)
                            {
                                nType = 1;
                            }
                            else
                            {
                                nType = rnd1.Next(2, 6);
                            }
                            _col3[nRow - 1] = nType;
                            break;
                        case 4:
                            if (_usebusiness4[nRow - 1] == false)
                            {
                                nType = 1;
                            }
                            else
                            {
                                nType = rnd1.Next(2, 6);
                            }
                            _col4[nRow - 1] = nType;
                            break;
                        case 5:
                            if (_usebusiness5[nRow - 1] == false)
                            {
                                nType = 1;
                            }
                            else
                            {
                                nType = rnd1.Next(2, 6);
                            }
                            _col5[nRow - 1] = nType;
                            break;
                        default:
                            if (_usebusiness6[nRow - 1] == false)
                            {
                                nType = 1;
                            }
                            else
                            {
                                nType = rnd1.Next(2, 6);
                            }
                            _col6[nRow - 1] = nType;
                            break;
                    }
                }
            }
        }

        private void fTechnology()
        {
            Random rnd1 = new Random();
            int nCol, nRow, nType;

            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    nCol = i;
                    nRow = j;
                    switch (nCol)
                    {
                        case 1:
                            if (_usetechnology1[nRow - 1] == false)
                            {
                                nType = 1;
                            }
                            else
                            {
                                nType = rnd1.Next(2, 6);
                            }
                            _col1[nRow - 1] = nType;
                            break;
                        case 2:
                            if (_usetechnology2[nRow - 1] == false)
                            {
                                nType = 1;
                            }
                            else
                            {
                                nType = rnd1.Next(2, 6);
                            }
                            _col2[nRow - 1] = nType;
                            break;
                        case 3:
                            if (_usetechnology3[nRow - 1] == false)
                            {
                                nType = 1;
                            }
                            else
                            {
                                nType = rnd1.Next(2, 6);
                            }
                            _col3[nRow - 1] = nType;
                            break;
                        case 4:
                            if (_usetechnology4[nRow - 1] == false)
                            {
                                nType = 1;
                            }
                            else
                            {
                                nType = rnd1.Next(2, 6);
                            }
                            _col4[nRow - 1] = nType;
                            break;
                        case 5:
                            if (_usetechnology5[nRow - 1] == false)
                            {
                                nType = 1;
                            }
                            else
                            {
                                nType = rnd1.Next(2, 6);
                            }
                            _col5[nRow - 1] = nType;
                            break;
                        default:
                            if (_usetechnology6[nRow - 1] == false)
                            {
                                nType = 1;
                            }
                            else
                            {
                                nType = rnd1.Next(2, 6);
                            }
                            _col6[nRow - 1] = nType;
                            break;
                    }
                }
            }
        }
        private void fArt()
        {
            Random rnd1 = new Random();
            int nCol, nRow, nType;

            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    nCol = i;
                    nRow = j;
                    switch (nCol)
                    {
                        case 1:
                            if (_useart1[nRow - 1] == false)
                            {
                                nType = 1;
                            }
                            else
                            {
                                nType = rnd1.Next(2, 6);
                            }
                            _col1[nRow - 1] = nType;
                            break;
                        case 2:
                            if (_useart2[nRow - 1] == false)
                            {
                                nType = 1;
                            }
                            else
                            {
                                nType = rnd1.Next(2, 6);
                            }
                            _col2[nRow - 1] = nType;
                            break;
                        case 3:
                            if (_useart3[nRow - 1] == false)
                            {
                                nType = 1;
                            }
                            else
                            {
                                nType = rnd1.Next(2, 6);
                            }
                            _col3[nRow - 1] = nType;
                            break;
                        case 4:
                            if (_useart4[nRow - 1] == false)
                            {
                                nType = 1;
                            }
                            else
                            {
                                nType = rnd1.Next(2, 6);
                            }
                            _col4[nRow - 1] = nType;
                            break;
                        case 5:
                            if (_useart5[nRow - 1] == false)
                            {
                                nType = 1;
                            }
                            else
                            {
                                nType = rnd1.Next(2, 6);
                            }
                            _col5[nRow - 1] = nType;
                            break;
                        default:
                            if (_useart6[nRow - 1] == false)
                            {
                                nType = 1;
                            }
                            else
                            {
                                nType = rnd1.Next(2, 6);
                            }
                            _col6[nRow - 1] = nType;
                            break;
                    }
                }
            }
        }

        private void fUpdateDisplay()
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F cross.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F pic1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F pic2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F pic3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F pic4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
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
                default:
                    pic11.Image = picture6.Image;
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
                default:
                    pic12.Image = picture6.Image;
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
                default:
                    pic13.Image = picture6.Image;
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
                default:
                    pic14.Image = picture6.Image;
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
                default:
                    pic15.Image = picture6.Image;
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
                default:
                    pic16.Image = picture6.Image;
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
                default:
                    pic21.Image = picture6.Image;
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
                default:
                    pic22.Image = picture6.Image;
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
                default:
                    pic23.Image = picture6.Image;
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
                default:
                    pic24.Image = picture6.Image;
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
                default:
                    pic25.Image = picture6.Image;
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
                default:
                    pic26.Image = picture6.Image;
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
                default:
                    pic31.Image = picture6.Image;
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
                default:
                    pic32.Image = picture6.Image;
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
                default:
                    pic33.Image = picture6.Image;
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
                default:
                    pic34.Image = picture6.Image;
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
                default:
                    pic35.Image = picture6.Image;
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
                default:
                    pic36.Image = picture6.Image;
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
                default:
                    pic41.Image = picture6.Image;
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
                default:
                    pic42.Image = picture6.Image;
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
                default:
                    pic43.Image = picture6.Image;
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
                default:
                    pic44.Image = picture6.Image;
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
                default:
                    pic45.Image = picture6.Image;
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
                default:
                    pic46.Image = picture6.Image;
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
                default:
                    pic51.Image = picture6.Image;
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
                default:
                    pic52.Image = picture6.Image;
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
                default:
                    pic53.Image = picture6.Image;
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
                default:
                    pic54.Image = picture6.Image;
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
                default:
                    pic55.Image = picture6.Image;
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
                default:
                    pic56.Image = picture6.Image;
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
                default:
                    pic61.Image = picture6.Image;
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
                default:
                    pic62.Image = picture6.Image;
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
                default:
                    pic63.Image = picture6.Image;
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
                default:
                    pic64.Image = picture6.Image;
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
                default:
                    pic65.Image = picture6.Image;
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
                default:
                    pic66.Image = picture6.Image;
                    break;
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();

            mnMode = rnd1.Next(1, 4);
            switch (mnMode)
            {
                case 1:
                    fBusiness();
                    lblMode.Text = "MODE = BUSINESS";
                    break;
                case 2:
                    fTechnology ();
                    lblMode.Text = "MODE = TECHNOLOGY";
                    break;
                default:
                    fArt();
                    lblMode.Text = "MODE = ART";
                    break;
            }
            fUpdateDisplay();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();

            mnMode = rnd1.Next(1, 4);
            switch (mnMode)
            {
                case 1:
                    fBusiness();
                    lblMode.Text = "MODE = BUSINESS";
                    break;
                case 2:
                    fTechnology();
                    lblMode.Text = "MODE = TECHNOLOGY";
                    break;
                default:
                    fArt();
                    lblMode.Text = "MODE = ART";
                    break;
            }
            fUpdateDisplay();

        }
    }
}
