using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookPage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = "Today is " + Convert.ToString(DateTime.Now);
        }

        private void btnPassportAccess_Click(object sender, EventArgs e)
        {
            Form2 _dlg = new Form2();

            _dlg.ShowDialog();
        }
    }
}
