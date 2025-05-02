
using System;

class Program
{
    static void Main(string[] args)
    {
     
        
    Console.Write("What is the magic number? ");
    string answer = Console.ReadLine();
    int number = int.Parse(answer);

    Console.Write("Whats is your guess? ");
    string guessAnswer = Console.ReadLine();
    int guessNumber = int.Parse(guessAnswer);

        
    if (number > guessNumber)
    {
        Console.WriteLine("Higher");
    }

    else if (number < guessNumber)
    {
        Console.WriteLine("Lower");
    }
    else if (number == guessNumber)
    {
        Console.WriteLine("You guessed it!");
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a number.");         
    }  
    }  
}                
// handling invalid input in C# is a common task, and there are several ways to do it. Here are some options:
//https://www.reddit.com/r/csharp/comments/7m9el7/having_a_hard_time_understanding_how_to_deal_with/?rdt=41024
