

' Jonathan Cales
' 10/30/2023
' Ch4WaterBillCalculator
' The program will take user input and adequately produce an output reading a consumers water bill.


' Option Strict is implemented.
Option Strict On

Imports System.Drawing.Imaging

Public Class Form1

    ' Defines the constant that is the cost of water per gallon.
    Const PricePerGallon As Decimal = 0.00175D

    Private Sub CalcButton_Click(sender As Object, e As EventArgs) Handles CalcButton.Click

        ' Try-catch blocks implemented

        Try

            ' Calculations will be conducted upon event and stored as variables.
            Dim GallonsUsed As Integer = CInt(CurrentTextBox.Text) - CInt(PreviousTextBox.Text)
            Dim TotalCharge As Decimal = CDec(PricePerGallon) * CDec(GallonsUsed)


            ' Data will only be displayed and converted to strings provided the readings are appropriate (no negative outputs).
            If CInt(PreviousTextBox.Text) > CInt(CurrentTextBox.Text) Then
                MessageBox.Show("Your previous reading cannot exceed your current reading.")
                CurrentTextBox.Text = ""
                PreviousTextBox.Text = ""
                CurrentTextBox.Focus()
                GallonsUsed = 0
                TotalCharge = 0
            Else
                GalUsedLabel.Text = GallonsUsed.ToString()
                ChargeLabel.Text = TotalCharge.ToString("C")
            End If


            ' Exception outcomes if raised.

        Catch mathError As ArithmeticException
            MessageBox.Show("There was an issue with preforming math calculations. Please ensure all inputs are rational numbers.")

        Catch conversionError As InvalidCastException
            MessageBox.Show("We have detected some of your inputs are not numeric. Please double check your inputs.")

        Catch otherError As Exception
            MessageBox.Show("Please contact a system administrator. Error code: " + otherError.ToString())

        End Try
    End Sub

    ' Clears all data being displayed, re-focuses the user.
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        GalUsedLabel.Text = ""
        ChargeLabel.Text = ""
        CurrentTextBox.Text = ""
        PreviousTextBox.Text = ""
        CurrentTextBox.Focus()
    End Sub

    ' Closes the program
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Close()
    End Sub

End Class
