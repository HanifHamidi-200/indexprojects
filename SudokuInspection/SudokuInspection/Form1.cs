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

namespace SudokuInspection
{
    public partial class Form1 : Form
    {
        private List<String> _list = new List<String> { null, null, null, null, null, null, null, null, null };
        private int mnFiles;

        private void fGet(int nPuzzle)
        {
           String  sName = "F data.txt";
            int nCount = 0;
            String sLine;
            int nPuzzle2;
            bool bOut = false;

            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(sName))
                {
                    // Read the stream to a string, and write the string to the console.
                    sLine = sr.ReadLine();
                    mnFiles = Convert.ToInt32(sLine);
                    nPuzzle2 = 0;
                    do
                    {
                        sLine = sr.ReadLine();
                        if (sLine == "END")
                        {
                            bOut = true;
                            continue;
                        }
                        nPuzzle2 += 1;
                        for (int i = 1; i <= 9; i++)
                        { 
                             sLine = sr.ReadLine();
                             _list[i - 1] = sLine;
                        }
                        if (nPuzzle2 == nPuzzle)
                        {
                            return;
                        }
                    } while (sr.EndOfStream == false);
                }

            }
            catch (Exception e1)
            {
                MessageBox.Show("The file could not be read:", e1.Message);
            }      
    }

        private void fReset()
        {
            String sText;

            if (lstShow1.Items.Count > 0)
            {
                do
                {
                    lstShow1.Items.RemoveAt(0);
                } while (lstShow1.Items.Count > 0);
            }
            if (lstShow2.Items.Count > 0)
            {
                do
                {
                    lstShow2.Items.RemoveAt(0);
                } while (lstShow2.Items.Count > 0);
            }

            fGet(1);
            btnShow1.Text = "SHOW" + Convert.ToString("1") + "/" + Convert.ToString(mnFiles);
            for (int i = 1; i <= 9; i++)
            {
                sText = _list[i - 1];
                lstShow1.Items.Add(sText);
            }
            fGet(2);
            btnShow2.Text = "SHOW" + Convert.ToString("2") + "/" + Convert.ToString(mnFiles);
            for (int i = 1; i <= 9; i++)
            {
                sText = _list[i - 1];
                lstShow2.Items.Add(sText);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
