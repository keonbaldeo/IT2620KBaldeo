Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim StepOne As String

        Try


            StepOne = TextBox1.Text
            If (StepOne.Length < 6) Then
                MessageBox.Show("Password must be at least 6 characters long")
            End If
            If IsNumeric(TextBox1.Text) Then
                MessageBox.Show("ok")
            End If

        Catch ex As Exception
            MessageBox.Show("Crash")
        End Try





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class
