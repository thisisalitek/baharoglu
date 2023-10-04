Public Class BaseControl


    Public KategoriID As Long
    Public KategoriKod As String
    Public KategoriParamID As Long

    Public SipDetayID As Long
    Public SipDetayParamID As Long

    Public bInitializing As Boolean = False
    ' Public bIntializing_appmode As Boolean = False

    Public Event IsOkay(ByVal sender As Control, ByRef e As IsOkayEventArgs)
    Public OkayControlMsg As String = ""

    Friend Event Save_Control(ByVal sender As Control, ByRef e As SaveEventArgs)
    Public bSecmeli As Boolean = False

    Dim Deleted_ As Boolean = False
    Dim oldHeight As Integer = 0
    Public ToplamAdet As Long = 0
    Public Bedenler As New ArrayList

    Public Property Deleted As Boolean
        Get
            Return Deleted_
        End Get
        Set(ByVal value As Boolean)
            If value Then
                Visible = False
            Else
                Visible = True
            End If

            Deleted_ = value

        End Set
    End Property

    Dim ApplicationMode_ As Boolean = False
    Public Property ApplicationMode As Boolean
        Get
            Return ApplicationMode_
        End Get
        Set(ByVal value As Boolean)
            ApplicationMode_ = value
            If DesignMode = True Then Exit Property
            If value = True Then
                XtraTabControl1.SelectedTabPageIndex = 1
                XtraTabControl1.TabPages(0).PageVisible = False
            Else
                XtraTabControl1.SelectedTabPageIndex = 0
                XtraTabControl1.TabPages(1).PageVisible = False
            End If
            XtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
        End Set
    End Property


    Dim MasrafListesi_ As New ArrayList
    Public Property MasrafListesi As ArrayList
        Get
            If bSecmeli And chkVar.Checked = False Then
                Return New ArrayList
            Else
                Return MasrafListesi_
            End If

        End Get
        Set(ByVal value As ArrayList)

            MasrafListesi_ = value
        End Set
    End Property

    Public Function Save() As Boolean

        Try
            If ApplicationMode = False Then
                If Deleted_ = True Then
                    MasterTable.Rows(MasterTable.Rows.Count - 1).Item("Deleted") = 1
                End If
                MasterTable.Save()

                If MasterTable.Rows.Count > 0 Then
                    KategoriParamID = If0Null(MasterTable.Rows(MasterTable.Rows.Count - 1).Item("KategoriParamID"))
                End If
            Else
                MasterTable2.Save()
                If MasterTable2.Rows.Count > 0 Then
                    SipDetayParamID = If0Null(MasterTable2.Rows(MasterTable2.Rows.Count - 1).Item("SipDetayParamID"))
                End If
            End If
            Dim e1 As New SaveEventArgs
            RaiseEvent Save_Control(Me, e1)
            If e1.Cancel = True Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Public Function IsOk() As Boolean
        Try
            If bSecmeli = True And chkVar.Checked = False Then
                Return True
            End If
            Dim e As New IsOkayEventArgs
            RaiseEvent IsOkay(Nothing, e)
            If e.Cancel = True Then
                OkayControlMsg = e.Message
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Public Event Initialize_Control(ByVal sender As Control, ByVal e As EventArgs)
    Public Event Initialize_Control_ForAppMode(ByVal sender As Control, ByVal e As EventArgs)


    Public Sub Initialize()

        Try
            KategoriKod = GetKategoriKod(AppConn.dbConn, KategoriID)
            bInitializing = True
            Dim e1 As New EventArgs

            If ApplicationMode = False Then
                chkSecmeli.Visible = True
                chkVar.Visible = False
            Else
                chkSecmeli.Visible = False
                chkVar.Visible = False

            End If

            If ApplicationMode = False Then
                MasterTable.Connection = Me.SqlConn
                MasterTable.SelectCommand.CommandText &= " AND KategoriParamID>0 AND KategoriParamID=" & KategoriParamID & " "
                OpenTable(MasterTable)
                If MasterTable.Rows.Count <= 0 Then
                    Dim newdr As DataRow = MasterTable.NewRow
                    newdr("KategoriID") = KategoriID
                    newdr("ParamType") = Me.Code
                    MasterTable.Rows.Add(newdr)
                    MasterTable.Save()
                End If
                RaiseEvent Initialize_Control(Me, e1)
            Else

                MasterTable.Connection = Me.SqlConn
                MasterTable.SelectCommand.CommandText &= " AND KategoriParamID=" & KategoriParamID & " "
                OpenTable(MasterTable)

                MasterTable2.Connection = Me.SqlConn
                MasterTable2.SelectCommand.CommandText &= " AND SipDetayID=" & SipDetayID & " AND KategoriParamID= " & KategoriParamID & " "
                OpenTable(MasterTable2)
                If MasterTable2.Rows.Count <= 0 Then
                    Dim newdr As DataRow = MasterTable2.NewRow
                    newdr("SipDetayID") = SipDetayID
                    newdr("KategoriParamID") = KategoriParamID
                    newdr("ParamType") = Me.Code
                    MasterTable2.Rows.Add(newdr)
                    MasterTable2.Save()
                End If
                SipDetayParamID = If0Null(MasterTable2.Rows(0).Item("SipDetayParamID"))

                If MasterTable.Rows.Count > 0 Then
                    If If0Null(MasterTable.Rows(0).Item("Secmeli")) = 1 Then
                        XtraTabControl1.Visible = False
                        chkVar.Visible = True
                        oldHeight = Me.Height
                        Me.Height = panelCaption.Height + 8
                        bSecmeli = True
                        'Debug.Print(Me.Code)
                        chkVar_CheckedChanged(Nothing, Nothing)
                    End If
                End If
                RaiseEvent Initialize_Control_ForAppMode(Me, e1)
            End If
            bInitializing = False
            Timer1.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        bInitializing = False
    End Sub

    Public Property Caption As String
        Get
            Return lblCaption.Text
        End Get
        Set(ByVal value As String)
            lblCaption.Text = value
        End Set
    End Property

    Dim Code_ As String = ""
    Public Property Code As String
        Get
            Return Code_
        End Get
        Set(ByVal value As String)
            Code_ = value
        End Set
    End Property



    Private Sub BaseControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        BaseControl_Resize(Nothing, Nothing)
        If DesignMode Then Exit Sub
        Try

        Catch ex As Exception
            MsgBox("(BaseControl_Load) " & ex.Message)
        End Try
    End Sub

    Private Sub BaseControl_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Try
            panelCaption.Top = 4
            panelCaption.Left = 4

            panelCaption.Width = Me.Width - 8
            XtraTabControl1.Top = panelCaption.Height + panelCaption.Top
            XtraTabControl1.Left = 4
            XtraTabControl1.Width = Me.Width - 8
            XtraTabControl1.Height = Me.Height - XtraTabControl1.Top - 4

            LabelControl1.Left = Me.Width - LabelControl1.Width
            LabelControl1.Top = Me.Height - LabelControl1.Height
        Catch ex As Exception

        End Try
    End Sub


    Private Sub MasterTable_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles MasterTable.ColumnChanged
        Try
            If bInitializing Then Exit Sub
            e.Row.EndEdit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MasterTable2_ColumnChanged(ByVal sender As Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles MasterTable2.ColumnChanged
        Try
            If bInitializing Then Exit Sub
            e.Row.EndEdit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
    End Sub


    Private Sub chkVar_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkVar.CheckedChanged
        Try
            If chkVar.Checked Then
                XtraTabControl1.Visible = True
                If oldHeight > 0 Then
                    Me.Height = oldHeight ' panelCaption.Height + XtraTabControl1.Height + 8
                End If
                RaiseEvent Initialize_Control_ForAppMode(sender, e)
            Else
                XtraTabControl1.Visible = False
                Me.Height = panelCaption.Height + 8
            End If
            BaseControl_Resize(Nothing, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Dim MouseX As Integer
    Dim MouseY As Integer
    Dim bMouseDown As Boolean = False

    Private Sub LabelControl1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LabelControl1.MouseDown

        MouseX = e.Location.X
        MouseY = e.Location.Y
        bMouseDown = True
    End Sub

    Private Sub LabelControl1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LabelControl1.MouseMove
        Try

            If e.Button = Windows.Forms.MouseButtons.Left Then
                LabelControl1.Left += e.X - MouseX
                LabelControl1.Top += e.Y - MouseY
                Me.Width += e.X - MouseX
                Me.Height += e.Y - MouseY
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LabelControl1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LabelControl1.MouseUp

        bMouseDown = False
        If Me.Width Mod 5 <> 0 Then
            Me.Width = Math.Round(Me.Width / 5, 0) * 5
        End If
        If Me.Height Mod 5 <> 0 Then
            Me.Height = Math.Round(Me.Height / 5, 0) * 5
        End If
        BaseControl_Resize(Nothing, Nothing)

    End Sub
End Class


Public Class IsOkayEventArgs
    Inherits EventArgs
    Public Cancel As Boolean
    Public Message As String
End Class
