﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
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
        PanelHeader = New Panel()
        Panel2 = New Panel()
        btnAddUserAccount = New FontAwesome.Sharp.IconButton()
        Panel1 = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        txtFirstName = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        PanelFooter = New Panel()
        Panel4 = New Panel()
        btnConfirmUserAccount = New FontAwesome.Sharp.IconButton()
        Panel8 = New Panel()
        dtgMonthly = New DataGridView()
        PanelHeader.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        PanelFooter.SuspendLayout()
        Panel4.SuspendLayout()
        Panel8.SuspendLayout()
        CType(dtgMonthly, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelHeader
        ' 
        PanelHeader.Controls.Add(Panel2)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(884, 76)
        PanelHeader.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnAddUserAccount)
        Panel2.Dock = DockStyle.Right
        Panel2.Location = New Point(722, 0)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(0, 20, 20, 0)
        Panel2.Size = New Size(162, 76)
        Panel2.TabIndex = 0
        ' 
        ' btnAddUserAccount
        ' 
        btnAddUserAccount.Dock = DockStyle.Fill
        btnAddUserAccount.FlatAppearance.BorderSize = 2
        btnAddUserAccount.FlatStyle = FlatStyle.Flat
        btnAddUserAccount.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnAddUserAccount.ForeColor = Color.White
        btnAddUserAccount.IconChar = FontAwesome.Sharp.IconChar.None
        btnAddUserAccount.IconColor = Color.Black
        btnAddUserAccount.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnAddUserAccount.Location = New Point(0, 20)
        btnAddUserAccount.Name = "btnAddUserAccount"
        btnAddUserAccount.Size = New Size(142, 56)
        btnAddUserAccount.TabIndex = 1
        btnAddUserAccount.Text = "Select Product"
        btnAddUserAccount.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TableLayoutPanel1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 76)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(884, 84)
        Panel1.TabIndex = 5
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Left
        TableLayoutPanel1.ColumnCount = 5
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 49.6666679F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 168F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 170F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 176F))
        TableLayoutPanel1.Controls.Add(TextBox4, 4, 1)
        TableLayoutPanel1.Controls.Add(TextBox3, 3, 1)
        TableLayoutPanel1.Controls.Add(TextBox2, 2, 1)
        TableLayoutPanel1.Controls.Add(TextBox1, 1, 1)
        TableLayoutPanel1.Controls.Add(txtFirstName, 0, 1)
        TableLayoutPanel1.Controls.Add(Label5, 4, 0)
        TableLayoutPanel1.Controls.Add(Label4, 3, 0)
        TableLayoutPanel1.Controls.Add(Label3, 2, 0)
        TableLayoutPanel1.Controls.Add(Label1, 1, 0)
        TableLayoutPanel1.Controls.Add(Label2, 0, 0)
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.Padding = New Padding(20, 0, 20, 0)
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(884, 84)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' TextBox4
        ' 
        TextBox4.Dock = DockStyle.Fill
        TextBox4.Font = New Font("Segoe UI", 12F)
        TextBox4.Location = New Point(690, 45)
        TextBox4.MaximumSize = New Size(300, 50)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(171, 29)
        TextBox4.TabIndex = 14
        ' 
        ' TextBox3
        ' 
        TextBox3.Dock = DockStyle.Fill
        TextBox3.Font = New Font("Segoe UI", 12F)
        TextBox3.Location = New Point(520, 45)
        TextBox3.MaximumSize = New Size(300, 50)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(164, 29)
        TextBox3.TabIndex = 13
        ' 
        ' TextBox2
        ' 
        TextBox2.Dock = DockStyle.Fill
        TextBox2.Font = New Font("Segoe UI", 12F)
        TextBox2.Location = New Point(352, 45)
        TextBox2.MaximumSize = New Size(300, 50)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(162, 29)
        TextBox2.TabIndex = 12
        ' 
        ' TextBox1
        ' 
        TextBox1.Dock = DockStyle.Fill
        TextBox1.Font = New Font("Segoe UI", 12F)
        TextBox1.Location = New Point(186, 45)
        TextBox1.MaximumSize = New Size(300, 50)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(160, 29)
        TextBox1.TabIndex = 11
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Dock = DockStyle.Fill
        txtFirstName.Font = New Font("Segoe UI", 12F)
        txtFirstName.Location = New Point(23, 45)
        txtFirstName.MaximumSize = New Size(300, 50)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(157, 29)
        txtFirstName.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Dock = DockStyle.Left
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(690, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(146, 42)
        Label5.TabIndex = 6
        Label5.Text = "Remaining Stocks"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Dock = DockStyle.Left
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(520, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 42)
        Label4.TabIndex = 5
        Label4.Text = "Subtotal"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Left
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(352, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 42)
        Label3.TabIndex = 4
        Label3.Text = "No. of Items"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Left
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(186, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(48, 42)
        Label1.TabIndex = 3
        Label1.Text = "Price"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Left
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(23, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 42)
        Label2.TabIndex = 2
        Label2.Text = "Product Name"
        ' 
        ' PanelFooter
        ' 
        PanelFooter.Controls.Add(Panel4)
        PanelFooter.Dock = DockStyle.Bottom
        PanelFooter.Location = New Point(0, 560)
        PanelFooter.Name = "PanelFooter"
        PanelFooter.Size = New Size(884, 76)
        PanelFooter.TabIndex = 6
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(btnConfirmUserAccount)
        Panel4.Dock = DockStyle.Right
        Panel4.Location = New Point(768, 0)
        Panel4.Name = "Panel4"
        Panel4.Padding = New Padding(0, 0, 20, 20)
        Panel4.Size = New Size(116, 76)
        Panel4.TabIndex = 0
        ' 
        ' btnConfirmUserAccount
        ' 
        btnConfirmUserAccount.Dock = DockStyle.Fill
        btnConfirmUserAccount.FlatAppearance.BorderSize = 2
        btnConfirmUserAccount.FlatStyle = FlatStyle.Flat
        btnConfirmUserAccount.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnConfirmUserAccount.ForeColor = Color.White
        btnConfirmUserAccount.IconChar = FontAwesome.Sharp.IconChar.None
        btnConfirmUserAccount.IconColor = Color.Black
        btnConfirmUserAccount.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnConfirmUserAccount.Location = New Point(0, 0)
        btnConfirmUserAccount.Name = "btnConfirmUserAccount"
        btnConfirmUserAccount.Size = New Size(96, 56)
        btnConfirmUserAccount.TabIndex = 2
        btnConfirmUserAccount.Text = "Confirm"
        btnConfirmUserAccount.UseVisualStyleBackColor = True
        ' 
        ' Panel8
        ' 
        Panel8.Controls.Add(dtgMonthly)
        Panel8.Dock = DockStyle.Fill
        Panel8.Location = New Point(0, 160)
        Panel8.Name = "Panel8"
        Panel8.Padding = New Padding(20)
        Panel8.Size = New Size(884, 400)
        Panel8.TabIndex = 7
        ' 
        ' dtgMonthly
        ' 
        dtgMonthly.BackgroundColor = Color.White
        dtgMonthly.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgMonthly.Dock = DockStyle.Fill
        dtgMonthly.Location = New Point(20, 20)
        dtgMonthly.Name = "dtgMonthly"
        dtgMonthly.Size = New Size(844, 360)
        dtgMonthly.TabIndex = 0
        ' 
        ' frmSales
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        ClientSize = New Size(884, 636)
        Controls.Add(Panel8)
        Controls.Add(PanelFooter)
        Controls.Add(Panel1)
        Controls.Add(PanelHeader)
        Name = "frmSales"
        Text = "Sales"
        PanelHeader.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        PanelFooter.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        CType(dtgMonthly, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnAddUserAccount As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents PanelFooter As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnConfirmUserAccount As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel8 As Panel
    Friend WithEvents dtgMonthly As DataGridView
End Class
