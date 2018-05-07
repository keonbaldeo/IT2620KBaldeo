Imports System.IO
Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        ComboBox1.SelectedIndex = -1

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NameFirst As String
        Dim NameMiddle As String
        Dim NameLast As String
        Dim Employee As Integer
        Dim Department As String
        Dim Telephone As Integer
        Dim Extension As Integer
        Dim Email As String
        Dim FileName As String
        Dim Fact As Boolean = True


    End Sub
End Class
