<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.StartProcedureButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InputBox = New System.Windows.Forms.TextBox()
        Me.StartFunctionButton = New System.Windows.Forms.Button()
        Me.StopTimer = New System.Windows.Forms.Button()
        Me.StartTimer = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProcedureOutputBox = New System.Windows.Forms.RichTextBox()
        Me.FunctionOutputBox = New System.Windows.Forms.RichTextBox()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.TimerStateShow = New System.Windows.Forms.RadioButton()
        Me.InputBoxTextLen = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CAlgFunctionButton = New System.Windows.Forms.Button()
        Me.CAlgProcedureButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'StartProcedureButton
        '
        Me.StartProcedureButton.Location = New System.Drawing.Point(22, 99)
        Me.StartProcedureButton.Name = "StartProcedureButton"
        Me.StartProcedureButton.Size = New System.Drawing.Size(178, 34)
        Me.StartProcedureButton.TabIndex = 0
        Me.StartProcedureButton.Text = "Start Procedure"
        Me.StartProcedureButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(296, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Procedure Result"
        '
        'InputBox
        '
        Me.InputBox.Location = New System.Drawing.Point(300, 174)
        Me.InputBox.Name = "InputBox"
        Me.InputBox.Size = New System.Drawing.Size(262, 26)
        Me.InputBox.TabIndex = 3
        '
        'StartFunctionButton
        '
        Me.StartFunctionButton.Location = New System.Drawing.Point(22, 139)
        Me.StartFunctionButton.Name = "StartFunctionButton"
        Me.StartFunctionButton.Size = New System.Drawing.Size(178, 34)
        Me.StartFunctionButton.TabIndex = 4
        Me.StartFunctionButton.Text = "Start Function"
        Me.StartFunctionButton.UseVisualStyleBackColor = True
        '
        'StopTimer
        '
        Me.StopTimer.Location = New System.Drawing.Point(22, 352)
        Me.StopTimer.Name = "StopTimer"
        Me.StopTimer.Size = New System.Drawing.Size(178, 34)
        Me.StopTimer.TabIndex = 6
        Me.StopTimer.Text = "Stop Timer"
        Me.StopTimer.UseVisualStyleBackColor = True
        '
        'StartTimer
        '
        Me.StartTimer.Location = New System.Drawing.Point(22, 312)
        Me.StartTimer.Name = "StartTimer"
        Me.StartTimer.Size = New System.Drawing.Size(178, 34)
        Me.StartTimer.TabIndex = 5
        Me.StartTimer.Text = "Start Timer"
        Me.StartTimer.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(560, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Function Result"
        '
        'ProcedureOutputBox
        '
        Me.ProcedureOutputBox.Location = New System.Drawing.Point(300, 250)
        Me.ProcedureOutputBox.Name = "ProcedureOutputBox"
        Me.ProcedureOutputBox.Size = New System.Drawing.Size(262, 290)
        Me.ProcedureOutputBox.TabIndex = 9
        Me.ProcedureOutputBox.Text = ""
        '
        'FunctionOutputBox
        '
        Me.FunctionOutputBox.Location = New System.Drawing.Point(564, 250)
        Me.FunctionOutputBox.Name = "FunctionOutputBox"
        Me.FunctionOutputBox.Size = New System.Drawing.Size(262, 290)
        Me.FunctionOutputBox.TabIndex = 10
        Me.FunctionOutputBox.Text = ""
        '
        'Timer
        '
        Me.Timer.Interval = 5000
        '
        'TimerStateShow
        '
        Me.TimerStateShow.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.TimerStateShow.AutoCheck = False
        Me.TimerStateShow.AutoSize = True
        Me.TimerStateShow.Location = New System.Drawing.Point(22, 392)
        Me.TimerStateShow.Name = "TimerStateShow"
        Me.TimerStateShow.Size = New System.Drawing.Size(73, 24)
        Me.TimerStateShow.TabIndex = 11
        Me.TimerStateShow.TabStop = True
        Me.TimerStateShow.Text = "Timer"
        Me.TimerStateShow.UseVisualStyleBackColor = True
        '
        'InputBoxTextLen
        '
        Me.InputBoxTextLen.AutoSize = True
        Me.InputBoxTextLen.Location = New System.Drawing.Point(568, 177)
        Me.InputBoxTextLen.Name = "InputBoxTextLen"
        Me.InputBoxTextLen.Size = New System.Drawing.Size(18, 20)
        Me.InputBoxTextLen.TabIndex = 12
        Me.InputBoxTextLen.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = " CTekstiPooraja "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = " CAlgoritmilinePooraja"
        '
        'CAlgFunctionButton
        '
        Me.CAlgFunctionButton.Location = New System.Drawing.Point(22, 256)
        Me.CAlgFunctionButton.Name = "CAlgFunctionButton"
        Me.CAlgFunctionButton.Size = New System.Drawing.Size(178, 34)
        Me.CAlgFunctionButton.TabIndex = 15
        Me.CAlgFunctionButton.Text = "Start Function"
        Me.CAlgFunctionButton.UseVisualStyleBackColor = True
        '
        'CAlgProcedureButton
        '
        Me.CAlgProcedureButton.Location = New System.Drawing.Point(22, 216)
        Me.CAlgProcedureButton.Name = "CAlgProcedureButton"
        Me.CAlgProcedureButton.Size = New System.Drawing.Size(178, 34)
        Me.CAlgProcedureButton.TabIndex = 14
        Me.CAlgProcedureButton.Text = "Start Procedure"
        Me.CAlgProcedureButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 552)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CAlgFunctionButton)
        Me.Controls.Add(Me.CAlgProcedureButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.InputBoxTextLen)
        Me.Controls.Add(Me.TimerStateShow)
        Me.Controls.Add(Me.FunctionOutputBox)
        Me.Controls.Add(Me.ProcedureOutputBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StopTimer)
        Me.Controls.Add(Me.StartTimer)
        Me.Controls.Add(Me.StartFunctionButton)
        Me.Controls.Add(Me.InputBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StartProcedureButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartProcedureButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents InputBox As TextBox
    Friend WithEvents StartFunctionButton As Button
    Friend WithEvents StopTimer As Button
    Friend WithEvents StartTimer As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ProcedureOutputBox As RichTextBox
    Friend WithEvents FunctionOutputBox As RichTextBox
    Friend WithEvents Timer As Timer
    Friend WithEvents TimerStateShow As RadioButton
    Friend WithEvents InputBoxTextLen As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CAlgFunctionButton As Button
    Friend WithEvents CAlgProcedureButton As Button
End Class
