Imports System.Data.OleDb

Public Class frmConcertInput
    Private Property Valid As Boolean

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtConcertName.Text = ""
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        Dim CN = txtConcertName.Text
        Dim CD = dtpConcert.Text

        If CN = Nothing Then
            MsgBox("Please Enter Concert Name")
        Else
            Valid = True
        End If

        Dim SQL As String
        Dim objCmd As New OleDbCommand
        Dim Con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jack\Documents\Visual Studio 2010\Projects\TRS\TRS\TRS.accdb")

        SQL = "INSERT INTO Concerts ([Concert_Name], [Concert_Date]) VALUES('" & CN & "','" & CD & "')"
        Con.Open()
        objCmd = New OleDbCommand(SQL, Con)
        objCmd.ExecuteNonQuery()
        MessageBox.Show("Succesful")
        Con.Close()



    End Sub
End Class