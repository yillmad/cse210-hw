using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());
        int reminder = grade%10;
        string letter;
        string sign;

        // determine letter grade
        if(grade >= 90 && grade <= 100)
        {
            letter = "A";
        }
        else if(grade >= 80 && grade < 100)
        {
            letter = "B";
        }
        else if(grade >= 70 && grade < 100)
        {
            letter = "C";
        }
        else if(grade >= 60 && grade < 100)
        {
            letter = "D";
        }
        else if(grade < 60)
        {
            letter = "F";
        }
        else{
            letter ="X";
        }

        // + or -
        if(reminder>=7){
            sign = "+";
        }
        else if(reminder<3){
            sign = "-";
        }        
        else{
            sign = "";
        }

        if(letter=="A"&&sign=="+"){
            sign = "";
        }
        else if(letter=="C"&&(sign=="+"||sign=="-")){
            sign = "";
        }

        // Passed or not

        if(letter=="A"||letter=="B"||letter=="C")
        {
            Console.WriteLine($"Your garde is {letter}{sign} and you passed");
        }
        else if(letter=="D"||letter=="F")
        {
            Console.WriteLine($"Your grade is {letter}{sign} and you didn't passed");
        }
        else{
            Console.WriteLine("Invalid grade");
        }
    }
}