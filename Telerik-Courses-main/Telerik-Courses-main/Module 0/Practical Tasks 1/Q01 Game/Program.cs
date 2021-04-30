using System;
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

        var strictSum = input[0] + input[1] + input[2];
        var strictMultiple = input[0] * input[1] * input[2];

        var strictMax = Math.Max(strictSum, strictMultiple);

        var firstMixed = input[0] * input[1] + input[2];
        var secondMixed = input[0] + input[1] * input[2];
        var mixedMax = Math.Max(firstMixed, secondMixed);

        Console.WriteLine(Math.Max(strictMax, mixedMax));

    }
}