using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int>numbers=new List<int>();
        int number;
        double sum = 0;
        double times = -1;
        int largest = 0;
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
            if (largest<num){
                largest = num;
            }
        }
        int smallest = largest;
        int realSmallest = largest;

        foreach(int small in numbers)
        {
            if(smallest>small&&small>0){
                smallest=small;
            }
            if(realSmallest>small){
                realSmallest=small;
            }
        }

        Console.WriteLine($"this is the relsamllest number {realSmallest}");

        int index = numbers.Count-1;
        List<int>orderedList=new List<int>();

        while(index!=orderedList.Count){
            foreach (int order in numbers){
                if(order<realSmallest&&order!=0){
                    orderedList.Add(order);
                }
                else{
                    realSmallest++;
                }
        }}

        double average = sum/times;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is:{largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        Console.WriteLine($"The sortered list is: ");
        foreach(int or in orderedList){
            Console.WriteLine(or);
        }
    }
}