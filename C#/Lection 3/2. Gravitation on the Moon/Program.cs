using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("Input weight of the earth:");
        double num = double.Parse(Console.ReadLine());
        
        Console.WriteLine("The weight of the man is {0}",0.17*num);
    }
}
