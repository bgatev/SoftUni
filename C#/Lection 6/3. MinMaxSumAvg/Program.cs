using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        double min = int.MaxValue, max = int.MinValue, sum = 0;

        Console.Write("Input number n:");
        int n = int.Parse(Console.ReadLine());

        double[] numbers = new double[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());
            if (min > numbers[i]) min = numbers[i];
            if (max < numbers[i]) max = numbers[i];
            sum += numbers[i];
        }

        double average = sum / n;

        Console.WriteLine("min = {0}",min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:0.00}", average);

    }
}
