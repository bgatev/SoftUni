using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int number, v, p;
        string binaryStringInput, binaryStringResult;

        Console.Write("Input Number:");
        number = int.Parse(Console.ReadLine());
        Console.Write("Input Bit Value:");
        v = int.Parse(Console.ReadLine());
        Console.Write("Input Bit Position:");
        p = int.Parse(Console.ReadLine());

        binaryStringInput = Convert.ToString(number, 2);

        if (v == 1) number |= (1 << p);
        else number &= ~(1 << p);
        
        binaryStringResult = Convert.ToString(number, 2);

        Console.WriteLine("Your number in binary is:   {0}", binaryStringInput);
        Console.WriteLine("Result number in binary is: {0}", binaryStringResult);
    }
}
