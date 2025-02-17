<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountList
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
        AccountListPanel = New Panel()
        Panel9 = New Panel()
        dtgAdmin = New DataGridView()
        Panel1 = New Panel()
        Label1 = New Label()
        Panel4 = New Panel()
        btnUserAccount = New FontAwesome.Sharp.IconButton()
        Panel5 = New Panel()
        btnAdminAccount = New FontAwesome.Sharp.IconButton()
        PanelHeader = New Panel()
        Panel3 = New Panel()
        btnSearchAccountList = New FontAwesome.Sharp.IconButton()
        Panel2 = New Panel()
        txtSearchAccountList = New TextBox()
        AccountListPanel.SuspendLayout()
        Panel9.SuspendLayout()
        CType(dtgAdmin, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        PanelHeader.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' AccountListPanel
        ' 
        AccountListPanel.Controls.Add(Panel9)
        AccountListPanel.Controls.Add(Panel1)
        AccountListPanel.Controls.Add(PanelHeader)
        AccountListPanel.Dock = DockStyle.Fill
        AccountListPanel.Location = New Point(0, 0)
        AccountListPanel.Name = "AccountListPanel"
        AccountListPanel.Size = New Size(884, 636)
        AccountListPanel.TabIndex = 0
        ' 
        ' Panel9
        ' 
        Panel9.Controls.Add(dtgAdmin)
        Panel9.Dock = DockStyle.Fill
        Panel9.Location = New Point(0, 152)
        Panel9.Name = "Panel9"
        Panel9.Padding = New Padding(20)
        Panel9.Size = New Size(884, 484)
        Panel9.TabIndex = 6
        ' 
        ' dtgAdmin
        ' 
        dtgAdmin.BackgroundColor = Color.White
        dtgAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgAdmin.Dock = DockStyle.Fill
        dtgAdmin.Location = New Point(20, 20)
        dtgAdmin.Name = "dtgAdmin"
        dtgAdmin.Size = New Size(844, 444)
        dtgAdmin.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel5)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 76)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(884, 76)
        Panel1.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Bottom
        Label1.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(0, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(332, 47)
        Label1.TabIndex = 2
        Label1.Text = "Available Accounts"
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(btnUserAccount)
        Panel4.Dock = DockStyle.Right
        Panel4.Location = New Point(606, 0)
        Panel4.Name = "Panel4"
        Panel4.Padding = New Padding(0, 35, 20, 0)
        Panel4.Size = New Size(139, 76)
        Panel4.TabIndex = 1
        ' 
        ' btnUserAccount
        ' 
        btnUserAccount.Dock = DockStyle.Fill
        btnUserAccount.FlatAppearance.BorderSize = 2
        btnUserAccount.FlatStyle = FlatStyle.Flat
        btnUserAccount.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUserAccount.ForeColor = Color.White
        btnUserAccount.IconChar = FontAwesome.Sharp.IconChar.None
        btnUserAccount.IconColor = Color.Black
        btnUserAccount.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnUserAccount.Location = New Point(0, 35)
        btnUserAccount.Name = "btnUserAccount"
        btnUserAccount.Size = New Size(119, 41)
        btnUserAccount.TabIndex = 0
        btnUserAccount.Text = "User Account"
        btnUserAccount.UseVisualStyleBackColor = True
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(btnAdminAccount)
        Panel5.Dock = DockStyle.Right
        Panel5.Location = New Point(745, 0)
        Panel5.Name = "Panel5"
        Panel5.Padding = New Padding(0, 35, 20, 0)
        Panel5.Size = New Size(139, 76)
        Panel5.TabIndex = 0
        ' 
        ' btnAdminAccount
        ' 
        btnAdminAccount.Dock = DockStyle.Fill
        btnAdminAccount.FlatAppearance.BorderSize = 2
        btnAdminAccount.FlatStyle = FlatStyle.Flat
        btnAdminAccount.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdminAccount.ForeColor = Color.White
        btnAdminAccount.IconChar = FontAwesome.Sharp.IconChar.None
        btnAdminAccount.IconColor = Color.Black
        btnAdminAccount.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnAdminAccount.Location = New Point(0, 35)
        btnAdminAccount.Name = "btnAdminAccount"
        btnAdminAccount.Size = New Size(119, 41)
        btnAdminAccount.TabIndex = 1
        btnAdminAccount.Text = "Admin Account"
        btnAdminAccount.UseVisualStyleBackColor = True
        ' 
        ' PanelHeader
        ' 
        PanelHeader.Controls.Add(Panel3)
        PanelHeader.Controls.Add(Panel2)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(884, 76)
        PanelHeader.TabIndex = 4
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(btnSearchAccountList)
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(528, 0)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(0, 40, 15, 0)
        Panel3.Size = New Size(130, 76)
        Panel3.TabIndex = 1
        ' 
        ' btnSearchAccountList
        ' 
        btnSearchAccountList.Dock = DockStyle.Fill
        btnSearchAccountList.FlatAppearance.BorderSize = 2
        btnSearchAccountList.FlatStyle = FlatStyle.Flat
        btnSearchAccountList.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnSearchAccountList.ForeColor = Color.White
        btnSearchAccountList.IconChar = FontAwesome.Sharp.IconChar.None
        btnSearchAccountList.IconColor = Color.Black
        btnSearchAccountList.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSearchAccountList.Location = New Point(0, 40)
        btnSearchAccountList.Name = "btnSearchAccountList"
        btnSearchAccountList.Size = New Size(115, 36)
        btnSearchAccountList.TabIndex = 0
        btnSearchAccountList.Text = "Search"
        btnSearchAccountList.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(txtSearchAccountList)
        Panel2.Dock = DockStyle.Right
        Panel2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel2.Location = New Point(658, 0)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(0, 40, 20, 0)
        Panel2.Size = New Size(226, 76)
        Panel2.TabIndex = 0
        ' 
        ' txtSearchAccountList
        ' 
        txtSearchAccountList.Dock = DockStyle.Fill
        txtSearchAccountList.Location = New Point(0, 40)
        txtSearchAccountList.Name = "txtSearchAccountList"
        txtSearchAccountList.Size = New Size(206, 33)
        txtSearchAccountList.TabIndex = 3
        ' 
        ' frmAccountList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        ClientSize = New Size(884, 636)
        Controls.Add(AccountListPanel)
        Name = "frmAccountList"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Account List"
        AccountListPanel.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        CType(dtgAdmin, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        PanelHeader.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents AccountListPanel As Panel
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnSearchAccountList As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtSearchAccountList As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnUserAccount As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnAdminAccount As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel9 As Panel
    Friend WithEvents dtgAdmin As DataGridView
    Friend WithEvents Label1 As Label
End Class
