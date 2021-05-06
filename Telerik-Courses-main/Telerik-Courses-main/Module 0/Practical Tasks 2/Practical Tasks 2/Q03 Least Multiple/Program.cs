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

        for (int i = numbers[2]; i < numbers[4] * 10; i++)
        {
            var devided = new bool[5];
            if (i % numbers[0] == 0)
            {
                devided[0] = true;
            }
            if (i % numbers[1] == 0) 
            {
                devided[1] = true;
            }
            if (i % numbers[2] == 0)
            {
                devided[2] = true;
            }
            if (i % numbers[3] == 0)
            {
                devided[3] = true;
            }
            if (i % numbers[4] == 0)
            {
                devided[4] = true;
            }

            if (devided.Where(x => x == true).Count() >= 3)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}