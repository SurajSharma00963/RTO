<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GenerateVehicleNo
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Serialno = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NOV = New System.Windows.Forms.Label()
        Me.NOB = New System.Windows.Forms.Label()
        Me.TOV = New System.Windows.Forms.Label()
        Me.AOB = New System.Windows.Forms.Label()
        Me.POB = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.VHNO = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rto_managementDataSet2 = New RTO.rto_managementDataSet2()
        Me.VehicleTableAdapter1 = New RTO.rto_managementDataSet2TableAdapters.vehicleTableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rto_managementDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(54, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(463, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vehicle No. Generator"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(242, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Vehicle Serial No."
        '
        'Serialno
        '
        Me.Serialno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Serialno.Location = New System.Drawing.Point(434, 124)
        Me.Serialno.Name = "Serialno"
        Me.Serialno.Size = New System.Drawing.Size(189, 26)
        Me.Serialno.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.IndianRed
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(434, 156)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 28)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Go"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Cyan
        Me.Label3.Location = New System.Drawing.Point(275, 364)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Name of Vehicle"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Cyan
        Me.Label4.Location = New System.Drawing.Point(275, 401)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Name of Buyer"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Cyan
        Me.Label5.Location = New System.Drawing.Point(275, 437)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Type Of Vehicle"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Cyan
        Me.Label6.Location = New System.Drawing.Point(275, 472)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 19)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Address Of The Buyer"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Cyan
        Me.Label7.Location = New System.Drawing.Point(275, 578)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 19)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Proof Of Buyer"
        Me.Label7.Visible = False
        '
        'NOV
        '
        Me.NOV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NOV.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOV.Location = New System.Drawing.Point(463, 360)
        Me.NOV.Name = "NOV"
        Me.NOV.Size = New System.Drawing.Size(257, 23)
        Me.NOV.TabIndex = 9
        Me.NOV.Text = "Label8"
        Me.NOV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NOV.Visible = False
        '
        'NOB
        '
        Me.NOB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NOB.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOB.Location = New System.Drawing.Point(463, 397)
        Me.NOB.Name = "NOB"
        Me.NOB.Size = New System.Drawing.Size(257, 23)
        Me.NOB.TabIndex = 10
        Me.NOB.Text = "Label9"
        Me.NOB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NOB.Visible = False
        '
        'TOV
        '
        Me.TOV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TOV.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOV.Location = New System.Drawing.Point(463, 433)
        Me.TOV.Name = "TOV"
        Me.TOV.Size = New System.Drawing.Size(257, 23)
        Me.TOV.TabIndex = 11
        Me.TOV.Text = "Label10"
        Me.TOV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TOV.Visible = False
        '
        'AOB
        '
        Me.AOB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AOB.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AOB.Location = New System.Drawing.Point(463, 472)
        Me.AOB.Name = "AOB"
        Me.AOB.Size = New System.Drawing.Size(257, 83)
        Me.AOB.TabIndex = 12
        Me.AOB.Text = "Label11"
        Me.AOB.Visible = False
        '
        'POB
        '
        Me.POB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.POB.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POB.Location = New System.Drawing.Point(463, 574)
        Me.POB.Name = "POB"
        Me.POB.Size = New System.Drawing.Size(257, 23)
        Me.POB.TabIndex = 13
        Me.POB.Text = "Label12"
        Me.POB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.POB.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(502, 625)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(195, 46)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Verify And Generate Vehicle No"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Cyan
        Me.Label13.Location = New System.Drawing.Point(824, 473)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 19)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Vehicle No."
        Me.Label13.Visible = False
        '
        'VHNO
        '
        Me.VHNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VHNO.Location = New System.Drawing.Point(931, 446)
        Me.VHNO.Name = "VHNO"
        Me.VHNO.Size = New System.Drawing.Size(191, 62)
        Me.VHNO.TabIndex = 16
        Me.VHNO.Text = "Label14"
        Me.VHNO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.VHNO.Visible = False
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(963, 574)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 44)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Done"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.DataGridView1.DataSource = Me.VehicleBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(140, 211)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(958, 150)
        Me.DataGridView1.TabIndex = 19
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Vehicle_Slno"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Vehicle_Slno"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "NameofVehicle"
        Me.DataGridViewTextBoxColumn9.HeaderText = "NameofVehicle"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Nameofbuyer"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Nameofbuyer"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "TOV"
        Me.DataGridViewTextBoxColumn11.HeaderText = "TOV"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "NOS"
        Me.DataGridViewTextBoxColumn12.HeaderText = "NOS"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "AOB"
        Me.DataGridViewTextBoxColumn13.HeaderText = "AOB"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "POB"
        Me.DataGridViewTextBoxColumn14.HeaderText = "POB"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'VehicleBindingSource
        '
        Me.VehicleBindingSource.DataMember = "vehicle"
        Me.VehicleBindingSource.DataSource = Me.Rto_managementDataSet2
        '
        'Rto_managementDataSet2
        '
        Me.Rto_managementDataSet2.DataSetName = "rto_managementDataSet2"
        Me.Rto_managementDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VehicleTableAdapter1
        '
        Me.VehicleTableAdapter1.ClearBeforeFill = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.IndianRed
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(521, 156)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(81, 28)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "Back"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'GenerateVehicleNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RTO.My.Resources.Resources._3869354719_6131325967_o1
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.VHNO)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.POB)
        Me.Controls.Add(Me.AOB)
        Me.Controls.Add(Me.TOV)
        Me.Controls.Add(Me.NOB)
        Me.Controls.Add(Me.NOV)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Serialno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GenerateVehicleNo"
        Me.Text = "GenerateVehicleNo"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rto_managementDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Serialno As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents NOV As Label
    Friend WithEvents NOB As Label
    Friend WithEvents TOV As Label
    Friend WithEvents AOB As Label
    Friend WithEvents POB As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents VHNO As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents NameofVehicleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameofbuyerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AOBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents POBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehicleSlnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehicleBindingSource As BindingSource
    Friend WithEvents VehicleTableAdapter1 As rto_managementDataSet2TableAdapters.vehicleTableAdapter
    Friend WithEvents Rto_managementDataSet2 As rto_managementDataSet2
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents Button4 As Button
End Class
