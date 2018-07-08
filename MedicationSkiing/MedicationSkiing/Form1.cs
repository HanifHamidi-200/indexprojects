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
    public partial class Form1 : Form
    {
        private static List<String> _db1 = new List<String> { null,null,null,null,null,null };
        private static List<String> _db2 = new List<String> { null, null, null, null, null, null };
        private static List<String> _db3 = new List<String> { null, null, null, null, null, null };
        String sTitle;
        private int mnCol, mnRow;

        private void fUpdateDisplay()
        {
            txtTitle.Text = sTitle;

            txt11.Text = _db1[0];
            txt12.Text = _db1[1];
            txt13.Text = _db1[2];
            txt14.Text = _db1[3];
            txt15.Text = _db1[4];
            txt16.Text = _db1[5];
            txt21.Text = _db2[0];
            txt22.Text = _db2[1];
            txt23.Text = _db2[2];
            txt24.Text = _db2[3];
            txt25.Text = _db2[4];
            txt26.Text = _db2[5];
            txt31.Text = _db3[0];
            txt32.Text = _db3[1];
            txt33.Text = _db3[2];
            txt34.Text = _db3[3];
            txt35.Text = _db3[4];
            txt36.Text = _db3[5];
        }

        private void fClear()
        {
            sTitle = null;
            for (int i = 1; i <= 6; i++)
            {
                _db1[i - 1] = null;
                _db2[i - 1] = null;
                _db3[i - 1] = null;
            }

            fUpdateDisplay();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();

            mnCol = rnd1.Next(1, 4);
            mnRow = rnd1.Next(1, 7);
            fClear();
        }

        private void txt11_TextChanged(object sender, EventArgs e)
        {
            mnCol = 1;
            mnRow = 1;
        }

        private void txt12_TextChanged(object sender, EventArgs e)
        {
            mnCol = 1;
            mnRow = 2;

        }

        private void txt13_TextChanged(object sender, EventArgs e)
        {
            mnCol = 1;
            mnRow = 3;

        }

        private void txt14_TextChanged(object sender, EventArgs e)
        {
            mnCol = 1;
            mnRow = 4;

        }

        private void txt15_TextChanged(object sender, EventArgs e)
        {
            mnCol = 1;
            mnRow = 5;

        }

        private void txt16_TextChanged(object sender, EventArgs e)
        {
            mnCol = 1;
            mnRow = 6;

        }

        private void txt21_TextChanged(object sender, EventArgs e)
        {
            mnCol = 2;
            mnRow = 1;

        }

        private void txt22_TextChanged(object sender, EventArgs e)
        {
            mnCol = 2;
            mnRow = 2;

        }

        private void txt23_TextChanged(object sender, EventArgs e)
        {
            mnCol = 2;
            mnRow = 3;

        }

        private void txt24_TextChanged(object sender, EventArgs e)
        {
            mnCol = 2;
            mnRow = 4;

        }

        private void txt25_TextChanged(object sender, EventArgs e)
        {
            mnCol = 2;
            mnRow = 5;

        }

        private void txt26_TextChanged(object sender, EventArgs e)
        {
            mnCol = 2;
            mnRow = 6;

        }

        private void txt31_TextChanged(object sender, EventArgs e)
        {
            mnCol = 3;
            mnRow = 1;

        }

        private void txt32_TextChanged(object sender, EventArgs e)
        {
            mnCol = 3;
            mnRow = 2;

        }

        private void txt33_TextChanged(object sender, EventArgs e)
        {
            mnCol = 3;
            mnRow = 3;

        }

        private void txt34_TextChanged(object sender, EventArgs e)
        {
            mnCol = 3;
            mnRow = 4;

        }

        private void txt35_TextChanged(object sender, EventArgs e)
        {
            mnCol = 3;
            mnRow = 5;

        }

        private void txt36_TextChanged(object sender, EventArgs e)
        {
            mnCol = 3;
            mnRow = 6;

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            char sLetter = (char)(rnd1.Next(1, 27) + 64);
            String sText = null;
            
            sText = sLetter.ToString()+"\\"+Convert.ToInt32(rnd1.Next(1,201));

            switch (mnCol)
            {
                case 1:
                    _db1[mnRow - 1] = sText;
                    break;
                case 2:
                    _db2[mnRow - 1] = sText;
                    break;
                default:
                    _db3[mnRow - 1] = sText;
                    break;
            }
            fUpdateDisplay();
        }

        private void txt11_Click(object sender, EventArgs e)
        {
            mnCol = 1;
            mnRow = 1;

        }

        private void txt12_Click(object sender, EventArgs e)
        {
            mnCol = 1;
            mnRow = 2;

        }

        private void txt13_Click(object sender, EventArgs e)
        {
            mnCol = 1;
            mnRow = 3;

        }

        private void txt14_Click(object sender, EventArgs e)
        {
            mnCol = 1;
            mnRow =4;

        }

        private void txt15_Click(object sender, EventArgs e)
        {
            mnCol = 1;
            mnRow = 5;

        }

        private void txt16_Click(object sender, EventArgs e)
        {
            mnCol = 1;
            mnRow = 6;

        }

        private void txt21_Click(object sender, EventArgs e)
        {
            mnCol = 2;
            mnRow = 1;

        }

        private void txt22_Click(object sender, EventArgs e)
        {
            mnCol = 2;
            mnRow = 2;

        }

        private void txt23_Click(object sender, EventArgs e)
        {
            mnCol = 2;
            mnRow = 3;

        }

        private void txt24_Click(object sender, EventArgs e)
        {
            mnCol = 2;
            mnRow = 4;

        }

        private void txt25_Click(object sender, EventArgs e)
        {
            mnCol = 2;
            mnRow = 5;

        }

        private void txt26_Click(object sender, EventArgs e)
        {
            mnCol = 2;
            mnRow = 6;

        }

        private void txt31_Click(object sender, EventArgs e)
        {
            mnCol = 3;
            mnRow = 1;

        }

        private void txt32_Click(object sender, EventArgs e)
        {
            mnCol = 3;
            mnRow = 2;

        }

        private void txt33_Click(object sender, EventArgs e)
        {
            mnCol = 3;
            mnRow = 3;

        }

        private void txt34_Click(object sender, EventArgs e)
        {
            mnCol = 3;
            mnRow = 4;

        }

        private void txt35_Click(object sender, EventArgs e)
        {
            mnCol = 3;
            mnRow = 5;

        }

        private void txt36_Click(object sender, EventArgs e)
        {
            mnCol = 3;
            mnRow = 6;

        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            Form2 dlg = new Form2();
            dlg.ShowDialog();
        }

        private void btnHospital_Click(object sender, EventArgs e)
        {
            Form3 dlg = new Form3();
            dlg.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            fClear();
        }
    }
}
