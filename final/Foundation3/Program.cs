using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Address a1 = new Address("1234", "New York", "New York");
        Lecture lecture = new Lecture("Fortnite is better than Among Us", "This lecture will be about all the reasons why Forntite is superior in every game, including Among Us!", "09-52-7493", "27:00", "Dwayne \"The Rock\" Johnson", 15000, a1);
        Reception reception = new Reception("The reception of Efrain and Rachael!", "It finally happened! They joined together! Please join us for this amaazing reception!", "04-16-2024", "17:00 - 20:00", "ARE YOU COMING? THIS IS A ONCE IN A LIFETIME OPPORTUNITY!", a1);
        OutdoorGathering outdoor = new OutdoorGathering("Ultimate Frisbee", "Spills! Chills! Thrills! Chaos ensues!", "21-56-9999", "-15:00", "Weather should be cloudy, with a chance of fire. Prepare Accordingly.", a1);

        lecture.StandardDetails();
        Console.WriteLine();
        lecture.Run();
        Console.WriteLine();
        lecture.ShortDetails();

        Console.WriteLine("\n\n");

        reception.StandardDetails();
        Console.WriteLine();
        reception.Run();
        Console.WriteLine();
        reception.ShortDetails();

        Console.WriteLine("\n\n");

        outdoor.StandardDetails();
        Console.WriteLine();
        outdoor.Run();
        Console.WriteLine();
        outdoor.ShortDetails();
    }
}