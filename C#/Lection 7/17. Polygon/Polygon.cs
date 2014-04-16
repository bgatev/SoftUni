using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonTask
{
    public class Polygon
    {
        private List<Point> polygonPoints;
        public Polygon(List<Point> polygonPoint)
        {
            this.polygonPoints = polygonPoint;
        }

        public double Perimeter
        {
            get
            {
                return this.CalculatePerimeter();
            }
        }

        public double Area
        {
            get
            {
                return this.CalculateArea();
            }
        }

        private double CalculatePerimeter()
        {
            double perimeter = 0;

            var sorted = polygonPoints.OrderBy(point => point.X).ThenBy(point => point.Y);

            //I don't know the formula for perimeter calculation

            return perimeter;
        }

        private double CalculateArea()
        {
            double area = 0;

            for (int i = 0; i < polygonPoints.Count - 1; i++) area += polygonPoints[i].X * polygonPoints[i + 1].Y - polygonPoints[i].Y * polygonPoints[i + 1].X;

            area += polygonPoints[polygonPoints.Count - 1].X * polygonPoints[0].Y - polygonPoints[polygonPoints.Count  -1].Y * polygonPoints[0].X;

            return Math.Abs(area / 2);
        }
    }
}
