Public Class cntUrunAgaci

    Public Event SelectedChanged(ByVal Sender As Object, ByVal e As UrunAgaciChangedEventArgs)

    Private Kopyala_KaynakKategoriID As Long

    Private _aktifKategori As New kategoriItem()
    Public Property aktifKategori() As kategoriItem
        Get
            Return _aktifKategori
        End Get
        Set(ByVal value As kategoriItem)
            _aktifKategori = value
        End Set
    End Property

    Private _contextMenu As New ContextMenuStrip()
    Public Property ContextAddMenu() As ContextMenuStrip
        Get
            Return _contextMenu
        End Get
        Set(ByVal value As ContextMenuStrip)
            _contextMenu = value

        End Set
    End Property

    Private _Editable As Boolean = True
    Public Property Editable() As Boolean
        Get
            Return _Editable
        End Get
        Set(ByVal value As Boolean)
            _Editable = value
            If value = False Then
                For i = 1 To ContextMenuStrip1.Items.Count - 1
                    ContextMenuStrip1.Items(i).Visible = False
                Next
            End If
        End Set
    End Property

    'Dim kategoriDT As New DataTable()

    'Private Sub load_kategoriDT()
    '    Try
    '        Dim cmd As New SqlClient.SqlCommand
    '        Dim da As SqlClient.SqlDataAdapter
    '        cmd.Connection = AppConn.dbConn
    '        cmd.CommandText = "Select *, (SELECT COUNT(*) FROM Kategoriler WHERE Deleted = 0 And UstKategoriID=K.KategoriID) as NodeCount  FROM Kategoriler K WHERE K.Deleted = 0 ORDER BY K.KategoriKod "
    '        da = New SqlClient.SqlDataAdapter(cmd)
    '        kategoriDT = New DataTable
    '        da.Fill(kategoriDT)
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Public Function findAndFocus(KategoriID As Long, Liste As ArrayList) As Long
        Try


            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As New DataTable()
            cmd.Connection = AppConn.dbConn
            cmd.Parameters.AddWithValue("@KategoriID", KategoriID)
            cmd.CommandText = "Select UstKategoriID  FROM Kategoriler K WHERE K.Deleted = 0 AND K.KategoriID=@KategoriID  "
            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If (dt.Rows.Count > 0) Then
                Dim UstKategoriID As Long = dt.Rows(0).Item("UstKategoriID")
                If (UstKategoriID = 0) Then
                    Liste.Add(KategoriID)
                    TreeView1.Nodes.Clear()
                    AddKategori(0, Nothing)
                    For Each node In TreeView1.Nodes
                        If KategoriID = CType(node.Tag, kategoriItem).KategoriID Then
                            siraliYukle(Liste.Count - 1, Liste, node)
                        End If
                    Next



                ElseIf UstKategoriID < 0 Then

                Else


                    Liste.Add(KategoriID)
                    findAndFocus(UstKategoriID, Liste)
                End If
            Else
                Return -1
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return -1
    End Function

    Private Sub siraliYukle(index As Long, Liste As ArrayList, ByRef node1 As TreeNode)
        If (index < 0) Then Return

        AddKategori(Liste(index), node1)

        If index > 0 Then
            For Each node In node1.Nodes
                If Liste(index - 1) = CType(node.Tag, kategoriItem).KategoriID Then
                    siraliYukle(index - 1, Liste, node)
                End If
            Next
        ElseIf index = 0 Then
            TreeView1.SelectedNode = node1
        End If

    End Sub

    Private Function loadKategoriDB(UstKategoriID As Long) As DataTable
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As New DataTable()
            cmd.Connection = AppConn.dbConn
            cmd.Parameters.AddWithValue("@UstKategoriID", UstKategoriID)
            cmd.CommandText = "Select *, (SELECT COUNT(*) FROM Kategoriler WHERE Deleted = 0 And UstKategoriID=K.KategoriID) as NodeCount  FROM Kategoriler K WHERE K.Deleted = 0 AND K.UstKategoriID=@UstKategoriID ORDER BY K.KategoriKod "
            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return New DataTable()
    End Function
    Private Sub cmdKategoriBul_Click(sender As Object, e As EventArgs) Handles cmdKategoriBul.Click
        Try
            If txtKategoriArama.Text.Trim() = "" Then Exit Sub

            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As New DataTable()
            cmd.Connection = AppConn.dbConn
            cmd.Parameters.AddWithValue("@Arama", "%" & txtKategoriArama.Text & "%")
            cmd.CommandText = "Select TOP 1 KategoriID,KategoriKod,KategoriIsim  FROM Kategoriler K WHERE K.Deleted = 0 AND (K.KategoriIsim Like @Arama )"
            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If (dt.Rows.Count > 0) Then
                Debug.WriteLine(dt.Rows(0).Item("KategoriKod") & " - " & dt.Rows(0).Item("KategoriIsim"))

                findAndFocus(dt.Rows(0).Item("KategoriID"), New ArrayList())
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub cntUrunAgaci_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try
            _contextMenu.AllowMerge = True
            ContextMenuStrip1.AllowMerge = True

            ' ContextMenuStrip1.Items.AddRange(_contextMenu.Items)
            If _contextMenu.Items.Count > 0 Then

                ContextMenuStrip1.Items.Add("-")
            End If
            Do While _contextMenu.Items.Count > 0
                Dim d = _contextMenu.Items(0)
                _contextMenu.Items.Remove(d)
                ContextMenuStrip1.Items.Add(d)
            Loop


            TreeView1.Nodes.Clear()
            AddKategori(0, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AddKategori(ByVal UstKategoriID As Long, ByRef Node1 As TreeNode)
        Try

            If Not Node1 Is Nothing Then
                If Node1.Nodes.Count > 0 Then
                    Node1.Nodes.Clear()
                End If
            End If
            Dim focusnode As TreeNode = Nothing

            'Dim dt = (From kat In kategoriDT.Rows Where kat("UstKategoriID") = UstKategoriID).ToList()
            Dim dt As DataTable = loadKategoriDB(UstKategoriID)

            For Each dr As DataRow In dt.Rows
                Dim newnode As TreeNode
                If Node1 Is Nothing Then
                    newnode = TreeView1.Nodes.Add(IfNull(dr("KategoriKod"), ""), IfNull(dr("KategoriKod"), "") & " - " & IfNull(dr("KategoriIsim"), ""))
                Else
                    newnode = Node1.Nodes.Add(IfNull(dr("KategoriKod"), ""), IfNull(dr("KategoriKod"), "") & " - " & IfNull(dr("KategoriIsim"), ""))
                End If

                Dim bKategori As Boolean = False

                If (CType(dr("NodeCount"), Int32) > 0) Then
                    bKategori = True
                    newnode.ImageIndex = 0
                    newnode.SelectedImageIndex = 0
                Else
                    bKategori = False
                    newnode.ImageIndex = 1
                    newnode.SelectedImageIndex = 1
                    If If0Null(dr("KendiFiyatBedenKullan")) = 1 Or If0Null(dr("KendiMasrafKullan")) = 1 Then
                        newnode.ForeColor = Color.Blue
                    End If
                End If


                newnode.Tag = New kategoriItem(If0Null(dr("UstKategoriID")), If0Null(dr("KategoriID")), If0Null(dr("KendiFiyatBedenKullan")), If0Null(dr("KendiMasrafKullan")), bKategori, IfNull(dr("KategoriKod"), ""), IfNull(dr("KategoriIsim"), ""))
                'AddKategori(If0Null(dr("KategoriID")), newnode)


                If aktifKategori.KategoriID > 0 Then
                    If CType(newnode.Tag, kategoriItem).KategoriID = aktifKategori.KategoriID Then
                        focusnode = newnode
                    End If
                End If
            Next

            'If aktifKategori.KategoriID > 0 Then
            '    TreeView1.SelectedNode = focusnode
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function seciliNodeYenilensinMi(node As TreeNode)
        Try
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = AppConn.dbConn
            cmd.Parameters.AddWithValue("@UstKategoriID", CType(node.Tag, kategoriItem).KategoriID)
            cmd.CommandText = "Select COUNT(*)  FROM Kategoriler K WHERE K.Deleted = 0 AND K.UstKategoriID=@UstKategoriID "
            If (cmd.ExecuteScalar() <> node.Nodes.Count) Then
                Return True
            Else
                Return False
            End If




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        Try
            If TreeView1.SelectedNode Is Nothing Then Exit Sub
            txtAktifKategori.Text = TreeView1.SelectedNode.Text
            aktifKategori = CType(TreeView1.SelectedNode.Tag, kategoriItem)
            If (TreeView1.SelectedNode.Nodes.Count = 0 And aktifKategori.bKategori) Then
                AddKategori(aktifKategori.KategoriID, TreeView1.SelectedNode)
                'ElseIf TreeView1.SelectedNode.Nodes.Count > 0 Then
                '    If seciliNodeYenilensinMi(TreeView1.SelectedNode) Then
                '        AddKategori(aktifKategori.KategoriID, TreeView1.SelectedNode)
                '    End If
            End If

                Dim e1 As New UrunAgaciChangedEventArgs
            e1.ActifKategori = aktifKategori
            RaiseEvent SelectedChanged(Me, e1)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        If (e.Button = MouseButtons.Right) Then TreeView1.SelectedNode = e.Node
    End Sub

    Private Sub YenileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YenileToolStripMenuItem.Click
        Try
            TreeView1.SelectedNode.Nodes.Clear()

            AddKategori(CType(TreeView1.SelectedNode.Tag, kategoriItem).KategoriID, TreeView1.SelectedNode)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RootKategoriEkleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RootKategoriEkleToolStripMenuItem.Click
        Try
            Dim f As New frmKategoriItem
            With f

                .FormNew(0)
                If .DialogResult = Windows.Forms.DialogResult.OK Then
                    TreeView1.Nodes.Clear()
                    AddKategori(0, Nothing)
                End If
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AltKodEkleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltKodEkleToolStripMenuItem.Click
        Try
            If TreeView1.SelectedNode Is Nothing Then Exit Sub
            If TreeView1.SelectedNode.Tag Is Nothing Then Exit Sub
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "SELECT COUNT(*) FROM Kategoriler WHERE Deleted = 0 AND KategoriID=" & CType(TreeView1.SelectedNode.Tag, kategoriItem).KategoriID
            If cmd.ExecuteScalar() = 0 Then
                MsgBox("Kategori baska bir kullanici tarafindan silinmis. Kategorileri tazeleyiniz!")
                Exit Sub

            End If

            Dim f As New frmKategoriItem
            With f


                .FormNew(CType(TreeView1.SelectedNode.Tag, kategoriItem).KategoriID)
                If .DialogResult = Windows.Forms.DialogResult.OK Then
                    'RefreshList(True)
                    'load_kategoriDT()
                    AddKategori(CType(TreeView1.SelectedNode.Tag, kategoriItem).KategoriID, TreeView1.SelectedNode)

                End If
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuDuzelt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDuzelt.Click
        Try

            If TreeView1.SelectedNode Is Nothing Then Exit Sub
            If TreeView1.SelectedNode.Tag Is Nothing Then Exit Sub
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "SELECT COUNT(*) FROM Kategoriler WHERE Deleted = 0 AND KategoriID=" & CType(TreeView1.SelectedNode.Tag, kategoriItem).KategoriID
            If cmd.ExecuteScalar() = 0 Then
                MsgBox("Kategori baska bir kullanici tarafindan silinmis. Kategorileri tazeleyiniz!")
                Exit Sub

            End If
            Dim f As New frmKategoriItem
            With f

                .FormEdit(CType(TreeView1.SelectedNode.Tag, kategoriItem).KategoriID)
                If .DialogResult = Windows.Forms.DialogResult.OK Then

                    If Not TreeView1.SelectedNode.Parent Is Nothing Then

                        AddKategori(CType(TreeView1.SelectedNode.Parent.Tag, kategoriItem).KategoriID, TreeView1.SelectedNode.Parent)

                    End If


                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SilToolStripMenuItem.Click
        Try
            If TreeView1.SelectedNode Is Nothing Then Exit Sub
            If TreeView1.SelectedNode.Tag Is Nothing Then Exit Sub

            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "SELECT     COUNT(*)  FROM Kategoriler WHERE Deleted = 0 And (UstKategoriID = " & CType(TreeView1.SelectedNode.Tag, kategoriItem).KategoriID & ")"
            If cmd.ExecuteScalar > 0 Then
                MsgBox("Kategori alt hesaplara sahip. Öncelikle alt hesapları silmelisiniz!")
                Exit Sub
            End If
            cmd.CommandText = "SELECT     COUNT(*)  FROM SipDetay WHERE     (Deleted = 0) And (KategoriID = " & CType(TreeView1.SelectedNode.Tag, kategoriItem).KategoriID & ")"
            If cmd.ExecuteScalar > 0 Then
                MsgBox("Bu kategori siparişlere bağlı. Silemezsiniz!")
                Exit Sub
            End If
            If MsgBox("Kategoriyi silmek istediğinizden emin misiniz?", MsgBoxStyle.Critical + MsgBoxStyle.YesNoCancel, "Sil?") <> MsgBoxResult.Yes Then Exit Sub

            cmd.CommandText = "UPDATE Kategoriler SET Deleted = KategoriID , ModifiedBy=" & AppConn.ActiveUser.UserID & " , ModifiedDate=GETDATE()   WHERE (KategoriID = " & CType(TreeView1.SelectedNode.Tag, kategoriItem).KategoriID & ") "
            cmd.ExecuteNonQuery()
            TreeView1.SelectedNode.Remove()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuKategoriOzellikKopyala_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuKategoriOzellikKopyala.Click
        Try
            If TreeView1.SelectedNode Is Nothing Then Exit Sub
            If TreeView1.SelectedNode.Tag Is Nothing Then Exit Sub
            Kopyala_KaynakKategoriID = CType(TreeView1.SelectedNode.Tag, kategoriItem).KategoriID

            mnuKategoriOzellikYapistir.Text = "Özellikleri Yapıştır (" & TreeView1.SelectedNode.Text & ")"
            mnuKategoriOzellikYapistir.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuKategoriOzellikYapistir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuKategoriOzellikYapistir.Click
        Try
            If TreeView1.SelectedNode Is Nothing Then Exit Sub
            If TreeView1.SelectedNode.Tag Is Nothing Then Exit Sub
            If Kopyala_KaynakKategoriID = CType(TreeView1.SelectedNode.Tag, kategoriItem).KategoriID Then
                MsgBox("Aynı kategoriyi yapıştıramazsınız.")
                Exit Sub
            End If
            Dim HedefKategoriID As Long = CType(TreeView1.SelectedNode.Tag, kategoriItem).KategoriID
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = AppConn.dbConn
            cmd.CommandText = "SELECT COUNT(*) FROM SipDetay WHERE Deleted = 0 AND KategoriID = " & HedefKategoriID
            If cmd.ExecuteScalar > 0 Then
                MsgBox("Hedef kategoriye sipariş alınmış! Özellik kopyalayamazsınız!")
                Exit Sub
            End If

            If (CopyKategori(AppConn.dbConn, Kopyala_KaynakKategoriID, HedefKategoriID, AppConn.ActiveUser.UserID)) Then
                MsgBox("Kopyalama tamam.")
            Else
                MsgBox("Kopyalama basarisiz :-(")
            End If

            TreeView1_AfterSelect(Nothing, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtKategoriArama_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKategoriArama.KeyDown
        If e.KeyCode = Keys.Return Then
            cmdKategoriBul_Click(Nothing, Nothing)
        End If
    End Sub


End Class

Public Class UrunAgaciChangedEventArgs
    Inherits System.EventArgs
    Public ActifKategori As kategoriItem

End Class