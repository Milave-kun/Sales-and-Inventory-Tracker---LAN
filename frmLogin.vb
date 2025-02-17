Imports FontAwesome.Sharp

Public Class frmLogin

    Private currentBtn As IconButton
    Private BorderBtn As Panel
    Private CurrentChildForm As Form

    Public Sub New()
        ' This call is required by the designer.'
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.'
        BorderBtn = New Panel()
        BorderBtn.Size = New Size(10, 53)
        PanelMenu.Controls.Add(BorderBtn)

        ' Form Settings '
        Me.Text = String.Empty ' Removes text from title bar '
        Me.ControlBox = False ' Hides minimize, maximize, and close buttons '
        Me.Size = New Size(816, 489) ' Set a fixed size '
        Me.MaximumSize = Me.Size ' Prevent resizing '
        Me.MinimumSize = Me.Size ' Prevent resizing '

        OpenChildForm(New FormUserLogin())

        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
    End Sub

    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        DisableButton()
        If senderBtn IsNot Nothing Then
            'Button'
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(255, 255, 255)
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
            'Left Border'
            BorderBtn.BackColor = customColor
            BorderBtn.Location = New Point(0, currentBtn.Location.Y)
            BorderBtn.Visible = True
            BorderBtn.BringToFront()
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
        ' Close the current child form if any '
        If CurrentChildForm IsNot Nothing Then
            CurrentChildForm.Close()
        End If

        ' Assign the new child form '
        CurrentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()

        ' Ensure consistent styling for both buttons BEFORE applying colors '
        Dim defaultPadding As New Padding(10, 0, 20, 0)
        Dim defaultTextAlign As ContentAlignment = ContentAlignment.MiddleLeft
        Dim defaultImageAlign As ContentAlignment = ContentAlignment.MiddleLeft
        Dim defaultTextImageRelation As TextImageRelation = TextImageRelation.ImageBeforeText

        ' Apply fixed styling to prevent movement '
        For Each btn As IconButton In {btnAdmin, btnUser}
            btn.FlatStyle = FlatStyle.Flat
            btn.AutoSize = False
            btn.TextAlign = defaultTextAlign
            btn.ImageAlign = defaultImageAlign
            btn.TextImageRelation = defaultTextImageRelation
            btn.Padding = defaultPadding
        Next

        ' Change button colors based on the opened child form '
        If TypeOf childForm Is FormAdminLogin Then
            btnAdmin.BackColor = Color.FromArgb(37, 36, 81)
            btnAdmin.ForeColor = Color.Cyan
            btnAdmin.IconColor = Color.Cyan

            btnUser.BackColor = Color.FromArgb(31, 30, 68)
            btnUser.ForeColor = Color.White
            btnUser.IconColor = Color.White
        ElseIf TypeOf childForm Is FormUserLogin Then
            btnUser.BackColor = Color.FromArgb(37, 36, 81)
            btnUser.ForeColor = Color.Lime
            btnUser.IconColor = Color.Lime

            btnAdmin.BackColor = Color.FromArgb(31, 30, 68)
            btnAdmin.ForeColor = Color.White
            btnAdmin.IconColor = Color.White
        End If

        ' Reapply padding after color changes '
        btnAdmin.Padding = defaultPadding
        btnUser.Padding = defaultPadding
    End Sub


    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        OpenChildForm(New FormAdminLogin)
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        OpenChildForm(New FormUserLogin)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

End Class
