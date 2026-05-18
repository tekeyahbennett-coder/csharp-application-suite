 public class CollegeStudent : Student, IMathClass
    {
        public CollegeStudent(string firstName, string lastName, string studentID)
            : base(firstName, lastName, studentID)
        {
        }
        public override string ImportantThing()
        {
            return "Major.";
        }
        public string Math()
        {
            return "Advanced Algebra.";
        }
        public override string ToString()
        {
            return $"CollegeStudent: {FirstName} {LastName} (ID: {StudentID}), Important: {ImportantThing()}, Math: {Math()}";
        }
    }
