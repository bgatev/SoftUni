using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("Input number < 100:");
        int x = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = 2; i < x; i++)
        {
            if (x % i == 0) counter++;
            if (counter == 1) break;
        }

        if ((x < 0) || (counter == 1)) Console.WriteLine("The number {0} is not prime",x);
        else Console.WriteLine("The number {0} is prime",x);
    }
}
