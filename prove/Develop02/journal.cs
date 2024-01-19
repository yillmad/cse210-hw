public class Journal
{
    public static List<Entry> _entries = new List<Entry>();

    public static void AddEntry(Entry newEntry){
        // store the date into a string
        DateTime currentTime = DateTime.Now;
        string dateString = currentTime.ToShortDateString();
        newEntry._date = dateString;
        // Get and Print a prompt
        newEntry._promptText = PromptGenerator.GetRandomPrompt();
        Console.WriteLine(newEntry._promptText);
        // ask for the new entry
        newEntry._entryText = Console.ReadLine();
        // add information to the entry list
        _entries.Add(newEntry);
    }

    public static void DisplayAll(){
        foreach (var entry in _entries) {
            entry.Display();
        }
    }

    public static void SaveToFile(string file){
        using(StreamWriter outputFile = new StreamWriter(file)){
            foreach(var entry in _entries){
                outputFile.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText} {entry._entryText}");
            }
        }
    }

    public static void LoadFromFile(string file){
        string[] lines = File.ReadAllLines(file);
        foreach(string line in lines){
            Console.WriteLine(line);
        }
    }
}    