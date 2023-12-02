Module Module1
    Sub Main()
        Dim num(5) As Integer
        Dim x(0 To 5) As Integer

        num(0) = 10
        num(1) = 450
        num(2) = 430
        num(3) = 430
        num(4) = 40
        num(5) = 50

        For i As Integer = 0 To 5
            Console.WriteLine(num(i))
        Next

        Console.ReadLine()
    End Sub

End Module
