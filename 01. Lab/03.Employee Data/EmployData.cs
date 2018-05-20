using System;

class EmployData
{
    static void Main()
    {
        //        Name: Ivan
        //Age: 24
        //Employee ID: 00001192
        //Salary: 1500.35

        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        int ID = int.Parse(Console.ReadLine());
        double solary = double.Parse(Console.ReadLine());

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Employee ID: {ID:d8}");
        Console.WriteLine($"Salary: {solary:f2}");





    }
}

