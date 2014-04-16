using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("Input number:");
        int num = int.Parse(Console.ReadLine());
        if (num % 2 == 0) Console.WriteLine("The number is even");
        else Console.WriteLine("The number is odd");
    }
}
