Imports System.Data.Odbc
Imports System.Data.DataTable
Imports System.Data.DataSet
Imports System.IO.MemoryStream
Imports System.IO

Public Class listProfessorsForm

    Dim connString As String = "driver=MySQL ODBC 5.3 ANSI Driver;Localhost;port=3306;uid='root';pwd=abc123;database=gmsdb"
    Dim connect As New OdbcConnection(connString)
    Dim StringQuery As String
    Dim command As OdbcCommand
    Dim adaptData As New OdbcDataAdapter
    Dim dbSet, setData As New DataSet

    Dim subjectId As New Integer


    Public Sub fillComboBox()

        Dim count As Integer = 0

        connect.Open()
        StringQuery = "select Column_name from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='tblprofessorlist'"
        command = New OdbcCommand(StringQuery, connect)
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

    Sub fillData()

        Try
            StringQuery = "select euid,firstname,middlename,lastname,age,gender,birthdate,address,degree,emailaddress,phonenumber from tblprofessorlist"
            command = New OdbcCommand(StringQuery, connect)

            adaptData = New OdbcDataAdapter(command)

            dbSet.Clear()
            adaptData.Fill(dbSet, "tblprofessorlist")
            DataGridView1.DataSource = dbSet.Tables(0)
            adaptData.Dispose()

            connect.Close()

        Catch ex As Exception

            MessageBox.Show("Make sure xampp is running!", "Database connection errror", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Sub gridSettings()

        Try
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
            DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Maroon

            DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Maroon
            DataGridView1.Columns(0).HeaderText = "#"
            DataGridView1.Columns(1).HeaderText = "First Name"
            DataGridView1.Columns(2).HeaderText = "Middle Name"
            DataGridView1.Columns(3).HeaderText = "Last Name"
            DataGridView1.Columns(4).HeaderText = "Age"
            DataGridView1.Columns(5).HeaderText = "Gender"
            DataGridView1.Columns(6).HeaderText = "Birth Date"
            DataGridView1.Columns(7).HeaderText = "Address"
            DataGridView1.Columns(8).HeaderText = "Degree"
            DataGridView1.Columns(9).HeaderText = "Email Address"
            DataGridView1.Columns(10).HeaderText = "Mobile Number"

        Catch ex As Exception

            MessageBox.Show("There is an error while loading the data!", "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub ProfessorsListForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        fillComboBox()
        fillData()
        gridSettings()

    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click

        MainForm.txtMainGivenName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        MainForm.txtMainMiddleName.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        MainForm.txtMainLastName.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        MainForm.txtMainAge.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        MainForm.txtMainGender.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        MainForm.txtMainBirthdate.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        MainForm.txtMainAddress.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString()
        MainForm.txtMainBachDegree.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString()
        MainForm.txtMainEmailAddress.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString()
        MainForm.txtMainPhoneNumber.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString()

        'Eto yung mag reretrieve ng Image sa database papuntang picturebox
        connect.Open()
        command = New OdbcCommand("select profilepic from tblprofessorlist where euid='" & DataGridView1.CurrentRow.Cells(0).Value() & "'", connect)
        Dim imageData As Byte() = DirectCast(command.ExecuteScalar(), Byte())

        If Not imageData Is Nothing Then

            Using ms As New MemoryStream(imageData, 0, imageData.Length)
                ms.Write(imageData, 0, imageData.Length)
                MainForm.pbMainProfilePicture.Image = Image.FromStream(ms, True)
                connect.Close()
            End Using

            MainForm.MainPanel.Visible = False
            MainForm.SplitContainer1.Visible = True
            MainForm.fillComboBox()
            MainForm.Show()
            Me.Close()

        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Try
            Dim newforma As New manageSubjectForm

            Dim stringQuery As String
            Dim connDB As New ConnectionDB
            MessageBox.Show(DataGridView1.CurrentRow.Cells(0).Value)
            'Dim selectedRow As Integer = manageSubjectForm.DataGridView1.CurrentRow().Cells(0).Value


            'selectedRow = newforma.DataGridView1.CurrentRow.Cells(0).Value





            stringQuery = "update tblprofessorlist set  subject_id = ? where euid = '" & DataGridView1.CurrentRow.Cells(0).Value & "'"
            command = New OdbcCommand(stringQuery)
            command.Parameters.AddWithValue("subject_id", Integer.Parse(subjectId))

            Dim questionForm As DialogResult
            questionForm = MessageBox.Show("Are you sure you want to assign a subject to this prof?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If questionForm = Windows.Forms.DialogResult.Yes Then

                MessageBox.Show("Successfully assigned! you can now manage this student", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                connDB.commandQuery(command)

            End If

        Catch ex As Exception

            MessageBox.Show("There is an error while connecting to database!" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Public Sub ShowMe(ByVal sender As System.Object, ByVal subjectIdArgs As String)
        MessageBox.Show("Id of Subject Selecter : " + subjectIdArgs)
        subjectId = subjectIdArgs
        Show()

    End Sub
End Class