// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string videoTitle)
    {
        Debug.Assert(!string.IsNullOrEmpty(videoTitle) && videoTitle.Length <= 100, "Invalid video title");

        Random random = new Random();
        this.id = random.Next(10000, 99999); // 5-digit random number
        this.title = videoTitle;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        Debug.Assert(count > 0, "Count harus lebih besar dari 0");
        Debug.Assert(playCount + count <= 10000000, "Maximum play mnelebihi batas");

        try
        {
            checked
            {
                playCount += count;
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }


    public void PrintVideoDetails()
    {
        Console.WriteLine("Video ID: " + id);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Play count: " + playCount);
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
