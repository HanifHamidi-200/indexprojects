using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexEdit
{
    public partial class Form1 : Form
    {
        private static List<String> _portaldifferences = new List<String> { null,null,null,null,null };
        private static List<int> _count = new List<int> { 0,0,0,0,0};
        private static List<int> _numbers1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 , 0, 0, 0, 0, 0, 0, 0, 0 , 0, 0, 0, 0};
        private static List<int> _numbers2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _numbers3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _numbers4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<int> _numbers5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public Form1()
        {
            InitializeComponent();
            _portaldifferences[0] = "<A>";
            _portaldifferences[1] = "<G>";
            _portaldifferences[2] = "<R>";
            _portaldifferences[3] = "<C>";
            _portaldifferences[4] = "<B>";
            _count[0] = 4;
            _count[1] = 3;
            _count[2] = 4;
            _count[3] = 5;
            _count[4] = 4;
            _numbers1[0] = 64;
            _numbers1[1] = 48;
            _numbers1[2] = 59;
            _numbers1[3] = 60;
            _numbers2[0] = 79;
            _numbers2[1] = 255;
            _numbers2[2] = 46;
            _numbers3[0] = 32;
            _numbers3[1] = 22;
            _numbers3[2] = 24;
            _numbers3[3] = 32;
            _numbers4[0] = 32;
            _numbers4[1] = 18;
            _numbers4[2] = 18;
            _numbers4[3] = 20;
            _numbers4[4] = 22;
            _numbers5[0] = 32;
            _numbers5[1] = 18;
            _numbers5[2] = 19;
            _numbers5[3] = 144;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            int nNumber;
            String sHex;
            int nTens, nUnits;

            txtPortal1.Text = _portaldifferences[0];
            txtPortal2.Text = _portaldifferences[1];
            txtPortal3.Text = _portaldifferences[2];
            txtPortal4.Text = _portaldifferences[3];
            txtPortal5.Text = _portaldifferences[4];
            for (int i = 1; i <= _count[0]; i++)
            {
                nNumber = _numbers1[i - 1];
                sHex = null;
                nTens = 0;
                nUnits = 0;
                if (nNumber <= 15)
                {
                    nUnits = nNumber;
                }
                else
                {
                    do
                    {
                        nNumber -= 16;
                        nTens += 1;
                    } while (nNumber > 15);
                    nUnits = nNumber;
                }
                switch (nTens)
                {
                    case 10:
                        sHex = "a";
                        break;
                    case 11:
                        sHex = "b";
                        break;
                    case 12:
                        sHex = "c";
                        break;
                    case 13:
                        sHex = "d";
                        break;
                    case 14:
                        sHex = "e";
                        break;
                    case 15:
                        sHex = "f";
                        break;
                    case 0:
                        break;
                    default:
                        sHex = Convert.ToString(nTens);
                        break;
                }
                switch (nUnits)
                {
                    case 10:
                        sHex = sHex+"a";
                        break;
                    case 11:
                        sHex = sHex + "b";
                        break;
                    case 12:
                        sHex = sHex + "c";
                        break;
                    case 13:
                        sHex = sHex + "d";
                        break;
                    case 14:
                        sHex = sHex + "e";
                        break;
                    case 15:
                        sHex = sHex + "f";
                        break;
                    case 0:
                        sHex = sHex + "0";
                        break;
                    default:
                        sHex = sHex + Convert.ToString(nUnits);
                        break;
                }
                switch (i)
                {
                    case 1:
                        txt1_1.Text = sHex;
                        break;
                    case 2:
                        txt1_2.Text = sHex;
                        break;
                    case 3:
                        txt1_3.Text = sHex;
                        break;
                    case 4:
                        txt1_4.Text = sHex;
                        break;
                    case 5:
                        txt1_5.Text = sHex;
                        break;
                    case 6:
                        txt1_6.Text = sHex;
                        break;
                    case 7:
                        txt1_7.Text = sHex;
                        break;
                    case 8:
                        txt1_8.Text = sHex;
                        break;
                    case 9:
                        txt1_9.Text = sHex;
                        break;
                    case 10:
                        txt1_10.Text = sHex;
                        break;
                    case 11:
                        txt1_11.Text = sHex;
                        break;
                    case 12:
                        txt1_12.Text = sHex;
                        break;
                    case 13:
                        txt1_13.Text = sHex;
                        break;
                    case 14:
                        txt1_14.Text = sHex;
                        break;
                    case 15:
                        txt1_15.Text = sHex;
                        break;
                    case 16:
                        txt1_16.Text = sHex;
                        break;
                    case 17:
                        txt1_17.Text = sHex;
                        break;
                    case 18:
                        txt1_18.Text = sHex;
                        break;
                    case 19:
                        txt1_19.Text = sHex;
                        break;
                    default:
                        txt1_20.Text = sHex;
                        break;
                }
            }

            //patch2 now
            for (int i = 1; i <= _count[1]; i++)
            {
                nNumber = _numbers2[i - 1];
                sHex = null;
                nTens = 0;
                nUnits = 0;
                if (nNumber <= 15)
                {
                    nUnits = nNumber;
                }
                else
                {
                    do
                    {
                        nNumber -= 16;
                        nTens += 1;
                    } while (nNumber > 15);
                    nUnits = nNumber;
                }
                switch (nTens)
                {
                    case 10:
                        sHex = "a";
                        break;
                    case 11:
                        sHex = "b";
                        break;
                    case 12:
                        sHex = "c";
                        break;
                    case 13:
                        sHex = "d";
                        break;
                    case 14:
                        sHex = "e";
                        break;
                    case 15:
                        sHex = "f";
                        break;
                    case 0:
                        break;
                    default:
                        sHex = Convert.ToString(nTens);
                        break;
                }
                switch (nUnits)
                {
                    case 10:
                        sHex = sHex + "a";
                        break;
                    case 11:
                        sHex = sHex + "b";
                        break;
                    case 12:
                        sHex = sHex + "c";
                        break;
                    case 13:
                        sHex = sHex + "d";
                        break;
                    case 14:
                        sHex = sHex + "e";
                        break;
                    case 15:
                        sHex = sHex + "f";
                        break;
                    case 0:
                        sHex = sHex + "0";
                        break;
                    default:
                        sHex = sHex + Convert.ToString(nUnits);
                        break;
                }
                switch (i)
                {
                    case 1:
                        txt2_1.Text = sHex;
                        break;
                    case 2:
                        txt2_2.Text = sHex;
                        break;
                    case 3:
                        txt2_3.Text = sHex;
                        break;
                    case 4:
                        txt2_4.Text = sHex;
                        break;
                    case 5:
                        txt2_5.Text = sHex;
                        break;
                    case 6:
                        txt2_6.Text = sHex;
                        break;
                    case 7:
                        txt2_7.Text = sHex;
                        break;
                    case 8:
                        txt2_8.Text = sHex;
                        break;
                    case 9:
                        txt2_9.Text = sHex;
                        break;
                    case 10:
                        txt2_10.Text = sHex;
                        break;
                    case 11:
                        txt2_11.Text = sHex;
                        break;
                    case 12:
                        txt2_12.Text = sHex;
                        break;
                    case 13:
                        txt2_13.Text = sHex;
                        break;
                    case 14:
                        txt2_14.Text = sHex;
                        break;
                    case 15:
                        txt2_15.Text = sHex;
                        break;
                    case 16:
                        txt2_16.Text = sHex;
                        break;
                    case 17:
                        txt2_17.Text = sHex;
                        break;
                    case 18:
                        txt2_18.Text = sHex;
                        break;
                    case 19:
                        txt2_19.Text = sHex;
                        break;
                    default:
                        txt2_20.Text = sHex;
                        break;
                }
            }


            //patch3 now
            for (int i = 1; i <= _count[2]; i++)
            {
                nNumber = _numbers3[i - 1];
                sHex = null;
                nTens = 0;
                nUnits = 0;
                if (nNumber <= 15)
                {
                    nUnits = nNumber;
                }
                else
                {
                    do
                    {
                        nNumber -= 16;
                        nTens += 1;
                    } while (nNumber > 15);
                    nUnits = nNumber;
                }
                switch (nTens)
                {
                    case 10:
                        sHex = "a";
                        break;
                    case 11:
                        sHex = "b";
                        break;
                    case 12:
                        sHex = "c";
                        break;
                    case 13:
                        sHex = "d";
                        break;
                    case 14:
                        sHex = "e";
                        break;
                    case 15:
                        sHex = "f";
                        break;
                    case 0:
                        break;
                    default:
                        sHex = Convert.ToString(nTens);
                        break;
                }
                switch (nUnits)
                {
                    case 10:
                        sHex = sHex + "a";
                        break;
                    case 11:
                        sHex = sHex + "b";
                        break;
                    case 12:
                        sHex = sHex + "c";
                        break;
                    case 13:
                        sHex = sHex + "d";
                        break;
                    case 14:
                        sHex = sHex + "e";
                        break;
                    case 15:
                        sHex = sHex + "f";
                        break;
                    case 0:
                        sHex = sHex + "0";
                        break;
                    default:
                        sHex = sHex + Convert.ToString(nUnits);
                        break;
                }
                switch (i)
                {
                    case 1:
                        txt3_1.Text = sHex;
                        break;
                    case 2:
                        txt3_2.Text = sHex;
                        break;
                    case 3:
                        txt3_3.Text = sHex;
                        break;
                    case 4:
                        txt3_4.Text = sHex;
                        break;
                    case 5:
                        txt3_5.Text = sHex;
                        break;
                    case 6:
                        txt3_6.Text = sHex;
                        break;
                    case 7:
                        txt3_7.Text = sHex;
                        break;
                    case 8:
                        txt3_8.Text = sHex;
                        break;
                    case 9:
                        txt3_9.Text = sHex;
                        break;
                    case 10:
                        txt3_10.Text = sHex;
                        break;
                    case 11:
                        txt3_11.Text = sHex;
                        break;
                    case 12:
                        txt3_12.Text = sHex;
                        break;
                    case 13:
                        txt3_13.Text = sHex;
                        break;
                    case 14:
                        txt3_14.Text = sHex;
                        break;
                    case 15:
                        txt3_15.Text = sHex;
                        break;
                    case 16:
                        txt3_16.Text = sHex;
                        break;
                    case 17:
                        txt3_17.Text = sHex;
                        break;
                    case 18:
                        txt3_18.Text = sHex;
                        break;
                    case 19:
                        txt3_19.Text = sHex;
                        break;
                    default:
                        txt3_20.Text = sHex;
                        break;
                }
            }


            //patch4 now
            for (int i = 1; i <= _count[3]; i++)
            {
                nNumber = _numbers4[i - 1];
                sHex = null;
                nTens = 0;
                nUnits = 0;
                if (nNumber <= 15)
                {
                    nUnits = nNumber;
                }
                else
                {
                    do
                    {
                        nNumber -= 16;
                        nTens += 1;
                    } while (nNumber > 15);
                    nUnits = nNumber;
                }
                switch (nTens)
                {
                    case 10:
                        sHex = "a";
                        break;
                    case 11:
                        sHex = "b";
                        break;
                    case 12:
                        sHex = "c";
                        break;
                    case 13:
                        sHex = "d";
                        break;
                    case 14:
                        sHex = "e";
                        break;
                    case 15:
                        sHex = "f";
                        break;
                    case 0:
                        break;
                    default:
                        sHex = Convert.ToString(nTens);
                        break;
                }
                switch (nUnits)
                {
                    case 10:
                        sHex = sHex + "a";
                        break;
                    case 11:
                        sHex = sHex + "b";
                        break;
                    case 12:
                        sHex = sHex + "c";
                        break;
                    case 13:
                        sHex = sHex + "d";
                        break;
                    case 14:
                        sHex = sHex + "e";
                        break;
                    case 15:
                        sHex = sHex + "f";
                        break;
                    case 0:
                        sHex = sHex + "0";
                        break;
                    default:
                        sHex = sHex + Convert.ToString(nUnits);
                        break;
                }
                switch (i)
                {
                    case 1:
                        txt4_1.Text = sHex;
                        break;
                    case 2:
                        txt4_2.Text = sHex;
                        break;
                    case 3:
                        txt4_3.Text = sHex;
                        break;
                    case 4:
                        txt4_4.Text = sHex;
                        break;
                    case 5:
                        txt4_5.Text = sHex;
                        break;
                    case 6:
                        txt4_6.Text = sHex;
                        break;
                    case 7:
                        txt4_7.Text = sHex;
                        break;
                    case 8:
                        txt4_8.Text = sHex;
                        break;
                    case 9:
                        txt4_9.Text = sHex;
                        break;
                    case 10:
                        txt4_10.Text = sHex;
                        break;
                    case 11:
                        txt4_11.Text = sHex;
                        break;
                    case 12:
                        txt4_12.Text = sHex;
                        break;
                    case 13:
                        txt4_13.Text = sHex;
                        break;
                    case 14:
                        txt4_14.Text = sHex;
                        break;
                    case 15:
                        txt4_15.Text = sHex;
                        break;
                    case 16:
                        txt4_16.Text = sHex;
                        break;
                    case 17:
                        txt4_17.Text = sHex;
                        break;
                    case 18:
                        txt4_18.Text = sHex;
                        break;
                    case 19:
                        txt4_19.Text = sHex;
                        break;
                    default:
                        txt4_20.Text = sHex;
                        break;
                }
            }


            //patch5 now
            for (int i = 1; i <= _count[4]; i++)
            {
                nNumber = _numbers5[i - 1];
                sHex = null;
                nTens = 0;
                nUnits = 0;
                if (nNumber <= 15)
                {
                    nUnits = nNumber;
                }
                else
                {
                    do
                    {
                        nNumber -= 16;
                        nTens += 1;
                    } while (nNumber > 15);
                    nUnits = nNumber;
                }
                switch (nTens)
                {
                    case 10:
                        sHex = "a";
                        break;
                    case 11:
                        sHex = "b";
                        break;
                    case 12:
                        sHex = "c";
                        break;
                    case 13:
                        sHex = "d";
                        break;
                    case 14:
                        sHex = "e";
                        break;
                    case 15:
                        sHex = "f";
                        break;
                    case 0:
                        break;
                    default:
                        sHex = Convert.ToString(nTens);
                        break;
                }
                switch (nUnits)
                {
                    case 10:
                        sHex = sHex + "a";
                        break;
                    case 11:
                        sHex = sHex + "b";
                        break;
                    case 12:
                        sHex = sHex + "c";
                        break;
                    case 13:
                        sHex = sHex + "d";
                        break;
                    case 14:
                        sHex = sHex + "e";
                        break;
                    case 15:
                        sHex = sHex + "f";
                        break;
                    case 0:
                        sHex = sHex + "0";
                        break;
                    default:
                        sHex = sHex + Convert.ToString(nUnits);
                        break;
                }
                switch (i)
                {
                    case 1:
                        txt5_1.Text = sHex;
                        break;
                    case 2:
                        txt5_2.Text = sHex;
                        break;
                    case 3:
                        txt5_3.Text = sHex;
                        break;
                    case 4:
                        txt5_4.Text = sHex;
                        break;
                    case 5:
                        txt5_5.Text = sHex;
                        break;
                    case 6:
                        txt5_6.Text = sHex;
                        break;
                    case 7:
                        txt5_7.Text = sHex;
                        break;
                    case 8:
                        txt5_8.Text = sHex;
                        break;
                    case 9:
                        txt5_9.Text = sHex;
                        break;
                    case 10:
                        txt5_10.Text = sHex;
                        break;
                    case 11:
                        txt5_11.Text = sHex;
                        break;
                    case 12:
                        txt5_12.Text = sHex;
                        break;
                    case 13:
                        txt5_13.Text = sHex;
                        break;
                    case 14:
                        txt5_14.Text = sHex;
                        break;
                    case 15:
                        txt5_15.Text = sHex;
                        break;
                    case 16:
                        txt5_16.Text = sHex;
                        break;
                    case 17:
                        txt5_17.Text = sHex;
                        break;
                    case 18:
                        txt5_18.Text = sHex;
                        break;
                    case 19:
                        txt5_19.Text = sHex;
                        break;
                    default:
                        txt5_20.Text = sHex;
                        break;
                }
            }

        }

    }
}
