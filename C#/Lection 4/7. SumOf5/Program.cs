using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("Input 5 numbers:");
        string inputLine = Console.ReadLine();

        int sum = 0;
        string[] numbers = inputLine.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < 5; i++) sum += int.Parse(numbers[i]);

        Console.WriteLine("The sum is {0}", sum);
    }
}
