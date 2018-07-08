using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolunteerToIntervene3157
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt1.Text = null;
            txt2.Text = null;
            txt3.Text = null;
            txt4.Text = null;
            txt5.Text = null;
            txt6.Text = null;

            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F m_chart.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F m_gun.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F m_negotiate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F m_ship.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            pic1.Image = picture1.Image;
            pic2.Image = picture2.Image;
            pic3.Image = picture3.Image;
            pic4.Image = picture4.Image;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pic1_Click(object sender, EventArgs e)
        {
            DialogResult sReply;

            sReply=dlg1.ShowDialog();
            if (sReply == DialogResult.OK)
            {
                PictureBox picture1 = new PictureBox
                {
                    Name = "pictureBox1",
                    Image = Image.FromFile(dlg1.FileName),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                pic1.Image = picture1.Image;
            }
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            DialogResult sReply;

            sReply = dlg1.ShowDialog();
            if (sReply == DialogResult.OK)
            {
                PictureBox picture1 = new PictureBox
                {
                    Name = "pictureBox1",
                    Image = Image.FromFile(dlg1.FileName),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                pic2.Image = picture1.Image;
            }

        }

        private void pic3_Click(object sender, EventArgs e)
        {
            DialogResult sReply;

            sReply = dlg1.ShowDialog();
            if (sReply == DialogResult.OK)
            {
                PictureBox picture1 = new PictureBox
                {
                    Name = "pictureBox1",
                    Image = Image.FromFile(dlg1.FileName),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                pic3.Image = picture1.Image;
            }

        }

        private void pic4_Click(object sender, EventArgs e)
        {
            DialogResult sReply;

            sReply = dlg1.ShowDialog();
            if (sReply == DialogResult.OK)
            {
                PictureBox picture1 = new PictureBox
                {
                    Name = "pictureBox1",
                    Image = Image.FromFile(dlg1.FileName),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                pic4.Image = picture1.Image;
            }

        }
    }
}
