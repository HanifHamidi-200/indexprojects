using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkRotorNumbers
{
    public partial class Form1 : Form
    {
        private static List<int> _col1 = new List<int> { 0, 0, 0, 0, 0 };
        private static List<int> _col2 = new List<int> { 0, 0, 0, 0, 0 };
        private static List<int> _col3 = new List<int> { 0, 0, 0, 0, 0};
        private static List<int> _col4 = new List<int> { 0, 0, 0, 0, 0 };
        private static List<int> _col5 = new List<int> { 0, 0, 0, 0, 0 };
        private int nNumber;
     
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nCount = rnd1.Next(4, 17);
            int nCol, nRow;

            for (int i = 1; i <= nCount; i++)
            {
                nCol = rnd1.Next(1, 6);
                nRow = rnd1.Next(1, 6);
                switch (nCol)
                {
                    case 1:
                        _col1[nRow - 1] = rnd1.Next(20, 201);
                        break;
                    case 2:
                        _col2[nRow - 1] = rnd1.Next(20, 201);
                        break;
                    case 3:
                        _col3[nRow - 1] = rnd1.Next(20, 201);
                        break;
                    case 4:
                        _col4[nRow - 1] = rnd1.Next(20, 201);
                        break;
                    default:
                        _col5[nRow - 1] = rnd1.Next(20, 201);
                        break;
                }
            }

            txt11.Text = Convert.ToString(_col1[0]);
            txt12.Text = Convert.ToString(_col1[1]);
            txt13.Text = Convert.ToString(_col1[2]);
            txt14.Text = Convert.ToString(_col1[3]);
            txt15.Text = Convert.ToString(_col1[4]);

            txt21.Text = Convert.ToString(_col2[0]);
            txt22.Text = Convert.ToString(_col2[1]);
            txt23.Text = Convert.ToString(_col2[2]);
            txt24.Text = Convert.ToString(_col2[3]);
            txt25.Text = Convert.ToString(_col2[4]);

            txt31.Text = Convert.ToString(_col3[0]);
            txt32.Text = Convert.ToString(_col3[1]);
            txt33.Text = Convert.ToString(_col3[2]);
            txt34.Text = Convert.ToString(_col3[3]);
            txt35.Text = Convert.ToString(_col3[4]);

            txt41.Text = Convert.ToString(_col4[0]);
            txt42.Text = Convert.ToString(_col4[1]);
            txt43.Text = Convert.ToString(_col4[2]);
            txt44.Text = Convert.ToString(_col4[3]);
            txt45.Text = Convert.ToString(_col4[4]);

            txt51.Text = Convert.ToString(_col5[0]);
            txt52.Text = Convert.ToString(_col5[1]);
            txt53.Text = Convert.ToString(_col5[2]);
            txt54.Text = Convert.ToString(_col5[3]);
            txt55.Text = Convert.ToString(_col5[4]);
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nCount = rnd1.Next(4, 17);
            int nCol, nRow;

            for (int i = 1; i <= nCount; i++)
            {
                nCol = rnd1.Next(1, 6);
                nRow = rnd1.Next(1, 6);
                switch (nCol)
                {
                    case 1:
                        _col1[nRow - 1] = rnd1.Next(20, 201);
                        break;
                    case 2:
                        _col2[nRow - 1] = rnd1.Next(20, 201);
                        break;
                    case 3:
                        _col3[nRow - 1] = rnd1.Next(20, 201);
                        break;
                    case 4:
                        _col4[nRow - 1] = rnd1.Next(20, 201);
                        break;
                    default:
                        _col5[nRow - 1] = rnd1.Next(20, 201);
                        break;
                }
            }

            txt11.Text = Convert.ToString(_col1[0]);
            txt12.Text = Convert.ToString(_col1[1]);
            txt13.Text = Convert.ToString(_col1[2]);
            txt14.Text = Convert.ToString(_col1[3]);
            txt15.Text = Convert.ToString(_col1[4]);

            txt21.Text = Convert.ToString(_col2[0]);
            txt22.Text = Convert.ToString(_col2[1]);
            txt23.Text = Convert.ToString(_col2[2]);
            txt24.Text = Convert.ToString(_col2[3]);
            txt25.Text = Convert.ToString(_col2[4]);

            txt31.Text = Convert.ToString(_col3[0]);
            txt32.Text = Convert.ToString(_col3[1]);
            txt33.Text = Convert.ToString(_col3[2]);
            txt34.Text = Convert.ToString(_col3[3]);
            txt35.Text = Convert.ToString(_col3[4]);

            txt41.Text = Convert.ToString(_col4[0]);
            txt42.Text = Convert.ToString(_col4[1]);
            txt43.Text = Convert.ToString(_col4[2]);
            txt44.Text = Convert.ToString(_col4[3]);
            txt45.Text = Convert.ToString(_col4[4]);

            txt51.Text = Convert.ToString(_col5[0]);
            txt52.Text = Convert.ToString(_col5[1]);
            txt53.Text = Convert.ToString(_col5[2]);
            txt54.Text = Convert.ToString(_col5[3]);
            txt55.Text = Convert.ToString(_col5[4]);
        }

    }
}

