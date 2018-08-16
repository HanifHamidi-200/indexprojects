using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConditionsOfConnection
{
    public partial class Form1 : Form
    {
        private List<int> _count = new List<int> { 6,4,4,4,6,3,3 };
        private List<int> _value1 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> _value2 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> _value3 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> _value4 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> _value5 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> _value6 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<int> _value7 = new List<int> { 0, 0, 0, 0, 0, 0 };
        private List<String> _text1 = new List<string> { "Exit", "SkinFormula", "Star", "carrier", "locater", "manipulater" };
        private List<String> _text2 = new List<string> { "homingdevice", "Steel", "copier", "screw" };
        private List<String> _text3 = new List<string> { "anime", "paddle", "spatum", "multiplexor"};
        private List<String> _text4 = new List<string> { "Proscient", "dataanalysis", "porter", "printer" };
        private List<String> _text5 = new List<string> { "Equals", "recharger", "hmax", "hmin", "originater", "translater" };
        private List<String> _text6 = new List<string> { "Triangle", "Turquoise", "intercepter" };
        private List<String> _text7 = new List<string> { "mebbelgrid", "organiser", "replier" };
        private int mnList, mnItem;

        private void fReset()
        {
            Random rnd1 = new Random();
            
            for (int i = 1; i <= 6; i++)
            {
                _value1[i - 1] = rnd1.Next(20, 201);
                _value2[i - 1] = rnd1.Next(20, 201);
                _value3[i - 1] = rnd1.Next(20, 201);
                _value4[i - 1] = rnd1.Next(20, 201);
                _value5[i - 1] = rnd1.Next(20, 201);
                _value6[i - 1] = rnd1.Next(20, 201);
                _value7[i - 1] = rnd1.Next(20, 201);
            }

            mnList = 1;
    
        }

        private void fUpdateList()
        {
            String sText;

            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }

            for (int i = 1; i <= _count[mnList - 1]; i++)
            {
                switch (mnList)
                {
                    case 1:
                        sText=_text1[i-1]+ Convert.ToString(_value1[i-1]) + "/200";
                        lst1.Items.Add(sText);
                        break;
                    case 2:
                        sText = _text2[i - 1] + Convert.ToString(_value2[i - 1]) + "/200";
                        lst1.Items.Add(sText);
                        break;
                    case 3:
                        sText = _text3[i - 1] + Convert.ToString(_value3[i - 1]) + "/200";
                        lst1.Items.Add(sText);
                        break;
                    case 4:
                        sText = _text4[i - 1] + Convert.ToString(_value4[i - 1]) + "/200";
                        lst1.Items.Add(sText);
                        break;
                    case 5:
                        sText = _text5[i - 1] + Convert.ToString(_value5[i - 1]) + "/200";
                        lst1.Items.Add(sText);
                        break;
                    case 6:
                        sText = _text6[i - 1] + Convert.ToString(_value6[i - 1]) + "/200";
                        lst1.Items.Add(sText);
                        break;
                   default:
                        sText = _text7[i - 1] + Convert.ToString(_value7[i - 1]) + "/200";
                        lst1.Items.Add(sText);
                        break;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            mnList = 1;
            fUpdateList();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            mnList = 2;
            fUpdateList();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            mnList = 3;
            fUpdateList();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            mnList = 4;
            fUpdateList();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            mnList = 5;
            fUpdateList();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            mnList = 6;
            fUpdateList();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            mnList = 7;
            fUpdateList();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
