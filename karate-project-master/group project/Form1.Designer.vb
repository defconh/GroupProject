<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MemberDateForm
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateJoinedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KarateDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KarateDataSet = New group_project.karateDataSet()
        Me.Date_Selector = New System.Windows.Forms.DateTimePicker()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gpbDate = New System.Windows.Forms.GroupBox()
        Me.radAfterDate = New System.Windows.Forms.RadioButton()
        Me.radBeforeDate = New System.Windows.Forms.RadioButton()
        Me.MembersTableAdapter = New group_project.karateDataSetTableAdapters.MembersTableAdapter()
        Me.errProvide = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblHolder = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KarateDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KarateDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbDate.SuspendLayout()
        CType(Me.errProvide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.DateJoinedDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MembersBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(11, 79)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(523, 209)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        '
        'DateJoinedDataGridViewTextBoxColumn
        '
        Me.DateJoinedDataGridViewTextBoxColumn.DataPropertyName = "Date_Joined"
        Me.DateJoinedDataGridViewTextBoxColumn.HeaderText = "Date_Joined"
        Me.DateJoinedDataGridViewTextBoxColumn.Name = "DateJoinedDataGridViewTextBoxColumn"
        '
        'MembersBindingSource
        '
        Me.MembersBindingSource.DataMember = "Members"
        Me.MembersBindingSource.DataSource = Me.KarateDataSetBindingSource
        '
        'KarateDataSetBindingSource
        '
        Me.KarateDataSetBindingSource.DataSource = Me.KarateDataSet
        Me.KarateDataSetBindingSource.Position = 0
        '
        'KarateDataSet
        '
        Me.KarateDataSet.DataSetName = "karateDataSet"
        Me.KarateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Date_Selector
        '
        Me.Date_Selector.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Date_Selector.CustomFormat = "m/d/yyyy"
        Me.Date_Selector.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_Selector.Location = New System.Drawing.Point(80, 20)
        Me.Date_Selector.MinDate = New Date(1995, 1, 1, 0, 0, 0, 0)
        Me.Date_Selector.Name = "Date_Selector"
        Me.Date_Selector.Size = New System.Drawing.Size(119, 20)
        Me.Date_Selector.TabIndex = 1
        Me.Date_Selector.Value = New Date(2017, 7, 7, 0, 0, 0, 0)
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(5, 20)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(73, 13)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Select a date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Members who joined before this date:"
        '
        'gpbDate
        '
        Me.gpbDate.Controls.Add(Me.lblHolder)
        Me.gpbDate.Controls.Add(Me.radAfterDate)
        Me.gpbDate.Controls.Add(Me.radBeforeDate)
        Me.gpbDate.Controls.Add(Me.lblDate)
        Me.gpbDate.Controls.Add(Me.Date_Selector)
        Me.gpbDate.Location = New System.Drawing.Point(11, 7)
        Me.gpbDate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gpbDate.Name = "gpbDate"
        Me.gpbDate.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gpbDate.Size = New System.Drawing.Size(473, 54)
        Me.gpbDate.TabIndex = 4
        Me.gpbDate.TabStop = False
        Me.gpbDate.Text = "Date Selection"
        '
        'radAfterDate
        '
        Me.radAfterDate.AutoSize = True
        Me.radAfterDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radAfterDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.radAfterDate.Location = New System.Drawing.Point(352, 21)
        Me.radAfterDate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.radAfterDate.Name = "radAfterDate"
        Me.radAfterDate.Size = New System.Drawing.Size(129, 17)
        Me.radAfterDate.TabIndex = 4
        Me.radAfterDate.TabStop = True
        Me.radAfterDate.Text = "On Or After This Date."
        Me.radAfterDate.UseVisualStyleBackColor = True
        '
        'radBeforeDate
        '
        Me.radBeforeDate.AutoSize = True
        Me.radBeforeDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radBeforeDate.Location = New System.Drawing.Point(231, 21)
        Me.radBeforeDate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.radBeforeDate.Name = "radBeforeDate"
        Me.radBeforeDate.Size = New System.Drawing.Size(108, 17)
        Me.radBeforeDate.TabIndex = 3
        Me.radBeforeDate.TabStop = True
        Me.radBeforeDate.Text = "Before This Date."
        Me.radBeforeDate.UseVisualStyleBackColor = True
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'errProvide
        '
        Me.errProvide.ContainerControl = Me
        '
        'lblHolder
        '
        Me.lblHolder.AutoSize = True
        Me.lblHolder.Location = New System.Drawing.Point(5, 39)
        Me.lblHolder.Name = "lblHolder"
        Me.lblHolder.Size = New System.Drawing.Size(0, 13)
        Me.lblHolder.TabIndex = 5
        '
        'MemberDateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 292)
        Me.Controls.Add(Me.gpbDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "MemberDateForm"
        Me.ShowIcon = False
        Me.Text = "Karate"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KarateDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KarateDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbDate.ResumeLayout(False)
        Me.gpbDate.PerformLayout()
        CType(Me.errProvide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents KarateDataSetBindingSource As BindingSource
    Friend WithEvents KarateDataSet As karateDataSet
    Friend WithEvents MembersBindingSource As BindingSource
    Friend WithEvents MembersTableAdapter As karateDataSetTableAdapters.MembersTableAdapter
    Friend WithEvents Date_Selector As DateTimePicker
    Friend WithEvents lblDate As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateJoinedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents gpbDate As GroupBox
    Friend WithEvents radAfterDate As RadioButton
    Friend WithEvents radBeforeDate As RadioButton
    Friend WithEvents errProvide As ErrorProvider
    Friend WithEvents lblHolder As Label
End Class
