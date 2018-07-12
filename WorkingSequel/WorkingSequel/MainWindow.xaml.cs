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

namespace WorkingSequel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static List<int> _data1 = new List<int> { 0, 0, 0, 0 };
        private static List<int> _data2 = new List<int> { 0, 0, 0, 0 };
        private int mnMode;

        private void fUpdateDisplay()
        {
            if (mnMode == 1)
            {
                lbl1.Content = "lebell = " + Convert.ToString(_data1[0]);
                lbl2.Content = "case = " + Convert.ToString(_data1[1]);
                lbl3.Content = "dominic = " + Convert.ToString(_data1[2]);
                lbl4.Content = "standby = " + Convert.ToString(_data1[3]);
            }
            else
            {
                lbl1.Content = "lebell = " + Convert.ToString(_data2[0]);
                lbl2.Content = "case = " + Convert.ToString(_data2[1]);
                lbl3.Content = "dominic = " + Convert.ToString(_data2[2]);
                lbl4.Content = "standby = " + Convert.ToString(_data2[3]);

            }
        }
        public MainWindow()
        {
            InitializeComponent();
            Random rnd1 = new Random();

            mnMode = 1;
            for (int i = 1; i <= 4; i++)
            {
                _data1[i - 1] = rnd1.Next(1, 1001);
                _data2[i - 1] = rnd1.Next(1, 1001);
            }
        }

         
        private void btnSequel_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            mnMode = 2;
            fUpdateDisplay();

        }

        private void btnWorking_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            mnMode = 1;
            fUpdateDisplay();

        }
    }
}
