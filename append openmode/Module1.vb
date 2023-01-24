Module Module1

    Sub Main()
        Dim name As String
        FileOpen(1, My.Application.Info.DirectoryPath & "\HighAchieversOfBSS.txt", OpenMode.Append)
        For x = 1 To 5
            Console.WriteLine("Enter Name: ")
            name = Console.ReadLine()
            WriteLine(1, name)
        Next
        FileClose()
    End Sub

End Module
