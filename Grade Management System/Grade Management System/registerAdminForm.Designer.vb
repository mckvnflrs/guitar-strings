<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registerAdminForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblNotice2 = New System.Windows.Forms.Label
        Me.lblNotice1 = New System.Windows.Forms.Label
        Me.cbxSecretQuestion = New System.Windows.Forms.ComboBox
        Me.txtConfirmAnswer = New System.Windows.Forms.TextBox
        Me.lblConfirmAnswer = New System.Windows.Forms.Label
        Me.txtAnswer = New System.Windows.Forms.TextBox
        Me.lblAnswer = New System.Windows.Forms.Label
        Me.lblSecretQuestion = New System.Windows.Forms.Label
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox
        Me.lblConfirmPassword = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.lblPassword = New System.Windows.Forms.Label
        Me.txtUsername = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnAdminConfirm = New System.Windows.Forms.Button
        Me.btnAdminClear = New System.Windows.Forms.Button
        Me.btnAdminRegExit = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(525, 294)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Register Here"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(7, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(512, 268)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.lblNotice2)
        Me.Panel2.Controls.Add(Me.lblNotice1)
        Me.Panel2.Controls.Add(Me.cbxSecretQuestion)
        Me.Panel2.Controls.Add(Me.txtConfirmAnswer)
        Me.Panel2.Controls.Add(Me.lblConfirmAnswer)
        Me.Panel2.Controls.Add(Me.txtAnswer)
        Me.Panel2.Controls.Add(Me.lblAnswer)
        Me.Panel2.Controls.Add(Me.lblSecretQuestion)
        Me.Panel2.Controls.Add(Me.txtConfirmPassword)
        Me.Panel2.Controls.Add(Me.lblConfirmPassword)
        Me.Panel2.Controls.Add(Me.txtPassword)
        Me.Panel2.Controls.Add(Me.lblPassword)
        Me.Panel2.Controls.Add(Me.txtUsername)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(16, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(478, 234)
        Me.Panel2.TabIndex = 0
        '
        'lblNotice2
        '
        Me.lblNotice2.BackColor = System.Drawing.Color.LightGray
        Me.lblNotice2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNotice2.ForeColor = System.Drawing.Color.DarkRed
        Me.lblNotice2.Location = New System.Drawing.Point(253, 190)
        Me.lblNotice2.Name = "lblNotice2"
        Me.lblNotice2.Size = New System.Drawing.Size(205, 20)
        Me.lblNotice2.TabIndex = 14
        Me.lblNotice2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNotice1
        '
        Me.lblNotice1.BackColor = System.Drawing.Color.LightGray
        Me.lblNotice1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNotice1.ForeColor = System.Drawing.Color.DarkRed
        Me.lblNotice1.Location = New System.Drawing.Point(23, 190)
        Me.lblNotice1.Name = "lblNotice1"
        Me.lblNotice1.Size = New System.Drawing.Size(205, 20)
        Me.lblNotice1.TabIndex = 13
        Me.lblNotice1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbxSecretQuestion
        '
        Me.cbxSecretQuestion.BackColor = System.Drawing.Color.LightGray
        Me.cbxSecretQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxSecretQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSecretQuestion.FormattingEnabled = True
        Me.cbxSecretQuestion.Items.AddRange(New Object() {"What is the name of your dog?", "What is your maiden name?", "What is your favorite food?", "What is your Hobby?"})
        Me.cbxSecretQuestion.Location = New System.Drawing.Point(253, 37)
        Me.cbxSecretQuestion.Name = "cbxSecretQuestion"
        Me.cbxSecretQuestion.Size = New System.Drawing.Size(205, 21)
        Me.cbxSecretQuestion.TabIndex = 4
        '
        'txtConfirmAnswer
        '
        Me.txtConfirmAnswer.BackColor = System.Drawing.Color.LightGray
        Me.txtConfirmAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirmAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmAnswer.Location = New System.Drawing.Point(253, 150)
        Me.txtConfirmAnswer.Name = "txtConfirmAnswer"
        Me.txtConfirmAnswer.Size = New System.Drawing.Size(205, 22)
        Me.txtConfirmAnswer.TabIndex = 6
        Me.txtConfirmAnswer.UseSystemPasswordChar = True
        '
        'lblConfirmAnswer
        '
        Me.lblConfirmAnswer.AutoSize = True
        Me.lblConfirmAnswer.ForeColor = System.Drawing.Color.Maroon
        Me.lblConfirmAnswer.Location = New System.Drawing.Point(250, 133)
        Me.lblConfirmAnswer.Name = "lblConfirmAnswer"
        Me.lblConfirmAnswer.Size = New System.Drawing.Size(98, 13)
        Me.lblConfirmAnswer.TabIndex = 10
        Me.lblConfirmAnswer.Text = "Confirm Answer:"
        '
        'txtAnswer
        '
        Me.txtAnswer.BackColor = System.Drawing.Color.LightGray
        Me.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.Location = New System.Drawing.Point(253, 94)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(205, 22)
        Me.txtAnswer.TabIndex = 5
        Me.txtAnswer.UseSystemPasswordChar = True
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.ForeColor = System.Drawing.Color.Maroon
        Me.lblAnswer.Location = New System.Drawing.Point(250, 77)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(52, 13)
        Me.lblAnswer.TabIndex = 8
        Me.lblAnswer.Text = "Answer:"
        '
        'lblSecretQuestion
        '
        Me.lblSecretQuestion.AutoSize = True
        Me.lblSecretQuestion.ForeColor = System.Drawing.Color.Maroon
        Me.lblSecretQuestion.Location = New System.Drawing.Point(250, 20)
        Me.lblSecretQuestion.Name = "lblSecretQuestion"
        Me.lblSecretQuestion.Size = New System.Drawing.Size(102, 13)
        Me.lblSecretQuestion.TabIndex = 6
        Me.lblSecretQuestion.Text = "Secret Question:"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.BackColor = System.Drawing.Color.LightGray
        Me.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(23, 150)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(205, 22)
        Me.txtConfirmPassword.TabIndex = 3
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.ForeColor = System.Drawing.Color.Maroon
        Me.lblConfirmPassword.Location = New System.Drawing.Point(20, 133)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(111, 13)
        Me.lblConfirmPassword.TabIndex = 4
        Me.lblConfirmPassword.Text = "Confirm Password:"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.LightGray
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(23, 94)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(205, 22)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.ForeColor = System.Drawing.Color.Maroon
        Me.lblPassword.Location = New System.Drawing.Point(20, 77)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(65, 13)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Password:"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.LightGray
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(23, 37)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(205, 20)
        Me.txtUsername.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(20, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'btnAdminConfirm
        '
        Me.btnAdminConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdminConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminConfirm.ForeColor = System.Drawing.Color.Maroon
        Me.btnAdminConfirm.Location = New System.Drawing.Point(544, 219)
        Me.btnAdminConfirm.Name = "btnAdminConfirm"
        Me.btnAdminConfirm.Size = New System.Drawing.Size(184, 23)
        Me.btnAdminConfirm.TabIndex = 1
        Me.btnAdminConfirm.Text = "Confirm"
        Me.btnAdminConfirm.UseVisualStyleBackColor = True
        '
        'btnAdminClear
        '
        Me.btnAdminClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdminClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminClear.ForeColor = System.Drawing.Color.Maroon
        Me.btnAdminClear.Location = New System.Drawing.Point(544, 248)
        Me.btnAdminClear.Name = "btnAdminClear"
        Me.btnAdminClear.Size = New System.Drawing.Size(184, 23)
        Me.btnAdminClear.TabIndex = 2
        Me.btnAdminClear.Text = "Clear"
        Me.btnAdminClear.UseVisualStyleBackColor = True
        '
        'btnAdminRegExit
        '
        Me.btnAdminRegExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdminRegExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminRegExit.ForeColor = System.Drawing.Color.Maroon
        Me.btnAdminRegExit.Location = New System.Drawing.Point(544, 284)
        Me.btnAdminRegExit.Name = "btnAdminRegExit"
        Me.btnAdminRegExit.Size = New System.Drawing.Size(184, 23)
        Me.btnAdminRegExit.TabIndex = 3
        Me.btnAdminRegExit.Text = "Exit"
        Me.btnAdminRegExit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Grade_Management_System.My.Resources.Resource1.bg_home
        Me.PictureBox1.Location = New System.Drawing.Point(545, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(183, 175)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'registerAdminForm
        '
        Me.AcceptButton = Me.btnAdminConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(740, 319)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnAdminRegExit)
        Me.Controls.Add(Me.btnAdminClear)
        Me.Controls.Add(Me.btnAdminConfirm)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "registerAdminForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Registration"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtConfirmAnswer As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirmAnswer As System.Windows.Forms.Label
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents lblSecretQuestion As System.Windows.Forms.Label
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirmPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents cbxSecretQuestion As System.Windows.Forms.ComboBox
    Friend WithEvents lblNotice1 As System.Windows.Forms.Label
    Friend WithEvents lblNotice2 As System.Windows.Forms.Label
    Friend WithEvents btnAdminConfirm As System.Windows.Forms.Button
    Friend WithEvents btnAdminClear As System.Windows.Forms.Button
    Friend WithEvents btnAdminRegExit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
