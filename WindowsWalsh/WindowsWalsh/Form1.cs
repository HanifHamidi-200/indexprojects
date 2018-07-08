using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsWalsh
{
    public partial class Form1 : Form
    {

        private static List<int> _count = new List<int> { 3,1,1,1,0 };
        private static List<String> _text1 = new List<String> { "HexEdit","ProjectManagerButtons","MarginControl (HP,SP,AC)"};
        private static List<String> _text2 = new List<String> { "Your Wallet!" };
        private static List<String> _text3 = new List<String> { "fat version control" };
        private static List<String> _text4 = new List<String> { "resconded manner" };
        private static List<String> _text5 = new List<String> { null };
        private int mnMode;

        private void fUpdateDisplay()
        {
            String sText = null;
            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }
            for (int i = 1; i <= _count[mnMode - 1]; i++)
            {
                switch (mnMode)
                {
                    case 1:
                        sText = _text1[i - 1];
                        break;
                    case 2:
                        sText = _text2[i - 1];
                        break;
                    case 3:
                        sText = _text3[i - 1];
                        break;
                    case 4:
                        sText = _text4[i - 1];
                        break;
                    default:
                        sText = _text5[i - 1];
                        break;
                }
                lst1.Items.Add(sText);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            mnMode = rnd1.Next(1, 6);
            fUpdateDisplay();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            mnMode = 1;
            fUpdateDisplay();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            mnMode = 2;
            fUpdateDisplay();


        }

        private void btn3_Click(object sender, EventArgs e)
        {
            mnMode = 3;
            fUpdateDisplay();


        }

        private void btn4_Click(object sender, EventArgs e)
        {
            mnMode = 4;
            fUpdateDisplay();


        }

        private void btn5_Click(object sender, EventArgs e)
        {
            mnMode = 5;
            fUpdateDisplay();


        }
    }
}
