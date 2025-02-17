

Public Class FormAdminLogin
    Private Sub FormAdminLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPassword.PasswordChar = "*"c
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit() ' Exit the application '
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        ' Validate empty fields '
        If username = "" OrElse password = "" Then
            MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ' Query the AdminAccount table '
            Dim query As String = "SELECT COUNT(1) FROM [dbo].[AdminAccount] WHERE username = @username AND password = @password"
            Dim parameters As New Dictionary(Of String, Object) From {
            {"@username", username},
            {"@password", password}
        }

            Dim count As Integer = Convert.ToInt32(ExecuteScalarQuery(query, parameters))

            If count = 1 Then
                MessageBox.Show("Admin Login Successful!", "Admin Log In", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Hide the login form '
                frmLogin.Hide()

                ' Open the Admin Dashboard '
                Dim AdminForm As New AdminForm()
                AdminForm.ShowDialog()

                ' Show the login form again after logging out '
                frmLogin.Show()
            Else
                MessageBox.Show("Invalid Admin Username or Password.", "Admin Log In", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Database connection error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
