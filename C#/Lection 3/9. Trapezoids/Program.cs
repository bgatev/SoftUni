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
        
        Console.Write("Input h:");
        double h = double.Parse(Console.ReadLine());

        Console.WriteLine("The area is {0} ", (a+b)*h/2);
    }
}
