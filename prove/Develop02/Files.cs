public class Files
{
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