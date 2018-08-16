using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipBuilding
{
    public partial class Form1 : Form
    {
        private List<String> _job = new List<String> { "papier", "xcross", "turnover", "paste", "grovelstick", "ustaples", "hurriendwrench" };
        private List<String> _descrption = new List<String> { "covers the bark", "describes the structure", "paltrys the money", "sticks the joints", "allows for forception", "intermittingly puts the impossible together", "knows how to swim" };
        private List<String> _text = new List<String> { "LINKSWITH", "WORKSWITH" };
        private List<int> _part1 = new List<int> { 0, 0, 0, 0 };
        private List<int> _part2 = new List<int> { 0, 0, 0, 0 };
        private List<int> _middle = new List<int> { 0, 0, 0, 0 };
        private List<bool> _done = new List<bool> {false,false,false,false };
        private int mnItem;

        private void fReset()
        {
            Random rnd1 = new Random();
            for (int i = 1; i <= 4; i++)
            {
                _part1[i-1] = rnd1.Next(1, 8);
                _part2[i-1] = rnd1.Next(1, 8);
                _middle[i-1] = rnd1.Next(1, 3);
                _done[i - 1] =false;
            }

            fUpdateDisplay();
            mnItem = 1;
            fDescription(1);
        }

        private void fUpdateDisplay()
        {
            lbl11.Text = _job[_part1[0]-1];
            lbl21.Text = _job[_part2[0] - 1];
            lblM1.Text = _text[_middle[0] - 1];
            lbl12.Text = _job[_part1[1] - 1];
            lbl22.Text = _job[_part2[1] - 1];
            lblM2.Text = _text[_middle[1] - 1];
            lbl13.Text = _job[_part1[2] - 1];
            lbl23.Text = _job[_part2[2] - 1];
            lblM3.Text = _text[_middle[2] - 1];
            lbl14.Text = _job[_part1[3] - 1];
            lbl24.Text = _job[_part2[3] - 1];
            lblM4.Text = _text[_middle[3] - 1];

            chk1.Checked = _done[0];
            chk2.Checked = _done[1];
            chk3.Checked = _done[2];
            chk4.Checked = _done[3];

        }

        private void fDescription(int nCol)
        {
            String sText = null;
            switch (mnItem)
            {
                case 1:
                    if (nCol == 1)
                    {
                        sText = _job[_part1[0] - 1] + " = " + _descrption[_part1[0] - 1];
                    }
                    else
                    {
                        sText = _job[_part2[0] - 1] + " = " + _descrption[_part2[0] - 1];
                    }
                    break;
                case 2:
                    if (nCol == 1)
                    {
                        sText = _job[_part1[1] - 1] + " = " + _descrption[_part1[1] - 1];
                    }
                    else
                    {
                        sText = _job[_part2[1] - 1] + " = " + _descrption[_part2[1] - 1];
                    }
                    break;
                case 3:
                    if (nCol == 1)
                    {
                        sText = _job[_part1[2] - 1] + " = " + _descrption[_part1[2] - 1];
                    }
                    else
                    {
                        sText = _job[_part2[2] - 1] + " = " + _descrption[_part2[2] - 1];
                    }
                    break;
               default:
                    if (nCol == 1)
                    {
                        sText = _job[_part1[3] - 1] + " = " + _descrption[_part1[3] - 1];
                    }
                    else
                    {
                        sText = _job[_part2[3] - 1] + " = " + _descrption[_part2[3] - 1];
                    }
                    break;
            }
            lblDescription.Text = sText;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void lbl11_Click(object sender, EventArgs e)
        {
            mnItem = 1;
            fDescription(1);
        }

     
    
        private void lbl21_Click(object sender, EventArgs e)
        {
            mnItem = 1;
            fDescription(2);

        }
        private void lbl12_Click(object sender, EventArgs e)
        {
            mnItem = 2;
            fDescription(1);

        }
        private void lbl22_Click(object sender, EventArgs e)
        {
            mnItem = 2;
            fDescription(2);

        }

        private void lbl13_Click(object sender, EventArgs e)
        {
            mnItem = 3;
            fDescription(1);

        }

        private void lbl23_Click(object sender, EventArgs e)
        {
            mnItem = 3;
            fDescription(2);

        }

        private void lbl14_Click(object sender, EventArgs e)
        {
            mnItem = 4;
            fDescription(1);

        }

        private void lbl24_Click(object sender, EventArgs e)
        {
            mnItem = 4;
            fDescription(2);

        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
