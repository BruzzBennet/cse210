public abstract class Goal(string name, string description, int points)
{
    protected string _name = name;
    protected string _description = description;
    protected int _points = points;

    public string getName(){
        return _name;
    }
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public virtual string getDetails()
    {
        if (IsComplete()==false)
            return $"[ ] {_name} ({_description})";
        else
            return $"[X] {_name} ({_description})";
    }

    public abstract string GetStringRepresentation();

}