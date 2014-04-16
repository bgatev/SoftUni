using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> result = new List<int>();

        for (int i = startNum; i <= endNum; i++)
        {
            int counter = 0;

            for (int j = 2; j < i; j++)
            {
                if (i % j == 0) counter++;
                if (counter == 1) break;   
            }
            if (counter == 0) result.Add(i);    
        }

        return result;
    }

    static void PrintPrimeNumbers(List<int> NumbersToPrint)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < NumbersToPrint.Count; i++)
        {
            sb.Append(string.Format("{0}, ", NumbersToPrint[i]));  
        }
        if (sb.Length >= 2)
        {
            sb.Remove(sb.Length - 2, 2);
            Console.WriteLine(sb.ToString());
        }
        else Console.WriteLine("(empty list)");
    }
    static void Main()
    {
        Console.Write("Input start number:");
        int startNumber = int.Parse(Console.ReadLine());

        if (startNumber < 2) startNumber = 2;

        Console.Write("Input end number:");
        int endNumber = int.Parse(Console.ReadLine());

        if (endNumber >= startNumber) PrintPrimeNumbers(FindPrimesInRange(startNumber,endNumber));
        else Console.WriteLine("(empty list)");
    }
}
