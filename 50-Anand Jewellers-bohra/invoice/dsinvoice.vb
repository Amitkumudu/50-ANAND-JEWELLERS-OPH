Partial Class dsinvoice
    Partial Class rptsessionDataTable

        Private Sub rptsessionDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.tagno_alphaColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class rptheaderDataTable

        Private Sub rptheaderDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            'If (e.Column.ColumnName = Me.Column1Column.ColumnName) Then
            '    'Add user code here
            'End If

        End Sub

    End Class

End Class
