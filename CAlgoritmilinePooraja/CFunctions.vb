Public Class CFunctions
    Implements IFunctions
    Private Function ReverseStringFunction(ByVal input As String) Implements IFunctions.ReverseStringFunction
        Dim inputLen As Integer
        Dim output As String
        Dim counter As Integer
        output = ""
        inputLen = input.Length
        counter = inputLen - 1
        Do While (counter >= 0)
            output = output + input.Chars(counter)
            counter = counter - 1
        Loop
        Return output
    End Function

    Private Sub ReverseStringProcedure(ByRef input As String) Implements IFunctions.ReverseStringProcedure
        Dim inputLen As Integer
        Dim output As String
        Dim counter As Integer
        output = ""
        inputLen = input.Length
        counter = inputLen - 1
        Do While (counter >= 0)
            output = output + input.Chars(counter)
            counter = counter - 1
        Loop
        input = output
    End Sub
End Class
