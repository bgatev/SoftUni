using System;
using System.Linq;
using System.Text;

class Task5
{
    static int BinToDec(string inString)
    {
        int result = 0;

        for (int i = inString.Length - 1, j = 0; i > -1; i--, j++) result += ((inString[i] - '0') * (int)Math.Pow(2, j));

        return result;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int[] inputBytes = new int[n];

        string input = string.Empty;
        for (int i = 0; i < n; i++)
        {
            inputBytes[i] = int.Parse(Console.ReadLine());
            input += Convert.ToString(inputBytes[i], 2).PadLeft(8,'0');
        }

        string output = string.Empty;
        output += input[0];
        for (int i = 0; i < input.Length - 1; i++)
        {
            if (i == 0) continue;
            if ((i % step) == 0) continue;
            output += input[i + 1];   
        }

        int bytesNumber = output.Length / 8;
        if (output.Length % 8 > 0) output = output.PadRight((bytesNumber + 1) * 8, '0');

        do
        {
            int number = BinToDec(output.Substring(0, 8));
            Console.WriteLine(number);
            output = output.Remove(0, 8);
        }
        while (output.Length > 0);
    }
}

