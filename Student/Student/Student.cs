using System;

public class Student
{
    public static int Count = 0;

    private static readonly Random rnd = new Random();
    private string firstName;
    private string lastName;
    private int sID;

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public int StudentID
    {
        get { return sID; }
        set { sID = value; }
    }

    public Student(string first, string last, int id)
    {
        this.firstName = first;
        this.lastName = last;
        this.sID = id;
        Count++;
    }

    public Student(string first = "", string last = "")
    {
        this.firstName = first;
        this.lastName = last;
        this.sID = rnd.Next(1000, 9999);
        Count++;
    }

    public override string ToString()
    {
        return $"Name: {firstName} {lastName}, ID: {sID}";
    }
}
