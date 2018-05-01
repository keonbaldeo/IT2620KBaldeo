Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim wholesale As String
        Dim Percent As String

        Dim Retail As Integer

        Try

            wholesale = TextBox1.Text
            Percent = TextBox2.Text

            Retail = CalculateRetail(CInt(wholesale), CInt(Percent))

            Label4.Text = "$" + Retail.ToString


            If (TextBox1.Text < 0) Then
                MessageBox.Show("Positive Numbers Only")
            End If


        Catch ex As Exception
            MessageBox.Show("Numeric Values Only")
        End Try



    End Sub
    Function CalculateRetail(ByVal wholesale As Integer, ByVal Percent As Integer)
        Dim Retail As Decimal


        Retail = wholesale + (Percent / 100 * wholesale)
        Return Retail

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
