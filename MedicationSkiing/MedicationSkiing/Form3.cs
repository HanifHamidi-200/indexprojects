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
    public partial class Form3 : Form
    {
        private static List<String> _text = new List<String> { null, null, null, null, null };
        private static List<int> _like = new List<int> { 0,0,0,0,0};



        private void fUpdateDisplay()
        {
            txt1.Text = _text[0];
            txt2.Text = _text[1];
            txt3.Text = _text[2];
            txt4.Text = _text[3];
            txt5.Text = _text[4];
            btnLike1.Text = "like"+Convert.ToString(_like[0]);
            btnLike2.Text = "like" + Convert.ToString(_like[1]);
            btnLike3.Text = "like" + Convert.ToString(_like[2]);
            btnLike4.Text = "like" + Convert.ToString(_like[3]);
            btnLike5.Text = "like" + Convert.ToString(_like[4]);
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nValue;

            for (int i = 1; i <= 5; i++)
            {
                nValue = rnd1.Next(20, 201);
                _text[i - 1] = Convert.ToString(nValue);
            }
            for (int i = 1; i <= 5; i++)
            {
                _like[i-1] = rnd1.Next(20, 601);
              }

            fUpdateDisplay();
        }

        private void btnLike1_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nAdd = rnd1.Next(20, 201);

            _like[0] += nAdd;
            fUpdateDisplay();
        }

        private void btnLike2_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nAdd = rnd1.Next(20, 201);

            _like[1] += nAdd;
            fUpdateDisplay();

        }

        private void btnLike3_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nAdd = rnd1.Next(20, 201);

            _like[2] += nAdd;
            fUpdateDisplay();

        }

        private void btnLike4_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nAdd = rnd1.Next(20, 201);

            _like[3] += nAdd;
            fUpdateDisplay();

        }

        private void btnLike5_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nAdd = rnd1.Next(20, 201);

            _like[4] += nAdd;
            fUpdateDisplay();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nValue;

            for (int i = 1; i <= 5; i++)
            {
                nValue = rnd1.Next(20, 201);
                _text[i - 1] = Convert.ToString(nValue);
            }
            for (int i = 1; i <= 5; i++)
            {
                _like[i - 1] = rnd1.Next(20, 601);
            }

            fUpdateDisplay();

        }
    }
}
