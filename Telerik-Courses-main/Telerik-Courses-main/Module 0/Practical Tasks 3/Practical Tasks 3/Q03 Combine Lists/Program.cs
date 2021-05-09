using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        // Combine two lists of the same length
        // Example: Input: 1,2,3 4,5,6 Output: 1,4,2,5,3,6

        var first = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).ToList();
        var second = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).ToList();

        var output = new List<string>();
        for (int i = 0; i < first.Count(); i++)
        {
            output.Add(first[i]);
            output.Add(second[i]);
        }

        Console.WriteLine(string.Join(",", output));
    }
}