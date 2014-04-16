using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int n, zerosNum = 0, mult5 = 1;

        Console.Write("Input Number N:");
        n = int.Parse(Console.ReadLine());  //n < 14895

        for (int i = 1; i <= n; i++)
        {
            mult5 *= 5;
            zerosNum += n / mult5;
        }
        //zerosNum = n / 5 + n / 25 + n / 125 + n / 625 + n / 3125;
        Console.WriteLine("Ending zeros in {0}! is {1}", n, zerosNum);
    }
}
