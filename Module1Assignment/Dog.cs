namespace Module1Assignment;

public class Dog : Pet, ITalkable
{
    private readonly bool _friendly;

    public Dog(string name, bool friendly) : base(name)
    {
        this._friendly = friendly;
    }

    public bool GetFriendly()
    {
        return _friendly;
    }

    public string Talk()
    {
        return "Bark";
    }

    public override string ToString()
    {
        return "Dog: " + "name=" + Name + " friendly=" + _friendly;
    }
}