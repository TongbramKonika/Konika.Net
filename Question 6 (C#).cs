using System;

public class Person
{
    public void Identify()
    {
        Console.WriteLine("I am a person.");
    }
}

// Class MyFriend inherits from Person (Single Inheritance)
public class MyFriend : Person
{
    public void Speak()
    {
        Console.WriteLine("My friend can speak.");
    }

    public void Eat()
    {
        Console.WriteLine("My friend can eat.");
    }
}

// Class Me inherits from MyFriend (Single Inheritance)
public class Me : MyFriend
{
    // Hiding the Speak method in MyFriend using 'new' keyword
    public new void Speak()
    {
        Console.WriteLine("I can speak.");
    }

    // Hiding the Eat method in MyFriend using 'new' keyword
    public new void Eat()
    {
        Console.WriteLine("I can eat.");
    }

    public void Run()
    {
        Console.WriteLine("But only I can run.");
    }
}

class Program
{
    public static void Main()
    {
        MyFriend obj1 = new MyFriend();
        obj1.Identify();  // From Person class
        obj1.Speak();     // From MyFriend class
        obj1.Eat();       // From MyFriend class

        Me obj2 = new Me();
        obj2.Identify();  // From Person class
        obj2.Speak();     // From Me class (hides MyFriend's Speak method)
        obj2.Eat();       // From Me class (hides MyFriend's Eat method)
        obj2.Run();       // Unique to Me class

        Console.ReadLine();
    }
}
