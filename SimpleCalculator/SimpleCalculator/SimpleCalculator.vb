'Justin Bell
'RCET0256
'Fall2024
'SimpleCalculator
'
Option Explicit On
Option Strict On
Module SimpleCalculator

    Sub Main()

        'specifing variables
        Dim firstnumber As Integer
        Dim secondnumber As Integer
        Dim userinput As String
        Dim [select] As String

        'where the user inputs the two numbers they wish to manipulate
        Console.WriteLine("Enter a Whole Number:")
        userinput = Console.ReadLine()
        firstnumber = CInt(userinput)
        Console.WriteLine("Enter Second Whole Number:")
        userinput = Console.ReadLine()
        secondnumber = CInt(userinput)

        'user selects mathmatical operation
        Console.WriteLine("Please Select Opteration:")
        Console.WriteLine("1. Addition")
        Console.WriteLine("2. Multiplication")
        [select] = Console.ReadLine()

        'mathmatical operation is carried out
        If [select] = "1" Then
            Console.WriteLine($"{firstnumber} + {secondnumber} = {firstnumber + secondnumber}")
        ElseIf [select] = "2" Then
            Console.WriteLine($"{firstnumber} * {secondnumber} = {firstnumber * secondnumber}")
        End If

        Console.ReadLine()

    End Sub

End Module
