using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine()
            .ToCharArray()
            .Select(x => 
            int.Parse(x.ToString()))
            .OrderByDescending(x => x)
            .ToArray();

        int biggestSum = input[0] * input[1];

        Console.WriteLine(Math.Max(biggestSum * input[2], biggestSum + input[2]));
    }
}