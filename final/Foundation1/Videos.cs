public class Video
{
    public string _title { get; set; }
    public string _author { get; set; }
    public int _lengthInSeconds { get; set; }
    private List<Comment> _comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>();
    }

    // Method to add a comment to the video
    public void AddComment(string commenterName, string text)
    {
        _comments.Add(new Comment(commenterName, text));
    }

    // Method to get the number of comments
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Method to display information about the video and its comments
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");

        Console.WriteLine("Comments:");
        foreach (var comment in _comments)
        {
            Console.WriteLine($"- {comment._commenterName}: {comment._text}");
        }
        Console.WriteLine();
    }
}