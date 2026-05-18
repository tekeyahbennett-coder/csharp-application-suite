public class Course
{
    private string CID;
    private string CName;

    public string ID
    {
        get { return CID; }
        set { CID = value; }
    }

    public string Name
    {
        get { return CName; }
        set { CName = value; }
    }
    public Course(string courseID, string courseName)
    {
        CID = courseID;
        CName = courseName;
    }
}