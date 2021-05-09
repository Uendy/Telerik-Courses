using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        // Find the most frequent element in array 
        // Example: Input 1 2 3 4 3 5 5 3 Output: 3 (3 times) 

        var numbers = new List<int>();
        var inputs = int.Parse(Console.ReadLine());

        for (int i = 0; i < inputs; i++)
        {
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        var grouped = numbers.GroupBy(x => x)
            .Select(group => new
            {
                num = group.Key,
                count = group.Count()
            })
            .OrderByDescending(X => X.count)
            .First();

        Console.WriteLine($"{grouped.num} ({grouped.count}times)");
    }
}