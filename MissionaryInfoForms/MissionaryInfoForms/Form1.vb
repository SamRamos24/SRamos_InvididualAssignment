Public Class Form1

    'Datagrid view - displays database records and allows user to interact with content'
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MissionarySupportDataSet.MissionInfo' table. You can move, or remove it, as needed.
        Me.MissionInfoTableAdapter.Fill(Me.MissionarySupportDataSet.MissionInfo)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    '--EVERYTHING BELOW THIS POINT DESCRIBES BUTTON FUNCTIONALITY--'

    'click activity to select the previous record - corresponds to the previous button'
    Private Sub previousRecord_Click(sender As Object, e As EventArgs) Handles previousRecord.Click
        MissionInfoBindingSource.MovePrevious()
    End Sub
    'click activity to select the next record - corresponds to the next button' 
    Private Sub nextRecord_Click(sender As Object, e As EventArgs) Handles nextRecord.Click
        MissionInfoBindingSource.MoveNext()
    End Sub
    'click activity to create a new record - corresponds with the new record button'
    Private Sub newRecord_Click(sender As Object, e As EventArgs) Handles newRecord.Click
        MissionInfoBindingSource.AddNew()
    End Sub
    'click activitiy to save the record - corresponds with the save record button'
    Private Sub saveRecord_Click(sender As Object, e As EventArgs) Handles saveRecord.Click
        MissionInfoBindingSource.EndEdit()
        MissionInfoTableAdapter.Update(MissionarySupportDataSet)
        MessageBox.Show("input saved")
    End Sub
    'click activity to delete current record - corresponds with the delete record button'
    Private Sub deleteRecord_Click(sender As Object, e As EventArgs) Handles deleteRecord.Click
        MissionInfoBindingSource.RemoveCurrent()

    End Sub
    'click activity to close app - corresponds with close button'
    Private Sub closeApp_Click(sender As Object, e As EventArgs) Handles closeApp.Click
        Me.Close()
    End Sub


End Class
