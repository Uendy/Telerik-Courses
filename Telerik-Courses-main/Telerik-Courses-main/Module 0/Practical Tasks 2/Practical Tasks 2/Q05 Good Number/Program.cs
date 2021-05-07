using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        // A good number is a number that neatly divides by each of its digits (except 0), find all the good numbers between 2 integers and print the count
        // Example: Input: 42 142   Output: 29

        var boundaries = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

        var count = 0;

        for (int i = boundaries[0]; i <= boundaries[1]; i++)
        {
            var currentDigits = i.ToString().ToCharArray().Select(x => int.Parse(x.ToString())).Where(x => x != 0).ToArray();
            var goodNum = true;
            foreach (var digit in currentDigits)
            {
                if (i % digit != 0)
                {
                    goodNum = false;
                    break;
                }
            }

            if (goodNum)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}