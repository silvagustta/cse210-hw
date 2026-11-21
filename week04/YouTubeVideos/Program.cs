using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learning C#", "Gustavo", 600);
        Video video2 = new Video("HTML for Beginners", "john" , 450);
        Video video3 = new Video("JavaScript Basics", "Mary", 720);

        video1.AddComment(new Comment("Pedro", "Great video!"));
        video1.AddComment(new Comment("Ana", "Very helpful!"));
        video1.AddComment(new Comment("Lucas", "Thanks for sharing!"));

        video2.AddComment(new Comment("Maria", "Amazing explanation!"));
        video2.AddComment(new Comment("Carlos", "I learned a lot!"));
        video2.AddComment(new Comment("John", "Keep it up!"));

        video3.AddComment(new Comment("David", "Excellent content!"));
        video3.AddComment(new Comment("Sarah", "Really useful!"));
        video3.AddComment(new Comment("Mike", "Thank you!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideo();
        }
    }
}