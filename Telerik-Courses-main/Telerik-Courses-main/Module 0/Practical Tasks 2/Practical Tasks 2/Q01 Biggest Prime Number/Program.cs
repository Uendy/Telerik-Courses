using System;
public class Program
{
    public static void Main()
    {
        // Find the biggest Prime Number between 1 and N and print it
        // Example: Input: 13 Output 13

        var input = int.Parse(Console.ReadLine());

        for (int start = input; start >= 2; start--)
        {
            bool isPrime = true;
            for (int i = 2; i < Math.Sqrt(start); i++)
            {
                if(start % i == 0) 
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime == true) 
            {
                Console.WriteLine(start);
                break;
            }
        }
    }
}