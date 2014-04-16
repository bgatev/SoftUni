using System;
using System.Linq;
using System.Text;

class Task1
{
    static double CalcD(int x1, int y1, int x2, int y2)
    {
        double result = 0;

        result = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1));

        return result;
    }
    static void Main()
    {
        int ax = int.Parse(Console.ReadLine());
        int ay = int.Parse(Console.ReadLine());
        int bx = int.Parse(Console.ReadLine());
        int by = int.Parse(Console.ReadLine());
        int cx = int.Parse(Console.ReadLine());
        int cy = int.Parse(Console.ReadLine());

        double AB = CalcD(ax, ay, bx, by);
        double BC = CalcD(bx, by, cx, cy);
        double CA = CalcD(cx, cy, ax, ay);
        double p = (AB + BC + CA) / 2;
        double area = Math.Sqrt(p*(p-AB)*(p-BC)*(p-CA));

        if ((AB + BC > CA) && (BC + CA > AB) && (AB + CA > BC))
        {
            Console.WriteLine("Yes");
            Console.WriteLine("{0:0.00}",area);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:0.00}",AB);
        }

    }
}

