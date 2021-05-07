using System;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        // decode a message by removing any consequently repeating characters
        // Example: Input: hoboobbo422222Aaao Output: hobobo42Aao

        var text = Console.ReadLine().ToCharArray();
        var output = new List<char>() { text[0] };

        for (int i = 1; i < text.Length; i++)
        {
            if (text[i] != text[i - 1])
            {
                output.Add(text[i]);
            }
        }

        Console.WriteLine(string.Join("", output));
    }
}