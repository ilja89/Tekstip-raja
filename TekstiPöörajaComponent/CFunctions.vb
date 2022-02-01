Public Class CFunctions
    Implements IFunctions
    Private InputText As String
    Private Property StringText() As String Implements IFunctions.StringText
        Get
            If (String.IsNullOrEmpty(StringText) = False) Then
                Return StringText
            Else
                Return ""
            End If
        End Get
        Set(ByVal value As String)
            InputText = value
        End Set
    End Property

    Private Function ReverseStringFunction() Implements IFunctions.ReverseStringFunction
        Dim inputLen As Integer
        Dim output As String
        Dim counter As Integer
        output = ""
        inputLen = InputText.Length
        counter = inputLen - 1
        Do While (counter >= 0)
            output = output + InputText.Chars(counter)
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

    Private Function isVowel(ByVal input As Char)
        Dim arr As String
        Dim counter As Integer
        arr = "aAeEiIuUyYoO"
        Do While (counter < arr.Length)
            If (arr.Chars(counter) = input) Then
                Return True
            End If
            counter = counter + 1
        Loop
        Return False
    End Function

    Private Function VowelsCount(ByVal input As String) Implements IFunctions.VowelsCount
        Dim len As Integer
        Dim vowels As Integer
        Dim counter As Integer
        counter = 0
        len = input.Length
        Do While (counter < len)
            If (isVowel(input.Chars(counter)) = True) Then
                vowels = vowels + 1
            End If
            counter = counter + 1
        Loop
        Return vowels
    End Function
End Class
