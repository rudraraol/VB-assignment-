Partial Class TRSDataSet
    Partial Class ConcertsDataTable

        Private Sub ConcertsDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.Concert_IDColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
