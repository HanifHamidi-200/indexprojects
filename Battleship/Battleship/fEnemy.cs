using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship
{
    public partial class fEnemy : Form
    {
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

        private void fGet()
        {
            String sName = "data.txt";
            String sLine;

            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(sName))
                {
                    // Read the stream to a string, and write the string to the console
                    for (int i = 1; i <= 10; i++)
                    {
                        for (int j = 1; j <= 10; j++)
                        {
                            sLine = sr.ReadLine();
                            switch (i)
                            {
                                case 1:
                                    _enemy1[j - 1] = Convert.ToInt32(sLine);
                                    break;
                                case 2:
                                    _enemy2[j - 1] = Convert.ToInt32(sLine);
                                    break;
                                case 3:
                                    _enemy3[j - 1] = Convert.ToInt32(sLine);
                                    break;
                                case 4:
                                    _enemy4[j - 1] = Convert.ToInt32(sLine);
                                    break;
                                case 5:
                                    _enemy5[j - 1] = Convert.ToInt32(sLine);
                                    break;
                                case 6:
                                    _enemy6[j - 1] = Convert.ToInt32(sLine);
                                    break;
                                case 7:
                                    _enemy7[j - 1] = Convert.ToInt32(sLine);
                                    break;
                                case 8:
                                    _enemy8[j - 1] = Convert.ToInt32(sLine);
                                    break;
                                case 9:
                                    _enemy9[j - 1] = Convert.ToInt32(sLine);
                                    break;
                                case 10:
                                    _enemya[j - 1] = Convert.ToInt32(sLine);
                                    break;
                            }
                        }   }
                    }
                } 
            
            catch (Exception e1)
            {
                MessageBox.Show("The file could not be read:", e1.Message);

                ActiveForm.Close();
            }

        }

        private void fUpdateDisplay()
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

            switch (_enemy1[0])
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
                    pic11.Image = picture9.Image;
                    break;
                default:
                    pic11.Image = picture10.Image;
                    break;
            }
            switch (_enemy1[1])
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
                    pic12.Image = picture9.Image;
                    break;
                default:
                    pic12.Image = picture10.Image;
                    break;
            }
            switch (_enemy1[2])
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
                    pic13.Image = picture9.Image;
                    break;
                default:
                    pic13.Image = picture10.Image;
                    break;
            }
            switch (_enemy1[3])
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
                    pic14.Image = picture9.Image;
                    break;
                default:
                    pic14.Image = picture10.Image;
                    break;
            }
            switch (_enemy1[4])
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
                    pic15.Image = picture9.Image;
                    break;
                default:
                    pic15.Image = picture10.Image;
                    break;
            }
            switch (_enemy1[5])
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
                    pic16.Image = picture9.Image;
                    break;
                default:
                    pic16.Image = picture10.Image;
                    break;
            }
            switch (_enemy1[6])
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
                    pic17.Image = picture9.Image;
                    break;
                default:
                    pic17.Image = picture10.Image;
                    break;
            }
            switch (_enemy1[7])
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
                    pic18.Image = picture9.Image;
                    break;
                default:
                    pic18.Image = picture10.Image;
                    break;
            }
            switch (_enemy1[8])
            {
                case 1:
                    pic19.Image = picture1.Image;
                    break;
                case 2:
                    pic19.Image = picture2.Image;
                    break;
                case 3:
                    pic19.Image = picture3.Image;
                    break;
                case 4:
                    pic19.Image = picture4.Image;
                    break;
                case 5:
                    pic19.Image = picture5.Image;
                    break;
                case 6:
                    pic19.Image = picture6.Image;
                    break;
                case 7:
                    pic19.Image = picture7.Image;
                    break;
                case 8:
                    pic19.Image = picture8.Image;
                    break;
                case 9:
                    pic19.Image = picture9.Image;
                    break;
                case 10:
                    pic19.Image = picture9.Image;
                    break;
                default:
                    pic19.Image = picture10.Image;
                    break;
            }
            switch (_enemy1[9])
            {
                case 1:
                    pic1a.Image = picture1.Image;
                    break;
                case 2:
                    pic1a.Image = picture2.Image;
                    break;
                case 3:
                    pic1a.Image = picture3.Image;
                    break;
                case 4:
                    pic1a.Image = picture4.Image;
                    break;
                case 5:
                    pic1a.Image = picture5.Image;
                    break;
                case 6:
                    pic1a.Image = picture6.Image;
                    break;
                case 7:
                    pic1a.Image = picture7.Image;
                    break;
                case 8:
                    pic1a.Image = picture8.Image;
                    break;
                case 9:
                    pic1a.Image = picture9.Image;
                    break;
                case 10:
                    pic1a.Image = picture9.Image;
                    break;
                default:
                    pic1a.Image = picture10.Image;
                    break;
            }


            //col2 now
            switch (_enemy2[0])
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
                    pic21.Image = picture9.Image;
                    break;
                default:
                    pic21.Image = picture10.Image;
                    break;
            }
            switch (_enemy2[1])
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
                    pic22.Image = picture9.Image;
                    break;
                default:
                    pic22.Image = picture10.Image;
                    break;
            }
            switch (_enemy2[2])
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
                    pic23.Image = picture9.Image;
                    break;
                default:
                    pic23.Image = picture10.Image;
                    break;
            }
            switch (_enemy2[3])
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
                    pic24.Image = picture9.Image;
                    break;
                default:
                    pic24.Image = picture10.Image;
                    break;
            }
            switch (_enemy2[4])
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
                    pic25.Image = picture9.Image;
                    break;
                default:
                    pic25.Image = picture10.Image;
                    break;
            }
            switch (_enemy2[5])
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
                    pic26.Image = picture9.Image;
                    break;
                default:
                    pic26.Image = picture10.Image;
                    break;
            }
            switch (_enemy2[6])
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
                    pic27.Image = picture9.Image;
                    break;
                default:
                    pic27.Image = picture10.Image;
                    break;
            }
            switch (_enemy2[7])
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
                    pic28.Image = picture9.Image;
                    break;
                default:
                    pic28.Image = picture10.Image;
                    break;
            }
            switch (_enemy2[8])
            {
                case 1:
                    pic29.Image = picture1.Image;
                    break;
                case 2:
                    pic29.Image = picture2.Image;
                    break;
                case 3:
                    pic29.Image = picture3.Image;
                    break;
                case 4:
                    pic29.Image = picture4.Image;
                    break;
                case 5:
                    pic29.Image = picture5.Image;
                    break;
                case 6:
                    pic29.Image = picture6.Image;
                    break;
                case 7:
                    pic29.Image = picture7.Image;
                    break;
                case 8:
                    pic29.Image = picture8.Image;
                    break;
                case 9:
                    pic29.Image = picture9.Image;
                    break;
                case 10:
                    pic29.Image = picture9.Image;
                    break;
                default:
                    pic29.Image = picture10.Image;
                    break;
            }
            switch (_enemy2[9])
            {
                case 1:
                    pic2a.Image = picture1.Image;
                    break;
                case 2:
                    pic2a.Image = picture2.Image;
                    break;
                case 3:
                    pic2a.Image = picture3.Image;
                    break;
                case 4:
                    pic2a.Image = picture4.Image;
                    break;
                case 5:
                    pic2a.Image = picture5.Image;
                    break;
                case 6:
                    pic2a.Image = picture6.Image;
                    break;
                case 7:
                    pic2a.Image = picture7.Image;
                    break;
                case 8:
                    pic2a.Image = picture8.Image;
                    break;
                case 9:
                    pic2a.Image = picture9.Image;
                    break;
                case 10:
                    pic2a.Image = picture9.Image;
                    break;
                default:
                    pic2a.Image = picture10.Image;
                    break;
            }



            //col3 now
            switch (_enemy3[0])
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
                    pic31.Image = picture9.Image;
                    break;
                default:
                    pic31.Image = picture10.Image;
                    break;
            }
            switch (_enemy3[1])
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
                    pic32.Image = picture9.Image;
                    break;
                default:
                    pic32.Image = picture10.Image;
                    break;
            }
            switch (_enemy3[2])
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
                    pic33.Image = picture9.Image;
                    break;
                default:
                    pic33.Image = picture10.Image;
                    break;
            }
            switch (_enemy3[3])
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
                    pic34.Image = picture9.Image;
                    break;
                default:
                    pic34.Image = picture10.Image;
                    break;
            }
            switch (_enemy3[4])
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
                    pic35.Image = picture9.Image;
                    break;
                default:
                    pic35.Image = picture10.Image;
                    break;
            }
            switch (_enemy3[5])
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
                    pic36.Image = picture9.Image;
                    break;
                default:
                    pic36.Image = picture10.Image;
                    break;
            }
            switch (_enemy3[6])
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
                    pic37.Image = picture9.Image;
                    break;
                default:
                    pic37.Image = picture10.Image;
                    break;
            }
            switch (_enemy3[7])
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
                    pic38.Image = picture9.Image;
                    break;
                default:
                    pic38.Image = picture10.Image;
                    break;
            }
            switch (_enemy3[8])
            {
                case 1:
                    pic39.Image = picture1.Image;
                    break;
                case 2:
                    pic39.Image = picture2.Image;
                    break;
                case 3:
                    pic39.Image = picture3.Image;
                    break;
                case 4:
                    pic39.Image = picture4.Image;
                    break;
                case 5:
                    pic39.Image = picture5.Image;
                    break;
                case 6:
                    pic39.Image = picture6.Image;
                    break;
                case 7:
                    pic39.Image = picture7.Image;
                    break;
                case 8:
                    pic39.Image = picture8.Image;
                    break;
                case 9:
                    pic39.Image = picture9.Image;
                    break;
                case 10:
                    pic39.Image = picture9.Image;
                    break;
                default:
                    pic39.Image = picture10.Image;
                    break;
            }
            switch (_enemy3[9])
            {
                case 1:
                    pic3a.Image = picture1.Image;
                    break;
                case 2:
                    pic3a.Image = picture2.Image;
                    break;
                case 3:
                    pic3a.Image = picture3.Image;
                    break;
                case 4:
                    pic3a.Image = picture4.Image;
                    break;
                case 5:
                    pic3a.Image = picture5.Image;
                    break;
                case 6:
                    pic3a.Image = picture6.Image;
                    break;
                case 7:
                    pic3a.Image = picture7.Image;
                    break;
                case 8:
                    pic3a.Image = picture8.Image;
                    break;
                case 9:
                    pic3a.Image = picture9.Image;
                    break;
                case 10:
                    pic3a.Image = picture9.Image;
                    break;
                default:
                    pic3a.Image = picture10.Image;
                    break;
            }



            //col4 now
            switch (_enemy4[0])
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
                    pic41.Image = picture9.Image;
                    break;
                default:
                    pic41.Image = picture10.Image;
                    break;
            }
            switch (_enemy4[1])
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
                    pic42.Image = picture9.Image;
                    break;
                default:
                    pic42.Image = picture10.Image;
                    break;
            }
            switch (_enemy4[2])
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
                    pic43.Image = picture9.Image;
                    break;
                default:
                    pic43.Image = picture10.Image;
                    break;
            }
            switch (_enemy4[3])
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
                    pic44.Image = picture9.Image;
                    break;
                default:
                    pic44.Image = picture10.Image;
                    break;
            }
            switch (_enemy4[4])
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
                    pic45.Image = picture9.Image;
                    break;
                default:
                    pic45.Image = picture10.Image;
                    break;
            }
            switch (_enemy4[5])
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
                    pic46.Image = picture9.Image;
                    break;
                default:
                    pic46.Image = picture10.Image;
                    break;
            }
            switch (_enemy4[6])
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
                    pic47.Image = picture9.Image;
                    break;
                default:
                    pic47.Image = picture10.Image;
                    break;
            }
            switch (_enemy4[7])
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
                    pic48.Image = picture9.Image;
                    break;
                default:
                    pic48.Image = picture10.Image;
                    break;
            }
            switch (_enemy4[8])
            {
                case 1:
                    pic49.Image = picture1.Image;
                    break;
                case 2:
                    pic49.Image = picture2.Image;
                    break;
                case 3:
                    pic49.Image = picture3.Image;
                    break;
                case 4:
                    pic49.Image = picture4.Image;
                    break;
                case 5:
                    pic49.Image = picture5.Image;
                    break;
                case 6:
                    pic49.Image = picture6.Image;
                    break;
                case 7:
                    pic49.Image = picture7.Image;
                    break;
                case 8:
                    pic49.Image = picture8.Image;
                    break;
                case 9:
                    pic49.Image = picture9.Image;
                    break;
                case 10:
                    pic49.Image = picture9.Image;
                    break;
                default:
                    pic49.Image = picture10.Image;
                    break;
            }
            switch (_enemy4[9])
            {
                case 1:
                    pic4a.Image = picture1.Image;
                    break;
                case 2:
                    pic4a.Image = picture2.Image;
                    break;
                case 3:
                    pic4a.Image = picture3.Image;
                    break;
                case 4:
                    pic4a.Image = picture4.Image;
                    break;
                case 5:
                    pic4a.Image = picture5.Image;
                    break;
                case 6:
                    pic4a.Image = picture6.Image;
                    break;
                case 7:
                    pic4a.Image = picture7.Image;
                    break;
                case 8:
                    pic4a.Image = picture8.Image;
                    break;
                case 9:
                    pic4a.Image = picture9.Image;
                    break;
                case 10:
                    pic4a.Image = picture9.Image;
                    break;
                default:
                    pic4a.Image = picture10.Image;
                    break;
            }


            //col5 now
            switch (_enemy5[0])
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
                    pic51.Image = picture9.Image;
                    break;
                default:
                    pic51.Image = picture10.Image;
                    break;
            }
            switch (_enemy5[1])
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
                    pic52.Image = picture9.Image;
                    break;
                default:
                    pic52.Image = picture10.Image;
                    break;
            }
            switch (_enemy5[2])
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
                    pic53.Image = picture9.Image;
                    break;
                default:
                    pic53.Image = picture10.Image;
                    break;
            }
            switch (_enemy5[3])
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
                    pic54.Image = picture9.Image;
                    break;
                default:
                    pic54.Image = picture10.Image;
                    break;
            }
            switch (_enemy5[4])
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
                    pic55.Image = picture9.Image;
                    break;
                default:
                    pic55.Image = picture10.Image;
                    break;
            }
            switch (_enemy5[5])
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
                    pic56.Image = picture9.Image;
                    break;
                default:
                    pic56.Image = picture10.Image;
                    break;
            }
            switch (_enemy5[6])
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
                    pic57.Image = picture9.Image;
                    break;
                default:
                    pic57.Image = picture10.Image;
                    break;
            }
            switch (_enemy5[7])
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
                    pic58.Image = picture9.Image;
                    break;
                default:
                    pic58.Image = picture10.Image;
                    break;
            }
            switch (_enemy5[8])
            {
                case 1:
                    pic59.Image = picture1.Image;
                    break;
                case 2:
                    pic59.Image = picture2.Image;
                    break;
                case 3:
                    pic59.Image = picture3.Image;
                    break;
                case 4:
                    pic59.Image = picture4.Image;
                    break;
                case 5:
                    pic59.Image = picture5.Image;
                    break;
                case 6:
                    pic59.Image = picture6.Image;
                    break;
                case 7:
                    pic59.Image = picture7.Image;
                    break;
                case 8:
                    pic59.Image = picture8.Image;
                    break;
                case 9:
                    pic59.Image = picture9.Image;
                    break;
                case 10:
                    pic59.Image = picture9.Image;
                    break;
                default:
                    pic59.Image = picture10.Image;
                    break;
            }
            switch (_enemy5[9])
            {
                case 1:
                    pic5a.Image = picture1.Image;
                    break;
                case 2:
                    pic5a.Image = picture2.Image;
                    break;
                case 3:
                    pic5a.Image = picture3.Image;
                    break;
                case 4:
                    pic5a.Image = picture4.Image;
                    break;
                case 5:
                    pic5a.Image = picture5.Image;
                    break;
                case 6:
                    pic5a.Image = picture6.Image;
                    break;
                case 7:
                    pic5a.Image = picture7.Image;
                    break;
                case 8:
                    pic5a.Image = picture8.Image;
                    break;
                case 9:
                    pic5a.Image = picture9.Image;
                    break;
                case 10:
                    pic5a.Image = picture9.Image;
                    break;
                default:
                    pic5a.Image = picture10.Image;
                    break;
            }



            //col6 now
            switch (_enemy6[0])
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
                    pic61.Image = picture9.Image;
                    break;
                default:
                    pic61.Image = picture10.Image;
                    break;
            }
            switch (_enemy6[1])
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
                    pic62.Image = picture9.Image;
                    break;
                default:
                    pic62.Image = picture10.Image;
                    break;
            }
            switch (_enemy6[2])
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
                    pic63.Image = picture9.Image;
                    break;
                default:
                    pic63.Image = picture10.Image;
                    break;
            }
            switch (_enemy6[3])
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
                    pic64.Image = picture9.Image;
                    break;
                default:
                    pic64.Image = picture10.Image;
                    break;
            }
            switch (_enemy6[4])
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
                    pic65.Image = picture9.Image;
                    break;
                default:
                    pic65.Image = picture10.Image;
                    break;
            }
            switch (_enemy6[5])
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
                    pic66.Image = picture9.Image;
                    break;
                default:
                    pic66.Image = picture10.Image;
                    break;
            }
            switch (_enemy6[6])
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
                    pic67.Image = picture9.Image;
                    break;
                default:
                    pic67.Image = picture10.Image;
                    break;
            }
            switch (_enemy6[7])
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
                    pic68.Image = picture9.Image;
                    break;
                default:
                    pic68.Image = picture10.Image;
                    break;
            }
            switch (_enemy6[8])
            {
                case 1:
                    pic69.Image = picture1.Image;
                    break;
                case 2:
                    pic69.Image = picture2.Image;
                    break;
                case 3:
                    pic69.Image = picture3.Image;
                    break;
                case 4:
                    pic69.Image = picture4.Image;
                    break;
                case 5:
                    pic69.Image = picture5.Image;
                    break;
                case 6:
                    pic69.Image = picture6.Image;
                    break;
                case 7:
                    pic69.Image = picture7.Image;
                    break;
                case 8:
                    pic69.Image = picture8.Image;
                    break;
                case 9:
                    pic69.Image = picture9.Image;
                    break;
                case 10:
                    pic69.Image = picture9.Image;
                    break;
                default:
                    pic69.Image = picture10.Image;
                    break;
            }
            switch (_enemy6[9])
            {
                case 1:
                    pic6a.Image = picture1.Image;
                    break;
                case 2:
                    pic6a.Image = picture2.Image;
                    break;
                case 3:
                    pic6a.Image = picture3.Image;
                    break;
                case 4:
                    pic6a.Image = picture4.Image;
                    break;
                case 5:
                    pic6a.Image = picture5.Image;
                    break;
                case 6:
                    pic6a.Image = picture6.Image;
                    break;
                case 7:
                    pic6a.Image = picture7.Image;
                    break;
                case 8:
                    pic6a.Image = picture8.Image;
                    break;
                case 9:
                    pic6a.Image = picture9.Image;
                    break;
                case 10:
                    pic6a.Image = picture9.Image;
                    break;
                default:
                    pic6a.Image = picture10.Image;
                    break;
            }



            //col7 now
            switch (_enemy7[0])
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
                    pic71.Image = picture9.Image;
                    break;
                default:
                    pic71.Image = picture10.Image;
                    break;
            }
            switch (_enemy7[1])
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
                    pic72.Image = picture9.Image;
                    break;
                default:
                    pic72.Image = picture10.Image;
                    break;
            }
            switch (_enemy7[2])
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
                    pic73.Image = picture9.Image;
                    break;
                default:
                    pic73.Image = picture10.Image;
                    break;
            }
            switch (_enemy7[3])
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
                    pic74.Image = picture9.Image;
                    break;
                default:
                    pic74.Image = picture10.Image;
                    break;
            }
            switch (_enemy7[4])
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
                    pic75.Image = picture9.Image;
                    break;
                default:
                    pic75.Image = picture10.Image;
                    break;
            }
            switch (_enemy7[5])
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
                    pic76.Image = picture9.Image;
                    break;
                default:
                    pic76.Image = picture10.Image;
                    break;
            }
            switch (_enemy7[6])
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
                    pic77.Image = picture9.Image;
                    break;
                default:
                    pic77.Image = picture10.Image;
                    break;
            }
            switch (_enemy7[7])
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
                    pic78.Image = picture9.Image;
                    break;
                default:
                    pic78.Image = picture10.Image;
                    break;
            }
            switch (_enemy7[8])
            {
                case 1:
                    pic79.Image = picture1.Image;
                    break;
                case 2:
                    pic79.Image = picture2.Image;
                    break;
                case 3:
                    pic79.Image = picture3.Image;
                    break;
                case 4:
                    pic79.Image = picture4.Image;
                    break;
                case 5:
                    pic79.Image = picture5.Image;
                    break;
                case 6:
                    pic79.Image = picture6.Image;
                    break;
                case 7:
                    pic79.Image = picture7.Image;
                    break;
                case 8:
                    pic79.Image = picture8.Image;
                    break;
                case 9:
                    pic79.Image = picture9.Image;
                    break;
                case 10:
                    pic79.Image = picture9.Image;
                    break;
                default:
                    pic79.Image = picture10.Image;
                    break;
            }
            switch (_enemy7[9])
            {
                case 1:
                    pic7a.Image = picture1.Image;
                    break;
                case 2:
                    pic7a.Image = picture2.Image;
                    break;
                case 3:
                    pic7a.Image = picture3.Image;
                    break;
                case 4:
                    pic7a.Image = picture4.Image;
                    break;
                case 5:
                    pic7a.Image = picture5.Image;
                    break;
                case 6:
                    pic7a.Image = picture6.Image;
                    break;
                case 7:
                    pic7a.Image = picture7.Image;
                    break;
                case 8:
                    pic7a.Image = picture8.Image;
                    break;
                case 9:
                    pic7a.Image = picture9.Image;
                    break;
                case 10:
                    pic7a.Image = picture9.Image;
                    break;
                default:
                    pic7a.Image = picture10.Image;
                    break;
            }



            //col8 now
            switch (_enemy8[0])
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
                    pic81.Image = picture9.Image;
                    break;
                default:
                    pic81.Image = picture10.Image;
                    break;
            }
            switch (_enemy8[1])
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
                    pic82.Image = picture9.Image;
                    break;
                default:
                    pic82.Image = picture10.Image;
                    break;
            }
            switch (_enemy8[2])
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
                    pic83.Image = picture9.Image;
                    break;
                default:
                    pic83.Image = picture10.Image;
                    break;
            }
            switch (_enemy8[3])
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
                    pic84.Image = picture9.Image;
                    break;
                default:
                    pic84.Image = picture10.Image;
                    break;
            }
            switch (_enemy8[4])
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
                    pic85.Image = picture9.Image;
                    break;
                default:
                    pic85.Image = picture10.Image;
                    break;
            }
            switch (_enemy8[5])
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
                    pic86.Image = picture9.Image;
                    break;
                default:
                    pic86.Image = picture10.Image;
                    break;
            }
            switch (_enemy8[6])
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
                    pic87.Image = picture9.Image;
                    break;
                default:
                    pic87.Image = picture10.Image;
                    break;
            }
            switch (_enemy8[7])
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
                    pic88.Image = picture9.Image;
                    break;
                default:
                    pic88.Image = picture10.Image;
                    break;
            }
            switch (_enemy8[8])
            {
                case 1:
                    pic89.Image = picture1.Image;
                    break;
                case 2:
                    pic89.Image = picture2.Image;
                    break;
                case 3:
                    pic89.Image = picture3.Image;
                    break;
                case 4:
                    pic89.Image = picture4.Image;
                    break;
                case 5:
                    pic89.Image = picture5.Image;
                    break;
                case 6:
                    pic89.Image = picture6.Image;
                    break;
                case 7:
                    pic89.Image = picture7.Image;
                    break;
                case 8:
                    pic89.Image = picture8.Image;
                    break;
                case 9:
                    pic89.Image = picture9.Image;
                    break;
                case 10:
                    pic89.Image = picture9.Image;
                    break;
                default:
                    pic89.Image = picture10.Image;
                    break;
            }
            switch (_enemy8[9])
            {
                case 1:
                    pic8a.Image = picture1.Image;
                    break;
                case 2:
                    pic8a.Image = picture2.Image;
                    break;
                case 3:
                    pic8a.Image = picture3.Image;
                    break;
                case 4:
                    pic8a.Image = picture4.Image;
                    break;
                case 5:
                    pic8a.Image = picture5.Image;
                    break;
                case 6:
                    pic8a.Image = picture6.Image;
                    break;
                case 7:
                    pic8a.Image = picture7.Image;
                    break;
                case 8:
                    pic8a.Image = picture8.Image;
                    break;
                case 9:
                    pic8a.Image = picture9.Image;
                    break;
                case 10:
                    pic8a.Image = picture9.Image;
                    break;
                default:
                    pic8a.Image = picture10.Image;
                    break;
            }



            //col9 now
            switch (_enemy9[0])
            {
                case 1:
                    pic91.Image = picture1.Image;
                    break;
                case 2:
                    pic91.Image = picture2.Image;
                    break;
                case 3:
                    pic91.Image = picture3.Image;
                    break;
                case 4:
                    pic91.Image = picture4.Image;
                    break;
                case 5:
                    pic91.Image = picture5.Image;
                    break;
                case 6:
                    pic91.Image = picture6.Image;
                    break;
                case 7:
                    pic91.Image = picture7.Image;
                    break;
                case 8:
                    pic91.Image = picture8.Image;
                    break;
                case 9:
                    pic91.Image = picture9.Image;
                    break;
                case 10:
                    pic91.Image = picture9.Image;
                    break;
                default:
                    pic91.Image = picture10.Image;
                    break;
            }
            switch (_enemy9[1])
            {
                case 1:
                    pic92.Image = picture1.Image;
                    break;
                case 2:
                    pic92.Image = picture2.Image;
                    break;
                case 3:
                    pic92.Image = picture3.Image;
                    break;
                case 4:
                    pic92.Image = picture4.Image;
                    break;
                case 5:
                    pic92.Image = picture5.Image;
                    break;
                case 6:
                    pic92.Image = picture6.Image;
                    break;
                case 7:
                    pic92.Image = picture7.Image;
                    break;
                case 8:
                    pic92.Image = picture8.Image;
                    break;
                case 9:
                    pic92.Image = picture9.Image;
                    break;
                case 10:
                    pic92.Image = picture9.Image;
                    break;
                default:
                    pic92.Image = picture10.Image;
                    break;
            }
            switch (_enemy9[2])
            {
                case 1:
                    pic93.Image = picture1.Image;
                    break;
                case 2:
                    pic93.Image = picture2.Image;
                    break;
                case 3:
                    pic93.Image = picture3.Image;
                    break;
                case 4:
                    pic93.Image = picture4.Image;
                    break;
                case 5:
                    pic93.Image = picture5.Image;
                    break;
                case 6:
                    pic93.Image = picture6.Image;
                    break;
                case 7:
                    pic93.Image = picture7.Image;
                    break;
                case 8:
                    pic93.Image = picture8.Image;
                    break;
                case 9:
                    pic93.Image = picture9.Image;
                    break;
                case 10:
                    pic93.Image = picture9.Image;
                    break;
                default:
                    pic93.Image = picture10.Image;
                    break;
            }
            switch (_enemy9[3])
            {
                case 1:
                    pic94.Image = picture1.Image;
                    break;
                case 2:
                    pic94.Image = picture2.Image;
                    break;
                case 3:
                    pic94.Image = picture3.Image;
                    break;
                case 4:
                    pic94.Image = picture4.Image;
                    break;
                case 5:
                    pic94.Image = picture5.Image;
                    break;
                case 6:
                    pic94.Image = picture6.Image;
                    break;
                case 7:
                    pic94.Image = picture7.Image;
                    break;
                case 8:
                    pic94.Image = picture8.Image;
                    break;
                case 9:
                    pic94.Image = picture9.Image;
                    break;
                case 10:
                    pic94.Image = picture9.Image;
                    break;
                default:
                    pic94.Image = picture10.Image;
                    break;
            }
            switch (_enemy9[4])
            {
                case 1:
                    pic95.Image = picture1.Image;
                    break;
                case 2:
                    pic95.Image = picture2.Image;
                    break;
                case 3:
                    pic95.Image = picture3.Image;
                    break;
                case 4:
                    pic95.Image = picture4.Image;
                    break;
                case 5:
                    pic95.Image = picture5.Image;
                    break;
                case 6:
                    pic95.Image = picture6.Image;
                    break;
                case 7:
                    pic95.Image = picture7.Image;
                    break;
                case 8:
                    pic95.Image = picture8.Image;
                    break;
                case 9:
                    pic95.Image = picture9.Image;
                    break;
                case 10:
                    pic95.Image = picture9.Image;
                    break;
                default:
                    pic95.Image = picture10.Image;
                    break;
            }
            switch (_enemy9[5])
            {
                case 1:
                    pic96.Image = picture1.Image;
                    break;
                case 2:
                    pic96.Image = picture2.Image;
                    break;
                case 3:
                    pic96.Image = picture3.Image;
                    break;
                case 4:
                    pic96.Image = picture4.Image;
                    break;
                case 5:
                    pic96.Image = picture5.Image;
                    break;
                case 6:
                    pic96.Image = picture6.Image;
                    break;
                case 7:
                    pic96.Image = picture7.Image;
                    break;
                case 8:
                    pic96.Image = picture8.Image;
                    break;
                case 9:
                    pic96.Image = picture9.Image;
                    break;
                case 10:
                    pic96.Image = picture9.Image;
                    break;
                default:
                    pic96.Image = picture10.Image;
                    break;
            }
            switch (_enemy9[6])
            {
                case 1:
                    pic97.Image = picture1.Image;
                    break;
                case 2:
                    pic97.Image = picture2.Image;
                    break;
                case 3:
                    pic97.Image = picture3.Image;
                    break;
                case 4:
                    pic97.Image = picture4.Image;
                    break;
                case 5:
                    pic97.Image = picture5.Image;
                    break;
                case 6:
                    pic97.Image = picture6.Image;
                    break;
                case 7:
                    pic97.Image = picture7.Image;
                    break;
                case 8:
                    pic97.Image = picture8.Image;
                    break;
                case 9:
                    pic97.Image = picture9.Image;
                    break;
                case 10:
                    pic97.Image = picture9.Image;
                    break;
                default:
                    pic97.Image = picture10.Image;
                    break;
            }
            switch (_enemy9[7])
            {
                case 1:
                    pic98.Image = picture1.Image;
                    break;
                case 2:
                    pic98.Image = picture2.Image;
                    break;
                case 3:
                    pic98.Image = picture3.Image;
                    break;
                case 4:
                    pic98.Image = picture4.Image;
                    break;
                case 5:
                    pic98.Image = picture5.Image;
                    break;
                case 6:
                    pic98.Image = picture6.Image;
                    break;
                case 7:
                    pic98.Image = picture7.Image;
                    break;
                case 8:
                    pic98.Image = picture8.Image;
                    break;
                case 9:
                    pic98.Image = picture9.Image;
                    break;
                case 10:
                    pic98.Image = picture9.Image;
                    break;
                default:
                    pic98.Image = picture10.Image;
                    break;
            }
            switch (_enemy9[8])
            {
                case 1:
                    pic99.Image = picture1.Image;
                    break;
                case 2:
                    pic99.Image = picture2.Image;
                    break;
                case 3:
                    pic99.Image = picture3.Image;
                    break;
                case 4:
                    pic99.Image = picture4.Image;
                    break;
                case 5:
                    pic99.Image = picture5.Image;
                    break;
                case 6:
                    pic99.Image = picture6.Image;
                    break;
                case 7:
                    pic99.Image = picture7.Image;
                    break;
                case 8:
                    pic99.Image = picture8.Image;
                    break;
                case 9:
                    pic99.Image = picture9.Image;
                    break;
                case 10:
                    pic99.Image = picture9.Image;
                    break;
                default:
                    pic99.Image = picture10.Image;
                    break;
            }
            switch (_enemy9[9])
            {
                case 1:
                    pic9a.Image = picture1.Image;
                    break;
                case 2:
                    pic9a.Image = picture2.Image;
                    break;
                case 3:
                    pic9a.Image = picture3.Image;
                    break;
                case 4:
                    pic9a.Image = picture4.Image;
                    break;
                case 5:
                    pic9a.Image = picture5.Image;
                    break;
                case 6:
                    pic9a.Image = picture6.Image;
                    break;
                case 7:
                    pic9a.Image = picture7.Image;
                    break;
                case 8:
                    pic9a.Image = picture8.Image;
                    break;
                case 9:
                    pic9a.Image = picture9.Image;
                    break;
                case 10:
                    pic9a.Image = picture9.Image;
                    break;
                default:
                    pic9a.Image = picture10.Image;
                    break;
            }



            //col10 now
            switch (_enemya[0])
            {
                case 1:
                    pica1.Image = picture1.Image;
                    break;
                case 2:
                    pica1.Image = picture2.Image;
                    break;
                case 3:
                    pica1.Image = picture3.Image;
                    break;
                case 4:
                    pica1.Image = picture4.Image;
                    break;
                case 5:
                    pica1.Image = picture5.Image;
                    break;
                case 6:
                    pica1.Image = picture6.Image;
                    break;
                case 7:
                    pica1.Image = picture7.Image;
                    break;
                case 8:
                    pica1.Image = picture8.Image;
                    break;
                case 9:
                    pica1.Image = picture9.Image;
                    break;
                case 10:
                    pica1.Image = picture9.Image;
                    break;
                default:
                    pica1.Image = picture10.Image;
                    break;
            }
            switch (_enemya[1])
            {
                case 1:
                    pica2.Image = picture1.Image;
                    break;
                case 2:
                    pica2.Image = picture2.Image;
                    break;
                case 3:
                    pica2.Image = picture3.Image;
                    break;
                case 4:
                    pica2.Image = picture4.Image;
                    break;
                case 5:
                    pica2.Image = picture5.Image;
                    break;
                case 6:
                    pica2.Image = picture6.Image;
                    break;
                case 7:
                    pica2.Image = picture7.Image;
                    break;
                case 8:
                    pica2.Image = picture8.Image;
                    break;
                case 9:
                    pica2.Image = picture9.Image;
                    break;
                case 10:
                    pica2.Image = picture9.Image;
                    break;
                default:
                    pica2.Image = picture10.Image;
                    break;
            }
            switch (_enemya[2])
            {
                case 1:
                    pica3.Image = picture1.Image;
                    break;
                case 2:
                    pica3.Image = picture2.Image;
                    break;
                case 3:
                    pica3.Image = picture3.Image;
                    break;
                case 4:
                    pica3.Image = picture4.Image;
                    break;
                case 5:
                    pica3.Image = picture5.Image;
                    break;
                case 6:
                    pica3.Image = picture6.Image;
                    break;
                case 7:
                    pica3.Image = picture7.Image;
                    break;
                case 8:
                    pica3.Image = picture8.Image;
                    break;
                case 9:
                    pica3.Image = picture9.Image;
                    break;
                case 10:
                    pica3.Image = picture9.Image;
                    break;
                default:
                    pica3.Image = picture10.Image;
                    break;
            }
            switch (_enemya[3])
            {
                case 1:
                    pica4.Image = picture1.Image;
                    break;
                case 2:
                    pica4.Image = picture2.Image;
                    break;
                case 3:
                    pica4.Image = picture3.Image;
                    break;
                case 4:
                    pica4.Image = picture4.Image;
                    break;
                case 5:
                    pica4.Image = picture5.Image;
                    break;
                case 6:
                    pica4.Image = picture6.Image;
                    break;
                case 7:
                    pica4.Image = picture7.Image;
                    break;
                case 8:
                    pica4.Image = picture8.Image;
                    break;
                case 9:
                    pica4.Image = picture9.Image;
                    break;
                case 10:
                    pica4.Image = picture9.Image;
                    break;
                default:
                    pica4.Image = picture10.Image;
                    break;
            }
            switch (_enemya[4])
            {
                case 1:
                    pica5.Image = picture1.Image;
                    break;
                case 2:
                    pica5.Image = picture2.Image;
                    break;
                case 3:
                    pica5.Image = picture3.Image;
                    break;
                case 4:
                    pica5.Image = picture4.Image;
                    break;
                case 5:
                    pica5.Image = picture5.Image;
                    break;
                case 6:
                    pica5.Image = picture6.Image;
                    break;
                case 7:
                    pica5.Image = picture7.Image;
                    break;
                case 8:
                    pica5.Image = picture8.Image;
                    break;
                case 9:
                    pica5.Image = picture9.Image;
                    break;
                case 10:
                    pica5.Image = picture9.Image;
                    break;
                default:
                    pica5.Image = picture10.Image;
                    break;
            }
            switch (_enemya[5])
            {
                case 1:
                    pica6.Image = picture1.Image;
                    break;
                case 2:
                    pica6.Image = picture2.Image;
                    break;
                case 3:
                    pica6.Image = picture3.Image;
                    break;
                case 4:
                    pica6.Image = picture4.Image;
                    break;
                case 5:
                    pica6.Image = picture5.Image;
                    break;
                case 6:
                    pica6.Image = picture6.Image;
                    break;
                case 7:
                    pica6.Image = picture7.Image;
                    break;
                case 8:
                    pica6.Image = picture8.Image;
                    break;
                case 9:
                    pica6.Image = picture9.Image;
                    break;
                case 10:
                    pica6.Image = picture9.Image;
                    break;
                default:
                    pica6.Image = picture10.Image;
                    break;
            }
            switch (_enemya[6])
            {
                case 1:
                    pica7.Image = picture1.Image;
                    break;
                case 2:
                    pica7.Image = picture2.Image;
                    break;
                case 3:
                    pica7.Image = picture3.Image;
                    break;
                case 4:
                    pica7.Image = picture4.Image;
                    break;
                case 5:
                    pica7.Image = picture5.Image;
                    break;
                case 6:
                    pica7.Image = picture6.Image;
                    break;
                case 7:
                    pica7.Image = picture7.Image;
                    break;
                case 8:
                    pica7.Image = picture8.Image;
                    break;
                case 9:
                    pica7.Image = picture9.Image;
                    break;
                case 10:
                    pica7.Image = picture9.Image;
                    break;
                default:
                    pica7.Image = picture10.Image;
                    break;
            }
            switch (_enemya[7])
            {
                case 1:
                    pica8.Image = picture1.Image;
                    break;
                case 2:
                    pica8.Image = picture2.Image;
                    break;
                case 3:
                    pica8.Image = picture3.Image;
                    break;
                case 4:
                    pica8.Image = picture4.Image;
                    break;
                case 5:
                    pica8.Image = picture5.Image;
                    break;
                case 6:
                    pica8.Image = picture6.Image;
                    break;
                case 7:
                    pica8.Image = picture7.Image;
                    break;
                case 8:
                    pica8.Image = picture8.Image;
                    break;
                case 9:
                    pica8.Image = picture9.Image;
                    break;
                case 10:
                    pica8.Image = picture9.Image;
                    break;
                default:
                    pica8.Image = picture10.Image;
                    break;
            }
            switch (_enemya[8])
            {
                case 1:
                    pica9.Image = picture1.Image;
                    break;
                case 2:
                    pica9.Image = picture2.Image;
                    break;
                case 3:
                    pica9.Image = picture3.Image;
                    break;
                case 4:
                    pica9.Image = picture4.Image;
                    break;
                case 5:
                    pica9.Image = picture5.Image;
                    break;
                case 6:
                    pica9.Image = picture6.Image;
                    break;
                case 7:
                    pica9.Image = picture7.Image;
                    break;
                case 8:
                    pica9.Image = picture8.Image;
                    break;
                case 9:
                    pica9.Image = picture9.Image;
                    break;
                case 10:
                    pica9.Image = picture9.Image;
                    break;
                default:
                    pica9.Image = picture10.Image;
                    break;
            }
            switch (_enemya[9])
            {
                case 1:
                    picaa.Image = picture1.Image;
                    break;
                case 2:
                    picaa.Image = picture2.Image;
                    break;
                case 3:
                    picaa.Image = picture3.Image;
                    break;
                case 4:
                    picaa.Image = picture4.Image;
                    break;
                case 5:
                    picaa.Image = picture5.Image;
                    break;
                case 6:
                    picaa.Image = picture6.Image;
                    break;
                case 7:
                    picaa.Image = picture7.Image;
                    break;
                case 8:
                    picaa.Image = picture8.Image;
                    break;
                case 9:
                    picaa.Image = picture9.Image;
                    break;
                case 10:
                    picaa.Image = picture9.Image;
                    break;
                default:
                    picaa.Image = picture10.Image;
                    break;
            }



        }
        public fEnemy()
        {
            InitializeComponent();
        }

        private void fEnemy_Load(object sender, EventArgs e)
        {
            fGet();
            fUpdateDisplay();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
