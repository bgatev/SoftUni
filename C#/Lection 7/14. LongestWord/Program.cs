using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string inputString = Console.ReadLine();
        string[] input = inputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var sorted = input.OrderByDescending(words => words.Length).Select(words => words).First();
        
        Console.WriteLine(sorted);
    }
}
