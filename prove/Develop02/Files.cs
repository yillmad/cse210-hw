public class Files
{
    // I consider the user might forget the exact name of previous files
    // So I added this class that save and display the name of he mentioned
    // files.
    public string _filePath;
    public static void SaveFileName(string path, string fileName){
        using(StreamWriter writer = new StreamWriter(path, true)){
            writer.WriteLine(fileName);
        }
    }

    public static void DisplayFiles(string fileName){
        string[] lines = File.ReadAllLines(fileName);
        foreach(string line in lines){
            Console.WriteLine(line);
        }
    }
}