using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicationSkiing
{
    public partial class Form2 : Form
    {
        private static List<String> _text = new List<String> { null, null, null, null, null, null,null,null };
        private int mnConfirm;

        private void fUpdateDisplay()
        {
            txt1.Text = _text[0];
            txt2.Text = _text[1];
            txt3.Text = _text[2];
            txt4.Text = _text[3];
            txt5.Text = _text[4];
            txt6.Text = _text[5];
            txt7.Text = _text[6];
            txt8.Text = _text[7];
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nValue;

            mnConfirm = 1;
            for (int i = 1; i <= 8; i++)
            {
                nValue = rnd1.Next(20, 201);
                _text[i - 1] = Convert.ToString(nValue);
            }

            fUpdateDisplay();
        }

        private void btnConfirm1_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nPos = rnd1.Next(1, 9);
            int nAdd = rnd1.Next(20, 201);
            int nNumber = Convert.ToInt32(_text[nPos - 1]) + nAdd;

            if (mnConfirm == 1)
            {
                DialogResult sReply = MessageBox.Show(this, "Item" + Convert.ToString(nPos) + " equals " + _text[nPos - 1] + "?",
                                   "Update", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);
                if (sReply == DialogResult.Yes)
                {
                    _text[nPos - 1] = Convert.ToString(nNumber);
                }
                mnConfirm = 2;
                fUpdateDisplay();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void btnConfirm2_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nPos = rnd1.Next(1, 9);
            int nAdd = rnd1.Next(20, 201);
            int nNumber = Convert.ToInt32(_text[nPos - 1]) + nAdd;

            if (mnConfirm == 2)
            {
                DialogResult sReply = MessageBox.Show(this, "Item" + Convert.ToString(nPos) + " equals " + _text[nPos - 1] + "?",
                                   "Update", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);
                if (sReply == DialogResult.Yes)
                {
                    _text[nPos - 1] = Convert.ToString(nNumber);
                }
                mnConfirm = 3;
                fUpdateDisplay();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void btnConfirm3_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nPos = rnd1.Next(1, 9);
            int nAdd = rnd1.Next(20, 201);
            int nNumber = Convert.ToInt32(_text[nPos - 1]) + nAdd;

            if (mnConfirm == 3)
            {
                DialogResult sReply = MessageBox.Show(this, "Item" + Convert.ToString(nPos) + " equals " + _text[nPos - 1] + "?",
                                   "Update", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);
                if (sReply == DialogResult.Yes)
                {
                    _text[nPos - 1] = Convert.ToString(nNumber);
                }
                mnConfirm = 1;
                fUpdateDisplay();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nValue;

            mnConfirm = 1;
            for (int i = 1; i <= 8; i++)
            {
                nValue = rnd1.Next(20, 201);
                _text[i - 1] = Convert.ToString(nValue);
            }

            fUpdateDisplay();

        }
    }
}
