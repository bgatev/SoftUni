using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static int CharCounter(string inString, char symbol)
    {
        int counter = 0;

        for (int i = 0; i < inString.Length; i++) if (inString[i] == symbol) counter++;

        return counter;
    }

    static void Main()
    {
        List<char> charList = new List<char>();

        string inputString = Console.ReadLine();
        string[] input = inputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < input.Length; i++) charList.Add(Convert.ToChar(input[i]));

        charList.Sort();
        IEnumerable<char> distinctChars = charList.Distinct();
        
        foreach (char symbol in distinctChars)
        {
            Console.WriteLine("{0} - {1} times", symbol, CharCounter(inputString, symbol));
        }
    }
}
