using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        List<string> infoList = new List<string>();

        Console.Write("Enter First Name: ");
        infoList.Add(Console.ReadLine());

        Console.Write("Enter Last Name: ");
        infoList.Add(Console.ReadLine());

        Console.Write("Enter Street Address: ");
        infoList.Add(Console.ReadLine());

        Console.Write("Enter City: ");
        infoList.Add(Console.ReadLine());

        Console.Write("Enter State: ");
        infoList.Add(Console.ReadLine());

        Console.Write("Enter Zip Code: ");
        infoList.Add(Console.ReadLine());

        var listInfo = infoList.Select(UppercaseWords).ToList();

        foreach (var info in listInfo)
        {
            Console.WriteLine(info);
        }
    }
    public static string UppercaseWords(string value)
    {
        char[] array = value.ToCharArray();

        if (array.Length >= 1)
        {
            if (char.IsLower(array[0]))
            {
                array[0] = char.ToUpper(array[0]);
            }
        }
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] == ' ')
            {
                if (char.IsLower(array[i]))
                {
                    array[i] = char.ToUpper(array[i]);
                }
            }
        }
        return new string(array);
    }
}
