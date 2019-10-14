Module Module1

    Sub Main()
        Dim str1 As String
        Dim char1 As String
        Dim finalstr As String
        Dim nextchar As String
        Dim counter As Integer

        str1 = ""
        char1 = ""
        finalstr = ""
        nextchar = ""
        counter = 0

        Console.WriteLine(" enter string: ")
        str1 = Console.ReadLine

        Console.WriteLine("enter character to remove: ")
        char1 = Console.ReadLine

        For counter = 1 To Len(str1)
            nextchar = Mid(str1, counter, 1)
            If nextchar <> char1 Then
                finalstr = finalstr & nextchar
            End If
        Next
        Console.WriteLine("final string  = " & finalstr)
        Console.ReadKey()





    End Sub

End Module
