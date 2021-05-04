using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        // Recieve four values and determine their order: ascending, descending, mixed
        // Example: Input: 3, 4, 4, 5 Output: mixed

        var array = Console.ReadLine()
            .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

        bool asc = true;
        bool des = true;

        for (int i = 0; i < array.Count() - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                asc = false;
            }
            else if (array[i] < array[i + 1])
            {
                des = false;
            }
            else 
            {
                asc = false;
                des = false;
            }
        }

        if (asc == true)
        {
            Console.WriteLine("Ascending");
        }
        else if (des == true)
        {
            Console.WriteLine("Descending");
        }
        else
        {
            Console.WriteLine("Mixed");
        }
    }
}