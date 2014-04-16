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
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("The number {0} is divided by 5 and 7: {1}", num, ((num % 35) == 0)?true:false);
    }
}
