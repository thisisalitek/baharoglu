Public Class frmCizgiRKafa
    Public TipFilter As String = ""
    Public CizgiSayisiFilter As Integer = 0

    Private Sub frmCizgiRKafa_ButtonSaveBeforeClick(ByVal Sender As Object, ByRef e As ItemFormSaveEventArgs) Handles Me.ButtonSaveBeforeClick
        Try
            If IfNull(MasterLink.CurrentRow("Tip"), "") = "" Then
                e.Cancel = True
                MsgBox("Lütfen tip seçiniz!")
                Exit Sub
            End If
            Dim sbuf As String = Trim(IfNull(MasterLink.CurrentRow("RKafa"), ""))
            Dim sbuf2 As String = ""
            Dim bCik As Boolean = False

            Do While bCik = False
                sbuf2 = sbuf
                sbuf = Replace(sbuf, "  ", " ")
                If sbuf = sbuf2 Then
                    bCik = True
                End If
            Loop

            MasterLink.CurrentRow("RKafa") = sbuf
            If If0Null(MasterLink.CurrentRow("CizgiSayisi")) <> sbuf.Split(" ").Length Then
                e.Cancel = True
                MsgBox("Çizgi Sayısı:" & If0Null(MasterLink.CurrentRow("CizgiSayisi")) & vbNewLine & _
                       "Parça Sayısı:" & sbuf.Split(" ").Length & vbNewLine & _
                       "Kafadaki boşluk sayısı çizgi sayısı ile uyumsuz!")
                Exit Sub

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmCizgiRKafa_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Trim(TipFilter) <> "" Then
                MasterTable.SelectCommand.CommandText &= " AND Tip='" & TipFilter & "' "
                If CizgiSayisiFilter > 0 Then
                    MasterTable.SelectCommand.CommandText &= " AND CizgiSayisi=" & CizgiSayisiFilter & " "
                End If
                OpenTable(MasterTable)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
