<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchStaff
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.dtgStaffSearch = New System.Windows.Forms.DataGridView()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TRSDataSet2 = New TRS.TRSDataSet2()
        Me.StaffTableAdapter = New TRS.TRSDataSet2TableAdapters.StaffTableAdapter()
        Me.cboSearchStaff = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        CType(Me.dtgStaffSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRSDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(471, 225)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(12, 223)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(390, 225)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'dtgStaffSearch
        '
        Me.dtgStaffSearch.AllowUserToAddRows = False
        Me.dtgStaffSearch.AllowUserToDeleteRows = False
        Me.dtgStaffSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgStaffSearch.Location = New System.Drawing.Point(0, 0)
        Me.dtgStaffSearch.Name = "dtgStaffSearch"
        Me.dtgStaffSearch.ReadOnly = True
        Me.dtgStaffSearch.Size = New System.Drawing.Size(557, 191)
        Me.dtgStaffSearch.TabIndex = 0
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.TRSDataSet2
        '
        'TRSDataSet2
        '
        Me.TRSDataSet2.DataSetName = "TRSDataSet2"
        Me.TRSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'cboSearchStaff
        '
        Me.cboSearchStaff.FormattingEnabled = True
        Me.cboSearchStaff.Location = New System.Drawing.Point(118, 197)
        Me.cboSearchStaff.Name = "cboSearchStaff"
        Me.cboSearchStaff.Size = New System.Drawing.Size(121, 21)
        Me.cboSearchStaff.TabIndex = 4
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(12, 197)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 5
        '
        'frmSearchStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 257)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cboSearchStaff)
        Me.Controls.Add(Me.dtgStaffSearch)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "frmSearchStaff"
        Me.Text = "Welcome to TRS"
        CType(Me.dtgStaffSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRSDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents dtgStaffSearch As System.Windows.Forms.DataGridView
    Friend WithEvents TRSDataSet2 As TRS.TRSDataSet2
    Friend WithEvents StaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StaffTableAdapter As TRS.TRSDataSet2TableAdapters.StaffTableAdapter
    Friend WithEvents cboSearchStaff As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
End Class
