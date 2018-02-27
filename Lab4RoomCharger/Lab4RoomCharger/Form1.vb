Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = Now.ToString("D")
        Label5.Text = Now.ToString("T")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim decNights As Decimal
        Dim decNightlyCharge As Decimal
        Dim decRoomCharges As Decimal
        Dim decAdditionalCharges As Decimal
        Dim decSubTotal As Decimal
        Dim decTotalCharge As Decimal


        Const decTax As Decimal = 0.08


        decNightlyCharge = CDec(TextBox14.Text)
        decNights = CDec(TextBox13.Text)
        decRoomCharges = decNightlyCharge * decNights
        Label16.Text = decRoomCharges.ToString("C")

        decAdditionalCharges = CDec(TextBox15.Text) + CDec(TextBox16.Text) + CDec(TextBox17.Text)
        Label17.Text = decAdditionalCharges.ToString("C")

        decSubTotal = decAdditionalCharges + decRoomCharges
        Label18.Text = decSubTotal.ToString("C")

        Label19.Text = decSubTotal * decTax
        Label19.Text = decTax.ToString("C")

        decTotalCharge = decSubTotal + decTax
        Label20.Text = decTotalCharge.ToString("C")



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox13.Clear()
        TextBox14.Clear()
        TextBox15.Clear()
        TextBox16.Clear()
        TextBox17.Clear()

        Label16.Text = ""
        Label17.Text = ""
        Label18.Text = ""
        Label19.Text = ""
        Label20.Text = ""


    End Sub
End Class
