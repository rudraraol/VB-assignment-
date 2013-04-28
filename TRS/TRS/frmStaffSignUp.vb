Imports System.Data.OleDb

Public Class frmStaffSignUp

    Private Property Valid As Boolean

    Private Sub btnSignUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignUp.Click
        Dim ID = txtUserID.Text
        Dim Password = txtPassword.Text
        Dim CPassword = txtCPassword.Text
        Dim FName = txtFirstName.Text
        Dim LName = txtLastName.Text

        If ID = Nothing Then
            MsgBox("Please Enter UserID")
        Else
            Valid = True
        End If

        If Password = Nothing Then
            MsgBox("Please Enter Password")
        Else
            Valid = True
        End If

        If CPassword = Nothing Then
            MsgBox("Please Enter Confirm Password")
        Else
            Valid = True
        End If

        If CPassword <> Password Then
            MsgBox("Please Re-Check Confirm Password")
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

            SQL = "INSERT INTO Staff([Staff_ID], [Password], [First_Name], [Last_Name]) VALUES('" & ID & "','" & Password & "','" & FName & "','" & LName & "')"
            Con.Open()
            objCmd = New OleDbCommand(SQL, Con)
            objCmd.ExecuteNonQuery()
            MessageBox.Show("Register Succesful")
            Con.Close()

        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtUserID.Text = ""
        txtPassword.Text = ""
        txtCPassword.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
    End Sub

    Private Sub cbShowPassword_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbShowPassword.CheckedChanged
        If cbShowPassword.Checked = True Then
            txtPassword.PasswordChar = ""
            txtCPassword.PasswordChar = ""
        End If

        If cbShowPassword.Checked = False Then
            txtPassword.PasswordChar = "*"
            txtCPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class