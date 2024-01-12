using System;

class Program
{
    static void Main(string[] args)
    {
        string toContinue = "yes";

        while(toContinue=="yes"){
            int guess;
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,100);
            int guesses = 0;

            do{
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guesses++;

                if (guess<magicNumber){
                    Console.WriteLine("Higher");
                }
                else if (guess>magicNumber){
                    Console.WriteLine("Lower");
                }
                else{
                    Console.WriteLine("You guessed it!");
                }

                Console.WriteLine($"You made {guesses} guesses");
            }while(guess!=magicNumber);

            Console.WriteLine("Do you want to continue playing?");
            toContinue = Console.ReadLine();
        }
    }
}