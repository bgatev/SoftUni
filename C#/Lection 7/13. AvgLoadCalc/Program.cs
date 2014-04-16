using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string inputString = string.Empty;
        Dictionary<string, Tuple<double, int>> data = new Dictionary<string, Tuple<double, int>>();

        do
        {
            inputString = Console.ReadLine();
            if (string.IsNullOrEmpty(inputString)) break;

            int index = inputString.IndexOf("http");
            inputString = inputString.Substring(index);
            string[] input = inputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (data.ContainsKey(input[0]))
            {
                Tuple<double, int> currentTupleValue = data[input[0]];
                double currentValue = currentTupleValue.Item1;
                int currentNumber = currentTupleValue.Item2;

                currentValue += double.Parse(input[1]);
                currentNumber++;
                
                data[input[0]] = new Tuple<double, int>(currentValue, currentNumber);
            }
            else data.Add(input[0], new Tuple<double, int>(double.Parse(input[1]), 1));

        }
        while (true);

        foreach (KeyValuePair<string, Tuple<double,int>> singleRecord in data)
        {
            string currentURL = singleRecord.Key;
            Tuple<double, int> currentRecord = singleRecord.Value;
            double avgLoad = currentRecord.Item1 / currentRecord.Item2;

            Console.WriteLine("{0} -> {1}",currentURL,avgLoad);
        }

    }
}
