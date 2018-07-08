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

namespace DataAndPrograms
{
    public partial class Form1 : Form
    {
        private static List<String> _list = new List<String> {null,null,null,null,null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null};
        private static List<String> _commands1 = new List<String> { "print","query","include","paste","update","refresh" };
        private static List<String> _commands2 = new List<String> { "add", "subtract", "multiply", "hex" };
        private static List<String> _status = new List<String> { null,null,null };
        private String sName;
        private int mnCount;
        private int nNumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nIndex,nValue;
            String sCommand;
            char sLetter;
            String sWord;

            nNumber = rnd1.Next(1, 21);
            sName = "program"+Convert.ToString(nNumber) + ".ts";
            txtName.Text = sName;

            mnCount = rnd1.Next(4, 21);
            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }
            for (int i = 1; i <= mnCount; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    nIndex = rnd1.Next(1, 7);
                    sCommand = _commands1[nIndex - 1];
                }
                else
                {
                    nIndex = rnd1.Next(1, 5);
                    nValue = rnd1.Next(1, 11);
                    sCommand = _commands2[nIndex - 1] + Convert.ToString(nValue);
                }
                lst1.Items.Add(sCommand);
            }
            for (int i = 1; i <= 3; i++)
            {
                _status[i - 1] = null;
                sWord = "<";
                sLetter = (char)(rnd1.Next(1, 27) + 64);
                sWord = sWord + Convert.ToString(sLetter);
                sLetter = (char)(rnd1.Next(1, 27) + 64);
                sWord = sWord + Convert.ToString(sLetter);
                sWord = sWord + ">";
                _status[i - 1] = sWord;
            }
            txtStatus1.Text = _status[0];
            txtStatus2.Text = _status[1];
            txtStatus3.Text = _status[2];

        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nIndex, nValue;
            String sCommand;
            char sLetter;
            String sWord;

            nNumber = rnd1.Next(1, 21);
            sName = "program" + Convert.ToString(nNumber) + ".ts";
            txtName.Text = sName;

            mnCount = rnd1.Next(4, 21);
            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }
            for (int i = 1; i <= mnCount; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    nIndex = rnd1.Next(1, 7);
                    sCommand = _commands1[nIndex - 1];
                }
                else
                {
                    nIndex = rnd1.Next(1, 5);
                    nValue = rnd1.Next(1, 11);
                    sCommand = _commands2[nIndex - 1] + Convert.ToString(nValue);
                }
                lst1.Items.Add(sCommand);
            }
            for (int i = 1; i <= 3; i++)
            {
                _status[i - 1] = null;
                sWord = "<";
                sLetter = (char)(rnd1.Next(1, 27) + 64);
                sWord = sWord + Convert.ToString(sLetter);
                sLetter = (char)(rnd1.Next(1, 27) + 64);
                sWord = sWord + Convert.ToString(sLetter);
                sWord = sWord + ">";
                _status[i - 1] = sWord;
            }
            txtStatus1.Text = _status[0];
            txtStatus2.Text = _status[1];
            txtStatus3.Text = _status[2];

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String sText = null;

            sName = txtName.Text;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@sName))
            {
                file.WriteLine("LIST");
                for (int i = 1; i <= mnCount; i++)
                {
                    sText = (String)lst1.Items[i - 1];
                    file.WriteLine(sText);
                }
                file.WriteLine("STATUS");
                sText = txtStatus1.Text;
                file.WriteLine(sText);
                sText = txtStatus2.Text;
                file.WriteLine(sText);
                sText = txtStatus3.Text;
                file.WriteLine(sText);
             }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            sName = txtName.Text;
            int nCount = 0;
            String sLine;

            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(sName))
                {
                    // Read the stream to a string, and write the string to the console.
                    sLine = sr.ReadLine();
                    do
                    {
                        sLine = sr.ReadLine();
                        nCount += 1;
                        _list[nCount - 1] = sLine;
                    } while (sLine != "STATUS");
                    sLine = sr.ReadLine();
                    _status[0] = sLine;
                    sLine = sr.ReadLine();
                    _status[1] = sLine;
                    sLine = sr.ReadLine();
                    _status[2] = sLine;
                }
                mnCount = nCount;

                if (lst1.Items.Count > 0)
                {
                    do
                    {
                        lst1.Items.RemoveAt(0);
                    } while (lst1.Items.Count > 0);
                }
                for (int i = 1; i <= mnCount; i++)
                {
                    lst1.Items.Add(_list[i-1]);
                }
                txtStatus1.Text = _status[0];
                txtStatus2.Text = _status[1];
                txtStatus3.Text = _status[2];

            }
            catch (Exception e1)
            {
                MessageBox.Show("The file could not be read:",e1.Message);
               }

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            String sSave = null;
            String sText;

            sSave = "LIST" + (char)13;

            for (int i = 1; i <= mnCount; i++)
            {
                sText = (String)lst1.Items[i - 1];
                sSave = sSave + sText + (char)13;
            }
            sSave = sSave + "STATUS"+ (char)13;
            sText = txtStatus1.Text;
            sSave = sSave + sText + (char)13;
            sText = txtStatus2.Text;
            sSave = sSave + sText + (char)13;
            sText = txtStatus3.Text;
            sSave = sSave + sText + (char)13;
            System.Windows.Forms.Clipboard.SetText(sSave);
        }
    }
}
