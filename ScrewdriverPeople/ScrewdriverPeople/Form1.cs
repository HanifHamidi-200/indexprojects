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
        private static List<int> _number = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private static List<String> _items = new List<String> { "carrier", "copier", "dataanalysis", "hmax", "hmin", "intercepter", "locater", "manipulater", "multiplexor", "organiser", "originater", "porter", "printer", "replier", "screw", "translater" };
        private int mnCount = 16;
        private int mnNeeded, mnQuantity;
        private int mnItem = 0;
        private int nScore;

        private void fReset()
        {
            Random rnd1 = new Random();
            mnNeeded = rnd1.Next(1, mnCount + 1);
            mnQuantity = rnd1.Next(1, 10);
            String sWord = null;

            for (int i = 1; i <= mnCount; i++)
            {
                _number[i - 1] = 0;
            }

            fUpdateDisplay1();
            fUpdateDisplay2();
            sWord = "x" + Convert.ToString(mnQuantity) + _items[mnNeeded - 1];
            sWord = "NEEDED = " + sWord;
            lblNeeded.Text = sWord;
        }

        private void fUpdateDisplay1()
        {
            String sWord;

            if (lstGot.Items.Count > 0)
            {

                do
                {
                    lstGot.Items.RemoveAt(0);
                } while (lstGot.Items.Count > 0);
            }

            for (int i = 1; i <= mnCount; i++)
            {
                sWord = "x" + Convert.ToString(_number[i - 1]) +_items[i - 1];
                 lstGot.Items.Add(sWord);
              }
    }
    

    private void fUpdateDisplay2()
    {
        if (lstShop.Items.Count > 0)
        {

            do
            {
                lstShop.Items.RemoveAt(0);
            } while (lstShop.Items.Count > 0);
        }


    }

    public Form1()
        {
            InitializeComponent();
            nScore = 0;
            lblScore.Text = "Score = 0";
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
                nNeeded = rnd1.Next(1, mnCount+1);
                nQuantity = rnd1.Next(1, 10);
                    sWord2 = "x[" + Convert.ToString(nQuantity) + "]"+_items[mnNeeded-1];
               sWord = sWord + sWord2;
            lstShop.Items.Add(sWord);
        }
    }

        private void btnTake_Click(object sender, EventArgs e)
        {
            String sList;
            int nPos;
            int nNeeded, nQuantity;
            String sLetter;
         
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
                            sLetter = sList.Substring(nPos - 1,3);
                             switch (sLetter)
                            {
                                case "car":
                                    nNeeded = 1;
                                    break;
                                case "cop":
                                    nNeeded = 2;
                                    break;
                                case "dat":
                                    nNeeded = 3;
                                    break;
                                case "hma":
                                    nNeeded = 4;
                                    break;
                                case "hmi":
                                    nNeeded = 5;
                                    break;
                            case "int":
                                nNeeded = 6;
                                break;
                            case "loc":
                                nNeeded = 7;
                                break;
                            case "man":
                                nNeeded = 8;
                                break;
                            case "mul":
                                nNeeded = 9;
                                break;
                            case "org":
                                nNeeded = 10;
                                break;
                            case "ori":
                                nNeeded = 11;
                                break;
                            case "por":
                                nNeeded = 12;
                                break;
                            case "pri":
                                nNeeded = 13;
                                break;
                            case "rep":
                                nNeeded = 14;
                                break;
                            case "scr":
                                nNeeded = 15;
                                break;
                            default:
                                nNeeded = 16;
                                break;
                        }
                        _number[nNeeded - 1] += nQuantity;
                        }
                    } while (nPos < sList.Length);

                fUpdateDisplay1();
                   
                    lstShop.Items.RemoveAt(mnItem - 1);
                    nScore += 10;
                    lblScore.Text = "Score = " + Convert.ToString(nScore);
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nNeeded1=mnNeeded, nQuantity1=mnQuantity;
            int nQuantity2=_number[nNeeded1-1];
            String sWord;

            if (nQuantity2 >= nQuantity1)
            {
                _number[nNeeded1 - 1] -= nQuantity1;
                mnNeeded = rnd1.Next(1, 5);
                mnQuantity = rnd1.Next(1, 10);
                  sWord = "x" + Convert.ToString(mnQuantity) + _items[mnNeeded-1];
                    sWord = "NEEDED = " + sWord;
                lblNeeded.Text = sWord;
            fUpdateDisplay1();
                nScore += 100;
                lblScore.Text = "Score = " + Convert.ToString(nScore);
            }
            else
            {
                MessageBox.Show("You have ruined everything!", "GameEnded");
                fReset();
            }
        }

        private void lstShop_SelectedIndexChanged(object sender, EventArgs e)
        {
            mnItem = lstShop.SelectedIndex + 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }    
}}
