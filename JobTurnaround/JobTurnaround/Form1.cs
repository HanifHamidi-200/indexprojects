using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobTurnaround
{
    public partial class Form1 : Form
    {
        private String[] _array = new String[8];
        private int mnItem;

        public Form1()
        {
            InitializeComponent();
            _array[0] = "a Trade butthen the Farming ison reserve";
            _array[1] = "a Brexit but who impounds what";
            _array[2] = "a CashlessSociety but who fetches the corridors";
            _array[3] = "several HorseManures but what will you do at the Roundabout";
            _array[4] = "a LawrenceArabia but who owns which hand";
            _array[5] = "a FriarTuck but is his information trustworthy";
            _array[6] = "several FacebookContacts but will the information last";
            _array[7] = "several CVs but who's leading the HQ";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();

            mnItem = rnd1.Next(1, 9);
            lst1.SelectedIndex = mnItem - 1;
            txt1.Text = _array[mnItem - 1];
        }

        private void lst1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mnItem = lst1.SelectedIndex + 1;
            txt1.Text = _array[mnItem - 1];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _array[mnItem - 1] = txt1.Text;
        }
    }
}
