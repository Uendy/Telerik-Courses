using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        // given an array of numbers find all numbers from 1 to array.Count that arent elements in the array
        // Example: Input: 1, 2, 3, 3, 5 Output: 4

        var array = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
        var output = new List<int>();
        for (int i = 1; i <= array.Length; i++)
        {
            if (!array.Contains(i))
            {
                output.Add(i);
            }
        }

        Console.WriteLine(string.Join(",", output));
    }
}