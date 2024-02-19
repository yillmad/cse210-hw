using System;
using System.Diagnostics;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base()
    {
        SetActivityName("Reflection Activity");

        SetActivityDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        _prompts = new List<string>
        {
            "--- Think of a time when you overcame a significant obstacle. ---",
            "--- Think of a moment when you demonstrated courage in the face of fear. ---",
            "--- Think of a time when you persevered despite feeling overwhelmed. ---",
            "--- Think of a situation where you took a risk and it paid off. ---"
        };

        _questions = new List<string> 
        {
            "What emotions did you experience during this challenge?",
            "How did you find the strength to push through?",
            "Were there any unexpected lessons from this experience?",
            "What advice would you give to someone facing a similar situation?",
            "In what ways did this experience change your perspective?",
            "How did others react to your actions during this time?",
            "Did this experience impact your relationships with others?",
            "What values or beliefs guided you through this experience?",
            "How can you apply the lessons learned from this situation to future challenges?",
            "What steps can you take to maintain your resilience in difficult times?"
        };
    }

    public void RunReflectingActivity()
    {
        RunActivityParentStart();
        DisplayPrompt();
        DisplayQuestions();
        RunActivityParentEnd();
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following: ");
        Console.WriteLine();

        int randomIndex = new Random().Next(0, _prompts.Count());
        Console.WriteLine(_prompts[randomIndex]);
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }    

    public void DisplayQuestions()
    {
        List<int> indexes = new List<int>();

        for (int i = 0; i < 4; i++)
        {
            int randomInt = new Random().Next(0, _questions.Count());
            while (indexes.Contains(randomInt))
            {
                randomInt = new Random().Next(0, _questions.Count());
            }
            indexes.Add(randomInt);
        }
        Console.Clear();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine();
        DisplayCountdown(5);

        foreach (int index in indexes)
        {
            Console.Write(_questions[index]);
            DisplaySpinner((GetUserSessionLengthInput() / indexes.Count()));
            Console.WriteLine();
        }
        
    }

        
}
