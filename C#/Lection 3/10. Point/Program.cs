using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("Input x:");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Input y:");
        double y = double.Parse(Console.ReadLine());

        bool insindeCircle = false;
        bool outsideRectangle = false;
        
        if ((!(x < -0.5 || x > 2.5 || y < -0.5 || y > 2.5)) && ((x-1) * (x-1) + (y-1) * (y-1) <= (1.5 * 1.5))) insindeCircle = true;
        if (x < -1 || x > 5 || y < -1 || y > 1) outsideRectangle = true;
        
        if (insindeCircle && outsideRectangle) Console.WriteLine("Yes");
        else Console.WriteLine("No");
    }
}
