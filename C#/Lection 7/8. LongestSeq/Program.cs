using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int maxIncreasingSeq = 0, tempSequence = 1, index = 0;

        string input = Console.ReadLine();
        string[] inputString = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numArray = new int[inputString.Length];

        for (int i = 0; i < inputString.Length; i++) numArray[i] = int.Parse(inputString[i]);

        for (int i = 0; i < numArray.Length - 1; i++)
        {
            if (numArray[i] < numArray[i + 1]) tempSequence++;
            else
            {
                if (tempSequence > maxIncreasingSeq)
                {
                    maxIncreasingSeq = tempSequence;
                    index = i - (maxIncreasingSeq - 1);
                }
                tempSequence = 1;
            }
        }

        Console.Write("Max increasing sequence is {0} numbers: ", maxIncreasingSeq);
        for (int i = index; i < index + maxIncreasingSeq; i++) Console.Write("{0} ", numArray[i]);

    }
}
