Imports DevExpress.Skins
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors

Public Class frmMainMenu

    
    Dim frmSplash1 As Form
    Public Sub New()

        Try
            DevExpress.UserSkins.BonusSkins.Register()
            DevExpress.Skins.SkinManager.EnableFormSkins()

            Application.EnableVisualStyles()
        Catch ex As Exception
            MsgBox("(frmMainMenu2_Load) " & ex.Message)
        End Try
        InitializeComponent()


    End Sub

#Region "SkinGallery"
    Private Sub InitSkinGallery()
        Dim imageButton As SimpleButton = New SimpleButton()
        For Each cnt As SkinContainer In SkinManager.Default.Skins
            imageButton.LookAndFeel.SetSkinStyle(cnt.SkinName)
            Dim gItem As GalleryItem = New GalleryItem()
            Dim groupIndex As Integer = 0
            If cnt.SkinName.IndexOf("Office") > -1 Then
                groupIndex = 1
            End If
            rgbiSkins.Gallery.Groups(groupIndex).Items.Add(gItem)
            gItem.Caption = cnt.SkinName

            gItem.Image = GetSkinImage(imageButton, 32, 17, 2)
            gItem.HoverImage = GetSkinImage(imageButton, 70, 36, 5)

            gItem.Caption = cnt.SkinName
            gItem.Hint = cnt.SkinName
            rgbiSkins.Gallery.Groups(1).Visible = False
        Next cnt

    End Sub
    Private Function GetSkinImage(ByVal button As SimpleButton, ByVal width As Integer, ByVal height As Integer, ByVal indent As Integer) As Bitmap
        Dim image As Bitmap = New Bitmap(width, height)
        Using g As Graphics = Graphics.FromImage(image)
            Dim info As StyleObjectInfoArgs = New StyleObjectInfoArgs(New GraphicsCache(g))
            info.Bounds = New Rectangle(0, 0, width, height)
            button.LookAndFeel.Painter.GroupPanel.DrawObject(info)
            button.LookAndFeel.Painter.Border.DrawObject(info)
            info.Bounds = New Rectangle(indent, indent, width - indent * 2, height - indent * 2)
            button.LookAndFeel.Painter.Button.DrawObject(info)
        End Using
        Return image
    End Function

    Private Sub rgbiSkins_Gallery_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs) Handles rgbiSkins.Gallery.ItemClick

        Try
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(e.Item.Caption)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rgbiSkins_Gallery_InitDropDownGallery(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.InplaceGalleryEventArgs) Handles rgbiSkins.Gallery.InitDropDownGallery
        e.PopupGallery.CreateFrom(rgbiSkins.Gallery)
        e.PopupGallery.AllowFilter = False
        e.PopupGallery.ShowItemText = True
        e.PopupGallery.ShowGroupCaption = True
        e.PopupGallery.AllowHoverImages = False
        For Each galleryGroup As GalleryItemGroup In e.PopupGallery.Groups
            For Each item As GalleryItem In galleryGroup.Items
                item.Image = item.HoverImage
            Next item
        Next galleryGroup
        e.PopupGallery.ColumnCount = 2
        e.PopupGallery.ImageSize = New Size(70, 36)
    End Sub
