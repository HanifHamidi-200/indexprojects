using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FWDApp
{
    public partial class Form1 : Form
    {
        private static List<String> _col1 = new List<String> { null,null,null,null,null,null};
        private static List<String> _col2 = new List<String> { null, null, null, null, null, null };


        private void fReset()
        {
            for (int i = 1; i <= 6; i++)
            {
                _col1[i - 1] = null;
                _col2[i - 1] = null;
            }

            txt11.Text = _col1[0];
            txt12.Text = _col1[1];
            txt13.Text = _col1[2];
            txt14.Text = _col1[3];
            txt15.Text = _col1[4];
            txt16.Text = _col1[5];
            txt21.Text = _col2[0];
            txt22.Text = _col2[1];
            txt23.Text = _col2[2];
            txt24.Text = _col2[3];
            txt25.Text = _col2[4];
            txt26.Text = _col2[5];
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
