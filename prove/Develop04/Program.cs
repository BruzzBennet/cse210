using System;
using System.ComponentModel.Design;
using System.Net.Quic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

//Added ways in made sure numeric inputs where ints, and if they aren't, they will continue asking for a number until 
//a number is inserted
//I also added a message when a number other than 1-4 that tell the user to insert a number between them

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;

        while (!quit)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string option = Console.ReadLine();
            try
            {
                int choice = int.Parse(option);
                if (choice == 1)
                {
                    BreathingActivity b = new BreathingActivity();
                    b.Run();
                }
                else if (choice == 2)
                {
                    ReflectingActivity r = new ReflectingActivity();
                    r.Run();
                }
                else if (choice == 3)
                {
                    ListingActivity l = new ListingActivity();
                    l.Run();
                }
                else if (choice == 4)
                {
                    quit = true;
                }
                else
                {
                    Console.WriteLine("Please insert a number between 1 and 4");
                    Console.Write("Hit enter to continue");
                    Console.ReadLine();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please insert a number");
                Console.Write("Hit enter to continue");
                Console.ReadLine();
            }
            Console.Clear();
        }
    }
}