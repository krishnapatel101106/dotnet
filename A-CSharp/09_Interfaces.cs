using System;

interface IPrint { void Print(); }
interface IShow { void Show(); }

// C# supports multiple interface implementation, not multiple base classes.
class Demo : IPrint, IShow
{
    public void Print() => Console.WriteLine("Print method implemented.");
    public void Show() => Console.WriteLine("Show method implemented.");
}

class Program
{
    static void Main()
    {
        Demo demo = new Demo();
        demo.Print();
        demo.Show();
    }
}
