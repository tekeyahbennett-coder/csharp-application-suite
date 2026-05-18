public class Campus : DSC
{
    private string campusName;
    public string CampusName
    {
        get { return campusName; }
        set { campusName = value; }
    }
    public Campus(string cName)
    {
        campusName = cName;
    }
        public override string ShowAddress()

    { return "1770 Williamson Blvd., Daytona Beach, Florida 32117"; }

    public string Departments()

    { return "Computer Science Department, Emergency Care Department, Police Academy"; }

    public override string ToString()
    {
        return $"{SchoolName} {CampusName} \n" +
            $"is located at {ShowAddress()}, \n" +
            $"it has {Departments()}";
    }
}
