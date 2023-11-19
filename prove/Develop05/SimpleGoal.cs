class SimpleGoal : Goal
{
    bool loop = true;

    public SimpleGoal()
    {
        _goalType = "Simple Goal";
        _description = "This goal is meant for just singular great achievements that you wish to reach.";
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
                SimpleGoal goal = new SimpleGoal();
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