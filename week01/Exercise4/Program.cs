using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // starting the list and set variables
        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber!= 0)
        {
            Console.Write("Enter a number (0 to quit): ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            // set 0 to quit, and other numbers to add.
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"the sum is: {sum}");

        // average
        float average = ((float)sum / numbers.Count);
        Console.WriteLine($"The average is: {average}");

        // max number
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}