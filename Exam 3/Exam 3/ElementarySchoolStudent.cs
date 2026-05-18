public class ElementarySchoolStudent : Student, IMathClass
{
    public ElementarySchoolStudent(string firstName, string lastName, string studentID)
        : base(firstName, lastName, studentID)
    {
    }
    public override string ImportantThing()
    {
        return "Farm field trip!";
    }
    public string Math()
    {
        return "Basic Math.";
    }
    public override string ToString()
    {
        return $"ElementarySchoolStudent: {FirstName} {LastName} (ID: {StudentID}), Important: {ImportantThing()}, Math: {Math()}";
    }
}
