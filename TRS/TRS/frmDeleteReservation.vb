Public Class frmDeleteReservation

    Private Sub frmDeleteReservation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TRSDataSet3.Reservations' table. You can move, or remove it, as needed.
        Me.ReservationsTableAdapter.Fill(Me.TRSDataSet3.Reservations)

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class