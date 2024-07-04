public class ReflectingActivity:Activity{
    private List<string> _prompts=new List<string>();
    private List<string> _questions=new List<string>();
    static Random rnd = new Random();
    public ReflectingActivity(){
        _name="Reflecting";
        _description="This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void Run(){
        DisplayStartingMessage();
        int time=_duration;
        Console.WriteLine("Get Ready...");
        ShowSpinner(3);
        time-=3;
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, hit enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now ponder each of the following questions as they related to this experience");
        Console.WriteLine("You may begin in...");
        ShowCountDown(5);
        Console.Clear();
        DisplayQuestions();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt(){
        int r = rnd.Next(_prompts.Count);
        return _prompts[r];
    }

    public string GetRandomQuestion(){
        int r = rnd.Next(_questions.Count);
        return _questions[r];
    }

    public void DisplayPrompt(){
        Console.WriteLine($"-- {GetRandomPrompt()} --");
    }

    public void DisplayQuestions(){
        string q=GetRandomQuestion();
        Console.WriteLine($"> {q}");
        int time=_duration/2;
        ShowSpinner(time);
        string q1=GetRandomQuestion();
        while (q1==q)
            q1=GetRandomQuestion();
        Console.WriteLine($"> {q1}");
        ShowSpinner(time);
    }
}