using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LevelsIndicater
{
    public partial class fSub1 : Form
    {
        private List<int> _colour = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _value = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _matchups = new List<int> { 0, 0, 0, 0, 0 };
        private List<int> _total = new List<int> { 0, 0, 0, 0, 0 };
        private List<String> _text1 = new List<String> { "RED", "BLUE", "PURPLE", "GREEN", "GREY" };
        private List<String> _text2 = new List<String> { "NULLGATE","castle", "computers", "greens", "park", "soils" };
        private int mnMatchup, mnMatchup2;
        private int mnItem,mnLevel;


        private void fTotal()
        {
            int nTotal;

            for (int i = 1; i <= 5; i++)
            {
                nTotal = 0;
                for (int j = 1; j <= 8; j++)
                {
                    if (_colour[j - 1] == i)
                    {
                        nTotal += _value[j - 1];
                    }
                }
                _total[i - 1] = nTotal;
            }
        }
        private void fChange()
        {
            int nItem = mnMatchup;

            _matchups[nItem - 1] = mnMatchup2;
            fUpdateDisplay2();
        }
        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F type1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F type2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F type3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F type4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F type5.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            switch (nValue)
            {
                case 1:
                    _pic2 = picture1;
                    break;
                case 2:
                    _pic2 = picture2;
                    break;
                case 3:
                    _pic2 = picture3;
                    break;
                case 4:
                    _pic2 = picture4;
                    break;
                case 5:
                    _pic2 = picture5;
                    break;
                default:
                    _pic2 = picture6;
                    break;
            }
            for (int i = 1; i <= nRotate - 1; i++)
            {
                _pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

        }

        private void fReset()
        {
            Random rnd1 = new Random();

            mnItem = 1;
            mnLevel = rnd1.Next(2000, 20001);
            for (int i = 1; i <= 8; i++)
            {
                _colour[i - 1] = rnd1.Next(1, 6);
                _value[i - 1] = rnd1.Next(20, 2001);
            }

            for (int i = 1; i <= 5; i++)
            {
                _matchups[i - 1] = 1;
            }
            fTotal();
        }

        private void fUpdateDisplay2()
        {
            String sText = null;

            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }

            for (int i = 1; i <= 5; i++)
            {
                sText ="["+Convert.ToString(_total[i-1])+"] "+ _text1[i - 1] + " with " + _text2[_matchups[i - 1] - 1];
                lst1.Items.Add(sText);
            }
        }
        private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate;

            btnLevelsIndicater.Text = "LevelsIndicater = " + Convert.ToString(mnLevel);
            nRotate = 1;

            nType = _colour[0];
            fPeek(nType, nRotate, ref _pic);
            pic1.Image = _pic.Image;
            nType = _colour[1];
            fPeek(nType, nRotate, ref _pic);
            pic2.Image = _pic.Image;
            nType = _colour[2];
            fPeek(nType, nRotate, ref _pic);
            pic3.Image = _pic.Image;
            nType = _colour[3];
            fPeek(nType, nRotate, ref _pic);
            pic4.Image = _pic.Image;
            nType = _colour[4];
            fPeek(nType, nRotate, ref _pic);
            pic5.Image = _pic.Image;
            nType = _colour[5];
            fPeek(nType, nRotate, ref _pic);
            pic6.Image = _pic.Image;
            nType = _colour[6];
            fPeek(nType, nRotate, ref _pic);
            pic7.Image = _pic.Image;
            nType = _colour[7];
            fPeek(nType, nRotate, ref _pic);
            pic8.Image = _pic.Image;
        }
        
        private void fClick(int nMode)
        {
            String sText = "Amount = " + Convert.ToString(_value[nMode - 1]);

            MessageBox.Show(sText, "Pile" + Convert.ToString(nMode));
        }

        public fSub1()
        {
            InitializeComponent();
            mnMatchup = 0;
            mnMatchup2 = 1;
        }

        private void fSub1_Load(object sender, EventArgs e)
        {
            fReset();
            fUpdateDisplay();
            fUpdateDisplay2();
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            fClick(1);
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            fClick(2);

        }

        private void pic3_Click(object sender, EventArgs e)
        {
            fClick(3);

        }

        private void pic4_Click(object sender, EventArgs e)
        {
            fClick(4);

        }

        private void pic5_Click(object sender, EventArgs e)
        {
            fClick(5);

        }

        private void pic6_Click(object sender, EventArgs e)
        {
            fClick(6);

        }

        private void pic7_Click(object sender, EventArgs e)
        {
            fClick(7);

        }

        private void pic8_Click(object sender, EventArgs e)
        {
            fClick(8);

        }

        private void btnMatchup1_Click(object sender, EventArgs e)
        {
            mnMatchup2 = 1;
        }

        private void btnMatchup2_Click(object sender, EventArgs e)
        {
            mnMatchup2 = 2;

        }

        private void btnMatchup3_Click(object sender, EventArgs e)
        {
            mnMatchup2 =3;

        }

        private void btnMatchup4_Click(object sender, EventArgs e)
        {
            mnMatchup2 = 4;

        }

        private void btnMatchup5_Click(object sender, EventArgs e)
        {
            mnMatchup2 = 5;

        }

        private void btnMatchup6_Click(object sender, EventArgs e)
        {
            mnMatchup2 = 6;

        }

        private void lst1_Click(object sender, EventArgs e)
        {
            mnMatchup = lst1.SelectedIndex + 1;
            fChange();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
            fUpdateDisplay();
            fUpdateDisplay2();
        }
    }
}
