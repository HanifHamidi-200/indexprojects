using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pMoAgain
{
    public partial class pMoAgain : Form
    {
        private String sDefault1 = "BelcritDesignsExample";
        private String sDefault2 = "ForestierPropertiesExample";
        private static List<int> _numbers = new List<int> { 0, 0, 0, 0, 0, 0};
        private static List<String> _analysis = new List<String> { "CDHIJKOSTU","AEGMNPRV","BFLQWXYZ" };
        private static List<String> _text = new List<String> { null,null,null };

        public pMoAgain()
        {
            InitializeComponent();
        }

        private void pMoAgain_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nLength, nPos;
            String sLetter;
            int nNumber;

            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }
            lst1.Items.Add(sDefault1);
            lst1.Items.Add(sDefault2);
            txt11.Text = null;
            txt12.Text = null;
            txt21.Text = null;
            txt22.Text = null;
            txt31.Text = null;
            txt32.Text = null;

            nLength = _analysis[0].Length;
            nPos = rnd1.Next(1, nLength + 1);
            sLetter = _analysis[0].Substring(nPos - 1, 1);
            nNumber = rnd1.Next(100, 501);
            _text[0] = sLetter + "-" + Convert.ToString(nNumber);

            nLength = _analysis[1].Length;
            nPos = rnd1.Next(1, nLength + 1);
            sLetter = _analysis[1].Substring(nPos - 1, 1);
            nNumber = rnd1.Next(100, 501);
            _text[1] = sLetter + "-" + Convert.ToString(nNumber);

            nLength = _analysis[2].Length;
            nPos = rnd1.Next(1, nLength + 1);
            sLetter = _analysis[2].Substring(nPos - 1, 1);
            nNumber = rnd1.Next(100, 501);
            _text[2] = sLetter + "-" + Convert.ToString(nNumber);

        }

        private void btnReset1_Click(object sender, EventArgs e)
        {
            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }
            lst1.Items.Add(sDefault1);
            lst1.Items.Add(sDefault2);

        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nLength, nPos;
            String sLetter;
            int nNumber;

            txt11.Text = null;
            txt12.Text = null;
            txt21.Text = null;
            txt22.Text = null;
            txt31.Text = null;
            txt32.Text = null;

            nLength = _analysis[0].Length;
            nPos = rnd1.Next(1, nLength + 1);
            sLetter = _analysis[0].Substring(nPos - 1, 1);
            nNumber = rnd1.Next(100, 501);
            _text[0] = sLetter + "-" + Convert.ToString(nNumber);

            nLength = _analysis[1].Length;
            nPos = rnd1.Next(1, nLength + 1);
            sLetter = _analysis[1].Substring(nPos - 1, 1);
            nNumber = rnd1.Next(100, 501);
            _text[1] = sLetter + "-" + Convert.ToString(nNumber);

            nLength = _analysis[2].Length;
            nPos = rnd1.Next(1, nLength + 1);
            sLetter = _analysis[2].Substring(nPos - 1, 1);
            nNumber = rnd1.Next(100, 501);
            _text[2] = sLetter + "-" + Convert.ToString(nNumber);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String sAdd = txtAdd.Text;
            lst1.Items.Add(sAdd);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_text[0], "Information");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_text[1], "Information");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_text[2], "Information");
        }
    }
}
