<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfirmReservation
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
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ReservationIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReservationDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeatNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatronIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConcertIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReservationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TRSDataSet4 = New TRS.TRSDataSet4()
        Me.ReservationsTableAdapter = New TRS.TRSDataSet4TableAdapters.ReservationsTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRSDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(3, 171)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "Confirm"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(568, 171)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReservationIDDataGridViewTextBoxColumn, Me.ReservationDateDataGridViewTextBoxColumn, Me.SeatNumberDataGridViewTextBoxColumn, Me.PatronIDDataGridViewTextBoxColumn, Me.ConcertIDDataGridViewTextBoxColumn, Me.StaffIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ReservationsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(648, 154)
        Me.DataGridView1.TabIndex = 2
        '
        'ReservationIDDataGridViewTextBoxColumn
        '
        Me.ReservationIDDataGridViewTextBoxColumn.DataPropertyName = "Reservation_ID"
        Me.ReservationIDDataGridViewTextBoxColumn.HeaderText = "Reservation_ID"
        Me.ReservationIDDataGridViewTextBoxColumn.Name = "ReservationIDDataGridViewTextBoxColumn"
        '
        'ReservationDateDataGridViewTextBoxColumn
        '
        Me.ReservationDateDataGridViewTextBoxColumn.DataPropertyName = "Reservation_Date"
        Me.ReservationDateDataGridViewTextBoxColumn.HeaderText = "Reservation_Date"
        Me.ReservationDateDataGridViewTextBoxColumn.Name = "ReservationDateDataGridViewTextBoxColumn"
        '
        'SeatNumberDataGridViewTextBoxColumn
        '
        Me.SeatNumberDataGridViewTextBoxColumn.DataPropertyName = "Seat_Number"
        Me.SeatNumberDataGridViewTextBoxColumn.HeaderText = "Seat_Number"
        Me.SeatNumberDataGridViewTextBoxColumn.Name = "SeatNumberDataGridViewTextBoxColumn"
        '
        'PatronIDDataGridViewTextBoxColumn
        '
        Me.PatronIDDataGridViewTextBoxColumn.DataPropertyName = "Patron_ID"
        Me.PatronIDDataGridViewTextBoxColumn.HeaderText = "Patron_ID"
        Me.PatronIDDataGridViewTextBoxColumn.Name = "PatronIDDataGridViewTextBoxColumn"
        '
        'ConcertIDDataGridViewTextBoxColumn
        '
        Me.ConcertIDDataGridViewTextBoxColumn.DataPropertyName = "Concert_ID"
        Me.ConcertIDDataGridViewTextBoxColumn.HeaderText = "Concert_ID"
        Me.ConcertIDDataGridViewTextBoxColumn.Name = "ConcertIDDataGridViewTextBoxColumn"
        '
        'StaffIDDataGridViewTextBoxColumn
        '
        Me.StaffIDDataGridViewTextBoxColumn.DataPropertyName = "Staff_ID"
        Me.StaffIDDataGridViewTextBoxColumn.HeaderText = "Staff_ID"
        Me.StaffIDDataGridViewTextBoxColumn.Name = "StaffIDDataGridViewTextBoxColumn"
        '
        'ReservationsBindingSource
        '
        Me.ReservationsBindingSource.DataMember = "Reservations"
        Me.ReservationsBindingSource.DataSource = Me.TRSDataSet4
        '
        'TRSDataSet4
        '
        Me.TRSDataSet4.DataSetName = "TRSDataSet4"
        Me.TRSDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReservationsTableAdapter
        '
        Me.ReservationsTableAdapter.ClearBeforeFill = True
        '
        'frmConfirmReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 217)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnUpdate)
        Me.Name = "frmConfirmReservation"
        Me.Text = "ConfirmReservation"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRSDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TRSDataSet4 As TRS.TRSDataSet4
    Friend WithEvents ReservationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReservationsTableAdapter As TRS.TRSDataSet4TableAdapters.ReservationsTableAdapter
    Friend WithEvents ReservationIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReservationDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeatNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatronIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConcertIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StaffIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
