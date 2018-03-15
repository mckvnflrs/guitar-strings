Imports System.Windows.Forms
Imports System.Data.Odbc
Imports System.Data.Odbc.OdbcConnection
Imports System.Data.Odbc.OdbcCommand

Public Class registerAdminForm

    Dim connString As String = "driver=MySQL ODBC 5.3 ANSI Driver;Localhost;port=3306;uid='root';pwd=abc123;database=gmsdb"
    Dim connect As New OdbcConnection(connString)

    Dim user As String
    Dim pass As String
    Dim secretQuestion As String
    Dim secretAnswer As String

    Private Sub btnAdminConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdminConfirm.Click

        user = txtUsername.Text().Trim()
        pass = txtPassword.Text().Trim()
        secretAnswer = txtAnswer.Text().Trim()

        Dim passwordValidation As Boolean
        Dim answerValidation As Boolean

        passwordValidation = Not (txtConfirmPassword.Text().Trim() = pass)

        answerValidation = Not (txtConfirmAnswer.Text().Trim() = secretAnswer)

        If passwordValidation = True Or answerValidation = True Then

            lblNotice1.Text = "NOTICE: Password didn't match!"
            txtPassword.Clear()
            txtConfirmPassword.Clear()

            lblNotice2.Text = "NOTICE: Answer didn't match!"
            txtAnswer.Clear()
            txtConfirmAnswer.Clear()

        Else

            lblNotice1.Text() = ""
            lblNotice2.Text() = ""

            Dim stringQuery, stringValidateQuery As String
            Dim command, validatecmd As OdbcCommand
            Dim reader As OdbcDataReader

            Dim connDB As New ConnectionDB

            If user = "" Or pass = "" Or secretAnswer = "" Then

                MessageBox.Show("Some information are Empty! please fill-up necessary info!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Else

                Try

                    connect.Open()
                    stringValidateQuery = "select username from tbladminlogin where (username) like (md5(?))"
                    validatecmd = New OdbcCommand(stringValidateQuery)
                    validatecmd.Connection = connect
                    validatecmd.Parameters.AddWithValue("?username", user)

                    reader = validatecmd.ExecuteReader


                    If reader.HasRows = True Then

                        MessageBox.Show("Username already Exist! Please insert a Unique username!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    Else

                        secretQuestion = cbxSecretQuestion.SelectedItem.ToString()

                        'Security Information Query
                        stringQuery = "insert into tbladminlogin (username, password, secretquestion, secretanswer) values( md5(?), md5(?), ?, md5(?))"
                        command = New OdbcCommand(stringQuery)

                        command.Parameters.AddWithValue("?username", user)
                        command.Parameters.AddWithValue("?password", pass)
                        command.Parameters.AddWithValue("?secretquestion", secretQuestion)
                        command.Parameters.AddWithValue("?secretanswer", secretAnswer)

                        connDB.commandQuery(command)

                        MessageBox.Show("Successfully Added to database!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        txtUsername.Clear()
                        txtPassword.Clear()
                        txtConfirmPassword.Clear()
                        cbxSecretQuestion.Text = ""
                        txtAnswer.Clear()
                        txtConfirmAnswer.Clear()

                    End If

                Catch ex As Exception

                    MessageBox.Show("There is something wrong while connecting to database! Please contact the system developer!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                Finally

                    connect.Close()

                End Try

            End If

        End If

    End Sub

    Private Sub btnAdminRegExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdminRegExit.Click

        Me.Close()

    End Sub

    Private Sub btnAdminClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdminClear.Click

        txtUsername.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()
        cbxSecretQuestion.Text = ""
        txtAnswer.Clear()
        txtConfirmAnswer.Clear()

    End Sub
End Class