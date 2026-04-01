using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Classes Explained", "Code Academy", 600);
        video1.AddComment(new Comment("Alice", "Very helpful tutorial!"));
        video1.AddComment(new Comment("Bob", "I understand classes now."));
        video1.AddComment(new Comment("Charlie", "Great explanation!"));

        Video video2 = new Video("OOP in 10 Minutes", "Dev Simplified", 480);
        video2.AddComment(new Comment("Dave", "Straight to the point."));
        video2.AddComment(new Comment("Eve", "This cleared my confusion."));
        video2.AddComment(new Comment("Frank", "Excellent content!"));

        Video video3 = new Video("Abstraction in Programming", "Tech World", 720);
        video3.AddComment(new Comment("Grace", "Abstraction finally makes sense."));
        video3.AddComment(new Comment("Hank", "Nice examples!"));
        video3.AddComment(new Comment("Ivy", "Well presented topic."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}