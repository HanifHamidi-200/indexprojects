using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimegapDifference
{
    public partial class Form1 : Form
    {
        private List<int> _numbers = new List<int> { 0, 0, 0, 0 };
        private List<String> _output = new List<string> { null, null, null, null };
        private int mnItem, mnCurrentValue;

        private void fReset()
        {
            Random rnd1 = new Random();

            for (int i = 1; i <= 4; i++)
            {
                _numbers[i-1] = 0;
            }
            _numbers[0] = rnd1.Next(1, 201);
            mnItem = 1;

            for (int i = 1; i <= 4; i++)
            {
                _output[i - 1] = null;
            }

            txt1.Text = null;
            txt2.Text = null;
            txt3.Text = null;
            txt4.Text = null;

        }

        private void fUpdateDisplay()
        {
            if (mnItem >= 1)
            {
                txt1.Text = Convert.ToString(_numbers[0]);
            }
            if (mnItem >= 2)
            {
                txt2.Text = Convert.ToString(_numbers[1]);
            }
            if (mnItem >= 3)
            {
                txt3.Text = Convert.ToString(_numbers[2]);
            }
            if (mnItem >= 4)
            { 
                txt4.Text = Convert.ToString(_numbers[3]);
            }

            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }
            
            if (_output[0] != null)
            {
                for (int i = 1; i <= 4; i++)
                {
                    lst1.Items.Add(_output[i - 1]);
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
            fUpdateDisplay();

        }

        private void btnKontrol1_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();

            if (mnItem == 1)
            {
                _numbers[0] = rnd1.Next(1, 201);
                fUpdateDisplay();
            }
        }

        private void btnKontrol2_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nAdd;

            if (mnItem == 1)
            {
                mnItem = 2;
                nAdd= rnd1.Next(1, 201);
                _numbers[1] =_numbers[0] + nAdd;
                fUpdateDisplay();
            }
            else
            {
                if (mnItem == 2)
                {
                    nAdd = rnd1.Next(1, 201);
                    _numbers[1] =_numbers[0]+nAdd;
                    fUpdateDisplay();

                }
            }

        }

        private void btnKontrol3_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nAdd;

            if (mnItem == 2)
            {
                mnItem = 3;
                nAdd = rnd1.Next(1, 201);
                _numbers[2] = _numbers[1] + nAdd;
                fUpdateDisplay();
            }
            else
            {
                if (mnItem == 3)
                {
                    nAdd = rnd1.Next(1, 201);
                    _numbers[2] = _numbers[1] + nAdd;
                    fUpdateDisplay();

                }
            }
        }

        private void btnKontrol4_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nAdd;

            if (mnItem == 3)
            {
                mnItem = 4;
                nAdd = rnd1.Next(1, 201);
                _numbers[3] = _numbers[2] + nAdd;
                fUpdateDisplay();
            }
            else
            {
                if (mnItem == 4)
                {
                    nAdd = rnd1.Next(1, 201);
                    _numbers[3] = _numbers[2] + nAdd;
                    fUpdateDisplay();

                }
            }
        }

        private void btnKontrol5_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            char sLetter1;
            char sLetter2;
            char sLetter3;
            String sText;

            if (mnItem == 4)
            {
                mnItem = 5;
                for (int i = 1; i <= 4; i++)
                {
                     sLetter1 = (char)(rnd1.Next(1, 27) + 64);
                     sLetter2 = (char)(rnd1.Next(1, 27) + 64);
                     sLetter3 = (char)(rnd1.Next(1, 27) + 64);
                     sText = sLetter1 + sLetter2 + sLetter3 + Convert.ToString(_numbers[3]);
                    _output[i - 1] = sText;

                }
                fUpdateDisplay();
              }
         }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
            fUpdateDisplay();
        }
    }
}
