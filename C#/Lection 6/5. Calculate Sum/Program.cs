using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        double n, x, xn = 1, nFact = 1;
        double sumS = 1;

        Console.Write("Input N:");
        n = double.Parse(Console.ReadLine());
        Console.Write("Input X:");
        x = double.Parse(Console.ReadLine());

        Console.Write("1");
        for (int i = 1; i <= n; i++)
        {
            nFact *= i;
            xn *= x;
            sumS += nFact / xn;
            Console.Write(" + {0}/{1}", nFact, xn);
        }
        Console.WriteLine("= {0:F5}", sumS);
        //n=5,x=2   1 + 1/2 + 2/4 + 6/8+ 24/16 + 120/32 = 5
    }
}
