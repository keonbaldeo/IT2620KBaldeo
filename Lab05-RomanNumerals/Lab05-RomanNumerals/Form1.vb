Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intEnglish As Integer
        intEnglish = CInt(TextBox1.Text)

        If (intEnglish < 1 Or intEnglish > 10) Then
            Label3.Text = "incorrect input follow directions"
        End If

        If (intEnglish = 1) Then
            Label3.Text = "I"
        End If

        If (intEnglish = 2) Then
            Label3.Text = "II"
        End If

        If (intEnglish = 3) Then
            Label3.Text = "III"
        End If

        If (intEnglish = 4) Then
            Label3.Text = "IV"
        End If

        If (intEnglish = 5) Then
            Label3.Text = "V"
        End If

        If (intEnglish = 6) Then
            Label3.Text = "VI"
        End If

        If (intEnglish = 7) Then
            Label3.Text = "VII"
        End If

        If (intEnglish = 8) Then
            Label3.Text = "VIII"
        End If

        If (intEnglish = 9) Then
            Label3.Text = "IX"
        End If

        If (intEnglish = 10) Then
            Label3.Text = "X"
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
