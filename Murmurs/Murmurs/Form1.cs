using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Murmurs
{
    public partial class Form1 : Form
    {

        private static List<String> _list = new List<String> { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
        private int mnCount;
        private int nNumber;

        private void fReset()
        {
            Random rnd1 = new Random();
            int nSyllables = rnd1.Next(4, 12);
            String sWord;
            String sMurmur, sMurmur2;

            mnCount = rnd1.Next(10, 21);

            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }
            txt1.Text = null;

            for (int i = 1; i <= mnCount; i++)
            {
                sWord = fMurmur();
                for (int j = 1; j <= nSyllables - 1; j++)
                {
                    sMurmur = fMurmur();
                    nNumber = rnd1.Next(1, 10);

                    if (nNumber <= 5)
                    {
                        sMurmur2 = sWord + sMurmur;
                    }
                    else
                    {
                        sMurmur2 = sMurmur + sWord;
                    }
                    nNumber = rnd1.Next(1, 10);
                    if (nNumber <= 2)
                    {
                        sMurmur2 = "<" + sMurmur2 + ">";
                    }
                    sWord = sMurmur2;
                }
                lst1.Items.Add(sWord);
            }

        }

        private String fMurmur()
        {
            Random rnd1 = new Random();
            int nLength = rnd1.Next(1, 5);
            char sLetter;
            String sWord=null;

            for(int i = 1; i <= nLength; i++){
                sLetter = (char)(rnd1.Next(1, 27) + 64);
                sWord = sWord + sLetter;
            }

            sWord = "<" + sWord + ">";
            return sWord;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void lst1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt1.Text = lst1.Text;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
             Clipboard.SetText(txt1.Text);
        }
    }
}
