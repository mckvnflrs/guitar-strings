Imports System.Data.Odbc

Public Class manageStudentForm

    Dim connString As String = "driver=MySQL ODBC 5.3 ANSI Driver;Localhost;port=3306;uid='root';pwd=abc123;database=gmsdb"
    Dim connect As New OdbcConnection(connString)
    Dim StringQuery As String
    Dim command As OdbcCommand
    Dim adaptData As OdbcDataAdapter
    Dim dbSet As New DataSet

    Sub fillData()

        Try

            StringQuery = "select student.studentid, student.firstname, student.middlename, student.lastname from tblstudentslist student, tblprofessorlist where student.professor_id =  '" & listProfessorsForm.DataGridView1.CurrentRow.Cells(0).Value & "'"
            command = New OdbcCommand(StringQuery, connect)

            adaptData = New OdbcDataAdapter(command)

            dbSet.Clear()
            adaptData.Fill(dbSet, "tblstudentslist")
            DataGridView1.DataSource = dbSet.Tables(0)
            adaptData.Dispose()

            connect.Close()

        Catch ex As Exception

            MessageBox.Show("Make sure xampp is running!" + ex.Message, "Database connection errror", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Sub gridSettings()

        Try
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
            DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Maroon

            DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Maroon

            DataGridView1.Columns(0).HeaderText = "Student ID"
            DataGridView1.Columns(1).HeaderText = "First Name"
            DataGridView1.Columns(2).HeaderText = "Initial"
            DataGridView1.Columns(3).HeaderText = "Last Name"

        Catch ex As Exception

            MessageBox.Show("There is an error while loading the data!", "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub manageStudentForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        fillData()
        gridSettings()

    End Sub

    Private Sub btnAddStudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddStudent.Click

        listStudentForm2.ShowDialog()

    End Sub

End Class