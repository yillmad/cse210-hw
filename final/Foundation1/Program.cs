class Program
{
    static void Main(string[] args)
    {
        // Creating videos
        var videos = new List<Video>
        {
            new Video("Video 1", "Author 1", 120),
            new Video("Video 2", "Author 2", 180),
            new Video("Video 3", "Author 3", 150)
        };

        // Adding comments to each video
        foreach (var video in videos)
        {
            video.AddComment("User 1", "This is a comment.");
            video.AddComment("User 2", "Another comment here.");
            video.AddComment("User 3", "Yet another comment.");
        }

        // Displaying information about each video
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}