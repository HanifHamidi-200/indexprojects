using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trendsetter
{
    public partial class Form1 : Form
    {
        private String sCardsAvailable = null;
        private static List<String> _display = new List<string> { null, null, null, null, null };
        private static List<String> _list = new List<string> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private int mnListCount;

        private void fReset()
        {
            Random rnd1 = new Random();
            String sWord = null;

            mnListCount = 0;
            if (lstCards.Items.Count > 0)
            {
                do
                {
                    lstCards.Items.RemoveAt(0);
                } while (lstCards.Items.Count > 0);
            }

            sCardsAvailable = null;
            for (int i = 1; i <= 13; i++)
            {
                sWord = Convert.ToString(i);
                if (sWord == "10")
                {
                    sWord = "T";
                }
                if (sWord == "11")
                {
                    sWord = "J";
                }
                if (sWord == "12")
                {
                    sWord = "Q";
                }
                if (sWord == "13")
                {
                    sWord = "K";
                }
                sWord = sWord + "S";
                sCardsAvailable = sCardsAvailable + sWord;
            }

            for (int i = 1; i <= 13; i++)
            {
                sWord = Convert.ToString(i);
                if (sWord == "10")
                {
                    sWord = "T";
                }
                if (sWord == "11")
                {
                    sWord = "J";
                }
                if (sWord == "12")
                {
                    sWord = "Q";
                }
                if (sWord == "13")
                {
                    sWord = "K";
                }
                sWord = sWord + "H";
                sCardsAvailable = sCardsAvailable + sWord;
            }
            for (int i = 1; i <= 13; i++)
            {
                sWord = Convert.ToString(i);
                if (sWord == "10")
                {
                    sWord = "T";
                }
                if (sWord == "11")
                {
                    sWord = "J";
                }
                if (sWord == "12")
                {
                    sWord = "Q";
                }
                if (sWord == "13")
                {
                    sWord = "K";
                }
                sWord = sWord + "C";
                sCardsAvailable = sCardsAvailable + sWord;
            }
            for (int i = 1; i <= 13; i++)
            {
                sWord = Convert.ToString(i);
                if (sWord == "10")
                {
                    sWord = "T";
                }
                if (sWord == "11")
                {
                    sWord = "J";
                }
                if (sWord == "12")
                {
                    sWord = "Q";
                }
                if (sWord == "13")
                {
                    sWord = "K";
                }
                sWord = sWord + "D";
                sCardsAvailable = sCardsAvailable + sWord;
            }
        }

        private String fPick()
        {
            Random rnd1 = new Random();
            int nLength = sCardsAvailable.Length / 2;
            int nPos = rnd1.Next(1, nLength + 1);
            String sCard;

            if (nLength == 0)
            {
                MessageBox.Show("Error!");
                return "0";
            }
            sCard = sCardsAvailable.Substring(nPos * 2 - 2, 2);
            sCardsAvailable = sCardsAvailable.Substring(0, nPos * 2 - 2) + sCardsAvailable.Substring(nPos * 2, nLength*2 - nPos * 2);
            return sCard;
        }

        private void fUpdateDisplay()
        {
            String sCard = null;
            String sText = null;

            for (int i = 1; i <= 5; i++)
            {
                sCard = _display[i - 1];
                switch (sCard.Substring(1, 1))
                {
                    case "S":
                        sText = "SPADES";
                        break;
                    case "H":
                        sText = "HEARTS";
                        break;
                    case "C":
                        sText = "CLUBS";
                        break;
                    case "D":
                        sText = "DIAMONDS";
                        break;
                    default:
                        sText = "[TAKEN]";
                        break;
                }
                switch (sCard.Substring(0, 1))
                {
                    case "*":
                        break;
                    case "T":
                        sText = "10" + sText;
                        break;
                    case "J":
                        sText = "Jack" + sText;
                        break;
                    case "Q":
                        sText = "Queen" + sText;
                        break;
                    case "K":
                        sText = "King" + sText;
                        break;
                    default:
                        sText = sCard.Substring(0, 1) + sText;
                        break;
                }
                switch (i)
                {
                    case 1:
                        btnCard1.Text = sText;
                        break;
                    case 2:
                        btnCard2.Text = sText;
                        break;
                    case 3:
                        btnCard3.Text = sText;
                        break;
                    case 4:
                        btnCard4.Text = sText;
                        break;
                   default:
                        btnCard5.Text = sText;
                        break;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String sCard = null;

            fReset();

            for (int i = 1; i <= 5; i++)
            {
                sCard = fPick();
                _display[i - 1] = sCard;
            }

            fUpdateDisplay();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            String sCard = null;

            fReset();

            for (int i = 1; i <= 5; i++)
            {
                sCard = fPick();
                _display[i - 1] = sCard;
            }

            fUpdateDisplay();

        }

        private void btnCard1_Click(object sender, EventArgs e)
        {
            String sText = btnCard1.Text;

             if (_display[0] == "**")
            {
                MessageBox.Show("Error!");
            }
            else
            {
                mnListCount += 1;
                if (mnListCount > 20)
                {
                    MessageBox.Show("Error!");
                    return;
                }
                _list[mnListCount - 1] = _display[0];
                lstCards.Items.Add(sText);
                _display[0] = "**";
                btnCard1.Text = "[TAKEN]";
            }
        }

        private void btnCard2_Click(object sender, EventArgs e)
        {
            String sText = btnCard2.Text;

            if (_display[1] == "**")
            {
                MessageBox.Show("Error!");
            }
            else
            {
                mnListCount += 1;
                if (mnListCount > 20)
                {
                    MessageBox.Show("Error!");
                    return;
                }
                _list[mnListCount - 1] = _display[1];
                lstCards.Items.Add(sText);
                _display[1] = "**";
                btnCard2.Text = "[TAKEN]";
            }
        }

        private void btnCard3_Click(object sender, EventArgs e)
        {
            String sText = btnCard3.Text;

            if (_display[2] == "**")
            {
                MessageBox.Show("Error!");
            }
            else
            {
                mnListCount += 1;
                if (mnListCount > 20)
                {
                    MessageBox.Show("Error!");
                    return;
                }
                _list[mnListCount - 1] = _display[2];
                lstCards.Items.Add(sText);
                _display[2] = "**";
                btnCard3.Text = "[TAKEN]";
            }
        }

        private void btnCard4_Click(object sender, EventArgs e)
        {
            String sText = btnCard4.Text;

            if (_display[3] == "**")
            {
                MessageBox.Show("Error!");
            }
            else
            {
                mnListCount += 1;
                if (mnListCount > 20)
                {
                    MessageBox.Show("Error!");
                    return;
                }
                _list[mnListCount - 1] = _display[3];
                lstCards.Items.Add(sText);
                _display[3] = "**";
                btnCard4.Text = "[TAKEN]";
            }
        }

        private void btnCard5_Click(object sender, EventArgs e)
        {
            String sText = btnCard5.Text;

            if (_display[4] == "**")
            {
                MessageBox.Show("Error!");
            }
            else
            {
                mnListCount += 1;
                if (mnListCount > 20)
                {
                    MessageBox.Show("Error!");
                    return;
                }
                _list[mnListCount - 1] = _display[4];
                lstCards.Items.Add(sText);
                _display[4] = "**";
                btnCard5.Text = "[TAKEN]";
            }
        }

        private void btnTwist_Click(object sender, EventArgs e)
        {
            String sCard = null;

            for (int i = 1; i <= 5; i++)
            {
                sCard = fPick();
                _display[i - 1] = sCard;
            }

            fUpdateDisplay();

        }
    }
}

