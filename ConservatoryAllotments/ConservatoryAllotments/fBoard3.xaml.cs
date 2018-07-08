﻿using System;
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
    /// Interaction logic for fBoard3.xaml
    /// </summary>
    public partial class fBoard3 : Window
    {
        private static List<int> _Colour = new List<int> { 0, 0, 0, 0, 0 };
        private static List<int> _type = new List<int> { 0, 0, 0, 0, 0 };
        private static List<int> _number = new List<int> { 0, 0, 0, 0, 0 };
        private int nNumber;

        public fBoard3()
        {
            InitializeComponent();
            Random rnd1 = new Random();
            Color cl1 = new Color();
            String sWord;

            for (int i = 1; i <= 5; i++)
            {
                _Colour[i - 1] = rnd1.Next(1, 5);
                _type[i - 1] = rnd1.Next(1, 9);
                _number[i - 1] = rnd1.Next(1, 201);
                switch (_Colour[i - 1])
                {
                    case 1:
                        cl1 = Color.FromArgb(128, 230, 30, 30);
                        break;
                    case 2:
                        cl1 = Color.FromArgb(128, 230, 30, 230);
                        break;
                    case 3:
                        cl1 = Color.FromArgb(128, 30, 30, 230);
                        break;
                    default:
                        cl1 = Color.FromArgb(128, 130, 130, 130);
                        break;
                }
                switch (i)
                {
                    case 1:
                        btn1.Background = new SolidColorBrush(cl1);
                        break;
                    case 2:
                        btn2.Background = new SolidColorBrush(cl1);
                        break;
                    case 3:
                        btn3.Background = new SolidColorBrush(cl1);
                        break;
                    case 4:
                        btn4.Background = new SolidColorBrush(cl1);
                        break;
                   default:
                        btn5.Background = new SolidColorBrush(cl1);
                        break;
                }
                switch (_type[i - 1])
                {
                    case 1:
                        sWord = "same";
                        break;
                    case 2:
                        sWord = "upgrade";
                        break;
                    case 3:
                        sWord = "obelisk";
                        break;
                    case 4:
                        sWord = "scatum";
                        break;
                    case 5:
                        sWord = "appeared";
                        break;
                    case 6:
                        sWord = "gravy";
                        break;
                    case 7:
                        sWord = "boiled";
                        break;
                    default:
                        sWord = "turnover";
                        break;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    sWord = sWord + "\\" + Convert.ToString(_number[i - 1]);
                }
                else
                {
                    sWord = sWord + "/" + Convert.ToString(_number[i - 1]);
                }
                switch (i)
                {
                    case 1:
                        btn1.Content = sWord;
                        break;
                    case 2:
                        btn2.Content = sWord;
                        break;
                    case 3:
                        btn3.Content = sWord;
                        break;
                    case 4:
                        btn4.Content = sWord;
                        break;
                   default:
                        btn5.Content = sWord;
                        break;
                }

            }
        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
              }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
          }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
           }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void btnDiary_Click(object sender, RoutedEventArgs e)
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
            Color cl1 = new Color();
            String sWord;

            for (int i = 1; i <= 5; i++)
            {
                _Colour[i - 1] = rnd1.Next(1, 5);
                _type[i - 1] = rnd1.Next(1, 9);
                _number[i - 1] = rnd1.Next(1, 201);
                switch (_Colour[i - 1])
                {
                    case 1:
                        cl1 = Color.FromArgb(128, 230, 30, 30);
                        break;
                    case 2:
                        cl1 = Color.FromArgb(128, 230, 30, 230);
                        break;
                    case 3:
                        cl1 = Color.FromArgb(128, 30, 30, 230);
                        break;
                    default:
                        cl1 = Color.FromArgb(128, 130, 130, 130);
                        break;
                }
                switch (i)
                {
                    case 1:
                        btn1.Background = new SolidColorBrush(cl1);
                        break;
                    case 2:
                        btn2.Background = new SolidColorBrush(cl1);
                        break;
                    case 3:
                        btn3.Background = new SolidColorBrush(cl1);
                        break;
                    case 4:
                        btn4.Background = new SolidColorBrush(cl1);
                        break;
                   default:
                        btn5.Background = new SolidColorBrush(cl1);
                        break;
                }
                switch (_type[i - 1])
                {
                    case 1:
                        sWord = "same";
                        break;
                    case 2:
                        sWord = "upgrade";
                        break;
                    case 3:
                        sWord = "obelisk";
                        break;
                    case 4:
                        sWord = "scatum";
                        break;
                    case 5:
                        sWord = "appeared";
                        break;
                    case 6:
                        sWord = "gravy";
                        break;
                    case 7:
                        sWord = "boiled";
                        break;
                    default:
                        sWord = "turnover";
                        break;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    sWord = sWord + "\\" + Convert.ToString(_number[i - 1]);
                }
                else
                {
                    sWord = sWord + "/" + Convert.ToString(_number[i - 1]);
                }
                switch (i)
                {
                    case 1:
                        btn1.Content = sWord;
                        break;
                    case 2:
                        btn2.Content = sWord;
                        break;
                    case 3:
                        btn3.Content = sWord;
                        break;
                    case 4:
                        btn4.Content = sWord;
                        break;
                    default:
                        btn5.Content = sWord;
                        break;
                }

            }
        }

        private void btn1_Click_1(object sender, RoutedEventArgs e)
        {
            Random rnd1 = new Random();
            MessageBoxResult sReply;
            String sNew = txt1.Text;
            String sWord;

            sReply = MessageBox.Show("Change [number]", "Change", MessageBoxButton.YesNo);
            if (sReply == MessageBoxResult.No)
            {
                switch (sNew)
                {
                    case "1":
                        _type[0] = 1;
                        break;
                    case "2":
                        _type[0] = 2;
                        break;
                    case "3":
                        _type[0] = 3;
                        break;
                    case "4":
                        _type[0] = 4;
                        break;
                    case "5":
                        _type[0] = 5;
                        break;
                    case "6":
                        _type[0] = 6;
                        break;
                    case "7":
                        _type[0] = 7;
                        break;
                    default:
                        _type[0] = 8;
                        break;
                }

            }
            else
            {
                _number[0] = Convert.ToInt32(sNew);
            }
            switch (_type[0])
            {
                case 1:
                    sWord = "same";
                    break;
                case 2:
                    sWord = "upgrade";
                    break;
                case 3:
                    sWord = "obelisk";
                    break;
                case 4:
                    sWord = "scatum";
                    break;
                case 5:
                    sWord = "appeared";
                    break;
                case 6:
                    sWord = "gravy";
                    break;
                case 7:
                    sWord = "boiled";
                    break;
                default:
                    sWord = "turnover";
                    break;
            }
            nNumber = rnd1.Next(1, 10);
            if (nNumber <= 5)
            {
                sWord = sWord + "\\" + Convert.ToString(_number[0]);
            }
            else
            {
                sWord = sWord + "/" + Convert.ToString(_number[0]);
            }
            btn1.Content = sWord;

        }

        private void btn2_Click_1(object sender, RoutedEventArgs e)
        {
            Random rnd1 = new Random();
            MessageBoxResult sReply;
            String sNew = txt1.Text;
            String sWord;

            sReply = MessageBox.Show("Change [number]", "Change", MessageBoxButton.YesNo);
            if (sReply == MessageBoxResult.No)
            {
                switch (sNew)
                {
                    case "1":
                        _type[1] = 1;
                        break;
                    case "2":
                        _type[1] = 2;
                        break;
                    case "3":
                        _type[1] = 3;
                        break;
                    case "4":
                        _type[1] = 4;
                        break;
                    case "5":
                        _type[1] = 5;
                        break;
                    case "6":
                        _type[1] = 6;
                        break;
                    case "7":
                        _type[1] = 7;
                        break;
                    default:
                        _type[1] = 8;
                        break;
                }

            }
            else
            {
                _number[1] = Convert.ToInt32(sNew);
            }
            switch (_type[1])
            {
                case 1:
                    sWord = "same";
                    break;
                case 2:
                    sWord = "upgrade";
                    break;
                case 3:
                    sWord = "obelisk";
                    break;
                case 4:
                    sWord = "scatum";
                    break;
                case 5:
                    sWord = "appeared";
                    break;
                case 6:
                    sWord = "gravy";
                    break;
                case 7:
                    sWord = "boiled";
                    break;
                default:
                    sWord = "turnover";
                    break;
            }
            nNumber = rnd1.Next(1, 10);
            if (nNumber <= 5)
            {
                sWord = sWord + "\\" + Convert.ToString(_number[1]);
            }
            else
            {
                sWord = sWord + "/" + Convert.ToString(_number[1]);
            }
            btn2.Content = sWord;

        }

        private void btn3_Click_1(object sender, RoutedEventArgs e)
        {
            Random rnd1 = new Random();
            MessageBoxResult sReply;
            String sNew = txt1.Text;
            String sWord;

            sReply = MessageBox.Show("Change [number]", "Change", MessageBoxButton.YesNo);
            if (sReply == MessageBoxResult.No)
            {
                switch (sNew)
                {
                    case "1":
                        _type[2] = 1;
                        break;
                    case "2":
                        _type[2] = 2;
                        break;
                    case "3":
                        _type[2] = 3;
                        break;
                    case "4":
                        _type[2] = 4;
                        break;
                    case "5":
                        _type[2] = 5;
                        break;
                    case "6":
                        _type[2] = 6;
                        break;
                    case "7":
                        _type[2] = 7;
                        break;
                    default:
                        _type[2] = 8;
                        break;
                }

            }
            else
            {
                _number[2] = Convert.ToInt32(sNew);
            }
            switch (_type[2])
            {
                case 1:
                    sWord = "same";
                    break;
                case 2:
                    sWord = "upgrade";
                    break;
                case 3:
                    sWord = "obelisk";
                    break;
                case 4:
                    sWord = "scatum";
                    break;
                case 5:
                    sWord = "appeared";
                    break;
                case 6:
                    sWord = "gravy";
                    break;
                case 7:
                    sWord = "boiled";
                    break;
                default:
                    sWord = "turnover";
                    break;
            }
            nNumber = rnd1.Next(1, 10);
            if (nNumber <= 5)
            {
                sWord = sWord + "\\" + Convert.ToString(_number[2]);
            }
            else
            {
                sWord = sWord + "/" + Convert.ToString(_number[2]);
            }
            btn3.Content = sWord;

        }

        private void btn4_Click_1(object sender, RoutedEventArgs e)
        {
            Random rnd1 = new Random();
            MessageBoxResult sReply;
            String sNew = txt1.Text;
            String sWord;

            sReply = MessageBox.Show("Change [number]", "Change", MessageBoxButton.YesNo);
            if (sReply == MessageBoxResult.No)
            {
                switch (sNew)
                {
                    case "1":
                        _type[3] = 1;
                        break;
                    case "2":
                        _type[3] = 2;
                        break;
                    case "3":
                        _type[3] = 3;
                        break;
                    case "4":
                        _type[3] = 4;
                        break;
                    case "5":
                        _type[3] = 5;
                        break;
                    case "6":
                        _type[3] = 6;
                        break;
                    case "7":
                        _type[3] = 7;
                        break;
                    default:
                        _type[3] = 8;
                        break;
                }

            }
            else
            {
                _number[3] = Convert.ToInt32(sNew);
            }
            switch (_type[3])
            {
                case 1:
                    sWord = "same";
                    break;
                case 2:
                    sWord = "upgrade";
                    break;
                case 3:
                    sWord = "obelisk";
                    break;
                case 4:
                    sWord = "scatum";
                    break;
                case 5:
                    sWord = "appeared";
                    break;
                case 6:
                    sWord = "gravy";
                    break;
                case 7:
                    sWord = "boiled";
                    break;
                default:
                    sWord = "turnover";
                    break;
            }
            nNumber = rnd1.Next(1, 10);
            if (nNumber <= 5)
            {
                sWord = sWord + "\\" + Convert.ToString(_number[3]);
            }
            else
            {
                sWord = sWord + "/" + Convert.ToString(_number[3]);
            }
            btn4.Content = sWord;

        }

        private void btn5_Click_1(object sender, RoutedEventArgs e)
        {
            Random rnd1 = new Random();
            MessageBoxResult sReply;
            String sNew = txt1.Text;
            String sWord;

            sReply = MessageBox.Show("Change [number]", "Change", MessageBoxButton.YesNo);
            if (sReply == MessageBoxResult.No)
            {
                switch (sNew)
                {
                    case "1":
                        _type[4] = 1;
                        break;
                    case "2":
                        _type[4] = 2;
                        break;
                    case "3":
                        _type[4] = 3;
                        break;
                    case "4":
                        _type[4] = 4;
                        break;
                    case "5":
                        _type[4] = 5;
                        break;
                    case "6":
                        _type[4] = 6;
                        break;
                    case "7":
                        _type[4] = 7;
                        break;
                    default:
                        _type[4] = 8;
                        break;
                }

            }
            else
            {
                _number[4] = Convert.ToInt32(sNew);
            }
            switch (_type[4])
            {
                case 1:
                    sWord = "same";
                    break;
                case 2:
                    sWord = "upgrade";
                    break;
                case 3:
                    sWord = "obelisk";
                    break;
                case 4:
                    sWord = "scatum";
                    break;
                case 5:
                    sWord = "appeared";
                    break;
                case 6:
                    sWord = "gravy";
                    break;
                case 7:
                    sWord = "boiled";
                    break;
                default:
                    sWord = "turnover";
                    break;
            }
            nNumber = rnd1.Next(1, 10);
            if (nNumber <= 5)
            {
                sWord = sWord + "\\" + Convert.ToString(_number[4]);
            }
            else
            {
                sWord = sWord + "/" + Convert.ToString(_number[4]);
            }
            btn5.Content = sWord;
        }
    }
}
