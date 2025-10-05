using System;
using System.Collections.Generic; 

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store all videos
        List<Video> videos = new List<Video>();

        // Create sample videos
        Video video1 = new Video("Exploring Zimbabwe", "Dylans Travel", 300);
        video1.AddComment(new Comment("Alice", "This is so beautiful!"));
        video1.AddComment(new Comment("Bob", "I love seeing Zimbabwe"));
        video1.AddComment(new Comment("Charlie", "When's the next tour"));

        Video video2 = new Video("How to Drink Water", "John Doe", 420);
        video2.AddComment(new Comment("Dana", "Easy to follow instructions."));
        video2.AddComment(new Comment("Eli", "Mine turned out great!"));
        video2.AddComment(new Comment("Faith", "Can you do a tutorial on how to breathe next?"));

        Video video3 = new Video("Top 10 Coding Tips", "Zimdev", 600);
        video3.AddComment(new Comment("George", "Tip #5 is a game-changer."));
        video3.AddComment(new Comment("Hannah", "How can I become a junior programmer in Zim"));
        video3.AddComment(new Comment("Ian", "Can you cover debugging next?"));

        Video video4 = new Video("Wildlife Documentary", "NatureWorld", 900);
        video4.AddComment(new Comment("Jane", "Beautiful cinematography."));
        video4.AddComment(new Comment("Kyle", "Love the narration."));
        video4.AddComment(new Comment("Laura", "More content like this please!"));gi

        // Add  videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // Display all videos and their comments
        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }
        }
    }
}