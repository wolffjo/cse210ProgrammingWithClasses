using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        int num = 99999;
        int count = 0;
        int adding = 0;
        int greatest = 0;
        string input = "";
        List<int> numbers = new List<int>();

        while (num != 0)
        {
            Console.WriteLine("Enter numbers to add to a list. Type 0 to finish. ");
            input = Console.ReadLine();
            num = int.Parse(input);
            numbers.Add(num);

        }

        foreach (int item in numbers)
        {
            Console.WriteLine(item);
            adding += item;
            count += 1;
            if(greatest < item)
            {
                greatest = item;
            }
        }
        int average = adding / count;
        Console.WriteLine($"The sum is {adding}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {greatest}");

    }
}