using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        var numbers = new List<int>();
        for (int i = 0; i < 5; i++)
        {
            numbers.Add(int.Parse(Console.ReadLine()));
        }
        numbers = numbers.OrderBy(x => x).ToList();

        var max = numbers[2] * numbers[3] * numbers[4];

        for (int i = numbers[1] + numbers[0]; i <= max; i+= numbers[0])
        {
            if (numbers.Any(x => x == i))
            {
                Console.WriteLine(i);
                break;
            }
        }

        for (int i = numbers[2] + numbers[1]; i <= max; i+= numbers[1])
        {
            if (numbers.Any(x => x == i))
            {
                Console.WriteLine(i);
                break;
            }
        }

        for (int i = numbers[3] + numbers[2]; i <= max; i+= numbers[2])
        {
            if (numbers.Any(x => x == i))
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}