using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        double a, b, c, D, x1, x2;

        Console.Write("Input a:");
        a = double.Parse(Console.ReadLine());
        Console.Write("Input b:");
        b = double.Parse(Console.ReadLine());
        Console.Write("Input c:");
        c = double.Parse(Console.ReadLine());

        D = b * b - 4 * a * c;
        if (D > 0)
        {
            x1 = (-b + Math.Sqrt(D)) / (2 * a);
            x2 = (-b - Math.Sqrt(D)) / (2 * a);
        }
        else if (D == 0)
        {
            x1 = -b / (2 * a);
            x2 = x1;
        }
        else
        {
            Console.WriteLine("Уравнението няма решение");
            return;
        }

        Console.WriteLine("The result of {0}*x^2 + {1}*x + {2} = 0 is:", a, b, c);
        Console.WriteLine("x1={0}", x1);
        Console.WriteLine("x2={0}", x2);
    }
}
