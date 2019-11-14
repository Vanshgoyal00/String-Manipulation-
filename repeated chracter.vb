Module Module1

    Sub Main()
        Dim str1 As String
        Dim nextchar As String
        Dim counter As Integer
        Dim mostrepeatchar As String
        Dim previuoschar As Integer
        Dim presentchar As Integer
      
        presentchar = 0
        previuoschar = 0
        str1 = ""
        nextchar = ""
        counter = 0
        mostrepeatchar = ""

        Console.WriteLine("Enter string:")
        str1 = Console.ReadLine

        If str1 <> "" Then
            For counter = 1 To Len(str1)

                nextchar = Mid(str1, counter, 1)
                presentchar = InStr(str1, nextchar)
                presentchar = presentchar + 1

                If presentchar > previuoschar Then
                    mostrepeatchar = nextchar
                End If
                previuoschar = presentchar
                presentchar = 0
            Next
            If mostrepeatchar = "" Then
                Console.WriteLine("there is no repeatation of character")
            End If
            If mostrepeatchar <> "" Then
                Console.WriteLine("most repeated char is : " & mostrepeatchar)
            End If
        Else
            Console.WriteLine("Enter A Valid String")
        End If
                Console.ReadKey()
    End Sub

End Module
