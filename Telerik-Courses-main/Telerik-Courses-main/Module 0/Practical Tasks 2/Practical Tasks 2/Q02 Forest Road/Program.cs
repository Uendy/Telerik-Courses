using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        // Write a map, where each step you move one down and diagonally, height = 2*N-1

        var width = int.Parse(Console.ReadLine());
        var output = new StringBuilder();

        // forward
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (i == j)
                {
                    output.Append("*");
                }
                else
                {
                    output.Append(".");
                }
            }
            output.AppendLine();
        }

        // backward
        for (int i = width - 2; i >= 0; i--)
        {
            for (int j = 0; j < width; j++)
            {
                if (i == j)
                {
                    output.Append("*");
                }
                else
                {
                    output.Append(".");
                }
            }
            output.AppendLine();
        }

        Console.WriteLine(output.ToString());
    }
}