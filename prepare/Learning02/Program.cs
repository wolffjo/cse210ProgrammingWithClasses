using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job(); //variable type job class, named job1 is assigned the value of a new instance of the job class...I think...
        job1._company = "Microsoft";
        job1._jobTitle = "Lead Programmer";
        job1._startYear = 2013;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Software engineer";
        job2._startYear = 2012;
        job2._endYear = 2036;




        Resume resume = new Resume();
        resume._name = "Joseph A.";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();

    }
}