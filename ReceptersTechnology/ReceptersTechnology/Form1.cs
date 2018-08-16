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

namespace ReceptersTechnology
{
    public partial class Form1 : Form
    {
        private List<String> _col1 = new List<string> { null, null, null, null, null };
        private List<String> _col2 = new List<string> { null, null, null, null, null };
        private List<String> _col3 = new List<string> { null, null, null, null, null };
        private List<String> _col4 = new List<string> { null, null, null, null, null };
        private List<String> _col5 = new List<string> { null, null, null, null, null };
        private List<String> _colb1 = new List<string> { null, null, null, null, null };
        private List<String> _colb2 = new List<string> { null, null, null, null, null };
        private List<String> _colb3 = new List<string> { null, null, null, null, null };
        private List<String> _colb4 = new List<string> { null, null, null, null, null };
        private List<String> _colb5 = new List<string> { null, null, null, null, null };

        private void fReset1()
        {
            txt111.Text = null;
            txt112.Text = null;
            txt113.Text = null;
            txt114.Text = null;
            txt115.Text = null;

            txt121.Text = null;
            txt122.Text = null;
            txt123.Text = null;
            txt124.Text = null;
            txt125.Text = null;

            txt131.Text = null;
            txt132.Text = null;
            txt133.Text = null;
            txt134.Text = null;
            txt135.Text = null;

            txt141.Text = null;
            txt142.Text = null;
            txt143.Text = null;
            txt144.Text = null;
            txt145.Text = null;

            txt151.Text = null;
            txt152.Text = null;
            txt153.Text = null;
            txt154.Text = null;
            txt155.Text = null;

            for (int i = 1; i <= 5; i++)
            {
                _col1[i - 1] = null;
                _col2[i - 1] = null;
                _col3[i - 1] = null;
                _col4[i - 1] = null;
                _col5[i - 1] = null;
            }
        }
            private void fReset2()
            {
                txt211.Text = null;
                txt212.Text = null;
                txt213.Text = null;
                txt214.Text = null;
                txt215.Text = null;

                txt221.Text = null;
                txt222.Text = null;
                txt223.Text = null;
                txt224.Text = null;
                txt225.Text = null;

                txt231.Text = null;
                txt232.Text = null;
                txt233.Text = null;
                txt234.Text = null;
                txt235.Text = null;

                txt241.Text = null;
                txt242.Text = null;
                txt243.Text = null;
                txt244.Text = null;
                txt245.Text = null;

                txt251.Text = null;
                txt252.Text = null;
                txt253.Text = null;
                txt254.Text = null;
                txt255.Text = null;


            for (int i = 1; i <= 5; i++)
            {
                _colb1[i - 1] = null;
                _colb2[i - 1] = null;
                _colb3[i - 1] = null;
                _colb4[i - 1] = null;
                _colb5[i - 1] = null;
            }
        }

