using System;

public class Person
{
    private string name;
    private int age;

    // Default constructor
    public Person()
    {
        name = "Unknown";
        age = 0;
        Console.WriteLine("Default constructor called.");
    }

    // Parameterized constructor
    public Person(string personName, int personAge)
    {
        name = personName;
        age = personAge;
        Console.WriteLine("Parameterized constructor called.");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Using the default constructor
        Person person1 = new Person();
        person1.DisplayInfo();

        // Using the parameterized constructor
        Person person2 = new Person("John", 30);
        person2.DisplayInfo();

        Console.ReadLine();
    }
}
