class ReflectingActivity : Activity
{
    Random random = new Random();
    private List<string> _promptList = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questionList = new List<string>()
    {
        "Why was this experience meaningful to you? ",
        "Have you ever done anything like this before? ",
        "How did you get started? ",
        "How did you feel when it was complete? ",
        "What made this time different than other times when you were not as successful? ",
        "What is your favorite thing about this experience? ",
        "What could you learn from this experience that applies to other situations? ",
        "What did you learn about yourself through this experience? ",
        "How can you keep this experience in mind in the future ?"
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

    public string GetRandomQuestion()
    {
        int num = random.Next(0, _questionList.Count);
        string question = _questionList[num];
        return question;
    }

    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.Write($"> {question} ");
    }

    public void DisplayCountdown()
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
                Console.Clear();
            }
        }
        
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

        Console.Clear();

        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine();

        Console.WriteLine("Press enter when you're ready to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions that are related to the experience.");
        Console.Write("You may begin in: ");
        DisplayCountdown();
        Console.Clear();

        SetWaitTime(getTime);

        while(activityRun == true)
        {
            DisplayQuestion();
            TrackSpinnerTime();
            Console.WriteLine();

            checkTime = true;
            SetWaitTime(getTime);
            if(activityRun == false)
            {
                Console.Clear();
                break;
            }
        }
        DisplayClosingMsg();
        TrackSpinnerTime();
    }

    public ReflectingActivity(string name)
    {
        _activityName = name;
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
}