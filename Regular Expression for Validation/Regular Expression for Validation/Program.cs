using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)

    {
        string namePattern = @"\b[a-zA-Z]{2,15}\s[a-zA-Z]{2,15}\b";
        string cardPattern = @"^[0-9]{12,19}$";
        string fullName = "";
        string cardNumber = "";

        while (true)
        {
            Console.Write("Enter your full name (First Last): ");
            fullName = Console.ReadLine();

            if (Regex.IsMatch(fullName, namePattern))
            {
                Console.WriteLine("Name format is valid.\n");
                break;
            }
            else
            {
                Console.WriteLine("Invalid name format. Please enter first and last name with only letter (2-15 characters each).\n");
            }
        }
        while (true)
        {
            Console.WriteLine("Enter your credit card number (12 to 19 digits): ");
            cardNumber = Console.ReadLine();

            if (Regex.IsMatch(cardNumber, cardPattern))
            {
                Console.WriteLine("Card number format is valid.\n");
                break;
            }
            else
            {
                Console.WriteLine("Invalid card number. Only digits are allowed, and length must be between 12 and 19 digits.\n");
            }
        }
            Console.WriteLine("Thank you! Your data has been verified.");
    }
}