#End Region

    Public Sub FormShow(Optional ByVal frmSplash1_ As Form = Nothing)

        Try

            frmSplash1 = frmSplash1_

            Dim f As New frmLogin
            With f
                .fMain = Me
                
                If Not frmSplash1 Is Nothing Then
                    frmSplash1.Opacity = 0
                    frmSplash1.Visible = False
                End If
                .FormLogin()
                If .DialogResult <> Windows.Forms.DialogResult.OK Then
                    .Dispose()
                    Me.DialogResult = Windows.Forms.DialogResult.Cancel
                    Me.Close()

                    Exit Sub
                End If


                .Dispose()
            End With



            battomItem_Server.Caption = AppConn.dbConn.DataSource
            battomItem_Database.Caption = AppConn.dbConn.Database
            battomItem_Username.Caption = AppConn.ActiveUser.UserName
            battomItem_MikroDB.Caption = AppConn.dbTicari.DataSource & " - " & AppConn.dbTicari.Database

            Me.Show()


        Catch ex As Exception
            MsgBox("(FormShow) " & ex.Message)
        End Try

    End Sub

    Private Sub frmMainMenu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            InitSkinGallery()
            RibbonControl.Minimized = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem2_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Try
            LoadingShow()
            Dim f As New frmSiparisRaporu()

            f.MdiParent = anaform
            f.FormShow(False)
            LoadingHide()
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Try
            LoadingShow()
            Dim f As New frmKategoriler()

            f.MdiParent = anaform
            f.FormShow()
            LoadingHide()
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Try
            Dim f As New Form2()

            f.MdiParent = anaform
            f.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        Try
            LoadingShow()
            Dim f As New frmSiparisler()

            f.MdiParent = anaform
            f.FormShow_CariSiparis(False)
            LoadingHide()
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        Try
            LoadingShow()
            Dim f As New frmSiparisler()

            f.MdiParent = anaform
            f.FormShow_DepoSiparis(False)
            LoadingHide()
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick

        Try
            LoadingShow()
            Dim f As New frmSevkler()

            f.MdiParent = anaform
            f.FormShow_Irsaliye(False)
            LoadingHide()
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem8_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick

        Try
            LoadingShow()
            Dim f As New frmSevkler()

            f.MdiParent = anaform
            f.FormShow_DepoSevk(False)
            LoadingHide()
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem9_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        Try
            LoadingShow()
            Dim f As New frmFason()

            f.MdiParent = anaform
            f.FormShow(False)
            LoadingHide()
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem10_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        Try
            LoadingShow()
            Dim f As New frmMikro_Cariler()

            f.MdiParent = anaform
            f.FormShow(False)
            LoadingHide()
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem11_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        Try
            LoadingShow()
            Dim f As New frmPlanlananTahsilatVeOdemeler()

            f.MdiParent = anaform
            f.FormShow(False)
            LoadingHide()
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem12_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        Try
            LoadingShow()
            Dim f As New frmKategoriReport()

            f.MdiParent = anaform
            f.FormShow(False)
            LoadingHide()
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem13_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        Try
            LoadingShow()
            Dim f As New frmUrunToplamRaporu()

            f.MdiParent = anaform
            f.FormShow(False)
            LoadingHide()
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem14_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        Try
            LoadingShow()
            Dim f As New frmSiparisToplamRaporu()

            f.MdiParent = anaform
            f.FormShow(False)
            LoadingHide()
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem15_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        Try
            LoadingShow()
            Dim f As New frmRenkler()

            f.MdiParent = anaform
            f.FormShow(False)
            LoadingHide()
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem16_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem16.ItemClick
        Try
            LoadingShow()
            Dim f As New frmIplik()

            f.MdiParent = anaform
            f.FormShow(False)
            LoadingHide()
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem17_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        Try
            LoadingShow()
            Dim f As New frmOrguTipi()

            f.MdiParent = anaform
            f.FormShow_Normal(False)
            LoadingHide()
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem18_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem18.ItemClick
        Try
            LoadingShow()
            Dim f As New frmOkullar()

            f.MdiParent = anaform
            f.FormShow(False)
            LoadingHide()
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem19_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        Try
            LoadingShow()
            Dim f As New frmCizgiRKafa()

            f.MdiParent = anaform
            f.FormShow(False)
            LoadingHide()
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem20_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem20.ItemClick
        Try
            LoadingShow()
            Dim f As New frmCizgiRKafaLakos()

            f.MdiParent = anaform
            f.FormShow(False)
            LoadingHide()
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem21_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem21.ItemClick
        Try
            LoadingShow()
            Dim f As New frmFasonTanim()

            f.MdiParent = anaform
            f.FormShow(False)
            LoadingHide()
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem22_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem22.ItemClick
        Try
            LoadingShow()
            Dim f As New frmKumasKatalog()

            f.MdiParent = anaform
            f.FormShow(False)
            LoadingHide()
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem23_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem23.ItemClick
        Try
            LoadingShow()
            Dim f As New frmDigerKumaslar()

            f.MdiParent = anaform
            f.FormShow(False)
            LoadingHide()
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem24_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem24.ItemClick
        Try
            LoadingShow()
            Dim f As New frmOrguTipi()

            f.MdiParent = anaform
            f.FormShow_Lakos(False)
            LoadingHide()
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem25_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem25.ItemClick
        Try
            LoadingShow()
            Dim f As New frmKargolar()

            f.MdiParent = anaform
            f.FormShow(False)
            LoadingHide()
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem26_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem26.ItemClick
        Try
            LoadingShow()
            Dim f As New frmSaticilar()

            f.MdiParent = anaform
            f.FormShow(False)
            LoadingHide()
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem27_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem27.ItemClick
        Try
            LoadingShow()
            Dim f As New frmAlimIrsaliyeleri()

            f.MdiParent = anaform
            f.FormShow(False)
            LoadingHide()
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem28_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem28.ItemClick
        Try
            LoadingShow()
            Dim f As New frmHammaddeAyarlar()

            f.MdiParent = anaform
            f.FormShow()
            LoadingHide()
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem29_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem29.ItemClick
        Try
            LoadingShow()
            Dim f As New frmUsers()

            f.MdiParent = anaform
            f.FormShow(False)
            LoadingHide()
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmMainMenu_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub

    Private Sub frmMainMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Try
            Application.ExitThread()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub barItem_DovizKurlari_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barItem_DovizKurlari.ItemClick
        Try
            LoadingShow()
            Dim f As New frmDovizKurlari()

            f.MdiParent = anaform
            f.FormShow(False)
            LoadingHide()
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try
    End Sub

    Dim bDovizIndirildi As Boolean = False

    Private Sub frmMainMenu_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Try
            If (bDovizIndirildi = False) Then
                bDovizIndirildi = True
                LoadingShow("Doviz kurlari indiriliyor...")
                Dim tcmb As New TCMB_Doviz

                tcmb.DovizKuruAl()
                LoadingShow("Siparis dovizleri guncelleniyor...")
                Dim cmd As New SqlClient.SqlCommand

                cmd.Connection = AppConn.dbConn
                cmd.CommandText = "exec spAcikSiparisDovizleriniGuncelle"
                cmd.ExecuteNonQuery()

                LoadingHide()
            End If
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmMainMenu_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.T And e.Control And e.Alt Then
                LoadingShow()
                Dim f As New Form1()

                f.MdiParent = anaform
                f.Show()
                LoadingHide()
            End If
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem31_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem31.ItemClick
        Try
            LoadingShow()
            Dim f As New frmSipAlanlar()

            f.MdiParent = anaform
            f.FormShow(False)
            LoadingHide()
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem32_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem32.ItemClick
        Try
            LoadingShow()
            Dim f As New frmBoyahaneler()

            f.MdiParent = anaform
            f.FormShow(False)
            LoadingHide()
        Catch ex As Exception
            LoadingHide()
            MsgBox(ex.Message)
        End Try
    End Sub
End Class