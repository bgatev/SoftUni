using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int a = 5, b = 10;
        Console.WriteLine("a={0}, b={1}",a,b);
        int c = a;
        a = b;
        b = c;
        Console.WriteLine("a={0}, b={1}", a, b);
    }
}

