<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchPatron
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
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dtgPatron = New System.Windows.Forms.DataGridView()
        Me.PatronBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TRSDataSet1 = New TRS.TRSDataSet1()
        Me.PatronTableAdapter = New TRS.TRSDataSet1TableAdapters.PatronTableAdapter()
        Me.PatronReservationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationsTableAdapter = New TRS.TRSDataSet1TableAdapters.ReservationsTableAdapter()
        Me.TRSDataSet = New TRS.TRSDataSet()
        Me.PatronBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatronTableAdapter1 = New TRS.TRSDataSetTableAdapters.PatronTableAdapter()
        Me.cboPatron = New System.Windows.Forms.ComboBox()
        CType(Me.dtgPatron, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatronBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRSDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatronReservationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatronBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(401, 218)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 37
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(12, 229)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 36
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 203)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 35
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(482, 218)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 34
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'dtgPatron
        '
        Me.dtgPatron.AllowUserToAddRows = False
        Me.dtgPatron.AllowUserToDeleteRows = False
        Me.dtgPatron.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgPatron.Location = New System.Drawing.Point(12, 12)
        Me.dtgPatron.Name = "dtgPatron"
        Me.dtgPatron.Size = New System.Drawing.Size(545, 185)
        Me.dtgPatron.TabIndex = 38
        '
        'PatronBindingSource
        '
        Me.PatronBindingSource.DataMember = "Patron"
        Me.PatronBindingSource.DataSource = Me.TRSDataSet1
        '
        'TRSDataSet1
        '
        Me.TRSDataSet1.DataSetName = "TRSDataSet1"
        Me.TRSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PatronTableAdapter
        '
        Me.PatronTableAdapter.ClearBeforeFill = True
        '
        'PatronReservationsBindingSource
        '
        Me.PatronReservationsBindingSource.DataMember = "PatronReservations"
        Me.PatronReservationsBindingSource.DataSource = Me.PatronBindingSource
        '
        'ReservationsTableAdapter
        '
        Me.ReservationsTableAdapter.ClearBeforeFill = True
        '
        'TRSDataSet
        '
        Me.TRSDataSet.DataSetName = "TRSDataSet"
        Me.TRSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PatronBindingSource1
        '
        Me.PatronBindingSource1.DataMember = "Patron"
        Me.PatronBindingSource1.DataSource = Me.TRSDataSet
        '
        'PatronTableAdapter1
        '
        Me.PatronTableAdapter1.ClearBeforeFill = True
        '
        'cboPatron
        '
        Me.cboPatron.FormattingEnabled = True
        Me.cboPatron.Location = New System.Drawing.Point(118, 203)
        Me.cboPatron.Name = "cboPatron"
        Me.cboPatron.Size = New System.Drawing.Size(121, 21)
        Me.cboPatron.TabIndex = 39
        '
        'frmSearchPatron
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 257)
        Me.Controls.Add(Me.cboPatron)
        Me.Controls.Add(Me.dtgPatron)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "frmSearchPatron"
        Me.Text = "frmSearchPatron"
        CType(Me.dtgPatron, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatronBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRSDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatronReservationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatronBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents dtgPatron As System.Windows.Forms.DataGridView
    Friend WithEvents TRSDataSet1 As TRS.TRSDataSet1
    Friend WithEvents PatronBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PatronTableAdapter As TRS.TRSDataSet1TableAdapters.PatronTableAdapter
    Friend WithEvents PatronReservationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReservationsTableAdapter As TRS.TRSDataSet1TableAdapters.ReservationsTableAdapter
    Friend WithEvents TRSDataSet As TRS.TRSDataSet
    Friend WithEvents PatronBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PatronTableAdapter1 As TRS.TRSDataSetTableAdapters.PatronTableAdapter
    Friend WithEvents cboPatron As System.Windows.Forms.ComboBox
End Class
