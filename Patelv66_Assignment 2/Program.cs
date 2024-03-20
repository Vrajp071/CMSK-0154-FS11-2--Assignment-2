using System;

class Program
{
    static void Main()
    {
        int evenSum = 0;
        int oddSum = 0;

        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"{i} is even number");
                evenSum += i;
            }
            else
            {
                Console.WriteLine($"{i} is odd number");
                oddSum += i;
            }
        }

        Console.WriteLine($"The sum of even numbers is {evenSum}");
        Console.WriteLine($"The sum of odd numbers is {oddSum}");
    }
}