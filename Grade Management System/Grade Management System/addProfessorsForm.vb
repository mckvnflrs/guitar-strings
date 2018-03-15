Imports System.Windows.Forms
Imports System.Data.Odbc
Imports System.Data.Odbc.OdbcConnection
Imports System.Data.Odbc.OdbcCommand
Imports System.Drawing
Imports System.IO


Public Class addProfessorsForm

    Dim firstName As String
    Dim middleName As String
    Dim lastName As String
    Dim age As Integer
    Dim gender As String
    Dim dateOfbirth As String
    Dim address As String
    Dim bachelorDegree As String

    Dim emailAddress As String
    Dim phoneNumber As String

    Sub reset()

        txtGivenName.Text = ""
        txtMiddleName.Text = ""
        txtLastName.Text = ""
        txtAge.Text = ""
        cbxDate.Text = "DD"
        cbxMonth.Text = "MM"
        cbxYear.Text = "YYYY"
        cbxGender.Text = "Male"
        txtAddress.Text = ""
        txtBdegree.Text = ""
        pbProfilePicture.Image = Nothing
        txtEmailAddress.Text = ""
        txtConfirmAddress.Text = ""
        txtPhoneNumber.Text = ""

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPersonalInfo.Click

        GroupBox1.Text = "Personal Information"
        pnlContactInfo.Hide()
        pnlPersonalInfo.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContactInfo.Click

        GroupBox1.Text = "Contact Information"
        pnlPersonalInfo.Hide()
        pnlContactInfo.Show()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click

        firstName = txtGivenName.Text.Trim()
        middleName = txtMiddleName.Text.Trim()
        lastName = txtLastName.Text.Trim()
        gender = cbxGender.SelectedItem.ToString()
        address = txtAddress.Text.Trim()
        bachelorDegree = txtBdegree.Text.Trim()
        emailAddress = txtEmailAddress.Text.Trim()
        Dim code As String = txtPhoneCode.Text()
        phoneNumber = code + txtPhoneNumber.Text().Trim()


        Dim emailValidation As Boolean

        emailValidation = Not (txtConfirmAddress.Text().Trim() = emailAddress)

        If emailValidation = True Then

            lblemailNotice.Text = "NOTICE: Email address didn't match!"
            txtConfirmAddress.Clear()

        End If


        Dim stringQuery As String
        Dim command As OdbcCommand
        Dim connDB As New ConnectionDB

        If firstName = "" Or lastName = "" Or gender = "" Or address = "" Or bachelorDegree = "" Or emailAddress = "" Or phoneNumber = "" Then

            MessageBox.Show("Some information are Empty! please fill-up necessary info!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            Try

                age = CInt(txtAge.Text)
                Dim day As String = cbxDate.SelectedItem.ToString()
                Dim month As String = cbxMonth.SelectedItem.ToString()
                Dim year As String = cbxYear.SelectedItem.ToString()
                dateOfbirth = day + "/" + month + "/" + year

                stringQuery = "insert into tblProfessorList (firstname, middlename, lastname, age, gender, birthdate, address, degree, emailaddress, phonenumber, profilepic) values( ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
                command = New OdbcCommand(stringQuery)

                Dim mstream As New System.IO.MemoryStream()
                pbProfilePicture.Image.Save(mstream, pbProfilePicture.Image.RawFormat)

                command.Parameters.AddWithValue("?firstname", firstName)
                command.Parameters.AddWithValue("?middlename", middleName)
                command.Parameters.AddWithValue("?lastname", lastName)
                command.Parameters.AddWithValue("?age", age)
                command.Parameters.AddWithValue("?gender", gender)
                command.Parameters.AddWithValue("?birthdate", dateOfbirth)
                command.Parameters.AddWithValue("?address", address)
                command.Parameters.AddWithValue("?degree", bachelorDegree)
                command.Parameters.AddWithValue("?emailaddress", emailAddress)
                command.Parameters.AddWithValue("?phonenumber", phoneNumber)
                command.Parameters.AddWithValue("?profilepic", mstream.ToArray)

                MessageBox.Show("You are now officially hired goodluck senpai!", "Hire Professors", MessageBoxButtons.OK, MessageBoxIcon.Information)
                connDB.commandQuery(command)

                reset()

            Catch ex As Exception

                MessageBox.Show("Some information are not properly set! please check e.g. (age,photo,etc..)", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End Try

        End If

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        If MessageBox.Show("Are you sure you want to reset all entries?", "Warning", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.OK Then

            reset()

        End If

    End Sub

    Private Sub btnUploadPic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUploadPic.Click

        Dim OpenFile As FileDialog = New OpenFileDialog()

        If OpenFile.ShowDialog(Me) = DialogResult.OK Then

            pbProfilePicture.Image = Image.FromFile(OpenFile.FileName)

        End If

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If MessageBox.Show("Are you sure?", "Remove Image", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            pbProfilePicture.Image = Nothing

        End If

    End Sub
End Class