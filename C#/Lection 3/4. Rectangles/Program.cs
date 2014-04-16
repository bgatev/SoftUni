using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("Input rectangle width:");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Input rectangle height:");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("The rectangle perimeter is {0} and its area is {1}", 2*(width + height), width*height);
    }
}
