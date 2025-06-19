public class Cycling : Activity
{
    private double _speedKph;

    public Cycling(string date, int lengthMinutes, double speedKph)
        : base(date, lengthMinutes)
    {
        _speedKph = speedKph;
    }

    public override double GetSpeed()
    {
        return _speedKph;
    }

    public override double GetDistance()
    {
        return (_speedKph * GetLength()) / 60;
    }

    public override double GetPace()
    {
        return 60 / _speedKph;
    }
}
