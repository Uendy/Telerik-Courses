﻿using System;
using System.Linq;
public class Program
{
    static void Main(string[] args)
    {
        // Find the longest consecutive symbols that arent letters, numbers or spaces
        // Example: Input: Tempera#### na @#$ata 23 grad#%&. Output: 4

        var input = Console.ReadLine().ToCharArray();

        var maxNonDesiredSymbols = 0;
        var currentNonDesiredSymbols = 0;

        for (int i = 0; i < input.Count() - 1; i++)
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