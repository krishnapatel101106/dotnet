using System;

// Single inheritance
class Animal { public void Eat() => Console.WriteLine("Animal eats."); }
class Dog : Animal { public void Bark() => Console.WriteLine("Dog barks."); }

// Multilevel inheritance
class Puppy : Dog { public void Weep() => Console.WriteLine("Puppy makes a sound."); }

// Hierarchical inheritance: Cat and Dog both derive from Animal.
class Cat : Animal { public void Meow() => Console.WriteLine("Cat meows."); }

class Program
{
    static void Main()
    {
        Dog d = new Dog(); d.Eat(); d.Bark();
        Puppy p = new Puppy(); p.Eat(); p.Bark(); p.Weep();
        Cat c = new Cat(); c.Eat(); c.Meow();
    }
}
