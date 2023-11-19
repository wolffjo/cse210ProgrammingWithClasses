using System.Linq.Expressions;

class ChecklistGoal : Goal
{
    bool loop = true;

    public ChecklistGoal()
    {
        _goalType = "Checklist Goal";
        _description = "This goal is for achievements you wish to reach a certain number of times.";
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
                ChecklistGoal goal = new ChecklistGoal();
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

    public override void isFinished(string input)
    {
        foreach(GoalList goal in _list)
        {
            if(input == goal._goalName)
            {
                if(goal._completed == false)
                {
                    goal._completed = true;
                    goal._currentAmount += 1;
                }
            }
        }
    }
}