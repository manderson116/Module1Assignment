namespace Module1Assignment;

public abstract class Person
{
    protected string Name;

    protected Person(string name)
    {
        this.Name = name;
    }

    public string GetName()
    {
        return Name;
    }

    public void SetName(string name)
    {
        this.Name = name;
    }
}