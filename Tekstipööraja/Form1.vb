Imports TekstiPöörajaComponent

Public Class Form1
    Private Sub StartProcedureButton_Click(sender As Object, e As EventArgs) Handles StartProcedureButton.Click
        Dim functionComponent As TekstiPöörajaComponent.IFunctions
        Dim temp As String
        functionComponent = New TekstiPöörajaComponent.CFunctions
        temp = InputBox.Text
        functionComponent.ReverseStringProcedure(temp)
        ProcedureOutputBox.Text = temp
    End Sub

    Private Sub StartFunctionButton_Click(sender As Object, e As EventArgs) Handles StartFunctionButton.Click
        Dim functionComponent As TekstiPöörajaComponent.IFunctions
        functionComponent = New TekstiPöörajaComponent.CFunctions
        functionComponent.StringText() = InputBox.Text
        FunctionOutputBox.Text = functionComponent.ReverseStringFunction()
    End Sub

    Private Sub StartTimer_Click(sender As Object, e As EventArgs) Handles StartTimer.Click
        TimerStateShow.Checked = True
        Timer.Enabled = True
    End Sub

    Private Sub StopTimer_Click(sender As Object, e As EventArgs) Handles StopTimer.Click
        TimerStateShow.Checked = False
        Timer.Enabled = False
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        StartProcedureButton_Click(sender, e)
        StartFunctionButton_Click(sender, e)
    End Sub

    Private Sub InputBox_TextChanged(sender As Object, e As EventArgs) Handles InputBox.TextChanged
        Dim functionComponent As TekstiPöörajaComponent.IFunctions
        functionComponent = New TekstiPöörajaComponent.CFunctions
        InputBoxTextLen.Text = InputBox.Text.Length
        InputBoxTextLen.Text = InputBoxTextLen.Text & "  " & functionComponent.VowelsCount(InputBox.Text)
    End Sub

    Private Sub CAlgProcedureButton_Click(sender As Object, e As EventArgs) Handles CAlgProcedureButton.Click
        Dim functionComponent As TekstiPöörajaComponent.IAlgo
        Dim temp As String
        functionComponent = New TekstiPöörajaComponent.CAlgo
        temp = InputBox.Text
        functionComponent.ReverseStringProcedureAlgo(temp)
        ProcedureOutputBox.Text = temp
    End Sub

    Private Sub CAlgFunctionButton_Click(sender As Object, e As EventArgs) Handles CAlgFunctionButton.Click
        Dim functionComponent As TekstiPöörajaComponent.IAlgo
        functionComponent = New TekstiPöörajaComponent.CAlgo
        FunctionOutputBox.Text = functionComponent.ReverseStringFunctionAlgo(InputBox.Text)
    End Sub
End Class
