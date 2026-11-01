using System;

class Program
{
    static void Main(string[] args)
    {
        // gets the number
        // Console.Write("What is the magic number: ");
        // int number = int.Parse(Console.ReadLine());

        // gets a random number
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);
        // not showing the number, if you want to see the number (kinda if not right) you need to delete the quote.
        // Console.WriteLine(number);

        int guess = -1;

        // guessing area
        while (guess != number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guess)
            {
                Console.WriteLine("lower");   
            }
            else
            {
                Console.WriteLine("You got it!");
            }
        }
    }
}