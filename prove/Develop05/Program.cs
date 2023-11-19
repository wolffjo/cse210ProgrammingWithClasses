using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        bool quit = false;
        //DevelopHabit habit = new DevelopHabit();
        Console.WriteLine("Welcome to the goal program!");

        while(quit != true)
        {
            Console.WriteLine("Input the number of the option you want");
            Console.WriteLine("1. Endless Goal");
            Console.WriteLine("2. Simple Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Display All Goals");
            Console.WriteLine("6. Quit");

            string i = Console.ReadLine();
            int input = int.Parse(i);

            if(input == 1) //endless
            {
                DevelopHabit habit = new DevelopHabit();
                habit.Display();
            }
            else if(input == 2) //simple
            {
                SimpleGoal simple = new SimpleGoal();
                simple.Display();
            }
            else if(input == 3) //checklist
            {
                ChecklistGoal checklist = new ChecklistGoal();
                checklist.Display();
            }
            else if(input == 4) //display score
            {
                
            }
            else if(input == 5)
            {
                foreach(GoalList goal in Goal._list)
                {
                    Console.WriteLine($"{goal._goalType}: {goal._goalName}");
                }
            }
            else if(input == 6) //quit
            {
                Console.Clear();
                quit = true;
            }
            else
            {
                Console.WriteLine("Sorry, that's not an option. Please try again.");
            }
        }
        Console.WriteLine("Goodbye!");
    }
}