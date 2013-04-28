<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeleteReservation
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
        Me.components = New System.ComponentModel.Container()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtReservationID = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TRSDataSet3 = New TRS.TRSDataSet3()
        Me.ReservationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationsTableAdapter = New TRS.TRSDataSet3TableAdapters.ReservationsTableAdapter()
        Me.ReservationIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReservationDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeatNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatronIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConcertIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRSDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(12, 196)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(561, 196)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtReservationID
        '
        Me.txtReservationID.Location = New System.Drawing.Point(93, 196)
        Me.txtReservationID.Name = "txtReservationID"
        Me.txtReservationID.Size = New System.Drawing.Size(136, 20)
        Me.txtReservationID.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReservationIDDataGridViewTextBoxColumn, Me.ReservationDateDataGridViewTextBoxColumn, Me.SeatNumberDataGridViewTextBoxColumn, Me.PatronIDDataGridViewTextBoxColumn, Me.ConcertIDDataGridViewTextBoxColumn, Me.StaffIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ReservationsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(646, 142)
        Me.DataGridView1.TabIndex = 3
        '
        'TRSDataSet3
        '
        Me.TRSDataSet3.DataSetName = "TRSDataSet3"
        Me.TRSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReservationsBindingSource
        '
        Me.ReservationsBindingSource.DataMember = "Reservations"
        Me.ReservationsBindingSource.DataSource = Me.TRSDataSet3
        '
        'ReservationsTableAdapter
        '
        Me.ReservationsTableAdapter.ClearBeforeFill = True
        '
        'ReservationIDDataGridViewTextBoxColumn
        '
        Me.ReservationIDDataGridViewTextBoxColumn.DataPropertyName = "Reservation_ID"
        Me.ReservationIDDataGridViewTextBoxColumn.HeaderText = "Reservation_ID"
        Me.ReservationIDDataGridViewTextBoxColumn.Name = "ReservationIDDataGridViewTextBoxColumn"
        Me.ReservationIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReservationDateDataGridViewTextBoxColumn
        '
        Me.ReservationDateDataGridViewTextBoxColumn.DataPropertyName = "Reservation_Date"
        Me.ReservationDateDataGridViewTextBoxColumn.HeaderText = "Reservation_Date"
        Me.ReservationDateDataGridViewTextBoxColumn.Name = "ReservationDateDataGridViewTextBoxColumn"
        Me.ReservationDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SeatNumberDataGridViewTextBoxColumn
        '
        Me.SeatNumberDataGridViewTextBoxColumn.DataPropertyName = "Seat_Number"
        Me.SeatNumberDataGridViewTextBoxColumn.HeaderText = "Seat_Number"
        Me.SeatNumberDataGridViewTextBoxColumn.Name = "SeatNumberDataGridViewTextBoxColumn"
        Me.SeatNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PatronIDDataGridViewTextBoxColumn
        '
        Me.PatronIDDataGridViewTextBoxColumn.DataPropertyName = "Patron_ID"
        Me.PatronIDDataGridViewTextBoxColumn.HeaderText = "Patron_ID"
        Me.PatronIDDataGridViewTextBoxColumn.Name = "PatronIDDataGridViewTextBoxColumn"
        Me.PatronIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ConcertIDDataGridViewTextBoxColumn
        '
        Me.ConcertIDDataGridViewTextBoxColumn.DataPropertyName = "Concert_ID"
        Me.ConcertIDDataGridViewTextBoxColumn.HeaderText = "Concert_ID"
        Me.ConcertIDDataGridViewTextBoxColumn.Name = "ConcertIDDataGridViewTextBoxColumn"
        Me.ConcertIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StaffIDDataGridViewTextBoxColumn
        '
        Me.StaffIDDataGridViewTextBoxColumn.DataPropertyName = "Staff_ID"
        Me.StaffIDDataGridViewTextBoxColumn.HeaderText = "Staff_ID"
        Me.StaffIDDataGridViewTextBoxColumn.Name = "StaffIDDataGridViewTextBoxColumn"
        Me.StaffIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(480, 196)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'frmDeleteReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 231)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtReservationID)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSearch)
        Me.Name = "frmDeleteReservation"
        Me.Text = "frmDeleteReservation"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRSDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents txtReservationID As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TRSDataSet3 As TRS.TRSDataSet3
    Friend WithEvents ReservationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReservationsTableAdapter As TRS.TRSDataSet3TableAdapters.ReservationsTableAdapter
    Friend WithEvents ReservationIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReservationDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeatNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatronIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConcertIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StaffIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
