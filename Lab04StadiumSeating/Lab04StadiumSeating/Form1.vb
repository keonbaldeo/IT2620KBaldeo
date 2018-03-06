Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim decClassA As Decimal
        decClassA = CDec(TextBox1.Text)
        Label7.Text = decClassA * 15

        Dim decClassB As Decimal
        decClassB = CDec(TextBox2.Text)
        Label8.Text = decClassB * 12

        Dim decClassC As Decimal
        decClassC = CDec(TextBox3.Text)
        Label9.Text = decClassC * 9

        Label11.Text = decClassA + decClassB + decClassC



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()

        Label7.Text = ""
        Label8.Text = ""
        Label9.Text = ""



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub
End Class
