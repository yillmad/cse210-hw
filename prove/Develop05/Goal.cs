using System.Net.NetworkInformation;
using System.Security.Cryptography;
/// Represents a goal that a user can achieve in the system.
public abstract class Goal
{
    // Properties to store basic information about the goal
    protected string GoalName { get; set; }
    protected string GoalDescription { get; set; }
    protected int Points { get; set; }
    protected string SaveString { get; set; }
    public Goal (string name, string description, int points)
    {
        GoalName = name;
        GoalDescription = description;
        Points = points;
    }
    // Update the string used for saving information.
    public abstract void UpdateSaveString();
    /// Displays the goal in a formatted way.
    public virtual void DisplayGoal(int i)
    {
        Console.WriteLine($"{i}. [ ] {GoalName} ({GoalDescription})");
    }
    public abstract int CompleteGoal();
    public string GetSaveString()
    {
        return SaveString;
    }
    // Input a string and use it to get the goal's information.
    public abstract Goal DecodeSaveString(string saveString);
    // An animation, which exceeds requirements by adding another visual aspect to the goals.
    protected void Celebration()
    {
        int counter = 0;
        while (counter < 10)
        {
            Console.Write("'0'");
            Thread.Sleep(200);
            int count = 0;
            while (count < 3)
            {
                Console.Write("\b");
                count++;
            }
            Console.Write("   ");
            Console.Write("\b");
            Console.Write("\b");
            Console.Write("\b");
            Console.Write(",0,");
            Thread.Sleep(200);
            count = 0;
            while (count < 3)
            {
                Console.Write("\b");
                count++;
            }
            Console.Write("   ");
            Console.Write("\b");
            Console.Write("\b");
            Console.Write("\b");
            counter++;
        }
    }
}