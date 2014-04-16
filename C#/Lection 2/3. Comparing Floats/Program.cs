using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        float eps = 0.000001f;
        
        Console.Write("Input first float number:");
        float first = float.Parse(Console.ReadLine());
        
        Console.Write("Input first float number:");
        float second = float.Parse(Console.ReadLine());

        Console.WriteLine("{0} is bigger than {1}: {2}", first, second, (Math.Abs(first-second) > eps)?true:false);
    }
}

