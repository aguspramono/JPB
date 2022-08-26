

Partial Public Class dsLaporan
    Partial Class PembayaranBertahapDataTable

        Private Sub PembayaranBertahapDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.KodePembayaranColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class FeePembayaranDetailFeeDataTable

        Private Sub FeePembayaranDetailFeeDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.kodeKelompokColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class FeePembayaranFeeDetailDataTable

        Private Sub FeePembayaranFeeDetailDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging

        End Sub

    End Class

End Class
