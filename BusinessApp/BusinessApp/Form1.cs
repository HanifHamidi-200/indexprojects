using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessApp
{
    public partial class Form1 : Form
    {
        int mnCount, mnMode;
        private static List<String> _names1 = new List<String> { "transcends","replennicate","Untitled3","Untitled4" };
        private static List<String> _names2 = new List<String> { "Selmek","Hives" };
        private static List<String> _names3 = new List<String> { "OverturnTheSoil","Gap2","Gap3"};
        private static List<String> _names4 = new List<String> { "LightningBolt","SharepointAgile" };
        private static List<int> _count = new List<int> { 4,2,3,2};
        private static List<int> _numbers1 = new List<int> { 0,0,0,0 };
        private static List<int> _numbers2 = new List<int> { 0, 0 };
        private static List<int> _numbers3=  new List<int> { 0, 0, 0 };
        private static List<int> _numbers4 = new List<int> { 0, 0 };

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            String sText;

            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }
            for (int i = 1; i <= _count[0]; i++)
            {
                sText = _names1[i - 1] + " = " + Convert.ToString(rnd1.Next(1, 201));
                lst1.Items.Add(sText);
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            String sText;

            if (lst2.Items.Count > 0)
            {
                do
                {
                    lst2.Items.RemoveAt(0);
                } while (lst2.Items.Count > 0);
            }
            for (int i = 1; i <= _count[1]; i++)
            {
                sText = _names2[i - 1] + " = " + Convert.ToString(rnd1.Next(1, 201));
                lst2.Items.Add(sText);
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            String sText;

            if (lst3.Items.Count > 0)
            {
                do
                {
                    lst3.Items.RemoveAt(0);
                } while (lst3.Items.Count > 0);
            }
            for (int i = 1; i <= _count[2]; i++)
            {
                sText = _names3[i - 1] + " = " + Convert.ToString(rnd1.Next(1, 201));
                lst3.Items.Add(sText);
            }

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            String sText;

            if (lst4.Items.Count > 0)
            {
                do
                {
                    lst4.Items.RemoveAt(0);
                } while (lst4.Items.Count > 0);
            }
            for (int i = 1; i <= _count[3]; i++)
            {
                sText = _names4[i - 1] + " = " + Convert.ToString(rnd1.Next(1, 201));
                lst4.Items.Add(sText);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            String sText;

            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }
            if (lst2.Items.Count > 0)
            {
                do
                {
                    lst2.Items.RemoveAt(0);
                } while (lst2.Items.Count > 0);
            }
            if (lst3.Items.Count > 0)
            {
                do
                {
                    lst3.Items.RemoveAt(0);
                } while (lst3.Items.Count > 0);
            }
            if (lst4.Items.Count > 0)
            {
                do
                {
                    lst4.Items.RemoveAt(0);
                } while (lst4.Items.Count > 0);
            }

            for (int i = 1; i <= _count[0]; i++)
            {
                sText = _names1[i - 1] + " = " + Convert.ToString(rnd1.Next(1, 201));
                lst1.Items.Add(sText);
            }
            for (int i = 1; i <= _count[1]; i++)
            {
                sText = _names2[i - 1] + " = " + Convert.ToString(rnd1.Next(1, 201));
                lst2.Items.Add(sText);
            }
            for (int i = 1; i <= _count[2]; i++)
            {
                sText = _names3[i - 1] + " = " + Convert.ToString(rnd1.Next(1, 201));
                lst3.Items.Add(sText);
            }
            for (int i = 1; i <= _count[3]; i++)
            {
                sText = _names4[i - 1] + " = " + Convert.ToString(rnd1.Next(1, 201));
                lst4.Items.Add(sText);
            }
        }
    }
}
