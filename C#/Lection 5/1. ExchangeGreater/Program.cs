using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("Input a:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Input b:");
        double b = double.Parse(Console.ReadLine());
        double c = 0;

        if (a > b)
        {
            c = a;
            a = b;
            b = c;
        }

        Console.WriteLine("{0} {1}",a,b);
    }
}
