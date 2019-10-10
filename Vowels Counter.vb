Module Module1

    Sub Main()
        Dim str1 As String
        Dim NoOfVowel As Integer
        Dim vowel As String
        Dim count As Integer

        str1 = ""
        NoOfVowel = 0
        count = 0
        vowel = "AEIOU"

        Console.WriteLine("input string to be checked:")
        str1 = Console.ReadLine

        str1 = UCase(str1)

        For count = 1 To Len(str1)
            If InStr(vowel, Mid(str1, count, 1)) > 0 Then
                NoOfVowel = NoOfVowel + 1

            End If
        Next

        Console.WriteLine(NoOfVowel)
        Console.ReadKey()
    End Sub

End Module
