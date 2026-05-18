public class HighSchoolStudent : Student, IMathClass
{
    public HighSchoolStudent(string firstName, string lastName, string studentID)
        : base(firstName, lastName, studentID)
    {
    }
    public override string ImportantThing()
    {
        return "SAT exam.";
    }
    public string Math()
    {
        return "Basic Algebra.";
    }
    public override string ToString()
    {
        return $"HighSchoolStudent: {FirstName} {LastName} (ID: {StudentID}), Important: {ImportantThing()}, Math: {Math()}";
    }
}