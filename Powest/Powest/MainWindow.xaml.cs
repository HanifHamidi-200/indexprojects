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

namespace Powest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int mnPowest, mnNorth, mnEast;

        private void lblPowest_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Random rnd1 = new Random();
            int nAdd = rnd1.Next(200, 2001);

            mnPowest += nAdd;
            fUpdateDisplay();
        }

        private void lblNorth_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Random rnd1 = new Random();
            int nAdd = rnd1.Next(200, 2001);

            mnNorth += nAdd;
            fUpdateDisplay();

        }

        private void lblEast_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Random rnd1 = new Random();
            int nAdd = rnd1.Next(200, 2001);

            mnEast += nAdd;
            fUpdateDisplay();

        }

        private void fUpdateDisplay()
        {
            lblPowest2.Content = "POWEST = " + Convert.ToString(mnPowest);
            lblNorth2.Content = "NORTH = " + Convert.ToString(mnNorth);
            lblEast2.Content = "EAST = " + Convert.ToString(mnEast);

        }
        public MainWindow()
        {
            InitializeComponent();
            Random rnd1 = new Random();

            mnPowest = rnd1.Next(1, 20001);
            mnNorth = rnd1.Next(1, 20001);
            mnEast = rnd1.Next(1, 20001);

        }
    }
}
