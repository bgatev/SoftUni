using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        double fNum, sNum, tNum, tempNum;

        Console.Write("Input first number:");
        fNum = double.Parse(Console.ReadLine());
        Console.Write("Input second number:");
        sNum = double.Parse(Console.ReadLine());
        Console.Write("Input third number:");
        tNum = double.Parse(Console.ReadLine());

        if (fNum > sNum)
        {
            if (sNum > tNum)
            {
                Console.WriteLine("Sorted completed {0} {1} {2}", fNum, sNum, tNum);
            }
            else
            {
                tempNum = sNum;
                sNum = tNum;
                tNum = tempNum;
                Console.WriteLine("Sorted completed {0} {1} {2}", fNum, sNum, tNum);
            }
        }
        else //fNum < sNum
        {
            tempNum = fNum;
            fNum = sNum;
            sNum = tempNum;
            if (tNum < sNum)
            {
                Console.WriteLine("Sorted completed {0} {1} {2}", fNum, sNum, tNum);
            }
            else if (tNum < fNum)
            {
                tempNum = sNum;
                sNum = tNum;
                tNum = tempNum;
                Console.WriteLine("Sorted completed {0} {1} {2}", fNum, sNum, tNum);
            }
            else
            {
                tempNum = tNum;
                tNum = sNum;
                sNum = fNum;
                fNum = tempNum;
                Console.WriteLine("Sorted completed {0} {1} {2}", fNum, sNum, tNum);
            }
        }
    }
}
