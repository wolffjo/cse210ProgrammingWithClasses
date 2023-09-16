using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        Console.Write("What is you grade percentage? ");
        string input = Console.ReadLine();
        int gradePercentage = int.Parse(input);

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage <= 89 && gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage <= 79 && gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage <= 69 && gradePercentage >= 60)
        {
            letter = "D";
        }
        else if (gradePercentage < 60)
        {
            letter = "F";
        }
        else
        {
            Console.WriteLine("HoI! i'M TeMmiE!");
        }
        Console.WriteLine($"Your grade is {letter}.");
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You pass the class!");
        }
        else
        {
            Console.WriteLine("You didn't pass the class, but if you worker harder, you can!");
        }
    }
}