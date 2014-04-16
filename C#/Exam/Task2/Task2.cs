using System;
using System.Linq;
using System.Text;

class Task2
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] inputString = input.Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);

        int[] numbers = new int[inputString.Length];

        for (int i = 0; i < numbers.Length; i++) numbers[i] = int.Parse(inputString[i]);

        int[] value = new int[numbers.Length / 2];
        bool allTheSameValue = false;
        for (int i = 0, j = 0; i < numbers.Length - 1; i += 2, j++) value[j] = numbers[i] + numbers[i + 1];

        for (int i = 0; i < value.Length - 1; i++)
        {
            if (value[i] == value[i + 1]) allTheSameValue = true;
            else
            {
                allTheSameValue = false;
                break;
            }
        }

        int maxDiff = 0;
        for (int i = 0; i < value.Length - 1; i++)
        {
            int currentDiff = Math.Abs(value[i] - value[i + 1]);
            if (currentDiff > maxDiff) maxDiff = currentDiff;
        }

        if ((numbers.Length == 2) && (numbers[0] == numbers[1])) Console.WriteLine("Yes, value={0}",numbers[0] + numbers[1]);
        else
        {
            if (allTheSameValue) Console.WriteLine("Yes, value={0}", value[0]);
            else Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
    }
}

