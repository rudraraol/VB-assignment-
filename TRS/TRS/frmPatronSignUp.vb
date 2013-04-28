Imports System.Data.OleDb

Public Class frmPatronSignUp
    Private Property Valid As Boolean

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        Dim ID = txtPatronID.Text
        Dim ContactNumber = txtContactNumber.Text
        Dim EmailAddress = txtEMailAddress.Text
        Dim FName = txtFirstName.Text
        Dim LName = txtLastName.Text

        If ID = Nothing Then
            MsgBox("Please Enter Patron ID")
        Else
            Valid = True
        End If

        If ContactNumber = Nothing Then
            MsgBox("Please Enter Contact Number")
        Else
            Valid = True
        End If

        If EmailAddress = Nothing Then
            MsgBox("Please Enter E-Mail Address")
        Else
            Valid = True
        End If

        If FName = Nothing Then
            MsgBox("Please Enter First Name")
        Else
            Valid = True
        End If

        If LName = Nothing Then
            MsgBox("Please Enter Last Name")
        Else
            Valid = True
        End If

        If Valid = True Then
            Dim SQL As String
            Dim objCmd As New OleDbCommand
            Dim Con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jack\Documents\Visual Studio 2010\Projects\TRS\TRS\TRS.accdb")

            SQL = "INSERT INTO Patron([Patron_ID], [First_Name], [Last_Name], [Contact_Number], [E-mail_Address]) VALUES('" & ID & "','" & FName & "','" & LName & "','" & ContactNumber & "','" & EmailAddress & "')"
            Con.Open()
            objCmd = New OleDbCommand(SQL, Con)
            objCmd.ExecuteNonQuery()
            MessageBox.Show("DATA SAVED !")
            Con.Close()
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtPatronID.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtContactNumber.Text = ""
        txtEMailAddress.Text = ""
    End Sub
End Class