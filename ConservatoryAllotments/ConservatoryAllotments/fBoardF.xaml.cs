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
using System.Windows.Shapes;

namespace ConservatoryAllotments
{
    /// <summary>
    /// Interaction logic for fBoardF.xaml
    /// </summary>
    public partial class fBoardF : Window
    {
        private static List<int> _state = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0,0 };
        private static List<int> _population = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 ,0};
        private static List<int> _work = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private int nNumber;
        private int mnItem;

        public fBoardF()
        {
            InitializeComponent();
            Random rnd1 = new Random();
            String sWord;
            String sWord2;

            if (lstEntry.Items.Count > 0)
            {

                do
                {
                    lstEntry.Items.RemoveAt(0);
                } while (lstEntry.Items.Count > 0);
            }

            for (int i = 1; i <= 8; i++)
            {
                _state[i - 1] = rnd1.Next(1, 7);
                _population[i - 1] = rnd1.Next(1, 14001);
                _work[i - 1] = rnd1.Next(1, 6);
                switch (_state[i - 1])
                {
                    case 1:
                        sWord = "UN";
                        break;
                    case 2:
                        sWord = "UD";
                        break;
                    case 3:
                        sWord = "P";
                        break;
                    case 4:
                        sWord = "R";
                        break;
                    case 5:
                        sWord = "N";
                        break;
                    default:
                        sWord = "Z";
                        break;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    sWord = sWord + "\\" + Convert.ToString(_population[i - 1]);
                }
                else
                {
                    sWord = sWord + "/" + Convert.ToString(_population[i - 1]);
                }
                switch (_work[i - 1])
                {
                    case 1:
                        sWord2 = "Messaging";
                        break;
                    case 2:
                        sWord2 = "TradeDriving";
                        break;
                    case 3:
                        sWord2 = "Unitarys";
                        break;
                    case 4:
                        sWord2 = "Thorpes";
                        break;
                    default:
                        sWord2 = "Processing";
                        break;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    sWord = sWord + "\\" + sWord2;
                }
                else
                {
                    sWord = sWord + "/" + sWord2;
                }
                lstEntry.Items.Add(sWord);
            }
        }

        private void lstEntry_MouseDown(object sender, MouseButtonEventArgs e)
        {
         }
            
        private void btnChange1_Click(object sender, RoutedEventArgs e)
        {
            Random rnd1 = new Random();
            String sWord;
            String sWord2;
            MessageBoxResult sReply;
        
            sReply = MessageBox.Show("Change [state]", "Change", MessageBoxButton.YesNo);
            if (sReply == MessageBoxResult.Yes)
            {
                switch (txt1.Text)
                {
                    case "1":
                        _state[mnItem - 1] = 1;
                        break;
                    case "2":
                        _state[mnItem - 1] = 2;
                        break;
                    case "3":
                        _state[mnItem - 1] = 3;
                        break;
                    case "4":
                        _state[mnItem - 1] = 4;
                        break;
                    case "5":
                        _state[mnItem - 1] = 5;
                        break;
                    default:
                        _state[mnItem - 1] = 6;
                        break;
                }

            }
            else
            {
                sReply = MessageBox.Show("Change [population]", "Change", MessageBoxButton.YesNo);
                if (sReply == MessageBoxResult.Yes)
                {
                    _population[mnItem - 1] = Convert.ToInt32(txt1.Text);

                }
                else
                {
                    switch (txt1.Text)
                    {
                        case "1":
                            _work[mnItem - 1] = 1;
                            break;
                        case "2":
                            _work[mnItem - 1] = 2;
                            break;
                        case "3":
                            _work[mnItem - 1] = 3;
                            break;
                        case "4":
                            _work[mnItem - 1] = 4;
                            break;
                        default:
                            _work[mnItem - 1] = 5;
                            break;
                    }

                }

            }


            if (lstEntry.Items.Count > 0)
            {

                do
                {
                    lstEntry.Items.RemoveAt(0);
                } while (lstEntry.Items.Count > 0);
            }

            for (int i = 1; i <= 8; i++)
            {
                  switch (_state[i - 1])
                {
                    case 1:
                        sWord = "UN";
                        break;
                    case 2:
                        sWord = "UD";
                        break;
                    case 3:
                        sWord = "P";
                        break;
                    case 4:
                        sWord = "R";
                        break;
                    case 5:
                        sWord = "N";
                        break;
                    default:
                        sWord = "Z";
                        break;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    sWord = sWord + "\\" + Convert.ToString(_population[i - 1]);
                }
                else
                {
                    sWord = sWord + "/" + Convert.ToString(_population[i - 1]);
                }
                switch (_work[i - 1])
                {
                    case 1:
                        sWord2 = "Messaging";
                        break;
                    case 2:
                        sWord2 = "TradeDriving";
                        break;
                    case 3:
                        sWord2 = "Unitarys";
                        break;
                    case 4:
                        sWord2 = "Thorpes";
                        break;
                    default:
                        sWord2 = "Processing";
                        break;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    sWord = sWord + "\\" + sWord2;
                }
                else
                {
                    sWord = sWord + "/" + sWord2;
                }
                lstEntry.Items.Add(sWord);
            }
        }


        private void btnChange3_Click(object sender, RoutedEventArgs e)
        {
            String sText = txtDiary.Text;
            lst1.Items.Add(sText);
        }

        private void btnDiaryClear_Click(object sender, RoutedEventArgs e)
        {
            if (lst1.Items.Count > 0)
            {

                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }
        }

        private void btnQNext_Click(object sender, RoutedEventArgs e)
        {
            Random rnd1 = new Random();
            String sWord;
            String sWord2;

            if (lstEntry.Items.Count > 0)
            {

                do
                {
                    lstEntry.Items.RemoveAt(0);
                } while (lstEntry.Items.Count > 0);
            }

            for (int i = 1; i <= 8; i++)
            {
                _state[i - 1] = rnd1.Next(1, 7);
                _population[i - 1] = rnd1.Next(1, 14001);
                _work[i - 1] = rnd1.Next(1, 6);
                switch (_state[i - 1])
                {
                    case 1:
                        sWord = "UN";
                        break;
                    case 2:
                        sWord = "UD";
                        break;
                    case 3:
                        sWord = "P";
                        break;
                    case 4:
                        sWord = "R";
                        break;
                    case 5:
                        sWord = "N";
                        break;
                    default:
                        sWord = "Z";
                        break;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    sWord = sWord + "\\" + Convert.ToString(_population[i - 1]);
                }
                else
                {
                    sWord = sWord + "/" + Convert.ToString(_population[i - 1]);
                }
                switch (_work[i - 1])
                {
                    case 1:
                        sWord2 = "Messaging";
                        break;
                    case 2:
                        sWord2 = "TradeDriving";
                        break;
                    case 3:
                        sWord2 = "Unitarys";
                        break;
                    case 4:
                        sWord2 = "Thorpes";
                        break;
                    default:
                        sWord2 = "Processing";
                        break;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    sWord = sWord + "\\" + sWord2;
                }
                else
                {
                    sWord = sWord + "/" + sWord2;
                }
                lstEntry.Items.Add(sWord);
            }
        }

        private void lstEntry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void lstEntry_MouseLeave(object sender, MouseEventArgs e)
        {
            mnItem = lstEntry.SelectedIndex + 1;
        }

    }
}
