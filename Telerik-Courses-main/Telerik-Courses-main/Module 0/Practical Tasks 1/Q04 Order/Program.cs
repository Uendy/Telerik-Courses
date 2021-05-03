using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        // Recieve four values and determine their order: ascending, descending, mixed
        // Example: Input: 3, 4, 4, 5 Output: mixed

        var array = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        if (array == array.OrderByDescending(x => x).ToArray())
        {
            Console.WriteLine("Descending");
        }
        else if (array == array.OrderBy(x => x).ToArray())
        {
            Console.WriteLine("Ascending");
        }
        else
        {
            Console.WriteLine("Mixed");
        }
    }
}