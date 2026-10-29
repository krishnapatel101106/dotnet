using System;

class Person
{
    public string Name = "";
    public void ShowName() => Console.WriteLine($"Name: {Name}");
}

class Student : Person
{
    public int RollNo;
    public void ShowRollNo() => Console.WriteLine($"Roll No: {RollNo}");
}

class Program
{
    static void Main()
    {
        Student s = new Student { Name = "Asha", RollNo = 101 };
        s.ShowName();
        s.ShowRollNo();
    }
}
