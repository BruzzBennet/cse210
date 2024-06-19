using System;
using System.ComponentModel.DataAnnotations;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        Journal addentry = new Journal();
        Prompts question = new Prompts();

        while (!quit)
        {
            Console.WriteLine("Please write one of the following:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What do you want to do? ");
            string option = Console.ReadLine();
            try
            {
                int choice = int.Parse(option);
                if (choice == 1)
                {
                    Entry newentry = new Entry();
                    DateTime theCurrentTime = DateTime.Now;
                    newentry._date = theCurrentTime.ToShortDateString();
                    newentry._question = question.GetRandomPrompt();
                    Console.Write($"{newentry._question} ");
                    newentry._answer = Console.ReadLine();
                    addentry.addEntry(newentry);
                }
                else if (choice == 2)
                {
                    addentry.displayAll();
                }
                else if (choice == 3)
                {
                    Console.Write("Write your filename: ");
                    string filename = Console.ReadLine();
                    addentry.LoadFromFile(filename);
                }
                else if (choice == 4)
                {
                    Console.Write("Write your filename: ");
                    string filename = Console.ReadLine();
                    addentry.SaveToFile(filename);
                }
                else if (choice == 5)
                {
                    quit = true;
                }
                else
                {
                    Console.WriteLine("Please insert a number between 1 and 5");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please insert a number");
            }
        }
    }
}