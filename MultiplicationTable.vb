'Calvin Coxen
'RCET0265
'Fall 2020
'Multiplication Table
'https://github.com/CalvinAC/MultiplicationTable/blob/master/MultiplicationTable.vb

Option Explicit On
Option Strict On
Option Compare Text

Module MultiplicationTable


    Sub Main()
        'This code takes the users value and sets it to a variable that determines the values input into the 
        'multiplication table. 
        Dim userInput As String
        Dim row As Integer
        Dim column As Integer
        Dim table(12, 12) As Double
        Dim userNum As Integer
        Dim goodData As Boolean

        'A while loop that prompts user to enter a value for the table to display,
        'if it within the parameters of 1 to 12 it will exicute, otherwise
        'the user is asked to enter the correct values. Also allows the user
        'to quit the program.
        Do

            Console.WriteLine("Please enter a number for the Multiplication table, or select N to quit.")

            Try

                userInput = Console.ReadLine()
                userNum = CInt(userInput)

                If userNum > 0 And userNum < 13 Then
                    goodData = True

                ElseIf userNum > 12 Or userNum < 1 Then
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

        'Prints the text for the table uses the users input to create the table
        Console.WriteLine("Enjoy your  " & userNum & " X " & userNum & " Multiplication Table:")
        For column = 1 To userNum
            For row = 1 To userNum

                table(row, column) = row * column
                Console.Write(table(row, column) & vbTab)

            Next
            Console.WriteLine()
        Next
        Console.ReadLine()
    End Sub


End Module
