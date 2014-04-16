using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int number, p;
        bool is1result;
        string binaryString;

        Console.Write("Input Number:");
        number = int.Parse(Console.ReadLine());
        Console.Write("Input Bit:");
        p = int.Parse(Console.ReadLine());
        binaryString = Convert.ToString(number, 2);
        is1result = (number & (1 << p)) != 0;

        if (is1result) Console.WriteLine("Bit {0} is 1: true", p);
        else Console.WriteLine("Bit {0} is 0: false", p);
        Console.WriteLine(binaryString);
    }
}
