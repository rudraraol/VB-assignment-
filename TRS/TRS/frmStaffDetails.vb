Imports System.Data.OleDb
Public Class frmStaffDetails

    Private Property Valid As Boolean

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        frmSearchStaff.Show()
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtUserID.Text = ""
        txtPassword.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim ID = txtUserID.Text
        Dim Password = txtPassword.Text
        Dim FName = txtFirstName.Text
        Dim LName = txtLastName.Text

        If Valid = True Then
            Dim SQL As String
            Dim objCmd As New OleDbCommand
            Dim Con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jack\Documents\Visual Studio 2010\Projects\TRS\TRS\TRS.accdb")

            SQL = "INSERT INTO Staff([Staff_ID], [Password], [First_Name], [Last_Name]) VALUES('" & ID & "','" & Password & "','" & FName & "','" & LName & "')"
            Con.Open()
            objCmd = New OleDbCommand(SQL, Con)
            objCmd.ExecuteNonQuery()
            MessageBox.Show("Register Succesful")
            Con.Close()


        End If
    End Sub
End Class