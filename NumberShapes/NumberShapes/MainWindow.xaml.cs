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

namespace NumberShapes
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<String> _viable = new List<string> { "GO", "Square", null, null, null, null, null, null, null, null };
        private List<String> _popularity = new List<string> { "Mazerunner", null, null, null, null, null, null, null, null, null };
        private List<String> _luck = new List<string> { "Cypher", "Email", null, null, null, null, null, null, null, null };
        private int mnItem;
        private void fUpdateList()
        {
            switch (mnItem)
            {
                case 1:
                    lbl1.Content = _viable[0];
                    lbl2.Content = _viable[1];
                    lbl3.Content = _viable[2];
                    lbl4.Content = _viable[3];
                    lbl5.Content = _viable[4];
                    lbl6.Content = _viable[5];
                    lbl7.Content = _viable[6];
                    lbl8.Content = _viable[7];
                    lbl9.Content = _viable[8];
                    lbl10.Content = _viable[9];
                    break;
                case 2:
                    lbl1.Content = _popularity[0];
                    lbl2.Content = _popularity[1];
                    lbl3.Content = _popularity[2];
                    lbl4.Content = _popularity[3];
                    lbl5.Content = _popularity[4];
                    lbl6.Content = _popularity[5];
                    lbl7.Content = _popularity[6];
                    lbl8.Content = _popularity[7];
                    lbl9.Content = _popularity[8];
                    lbl10.Content = _popularity[9];
                    break;
                default:
                    lbl1.Content = _luck[0];
                    lbl2.Content = _luck[1];
                    lbl3.Content = _luck[2];
                    lbl4.Content = _luck[3];
                    lbl5.Content = _luck[4];
                    lbl6.Content = _luck[5];
                    lbl7.Content = _luck[6];
                    lbl8.Content = _luck[7];
                    lbl9.Content = _luck[8];
                    lbl10.Content = _luck[9];
                    break;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            mnItem = 1;
            fUpdateList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mnItem = 1;
            fUpdateList();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mnItem = 2;
            fUpdateList();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            mnItem = 3;
            fUpdateList();

        }
    }
}
