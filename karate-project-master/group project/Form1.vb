Public Class MemberDateForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Date_Selector.MaxDate = Today()
        Date_Selector.Value = Today()
    End Sub

    Private Sub Date_Selector_ValueChanged(sender As Object, e As EventArgs) Handles Date_Selector.ValueChanged, DataGridView1.Click
        Try 'The try block should test the block of code to fill the database table depending on which radio button is selected
            If radBeforeDate.Checked Then 'If checked, should run the query method for Members
                Me.MembersTableAdapter.FilterDateLess(KarateDataSet.Members, Date_Selector.Value.Date.ToShortDateString()) 'Calls upon the query method to show dates before the user input
                errProvide.SetError(lblHolder, String.Empty)
            ElseIf radAfterDate.Checked Then 'If checked, should run the query method for members that are higher than user input
                Me.MembersTableAdapter.FilterDateMore(KarateDataSet.Members, Date_Selector.Value.Date.ToShortDateString()) 'Calls upon the query method to show dates after the user input'
                errProvide.SetError(lblHolder, String.Empty)
            ElseIf radBeforeDate.Checked = False And radAfterDate.Checked = False Then
                errProvide.SetError(lblHolder, "One of the date selectors must be chosen.")
            Else
                errProvide.SetError(lblHolder, String.Empty)
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid date.")
        End Try
    End Sub

    Private Sub radBeforeDate_CheckedChanged(sender As Object, e As EventArgs) Handles radBeforeDate.CheckedChanged
        Try
            Me.MembersTableAdapter.FilterDateLess(KarateDataSet.Members, Date_Selector.Value.Date.ToShortDateString())
            errProvide.SetError(lblHolder, String.Empty)
        Catch ex As Exception
            MessageBox.Show("Invalid date.")
        End Try
    End Sub

    Private Sub radAfterDate_CheckedChanged(sender As Object, e As EventArgs) Handles radAfterDate.CheckedChanged
        Try
            Me.MembersTableAdapter.FilterDateMore(KarateDataSet.Members, Date_Selector.Value.Date.ToShortDateString())
            errProvide.SetError(lblHolder, String.Empty)
        Catch ex As Exception
            MessageBox.Show("Invalid date.")
        End Try
    End Sub
End Class
