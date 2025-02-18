<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddItem
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
        Label1 = New Label()
        PanelMain = New Panel()
        PanelFooter = New Panel()
        Panel4 = New Panel()
        btnConfirmUserAccount = New FontAwesome.Sharp.IconButton()
        TableLayoutPanel3 = New TableLayoutPanel()
        Label9 = New Label()
        Label6 = New Label()
        ComboBox3 = New ComboBox()
        TableLayoutPanel4 = New TableLayoutPanel()
        IconButton2 = New FontAwesome.Sharp.IconButton()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        TableLayoutPanel2 = New TableLayoutPanel()
        TextBox1 = New TextBox()
        ComboBox2 = New ComboBox()
        Label7 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        DateTimePicker1 = New DateTimePicker()
        TableLayoutPanel1 = New TableLayoutPanel()
        TextBox2 = New TextBox()
        ComboBox1 = New ComboBox()
        txtFirstName = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label8 = New Label()
        Panel1.SuspendLayout()
        PanelMain.SuspendLayout()
        PanelFooter.SuspendLayout()
        Panel4.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(20, 0, 0, 0)
        Panel1.Size = New Size(884, 54)
        Panel1.TabIndex = 18
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Left
        Label1.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(20, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(274, 47)
        Label1.TabIndex = 0
        Label1.Text = "Product Details"
        ' 
        ' PanelMain
        ' 
        PanelMain.Controls.Add(PanelFooter)
        PanelMain.Controls.Add(TableLayoutPanel3)
        PanelMain.Controls.Add(TableLayoutPanel2)
        PanelMain.Controls.Add(TableLayoutPanel1)
        PanelMain.Dock = DockStyle.Fill
        PanelMain.Location = New Point(0, 54)
        PanelMain.Name = "PanelMain"
        PanelMain.Size = New Size(884, 582)
        PanelMain.TabIndex = 19
        ' 
        ' PanelFooter
        ' 
        PanelFooter.Controls.Add(Panel4)
        PanelFooter.Dock = DockStyle.Bottom
        PanelFooter.Location = New Point(0, 506)
        PanelFooter.Name = "PanelFooter"
        PanelFooter.Size = New Size(884, 76)
        PanelFooter.TabIndex = 21
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
        btnConfirmUserAccount.Text = "Next"
        btnConfirmUserAccount.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 3
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 49.29078F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.70922F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 279F))
        TableLayoutPanel3.Controls.Add(Label9, 0, 0)
        TableLayoutPanel3.Controls.Add(Label6, 1, 0)
        TableLayoutPanel3.Controls.Add(ComboBox3, 0, 1)
        TableLayoutPanel3.Controls.Add(TableLayoutPanel4, 1, 1)
        TableLayoutPanel3.Dock = DockStyle.Top
        TableLayoutPanel3.Location = New Point(0, 215)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.Padding = New Padding(20, 20, 20, 0)
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 36.9863F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 63.0137F))
        TableLayoutPanel3.Size = New Size(884, 93)
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
        Label9.Size = New Size(272, 27)
        Label9.TabIndex = 8
        Label9.Text = "Product Location"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(301, 20)
        Label6.Name = "Label6"
        Label6.Size = New Size(122, 27)
        Label6.TabIndex = 5
        Label6.Text = "Product Image"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ComboBox3.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox3.Font = New Font("Segoe UI", 12F)
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"Male", "Female"})
        ComboBox3.Location = New Point(23, 50)
        ComboBox3.MaximumSize = New Size(300, 0)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(272, 29)
        ComboBox3.TabIndex = 17
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 2
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Controls.Add(IconButton2, 0, 0)
        TableLayoutPanel4.Controls.Add(IconButton1, 1, 0)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(301, 50)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Size = New Size(280, 40)
        TableLayoutPanel4.TabIndex = 19
        ' 
        ' IconButton2
        ' 
        IconButton2.Dock = DockStyle.Fill
        IconButton2.FlatAppearance.BorderSize = 2
        IconButton2.FlatStyle = FlatStyle.Flat
        IconButton2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        IconButton2.ForeColor = Color.White
        IconButton2.IconChar = FontAwesome.Sharp.IconChar.None
        IconButton2.IconColor = Color.Black
        IconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton2.Location = New Point(3, 3)
        IconButton2.Name = "IconButton2"
        IconButton2.Size = New Size(134, 34)
        IconButton2.TabIndex = 19
        IconButton2.Text = "Add"
        IconButton2.UseVisualStyleBackColor = True
        ' 
        ' IconButton1
        ' 
        IconButton1.Dock = DockStyle.Fill
        IconButton1.FlatAppearance.BorderSize = 2
        IconButton1.FlatStyle = FlatStyle.Flat
        IconButton1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        IconButton1.ForeColor = Color.White
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.None
        IconButton1.IconColor = Color.Black
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.Location = New Point(143, 3)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(134, 34)
        IconButton1.TabIndex = 18
        IconButton1.Text = "View"
        IconButton1.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 49.20354F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.79646F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 298F))
        TableLayoutPanel2.Controls.Add(TextBox1, 0, 1)
        TableLayoutPanel2.Controls.Add(ComboBox2, 2, 1)
        TableLayoutPanel2.Controls.Add(Label7, 0, 0)
        TableLayoutPanel2.Controls.Add(Label4, 1, 0)
        TableLayoutPanel2.Controls.Add(Label5, 2, 0)
        TableLayoutPanel2.Controls.Add(DateTimePicker1, 1, 1)
        TableLayoutPanel2.Dock = DockStyle.Top
        TableLayoutPanel2.Location = New Point(0, 107)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.Padding = New Padding(20, 20, 0, 20)
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(884, 108)
        TableLayoutPanel2.TabIndex = 19
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox1.Font = New Font("Segoe UI", 12F)
        TextBox1.Location = New Point(23, 57)
        TextBox1.MaximumSize = New Size(300, 50)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(272, 29)
        TextBox1.TabIndex = 18
        ' 
        ' ComboBox2
        ' 
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.Font = New Font("Segoe UI", 12F)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Male", "Female"})
        ComboBox2.Location = New Point(588, 57)
        ComboBox2.MaximumSize = New Size(300, 0)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(272, 29)
        ComboBox2.TabIndex = 17
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
        Label7.Text = "Model Number"
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
        Label4.Text = "Purchase Date"
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
        Label5.Text = "Warranty Expiration"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Dock = DockStyle.Fill
        DateTimePicker1.Font = New Font("Segoe UI", 12F)
        DateTimePicker1.Location = New Point(301, 57)
        DateTimePicker1.MaximumSize = New Size(300, 50)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(281, 29)
        DateTimePicker1.TabIndex = 15
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 49.09091F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.90909F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 278F))
        TableLayoutPanel1.Controls.Add(TextBox2, 2, 1)
        TableLayoutPanel1.Controls.Add(ComboBox1, 1, 1)
        TableLayoutPanel1.Controls.Add(txtFirstName, 0, 1)
        TableLayoutPanel1.Controls.Add(Label2, 0, 0)
        TableLayoutPanel1.Controls.Add(Label3, 1, 0)
        TableLayoutPanel1.Controls.Add(Label8, 2, 0)
        TableLayoutPanel1.Dock = DockStyle.Top
        TableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.Padding = New Padding(20, 20, 20, 0)
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 44.2857132F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 55.7142868F))
        TableLayoutPanel1.Size = New Size(884, 107)
        TableLayoutPanel1.TabIndex = 18
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox2.Font = New Font("Segoe UI", 12F)
        TextBox2.Location = New Point(588, 61)
        TextBox2.MaximumSize = New Size(300, 50)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(273, 29)
        TextBox2.TabIndex = 19
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Segoe UI", 12F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Male", "Female"})
        ComboBox1.Location = New Point(300, 61)
        ComboBox1.MaximumSize = New Size(300, 0)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(282, 29)
        ComboBox1.TabIndex = 17
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
        Label2.Text = "Product Name"
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
        Label3.Text = "Type"
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
        Label8.Text = "Brand"
        ' 
        ' frmAddItem
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        ClientSize = New Size(884, 636)
        Controls.Add(PanelMain)
        Controls.Add(Panel1)
        Name = "frmAddItem"
        Text = "Add Item"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        PanelMain.ResumeLayout(False)
        PanelFooter.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelMain As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PanelFooter As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnConfirmUserAccount As FontAwesome.Sharp.IconButton
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
