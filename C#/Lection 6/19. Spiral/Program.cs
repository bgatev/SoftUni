using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int n, row = 0, currentRow, col = 0, currentCol = 0, num = 1, fPos = 0;

        Console.Write("Input number n:");
        n = ushort.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        do
        {
            // right then down
            for (currentRow = fPos; currentRow < (n - fPos); currentRow++)
            {
                for (currentCol = col; currentCol < (n - fPos); currentCol++)
                {
                    matrix[currentRow, currentCol] = num;
                    num++;
                }
                col = currentCol - 1;
            }

            row = currentRow - 1;
            col--;

            // left then up
            for (currentRow = row; currentRow > fPos; currentRow--)
            {
                for (currentCol = col; currentCol >= fPos; currentCol--)
                {
                    matrix[currentRow, currentCol] = num;
                    num++;
                }
                col = currentCol + 1;
            }
            col++;
            fPos++;
        }
        while (fPos < n);

        // print all
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}
