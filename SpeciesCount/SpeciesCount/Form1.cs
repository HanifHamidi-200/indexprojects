using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeciesCount
{
    public partial class Form1 : Form
    {
        private static List<String> _title = new List<String> {"cars","tools and equipment","animals","colours" };
        private static List<int> _length = new List<int> { 200,600,60,24};
        private static List<int> _cost = new List<int> { 1200,500,200,80 };
        private static List<String> _comments1 = new List<String> {null,null,null,null,null, null, null, null, null, null };
        private static List<String> _comments2 = new List<String> { null, null, null, null, null, null, null, null, null, null };
        private static List<String> _comments3 = new List<String> { null, null, null, null, null, null, null, null, null, null };
        private static List<String> _comments4 = new List<String> { null, null, null, null, null, null, null, null, null, null };
        private static List<int> _count = new List<int> { 0, 0, 0, 0 };
        private int mnItem;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            mnItem = rnd1.Next(1, 5);

            fraView.Text = _title[mnItem - 1];
            lblLength.Text = Convert.ToString(_length[mnItem - 1]);
            lblCost.Text = Convert.ToString(_cost[mnItem - 1]);

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F pic1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F pic2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F pic3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F pic4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            switch (mnItem)
            {
                case 1:
                    picView.Image = picture1.Image;
                    break;
                case 2:
                    picView.Image = picture2.Image;
                    break;
                case 3:
                    picView.Image = picture3.Image;
                    break;
                default:
                    picView.Image = picture4.Image;
                    break;
            }

            if (lstComments.Items.Count > 0)
            {
                do
                {
                    lstComments.Items.RemoveAt(0);
                } while (lstComments.Items.Count > 0);
            }

            for (int i = 1; i <= _count[mnItem - 1]; i++)
            {
                switch (mnItem)
                {
                    case 1:
                        lstComments.Items.Add(_comments1[i - 1]);
                        break;
                    case 2:
                        lstComments.Items.Add(_comments2[i - 1]);
                        break;
                    case 3:
                        lstComments.Items.Add(_comments3[i - 1]);
                        break;
                    default:
                        lstComments.Items.Add(_comments4[i - 1]);
                        break;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstComments.Items.Add(txtComments.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (lstComments.Items.Count > 0)
            {
                do
                {
                    lstComments.Items.RemoveAt(0);
                } while (lstComments.Items.Count > 0);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            mnItem = 1;

            fraView.Text = _title[mnItem - 1];
            lblLength.Text = Convert.ToString(_length[mnItem - 1]);
            lblCost.Text = Convert.ToString(_cost[mnItem - 1]);

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F pic1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F pic2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F pic3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F pic4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            picView.Image = picture1.Image;
            if (lstComments.Items.Count > 0)
            {
                do
                {
                    lstComments.Items.RemoveAt(0);
                } while (lstComments.Items.Count > 0);
            }

            for (int i = 1; i <= _count[mnItem - 1]; i++)
            {
                switch (mnItem)
                {
                    case 1:
                        lstComments.Items.Add(_comments1[i - 1]);
                        break;
                    case 2:
                        lstComments.Items.Add(_comments2[i - 1]);
                        break;
                    case 3:
                        lstComments.Items.Add(_comments3[i - 1]);
                        break;
                    default:
                        lstComments.Items.Add(_comments4[i - 1]);
                        break;
                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            mnItem = 2;

            fraView.Text = _title[mnItem - 1];
            lblLength.Text = Convert.ToString(_length[mnItem - 1]);
            lblCost.Text = Convert.ToString(_cost[mnItem - 1]);

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F pic1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F pic2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F pic3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F pic4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            picView.Image = picture2.Image;
            if (lstComments.Items.Count > 0)
            {
                do
                {
                    lstComments.Items.RemoveAt(0);
                } while (lstComments.Items.Count > 0);
            }

            for (int i = 1; i <= _count[mnItem - 1]; i++)
            {
                switch (mnItem)
                {
                    case 1:
                        lstComments.Items.Add(_comments1[i - 1]);
                        break;
                    case 2:
                        lstComments.Items.Add(_comments2[i - 1]);
                        break;
                    case 3:
                        lstComments.Items.Add(_comments3[i - 1]);
                        break;
                    default:
                        lstComments.Items.Add(_comments4[i - 1]);
                        break;
                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            mnItem = 3;

            fraView.Text = _title[mnItem - 1];
            lblLength.Text = Convert.ToString(_length[mnItem - 1]);
            lblCost.Text = Convert.ToString(_cost[mnItem - 1]);

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F pic1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F pic2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F pic3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F pic4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            picView.Image = picture3.Image;
            if (lstComments.Items.Count > 0)
            {
                do
                {
                    lstComments.Items.RemoveAt(0);
                } while (lstComments.Items.Count > 0);
            }

            for (int i = 1; i <= _count[mnItem - 1]; i++)
            {
                switch (mnItem)
                {
                    case 1:
                        lstComments.Items.Add(_comments1[i - 1]);
                        break;
                    case 2:
                        lstComments.Items.Add(_comments2[i - 1]);
                        break;
                    case 3:
                        lstComments.Items.Add(_comments3[i - 1]);
                        break;
                    default:
                        lstComments.Items.Add(_comments4[i - 1]);
                        break;
                }
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            mnItem = 4;

            fraView.Text = _title[mnItem - 1];
            lblLength.Text = Convert.ToString(_length[mnItem - 1]);
            lblCost.Text = Convert.ToString(_cost[mnItem - 1]);

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F pic1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F pic2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F pic3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F pic4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            picView.Image = picture4.Image;
            if (lstComments.Items.Count > 0)
            {
                do
                {
                    lstComments.Items.RemoveAt(0);
                } while (lstComments.Items.Count > 0);
            }

            for (int i = 1; i <= _count[mnItem - 1]; i++)
            {
                switch (mnItem)
                {
                    case 1:
                        lstComments.Items.Add(_comments1[i - 1]);
                        break;
                    case 2:
                        lstComments.Items.Add(_comments2[i - 1]);
                        break;
                    case 3:
                        lstComments.Items.Add(_comments3[i - 1]);
                        break;
                    default:
                        lstComments.Items.Add(_comments4[i - 1]);
                        break;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String sText = null;

            _count[mnItem - 1] = lstComments.Items.Count;
            for (int i = 1; i <= _count[mnItem - 1]; i++)
            {
                sText = (String)lstComments.Items[i - 1];
                switch (mnItem)
                {
                    case 1:
                        _comments1[i - 1] = sText;
                        break;
                    case 2:
                        _comments2[i - 1] = sText;
                        break;
                    case 3:
                        _comments3[i - 1] = sText;
                        break;
                    default:
                        _comments4[i - 1] = sText;
                        break;
                }
            }
        }
    }
}
