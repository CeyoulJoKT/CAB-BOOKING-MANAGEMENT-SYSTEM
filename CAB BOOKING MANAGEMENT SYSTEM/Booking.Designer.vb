<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Booking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Booking))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtbooking = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Txtphone = New System.Windows.Forms.TextBox()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.Txtkm = New System.Windows.Forms.TextBox()
        Me.Txtamt = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.RichTextBox()
        Me.cmdploc = New System.Windows.Forms.ComboBox()
        Me.cmddloc = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cmdcarmodel = New System.Windows.Forms.ComboBox()
        Me.cmdcolor = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtreset = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtpassenger = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtmm = New System.Windows.Forms.ComboBox()
        Me.txthour = New System.Windows.Forms.ComboBox()
        Me.txtmin = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(85, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Booking Id:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(119, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(89, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone No:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(98, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 12)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(299, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 12)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Pickup Location:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(310, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 12)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Drop Location:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(382, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 12)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Pickupdatedate:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(336, 366)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 12)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Car Model:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Goldenrod
        Me.Label9.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(583, 338)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 12)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Total Amt:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(326, 333)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 12)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Car Colour:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(614, 201)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 12)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Price:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(547, 255)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(110, 12)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Total No Of Km:"
        '
        'txtbooking
        '
        Me.txtbooking.Location = New System.Drawing.Point(166, 92)
        Me.txtbooking.Name = "txtbooking"
        Me.txtbooking.ReadOnly = True
        Me.txtbooking.Size = New System.Drawing.Size(100, 23)
        Me.txtbooking.TabIndex = 13
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(167, 164)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(100, 23)
        Me.txtname.TabIndex = 14
        '
        'Txtphone
        '
        Me.Txtphone.Location = New System.Drawing.Point(167, 222)
        Me.Txtphone.Name = "Txtphone"
        Me.Txtphone.Size = New System.Drawing.Size(100, 23)
        Me.Txtphone.TabIndex = 15
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(663, 196)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.ReadOnly = True
        Me.txtprice.Size = New System.Drawing.Size(100, 23)
        Me.txtprice.TabIndex = 23
        '
        'Txtkm
        '
        Me.Txtkm.Location = New System.Drawing.Point(663, 250)
        Me.Txtkm.Name = "Txtkm"
        Me.Txtkm.ReadOnly = True
        Me.Txtkm.Size = New System.Drawing.Size(100, 23)
        Me.Txtkm.TabIndex = 24
        '
        'Txtamt
        '
        Me.Txtamt.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Txtamt.Location = New System.Drawing.Point(663, 332)
        Me.Txtamt.Name = "Txtamt"
        Me.Txtamt.ReadOnly = True
        Me.Txtamt.Size = New System.Drawing.Size(100, 21)
        Me.Txtamt.TabIndex = 25
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Stencil", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label14.Location = New System.Drawing.Point(243, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(353, 34)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "CabMe Booking Portal"
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(158, 278)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(122, 82)
        Me.txtaddress.TabIndex = 28
        Me.txtaddress.Text = ""
        '
        'cmdploc
        '
        Me.cmdploc.FormattingEnabled = True
        Me.cmdploc.Items.AddRange(New Object() {"Bangalore", "Pune", "Mumbai", "Chennai"})
        Me.cmdploc.Location = New System.Drawing.Point(417, 120)
        Me.cmdploc.Name = "cmdploc"
        Me.cmdploc.Size = New System.Drawing.Size(107, 23)
        Me.cmdploc.TabIndex = 29
        '
        'cmddloc
        '
        Me.cmddloc.FormattingEnabled = True
        Me.cmddloc.Items.AddRange(New Object() {"Pune", "Mumbai", "Chennai", "Delhi", "Bangalore", "Hyderabad", "Kolkata", "Kerala", "Jharkhand"})
        Me.cmddloc.Location = New System.Drawing.Point(417, 158)
        Me.cmddloc.Name = "cmddloc"
        Me.cmddloc.Size = New System.Drawing.Size(107, 23)
        Me.cmddloc.TabIndex = 30
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Checked = False
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.Location = New System.Drawing.Point(336, 225)
        Me.DateTimePicker1.MaxDate = New Date(2022, 5, 22, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(2022, 5, 18, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 23)
        Me.DateTimePicker1.TabIndex = 31
        Me.DateTimePicker1.Value = New Date(2022, 5, 18, 0, 0, 0, 0)
        '
        'cmdcarmodel
        '
        Me.cmdcarmodel.FormattingEnabled = True
        Me.cmdcarmodel.Items.AddRange(New Object() {"Mercedes Benz", "Fortuner", "Hyundai I20", "Mahindira Bolero"})
        Me.cmdcarmodel.Location = New System.Drawing.Point(417, 357)
        Me.cmdcarmodel.Name = "cmdcarmodel"
        Me.cmdcarmodel.Size = New System.Drawing.Size(114, 23)
        Me.cmdcarmodel.TabIndex = 32
        '
        'cmdcolor
        '
        Me.cmdcolor.FormattingEnabled = True
        Me.cmdcolor.Items.AddRange(New Object() {"White", "Grey", "Black", "Maroon"})
        Me.cmdcolor.Location = New System.Drawing.Point(417, 328)
        Me.cmdcolor.Name = "cmdcolor"
        Me.cmdcolor.Size = New System.Drawing.Size(114, 23)
        Me.cmdcolor.TabIndex = 33
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Cornsilk
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(631, 423)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 32)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Book Cabme"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Cornsilk
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(222, 423)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 32)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtreset
        '
        Me.txtreset.BackColor = System.Drawing.Color.Cornsilk
        Me.txtreset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtreset.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtreset.Location = New System.Drawing.Point(355, 423)
        Me.txtreset.Name = "txtreset"
        Me.txtreset.Size = New System.Drawing.Size(108, 32)
        Me.txtreset.TabIndex = 37
        Me.txtreset.Text = "Reset"
        Me.txtreset.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(597, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(255, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-18, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(255, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 39
        Me.PictureBox2.TabStop = False
        '
        'txtpassenger
        '
        Me.txtpassenger.FormattingEnabled = True
        Me.txtpassenger.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.txtpassenger.Location = New System.Drawing.Point(663, 135)
        Me.txtpassenger.Name = "txtpassenger"
        Me.txtpassenger.Size = New System.Drawing.Size(100, 23)
        Me.txtpassenger.TabIndex = 40
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.LightSalmon
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label15.Location = New System.Drawing.Point(134, 248)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(177, 13)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "Please Enter Valid Phone Number"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gold
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(185, 122)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 22)
        Me.Button3.TabIndex = 42
        Me.Button3.Text = "Generate Id"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Copperplate Gothic Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label16.Location = New System.Drawing.Point(336, 256)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 16)
        Me.Label16.TabIndex = 44
        Me.Label16.Text = "Time:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(639, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 12)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "No of Passengers:"
        '
        'txtmm
        '
        Me.txtmm.FormattingEnabled = True
        Me.txtmm.Items.AddRange(New Object() {"AM", "PM"})
        Me.txtmm.Location = New System.Drawing.Point(481, 293)
        Me.txtmm.Name = "txtmm"
        Me.txtmm.Size = New System.Drawing.Size(43, 23)
        Me.txtmm.TabIndex = 45
        '
        'txthour
        '
        Me.txthour.FormattingEnabled = True
        Me.txthour.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.txthour.Location = New System.Drawing.Point(362, 293)
        Me.txthour.Name = "txthour"
        Me.txthour.Size = New System.Drawing.Size(36, 23)
        Me.txthour.TabIndex = 46
        '
        'txtmin
        '
        Me.txtmin.FormattingEnabled = True
        Me.txtmin.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.txtmin.Location = New System.Drawing.Point(417, 293)
        Me.txtmin.Name = "txtmin"
        Me.txtmin.Size = New System.Drawing.Size(43, 23)
        Me.txtmin.TabIndex = 47
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label17.Location = New System.Drawing.Point(355, 278)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(43, 12)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "Hour:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label18.Location = New System.Drawing.Point(408, 278)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 12)
        Me.Label18.TabIndex = 49
        Me.Label18.Text = "Minute:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label19.Location = New System.Drawing.Point(477, 278)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 12)
        Me.Label19.TabIndex = 50
        Me.Label19.Text = "Meridiem:"
        '
        'Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(848, 484)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtmin)
        Me.Controls.Add(Me.txthour)
        Me.Controls.Add(Me.txtmm)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtpassenger)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtreset)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdcolor)
        Me.Controls.Add(Me.cmdcarmodel)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cmddloc)
        Me.Controls.Add(Me.cmdploc)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Txtamt)
        Me.Controls.Add(Me.Txtkm)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.Txtphone)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtbooking)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Booking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Booking"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtbooking As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents Txtphone As TextBox
    Friend WithEvents txtprice As TextBox
    Friend WithEvents Txtkm As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtaddress As RichTextBox
    Friend WithEvents cmdploc As ComboBox
    Friend WithEvents cmddloc As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cmdcarmodel As ComboBox
    Friend WithEvents cmdcolor As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtreset As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtpassenger As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Button3 As Button
    Public WithEvents Txtamt As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtmm As ComboBox
    Friend WithEvents txthour As ComboBox
    Friend WithEvents txtmin As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
End Class
