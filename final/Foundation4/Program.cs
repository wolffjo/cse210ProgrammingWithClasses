using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Activity> list = new List<Activity>();
        Running run = new Running(30, 5);
        Cycling cycle = new Cycling(60, 30);
        Swimming swim = new Swimming(45, 8);
        list.Add(run);
        list.Add(cycle);
        list.Add(swim);

        foreach(Activity activity in list)
        {
            activity.GetSummary();
        }
    }
}