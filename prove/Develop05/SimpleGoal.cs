using System.ComponentModel.DataAnnotations.Schema;

public class SimpleGoal:Goal{

    public bool _isComplete;

    public SimpleGoal(string name, string desc, int points):base(name,desc,points){

    }

    public override int RecordEvent()
    {
        IsComplete();
        return _points;
    }

    public override bool IsComplete()
    {
        _isComplete=true;
        return _isComplete;
    }


    public override string GetStringRepresentation()
    {
            return $"SimpleGoal,{_name},{_description},{_points},{_isComplete}";
    }
}