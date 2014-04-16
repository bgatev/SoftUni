using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int fNum, sNum, tNum, tempNum;

        Console.Write("Input first number:");
        fNum = int.Parse(Console.ReadLine());
        Console.Write("Input second number:");
        sNum = int.Parse(Console.ReadLine());
        Console.Write("Input third number:");
        tNum = int.Parse(Console.ReadLine());

        if (fNum > sNum)
        {
            if (tNum < sNum)
            {
                Console.WriteLine("The biggest number is {0}", fNum);
            }
            else if (tNum < fNum)
            {
                Console.WriteLine("The biggest number is {0}", fNum);
            }
            else
            {
                Console.WriteLine("The biggest number is {0}", tNum);
            }

        }
        else
        {
            if (tNum < fNum)
            {
                Console.WriteLine("The biggest number is {0}", sNum);
            }
            else if (tNum < sNum)
            {
                Console.WriteLine("The biggest number is {0}", sNum);
            }
            else
            {
                Console.WriteLine("The biggest number is {0}", tNum);
            }
        }
    }
}
