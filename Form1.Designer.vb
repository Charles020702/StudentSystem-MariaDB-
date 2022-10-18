<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtstudno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.txtmi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.cmbgender = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbcourse = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.txtclear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student No:"
        '
        'txtstudno
        '
        Me.txtstudno.BackColor = System.Drawing.SystemColors.Menu
        Me.txtstudno.Location = New System.Drawing.Point(107, 38)
        Me.txtstudno.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtstudno.Name = "txtstudno"
        Me.txtstudno.Size = New System.Drawing.Size(50, 20)
        Me.txtstudno.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 79)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Last Name"
        '
        'txtlastname
        '
        Me.txtlastname.BackColor = System.Drawing.SystemColors.Menu
        Me.txtlastname.Location = New System.Drawing.Point(34, 95)
        Me.txtlastname.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(167, 20)
        Me.txtlastname.TabIndex = 3
        '
        'txtmi
        '
        Me.txtmi.BackColor = System.Drawing.SystemColors.Menu
        Me.txtmi.Location = New System.Drawing.Point(400, 95)
        Me.txtmi.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtmi.Name = "txtmi"
        Me.txtmi.Size = New System.Drawing.Size(41, 20)
        Me.txtmi.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(209, 79)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(397, 79)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "MI"
        '
        'txtfirstname
        '
        Me.txtfirstname.BackColor = System.Drawing.SystemColors.Menu
        Me.txtfirstname.Location = New System.Drawing.Point(209, 95)
        Me.txtfirstname.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(167, 20)
        Me.txtfirstname.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 142)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Address"
        '
        'txtaddress
        '
        Me.txtaddress.BackColor = System.Drawing.SystemColors.Menu
        Me.txtaddress.Location = New System.Drawing.Point(34, 158)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(423, 20)
        Me.txtaddress.TabIndex = 10
        '
        'cmbgender
        '
        Me.cmbgender.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.cmbgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbgender.FormattingEnabled = True
        Me.cmbgender.Items.AddRange(New Object() {"" & Global.Microsoft.VisualBasic.ChrW(9) & "Boy", "Girl"})
        Me.cmbgender.Location = New System.Drawing.Point(34, 210)
        Me.cmbgender.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbgender.Name = "cmbgender"
        Me.cmbgender.Size = New System.Drawing.Size(140, 21)
        Me.cmbgender.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 192)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Gender"
        '
        'cmbcourse
        '
        Me.cmbcourse.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.cmbcourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcourse.FormattingEnabled = True
        Me.cmbcourse.Items.AddRange(New Object() {"BSED", "BSIT", "BSCrim", "HRM"})
        Me.cmbcourse.Location = New System.Drawing.Point(352, 211)
        Me.cmbcourse.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbcourse.Name = "cmbcourse"
        Me.cmbcourse.Size = New System.Drawing.Size(140, 21)
        Me.cmbcourse.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(349, 192)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Course"
        '
        'txtcontact
        '
        Me.txtcontact.BackColor = System.Drawing.SystemColors.Menu
        Me.txtcontact.Location = New System.Drawing.Point(182, 211)
        Me.txtcontact.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(163, 20)
        Me.txtcontact.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(178, 192)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Contact No."
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.Menu
        Me.ListView1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(34, 237)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(459, 140)
        Me.ListView1.TabIndex = 17
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'btnadd
        '
        Me.btnadd.Image = CType(resources.GetObject("btnadd.Image"), System.Drawing.Image)
        Me.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnadd.Location = New System.Drawing.Point(168, 394)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(98, 32)
        Me.btnadd.TabIndex = 18
        Me.btnadd.Text = "ADD NEW"
        Me.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Image = CType(resources.GetObject("btnupdate.Image"), System.Drawing.Image)
        Me.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnupdate.Location = New System.Drawing.Point(274, 394)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(92, 32)
        Me.btnupdate.TabIndex = 19
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Image = CType(resources.GetObject("btndelete.Image"), System.Drawing.Image)
        Me.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndelete.Location = New System.Drawing.Point(400, 394)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(90, 32)
        Me.btndelete.TabIndex = 20
        Me.btndelete.Text = "DELETE"
        Me.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'txtclear
        '
        Me.txtclear.Image = CType(resources.GetObject("txtclear.Image"), System.Drawing.Image)
        Me.txtclear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtclear.Location = New System.Drawing.Point(34, 394)
        Me.txtclear.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtclear.Name = "txtclear"
        Me.txtclear.Size = New System.Drawing.Size(98, 32)
        Me.txtclear.TabIndex = 21
        Me.txtclear.Text = "Clear"
        Me.txtclear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(507, 450)
        Me.Controls.Add(Me.txtclear)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtcontact)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbcourse)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbgender)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtfirstname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtmi)
        Me.Controls.Add(Me.txtlastname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtstudno)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Student System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtstudno As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents txtmi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbcourse As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtcontact As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents btnadd As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents cmbgender As ComboBox
    Friend WithEvents txtclear As Button
End Class
