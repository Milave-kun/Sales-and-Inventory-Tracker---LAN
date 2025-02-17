<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Panel1 = New Panel()
        PanelDesktop = New Panel()
        Panel2 = New Panel()
        btnMinimize = New FontAwesome.Sharp.IconButton()
        btnClose = New FontAwesome.Sharp.IconButton()
        PictureBox1 = New PictureBox()
        PanelMenu = New Panel()
        btnAdmin = New FontAwesome.Sharp.IconButton()
        btnUser = New FontAwesome.Sharp.IconButton()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(PanelDesktop)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(410, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(395, 450)
        Panel1.TabIndex = 2
        ' 
        ' PanelDesktop
        ' 
        PanelDesktop.Dock = DockStyle.Fill
        PanelDesktop.Location = New Point(0, 42)
        PanelDesktop.Name = "PanelDesktop"
        PanelDesktop.Size = New Size(395, 408)
        PanelDesktop.TabIndex = 14
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnMinimize)
        Panel2.Controls.Add(btnClose)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(395, 42)
        Panel2.TabIndex = 13
        ' 
        ' btnMinimize
        ' 
        btnMinimize.Dock = DockStyle.Right
        btnMinimize.FlatAppearance.BorderSize = 0
        btnMinimize.FlatStyle = FlatStyle.Flat
        btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Subtract
        btnMinimize.IconColor = Color.Black
        btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnMinimize.IconSize = 30
        btnMinimize.Location = New Point(309, 0)
        btnMinimize.Name = "btnMinimize"
        btnMinimize.Size = New Size(43, 42)
        btnMinimize.TabIndex = 0
        btnMinimize.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Dock = DockStyle.Right
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.IconChar = FontAwesome.Sharp.IconChar.Close
        btnClose.IconColor = Color.Black
        btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnClose.IconSize = 30
        btnClose.Location = New Point(352, 0)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(43, 42)
        btnClose.TabIndex = 1
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Logo
        PictureBox1.Location = New Point(89, 155)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(223, 218)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' PanelMenu
        ' 
        PanelMenu.Controls.Add(btnAdmin)
        PanelMenu.Controls.Add(btnUser)
        PanelMenu.Dock = DockStyle.Top
        PanelMenu.Location = New Point(0, 0)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(410, 85)
        PanelMenu.TabIndex = 6
        ' 
        ' btnAdmin
        ' 
        btnAdmin.Dock = DockStyle.Fill
        btnAdmin.FlatAppearance.BorderSize = 0
        btnAdmin.FlatStyle = FlatStyle.Flat
        btnAdmin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdmin.ForeColor = Color.White
        btnAdmin.IconChar = FontAwesome.Sharp.IconChar.UserTie
        btnAdmin.IconColor = Color.White
        btnAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnAdmin.IconSize = 40
        btnAdmin.Location = New Point(205, 0)
        btnAdmin.Name = "btnAdmin"
        btnAdmin.Size = New Size(205, 85)
        btnAdmin.TabIndex = 2
        btnAdmin.Text = "Admin"
        btnAdmin.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAdmin.UseVisualStyleBackColor = True
        ' 
        ' btnUser
        ' 
        btnUser.Dock = DockStyle.Left
        btnUser.FlatAppearance.BorderSize = 0
        btnUser.FlatStyle = FlatStyle.Flat
        btnUser.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUser.ForeColor = Color.White
        btnUser.IconChar = FontAwesome.Sharp.IconChar.Users
        btnUser.IconColor = Color.White
        btnUser.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnUser.IconSize = 40
        btnUser.Location = New Point(0, 0)
        btnUser.Name = "btnUser"
        btnUser.Size = New Size(205, 85)
        btnUser.TabIndex = 1
        btnUser.Text = "User"
        btnUser.TextImageRelation = TextImageRelation.ImageBeforeText
        btnUser.UseVisualStyleBackColor = True
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        ClientSize = New Size(805, 450)
        Controls.Add(PanelMenu)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmLogin"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelMenu.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnFormLogin As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnUser As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAdmin As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClose As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMinimize As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents Panel2 As Panel
End Class
