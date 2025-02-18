<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductList
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
        btnSearch = New FontAwesome.Sharp.IconButton()
        Panel2 = New Panel()
        txtSearch = New TextBox()
        Panel1 = New Panel()
        Panel7 = New Panel()
        btnAudioDevices = New FontAwesome.Sharp.IconButton()
        Panel6 = New Panel()
        btnStorageDevices = New FontAwesome.Sharp.IconButton()
        Panel5 = New Panel()
        btnMobileDevices = New FontAwesome.Sharp.IconButton()
        Panel4 = New Panel()
        btnComputerLaptop = New FontAwesome.Sharp.IconButton()
        Panel8 = New Panel()
        dtgAudio = New DataGridView()
        PanelHeader.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel7.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel8.SuspendLayout()
        CType(dtgAudio, ComponentModel.ISupportInitialize).BeginInit()
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
        PanelHeader.TabIndex = 5
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(btnSearch)
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(528, 0)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(0, 40, 15, 0)
        Panel3.Size = New Size(130, 76)
        Panel3.TabIndex = 1
        ' 
        ' btnSearch
        ' 
        btnSearch.Dock = DockStyle.Fill
        btnSearch.FlatAppearance.BorderSize = 2
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnSearch.ForeColor = Color.White
        btnSearch.IconChar = FontAwesome.Sharp.IconChar.None
        btnSearch.IconColor = Color.Black
        btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSearch.Location = New Point(0, 40)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(115, 36)
        btnSearch.TabIndex = 0
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(txtSearch)
        Panel2.Dock = DockStyle.Right
        Panel2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel2.Location = New Point(658, 0)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(0, 40, 20, 0)
        Panel2.Size = New Size(226, 76)
        Panel2.TabIndex = 0
        ' 
        ' txtSearch
        ' 
        txtSearch.Dock = DockStyle.Fill
        txtSearch.Location = New Point(0, 40)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(206, 33)
        txtSearch.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel4)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 76)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(884, 84)
        Panel1.TabIndex = 6
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(btnAudioDevices)
        Panel7.Dock = DockStyle.Left
        Panel7.Location = New Point(486, 0)
        Panel7.Name = "Panel7"
        Panel7.Padding = New Padding(20)
        Panel7.Size = New Size(162, 84)
        Panel7.TabIndex = 3
        ' 
        ' btnAudioDevices
        ' 
        btnAudioDevices.Dock = DockStyle.Fill
        btnAudioDevices.FlatAppearance.BorderSize = 2
        btnAudioDevices.FlatStyle = FlatStyle.Flat
        btnAudioDevices.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAudioDevices.ForeColor = Color.White
        btnAudioDevices.IconChar = FontAwesome.Sharp.IconChar.None
        btnAudioDevices.IconColor = Color.Black
        btnAudioDevices.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnAudioDevices.Location = New Point(20, 20)
        btnAudioDevices.Name = "btnAudioDevices"
        btnAudioDevices.Size = New Size(122, 44)
        btnAudioDevices.TabIndex = 4
        btnAudioDevices.Text = "Audio Devices"
        btnAudioDevices.UseVisualStyleBackColor = True
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(btnStorageDevices)
        Panel6.Dock = DockStyle.Left
        Panel6.Location = New Point(324, 0)
        Panel6.Name = "Panel6"
        Panel6.Padding = New Padding(20)
        Panel6.Size = New Size(162, 84)
        Panel6.TabIndex = 2
        ' 
        ' btnStorageDevices
        ' 
        btnStorageDevices.Dock = DockStyle.Fill
        btnStorageDevices.FlatAppearance.BorderSize = 2
        btnStorageDevices.FlatStyle = FlatStyle.Flat
        btnStorageDevices.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnStorageDevices.ForeColor = Color.White
        btnStorageDevices.IconChar = FontAwesome.Sharp.IconChar.None
        btnStorageDevices.IconColor = Color.Black
        btnStorageDevices.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnStorageDevices.Location = New Point(20, 20)
        btnStorageDevices.Name = "btnStorageDevices"
        btnStorageDevices.Size = New Size(122, 44)
        btnStorageDevices.TabIndex = 3
        btnStorageDevices.Text = "Storage Devices"
        btnStorageDevices.UseVisualStyleBackColor = True
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(btnMobileDevices)
        Panel5.Dock = DockStyle.Left
        Panel5.Location = New Point(162, 0)
        Panel5.Name = "Panel5"
        Panel5.Padding = New Padding(20)
        Panel5.Size = New Size(162, 84)
        Panel5.TabIndex = 1
        ' 
        ' btnMobileDevices
        ' 
        btnMobileDevices.Dock = DockStyle.Fill
        btnMobileDevices.FlatAppearance.BorderSize = 2
        btnMobileDevices.FlatStyle = FlatStyle.Flat
        btnMobileDevices.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnMobileDevices.ForeColor = Color.White
        btnMobileDevices.IconChar = FontAwesome.Sharp.IconChar.None
        btnMobileDevices.IconColor = Color.Black
        btnMobileDevices.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnMobileDevices.Location = New Point(20, 20)
        btnMobileDevices.Name = "btnMobileDevices"
        btnMobileDevices.Size = New Size(122, 44)
        btnMobileDevices.TabIndex = 2
        btnMobileDevices.Text = "Mobile Devices"
        btnMobileDevices.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(btnComputerLaptop)
        Panel4.Dock = DockStyle.Left
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Padding = New Padding(20)
        Panel4.Size = New Size(162, 84)
        Panel4.TabIndex = 0
        ' 
        ' btnComputerLaptop
        ' 
        btnComputerLaptop.Dock = DockStyle.Fill
        btnComputerLaptop.FlatAppearance.BorderSize = 2
        btnComputerLaptop.FlatStyle = FlatStyle.Flat
        btnComputerLaptop.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnComputerLaptop.ForeColor = Color.White
        btnComputerLaptop.IconChar = FontAwesome.Sharp.IconChar.None
        btnComputerLaptop.IconColor = Color.Black
        btnComputerLaptop.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnComputerLaptop.Location = New Point(20, 20)
        btnComputerLaptop.Name = "btnComputerLaptop"
        btnComputerLaptop.Size = New Size(122, 44)
        btnComputerLaptop.TabIndex = 1
        btnComputerLaptop.Text = "Computer/Laptop"
        btnComputerLaptop.UseVisualStyleBackColor = True
        ' 
        ' Panel8
        ' 
        Panel8.Controls.Add(dtgAudio)
        Panel8.Dock = DockStyle.Fill
        Panel8.Location = New Point(0, 160)
        Panel8.Name = "Panel8"
        Panel8.Padding = New Padding(20)
        Panel8.Size = New Size(884, 476)
        Panel8.TabIndex = 7
        ' 
        ' dtgAudio
        ' 
        dtgAudio.BackgroundColor = Color.White
        dtgAudio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgAudio.Dock = DockStyle.Fill
        dtgAudio.Location = New Point(20, 20)
        dtgAudio.Name = "dtgAudio"
        dtgAudio.Size = New Size(844, 436)
        dtgAudio.TabIndex = 0
        ' 
        ' frmProductList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        ClientSize = New Size(884, 636)
        Controls.Add(Panel8)
        Controls.Add(Panel1)
        Controls.Add(PanelHeader)
        Name = "frmProductList"
        Text = "Product List"
        PanelHeader.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        CType(dtgAudio, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnSearch As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnAudioDevices As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnStorageDevices As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnMobileDevices As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnComputerLaptop As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel8 As Panel
    Friend WithEvents dtgAudio As DataGridView
End Class
