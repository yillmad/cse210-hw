using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int>numbers=new List<int>();
        int number;
        int sum = 0;
        int times = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        
        do{
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
            times++;
        }while(number!=0);

        foreach(int num in numbers)
        {
            sum = sum + num;
            int largest;
            if (lastNumber>num){

            }
            int lastNumber = num;
        }

        int average = sum/times;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: ");

    }
}