public class MiddleSchoolStudent : Student, IMathClass
{
    public MiddleSchoolStudent(string firstName, string lastName, string studentID)
        : base(firstName, lastName, studentID)
    {
    }
    public override string ImportantThing()
    {
        return "Summer Camp!";
    }
    public string Math()
    {
        return "Geometry.";
    }
    public override string ToString()
    {
        return $"MiddleSchoolStudent: {FirstName} {LastName} (ID: {StudentID}), Important: {ImportantThing()}, Math: {Math()}";
    }
}
