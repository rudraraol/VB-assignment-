<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatronSignUp
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
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtEMailAddress = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.txtPatronID = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblEMailAddress = New System.Windows.Forms.Label()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.lblPatronID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(182, 150)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 26
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(101, 150)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 25
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(15, 150)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(75, 23)
        Me.btnRegister.TabIndex = 24
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(126, 33)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 20
        '
        'txtEMailAddress
        '
        Me.txtEMailAddress.Location = New System.Drawing.Point(126, 108)
        Me.txtEMailAddress.Name = "txtEMailAddress"
        Me.txtEMailAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtEMailAddress.TabIndex = 23
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(126, 59)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 21
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Location = New System.Drawing.Point(126, 83)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtContactNumber.TabIndex = 22
        '
        'txtPatronID
        '
        Me.txtPatronID.Location = New System.Drawing.Point(126, 6)
        Me.txtPatronID.Name = "txtPatronID"
        Me.txtPatronID.Size = New System.Drawing.Size(100, 20)
        Me.txtPatronID.TabIndex = 19
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(12, 62)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 18
        Me.lblLastName.Text = "Last Name"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(12, 36)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 17
        Me.lblFirstName.Text = "First Name"
        '
        'lblEMailAddress
        '
        Me.lblEMailAddress.AutoSize = True
        Me.lblEMailAddress.Location = New System.Drawing.Point(12, 111)
        Me.lblEMailAddress.Name = "lblEMailAddress"
        Me.lblEMailAddress.Size = New System.Drawing.Size(77, 13)
        Me.lblEMailAddress.TabIndex = 16
        Me.lblEMailAddress.Text = "E-Mail Address"
        '
        'lblContactNumber
        '
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.Location = New System.Drawing.Point(12, 85)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(84, 13)
        Me.lblContactNumber.TabIndex = 15
        Me.lblContactNumber.Text = "Contact Number"
        '
        'lblPatronID
        '
        Me.lblPatronID.AutoSize = True
        Me.lblPatronID.Location = New System.Drawing.Point(12, 9)
        Me.lblPatronID.Name = "lblPatronID"
        Me.lblPatronID.Size = New System.Drawing.Size(52, 13)
        Me.lblPatronID.TabIndex = 14
        Me.lblPatronID.Text = "Patron ID"
        '
        'frmPatronSignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 202)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtEMailAddress)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtContactNumber)
        Me.Controls.Add(Me.txtPatronID)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblEMailAddress)
        Me.Controls.Add(Me.lblContactNumber)
        Me.Controls.Add(Me.lblPatronID)
        Me.Name = "frmPatronSignUp"
        Me.Text = "Welcome To TRS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtEMailAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtContactNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtPatronID As System.Windows.Forms.TextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblEMailAddress As System.Windows.Forms.Label
    Friend WithEvents lblContactNumber As System.Windows.Forms.Label
    Friend WithEvents lblPatronID As System.Windows.Forms.Label
End Class
