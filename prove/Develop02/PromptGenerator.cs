public class PromptGenerator
{
    public static List<string> _prompts = new List<string>();

    public static string GetRandomPrompt(){
        Random randomNumber = new Random();
        int number = randomNumber.Next(1,16);
        return _prompts[number];
    }
}