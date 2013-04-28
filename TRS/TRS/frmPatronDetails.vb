Imports System.Data.OleDb
Public Class frmPatronDetails
    Private Property Valid As Boolean

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        frmSearchPatron.Show()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtPatronID.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtContactNumber.Text = ""
        txtEMailAddress.Text = ""
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim ID = txtPatronID.Text
        Dim ContactNumber = txtContactNumber.Text
        Dim EmailAddress = txtEMailAddress.Text
        Dim FName = txtFirstName.Text
        Dim LName = txtLastName.Text

        If Valid = True Then
            Dim SQL As String
            Dim objCmd As New OleDbCommand
            Dim Con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jack\Documents\Visual Studio 2010\Projects\TRS\TRS\TRS.accdb")

            SQL = "UPDATE Patron SET Patron_ID = @Patron_ID, First_Name = @First_Name, Last_Name = @Last_Name, Contact_Number = @Contact_Number, E-Mail_Address = @E-Mail_Address"
            Con.Open()
            objCmd = New OleDbCommand(SQL, Con)
            objCmd.ExecuteNonQuery()
            MessageBox.Show("DATA SAVED !")
            Con.Close()
        End If
    End Sub
End Class