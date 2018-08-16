using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalsDatabase
{
    public partial class fSub2 : Form
    {
        private int mnCol, mnRow;

        private void fOverride(int nCol, int nRow, String sText)
        {
            switch (nCol)
            {
                case 1:
                    switch (nRow)
                    {
                        case 1:
                            txt11.Text = sText;
                            break;
                        case 2:
                            txt12.Text = sText;
                            break;
                        case 3:
                            txt13.Text = sText;
                            break;
                        case 4:
                            txt14.Text = sText;
                            break;
                        case 5:
                            txt15.Text = sText;
                            break;
                        case 6:
                            txt16.Text = sText;
                            break;
                        case 7:
                            txt17.Text = sText;
                            break;
                        case 8:
                            txt18.Text = sText;
                            break;
                        case 9:
                            txt19.Text = sText;
                            break;
                        default:
                            txt1a.Text = sText;
                            break;

                    }
                    break;
                case 2:
                    switch (nRow)
                    {
                        case 1:
                            txt21.Text = sText;
                            break;
                        case 2:
                            txt22.Text = sText;
                            break;
                        case 3:
                            txt23.Text = sText;
                            break;
                        case 4:
                            txt24.Text = sText;
                            break;
                        case 5:
                            txt25.Text = sText;
                            break;
                        case 6:
                            txt26.Text = sText;
                            break;
                        case 7:
                            txt27.Text = sText;
                            break;
                        case 8:
                            txt28.Text = sText;
                            break;
                        case 9:
                            txt29.Text = sText;
                            break;
                        default:
                            txt2a.Text = sText;
                            break;

                    }
                    break;
                case 3:
                    switch (nRow)
                    {
                        case 1:
                            txt31.Text = sText;
                            break;
                        case 2:
                            txt32.Text = sText;
                            break;
                        case 3:
                            txt33.Text = sText;
                            break;
                        case 4:
                            txt34.Text = sText;
                            break;
                        case 5:
                            txt35.Text = sText;
                            break;
                        case 6:
                            txt36.Text = sText;
                            break;
                        case 7:
                            txt37.Text = sText;
                            break;
                        case 8:
                            txt38.Text = sText;
                            break;
                        case 9:
                            txt39.Text = sText;
                            break;
                        default:
                            txt3a.Text = sText;
                            break;

                    }
                    break;
                case 4:
                    switch (nRow)
                    {
                        case 1:
                            txt41.Text = sText;
                            break;
                        case 2:
                            txt42.Text = sText;
                            break;
                        case 3:
                            txt43.Text = sText;
                            break;
                        case 4:
                            txt44.Text = sText;
                            break;
                        case 5:
                            txt45.Text = sText;
                            break;
                        case 6:
                            txt46.Text = sText;
                            break;
                        case 7:
                            txt47.Text = sText;
                            break;
                        case 8:
                            txt48.Text = sText;
                            break;
                        case 9:
                            txt49.Text = sText;
                            break;
                        default:
                            txt4a.Text = sText;
                            break;

                    }
                    break;
                case 5:
                    switch (nRow)
                    {
                        case 1:
                            txt51.Text = sText;
                            break;
                        case 2:
                            txt52.Text = sText;
                            break;
                        case 3:
                            txt53.Text = sText;
                            break;
                        case 4:
                            txt54.Text = sText;
                            break;
                        case 5:
                            txt55.Text = sText;
                            break;
                        case 6:
                            txt56.Text = sText;
                            break;
                        case 7:
                            txt57.Text = sText;
                            break;
                        case 8:
                            txt58.Text = sText;
                            break;
                        case 9:
                            txt59.Text = sText;
                            break;
                        default:
                            txt5a.Text = sText;
                            break;

                    }
                    break;
                default:
                    switch (nRow)
                    {
                        case 1:
                            txt61.Text = sText;
                            break;
                        case 2:
                            txt62.Text = sText;
                            break;
                        case 3:
                            txt63.Text = sText;
                            break;
                        case 4:
                            txt64.Text = sText;
                            break;
                        case 5:
                            txt65.Text = sText;
                            break;
                        case 6:
                            txt66.Text = sText;
                            break;
                        case 7:
                            txt67.Text = sText;
                            break;
                        case 8:
                            txt68.Text = sText;
                            break;
                        case 9:
                            txt69.Text = sText;
                            break;
                        default:
                            txt6a.Text = sText;
                            break;

                    }
                    break;
            }
        }

        public fSub2()
        {
            InitializeComponent();
            mnCol = 1;
            mnRow = 1;
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
            mnRow = 4;

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
        private void txt17_Click(object sender, EventArgs e)
        {
            mnCol = 1;
            mnRow = 7;

        }
        private void txt18_Click(object sender, EventArgs e)
        {
            mnCol = 1;
            mnRow = 8;

        }
        private void txt19_Click(object sender, EventArgs e)
        {
            mnCol = 1;
            mnRow = 9;

        }
        private void txt1a_Click(object sender, EventArgs e)
        {
            mnCol = 1;
            mnRow = 10;

        }

        //col2
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
        private void txt27_Click(object sender, EventArgs e)
        {
            mnCol = 2;
            mnRow = 7;

        }
        private void txt28_Click(object sender, EventArgs e)
        {
            mnCol = 2;
            mnRow = 8;

        }
        private void txt29_Click(object sender, EventArgs e)
        {
            mnCol = 2;
            mnRow = 9;

        }
        private void txt2a_Click(object sender, EventArgs e)
        {
            mnCol = 2;
            mnRow = 10;

        }

        //col3
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
        private void txt37_Click(object sender, EventArgs e)
        {
            mnCol = 3;
            mnRow = 7;

        }
        private void txt38_Click(object sender, EventArgs e)
        {
            mnCol = 3;
            mnRow = 8;

        }
        private void txt39_Click(object sender, EventArgs e)
        {
            mnCol = 3;
            mnRow = 9;

        }
        private void txt3a_Click(object sender, EventArgs e)
        {
            mnCol = 3;
            mnRow = 10;

        }

        //col4
        private void txt41_Click(object sender, EventArgs e)
        {
            mnCol = 4;
            mnRow = 1;

        }
        private void txt42_Click(object sender, EventArgs e)
        {
            mnCol = 4;
            mnRow = 2;

        }
        private void txt43_Click(object sender, EventArgs e)
        {
            mnCol = 4;
            mnRow = 3;

        }
        private void txt44_Click(object sender, EventArgs e)
        {
            mnCol = 4;
            mnRow = 4;

        }
        private void txt45_Click(object sender, EventArgs e)
        {
            mnCol = 4;
            mnRow = 5;

        }
        private void txt46_Click(object sender, EventArgs e)
        {
            mnCol = 4;
            mnRow = 6;

        }
        private void txt47_Click(object sender, EventArgs e)
        {
            mnCol = 4;
            mnRow = 7;

        }
        private void txt48_Click(object sender, EventArgs e)
        {
            mnCol = 4;
            mnRow = 8;

        }
        private void txt49_Click(object sender, EventArgs e)
        {
            mnCol = 4;
            mnRow = 9;

        }
        private void txt4a_Click(object sender, EventArgs e)
        {
            mnCol = 4;
            mnRow = 10;

        }

        //col5
        private void txt51_Click(object sender, EventArgs e)
        {
            mnCol = 5;
            mnRow = 1;

        }
        private void txt52_Click(object sender, EventArgs e)
        {
            mnCol = 5;
            mnRow = 2;

        }
        private void txt53_Click(object sender, EventArgs e)
        {
            mnCol = 5;
            mnRow = 3;

        }
        private void txt54_Click(object sender, EventArgs e)
        {
            mnCol = 5;
            mnRow = 4;

        }
        private void txt55_Click(object sender, EventArgs e)
        {
            mnCol = 5;
            mnRow = 5;

        }
        private void txt56_Click(object sender, EventArgs e)
        {
            mnCol = 5;
            mnRow = 6;

        }
        private void txt57_Click(object sender, EventArgs e)
        {
            mnCol = 5;
            mnRow = 7;

        }
        private void txt58_Click(object sender, EventArgs e)
        {
            mnCol = 5;
            mnRow = 8;

        }
        private void txt59_Click(object sender, EventArgs e)
        {
            mnCol = 5;
            mnRow = 9;

        }
        private void txt5a_Click(object sender, EventArgs e)
        {
            mnCol = 5;
            mnRow = 10;

        }

        //col6
        private void txt61_Click(object sender, EventArgs e)
        {
            mnCol = 6;
            mnRow = 1;

        }
        private void txt62_Click(object sender, EventArgs e)
        {
            mnCol = 6;
            mnRow = 2;

        }
        private void txt63_Click(object sender, EventArgs e)
        {
            mnCol = 6;
            mnRow = 3;

        }
        private void txt64_Click(object sender, EventArgs e)
        {
            mnCol = 6;
            mnRow = 4;

        }
        private void txt65_Click(object sender, EventArgs e)
        {
            mnCol = 6;
            mnRow = 5;

        }
        private void txt66_Click(object sender, EventArgs e)
        {
            mnCol = 6;
            mnRow = 6;

        }
        private void txt67_Click(object sender, EventArgs e)
        {
            mnCol = 6;
            mnRow = 7;

        }
        private void txt68_Click(object sender, EventArgs e)
        {
            mnCol = 6;
            mnRow = 8;

        }
        private void txt69_Click(object sender, EventArgs e)
        {
            mnCol = 6;
            mnRow = 9;

        }

        private void fSub2_Load(object sender, EventArgs e)
        {

        }

        private void btn21_Click(object sender, EventArgs e)
        {
            if (mnCol == 2)
            {
                fOverride(mnCol, mnRow, btn21.Text);
            }

        }

        private void btn31_Click(object sender, EventArgs e)
        {
            if (mnCol == 3)
            {
                fOverride(mnCol, mnRow, btn31.Text);
            }

        }

        private void btn41_Click(object sender, EventArgs e)
        {
            if (mnCol == 4)
            {
                fOverride(mnCol, mnRow, btn41.Text);
            }

        }

        private void btn51_Click(object sender, EventArgs e)
        {
            if (mnCol == 5)
            {
                fOverride(mnCol, mnRow, btn51.Text);
            }

        }

        private void btn52_Click(object sender, EventArgs e)
        {
            if (mnCol == 5)
            {
                fOverride(mnCol, mnRow, btn52.Text);
            }

        }

        private void txt6a_Click(object sender, EventArgs e)
        {
            mnCol = 6;
            mnRow = 10;

        }

    }
}
