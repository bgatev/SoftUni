using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("Input first date dd.MM.yyyy:");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Input second date dd.MM.yyyy:");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());

        long days = (secondDate.Ticks - firstDate.Ticks) / 10000000 / 86400;
        Console.WriteLine("Difference is {0} days",days);
    }
}
