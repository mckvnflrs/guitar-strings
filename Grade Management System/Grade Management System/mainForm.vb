Imports System.Windows.Forms
Imports System.Data.Odbc

Public Class MainForm

    Dim connString As String = "driver=MySQL ODBC 5.3 ANSI Driver;Localhost;port=3306;uid='root';pwd=abc123;database=gmsdb"
    Dim connect As New OdbcConnection(connString)

    Dim stringQuery, stringQuery2 As String
    Dim command, command2 As OdbcCommand
    Dim adaptData, adaptData2 As New OdbcDataAdapter
    Dim setData As New DataSet

    Public Sub fillComboBox()

        Dim count As Integer = 0

        Try
            connect.Open()
            stringQuery = "select * from tblsubjectlist"
            command = New OdbcCommand(stringQuery, connect)
            adaptData.SelectCommand = command
            adaptData.Fill(setData)
            adaptData.Dispose()
            command.Dispose()
            connect.Close()
            cbxSelectSubject.DataSource = setData.Tables(0)
            cbxSelectSubject.ValueMember = "id"
            cbxSelectSubject.DisplayMember = "code"
            cbxSelectSubject.Refresh()

        Catch ex As Exception

            MessageBox.Show("There is an error while connecting to database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Close()

    End Sub

    Private Sub NewStaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewStaffToolStripMenuItem.Click

        Dim RegForm As New addProfessorsForm
        RegForm.ShowDialog()

    End Sub

    Private Sub NewAdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewAdminToolStripMenuItem.Click

        Dim AdminForm As New registerAdminForm
        AdminForm.ShowDialog()

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click

        Dim result = MessageBox.Show("Are you sure you want to log out?", "Log out Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


        If result = DialogResult.Yes Then

            Dim loginForm As New LoginForm

            MainPanel.Visible = True
            loginForm.ShowDialog()

        End If

    End Sub

    Private Sub ManageProfessor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageProfessor.Click

        Timer1.Start()
        ManageProfessor.Enabled = False

    End Sub

    Private Sub ManageStudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageStudent.Click

        Timer1.Start()
        ManageStudent.Enabled = False

    End Sub

    Private Sub GradingSystem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradingSystem.Click

        Timer1.Start()
        GradingSystem.Enabled = False

    End Sub

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        connect.Close()
        LoginForm.ShowDialog()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        SplitContainer1.Visible = False
        MainPanel.Visible = True

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        ToolStripProgressBar1.Increment(20)
        If ToolStripProgressBar1.Value = ToolStripProgressBar1.Maximum Then

            Timer1.Stop()
            ToolStripProgressBar1.Value = 0

            If ManageStudent.Enabled = False Then

                ManageStudent.Enabled = True
                listStudentForm.ShowDialog()

            ElseIf ManageProfessor.Enabled = False Then

                ManageProfessor.Enabled = True
                listProfessorsForm.ShowDialog()

            ElseIf GradingSystem.Enabled = False Then

                GradingSystem.Enabled = True
                Dim subjectForm As New manageSubjectForm

                subjectForm.btnEdit.Enabled = False
                subjectForm.ShowDialog()

            End If

        End If

    End Sub

    Private Sub btnManageStudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManageStudent.Click

        manageStudentForm.ShowDialog()

    End Sub
End Class
