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
    public partial class fSub3 : Form
    {

        private List<int> _values1 = new List<int> { 0, 0, 0 };
        private List<int> _values2 = new List<int> { 0, 0, 0 };
        private int mnOutput,mnEdit;
        
        private bool fCheck()
        {
            bool bFound = false;

            for (int i = 1; i <= 3; i++)
            {
                if (_values2[i - 1] != _values1[i - 1])
                {
                    bFound = true;
                    continue;
                }
            }

            return !bFound;
        }

        private void fReset()
        {
            Random rnd1 = new Random();

            mnOutput = 0;
            mnEdit = 0;
            for (int i = 1; i <= 3; i++)
            {
                _values1[i - 1] = rnd1.Next(20, 20001);
            }
            for (int i = 1; i <= 3; i++)
            {
                _values2[i - 1] = 0;
            }

            fUpdateDisplay();
        }

        private void fUpdateDisplay()
        {
            lbl1.Text = "BTSDeal = " + Convert.ToString(_values1[0]);
            lbl2.Text = "BrexitPlan = " + Convert.ToString(_values1[1]);
            lbl3.Text = "MigrationPlan = " + Convert.ToString(_values1[2]);
            btnOutput.Text = "OUTPUT = " + Convert.ToString(mnOutput);
        }
        public fSub3()
        {
            InitializeComponent();
        }

        private void fSub3_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            _values2[0] = mnEdit;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            _values2[1] = mnEdit;
   
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            _values2[2] = mnEdit;
   
        }

        private void btnMiddle_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            bool bPassed = fCheck();
            
            if (bPassed)
            {
                mnOutput = rnd1.Next(1, 4001);
                fUpdateDisplay();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtEdit.Text == null)
            {
                mnEdit = 0;
            }
            else
            {
                mnEdit = Convert.ToInt32(txtEdit.Text);
            }
        }
    }
}
