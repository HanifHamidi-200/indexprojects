using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarsTrainline
{
    public partial class Form1 : Form
    {
        private static List<int> _value = new List<int> { 0, 0, 0, 0 };

        private void fUpdateDisplay()
        {
            btn11.ForeColor = Color.Black;
            btn12.ForeColor = Color.Black;
            btn13.ForeColor = Color.Black;
            btn21.ForeColor = Color.Black;
            btn22.ForeColor = Color.Black;
            btn23.ForeColor = Color.Black;
            btn31.ForeColor = Color.Black;
            btn32.ForeColor = Color.Black;
            btn33.ForeColor = Color.Black;
            btn41.ForeColor = Color.Black;
            btn42.ForeColor = Color.Black;
            btn43.ForeColor = Color.Black;
            btn44.ForeColor = Color.Black;

            switch (_value[0])
            {
                case 1:
                    btn11.ForeColor = Color.Red;
                    break;
                case 2:
                    btn12.ForeColor = Color.Red;
                    break;
                default:
                    btn13.ForeColor = Color.Red;
                    break;
            }
            switch (_value[1])
            {
                case 1:
                    btn21.ForeColor = Color.Red;
                    break;
                case 2:
                    btn22.ForeColor = Color.Red;
                    break;
                default:
                    btn23.ForeColor = Color.Red;
                    break;
            }
            switch (_value[2])
            {
                case 1:
                    btn31.ForeColor = Color.Red;
                    break;
                case 2:
                    btn32.ForeColor = Color.Red;
                    break;
                default:
                    btn33.ForeColor = Color.Red;
                    break;
            }
            switch (_value[3])
            {
                case 1:
                    btn41.ForeColor = Color.Red;
                    break;
                case 2:
                    btn42.ForeColor = Color.Red;
                    break;
                case 3:
                    btn43.ForeColor = Color.Red;
                    break;
                default:
                    btn44.ForeColor = Color.Red;
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

            _value[0] = rnd1.Next(1, 4);
            _value[1] = rnd1.Next(1, 4);
            _value[2] = rnd1.Next(1, 4);
            _value[3] = rnd1.Next(1, 5);

            fUpdateDisplay();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();

            _value[0] = rnd1.Next(1, 4);
            _value[1] = rnd1.Next(1, 4);
            _value[2] = rnd1.Next(1, 4);
            _value[3] = rnd1.Next(1, 5);

            fUpdateDisplay();

        }

        private void btn11_Click(object sender, EventArgs e)
        {
            _value[0] = 1;
            fUpdateDisplay();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            _value[0] = 2;
            fUpdateDisplay();

        }

        private void btn13_Click(object sender, EventArgs e)
        {
            _value[0] = 3;
            fUpdateDisplay();

        }

        private void btn21_Click(object sender, EventArgs e)
        {
            _value[1] = 1;
            fUpdateDisplay();

        }

        private void btn22_Click(object sender, EventArgs e)
        {
            _value[1] = 2;
            fUpdateDisplay();

        }

        private void btn23_Click(object sender, EventArgs e)
        {
            _value[1] = 3;
            fUpdateDisplay();

        }

        private void btn31_Click(object sender, EventArgs e)
        {
            _value[2] = 1;
            fUpdateDisplay();

        }

        private void btn32_Click(object sender, EventArgs e)
        {
            _value[2] = 2;
            fUpdateDisplay();

        }

        private void btn33_Click(object sender, EventArgs e)
        {
            _value[2] = 3;
            fUpdateDisplay();

        }

        private void btn41_Click(object sender, EventArgs e)
        {
            _value[3] = 1;
            fUpdateDisplay();

        }

        private void btn42_Click(object sender, EventArgs e)
        {
            _value[3] = 2;
            fUpdateDisplay();

        }

        private void btn43_Click(object sender, EventArgs e)
        {
            _value[3] = 3;
            fUpdateDisplay();

        }

        private void btn44_Click(object sender, EventArgs e)
        {
            _value[3] = 4;
            fUpdateDisplay();

        }
    }
}
