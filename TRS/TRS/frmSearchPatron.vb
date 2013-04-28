Public Class frmSearchPatron

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub frmSearchPatron_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TRSDataSet.Patron' table. You can move, or remove it, as needed.
        Me.PatronTableAdapter1.Fill(Me.TRSDataSet.Patron)
        'TODO: This line of code loads data into the 'TRSDataSet1.Reservations' table. You can move, or remove it, as needed.
        Me.ReservationsTableAdapter.Fill(Me.TRSDataSet1.Reservations)
        'TODO: This line of code loads data into the 'TRSDataSet1.Patron' table. You can move, or remove it, as needed.
        Me.PatronTableAdapter.Fill(Me.TRSDataSet1.Patron)

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If dtgPatron.RowCount > 0 Then
            Dim frm As New frmStaffDetails
            frm.Tag = dtgPatron.Item(0, dtgPatron.CurrentRow.Index).Value
            frm.ShowDialog()
            frm = Nothing
        End If
    End Sub
End Class