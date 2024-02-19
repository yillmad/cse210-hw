using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Initialize variables
        bool remain = true;
        int points = 0;
        int choice;
        Level userLevel = new Level(); // Initialize the user's level
        List<Goal> goals = new List<Goal>();

        // Print the menu
        while (remain)
        {
            Console.WriteLine($"You have {points} points");
            Console.WriteLine($"Current Level: {userLevel.Current}");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create new goal");
            Console.WriteLine("  2. List goals");
            Console.WriteLine("  3. Save goals");
            Console.WriteLine("  4. Load goals");
            Console.WriteLine("  5. Record event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            // Handle user choices
            if (choice == 1)
            {
                // Create a goal
                Console.WriteLine("The kinds of goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                int goalType = int.Parse(Console.ReadLine());
                Console.Write("What is the name of the goal? ");
                string goalName = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the number of points associated with it? ");
                int pointValue = int.Parse(Console.ReadLine());
                // Filter based on goal types
                if (goalType == 1)
                {
                    SimpleGoal simpleGoal = new SimpleGoal(goalName, description, pointValue);
                    goals.Add(simpleGoal);
                }
                else if (goalType == 2)
                {
                    EternalGoal eternalGoal = new EternalGoal(goalName, description, pointValue);
                    goals.Add(eternalGoal);
                }
                else if (goalType == 3)
                {
                    Console.Write("How many times do you want to complete this goal? ");
                    int numberNeeded = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus points when you complete it? ");
                    int bonusPoints = int.Parse(Console.ReadLine());
                    ChecklistGoal checklistGoal = new ChecklistGoal(goalName, description, pointValue, numberNeeded, bonusPoints);
                    goals.Add(checklistGoal);
                }
                else
                {
                    Console.WriteLine("The number you entered is not a valid choice.");
                }

            }
            else if (choice == 2)
            {
                int counter = 1;
                // List goals by printing them individually
                foreach (Goal goal in goals)
                {
                    goal.DisplayGoal(counter);
                    counter++;
                }
            }
            else if (choice == 3)
            {
                // Save goals
                SaveData(points, userLevel, goals);
            }
            else if (choice == 4)
            {
                // Load goals
                LoadData(out points, out userLevel, out goals);
            }
            else if (choice == 5)
            {
                // Record event
                Console.WriteLine("The goals are:");
                int counter = 1;
                foreach (Goal goal in goals)
                {
                    goal.DisplayGoal(counter);
                    counter++;
                }
                Console.Write("Which goal did you accomplish? ");
                int goalChoice = int.Parse(Console.ReadLine());
                points += goals[goalChoice - 1].CompleteGoal();

                // Update level based on accumulated points
                userLevel.UpdateLevel(points);
            }

            else if (choice == 6)
            {
                // Quit
                remain = false;
            }            
        }
    }

    static void SaveData(int points, Level userLevel, List<Goal> goals)
    {
        Console.Write("What is the name of the file you would like to save to? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = File.CreateText(fileName))
        {
            // Save points and level
            outputFile.WriteLine($"{points}");
            outputFile.WriteLine($"{userLevel.Current}");

            // Save goals
            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal.GetSaveString());
            }
        }

        Console.WriteLine("Data saved successfully.");
    }

    static void LoadData(out int points, out Level userLevel, out List<Goal> goals)
    {
        Console.Write("What is the name of the file you would like to load information from? ");
        string fileName = Console.ReadLine();

        points = 0;
        userLevel = new Level();
        goals = new List<Goal>();

        if (File.Exists(fileName))
        {
            using (StreamReader inputFile = File.OpenText(fileName))
            {
                // Load points and level
                points = int.Parse(inputFile.ReadLine());
                userLevel.Current = int.Parse(inputFile.ReadLine());

                // Load goals
                string line;
                while ((line = inputFile.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string goalType = parts[0];

                    if (goalType == "SimpleGoal")
                    {
                        SimpleGoal simpleGoal = new SimpleGoal("", "", 0);
                        goals.Add(simpleGoal.DecodeSaveString(line));
                    }
                    else if (goalType == "EternalGoal")
                    {
                        EternalGoal eternalGoal = new EternalGoal("", "", 0);
                        goals.Add(eternalGoal.DecodeSaveString(line));
                    }
                    else if (goalType == "ChecklistGoal")
                    {
                        ChecklistGoal checklistGoal = new ChecklistGoal("", "", 0, 0, 0);
                        goals.Add(checklistGoal.DecodeSaveString(line));
                    }
                }
            }

            Console.WriteLine("Data loaded successfully.");
        }
        else
        {
            Console.WriteLine("The file you are trying to load from doesn't exist.");
        }
    }
}