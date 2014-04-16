using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("Input start number:");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Input end number:");
        int end = int.Parse(Console.ReadLine());

        int p = 0;
        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0) p++;   
        }

        Console.WriteLine("There is {0} numbers divisible by 5 without remainder",p);
    }
}
