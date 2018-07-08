using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThePentagon
{
    public partial class Form1 : Form
    {
        private static List<String> _place1 = new List<String> { "TimesHaveChanged","Computerisation","SlaveTradeTriangle","DallasEast" };
        private static List<String> _place2 = new List<String> { "RelationsHaveBroken", "Incubater" };
        private static List<String> _place3 = new List<String> { "SyrianLevitronConnections", "WondersBasedCategorisation" };
        private static List<String> _place4 = new List<String> { "6thMilitaryArm"};
        private static List<String> _place5 = new List<String> { "GreatAustralianTrainNetwork" };
        private static List<String> _relations = new List<String> { "AfricaCop", " Alaska", "  ArabianBloc ", " AsianCoalition", "  BrazilianUnion ", " EgyptianCartel ", " Eurasia ", " EuroSyndicate ", " FedKorea ", " IcelandicUnion", "  NeoJapan", "  NewMexico ", " Scandinavia ", " USA" };
        private static List<int> _type = new List<int> { 0, 0, 0, 0, 0};
        private static List<int> _number = new List<int> { 0, 0, 0, 0, 0 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            String sBait = "12345";
            String sBait2 = "12345";
            int nLength;
            int nPos,nPos2;
            String sLetter;
            int nIndex=0;
            int nType, nNumber;
            String sWord=null;

            nLength = sBait.Length;
            do
            {
                nIndex+=1;
                nLength = sBait.Length;
                nPos = rnd1.Next(1, nLength + 1);
                sLetter = sBait.Substring(nPos - 1, 1);
                _type[nIndex-1] = Convert.ToInt32(sLetter);
                switch(_type[nIndex - 1])
                {
                    case 1:
                        sBait2 = "1234";
                        break;
                    case 2:
                        sBait2 = "12";
                        break;
                    case 3:
                        sBait2 = "12";
                        break;
                    case 4:
                        sBait2 = "1";
                        break;
                    default:
                        sBait2 = "1";
                        break;
                }
                nPos2 = rnd1.Next(1, sBait2.Length + 1);
                sLetter = sBait2.Substring(nPos2 - 1, 1);
                _number[nIndex - 1] = Convert.ToInt32(sLetter);
                if (nPos == 1)
                {
                    sBait = sBait.Substring(nPos, nLength - nPos);
                }
                else
                {
                    sBait = sBait.Substring(0, nPos - 1) + sBait.Substring(nPos, nLength - nPos);
                }
                nLength = sBait.Length;
            } while (nLength > 0);

            nType = _type[0];
            nNumber = _number[0];
            switch (nType)
            {
                case 1:
                     sWord = _place1[nNumber - 1];
                     break;
                case 2:
                    sWord = _place2[nNumber - 1];
                    break;
                case 3:
                    sWord = _place3[nNumber - 1];
                    break;
                case 4:
                    sWord = _place4[nNumber - 1];
                    break;
                default:
                    sWord = _place5[nNumber - 1];
                    break;
            }
            lbl1.Text = sWord;
            nType = _type[1];
            nNumber = _number[1];
            switch (nType)
            {
                case 1:
                    sWord = _place1[nNumber - 1];
                    break;
                case 2:
                    sWord = _place2[nNumber - 1];
                    break;
                case 3:
                    sWord = _place3[nNumber - 1];
                    break;
                case 4:
                    sWord = _place4[nNumber - 1];
                    break;
                default:
                    sWord = _place5[nNumber - 1];
                    break;
            }
            lbl2.Text = sWord;
            nType = _type[2];
            nNumber = _number[2];
            switch (nType)
            {
                case 1:
                    sWord = _place1[nNumber - 1];
                    break;
                case 2:
                    sWord = _place2[nNumber - 1];
                    break;
                case 3:
                    sWord = _place3[nNumber - 1];
                    break;
                case 4:
                    sWord = _place4[nNumber - 1];
                    break;
                default:
                    sWord = _place5[nNumber - 1];
                    break;
            }
            lbl3.Text = sWord;
            nType = _type[3];
            nNumber = _number[3];
            switch (nType)
            {
                case 1:
                    sWord = _place1[nNumber - 1];
                    break;
                case 2:
                    sWord = _place2[nNumber - 1];
                    break;
                case 3:
                    sWord = _place3[nNumber - 1];
                    break;
                case 4:
                    sWord = _place4[nNumber - 1];
                    break;
                default:
                    sWord = _place5[nNumber - 1];
                    break;
            }
            lbl4.Text = sWord;
            nType = _type[4];
            nNumber = _number[4];
            switch (nType)
            {
                case 1:
                    sWord = _place1[nNumber - 1];
                    break;
                case 2:
                    sWord = _place2[nNumber - 1];
                    break;
                case 3:
                    sWord = _place3[nNumber - 1];
                    break;
                case 4:
                    sWord = _place4[nNumber - 1];
                    break;
                default:
                    sWord = _place5[nNumber - 1];
                    break;
            }
            lbl5.Text = sWord;

            for (int i = 1; i <= 14; i++)
            {
                sWord = _relations[i - 1] + " = ";
                lst1.Items.Add(sWord);
            }
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            String sBait = "12345";
            String sBait2 = "12345";
            int nLength;
            int nPos, nPos2;
            String sLetter;
            int nIndex = 0;
            int nType, nNumber;
            String sWord = null;

            nLength = sBait.Length;
            do
            {
                nIndex+=1;
                nLength = sBait.Length;
                nPos = rnd1.Next(1, nLength + 1);
                sLetter = sBait.Substring(nPos - 1, 1);
                _type[nIndex - 1] = Convert.ToInt32(sLetter);
                switch (_type[nIndex - 1])
                {
                    case 1:
                        sBait2 = "1234";
                        break;
                    case 2:
                        sBait2 = "12";
                        break;
                    case 3:
                        sBait2 = "12";
                        break;
                    case 4:
                        sBait2 = "1";
                        break;
                    default:
                        sBait2 = "1";
                        break;
                }
                nPos2 = rnd1.Next(1, sBait2.Length + 1);
                sLetter = sBait2.Substring(nPos2 - 1, 1);
                _number[nIndex - 1] = Convert.ToInt32(sLetter);
                if (nPos == 1)
                {
                    sBait = sBait.Substring(nPos, nLength - nPos);
                }
                else
                {
                    sBait = sBait.Substring(0, nPos - 1) + sBait.Substring(nPos, nLength - nPos);
                }
                nLength = sBait.Length;
            } while (nLength > 0);

            nType = _type[0];
            nNumber = _number[0];
            switch (nType)
            {
                case 1:
                    sWord = _place1[nNumber - 1];
                    break;
                case 2:
                    sWord = _place2[nNumber - 1];
                    break;
                case 3:
                    sWord = _place3[nNumber - 1];
                    break;
                case 4:
                    sWord = _place4[nNumber - 1];
                    break;
                default:
                    sWord = _place5[nNumber - 1];
                    break;
            }
            lbl1.Text = sWord;
            nType = _type[1];
            nNumber = _number[1];
            switch (nType)
            {
                case 1:
                    sWord = _place1[nNumber - 1];
                    break;
                case 2:
                    sWord = _place2[nNumber - 1];
                    break;
                case 3:
                    sWord = _place3[nNumber - 1];
                    break;
                case 4:
                    sWord = _place4[nNumber - 1];
                    break;
                default:
                    sWord = _place5[nNumber - 1];
                    break;
            }
            lbl2.Text = sWord;
            nType = _type[2];
            nNumber = _number[2];
            switch (nType)
            {
                case 1:
                    sWord = _place1[nNumber - 1];
                    break;
                case 2:
                    sWord = _place2[nNumber - 1];
                    break;
                case 3:
                    sWord = _place3[nNumber - 1];
                    break;
                case 4:
                    sWord = _place4[nNumber - 1];
                    break;
                default:
                    sWord = _place5[nNumber - 1];
                    break;
            }
            lbl3.Text = sWord;
            nType = _type[3];
            nNumber = _number[3];
            switch (nType)
            {
                case 1:
                    sWord = _place1[nNumber - 1];
                    break;
                case 2:
                    sWord = _place2[nNumber - 1];
                    break;
                case 3:
                    sWord = _place3[nNumber - 1];
                    break;
                case 4:
                    sWord = _place4[nNumber - 1];
                    break;
                default:
                    sWord = _place5[nNumber - 1];
                    break;
            }
            lbl4.Text = sWord;
            nType = _type[4];
            nNumber = _number[4];
            switch (nType)
            {
                case 1:
                    sWord = _place1[nNumber - 1];
                    break;
                case 2:
                    sWord = _place2[nNumber - 1];
                    break;
                case 3:
                    sWord = _place3[nNumber - 1];
                    break;
                case 4:
                    sWord = _place4[nNumber - 1];
                    break;
                default:
                    sWord = _place5[nNumber - 1];
                    break;
            }
            lbl5.Text = sWord;

            if (lst1.Items.Count > 0)
            {

                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }

            for (int i = 1; i <= 14; i++)
            {
                sWord = _relations[i - 1] + " = ";
                lst1.Items.Add(sWord);
            }

        }

    }
}

