using System;

class Program
{
    static void Main(string[] args)
    {
        bool loop = true;
        string choice = "";
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness Program!");
        while (loop == true)
        {
            Console.WriteLine("Select from the options below by typing the number and pressing enter.");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            choice = Console.ReadLine();


            if (choice == "1") //Breathe
            {
                BreathingActivity breathing = new BreathingActivity("Breathing");
                Console.Clear();
                breathing.Run();

            }
            else if (choice == "2") //Reflect
            {
                ReflectingActivity reflecting = new ReflectingActivity("Reflecting");
                Console.Clear();
                reflecting.Run();
            }
            else if (choice == "3") //List
            {
                ListingActivity listing = new ListingActivity("Listing");
                Console.Clear();
                listing.Run();
            }
            else if (choice == "4") //Quit
            {
                Console.Clear();
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("That's not an option, please try again.");
                Console.WriteLine();
            }
        }
        
        
    }
}