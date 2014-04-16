using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string[] cardsAll = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        string[] suitAll = { "\u2663", "\u2666", "\u2665", "\u2660" };

        /*foreach (string card in cardsAll)
        {
            foreach (string suit in suitAll) Console.Write("{0}{1} ", card, suit);
            Console.WriteLine();
        }*/

        for (int i = 0; i < 13; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write("{0}{1} ", cardsAll[i],suitAll[j]);       
            }
            Console.WriteLine();
        }
    }
}
