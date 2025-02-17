<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserForm
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
        btnSales = New FontAwesome.Sharp.IconButton()
        btnDeleteItem = New FontAwesome.Sharp.IconButton()
        btnUpdateItem = New FontAwesome.Sharp.IconButton()
        btnAdditem = New FontAwesome.Sharp.IconButton()
        btnProductList = New FontAwesome.Sharp.IconButton()
        btnLogOut = New FontAwesome.Sharp.IconButton()
        btnDashboard = New FontAwesome.Sharp.IconButton()
        PanelLogo = New Panel()
        PictureBox1 = New PictureBox()
        PanelTitleBar = New Panel()
        btnExitUser = New FontAwesome.Sharp.IconButton()
        btnMaximizeUser = New FontAwesome.Sharp.IconButton()
        btnMinimizeUser = New FontAwesome.Sharp.IconButton()
        btnMaximize = New FontAwesome.Sharp.IconButton()
        btnMinimize = New FontAwesome.Sharp.IconButton()
        btnExit = New FontAwesome.Sharp.IconButton()
        lblFormTitleUser = New Label()
        IconCurrentFormUser = New FontAwesome.Sharp.IconPictureBox()
        PanelDesktop = New Panel()
        PanelMenu.SuspendLayout()
        PanelLogo.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelTitleBar.SuspendLayout()
        CType(IconCurrentFormUser, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelMenu
        ' 
        PanelMenu.BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        PanelMenu.Controls.Add(btnSales)
        PanelMenu.Controls.Add(btnDeleteItem)
        PanelMenu.Controls.Add(btnUpdateItem)
        PanelMenu.Controls.Add(btnAdditem)
        PanelMenu.Controls.Add(btnProductList)
        PanelMenu.Controls.Add(btnLogOut)
        PanelMenu.Controls.Add(btnDashboard)
        PanelMenu.Controls.Add(PanelLogo)
        PanelMenu.Dock = DockStyle.Left
        PanelMenu.Location = New Point(0, 0)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(284, 761)
        PanelMenu.TabIndex = 1
        ' 
        ' btnSales
        ' 
        btnSales.Dock = DockStyle.Top
        btnSales.FlatAppearance.BorderSize = 0
        btnSales.FlatStyle = FlatStyle.Flat
        btnSales.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSales.ForeColor = Color.White
        btnSales.IconChar = FontAwesome.Sharp.IconChar.Coins
        btnSales.IconColor = Color.White
        btnSales.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSales.IconSize = 32
        btnSales.ImageAlign = ContentAlignment.MiddleLeft
        btnSales.Location = New Point(0, 492)
        btnSales.Name = "btnSales"
        btnSales.Padding = New Padding(10, 0, 20, 0)
        btnSales.Size = New Size(284, 60)
        btnSales.TabIndex = 11
        btnSales.Text = "Sales"
        btnSales.TextAlign = ContentAlignment.MiddleLeft
        btnSales.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSales.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteItem
        ' 
        btnDeleteItem.Dock = DockStyle.Top
        btnDeleteItem.FlatAppearance.BorderSize = 0
        btnDeleteItem.FlatStyle = FlatStyle.Flat
        btnDeleteItem.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDeleteItem.ForeColor = Color.White
        btnDeleteItem.IconChar = FontAwesome.Sharp.IconChar.Subtract
        btnDeleteItem.IconColor = Color.White
        btnDeleteItem.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnDeleteItem.IconSize = 32
        btnDeleteItem.ImageAlign = ContentAlignment.MiddleLeft
        btnDeleteItem.Location = New Point(0, 432)
        btnDeleteItem.Name = "btnDeleteItem"
        btnDeleteItem.Padding = New Padding(10, 0, 20, 0)
        btnDeleteItem.Size = New Size(284, 60)
        btnDeleteItem.TabIndex = 10
        btnDeleteItem.Text = "Delete Item"
        btnDeleteItem.TextAlign = ContentAlignment.MiddleLeft
        btnDeleteItem.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDeleteItem.UseVisualStyleBackColor = True
        ' 
        ' btnUpdateItem
        ' 
        btnUpdateItem.Dock = DockStyle.Top
        btnUpdateItem.FlatAppearance.BorderSize = 0
        btnUpdateItem.FlatStyle = FlatStyle.Flat
        btnUpdateItem.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUpdateItem.ForeColor = Color.White
        btnUpdateItem.IconChar = FontAwesome.Sharp.IconChar.Pen
        btnUpdateItem.IconColor = Color.White
        btnUpdateItem.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnUpdateItem.IconSize = 32
        btnUpdateItem.ImageAlign = ContentAlignment.MiddleLeft
        btnUpdateItem.Location = New Point(0, 372)
        btnUpdateItem.Name = "btnUpdateItem"
        btnUpdateItem.Padding = New Padding(10, 0, 20, 0)
        btnUpdateItem.Size = New Size(284, 60)
        btnUpdateItem.TabIndex = 9
        btnUpdateItem.Text = "Update Item"
        btnUpdateItem.TextAlign = ContentAlignment.MiddleLeft
        btnUpdateItem.TextImageRelation = TextImageRelation.ImageBeforeText
        btnUpdateItem.UseVisualStyleBackColor = True
        ' 
        ' btnAdditem
        ' 
        btnAdditem.Dock = DockStyle.Top
        btnAdditem.FlatAppearance.BorderSize = 0
        btnAdditem.FlatStyle = FlatStyle.Flat
        btnAdditem.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAdditem.ForeColor = Color.White
        btnAdditem.IconChar = FontAwesome.Sharp.IconChar.Add
        btnAdditem.IconColor = Color.White
        btnAdditem.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnAdditem.IconSize = 32
        btnAdditem.ImageAlign = ContentAlignment.MiddleLeft
        btnAdditem.Location = New Point(0, 312)
        btnAdditem.Name = "btnAdditem"
        btnAdditem.Padding = New Padding(10, 0, 20, 0)
        btnAdditem.Size = New Size(284, 60)
        btnAdditem.TabIndex = 8
        btnAdditem.Text = "Add Item"
        btnAdditem.TextAlign = ContentAlignment.MiddleLeft
        btnAdditem.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAdditem.UseVisualStyleBackColor = True
        ' 
        ' btnProductList
        ' 
        btnProductList.Dock = DockStyle.Top
        btnProductList.FlatAppearance.BorderSize = 0
        btnProductList.FlatStyle = FlatStyle.Flat
        btnProductList.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnProductList.ForeColor = Color.White
        btnProductList.IconChar = FontAwesome.Sharp.IconChar.TableList
        btnProductList.IconColor = Color.White
        btnProductList.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnProductList.IconSize = 32
        btnProductList.ImageAlign = ContentAlignment.MiddleLeft
        btnProductList.Location = New Point(0, 252)
        btnProductList.Name = "btnProductList"
        btnProductList.Padding = New Padding(10, 0, 20, 0)
        btnProductList.Size = New Size(284, 60)
        btnProductList.TabIndex = 7
        btnProductList.Text = "Product List"
        btnProductList.TextAlign = ContentAlignment.MiddleLeft
        btnProductList.TextImageRelation = TextImageRelation.ImageBeforeText
        btnProductList.UseVisualStyleBackColor = True
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
        ' btnDashboard
        ' 
        btnDashboard.Dock = DockStyle.Top
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDashboard.ForeColor = Color.White
        btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        btnDashboard.IconColor = Color.White
        btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnDashboard.IconSize = 32
        btnDashboard.ImageAlign = ContentAlignment.MiddleLeft
        btnDashboard.Location = New Point(0, 192)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Padding = New Padding(10, 0, 20, 0)
        btnDashboard.Size = New Size(284, 60)
        btnDashboard.TabIndex = 1
        btnDashboard.Text = "Dashboard"
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDashboard.UseVisualStyleBackColor = True
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
        PanelTitleBar.Controls.Add(btnExitUser)
        PanelTitleBar.Controls.Add(btnMaximizeUser)
        PanelTitleBar.Controls.Add(btnMinimizeUser)
        PanelTitleBar.Controls.Add(btnMaximize)
        PanelTitleBar.Controls.Add(btnMinimize)
        PanelTitleBar.Controls.Add(btnExit)
        PanelTitleBar.Controls.Add(lblFormTitleUser)
        PanelTitleBar.Controls.Add(IconCurrentFormUser)
        PanelTitleBar.Dock = DockStyle.Top
        PanelTitleBar.Location = New Point(284, 0)
        PanelTitleBar.Name = "PanelTitleBar"
        PanelTitleBar.Size = New Size(900, 86)
        PanelTitleBar.TabIndex = 2
        ' 
        ' btnExitUser
        ' 
        btnExitUser.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnExitUser.FlatAppearance.BorderSize = 0
        btnExitUser.FlatStyle = FlatStyle.Flat
        btnExitUser.IconChar = FontAwesome.Sharp.IconChar.Close
        btnExitUser.IconColor = Color.White
        btnExitUser.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnExitUser.IconSize = 30
        btnExitUser.Location = New Point(855, 3)
        btnExitUser.Name = "btnExitUser"
        btnExitUser.Size = New Size(40, 40)
        btnExitUser.TabIndex = 7
        btnExitUser.UseVisualStyleBackColor = True
        ' 
        ' btnMaximizeUser
        ' 
        btnMaximizeUser.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMaximizeUser.FlatAppearance.BorderSize = 0
        btnMaximizeUser.FlatStyle = FlatStyle.Flat
        btnMaximizeUser.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        btnMaximizeUser.IconColor = Color.White
        btnMaximizeUser.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnMaximizeUser.IconSize = 30
        btnMaximizeUser.Location = New Point(809, 3)
        btnMaximizeUser.Name = "btnMaximizeUser"
        btnMaximizeUser.Size = New Size(40, 40)
        btnMaximizeUser.TabIndex = 6
        btnMaximizeUser.UseVisualStyleBackColor = True
        ' 
        ' btnMinimizeUser
        ' 
        btnMinimizeUser.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMinimizeUser.FlatAppearance.BorderSize = 0
        btnMinimizeUser.FlatStyle = FlatStyle.Flat
        btnMinimizeUser.IconChar = FontAwesome.Sharp.IconChar.Subtract
        btnMinimizeUser.IconColor = Color.White
        btnMinimizeUser.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnMinimizeUser.IconSize = 30
        btnMinimizeUser.Location = New Point(763, 3)
        btnMinimizeUser.Name = "btnMinimizeUser"
        btnMinimizeUser.Size = New Size(40, 40)
        btnMinimizeUser.TabIndex = 5
        btnMinimizeUser.UseVisualStyleBackColor = True
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
        btnMaximize.Location = New Point(1509, 3)
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
        btnMinimize.Location = New Point(1463, 3)
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
        btnExit.Location = New Point(1555, 3)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(40, 40)
        btnExit.TabIndex = 3
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' lblFormTitleUser
        ' 
        lblFormTitleUser.AutoSize = True
        lblFormTitleUser.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFormTitleUser.ForeColor = Color.White
        lblFormTitleUser.Location = New Point(65, 24)
        lblFormTitleUser.Name = "lblFormTitleUser"
        lblFormTitleUser.Size = New Size(138, 32)
        lblFormTitleUser.TabIndex = 1
        lblFormTitleUser.Text = "Dashboard"
        ' 
        ' IconCurrentFormUser
        ' 
        IconCurrentFormUser.BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        IconCurrentFormUser.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        IconCurrentFormUser.IconColor = Color.White
        IconCurrentFormUser.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconCurrentFormUser.Location = New Point(27, 24)
        IconCurrentFormUser.Name = "IconCurrentFormUser"
        IconCurrentFormUser.Size = New Size(32, 32)
        IconCurrentFormUser.TabIndex = 0
        IconCurrentFormUser.TabStop = False
        ' 
        ' PanelDesktop
        ' 
        PanelDesktop.BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        PanelDesktop.Dock = DockStyle.Fill
        PanelDesktop.Location = New Point(284, 86)
        PanelDesktop.Name = "PanelDesktop"
        PanelDesktop.Size = New Size(900, 675)
        PanelDesktop.TabIndex = 3
        ' 
        ' UserForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1184, 761)
        Controls.Add(PanelDesktop)
        Controls.Add(PanelTitleBar)
        Controls.Add(PanelMenu)
        MinimumSize = New Size(1100, 700)
        Name = "UserForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UserForm"
        PanelMenu.ResumeLayout(False)
        PanelLogo.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelTitleBar.ResumeLayout(False)
        PanelTitleBar.PerformLayout()
        CType(IconCurrentFormUser, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnLogOut As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents btnMaximize As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMinimize As FontAwesome.Sharp.IconButton
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents lblFormTitleUser As Label
    Friend WithEvents IconCurrentFormUser As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents btnSales As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDeleteItem As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUpdateItem As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAdditem As FontAwesome.Sharp.IconButton
    Friend WithEvents btnProductList As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMinimizeUser As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMaximizeUser As FontAwesome.Sharp.IconButton
    Friend WithEvents btnExitUser As FontAwesome.Sharp.IconButton
End Class
