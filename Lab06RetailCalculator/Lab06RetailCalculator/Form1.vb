Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim wholesale As Integer
        Dim Percent As Decimal

        Try

            wholesale = TextBox1.Text
            Percent = (TextBox2.Text / 100) * TextBox1.Text
            Label4.Text = "$" & wholesale + Percent

            If (TextBox1.Text < 0) Then
                MessageBox.Show("Positive Numbers Only")
            End If


        Catch ex As Exception
            MessageBox.Show("Numeric Values Only")
        End Try



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
