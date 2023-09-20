using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int mNumber = randomGenerator.Next(1, 101);
        int guess = 999999999;

        string input = "";

        //Console.WriteLine("What is your magic number? ");
        //string input = Console.ReadLine();
        //int mNumber = int.Parse(input);

        while(guess != mNumber)
        {
            Console.WriteLine("What is your guess? ");
            input = Console.ReadLine();
            int gNum = int.Parse(input);
            if (gNum < mNumber)
            {
                Console.WriteLine("Higher");
            }
            else if(gNum > mNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                guess = mNumber;
            }
        }
        Console.WriteLine("You guessed it!");
    }
}