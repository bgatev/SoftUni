using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        ushort n;

        Console.Write("Input number n:");
        n = ushort.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j <= n + i; j++) Console.Write("{0} ", j);
            Console.WriteLine();
        }
    }
}
