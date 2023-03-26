// See https://aka.ms/new-console-template for more information
using System;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string videoTitle)
    {
        Random random = new Random();
        this.id = random.Next(10000, 99999); // 5-digit random number
        this.title = videoTitle;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int countToAdd)
    {
        this.playCount += countToAdd;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"Video ID: " + id );
        Console.WriteLine($"Title: " +title );
        Console.WriteLine($"Play Count: " + playCount );
    }
}

class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo myVideo = new SayaTubeVideo("Tutorial Design By Contract – [MRafaEkaP]");
        myVideo.IncreasePlayCount(1000); 
        myVideo.PrintVideoDetails();
    }
}
