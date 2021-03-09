<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DLLANDLLAPP
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
        Me.open = New System.Windows.Forms.Button()
        Me.Applicationno = New System.Windows.Forms.TextBox()
        Me.View = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.APPLICATIONNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TYPEOFLICENCEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMEOFAPPLICANTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegisteredBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rto_managementDataSet = New RTO.rto_managementDataSet()
        Me.RtomanagementDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegisteredTableAdapter = New RTO.rto_managementDataSetTableAdapters.registeredTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegisteredBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rto_managementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RtomanagementDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'open
        '
        Me.open.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.open.Location = New System.Drawing.Point(427, 72)
        Me.open.Name = "open"
        Me.open.Size = New System.Drawing.Size(119, 34)
        Me.open.TabIndex = 20
        Me.open.Text = "Open"
        Me.open.UseVisualStyleBackColor = True
        '
        'Applicationno
        '
        Me.Applicationno.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Applicationno.Location = New System.Drawing.Point(427, 34)
        Me.Applicationno.Name = "Applicationno"
        Me.Applicationno.Size = New System.Drawing.Size(288, 32)
        Me.Applicationno.TabIndex = 19
        '
        'View
        '
        Me.View.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.View.Location = New System.Drawing.Point(68, 33)
        Me.View.Name = "View"
        Me.View.Size = New System.Drawing.Size(329, 32)
        Me.View.TabIndex = 18
        Me.View.Text = "Viewing/Approving  Application"
        Me.View.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Sienna
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.APPLICATIONNODataGridViewTextBoxColumn, Me.TYPEOFLICENCEDataGridViewTextBoxColumn, Me.NAMEOFAPPLICANTDataGridViewTextBoxColumn, Me.STATUSDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RegisteredBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(106, 154)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(850, 299)
        Me.DataGridView1.TabIndex = 17
        '
        'APPLICATIONNODataGridViewTextBoxColumn
        '
        Me.APPLICATIONNODataGridViewTextBoxColumn.DataPropertyName = "APPLICATION_NO"
        Me.APPLICATIONNODataGridViewTextBoxColumn.HeaderText = "APPLICATION_NO"
        Me.APPLICATIONNODataGridViewTextBoxColumn.Name = "APPLICATIONNODataGridViewTextBoxColumn"
        Me.APPLICATIONNODataGridViewTextBoxColumn.ReadOnly = True
        '
        'TYPEOFLICENCEDataGridViewTextBoxColumn
        '
        Me.TYPEOFLICENCEDataGridViewTextBoxColumn.DataPropertyName = "TYPE_OF_LICENCE"
        Me.TYPEOFLICENCEDataGridViewTextBoxColumn.HeaderText = "TYPE_OF_LICENCE"
        Me.TYPEOFLICENCEDataGridViewTextBoxColumn.Name = "TYPEOFLICENCEDataGridViewTextBoxColumn"
        Me.TYPEOFLICENCEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NAMEOFAPPLICANTDataGridViewTextBoxColumn
        '
        Me.NAMEOFAPPLICANTDataGridViewTextBoxColumn.DataPropertyName = "NAME_OF_APPLICANT"
        Me.NAMEOFAPPLICANTDataGridViewTextBoxColumn.HeaderText = "NAME_OF_APPLICANT"
        Me.NAMEOFAPPLICANTDataGridViewTextBoxColumn.Name = "NAMEOFAPPLICANTDataGridViewTextBoxColumn"
        Me.NAMEOFAPPLICANTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'STATUSDataGridViewTextBoxColumn
        '
        Me.STATUSDataGridViewTextBoxColumn.DataPropertyName = "STATUS"
        Me.STATUSDataGridViewTextBoxColumn.HeaderText = "STATUS"
        Me.STATUSDataGridViewTextBoxColumn.Name = "STATUSDataGridViewTextBoxColumn"
        Me.STATUSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RegisteredBindingSource
        '
        Me.RegisteredBindingSource.DataMember = "registered"
        Me.RegisteredBindingSource.DataSource = Me.Rto_managementDataSet
        '
        'Rto_managementDataSet
        '
        Me.Rto_managementDataSet.DataSetName = "rto_managementDataSet"
        Me.Rto_managementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RtomanagementDataSetBindingSource
        '
        Me.RtomanagementDataSetBindingSource.DataSource = Me.Rto_managementDataSet
        Me.RtomanagementDataSetBindingSource.Position = 0
        '
        'RegisteredTableAdapter
        '
        Me.RegisteredTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(552, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 34)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DLLANDLLAPP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SaddleBrown
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.open)
        Me.Controls.Add(Me.Applicationno)
        Me.Controls.Add(Me.View)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DLLANDLLAPP"
        Me.Text = "DLLANDLLAPPvb"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegisteredBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rto_managementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RtomanagementDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents open As Button
    Friend WithEvents Applicationno As TextBox
    Friend WithEvents View As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RtomanagementDataSetBindingSource As BindingSource
    Friend WithEvents Rto_managementDataSet As rto_managementDataSet
    Friend WithEvents RegisteredBindingSource As BindingSource
    Friend WithEvents RegisteredTableAdapter As rto_managementDataSetTableAdapters.registeredTableAdapter
    Friend WithEvents APPLICATIONNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TYPEOFLICENCEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NAMEOFAPPLICANTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STATUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
