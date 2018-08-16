using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MOO2019
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<String> _secure = new List<string> { null, null, null, null, null, null, null, null };
        private List<String> _attach = new List<string> { null, null, null, null, null, null, null, null };
        private List<String> _record = new List<string> { null, null, null, null, null, null, null, null };
        private int mnItem;

        public MainWindow()
        {
            InitializeComponent();
            mnItem = 1;
        }

        private void pic1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            mnItem = 1;
        }

        private void pic2_MouseUp(object sender, MouseButtonEventArgs e)
        {
            mnItem = 2;
        }

        private void pic3_MouseUp(object sender, MouseButtonEventArgs e)
        {
            mnItem = 3;
        }

        private void pic4_MouseUp(object sender, MouseButtonEventArgs e)
        {
            mnItem = 4;
        }

        private void pic5_MouseUp(object sender, MouseButtonEventArgs e)
        {
            mnItem = 5;
        }

        private void pic6_MouseUp(object sender, MouseButtonEventArgs e)
        {
            mnItem = 6;
        }

        private void pic7_MouseUp(object sender, MouseButtonEventArgs e)
        {
            mnItem = 7;
        }

        private void pic8_MouseUp(object sender, MouseButtonEventArgs e)
        {
            mnItem = 8;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            String sText1 = txt1.Text;
            String sText2 = _secure[mnItem - 1];

            if (sText1 != sText2)
            {
                _secure[mnItem - 1] = sText1;
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            String sText1 = txt1.Text;
            String sText2 = _attach[mnItem - 1];

            if (sText1 != sText2)
            {
                _attach[mnItem - 1] = sText1;
            }

        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            String sText1 = txt1.Text;
            String sText2 = _record[mnItem - 1];

            if (sText1 != sText2)
            {
                _record[mnItem - 1] = sText1;
            }

        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            String sText1 = _secure[mnItem - 1];
            String sText2 = _attach[mnItem - 1];
            String sText3 = _record[mnItem - 1];
            String sText = "ITEMS ARE:- " + sText1 + ", " + sText2 + ", " + sText3;

            MessageBox.Show(sText);
        }
    }
}
