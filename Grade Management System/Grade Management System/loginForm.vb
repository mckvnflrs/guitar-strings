Imports System.Windows.Forms
Imports System.Data.Odbc

Public Class LoginForm

    Dim connString As String = "driver=MySQL ODBC 5.3 ANSI Driver;Localhost;port=3306;uid='root';pwd=abc123;database=gmsdb"
    Dim connect As New OdbcConnection(connString)

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click

        Dim username As String
        Dim password As String
        Dim stringQuery As String
        Dim command As OdbcCommand
        Dim loginQuery As OdbcDataReader

        username = txtUsername.Text()
        password = txtPassword.Text()

        Try

            connect.Open()
            stringQuery = "select * from tbladminlogin where username = md5(?) and password = md5(?)"
            command = New OdbcCommand(stringQuery)
            command.Connection = connect
            command.Parameters.AddWithValue("?username", username)
            command.Parameters.AddWithValue("?password", password)
            loginQuery = command.ExecuteReader()

            If loginQuery.Read() = True Then

                bufferingForm.ShowDialog()
                MessageBox.Show("Welcome Admin!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Close()

            Else

                MessageBox.Show("Logged In failed! Check username or password if correct!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUsername.Clear()
                txtPassword.Clear()

            End If

        Catch ex As Exception

            MessageBox.Show("ERROR: can't connect to database! please check the connection!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            connect.Close()

        End Try

        txtUsername.Focus()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        MainForm.Close()
        Me.Close()

    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown

        If e.KeyCode = 13 Then

            btnLogin.Focus()

        End If

    End Sub

    Private Sub LinkForgot_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkForgot.LinkClicked

    End Sub

    Private Sub LinkRegister_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkRegister.LinkClicked

        registerAdminForm.ShowDialog()

    End Sub

End Class