Partial Class rto_managementDataSet
    Partial Public Class registeredDataTable
        Private Sub registeredDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.TYPE_OF_LICENCEColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
