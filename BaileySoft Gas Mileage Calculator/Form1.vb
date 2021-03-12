Public Class FrmMileageCalc
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim gallons, miles, mpg As Double

        gallons = txtGallons.Text
        miles = txtMiles.Text

        mpg = miles / gallons

        txtMPG.Text = Math.Round(mpg, 1)

    End Sub
End Class
