using System;
// As an additional challenge, I attempted to maintain a log of the frequency of activity occurrences, ensuring avoidance of repetitive prompts.

class Program
{
    static void Main(string[] args)
    {
        int breatheCount = 0;
        int reflectCount = 0;
        int listCount = 0;

        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine();
        bool running = true;
        while (running)
        {
            Console.WriteLine("Please select one of the following activities: ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            Console.Write("What would you like to do? ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {   
                //BreathingActivity
                case 1:
                    Console.Clear();
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.RunBreathingActivity();
                    breatheCount++;
                    break;
                //ReflectingActivity
                case 2:
                    Console.Clear();
                    ReflectingActivity reflection = new ReflectingActivity();
                    reflection.RunReflectingActivity();
                    reflectCount++;
                    break;
                //ListingActivity
                case 3:
                    Console.Clear();
                    ListingActivity listing = new ListingActivity();
                    listing.RunListingActivity();
                    listCount++;
                    break;
                //quit the program
                case 4:
                    running = false;
                    Console.WriteLine("Congratulations! You have completed these activities: ");
                    Console.WriteLine($"Breathing Activity: {breatheCount} times");
                    Console.WriteLine($"Reflecting Activity: {reflectCount} times");
                    Console.WriteLine($"Listing Activity: {listCount} times");
                    Console.WriteLine();
                    Console.WriteLine("Thank you. See you soon!");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please choose one of the following activities.");
                    break;
            }
     
        }
    }
}