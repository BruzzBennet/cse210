using System.Transactions;

public class Video(){
    private string _author;
    private string _title;
    private int _duration;
    private List<Comments> _comments = new List<Comments>();

    public void SetAuthor(string author){
        _author=author;
    }

    public void SetTitle(string title){
        _title=title;
    }

    public void SetDuration(int duration){
        _duration=duration;
    }

    public void AddComment(Comments comments){
        _comments.Add(comments);
    }

    public void Display(){
        Console.WriteLine($"{_author}: '{_title}', {_duration} seconds");
        Console.WriteLine("Comments:");
        foreach (Comments Comment in _comments){
            Console.WriteLine($"      {Comment.Display()}");
        }
    }
}