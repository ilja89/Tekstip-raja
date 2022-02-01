Public Class CAlgo
    Implements IAlgo
    Private Function ReverseStringFunctionAlgo(ByVal input As String) Implements IAlgo.ReverseStringFunctionAlgo
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

    Private Sub ReverseStringProcedureAlgo(ByRef input As String) Implements IAlgo.ReverseStringProcedureAlgo
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
