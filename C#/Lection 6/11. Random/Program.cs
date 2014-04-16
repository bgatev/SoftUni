using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Random randomNumber = new Random();
        Console.Write("Input n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Input min: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Input max: ");
        int max = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++) Console.Write("{0} ", randomNumber.Next(min, max));
    }
}
