'displays summary data for all car rentals
Public Class SummaryForm

    ' Totals will be displayed on load.
    Private Sub SummaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GrandTotalMilesLabel.Text = CostCalculatorForm.TotalMileageOfVehicles.ToString()
        GrandTotalReceiptsLabel.Text = CostCalculatorForm.TotalRevenueMade.ToString("C")
        GrandTotalRentalsLabel.Text = CostCalculatorForm.TotalNumberOfRentals.ToString()
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Close()
    End Sub
End Class