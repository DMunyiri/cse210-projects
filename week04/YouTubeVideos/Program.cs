using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("How to Bake a Cake", "Chef John", 300);
        Video video2 = new Video("Product Review: New Smartphone", "Tech Guru", 600);
        Video video3 = new Video("Travel Vlog: Paris", "Explorer Jane", 900);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "This cake looks amazing!"));
        video1.AddComment(new Comment("Bob", "I can't wait to try it."));
        video1.AddComment(new Comment("Charlie", "Your videos are always so helpful."));

        // Add comments to video2
        video2.AddComment(new Comment("David", "Great review, as always!"));
        video2.AddComment(new Comment("Eve", "Is the battery life really that good?"));
        video2.AddComment(new Comment("Frank", "I bought the phone based on your recommendation."));

        // Add comments to video3
        video3.AddComment(new Comment("Grace", "Paris looks stunning in your vlog!"));
        video3.AddComment(new Comment("Heidi", "I want to visit someday."));
        video3.AddComment(new Comment("Ian", "Your editing skills are top-notch."));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display each video and its comments
        foreach (var video in videos)
        {
            video.Display();
        }
    }
}