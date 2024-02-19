public class ChecklistGoal : Goal
{
    // Properties to track the completion status and bonus points
    private int Completed { get; set; }
    private int TotalNeeded { get; set; }
    private int BonusPoints { get; set; }

    // Constructor for creating a new checklist goal
    public ChecklistGoal(string name, string description, int points, int total, int bonus) : base(name, description, points)
    {
        Completed = 0;
        TotalNeeded = total;
        BonusPoints = bonus;
        UpdateSaveString();
    }
     // Method to complete the goal
    // Constructor for creating a checklist goal with completion status
    public ChecklistGoal(string name, string description, int points, int total, int bonus, int completed) : base(name, description, points)
    {
        Completed = completed;
        TotalNeeded = total;
        BonusPoints = bonus;
        UpdateSaveString();
    }
    // Increase the count of completed goals, give the bonus if applicable. If it's complete, give no points.
    public override int CompleteGoal()
    {
        if (Completed < TotalNeeded)
        {
            Completed++;
            int points = 0;
            points += Points;
            Console.WriteLine($"Congratulations! You have scored {Points} points!");
            Celebration();
            if (Completed == TotalNeeded)
            {
                points += BonusPoints;
            }
            UpdateSaveString();
            return points;
        }
        else
        {
            Console.WriteLine("You have already completed this goal.");
            return 0;
        }
    }
    // Method to display the goal
    public override void DisplayGoal(int i)
    {
        if (Completed < TotalNeeded)
        {
            Console.WriteLine($"{i}. [ ] {GoalName} ({GoalDescription}) -- Currently Completed: {Completed}/{TotalNeeded}");
        }
        else
        {
            Console.WriteLine($"{i}. [X] {GoalName} ({GoalDescription}) -- Currently Completed: {Completed}/{TotalNeeded}");
        }
    }
    // Method to update the save string
    public override void UpdateSaveString()
    {
        SaveString = $"ChecklistGoal,{GoalName},{GoalDescription},{Points},{BonusPoints},{TotalNeeded},{Completed}";
    }
    // Method to decode the save string and create a new instance of ChecklistGoal
    public override ChecklistGoal DecodeSaveString(string saveString)
    {
        string[] pieces = saveString.Split(",");
        ChecklistGoal checklistGoal = new(pieces[1], pieces[2], int.Parse(pieces[3]), int.Parse(pieces[4]), int.Parse(pieces[5]), int.Parse(pieces[6]));
        return checklistGoal;
    }
}