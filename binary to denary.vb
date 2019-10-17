Module Module1

    Sub Main()
        Dim BinaryNumber As String
        Dim counter As Integer
        Dim ValidBinaryNumber As Boolean
        Dim nextchar As String
        Dim string1 As String
        Dim denrynumber As String
        Dim string2 As String
        Dim num1 As Integer

        num1 = 0
        string2 = ""
        denrynumber = 0
        nextchar = ""
        string1 = ""
        BinaryNumber = ""
        counter = 0
        ValidBinaryNumber = True

        Console.WriteLine("enter binary number: ")
        BinaryNumber = Console.ReadLine

        If Len(BinaryNumber) <= 8 Then
        End If
        For counter = 1 To Len(BinaryNumber)
            nextchar = Mid(BinaryNumber, counter, 1)
            If nextchar <> 1 And nextchar <> 0 Then
                ValidBinaryNumber = False
            End If

        Next
        If ValidBinaryNumber = False Then
            Console.WriteLine("not a valid binary number ")
            Console.ReadKey()
        End If
        If ValidBinaryNumber = True Then

        End If
        For counter = 1 To Len(BinaryNumber)
            string2 = Mid(BinaryNumber, counter, 1) & string2
        Next
        For counter = 1 To Len(string2)
            nextchar = Mid(string2, counter, 1)
            num1 = 0
            If nextchar = "1" Then
                num1 = 1

            End If



            If counter = 1 Then
                denrynumber = denrynumber + num1 * 2 ^ 0
            End If

            If counter = 2 Then
                denrynumber = denrynumber + num1 * 2 ^ 1
            End If

            If counter = 3 Then
                denrynumber = denrynumber + num1 * 2 ^ 2
            End If

            If counter = 4 Then
                denrynumber = denrynumber + num1 * 2 ^ 3
            End If

            If counter = 5 Then
                denrynumber = denrynumber + num1 * 2 ^ 4
            End If

            If counter = 6 Then
                denrynumber = denrynumber + num1 * 2 ^ 5
            End If

            If counter = 7 Then
                denrynumber = denrynumber + num1 * 2 ^ 6
            End If

            If counter = 8 Then
                denrynumber = denrynumber + num1 * 2 ^ 7
            End If
        Next

        Console.WriteLine(BinaryNumber & " = " & denrynumber)
        Console.ReadKey()
    End Sub

End Module