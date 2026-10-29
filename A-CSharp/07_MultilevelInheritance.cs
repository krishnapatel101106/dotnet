using System;

class Person
{
    public void Eat() => Console.WriteLine("Person can eat.");
}
class Student : Person
{
    public void Study() => Console.WriteLine("Student can study.");
}
class GraduateStudent : Student
{
    public void Research() => Console.WriteLine("Graduate student can research.");
}
class Program
{
    static void Main()
    {
        GraduateStudent g = new GraduateStudent();
        g.Eat();
        g.Study();
        g.Research();
    }
}
