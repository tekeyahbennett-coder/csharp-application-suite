using System;

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();

        s1.FirstName = "John";
        s1.LastName = "Smith";
        s1.StudentID = 2560;

        Student s2 = new Student("Peter");
        Student s3 = new Student("Morgan", "Simmons");
        Student s4 = new Student("James", "Walters");
        Student s5 = new Student("Linda", "Scott", 1005);

        Console.WriteLine();

        Console.WriteLine("Total students: {0}", Student.Count);
        Console.WriteLine("Student 1: " + s1);
        Console.WriteLine("Student 2: " + s2);
        Console.WriteLine("Student 3: " + s3);
        Console.WriteLine("Student 4: " + s4);
        Console.WriteLine("Student 5: " + s5);

        Console.ReadLine();
    }
}

