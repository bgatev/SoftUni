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
        long number = long.Parse(Console.ReadLine());

        string binaryString = Convert.ToString(number, 2);
        bool is1result = (number & (1 << 3)) != 0;

        Console.WriteLine(binaryString);
        Console.WriteLine("Bit 3 is 1: {0}",is1result);
    }
}
