public class Activity
{
    protected string _openingMsg;
    protected string _closingMsg;
    protected int _time;
    protected string _description;
    protected string _activityName;
    protected bool checkTime = false;
    protected bool activityRun = true;
    DateTime futureTime;

    public void DisplayOpeningMsg()
    {
        Console.WriteLine($"Welcome to the {_activityName} Activity!");
    }

    public void DisplayClosingMsg()
    {
        Console.WriteLine($"Congratulations, you completed another {_time} seconds of the {_activityName} Activity!");
    }

    public void DisplaySpinner() //haha spinner go brrrrrrrrrrrrrrrrrrrrr
    {
        int wait = 50;

        Console.Write("\\");
        Thread.Sleep(wait);
        Console.Write("\b \b");

        Console.Write("|");
        Thread.Sleep(wait);
        Console.Write("\b \b");

        Console.Write("/");
        Thread.Sleep(wait);
        Console.Write("\b \b");

        Console.Write("-");
        Thread.Sleep(wait);
        Console.Write("\b \b");
    }

    public void SetWaitTime(string getTime) //probably added a bit more here than I should have, but I'm too lazy to move it (-_-')
    {
        if(checkTime == false)
        {
            _time = int.Parse(getTime);
            DateTime startTime = DateTime.Now;
            futureTime = startTime.AddSeconds(_time);
        }
        else if(checkTime == true)
        {
            DateTime currentTime = DateTime.Now;
            if(futureTime <= currentTime)
            {
                activityRun = false;
                checkTime = false;
            }
        }
    }

   public void TrackSpinnerTime() //also probably should name this something else but ¯\_(ツ)_/¯
   {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(3);
        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime)
        {
            DisplaySpinner();
            currentTime = DateTime.Now;
        }
   }
}