Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim userInput As String
        Dim intcount As Integer
        Dim sumcount As Integer

        Try
            userInput = InputBox("Enter a value", "Provide a value", "10")
            If (Integer.TryParse(userInput, intcount) = False) Then
                MessageBox.Show("Do not enter a string. Enter an integer")
            Else
                For i = 1 To intcount
                    sumcount = sumcount + i
                Next
                MessageBox.Show(sumcount)
            End If
        Catch ex As Exception
                MessageBox.Show("Error in your code")
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class

