public class DSC
{
    private string schoolName = "Daytona State College";
    public string SchoolName
    {
        get { return schoolName; }
        set { schoolName = value; }
    }

    public virtual string ShowAddress()
    { return "1200 W. International Speedway Blvd., Daytona Beach, Florida 32114"; }
}