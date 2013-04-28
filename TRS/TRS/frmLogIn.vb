Imports System.Data.OleDb

Public Class frmLogIn

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        If Validate_User() Then
            frmHome.Show()
            Me.Hide()
        Else
            MsgBox("Wrong password or User ID")
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Function Validate_User()
        Dim SQL As String
        Dim objCmd As New OleDbCommand
        Dim Con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\DB\Database.accdb")

        SQL = "SELECT Staff_ID,Password FROM Staff WHERE [Staff_ID] = '" & txtUserID.Text & "' and [Password] = '" & txtPassword.Text & "'"
        Con.Open()
        objCmd = New OleDbCommand(SQL, Con)
            `objCmd.ExecuteNonQuery()
        MessageBox.Show("Login Sucess")
        Con.Close()
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        frmHome.Show()
    End Sub
End Class
