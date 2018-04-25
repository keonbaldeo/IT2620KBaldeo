Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        ListBox1.SelectedIndex = -1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Dim check1 As Integer
        Dim check2 As Integer
        Dim check3 As Integer

        Try

            If CheckBox1.Checked Then
                check1 = 895

                If CheckBox2.Checked Then
                    check2 = 30
                Else
                    check2 = 0
                End If

                If ListBox1.SelectedIndex = 0 Then
                    check3 = 295
                End If

                If ListBox1.SelectedIndex = 1 Then
                    check3 = 295
                End If

                If ListBox1.SelectedIndex = 2 Then
                    check3 = 395
                End If

                If ListBox1.SelectedIndex = 3 Then
                    check3 = 395
                End If

            Else
                MessageBox.Show("You must register in order to participate.")

            End If

            Form1.Label10.Text = "$" & check1 + check2 + check3

        Catch ex As Exception
            MessageBox.Show("Error")
        End Try

    End Sub
End Class