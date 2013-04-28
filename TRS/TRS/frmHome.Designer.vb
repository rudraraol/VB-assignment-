<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffInfoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatronInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreatePatronToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchInfoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchPatronToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateReservationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteReservationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConcertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateConcertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteConcertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformationToolStripMenuItem, Me.ReservationToolStripMenuItem, Me.ConcertToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(553, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InformationToolStripMenuItem
        '
        Me.InformationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StaffInfoToolStripMenuItem2, Me.PatronInfoToolStripMenuItem, Me.SearchInfoToolStripMenuItem1})
        Me.InformationToolStripMenuItem.Name = "InformationToolStripMenuItem"
        Me.InformationToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.InformationToolStripMenuItem.Text = "Information"
        '
        'StaffInfoToolStripMenuItem2
        '
        Me.StaffInfoToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateStaffToolStripMenuItem})
        Me.StaffInfoToolStripMenuItem2.Name = "StaffInfoToolStripMenuItem2"
        Me.StaffInfoToolStripMenuItem2.Size = New System.Drawing.Size(109, 22)
        Me.StaffInfoToolStripMenuItem2.Text = "Staff"
        '
        'CreateStaffToolStripMenuItem
        '
        Me.CreateStaffToolStripMenuItem.Name = "CreateStaffToolStripMenuItem"
        Me.CreateStaffToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.CreateStaffToolStripMenuItem.Text = "Create"
        '
        'PatronInfoToolStripMenuItem
        '
        Me.PatronInfoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreatePatronToolStripMenuItem})
        Me.PatronInfoToolStripMenuItem.Name = "PatronInfoToolStripMenuItem"
        Me.PatronInfoToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.PatronInfoToolStripMenuItem.Text = "Patron"
        '
        'CreatePatronToolStripMenuItem
        '
        Me.CreatePatronToolStripMenuItem.Name = "CreatePatronToolStripMenuItem"
        Me.CreatePatronToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.CreatePatronToolStripMenuItem.Text = "Create"
        '
        'SearchInfoToolStripMenuItem1
        '
        Me.SearchInfoToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchStaffToolStripMenuItem, Me.SearchPatronToolStripMenuItem})
        Me.SearchInfoToolStripMenuItem1.Name = "SearchInfoToolStripMenuItem1"
        Me.SearchInfoToolStripMenuItem1.Size = New System.Drawing.Size(109, 22)
        Me.SearchInfoToolStripMenuItem1.Text = "Edit"
        '
        'SearchStaffToolStripMenuItem
        '
        Me.SearchStaffToolStripMenuItem.Name = "SearchStaffToolStripMenuItem"
        Me.SearchStaffToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.SearchStaffToolStripMenuItem.Text = "Staff"
        '
        'SearchPatronToolStripMenuItem
        '
        Me.SearchPatronToolStripMenuItem.Name = "SearchPatronToolStripMenuItem"
        Me.SearchPatronToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.SearchPatronToolStripMenuItem.Text = "Patron"
        '
        'ReservationToolStripMenuItem
        '
        Me.ReservationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateReservationToolStripMenuItem, Me.DeleteReservationToolStripMenuItem})
        Me.ReservationToolStripMenuItem.Name = "ReservationToolStripMenuItem"
        Me.ReservationToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.ReservationToolStripMenuItem.Text = "Reservation"
        '
        'CreateReservationToolStripMenuItem
        '
        Me.CreateReservationToolStripMenuItem.Name = "CreateReservationToolStripMenuItem"
        Me.CreateReservationToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.CreateReservationToolStripMenuItem.Text = "Create"
        '
        'DeleteReservationToolStripMenuItem
        '
        Me.DeleteReservationToolStripMenuItem.Name = "DeleteReservationToolStripMenuItem"
        Me.DeleteReservationToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.DeleteReservationToolStripMenuItem.Text = "Delete"
        '
        'ConcertToolStripMenuItem
        '
        Me.ConcertToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateConcertToolStripMenuItem, Me.DeleteConcertToolStripMenuItem})
        Me.ConcertToolStripMenuItem.Name = "ConcertToolStripMenuItem"
        Me.ConcertToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ConcertToolStripMenuItem.Text = "Concert"
        '
        'CreateConcertToolStripMenuItem
        '
        Me.CreateConcertToolStripMenuItem.Name = "CreateConcertToolStripMenuItem"
        Me.CreateConcertToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.CreateConcertToolStripMenuItem.Text = "Create"
        '
        'DeleteConcertToolStripMenuItem
        '
        Me.DeleteConcertToolStripMenuItem.Name = "DeleteConcertToolStripMenuItem"
        Me.DeleteConcertToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.DeleteConcertToolStripMenuItem.Text = "Delete"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowReportToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'ShowReportToolStripMenuItem
        '
        Me.ShowReportToolStripMenuItem.Name = "ShowReportToolStripMenuItem"
        Me.ShowReportToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ShowReportToolStripMenuItem.Text = "Show"
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(12, 233)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(75, 23)
        Me.btnLogOut.TabIndex = 11
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 268)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmHome"
        Me.Text = "frmHome"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffInfoToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateStaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PatronInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreatePatronToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchInfoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchStaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchPatronToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReservationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateReservationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteReservationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConcertToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateConcertToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteConcertToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
End Class
