using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string inputList = Console.ReadLine();
        string[] inputString = inputList.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string inputList2 = Console.ReadLine();
        string[] inputString2 = inputList2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        List<int> inputListInt = new List<int>();

        for (int i = 0; i < inputString.Length; i++) if (!inputListInt.Contains(int.Parse(inputString[i]))) inputListInt.Add(int.Parse(inputString[i]));
        for (int i = 0; i < inputString2.Length; i++) if (!inputListInt.Contains(int.Parse(inputString2[i]))) inputListInt.Add(int.Parse(inputString2[i]));

        inputListInt.Sort();
        for (int i = 0; i < inputListInt.Count; i++) Console.Write("{0} ", inputListInt[i]);

    }
}
