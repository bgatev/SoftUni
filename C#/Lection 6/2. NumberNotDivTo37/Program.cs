using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        uint n;

        Console.Write("Input number n:");
        n = uint.Parse(Console.ReadLine());

        for (uint i = 1; i <= n; i++)
        {
            if (!((i % 3 == 0) || (i % 7 == 0))) Console.Write("{0} ",i);
        }

    }
}
