Public Class Form1
    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PrintBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintBooksToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim item As String = "Empty"
        item = Form2.GroupBox1.Selectedindex

    End Sub
End Class
