
'Jonathan Cales
' 12/4/2023
' RhodesCarRentals
' This program will calculate and display car rental info for customers.
' This is a submission for the VB final exam.

' Option Strict is enforced and Input Output is importer
Option Strict On
Imports System.IO


Public Class CostCalculatorForm
    ' Constant hardcoded rates.
    Const COMPACT_RATE As Decimal = 45D
    Const MIDSIZE_RATE As Decimal = 50D
    Const PREMIUN_RATE As Decimal = 55D
    Const MINIVAN_RATE As Decimal = 60D
    Const SUV_RATE As Decimal = 65D
    Const MILEAGE_RATE As Decimal = 0.05D

    ' Accumulating totals.
    Friend TotalNumberOfRentals As Integer = 0
    Friend TotalMileageOfVehicles As Decimal = 0
    Friend TotalRevenueMade As Decimal = 0


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'do NOT comment these out or write to a file
        VehicleListBox.Items.Add("Compact - $45/day")
        VehicleListBox.Items.Add("Mid-Size - $50/day")
        VehicleListBox.Items.Add("Premium - $55/day")
        VehicleListBox.Items.Add("Minivan - $60/day")
        VehicleListBox.Items.Add("SUV - $65/day")

        Try
            'add code here to read file info and place data into correct variables
            'only ONE file is to be read - the file with the 3 totals)

            ' Defines the file to read.
            Dim FileToRead As String = "CarRentalInfo.txt"

            ' Checks to see if the file exists, then will attempt to open a stream that will read the file.
            If File.Exists(FileToRead) Then
                Dim Reader As StreamReader = File.OpenText(FileToRead)
                TotalMileageOfVehicles = CDec(Reader.ReadLine)
                TotalNumberOfRentals = CInt(Reader.ReadLine)
                TotalRevenueMade = CDec(Reader.ReadLine)
                Reader.Close()
            End If

        Catch fileNotFound As FileNotFoundException
            MessageBox.Show("File could not be found. Please contact a system administrator.", "File Not Found")
        Catch fileNotLoading As FileLoadException
            MessageBox.Show("File could not be loaded at runtime.. Please contact a system administrator.", "File Load Failure")
        End Try

    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        VehicleListBox.SelectedIndex = -1
        TotalMilesLabel.Text = ""
        CustomerChargeLabel.Text = ""
        DaysTextBox.Clear()
        BeginningTextBox.Clear()
        EndingTextBox.Clear()

    End Sub


    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        'show about window
        AboutForm.ShowDialog()
    End Sub

    Private Sub CostCalculatorForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'only ONE file is created here - the file with the 3 totals

        ' Defines the file to write.
        Dim FileToWrite As String = "CarRentalInfo.txt"

        ' Defines user input to be stored.
        Dim Answer As DialogResult
        Answer = MessageBox.Show("Would you like to save your work?", "Save All Changes?", MessageBoxButtons.YesNoCancel)

        If Answer = DialogResult.Yes Then
            ' Will open a write stream that will store the three totals.
            Dim Writer As New StreamWriter(FileToWrite)
            Writer.WriteLine(TotalMileageOfVehicles)
            Writer.WriteLine(TotalNumberOfRentals)
            Writer.WriteLine(TotalRevenueMade)
            ' Closes the stream.
            Writer.Close()
        End If

    End Sub

    Private Sub CalculateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculateToolStripMenuItem.Click

        Try

            ' Converts user input into numbers for calculations.
            Dim BeginningMileage As Decimal = CDec(BeginningTextBox.Text)
            Dim EndingMileage As Decimal = CDec(EndingTextBox.Text)
            Dim DaysRented As Integer = CInt(DaysTextBox.Text)

            ' Days given must be greater then 0.
            If CInt(DaysTextBox.Text) > 0 Then
                ' We cannot have negative mileage. Starting mileage great then the ending will not be accepted.
                If BeginningMileage < EndingMileage Then
                    ' A rate/vehicle must be selected.
                    If VehicleListBox.SelectedIndex <> -1 Then

                        Dim MilesDriven = EndingMileage - BeginningMileage
                        Dim DailyRate As Decimal

                        ' If Statements to decided the daily rate.
                        If VehicleListBox.SelectedIndex = 0 Then
                            DailyRate = COMPACT_RATE
                        End If
                        If VehicleListBox.SelectedIndex = 1 Then
                            DailyRate = MIDSIZE_RATE
                        End If
                        If VehicleListBox.SelectedIndex = 2 Then
                            DailyRate = PREMIUN_RATE
                        End If
                        If VehicleListBox.SelectedIndex = 3 Then
                            DailyRate = MINIVAN_RATE
                        End If
                        If VehicleListBox.SelectedIndex = 4 Then
                            DailyRate = SUV_RATE
                        End If

                        ' Calculations to be preformed.
                        Dim CustomerCost = (MilesDriven * MILEAGE_RATE) + (DaysRented * DailyRate)
                        TotalMileageOfVehicles += MilesDriven
                        TotalNumberOfRentals += 1
                        TotalRevenueMade += CustomerCost

                        'Displays the customer cost to the user.
                        TotalMilesLabel.Text = MilesDriven.ToString()
                        CustomerChargeLabel.Text = CustomerCost.ToString()

                    Else
                        MessageBox.Show("You must select a vehicle to use.", "Vehicle Not Selected")
                    End If
                Else
                    MessageBox.Show("You cannot have mileage larger then your ending mileage.", "Mileage Invalid")
                End If
            Else
                MessageBox.Show("You must enter a valid amount of days.", "Days Invalid")
            End If

        Catch mathError As ArithmeticException
            MessageBox.Show("Please ensure all your values are numeric for use in calculations." + vbNewLine + mathError.ToString())
        Catch conversionError As InvalidCastException
            MessageBox.Show("Please ensure all your values can be interpretted as an integer or decimal." + vbNewLine + conversionError.ToString())
        Catch otherError As Exception
            MessageBox.Show("Please contact a system administrator." + vbNewLine + otherError.ToString())
        End Try

    End Sub

    ' Shows grand totals through the summary form.
    Private Sub ShowTotalsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowTotalsToolStripMenuItem.Click
        SummaryForm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
End Class
