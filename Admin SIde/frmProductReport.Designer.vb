<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductReport
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
        btnSearchProductReport = New FontAwesome.Sharp.IconButton()
        Panel2 = New Panel()
        txtSearchProductReport = New TextBox()
        Panel1 = New Panel()
        Panel8 = New Panel()
        btnMonthlyReport = New FontAwesome.Sharp.IconButton()
        Panel7 = New Panel()
        btnExportTable = New FontAwesome.Sharp.IconButton()
        Panel6 = New Panel()
        btnWeeklyReport = New FontAwesome.Sharp.IconButton()
        Panel5 = New Panel()
        btnDailyReport = New FontAwesome.Sharp.IconButton()
        Panel4 = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        cmbType = New ComboBox()
        Label1 = New Label()
        Panel9 = New Panel()
        dtgComp = New DataGridView()
        PanelHeader.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel8.SuspendLayout()
        Panel7.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        Panel9.SuspendLayout()
        CType(dtgComp, ComponentModel.ISupportInitialize).BeginInit()
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
        PanelHeader.TabIndex = 3
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(btnSearchProductReport)
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(528, 0)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(0, 40, 15, 0)
        Panel3.Size = New Size(130, 76)
        Panel3.TabIndex = 1
        ' 
        ' btnSearchProductReport
        ' 
        btnSearchProductReport.Dock = DockStyle.Fill
        btnSearchProductReport.FlatAppearance.BorderSize = 2
        btnSearchProductReport.FlatStyle = FlatStyle.Flat
        btnSearchProductReport.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnSearchProductReport.ForeColor = Color.White
        btnSearchProductReport.IconChar = FontAwesome.Sharp.IconChar.None
        btnSearchProductReport.IconColor = Color.Black
        btnSearchProductReport.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSearchProductReport.Location = New Point(0, 40)
        btnSearchProductReport.Name = "btnSearchProductReport"
        btnSearchProductReport.Size = New Size(115, 36)
        btnSearchProductReport.TabIndex = 0
        btnSearchProductReport.Text = "Search"
        btnSearchProductReport.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(txtSearchProductReport)
        Panel2.Dock = DockStyle.Right
        Panel2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel2.Location = New Point(658, 0)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(0, 40, 20, 0)
        Panel2.Size = New Size(226, 76)
        Panel2.TabIndex = 0
        ' 
        ' txtSearchProductReport
        ' 
        txtSearchProductReport.Dock = DockStyle.Fill
        txtSearchProductReport.Location = New Point(0, 40)
        txtSearchProductReport.Name = "txtSearchProductReport"
        txtSearchProductReport.Size = New Size(206, 33)
        txtSearchProductReport.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel8)
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel4)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 76)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(884, 84)
        Panel1.TabIndex = 4
        ' 
        ' Panel8
        ' 
        Panel8.Controls.Add(btnMonthlyReport)
        Panel8.Dock = DockStyle.Left
        Panel8.Location = New Point(486, 0)
        Panel8.Name = "Panel8"
        Panel8.Padding = New Padding(20)
        Panel8.Size = New Size(162, 84)
        Panel8.TabIndex = 4
        ' 
        ' btnMonthlyReport
        ' 
        btnMonthlyReport.Dock = DockStyle.Fill
        btnMonthlyReport.FlatAppearance.BorderSize = 2
        btnMonthlyReport.FlatStyle = FlatStyle.Flat
        btnMonthlyReport.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnMonthlyReport.ForeColor = Color.White
        btnMonthlyReport.IconChar = FontAwesome.Sharp.IconChar.None
        btnMonthlyReport.IconColor = Color.Black
        btnMonthlyReport.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnMonthlyReport.Location = New Point(20, 20)
        btnMonthlyReport.Name = "btnMonthlyReport"
        btnMonthlyReport.Size = New Size(122, 44)
        btnMonthlyReport.TabIndex = 3
        btnMonthlyReport.Text = "Monthly Report"
        btnMonthlyReport.UseVisualStyleBackColor = True
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(btnExportTable)
        Panel7.Dock = DockStyle.Right
        Panel7.Location = New Point(722, 0)
        Panel7.Name = "Panel7"
        Panel7.Padding = New Padding(20)
        Panel7.Size = New Size(162, 84)
        Panel7.TabIndex = 3
        ' 
        ' btnExportTable
        ' 
        btnExportTable.Dock = DockStyle.Fill
        btnExportTable.FlatAppearance.BorderSize = 2
        btnExportTable.FlatStyle = FlatStyle.Flat
        btnExportTable.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExportTable.ForeColor = Color.White
        btnExportTable.IconChar = FontAwesome.Sharp.IconChar.None
        btnExportTable.IconColor = Color.Black
        btnExportTable.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnExportTable.Location = New Point(20, 20)
        btnExportTable.Name = "btnExportTable"
        btnExportTable.Size = New Size(122, 44)
        btnExportTable.TabIndex = 4
        btnExportTable.Text = "Export Table"
        btnExportTable.UseVisualStyleBackColor = True
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(btnWeeklyReport)
        Panel6.Dock = DockStyle.Left
        Panel6.Location = New Point(324, 0)
        Panel6.Name = "Panel6"
        Panel6.Padding = New Padding(20)
        Panel6.Size = New Size(162, 84)
        Panel6.TabIndex = 2
        ' 
        ' btnWeeklyReport
        ' 
        btnWeeklyReport.Dock = DockStyle.Fill
        btnWeeklyReport.FlatAppearance.BorderSize = 2
        btnWeeklyReport.FlatStyle = FlatStyle.Flat
        btnWeeklyReport.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnWeeklyReport.ForeColor = Color.White
        btnWeeklyReport.IconChar = FontAwesome.Sharp.IconChar.None
        btnWeeklyReport.IconColor = Color.Black
        btnWeeklyReport.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnWeeklyReport.Location = New Point(20, 20)
        btnWeeklyReport.Name = "btnWeeklyReport"
        btnWeeklyReport.Size = New Size(122, 44)
        btnWeeklyReport.TabIndex = 2
        btnWeeklyReport.Text = "Weekly Report"
        btnWeeklyReport.UseVisualStyleBackColor = True
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(btnDailyReport)
        Panel5.Dock = DockStyle.Left
        Panel5.Location = New Point(162, 0)
        Panel5.Name = "Panel5"
        Panel5.Padding = New Padding(20)
        Panel5.Size = New Size(162, 84)
        Panel5.TabIndex = 1
        ' 
        ' btnDailyReport
        ' 
        btnDailyReport.Dock = DockStyle.Fill
        btnDailyReport.FlatAppearance.BorderSize = 2
        btnDailyReport.FlatStyle = FlatStyle.Flat
        btnDailyReport.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnDailyReport.ForeColor = Color.White
        btnDailyReport.IconChar = FontAwesome.Sharp.IconChar.None
        btnDailyReport.IconColor = Color.Black
        btnDailyReport.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnDailyReport.Location = New Point(20, 20)
        btnDailyReport.Name = "btnDailyReport"
        btnDailyReport.Size = New Size(122, 44)
        btnDailyReport.TabIndex = 1
        btnDailyReport.Text = "Daily Report"
        btnDailyReport.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(TableLayoutPanel1)
        Panel4.Dock = DockStyle.Left
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(162, 84)
        Panel4.TabIndex = 0
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(cmbType, 0, 1)
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.Padding = New Padding(20, 20, 0, 0)
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 31.25F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 68.75F))
        TableLayoutPanel1.Size = New Size(162, 84)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' cmbType
        ' 
        cmbType.Dock = DockStyle.Fill
        cmbType.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbType.FormattingEnabled = True
        cmbType.Items.AddRange(New Object() {"Computers/Laptops", "Mobile Devices", "Storage Devices", "Audio Devices"})
        cmbType.Location = New Point(23, 43)
        cmbType.Name = "cmbType"
        cmbType.Size = New Size(136, 23)
        cmbType.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(23, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 15)
        Label1.TabIndex = 5
        Label1.Text = "Product Type"
        ' 
        ' Panel9
        ' 
        Panel9.Controls.Add(dtgComp)
        Panel9.Dock = DockStyle.Fill
        Panel9.Location = New Point(0, 160)
        Panel9.Name = "Panel9"
        Panel9.Padding = New Padding(20)
        Panel9.Size = New Size(884, 476)
        Panel9.TabIndex = 5
        ' 
        ' dtgComp
        ' 
        dtgComp.BackgroundColor = Color.White
        dtgComp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgComp.Dock = DockStyle.Fill
        dtgComp.Location = New Point(20, 20)
        dtgComp.Name = "dtgComp"
        dtgComp.Size = New Size(844, 436)
        dtgComp.TabIndex = 0
        ' 
        ' frmProductReport
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        ClientSize = New Size(884, 636)
        Controls.Add(Panel9)
        Controls.Add(Panel1)
        Controls.Add(PanelHeader)
        Name = "frmProductReport"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Product Report"
        PanelHeader.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        Panel9.ResumeLayout(False)
        CType(dtgComp, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnSearchProductReport As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtSearchProductReport As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnExportTable As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnMonthlyReport As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnWeeklyReport As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDailyReport As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents dtgComp As DataGridView
End Class
