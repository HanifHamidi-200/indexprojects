using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentsOfFarming
{
    
    public partial class Form1 : Form
    {
        private int fArable()
        {
            int nTotal = 0;

            if (txta1.Text.Length>0)
            {
                nTotal = nTotal + Convert.ToInt32(txta1.Text);
            }
            if (txta2.Text.Length>0)
            {
                nTotal = nTotal + Convert.ToInt32(txta2.Text);
            }
            if (txta3.Text.Length>0)
            {
                nTotal = nTotal + Convert.ToInt32(txta3.Text);
            }
            if (txta4.Text.Length>0)
            {
                nTotal = nTotal + Convert.ToInt32(txta4.Text);
            }
            if (txta5.Text.Length>0)
            {
                nTotal = nTotal + Convert.ToInt32(txta5.Text);
            }
            if (txta6.Text.Length>0)
            {
                nTotal = nTotal + Convert.ToInt32(txta6.Text);
            }
            if (txta7.Text.Length>0)
            {
                nTotal = nTotal + Convert.ToInt32(txta7.Text);
            }
            return nTotal;
        }
        private int fPastoral()
        {
            int nTotal = 0;

            if (txtb1.Text.Length>0)
            {
                nTotal = nTotal + Convert.ToInt32(txtb1.Text);
            }
            if (txtb2.Text.Length>0)
            {
                nTotal = nTotal + Convert.ToInt32(txtb2.Text);
            }
            if (txtb3.Text.Length>0)
            {
                nTotal = nTotal + Convert.ToInt32(txtb3.Text);
            }
            if (txtb4.Text.Length>0)
            {
                nTotal = nTotal + Convert.ToInt32(txtb4.Text);
            }
            if (txtb5.Text.Length>0)
            {
                nTotal = nTotal + Convert.ToInt32(txtb5.Text);
            }
            if (txtb6.Text.Length>0)
            {
                nTotal = nTotal + Convert.ToInt32(txtb6.Text);
            }
            if (txtb7.Text.Length>0)
            {
                nTotal = nTotal + Convert.ToInt32(txtb7.Text);
            }
            if (txtb8.Text.Length>0)
            {
                nTotal = nTotal + Convert.ToInt32(txtb8.Text);
            }
            if (txtb9.Text.Length>0)
            {
                nTotal = nTotal + Convert.ToInt32(txtb9.Text);
            }
            return nTotal;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int nArable = fArable();
            int nPastoral = fPastoral();
            int nIn, nOut, nTotal;
           
            lblTotala.Text = "TOTAL = " + Convert.ToString(nArable);
            lblTotalb.Text = "TOTAL = " + Convert.ToString(nPastoral);

            if (txtIncome.Text.Length==0)
            {
                nIn = 5000;
            }
            else
            {
                nIn = Convert.ToInt32(txtIncome.Text);
            }
            nOut = nArable + nPastoral;
            nTotal = nIn - nOut;

            lblTotalIn.Text = "IN = "+Convert.ToString(nIn);
            lblTotalOut.Text = "OUT = " + Convert.ToString(nOut);
            lblTotalTotal.Text = "TOTAL = " + Convert.ToString(nTotal);
        }

        private void btnOpen2_Click(object sender, EventArgs e)
        {
            Form2 _dlg = new Form2();

            _dlg.ShowDialog();
        }

        private void btnOpen3_Click(object sender, EventArgs e)
        {
            Form3 _dlg = new Form3();

            _dlg.ShowDialog();
        }
    }
}
