using System.Reflection.Metadata;

abstract class Goal
{   
    // protected GoalList goal = new GoalList();
    public static List<GoalList> _list = new List<GoalList>();
    protected string _goalType;
    protected string _description;
    protected static int _userScore;
    protected string _goalName;

    public virtual void isFinished(string input)
    {
        foreach(GoalList goal in _list)
        {
            if(input == goal._goalName)
            {
                if(goal._completed == false)
                {
                    goal._completed = true;
                }
            }
        }
    }
    
    protected void createGoal()
    {
        GoalList goal = new GoalList();

        goal._goalType = _goalType;

        Console.WriteLine("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        goal._goalName = _goalName;

        Console.WriteLine("How many points is it worth? (i.e. 50 or 500)");
        int _goalPoints = int.Parse(Console.ReadLine());
        goal._goalPoints = _goalPoints;

        if(_goalType == "Checklist Goal")
        {
            Console.WriteLine("How many times would you like to do this? (type number, i.e. 3 or 5)");
            int input = int.Parse(Console.ReadLine());
            goal._endAmount = input;
        }

       _list.Add(goal);

        SaveEntries();
    }

    protected void SaveEntries() //every time I reopen the program, creating goals overwrites the .txt file
    {
        if (File.Exists("AllGoals.txt"))
        {
            File.Delete("AllGoals.txt");
        }
        using (StreamWriter sw = new StreamWriter("AllGoals.txt", true))
        {
            foreach(GoalList item in _list)
            {
                sw.WriteLine(item.Display());
            }
        }
    }


    public virtual void markGoal()
    {
        Console.Clear();
        string[] lines = System.IO.File.ReadAllLines("AllGoals.txt");
        retrieveGoal(lines);
        displayGoal();
        Console.WriteLine("\n\nWhich goal did you complete? ");
        string input = Console.ReadLine();
        isFinished(input);
        gainPoints(input);
    }

    protected void displayGoal()
    {
        foreach(GoalList goal in _list)
        {
            if(goal._goalType == _goalType)
            {
                if(goal._completed == true)
                {
                    Console.WriteLine($"{goal._goalType}: {goal._goalName} [x]");
                }
                else
                {
                    Console.WriteLine($"{goal._goalType}: {goal._goalName} [ ]");
                }                
            }
        }     
    }
    protected void retrieveGoal(string[] lines)
    {
        foreach (string line in lines)
        {
            GoalList goal = new GoalList();
            string[] part = line.Split("~|~");

            goal._goalType = part[0];
            goal._goalName = part[1];
            goal._goalPoints = int.Parse(part[2]);
            goal._currentAmount = int.Parse(part[3]);
            goal._endAmount = int.Parse(part[4]);
            goal._completed = bool.Parse(part[5]);

            _list.Add(goal);
        }
    }

    protected void intro()
    {
        Console.WriteLine($"Hello! Welcome to the {_goalType} activity!");
        Console.WriteLine(_description);
    }

    protected void gainPoints(string userInput)
    {   
        foreach(GoalList goal in _list)
        {
            if(userInput == goal._goalName)
            {
                if(goal._completed == true)
                {    
                    if(goal._goalType == "Endless Goal")
                    {
                        goal._completed = false;
                        Console.WriteLine($"You've gained {goal._goalPoints} points!");
                        _userScore += goal._goalPoints;
                    }
                    else if(goal._goalType == "Checklist Goal")
                    {
                        if(goal._currentAmount == goal._endAmount)
                        {
                            goal._goalPoints = goal._goalPoints * 10;
                            Console.WriteLine("Congratulations! You've achieved a checklist goal!");
                            Console.WriteLine($"You gained {goal._goalPoints} points!");
                            _userScore += goal._goalPoints;
                            goal._goalPoints = goal._goalPoints / 10;
                        }
                        else
                        {
                            Console.WriteLine($"You've gained {goal._goalPoints} points!");
                            _userScore += goal._goalPoints;
                        }
                    }
                    else if(goal._goalType == "Simple Goal")
                    {
                        goal._completed = false;
                        Console.WriteLine("Congratulations! You completed a Simple Goal!");
                        Console.WriteLine($"You've gained {goal._goalPoints} points!");
                        _userScore += goal._goalPoints;
                    }
                }
            }

            SaveEntries();
        }
    }
}