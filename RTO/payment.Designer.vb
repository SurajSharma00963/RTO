<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payment
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Country = New System.Windows.Forms.ComboBox()
        Me.mm = New System.Windows.Forms.ComboBox()
        Me.YYYY = New System.Windows.Forms.ComboBox()
        Me.s = New System.Windows.Forms.Label()
        Me.Aname = New System.Windows.Forms.TextBox()
        Me.City = New System.Windows.Forms.TextBox()
        Me.Pin = New System.Windows.Forms.TextBox()
        Me.CD = New System.Windows.Forms.TextBox()
        Me.cvv = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.amt = New System.Windows.Forms.Label()
        Me.Recieptno = New System.Windows.Forms.Label()
        Me.appno = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cardtype = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Cyan
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(909, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BILL AND PAYMENT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(22, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(22, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "CITY"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(22, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "PINCODE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(22, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "COUNTRY"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(22, 239)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "CREDIT/DEBIT CARD NO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(22, 301)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "EXPIRY DATE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(22, 338)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "CVV "
        '
        'Country
        '
        Me.Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Country.FormattingEnabled = True
        Me.Country.Items.AddRange(New Object() {"INDIA"})
        Me.Country.Location = New System.Drawing.Point(186, 184)
        Me.Country.Name = "Country"
        Me.Country.Size = New System.Drawing.Size(228, 21)
        Me.Country.TabIndex = 9
        '
        'mm
        '
        Me.mm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.mm.FormattingEnabled = True
        Me.mm.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.mm.Location = New System.Drawing.Point(186, 293)
        Me.mm.Name = "mm"
        Me.mm.Size = New System.Drawing.Size(38, 21)
        Me.mm.TabIndex = 10
        '
        'YYYY
        '
        Me.YYYY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.YYYY.FormattingEnabled = True
        Me.YYYY.Items.AddRange(New Object() {"2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040"})
        Me.YYYY.Location = New System.Drawing.Point(269, 293)
        Me.YYYY.Name = "YYYY"
        Me.YYYY.Size = New System.Drawing.Size(65, 21)
        Me.YYYY.TabIndex = 11
        '
        's
        '
        Me.s.AutoSize = True
        Me.s.BackColor = System.Drawing.Color.Transparent
        Me.s.Location = New System.Drawing.Point(240, 296)
        Me.s.Name = "s"
        Me.s.Size = New System.Drawing.Size(12, 13)
        Me.s.TabIndex = 12
        Me.s.Text = "/"
        '
        'Aname
        '
        Me.Aname.Location = New System.Drawing.Point(186, 72)
        Me.Aname.Name = "Aname"
        Me.Aname.Size = New System.Drawing.Size(228, 20)
        Me.Aname.TabIndex = 13
        '
        'City
        '
        Me.City.Location = New System.Drawing.Point(186, 110)
        Me.City.Name = "City"
        Me.City.Size = New System.Drawing.Size(228, 20)
        Me.City.TabIndex = 14
        '
        'Pin
        '
        Me.Pin.Location = New System.Drawing.Point(186, 144)
        Me.Pin.Name = "Pin"
        Me.Pin.Size = New System.Drawing.Size(228, 20)
        Me.Pin.TabIndex = 15
        '
        'CD
        '
        Me.CD.Location = New System.Drawing.Point(186, 232)
        Me.CD.Name = "CD"
        Me.CD.Size = New System.Drawing.Size(228, 20)
        Me.CD.TabIndex = 16
        '
        'cvv
        '
        Me.cvv.Location = New System.Drawing.Point(186, 335)
        Me.cvv.Name = "cvv"
        Me.cvv.Size = New System.Drawing.Size(228, 20)
        Me.cvv.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(183, 277)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "MM"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(266, 277)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "YYYY"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Location = New System.Drawing.Point(421, 338)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(76, 13)
        Me.LinkLabel1.TabIndex = 19
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "? What is CVV"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.RTO.My.Resources.Resources.codigo_cvv
        Me.PictureBox1.Location = New System.Drawing.Point(503, 310)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(354, 179)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(186, 379)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Pay"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.amt)
        Me.GroupBox1.Controls.Add(Me.Recieptno)
        Me.GroupBox1.Controls.Add(Me.appno)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cardtype)
        Me.GroupBox1.Location = New System.Drawing.Point(542, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 157)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'amt
        '
        Me.amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.amt.Location = New System.Drawing.Point(196, 74)
        Me.amt.Name = "amt"
        Me.amt.Size = New System.Drawing.Size(100, 23)
        Me.amt.TabIndex = 1
        Me.amt.Text = "Label14"
        Me.amt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Recieptno
        '
        Me.Recieptno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Recieptno.Location = New System.Drawing.Point(196, 16)
        Me.Recieptno.Name = "Recieptno"
        Me.Recieptno.Size = New System.Drawing.Size(100, 23)
        Me.Recieptno.TabIndex = 1
        Me.Recieptno.Text = "Label14"
        Me.Recieptno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Recieptno.Visible = False
        '
        'appno
        '
        Me.appno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.appno.Location = New System.Drawing.Point(196, 41)
        Me.appno.Name = "appno"
        Me.appno.Size = New System.Drawing.Size(100, 23)
        Me.appno.TabIndex = 1
        Me.appno.Text = "Label14"
        Me.appno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(34, 79)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 23)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Amount"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(34, 115)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 23)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Card Type"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(34, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 23)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Receipt"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label10.Visible = False
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(34, 41)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 23)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Application No"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cardtype
        '
        Me.cardtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cardtype.FormattingEnabled = True
        Me.cardtype.Items.AddRange(New Object() {"CREDIT CARD", "DEBIT CARD"})
        Me.cardtype.Location = New System.Drawing.Point(196, 117)
        Me.cardtype.Name = "cardtype"
        Me.cardtype.Size = New System.Drawing.Size(100, 21)
        Me.cardtype.TabIndex = 11
        '
        'payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RTO.My.Resources.Resources.blue_waves_1366x768_abstract_background_93_258598435
        Me.ClientSize = New System.Drawing.Size(980, 569)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cvv)
        Me.Controls.Add(Me.CD)
        Me.Controls.Add(Me.Pin)
        Me.Controls.Add(Me.City)
        Me.Controls.Add(Me.Aname)
        Me.Controls.Add(Me.s)
        Me.Controls.Add(Me.YYYY)
        Me.Controls.Add(Me.mm)
        Me.Controls.Add(Me.Country)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "payment"
        Me.Text = "payment"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
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
    Friend WithEvents Country As ComboBox
    Friend WithEvents mm As ComboBox
    Friend WithEvents YYYY As ComboBox
    Friend WithEvents s As Label
    Friend WithEvents Aname As TextBox
    Friend WithEvents City As TextBox
    Friend WithEvents Pin As TextBox
    Friend WithEvents CD As TextBox
    Friend WithEvents cvv As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents amt As Label
    Friend WithEvents appno As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cardtype As ComboBox
    Friend WithEvents Recieptno As Label
    Friend WithEvents Label10 As Label
End Class
