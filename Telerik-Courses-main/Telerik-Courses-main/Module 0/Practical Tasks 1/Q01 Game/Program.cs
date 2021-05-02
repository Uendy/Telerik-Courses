using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        // Get a 3 digit number and find a combination of sum and multiplication for the digits and print the biggest number
        // Example: Input: 185 Output: 45
        var input = Console.ReadLine().ToCharArray().Select(x => int.Parse(x.ToString())).ToArray();

        var sumMax = input[0] + input[1] + input[2];
        var multiplyMax = input[0] * input[1] * input[2];

        var strictMax = Math.Max(sumMax, multiplyMax);

        var firstMixedMax = input[0] + input[1] * input[2];
        var secondMixedMax = input[0] * input[1] + input[2];
        var mixedMax = Math.Max(firstMixedMax, secondMixedMax);

        Console.WriteLine(Math.Max(strictMax, mixedMax));
    }
}