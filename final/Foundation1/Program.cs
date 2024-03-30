using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {

        // create 3-4 videos
        Video video1 = new Video("CATS!", "CatLover", 120);
        Video video2 = new Video("Best Burger Ever!", "HomeCook", 849);
        Video video3 = new Video("Insane Dive from 500,000 feet", "Adr3nalin3Junkie", 560);

        // comments
        Comment comment1 = new Comment("CatLady2000", "I love this!");
        Comment comment2 = new Comment("CatHater", "This is stupid.");
        Comment comment3 = new Comment("Jessica2347", "This is very interesting.");
        Comment comment4 = new Comment("Dave01", "I tried this last night!");
        Comment comment5 = new Comment("BurgerTime234", "I love this recipe!");
        Comment comment6 = new Comment("YoutubeWatcher3589", "BURGER");
        Comment comment7 = new Comment("FIRSTCOMMENTER200!", "FIRST!");
        Comment comment8 = new Comment("Diver2498", "This is sick!!!");
        Comment comment9 = new Comment("SharkyBoy1010", "How bad were the bruises? lol");

        // add comments
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);

        // video list
        List<Video> videos = new List<Video>{video1, video2, video3};

        // print videos
        foreach (Video video in videos)
        {
            Console.WriteLine();
            video.PrintVideo();
        }
        Console.WriteLine();

    }
}