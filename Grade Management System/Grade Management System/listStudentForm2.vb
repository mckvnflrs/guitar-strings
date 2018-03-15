Imports System.Data.Odbc
Imports System.Windows.Forms
Imports System.IO

Public Class listStudentForm2

    Dim connString As String = "driver=MySQL ODBC 5.3 ANSI Driver;Localhost;port=3306;uid='root';pwd=abc123;database=gmsdb"
    Dim connect As New OdbcConnection(connString)
    Dim command As OdbcCommand
    Dim adaptData, adaptData2 As New OdbcDataAdapter
    Dim dbSet, setData As New DataSet
    Dim tData As New DataTable

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

    Private Sub listStudentForm2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        fillData()
        gridSetting()

    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click



    End Sub
End Class