using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C#", "Juan Pérez", 300);
        video1.AddComment(new Comment("Laura", "Great video, thanks!"));
        video1.AddComment(new Comment("Carlos", "Could you explain more about classes?"));
        video1.AddComment(new Comment("Ana", "Excellent explanation!"));
        videos.Add(video1);

        Video video2 = new Video("Teardrops On My Guitar", "Taylor Swift", 217);
        video2.AddComment(new Comment("Emma", "She owns this now!!"));
        video2.AddComment(new Comment("Tess", "I love this song"));
        video2.AddComment(new Comment("Mia", "Love you Tay"));
        videos.Add(video2);

        Video video3 = new Video("What is abstraction?", "Pedro Gómez", 250);
        video3.AddComment(new Comment("Tomi", "Now I understand the concept better."));
        video3.AddComment(new Comment("Lucía", "Good pace of explanation"));
        video3.AddComment(new Comment("Mateo", "Thanks for sharing this"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}