using System.Linq.Expressions;
using System.Runtime.CompilerServices;

class DevelopHabit : Goal
{
    bool loop = true;
    public DevelopHabit()
    {
        _goalType = "Endless Goal";
        _description = "This goal doesn't have an end (hence the name) but keeps people accountable while they try to develop good habits!";
    }

    public void Display()
    {   
        while(loop == true)
        {
            Console.Clear();
            intro();
            Console.WriteLine("What would you like to do? ");
            Console.WriteLine("1. Mark Goal");
            Console.WriteLine("2. Create Goal");
            Console.WriteLine("3. Go back");
            string i = Console.ReadLine();
            int input = int.Parse(i);

            if(input == 1)
            {
                markGoal();
            }
            else if(input == 2)
            {
                DevelopHabit goal = new DevelopHabit();
                Console.Clear();
                goal.createGoal();
            }
            else if(input == 3)
            {
                Console.Clear();
                loop = false;
            }
        }
        
    }
}