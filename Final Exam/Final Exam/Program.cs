using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Course course1 = new Course("CTS1851", "Internet Web Foundation");
        Course course2 = new Course("CGS2820", "Web Programming");
        Course course3 = new Course("CGS2821", "Advanced Web Programming");
        Course course4 = new Course("COP2361", "C# Programming");

        Dictionary<string, Course> courses = new Dictionary<string, Course>();

        courses.Add(course1.ID, course1);
        courses.Add(course2.ID, course2);
        courses.Add(course3.ID, course3);
        courses.Add(course4.ID, course4);

        foreach (var entry in courses)
        {
            Console.WriteLine($"Course ID: {entry.Key}, Course Name: {entry.Value.Name}");
        }
    }
}