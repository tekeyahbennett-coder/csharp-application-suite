public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int YearsToWork { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    public void YTK()
    {
        YearsToWork = 65 - Age;
        if (YearsToWork < 0)
        { YearsToWork = 0; }
    }
}

