using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();

        if (int.TryParse(grade, out int intGrade))
        {
            string letter;

            if (intGrade >= 90)
            {
                letter = "A";
            }
            else if (intGrade >= 80)
            {
                letter = "B";
            }
            else if (intGrade >= 70)
            {
                letter = "C";
            }
            else if (intGrade >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            if (letter == "A" || letter == "B" || letter == "C")
            {
                Console.WriteLine($"Your grade is {letter} and you passed");
            }
            else if (letter == "D" || letter == "F")
            {
                Console.WriteLine($"Your grade is {letter} and you didn't pass");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid grade percentage.");
        }
    }
}
