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
            Console.Write("{0} ",i);
        }


    }
}
