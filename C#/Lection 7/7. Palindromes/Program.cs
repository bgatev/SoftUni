using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string inputLine = Console.ReadLine();

        string[] lines = inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int rows = int.Parse(lines[0]);
        int cols = int.Parse(lines[1]);

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("{0}{1}{2} ",Convert.ToChar('a' + row), Convert.ToChar('a' + col), Convert.ToChar('a' + row));
            }
            Console.WriteLine();
        }

        
    }
}
