Public Class frmFason

    Public Sub Form1Item(ID As Long)
        Try
            bFormShowOneItem = True
            MasterTable.SelectCommand.CommandText &= " AND FasonFis.SipDetayID=" & ID
            Me.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdSiparisSec_Click(sender As Object, e As EventArgs) Handles cmdSiparisSec.Click
        Try
            If EditMode = False Then
                Beep()

                Exit Sub
            End If
            If MasterLink.CurrentRow Is Nothing Then Exit Sub
            If IfNull(MasterLink.CurrentRow("CariKod"), "") = "" Then
                MsgBox("Lütfen cari kod seçiniz!")
                Exit Sub
            End If
            Dim f As New frmSiparisRaporu
            With f
                
                .FormShow_SelectSiparis("", " AND SipDetay.Durumu<>'BITTI' ", False)
                If .DialogResult = Windows.Forms.DialogResult.OK Then
                    Dim cmd As New SqlClient.SqlCommand
                    Dim da As SqlClient.SqlDataAdapter
                    Dim dt As DataTable
                    cmd.Connection = AppConn.dbConn
                    cmd.CommandText = "SELECT COUNT(*) FROM FasonFis WHERE Deleted = 0 AND Kapali=0 AND Iptal = 0 AND SipDetayID =" & .ReturnDataRow("SipDetayID") & " AND FasonFisID<>" & If0Null(MasterLink.CurrentRow("FasonFisID")) & " AND Parca='" & MasterLink.CurrentRow("Parca") & "' "
                    If cmd.ExecuteScalar > 0 Then
                        MsgBox("Secilen siparisin parcasi(" & MasterLink.CurrentRow("Parca") & ") zaten fasonda gorunuyor. Lutfen kontrol ediniz!")
                        Exit Sub
                    End If

                    MasterLink.CurrentRow("SipDetayID") = .ReturnDataRow("SipDetayID")
                    MasterLink.CurrentRow("SiparisID") = .ReturnDataRow("SiparisID")

                    cmd.CommandText = "SELECT Siparis.SipEvrakSeri, Siparis.SipEvrakSira, SipDetay.StokKod, Siparis.CariKod AS SipCariKod, Siparis.CariUnvan AS SipCariUnvan, SipDetay.Miktar, SipDetay.TerminTarihi AS SipTermin, " &
                        " Siparis.Tarih AS SipTarihi, SipDetay.Durumu, SipDetay.AnaRenk, SipDetay.Bedenler " &
                        " FROM  SipDetay INNER JOIN " &
                        " Siparis ON SipDetay.SiparisID = Siparis.SiparisID " &
                        " WHERE SipDetay.SipDetayID=" & MasterLink.CurrentRow("SipDetayID")
                    da = New SqlClient.SqlDataAdapter(cmd)
                    dt = New DataTable
                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        MasterLink.CurrentRow("Adet") = dt.Rows(0).Item("Miktar")
                        MasterLink.CurrentRow("SipEvrakSeri") = dt.Rows(0).Item("SipEvrakSeri")
                        MasterLink.CurrentRow("SipEvrakSira") = dt.Rows(0).Item("SipEvrakSira")
                        MasterLink.CurrentRow("StokKod") = dt.Rows(0).Item("StokKod")
                        MasterLink.CurrentRow("SipCariKod") = dt.Rows(0).Item("SipCariKod")
                        MasterLink.CurrentRow("SipCariUnvan") = dt.Rows(0).Item("SipCariUnvan")
                        MasterLink.CurrentRow("Miktar") = dt.Rows(0).Item("Miktar")
                        MasterLink.CurrentRow("SipTermin") = dt.Rows(0).Item("SipTermin")
                        MasterLink.CurrentRow("SipTarihi") = dt.Rows(0).Item("SipTarihi")
                        MasterLink.CurrentRow("Durumu") = dt.Rows(0).Item("Durumu")
                        MasterLink.CurrentRow("AnaRenk") = dt.Rows(0).Item("AnaRenk")
                        MasterLink.CurrentRow("Bedenler") = dt.Rows(0).Item("Bedenler")
                        MasterLink.CurrentRow.EndEdit()
                    End If
                    dt.Dispose()
                    da.Dispose()
                    cmd.Dispose()

                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Dim ForDelete_SipDetayID As Long = 0

    Private Sub frmFason_ButtonDeleteAfterClick(Sender As Object, ByRef e As ItemFormSaveEventArgs) Handles Me.ButtonDeleteAfterClick
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = MasterTable.Connection.SqlConnection
            cmd.Transaction = MasterTable.Transaction
            cmd.CommandText = "IF NOT EXISTS (SELECT * FROM FasonFis WHERE Deleted = 0 AND Kapali=0 AND Iptal=0 AND SipDetayID = " & ForDelete_SipDetayID & ") BEGIN " & vbNewLine
            cmd.CommandText &= " UPDATE SipDetay SET FasondaMi=0 INNER JOIN  WHERE SipDetayID = " & ForDelete_SipDetayID & " " & vbNewLine
            cmd.CommandText &= " END "
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            e.Cancel = True
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmFason_ButtonDeleteBeforeClick(Sender As Object, ByRef e As ItemFormSaveEventArgs) Handles Me.ButtonDeleteBeforeClick
        ForDelete_SipDetayID = If0Null(MasterLink.CurrentRow("SipDetayID"))
    End Sub

    Private Sub frmFason_ButtonNewClick(Sender As Object, e As EventArgs) Handles Me.ButtonNewClick
        Try
            With MasterLink.CurrentRow
                .Item("Tarih") = AppConn.Today
                .Item("FasonTermin") = AppConn.Today


            End With
            YeniEvrakNo()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub YeniEvrakNo()
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim dt As DataTable
            Dim da As SqlClient.SqlDataAdapter
            Dim Seri As String = ""
            Dim Sira As Long = 0
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "SELECT TOP 1 F.FasonEvrakSeri,L.Sira  FROM FasonFis F INNER JOIN  " &
                "(SELECT FasonEvrakSeri,MAX(FasonEvrakSira) as Sira FROM FasonFis WHERE Deleted = 0 " &
                "GROUP BY FasonEvrakSeri) L ON F.FasonEvrakSeri = L.FasonEvrakSeri " &
                "WHERE F.Deleted = 0  " &
                "ORDER BY F.FasonFisID DESC " &
                ""
            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Seri = IfNull(dt.Rows(0).Item("FasonEvrakSeri"), "")
                Sira = If0Null(dt.Rows(0).Item("Sira"))
            End If
            dt.Dispose()
            da.Dispose()
            cmd.Dispose()

            With MasterLink.CurrentRow

                .Item("FasonEvrakSeri") = Seri
                .Item("FasonEvrakSira") = Sira + 1
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmFason_ButtonRefreshClick(Sender As Object, e As EventArgs) Handles Me.ButtonRefreshClick

    End Sub

    Private Sub frmFason_ButtonSaveAfterClick(Sender As Object, ByRef e As ItemFormSaveEventArgs) Handles Me.ButtonSaveAfterClick
        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = MasterTable.Connection.SqlConnection
            cmd.Transaction = MasterTable.Transaction

            'If If0Null(MasterLink.CurrentRow("Kapali")) = 0 And If0Null(MasterLink.CurrentRow("Iptal")) = 0 Then
            '    cmd.CommandText = "UPDATE SipDetay SET FasondaMi=1  WHERE SipDetayID = " & If0Null(MasterLink.CurrentRow("SipDetayID"))
            '    cmd.ExecuteNonQuery()
            'Else
            '    cmd.CommandText = "IF NOT EXISTS (SELECT * FROM FasonFis WHERE Deleted = 0 AND Kapali=0 AND Iptal=0 AND SipDetayID = " & If0Null(MasterLink.CurrentRow("SipDetayID")) & ") BEGIN " & vbNewLine
            '    cmd.CommandText &= " UPDATE SipDetay SET FasondaMi=0 INNER JOIN  WHERE SipDetayID = " & If0Null(MasterLink.CurrentRow("SipDetayID")) & " " & vbNewLine
            '    cmd.CommandText &= " END "
            '    cmd.ExecuteNonQuery()

            'End If

            cmd.CommandText = "UPDATE SipDetay SET FasondaMi=1 " & vbNewLine &
                " WHERE SipDetayID IN (SELECT SipDetayID FROM FasonFis WHERE Deleted = 0 AND Kapali=0 AND Iptal=0) "
            cmd.ExecuteNonQuery()

            cmd.CommandText = "UPDATE SipDetay SET FasondaMi=0 " & vbNewLine &
                " WHERE NOT SipDetayID IN (SELECT SipDetayID FROM FasonFis WHERE Deleted = 0 AND Kapali=0 AND Iptal=0) "
            cmd.ExecuteNonQuery()



        Catch ex As Exception
            e.Cancel = True
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmFason_ButtonSaveBeforeClick(Sender As Object, ByRef e As ItemFormSaveEventArgs) Handles Me.ButtonSaveBeforeClick
        Try
            If IfNull(MasterLink.CurrentRow("FasonTuru"), "") = "" Then
                e.Cancel = True
                MsgBox("Lutfen fason turunu seciniz!")
                Exit Sub
            End If

            If IfNull(MasterLink.CurrentRow("CariKod"), "") = "" Then
                e.Cancel = True
                MsgBox("Lutfen fason carisi seciniz!")
                Exit Sub
            End If

            If If0Null(MasterLink.CurrentRow("SipDetayID")) = 0 Then
                e.Cancel = True
                MsgBox("Lutfen siparis seciniz!")
                Exit Sub
            End If
            MasterLink.CurrentRow("Parca") = Replace(UCaseEng(IfNull(MasterLink.CurrentRow("Parca"), "")), "'", " ")
            MasterLink.CurrentRow.EndEdit()



            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "SELECT COUNT(*) FROM FasonFis WHERE Deleted = 0 AND Kapali=0 AND Iptal = 0 AND SipDetayID =" & If0Null(MasterLink.CurrentRow("SipDetayID")) & " AND FasonFisID<>" & If0Null(MasterLink.CurrentRow("FasonFisID")) & " AND Parca='" & MasterLink.CurrentRow("Parca") & "' "
            If cmd.ExecuteScalar > 0 Then
                MsgBox("Secilen siparisin parcasi(" & MasterLink.CurrentRow("Parca") & ") zaten fasonda gorunuyor. Lutfen kontrol ediniz!")
                Exit Sub
            End If



        Catch ex As Exception
            e.Cancel = True
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmFason_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F3 Then
                cmdSiparisSec_Click(Nothing, Nothing)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub CariKodButtonEdit_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles CariKodButtonEdit.ButtonClick, CariUnvanButtonEdit.ButtonClick
        Try
            If MasterLink.CurrentRow Is Nothing Then Exit Sub
            If EditMode = False Then
                MsgBox("Değiştirme modu aktif değil!")
                Exit Sub
            End If
            If CariKodButtonEdit.Properties.ReadOnly Then Exit Sub
            Dim f As New frmMikro_Cariler
            With f
                
                .FormSelect()
                If .DialogResult = Windows.Forms.DialogResult.OK Then
                    MasterLink.CurrentRow("CariKod") = IfNull(.ReturnDataRow("cari_kod"), "")
                    MasterLink.CurrentRow("CariUnvan") = IfNull(.ReturnDataRow("CariUnvan"), "")
                    MasterLink.CurrentRow.EndEdit()
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CariKodButtonEdit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CariKodButtonEdit.KeyDown, CariUnvanButtonEdit.KeyDown
        Try
            If e.KeyCode = Keys.F10 Then
                CariKodButtonEdit_ButtonClick(Nothing, Nothing)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub KapatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KapatToolStripMenuItem.Click
        Try
            If GridView1.FocusedRowHandle < 0 Then Exit Sub
            Dim RowIndex As Integer = GridView1.GetDataSourceRowIndex(GridView1.FocusedRowHandle)
            If RowIndex < 0 Then Exit Sub
            Dim dr As DataRow = MasterTable.Rows(RowIndex)
            If If0Null(dr("Kapali")) = 1 Then Exit Sub

            If MsgBox("Fisno:" & IfNull(dr("FasonEvrakSeri"), "") & "-" & If0Null(dr("FasonEvrakSira")) & " Fason fisini kapatmak istiyor musunuz?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Kapat?") <> MsgBoxResult.Yes Then Exit Sub

            Dim cmd As New SqlClient.SqlCommand
            Dim trans As SqlClient.SqlTransaction
            cmd.Connection = AppConn.dbConn
            trans = AppConn.dbConn.BeginTransaction
            cmd.Transaction = trans
            Try
                cmd.CommandText = "UPDATE FasonFis SET Kapali=1 , ModifiedDate=GETDATE() , ModifiedBy=" & AppConn.ActiveUser.UserID & " , KapanmaTarihi=CAST(ROUND(CAST(GETDATE() as FLOAT),0,1) as DATETIME) WHERE FasonFisID=" & If0Null(dr("FasonFisID"))
                cmd.ExecuteNonQuery()
                cmd.CommandText = "UPDATE SipDetay SET FasondaMi=1 " & vbNewLine &
                    " WHERE SipDetayID IN (SELECT SipDetayID FROM FasonFis WHERE Deleted = 0 AND Kapali=0 AND Iptal=0) "
                cmd.ExecuteNonQuery()

                cmd.CommandText = "UPDATE SipDetay SET FasondaMi=0 " & vbNewLine &
                    " WHERE NOT SipDetayID IN (SELECT SipDetayID FROM FasonFis WHERE Deleted = 0 AND Kapali=0 AND Iptal=0) "
                cmd.ExecuteNonQuery()

                'cmd.CommandText = "UPDATE SipDetay SET FasondaMi=0  WHERE SipDetayID = " & If0Null(dr("SipDetayID"))
                'cmd.ExecuteNonQuery()
                'dr("Kapali") = 1
                'dr.EndEdit()
                trans.Commit()
                btnRefresh_ItemClick(Nothing, Nothing)

            Catch ex As Exception
                trans.Rollback()
                MsgBox(ex.Message)
            End Try




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chkGoster_Kapalilar_CheckedChanged(sender As Object, e As EventArgs) Handles chkGoster_Kapalilar.CheckedChanged, chkGoster_Iptaller.CheckedChanged
        Try
            If chkGoster_Kapalilar.Checked Then
                MasterTable.SelectCommand.Parameters("@Kapali").Value = 1
            Else
                MasterTable.SelectCommand.Parameters("@Kapali").Value = 0
            End If

            If chkGoster_Iptaller.Checked Then
                MasterTable.SelectCommand.Parameters("@Iptal").Value = 1
            Else
                MasterTable.SelectCommand.Parameters("@Iptal").Value = 0
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MasterTable_ColumnChanged(sender As Object, e As DataColumnChangeEventArgs) Handles MasterTable.ColumnChanged
        Try
            If e.Column.ColumnName = "Kapali" Then
                If e.Row("Kapali") = 1 Then
                    e.Row("KapanmaTarihi") = Today

                End If

            End If

            e.Row.EndEdit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
