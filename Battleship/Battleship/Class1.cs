using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class cLookup
    {
        private int mode;
        public int Mode
        {
            get
            {
                return mode;
            }
            set
            {
                mode = value;
            }
        }

        private int letter;
        public int Letter
        {
            get
            {
                return letter;
            }
            set
            {
                letter = value;
            }
        }

        private int column;
        public int Column
        {
            get
            {
                return column;
            }
            set
            {
                column = value;
            }
        }

        private int row;
        public int Row
        {
            get
            {
                return row;
            }
            set
            {
                row = value;
            }
        }

        
        private int[] array1 = new int[10];
        private int[] array2 = new int[10];
        private int[] array3 = new int[10];
        private int[] array4 = new int[10];
        private int[] array5 = new int[10];
        private int[] array6 = new int[10];
        private int[] array7 = new int[10];
        private int[] array8 = new int[10];
        private int[] array9 = new int[10];
        private int[] arraya = new int[10];
        public int Item
        {
            get
            {
                switch (column)
                {
                    case 1:
                        return array1[column];
                    case 2:
                        return array2[column];
                     case 3:
                        return array3[column];
                     case 4:
                        return array4[column];
                     case 5:
                        return array5[column];
                    case 6:
                        return array6[column];
                     case 7:
                        return array7[column];
                    case 8:
                        return array8[column];
                     case 9:
                        return array9[column];
                     default:
                        return arraya[column];
                   }
            }
            set
            {
                switch (column)
                {
                    case 1:
                        array1[column]=value;
                        break;
                    case 2:
                        array2[column] = value;
                        break;
                    case 3:
                        array3[column] = value;
                        break;
                    case 4:
                        array4[column] = value;
                        break;
                    case 5:
                        array5[column] = value;
                        break;
                    case 6:
                        array6[column] = value;
                        break;
                    case 7:
                        array7[column] = value;
                        break;
                    case 8:
                        array8[column] = value;
                        break;
                    case 9:
                        array9[column] = value;
                        break;
                    default:
                        arraya[column] = value;
                        break;
                }
                Item = value;
            }
        }
    }
}
