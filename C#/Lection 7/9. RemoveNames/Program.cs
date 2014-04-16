using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string names = Console.ReadLine();
        string[] namesString = names.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string namesRestricted = Console.ReadLine();
        string[] namesRestrictedString = namesRestricted.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        List<string> namesList = new List<string>();
        List<string> namesRestrictedList = new List<string>();

        for (int i = 0; i < namesRestrictedString.Length; i++) namesRestrictedList.Add(namesRestrictedString[i]);
        for (int i = 0; i < namesString.Length; i++)
        {
            if (!namesRestrictedList.Contains(namesString[i])) namesList.Add(namesString[i]);
        }
        for (int i = 0; i < namesList.Count; i++) Console.Write("{0} ",namesList[i]);

    }
}
