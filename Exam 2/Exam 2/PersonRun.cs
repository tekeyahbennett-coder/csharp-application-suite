using System;

public class PersonRun
{
    public static void Main(string[] args) 
    {
        Console.Write("Enter your name: ");
        string nameInput = Console.ReadLine();

        
        Person person = new Person(nameInput);

        Console.Write("Enter your age: ");
        person.Age = Convert.ToInt32(Console.ReadLine());

        person.YTK();

        Console.WriteLine($"You will work: {person.YearsToWork} years before you retire.");
    }
}
