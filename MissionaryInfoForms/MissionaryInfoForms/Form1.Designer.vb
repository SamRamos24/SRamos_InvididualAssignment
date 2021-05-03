<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.FormBox = New System.Windows.Forms.GroupBox()
        Me.saveRecord = New System.Windows.Forms.Button()
        Me.newRecord = New System.Windows.Forms.Button()
        Me.deleteRecord = New System.Windows.Forms.Button()
        Me.funding = New System.Windows.Forms.TextBox()
        Me.MissionInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MissionarySupportDataSet = New MissionaryInfoForms.MissionarySupportDataSet()
        Me.churchAttendence = New System.Windows.Forms.TextBox()
        Me.missionLocation = New System.Windows.Forms.TextBox()
        Me.org = New System.Windows.Forms.TextBox()
        Me.missionary = New System.Windows.Forms.TextBox()
        Me.missionaryIdInput = New System.Windows.Forms.TextBox()
        Me.mFunding = New System.Windows.Forms.Label()
        Me.attendence = New System.Windows.Forms.Label()
        Me.location = New System.Windows.Forms.Label()
        Me.organization = New System.Windows.Forms.Label()
        Me.missionaryID = New System.Windows.Forms.Label()
        Me.assignedMissionary = New System.Windows.Forms.Label()
        Me.closeApp = New System.Windows.Forms.Button()
        Me.nextRecord = New System.Windows.Forms.Button()
        Me.previousRecord = New System.Windows.Forms.Button()
        Me.MissionInfoTableAdapter = New MissionaryInfoForms.MissionarySupportDataSetTableAdapters.MissionInfoTableAdapter()
        Me.records = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MissionaryIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssignedMissionaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrganizationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChurchAttendenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontlyFundingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormBox.SuspendLayout()
        CType(Me.MissionInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MissionarySupportDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.records.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormBox
        '
        Me.FormBox.Controls.Add(Me.saveRecord)
        Me.FormBox.Controls.Add(Me.newRecord)
        Me.FormBox.Controls.Add(Me.deleteRecord)
        Me.FormBox.Controls.Add(Me.funding)
        Me.FormBox.Controls.Add(Me.churchAttendence)
        Me.FormBox.Controls.Add(Me.missionLocation)
        Me.FormBox.Controls.Add(Me.org)
        Me.FormBox.Controls.Add(Me.missionary)
        Me.FormBox.Controls.Add(Me.missionaryIdInput)
        Me.FormBox.Controls.Add(Me.mFunding)
        Me.FormBox.Controls.Add(Me.attendence)
        Me.FormBox.Controls.Add(Me.location)
        Me.FormBox.Controls.Add(Me.organization)
        Me.FormBox.Controls.Add(Me.missionaryID)
        Me.FormBox.Controls.Add(Me.assignedMissionary)
        Me.FormBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.FormBox.Location = New System.Drawing.Point(12, 12)
        Me.FormBox.Name = "FormBox"
        Me.FormBox.Size = New System.Drawing.Size(641, 249)
        Me.FormBox.TabIndex = 0
        Me.FormBox.TabStop = False
        Me.FormBox.Text = "Form"
        '
        'saveRecord
        '
        Me.saveRecord.Location = New System.Drawing.Point(475, 77)
        Me.saveRecord.Name = "saveRecord"
        Me.saveRecord.Size = New System.Drawing.Size(152, 46)
        Me.saveRecord.TabIndex = 13
        Me.saveRecord.Text = "Save Record "
        Me.saveRecord.UseVisualStyleBackColor = True
        '
        'newRecord
        '
        Me.newRecord.Location = New System.Drawing.Point(475, 24)
        Me.newRecord.Name = "newRecord"
        Me.newRecord.Size = New System.Drawing.Size(152, 46)
        Me.newRecord.TabIndex = 12
        Me.newRecord.Text = "New Record"
        Me.newRecord.UseVisualStyleBackColor = True
        '
        'deleteRecord
        '
        Me.deleteRecord.Location = New System.Drawing.Point(475, 183)
        Me.deleteRecord.Name = "deleteRecord"
        Me.deleteRecord.Size = New System.Drawing.Size(152, 46)
        Me.deleteRecord.TabIndex = 11
        Me.deleteRecord.Text = "Delete Record"
        Me.deleteRecord.UseVisualStyleBackColor = True
        '
        'funding
        '
        Me.funding.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MissionInfoBindingSource, "Montly Funding", True))
        Me.funding.Location = New System.Drawing.Point(224, 200)
        Me.funding.Name = "funding"
        Me.funding.Size = New System.Drawing.Size(152, 29)
        Me.funding.TabIndex = 10
        '
        'MissionInfoBindingSource
        '
        Me.MissionInfoBindingSource.DataMember = "MissionInfo"
        Me.MissionInfoBindingSource.DataSource = Me.MissionarySupportDataSet
        '
        'MissionarySupportDataSet
        '
        Me.MissionarySupportDataSet.DataSetName = "MissionarySupportDataSet"
        Me.MissionarySupportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'churchAttendence
        '
        Me.churchAttendence.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MissionInfoBindingSource, "Church Attendence", True))
        Me.churchAttendence.Location = New System.Drawing.Point(224, 165)
        Me.churchAttendence.Name = "churchAttendence"
        Me.churchAttendence.Size = New System.Drawing.Size(152, 29)
        Me.churchAttendence.TabIndex = 9
        '
        'missionLocation
        '
        Me.missionLocation.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MissionInfoBindingSource, "Location", True))
        Me.missionLocation.Location = New System.Drawing.Point(224, 129)
        Me.missionLocation.Name = "missionLocation"
        Me.missionLocation.Size = New System.Drawing.Size(152, 29)
        Me.missionLocation.TabIndex = 8
        '
        'org
        '
        Me.org.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MissionInfoBindingSource, "Organization", True))
        Me.org.Location = New System.Drawing.Point(224, 94)
        Me.org.Name = "org"
        Me.org.Size = New System.Drawing.Size(152, 29)
        Me.org.TabIndex = 7
        '
        'missionary
        '
        Me.missionary.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MissionInfoBindingSource, "Assigned Missionary", True))
        Me.missionary.Location = New System.Drawing.Point(224, 59)
        Me.missionary.Name = "missionary"
        Me.missionary.Size = New System.Drawing.Size(152, 29)
        Me.missionary.TabIndex = 6
        '
        'missionaryIdInput
        '
        Me.missionaryIdInput.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MissionInfoBindingSource, "MissionaryID", True))
        Me.missionaryIdInput.Location = New System.Drawing.Point(224, 24)
        Me.missionaryIdInput.Name = "missionaryIdInput"
        Me.missionaryIdInput.Size = New System.Drawing.Size(152, 29)
        Me.missionaryIdInput.TabIndex = 5
        '
        'mFunding
        '
        Me.mFunding.AutoSize = True
        Me.mFunding.Location = New System.Drawing.Point(6, 200)
        Me.mFunding.Name = "mFunding"
        Me.mFunding.Size = New System.Drawing.Size(152, 24)
        Me.mFunding.TabIndex = 4
        Me.mFunding.Text = "Monthly Funding"
        '
        'attendence
        '
        Me.attendence.AutoSize = True
        Me.attendence.Location = New System.Drawing.Point(6, 168)
        Me.attendence.Name = "attendence"
        Me.attendence.Size = New System.Drawing.Size(174, 24)
        Me.attendence.TabIndex = 3
        Me.attendence.Text = "Church Attendence"
        '
        'location
        '
        Me.location.AutoSize = True
        Me.location.Location = New System.Drawing.Point(6, 132)
        Me.location.Name = "location"
        Me.location.Size = New System.Drawing.Size(81, 24)
        Me.location.TabIndex = 2
        Me.location.Text = "Location"
        '
        'organization
        '
        Me.organization.AutoSize = True
        Me.organization.Location = New System.Drawing.Point(6, 97)
        Me.organization.Name = "organization"
        Me.organization.Size = New System.Drawing.Size(116, 24)
        Me.organization.TabIndex = 1
        Me.organization.Text = "Organization"
        '
        'missionaryID
        '
        Me.missionaryID.AutoSize = True
        Me.missionaryID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.missionaryID.Location = New System.Drawing.Point(6, 27)
        Me.missionaryID.Name = "missionaryID"
        Me.missionaryID.Size = New System.Drawing.Size(116, 24)
        Me.missionaryID.TabIndex = 0
        Me.missionaryID.Text = "MissionaryID"
        '
        'assignedMissionary
        '
        Me.assignedMissionary.AutoSize = True
        Me.assignedMissionary.Location = New System.Drawing.Point(6, 62)
        Me.assignedMissionary.Name = "assignedMissionary"
        Me.assignedMissionary.Size = New System.Drawing.Size(183, 24)
        Me.assignedMissionary.TabIndex = 0
        Me.assignedMissionary.Text = "Assigned Missionary"
        '
        'closeApp
        '
        Me.closeApp.Location = New System.Drawing.Point(546, 411)
        Me.closeApp.Name = "closeApp"
        Me.closeApp.Size = New System.Drawing.Size(93, 32)
        Me.closeApp.TabIndex = 2
        Me.closeApp.Text = "Close"
        Me.closeApp.UseVisualStyleBackColor = True
        '
        'nextRecord
        '
        Me.nextRecord.Location = New System.Drawing.Point(111, 414)
        Me.nextRecord.Name = "nextRecord"
        Me.nextRecord.Size = New System.Drawing.Size(93, 32)
        Me.nextRecord.TabIndex = 5
        Me.nextRecord.Text = "Next"
        Me.nextRecord.UseVisualStyleBackColor = True
        '
        'previousRecord
        '
        Me.previousRecord.Location = New System.Drawing.Point(12, 414)
        Me.previousRecord.Name = "previousRecord"
        Me.previousRecord.Size = New System.Drawing.Size(93, 32)
        Me.previousRecord.TabIndex = 6
        Me.previousRecord.Text = "Previous"
        Me.previousRecord.UseVisualStyleBackColor = True
        '
        'MissionInfoTableAdapter
        '
        Me.MissionInfoTableAdapter.ClearBeforeFill = True
        '
        'records
        '
        Me.records.Controls.Add(Me.DataGridView1)
        Me.records.Location = New System.Drawing.Point(12, 267)
        Me.records.Name = "records"
        Me.records.Size = New System.Drawing.Size(641, 141)
        Me.records.TabIndex = 7
        Me.records.TabStop = False
        Me.records.Text = "Records"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MissionaryIDDataGridViewTextBoxColumn, Me.AssignedMissionaryDataGridViewTextBoxColumn, Me.OrganizationDataGridViewTextBoxColumn, Me.LocationDataGridViewTextBoxColumn, Me.ChurchAttendenceDataGridViewTextBoxColumn, Me.MontlyFundingDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MissionInfoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(10, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(617, 116)
        Me.DataGridView1.TabIndex = 0
        '
        'MissionaryIDDataGridViewTextBoxColumn
        '
        Me.MissionaryIDDataGridViewTextBoxColumn.DataPropertyName = "MissionaryID"
        Me.MissionaryIDDataGridViewTextBoxColumn.HeaderText = "MissionaryID"
        Me.MissionaryIDDataGridViewTextBoxColumn.Name = "MissionaryIDDataGridViewTextBoxColumn"
        '
        'AssignedMissionaryDataGridViewTextBoxColumn
        '
        Me.AssignedMissionaryDataGridViewTextBoxColumn.DataPropertyName = "Assigned Missionary"
        Me.AssignedMissionaryDataGridViewTextBoxColumn.HeaderText = "Assigned Missionary"
        Me.AssignedMissionaryDataGridViewTextBoxColumn.Name = "AssignedMissionaryDataGridViewTextBoxColumn"
        '
        'OrganizationDataGridViewTextBoxColumn
        '
        Me.OrganizationDataGridViewTextBoxColumn.DataPropertyName = "Organization"
        Me.OrganizationDataGridViewTextBoxColumn.HeaderText = "Organization"
        Me.OrganizationDataGridViewTextBoxColumn.Name = "OrganizationDataGridViewTextBoxColumn"
        '
        'LocationDataGridViewTextBoxColumn
        '
        Me.LocationDataGridViewTextBoxColumn.DataPropertyName = "Location"
        Me.LocationDataGridViewTextBoxColumn.HeaderText = "Location"
        Me.LocationDataGridViewTextBoxColumn.Name = "LocationDataGridViewTextBoxColumn"
        '
        'ChurchAttendenceDataGridViewTextBoxColumn
        '
        Me.ChurchAttendenceDataGridViewTextBoxColumn.DataPropertyName = "Church Attendence"
        Me.ChurchAttendenceDataGridViewTextBoxColumn.HeaderText = "Church Attendence"
        Me.ChurchAttendenceDataGridViewTextBoxColumn.Name = "ChurchAttendenceDataGridViewTextBoxColumn"
        '
        'MontlyFundingDataGridViewTextBoxColumn
        '
        Me.MontlyFundingDataGridViewTextBoxColumn.DataPropertyName = "Montly Funding"
        Me.MontlyFundingDataGridViewTextBoxColumn.HeaderText = "Montly Funding"
        Me.MontlyFundingDataGridViewTextBoxColumn.Name = "MontlyFundingDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 455)
        Me.Controls.Add(Me.records)
        Me.Controls.Add(Me.previousRecord)
        Me.Controls.Add(Me.closeApp)
        Me.Controls.Add(Me.nextRecord)
        Me.Controls.Add(Me.FormBox)
        Me.Name = "Form1"
        Me.Text = "Ministry Data Form"
        Me.FormBox.ResumeLayout(False)
        Me.FormBox.PerformLayout()
        CType(Me.MissionInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MissionarySupportDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.records.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormBox As GroupBox
    Friend WithEvents organization As Label
    Friend WithEvents missionaryID As Label
    Friend WithEvents assignedMissionary As Label
    Friend WithEvents location As Label
    Friend WithEvents attendence As Label
    Friend WithEvents previousRecord As Button
    Friend WithEvents nextRecord As Button
    Friend WithEvents mFunding As Label
    Friend WithEvents closeApp As Button
    Friend WithEvents funding As TextBox
    Friend WithEvents churchAttendence As TextBox
    Friend WithEvents missionLocation As TextBox
    Friend WithEvents org As TextBox
    Friend WithEvents missionary As TextBox
    Friend WithEvents missionaryIdInput As TextBox
    Friend WithEvents saveRecord As Button
    Friend WithEvents newRecord As Button
    Friend WithEvents deleteRecord As Button
    Friend WithEvents MissionarySupportDataSet As MissionarySupportDataSet
    Friend WithEvents MissionInfoBindingSource As BindingSource
    Friend WithEvents MissionInfoTableAdapter As MissionarySupportDataSetTableAdapters.MissionInfoTableAdapter
    Friend WithEvents records As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MissionaryIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AssignedMissionaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrganizationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChurchAttendenceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontlyFundingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
