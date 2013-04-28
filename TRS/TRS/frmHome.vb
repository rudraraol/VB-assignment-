Public Class frmHome
    Private Sub btnLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOut.Click
        frmLogIn.Show()
        Me.Close()

    End Sub

    Private Sub CreateStaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateStaffToolStripMenuItem.Click
        frmStaffSignUp.Show()
    End Sub

    Private Sub CreatePatronToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreatePatronToolStripMenuItem.Click
        frmPatronSignUp.Show()
    End Sub

    Private Sub CreateReservationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateReservationToolStripMenuItem.Click
        Me.Hide()
        frmReservation.Show()
    End Sub

    Private Sub CreateConcertToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateConcertToolStripMenuItem.Click
        frmConcertInput.Show()
    End Sub

    Private Sub SearchStaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchStaffToolStripMenuItem.Click
        frmSearchStaff.Show()
    End Sub

    Private Sub SearchPatronToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchPatronToolStripMenuItem.Click
        frmSearchPatron.Show()
    End Sub

    Private Sub DeleteConcertToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteConcertToolStripMenuItem.Click
        frmDeleteConcert.Show()
    End Sub

    Private Sub DeleteReservationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteReservationToolStripMenuItem.Click
        frmDeleteReservation.Show()
    End Sub
End Class