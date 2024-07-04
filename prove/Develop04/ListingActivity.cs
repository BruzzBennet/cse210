public class ListingActivity:Activity{
    private int _count;
    private List<string> _prompts=new List<string>();
    static Random rnd = new Random();
    public ListingActivity(){
        _name="Listing";
        _description="This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run(){
        DisplayStartingMessage();
        int time=_duration;
        Console.WriteLine("Get Ready...");
        ShowSpinner(3);
        time-=3;
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --{GetRandomPrompt()}--");
        Console.Write("You may begin in...");
        ShowCountDown(5);
        int c=GetListFromUser();
        Console.WriteLine($"You listed {c} items!");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt(){
        int r = rnd.Next(_prompts.Count);
        return _prompts[r];
    }

    public int GetListFromUser(){
        int time=_duration;
        // List<string> userList = new List<string>();
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);
        Console.WriteLine();
        bool quit=false;
        while (!quit){
            Console.Write("> ");
            Console.ReadLine();
            // userList.Add(Console.ReadLine());
            _count++;
            startTime = DateTime.Now;
            if (startTime > futureTime){
                quit=true;
            }   
        }        
        return _count;
    }
}