<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        PanelMenu = New Panel()
        btnLogOut = New FontAwesome.Sharp.IconButton()
        btnAccountList = New FontAwesome.Sharp.IconButton()
        btnProductReport = New FontAwesome.Sharp.IconButton()
        btnSalesReport = New FontAwesome.Sharp.IconButton()
        btnAdminAccount = New FontAwesome.Sharp.IconButton()
        btnUserAccount = New FontAwesome.Sharp.IconButton()
        PanelLogo = New Panel()
        PictureBox1 = New PictureBox()
        PanelTitleBar = New Panel()
        btnMaximize = New FontAwesome.Sharp.IconButton()
        btnMinimize = New FontAwesome.Sharp.IconButton()
        btnExit = New FontAwesome.Sharp.IconButton()
        lblFormTitle = New Label()
        IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        PanelDesktop = New Panel()
        PanelMenu.SuspendLayout()
        PanelLogo.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelTitleBar.SuspendLayout()
        CType(IconCurrentForm, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelMenu
        ' 
        PanelMenu.BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        PanelMenu.Controls.Add(btnLogOut)
        PanelMenu.Controls.Add(btnAccountList)
        PanelMenu.Controls.Add(btnProductReport)
        PanelMenu.Controls.Add(btnSalesReport)
        PanelMenu.Controls.Add(btnAdminAccount)
        PanelMenu.Controls.Add(btnUserAccount)
        PanelMenu.Controls.Add(PanelLogo)
        PanelMenu.Dock = DockStyle.Left
        PanelMenu.Location = New Point(0, 0)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(284, 761)
        PanelMenu.TabIndex = 0
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Dock = DockStyle.Bottom
        btnLogOut.FlatAppearance.BorderSize = 0
        btnLogOut.FlatStyle = FlatStyle.Flat
        btnLogOut.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogOut.ForeColor = Color.White
        btnLogOut.IconChar = FontAwesome.Sharp.IconChar.UserGear
        btnLogOut.IconColor = Color.White
        btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnLogOut.IconSize = 32
        btnLogOut.ImageAlign = ContentAlignment.MiddleLeft
        btnLogOut.Location = New Point(0, 701)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Padding = New Padding(10, 0, 20, 0)
        btnLogOut.Size = New Size(284, 60)
        btnLogOut.TabIndex = 6
        btnLogOut.Text = "Log Out"
        btnLogOut.TextAlign = ContentAlignment.MiddleLeft
        btnLogOut.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLogOut.UseVisualStyleBackColor = True
        ' 
        ' btnAccountList
        ' 
        btnAccountList.Dock = DockStyle.Top
        btnAccountList.FlatAppearance.BorderSize = 0
        btnAccountList.FlatStyle = FlatStyle.Flat
        btnAccountList.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAccountList.ForeColor = Color.White
        btnAccountList.IconChar = FontAwesome.Sharp.IconChar.ListAlt
        btnAccountList.IconColor = Color.White
        btnAccountList.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnAccountList.IconSize = 32
        btnAccountList.ImageAlign = ContentAlignment.MiddleLeft
        btnAccountList.Location = New Point(0, 432)
        btnAccountList.Name = "btnAccountList"
        btnAccountList.Padding = New Padding(10, 0, 20, 0)
        btnAccountList.Size = New Size(284, 60)
        btnAccountList.TabIndex = 5
        btnAccountList.Text = "Account List"
        btnAccountList.TextAlign = ContentAlignment.MiddleLeft
        btnAccountList.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAccountList.UseVisualStyleBackColor = True
        ' 
        ' btnProductReport
        ' 
        btnProductReport.Dock = DockStyle.Top
        btnProductReport.FlatAppearance.BorderSize = 0
        btnProductReport.FlatStyle = FlatStyle.Flat
        btnProductReport.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnProductReport.ForeColor = Color.White
        btnProductReport.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        btnProductReport.IconColor = Color.White
        btnProductReport.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnProductReport.IconSize = 32
        btnProductReport.ImageAlign = ContentAlignment.MiddleLeft
        btnProductReport.Location = New Point(0, 372)
        btnProductReport.Name = "btnProductReport"
        btnProductReport.Padding = New Padding(10, 0, 20, 0)
        btnProductReport.Size = New Size(284, 60)
        btnProductReport.TabIndex = 4
        btnProductReport.Text = "Product Report"
        btnProductReport.TextAlign = ContentAlignment.MiddleLeft
        btnProductReport.TextImageRelation = TextImageRelation.ImageBeforeText
        btnProductReport.UseVisualStyleBackColor = True
        ' 
        ' btnSalesReport
        ' 
        btnSalesReport.Dock = DockStyle.Top
        btnSalesReport.FlatAppearance.BorderSize = 0
        btnSalesReport.FlatStyle = FlatStyle.Flat
        btnSalesReport.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSalesReport.ForeColor = Color.White
        btnSalesReport.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar
        btnSalesReport.IconColor = Color.White
        btnSalesReport.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSalesReport.IconSize = 32
        btnSalesReport.ImageAlign = ContentAlignment.MiddleLeft
        btnSalesReport.Location = New Point(0, 312)
        btnSalesReport.Name = "btnSalesReport"
        btnSalesReport.Padding = New Padding(10, 0, 20, 0)
        btnSalesReport.Size = New Size(284, 60)
        btnSalesReport.TabIndex = 3
        btnSalesReport.Text = "Sales Report"
        btnSalesReport.TextAlign = ContentAlignment.MiddleLeft
        btnSalesReport.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSalesReport.UseVisualStyleBackColor = True
        ' 
        ' btnAdminAccount
        ' 
        btnAdminAccount.Dock = DockStyle.Top
        btnAdminAccount.FlatAppearance.BorderSize = 0
        btnAdminAccount.FlatStyle = FlatStyle.Flat
        btnAdminAccount.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAdminAccount.ForeColor = Color.White
        btnAdminAccount.IconChar = FontAwesome.Sharp.IconChar.UserTie
        btnAdminAccount.IconColor = Color.White
        btnAdminAccount.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnAdminAccount.IconSize = 32
        btnAdminAccount.ImageAlign = ContentAlignment.MiddleLeft
        btnAdminAccount.Location = New Point(0, 252)
        btnAdminAccount.Name = "btnAdminAccount"
        btnAdminAccount.Padding = New Padding(10, 0, 20, 0)
        btnAdminAccount.Size = New Size(284, 60)
        btnAdminAccount.TabIndex = 2
        btnAdminAccount.Text = "Admin Account"
        btnAdminAccount.TextAlign = ContentAlignment.MiddleLeft
        btnAdminAccount.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAdminAccount.UseVisualStyleBackColor = True
        ' 
        ' btnUserAccount
        ' 
        btnUserAccount.Dock = DockStyle.Top
        btnUserAccount.FlatAppearance.BorderSize = 0
        btnUserAccount.FlatStyle = FlatStyle.Flat
        btnUserAccount.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUserAccount.ForeColor = Color.White
        btnUserAccount.IconChar = FontAwesome.Sharp.IconChar.UserGear
        btnUserAccount.IconColor = Color.White
        btnUserAccount.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnUserAccount.IconSize = 32
        btnUserAccount.ImageAlign = ContentAlignment.MiddleLeft
        btnUserAccount.Location = New Point(0, 192)
        btnUserAccount.Name = "btnUserAccount"
        btnUserAccount.Padding = New Padding(10, 0, 20, 0)
        btnUserAccount.Size = New Size(284, 60)
        btnUserAccount.TabIndex = 1
        btnUserAccount.Text = "User Account"
        btnUserAccount.TextAlign = ContentAlignment.MiddleLeft
        btnUserAccount.TextImageRelation = TextImageRelation.ImageBeforeText
        btnUserAccount.UseVisualStyleBackColor = True
        ' 
        ' PanelLogo
        ' 
        PanelLogo.BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        PanelLogo.Controls.Add(PictureBox1)
        PanelLogo.Dock = DockStyle.Top
        PanelLogo.Location = New Point(0, 0)
        PanelLogo.Name = "PanelLogo"
        PanelLogo.Size = New Size(284, 192)
        PanelLogo.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Logo
        PictureBox1.Location = New Point(68, 24)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(148, 139)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PanelTitleBar
        ' 
        PanelTitleBar.BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        PanelTitleBar.Controls.Add(btnMaximize)
        PanelTitleBar.Controls.Add(btnMinimize)
        PanelTitleBar.Controls.Add(btnExit)
        PanelTitleBar.Controls.Add(lblFormTitle)
        PanelTitleBar.Controls.Add(IconCurrentForm)
        PanelTitleBar.Dock = DockStyle.Top
        PanelTitleBar.Location = New Point(284, 0)
        PanelTitleBar.Name = "PanelTitleBar"
        PanelTitleBar.Size = New Size(900, 86)
        PanelTitleBar.TabIndex = 1
        ' 
        ' btnMaximize
        ' 
        btnMaximize.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMaximize.FlatAppearance.BorderSize = 0
        btnMaximize.FlatStyle = FlatStyle.Flat
        btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        btnMaximize.IconColor = Color.White
        btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnMaximize.IconSize = 30
        btnMaximize.Location = New Point(809, 3)
        btnMaximize.Name = "btnMaximize"
        btnMaximize.Size = New Size(40, 40)
        btnMaximize.TabIndex = 4
        btnMaximize.UseVisualStyleBackColor = True
        ' 
        ' btnMinimize
        ' 
        btnMinimize.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMinimize.FlatAppearance.BorderSize = 0
        btnMinimize.FlatStyle = FlatStyle.Flat
        btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Subtract
        btnMinimize.IconColor = Color.White
        btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnMinimize.IconSize = 30
        btnMinimize.Location = New Point(763, 3)
        btnMinimize.Name = "btnMinimize"
        btnMinimize.Size = New Size(40, 40)
        btnMinimize.TabIndex = 2
        btnMinimize.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.IconChar = FontAwesome.Sharp.IconChar.Close
        btnExit.IconColor = Color.White
        btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnExit.IconSize = 30
        btnExit.Location = New Point(855, 3)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(40, 40)
        btnExit.TabIndex = 3
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' lblFormTitle
        ' 
        lblFormTitle.AutoSize = True
        lblFormTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFormTitle.ForeColor = Color.White
        lblFormTitle.Location = New Point(65, 24)
        lblFormTitle.Name = "lblFormTitle"
        lblFormTitle.Size = New Size(167, 32)
        lblFormTitle.TabIndex = 1
        lblFormTitle.Text = "User Account"
        ' 
        ' IconCurrentForm
        ' 
        IconCurrentForm.BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.UserGear
        IconCurrentForm.IconColor = Color.White
        IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconCurrentForm.Location = New Point(27, 24)
        IconCurrentForm.Name = "IconCurrentForm"
        IconCurrentForm.Size = New Size(32, 32)
        IconCurrentForm.TabIndex = 0
        IconCurrentForm.TabStop = False
        ' 
        ' PanelDesktop
        ' 
        PanelDesktop.BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        PanelDesktop.Dock = DockStyle.Fill
        PanelDesktop.Location = New Point(284, 86)
        PanelDesktop.Name = "PanelDesktop"
        PanelDesktop.Size = New Size(900, 675)
        PanelDesktop.TabIndex = 2
        ' 
        ' AdminForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1184, 761)
        Controls.Add(PanelDesktop)
        Controls.Add(PanelTitleBar)
        Controls.Add(PanelMenu)
        MinimumSize = New Size(1100, 700)
        Name = "AdminForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AdminForm"
        PanelMenu.ResumeLayout(False)
        PanelLogo.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelTitleBar.ResumeLayout(False)
        PanelTitleBar.PerformLayout()
        CType(IconCurrentForm, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnUserAccount As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLogOut As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAccountList As FontAwesome.Sharp.IconButton
    Friend WithEvents btnProductReport As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSalesReport As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAdminAccount As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents btnMinimize As FontAwesome.Sharp.IconButton
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMaximize As FontAwesome.Sharp.IconButton
End Class
