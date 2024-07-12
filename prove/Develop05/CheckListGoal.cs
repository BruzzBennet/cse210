public class CheckListGoal:Goal{
    private int _amountCompleted=0;
    private int _target;
    private int _bonus;
    public CheckListGoal(string name, string desc, int points, int target, int bonus):base(name,desc,points){
        _target=target;
        _bonus=bonus;
    }

    public void addAmount(int amount){
        _amountCompleted=amount;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        if (IsComplete())
            return _bonus;
        else
            return _points;
    }

    public override string getDetails(){
        if (_amountCompleted<_target)
            return  $"[ ] {_name} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        else
            return  $"[X] {_name} ({_description}) -- Completed {_amountCompleted}/{_target}!";
    }

    public override bool IsComplete()
    {
        if (_amountCompleted==_target)
            return true;
        else
            return false;
    }

    public override string GetStringRepresentation()
    {
        return  $"ChecklistGoal,{_name},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }
}