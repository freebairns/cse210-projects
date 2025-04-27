using System;

class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine("Enter your grade percentage (0-100): ");
        string answer = Console.ReadLine();
        int gradePercentage = int.Parse(answer);


        if (gradePercentage >= 90 && gradePercentage <= 100)
        {
            Console.WriteLine("A");
        }
        else if (gradePercentage >= 80 && gradePercentage < 90)
        {
            Console.WriteLine("B");
        }
        else if (gradePercentage >= 70 && gradePercentage < 80)
        {
            Console.WriteLine("C");
        }
        else if (gradePercentage >= 60 && gradePercentage < 70)
        {
            Console.WriteLine("D");
        }
        else if (gradePercentage >= 0 && gradePercentage < 60)
        {
            Console.WriteLine("F");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 0 and 100."); 
        }

        if (gradePercentage >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("Almost there! You can do it next time!");
        }
    }
}