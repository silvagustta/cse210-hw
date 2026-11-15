using System;

class Program
{
    static void Main(string[] args)
    {
        Reference first = new Reference("John", 3, 16);

        Reference second = new Reference("Proverbs", 3, 5, 6);

        Console.WriteLine(first.GetDisplayText());
        Console.WriteLine(second.GetDisplayText());

        Word word = new Word("Heaven");

        // word.Hide();

        Console.WriteLine(word.GetDisplayText());

        word.Hide();

        Console.WriteLine(word.GetDisplayText());

        word.Unhide();

        Console.WriteLine(word.GetDisplayText());
    }
}