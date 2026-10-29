using System;

class Student
{
    public int RollNo;
    public string Name;

    public Student() { RollNo = 0; Name = "Unknown"; }
    public Student(int rollNo, string name) { RollNo = rollNo; Name = name; }
    public Student(int rollNo) { RollNo = rollNo; Name = "Not provided"; }

    public void Display() => Console.WriteLine($"Roll No: {RollNo}, Name: {Name}");
}

class Program
{
    static void Main()
    {
        new Student().Display();
        new Student(12).Display();
        new Student(13, "Asha").Display();
    }
}
