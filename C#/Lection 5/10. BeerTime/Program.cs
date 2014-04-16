using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("Input time (hh:mm tt)");
        string inputValue = Console.ReadLine();
        DateTime beerTime;

        if (!DateTime.TryParse(inputValue, out beerTime))
        {
            Console.WriteLine("invalid time");
        }
        else
        {
            if (beerTime.Hour >= 3 && beerTime.Hour <= 13) Console.WriteLine("non-beer time");
            else Console.WriteLine("beer time");
        }
    }
}
