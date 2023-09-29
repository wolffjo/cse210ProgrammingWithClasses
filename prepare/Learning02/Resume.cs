using System.ComponentModel.DataAnnotations;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}\nJobs: ");
        foreach (Job item in _jobs)
        {
            item.Display();
        }

    }

}