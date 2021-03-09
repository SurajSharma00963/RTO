<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VehicleRegistration
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
        Me.tov = New System.Windows.Forms.ComboBox()
        Me.slv = New System.Windows.Forms.TextBox()
        Me.nov = New System.Windows.Forms.TextBox()
        Me.nob = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.aob = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.POB = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RTO = New System.Windows.Forms.Label()
        Me.nos = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.Label1.Location = New System.Drawing.Point(60, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(419, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vehicle Registration"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.Label2.Location = New System.Drawing.Point(336, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sl no. of Vehicle"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.Label3.Location = New System.Drawing.Point(336, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Name Of The Vehicle"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.Label4.Location = New System.Drawing.Point(337, 295)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Name Of Buyer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.Label5.Location = New System.Drawing.Point(337, 346)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Type Of Vehicle"
        '
        'tov
        '
        Me.tov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tov.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tov.FormattingEnabled = True
        Me.tov.Items.AddRange(New Object() {"Car", "Bike With Gear", "Bike Without Gear"})
        Me.tov.Location = New System.Drawing.Point(527, 343)
        Me.tov.Name = "tov"
        Me.tov.Size = New System.Drawing.Size(275, 27)
        Me.tov.TabIndex = 4
        '
        'slv
        '
        Me.slv.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slv.Location = New System.Drawing.Point(527, 186)
        Me.slv.Name = "slv"
        Me.slv.Size = New System.Drawing.Size(275, 26)
        Me.slv.TabIndex = 5
        '
        'nov
        '
        Me.nov.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nov.Location = New System.Drawing.Point(527, 238)
        Me.nov.Name = "nov"
        Me.nov.Size = New System.Drawing.Size(275, 26)
        Me.nov.TabIndex = 6
        '
        'nob
        '
        Me.nob.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nob.Location = New System.Drawing.Point(527, 292)
        Me.nob.Name = "nob"
        Me.nob.Size = New System.Drawing.Size(275, 26)
        Me.nob.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.Label6.Location = New System.Drawing.Point(337, 403)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 19)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Name of Store"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.Label7.Location = New System.Drawing.Point(336, 453)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(155, 19)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Address Of the Buyer"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.Label8.Location = New System.Drawing.Point(336, 568)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 19)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Proof Of Buyer"
        '
        'aob
        '
        Me.aob.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aob.Location = New System.Drawing.Point(527, 453)
        Me.aob.Multiline = True
        Me.aob.Name = "aob"
        Me.aob.Size = New System.Drawing.Size(275, 86)
        Me.aob.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(527, 610)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 30)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(619, 610)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 30)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'POB
        '
        Me.POB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.POB.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POB.FormattingEnabled = True
        Me.POB.Items.AddRange(New Object() {"Aadhar Card", "Rental Agreement", "Voter id", "Pan Card", "Vehicle Bill"})
        Me.POB.Location = New System.Drawing.Point(527, 560)
        Me.POB.Name = "POB"
        Me.POB.Size = New System.Drawing.Size(275, 27)
        Me.POB.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.Label9.Location = New System.Drawing.Point(336, 145)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 19)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "RTO Name"
        '
        'RTO
        '
        Me.RTO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RTO.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTO.Location = New System.Drawing.Point(527, 143)
        Me.RTO.Name = "RTO"
        Me.RTO.Size = New System.Drawing.Size(275, 23)
        Me.RTO.TabIndex = 17
        Me.RTO.Text = "Label10"
        Me.RTO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nos
        '
        Me.nos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nos.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nos.Location = New System.Drawing.Point(527, 399)
        Me.nos.Name = "nos"
        Me.nos.Size = New System.Drawing.Size(275, 23)
        Me.nos.TabIndex = 18
        Me.nos.Text = "Label10"
        Me.nos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VehicleRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RTO.My.Resources.Resources.Ducati_999_2005_01_b1920
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.nos)
        Me.Controls.Add(Me.RTO)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.POB)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.aob)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.nob)
        Me.Controls.Add(Me.nov)
        Me.Controls.Add(Me.slv)
        Me.Controls.Add(Me.tov)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VehicleRegistration"
        Me.Text = "VehicleRegistration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tov As ComboBox
    Friend WithEvents slv As TextBox
    Friend WithEvents nov As TextBox
    Friend WithEvents nob As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents aob As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents POB As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents RTO As Label
    Friend WithEvents nos As Label
End Class
