using System;
using System.Numerics;
public class Program
{
    public static void Main()
    {
        // Create a matrix where each element is a power of 2 and return the sum of the above diagonal
        // Example: Input: 4 Output: 70

        var rows = int.Parse(Console.ReadLine());
        var matrix = GetMatrix(rows);
        BigInteger sum = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col > row)
                {
                    sum += matrix[row, col];
                }
            }
        }
        Console.WriteLine(sum);

    }
    static BigInteger[,] GetMatrix(int size)
    {
        var matrix = new BigInteger[size, size];

        BigInteger currentRow = 1;
        BigInteger counter = 1;
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                matrix[row, col] = counter;
                counter *= 2;

                if (col == size - 1)
                {
                    currentRow *= 2;
                    counter = currentRow;
                }
            }
        }
        return matrix;
    }
}