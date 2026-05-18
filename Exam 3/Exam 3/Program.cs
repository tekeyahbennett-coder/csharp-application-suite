using System;

class Program
{
    static void Main (string[] args)
    {
        Student[] students = new Student[4];

        students[0] = new ElementarySchoolStudent("Empryss", "Stewart", "15000223");
        students[1] = new MiddleSchoolStudent("Indira", "Young", "21338799");
        students[2] = new HighSchoolStudent("Charlie", "Mack", "97620143");
        students[3] = new CollegeStudent("Deion", "Hunter", "63451097");

        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine(students[i]);
        }
    }
}
