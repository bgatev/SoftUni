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

        string[] lines = new string[n];
        for (int i = 0; i < n; i++) lines[i] = Console.ReadLine();

        Array.Sort(lines);
        int count = 1, maxCount = 1, index = 0;

        for (int i = 0; i < n - 1; i++)
        {
            if (lines[i] == lines[i + 1]) count++;
            else
            {
                if (count > maxCount)
                {
                    maxCount = count;
                    index = i - 1;
                }
                count = 1;
            }
        }
        if (count > maxCount)
        {
            maxCount = count;
            index = n - 1;
        }

        Console.WriteLine(maxCount);
        for (int i = 0; i < maxCount; i++) Console.WriteLine(lines[index]);
        
    }
}
