Imports System.Runtime.InteropServices
Imports System.Xml
Imports FontAwesome.Sharp

Public Class UserForm
    'Fields'
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form
    'Constructor'
    Public Sub New()
        ' This call is required by the designer.'
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.'
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)
        'Form'

        ActivateButton(btnDashboard, RGBColors.color5)

        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    'Methods'
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button'
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border'
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'current Form icon'
            IconCurrentFormUser.IconChar = currentBtn.IconChar
            IconCurrentFormUser.IconColor = customColor
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(31, 30, 68)
            currentBtn.ForeColor = Color.White
            currentBtn.IconColor = Color.White
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        'Open only form'
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end'
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblFormTitleUser.Text = childForm.Text
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ActivateButton(sender, RGBColors.color1)
        OpenChildForm(New frmDashboard())
    End Sub

    Private Sub btnProductList_Click(sender As Object, e As EventArgs) Handles btnProductList.Click
        ActivateButton(sender, RGBColors.color2)
        OpenChildForm(New frmProductList())
    End Sub

    Private Sub btnAdditem_Click(sender As Object, e As EventArgs) Handles btnAdditem.Click
        ActivateButton(sender, RGBColors.color3)
        OpenChildForm(New frmAddItem())
    End Sub

    Private Sub btnUpdateItem_Click(sender As Object, e As EventArgs) Handles btnUpdateItem.Click
        ActivateButton(sender, RGBColors.color4)
        OpenChildForm(New frmUpdateItem())
    End Sub

    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click
        ActivateButton(sender, RGBColors.color5)
        OpenChildForm(New frmDeleteItem())
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        ActivateButton(sender, RGBColors.color6)
        OpenChildForm(New frmSales())
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        ActivateButton(sender, RGBColors.color7)
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Log Out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Hide the AdminForm instead of closing it '
            Me.Hide()

            ' Show the login form again '
            frmLogin.Show()
        End If
    End Sub

    'Drag Form'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Handle, &H112&, &HF012&, 0)
    End Sub

    'Remove transparent border in maximized state'
    Private Sub AdminForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    Private Sub btnExitUser_Click(sender As Object, e As EventArgs) Handles btnExitUser.Click
        Application.Exit()
    End Sub

    Private Sub btnMaximizeUser_Click(sender As Object, e As EventArgs) Handles btnMaximizeUser.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnMinimizeUser_Click(sender As Object, e As EventArgs) Handles btnMinimizeUser.Click
        WindowState = FormWindowState.Minimized
    End Sub

    'Close-Maximize-Minimize'

End Class