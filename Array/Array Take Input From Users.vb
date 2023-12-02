Module Module1

    Sub Main()
        Dim array(7) As Integer
        Console.WriteLine("Enter your values:")
        For i As Integer = 0 To 7
            array(i) = Console.ReadLine

        Next
        For j As Integer = 0 To 7
            Console.WriteLine(array(j))


        Next
        Console.ReadLine()

    End Sub

End Module
