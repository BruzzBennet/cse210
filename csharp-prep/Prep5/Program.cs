using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        DisplayWelcome();

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        string name = PromptUserName();
        // Console.WriteLine(name);

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);
            return userNumber;
        }
        int number = PromptUserNumber();

        static int SquareNumber(int numbersqr)
        {
            int sqrt = numbersqr * numbersqr;
            return sqrt;
        }
        int sqrt = SquareNumber(number);

        static void DisplayResult(int number1, string name1)
        {
            Console.WriteLine($"{name1}, the square of your number is {number1}");
        }
        DisplayResult(sqrt, name);
    }
}