Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim speed As Decimal
        Dim time As Decimal
        Dim distance As Decimal
        Dim sumtotal As Decimal
        Try

            speed = InputBox("In mph", "Input Speed")
            time = InputBox("In hours", "Time")

            distance = speed * time
            ListBox1.Items.Add("Vehicle Speed" & " " & speed & " " & "MPH")
            ListBox1.Items.Add("Time Traveled" & " " & time & " " & "Hours")

            ListBox1.Items.Add("Hours" & "   " & "Distance Traveled")
            ListBox1.Items.Add("_____________________________")


            For i = 1 To time
                sumtotal = sumtotal + speed
                ListBox1.Items.Add(i & "            " & sumtotal)

            Next

            ListBox1.Items.Add("Total Distance" & " " & distance)

        Catch ex As Exception
            MessageBox.Show("Numbers only")

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
