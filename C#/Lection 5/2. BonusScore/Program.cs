using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        ushort bonus;

        Console.Write("Input Bonus Base:");
        bonus = ushort.Parse(Console.ReadLine());

        switch (bonus)
        {
            case 1:
            case 2:
            case 3:
                bonus *= 10;
                break;
            case 4:
            case 5:
            case 6:
                bonus *= 100;
                break;
            case 7:
            case 8:
            case 9:
                bonus *= 1000;
                break;
            default: Console.WriteLine("You want too much!!! Please input correct bonus"); break;
        }
        Console.WriteLine("Your bonus is: {0}", bonus);
    }
}
