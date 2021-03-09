<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class generatedvehicleno
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.serialno = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.VNO = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.VehicleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rto_managementDataSet1 = New RTO.rto_managementDataSet1()
        Me.VehicleTableAdapter = New RTO.rto_managementDataSet1TableAdapters.vehicleTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.sname = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rto_managementDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.Label1.Location = New System.Drawing.Point(92, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(428, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Generated Vehicle No. of"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.Label2.Location = New System.Drawing.Point(156, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Vehicle No"
        '
        'serialno
        '
        Me.serialno.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.serialno.Location = New System.Drawing.Point(362, 123)
        Me.serialno.Name = "serialno"
        Me.serialno.Size = New System.Drawing.Size(290, 31)
        Me.serialno.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(362, 161)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 35)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Show "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'VNO
        '
        Me.VNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VNO.Location = New System.Drawing.Point(488, 462)
        Me.VNO.Name = "VNO"
        Me.VNO.Size = New System.Drawing.Size(492, 222)
        Me.VNO.TabIndex = 5
        Me.VNO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.VNO.UseCompatibleTextRendering = True
        Me.VNO.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(610, 493)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(232, 73)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Label3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(610, 566)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(232, 73)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Label3"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label4.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(135, 212)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1051, 152)
        Me.DataGridView1.TabIndex = 7
        '
        'VehicleBindingSource
        '
        Me.VehicleBindingSource.DataMember = "vehicle"
        Me.VehicleBindingSource.DataSource = Me.Rto_managementDataSet1
        '
        'Rto_managementDataSet1
        '
        Me.Rto_managementDataSet1.DataSetName = "rto_managementDataSet1"
        Me.Rto_managementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VehicleTableAdapter
        '
        Me.VehicleTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1175, 713)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 32)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'sname
        '
        Me.sname.AutoSize = True
        Me.sname.BackColor = System.Drawing.Color.Transparent
        Me.sname.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sname.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.sname.Location = New System.Drawing.Point(538, 44)
        Me.sname.Name = "sname"
        Me.sname.Size = New System.Drawing.Size(37, 39)
        Me.sname.TabIndex = 0
        Me.sname.Text = "1"
        '
        'generatedvehicleno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.BackgroundImage = Global.RTO.My.Resources.Resources.Pulsar_200_SS_rear_rendering
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.VNO)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.serialno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.sname)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "generatedvehicleno"
        Me.Text = "generatedvehicleno"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rto_managementDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents serialno As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents VNO As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Rto_managementDataSet1 As rto_managementDataSet1
    Friend WithEvents VehicleBindingSource As BindingSource
    Friend WithEvents VehicleTableAdapter As rto_managementDataSet1TableAdapters.vehicleTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents sname As Label
End Class
