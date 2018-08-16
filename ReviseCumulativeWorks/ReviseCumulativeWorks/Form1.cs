using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReviseCumulativeWorks
{
    public partial class Form1 : Form
    {
        private List<String> _date = new List<string> { null, null, null, null, null, null, null, null, null, null };
        private List<String> _text1 = new List<string> { null, null, null, null, null, null, null, null, null, null };
        private List<String> _text2 = new List<string> { null, null, null, null, null, null, null, null, null, null };
        private List<int> _combo1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _combo2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _combo3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _number1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _number2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _number3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _number4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private int mnCount;
        private cItem _item = new cItem();


        private void fResetDisplay()
        {
            txtDate.Text = null;
            txt1.Text = null;
            txt2.Text = null;
            cmb1.SelectedIndex = 0;
            cmb2.SelectedIndex = 0;
            cmb3.SelectedIndex = 0;
            txtNumbers1.Text = "0";
            txtNumbers2.Text = "0";
            txtNumbers3.Text = "0";
            txtNumbers4.Text = "0";
        }


        private void fAdd()
        { 

            String sDate = txtDate.Text;
            String sText1 = txt1.Text;
            String sText2 = txt2.Text;
            int nCombo1 = cmb1.SelectedIndex;
            int nCombo2 = cmb2.SelectedIndex;
            int nCombo3 = cmb3.SelectedIndex;
            int nNumber1, nNumber2, nNumber3, nNumber4;
            String sText;

            if (txtNumbers1.Text == null)
            {
                nNumber1 = 0;
            }
            else
            {
                nNumber1 = Convert.ToInt32(txtNumbers1.Text);
            }
            if (txtNumbers2.Text == null)
            {
                nNumber2 = 0;
            }
            else
            {
                nNumber2 = Convert.ToInt32(txtNumbers2.Text);
            }
            if (txtNumbers3.Text == null)
            {
                nNumber3 = 0;
            }
            else
            {
                nNumber3 = Convert.ToInt32(txtNumbers3.Text);
            }
            if (txtNumbers4.Text == null)
            {
                nNumber4 = 0;
            }
            else
            {
                nNumber4 = Convert.ToInt32(txtNumbers4.Text);
            }
            mnCount += 1;

            _item.fSet(mnCount, sDate, sText1, sText2, nCombo1, nCombo2, nCombo3, nNumber1, nNumber2, nNumber3, nNumber4);
            sText = _item.fGet();
            lst1.Items.Add(sText);
        }



        public Form1()
        {
            InitializeComponent();
            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }
        }

     
        private void Form1_Load(object sender, EventArgs e)
        {
            fResetDisplay();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            fAdd();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lst1.Items.RemoveAt(mnCount - 1);
            mnCount -= 1;
            fResetDisplay();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }
            mnCount = 0;
            fResetDisplay();
        }

        private void btn5_Click(object sender, EventArgs e)
        {

        }
    }
}
