Module PromptUser
    Sub Main()
        PromptUser("Hello user")

        For i = 0 To 5
            StoreMessages("Hello" & vbNewLine) 'makes a new line after the string
        Next
        PromptUser(StoreMessages(""))
        Console.Read()
    End Sub

    Sub PromptUser(message As String)
        Console.WriteLine(message)
    End Sub

    Function StoreMessages(message As String) As String
        Static storedMessages As String 'static extends the lifetime of the string
        storedMessages &= message

        Return storedMessages
    End Function

End Module
