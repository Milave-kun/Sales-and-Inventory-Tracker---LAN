<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserAccount
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
        Panel3 = New Panel()
        btnUpdateUserAccount = New FontAwesome.Sharp.IconButton()
        Panel2 = New Panel()
        btnAddUserAccount = New FontAwesome.Sharp.IconButton()
        PanelFooter = New Panel()
        Panel4 = New Panel()
        btnConfirmUserAccount = New FontAwesome.Sharp.IconButton()
        Panel1 = New Panel()
        Label1 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        txtLastName = New TextBox()
        txtFirstName = New TextBox()
        txtMiddleName = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label8 = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        cmbGender = New ComboBox()
        Label7 = New Label()
        Label4 = New Label()
        DateTimePicker1 = New DateTimePicker()
        txtContactNumber = New TextBox()
        Label5 = New Label()
        TableLayoutPanel3 = New TableLayoutPanel()
        Label9 = New Label()
        txtUserName = New TextBox()
        txtPassword = New TextBox()
        Label6 = New Label()
        PanelMain = New Panel()
        PanelHeader.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        PanelFooter.SuspendLayout()
        Panel4.SuspendLayout()
        Panel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        PanelMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelHeader
        ' 
        PanelHeader.Controls.Add(Panel3)
        PanelHeader.Controls.Add(Panel2)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(884, 76)
        PanelHeader.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(btnUpdateUserAccount)
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(652, 0)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(0, 20, 20, 0)
        Panel3.Size = New Size(116, 76)
        Panel3.TabIndex = 1
        ' 
        ' btnUpdateUserAccount
        ' 
        btnUpdateUserAccount.Dock = DockStyle.Fill
        btnUpdateUserAccount.FlatAppearance.BorderSize = 2
        btnUpdateUserAccount.FlatStyle = FlatStyle.Flat
        btnUpdateUserAccount.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnUpdateUserAccount.ForeColor = Color.White
        btnUpdateUserAccount.IconChar = FontAwesome.Sharp.IconChar.None
        btnUpdateUserAccount.IconColor = Color.Black
        btnUpdateUserAccount.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnUpdateUserAccount.Location = New Point(0, 20)
        btnUpdateUserAccount.Name = "btnUpdateUserAccount"
        btnUpdateUserAccount.Size = New Size(96, 56)
        btnUpdateUserAccount.TabIndex = 0
        btnUpdateUserAccount.Text = "Update"
        btnUpdateUserAccount.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnAddUserAccount)
        Panel2.Dock = DockStyle.Right
        Panel2.Location = New Point(768, 0)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(0, 20, 20, 0)
        Panel2.Size = New Size(116, 76)
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
        btnAddUserAccount.Size = New Size(96, 56)
        btnAddUserAccount.TabIndex = 1
        btnAddUserAccount.Text = "Add"
        btnAddUserAccount.UseVisualStyleBackColor = True
        ' 
        ' PanelFooter
        ' 
        PanelFooter.Controls.Add(Panel4)
        PanelFooter.Dock = DockStyle.Bottom
        PanelFooter.Location = New Point(0, 560)
        PanelFooter.Name = "PanelFooter"
        PanelFooter.Size = New Size(884, 76)
        PanelFooter.TabIndex = 2
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
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(20, 0, 0, 0)
        Panel1.Size = New Size(884, 54)
        Panel1.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Left
        Label1.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(20, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(363, 47)
        Label1.TabIndex = 0
        Label1.Text = "Account Information"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 49.09091F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.90909F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 278F))
        TableLayoutPanel1.Controls.Add(txtLastName, 1, 1)
        TableLayoutPanel1.Controls.Add(txtFirstName, 0, 1)
        TableLayoutPanel1.Controls.Add(txtMiddleName, 2, 1)
        TableLayoutPanel1.Controls.Add(Label2, 0, 0)
        TableLayoutPanel1.Controls.Add(Label3, 1, 0)
        TableLayoutPanel1.Controls.Add(Label8, 2, 0)
        TableLayoutPanel1.Dock = DockStyle.Top
        TableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize
        TableLayoutPanel1.Location = New Point(0, 54)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.Padding = New Padding(20, 20, 20, 0)
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 44.2857132F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 55.7142868F))
        TableLayoutPanel1.Size = New Size(884, 107)
        TableLayoutPanel1.TabIndex = 18
        ' 
        ' txtLastName
        ' 
        txtLastName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtLastName.Font = New Font("Segoe UI", 12F)
        txtLastName.Location = New Point(300, 61)
        txtLastName.MaximumSize = New Size(300, 50)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(282, 29)
        txtLastName.TabIndex = 10
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtFirstName.Font = New Font("Segoe UI", 12F)
        txtFirstName.Location = New Point(23, 61)
        txtFirstName.MaximumSize = New Size(300, 50)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(271, 29)
        txtFirstName.TabIndex = 9
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtMiddleName.Font = New Font("Segoe UI", 12F)
        txtMiddleName.Location = New Point(588, 61)
        txtMiddleName.MaximumSize = New Size(300, 50)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(273, 29)
        txtMiddleName.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(23, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(271, 38)
        Label2.TabIndex = 1
        Label2.Text = "First Name"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(300, 20)
        Label3.Name = "Label3"
        Label3.Size = New Size(282, 38)
        Label3.TabIndex = 2
        Label3.Text = "Last Name"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(588, 20)
        Label8.Name = "Label8"
        Label8.Size = New Size(273, 38)
        Label8.TabIndex = 7
        Label8.Text = "Middle Name"
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 49.20354F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.79646F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 298F))
        TableLayoutPanel2.Controls.Add(cmbGender, 0, 1)
        TableLayoutPanel2.Controls.Add(Label7, 0, 0)
        TableLayoutPanel2.Controls.Add(Label4, 1, 0)
        TableLayoutPanel2.Controls.Add(DateTimePicker1, 2, 1)
        TableLayoutPanel2.Controls.Add(txtContactNumber, 1, 1)
        TableLayoutPanel2.Controls.Add(Label5, 2, 0)
        TableLayoutPanel2.Dock = DockStyle.Top
        TableLayoutPanel2.Location = New Point(0, 161)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.Padding = New Padding(20, 20, 0, 20)
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(884, 108)
        TableLayoutPanel2.TabIndex = 19
        ' 
        ' cmbGender
        ' 
        cmbGender.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        cmbGender.DropDownStyle = ComboBoxStyle.DropDownList
        cmbGender.Font = New Font("Segoe UI", 12F)
        cmbGender.FormattingEnabled = True
        cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        cmbGender.Location = New Point(23, 57)
        cmbGender.MaximumSize = New Size(300, 0)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(272, 29)
        cmbGender.TabIndex = 16
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(23, 20)
        Label7.Name = "Label7"
        Label7.Size = New Size(272, 34)
        Label7.TabIndex = 6
        Label7.Text = "Gender"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(301, 20)
        Label4.Name = "Label4"
        Label4.Size = New Size(281, 34)
        Label4.TabIndex = 3
        Label4.Text = "Contact Number"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        DateTimePicker1.Font = New Font("Segoe UI", 12F)
        DateTimePicker1.Location = New Point(588, 57)
        DateTimePicker1.MaximumSize = New Size(300, 50)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(273, 29)
        DateTimePicker1.TabIndex = 15
        ' 
        ' txtContactNumber
        ' 
        txtContactNumber.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtContactNumber.Font = New Font("Segoe UI", 12F)
        txtContactNumber.Location = New Point(301, 57)
        txtContactNumber.MaximumSize = New Size(300, 50)
        txtContactNumber.Name = "txtContactNumber"
        txtContactNumber.Size = New Size(281, 29)
        txtContactNumber.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(588, 20)
        Label5.Name = "Label5"
        Label5.Size = New Size(293, 34)
        Label5.TabIndex = 4
        Label5.Text = "Date Added"
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 3
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 49.29078F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.70922F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 279F))
        TableLayoutPanel3.Controls.Add(Label9, 0, 0)
        TableLayoutPanel3.Controls.Add(txtUserName, 0, 1)
        TableLayoutPanel3.Controls.Add(txtPassword, 1, 1)
        TableLayoutPanel3.Controls.Add(Label6, 1, 0)
        TableLayoutPanel3.Dock = DockStyle.Top
        TableLayoutPanel3.Location = New Point(0, 269)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.Padding = New Padding(20, 20, 20, 0)
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(884, 100)
        TableLayoutPanel3.TabIndex = 20
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(23, 20)
        Label9.Name = "Label9"
        Label9.Size = New Size(272, 40)
        Label9.TabIndex = 8
        Label9.Text = "Username"
        ' 
        ' txtUserName
        ' 
        txtUserName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtUserName.Font = New Font("Segoe UI", 12F)
        txtUserName.Location = New Point(23, 63)
        txtUserName.MaximumSize = New Size(300, 50)
        txtUserName.Name = "txtUserName"
        txtUserName.Size = New Size(272, 29)
        txtUserName.TabIndex = 13
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtPassword.Font = New Font("Segoe UI", 12F)
        txtPassword.Location = New Point(301, 63)
        txtPassword.MaximumSize = New Size(300, 50)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(280, 29)
        txtPassword.TabIndex = 14
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(301, 20)
        Label6.Name = "Label6"
        Label6.Size = New Size(82, 40)
        Label6.TabIndex = 5
        Label6.Text = "Password"
        ' 
        ' PanelMain
        ' 
        PanelMain.Controls.Add(TableLayoutPanel3)
        PanelMain.Controls.Add(TableLayoutPanel2)
        PanelMain.Controls.Add(TableLayoutPanel1)
        PanelMain.Controls.Add(Panel1)
        PanelMain.Dock = DockStyle.Fill
        PanelMain.Location = New Point(0, 76)
        PanelMain.Name = "PanelMain"
        PanelMain.Size = New Size(884, 560)
        PanelMain.TabIndex = 1
        ' 
        ' frmUserAccount
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        ClientSize = New Size(884, 636)
        Controls.Add(PanelFooter)
        Controls.Add(PanelMain)
        Controls.Add(PanelHeader)
        Name = "frmUserAccount"
        Text = "User Account"
        PanelHeader.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        PanelFooter.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        PanelMain.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents btnAddUserAccount As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUpdateUserAccount As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelFooter As Panel
    Friend WithEvents btnConfirmUserAccount As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PanelMain As Panel
End Class
