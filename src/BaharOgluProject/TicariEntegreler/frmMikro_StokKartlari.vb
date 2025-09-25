Public Class frmMikro_StokKartlari

    Public Sub FormSelect_PartiLot(Optional ByVal bDialog As Boolean = True, Optional ByVal Owner As Form = Nothing, Optional ByVal bMultiSelect As Boolean = False)
        Try
            Me.MasterTable.SelectCommand.CommandText &= " AND sto_detay_takip=2 "
            Me.FormSelect(bDialog, Owner, bMultiSelect)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
