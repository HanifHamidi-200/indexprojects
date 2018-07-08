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

namespace LowcroftModules
{
    public partial class Form1 : Form
    {
        private static List<String> _db1 = new List<String> { null, null, null, null };
        private static List<String> _db2 = new List<String> { null, null, null, null };
        private static List<String> _db3 = new List<String> { null, null, null, null };
        private int mnMode;
        private String sName;

        private void fOpen()
        {
            sName = "data.txt";
             String sLine;

            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(sName))
                {
                    // Read the stream to a string, and write the string to the console.
                    sLine = sr.ReadLine();
                    for (int i=1;i<=4;i++)
                    {
                        sLine = sr.ReadLine();
                        _db1[i - 1] = sLine;
                    }
                    sLine = sr.ReadLine();
                    for (int i = 1; i <= 4; i++)
                    {
                        sLine = sr.ReadLine();
                        _db2[i - 1] = sLine;
                    }
                    sLine = sr.ReadLine();
                    for (int i = 1; i <= 4; i++)
                    {
                        sLine = sr.ReadLine();
                        _db3[i - 1] = sLine;
                    }
                }

                fUpdateDisplay();
            
            }
            catch (Exception e1)
            {
                MessageBox.Show("The file could not be read:", e1.Message);
                for (int i = 1; i <= 4; i++)
                {
                    _db1[i - 1] = null;
                    _db2[i - 1] = null;
                    _db3[i - 1] = null;
                }
                fUpdateDisplay();
            }

        }

        private void fUpdateDisplay()
        {
            switch (mnMode)
            {
                case 1:
                    txt1.Text = _db1[0];
                    txt2.Text = _db1[1];
                    txt3.Text = _db1[2];
                    txt4.Text = _db1[3];
                    break;
                case 2:
                    txt1.Text = _db2[0];
                    txt2.Text = _db2[1];
                    txt3.Text = _db2[2];
                    txt4.Text = _db2[3];
                    break;
                default:
                    txt1.Text = _db3[0];
                    txt2.Text = _db3[1];
                    txt3.Text = _db3[2];
                    txt4.Text = _db3[3];
                    break;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mnMode = 1;
            fOpen();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (mnMode)
            {
                case 1:
                    _db1[0] = txt1.Text;
                    _db1[1] = txt2.Text;
                    _db1[2] = txt3.Text;
                    _db1[3] = txt4.Text;
                    break;
                case 2:
                    _db2[0] = txt1.Text;
                    _db2[1] = txt2.Text;
                    _db2[2] = txt3.Text;
                    _db2[3] = txt4.Text;
                    break;
                default:
                    _db3[0] = txt1.Text;
                    _db3[1] = txt2.Text;
                    _db3[2] = txt3.Text;
                    _db3[3] = txt4.Text;
                    break;
            }
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

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            sName = "data.txt";

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@sName))
            {
                file.WriteLine("LIST1");
                for (int i = 1; i <= 4; i++)
                {
                       file.WriteLine(_db1[i-1]);
                }
                file.WriteLine("LIST2");
                for (int i = 1; i <= 4; i++)
                {
                    file.WriteLine(_db2[i - 1]);
                }
                file.WriteLine("LIST3");
                for (int i = 1; i <= 4; i++)
                {
                    file.WriteLine(_db3[i - 1]);
                }
            }
        }
    }
}
