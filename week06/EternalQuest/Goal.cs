public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetName() => _name;

    public abstract int RecordEvent();      // polymorphism
    public abstract bool IsComplete();      // polymorphism
    public abstract string GetStatus();     // polymorphism
    public abstract string SaveFormat();    // polymorphism
}