class ListingActivity : Activity
{
    Random random = new Random();
    int count = 0;
    private List<string> _promptList = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public string GetRandomPrompt()
    {
        int num = random.Next(0, _promptList.Count);
        string prompt = _promptList[num];
        return prompt;
    }   

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($">>> {prompt} <<<");
    }

    public void DisplayCountdown() //I used this more often than I thought i would, I could have put it in activity
    {
        int num = 5;
        while(num != 0)
        {
            Console.Write(num);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            num = num - 1;
            if(num == 0)
            {
                Console.WriteLine();
            }
        }
    }

    public void CountTracker()
    {
        count += 1;
    }

    public void Run()
    {
        DisplayOpeningMsg();
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like this activity to be? ");
        string getTime = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Get ready...");
        TrackSpinnerTime();

        Console.WriteLine("List as many responses as you can to the following prompt: ");

        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine();

        Console.Write("You may begin in: ");
        DisplayCountdown();

        SetWaitTime(getTime);

        while(activityRun == true)
        {
            Console.Write(">");
            Console.ReadLine();
            CountTracker();

            checkTime = true;
            SetWaitTime(getTime);
            if(activityRun == false)
            {
                Console.Clear();
                Console.WriteLine($"You listed {count} items!");
                //Console.WriteLine("Well done!"); //doesn't really fit, ya know what I mean?
                count = 0;
                TrackSpinnerTime();
                break;
            }
        }
        DisplayClosingMsg();
        TrackSpinnerTime();
    }

    public ListingActivity(string name) //I wonder if there's a way to have an activity constructor and tailor it to the children?
    {
        _activityName = name;
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
}