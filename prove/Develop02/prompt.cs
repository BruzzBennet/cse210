public class Prompts{
    public List<string> _prompts= new List<string>();
    static Random rnd = new Random();

    public string GetRandomPrompt(){
        _prompts.Add("What was the highlight of your day?");
        _prompts.Add("How did you feel today?");
        _prompts.Add("What thing did you learn today?");
        _prompts.Add("Who made your day special?");
        _prompts.Add("What did you do today?");       
        int r = rnd.Next(_prompts.Count);
        return _prompts[r];
    }
}