using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world something else, I don't know what I have to write");

        while (scripture.IsCompletelyHidden()==false)
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
        }
    }
}