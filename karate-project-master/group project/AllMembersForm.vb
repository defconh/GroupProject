Public Class AllMembersForm
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AllMembersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KarateDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.KarateDataSet.Members)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Try
            MembersBindingSource.Filter = txtSearch.Text
        Catch ex As Exception
            MessageBox.Show("Please use proper formatting.")
        End Try
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles txtSearch.Click

    End Sub
End Class