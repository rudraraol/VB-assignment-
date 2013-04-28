<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConcertInput
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.txtConcertName = New System.Windows.Forms.TextBox()
        Me.lblConcert_Date = New System.Windows.Forms.Label()
        Me.lblConcertName = New System.Windows.Forms.Label()
        Me.dtpConcert = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(174, 108)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 39
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(93, 108)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 38
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(12, 108)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 37
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'txtConcertName
        '
        Me.txtConcertName.Location = New System.Drawing.Point(126, 19)
        Me.txtConcertName.Name = "txtConcertName"
        Me.txtConcertName.Size = New System.Drawing.Size(197, 20)
        Me.txtConcertName.TabIndex = 33
        '
        'lblConcert_Date
        '
        Me.lblConcert_Date.AutoSize = True
        Me.lblConcert_Date.Location = New System.Drawing.Point(12, 48)
        Me.lblConcert_Date.Name = "lblConcert_Date"
        Me.lblConcert_Date.Size = New System.Drawing.Size(70, 13)
        Me.lblConcert_Date.TabIndex = 31
        Me.lblConcert_Date.Text = "Concert Date"
        '
        'lblConcertName
        '
        Me.lblConcertName.AutoSize = True
        Me.lblConcertName.Location = New System.Drawing.Point(12, 22)
        Me.lblConcertName.Name = "lblConcertName"
        Me.lblConcertName.Size = New System.Drawing.Size(75, 13)
        Me.lblConcertName.TabIndex = 30
        Me.lblConcertName.Text = "Concert Name"
        '
        'dtpConcert
        '
        Me.dtpConcert.Location = New System.Drawing.Point(126, 48)
        Me.dtpConcert.Name = "dtpConcert"
        Me.dtpConcert.Size = New System.Drawing.Size(197, 20)
        Me.dtpConcert.TabIndex = 40
        '
        'frmConcertInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 162)
        Me.Controls.Add(Me.dtpConcert)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.txtConcertName)
        Me.Controls.Add(Me.lblConcert_Date)
        Me.Controls.Add(Me.lblConcertName)
        Me.Name = "frmConcertInput"
        Me.Text = "Welcome To TRS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents txtConcertName As System.Windows.Forms.TextBox
    Friend WithEvents lblConcert_Date As System.Windows.Forms.Label
    Friend WithEvents lblConcertName As System.Windows.Forms.Label
    Friend WithEvents dtpConcert As System.Windows.Forms.DateTimePicker
End Class
