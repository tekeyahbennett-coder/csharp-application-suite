public class C1 : IMyInterface
{
    private double loanAmount = 0.0;
    private double years = 0.0;
    private double interests = 0.0;
    private double interestRate = 0.0;

    public double LoanAmount
    {
        get { return loanAmount; }
        set
        {
            if (value >= 0)
                loanAmount = value;
            else
                throw new ArgumentOutOfRangeException("Loan Amount", "Loan amount must be non-negative.");
        }
    }
    public double Years
    {
        get { return years; }
        set
        {
            if (value > 0)
                years = value;
            else
                throw new ArgumentOutOfRangeException("Years", "Years must be greater than zero.");
        }
    }
    public double Interests
    {
        get { return interests; }
        set { interests = value; }
    }
    public double InterestRate
    {
        get { return interestRate; }
        set {
            if (value >= 0 && value <= 1)
                interestRate = value;
            else
                throw new ArgumentOutOfRangeException("Interest Rate", "Interest rate must be between 0 and 1.");
            }
    }
    public C1(double loanAmount, double years, double interestRate)
    {
        LoanAmount = loanAmount;
        Years = years;
        InterestRate = interestRate; 
    }
    public double PayInterests()
    {
        Interests = LoanAmount * InterestRate * Years;
        return Interests;
    }
    public string iMessage()
    {
        return "Be ready!";
    }
}
