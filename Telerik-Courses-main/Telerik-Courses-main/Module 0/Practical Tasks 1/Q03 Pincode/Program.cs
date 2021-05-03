using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        // Recieve two numbers, reverse them and print the bigger
        // Example: Input: 234 145 Output: 541

        var numbers = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        var firstNumber = int.Parse(new string(numbers[0].Reverse().ToArray()));
        var secondNumber = int.Parse(new string(numbers[1].Reverse().ToArray()));

        Console.WriteLine(Math.Max(firstNumber, secondNumber));
    }
}