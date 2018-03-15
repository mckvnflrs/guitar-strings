Imports System.Data.Odbc
Imports System.Windows.Forms
Imports System.IO

Public Class listStudentForm

    Dim connString As String = "driver=MySQL ODBC 5.3 ANSI Driver;Localhost;port=3306;uid='root';pwd=abc123;database=gmsdb"
    Dim connect As New OdbcConnection(connString)
    Dim command As OdbcCommand
    Dim adaptData, adaptData2 As New OdbcDataAdapter
    Dim dbSet, setData As New DataSet
    Dim tData As New DataTable

    Public Sub fillComboBox()

        Dim stringQuery As String
        Dim count As Integer = 0

        connect.Open()
        stringQuery = "select Column_name from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='tblstudentslist'"
        command = New OdbcCommand(stringQuery, connect)
        adaptData.SelectCommand = command
        adaptData.Fill(setData)
        adaptData.Dispose()
        command.Dispose()
        connect.Close()
        cbxSort.DataSource = setData.Tables(0)

        cbxSort.DisplayMember = "Column_name"
        cbxSort.ValueMember = "Column_name"
        cbxSort.Refresh()

    End Sub

    Public Sub fillData()

        Try

            Dim StringQuery As String = "select id,studentid, schoolyear, firstname, middlename, lastname, gender, age, birthdate, year, course, major, studenttype, collegedept, completeaddress, contactnumber from tblstudentslist"
            command = New OdbcCommand(StringQuery, connect)

            adaptData = New OdbcDataAdapter(command)

            dbSet.Clear()
            adaptData.Fill(dbSet, "tblstudentslist")
            DataGridView1.DataSource = dbSet.Tables(0)
            adaptData.Dispose()

            connect.Close()

        Catch ex As Exception

            MessageBox.Show("Make sure xampp is running!", "Database connection errror", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Sub gridSetting()

        Try

            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
            DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Maroon

            DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Maroon
            DataGridView1.Columns(0).HeaderText = "#"
            DataGridView1.Columns(1).HeaderText = "Student ID"
            DataGridView1.Columns(2).HeaderText = "School Year"
            DataGridView1.Columns(3).HeaderText = "First Name"
            DataGridView1.Columns(4).HeaderText = "Initial"
            DataGridView1.Columns(5).HeaderText = "Last Name"
            DataGridView1.Columns(6).HeaderText = "Gender"
            DataGridView1.Columns(7).HeaderText = "Age"
            DataGridView1.Columns(8).HeaderText = "Birth Date"
            DataGridView1.Columns(9).HeaderText = "Year"
            DataGridView1.Columns(10).HeaderText = "Course"
            DataGridView1.Columns(11).HeaderText = "Major"
            DataGridView1.Columns(12).HeaderText = "Student type"
            DataGridView1.Columns(13).HeaderText = "College Dept"
            DataGridView1.Columns(14).HeaderText = "Address"
            DataGridView1.Columns(15).HeaderText = "Mobile Number"

        Catch ex As Exception

            MessageBox.Show("There is an error while loading the data!", "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Sub refreshData()

        Me.DataGridView1.Refresh()

    End Sub

    Sub deleteData()

        Dim stringQuery As String = "delete from tblstudentslist where id = '" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "'"
        Dim command As New OdbcCommand(stringQuery, connect)
        Dim connDB As New ConnectionDB
        connDB.commandQuery(command)
        connect.Close()
        Me.fillData()

    End Sub


    Sub searchData()

        Dim stringQuery As String
        Dim count As Integer = 0

        connect.Open()
        stringQuery = "select distinct from tblstudentslist where Column_name = '" & cbxSort.SelectedIndex & "' like '" & txtSearch.Text & "'"
        command = New OdbcCommand(stringQuery, connect)
        adaptData.SelectCommand = command
        adaptData.Fill(dbSet, "tblstudentslist")
        DataGridView1.DataSource = dbSet.Tables(0)
        adaptData.Dispose()

        connect.Close()

    End Sub



    Private Sub StudentsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        fillData()
        gridSetting()
        fillComboBox()

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click

        Dim studentNewUI As New addStudentsForm
        studentNewUI.ShowDialog()

    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click

        connect.Open()
        Dim StringQuery As String = "select studentid, schoolyear, firstname, middlename, lastname, gender, age, birthdate, year, course, major, studenttype, collegedept, completeaddress, contactnumber, studentphoto from tblstudentslist where id = '" & DataGridView1.CurrentRow.Cells(0).Value & "'"
        Dim rptStudentInfo As New StudentRegForm
        Dim dataset As New DataSet
        Dim reportDS As New gmsDS

        adaptData2 = New OdbcDataAdapter(StringQuery, connect)
        adaptData2.Fill(reportDS, "studentinfo")
        rptStudentInfo.SetDataSource(reportDS.Tables(0))
        connect.Close()

        studentProfilephoto.Image = Nothing

        CrystalReportViewer1.ReportSource = rptStudentInfo

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        Try

            editStudentsForm.txtStudentid.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
            editStudentsForm.txtSchoolYear.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
            editStudentsForm.txtStudentFirstname.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
            editStudentsForm.txtStudentInitial.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
            editStudentsForm.txtStudentLastname.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
            editStudentsForm.cbxStudentGender.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
            editStudentsForm.txtStudentAge.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
            editStudentsForm.mtxtStudentBirthdate.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
            editStudentsForm.txtStudentCourse.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString
            editStudentsForm.txtStudentMajor.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString
            editStudentsForm.cbxStudentType.Text = DataGridView1.CurrentRow.Cells(12).Value.ToString
            editStudentsForm.txtStudentDept.Text = DataGridView1.CurrentRow.Cells(13).Value.ToString
            editStudentsForm.txtStudentAddress.Text = DataGridView1.CurrentRow.Cells(14).Value.ToString
            editStudentsForm.txtStudentContact.Text = DataGridView1.CurrentRow.Cells(15).Value.ToString

            'Eto yung mag reretrieve ng Image sa database papuntang picturebox
            command = New OdbcCommand("select studentphoto from tblstudentslist where id='" & DataGridView1.CurrentRow.Cells(0).Value() & "'", connect)
            connect.Open()

            Dim pictureData As Byte() = DirectCast(command.ExecuteScalar(), Byte())

            Using stream As New IO.MemoryStream(pictureData)

                Dim img As Image = Image.FromStream(stream)
                editStudentsForm.pbStudentPicture.Image = New Bitmap(img)

                command.Dispose()
                stream.Dispose()
                stream.Close()
                connect.Close()

            End Using

            editStudentsForm.ShowDialog()

        Catch ex As Exception

            MessageBox.Show("Error: Make sure the table is not empty before you proceed, " + ex.Message, "Error Message", MessageBoxButtons.OK)

        End Try

    End Sub

    Private Sub btnDrop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDrop.Click

        Dim userAction As New DialogResult

        userAction = MessageBox.Show("Are you sure you want to permanently delete " & DataGridView1.SelectedCells(0).Value & "?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

        If userAction = Windows.Forms.DialogResult.OK Then

            MessageBox.Show("Successfully Dropped Student!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            deleteData()

        Else

            MessageBox.Show("Action aborted!", "Abort", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView1.ClearSelection()

        End If

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click

        refreshData()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        'Eto yung mag reretrieve ng Image sa database papuntang picturebox

        command = New OdbcCommand("select studentphoto from tblstudentslist where id='" & DataGridView1.CurrentRow.Cells(0).Value() & "'", connect)
        connect.Open()

        Dim pictureData As Byte() = DirectCast(command.ExecuteScalar(), Byte())

        connect.Close()

        'Dim picture As Image = Nothing

        Using stream As New IO.MemoryStream(pictureData)

            studentProfilephoto.Image = Image.FromStream(stream)

        End Using

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        searchData()

    End Sub
End Class