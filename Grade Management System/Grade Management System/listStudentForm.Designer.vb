<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listStudentForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.cbxSort = New System.Windows.Forms.ComboBox
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnView = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.btnDrop = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.StudentRegForm2 = New Grade_Management_System.StudentRegForm
        Me.StudentRegForm1 = New Grade_Management_System.StudentRegForm
        Me.btnSearch = New System.Windows.Forms.Button
        Me.studentProfilephoto = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.studentProfilephoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxSort
        '
        Me.cbxSort.BackColor = System.Drawing.Color.LightGray
        Me.cbxSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSort.ForeColor = System.Drawing.Color.Maroon
        Me.cbxSort.FormattingEnabled = True
        Me.cbxSort.Location = New System.Drawing.Point(466, 29)
        Me.cbxSort.Name = "cbxSort"
        Me.cbxSort.Size = New System.Drawing.Size(121, 21)
        Me.cbxSort.TabIndex = 23
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.LightGray
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Location = New System.Drawing.Point(339, 29)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(121, 20)
        Me.txtSearch.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnView)
        Me.GroupBox1.Location = New System.Drawing.Point(683, 228)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 49)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 3
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.Maroon
        Me.btnClose.Location = New System.Drawing.Point(114, 13)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 30)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.FlatAppearance.BorderSize = 3
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.ForeColor = System.Drawing.Color.Maroon
        Me.btnView.Location = New System.Drawing.Point(7, 13)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(80, 30)
        Me.btnView.TabIndex = 0
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(10, 55)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(667, 167)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Colegio De San Gabriel | List of all Students"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(655, 142)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.studentProfilephoto)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox5.Location = New System.Drawing.Point(683, 10)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 212)
        Me.GroupBox5.TabIndex = 19
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Student Photo:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnRefresh)
        Me.GroupBox2.Controls.Add(Me.btnDrop)
        Me.GroupBox2.Controls.Add(Me.btnEdit)
        Me.GroupBox2.Controls.Add(Me.btnNew)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 228)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(354, 49)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        '
        'btnRefresh
        '
        Me.btnRefresh.FlatAppearance.BorderSize = 3
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.ForeColor = System.Drawing.Color.Maroon
        Me.btnRefresh.Location = New System.Drawing.Point(265, 13)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(80, 30)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnDrop
        '
        Me.btnDrop.FlatAppearance.BorderSize = 3
        Me.btnDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDrop.ForeColor = System.Drawing.Color.Maroon
        Me.btnDrop.Location = New System.Drawing.Point(179, 13)
        Me.btnDrop.Name = "btnDrop"
        Me.btnDrop.Size = New System.Drawing.Size(80, 30)
        Me.btnDrop.TabIndex = 2
        Me.btnDrop.Text = "Drop"
        Me.btnDrop.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.FlatAppearance.BorderSize = 3
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.ForeColor = System.Drawing.Color.Maroon
        Me.btnEdit.Location = New System.Drawing.Point(93, 13)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(80, 30)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.FlatAppearance.BorderSize = 3
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.ForeColor = System.Drawing.Color.Maroon
        Me.btnNew.Location = New System.Drawing.Point(7, 13)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(80, 30)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(10, 283)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.StudentRegForm2
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(873, 315)
        Me.CrystalReportViewer1.TabIndex = 20
        '
        'btnSearch
        '
        Me.btnSearch.FlatAppearance.BorderSize = 2
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Maroon
        Me.btnSearch.Image = Global.Grade_Management_System.My.Resources.Resource1.ico_Ssearch
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnSearch.Location = New System.Drawing.Point(593, 21)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(84, 37)
        Me.btnSearch.TabIndex = 24
        Me.btnSearch.Text = "Search"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'studentProfilephoto
        '
        Me.studentProfilephoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.studentProfilephoto.Location = New System.Drawing.Point(6, 20)
        Me.studentProfilephoto.Name = "studentProfilephoto"
        Me.studentProfilephoto.Size = New System.Drawing.Size(188, 186)
        Me.studentProfilephoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.studentProfilephoto.TabIndex = 0
        Me.studentProfilephoto.TabStop = False
        '
        'listStudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(895, 587)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.cbxSort)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "listStudentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List of All Students"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.studentProfilephoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents cbxSort As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents studentProfilephoto As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnDrop As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents StudentRegForm1 As Grade_Management_System.StudentRegForm
    Friend WithEvents StudentRegForm2 As Grade_Management_System.StudentRegForm
End Class
