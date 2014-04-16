using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {

        int fNum, sNum, tNum;

        Console.Write("Input first number:");
        fNum = int.Parse(Console.ReadLine());
        Console.Write("Input second number:");
        sNum = int.Parse(Console.ReadLine());
        Console.Write("Input third number:");
        tNum = int.Parse(Console.ReadLine());

        if (fNum > 0)
        {
            if (sNum > 0)
            {
                if (tNum > 0) Console.WriteLine("The sign of multiplication of {0} * {1} * {2} is +", fNum, sNum, tNum);
                else Console.WriteLine("The sign of multiplication of {0} * {1} * {2} is -", fNum, sNum, tNum);
            }
            else if (tNum > 0) Console.WriteLine("The sign of multiplication of {0} * {1} * {2} is -", fNum, sNum, tNum);
            else Console.WriteLine("The sign of multiplication of {0} * {1} * {2} is +", fNum, sNum, tNum);
        }
        else
        {
            if (sNum > 0)
            {
                if (tNum > 0) Console.WriteLine("The sign of multiplication of {0} * {1} * {2} is -", fNum, sNum, tNum);
                else Console.WriteLine("The sign of multiplication of {0} * {1} * {2} is +", fNum, sNum, tNum);
            }
            else if (tNum > 0) Console.WriteLine("The sign of multiplication of {0} * {1} * {2} is +", fNum, sNum, tNum);
            else Console.WriteLine("The sign of multiplication of {0} * {1} * {2} is -", fNum, sNum, tNum);
        }

    }
}
