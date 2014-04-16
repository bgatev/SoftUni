using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static int NamesCounter(string[] inString, string name)
    {
        int counter = 0;

        for (int i = 0; i < inString.Length; i++) if (inString[i] == name) counter++;

        return counter;
    }

    static void Main()
    {
        List<string> stringList = new List<string>();

        string inputString = Console.ReadLine();
        string[] input = inputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < input.Length; i++) stringList.Add(input[i]);

        stringList.Sort();
        IEnumerable<string> distinctString = stringList.Distinct();

        foreach (string name in distinctString)
        {
            Console.WriteLine("{0} - {1} times", name, NamesCounter(input, name));
        }
    }
}
