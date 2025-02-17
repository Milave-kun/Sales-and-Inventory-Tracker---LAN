<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUserLogin
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
        btnConfirm = New Button()
        btnExit = New Button()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnConfirm
        ' 
        btnConfirm.FlatAppearance.BorderSize = 0
        btnConfirm.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnConfirm.Location = New Point(204, 209)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Size = New Size(104, 38)
        btnConfirm.TabIndex = 17
        btnConfirm.Text = "Confirm"
        btnConfirm.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExit.Location = New Point(70, 209)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(104, 38)
        btnExit.TabIndex = 16
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(70, 143)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(238, 33)
        txtPassword.TabIndex = 15
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(70, 63)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(238, 33)
        txtUsername.TabIndex = 14
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(58, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 21)
        Label3.TabIndex = 13
        Label3.Text = "Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(58, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 21)
        Label1.TabIndex = 12
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(101, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(185, 40)
        Label2.TabIndex = 11
        Label2.Text = "USER LOGIN"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(379, 120)
        Panel1.TabIndex = 18
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(btnConfirm)
        Panel2.Controls.Add(txtUsername)
        Panel2.Controls.Add(btnExit)
        Panel2.Controls.Add(txtPassword)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 120)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(379, 291)
        Panel2.TabIndex = 19
        ' 
        ' FormUserLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(379, 411)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "FormUserLogin"
        Text = "FormUserLogin"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
