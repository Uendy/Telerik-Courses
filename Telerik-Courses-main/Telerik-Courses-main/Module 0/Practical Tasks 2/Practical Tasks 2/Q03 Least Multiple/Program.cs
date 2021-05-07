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

        for (int i = numbers[0]; i < int.MaxValue; i+= numbers[0])
        {
            if (numbers.Where(x => i % x == 0).Count() >= 3)
            {
                Console.WriteLine(i);
                return;
            }
        }
    }
}