using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The3Juggle
{
    public partial class Form1 : Form
    {
        private static List<int> _col1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _col5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
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
        private int mnAdd;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            mnAdd = 2;
            for (int i = 1; i <= 8; i++)
            {
                _col1[i - 1] = rnd1.Next(2, 5);
                _col2[i - 1] = rnd1.Next(2, 5);
                _col3[i - 1] = rnd1.Next(2, 5);
                _col4[i - 1] = rnd1.Next(2, 5);
                _col5[i - 1] = rnd1.Next(2, 5);
                _col6[i - 1] = rnd1.Next(2, 5);
                _col7[i - 1] = rnd1.Next(2, 5);
                _col8[i - 1] = rnd1.Next(2, 5);
            }
            for (int i = 1; i <= 8; i++)
            {
                _rotate1[i - 1] = rnd1.Next(1, 4);
                _rotate2[i - 1] = rnd1.Next(1, 4);
                _rotate3[i - 1] = rnd1.Next(1, 4);
                _rotate4[i - 1] = rnd1.Next(1, 4);
                _rotate5[i - 1] = rnd1.Next(1, 4);
                _rotate6[i - 1] = rnd1.Next(1, 4);
                _rotate7[i - 1] = rnd1.Next(1, 4);
                _rotate8[i - 1] = rnd1.Next(1, 4);
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate1[0];
            switch (_col1[0])
            {
                case 1:
                    pic11.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic11.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic11.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic11.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic11.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic11.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic11.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic11.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic11.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic11.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate1[1];
            switch (_col1[1])
            {
                case 1:
                    pic12.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic12.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic12.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic12.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic12.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic12.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic12.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic12.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic12.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic12.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate1[2];
            switch (_col1[2])
            {
                case 1:
                    pic13.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic13.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic13.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic13.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic13.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic13.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic13.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic13.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic13.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic13.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate1[3];
            switch (_col1[3])
            {
                case 1:
                    pic14.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic14.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic14.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic14.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic14.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic14.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic14.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic14.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic14.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic14.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate1[4];
            switch (_col1[4])
            {
                case 1:
                    pic15.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic15.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic15.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic15.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic15.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic15.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic15.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic15.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic15.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic15.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate1[5];
            switch (_col1[5])
            {
                case 1:
                    pic16.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic16.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic16.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic16.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic16.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic16.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic16.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic16.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic16.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic16.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate1[6];
            switch (_col1[6])
            {
                case 1:
                    pic17.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic17.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic17.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic17.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic17.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic17.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic17.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic17.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic17.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic17.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate1[7];
            switch (_col1[7])
            {
                case 1:
                    pic18.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic18.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic18.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic18.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic18.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic18.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic18.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic18.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic18.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic18.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

            //col2 now
            nRotate = _rotate2[0];
            switch (_col2[0])
            {
                case 1:
                    pic21.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic21.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic21.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic21.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic21.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic21.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic21.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic21.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic21.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic21.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate2[1];
            switch (_col2[1])
            {
                case 1:
                    pic22.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic22.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic22.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic22.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic22.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic22.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic22.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic22.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic22.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic22.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate2[2];
            switch (_col2[2])
            {
                case 1:
                    pic23.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic23.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic23.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic23.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic23.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic23.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic23.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic23.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic23.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic23.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate2[3];
            switch (_col2[3])
            {
                case 1:
                    pic24.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic24.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic24.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic24.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic24.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic24.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic24.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic24.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic24.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic24.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate2[4];
            switch (_col2[4])
            {
                case 1:
                    pic25.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic25.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic25.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic25.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic25.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic25.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic25.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic25.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic25.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic25.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate2[5];
            switch (_col2[5])
            {
                case 1:
                    pic26.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic26.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic26.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic26.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic26.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic26.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic26.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic26.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic26.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic26.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate2[6];
            switch (_col2[6])
            {
                case 1:
                    pic27.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic27.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic27.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic27.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic27.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic27.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic27.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic27.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic27.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic27.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate2[7];
            switch (_col2[7])
            {
                case 1:
                    pic28.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic28.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic28.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic28.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic28.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic28.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic28.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic28.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic28.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic28.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }


            //col3 now
            nRotate = _rotate3[0];
            switch (_col3[0])
            {
                case 1:
                    pic31.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic31.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic31.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic31.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic31.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic31.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic31.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic31.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic31.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic31.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate3[1];
            switch (_col3[1])
            {
                case 1:
                    pic32.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic32.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic32.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic32.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic32.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic32.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic32.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic32.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic32.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic32.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate3[2];
            switch (_col3[2])
            {
                case 1:
                    pic33.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic33.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic33.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic33.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic33.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic33.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic33.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic33.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic33.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic33.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate3[3];
            switch (_col3[3])
            {
                case 1:
                    pic34.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic34.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic34.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic34.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic34.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic34.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic34.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic34.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic34.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic34.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate3[4];
            switch (_col3[4])
            {
                case 1:
                    pic35.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic35.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic35.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic35.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic35.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic35.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic35.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic35.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic35.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic35.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate3[5];
            switch (_col3[5])
            {
                case 1:
                    pic36.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic36.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic36.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic36.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic36.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic36.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic36.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic36.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic36.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic36.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate3[6];
            switch (_col3[6])
            {
                case 1:
                    pic37.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic37.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic37.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic37.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic37.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic37.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic37.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic37.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic37.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic37.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate3[7];
            switch (_col3[7])
            {
                case 1:
                    pic38.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic38.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic38.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic38.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic38.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic38.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic38.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic38.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic38.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic38.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

            //col4 now
            nRotate = _rotate4[0];
            switch (_col4[0])
            {
                case 1:
                    pic41.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic41.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic41.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic41.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic41.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic41.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic41.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic41.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic41.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic41.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate4[1];
            switch (_col4[1])
            {
                case 1:
                    pic42.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic42.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic42.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic42.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic42.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic42.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic42.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic42.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic42.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic42.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate4[2];
            switch (_col4[2])
            {
                case 1:
                    pic43.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic43.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic43.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic43.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic43.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic43.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic43.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic43.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic43.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic43.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate4[3];
            switch (_col4[3])
            {
                case 1:
                    pic44.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic44.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic44.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic44.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic44.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic44.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic44.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic44.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic44.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic44.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate4[4];
            switch (_col4[4])
            {
                case 1:
                    pic45.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic45.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic45.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic45.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic45.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic45.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic45.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic45.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic45.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic45.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate4[5];
            switch (_col4[5])
            {
                case 1:
                    pic46.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic46.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic46.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic46.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic46.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic46.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic46.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic46.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic46.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic46.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate4[6];
            switch (_col4[6])
            {
                case 1:
                    pic47.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic47.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic47.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic47.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic47.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic47.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic47.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic47.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic47.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic47.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate4[7];
            switch (_col4[7])
            {
                case 1:
                    pic48.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic48.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic48.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic48.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic48.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic48.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic48.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic48.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic48.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic48.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

            //col5 now
            nRotate = _rotate5[0];
            switch (_col5[0])
            {
                case 1:
                    pic51.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic51.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic51.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic51.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic51.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic51.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic51.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic51.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic51.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic51.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate5[1];
            switch (_col5[1])
            {
                case 1:
                    pic52.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic52.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic52.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic52.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic52.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic52.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic52.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic52.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic52.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic52.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate5[2];
            switch (_col5[2])
            {
                case 1:
                    pic53.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic53.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic53.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic53.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic53.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic53.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic53.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic53.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic53.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic53.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate5[3];
            switch (_col5[3])
            {
                case 1:
                    pic54.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic54.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic54.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic54.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic54.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic54.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic54.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic54.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic54.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic54.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate5[4];
            switch (_col5[4])
            {
                case 1:
                    pic55.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic55.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic55.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic55.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic55.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic55.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic55.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic55.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic55.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic55.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate5[5];
            switch (_col5[5])
            {
                case 1:
                    pic56.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic56.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic56.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic56.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic56.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic56.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic56.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic56.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic56.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic56.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate5[6];
            switch (_col5[6])
            {
                case 1:
                    pic57.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic57.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic57.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic57.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic57.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic57.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic57.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic57.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic57.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic57.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate5[7];
            switch (_col5[7])
            {
                case 1:
                    pic58.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic58.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic58.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic58.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic58.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic58.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic58.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic58.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic58.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic58.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

            //col6 now
            nRotate = _rotate6[0];
            switch (_col6[0])
            {
                case 1:
                    pic61.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic61.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic61.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic61.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic61.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic61.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic61.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic61.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic61.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic61.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate6[1];
            switch (_col6[1])
            {
                case 1:
                    pic62.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic62.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic62.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic62.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic62.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic62.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic62.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic62.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic62.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic62.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate6[2];
            switch (_col6[2])
            {
                case 1:
                    pic63.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic63.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic63.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic63.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic63.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic63.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic63.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic63.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic63.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic63.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate6[3];
            switch (_col6[3])
            {
                case 1:
                    pic64.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic64.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic64.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic64.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic64.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic64.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic64.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic64.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic64.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic64.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate6[4];
            switch (_col6[4])
            {
                case 1:
                    pic65.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic65.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic65.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic65.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic65.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic65.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic65.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic65.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic65.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic65.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate6[5];
            switch (_col6[5])
            {
                case 1:
                    pic66.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic66.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic66.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic66.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic66.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic66.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic66.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic66.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic66.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic66.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate6[6];
            switch (_col6[6])
            {
                case 1:
                    pic67.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic67.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic67.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic67.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic67.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic67.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic67.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic67.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic67.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic67.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate6[7];
            switch (_col6[7])
            {
                case 1:
                    pic68.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic68.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic68.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic68.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic68.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic68.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic68.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic68.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic68.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic68.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

            //col7 now
            nRotate = _rotate7[0];
            switch (_col7[0])
            {
                case 1:
                    pic71.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic71.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic71.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic71.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic71.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic71.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic71.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic71.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic71.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic71.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate7[1];
            switch (_col7[1])
            {
                case 1:
                    pic72.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic72.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic72.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic72.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic72.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic72.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic72.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic72.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic72.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic72.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate7[2];
            switch (_col7[2])
            {
                case 1:
                    pic73.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic73.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic73.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic73.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic73.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic73.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic73.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic73.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic73.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic73.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate7[3];
            switch (_col7[3])
            {
                case 1:
                    pic74.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic74.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic74.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic74.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic74.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic74.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic74.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic74.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic74.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic74.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate7[4];
            switch (_col7[4])
            {
                case 1:
                    pic75.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic75.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic75.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic75.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic75.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic75.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic75.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic75.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic75.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic75.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate7[5];
            switch (_col7[5])
            {
                case 1:
                    pic76.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic76.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic76.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic76.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic76.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic76.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic76.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic76.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic76.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic76.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate7[6];
            switch (_col7[6])
            {
                case 1:
                    pic77.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic77.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic77.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic77.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic77.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic77.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic77.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic77.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic77.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic77.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate7[7];
            switch (_col7[7])
            {
                case 1:
                    pic78.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic78.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic78.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic78.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic78.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic78.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic78.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic78.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic78.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic78.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

            //col8 now
            nRotate = _rotate8[0];
            switch (_col8[0])
            {
                case 1:
                    pic81.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic81.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic81.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic81.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic81.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic81.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic81.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic81.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic81.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic81.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate8[1];
            switch (_col8[1])
            {
                case 1:
                    pic82.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic82.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic82.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic82.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic82.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic82.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic82.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic82.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic82.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic82.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate8[2];
            switch (_col8[2])
            {
                case 1:
                    pic83.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic83.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic83.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic83.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic83.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic83.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic83.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic83.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic83.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic83.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate8[3];
            switch (_col8[3])
            {
                case 1:
                    pic84.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic84.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic84.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic84.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic84.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic84.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic84.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic84.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic84.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic84.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate8[4];
            switch (_col8[4])
            {
                case 1:
                    pic85.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic85.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic85.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic85.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic85.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic85.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic85.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic85.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic85.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic85.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate8[5];
            switch (_col8[5])
            {
                case 1:
                    pic86.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic86.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic86.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic86.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic86.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic86.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic86.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic86.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic86.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic86.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate8[6];
            switch (_col8[6])
            {
                case 1:
                    pic87.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic87.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic87.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic87.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic87.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic87.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic87.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic87.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic87.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic87.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate8[7];
            switch (_col8[7])
            {
                case 1:
                    pic88.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic88.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic88.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic88.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic88.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic88.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic88.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic88.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic88.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic88.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }


        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;
          
            for (int i = 1; i <= 8; i++)
            {
                _col1[i - 1] = rnd1.Next(2, 5);
                _col2[i - 1] = rnd1.Next(2, 5);
                _col3[i - 1] = rnd1.Next(2, 5);
                _col4[i - 1] = rnd1.Next(2, 5);
                _col5[i - 1] = rnd1.Next(2, 5);
                _col6[i - 1] = rnd1.Next(2, 5);
                _col7[i - 1] = rnd1.Next(2, 5);
                _col8[i - 1] = rnd1.Next(2, 5);
            }
            for (int i = 1; i <= 8; i++)
            {
                _rotate1[i - 1] = rnd1.Next(1, 4);
                _rotate2[i - 1] = rnd1.Next(1, 4);
                _rotate3[i - 1] = rnd1.Next(1, 4);
                _rotate4[i - 1] = rnd1.Next(1, 4);
                _rotate5[i - 1] = rnd1.Next(1, 4);
                _rotate6[i - 1] = rnd1.Next(1, 4);
                _rotate7[i - 1] = rnd1.Next(1, 4);
                _rotate8[i - 1] = rnd1.Next(1, 4);
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate1[0];
            nRotate = _rotate1[0];
            nRotate = _rotate1[0];
            switch (_col1[0])
            {
                case 1:
                    pic11.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic11.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic11.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic11.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic11.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic11.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic11.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic11.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic11.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic11.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate1[1];
            switch (_col1[1])
            {
                case 1:
                    pic12.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic12.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic12.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic12.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic12.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic12.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic12.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic12.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic12.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic12.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate1[2];
            switch (_col1[2])
            {
                case 1:
                    pic13.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic13.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic13.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic13.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic13.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic13.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic13.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic13.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic13.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic13.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate1[3];
            switch (_col1[3])
            {
                case 1:
                    pic14.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic14.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic14.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic14.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic14.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic14.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic14.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic14.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic14.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic14.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate1[4];
            switch (_col1[4])
            {
                case 1:
                    pic15.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic15.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic15.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic15.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic15.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic15.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic15.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic15.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic15.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic15.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate1[5];
            switch (_col1[5])
            {
                case 1:
                    pic16.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic16.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic16.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic16.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic16.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic16.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic16.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic16.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic16.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic16.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate1[6];
            switch (_col1[6])
            {
                case 1:
                    pic17.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic17.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic17.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic17.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic17.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic17.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic17.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic17.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic17.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic17.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate1[7];
            switch (_col1[7])
            {
                case 1:
                    pic18.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic18.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic18.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic18.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic18.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic18.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic18.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic18.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic18.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic18.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

            //col2 now
            nRotate = _rotate2[0];
            switch (_col2[0])
            {
                case 1:
                    pic21.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic21.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic21.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic21.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic21.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic21.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic21.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic21.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic21.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic21.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate2[1];
            switch (_col2[1])
            {
                case 1:
                    pic22.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic22.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic22.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic22.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic22.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic22.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic22.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic22.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic22.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic22.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate2[2];
            switch (_col2[2])
            {
                case 1:
                    pic23.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic23.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic23.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic23.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic23.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic23.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic23.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic23.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic23.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic23.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate2[3];
            switch (_col2[3])
            {
                case 1:
                    pic24.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic24.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic24.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic24.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic24.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic24.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic24.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic24.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic24.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic24.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate2[4];
            switch (_col2[4])
            {
                case 1:
                    pic25.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic25.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic25.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic25.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic25.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic25.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic25.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic25.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic25.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic25.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate2[5];
            switch (_col2[5])
            {
                case 1:
                    pic26.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic26.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic26.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic26.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic26.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic26.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic26.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic26.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic26.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic26.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate2[6];
            switch (_col2[6])
            {
                case 1:
                    pic27.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic27.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic27.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic27.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic27.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic27.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic27.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic27.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic27.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic27.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate2[7];
            switch (_col2[7])
            {
                case 1:
                    pic28.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic28.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic28.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic28.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic28.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic28.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic28.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic28.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic28.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic28.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }


            //col3 now
            nRotate = _rotate3[0];
            switch (_col3[0])
            {
                case 1:
                    pic31.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic31.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic31.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic31.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic31.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic31.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic31.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic31.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic31.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic31.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate3[1];
            switch (_col3[1])
            {
                case 1:
                    pic32.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic32.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic32.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic32.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic32.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic32.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic32.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic32.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic32.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic32.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate3[2];
            switch (_col3[2])
            {
                case 1:
                    pic33.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic33.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic33.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic33.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic33.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic33.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic33.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic33.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic33.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic33.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate3[3];
            switch (_col3[3])
            {
                case 1:
                    pic34.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic34.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic34.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic34.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic34.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic34.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic34.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic34.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic34.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic34.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate3[4];
            switch (_col3[4])
            {
                case 1:
                    pic35.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic35.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic35.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic35.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic35.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic35.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic35.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic35.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic35.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic35.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate3[5];
            switch (_col3[5])
            {
                case 1:
                    pic36.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic36.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic36.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic36.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic36.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic36.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic36.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic36.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic36.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic36.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate3[6];
            switch (_col3[6])
            {
                case 1:
                    pic37.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic37.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic37.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic37.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic37.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic37.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic37.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic37.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic37.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic37.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate3[7];
            switch (_col3[7])
            {
                case 1:
                    pic38.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic38.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic38.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic38.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic38.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic38.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic38.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic38.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic38.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic38.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

            //col4 now
            nRotate = _rotate4[0];
            switch (_col4[0])
            {
                case 1:
                    pic41.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic41.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic41.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic41.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic41.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic41.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic41.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic41.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic41.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic41.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate4[1];
            switch (_col4[1])
            {
                case 1:
                    pic42.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic42.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic42.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic42.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic42.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic42.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic42.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic42.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic42.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic42.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate4[2];
            switch (_col4[2])
            {
                case 1:
                    pic43.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic43.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic43.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic43.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic43.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic43.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic43.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic43.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic43.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic43.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate4[3];
            switch (_col4[3])
            {
                case 1:
                    pic44.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic44.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic44.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic44.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic44.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic44.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic44.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic44.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic44.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic44.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate4[4];
            switch (_col4[4])
            {
                case 1:
                    pic45.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic45.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic45.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic45.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic45.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic45.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic45.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic45.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic45.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic45.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate4[5];
            switch (_col4[5])
            {
                case 1:
                    pic46.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic46.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic46.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic46.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic46.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic46.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic46.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic46.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic46.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic46.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate4[6];
            switch (_col4[6])
            {
                case 1:
                    pic47.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic47.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic47.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic47.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic47.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic47.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic47.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic47.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic47.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic47.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate4[7];
            switch (_col4[7])
            {
                case 1:
                    pic48.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic48.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic48.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic48.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic48.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic48.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic48.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic48.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic48.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic48.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

            //col5 now
            nRotate = _rotate5[0];
            switch (_col5[0])
            {
                case 1:
                    pic51.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic51.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic51.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic51.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic51.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic51.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic51.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic51.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic51.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic51.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate5[1];
            switch (_col5[1])
            {
                case 1:
                    pic52.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic52.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic52.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic52.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic52.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic52.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic52.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic52.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic52.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic52.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate5[2];
            switch (_col5[2])
            {
                case 1:
                    pic53.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic53.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic53.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic53.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic53.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic53.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic53.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic53.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic53.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic53.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate5[3];
            switch (_col5[3])
            {
                case 1:
                    pic54.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic54.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic54.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic54.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic54.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic54.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic54.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic54.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic54.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic54.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate5[4];
            switch (_col5[4])
            {
                case 1:
                    pic55.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic55.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic55.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic55.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic55.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic55.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic55.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic55.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic55.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic55.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate5[5];
            switch (_col5[5])
            {
                case 1:
                    pic56.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic56.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic56.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic56.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic56.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic56.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic56.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic56.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic56.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic56.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate5[6];
            switch (_col5[6])
            {
                case 1:
                    pic57.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic57.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic57.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic57.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic57.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic57.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic57.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic57.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic57.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic57.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate5[7];
            switch (_col5[7])
            {
                case 1:
                    pic58.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic58.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic58.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic58.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic58.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic58.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic58.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic58.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic58.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic58.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

            //col6 now
            nRotate = _rotate6[0];
            switch (_col6[0])
            {
                case 1:
                    pic61.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic61.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic61.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic61.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic61.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic61.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic61.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic61.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic61.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic61.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate6[1];
            switch (_col6[1])
            {
                case 1:
                    pic62.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic62.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic62.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic62.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic62.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic62.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic62.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic62.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic62.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic62.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate6[2];
            switch (_col6[2])
            {
                case 1:
                    pic63.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic63.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic63.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic63.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic63.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic63.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic63.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic63.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic63.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic63.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate6[3];
            switch (_col6[3])
            {
                case 1:
                    pic64.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic64.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic64.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic64.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic64.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic64.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic64.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic64.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic64.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic64.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate6[4];
            switch (_col6[4])
            {
                case 1:
                    pic65.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic65.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic65.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic65.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic65.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic65.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic65.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic65.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic65.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic65.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate6[5];
            switch (_col6[5])
            {
                case 1:
                    pic66.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic66.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic66.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic66.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic66.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic66.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic66.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic66.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic66.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic66.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate6[6];
            switch (_col6[6])
            {
                case 1:
                    pic67.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic67.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic67.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic67.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic67.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic67.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic67.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic67.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic67.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic67.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate6[7];
            switch (_col6[7])
            {
                case 1:
                    pic68.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic68.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic68.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic68.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic68.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic68.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic68.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic68.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic68.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic68.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

            //col7 now
            nRotate = _rotate7[0];
            switch (_col7[0])
            {
                case 1:
                    pic71.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic71.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic71.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic71.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic71.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic71.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic71.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic71.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic71.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic71.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate7[1];
            switch (_col7[1])
            {
                case 1:
                    pic72.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic72.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic72.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic72.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic72.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic72.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic72.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic72.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic72.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic72.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate7[2];
            switch (_col7[2])
            {
                case 1:
                    pic73.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic73.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic73.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic73.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic73.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic73.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic73.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic73.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic73.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic73.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate7[3];
            switch (_col7[3])
            {
                case 1:
                    pic74.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic74.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic74.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic74.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic74.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic74.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic74.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic74.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic74.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic74.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate7[4];
            switch (_col7[4])
            {
                case 1:
                    pic75.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic75.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic75.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic75.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic75.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic75.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic75.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic75.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic75.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic75.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate7[5];
            switch (_col7[5])
            {
                case 1:
                    pic76.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic76.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic76.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic76.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic76.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic76.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic76.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic76.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic76.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic76.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate7[6];
            switch (_col7[6])
            {
                case 1:
                    pic77.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic77.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic77.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic77.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic77.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic77.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic77.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic77.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic77.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic77.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate7[7];
            switch (_col7[7])
            {
                case 1:
                    pic78.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic78.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic78.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic78.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic78.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic78.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic78.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic78.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic78.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic78.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

            //col8 now
            nRotate = _rotate8[0];
            switch (_col8[0])
            {
                case 1:
                    pic81.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic81.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic81.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic81.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic81.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic81.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic81.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic81.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic81.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic81.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate8[1];
            switch (_col8[1])
            {
                case 1:
                    pic82.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic82.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic82.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic82.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic82.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic82.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic82.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic82.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic82.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic82.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate8[2];
            switch (_col8[2])
            {
                case 1:
                    pic83.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic83.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic83.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic83.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic83.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic83.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic83.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic83.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic83.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic83.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate8[3];
            switch (_col8[3])
            {
                case 1:
                    pic84.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic84.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic84.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic84.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic84.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic84.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic84.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic84.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic84.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic84.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate8[4];
            switch (_col8[4])
            {
                case 1:
                    pic85.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic85.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic85.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic85.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic85.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic85.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic85.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic85.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic85.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic85.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate8[5];
            switch (_col8[5])
            {
                case 1:
                    pic86.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic86.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic86.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic86.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic86.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic86.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic86.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic86.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic86.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic86.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate8[6];
            switch (_col8[6])
            {
                case 1:
                    pic87.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic87.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic87.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic87.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic87.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic87.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic87.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic87.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic87.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic87.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
            nRotate = _rotate8[7];
            switch (_col8[7])
            {
                case 1:
                    pic88.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic88.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic88.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic88.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic88.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic88.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic88.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic88.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic88.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic88.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }



        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            mnAdd = 1;
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            mnAdd = 2;
        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            mnAdd = 3;
        }

        private void pic11_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col1[0] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate1[0] = rnd1.Next(1,4);
                    break;
                default:
                    _col1[0] = 1;
                    _rotate1[0] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate1[0];
            switch (_col1[0])
            {
                case 1:
                    pic11.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic11.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic11.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic11.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic11.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic11.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic11.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic11.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic11.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic11.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic12_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col1[1] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate1[1] = rnd1.Next(1, 4);
                    break;
                default:
                    _col1[1] = 1;
                    _rotate1[1] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate1[1];
            switch (_col1[1])
            {
                case 1:
                    pic12.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic12.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic12.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic12.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic12.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic12.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic12.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic12.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic12.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic12.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic13_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col1[2] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate1[2] = rnd1.Next(1, 4);
                    break;
                default:
                    _col1[2] = 1;
                    _rotate1[2] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate1[2];
            switch (_col1[2])
            {
                case 1:
                    pic13.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic13.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic13.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic13.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic13.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic13.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic13.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic13.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic13.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic13.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic14_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col1[3] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate1[3] = rnd1.Next(1, 4);
                    break;
                default:
                    _col1[3] = 1;
                    _rotate1[3] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate1[3];
            switch (_col1[3])
            {
                case 1:
                    pic14.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic14.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic14.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic14.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic14.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic14.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic14.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic14.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic14.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic14.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic15_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col1[4] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate1[4] = rnd1.Next(1, 4);
                    break;
                default:
                    _col1[4] = 1;
                    _rotate1[4] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate1[4];
            switch (_col1[4])
            {
                case 1:
                    pic15.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic15.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic15.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic15.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic15.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic15.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic15.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic15.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic15.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic15.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic16_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col1[5] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate1[5] = rnd1.Next(1, 4);
                    break;
                default:
                    _col1[5] = 1;
                    _rotate1[5] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate1[5];
            switch (_col1[5])
            {
                case 1:
                    pic16.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic16.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic16.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic16.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic16.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic16.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic16.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic16.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic16.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic16.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic17_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col1[6] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate1[6] = rnd1.Next(1, 4);
                    break;
                default:
                    _col1[6] = 1;
                    _rotate1[6] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate1[6];
            switch (_col1[6])
            {
                case 1:
                    pic17.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic17.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic17.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic17.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic17.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic17.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic17.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic17.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic17.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic17.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic18_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col1[7] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate1[7] = rnd1.Next(1, 4);
                    break;
                default:
                    _col1[7] = 1;
                    _rotate1[7] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate1[7];
            switch (_col1[7])
            {
                case 1:
                    pic18.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic18.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic18.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic18.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic18.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic18.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic18.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic18.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic18.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic18.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic21_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col2[0] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate2[0] = rnd1.Next(1, 4);
                    break;
                default:
                    _col2[0] = 1;
                    _rotate2[0] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate2[0];
            switch (_col2[0])
            {
                case 1:
                    pic21.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic21.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic21.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic21.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic21.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic21.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic21.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic21.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic21.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic21.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic22_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col2[1] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate2[1] = rnd1.Next(1, 4);
                    break;
                default:
                    _col2[1] = 1;
                    _rotate2[1] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate2[1];
            switch (_col2[1])
            {
                case 1:
                    pic22.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic22.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic22.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic22.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic22.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic22.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic22.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic22.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic22.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic22.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic23_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col2[2] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate2[2] = rnd1.Next(1, 4);
                    break;
                default:
                    _col2[2] = 1;
                    _rotate2[2] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate2[2];
            switch (_col2[2])
            {
                case 1:
                    pic23.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic23.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic23.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic23.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic23.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic23.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic23.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic23.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic23.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic23.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic24_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col2[3] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate2[3] = rnd1.Next(1, 4);
                    break;
                default:
                    _col2[3] = 1;
                    _rotate2[3] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate2[3];
            switch (_col2[3])
            {
                case 1:
                    pic24.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic24.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic24.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic24.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic24.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic24.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic24.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic24.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic24.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic24.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic25_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col2[4] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate2[4] = rnd1.Next(1, 4);
                    break;
                default:
                    _col2[4] = 1;
                    _rotate2[4] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate2[4];
            switch (_col2[4])
            {
                case 1:
                    pic25.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic25.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic25.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic25.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic25.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic25.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic25.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic25.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic25.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic25.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic26_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col2[5] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate2[5] = rnd1.Next(1, 4);
                    break;
                default:
                    _col2[5] = 1;
                    _rotate2[5] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate2[5];
            switch (_col2[5])
            {
                case 1:
                    pic26.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic26.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic26.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic26.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic26.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic26.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic26.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic26.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic26.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic26.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic27_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col2[6] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate2[6] = rnd1.Next(1, 4);
                    break;
                default:
                    _col2[6] = 1;
                    _rotate2[6] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate2[6];
            switch (_col2[6])
            {
                case 1:
                    pic27.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic27.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic27.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic27.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic27.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic27.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic27.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic27.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic27.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic27.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic28_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col2[7] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate2[7] = rnd1.Next(1, 4);
                    break;
                default:
                    _col2[7] = 1;
                    _rotate2[7] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate2[7];
            switch (_col2[7])
            {
                case 1:
                    pic28.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic28.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic28.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic28.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic28.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic28.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic28.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic28.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic28.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic28.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic31_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col3[0] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate3[0] = rnd1.Next(1, 4);
                    break;
                default:
                    _col3[0] = 1;
                    _rotate3[0] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate3[0];
            switch (_col3[0])
            {
                case 1:
                    pic31.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic31.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic31.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic31.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic31.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic31.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic31.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic31.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic31.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic31.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic32_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col3[1] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate3[1] = rnd1.Next(1, 4);
                    break;
                default:
                    _col3[1] = 1;
                    _rotate3[1] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate3[1];
            switch (_col3[1])
            {
                case 1:
                    pic32.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic32.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic32.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic32.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic32.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic32.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic32.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic32.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic32.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic32.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

        }

        private void pic33_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col3[2] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate3[2] = rnd1.Next(1, 4);
                    break;
                default:
                    _col3[2] = 1;
                    _rotate3[2] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate3[2];
            switch (_col3[2])
            {
                case 1:
                    pic33.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic33.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic33.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic33.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic33.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic33.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic33.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic33.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic33.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic33.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

        }

        private void pic34_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col3[3] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate3[3] = rnd1.Next(1, 4);
                    break;
                default:
                    _col3[3] = 1;
                    _rotate3[3] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate3[3];
            switch (_col3[3])
            {
                case 1:
                    pic34.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic34.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic34.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic34.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic34.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic34.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic34.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic34.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic34.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic34.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

        }

        private void pic35_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col3[4] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate3[4] = rnd1.Next(1, 4);
                    break;
                default:
                    _col3[4] = 1;
                    _rotate3[4] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate3[4];
            switch (_col3[4])
            {
                case 1:
                    pic35.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic35.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic35.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic35.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic35.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic35.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic35.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic35.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic35.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic35.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

        }

        private void pic36_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col3[5] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate3[5] = rnd1.Next(1, 4);
                    break;
                default:
                    _col3[5] = 1;
                    _rotate3[5] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate3[5];
            switch (_col3[5])
            {
                case 1:
                    pic36.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic36.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic36.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic36.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic36.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic36.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic36.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic36.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic36.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic36.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

        }

        private void pic37_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col3[6] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate3[6] = rnd1.Next(1, 4);
                    break;
                default:
                    _col3[6] = 1;
                    _rotate3[6] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate3[6];
            switch (_col3[6])
            {
                case 1:
                    pic37.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic37.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic37.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic37.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic37.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic37.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic37.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic37.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic37.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic37.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

        }

        private void pic38_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col3[7] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate3[7] = rnd1.Next(1, 4);
                    break;
                default:
                    _col3[7] = 1;
                    _rotate3[7] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate3[7];
            switch (_col3[7])
            {
                case 1:
                    pic38.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic38.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic38.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic38.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic38.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic38.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic38.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic38.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic38.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic38.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

        }

        private void pic41_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col4[0] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate4[0] = rnd1.Next(1, 4);
                    break;
                default:
                    _col4[0] = 1;
                    _rotate4[0] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate4[0];
            switch (_col4[0])
            {
                case 1:
                    pic41.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic41.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic41.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic41.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic41.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic41.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic41.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic41.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic41.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic41.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

        }

        private void pic42_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col4[1] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate4[1] = rnd1.Next(1, 4);
                    break;
                default:
                    _col4[1] = 1;
                    _rotate4[1] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate4[1];
            switch (_col4[1])
            {
                case 1:
                    pic42.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic42.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic42.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic42.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic42.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic42.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic42.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic42.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic42.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic42.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

        }

        private void pic43_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col4[2] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate4[2] = rnd1.Next(1, 4);
                    break;
                default:
                    _col4[2] = 1;
                    _rotate4[2] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate4[2];
            switch (_col4[2])
            {
                case 1:
                    pic43.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic43.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic43.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic43.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic43.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic43.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic43.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic43.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic43.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic43.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

        }

        private void pic44_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col4[3] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate4[3] = rnd1.Next(1, 4);
                    break;
                default:
                    _col4[3] = 1;
                    _rotate4[3] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate4[3];
            switch (_col4[3])
            {
                case 1:
                    pic44.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic44.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic44.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic44.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic44.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic44.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic44.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic44.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic44.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic44.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

        }

        private void pic45_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col4[4] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate4[4] = rnd1.Next(1, 4);
                    break;
                default:
                    _col4[4] = 1;
                    _rotate4[4] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate4[4];
            switch (_col4[4])
            {
                case 1:
                    pic45.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic45.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic45.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic45.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic45.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic45.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic45.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic45.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic45.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic45.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

        }

        private void pic46_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col4[5] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate4[5] = rnd1.Next(1, 4);
                    break;
                default:
                    _col4[5] = 1;
                    _rotate4[5] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate4[5];
            switch (_col4[5])
            {
                case 1:
                    pic46.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic46.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic46.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic46.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic46.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic46.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic46.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic46.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic46.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic46.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

        }

        private void pic47_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col4[6] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate4[6] = rnd1.Next(1, 4);
                    break;
                default:
                    _col4[6] = 1;
                    _rotate4[6] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate4[6];
            switch (_col4[6])
            {
                case 1:
                    pic47.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic47.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic47.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic47.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic47.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic47.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic47.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic47.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic47.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic47.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

        }

        private void pic48_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col4[7] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate4[7] = rnd1.Next(1, 4);
                    break;
                default:
                    _col4[7] = 1;
                    _rotate4[7] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate4[7];
            switch (_col4[7])
            {
                case 1:
                    pic48.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic48.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic48.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic48.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic48.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic48.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic48.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic48.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic48.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic48.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

        }

        private void pic51_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col5[0] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate5[0] = rnd1.Next(1, 4);
                    break;
                default:
                    _col5[0] = 1;
                    _rotate5[0] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate5[0];
            switch (_col5[0])
            {
                case 1:
                    pic51.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic51.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic51.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic51.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic51.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic51.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic51.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic51.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic51.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic51.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

        }

        private void pic52_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col5[1] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate5[1] = rnd1.Next(1, 4);
                    break;
                default:
                    _col5[1] = 1;
                    _rotate5[1] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate5[1];
            switch (_col5[1])
            {
                case 1:
                    pic52.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic52.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic52.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic52.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic52.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic52.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic52.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic52.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic52.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic52.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

        }

        private void pic53_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col5[2] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate5[2] = rnd1.Next(1, 4);
                    break;
                default:
                    _col5[2] = 1;
                    _rotate5[2] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate5[2];
            switch (_col5[2])
            {
                case 1:
                    pic53.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic53.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic53.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic53.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic53.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic53.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic53.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic53.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic53.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic53.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

        }

        private void pic54_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col5[3] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate5[3] = rnd1.Next(1, 4);
                    break;
                default:
                    _col5[3] = 1;
                    _rotate5[3] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate5[3];
            switch (_col5[3])
            {
                case 1:
                    pic54.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic54.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic54.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic54.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic54.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic54.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic54.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic54.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic54.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic54.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

        }

        private void pic55_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col5[4] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate5[4] = rnd1.Next(1, 4);
                    break;
                default:
                    _col5[4] = 1;
                    _rotate5[4] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate5[4];
            switch (_col5[4])
            {
                case 1:
                    pic55.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic55.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic55.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic55.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic55.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic55.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic55.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic55.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic55.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic55.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

        }

        private void pic56_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col5[5] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate5[5] = rnd1.Next(1, 4);
                    break;
                default:
                    _col5[5] = 1;
                    _rotate5[5] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate5[5];
            switch (_col5[5])
            {
                case 1:
                    pic56.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic56.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic56.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic56.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic56.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic56.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic56.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic56.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic56.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic56.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

        }

        private void pic57_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col5[6] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate5[6] = rnd1.Next(1, 4);
                    break;
                default:
                    _col5[6] = 1;
                    _rotate5[6] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate5[6];
            switch (_col5[6])
            {
                case 1:
                    pic57.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic57.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic57.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic57.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic57.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic57.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic57.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic57.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic57.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic57.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

        }

        private void pic58_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col5[7] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate5[7] = rnd1.Next(1, 4);
                    break;
                default:
                    _col5[7] = 1;
                    _rotate5[7] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate5[7];
            switch (_col5[7])
            {
                case 1:
                    pic58.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic58.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic58.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic58.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic58.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic58.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic58.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic58.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic58.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic58.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

        }

        private void pic61_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col6[0] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate6[0] = rnd1.Next(1, 4);
                    break;
                default:
                    _col6[0] = 1;
                    _rotate6[0] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate6[0];
            switch (_col6[0])
            {
                case 1:
                    pic61.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic61.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic61.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic61.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic61.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic61.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic61.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic61.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic61.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic61.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }

        }

        private void pic62_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col6[1] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate6[1] = rnd1.Next(1, 4);
                    break;
                default:
                    _col6[1] = 1;
                    _rotate6[1] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate6[1];
            switch (_col6[1])
            {
                case 1:
                    pic62.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic62.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic62.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic62.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic62.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic62.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic62.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic62.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic62.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic62.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic63_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col6[2] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate6[2] = rnd1.Next(1, 4);
                    break;
                default:
                    _col6[2] = 1;
                    _rotate6[2] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate6[2];
            switch (_col6[2])
            {
                case 1:
                    pic63.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic63.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic63.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic63.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic63.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic63.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic63.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic63.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic63.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic63.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic64_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col6[3] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate6[3] = rnd1.Next(1, 4);
                    break;
                default:
                    _col6[3] = 1;
                    _rotate6[3] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate6[3];
            switch (_col6[3])
            {
                case 1:
                    pic64.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic64.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic64.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic64.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic64.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic64.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic64.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic64.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic64.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic64.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic65_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col6[4] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate6[4] = rnd1.Next(1, 4);
                    break;
                default:
                    _col6[4] = 1;
                    _rotate6[4] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate6[4];
            switch (_col6[4])
            {
                case 1:
                    pic65.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic65.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic65.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic65.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic65.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic65.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic65.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic65.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic65.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic65.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic66_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col6[5] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate6[5] = rnd1.Next(1, 4);
                    break;
                default:
                    _col6[5] = 1;
                    _rotate6[5] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate6[5];
            switch (_col6[5])
            {
                case 1:
                    pic66.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic66.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic66.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic66.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic66.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic66.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic66.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic66.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic66.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic66.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic67_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col6[6] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate6[6] = rnd1.Next(1, 4);
                    break;
                default:
                    _col6[6] = 1;
                    _rotate6[6] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate6[6];
            switch (_col6[6])
            {
                case 1:
                    pic67.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic67.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic67.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic67.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic67.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic67.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic67.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic67.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic67.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic67.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic68_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col6[7] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate6[7] = rnd1.Next(1, 4);
                    break;
                default:
                    _col6[7] = 1;
                    _rotate6[7] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate6[7];
            switch (_col6[7])
            {
                case 1:
                    pic68.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic68.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic68.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic68.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic68.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic68.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic68.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic68.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic68.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic68.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic71_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col7[0] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate7[0] = rnd1.Next(1, 4);
                    break;
                default:
                    _col7[0] = 1;
                    _rotate7[0] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate7[0];
            switch (_col7[0])
            {
                case 1:
                    pic71.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic71.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic71.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic71.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic71.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic71.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic71.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic71.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic71.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic71.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic72_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col7[1] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate7[1] = rnd1.Next(1, 4);
                    break;
                default:
                    _col7[1] = 1;
                    _rotate7[1] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate7[1];
            switch (_col7[1])
            {
                case 1:
                    pic72.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic72.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic72.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic72.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic72.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic72.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic72.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic72.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic72.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic72.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic73_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col7[2] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate7[2] = rnd1.Next(1, 4);
                    break;
                default:
                    _col7[2] = 1;
                    _rotate7[2] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate7[2];
            switch (_col7[2])
            {
                case 1:
                    pic73.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic73.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic73.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic73.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic73.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic73.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic73.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic73.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic73.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic73.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic74_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col7[3] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate7[3] = rnd1.Next(1, 4);
                    break;
                default:
                    _col7[3] = 1;
                    _rotate7[3] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate7[3];
            switch (_col7[3])
            {
                case 1:
                    pic74.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic74.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic74.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic74.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic74.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic74.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic74.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic74.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic74.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic74.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic75_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col7[4] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate7[4] = rnd1.Next(1, 4);
                    break;
                default:
                    _col7[4] = 1;
                    _rotate7[4] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate7[4];
            switch (_col7[4])
            {
                case 1:
                    pic75.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic75.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic75.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic75.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic75.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic75.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic75.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic75.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic75.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic75.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic76_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col7[5] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate7[5] = rnd1.Next(1, 4);
                    break;
                default:
                    _col7[5] = 1;
                    _rotate7[5] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate7[5];
            switch (_col7[5])
            {
                case 1:
                    pic76.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic76.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic76.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic76.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic76.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic76.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic76.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic76.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic76.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic76.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic77_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col7[6] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate7[6] = rnd1.Next(1, 4);
                    break;
                default:
                    _col7[6] = 1;
                    _rotate7[6] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate7[6];
            switch (_col7[6])
            {
                case 1:
                    pic77.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic77.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic77.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic77.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic77.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic77.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic77.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic77.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic77.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic77.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic78_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col7[7] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate7[7] = rnd1.Next(1, 4);
                    break;
                default:
                    _col7[7] = 1;
                    _rotate7[7] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate7[7];
            switch (_col7[7])
            {
                case 1:
                    pic78.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic78.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic78.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic78.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic78.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic78.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic78.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic78.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic78.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic78.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic81_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col8[0] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate8[0] = rnd1.Next(1, 4);
                    break;
                default:
                    _col8[0] = 1;
                    _rotate8[0] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate8[0];
            switch (_col8[0])
            {
                case 1:
                    pic81.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic81.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic81.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic81.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic81.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic81.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic81.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic81.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic81.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic81.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic82_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col8[1] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate8[1] = rnd1.Next(1, 4);
                    break;
                default:
                    _col8[1] = 1;
                    _rotate8[1] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate8[1];
            switch (_col8[1])
            {
                case 1:
                    pic82.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic82.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic82.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic82.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic82.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic82.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic82.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic82.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic82.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic82.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic83_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col8[2] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate8[2] = rnd1.Next(1, 4);
                    break;
                default:
                    _col8[2] = 1;
                    _rotate8[2] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate8[2];
            switch (_col8[2])
            {
                case 1:
                    pic83.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic83.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic83.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic83.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic83.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic83.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic83.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic83.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic83.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic83.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic84_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col8[3] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate8[3] = rnd1.Next(1, 4);
                    break;
                default:
                    _col8[3] = 1;
                    _rotate8[3] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate8[3];
            switch (_col8[3])
            {
                case 1:
                    pic84.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic84.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic84.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic84.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic84.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic84.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic84.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic84.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic84.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic84.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic85_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col8[4] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate8[4] = rnd1.Next(1, 4);
                    break;
                default:
                    _col8[4] = 1;
                    _rotate8[4] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate8[4];
            switch (_col8[4])
            {
                case 1:
                    pic85.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic85.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic85.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic85.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic85.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic85.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic85.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic85.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic85.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic85.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic86_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col8[5] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate8[5] = rnd1.Next(1, 4);
                    break;
                default:
                    _col8[5] = 1;
                    _rotate8[5] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate8[5];
            switch (_col8[5])
            {
                case 1:
                    pic86.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic86.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic86.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic86.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic86.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic86.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic86.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic86.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic86.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic86.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic87_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col8[6] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate8[6] = rnd1.Next(1, 4);
                    break;
                default:
                    _col8[6] = 1;
                    _rotate8[6] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate8[6];
            switch (_col8[6])
            {
                case 1:
                    pic87.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic87.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic87.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic87.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic87.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic87.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic87.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic87.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic87.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic87.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }

        private void pic88_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nRotate;

            switch (mnAdd)
            {
                case 1:
                    _col8[7] = rnd1.Next(2, 5);
                    break;
                case 2:
                    _rotate8[7] = rnd1.Next(1, 4);
                    break;
                default:
                    _col8[7] = 1;
                    _rotate8[7] = 1;
                    break;
            }

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F dome.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F juggle1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F juggle2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F juggle3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            nRotate = _rotate8[7];
            switch (_col8[7])
            {
                case 1:
                    pic88.Image = picture1.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic88.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 2:
                    pic88.Image = picture2.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic88.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 3:
                    pic88.Image = picture3.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic88.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 4:
                    pic88.Image = picture4.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic88.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
                case 5:
                    pic88.Image = picture5.Image;
                    for (int i = 1; i <= nRotate - 1; i++)
                    {
                        pic88.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    break;
            }
        }
    }
}

