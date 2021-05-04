using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        var possibleCards = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        var input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        foreach (var card in input)
        {
            if (possibleCards.Contains(card)) 
            {
                Console.WriteLine($"yes {card}");
            }
            else 
            {
                Console.WriteLine($"no {card}");
            }
        }
    }
}