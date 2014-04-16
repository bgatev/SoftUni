using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("Input 5 numbers, separated by space:");
        string input = Console.ReadLine();

        string[] numberString = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int[] numbers = new int[5];
        for (int i = 0; i < 5; i++) numbers[i] = int.Parse(numberString[i]);
        
        int subSets = 0;
        int subsetsNumber = (int)Math.Pow(2, 5) - 1;
        
        for (int i = 1; i <= subsetsNumber; i++)
        {
            int currentSum = 0;
            for (int j = 0; j < 5; j++)
            {
                if (((i >> j) & 1) == 1) currentSum += numbers[j];
            }
            if (currentSum == 0) subSets++;
        }

        if (subSets > 0) Console.WriteLine(subSets);
        else Console.WriteLine("no zero subset");
    }
}
