
// _________________________________________________________________________
// defenitivo 
using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);

        Scripture scripture = new Scripture(
            reference,
            "For God so loved the world that he gave his only begotten Son"
        );

        string input = "";

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish.");

            input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();
        }

        Console.Clear();

        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nProgram finished.");
    }
}

// ______________________________________________________________
// Testing
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Reference first = new Reference("John", 3, 16);

//         // Reference second = new Reference("Proverbs", 3, 5, 6);

//         // Console.WriteLine(first.GetDisplayText());
//         // Console.WriteLine(second.GetDisplayText());

//         // Word word = new Word("Heaven");

//         // // word.Hide();

//         // Console.WriteLine(word.GetDisplayText());

//         // word.Hide();

//         // Console.WriteLine(word.GetDisplayText());

//         // word.Unhide();

//         // Console.WriteLine(word.GetDisplayText());

//         // Reference reference = new Reference("John", 3, 16);

//         // Scripture scripture = new Scripture(reference,
//         // "For God so loved the world that he gave his only begotten Son");

//         // // Reference reference = new Reference("Proverbs", 3, 5, 6);

//         // // Scripture scripture = new Scripture(
//         // //     reference,
//         // //     "Trust in the Lord with all thine heart"
//         // // );

//         // Console.WriteLine(scripture.GetDisplayText());

//         // // scripture.HideRandomWords();

//         // // Console.WriteLine(scripture.GetDisplayText());
//     }
// }