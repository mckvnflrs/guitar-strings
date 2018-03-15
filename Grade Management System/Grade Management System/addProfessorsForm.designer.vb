<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addProfessorsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addProfessorsForm))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.btnContactInfo = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnPersonalInfo = New System.Windows.Forms.Button
        Me.btnConfirm = New System.Windows.Forms.Button
        Me.pbBanner = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.pnlContactInfo = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtEmailAddress = New System.Windows.Forms.TextBox
        Me.lblemailNotice = New System.Windows.Forms.Label
        Me.phoneIcon = New System.Windows.Forms.PictureBox
        Me.lblConfirmEmailAddress = New System.Windows.Forms.Label
        Me.txtConfirmAddress = New System.Windows.Forms.TextBox
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox
        Me.txtPhoneCode = New System.Windows.Forms.TextBox
        Me.lblPhoneNumber = New System.Windows.Forms.Label
        Me.lblEmailAddress = New System.Windows.Forms.Label
        Me.pnlPersonalInfo = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.pbProfilePicture = New System.Windows.Forms.PictureBox
        Me.btnUploadPic = New System.Windows.Forms.Button
        Me.txtBdegree = New System.Windows.Forms.TextBox
        Me.lblBdegree = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.lblAddress = New System.Windows.Forms.Label
        Me.txtAge = New System.Windows.Forms.TextBox
        Me.lblAge = New System.Windows.Forms.Label
        Me.cbxGender = New System.Windows.Forms.ComboBox
        Me.lblGender = New System.Windows.Forms.Label
        Me.cbxYear = New System.Windows.Forms.ComboBox
        Me.cbxMonth = New System.Windows.Forms.ComboBox
        Me.cbxDate = New System.Windows.Forms.ComboBox
        Me.lblBirthDate = New System.Windows.Forms.Label
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.lblLastName = New System.Windows.Forms.Label
        Me.txtMiddleName = New System.Windows.Forms.TextBox
        Me.lblMiddleName = New System.Windows.Forms.Label
        Me.txtGivenName = New System.Windows.Forms.TextBox
        Me.lblGivenName = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.pbBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.pnlContactInfo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.phoneIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPersonalInfo.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbProfilePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Location = New System.Drawing.Point(14, 12)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnContactInfo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnExit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnClear)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnPersonalInfo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnConfirm)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pbBanner)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel2MinSize = 12
        Me.SplitContainer1.Size = New System.Drawing.Size(737, 345)
        Me.SplitContainer1.SplitterDistance = 230
        Me.SplitContainer1.TabIndex = 7
        '
        'btnContactInfo
        '
        Me.btnContactInfo.BackColor = System.Drawing.Color.White
        Me.btnContactInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnContactInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContactInfo.ForeColor = System.Drawing.Color.Maroon
        Me.btnContactInfo.Location = New System.Drawing.Point(13, 128)
        Me.btnContactInfo.Name = "btnContactInfo"
        Me.btnContactInfo.Size = New System.Drawing.Size(204, 40)
        Me.btnContactInfo.TabIndex = 2
        Me.btnContactInfo.Text = "Contact Information"
        Me.btnContactInfo.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Maroon
        Me.btnExit.Location = New System.Drawing.Point(13, 311)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(204, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Maroon
        Me.btnClear.Location = New System.Drawing.Point(13, 285)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(204, 23)
        Me.btnClear.TabIndex = 62
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnPersonalInfo
        '
        Me.btnPersonalInfo.BackColor = System.Drawing.Color.White
        Me.btnPersonalInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPersonalInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPersonalInfo.ForeColor = System.Drawing.Color.Maroon
        Me.btnPersonalInfo.Location = New System.Drawing.Point(13, 82)
        Me.btnPersonalInfo.Name = "btnPersonalInfo"
        Me.btnPersonalInfo.Size = New System.Drawing.Size(204, 40)
        Me.btnPersonalInfo.TabIndex = 0
        Me.btnPersonalInfo.Text = "Personal Information"
        Me.btnPersonalInfo.UseVisualStyleBackColor = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.White
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.Maroon
        Me.btnConfirm.Location = New System.Drawing.Point(13, 258)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(204, 23)
        Me.btnConfirm.TabIndex = 61
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'pbBanner
        '
        Me.pbBanner.BackColor = System.Drawing.Color.White
        Me.pbBanner.Image = CType(resources.GetObject("pbBanner.Image"), System.Drawing.Image)
        Me.pbBanner.InitialImage = Nothing
        Me.pbBanner.Location = New System.Drawing.Point(13, 12)
        Me.pbBanner.Name = "pbBanner"
        Me.pbBanner.Size = New System.Drawing.Size(204, 50)
        Me.pbBanner.TabIndex = 63
        Me.pbBanner.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Maroon
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.pnlPersonalInfo)
        Me.GroupBox1.Controls.Add(Me.pnlContactInfo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(494, 337)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information"
        Me.GroupBox1.UseCompatibleTextRendering = True
        '
        'pnlContactInfo
        '
        Me.pnlContactInfo.BackColor = System.Drawing.Color.White
        Me.pnlContactInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlContactInfo.Controls.Add(Me.Panel1)
        Me.pnlContactInfo.Location = New System.Drawing.Point(6, 19)
        Me.pnlContactInfo.Name = "pnlContactInfo"
        Me.pnlContactInfo.Size = New System.Drawing.Size(482, 312)
        Me.pnlContactInfo.TabIndex = 49
        Me.pnlContactInfo.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(18, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(444, 270)
        Me.Panel1.TabIndex = 22
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.txtEmailAddress)
        Me.Panel2.Controls.Add(Me.lblemailNotice)
        Me.Panel2.Controls.Add(Me.phoneIcon)
        Me.Panel2.Controls.Add(Me.lblConfirmEmailAddress)
        Me.Panel2.Controls.Add(Me.txtConfirmAddress)
        Me.Panel2.Controls.Add(Me.txtPhoneNumber)
        Me.Panel2.Controls.Add(Me.txtPhoneCode)
        Me.Panel2.Controls.Add(Me.lblPhoneNumber)
        Me.Panel2.Controls.Add(Me.lblEmailAddress)
        Me.Panel2.Location = New System.Drawing.Point(22, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(399, 230)
        Me.Panel2.TabIndex = 0
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.BackColor = System.Drawing.Color.LightGray
        Me.txtEmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailAddress.Location = New System.Drawing.Point(180, 54)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(177, 20)
        Me.txtEmailAddress.TabIndex = 1
        '
        'lblemailNotice
        '
        Me.lblemailNotice.BackColor = System.Drawing.Color.Transparent
        Me.lblemailNotice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblemailNotice.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemailNotice.ForeColor = System.Drawing.Color.DarkRed
        Me.lblemailNotice.Location = New System.Drawing.Point(40, 171)
        Me.lblemailNotice.Name = "lblemailNotice"
        Me.lblemailNotice.Size = New System.Drawing.Size(317, 32)
        Me.lblemailNotice.TabIndex = 30
        Me.lblemailNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'phoneIcon
        '
        Me.phoneIcon.BackgroundImage = Global.Grade_Management_System.My.Resources.Resource1.ico_ph
        Me.phoneIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.phoneIcon.Location = New System.Drawing.Point(180, 126)
        Me.phoneIcon.Name = "phoneIcon"
        Me.phoneIcon.Size = New System.Drawing.Size(20, 19)
        Me.phoneIcon.TabIndex = 29
        Me.phoneIcon.TabStop = False
        '
        'lblConfirmEmailAddress
        '
        Me.lblConfirmEmailAddress.AutoSize = True
        Me.lblConfirmEmailAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblConfirmEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmEmailAddress.ForeColor = System.Drawing.Color.Maroon
        Me.lblConfirmEmailAddress.Location = New System.Drawing.Point(40, 95)
        Me.lblConfirmEmailAddress.Name = "lblConfirmEmailAddress"
        Me.lblConfirmEmailAddress.Size = New System.Drawing.Size(136, 13)
        Me.lblConfirmEmailAddress.TabIndex = 28
        Me.lblConfirmEmailAddress.Text = "Confirm Email Address:"
        '
        'txtConfirmAddress
        '
        Me.txtConfirmAddress.BackColor = System.Drawing.Color.LightGray
        Me.txtConfirmAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirmAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmAddress.Location = New System.Drawing.Point(180, 91)
        Me.txtConfirmAddress.Name = "txtConfirmAddress"
        Me.txtConfirmAddress.Size = New System.Drawing.Size(177, 20)
        Me.txtConfirmAddress.TabIndex = 2
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.BackColor = System.Drawing.Color.LightGray
        Me.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(234, 126)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(123, 20)
        Me.txtPhoneNumber.TabIndex = 3
        '
        'txtPhoneCode
        '
        Me.txtPhoneCode.BackColor = System.Drawing.Color.LightGray
        Me.txtPhoneCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhoneCode.Enabled = False
        Me.txtPhoneCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneCode.Location = New System.Drawing.Point(201, 126)
        Me.txtPhoneCode.Name = "txtPhoneCode"
        Me.txtPhoneCode.Size = New System.Drawing.Size(30, 20)
        Me.txtPhoneCode.TabIndex = 25
        Me.txtPhoneCode.Text = "+63"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNumber.ForeColor = System.Drawing.Color.Maroon
        Me.lblPhoneNumber.Location = New System.Drawing.Point(40, 130)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(92, 13)
        Me.lblPhoneNumber.TabIndex = 24
        Me.lblPhoneNumber.Text = "Phone number:"
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.AutoSize = True
        Me.lblEmailAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailAddress.ForeColor = System.Drawing.Color.Maroon
        Me.lblEmailAddress.Location = New System.Drawing.Point(40, 58)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(90, 13)
        Me.lblEmailAddress.TabIndex = 22
        Me.lblEmailAddress.Text = "Email Address:"
        '
        'pnlPersonalInfo
        '
        Me.pnlPersonalInfo.BackColor = System.Drawing.Color.White
        Me.pnlPersonalInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlPersonalInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlPersonalInfo.Controls.Add(Me.GroupBox2)
        Me.pnlPersonalInfo.Controls.Add(Me.txtBdegree)
        Me.pnlPersonalInfo.Controls.Add(Me.lblBdegree)
        Me.pnlPersonalInfo.Controls.Add(Me.txtAddress)
        Me.pnlPersonalInfo.Controls.Add(Me.lblAddress)
        Me.pnlPersonalInfo.Controls.Add(Me.txtAge)
        Me.pnlPersonalInfo.Controls.Add(Me.lblAge)
        Me.pnlPersonalInfo.Controls.Add(Me.cbxGender)
        Me.pnlPersonalInfo.Controls.Add(Me.lblGender)
        Me.pnlPersonalInfo.Controls.Add(Me.cbxYear)
        Me.pnlPersonalInfo.Controls.Add(Me.cbxMonth)
        Me.pnlPersonalInfo.Controls.Add(Me.cbxDate)
        Me.pnlPersonalInfo.Controls.Add(Me.lblBirthDate)
        Me.pnlPersonalInfo.Controls.Add(Me.txtLastName)
        Me.pnlPersonalInfo.Controls.Add(Me.lblLastName)
        Me.pnlPersonalInfo.Controls.Add(Me.txtMiddleName)
        Me.pnlPersonalInfo.Controls.Add(Me.lblMiddleName)
        Me.pnlPersonalInfo.Controls.Add(Me.txtGivenName)
        Me.pnlPersonalInfo.Controls.Add(Me.lblGivenName)
        Me.pnlPersonalInfo.Location = New System.Drawing.Point(6, 19)
        Me.pnlPersonalInfo.Name = "pnlPersonalInfo"
        Me.pnlPersonalInfo.Size = New System.Drawing.Size(482, 312)
        Me.pnlPersonalInfo.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.pbProfilePicture)
        Me.GroupBox2.Controls.Add(Me.btnUploadPic)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(280, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(195, 233)
        Me.GroupBox2.TabIndex = 65
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Profile Picture:"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Maroon
        Me.Button1.Location = New System.Drawing.Point(18, 204)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 23)
        Me.Button1.TabIndex = 70
        Me.Button1.Text = "Remove"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pbProfilePicture
        '
        Me.pbProfilePicture.BackColor = System.Drawing.Color.White
        Me.pbProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbProfilePicture.Location = New System.Drawing.Point(19, 26)
        Me.pbProfilePicture.Name = "pbProfilePicture"
        Me.pbProfilePicture.Size = New System.Drawing.Size(159, 143)
        Me.pbProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProfilePicture.TabIndex = 68
        Me.pbProfilePicture.TabStop = False
        '
        'btnUploadPic
        '
        Me.btnUploadPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUploadPic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUploadPic.ForeColor = System.Drawing.Color.Maroon
        Me.btnUploadPic.Location = New System.Drawing.Point(18, 177)
        Me.btnUploadPic.Name = "btnUploadPic"
        Me.btnUploadPic.Size = New System.Drawing.Size(159, 23)
        Me.btnUploadPic.TabIndex = 69
        Me.btnUploadPic.Text = "Upload Photo"
        Me.btnUploadPic.UseVisualStyleBackColor = True
        '
        'txtBdegree
        '
        Me.txtBdegree.BackColor = System.Drawing.Color.LightGray
        Me.txtBdegree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBdegree.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBdegree.Location = New System.Drawing.Point(19, 281)
        Me.txtBdegree.Name = "txtBdegree"
        Me.txtBdegree.Size = New System.Drawing.Size(444, 20)
        Me.txtBdegree.TabIndex = 10
        '
        'lblBdegree
        '
        Me.lblBdegree.AutoSize = True
        Me.lblBdegree.BackColor = System.Drawing.Color.White
        Me.lblBdegree.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBdegree.ForeColor = System.Drawing.Color.Maroon
        Me.lblBdegree.Location = New System.Drawing.Point(19, 265)
        Me.lblBdegree.Name = "lblBdegree"
        Me.lblBdegree.Size = New System.Drawing.Size(115, 13)
        Me.lblBdegree.TabIndex = 64
        Me.lblBdegree.Text = "Bachelor's Degree:"
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.LightGray
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(22, 242)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(441, 20)
        Me.txtAddress.TabIndex = 9
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.BackColor = System.Drawing.Color.White
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.Maroon
        Me.lblAddress.Location = New System.Drawing.Point(19, 226)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(112, 13)
        Me.lblAddress.TabIndex = 53
        Me.lblAddress.Text = "Complete Address:"
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.Color.LightGray
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(192, 134)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(62, 20)
        Me.txtAge.TabIndex = 4
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.BackColor = System.Drawing.Color.Transparent
        Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.ForeColor = System.Drawing.Color.Maroon
        Me.lblAge.Location = New System.Drawing.Point(189, 118)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(33, 13)
        Me.lblAge.TabIndex = 51
        Me.lblAge.Text = "Age:"
        '
        'cbxGender
        '
        Me.cbxGender.BackColor = System.Drawing.Color.LightGray
        Me.cbxGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxGender.FormattingEnabled = True
        Me.cbxGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbxGender.Location = New System.Drawing.Point(192, 180)
        Me.cbxGender.Name = "cbxGender"
        Me.cbxGender.Size = New System.Drawing.Size(82, 21)
        Me.cbxGender.TabIndex = 8
        Me.cbxGender.Text = "Male"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.Color.White
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.Maroon
        Me.lblGender.Location = New System.Drawing.Point(189, 166)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(52, 13)
        Me.lblGender.TabIndex = 49
        Me.lblGender.Text = "Gender:"
        '
        'cbxYear
        '
        Me.cbxYear.BackColor = System.Drawing.Color.LightGray
        Me.cbxYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxYear.FormattingEnabled = True
        Me.cbxYear.Items.AddRange(New Object() {"1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018"})
        Me.cbxYear.Location = New System.Drawing.Point(115, 182)
        Me.cbxYear.Name = "cbxYear"
        Me.cbxYear.Size = New System.Drawing.Size(55, 21)
        Me.cbxYear.TabIndex = 7
        Me.cbxYear.Text = "YYYY"
        '
        'cbxMonth
        '
        Me.cbxMonth.BackColor = System.Drawing.Color.LightGray
        Me.cbxMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMonth.FormattingEnabled = True
        Me.cbxMonth.Items.AddRange(New Object() {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"})
        Me.cbxMonth.Location = New System.Drawing.Point(64, 182)
        Me.cbxMonth.Name = "cbxMonth"
        Me.cbxMonth.Size = New System.Drawing.Size(45, 21)
        Me.cbxMonth.TabIndex = 6
        Me.cbxMonth.Text = "MM"
        '
        'cbxDate
        '
        Me.cbxDate.BackColor = System.Drawing.Color.LightGray
        Me.cbxDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDate.FormattingEnabled = True
        Me.cbxDate.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cbxDate.Location = New System.Drawing.Point(19, 182)
        Me.cbxDate.Name = "cbxDate"
        Me.cbxDate.Size = New System.Drawing.Size(39, 21)
        Me.cbxDate.TabIndex = 5
        Me.cbxDate.Text = "DDD"
        '
        'lblBirthDate
        '
        Me.lblBirthDate.AutoSize = True
        Me.lblBirthDate.BackColor = System.Drawing.Color.White
        Me.lblBirthDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthDate.ForeColor = System.Drawing.Color.Maroon
        Me.lblBirthDate.Location = New System.Drawing.Point(16, 166)
        Me.lblBirthDate.Name = "lblBirthDate"
        Me.lblBirthDate.Size = New System.Drawing.Size(82, 13)
        Me.lblBirthDate.TabIndex = 45
        Me.lblBirthDate.Text = "Date of birth:"
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.LightGray
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(19, 132)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(151, 20)
        Me.txtLastName.TabIndex = 3
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.BackColor = System.Drawing.Color.White
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.Color.Maroon
        Me.lblLastName.Location = New System.Drawing.Point(16, 116)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(69, 13)
        Me.lblLastName.TabIndex = 43
        Me.lblLastName.Text = "Last name:"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.BackColor = System.Drawing.Color.LightGray
        Me.txtMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMiddleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleName.Location = New System.Drawing.Point(19, 86)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(151, 20)
        Me.txtMiddleName.TabIndex = 2
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.BackColor = System.Drawing.Color.White
        Me.lblMiddleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddleName.ForeColor = System.Drawing.Color.Maroon
        Me.lblMiddleName.Location = New System.Drawing.Point(16, 70)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(82, 13)
        Me.lblMiddleName.TabIndex = 41
        Me.lblMiddleName.Text = "Middle name:"
        '
        'txtGivenName
        '
        Me.txtGivenName.BackColor = System.Drawing.Color.LightGray
        Me.txtGivenName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGivenName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGivenName.Location = New System.Drawing.Point(19, 45)
        Me.txtGivenName.Name = "txtGivenName"
        Me.txtGivenName.Size = New System.Drawing.Size(151, 20)
        Me.txtGivenName.TabIndex = 1
        '
        'lblGivenName
        '
        Me.lblGivenName.AutoSize = True
        Me.lblGivenName.BackColor = System.Drawing.Color.White
        Me.lblGivenName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGivenName.ForeColor = System.Drawing.Color.Maroon
        Me.lblGivenName.Location = New System.Drawing.Point(16, 29)
        Me.lblGivenName.Name = "lblGivenName"
        Me.lblGivenName.Size = New System.Drawing.Size(78, 13)
        Me.lblGivenName.TabIndex = 39
        Me.lblGivenName.Text = "Given name:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 364)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(762, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(140, 17)
        Me.ToolStripStatusLabel1.Text = "Made by Kevin F. Macalalag"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Image Files (*.jpeg,*.jpg,*.png, *.bmp, *.gif)|*.png; *.bmp; *.jpg;*.jpeg; *.gif;" & _
            ""
        Me.OpenFileDialog1.FilterIndex = 4
        '
        'addProfessorsForm
        '
        Me.AcceptButton = Me.btnConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(762, 386)
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "addProfessorsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Professor's Registration"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.pbBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.pnlContactInfo.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.phoneIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPersonalInfo.ResumeLayout(False)
        Me.pnlPersonalInfo.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.pbProfilePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnPersonalInfo As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnContactInfo As System.Windows.Forms.Button
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents pnlPersonalInfo As System.Windows.Forms.Panel
    Friend WithEvents cbxYear As System.Windows.Forms.ComboBox
    Friend WithEvents cbxMonth As System.Windows.Forms.ComboBox
    Friend WithEvents cbxDate As System.Windows.Forms.ComboBox
    Friend WithEvents lblBirthDate As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents txtMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents lblMiddleName As System.Windows.Forms.Label
    Friend WithEvents txtGivenName As System.Windows.Forms.TextBox
    Friend WithEvents lblGivenName As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents pnlContactInfo As System.Windows.Forms.Panel
    Friend WithEvents cbxGender As System.Windows.Forms.ComboBox
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents txtBdegree As System.Windows.Forms.TextBox
    Friend WithEvents lblBdegree As System.Windows.Forms.Label
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents phoneIcon As System.Windows.Forms.PictureBox
    Friend WithEvents lblConfirmEmailAddress As System.Windows.Forms.Label
    Friend WithEvents txtConfirmAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneCode As System.Windows.Forms.TextBox
    Friend WithEvents lblPhoneNumber As System.Windows.Forms.Label
    Friend WithEvents txtEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblEmailAddress As System.Windows.Forms.Label
    Friend WithEvents lblemailNotice As System.Windows.Forms.Label
    Friend WithEvents pbBanner As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pbProfilePicture As System.Windows.Forms.PictureBox
    Friend WithEvents btnUploadPic As System.Windows.Forms.Button
End Class
