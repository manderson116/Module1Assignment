namespace Module1Assignment;

public abstract class Pet
{
    protected string Name;

    protected Pet(string name)
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