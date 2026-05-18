using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter loan amount: ");
        double loanAmount = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter number of years: ");
        double years = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter interest rate: ");
        double interestRate = Convert.ToDouble(Console.ReadLine());

        C1 loanObject = new C1(loanAmount, years, interestRate);

        double totalInterest = loanObject.PayInterests();
        Console.WriteLine($"Total Interest: ${totalInterest}");

        Console.WriteLine(loanObject.iMessage());
    }
}