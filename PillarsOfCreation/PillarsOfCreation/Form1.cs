using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PillarsOfCreation
{
    public partial class Form1 : Form
    {
        private List<int> _min = new List<int> { 6000, 20000, 16000, 10000 };
        private List<int> _max = new List<int> { 14000, 40000, 38000, 20000 };
        private List<int> _values = new List<int> { 0, 0, 0, 0 };
        

        private void fReset()
        {
            Random rnd1 = new Random();

            for (int i = 1; i <= 4; i++)
            {
                _values[i - 1] = rnd1.Next(_min[i - 1], _max[i - 1]);
            }

            txt1.Text = Convert.ToString(_values[0]);
            txt2.Text = Convert.ToString(_values[1]);
            txt3.Text = Convert.ToString(_values[2]);
            txt4.Text = Convert.ToString(_values[3]);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
