using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator generator = new PromptGenerator();
        Journal journal = new Journal();
        

        bool quit = false;
        string response;

        //entry._file = "Journal.txt";
        
       

        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Choose an option by typing the corresponding number wihout the period.");

        while(quit != true)
        {
            Console.WriteLine();
            Console.WriteLine("1. New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Quit");
            //Console.WriteLine("5. Create Prompts");

            Console.WriteLine();

            string input = Console.ReadLine();
            int number = int.Parse(input);

            // Add entry
            if(number == 1)
            {
                Entry entry = new Entry();
                string prompt = generator.GetPrompt();
                DateTime dateTime = DateTime.Now;
                string dateText = dateTime.ToShortDateString();

                Console.WriteLine($"{prompt}");
                response = Console.ReadLine();

                entry._date = dateText;
                entry._prompt = prompt;
                entry._response = response;

                journal._entries.Add(entry);
            }

            // Display entry
            else if(number == 2)
            {
                journal.Display();
            }

            // Save
            else if(number == 3)
            {
                Console.WriteLine("Where would you like to save the file? ");
                string file = Console.ReadLine();

                journal.SaveEntries(file);                
            }

            // Load
            else if(number == 4)
            {
                Console.WriteLine("What file would you like to load? ");
                string file = Console.ReadLine();


                string[] lines = System.IO.File.ReadAllLines(file);
                foreach (string line in lines)
                {
                    Entry entry = new Entry();
                    string[] part = line.Split("~|~");

                    entry._date = part[0];
                    entry._prompt = part[1];
                    entry._response = part[2];

                    journal._entries.Add(entry);

                }
                
            }

            // Quit
            else if(number == 5)
            {
                quit = true;
            }
        }
        
    }
}