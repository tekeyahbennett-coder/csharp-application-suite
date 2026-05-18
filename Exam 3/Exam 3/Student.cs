public abstract class Student
{
    private string firstName;
    private string lastName;
    private string studentID;
    public Student(string firstName, string lastName, string studentID)
    {
       this.firstName = firstName;
       this.lastName = lastName;   
       this.studentID = studentID;
    }
    public string FirstName
    {
        get { return firstName; }
    }
    public string LastName
    {
        get { return lastName; }
    }
    public string StudentID
    {
        get { return studentID; }
    }
    public abstract string ImportantThing();
}
