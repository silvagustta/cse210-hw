using System;

class Program
{
    static void Main(string[] args)
    {
        // get name
        Console.WriteLine("What is your first name? ");
        string name = Console.ReadLine();
        Console.WriteLine("What is your last name? ");
        string last_name = Console.ReadLine();
        
        // test
        // Console.WriteLine(name + last_name);
        
        // display name
        Console.WriteLine($"Your name is {last_name}, {name} {last_name}.");
    }
}