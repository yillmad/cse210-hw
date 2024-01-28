// Class that help in the process of reading the file, allowing the main program 
// to know what is the reference, and what is the scipture content. 
class ScriptureReader
{
    public static Scripture ReadScriptureFromFile(string filePath)
    {
        try
        {
            string[] lines = File.ReadAllLines(filePath);

            // Check if there are at least two lines (reference and text)
            if (lines.Length < 2)
            {
                Console.WriteLine("Invalid file format. Exiting.");
                return null;
            }

            // Parse the reference
            string[] referenceParts = lines[0].Split(' ');
            if (referenceParts.Length < 2)
            {
                Console.WriteLine("Invalid reference format. Exiting.");
                return null;
            }

            string book = referenceParts[0];
            string[] chapterVerse = referenceParts[1].Split(':');
            if (chapterVerse.Length < 2)
            {
                Console.WriteLine("Invalid reference format. Exiting.");
                return null;
            }

            int chapter = int.Parse(chapterVerse[0]);
            int verse = int.Parse(chapterVerse[1]);

            Reference reference = new Reference(book, chapter, verse);

            // Combine the remaining lines to get the scripture text
            string text = string.Join("\n", lines, 1, lines.Length - 1);

            return new Scripture(reference, text);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading the file: {ex.Message}");
            return null;
        }
    }
}
