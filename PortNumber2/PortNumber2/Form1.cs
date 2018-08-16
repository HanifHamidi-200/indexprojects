using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortNumber2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fSub1 _dlg = new fSub1();
            _dlg.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fSub2 _dlg = new fSub2();
            _dlg.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            fSub3 _dlg = new fSub3();
            _dlg.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            fSub4 _dlg = new fSub4();
            _dlg.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            fSub5 _dlg = new fSub5();
            _dlg.ShowDialog();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            fSub6 _dlg = new fSub6();
            _dlg.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            fSub7 _dlg = new fSub7();
            _dlg.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            fSub8 _dlg = new fSub8();
            _dlg.ShowDialog();

        }
    }
}
