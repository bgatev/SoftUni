using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int a, b, GCD = 0;

        Console.Write("Input first number:");
        a = int.Parse(Console.ReadLine());
        Console.Write("Input second number:");
        b = int.Parse(Console.ReadLine());

        if (a % b == 0) Console.WriteLine("GCD is {0}", b);
        else
        {
            do
            {
                GCD = a % b;
                a = b;
                b = GCD;
                if (GCD == 0) break;
            }
            while (a % b != 0);
            Console.WriteLine("GCD is {0}", GCD);
        }
    }
}
