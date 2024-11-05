Imports System
Imports System.Collections

Module Module1
    Sub Main()
        ' ArrayList Example
        Dim arrayList As New ArrayList()

        ' Adding elements
        arrayList.Add("Apple")
        arrayList.Add("Banana")
        arrayList.Add("Cherry")

        ' Displaying elements in ArrayList
        Console.WriteLine("ArrayList contents:")
        For Each item In arrayList
            Console.WriteLine(item)
        Next

        ' Dictionary Example
        Dim dictionary As New Dictionary(Of String, Integer)()

        ' Adding elements
        dictionary.Add("Apple", 1)
        dictionary.Add("Banana", 2)
        dictionary.Add("Cherry", 3)

        ' Displaying elements in Dictionary
        Console.WriteLine(vbLf & "Dictionary contents:")
        For Each kvp In dictionary
            Console.WriteLine($"{kvp.Key}: {kvp.Value}")
        Next

        ' Retrieving a value
        Console.WriteLine(vbLf & $"Value for 'Banana': {dictionary("Banana")}")
    End Sub
End Module
