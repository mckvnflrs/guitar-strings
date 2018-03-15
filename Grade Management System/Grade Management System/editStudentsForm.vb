Imports System.Data.Odbc
Imports System.Windows.Forms

Public Class editStudentsForm

    Dim studentId As String
    Dim schoolYear As String
    Dim firstName As String
    Dim middleName As String
    Dim lastName As String
    Dim gender As String
    Dim age As Integer
    Dim dateOfbirth As String
    Dim collegeYear As String
    Dim collegeCourse As String
    Dim collegeMajor As String
    Dim studentType As String
    Dim collegeDept As String
    Dim address As String
    Dim contactNumber As String

    Dim connString As String = "driver=MySQL ODBC 5.3 ANSI Driver;Localhost;port=3306;uid='root';pwd=abc123;database=gmsdb"
    Dim connect As New OdbcConnection(connString)
    Dim command As OdbcCommand
    Dim adaptData, adaptData2 As New OdbcDataAdapter
    Dim dbSet, setData As New DataSet
    Dim tData As New DataTable

    Public Sub fillComboBox()

        Dim stringQuery As String

        connect.Open()
        stringQuery = "select y_id, yearlevel from tblyearlevel "
        command = New OdbcCommand(stringQuery, connect)
        adaptData.SelectCommand = command
        adaptData.Fill(setData)
        adaptData.Dispose()
        command.Dispose()
        connect.Close()
        cbxYearLevel.DataSource = setData.Tables(0)

        cbxYearLevel.ValueMember = "y_id"
        cbxYearLevel.DisplayMember = "yearlevel"

        cbxYearLevel.Refresh()

    End Sub

    Sub reset()

        txtStudentid.Text = ""
        txtSchoolYear.Text = ""
        txtStudentFirstname.Text = ""
        txtStudentInitial.Text = ""
        txtStudentLastname.Text = ""
        cbxStudentGender.Text = "Male"
        txtStudentAge.Text = ""
        mtxtStudentBirthdate.Text = ""
        txtStudentCourse.Text = ""
        txtStudentMajor.Text = ""
        cbxStudentType.Text = "Regular"
        txtStudentDept.Text = ""
        txtStudentAddress.Text = ""
        txtStudentContact.Text = ""

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        studentId = txtStudentid.Text.Trim()
        schoolYear = txtSchoolYear.Text.Trim()
        firstName = txtStudentFirstname.Text.Trim()
        middleName = txtStudentInitial.Text.Trim()
        lastName = txtStudentLastname.Text.Trim()
        dateOfbirth = mtxtStudentBirthdate.Text.Trim()
        gender = cbxStudentGender.SelectedItem.ToString()
        collegeYear = cbxYearLevel.Text.Trim()
        collegeCourse = txtStudentCourse.Text.Trim()
        collegeMajor = txtStudentMajor.Text.Trim()
        studentType = cbxStudentType.SelectedItem.ToString
        collegeDept = txtStudentDept.Text.Trim

        contactNumber = txtStudentContact.Text().Trim()
        address = txtStudentAddress.Text.Trim()

        Dim stringQuery As String
        Dim command As OdbcCommand
        Dim connDB As New ConnectionDB

        If studentId = "" Or schoolYear = "" Or firstName = "" Or lastName = "" Or dateOfbirth = "" Or gender = "" Or collegeYear = "" Or collegeCourse = "" Or collegeMajor = "" Or studentType = "" Or collegeDept = "" Or address = "" Or contactNumber = "" Then

            MessageBox.Show("Some information are Empty! please fill-up necessary info!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            Dim mstream As New System.IO.MemoryStream()

            pbStudentPicture.Image.Save(mstream, pbStudentPicture.Image.RawFormat)
            mstream.Close()
            mstream.Dispose()

            Try

                Dim selectedIndex As Integer = cbxYearLevel.SelectedIndex
                age = CInt(txtStudentAge.Text)

                If selectedIndex <= 0 Then

                    MessageBox.Show("Please select year level!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                Else
                    stringQuery = "update tblstudentslist set year_id = ? studentid = ?, schoolyear = ?, firstname = ?, middlename = ?, lastname = ?, gender = ?, age = ?, birthdate = ?, year = ?, course = ?, major = ?, studenttype = ?, collegedept = ?, completeaddress = ?, contactnumber = ?, studentphoto = ? where id = '" & listStudentForm.DataGridView1.CurrentRow.Cells(0).Value & "'"
                    command = New OdbcCommand(stringQuery)

                    command.Parameters.AddWithValue("?year_id", selectedIndex)
                    command.Parameters.AddWithValue("?studentid", studentId)
                    command.Parameters.AddWithValue("?schoolyear", schoolYear)
                    command.Parameters.AddWithValue("?firstname", firstName)
                    command.Parameters.AddWithValue("?middlename", middleName)
                    command.Parameters.AddWithValue("?lastname", lastName)
                    command.Parameters.AddWithValue("?gender", gender)
                    command.Parameters.AddWithValue("?age", age)
                    command.Parameters.AddWithValue("?birthdate", dateOfbirth)
                    command.Parameters.AddWithValue("?year", collegeYear)
                    command.Parameters.AddWithValue("?course", collegeCourse)
                    command.Parameters.AddWithValue("?major", collegeMajor)
                    command.Parameters.AddWithValue("?studenttype", studentType)
                    command.Parameters.AddWithValue("?collegedept", collegeDept)
                    command.Parameters.AddWithValue("?completeaddress", address)
                    command.Parameters.AddWithValue("?contactnumber", contactNumber)
                    command.Parameters.AddWithValue("?profilepic", mstream.ToArray)

                    Dim userAction As New DialogResult

                    userAction = MessageBox.Show("Please make sure that all entries are correct before you proceed. Continue? ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

                    If userAction = Windows.Forms.DialogResult.OK Then

                        MessageBox.Show("Successfully Updated !!", "Manage Students", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        connDB.commandQuery(command)
                        reset()
                        listStudentForm.fillData()

                    Else

                        MessageBox.Show("Action aborted!", "Abort", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If

                End If

            Catch ex As Exception

                MessageBox.Show("Some information are not properly set! please check e.g. (age,photo,etc..)", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End Try

        End If

        txtStudentid.Focus()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click

        If OpenFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

            pbStudentPicture.Image = Image.FromFile(OpenFileDialog1.FileName)

        End If

    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click

        If MessageBox.Show("Are you sure?", "Remove Image", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            pbStudentPicture.Image = Nothing

        End If

    End Sub

    Private Sub editStudentsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtStudentMajor.Text = "N/A"
        fillComboBox()

    End Sub
End Class