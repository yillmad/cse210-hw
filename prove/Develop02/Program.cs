using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Files filePath = new Files();
        filePath._filePath = "filesList.txt";

        int optionChosen;
        List<string>propmtsToAdd = new List<string>{
            "What made you happy today?",
            "How did you handle a recent challenge?",
            "Describe a moment of joy.",
            "What's a goal you're working towards?",
            "Write about someone who inspires you today.",
            "Share a lesson from a mistake you made recently.",
            "What are you grateful for right now?",
            "What hobby brings you fulfillment today?",
            "Reflect on a recent decision you made.",
            "Connect with a book or movie you love.",
            "Share your self-care routine.",
            "Write about a personal value you hold.",
            "Recall a recent act of kindness.",
            "Reflect on a recent life change.",
            "Write about a recent achievement.",
            "Share thoughts on a current event.",
        };
        PromptGenerator._prompts.AddRange(propmtsToAdd);

        do{
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices");
            static void DisplayMenu(){
                List<string> menuOptions = new List<string>{
                    "1. Write",
                    "2. Display",
                    "3. Load",
                    "4. Save",
                    "5. Quit",
                };
                
                foreach (string option in menuOptions){
                    Console.WriteLine(option);
                }
            }
            DisplayMenu();
            Console.Write("What would you like to do? ");
            optionChosen = int.Parse(Console.ReadLine());

            if(optionChosen == 1){
                Entry newEntryName = new Entry();
                Journal.AddEntry(newEntryName);
            }
            else if(optionChosen==2){
                Journal.DisplayAll();
            }
            else if(optionChosen==3){
                Console.WriteLine("Here is a list of exiting files");
                Files.DisplayFiles(filePath._filePath);
                Console.WriteLine("What is the File Name?");
                string nameFile = Console.ReadLine();
                Journal.LoadFromFile(nameFile);
            }
            else if(optionChosen==4){
                Console.WriteLine("What is the File Name?");
                string nameFile = Console.ReadLine();
                Journal.SaveToFile(nameFile);
                Files.SaveFileName(filePath._filePath,nameFile);
            }
            else if(optionChosen > 5){
                Console.WriteLine("Invalid Choise");
            }

        }while(optionChosen != 5);
    }
}