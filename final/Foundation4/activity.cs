public abstract class Activity{
    protected string _date;
    protected int _length;
    protected double _distance;
    protected double _speed;
    protected double _pace;

    public Activity(string date, int length){
        _date=date;
        _length=length;
    }

    public abstract string GetSummary();

    public virtual double GetSpeed(){
        _speed=60*_distance/_length;
        return _speed;
    }

    public virtual double GetPace(){
        _pace=_length/_distance;
        return _pace;
    }

    public virtual double GetDistance(){
        _distance=_length*GetSpeed();
        return _distance;
    }
}