using System;

class Program
{
    static void Main(string[] args)
    {
        Comment comment = new Comment("Gustavo", "Great Video!");

        Console.WriteLine(comment.GetComment());
    }
}