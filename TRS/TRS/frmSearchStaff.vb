Imports System.Data.OleDb

Public Class frmSearchStaff

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub frmSearchStaff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TRSDataSet2.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.TRSDataSet2.Staff)

    End Sub

    Private Sub cboSearchStaff_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSearchStaff.SelectedIndexChanged
        cboSearchStaff.SelectedIndex = 0
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Search_record()
    End Sub

    Private Sub Search_record()
        Dim SQL As String
        Dim objCmd As New OleDbCommand
        Dim Con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jack\Documents\Visual Studio 2010\Projects\TRS\TRS\TRS.accdb")

        SQL = "SELECT Staff_Id, Password, last_name + ', ' + first_name as name FROM Staff"
        Con.Open()
        objCmd = New OleDbCommand(SQL, Con)
        objCmd.ExecuteNonQuery()
        Con.Close()

        If cboSearchStaff.Text = "Name" Then
            SQL = SQL & " where last_name + ', ' + first_name like '%" & txtSearch.Text & "%'"
        Else
            SQL = SQL & " where staff_id =" & txtSearch.Text
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If dtgStaffSearch.RowCount > 0 Then
            Dim frm As New frmStaffDetails
            frm.Tag = dtgStaffSearch.Item(0, dtgStaffSearch.CurrentRow.Index).Value
            frm.ShowDialog()
            frm = Nothing
        End If
    End Sub
End Class

