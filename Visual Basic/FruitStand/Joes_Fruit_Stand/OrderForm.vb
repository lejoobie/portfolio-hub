' Jonathan Cales
' 11/06/2023
' Ch4JoesFruitStand
' This program will properly represent a mock-up of a point-of-purchase for fruit and other goods related to Joe's.

' Option Strict convention is being followed:
Option Strict On

Public Class OrderForm
    ' Defining rates and constants.

    ' Discount offered to VIP members of Joe's.
    Const VIPDiscount As Decimal = 0.1D
    Dim DiscountQualification As DialogResult

    ' Price of fruit.
    Const Apples As Decimal = 1D
    Const Oranges As Decimal = 0.5D
    Const Pears As Decimal = 1.25D
    Const Bananas As Decimal = 0.25D

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click

        ' Exceptions net added.

        Try

            ' Data will be defined and calculations will be preformed.
            Dim TotalApplesPrice As Decimal = CInt(ApplesTextBox.Text) * Apples
            Dim TotalOrangesPrice As Decimal = CInt(OrangesTextBox.Text) * Oranges
            Dim TotalPearsPrice As Decimal = CInt(PearsTextBox.Text) * Pears
            Dim TotalBananasPrice As Decimal = CInt(BananasTextBox.Text) * Bananas


            Dim AmountPaid As Decimal = CDec(PaidTextBox.Text)
            Dim AmountDue As Decimal = TotalApplesPrice + TotalOrangesPrice + TotalPearsPrice + TotalBananasPrice

            ' Prompts the user to see if they are a VIP member to apply their discount.
            Dim DiscountQualification As DialogResult = MessageBox.Show("Are you a Joe's Fruit Stand VIP?", "VIP Member Welcome Page", MessageBoxButtons.YesNo)

            ' Displays the pre-discount subtotal.
            SubtotalLabel.Text = AmountDue.ToString("C")

            ' Will check to see if the user qualifies for the discount and will apply/display it.
            If DiscountQualification = DialogResult.Yes Then
                Dim DiscountAmount As Decimal = AmountDue * VIPDiscount
                AmountDue = AmountDue - DiscountAmount
                DiscountAmountLabel.Text = DiscountAmount.ToString("C")
            Else
                Dim DiscountAmount As Decimal = 0.0D
                AmountDue = AmountDue
                DiscountAmountLabel.Text = "$0.00"
            End If

            ' Calculates the change.
            Dim ChangeDue As Decimal = AmountPaid - AmountDue

            ' Ensures the program will not give improper change (negative change, or exact)
            If ChangeDue < 0 Then
                ChangeDue = 0.0D
            End If

            ' Display all other data for the user to see.
            TotalLabel.Text = AmountDue.ToString("C")
            PaidLabel.Text = AmountPaid.ToString("C")
            ChangeLabel.Text = ChangeDue.ToString("C")

        Catch mathError As ArithmeticException
            MessageBox.Show("Please ensure all your values are numeric for use in calculations." + vbNewLine + mathError.ToString())
        Catch conversionError As InvalidCastException
            MessageBox.Show("Please ensure all your values can be interpretted as an integer or decimal." + vbNewLine + conversionError.ToString())
        Catch otherError As Exception
            MessageBox.Show("Please contact a system administrator. The program will close when this message is closed." + vbNewLine + otherError.ToString())
        End Try

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ' Clears all data on screen.
        SubtotalLabel.Text = ""
        TotalLabel.Text = ""
        DiscountAmountLabel.Text = ""
        PaidLabel.Text = ""
        ChangeLabel.Text = ""
        PaidTextBox.Text = ""
        ApplesTextBox.Text = ""
        OrangesTextBox.Text = ""
        PearsTextBox.Text = ""
        BananasTextBox.Text = ""
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ' Closes the program
        Close()
    End Sub

End Class
