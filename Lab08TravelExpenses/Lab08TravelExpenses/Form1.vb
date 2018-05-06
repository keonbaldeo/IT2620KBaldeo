Public Class Form1
    Function CalcMeals(ByVal Days As Integer)
        Dim Reimbursed As Integer
        Reimbursed = Days * 37
        Return Reimbursed
    End Function

    Function CalcMileage(ByVal Miles As Integer)
        Dim Reimbursed As Decimal
        Reimbursed = Miles * 0.27
        Return Reimbursed
    End Function

    Function CalcParking(ByVal Days As Integer)
        Dim Reimbursed As Integer
        Reimbursed = Days * 10
        Return Reimbursed
    End Function

    Function CalcTaxi(ByVal Days As Integer)
        Dim Reimbursed As Decimal
        Reimbursed = Days * 20
        Return Reimbursed
    End Function

    Function CalcLodging(ByVal Days As Integer)
        Dim Reimbursed As Decimal
        Reimbursed = Days * 95
        Return Reimbursed
    End Function

    Function CalcPrivateVehicle(ByVal Miles As Integer)
        Dim Reimbursed As Decimal
        Reimbursed = Miles * 0.27
        Return Reimbursed
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Days As Integer
        Dim Miles As Decimal

        Dim ReimbursedMeals As Integer
        Dim ReimbursedMiles As Decimal
        Dim ReimbursedParking As Integer
        Dim ReimbursedLodging As Integer
        Dim ReimbursedPrivate As Decimal

        Dim CalcTotalReimbursement As Decimal
        Dim CalcUnallowed As Decimal
        Dim CalcSaved As Decimal

        Days = CInt(TextBox3.Text)
        ReimbursedMeals = CalcMeals(Days)

        Miles = CInt(TextBox7.Text)
        ReimbursedMiles = CalcMileage(Miles)

        ReimbursedParking = CalcParking(Days)

        ReimbursedLodging = CalcLodging(Days)

        ReimbursedPrivate = CalcPrivateVehicle(Miles)

        CalcTotalReimbursement = ReimbursedMeals + ReimbursedMiles + ReimbursedParking + ReimbursedLodging + ReimbursedPrivate

        Label12.Text = "$" & CalcTotalReimbursement.ToString

        CalcUnallowed = (TextBox5.Text / 37) + (TextBox8.Text / 10) + (TextBox9.Text / 20) + (TextBox2.Text / 95) + (TextBox7.Text / 0.27)

        Label15.Text = "$" & CalcUnallowed.ToString

        CalcSaved = CalcTotalReimbursement - CalcUnallowed

        Label17.Text = "$" & CalcSaved.ToString


    End Sub
End Class
