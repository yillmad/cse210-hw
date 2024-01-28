using System;

class Program
{
    // static void Main(string[] args)
    // {
    //     Reference reference = new Reference("John", 3, 16);
    //     Scripture scripture = new Scripture(reference, "For God so loved the world something else, I don't know what I have to write");

    //     while (true)
    //     {
    //         Console.Clear();
    //         Console.WriteLine(scripture.GetDisplayText());

    //         Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit:");
    //         string userInput = Console.ReadLine();

    //         if (userInput.ToLower() == "quit")
    //         {
    //             break;
    //         }

    //         scripture.HideRandomWords(2);

    //         if (scripture.IsCompletelyHidden())
    //         {
    //             Console.Clear();
    //             Console.WriteLine(scripture.GetDisplayText());
    //             Console.WriteLine("All words are hidden. Press Enter to exit.");
    //             Console.ReadLine();
    //             break;
    //         }
    //     }

    // }
    static void Main(string[] args)
    {
        // It reads the scripture from the file created
        Scripture scripture = ScriptureReader.ReadScriptureFromFile("scripture.txt");

        if (scripture == null)
        {
            // Handle error if reading the file fails
            Console.WriteLine("Failed to read scripture from file. Exiting.");
            return;
        }

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit:");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(2);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("All words are hidden. Press Enter to exit.");
                Console.ReadLine();
                break;
            }
        }
    }
}