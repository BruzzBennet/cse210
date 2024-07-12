using System.Globalization;
using System.Net.Quic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    private string number;

    public int checknumber(string menu)
    {
        bool correct = false;
        while (!correct)
        {
            Console.Write(menu);
            number = Console.ReadLine();
            try
            {
                int cn = int.Parse(number);
                correct = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please insert a number");
                Console.Write("Hit enter to continue");
                Console.ReadLine();
            }
        }
        return int.Parse(number);
    }

    public void Start()
    {
        bool quit = false;
        while (!quit)
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            int choice = checknumber("Select a choice from the menu: ");
            if (choice == 1)
            {
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.WriteLine("  Press any other number to go back");
                int goalchoice = checknumber("Select a choice from the menu: ");
                if (goalchoice>1 && goalchoice<3)
                    CreateGoal(goalchoice);
            }
            else if (choice == 2)
            {
                ListGoalDetails();
            }
            else if (choice == 3)
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                SaveGoals(filename);
            }
            else if (choice == 4)
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                LoadGoals(filename);
            }
            else if (choice == 5)
            {
                RecordEvent();
            }
            else if (choice == 6)
            {
                quit = true;
            }
            else
            {
                Console.WriteLine("Please insert a number between 1 and 6");
                Console.Write("Hit enter to continue");
                Console.ReadLine();
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your current score is {_score}");
    }

    public void ListGoalNames()
    {
        int num=0;
        foreach (Goal goal in _goals)
        {
            num++;
            Console.WriteLine($"{num}. {goal.getName()}");
        }
    }

    public void ListGoalDetails()
    {
        int num=0;
        foreach (Goal goal in _goals)
        {
            num++;
            Console.WriteLine($"{num}. {goal.getDetails()}");
        }
    }

    public void CreateGoal(int choice)
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string desc = Console.ReadLine();
        int points = checknumber("How many points would this goal have? ");
        if (choice == 1)          
            _goals.Add(new SimpleGoal(name, desc, points));
        else if (choice == 2)
            _goals.Add(new EternalGoal(name, desc, points));
        else if (choice == 3)
        {
            int target = checknumber("How many times does it need to be done for a bonus? ");
            int bonus = checknumber($"What is the bonus for achieving it {target} times? ");
            _goals.Add(new CheckListGoal(name, desc, points, target, bonus));
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        int eventnum = checknumber("Which goal did you accomplish? ");
        _score = _score+ _goals[eventnum - 1].RecordEvent();
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach(Goal goal in _goals)
                outputFile.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void LoadGoals(string filename)
    {
        int score = int.Parse(System.IO.File.ReadLines(filename).First());
        _score=score;
        string[] lines = System.IO.File.ReadAllLines(filename);
        lines = lines.Skip(1).ToArray();
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string type= parts[0];
            string name = parts[1];
            string desc = parts[2];
            string pointstring = parts[3];
            int points = int.Parse(pointstring);
            if (type=="SimpleGoal")
            {
                SimpleGoal newgoal = new SimpleGoal(name,desc,points);
                string completed=parts[4];
                if (completed=="True")
                    newgoal.IsComplete();
                _goals.Add(newgoal);                
            }
            else if (type=="EternalGoal")
                _goals.Add(new EternalGoal(name,desc,points));
            else if (type=="ChecklistGoal"){
                string completedb = parts[4];
                string targetb = parts[5];
                string bonusb = parts[6];
                int completed=int.Parse(completedb);
                int target=int.Parse(targetb);
                int bonus=int.Parse(bonusb);
                CheckListGoal newgoal = new CheckListGoal(name,desc,points,target,bonus);
                newgoal.addAmount(completed);
                _goals.Add(newgoal);
            }
        }
    }
}