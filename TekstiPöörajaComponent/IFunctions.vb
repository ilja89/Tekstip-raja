Public Interface IFunctions
    Property StringText() As String
    Function ReverseStringFunction()
    Sub ReverseStringProcedure(ByRef input As String)
    Function VowelsCount(ByVal input As String)
End Interface