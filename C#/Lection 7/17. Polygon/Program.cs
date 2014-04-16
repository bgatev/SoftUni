using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PolygonTask
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Point> points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] inputString = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                points.Add(new Point(double.Parse(inputString[0]), double.Parse(inputString[1])));
            }

            Polygon myPolygon = new Polygon(points);

            Console.WriteLine("perimeter = {0:0.00}", myPolygon.Perimeter);
            Console.WriteLine("area = {0:0.00}", myPolygon.Area);
        }
    }
}