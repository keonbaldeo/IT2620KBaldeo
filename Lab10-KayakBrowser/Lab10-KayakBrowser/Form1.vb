Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex = 0 Then
            Label2.Text = "This is a good Kayak for beginners, which is easy to use and usually inexpensive. It is usually not built for speed, but it is stable."
        End If

        If ListBox1.SelectedIndex = 1 Then
            Label2.Text = "This is an excellent Kayak for experts. The level of difficulty is moderately high but it is very capable of reaching high speeds."
        End If

        If ListBox1.SelectedIndex = 2 Then
            Label2.Text = " This is the perfect Kayak for people who are familiar with the sport. It is fairly easy to use."
        End If

        If ListBox1.SelectedIndex = 3 Then
            Label2.Text = "This is a meduim difficulty Kayak. It takes some skill to use but is very rewarding in the end."
        End If

        If ListBox1.SelectedIndex = 4 Then
            Label2.Text = "Pro Kayak-ers only! Dangerous but fun Kayaking experience."
        End If
    End Sub
End Class
