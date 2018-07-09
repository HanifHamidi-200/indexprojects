using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typeouts
{
    public partial class Form1 : Form
    {
        String sCode = null;
        int nNumber;
        private static List<String> _bar = new List<string> { null, null, null, null };
        private static List<int> _nodes = new List<int> { 0,0,0,0 };

        private void fWorking()
        {
            Random rnd1 = new Random();
            int nTotal=0;
            String sText;
            int nCount;
            int nLength;
            String sLetter;
            int nValue;
            int nAdd;
            int nTowers, nCalculater;

            if (lst1.Items.Count == 0)
            {
                MessageBox.Show("Error!");
                return;
            }

            nCount = lst1.Items.Count;
            for (int i = 1; i <= nCount; i++)
            {
                sText = (String)lst1.Items[i-1];
                nLength = sText.Length;
                sLetter = sText.Substring(nLength - 3, 1);
                nValue = Convert.ToInt32(sLetter);
                for (int j = 1; j <= nValue; j++)
                {
                    nAdd = rnd1.Next(2000, 6001);
                    nTotal += nAdd;
                }
            }

            if (nTotal < 60000)
            {
                sText=Convert.ToString(nTotal)+"/60000";
                MessageBox.Show(sText, "NotWorking!");
            }
            else
            {
                nTowers = rnd1.Next(600, 1001);
                nCalculater = rnd1.Next(40, 20001);
                sText = "Towers = " + Convert.ToString(nTowers) + "<br>" + "Calculater = " + Convert.ToString(nCalculater);
                MessageBox.Show(sText, "WORKING");
                fReset();
                fClear();
            }
        }

        private void fReset()
        {
            Random rnd1 = new Random();
            int nTimes = rnd1.Next(4, 10);
            int nLength;
            String sWord;
            char sLetter;

            sCode = null;
            sWord = null;
            for (int i = 1; i <= nTimes; i++)
            {
                sLetter = (char)(rnd1.Next(1, 27) + 64);
                nLength = rnd1.Next(1, 5);
                for (int j = 1; j <= nLength; j++)
                {
                    sWord = sWord + sLetter;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 2)
                {
                    sWord = sWord + "$";
                }
            }
            sCode = sWord;
            txtCode.Text = sCode;

        }
        private void fClear()
        {
            for (int i = 1; i <= 4; i++)
            {
                _bar[i - 1] = null;
                _nodes[i - 1] = 0;
            }

            if (_bar[0] == null)
            {
                lblBar1.Text = "#null";
            }
            else
            {
                lblBar1.Text = _bar[0];
            }
            if (_bar[1] == null)
            {
                lblBar2.Text = "#null";
            }
            else
            {
                lblBar2.Text = _bar[1];
            }
            if (_bar[2] == null)
            {
                lblBar3.Text = "#null";
            }
            else
            {
                lblBar3.Text = _bar[2];
            }
            if (_bar[3] == null)
            {
                lblBar4.Text = "#null";
            }
            else
            {
                lblBar4.Text = _bar[3];
            }
            lblNodes1.Text = "nodes[" + Convert.ToString(_nodes[0]) + "]";
            lblNodes2.Text = "nodes[" + Convert.ToString(_nodes[1]) + "]";
            lblNodes3.Text = "nodes[" + Convert.ToString(_nodes[2]) + "]";
            lblNodes4.Text = "nodes[" + Convert.ToString(_nodes[3]) + "]";

            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }
        }

        private void fPick(int nMode)
        {
            Random rnd1 = new Random();
            String sText = txtCode.SelectedText;
            String sWord = null;
            int nNodes = rnd1.Next(2, 7);

            if (sText == null)
            {
                return;
            }

            sText = sText.Substring(0, 1);
            for (int i = 1; i <= 10; i++)
            {
                sWord = sWord + sText;
            }

            switch (nMode)
            {
                case 1:
                    lblBar1.Text = sWord;
                    lblNodes1.Text = "nodes[" + Convert.ToString(nNodes) + "]";
                    _bar[0] = sWord;
                    _nodes[0] = nNodes;
                    break;
                case 2:
                    lblBar2.Text = sWord;
                    lblNodes2.Text = "nodes[" + Convert.ToString(nNodes) + "]";
                    _bar[1] = sWord;
                    _nodes[1] = nNodes;
                    break;
                case 3:
                    lblBar3.Text = sWord;
                    lblNodes3.Text = "nodes[" + Convert.ToString(nNodes) + "]";
                    _bar[2] = sWord;
                    _nodes[2] = nNodes;
                    break;
                default:
                    lblBar4.Text = sWord;
                    lblNodes4.Text = "nodes[" + Convert.ToString(nNodes) + "]";
                    _bar[3] = sWord;
                    _nodes[3] = nNodes;
                    break;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
            fClear();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            fReset();
            fClear();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
             fClear();

        }

        private void lblBar1_Click(object sender, EventArgs e)
        {
            fPick(1);
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {

            String sText;

            if (_bar[0] == null)
            {
                MessageBox.Show("Error!");
                return;
            }
            else
            {
                sText = "[" + lblBar1.Text + "," + lblNodes1.Text + "]";
                lst1.Items.Add(sText);
                _bar[0] = null;
                _nodes[0] = 0;
                lblBar1.Text = "#null";
                lblNodes1.Text = "nodes[0]";
            }
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {

            String sText;

            if (_bar[1] == null)
            {
                MessageBox.Show("Error!");
                return;
            }
            else
            {
                sText = "[" + lblBar2.Text + "," + lblNodes2.Text + "]";
                lst1.Items.Add(sText);
                _bar[1] = null;
                _nodes[1] = 0;
                lblBar2.Text = "#null";
                lblNodes2.Text = "nodes[0]";
            }

        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {

            String sText;

            if (_bar[2] == null)
            {
                MessageBox.Show("Error!");
                return;
            }
            else
            {
                sText = "[" + lblBar3.Text + "," + lblNodes3.Text + "]";
                lst1.Items.Add(sText);
                _bar[2] = null;
                _nodes[2] = 0;
                lblBar3.Text = "#null";
                lblNodes3.Text = "nodes[0]";
            }

        }

        private void btnAdd4_Click(object sender, EventArgs e)
        {

            String sText;

            if (_bar[3] == null)
            {
                MessageBox.Show("Error!");
                return;
            }
            else
            {
                sText = "[" + lblBar4.Text + "," + lblNodes4.Text + "]";
                lst1.Items.Add(sText);
                _bar[3] = null;
                _nodes[3] = 0;
                lblBar4.Text = "#null";
                lblNodes4.Text = "nodes[0]";
            }

        }

        private void lblBar2_Click(object sender, EventArgs e)
        {
            fPick(2);

        }

        private void lblBar3_Click(object sender, EventArgs e)
        {
            fPick(3);

        }

        private void lblBar4_Click(object sender, EventArgs e)
        {
            fPick(4);

        }

        private void btnWorking_Click(object sender, EventArgs e)
        {
            fWorking();
        }
    }
}
