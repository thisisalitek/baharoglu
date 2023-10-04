Public Class frmHammaddeAyarlar 
    
    Public FormCode As String = "000023"

    Public Sub FormShow()
        'LoadForm()
        Me.Show()
    End Sub


    Private Sub LoadForm()

    End Sub

    Private Sub frmHammaddeAyarlar_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try
            Dim sbuf As String = ""
            sbuf = GetSetting(AppConn.ApplicationCode, "HammaddeAyar", "Hammadde_SabitDepo", "False")
            If UCase(sbuf) = "TRUE" Then
                chkHammadde_SabitDepo.Checked = True
            Else
                chkHammadde_SabitDepo.Checked = False
            End If
            txtDepo.Text = GetSetting(AppConn.ApplicationCode, "HammaddeAyar", "Hammadde_DepoNo", "")

            txtHammaddeGiris_SeriIrsaliyeType0.Text = GetSetting(AppConn.ApplicationCode, "HammaddeAyar", "HammaddeGiris_SeriIrsaliyeType0", "HA")
            txtHammaddeGiris_SeriIrsaliyeType1.Text = GetSetting(AppConn.ApplicationCode, "HammaddeAyar", "HammaddeGiris_SeriIrsaliyeType1", "HD")
            txtHammaddeGiris_SeriIrsaliyeType2.Text = GetSetting(AppConn.ApplicationCode, "HammaddeAyar", "HammaddeGiris_SeriIrsaliyeType2", "UI")

            txtHammadde_UretimIadeGirisIsEmriNo.Text = GetSetting(AppConn.ApplicationCode, "HammaddeAyar", "HammaddeGiris_UretimIadeIsEmriNo", "")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chkHammadde_SabitDepo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkHammadde_SabitDepo.CheckedChanged
        Try
            SaveSetting(AppConn.ApplicationCode, "HammaddeAyar", "Hammadde_SabitDepo", chkHammadde_SabitDepo.Checked.ToString)
            If chkHammadde_SabitDepo.Checked Then
                txtDepo.Enabled = True
            Else
                txtDepo.Enabled = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtDepo_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtDepo.ButtonClick
        Try
            Dim f As New frmMikro_Depolar
            With f
                
                .FormSelect()
                If .DialogResult = Windows.Forms.DialogResult.OK Then
                    txtDepo.Text = IfNull(.ReturnDataRow("dep_no"), "")

                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtDepo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDepo.KeyDown
        Try
            If e.KeyCode = Keys.F10 Then
                txtDepo_ButtonClick(Nothing, Nothing)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdKaydet_Click(sender As System.Object, e As System.EventArgs) Handles cmdKaydet.Click
        Try
            SaveSetting(AppConn.ApplicationCode, "HammaddeAyar", "Hammadde_SabitDepo", chkHammadde_SabitDepo.Checked.ToString)
            SaveSetting(AppConn.ApplicationCode, "HammaddeAyar", "Hammadde_DepoNo", txtDepo.Text)
            SaveSetting(AppConn.ApplicationCode, "HammaddeAyar", "HammaddeGiris_SeriIrsaliyeType0", txtHammaddeGiris_SeriIrsaliyeType0.Text)
            SaveSetting(AppConn.ApplicationCode, "HammaddeAyar", "HammaddeGiris_SeriIrsaliyeType1", txtHammaddeGiris_SeriIrsaliyeType1.Text)
            SaveSetting(AppConn.ApplicationCode, "HammaddeAyar", "HammaddeGiris_SeriIrsaliyeType2", txtHammaddeGiris_SeriIrsaliyeType2.Text)

            SaveSetting(AppConn.ApplicationCode, "HammaddeAyar", "HammaddeGiris_UretimIadeIsEmriNo", txtHammadde_UretimIadeGirisIsEmriNo.Text)


            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdVazgec_Click(sender As System.Object, e As System.EventArgs) Handles cmdVazgec.Click
        Try

            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class