using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManuscriptReaders6
{
    public partial class Form1 : Form
    {
        private List<String> _list = new List<String> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null , null, null, null, null, null, null, null, null, null, null, null, null, null, null};
        private List<String> _text = new List<String> { "hueblo", "timely", "active", "mountain", "poll", "knackers", "machine" };

        private void fClick(int nItem)
        {
            _list[nItem - 1] = txtEdit.Text;
            fUpdateDisplay();
        }

        private void fReset()
        {
            Random rnd1 = new Random();
             int nAdd,nItem=1;

            for (int i = 1; i <= 42; i++)
            {
                _list[i - 1] = "<ditto>";
            }
            for (int i = 1; i <= 42; i++)
            {
                _list[i - 1] = _text[nItem - 1];
                nItem += 1;
                if (nItem >= 8)
                {
                    fUpdateDisplay();
                    return;
                }
                nAdd = rnd1.Next(1, 6);
                i += nAdd;
            }

              fUpdateDisplay();
        }

        private void fUpdateDisplay()
        {
            lbl1.Text = _list[0];
            lbl2.Text = _list[1];
            lbl3.Text = _list[2];
            lbl4.Text = _list[3];
            lbl5.Text = _list[4];
            lbl6.Text = _list[5];
            lbl7.Text = _list[6];
            lbl8.Text = _list[7];
            lbl9.Text = _list[8];
            lbl10.Text = _list[9];

            lbl11.Text = _list[10];
            lbl12.Text = _list[11];
            lbl13.Text = _list[12];
            lbl14.Text = _list[13];
            lbl15.Text = _list[14];
            lbl16.Text = _list[15];
            lbl17.Text = _list[16];
            lbl18.Text = _list[17];
            lbl19.Text = _list[18];
            lbl20.Text = _list[19];

            lbl21.Text = _list[20];
            lbl22.Text = _list[21];
            lbl23.Text = _list[22];
            lbl24.Text = _list[23];
            lbl25.Text = _list[24];
            lbl26.Text = _list[25];
            lbl27.Text = _list[26];
            lbl28.Text = _list[27];
            lbl29.Text = _list[28];
            lbl30.Text = _list[29];

            lbl31.Text = _list[30];
            lbl32.Text = _list[31];
            lbl33.Text = _list[32];
            lbl34.Text = _list[33];
            lbl35.Text = _list[34];
            lbl36.Text = _list[35];
            lbl37.Text = _list[36];
            lbl38.Text = _list[37];
            lbl39.Text = _list[38];
            lbl40.Text = _list[39];

            lbl41.Text = _list[40];
            lbl42.Text = _list[41];

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

        private void lbl1_Click(object sender, EventArgs e)
        {
            fClick(1);
        }
        private void lbl2_Click(object sender, EventArgs e)
        {
            fClick(2);
        }
        private void lbl3_Click(object sender, EventArgs e)
        {
            fClick(3);
        }
        private void lbl4_Click(object sender, EventArgs e)
        {
            fClick(4);
        }
        private void lbl5_Click(object sender, EventArgs e)
        {
            fClick(5);
        }
        private void lbl6_Click(object sender, EventArgs e)
        {
            fClick(6);
        }
        private void lbl7_Click(object sender, EventArgs e)
        {
            fClick(7);
        }
        private void lbl8_Click(object sender, EventArgs e)
        {
            fClick(8);
        }
        private void lbl9_Click(object sender, EventArgs e)
        {
            fClick(9);
        }
        private void lbl10_Click(object sender, EventArgs e)
        {
            fClick(10);
        }

        //col2
        private void lbl11_Click(object sender, EventArgs e)
        {
            fClick(11);
        }
        private void lbl12_Click(object sender, EventArgs e)
        {
            fClick(12);
        }
        private void lbl13_Click(object sender, EventArgs e)
        {
            fClick(13);
        }
        private void lbl14_Click(object sender, EventArgs e)
        {
            fClick(14);
        }
        private void lbl15_Click(object sender, EventArgs e)
        {
            fClick(15);
        }
        private void lbl16_Click(object sender, EventArgs e)
        {
            fClick(16);
        }
        private void lbl17_Click(object sender, EventArgs e)
        {
            fClick(17);
        }
        private void lbl18_Click(object sender, EventArgs e)
        {
            fClick(18);
        }
        private void lbl19_Click(object sender, EventArgs e)
        {
            fClick(19);
        }
        private void lbl20_Click(object sender, EventArgs e)
        {
            fClick(20);
        }


        //col3
        private void lbl21_Click(object sender, EventArgs e)
        {
            fClick(21);
        }
        private void lbl22_Click(object sender, EventArgs e)
        {
            fClick(22);
        }
        private void lbl23_Click(object sender, EventArgs e)
        {
            fClick(23);
        }
        private void lbl24_Click(object sender, EventArgs e)
        {
            fClick(24);
        }
        private void lbl25_Click(object sender, EventArgs e)
        {
            fClick(25);
        }
        private void lbl26_Click(object sender, EventArgs e)
        {
            fClick(26);
        }
        private void lbl27_Click(object sender, EventArgs e)
        {
            fClick(27);
        }
        private void lbl28_Click(object sender, EventArgs e)
        {
            fClick(28);
        }
        private void lbl29_Click(object sender, EventArgs e)
        {
            fClick(29);
        }
        private void lbl30_Click(object sender, EventArgs e)
        {
            fClick(30);
        }


        //col4
        private void lbl31_Click(object sender, EventArgs e)
        {
            fClick(31);
        }
        private void lbl32_Click(object sender, EventArgs e)
        {
            fClick(32);
        }
        private void lbl33_Click(object sender, EventArgs e)
        {
            fClick(33);
        }
        private void lbl34_Click(object sender, EventArgs e)
        {
            fClick(34);
        }
        private void lbl35_Click(object sender, EventArgs e)
        {
            fClick(35);
        }
        private void lbl36_Click(object sender, EventArgs e)
        {
            fClick(36);
        }
        private void lbl37_Click(object sender, EventArgs e)
        {
            fClick(37);
        }
        private void lbl38_Click(object sender, EventArgs e)
        {
            fClick(38);
        }
        private void lbl39_Click(object sender, EventArgs e)
        {
            fClick(39);
        }
        private void lbl40_Click(object sender, EventArgs e)
        {
            fClick(40);
        }

        private void lbl41_Click(object sender, EventArgs e)
        {
            fClick(41);
        }
        private void lbl42_Click(object sender, EventArgs e)
        {
            fClick(42);
        }

    }
}
