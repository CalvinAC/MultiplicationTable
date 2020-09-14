'Calvin Coxen
'RCET0265
'Fall 2020
'Multiplication Table

Option Explicit On
Option Strict On
Option Compare Text

Module MultiplicationTable


    Sub Main()
        Dim userInput As String
        Dim row As Integer
        Dim column As Integer
        Dim table(12, 12) As Double
        Dim userNum As Integer
        Dim goodData As Boolean

        Do

            Console.WriteLine("Please enter a number for the Multiplication table, or select N to quit.")

            Try

                userInput = Console.ReadLine()
                userNum = CInt(userInput)

                If userNum > 0 And userNum < 13 Then
                    goodData = True

                ElseIf userNum > 12 Or userNum < 0 Then
                    Console.WriteLine("That is not between 1 and 12, please try again")
                    Console.ReadLine()
                    Console.Clear()
                End If

            Catch ex As Exception
                If userInput = "n" Then
                    Exit Sub
                End If

            End Try

        Loop Until goodData = True

        Console.WriteLine("Enjoy your  " & userNum & " X " & userNum & " Multiplication Table:")

        For column = 1 To userNum

            For row = 1 To userNum

                table(row, column) = row * column
                Console.WriteLine(table(row, column) & "  ")

            Next
            Console.WriteLine()
        Next
        Console.ReadLine()
    End Sub


End Module
