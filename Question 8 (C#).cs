using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // ArrayList Example
        ArrayList arrayList = new ArrayList();

        // Adding elements
        arrayList.Add("Apple");
        arrayList.Add("Banana");
        arrayList.Add("Cherry");

        // Displaying elements in ArrayList
        Console.WriteLine("ArrayList contents:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

        // Dictionary Example
        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        // Adding elements
        dictionary.Add("Apple", 1);
        dictionary.Add("Banana", 2);
        dictionary.Add("Cherry", 3);

        // Displaying elements in Dictionary
        Console.WriteLine("\nDictionary contents:");
        foreach (var kvp in dictionary)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }

        // Retrieving a value
        Console.WriteLine($"\nValue for 'Banana': {dictionary["Banana"]}");
    }
}
