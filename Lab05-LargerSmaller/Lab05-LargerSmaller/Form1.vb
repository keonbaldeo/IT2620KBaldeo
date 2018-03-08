Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim InputA As Integer
        InputA = CInt(TextBox1.Text)

        Dim InputB As Integer
        InputB = CInt(TextBox2.Text)

        If (InputA > InputB) Then
            Label4.Text = "Value A is greater"
        End If

        If (InputB > InputA) Then
            Label4.Text = "Value B is greater"
        End If

        If (InputB = InputA) Then
            Label4.Text = "Number inputs Must be different"
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
