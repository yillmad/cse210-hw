/// Represents the level of a user in the achievement system.
public class Level
{
    private int _current;
    /// Gets or sets the current level.
    /// When setting the level, it notifies the user if they have reached a new level.
    public int Current
    {
        get { return _current; }
        set
        {
            _current = value;
            Console.WriteLine($"Congratulations! You have reached Level {_current}!");
        }
    }

    public Level()
    {
        Current = 1; // Start at level 1
    }
    public void UpdateLevel(int points)
    {
        int newLevel = (points / 1000) + 1; // Calculate new level based on points
        if (newLevel > Current)
        {
            Current = newLevel; // Update current level if new level is higher
        }
    }
}
