﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesReport
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
        btnSearchSalesReport = New FontAwesome.Sharp.IconButton()
        Panel2 = New Panel()
        txtSearchSalesReport = New TextBox()
        Panel1 = New Panel()
        Panel7 = New Panel()
        btnExportTable = New FontAwesome.Sharp.IconButton()
        Panel6 = New Panel()
        btnMonthlyReport = New FontAwesome.Sharp.IconButton()
        Panel5 = New Panel()
        btnWeeklyReport = New FontAwesome.Sharp.IconButton()
        Panel4 = New Panel()
        btnDailyReport = New FontAwesome.Sharp.IconButton()
        Panel8 = New Panel()
        dtgMonthly = New DataGridView()
        PanelHeader.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel7.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel8.SuspendLayout()
        CType(dtgMonthly, ComponentModel.ISupportInitialize).BeginInit()
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
        PanelHeader.TabIndex = 2
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(btnSearchSalesReport)
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(528, 0)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(0, 40, 15, 0)
        Panel3.Size = New Size(130, 76)
        Panel3.TabIndex = 1
        ' 
        ' btnSearchSalesReport
        ' 
        btnSearchSalesReport.Dock = DockStyle.Fill
        btnSearchSalesReport.FlatAppearance.BorderSize = 2
        btnSearchSalesReport.FlatStyle = FlatStyle.Flat
        btnSearchSalesReport.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnSearchSalesReport.ForeColor = Color.White
        btnSearchSalesReport.IconChar = FontAwesome.Sharp.IconChar.None
        btnSearchSalesReport.IconColor = Color.Black
        btnSearchSalesReport.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSearchSalesReport.Location = New Point(0, 40)
        btnSearchSalesReport.Name = "btnSearchSalesReport"
        btnSearchSalesReport.Size = New Size(115, 36)
        btnSearchSalesReport.TabIndex = 0
        btnSearchSalesReport.Text = "Search"
        btnSearchSalesReport.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(txtSearchSalesReport)
        Panel2.Dock = DockStyle.Right
        Panel2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel2.Location = New Point(658, 0)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(0, 40, 20, 0)
        Panel2.Size = New Size(226, 76)
        Panel2.TabIndex = 0
        ' 
        ' txtSearchSalesReport
        ' 
        txtSearchSalesReport.Dock = DockStyle.Fill
        txtSearchSalesReport.Location = New Point(0, 40)
        txtSearchSalesReport.Name = "txtSearchSalesReport"
        txtSearchSalesReport.Size = New Size(206, 33)
        txtSearchSalesReport.TabIndex = 3
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
        Panel1.TabIndex = 3
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
        Panel6.Controls.Add(btnMonthlyReport)
        Panel6.Dock = DockStyle.Left
        Panel6.Location = New Point(324, 0)
        Panel6.Name = "Panel6"
        Panel6.Padding = New Padding(20)
        Panel6.Size = New Size(162, 84)
        Panel6.TabIndex = 2
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
        ' Panel5
        ' 
        Panel5.Controls.Add(btnWeeklyReport)
        Panel5.Dock = DockStyle.Left
        Panel5.Location = New Point(162, 0)
        Panel5.Name = "Panel5"
        Panel5.Padding = New Padding(20)
        Panel5.Size = New Size(162, 84)
        Panel5.TabIndex = 1
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
        ' Panel4
        ' 
        Panel4.Controls.Add(btnDailyReport)
        Panel4.Dock = DockStyle.Left
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Padding = New Padding(20)
        Panel4.Size = New Size(162, 84)
        Panel4.TabIndex = 0
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
        ' Panel8
        ' 
        Panel8.Controls.Add(dtgMonthly)
        Panel8.Dock = DockStyle.Fill
        Panel8.Location = New Point(0, 160)
        Panel8.Name = "Panel8"
        Panel8.Padding = New Padding(20)
        Panel8.Size = New Size(884, 476)
        Panel8.TabIndex = 4
        ' 
        ' dtgMonthly
        ' 
        dtgMonthly.BackgroundColor = Color.White
        dtgMonthly.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgMonthly.Dock = DockStyle.Fill
        dtgMonthly.Location = New Point(20, 20)
        dtgMonthly.Name = "dtgMonthly"
        dtgMonthly.Size = New Size(844, 436)
        dtgMonthly.TabIndex = 0
        ' 
        ' frmSalesReport
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(31), CByte(30), CByte(68))
        ClientSize = New Size(884, 636)
        Controls.Add(Panel8)
        Controls.Add(Panel1)
        Controls.Add(PanelHeader)
        Name = "frmSalesReport"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sales Report"
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
        CType(dtgMonthly, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnSearchSalesReport As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtSearchSalesReport As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnExportTable As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMonthlyReport As FontAwesome.Sharp.IconButton
    Friend WithEvents btnWeeklyReport As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDailyReport As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel8 As Panel
    Friend WithEvents dtgMonthly As DataGridView
End Class
