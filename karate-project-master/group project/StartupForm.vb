Public Class StartupForm
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ListAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListAllToolStripMenuItem.Click
        AllMembersForm.ShowDialog()
    End Sub
End Class