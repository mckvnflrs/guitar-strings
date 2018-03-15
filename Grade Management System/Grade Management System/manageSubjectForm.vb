Imports System.Windows.Forms
Imports System.Data.Odbc
Imports System.Data.Odbc.OdbcConnection
Imports System.Data.Odbc.OdbcCommand

Public Class manageSubjectForm

    Dim connString As String = "driver=MySQL ODBC 5.3 ANSI Driver;Localhost;port=3306;uid='root';pwd=abc123;database=gmsdb"
    Dim connect As New OdbcConnection(connString)
    Dim command As OdbcCommand
    Dim adaptData, adaptData2 As New OdbcDataAdapter
    Dim dbSet, setData As New DataSet
    Dim tData As New DataTable

    Dim selectedIndex As Integer
    Dim subjectCode As String
    Dim subjectDesc As String

    Public Sub fillComboBox()

        Dim stringQuery As String
        Dim count As Integer = 0

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

    Public Sub fillData()

        Try
            Dim StringQuery As String = "select id, code, description from tblsubjectlist"
            command = New OdbcCommand(StringQuery, connect)

            adaptData = New OdbcDataAdapter(command)

            dbSet.Clear()
            adaptData.Fill(dbSet, "tblsubjectlist")
            DataGridView1.DataSource = dbSet.Tables(0)
            adaptData.Dispose()

            connect.Close()

        Catch ex As Exception

            MessageBox.Show("Make sure xampp is running!", "Database connection errror", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Sub gridSetting()

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.RowsDefaultCellStyle.BackColor = Color.White
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Maroon

        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Maroon
        DataGridView1.Columns(0).HeaderText = "#"
        DataGridView1.Columns(1).HeaderText = "Subject Code"
        DataGridView1.Columns(2).HeaderText = "Subject Description"

    End Sub


    Sub clearData()

        txtSubjectCode.Text = ""
        txtSubjectDesc.Text = ""

    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        subjectCode = txtSubjectCode.Text.Trim()
        subjectDesc = txtSubjectDesc.Text.Trim()

        Dim stringQuery As String
        Dim command As OdbcCommand
        Dim connDB As New ConnectionDB

        If subjectCode = "" Or subjectDesc = "" Then

            MessageBox.Show("Please fill up the form!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        Else

            Try
                selectedIndex = cbxYearLevel.SelectedIndex

                stringQuery = "insert into tblsubjectlist (year_id, code, description) values ( ?, ?, ?)"
                command = New OdbcCommand(stringQuery)

                command.Parameters.AddWithValue("?year_id", selectedIndex)
                command.Parameters.AddWithValue("?code", subjectCode)
                command.Parameters.AddWithValue("?description", subjectDesc)

                connDB.commandQuery(command)
                fillData()
                gridSetting()
                clearData()
                MainForm.fillComboBox()

            Catch ex As Exception

                MessageBox.Show("There is an error in database!" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        End If

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub manageSubjectForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        fillComboBox()
        fillData()
        gridSetting()

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        Dim stringQuery As String

        subjectCode = txtSubjectCode.Text.Trim()
        subjectDesc = txtSubjectDesc.Text.Trim()

        If subjectCode = "" Then

            MessageBox.Show("Subject Code is empty! Please Fill up before attempting to update!", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            txtSubjectCode.Focus()

        ElseIf subjectDesc = "" Then

            MessageBox.Show("Subject Description is empty! Please Fill up before attempting to update!", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            txtSubjectDesc.Focus()

        ElseIf selectedIndex <= 0 Then

            MessageBox.Show("Please select specific year level!", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        Else

            Try
                Dim connDB As New ConnectionDB
                stringQuery = "update tblsubjectlist set year_id = ? code = ?, description = ? where id = '" & DataGridView1.CurrentRow.Cells(0).Value & "'"
                command = New OdbcCommand(stringQuery)

                command.Parameters.AddWithValue("?code", subjectCode)
                command.Parameters.AddWithValue("?description", subjectDesc)

                connDB.commandQuery(command)
                fillData()
                gridSetting()
                clearData()
                btnAdd.Enabled = True
                btnEdit.Enabled = False

            Catch ex As Exception

                MessageBox.Show("There is an Error While Connecting to Database! Please Contact your Software Engineer", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try

        End If

    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click

        btnEdit.Enabled = True
        btnAdd.Enabled = False
        txtSubjectCode.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        txtSubjectDesc.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString

    End Sub

    Private Sub btnAssign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssign.Click

        MessageBox.Show(DataGridView1.CurrentRow.Cells(0).Value)
        listProfessorsForm.ShowMe(sender, DataGridView1.CurrentRow.Cells(0).Value)
       
    End Sub
End Class