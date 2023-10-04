Module modMain
    Public Const MSG_SearchText = "Aranan kelimeyi buraya yazınız."
    Public AppConn As New cAppConn

    Public DocumentClipboard_DocumentID As Guid
    Public DocumentClipboard_Action As typDocumentClipboard_Action = typDocumentClipboard_Action.DocumentAction_None

    Public FormLanguage_WritingMode As Boolean = False
    Public glb_TeslimEksikOran As Double = 5 'yuzde +- fark olabilir
    Public glb_TeslimFazlaOran As Double = 5 'yuzde +- fark olabilir


    Public Sub SaveGridView(ByVal FormCode As String, ByVal GridView1 As DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            If FormCode <> "" Then
                If GridView1.OptionsLayout.LayoutVersion <> "" Then
                    GridView1.SaveLayoutToRegistry("HKEY_CURRENT_USER\Software\VB and VBA Program Settings\" & AppConn.ApplicationCode & "\" & FormCode & "\" & GridView1.Name & "\" & GridView1.OptionsLayout.LayoutVersion)
                Else
                    GridView1.SaveLayoutToRegistry("HKEY_CURRENT_USER\Software\VB and VBA Program Settings\" & AppConn.ApplicationCode & "\" & FormCode & "\" & GridView1.Name & "\0")
                End If
            End If
        Catch ex As Exception
            MsgBox("Registry hatası:" & ex.Message)
        End Try
    End Sub

    Public Sub LoadGridView(ByVal FormCode As String, ByRef GridView1 As DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            If FormCode <> "" Then
                If GridView1.OptionsLayout.LayoutVersion <> "" Then
                    GridView1.RestoreLayoutFromRegistry("HKEY_CURRENT_USER\Software\VB and VBA Program Settings\" & AppConn.ApplicationCode & "\" & FormCode & "\" & GridView1.Name & "\" & GridView1.OptionsLayout.LayoutVersion)
                Else
                    GridView1.RestoreLayoutFromRegistry("HKEY_CURRENT_USER\Software\VB and VBA Program Settings\" & AppConn.ApplicationCode & "\" & FormCode & "\" & GridView1.Name & "\0")
                End If

                GridView1.ClearColumnsFilter()
            End If
        Catch ex As Exception
            MsgBox("Registry hatası:" & ex.Message)
        End Try
    End Sub

    Public Sub SaveDataLayout(ByVal FormCode As String, ByVal DataLayout1 As DevExpress.XtraDataLayout.DataLayoutControl)
        Try
            If FormCode <> "" Then
                If DataLayout1.LayoutVersion <> "" Then
                    DataLayout1.SaveLayoutToRegistry("HKEY_CURRENT_USER\Software\VB and VBA Program Settings\" & AppConn.ApplicationCode & "\" & FormCode & "\" & DataLayout1.Name & "\" & DataLayout1.LayoutVersion)
                Else
                    DataLayout1.SaveLayoutToRegistry("HKEY_CURRENT_USER\Software\VB and VBA Program Settings\" & AppConn.ApplicationCode & "\" & FormCode & "\" & DataLayout1.Name & "\0")
                End If
            End If
        Catch ex As Exception
            MsgBox("Registry hatası:" & ex.Message)
        End Try
    End Sub

    Public Sub LoadDataLayout(ByVal FormCode As String, ByRef DataLayout1 As DevExpress.XtraDataLayout.DataLayoutControl)
        Try
            If FormCode <> "" Then
                If DataLayout1.LayoutVersion <> "" Then
                    DataLayout1.RestoreLayoutFromRegistry("HKEY_CURRENT_USER\Software\VB and VBA Program Settings\" & AppConn.ApplicationCode & "\" & FormCode & "\" & DataLayout1.Name & "\" & DataLayout1.LayoutVersion)
                Else
                    DataLayout1.RestoreLayoutFromRegistry("HKEY_CURRENT_USER\Software\VB and VBA Program Settings\" & AppConn.ApplicationCode & "\" & FormCode & "\" & DataLayout1.Name & "\0")
                End If
            End If
        Catch ex As Exception
            MsgBox("Registry hatası:" & ex.Message)
        End Try
    End Sub

    Public Function GridExport(ByVal tExport As typePiconnExport, ByVal SaveFileDialog1 As SaveFileDialog, ByVal GridView1 As DevExpress.XtraGrid.Views.Grid.GridView) As Boolean

        Try
            SaveFileDialog1.FileName = ""
            Select Case tExport
                Case typePiconnExport.XLS
                    SaveFileDialog1.DefaultExt = "xls"
                    SaveFileDialog1.Filter = "Excel Files (*.xls)|*.xls|All Files (*.*)|*.*"
                Case typePiconnExport.PDF
                    SaveFileDialog1.DefaultExt = "pdf"
                    SaveFileDialog1.Filter = "Acrobat Reader Files (*.PDF)|*.pdf|All Files (*.*)|*.*"
                Case typePiconnExport.TXT
                    SaveFileDialog1.DefaultExt = "txt"
                    SaveFileDialog1.Filter = "Text Files (*.TXT)|*.TXT|All Files (*.*)|*.*"
                Case typePiconnExport.CSV
                    SaveFileDialog1.DefaultExt = "csv"
                    SaveFileDialog1.Filter = "CSV Files (*.CSV)|*.CSV|All Files (*.*)|*.*"
                Case typePiconnExport.HTML
                    SaveFileDialog1.DefaultExt = "htm"
                    SaveFileDialog1.Filter = "HTML Files (*.HTM)|*.HTM|All Files (*.*)|*.*"
            End Select
            If SaveFileDialog1.ShowDialog() <> Windows.Forms.DialogResult.OK Then Exit Function
            If IO.File.Exists(SaveFileDialog1.FileName) Then
                If MsgBox(SaveFileDialog1.FileName & vbNewLine & "Dosya zaten var! Üzerine yazmak istiyor musunuz?", MsgBoxStyle.Critical + MsgBoxStyle.YesNoCancel, "Üzerine yaz?") <> MsgBoxResult.Yes Then Exit Function
            End If
            Select Case tExport
                Case typePiconnExport.XLS
                    GridView1.ExportToXls(SaveFileDialog1.FileName)
                Case typePiconnExport.PDF
                    GridView1.ExportToPdf(SaveFileDialog1.FileName)
                Case typePiconnExport.TXT
                    Dim s As New DevExpress.XtraPrinting.TextExportOptions
                    s.Separator = vbTab
                    GridView1.ExportToText(SaveFileDialog1.FileName, s)
                Case typePiconnExport.CSV
                    Dim s As New DevExpress.XtraPrinting.TextExportOptions
                    s.Separator = ";"
                    GridView1.ExportToText(SaveFileDialog1.FileName, s)
                Case typePiconnExport.HTML
                    GridView1.ExportToHtml(SaveFileDialog1.FileName)
            End Select
Cikis:
            If MsgBox("Dosyayı Açmak ister misiniz", MsgBoxStyle.Question Or MsgBoxStyle.YesNoCancel, "Dosyayı Aç?") = MsgBoxResult.Yes Then
                Try
                    Shell("Explorer.exe " & Chr(34) & SaveFileDialog1.FileName & Chr(34), AppWinStyle.NormalFocus, False)
                Catch ex As Exception

                End Try

            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Dim loading As New frmLoading()

    Public Sub LoadingShow(Optional text As String = "")
        If text = "" Then
            loading.ProgressPanel1.Text = "Lütfen bekleyiniz"
        Else
            loading.ProgressPanel1.Text = text
        End If
        loading.Show()
        Application.DoEvents()

    End Sub

    Public Sub LoadingHide()

        loading.Hide()
        Application.DoEvents()

    End Sub

    Public Function getYilAyListesi(dtFormDate1 As DateTime, dtFormDate2 As DateTime) As List(Of YilAy)
        Dim liste As New List(Of YilAy)
        Dim yil1 As Integer = dtFormDate1.Year
        Dim ay1 As Integer = dtFormDate1.Month
        Dim yil2 As Integer = dtFormDate2.Year
        Dim ay2 As Integer = dtFormDate2.Month

        For yil = yil1 To yil2
            If yil = yil1 Then
                If (yil1 < yil2) Then
                    For ay = ay1 To 12

                        liste.Add(New YilAy(yil, ay))
                    Next
                Else
                    For ay = ay1 To ay2
                        liste.Add(New YilAy(yil, ay))
                    Next
                End If
            ElseIf yil = yil2 Then
                For ay = 1 To ay2
                    liste.Add(New YilAy(yil, ay))
                Next
            Else
                For ay = 1 To 12
                    liste.Add(New YilAy(yil, ay))
                Next
            End If
        Next




        Return liste
    End Function
End Module

Public Class YilAy
    Public Yil As Integer
    Public Ay As Integer
    Public Baslangic As DateTime
    Public Bitis As DateTime
    Public Sub New(_yil As Integer, _ay As Integer)
        Yil = _yil
        Ay = _ay
        Baslangic = New DateTime(Yil, Ay, 1)
        Bitis = New DateTime(Yil, Ay, DateTime.DaysInMonth(Yil, Ay))

    End Sub
End Class

Public Enum typDocumentClipboard_Action
    DocumentAction_None = 0
    DocumentAction_Cut = 1
    DocumentAction_Copy = 2

End Enum


Public Enum typePiconnExport
    XLS = 1
    PDF = 2
    TXT = 3
    CSV = 4
    HTML = 5
End Enum

Public Class kategoriItem
    Public UstKategoriID As Long
    Public KategoriID As Long
    Public KendiFiyatBedenKullan As Long
    Public KendiMasrafKullan As Long
    Public bKategori As Boolean
    Public KategoriKod As String
    Public KategoriIsim As String
    Public Sub New()

    End Sub

    Public Sub New(_ustKategoriID As Long, _kategoriID As Long, _kendiFiyatBedenKullan As Long, _KendiMasrafKullan As Long, _bKategori As Boolean)
        Me.UstKategoriID = _ustKategoriID
        Me.KategoriID = _kategoriID
        Me.KendiFiyatBedenKullan = _kendiFiyatBedenKullan
        Me.KendiMasrafKullan = _KendiMasrafKullan
        Me.bKategori = _bKategori

    End Sub

    Public Sub New(_ustKategoriID As Long, _kategoriID As Long, _kendiFiyatBedenKullan As Long, _KendiMasrafKullan As Long, _bKategori As Boolean, _KategoriKod As String, _KategoriIsim As String)
        Me.UstKategoriID = _ustKategoriID
        Me.KategoriID = _kategoriID
        Me.KendiFiyatBedenKullan = _kendiFiyatBedenKullan
        Me.KendiMasrafKullan = _KendiMasrafKullan
        Me.bKategori = _bKategori
        Me.KategoriKod = _KategoriKod
        Me.KategoriIsim = _KategoriIsim

    End Sub
End Class
