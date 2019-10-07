Module Module1

    Sub Main()
        Dim Str1, Str2, Char1, Char2, NextChar As String
        Dim Counter As Integer

        Str1 = ""
        Str2 = ""
        Char1 = ""
        Char2 = ""
        NextChar = ""
        Counter = 0

        Console.WriteLine(" enter string ")
        Str1 = Console.ReadLine

        Console.WriteLine(" enter character to remove ")
        Char1 = Console.ReadLine

        Console.WriteLine(" enter charater to add ")
        Char2 = Console.ReadLine

        For Counter = 1 To Len(Str1)
            NextChar = Mid(Str1, Counter, 1)
            If NextChar <> Char1 Then
                Str2 = Str2 & NextChar
            Else
                If NextChar = Char1 Then
                    Str2 = Str2 & Char2
                End If
            End If
        Next
        Console.WriteLine(Str2)
        Console.ReadKey()
    End Sub

End Module
