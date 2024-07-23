using System.Runtime.InteropServices;

public class Cycling:Activity{

    public Cycling(string date, int length, double speed):base(date,length){
        _speed=speed;
    }

    public override double GetPace()
    {
        _pace=60/_speed;
        return _pace;
    }

    public override double GetDistance()
    {
        _distance=_length*_speed/60;
        return _distance;
    }

    public override string GetSummary()
    {
        return $"{_date} Cycling ({_length} min) - Distance {Math.Round(GetDistance(),2)} km, Speed {Math.Round(_speed,2)} kph, Pace: {Math.Round(GetPace(),2)} min per km";
    }
}