using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aGoldenRobot
{
    public partial class Form1 : Form
    {

        private List<int> _weights = new List<int> { 0, 0, 0, 0 };
        private List<int> _instance = new List<int> { 0, 0, 0, 0 };

        private void fReset()
        {
            Random rnd1 = new Random();

            for(int i = 1; i <= 4; i++)
            {
                _weights[i - 1] = rnd1.Next(20, 2001);
                _instance[i - 1] = rnd1.Next(600, 60001);
            }

            fUpdateDisplay();
        }

        private void fUpdateDisplay()
        {
            txt11.Text = Convert.ToString(_weights[0]);
            txt12.Text = Convert.ToString(_weights[1]);
            txt13.Text = Convert.ToString(_weights[2]);
            txt14.Text = Convert.ToString(_weights[3]);
            txt21.Text = Convert.ToString(_instance[0]);
            txt22.Text = Convert.ToString(_instance[1]);
            txt23.Text = Convert.ToString(_instance[2]);
            txt24.Text = Convert.ToString(_instance[3]);

        }

        public Form1()
        {
            InitializeComponent();
        }

            private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
