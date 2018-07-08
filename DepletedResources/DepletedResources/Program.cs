using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepletedResources
{
    class Program
    {
        private static List<int> _count = new List<int> { 0, 0, 0, 0, 0, 0};
        
        static void Main(string[] args)
        {
            Random rnd1 = new Random();
            String sReply = null;
            int nNumber;
            int nGiven;
            bool bEnded = false;
            bool bFound = false;

            for (int i = 1; i <= 6; i++)
            {
                _count[i - 1] = rnd1.Next(1, 2000);
            }

            do
            {
                nGiven = rnd1.Next(1, 200);
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 2)
                {
                    nGiven = 400;
                }
                Console.WriteLine("Inside DepletedResources");
                Console.WriteLine("[1] A = {0}", Convert.ToString(_count[0]));
                Console.WriteLine("[2] B = {0}", Convert.ToString(_count[1]));
                Console.WriteLine("[3] C = {0}", Convert.ToString(_count[2]));
                Console.WriteLine("[4] D = {0}", Convert.ToString(_count[3]));
                Console.WriteLine("[5] E = {0}", Convert.ToString(_count[4]));
                Console.WriteLine("[6] F = {0}", Convert.ToString(_count[5]));
                Console.WriteLine("GIVEN = {0}", Convert.ToString(nGiven));
                Console.WriteLine("[7] comply");
                sReply = Console.ReadLine();
                nNumber = Convert.ToInt32(sReply);
                switch (nNumber)
                {
                    case 1:
                        _count[0] = _count[0] - nGiven;
                        if (_count[0] < 1)
                        {
                            bEnded = true;
                        }
                        break;
                    case 2:
                        _count[1] = _count[1] - nGiven;
                        if (_count[1] < 1)
                        {
                            bEnded = true;
                        }
                        break;
                    case 3:
                        _count[2] = _count[2] - nGiven;
                        if (_count[2] < 1)
                        {
                            bEnded = true;
                        }
                        break;
                    case 4:
                        _count[3] = _count[3] - nGiven;
                        if (_count[3] < 1)
                        {
                            bEnded = true;
                        }
                        break;
                    case 5:
                        _count[4] = _count[4] - nGiven;
                        if (_count[4] < 1)
                        {
                            bEnded = true;
                        }
                        break;
                    case 6:
                        _count[5] = _count[5] - nGiven;
                        if (_count[5] < 1)
                        {
                            bEnded = true;
                        }
                        break;
                    default:
                        bFound = false;
                        for (int i = 1; i <= 6; i++)
                        {
                            if (_count[i - 1] > 200)
                            {
                                bFound = true;                            
                            }
                        }
                        if (bFound == false)
                        {
                            Console.WriteLine("YOU WIN!");
                            bEnded = true;
                        }
                        break;
                }
            } while (bEnded == false);
            Console.ReadLine();
        }
    }
}
