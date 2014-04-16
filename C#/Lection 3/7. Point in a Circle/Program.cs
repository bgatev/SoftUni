using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("Input x:");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Input y:");
        double y = double.Parse(Console.ReadLine());
        bool result = false;

        if (x * x + y * y <= 4) result = true;
        Console.WriteLine("The point ({0},{1}) is inside circle K({0},{1}),2): {2}", x, y, result);
    }
}
