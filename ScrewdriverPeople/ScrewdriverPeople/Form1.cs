using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrewdriverPeople
{
    public partial class Form1 : Form
    {
        private static List<int> _number = new List<int> { 0, 0, 0, 0 ,0,0,0};
        private int mnNeeded,mnQuantity;
        private int mnItem = 0;

        private void fReset()
        {
            Random rnd1 = new Random();
            mnNeeded = rnd1.Next(1, 5);
            mnQuantity = rnd1.Next(1, 10);
            String sWord;

            for (int i = 1; i <= 4; i++)
            {
                _number[i - 1] = 0;
            }
            if (lstGot.Items.Count > 0)
            {

                do
                {
                    lstGot.Items.RemoveAt(0);
                } while (lstGot.Items.Count > 0);
            }
            if (lstShop.Items.Count > 0)
            {

                do
                {
                    lstShop.Items.RemoveAt(0);
                } while (lstShop.Items.Count > 0);
            }

            sWord = "x" + Convert.ToString(_number[0]) + "screw";
            lstGot.Items.Add(sWord);
            sWord = "x" + Convert.ToString(_number[1]) + "multiplexor";
            lstGot.Items.Add(sWord);
            sWord = "x" + Convert.ToString(_number[2]) + "locater";
            lstGot.Items.Add(sWord);
            sWord = "x" + Convert.ToString(_number[3]) + "intercepter";
            lstGot.Items.Add(sWord);
            sWord = "x" + Convert.ToString(_number[4]) + "dataanalysis";
            lstGot.Items.Add(sWord);
            sWord = "x" + Convert.ToString(_number[5]) + "hmax";
            lstGot.Items.Add(sWord);
            sWord = "x" + Convert.ToString(_number[6]) + "hmin";
            lstGot.Items.Add(sWord);

            switch (mnNeeded)
            {
                case 1:
                    sWord = "x" + Convert.ToString(mnQuantity) + "screw";
                    break;
                case 2:
                    sWord = "x" + Convert.ToString(mnQuantity) + "multiplexor";
                    break;
                case 3:
                    sWord = "x" + Convert.ToString(mnQuantity) + "locater";
                    break;
                case 4:
                    sWord = "x" + Convert.ToString(mnQuantity) + "intercepter";
                    break;
                case 5:
                    sWord = "x" + Convert.ToString(mnQuantity) + "dataanalysis";
                    break;
                case 6:
                    sWord = "x" + Convert.ToString(mnQuantity) + "hmax";
                    break;
                default:
                    sWord = "x" + Convert.ToString(mnQuantity) + "hmin";
                    break;
            }
            sWord = "NEEDED = " + sWord;
            lblNeeded.Text = sWord;
        }

    
    public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nTimes = rnd1.Next(1, 4);
            int nNeeded ,nQuantity;
            String sWord,sWord2;

            sWord = null;
            for (int i = 1; i <= nTimes; i++)
            {
                nNeeded = rnd1.Next(1, 8);
                nQuantity = rnd1.Next(1, 10);
                switch (nNeeded)
                {
                    case 1:
                        sWord2 = "x[" + Convert.ToString(nQuantity) + "]screw ";
                        break;
                    case 2:
                        sWord2 = "x[" + Convert.ToString(nQuantity) + "]multiplexor ";
                        break;
                    case 3:
                        sWord2 = "x[" + Convert.ToString(nQuantity) + "]locater ";
                        break;
                    case 4:
                        sWord2 = "x[" + Convert.ToString(nQuantity) + "]intercepter ";
                        break;
                    case 5:
                        sWord2 = "x[" + Convert.ToString(nQuantity) + "]dataanalysis ";
                        break;
                    case 6:
                        sWord2 = "x[" + Convert.ToString(nQuantity) + "]hmax ";
                        break;
                    default:
                        sWord2 = "x[" + Convert.ToString(nQuantity) + "]hmin ";
                        break;
                }
                sWord = sWord + sWord2;
            }
            lstShop.Items.Add(sWord);
        }

        private void lstShop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstShop_MouseLeave(object sender, EventArgs e)
        {
            mnItem = lstShop.SelectedIndex + 1;
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            String sList;
            int nPos;
            int nNeeded, nQuantity;
            String sLetter;
            String sWord;

            if (mnItem == 0)
            {

            }
            else
            {
                if (mnItem > lstShop.Items.Count)
                {

                }
                else
                {
                    sList = lstShop.Items[mnItem-1].ToString();
                    nPos = 0;
                    do
                    {
                        nPos = nPos + 1;
                        if (sList.Substring(nPos - 1,1) == "[")
                        {
                            nPos = nPos + 1;
                            nQuantity = Convert.ToInt32(sList.Substring(nPos - 1,1));
                            nPos = nPos + 2;
                            sLetter = sList.Substring(nPos - 1,1);
                            switch (sLetter)
                            {
                                case "s":
                                    nNeeded = 1;
                                    break;
                                case "m":
                                    nNeeded = 2;
                                    break;
                                case "l":
                                    nNeeded = 3;
                                    break;
                                case "i":
                                    nNeeded = 4;
                                    break;
                                case "d":
                                    nNeeded = 5;
                                    break;
                                default:
                                    sLetter = sList.Substring(nPos+1 , 1);
                                    switch (sLetter)
                                    {
                                        case "a":
                                            nNeeded = 6;
                                            break;
                                        default:
                                            nNeeded = 7;
                                            break;
                                    }
                                   break;
                            }
                            _number[nNeeded - 1] += nQuantity;
                        }
                    } while (nPos < sList.Length);

                    if (lstGot.Items.Count > 0)
                    {

                        do
                        {
                            lstGot.Items.RemoveAt(0);
                        } while (lstGot.Items.Count > 0);
                    }
                    sWord = "x" + Convert.ToString(_number[0]) + "screw";
                    lstGot.Items.Add(sWord);
                    sWord = "x" + Convert.ToString(_number[1]) + "multiplexor";
                    lstGot.Items.Add(sWord);
                    sWord = "x" + Convert.ToString(_number[2]) + "locater";
                    lstGot.Items.Add(sWord);
                    sWord = "x" + Convert.ToString(_number[3]) + "intercepter";
                    lstGot.Items.Add(sWord);
                    sWord = "x" + Convert.ToString(_number[4]) + "dataanalysis";
                    lstGot.Items.Add(sWord);
                    sWord = "x" + Convert.ToString(_number[5]) + "hmax";
                    lstGot.Items.Add(sWord);
                    sWord = "x" + Convert.ToString(_number[6]) + "hmin";
                    lstGot.Items.Add(sWord);

                    lstShop.Items.RemoveAt(mnItem - 1);
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nNeeded1=mnNeeded, nQuantity1=mnQuantity;
            int nGot2, nQuantity2=_number[nNeeded1-1];
            String sWord;

            if (nQuantity2 >= nQuantity1)
            {
                _number[nNeeded1 - 1] -= nQuantity1;
                mnNeeded = rnd1.Next(1, 5);
                mnQuantity = rnd1.Next(1, 10);
                switch (mnNeeded)
                {
                    case 1:
                        sWord = "x" + Convert.ToString(mnQuantity) + "screw";
                        break;
                    case 2:
                        sWord = "x" + Convert.ToString(mnQuantity) + "multiplexor";
                        break;
                    case 3:
                        sWord = "x" + Convert.ToString(mnQuantity) + "locater";
                        break;
                    case 4:
                        sWord = "x" + Convert.ToString(mnQuantity) + "intercepter";
                        break;
                    case 5:
                        sWord = "x" + Convert.ToString(mnQuantity) + "dataanalysis";
                        break;
                    case 6:
                        sWord = "x" + Convert.ToString(mnQuantity) + "hmax";
                        break;
                    default:
                        sWord = "x" + Convert.ToString(mnQuantity) + "hmin";
                        break;
                }
                sWord = "NEEDED = " + sWord;
                lblNeeded.Text = sWord;
                if (lstGot.Items.Count > 0)
                {

                    do
                    {
                        lstGot.Items.RemoveAt(0);
                    } while (lstGot.Items.Count > 0);
                }
                sWord = "x" + Convert.ToString(_number[0]) + "screw";
                lstGot.Items.Add(sWord);
                sWord = "x" + Convert.ToString(_number[1]) + "multiplexor";
                lstGot.Items.Add(sWord);
                sWord = "x" + Convert.ToString(_number[2]) + "locater";
                lstGot.Items.Add(sWord);
                sWord = "x" + Convert.ToString(_number[3]) + "intercepter";
                lstGot.Items.Add(sWord);
                sWord = "x" + Convert.ToString(_number[4]) + "dataanalysis";
                lstGot.Items.Add(sWord);
                sWord = "x" + Convert.ToString(_number[5]) + "hmax";
                lstGot.Items.Add(sWord);
                sWord = "x" + Convert.ToString(_number[6]) + "hmin";
                lstGot.Items.Add(sWord);
            }
            else
            {
                MessageBox.Show("You have ruined everything!", "GameEnded");
                fReset();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }    }
}