        private void fSave()
        {
            String sText = null;

           String sName = "save.txt";

            _col1[0] = txt111.Text;
            _col1[1] = txt112.Text;
            _col1[2] = txt113.Text;
            _col1[3] = txt114.Text;
            _col1[4] = txt115.Text;
            _col2[0] = txt121.Text;
            _col2[1] = txt122.Text;
            _col2[2] = txt123.Text;
            _col2[3] = txt124.Text;
            _col2[4] = txt125.Text;
            _col3[0] = txt131.Text;
            _col3[1] = txt132.Text;
            _col3[2] = txt133.Text;
            _col3[3] = txt134.Text;
            _col3[4] = txt135.Text;
            _col4[0] = txt141.Text;
            _col4[1] = txt142.Text;
            _col4[2] = txt143.Text;
            _col4[3] = txt144.Text;
            _col4[4] = txt145.Text;
            _col5[0] = txt151.Text;
            _col5[1] = txt152.Text;
            _col5[2] = txt153.Text;
            _col5[3] = txt154.Text;
            _col5[4] = txt155.Text;

            _colb1[0] = txt211.Text;
            _colb1[1] = txt212.Text;
            _colb1[2] = txt213.Text;
            _colb1[3] = txt214.Text;
            _colb1[4] = txt215.Text;
            _colb2[0] = txt221.Text;
            _colb2[1] = txt222.Text;
            _colb2[2] = txt223.Text;
            _colb2[3] = txt224.Text;
            _colb2[4] = txt225.Text;
            _colb3[0] = txt231.Text;
            _colb3[1] = txt232.Text;
            _colb3[2] = txt233.Text;
            _colb3[3] = txt234.Text;
            _colb3[4] = txt235.Text;
            _colb4[0] = txt241.Text;
            _colb4[1] = txt242.Text;
            _colb4[2] = txt243.Text;
            _colb4[3] = txt244.Text;
            _colb4[4] = txt245.Text;
            _colb5[0] = txt251.Text;
            _colb5[1] = txt252.Text;
            _colb5[2] = txt253.Text;
            _colb5[3] = txt254.Text;
            _colb5[4] = txt255.Text;

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@sName))
            {
                file.WriteLine("LIST");
                for (int i = 1; i <= 5; i++)
                {
                    sText = _col1[i - 1];
                    file.WriteLine(sText);
                }
                for (int i = 1; i <= 5; i++)
                {
                    sText = _col2[i - 1];
                    file.WriteLine(sText);
                }
                for (int i = 1; i <= 5; i++)
                {
                    sText = _col3[i - 1];
                    file.WriteLine(sText);
                }
                for (int i = 1; i <= 5; i++)
                {
                    sText = _col4[i - 1];
                    file.WriteLine(sText);
                }
                for (int i = 1; i <= 5; i++)
                {
                    sText = _col5[i - 1];
                    file.WriteLine(sText);
                }
                file.WriteLine("LIST");
                for (int i = 1; i <= 5; i++)
                {
                    sText = _colb1[i - 1];
                    file.WriteLine(sText);
                }
                for (int i = 1; i <= 5; i++)
                {
                    sText = _colb2[i - 1];
                    file.WriteLine(sText);
                }
                for (int i = 1; i <= 5; i++)
                {
                    sText = _colb3[i - 1];
                    file.WriteLine(sText);
                }
                for (int i = 1; i <= 5; i++)
                {
                    sText = _colb4[i - 1];
                    file.WriteLine(sText);
                }
                for (int i = 1; i <= 5; i++)
                {
                    sText = _colb5[i - 1];
                    file.WriteLine(sText);
                }
            }

        }

        private void fGet()
        {
            String sName = "save.txt";
            int nCount = 0;
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
                        _col1[i - 1] = sLine;
                    }
                    for (int i = 1; i <= 5; i++)
                    {
                        sLine = sr.ReadLine();
                        _col2[i - 1] = sLine;
                    }
                    for (int i = 1; i <= 5; i++)
                    {
                        sLine = sr.ReadLine();
                        _col3[i - 1] = sLine;
                    }
                    for (int i = 1; i <= 5; i++)
                    {
                        sLine = sr.ReadLine();
                        _col4[i - 1] = sLine;
                    }
                    for (int i = 1; i <= 5; i++)
                    {
                        sLine = sr.ReadLine();
                        _col5[i - 1] = sLine;
                    }
                    sLine = sr.ReadLine();
                    for (int i = 1; i <= 5; i++)
                    {
                        sLine = sr.ReadLine();
                        _colb1[i - 1] = sLine;
                    }
                    for (int i = 1; i <= 5; i++)
                    {
                        sLine = sr.ReadLine();
                        _colb2[i - 1] = sLine;
                    }
                    for (int i = 1; i <= 5; i++)
                    {
                        sLine = sr.ReadLine();
                        _colb3[i - 1] = sLine;
                    }
                    for (int i = 1; i <= 5; i++)
                    {
                        sLine = sr.ReadLine();
                        _colb4[i - 1] = sLine;
                    }
                    for (int i = 1; i <= 5; i++)
                    {
                        sLine = sr.ReadLine();
                        _colb5[i - 1] = sLine;
                    }
                }

                txt111.Text = _col1[0];
                txt112.Text = _col1[1];
                txt113.Text = _col1[2];
                txt114.Text = _col1[3];
                txt115.Text = _col1[4];
                txt121.Text = _col2[0];
                txt122.Text = _col2[1];
                txt123.Text = _col2[2];
                txt124.Text = _col2[3];
                txt125.Text = _col2[4];
                txt131.Text = _col3[0];
                txt132.Text = _col3[1];
                txt133.Text = _col3[2];
                txt134.Text = _col3[3];
                txt135.Text = _col3[4];
                txt141.Text = _col4[0];
                txt142.Text = _col4[1];
                txt143.Text = _col4[2];
                txt144.Text = _col4[3];
                txt145.Text = _col4[4];
                txt151.Text = _col5[0];
                txt152.Text = _col5[1];
                txt153.Text = _col5[2];
                txt154.Text = _col5[3];
                txt155.Text = _col5[4];

                txt211.Text = _colb1[0];
                txt212.Text = _colb1[1];
                txt213.Text = _colb1[2];
                txt214.Text = _colb1[3];
                txt215.Text = _colb1[4];
                txt221.Text = _colb2[0];
                txt222.Text = _colb2[1];
                txt223.Text = _colb2[2];
                txt224.Text = _colb2[3];
                txt225.Text = _colb2[4];
                txt231.Text = _colb3[0];
                txt232.Text = _colb3[1];
                txt233.Text = _colb3[2];
                txt234.Text = _colb3[3];
                txt235.Text = _colb3[4];
                txt241.Text = _colb4[0];
                txt242.Text = _colb4[1];
                txt243.Text = _colb4[2];
                txt244.Text = _colb4[3];
                txt245.Text = _colb4[4];
                txt251.Text = _colb5[0];
                txt252.Text = _colb5[1];
                txt253.Text = _colb5[2];
                txt254.Text = _colb5[3];
                txt255.Text = _colb5[4];

            }
            catch (Exception e1)
            {
                MessageBox.Show("The file could not be read:", e1.Message);
            }

        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fGet();
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            fReset1();
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            fReset2();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fSave();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            fGet();
        }
    }
}
