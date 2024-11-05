Module Module1

    Public Class Person
        Private name As String
        Private age As Integer

        ' Default constructor
        Public Sub New()
            name = "Unknown"
            age = 0
            Console.WriteLine("Default constructor called.")
        End Sub

        ' Parameterized constructor
        Public Sub New(personName As String, personAge As Integer)
            name = personName
            age = personAge
            Console.WriteLine("Parameterized constructor called.")
        End Sub

        Public Sub DisplayInfo()
            Console.WriteLine($"Name: {name}, Age: {age}")
        End Sub
    End Class

    Sub Main()
        ' Using the default constructor
        Dim person1 As New Person() ' Default constructor is used
        person1.DisplayInfo() ' Displays: Name: Unknown, Age: 0

        ' Using the parameterized constructor
        Dim person2 As New Person("John", 30) ' Parameterized constructor is used
        person2.DisplayInfo() ' Displays: Name: John, Age: 30

        Console.ReadLine() ' Keeps the console open until Enter is pressed
    End Sub

End Module
