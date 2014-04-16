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
        long num = long.Parse(Console.ReadLine());

        int digit = (int)(num / 100) % 10;

        if (num < 100) Console.WriteLine("The third digit is 7: {0}", false);
        else Console.WriteLine("The third digit is 7: {0}", (digit == 7)?true:false);
    }
}
