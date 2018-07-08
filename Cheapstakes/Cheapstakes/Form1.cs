using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cheapstakes
{
    public partial class Form1 : Form
    {
        private static List<String> _db = new List<String> { null,null,null,null , null, null, null, null };
        private static List<bool> _dbLetter = new List<bool> { true,true,true,true, true, true, true, true, };
        private static List<bool> _dbLetter2 = new List<bool> { true, true, true, true, true, true, true, true, };
        private int nNumber;
        private String sWord1, sWord3;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            String sCheck = txt2.Text;
            int nLength = sCheck.Length;
            String sLetter1, sLetter2;
            String sNew = "--------";

            if (nLength > 8)
            {
                nLength = 8;
            }
            for (int i = 1; i <= nLength; i++)
            {
                sLetter1 = sCheck.Substring(i - 1, 1);
                sLetter2 = sWord3.Substring(i - 1, 1);
                if (sLetter1 == sLetter2)
                {
                    sNew = sNew.Substring(0, i - 1) + sLetter1+sNew.Substring(i, nLength - i);
                }
            }
            txt3.Text = sNew;
        }

        private void btnComply_Click(object sender, EventArgs e)
        {
            if (txt3.Text == sWord3)
            {
                MessageBox.Show("You've won!!!", "GameEnded");
                Random rnd1 = new Random();
                String sWord = null;
                char sLetter;
                String sOld, sNew, sLetter2;
                String sLeft = null, sRight = null;
                int nPos, nLength;

                for (int i = 1; i <= 8; i++)
                {
                    nNumber = rnd1.Next(1, 10);
                    if (nNumber <= 5)
                    {
                        _dbLetter[i - 1] = true;
                    }
                    else
                    {
                        _dbLetter[i - 1] = false;
                    }
                    _dbLetter2[i - 1] = _dbLetter[i - 1];
                    if (_dbLetter[i - 1] == true)
                    {
                        sLetter = (char)(rnd1.Next(1, 27) + 64);
                        sWord = sWord + Convert.ToString(sLetter);
                    }
                    else
                    {
                        sWord = sWord + Convert.ToString(rnd1.Next(1, 10));
                    }
                }
                sWord1 = sWord;
                txt1.Text = sWord;
                sOld = sWord;
                sNew = null;
                for (int i = 1; i <= 8; i++)
                {
                    nLength = 9 - i;
                    nPos = rnd1.Next(1, nLength + 1);
                    sLetter2 = sOld.Substring(nPos - 1, 1);
                    switch (_dbLetter2[nPos - 1])
                    {
                        case true:
                            sLeft = sLeft + sLetter2;
                            break;
                        default:
                            sRight = sRight + sLetter2;
                            break;
                    }
                     sOld = sOld.Substring(0, nPos - 1) + sOld.Substring(nPos, nLength - nPos);
                    for (int j = nPos ; j <= nLength-1; j++)
                    {
                        _dbLetter2[j-1] = _dbLetter2[j];
                    }
                }
                sNew = sLeft + sRight;
                sWord3 = sNew;
                txt2.Text = null;
                txt3.Text = "--------";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            String sWord = null;
            char sLetter;
            String sOld, sNew, sLetter2;
            String sLeft = null, sRight = null;
            int nPos, nLength;

            for (int i = 1; i <= 8; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    _dbLetter[i - 1] = true;
                }
                else
                {
                    _dbLetter[i - 1] = false;
                }
                _dbLetter2[i - 1] = _dbLetter[i - 1];
                if (_dbLetter[i - 1] == true)
                {
                    sLetter = (char)(rnd1.Next(1, 27) + 64);
                    sWord = sWord + Convert.ToString(sLetter);
                }
                else
                {
                    sWord = sWord + Convert.ToString(rnd1.Next(1, 10));
                }
            }
            sWord1 = sWord;
            txt1.Text = sWord;
            sOld = sWord;
            sNew = null;
            for (int i = 1; i <= 8; i++)
            {
                nLength = 9 - i;
                nPos = rnd1.Next(1, nLength + 1);
                sLetter2 = sOld.Substring(nPos - 1, 1);
                switch (_dbLetter2[nPos - 1])
                {
                    case true:
                        sLeft = sLeft + sLetter2;
                        break;
                    default:
                        sRight = sRight + sLetter2;
                        break;
                }
                sOld = sOld.Substring(0, nPos - 1) + sOld.Substring(nPos, nLength - nPos);
                for (int j = nPos; j <= nLength - 1; j++)
                {
                    _dbLetter2[j - 1] = _dbLetter2[j];
                }
            }
            sNew = sLeft + sRight;
            sWord3 = sNew;
            txt2.Text = null;
            txt3.Text = "--------";
        }
    }
}
