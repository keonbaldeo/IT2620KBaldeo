Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim y As New Random
        Dim a As New Random
        Dim middle As Integer
        Dim median As Double
        Dim length As Integer

        length = a.Next(5, 10)
        Dim x(length) As Integer

        For i = 0 To length - 1
            x(i) = y.Next(100)
            Label2.Text = Label2.Text + x(i).ToString() + ","
        Next

        Array.Sort(x)
        If x.Length Mod 2 = 0 Then
            middle = x.Length / 2
            median = (x(middle) + x(middle - 1)) / 2
            Label4.Text = median
        Else
            middle = x.Length / 2
            Label4.Text = x(middle)
        End If
    End Sub
End Class
