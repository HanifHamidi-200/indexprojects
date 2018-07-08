using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MirageSquare
{
    public partial class Form1 : Form
    {
        private static List<string> _db = new List<string> { "Candesit","Eagleton","Horoscope","Bollard","Daimler","Stampede" };
        private static List<int> _count = new List<int> { 0,0,0,0,0,0 };
        private static List<string> _db0 = new List<string> { null,null,null, null, null, null, null, null, null, null, null, null };
        private static List<int> _count0 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private Random rnd1 = new Random();
        private int nCount;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            String sWord = null;
             int nNumber;
            nCount = rnd1.Next(4, 13);
            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }
            for (int i=1; i <= nCount; i++)
            {
                nNumber = rnd1.Next(10, 100);
                _count0[i - 1] = nNumber;
                sWord = Convert.ToString(nNumber);
                nNumber = rnd1.Next(1, 7);
                _db0[i - 1] =  _db[nNumber - 1];
                sWord = _db[nNumber - 1] + " x" + sWord;
                lst1.Items.Add(sWord);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String sWord = null;
            for (int i = 1; i <= lst2.Items.Count; i++)
            {
                lst2.Items.RemoveAt(0);
            }
               for (int i = 1; i <= 6; i++)
            {
                sWord = _db[i - 1];
                sWord = sWord + " = " + Convert.ToString(_count[i - 1]);
                lst2.Items.Add(sWord);
            }
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            int nItem = lst1.SelectedIndex;
            String sClass = null;
            int nAmount;
            int nPlace;
            if (nItem > -1)
            {
                sClass = _db0[nItem];
                nAmount = _count0[nItem];
                switch (sClass)
                {
                    case "Candesit":
                        nPlace = 1;
                        break;
                    case "Eagleton":
                        nPlace = 2;
                        break;
                    case "Horoscope":
                        nPlace = 3;
                        break;
                    case "Bollard":
                        nPlace = 4;
                        break;
                    case "Daimler":
                        nPlace = 5;
                        break;
                    default:
                        nPlace = 6;
                        break;
                }
                _count[nPlace - 1] = _count[nPlace - 1] + nAmount;
                String sWord = null;
                int nCount = lst2.Items.Count;
                for (int i = 1; i <= 6; i++)
                {
                    lst2.Items.RemoveAt(0);
                }
                for (int i = 1; i <= 6; i++)
                {
                    sWord = _db[i - 1];
                    sWord = sWord + " = " + Convert.ToString(_count[i - 1]);
                    lst2.Items.Add(sWord);
                }
                nCount =- 1;
                for (int i = nPlace; i <= nCount; i++)
                {
                    _db0[i - 1] = _db0[i];
                    _count0[i - 1] = _count0[i];
                }
                lst1.Items.RemoveAt(nItem);
             }
        }
    }
}
