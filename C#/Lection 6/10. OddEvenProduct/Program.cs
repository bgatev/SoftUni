using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("Input numbers: ");
        string input = Console.ReadLine();
        string[] numbersString = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[numbersString.Length];
        long oddProduct = 1, evenProduct = 1;

        for (int i = 0; i < numbersString.Length; i++)
        {
            numbers[i] = int.Parse(numbersString[i]);
            if (i % 2 == 0) oddProduct *= numbers[i];
            else evenProduct *= numbers[i];
        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd product = {0}", oddProduct);
            Console.WriteLine("even product = {0}", evenProduct);
        }
    }
}
