class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        var address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        var address2 = new Address("456 Elm St", "Othertown", "NY", "Canada");

        // Create events
        var lecture = new Lecture("Lecture on AI", "Introduction to Artificial Intelligence", DateTime.Now.Date, new TimeSpan(10, 0, 0), address1, "Dr. Smith", 50);
        var reception = new Reception("Networking Reception", "Join us for a networking event", DateTime.Now.Date.AddDays(2), new TimeSpan(18, 0, 0), address2, "rsvp@example.com");
        var outdoorGathering = new OutdoorGathering("Picnic in the Park", "Enjoy a day outdoors with friends and family", DateTime.Now.Date.AddDays(5), new TimeSpan(12, 0, 0), address1, "Sunny skies");

        // Generate and display messages
        Console.WriteLine("Lecture:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine("\nReception:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine("\nOutdoor Gathering:");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}