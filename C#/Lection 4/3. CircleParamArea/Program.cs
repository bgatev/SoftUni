using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("Input r:");
        double r = double.Parse(Console.ReadLine());
        double area = Math.PI * r * r;
        double perimeter = 2 * Math.PI * r;

        Console.WriteLine("The area is {0:N2} and the perimeter is {1:N2}",area,perimeter);
    }
}
