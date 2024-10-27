namespace Module1Assignment;

public class Teacher : Person, ITalkable
{
    private int _age;

    public Teacher(string name, int age) : base(name)
    {
        this._age = age;
    }

    public int GetAge()
    {
        return _age;
    }

    public void SetAge(int age)
    {
        this._age = age;
    }
    
    public string Talk()
    {
        return "Don't forget to do the assigned reading!";
    }

    public override string ToString()
    {
        return "Teacher: " + "name=" + Name + " age=" + _age;
    }
}