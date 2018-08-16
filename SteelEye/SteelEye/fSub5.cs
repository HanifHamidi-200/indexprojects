using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteelEye
{
    public partial class fSub5 : Form
    {
        private List<String> _list1 = new List<string> { null, null, null, null, null };
        private List<String> _list2 = new List<string> { null, null, null, null, null };
        private List<String> _list3 = new List<string> { null, null, null, null, null };
        private List<String> _list4 = new List<string> { null, null, null, null, null };
        private List<String> _list5 = new List<string> { null, null, null, null, null };
        private int mnButton;

        private void fGet()
        {
            String sName = "F Sub5.txt";
            String sLine;

            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(sName))
                {
                    // Read the stream to a string, and write the string to the console.
                    sLine = sr.ReadLine();
                    for (int i = 1; i <= 5; i++)
                    {
                        sLine = sr.ReadLine();
                        _list1[i - 1] = sLine;
                    }
                    sLine = sr.ReadLine();
                    for (int i = 1; i <= 5; i++)
                    {
                        sLine = sr.ReadLine();
                        _list2[i - 1] = sLine;
                    }
                    sLine = sr.ReadLine();
                    for (int i = 1; i <= 5; i++)
                    {
                        sLine = sr.ReadLine();
                        _list3[i - 1] = sLine;
                    }
                    sLine = sr.ReadLine();
                    for (int i = 1; i <= 5; i++)
                    {
                        sLine = sr.ReadLine();
                        _list4[i - 1] = sLine;
                    }
                    sLine = sr.ReadLine();
                    for (int i = 1; i <= 5; i++)
                    {
                        sLine = sr.ReadLine();
                        _list5[i - 1] = sLine;
                    }

                    fUpdateDisplay();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("The file could not be read:", e1.Message);
            }

        }

        private void fUpdateDisplay()
        {
            switch (mnButton)
            {
                case 1:
                    txtTitle.Text = _list1[0];
                    txt1.Text = _list1[1];
                    txt2.Text = _list1[2];
                    txt3.Text = _list1[3];
                    txt4.Text = _list1[4];
                    break;
                case 2:
                    txtTitle.Text = _list2[0];
                    txt1.Text = _list2[1];
                    txt2.Text = _list2[2];
                    txt3.Text = _list2[3];
                    txt4.Text = _list2[4];
                    break;
                case 3:
                    txtTitle.Text = _list3[0];
                    txt1.Text = _list3[1];
                    txt2.Text = _list3[2];
                    txt3.Text = _list3[3];
                    txt4.Text = _list3[4];
                    break;
                case 4:
                    txtTitle.Text = _list4[0];
                    txt1.Text = _list4[1];
                    txt2.Text = _list4[2];
                    txt3.Text = _list4[3];
                    txt4.Text = _list4[4];
                    break;
                default:
                    txtTitle.Text = _list5[0];
                    txt1.Text = _list5[1];
                    txt2.Text = _list5[2];
                    txt3.Text = _list5[3];
                    txt4.Text = _list5[4];
                    break;
            }
        }

        private void fSave()
        {
            switch (mnButton)
            {
                case 1:
                    _list1[0] = txtTitle.Text;
                    _list1[1] = txt1.Text;
                    _list1[2] = txt2.Text;
                    _list1[3] = txt3.Text;
                    _list1[4] = txt4.Text;
                    break;
                case 2:
                    _list2[0] = txtTitle.Text;
                    _list2[1] = txt1.Text;
                    _list2[2] = txt2.Text;
                    _list2[3] = txt3.Text;
                    _list2[4] = txt4.Text;
                    break;
                case 3:
                    _list3[0] = txtTitle.Text;
                    _list3[1] = txt1.Text;
                    _list3[2] = txt2.Text;
                    _list3[3] = txt3.Text;
                    _list3[4] = txt4.Text;
                    break;
                case 4:
                    _list4[0] = txtTitle.Text;
                    _list4[1] = txt1.Text;
                    _list4[2] = txt2.Text;
                    _list4[3] = txt3.Text;
                    _list4[4] = txt4.Text;
                    break;
                default:
                    _list5[0] = txtTitle.Text;
                    _list5[1] = txt1.Text;
                    _list5[2] = txt2.Text;
                    _list5[3] = txt3.Text;
                    _list5[4] = txt4.Text;
                    break;
            }

            String sText = null;

            String sName = "F Sub5.txt";

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@sName))
            {
                file.WriteLine("LIST1");
                for (int i = 1; i <= 5; i++)
                {
                    sText = _list1[i - 1];
                    file.WriteLine(sText);
                }
                file.WriteLine("LIST2");
                for (int i = 1; i <= 5; i++)
                {
                    sText = _list2[i - 1];
                    file.WriteLine(sText);
                }
                file.WriteLine("LIST3");
                for (int i = 1; i <= 5; i++)
                {
                    sText = _list3[i - 1];
                    file.WriteLine(sText);
                }
                file.WriteLine("LIST4");
                for (int i = 1; i <= 5; i++)
                {
                    sText = _list4[i - 1];
                    file.WriteLine(sText);
                }
                file.WriteLine("LIST5");
                for (int i = 1; i <= 5; i++)
                {
                    sText = _list5[i - 1];
                    file.WriteLine(sText);
                }
            }

        }
        public fSub5()
        {
            InitializeComponent();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            fSave();
            mnButton = 3;
            fGet();

        }

      
        private void btn1_Click(object sender, EventArgs e)
        {
            fSave();
            mnButton = 1;
            fGet();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            fSave();
            mnButton = 2;
            fGet();

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            fSave();
            mnButton = 4;
            fGet();


        }

        private void btn5_Click(object sender, EventArgs e)
        {
            fSave();
            mnButton = 5;
            fGet();

        }

        private void fSub5_Load(object sender, EventArgs e)
        {
            mnButton = 1;
            fGet();

        }
    }
}

