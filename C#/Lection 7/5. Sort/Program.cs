using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("Input n:");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        for (int i = 0; i < n; i++) numbers[i] = int.Parse(Console.ReadLine());

        Array.Sort(numbers);
        for (int i = 0; i < n; i++) Console.WriteLine(numbers[i]);
    }
}
