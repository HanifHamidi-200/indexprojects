using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterimReporter
{
    public partial class Form1 : Form
    {
        private List<String> _data = new List<string> { null, null, null, null };
        private String sName;

        private void fReset()
        {
            for (int i = 1; i <= 4; i++)
            {
                _data[i - 1] = null;
            }
            sName = null;

            fUpdateDisplay();
        }

        private void fUpdateDisplay()
        {
            txt1.Text = _data[0];
            txt2.Text = _data[1];
            txt3.Text = _data[2];
            txt4.Text = _data[3];
            txtSave.Text = sName;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            String sText = null;
            sName = txtSave.Text;

            _data[0] = txt1.Text;
            _data[1] = txt2.Text;
            _data[2] = txt3.Text;
            _data[3] = txt4.Text;

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@sName))
                {
                    file.WriteLine("DATA");
                for (int i = 1; i <= 4; i++)
                {
                    sText = _data[i - 1];
                    file.WriteLine(sText);
                }
                           }
            }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
