using System;
using System.Linq;
public class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().ToCharArray();

        var maxNonDesiredSymbols = 0;
        var currentNonDesiredSymbols = 0;

        for (int i = 0; i < input.Count(); i++)
        {
            var currentChar = input[i];

            if (char.IsLetterOrDigit(currentChar) || currentChar == ' ')
            {
                if (currentNonDesiredSymbols > maxNonDesiredSymbols)
                {
                    maxNonDesiredSymbols = currentNonDesiredSymbols;
                }
                currentNonDesiredSymbols = 0;
            }
            else 
            {
                currentNonDesiredSymbols++;   
            }
        }

        Console.WriteLine(Math.Max(maxNonDesiredSymbols, currentNonDesiredSymbols));
    }
}