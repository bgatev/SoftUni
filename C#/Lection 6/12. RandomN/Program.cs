using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Random randomNumber = new Random();
        
        Console.Write("Input n: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        for (int i = 0; i < n; i++) numbers[i] = i + 1;

        while (n > 1)
        {
            int k = randomNumber.Next(n--);
            int temp = numbers[n];
            numbers[n] = numbers[k];
            numbers[k] = temp;
        }

        for (int i = 0; i < numbers.Length; i++) Console.Write("{0} ", numbers[i]);
        
    }
}
