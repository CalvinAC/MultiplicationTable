'Calvin Coxen
'RCET0265
'Fall 2020
'Multiplication Table



Module MultiplicationTable


    Sub Main()
        Dim userInput As Integer
        Dim row As Integer
        Dim column As Integer
        Dim table(12, 12) As Integer

        Console.WriteLine("please enter a number")
        Console.ReadLine()
        Console.WriteLine("you entered " & userInput)

        For row = 1 To userInput
            For column = 1 To userInput

                table(row, column) = row * column
                Console.WriteLine(table(row, column) & "  ")
            Next
            Console.WriteLine()
        Next
        Console.ReadLine()
    End Sub


End Module
