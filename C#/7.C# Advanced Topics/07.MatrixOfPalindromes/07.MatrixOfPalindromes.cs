using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MatrixOfPolidromes
{
    static void Main()
    {
        int matrixRows = int.Parse(Console.ReadLine());
        int matrixCols = int.Parse(Console.ReadLine());

        string[,] polidromesMatrix = new string[matrixRows, matrixCols];

        for (int row = 0; row < matrixRows; row++)
        {
            for (int col = 0; col < matrixCols; col++)
            {
                polidromesMatrix[row, col] = "" + (char)('a' + row) + (char)('a' + row + col) + (char)('a' + row);


            }
        }

        for (int row = 0; row < matrixRows; row++)
        {
            for (int col = 0; col < matrixCols; col++)
            {
                Console.Write(polidromesMatrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}

