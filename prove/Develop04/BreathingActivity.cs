class BreathingActivity : Activity
{
    private string breatheIn;
    private string breatheOut;
    bool bIn = true;

    public void DisplayCountdown()
    {
        int biNumber = 4;
        int boNumber = 6;

        if (bIn == true)
        {
            while(biNumber != 0) //aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaHHHHHHHHHHHHHHHHHHHHHHHHHHHHH
            {   
                Console.Write(biNumber);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                biNumber = biNumber - 1;
                if(biNumber == 0)
                {
                    Console.WriteLine();
                }
            }
        }
        else if (bIn != true)
        {
            while(boNumber != 0)
            {
                Console.Write(boNumber);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                boNumber = boNumber - 1;
                if(boNumber == 0)
                {
                    Console.WriteLine();
                }
            }
        }

    }

    public void DisplayBreatheIn()
    {
        breatheIn = "Breathe In...";
        Console.Write(breatheIn);
    }

    public void DisplayBreatheOut()
    {
        breatheOut = "Now Breathe Out...";
        Console.Write(breatheOut);
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
        SetWaitTime(getTime);

        while(activityRun == true)
        {
            DisplayBreatheIn();
            DisplayCountdown();
            bIn = false;
            

            DisplayBreatheOut();
            DisplayCountdown();
            bIn = true;
            Console.WriteLine();

            checkTime = true;
            SetWaitTime(getTime);
            if(activityRun == false)
            {
                Console.Clear();
                break;
            }
            //else 
            //{
              //  checkTime = false;
            //}
        }
        DisplayClosingMsg();
        TrackSpinnerTime();
    }

    public BreathingActivity(string name)
    {
        _activityName = name;
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
}