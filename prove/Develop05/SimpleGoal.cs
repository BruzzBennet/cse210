using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

public class SimpleGoal:Goal{

    public bool _isComplete=false;

    public SimpleGoal(string name, string desc, int points):base(name,desc,points){

    }

    public void Completed(){
        _isComplete=true;
    }

    public override int RecordEvent()
    {
        _isComplete=true;
        return _points;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }


    public override string GetStringRepresentation()
    {
            return $"SimpleGoal,{_name},{_description},{_points},{_isComplete}";
    }
}