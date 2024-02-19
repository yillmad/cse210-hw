using System.ComponentModel;
/// Represents a goal that grants a fixed amount of points upon completion, without any additional conditions or requirements.
public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        UpdateSaveString();
    }
    /// Updates the string used for saving information about the goal.
    public override void UpdateSaveString()
    {
        SaveString = $"EternalGoal,{GoalName},{GoalDescription},{Points}";
    }
    public override EternalGoal DecodeSaveString(string saveString)
    {
        string[] pieces = saveString.Split(",");
        EternalGoal eternalGoal = new(pieces[1], pieces[2], int.Parse(pieces[3]));
        return eternalGoal;
    }
    /// Marks the goal as completed and provides the fixed number of points associated with it.
    public override int CompleteGoal()
    {
        Console.WriteLine($"Congratulations! You have scored {Points} points!");
        Celebration();
        return Points;
    }
}