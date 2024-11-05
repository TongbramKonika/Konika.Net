Imports System

Namespace InterfaceExample

    ' Define the first interface
    Public Interface IMovable
        Sub Move()
    End Interface

    ' Define the second interface
    Public Interface IRechargeable
        Sub Recharge()
    End Interface

    ' Implementing both interfaces in a class
    Public Class Robot
        Implements IMovable, IRechargeable

        ' Implement the Move method from IMovable
        Public Sub Move() Implements IMovable.Move
            Console.WriteLine("The robot is moving.")
        End Sub

        ' Implement the Recharge method from IRechargeable
        Public Sub Recharge() Implements IRechargeable.Recharge
            Console.WriteLine("The robot is recharging.")
        End Sub
    End Class

    Module Program
        Sub Main()
            Dim robot As New Robot()

            ' Calling methods from both interfaces
            robot.Move()       ' From IMovable
            robot.Recharge()   ' From IRechargeable
        End Sub
    End Module
End Namespace
