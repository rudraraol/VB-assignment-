Public Class frmConfirmReservation

    Private Sub ConfirmReservation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TRSDataSet4.Reservations' table. You can move, or remove it, as needed.
        Me.ReservationsTableAdapter.Fill(Me.TRSDataSet4.Reservations)

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        frmReservation.Show()
    End Sub
End Class