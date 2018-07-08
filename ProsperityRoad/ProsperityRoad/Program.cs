using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProsperityRoad
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd1 = new Random();
            String sReply = null;
            int nNumber;
            bool bEnded = false;
            String sPath=null;
            int nLength = rnd1.Next(3, 11);
            int nSofar = 0;
            char sChar;
            String sWord = null;
            int nQuestionLength;
            String sQuestionPath = null;
            String sFormat=null;
            String sFormat2 = null;
            String sFormat3 = null;
            int nRoad;
            int nPos;

            for (int i = 1; i <= nLength; i++)
            {
                sChar = (char)(rnd1.Next(1, 27) + 64);
                sWord = sWord + sChar;
            }
            sPath = sWord;

            do
            {
                nSofar += 1;
                nQuestionLength = rnd1.Next(3, 9);
                sWord = null;
                for (int i = 1; i <= nQuestionLength; i++)
                {
                    sChar = (char)(rnd1.Next(1, 27) + 64);
                    sWord = sWord + sChar;
                }
                sQuestionPath = sWord;

                Console.WriteLine("Inside ProsperityRoad"+Convert.ToString(nSofar));
                sFormat2 = sPath.Substring(nSofar - 1, 1);
                Console.WriteLine("TAKE "+sFormat2);
                nPos = rnd1.Next(1, nQuestionLength + 1);
                sQuestionPath=sQuestionPath.Substring(1-1, nPos-1) + sFormat2+ sQuestionPath.Substring(nPos+1-1, nQuestionLength-nPos);
                for (int i = 1; i <= nQuestionLength; i++)
                {
                    nRoad = rnd1.Next(1, 4);
                    sFormat = "["+Convert.ToString(i)+"] "+sQuestionPath.Substring(i-1,1);
                    switch (nRoad)
                    {
                        case 1:
                            sFormat = sFormat + " Road";
                            break;
                        case 2:
                            sFormat = sFormat + " Street";
                            break;
                        default:
                            sFormat = sFormat + " Avenue";
                            break;
                    }
                    if (nSofar == nLength)
                    {
                        if (i == nPos)
                        {
                            sFormat = "[" + Convert.ToString(i) + "] TAKE BOAT";
                        }
                    }
                    Console.WriteLine(sFormat);
                }
                sReply = Console.ReadLine();
                nNumber = Convert.ToInt32(sReply);
                sFormat3 =  sQuestionPath.Substring(nNumber - 1, 1);
                if (sFormat3 != sFormat2)
                {
                    bEnded = true;
                }
                else
                {
                    if (nSofar == nLength)
                    {
                        bEnded = true;
                        Console.WriteLine("YOU WIN!");
                    }
                }
            } while (bEnded == false);
            Console.ReadLine();
        }
    }
}
