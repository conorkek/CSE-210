using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video video1 = new("How to Tie Your Shoelaces", "Curious George", 60);
        _videos.Add(video1);
        video1.AddComment("Conor Kekauoha", "This video is good!");
        video1.AddComment("Bob Tub", "I can tie my shoeslaces now!");
        video1.AddComment("Logan Lucky", "This video helped me a lot!");

        Video video2 = new("How to Scream", "Baby.com", 70);
        _videos.Add(video2);
        video2.AddComment("Obi Wan Kenobi", "I can scream really good now!!");
        video2.AddComment("John Doe", "I still can't scream.");
        video2.AddComment("Jack Frost", "You should make a video on how to whisper next");
        video2.AddComment("Bethany Honk", "I AM THE LOUDEST IN MY HOUSE NOW!!!!!!");

        Video video3 = new("How to Cast a Jinx on a Friend", "Fred & George Weasley", 80);
        _videos.Add(video3);
        video3.AddComment("Harry Potter", "I just cast a jinx on Ron and it was hilarious!!");
        video3.AddComment("Hermione Granger", "You should take this video down, too many wizards are jinxing now.");
        video3.AddComment("Albus Percival Wulfric Brian Dumbledore", "How do I change my username? I don't want my full name out there.");

        foreach(Video video in _videos)
        {
            Console.WriteLine();
            Console.WriteLine("******************************");
            Console.WriteLine();
            video.Display();
            video.DisplayComments();
            Console.WriteLine();
        }

        // int repeat = 0;
        // while (repeat != 4)
        // {
        //     Console.WriteLine("Create a video: \n");
        //     Console.Write("Enter the video title: ");
        //     string title = Console.ReadLine();
        //     Console.Write("Enter the video author: ");
        //     string author = Console.ReadLine();
        //     Console.Write("Enter the video length in seconds: ");
        //     int seconds = int.Parse(Console.ReadLine());
        //     Video video = new(title, author, seconds);


        //     string done;
        //     do
        //     {
        //         Console.WriteLine("Add any comments to the video you created: ");
        //         video.AddComment();
        //         Console.Write("Are you done adding comments? (If so, type 'yes'): ");
        //         done = Console.ReadLine();
        //     } while (done != "yes");

        //     _videos.Add(video);

        //     repeat += 1;
        // }

        // foreach(Video video in _videos)
        // {
        //     Console.WriteLine("******************************");
        //     video.Display();
        //     video.DisplayComments();
        // }
    }
}