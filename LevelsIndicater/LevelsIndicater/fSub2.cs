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
    public partial class fSub2 : Form
    {
        private List<String> _text1 = new List<string> { "RUSSIA", "UKRAINE", "UK", "USA", "FRANCE", "SWITZERLAND", "GERMANY", "EGYPT", "LIBYA", "TURKEY", "NORWAY", "SWEDEN", "FINLAND", "AUSTRALIA" };
        private List<String> _text2 = new List<string> { "fish", "computers", "salt", "perfume", "books", "magazines", "cars", "lorries", "windows", "sheds", "clothes" };
        private List<int> _slot = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _phase = new List<int> { 0, 0, 0 };
        private int mnProduct,mnPhase;
        
        private void fRecord()
        {
            String sText = null;

            sText = "BUY " + _text1[_phase[0] - 1] + "(" + _text2[_phase[1] - 1] + ") from(" + _text1[_phase[2] - 1] + ")";
            lst1.Items.Add(sText);
            sText = "SELL " + _text1[_phase[2] - 1] + "(" + _text2[_phase[1] - 1] + ") from(" + _text1[_phase[0] - 1] + ")";
            lst2.Items.Add(sText);
        }

        private void fPhase(int nItem)
        {
            switch (mnPhase)
            {
                case 1:
                    _phase[0] = _slot[nItem - 1];
                    break;
                case 2:
                    _phase[1] = mnProduct;
                    break;
                default:
                    _phase[2] = _slot[nItem - 1];
                    break;
            }

            if (mnPhase == 3)
            {
                fRecord();
                mnPhase = 1;
            }
            else
            {
                mnPhase += 1;

            }
        }

        private void fReset()
        {
            Random rnd1 = new Random();

            mnPhase = 1;

            for (int i = 1; i <= 8; i++)
            {
                _slot[i - 1] = rnd1.Next(1, 15);
            }
            mnProduct = rnd1.Next(1, 12);

            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }
            if (lst2.Items.Count > 0)
            {
                do
                {
                    lst2.Items.RemoveAt(0);
                } while (lst2.Items.Count > 0);
            }

            fUpdateDisplay();
        }

        private void fUpdateDisplay()
        {
            btn1.Text = _text1[_slot[0]-1];
            btn2.Text = _text1[_slot[1] - 1];
            btn3.Text = _text1[_slot[2] - 1];
            btn4.Text = _text1[_slot[3] - 1];
            btn5.Text = _text1[_slot[4] - 1];
            btn6.Text = _text1[_slot[5] - 1];
            btn7.Text = _text1[_slot[6] - 1];
            btn8.Text = _text1[_slot[7] - 1];
           btnMiddle.Text = _text2[mnProduct - 1];
        }
        public fSub2()
        {
            InitializeComponent();
        }

        private void fSub2_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            mnPhase = 1;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            fPhase(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            fPhase(2);

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            fPhase(3);

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            fPhase(4);

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            fPhase(5);

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            fPhase(6);

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            fPhase(7);

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            fPhase(8);

        }

        private void btnMiddle_Click(object sender, EventArgs e)
        {
            fPhase(0);

        }

        private void btnPNext_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();

            mnProduct = rnd1.Next(1, 12);
            btnMiddle.Text = _text2[mnProduct - 1];

        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
