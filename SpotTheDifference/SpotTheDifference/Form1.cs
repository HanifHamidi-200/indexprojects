﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotTheDifference
{
    public partial class Form1 : Form
    {
        private static List<int> _col1_1 = new List<int> { 0, 0, 0, 0, 0 };
        private static List<int> _col1_2 = new List<int> { 0, 0, 0, 0, 0 };
        private static List<int> _col1_3 = new List<int> { 0, 0, 0, 0, 0 };
        private static List<int> _col1_4 = new List<int> { 0, 0, 0, 0, 0 };
        private static List<int> _col1_5 = new List<int> { 0, 0, 0, 0, 0 };
        private static List<int> _col2_1 = new List<int> { 0, 0, 0, 0, 0 };
        private static List<int> _col2_2 = new List<int> { 0, 0, 0, 0, 0 };
        private static List<int> _col2_3 = new List<int> { 0, 0, 0, 0, 0 };
        private static List<int> _col2_4 = new List<int> { 0, 0, 0, 0, 0 };
        private static List<int> _col2_5 = new List<int> { 0, 0, 0, 0, 0 };
        private static List<int> _rotate1_1 = new List<int> { 0, 0, 0, 0, 0 };
        private static List<int> _rotate1_2 = new List<int> { 0, 0, 0, 0, 0 };
        private static List<int> _rotate1_3 = new List<int> { 0, 0, 0, 0, 0 };
        private static List<int> _rotate1_4 = new List<int> { 0, 0, 0, 0, 0 };
        private static List<int> _rotate1_5 = new List<int> { 0, 0, 0, 0, 0 };
        private static List<int> _rotate2_1 = new List<int> { 0, 0, 0, 0, 0 };
        private static List<int> _rotate2_2 = new List<int> { 0, 0, 0, 0, 0 };
        private static List<int> _rotate2_3 = new List<int> { 0, 0, 0, 0, 0 };
        private static List<int> _rotate2_4 = new List<int> { 0, 0, 0, 0, 0 };
        private static List<int> _rotate2_5 = new List<int> { 0, 0, 0, 0, 0 };
        private static List<bool> _use1 = new List<bool> { false,false,false,false,false};
        private static List<bool> _use2= new List<bool> { false, false, false, false, false };
        private static List<bool> _use3 = new List<bool> { false, false, false, false, false };
        private static List<bool> _use4 = new List<bool> { false, false, false, false, false };
        private static List<bool> _use5 = new List<bool> { false, false, false, false, false };
        private int nNumber;

        private void fUpdateDisplay()
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F colour1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F colour2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F colour3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F colour4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F cross.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };


            switch (_col1_1[0])
            {
                case 1:
                    pic1_11.Image = picture1.Image;
                    break;
                case 2:
                    pic1_11.Image = picture2.Image;
                    break;
                case 3:
                    pic1_11.Image = picture3.Image;
                    break;
                case 4:
                    pic1_11.Image = picture4.Image;
                    break;
                case 5:
                    pic1_11.Image = picture5.Image;
                    break;
                default:
                    pic1_11.Image = picture6.Image;
                    break;
            }
            switch (_col1_1[1])
            {
                case 1:
                    pic1_12.Image = picture1.Image;
                    break;
                case 2:
                    pic1_12.Image = picture2.Image;
                    break;
                case 3:
                    pic1_12.Image = picture3.Image;
                    break;
                case 4:
                    pic1_12.Image = picture4.Image;
                    break;
                case 5:
                    pic1_12.Image = picture5.Image;
                    break;
                default:
                    pic1_12.Image = picture6.Image;
                    break;
            }
            switch (_col1_1[2])
            {
                case 1:
                    pic1_13.Image = picture1.Image;
                    break;
                case 2:
                    pic1_13.Image = picture2.Image;
                    break;
                case 3:
                    pic1_13.Image = picture3.Image;
                    break;
                case 4:
                    pic1_13.Image = picture4.Image;
                    break;
                case 5:
                    pic1_13.Image = picture5.Image;
                    break;
                default:
                    pic1_13.Image = picture6.Image;
                    break;
            }
            switch (_col1_1[3])
            {
                case 1:
                    pic1_14.Image = picture1.Image;
                    break;
                case 2:
                    pic1_14.Image = picture2.Image;
                    break;
                case 3:
                    pic1_14.Image = picture3.Image;
                    break;
                case 4:
                    pic1_14.Image = picture4.Image;
                    break;
                case 5:
                    pic1_14.Image = picture5.Image;
                    break;
                default:
                    pic1_14.Image = picture6.Image;
                    break;
            }
            switch (_col1_1[4])
            {
                case 1:
                    pic1_15.Image = picture1.Image;
                    break;
                case 2:
                    pic1_15.Image = picture2.Image;
                    break;
                case 3:
                    pic1_15.Image = picture3.Image;
                    break;
                case 4:
                    pic1_15.Image = picture4.Image;
                    break;
                case 5:
                    pic1_15.Image = picture5.Image;
                    break;
                default:
                    pic1_15.Image = picture6.Image;
                    break;
            }

            //col2 now
            switch (_col1_2[0])
            {
                case 1:
                    pic1_21.Image = picture1.Image;
                    break;
                case 2:
                    pic1_21.Image = picture2.Image;
                    break;
                case 3:
                    pic1_21.Image = picture3.Image;
                    break;
                case 4:
                    pic1_21.Image = picture4.Image;
                    break;
                case 5:
                    pic1_21.Image = picture5.Image;
                    break;
                default:
                    pic1_21.Image = picture6.Image;
                    break;
            }
            switch (_col1_2[1])
            {
                case 1:
                    pic1_22.Image = picture1.Image;
                    break;
                case 2:
                    pic1_22.Image = picture2.Image;
                    break;
                case 3:
                    pic1_22.Image = picture3.Image;
                    break;
                case 4:
                    pic1_22.Image = picture4.Image;
                    break;
                case 5:
                    pic1_22.Image = picture5.Image;
                    break;
                default:
                    pic1_22.Image = picture6.Image;
                    break;
            }
            switch (_col1_2[2])
            {
                case 1:
                    pic1_23.Image = picture1.Image;
                    break;
                case 2:
                    pic1_23.Image = picture2.Image;
                    break;
                case 3:
                    pic1_23.Image = picture3.Image;
                    break;
                case 4:
                    pic1_23.Image = picture4.Image;
                    break;
                case 5:
                    pic1_23.Image = picture5.Image;
                    break;
                default:
                    pic1_23.Image = picture6.Image;
                    break;
            }
            switch (_col1_2[3])
            {
                case 1:
                    pic1_24.Image = picture1.Image;
                    break;
                case 2:
                    pic1_24.Image = picture2.Image;
                    break;
                case 3:
                    pic1_24.Image = picture3.Image;
                    break;
                case 4:
                    pic1_24.Image = picture4.Image;
                    break;
                case 5:
                    pic1_24.Image = picture5.Image;
                    break;
                default:
                    pic1_24.Image = picture6.Image;
                    break;
            }
            switch (_col1_2[4])
            {
                case 1:
                    pic1_25.Image = picture1.Image;
                    break;
                case 2:
                    pic1_25.Image = picture2.Image;
                    break;
                case 3:
                    pic1_25.Image = picture3.Image;
                    break;
                case 4:
                    pic1_25.Image = picture4.Image;
                    break;
                case 5:
                    pic1_25.Image = picture5.Image;
                    break;
                default:
                    pic1_25.Image = picture6.Image;
                    break;
            }


            //col3 now

            switch (_col1_3[0])
            {
                case 1:
                    pic1_31.Image = picture1.Image;
                    break;
                case 2:
                    pic1_31.Image = picture2.Image;
                    break;
                case 3:
                    pic1_31.Image = picture3.Image;
                    break;
                case 4:
                    pic1_31.Image = picture4.Image;
                    break;
                case 5:
                    pic1_31.Image = picture5.Image;
                    break;
                default:
                    pic1_31.Image = picture6.Image;
                    break;
            }
            switch (_col1_3[1])
            {
                case 1:
                    pic1_32.Image = picture1.Image;
                    break;
                case 2:
                    pic1_32.Image = picture2.Image;
                    break;
                case 3:
                    pic1_32.Image = picture3.Image;
                    break;
                case 4:
                    pic1_32.Image = picture4.Image;
                    break;
                case 5:
                    pic1_32.Image = picture5.Image;
                    break;
                default:
                    pic1_32.Image = picture6.Image;
                    break;
            }
            switch (_col1_3[2])
            {
                case 1:
                    pic1_33.Image = picture1.Image;
                    break;
                case 2:
                    pic1_33.Image = picture2.Image;
                    break;
                case 3:
                    pic1_33.Image = picture3.Image;
                    break;
                case 4:
                    pic1_33.Image = picture4.Image;
                    break;
                case 5:
                    pic1_33.Image = picture5.Image;
                    break;
                default:
                    pic1_33.Image = picture6.Image;
                    break;
            }
            switch (_col1_3[3])
            {
                case 1:
                    pic1_34.Image = picture1.Image;
                    break;
                case 2:
                    pic1_34.Image = picture2.Image;
                    break;
                case 3:
                    pic1_34.Image = picture3.Image;
                    break;
                case 4:
                    pic1_34.Image = picture4.Image;
                    break;
                case 5:
                    pic1_34.Image = picture5.Image;
                    break;
                default:
                    pic1_34.Image = picture6.Image;
                    break;
            }
            switch (_col1_3[4])
            {
                case 1:
                    pic1_35.Image = picture1.Image;
                    break;
                case 2:
                    pic1_35.Image = picture2.Image;
                    break;
                case 3:
                    pic1_35.Image = picture3.Image;
                    break;
                case 4:
                    pic1_35.Image = picture4.Image;
                    break;
                case 5:
                    pic1_35.Image = picture5.Image;
                    break;
                default:
                    pic1_35.Image = picture6.Image;
                    break;
            }


            //col4 now
            switch (_col1_4[0])
            {
                case 1:
                    pic1_41.Image = picture1.Image;
                    break;
                case 2:
                    pic1_41.Image = picture2.Image;
                    break;
                case 3:
                    pic1_41.Image = picture3.Image;
                    break;
                case 4:
                    pic1_41.Image = picture4.Image;
                    break;
                case 5:
                    pic1_41.Image = picture5.Image;
                    break;
                default:
                    pic1_41.Image = picture6.Image;
                    break;
            }
            switch (_col1_4[1])
            {
                case 1:
                    pic1_42.Image = picture1.Image;
                    break;
                case 2:
                    pic1_42.Image = picture2.Image;
                    break;
                case 3:
                    pic1_42.Image = picture3.Image;
                    break;
                case 4:
                    pic1_42.Image = picture4.Image;
                    break;
                case 5:
                    pic1_42.Image = picture5.Image;
                    break;
                default:
                    pic1_42.Image = picture6.Image;
                    break;
            }
            switch (_col1_4[2])
            {
                case 1:
                    pic1_43.Image = picture1.Image;
                    break;
                case 2:
                    pic1_43.Image = picture2.Image;
                    break;
                case 3:
                    pic1_43.Image = picture3.Image;
                    break;
                case 4:
                    pic1_43.Image = picture4.Image;
                    break;
                case 5:
                    pic1_43.Image = picture5.Image;
                    break;
                default:
                    pic1_43.Image = picture6.Image;
                    break;
            }
            switch (_col1_4[3])
            {
                case 1:
                    pic1_44.Image = picture1.Image;
                    break;
                case 2:
                    pic1_44.Image = picture2.Image;
                    break;
                case 3:
                    pic1_44.Image = picture3.Image;
                    break;
                case 4:
                    pic1_44.Image = picture4.Image;
                    break;
                case 5:
                    pic1_44.Image = picture5.Image;
                    break;
                default:
                    pic1_44.Image = picture6.Image;
                    break;
            }
            switch (_col1_4[4])
            {
                case 1:
                    pic1_45.Image = picture1.Image;
                    break;
                case 2:
                    pic1_45.Image = picture2.Image;
                    break;
                case 3:
                    pic1_45.Image = picture3.Image;
                    break;
                case 4:
                    pic1_45.Image = picture4.Image;
                    break;
                case 5:
                    pic1_45.Image = picture5.Image;
                    break;
                default:
                    pic1_45.Image = picture6.Image;
                    break;
            }


            //col5 now
            switch (_col1_5[0])
            {
                case 1:
                    pic1_51.Image = picture1.Image;
                    break;
                case 2:
                    pic1_51.Image = picture2.Image;
                    break;
                case 3:
                    pic1_51.Image = picture3.Image;
                    break;
                case 4:
                    pic1_51.Image = picture4.Image;
                    break;
                case 5:
                    pic1_51.Image = picture5.Image;
                    break;
                default:
                    pic1_51.Image = picture6.Image;
                    break;
            }
            switch (_col1_5[1])
            {
                case 1:
                    pic1_52.Image = picture1.Image;
                    break;
                case 2:
                    pic1_52.Image = picture2.Image;
                    break;
                case 3:
                    pic1_52.Image = picture3.Image;
                    break;
                case 4:
                    pic1_52.Image = picture4.Image;
                    break;
                case 5:
                    pic1_52.Image = picture5.Image;
                    break;
                default:
                    pic1_52.Image = picture6.Image;
                    break;
            }
            switch (_col1_5[2])
            {
                case 1:
                    pic1_53.Image = picture1.Image;
                    break;
                case 2:
                    pic1_53.Image = picture2.Image;
                    break;
                case 3:
                    pic1_53.Image = picture3.Image;
                    break;
                case 4:
                    pic1_53.Image = picture4.Image;
                    break;
                case 5:
                    pic1_53.Image = picture5.Image;
                    break;
                default:
                    pic1_53.Image = picture6.Image;
                    break;
            }
            switch (_col1_5[3])
            {
                case 1:
                    pic1_54.Image = picture1.Image;
                    break;
                case 2:
                    pic1_54.Image = picture2.Image;
                    break;
                case 3:
                    pic1_54.Image = picture3.Image;
                    break;
                case 4:
                    pic1_54.Image = picture4.Image;
                    break;
                case 5:
                    pic1_54.Image = picture5.Image;
                    break;
                default:
                    pic1_54.Image = picture6.Image;
                    break;
            }
            switch (_col1_5[4])
            {
                case 1:
                    pic1_55.Image = picture1.Image;
                    break;
                case 2:
                    pic1_55.Image = picture2.Image;
                    break;
                case 3:
                    pic1_55.Image = picture3.Image;
                    break;
                case 4:
                    pic1_55.Image = picture4.Image;
                    break;
                case 5:
                    pic1_55.Image = picture5.Image;
                    break;
                default:
                    pic1_55.Image = picture6.Image;
                    break;
            }


            //GridB
            switch (_col2_1[0])
            {
                case 1:
                    pic2_11.Image = picture1.Image;
                    break;
                case 2:
                    pic2_11.Image = picture2.Image;
                    break;
                case 3:
                    pic2_11.Image = picture3.Image;
                    break;
                case 4:
                    pic2_11.Image = picture4.Image;
                    break;
                case 5:
                    pic2_11.Image = picture5.Image;
                    break;
                default:
                    pic2_11.Image = picture6.Image;
                    break;
            }
            switch (_col2_1[1])
            {
                case 1:
                    pic2_12.Image = picture1.Image;
                    break;
                case 2:
                    pic2_12.Image = picture2.Image;
                    break;
                case 3:
                    pic2_12.Image = picture3.Image;
                    break;
                case 4:
                    pic2_12.Image = picture4.Image;
                    break;
                case 5:
                    pic2_12.Image = picture5.Image;
                    break;
                default:
                    pic2_12.Image = picture6.Image;
                    break;
            }
            switch (_col2_1[2])
            {
                case 1:
                    pic2_13.Image = picture1.Image;
                    break;
                case 2:
                    pic2_13.Image = picture2.Image;
                    break;
                case 3:
                    pic2_13.Image = picture3.Image;
                    break;
                case 4:
                    pic2_13.Image = picture4.Image;
                    break;
                case 5:
                    pic2_13.Image = picture5.Image;
                    break;
                default:
                    pic2_13.Image = picture6.Image;
                    break;
            }
            switch (_col2_1[3])
            {
                case 1:
                    pic2_14.Image = picture1.Image;
                    break;
                case 2:
                    pic2_14.Image = picture2.Image;
                    break;
                case 3:
                    pic2_14.Image = picture3.Image;
                    break;
                case 4:
                    pic2_14.Image = picture4.Image;
                    break;
                case 5:
                    pic2_14.Image = picture5.Image;
                    break;
                default:
                    pic2_14.Image = picture6.Image;
                    break;
            }
            switch (_col2_1[4])
            {
                case 1:
                    pic2_15.Image = picture1.Image;
                    break;
                case 2:
                    pic2_15.Image = picture2.Image;
                    break;
                case 3:
                    pic2_15.Image = picture3.Image;
                    break;
                case 4:
                    pic2_15.Image = picture4.Image;
                    break;
                case 5:
                    pic2_15.Image = picture5.Image;
                    break;
                default:
                    pic2_15.Image = picture6.Image;
                    break;
            }

            //col2 now
            switch (_col2_2[0])
            {
                case 1:
                    pic2_21.Image = picture1.Image;
                    break;
                case 2:
                    pic2_21.Image = picture2.Image;
                    break;
                case 3:
                    pic2_21.Image = picture3.Image;
                    break;
                case 4:
                    pic2_21.Image = picture4.Image;
                    break;
                case 5:
                    pic2_21.Image = picture5.Image;
                    break;
                default:
                    pic2_21.Image = picture6.Image;
                    break;
            }
            switch (_col2_2[1])
            {
                case 1:
                    pic2_22.Image = picture1.Image;
                    break;
                case 2:
                    pic2_22.Image = picture2.Image;
                    break;
                case 3:
                    pic2_22.Image = picture3.Image;
                    break;
                case 4:
                    pic2_22.Image = picture4.Image;
                    break;
                case 5:
                    pic2_22.Image = picture5.Image;
                    break;
                default:
                    pic2_22.Image = picture6.Image;
                    break;
            }
            switch (_col2_2[2])
            {
                case 1:
                    pic2_23.Image = picture1.Image;
                    break;
                case 2:
                    pic2_23.Image = picture2.Image;
                    break;
                case 3:
                    pic2_23.Image = picture3.Image;
                    break;
                case 4:
                    pic2_23.Image = picture4.Image;
                    break;
                case 5:
                    pic2_23.Image = picture5.Image;
                    break;
                default:
                    pic2_23.Image = picture6.Image;
                    break;
            }
            switch (_col2_2[3])
            {
                case 1:
                    pic2_24.Image = picture1.Image;
                    break;
                case 2:
                    pic2_24.Image = picture2.Image;
                    break;
                case 3:
                    pic2_24.Image = picture3.Image;
                    break;
                case 4:
                    pic2_24.Image = picture4.Image;
                    break;
                case 5:
                    pic2_24.Image = picture5.Image;
                    break;
                default:
                    pic2_24.Image = picture6.Image;
                    break;
            }
            switch (_col2_2[4])
            {
                case 1:
                    pic2_25.Image = picture1.Image;
                    break;
                case 2:
                    pic2_25.Image = picture2.Image;
                    break;
                case 3:
                    pic2_25.Image = picture3.Image;
                    break;
                case 4:
                    pic2_25.Image = picture4.Image;
                    break;
                case 5:
                    pic2_25.Image = picture5.Image;
                    break;
                default:
                    pic2_25.Image = picture6.Image;
                    break;
            }


            //col3 now

            switch (_col2_3[0])
            {
                case 1:
                    pic2_31.Image = picture1.Image;
                    break;
                case 2:
                    pic2_31.Image = picture2.Image;
                    break;
                case 3:
                    pic2_31.Image = picture3.Image;
                    break;
                case 4:
                    pic2_31.Image = picture4.Image;
                    break;
                case 5:
                    pic2_31.Image = picture5.Image;
                    break;
                default:
                    pic2_31.Image = picture6.Image;
                    break;
            }
            switch (_col2_3[1])
            {
                case 1:
                    pic2_32.Image = picture1.Image;
                    break;
                case 2:
                    pic2_32.Image = picture2.Image;
                    break;
                case 3:
                    pic2_32.Image = picture3.Image;
                    break;
                case 4:
                    pic2_32.Image = picture4.Image;
                    break;
                case 5:
                    pic2_32.Image = picture5.Image;
                    break;
                default:
                    pic2_32.Image = picture6.Image;
                    break;
            }
            switch (_col2_3[2])
            {
                case 1:
                    pic2_33.Image = picture1.Image;
                    break;
                case 2:
                    pic2_33.Image = picture2.Image;
                    break;
                case 3:
                    pic2_33.Image = picture3.Image;
                    break;
                case 4:
                    pic2_33.Image = picture4.Image;
                    break;
                case 5:
                    pic2_33.Image = picture5.Image;
                    break;
                default:
                    pic2_33.Image = picture6.Image;
                    break;
            }
            switch (_col2_3[3])
            {
                case 1:
                    pic2_34.Image = picture1.Image;
                    break;
                case 2:
                    pic2_34.Image = picture2.Image;
                    break;
                case 3:
                    pic2_34.Image = picture3.Image;
                    break;
                case 4:
                    pic2_34.Image = picture4.Image;
                    break;
                case 5:
                    pic2_34.Image = picture5.Image;
                    break;
                default:
                    pic2_34.Image = picture6.Image;
                    break;
            }
            switch (_col2_3[4])
            {
                case 1:
                    pic2_35.Image = picture1.Image;
                    break;
                case 2:
                    pic2_35.Image = picture2.Image;
                    break;
                case 3:
                    pic2_35.Image = picture3.Image;
                    break;
                case 4:
                    pic2_35.Image = picture4.Image;
                    break;
                case 5:
                    pic2_35.Image = picture5.Image;
                    break;
                default:
                    pic2_35.Image = picture6.Image;
                    break;
            }


            //col4 now
            switch (_col2_4[0])
            {
                case 1:
                    pic2_41.Image = picture1.Image;
                    break;
                case 2:
                    pic2_41.Image = picture2.Image;
                    break;
                case 3:
                    pic2_41.Image = picture3.Image;
                    break;
                case 4:
                    pic2_41.Image = picture4.Image;
                    break;
                case 5:
                    pic2_41.Image = picture5.Image;
                    break;
                default:
                    pic2_41.Image = picture6.Image;
                    break;
            }
            switch (_col2_4[1])
            {
                case 1:
                    pic2_42.Image = picture1.Image;
                    break;
                case 2:
                    pic2_42.Image = picture2.Image;
                    break;
                case 3:
                    pic2_42.Image = picture3.Image;
                    break;
                case 4:
                    pic2_42.Image = picture4.Image;
                    break;
                case 5:
                    pic2_42.Image = picture5.Image;
                    break;
                default:
                    pic2_42.Image = picture6.Image;
                    break;
            }
            switch (_col2_4[2])
            {
                case 1:
                    pic2_43.Image = picture1.Image;
                    break;
                case 2:
                    pic2_43.Image = picture2.Image;
                    break;
                case 3:
                    pic2_43.Image = picture3.Image;
                    break;
                case 4:
                    pic2_43.Image = picture4.Image;
                    break;
                case 5:
                    pic2_43.Image = picture5.Image;
                    break;
                default:
                    pic2_43.Image = picture6.Image;
                    break;
            }
            switch (_col2_4[3])
            {
                case 1:
                    pic2_44.Image = picture1.Image;
                    break;
                case 2:
                    pic2_44.Image = picture2.Image;
                    break;
                case 3:
                    pic2_44.Image = picture3.Image;
                    break;
                case 4:
                    pic2_44.Image = picture4.Image;
                    break;
                case 5:
                    pic2_44.Image = picture5.Image;
                    break;
                default:
                    pic2_44.Image = picture6.Image;
                    break;
            }
            switch (_col2_4[4])
            {
                case 1:
                    pic2_45.Image = picture1.Image;
                    break;
                case 2:
                    pic2_45.Image = picture2.Image;
                    break;
                case 3:
                    pic2_45.Image = picture3.Image;
                    break;
                case 4:
                    pic2_45.Image = picture4.Image;
                    break;
                case 5:
                    pic2_45.Image = picture5.Image;
                    break;
                default:
                    pic2_45.Image = picture6.Image;
                    break;
            }


            //col5 now
            switch (_col2_5[0])
            {
                case 1:
                    pic2_51.Image = picture1.Image;
                    break;
                case 2:
                    pic2_51.Image = picture2.Image;
                    break;
                case 3:
                    pic2_51.Image = picture3.Image;
                    break;
                case 4:
                    pic2_51.Image = picture4.Image;
                    break;
                case 5:
                    pic2_51.Image = picture5.Image;
                    break;
                default:
                    pic2_51.Image = picture6.Image;
                    break;
            }
            switch (_col2_5[1])
            {
                case 1:
                    pic2_52.Image = picture1.Image;
                    break;
                case 2:
                    pic2_52.Image = picture2.Image;
                    break;
                case 3:
                    pic2_52.Image = picture3.Image;
                    break;
                case 4:
                    pic2_52.Image = picture4.Image;
                    break;
                case 5:
                    pic2_52.Image = picture5.Image;
                    break;
                default:
                    pic2_52.Image = picture6.Image;
                    break;
            }
            switch (_col2_5[2])
            {
                case 1:
                    pic2_53.Image = picture1.Image;
                    break;
                case 2:
                    pic2_53.Image = picture2.Image;
                    break;
                case 3:
                    pic2_53.Image = picture3.Image;
                    break;
                case 4:
                    pic2_53.Image = picture4.Image;
                    break;
                case 5:
                    pic2_53.Image = picture5.Image;
                    break;
                default:
                    pic2_53.Image = picture6.Image;
                    break;
            }
            switch (_col2_5[3])
            {
                case 1:
                    pic2_54.Image = picture1.Image;
                    break;
                case 2:
                    pic2_54.Image = picture2.Image;
                    break;
                case 3:
                    pic2_54.Image = picture3.Image;
                    break;
                case 4:
                    pic2_54.Image = picture4.Image;
                    break;
                case 5:
                    pic2_54.Image = picture5.Image;
                    break;
                default:
                    pic2_54.Image = picture6.Image;
                    break;
            }
            switch (_col2_5[4])
            {
                case 1:
                    pic2_55.Image = picture1.Image;
                    break;
                case 2:
                    pic2_55.Image = picture2.Image;
                    break;
                case 3:
                    pic2_55.Image = picture3.Image;
                    break;
                case 4:
                    pic2_55.Image = picture4.Image;
                    break;
                case 5:
                    pic2_55.Image = picture5.Image;
                    break;
                default:
                    pic2_55.Image = picture6.Image;
                    break;
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nCol,nRow,nType;
            int nRotate1, nRotate2;

            for (int i = 1; i <= 5; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 4)
                {
                    _use1[i - 1] = false;
                }
                else
                {
                    _use1[i - 1] = true;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 4)
                {
                    _use2[i - 1] = false;
                }
                else
                {
                    _use2[i - 1] = true;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 4)
                {
                    _use3[i - 1] = false;
                }
                else
                {
                    _use3[i - 1] = true;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 4)
                {
                    _use4[i - 1] = false;
                }
                else
                {
                    _use4[i - 1] = true;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 4)
                {
                    _use5[i - 1] = false;
                }
                else
                {
                    _use5[i - 1] = true;
                }

            }

            //Board
            for (int i = 1; i <= 5; i++)
            {
                if (_use1[i - 1])
                {
                    nType = rnd1.Next(1, 5);
                    nRotate1 = rnd1.Next(1, 5);
                    nRotate2 = nRotate1 + rnd1.Next(1, 5);
                    _col1_1[i - 1] = nType;
                    _col2_1[i - 1] = nType;
                    _rotate1_1[i - 1] = nRotate1;
                    _rotate2_1[i - 1] = nRotate2;
                }
                else
                {
                    nType = 5;
                    nRotate1 = 1;
                    nRotate2 = 1;
                    _col1_1[i - 1] = nType;
                    _col2_1[i - 1] = nType;
                    _rotate1_1[i - 1] = nRotate1;
                    _rotate2_1[i - 1] = nRotate2;
                }
            }
            for (int i = 1; i <= 5; i++)
            {
                if (_use2[i - 1])
                {
                    nType = rnd1.Next(1, 5);
                    nRotate1 = rnd1.Next(1, 5);
                    nRotate2 = nRotate1 + rnd1.Next(1, 5);
                    _col1_2[i - 1] = nType;
                    _col2_2[i - 1] = nType;
                    _rotate1_2[i - 1] = nRotate1;
                    _rotate2_2[i - 1] = nRotate2;
                }
                else
                {
                    nType = 5;
                    nRotate1 = 1;
                    nRotate2 = 1;
                    _col1_2[i - 1] = nType;
                    _col2_2[i - 1] = nType;
                    _rotate1_2[i - 1] = nRotate1;
                    _rotate2_2[i - 1] = nRotate2;
                }
            }
            for (int i = 1; i <= 5; i++)
            {
                if (_use3[i - 1])
                {
                    nType = rnd1.Next(1, 5);
                    nRotate1 = rnd1.Next(1, 5);
                    nRotate2 = nRotate1 + rnd1.Next(1, 5);
                    _col1_3[i - 1] = nType;
                    _col2_3[i - 1] = nType;
                    _rotate1_3[i - 1] = nRotate1;
                    _rotate2_3[i - 1] = nRotate2;
                }
                else
                {
                    nType = 5;
                    nRotate1 = 1;
                    nRotate2 = 1;
                    _col1_3[i - 1] = nType;
                    _col2_3[i - 1] = nType;
                    _rotate1_3[i - 1] = nRotate1;
                    _rotate2_3[i - 1] = nRotate2;
                }
            }
            for (int i = 1; i <= 5; i++)
            {
                if (_use4[i - 1])
                {
                    nType = rnd1.Next(1, 5);
                    nRotate1 = rnd1.Next(1, 5);
                    nRotate2 = nRotate1 + rnd1.Next(1, 5);
                    _col1_4[i - 1] = nType;
                    _col2_4[i - 1] = nType;
                    _rotate1_4[i - 1] = nRotate1;
                    _rotate2_4[i - 1] = nRotate2;
                }
                else
                {
                    nType = 5;
                    nRotate1 = 1;
                    nRotate2 = 1;
                    _col1_4[i - 1] = nType;
                    _col2_4[i - 1] = nType;
                    _rotate1_4[i - 1] = nRotate1;
                    _rotate2_1[i - 1] = nRotate2;
                }
            }
            for (int i = 1; i <= 5; i++)
            {
                if (_use5[i - 1])
                {
                    nType = rnd1.Next(1, 5);
                    nRotate1 = rnd1.Next(1, 5);
                    nRotate2 = nRotate1 + rnd1.Next(1, 5);
                    _col1_5[i - 1] = nType;
                    _col2_5[i - 1] = nType;
                    _rotate1_5[i - 1] = nRotate1;
                    _rotate2_5[i - 1] = nRotate2;
                }
                else
                {
                    nType = 5;
                    nRotate1 = 1;
                    nRotate2 = 1;
                    _col1_5[i - 1] = nType;
                    _col2_5[i - 1] = nType;
                    _rotate1_5[i - 1] = nRotate1;
                    _rotate2_5[i - 1] = nRotate2;
                }
            }

            nNumber = rnd1.Next(2, 7);
            for (int i = 1; i <= nNumber; i++)
            {
                nCol = rnd1.Next(1, 6);
                nRow = rnd1.Next(1, 6);
                nType = rnd1.Next(1, 5);
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    switch (nCol)
                    {
                        case 1:
                            _col1_1[nRow - 1] = nType;
                            break;
                        case 2:
                            _col1_2[nRow - 1] = nType;
                            break;
                        case 3:
                            _col1_3[nRow - 1] = nType;
                            break;
                        case 4:
                            _col1_4[nRow - 1] = nType;
                            break;
                        default:
                            _col1_5[nRow - 1] = nType;
                            break;
                    }
                }
                else
                {
                    switch (nCol)
                    {
                        case 1:
                            _col2_1[nRow - 1] = nType;
                            break;
                        case 2:
                            _col2_2[nRow - 1] = nType;
                            break;
                        case 3:
                            _col2_3[nRow - 1] = nType;
                            break;
                        case 4:
                            _col2_4[nRow - 1] = nType;
                            break;
                        default:
                            _col2_5[nRow - 1] = nType;
                            break;
                    }

                }
            }

            fUpdateDisplay();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nCol, nRow, nType;
            int nRotate1, nRotate2;

            for (int i = 1; i <= 5; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 4)
                {
                    _use1[i - 1] = false;
                }
                else
                {
                    _use1[i - 1] = true;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 4)
                {
                    _use2[i - 1] = false;
                }
                else
                {
                    _use2[i - 1] = true;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 4)
                {
                    _use3[i - 1] = false;
                }
                else
                {
                    _use3[i - 1] = true;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 4)
                {
                    _use4[i - 1] = false;
                }
                else
                {
                    _use4[i - 1] = true;
                }
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 4)
                {
                    _use5[i - 1] = false;
                }
                else
                {
                    _use5[i - 1] = true;
                }

            }

            //Board
            for (int i = 1; i <= 5; i++)
            {
                if (_use1[i - 1])
                {
                    nType = rnd1.Next(1, 5);
                    nRotate1 = rnd1.Next(1, 5);
                    nRotate2 = nRotate1 + rnd1.Next(1, 5);
                    _col1_1[i - 1] = nType;
                    _col2_1[i - 1] = nType;
                    _rotate1_1[i - 1] = nRotate1;
                    _rotate2_1[i - 1] = nRotate2;
                }
                else
                {
                    nType = 5;
                    nRotate1 = 1;
                    nRotate2 = 1;
                    _col1_1[i - 1] = nType;
                    _col2_1[i - 1] = nType;
                    _rotate1_1[i - 1] = nRotate1;
                    _rotate2_1[i - 1] = nRotate2;
                }
            }
            for (int i = 1; i <= 5; i++)
            {
                if (_use2[i - 1])
                {
                    nType = rnd1.Next(1, 5);
                    nRotate1 = rnd1.Next(1, 5);
                    nRotate2 = nRotate1 + rnd1.Next(1, 5);
                    _col1_2[i - 1] = nType;
                    _col2_2[i - 1] = nType;
                    _rotate1_2[i - 1] = nRotate1;
                    _rotate2_2[i - 1] = nRotate2;
                }
                else
                {
                    nType = 5;
                    nRotate1 = 1;
                    nRotate2 = 1;
                    _col1_2[i - 1] = nType;
                    _col2_2[i - 1] = nType;
                    _rotate1_2[i - 1] = nRotate1;
                    _rotate2_2[i - 1] = nRotate2;
                }
            }
            for (int i = 1; i <= 5; i++)
            {
                if (_use3[i - 1])
                {
                    nType = rnd1.Next(1, 5);
                    nRotate1 = rnd1.Next(1, 5);
                    nRotate2 = nRotate1 + rnd1.Next(1, 5);
                    _col1_3[i - 1] = nType;
                    _col2_3[i - 1] = nType;
                    _rotate1_3[i - 1] = nRotate1;
                    _rotate2_3[i - 1] = nRotate2;
                }
                else
                {
                    nType = 5;
                    nRotate1 = 1;
                    nRotate2 = 1;
                    _col1_3[i - 1] = nType;
                    _col2_3[i - 1] = nType;
                    _rotate1_3[i - 1] = nRotate1;
                    _rotate2_3[i - 1] = nRotate2;
                }
            }
            for (int i = 1; i <= 5; i++)
            {
                if (_use4[i - 1])
                {
                    nType = rnd1.Next(1, 5);
                    nRotate1 = rnd1.Next(1, 5);
                    nRotate2 = nRotate1 + rnd1.Next(1, 5);
                    _col1_4[i - 1] = nType;
                    _col2_4[i - 1] = nType;
                    _rotate1_4[i - 1] = nRotate1;
                    _rotate2_4[i - 1] = nRotate2;
                }
                else
                {
                    nType = 5;
                    nRotate1 = 1;
                    nRotate2 = 1;
                    _col1_4[i - 1] = nType;
                    _col2_4[i - 1] = nType;
                    _rotate1_4[i - 1] = nRotate1;
                    _rotate2_1[i - 1] = nRotate2;
                }
            }
            for (int i = 1; i <= 5; i++)
            {
                if (_use5[i - 1])
                {
                    nType = rnd1.Next(1, 5);
                    nRotate1 = rnd1.Next(1, 5);
                    nRotate2 = nRotate1 + rnd1.Next(1, 5);
                    _col1_5[i - 1] = nType;
                    _col2_5[i - 1] = nType;
                    _rotate1_5[i - 1] = nRotate1;
                    _rotate2_5[i - 1] = nRotate2;
                }
                else
                {
                    nType = 5;
                    nRotate1 = 1;
                    nRotate2 = 1;
                    _col1_5[i - 1] = nType;
                    _col2_5[i - 1] = nType;
                    _rotate1_5[i - 1] = nRotate1;
                    _rotate2_5[i - 1] = nRotate2;
                }
            }

            nNumber = rnd1.Next(2, 7);
            for (int i = 1; i <= nNumber; i++)
            {
                nCol = rnd1.Next(1, 6);
                nRow = rnd1.Next(1, 6);
                nType = rnd1.Next(1, 5);
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    switch (nCol)
                    {
                        case 1:
                            _col1_1[nRow - 1] = nType;
                            break;
                        case 2:
                            _col1_2[nRow - 1] = nType;
                            break;
                        case 3:
                            _col1_3[nRow - 1] = nType;
                            break;
                        case 4:
                            _col1_4[nRow - 1] = nType;
                            break;
                        default:
                            _col1_5[nRow - 1] = nType;
                            break;
                    }
                }
                else
                {
                    switch (nCol)
                    {
                        case 1:
                            _col2_1[nRow - 1] = nType;
                            break;
                        case 2:
                            _col2_2[nRow - 1] = nType;
                            break;
                        case 3:
                            _col2_3[nRow - 1] = nType;
                            break;
                        case 4:
                            _col2_4[nRow - 1] = nType;
                            break;
                        default:
                            _col2_5[nRow - 1] = nType;
                            break;
                    }

                }
            }

            fUpdateDisplay();

        }
    }
}