Public Class PiconnLanguage

    Dim WritingMode As Boolean = False               'normalde false, komponent toplama modunda True olacak


    Public LanguageDB As DataTable
    Public CustomizedLanguageDB As DataTable

    'Dim mVar_FormCode As String = ""
    'Public Property FormCode() As String
    '    Get
    '        Return mVar_FormCode
    '    End Get
    '    Set(ByVal value As String)
    '        mVar_FormCode = value
    '    End Set
    'End Property

    Dim mVar_Language As String = ""
    Public Property Language() As String
        Get
            Return mVar_Language
        End Get
        Set(ByVal value As String)
            mVar_Language = value
        End Set
    End Property

    Dim mVar_Assembly As System.Reflection.Assembly
    Public Property Assembly() As System.Reflection.Assembly
        Get
            Return mVar_Assembly
        End Get
        Set(ByVal value As System.Reflection.Assembly)
            mVar_Assembly = value
        End Set
    End Property

    Public Sub New()
        mVar_Language = "TR"
    End Sub

    Public Sub New(ByVal Language_ As String)
        'mVar_FormCode = FormCode_
        mVar_Language = Language_
    End Sub

    Public Function Save(ByVal mVar_FormCode As String, ByVal ct As Control, ByVal Text As String, Optional ByVal Language As String = "DefaultText") As Boolean
        Try
            
            Dim ComponentName As String = ct.Name
            Dim ComponentType As String = ct.GetType.ToString
            Dim ConnComponentName As String = ""
            If Not ct.Parent Is Nothing Then
                ConnComponentName = ct.Parent.Name
            End If
            Return Save(mVar_FormCode, ComponentName, ComponentType, Text, Language, ConnComponentName)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Dim Conn As New SqlClient.SqlConnection
    Public Property Connection() As SqlClient.SqlConnection
        Get
            Return Conn
        End Get
        Set(ByVal value As SqlClient.SqlConnection)
            Conn = value
        End Set
    End Property

    Public Function Save(ByVal mVar_FormCode As String, ByVal ComponentName As String, ByVal ComponentType As String, ByVal Text As String, Optional ByVal Language As String = "DefaultText", Optional ByVal ConnComponentName As String = "") As Boolean
        Try

            If Language = "" Then
                Language = "DefaultText"
            End If

            Dim cmd As New SqlClient.SqlCommand
            If Conn.State <> ConnectionState.Open Then
                Conn = New SqlClient.SqlConnection("Server=.;Database=LANGUAGE;User ID=sa;Password=axj5l8hc;Trusted_Connection=No;")
                Conn.Open()
            End If
            cmd.Connection = Conn
            cmd.CommandText = "DECLARE @ComponentID INT " & vbNewLine
            cmd.CommandText &= "DECLARE @ConnComponentID INT " & vbNewLine
            cmd.CommandText &= "SET @ComponentID = 0 " & vbNewLine
            cmd.CommandText &= "SET @ConnComponentID = 0 " & vbNewLine
            If ConnComponentName <> "" Then
                cmd.CommandText &= "SELECT TOP 1 @ConnComponentID=ComponentID FROM  langPiconnCevahir WHERE FormCode='" & mVar_FormCode & "' AND ComponentName='" & ConnComponentName & "' " & vbNewLine
            End If
            cmd.CommandText &= "SELECT TOP 1 @ComponentID=ComponentID FROM  langPiconnCevahir WHERE FormCode='" & mVar_FormCode & "' AND ComponentName='" & ComponentName & "' " & vbNewLine
            cmd.CommandText &= "IF ISNULL(@ComponentID,0)<=0 BEGIN  " & vbNewLine
            cmd.CommandText &= "INSERT INTO langPiconnCevahir (FormCode, ComponentType, ComponentName, ConnComponentID, ConnComponentName, " & Language & ") " & vbNewLine
            cmd.CommandText &= "VALUES ('" & mVar_FormCode & "','" & ComponentType & "','" & ComponentName & "', @ConnComponentID, '" & ConnComponentName & "', '" & Replace(Text, "'", "''") & "') " & vbNewLine
            cmd.CommandText &= "END ELSE BEGIN " & vbNewLine
            cmd.CommandText &= "UPDATE langPiconnCevahir SET ComponentType = '" & ComponentType & "' ," & Language & " = '" & Replace(Text, "'", "''") & "' WHERE ComponentID=@ComponentID "
            cmd.CommandText &= "END" & vbNewLine
            If cmd.ExecuteNonQuery() > 0 Then
                cmd.Dispose()
                Return True
            End If
            cmd.Dispose()

            Return False
        Catch ex As Exception
            MsgBox("(PiconnLanguage.Save) " & ex.Message)
        End Try
    End Function

    Public Function Read(ByVal mVar_FormCode As String, ByVal ct As Control, Optional ByVal DefaultText As String = "", Optional ByVal Language As String = "DefaultText") As String
        Try
            Dim ComponentName As String = ct.Name

            Return Read(mVar_FormCode, ComponentName, DefaultText, Language)
        Catch ex As Exception
            MsgBox("(PiconnLanguage.Save) " & ex.Message)
        End Try
        Return DefaultText
    End Function

    'Public Function Read(ByVal ComponentName As String, Optional ByVal DefaultText As String = "", Optional ByVal Language As String = "DefaultText") As String
    '    Try

    '        If Language = "" Then
    '            Language = "DefaultText"
    '        End If
    '        Dim cmd As New Devart.Data.SqlServer.SqlCommand
    '        Dim Conn As New Devart.Data.SqlServer.SqlConnection("Server=.;Database=LANGUAGE;User ID=sa;Password=axj5l8hc;Trusted_Connection=No;")
    '        Dim da As Devart.Data.SqlServer.SqlDataAdapter
    '        Dim dt As DataTable
    '        Dim sText As String = ""
    '        Dim bFound As Boolean = False

    '        cmd.Connection = Conn
    '        cmd.CommandText = "SELECT TOP 1 " & Language & " as sText FROM  langPiconnCevahir WHERE FormCode='" & mVar_FormCode & "' AND ComponentName='" & ComponentName & "' "
    '        da = New Devart.Data.SqlServer.SqlDataAdapter(cmd)
    '        dt = New DataTable
    '        da.Fill(dt)
    '        If dt.Rows.Count > 0 Then
    '            bFound = True
    '            sText = IfNull(dt.Rows(0).Item("sText"), "")
    '        End If
    '        dt.Dispose()
    '        da.Dispose()
    '        If bFound = False Then
    '            sText = DefaultText
    '        End If

    '        cmd.Dispose()
    '        Conn.Close()
    '        Return sText
    '    Catch ex As Exception
    '        MsgBox("(PiconnLanguage.Save) " & ex.Message)
    '    End Try
    '    Return DefaultText
    'End Function

    Public Function Read(ByVal mVar_FormCode As String, ByVal ComponentName As String, Optional ByVal DefaultText As String = "", Optional ByVal Language As String = "DefaultText", Optional ByVal bText As Boolean = False) As String
        Try
            Dim sFormCode As String = mVar_FormCode
            If bText Then sFormCode = "Text"

            If Language = "" Then
                Language = "DefaultText"
            End If
            If LanguageDB Is Nothing And CustomizedLanguageDB Is Nothing Then
                Return DefaultText
            End If

            Dim drList As DataRow()
            drList = CustomizedLanguageDB.Select("FormCode='" & sFormCode & "' AND ComponentName='" & Replace(ComponentName, "'", "''") & "'")
            If drList.Length <= 0 Then
                drList = LanguageDB.Select("FormCode='" & sFormCode & "' AND ComponentName='" & Replace(ComponentName, "'", "''") & "'")
            End If
            If drList.Length <= 0 Then
                Return DefaultText
            End If
            If LanguageDB.Columns.Contains(Language) Then

               
                If IfNull(drList(drList.Length - 1)(Language), "") = "" Then
                    Return DefaultText
                ElseIf IfNull(drList(drList.Length - 1)(Language), "") = "#ERROR#" Then
                    Return "#" & DefaultText
                Else

                    Return IfNull(drList(drList.Length - 1)(Language), "")
                End If

            End If
            Return DefaultText
        Catch ex As Exception
            MsgBox("(PiconnLanguage.Read) " & ex.Message)
        End Try
        Return DefaultText
    End Function


    Public Sub WalkInControl(ByVal mVar_FormCode As String, ByRef xControl As Control)
        Exit Sub
        'WritingMode = True
        Dim AlignRight As Boolean = False
        If mVar_Language Is Nothing Then Exit Sub
        Select Case mVar_Language
            Case "IR", "SA", "IL"
                AlignRight = True
        End Select

        'EXCEPTIONS
        If mVar_FormCode = "frmLogin" And xControl.Name = "cboLanguage" Then
            Exit Sub
        End If

        If TypeOf xControl Is Form Or TypeOf xControl Is DevExpress.XtraEditors.XtraForm Then

            If WritingMode = True Then
                Save(mVar_FormCode, xControl, xControl.Text)
            Else
                xControl.Text = Read(mVar_FormCode, xControl, xControl.Text, mVar_Language)
            End If
        End If

        Dim ct As Control

        For Each ct In xControl.Controls
            If TypeOf ct Is Form Then
                If WritingMode = True Then
                    Save(mVar_FormCode, ct, CType(ct, Form).Text)
                Else
                    CType(ct, Form).Text = Read(mVar_FormCode, ct, CType(ct, Form).Text, mVar_Language)
                End If

            End If

            If TypeOf ct Is Button Then
                If CType(ct, Button).Tag = "" Then
                    If WritingMode = True Then
                        Save(mVar_FormCode, ct, CType(ct, Button).Text)
                    Else
                        CType(ct, Button).Text = Read(mVar_FormCode, ct, CType(ct, Button).Text, mVar_Language)
                    End If


                End If
            End If

            If TypeOf ct Is DevExpress.XtraEditors.ImageComboBoxEdit Then
                Dim icb As DevExpress.XtraEditors.ImageComboBoxEdit = CType(ct, DevExpress.XtraEditors.ImageComboBoxEdit)
                For i As Integer = 0 To icb.Properties.Items.Count - 1
                    'icb.Properties.Items(i).Description = GeriDon(m_Form, m_Lang, CStr(icb.Properties.Items(i).Value) + icb.Name)

                    If WritingMode = True Then
                        Save(mVar_FormCode, ct.Name & ".Properties.Items." & icb.Properties.Items(i).Description, icb.Properties.Items(i).GetType.ToString, icb.Properties.Items(i).Description)
                    Else
                        icb.Properties.Items(i).Description = Read(mVar_FormCode, ct.Name & ".Properties.Items." & icb.Properties.Items(i).Description, icb.Properties.Items(i).Description, mVar_Language)
                    End If


                Next
                If AlignRight Then
                    icb.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                    icb.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                End If
            ElseIf TypeOf ct Is DevExpress.XtraEditors.ComboBoxEdit Then
                'Dim icb As DevExpress.XtraEditors.ComboBoxEdit = CType(ct, DevExpress.XtraEditors.ComboBoxEdit)
                'For i As Integer = 0 To icb.Properties.Items.Count - 1
                '    'icb.Properties.Items(i).Description = GeriDon(m_Form, m_Lang, CStr(icb.Properties.Items(i).Value) + icb.Name)

                '    If WritingMode = True Then
                '        Save(mVar_FormCode, ct.Name & ".Properties.Items." & icb.Properties.Items(i).ToString, icb.Properties.Items(i).GetType.ToString, icb.Properties.Items(i).ToString)
                '    Else
                '        icb.Properties.Items(i) = Read(mVar_FormCode, ct.Name & ".Properties.Items" & icb.Properties.Items(i).ToString, icb.Properties.Items(i).ToString, mVar_Language)
                '    End If


                'Next
                'If AlignRight Then
                '    icb.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                '    icb.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                'End If
            ElseIf TypeOf ct Is DevExpress.XtraEditors.LookUpEdit Then

                'If WritingMode = True Then
                '    Save(mVar_FormCode, CType(ct, DevExpress.XtraEditors.LookUpEdit).Name & ".Properties.NullText", CType(ct, DevExpress.XtraEditors.LookUpEdit).GetType.ToString, CType(ct, DevExpress.XtraEditors.LookUpEdit).Properties.NullText)
                'Else
                '    CType(ct, DevExpress.XtraEditors.LookUpEdit).Properties.NullText = Read(mVar_FormCode, CType(ct, DevExpress.XtraEditors.LookUpEdit).Name & ".Properties.NullText", CType(ct, DevExpress.XtraEditors.LookUpEdit).Properties.NullText, mVar_Language)
                'End If

                'For i As Integer = 0 To CType(ct, DevExpress.XtraEditors.LookUpEdit).Properties.Columns.Count - 1
                '    'CType(ct, DevExpress.XtraEditors.LookUpEdit).Properties.Columns(i).Caption = GeriDon(m_Form, m_Lang, CType(ct, DevExpress.XtraEditors.LookUpEdit).Properties.Columns(i).FieldName)
                '    If WritingMode = True Then
                '        Save(mVar_FormCode, CType(ct, DevExpress.XtraEditors.LookUpEdit).Properties.Columns(i).FieldName, CType(ct, DevExpress.XtraEditors.LookUpEdit).Properties.Columns(i).GetType.ToString, CType(ct, DevExpress.XtraEditors.LookUpEdit).Properties.Columns(i).Caption)
                '    Else
                '        CType(ct, DevExpress.XtraEditors.LookUpEdit).Properties.Columns(i).Caption = Read(mVar_FormCode, CType(ct, DevExpress.XtraEditors.LookUpEdit).Properties.Columns(i).FieldName, CType(ct, DevExpress.XtraEditors.LookUpEdit).Properties.Columns(i).Caption, mVar_Language)
                '    End If

                'Next

                'If AlignRight Then CType(ct, DevExpress.XtraEditors.LookUpEdit).Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                'If AlignRight Then CType(ct, DevExpress.XtraEditors.LookUpEdit).Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far

            ElseIf TypeOf ct Is DevExpress.XtraEditors.GridLookUpEdit Then

                'If WritingMode = True Then
                '    Save(mVar_FormCode, CType(ct, DevExpress.XtraEditors.GridLookUpEdit).Name & ".Properties.NullText", CType(ct, DevExpress.XtraEditors.GridLookUpEdit).GetType.ToString, CType(ct, DevExpress.XtraEditors.GridLookUpEdit).Properties.NullText)
                'Else
                '    CType(ct, DevExpress.XtraEditors.GridLookUpEdit).Properties.NullText = Read(mVar_FormCode, CType(ct, DevExpress.XtraEditors.GridLookUpEdit).Name & ".Properties.NullText", CType(ct, DevExpress.XtraEditors.GridLookUpEdit).Properties.NullText, mVar_Language)
                'End If



                'If AlignRight Then CType(ct, DevExpress.XtraEditors.GridLookUpEdit).Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                'If AlignRight Then CType(ct, DevExpress.XtraEditors.GridLookUpEdit).Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far

            ElseIf TypeOf ct Is DevExpress.XtraEditors.TextEdit Then
                If WritingMode = True Then
                    Save(mVar_FormCode, ct, CType(ct, DevExpress.XtraEditors.TextEdit).Text)
                Else
                    CType(ct, DevExpress.XtraEditors.TextEdit).Text = Read(mVar_FormCode, ct, CType(ct, DevExpress.XtraEditors.TextEdit).Text, mVar_Language)
                End If
                If AlignRight Then CType(ct, DevExpress.XtraEditors.TextEdit).Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            ElseIf TypeOf ct Is DevExpress.XtraEditors.MemoEdit Then
                If WritingMode = True Then
                    Save(mVar_FormCode, ct, CType(ct, DevExpress.XtraEditors.MemoEdit).Text)
                Else
                    CType(ct, DevExpress.XtraEditors.MemoEdit).Text = Read(mVar_FormCode, ct, CType(ct, DevExpress.XtraEditors.MemoEdit).Text, mVar_Language)
                End If
                If AlignRight Then CType(ct, DevExpress.XtraEditors.MemoEdit).Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            End If

            If TypeOf ct Is DevExpress.XtraEditors.GroupControl Then
                If WritingMode = True Then
                    Save(mVar_FormCode, ct, CType(ct, DevExpress.XtraEditors.GroupControl).Text)
                Else
                    CType(ct, DevExpress.XtraEditors.GroupControl).Text = Read(mVar_FormCode, ct, CType(ct, DevExpress.XtraEditors.GroupControl).Text, mVar_Language)
                End If

            End If

            If TypeOf ct Is DevExpress.XtraGrid.GridControl Then
                Dim gc As DevExpress.XtraGrid.GridControl = CType(ct, DevExpress.XtraGrid.GridControl)

                For i As Integer = 0 To gc.Views.Count - 1
                    If TypeOf gc.Views(i) Is DevExpress.XtraGrid.Views.Grid.GridView Then
                        Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = CType(gc.ViewCollection.Item(0), DevExpress.XtraGrid.Views.Grid.GridView)
                        With CType(ct, DevExpress.XtraGrid.GridControl).EmbeddedNavigator.Buttons
                            If WritingMode = True Then
                                Save(mVar_FormCode, ct.Name & ".EmbeddedNavigator.Buttons.Append", .Append.ButtonType.ToString, .Append.Hint)
                            Else
                                .Append.Hint = Read(mVar_FormCode, ct.Name & ".EmbeddedNavigator.Buttons.Append", .Append.Hint, mVar_Language)
                            End If

                            If WritingMode = True Then
                                Save(mVar_FormCode, ct.Name & ".EmbeddedNavigator.Buttons.CancelEdit", .CancelEdit.ButtonType.ToString, .CancelEdit.Hint)
                            Else
                                .CancelEdit.Hint = Read(mVar_FormCode, ct.Name & ".EmbeddedNavigator.Buttons.CancelEdit", .CancelEdit.Hint, mVar_Language)
                            End If

                            If WritingMode = True Then
                                Save(mVar_FormCode, ct.Name & ".EmbeddedNavigator.Buttons.Edit", .Edit.ButtonType.ToString, .Edit.Hint)
                            Else
                                .Edit.Hint = Read(mVar_FormCode, ct.Name & ".EmbeddedNavigator.Buttons.Edit", .Edit.Hint, mVar_Language)
                            End If

                            If WritingMode = True Then
                                Save(mVar_FormCode, ct.Name & ".EmbeddedNavigator.Buttons.EndEdit", .EndEdit.ButtonType.ToString, .EndEdit.Hint)
                            Else
                                .EndEdit.Hint = Read(mVar_FormCode, ct.Name & ".EmbeddedNavigator.Buttons.EndEdit", .EndEdit.Hint, mVar_Language)
                            End If

                            If WritingMode = True Then
                                Save(mVar_FormCode, ct.Name & ".EmbeddedNavigator.Buttons.First", .First.ButtonType.ToString, .First.Hint)
                            Else
                                .First.Hint = Read(mVar_FormCode, ct.Name & ".EmbeddedNavigator.Buttons.First", .First.Hint, mVar_Language)
                            End If

                            If WritingMode = True Then
                                Save(mVar_FormCode, ct.Name & ".EmbeddedNavigator.Buttons.Last", .Last.ButtonType.ToString, .Last.Hint)
                            Else
                                .Last.Hint = Read(mVar_FormCode, ct.Name & ".EmbeddedNavigator.Buttons.Last", .Last.Hint, mVar_Language)
                            End If

                            If WritingMode = True Then
                                Save(mVar_FormCode, ct.Name & ".EmbeddedNavigator.Buttons.Next", .Next.ButtonType.ToString, .Next.Hint)
                            Else
                                .Next.Hint = Read(mVar_FormCode, ct.Name & ".EmbeddedNavigator.Buttons.Next", .Next.Hint, mVar_Language)
                            End If

                            If WritingMode = True Then
                                Save(mVar_FormCode, ct.Name & ".EmbeddedNavigator.Buttons.NextPage", .NextPage.ButtonType.ToString, .NextPage.Hint)
                            Else
                                .NextPage.Hint = Read(mVar_FormCode, ct.Name & ".EmbeddedNavigator.Buttons.NextPage", .NextPage.Hint, mVar_Language)
                            End If

                            If WritingMode = True Then
                                Save(mVar_FormCode, ct.Name & ".EmbeddedNavigator.Buttons.Prev", .Prev.ButtonType.ToString, .Prev.Hint)
                            Else
                                .Prev.Hint = Read(mVar_FormCode, ct.Name & ".EmbeddedNavigator.Buttons.Prev", .Prev.Hint, mVar_Language)
                            End If

                            If WritingMode = True Then
                                Save(mVar_FormCode, ct.Name & ".EmbeddedNavigator.Buttons.PrevPage", .PrevPage.ButtonType.ToString, .PrevPage.Hint)
                            Else
                                .PrevPage.Hint = Read(mVar_FormCode, ct.Name & ".EmbeddedNavigator.Buttons.PrevPage", .PrevPage.Hint, mVar_Language)
                            End If

                            If WritingMode = True Then
                                Save(mVar_FormCode, ct.Name & ".EmbeddedNavigator.Buttons.Remove", .Remove.ButtonType.ToString, .Remove.Hint)
                            Else
                                .Remove.Hint = Read(mVar_FormCode, ct.Name & ".EmbeddedNavigator.Buttons.Remove", .Remove.Hint, mVar_Language)
                            End If


                        End With

                        If WritingMode = True Then
                            Save(mVar_FormCode, ct.Name & ".GroupPanelText", ct.GetType.ToString & ".GroupPanelText", gv.GroupPanelText)
                        Else
                            gv.GroupPanelText = Read(mVar_FormCode, ct.Name & ".GroupPanelText", gv.GroupPanelText, mVar_Language)
                        End If

                        If WritingMode = True Then
                            Save(mVar_FormCode, ct.Name & ".NewItemRowText", ct.GetType.ToString & ".NewItemRowText", gv.NewItemRowText)
                        Else
                            gv.NewItemRowText = Read(mVar_FormCode, ct.Name & ".NewItemRowText", gv.NewItemRowText, mVar_Language)
                        End If


                        For Each col As DevExpress.XtraGrid.Columns.GridColumn In gv.Columns
                            If WritingMode = True Then
                                Save(mVar_FormCode, col.Name, col.GetType.ToString, col.Caption)
                            Else
                                col.Caption = Read(mVar_FormCode, col.Name, col.Caption, mVar_Language)
                            End If
                            If AlignRight Then col.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far


                        Next
                    ElseIf 1 = 1 Then
                    End If
                Next

            End If

            If TypeOf ct Is DevExpress.XtraNavBar.NavBarControl Then
                Dim nb As DevExpress.XtraNavBar.NavBarControl = CType(ct, DevExpress.XtraNavBar.NavBarControl)
                For i As Integer = 0 To nb.Groups.Count - 1
                    If TypeOf nb.Groups(i) Is DevExpress.XtraNavBar.NavBarGroup Then
                        Dim ni As DevExpress.XtraNavBar.NavBarGroup = CType(nb.Groups(i), DevExpress.XtraNavBar.NavBarGroup)

                        If WritingMode = True Then
                            Save(mVar_FormCode, ni.Name, ni.GetType.ToString, ni.Caption)
                        Else
                            ni.Caption = Read(mVar_FormCode, ni.Name, ni.Caption, mVar_Language)
                        End If

                        For d As Integer = 0 To ni.ItemLinks.Count - 1

                            If WritingMode = True Then
                                Save(mVar_FormCode, ni.ItemLinks(d).Item.Name, ni.ItemLinks(d).Item.GetType.ToString, ni.ItemLinks(d).Item.Caption)
                            Else
                                ni.ItemLinks(d).Item.Caption = Read(mVar_FormCode, ni.ItemLinks(d).Item.Name, ni.ItemLinks(d).Item.Caption, mVar_Language)
                            End If

                        Next
                    End If
                Next
            End If

            If TypeOf ct Is DevExpress.XtraDataLayout.DataLayoutControl Then
                Dim dl As DevExpress.XtraDataLayout.DataLayoutControl = CType(ct, DevExpress.XtraDataLayout.DataLayoutControl)
                If Not dl.Root Is Nothing Then
                    For i As Integer = 0 To dl.Root.Items.Count - 1
                        If TypeOf dl.Root.Item(i) Is DevExpress.XtraLayout.LayoutControlGroup Then

                            For d As Integer = 0 To CType(dl.Root(i), DevExpress.XtraLayout.LayoutControlGroup).Items.Count - 1
                                Dim itm As DevExpress.XtraLayout.LayoutControlItem = CType(dl.Root(i), DevExpress.XtraLayout.LayoutControlGroup).Items(d)

                                'itm.Items.Item(d).Text = GeriDon(m_Form, m_Lang, CType(dl.Root.Item(i), DevExpress.XtraLayout.LayoutControlGroup).Items.Item(d).Name)
                                'itm.Items.Item(d).CustomizationFormText = GeriDon(m_Form, m_Lang, CType(dl.Root.Item(i), DevExpress.XtraLayout.LayoutControlGroup).Items.Item(d).Name)

                                If WritingMode = True Then

                                    Save(mVar_FormCode, itm.Name, itm.GetType.ToString, itm.Text)
                                Else
                                    itm.Text = Read(mVar_FormCode, itm.Name, itm.Text, mVar_Language)
                                End If
                                If AlignRight Then itm.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far

                            Next
                        Else

                            If TypeOf dl.Root.Item(i) Is DevExpress.XtraLayout.LayoutControlItem Then

                                If WritingMode = True Then
                                    Save(mVar_FormCode, dl.Root.Item(i).Name, dl.Root.Item(i).GetType.ToString, dl.Root.Item(i).Text)
                                Else
                                    dl.Root.Item(i).Text = Read(mVar_FormCode, dl.Root.Item(i).Name, dl.Root.Item(i).Text, mVar_Language)
                                End If
                                If AlignRight Then dl.Root.Item(i).AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                            End If

                        End If
                    Next
                End If
            ElseIf TypeOf ct Is DevExpress.XtraLayout.LayoutControl Then
                Dim dl As DevExpress.XtraLayout.LayoutControl = CType(ct, DevExpress.XtraLayout.LayoutControl)
                If Not dl.Root Is Nothing Then
                    For i As Integer = 0 To dl.Root.Items.Count - 1

                        If TypeOf dl.Root.Item(i) Is DevExpress.XtraLayout.LayoutControlGroup Then
                            For d As Integer = 0 To CType(dl.Root(i), DevExpress.XtraLayout.LayoutControlGroup).Items.Count - 1
                                'CType(dl.Root.Item(i), DevExpress.XtraLayout.LayoutControlGroup).Items.Item(d).Text = GeriDon(m_Form, m_Lang, dl.Root.Item(i).Name)
                                'CType(dl.Root.Item(i), DevExpress.XtraLayout.LayoutControlGroup).Items.Item(d).CustomizationFormText = GeriDon(m_Form, m_Lang, dl.Root.Item(i).Name)
                                Dim itm As DevExpress.XtraLayout.LayoutControlItem = CType(dl.Root(i), DevExpress.XtraLayout.LayoutControlGroup).Items(d)
                                If WritingMode = True Then
                                    Save(mVar_FormCode, itm.Name, itm.GetType.ToString, itm.Text)
                                Else
                                    itm.Text = Read(mVar_FormCode, itm.Name, itm.Text, mVar_Language)
                                End If
                                If AlignRight Then itm.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                            Next
                        End If

                        If TypeOf dl.Root.Item(i) Is DevExpress.XtraLayout.LayoutControlItem Then
                            'CType(dl.Root.Item(i), DevExpress.XtraLayout.LayoutControlItem).Text = GeriDon(m_Form, m_Lang, dl.Root.Item(i).Name)
                            'CType(dl.Root.Item(i), DevExpress.XtraLayout.LayoutControlItem).CustomizationFormText = GeriDon(m_Form, m_Lang, dl.Root.Item(i).Name)

                            If WritingMode = True Then
                                Save(mVar_FormCode, dl.Root.Item(i).Name, dl.Root.Item(i).GetType.ToString, dl.Root.Item(i).Text)
                            Else
                                dl.Root.Item(i).Text = Read(mVar_FormCode, dl.Root.Item(i).Name, dl.Root.Item(i).Text, mVar_Language)
                            End If
                            If AlignRight Then dl.Root.Item(i).AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                        End If

                    Next
                End If
            End If

            If TypeOf ct Is DevExpress.XtraBars.Ribbon.RibbonControl Then
                Dim rc As DevExpress.XtraBars.Ribbon.RibbonControl = CType(ct, DevExpress.XtraBars.Ribbon.RibbonControl)
                For m As Integer = 0 To rc.Items.Count - 1

                    If TypeOf rc.Items(m) Is DevExpress.XtraBars.BarEditItem Then
                        If WritingMode = True Then
                            Save(mVar_FormCode, rc.Items(m).Name & ".Caption", rc.Items(m).GetType.ToString, rc.Items(m).Caption)
                        Else
                            rc.Items(m).Caption = Read(mVar_FormCode, rc.Items(m).Name & ".Caption", rc.Items(m).Caption, mVar_Language)
                        End If

                        If WritingMode = True Then
                            Save(mVar_FormCode, rc.Items(m).Name & ".Hint", rc.Items(m).GetType.ToString, rc.Items(m).Hint)
                        Else
                            rc.Items(m).Hint = Read(mVar_FormCode, rc.Items(m).Name & ".Hint", rc.Items(m).Hint, mVar_Language)
                        End If

                    End If

                    If TypeOf rc.Items(m) Is DevExpress.XtraBars.BarButtonItem Then
                        'rc.Items(m).Caption = GeriDon(m_Form, m_Lang, rc.Items(m).Name)
                        'rc.Items(m).Hint = GeriDon(m_Form, m_Lang, rc.Items(m).Name)

                        If WritingMode = True Then
                            Save(mVar_FormCode, rc.Items(m).Name & ".Caption", rc.Items(m).GetType.ToString, rc.Items(m).Caption)
                        Else
                            rc.Items(m).Caption = Read(mVar_FormCode, rc.Items(m).Name & ".Caption", rc.Items(m).Caption, mVar_Language)
                        End If

                        If WritingMode = True Then
                            Save(mVar_FormCode, rc.Items(m).Name & ".Hint", rc.Items(m).GetType.ToString, rc.Items(m).Hint)
                        Else
                            rc.Items(m).Hint = Read(mVar_FormCode, rc.Items(m).Name & ".Hint", rc.Items(m).Hint, mVar_Language)
                        End If

                    End If

                    If TypeOf rc.Items(m) Is DevExpress.XtraBars.BarCheckItem Then
                        'rc.Items(m).Caption = GeriDon(m_Form, m_Lang, rc.Items(m).Name)
                        'rc.Items(m).Hint = GeriDon(m_Form, m_Lang, rc.Items(m).Name)

                        If WritingMode = True Then
                            Save(mVar_FormCode, rc.Items(m).Name & ".Caption", rc.Items(m).GetType.ToString, rc.Items(m).Caption)
                        Else
                            rc.Items(m).Caption = Read(mVar_FormCode, rc.Items(m).Name & ".Caption", rc.Items(m).Caption, mVar_Language)
                        End If

                        If WritingMode = True Then
                            Save(mVar_FormCode, rc.Items(m).Name & ".Hint", rc.Items(m).GetType.ToString, rc.Items(m).Hint)
                        Else
                            rc.Items(m).Hint = Read(mVar_FormCode, rc.Items(m).Name & ".Hint", rc.Items(m).Hint, mVar_Language)
                        End If

                    End If

                    If TypeOf rc.Items(m) Is DevExpress.XtraBars.BarLargeButtonItem Then
                        'rc.Items(m).Caption = GeriDon(m_Form, m_Lang, rc.Items(m).Name)
                        'rc.Items(m).Hint = GeriDon(m_Form, m_Lang, rc.Items(m).Name)

                        If WritingMode = True Then
                            Save(mVar_FormCode, rc.Items(m).Name & ".Caption", rc.Items(m).GetType.ToString, rc.Items(m).Caption)
                        Else
                            rc.Items(m).Caption = Read(mVar_FormCode, rc.Items(m).Name & ".Caption", rc.Items(m).Caption, mVar_Language)
                        End If

                        If WritingMode = True Then
                            Save(mVar_FormCode, rc.Items(m).Name & ".Hint", rc.Items(m).GetType.ToString, rc.Items(m).Hint)
                        Else
                            rc.Items(m).Hint = Read(mVar_FormCode, rc.Items(m).Name & ".Hint", rc.Items(m).Hint, mVar_Language)
                        End If
                    End If

                    If TypeOf rc.Items(m) Is DevExpress.XtraBars.BarStaticItem Then
                        'rc.Items(m).Caption = GeriDon(m_Form, m_Lang, rc.Items(m).Name)
                        'rc.Items(m).Hint = GeriDon(m_Form, m_Lang, rc.Items(m).Name)
                        If WritingMode = True Then
                            Save(mVar_FormCode, rc.Items(m).Name & ".Caption", rc.Items(m).GetType.ToString, rc.Items(m).Caption)
                        Else
                            rc.Items(m).Caption = Read(mVar_FormCode, rc.Items(m).Name & ".Caption", rc.Items(m).Caption, mVar_Language)
                        End If

                        If WritingMode = True Then
                            Save(mVar_FormCode, rc.Items(m).Name & ".Hint", rc.Items(m).GetType.ToString, rc.Items(m).Hint)
                        Else
                            rc.Items(m).Hint = Read(mVar_FormCode, rc.Items(m).Name & ".Hint", rc.Items(m).Hint, mVar_Language)
                        End If
                    End If

                    If TypeOf rc.Items(m) Is DevExpress.XtraBars.BarSubItem Then
                        'rc.Items(m).Caption = GeriDon(m_Form, m_Lang, rc.Items(m).Name)
                        'rc.Items(m).Hint = GeriDon(m_Form, m_Lang, rc.Items(m).Name)
                        If WritingMode = True Then
                            Save(mVar_FormCode, rc.Items(m).Name & ".Caption", rc.Items(m).GetType.ToString, rc.Items(m).Caption)
                        Else
                            rc.Items(m).Caption = Read(mVar_FormCode, rc.Items(m).Name & ".Caption", rc.Items(m).Caption, mVar_Language)
                        End If

                        If WritingMode = True Then
                            Save(mVar_FormCode, rc.Items(m).Name & ".Hint", rc.Items(m).GetType.ToString, rc.Items(m).Hint)
                        Else
                            rc.Items(m).Hint = Read(mVar_FormCode, rc.Items(m).Name & ".Hint", rc.Items(m).Hint, mVar_Language)
                        End If
                    End If

                    If AlignRight Then rc.Items(m).Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far

                Next

                For i As Integer = 0 To rc.Pages.Count - 1
                    If TypeOf rc.Pages.Item(i) Is DevExpress.XtraBars.Ribbon.RibbonPage Then
                        'rc.Pages.Item(i).Text = GeriDon(m_Form, m_Lang, rc.Pages.Item(i).Name)

                        If WritingMode = True Then
                            Save(mVar_FormCode, rc.Pages.Item(i).Name, rc.Pages.Item(i).GetType.ToString, rc.Pages.Item(i).Text)
                        Else
                            rc.Pages.Item(i).Text = Read(mVar_FormCode, rc.Pages.Item(i).Name, rc.Pages.Item(i).Text, mVar_Language)
                        End If


                        For d As Integer = 0 To rc.Pages.Item(i).Groups.Count - 1
                            'rc.Pages.Item(i).Groups.Item(d).Text = GeriDon(m_Form, m_Lang, rc.Pages.Item(i).Groups.Item(d).Name)

                            If WritingMode = True Then
                                Save(mVar_FormCode, rc.Pages.Item(i).Groups.Item(d).Name, rc.Pages.Item(i).Groups.Item(d).GetType.ToString, rc.Pages.Item(i).Groups.Item(d).Text)
                            Else
                                rc.Pages.Item(i).Groups.Item(d).Text = Read(mVar_FormCode, rc.Pages.Item(i).Groups.Item(d).Name, rc.Pages.Item(i).Groups.Item(d).Text, mVar_Language)
                            End If


                        Next
                    End If
                Next
            End If

            If TypeOf ct Is DevExpress.XtraTab.XtraTabPage Then
                'CType(ct, DevExpress.XtraTab.XtraTabPage).Text = GeriDon(m_Form, m_Lang, ct.Name)

                If WritingMode = True Then
                    Save(mVar_FormCode, ct, ct.Text)
                Else
                    ct.Text = Read(mVar_FormCode, ct, ct.Text, mVar_Language)
                End If
                If AlignRight Then CType(ct, DevExpress.XtraTab.XtraTabPage).Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far

            End If

            If TypeOf ct Is DevExpress.XtraEditors.SimpleButton Then
                If CType(ct, DevExpress.XtraEditors.SimpleButton).Tag = Nothing Then
                    'CType(ct, DevExpress.XtraEditors.SimpleButton).Text = GeriDon(m_Form, m_Lang, ct.Name)
                    If WritingMode = True Then
                        Save(mVar_FormCode, ct, ct.Text)
                    Else
                        ct.Text = Read(mVar_FormCode, ct, ct.Text, mVar_Language)
                    End If

                End If
            End If



            ''If TypeOf ct Is DevExpress.XtraEditors.ComboBoxEdit Then
            ''    CType(ct, DevExpress.XtraEditors.ComboBoxEdit).Properties.NullText = GeriDon(m_Form, m_Lang, ct.Name)
            ''    For i As Integer = 0 To CType(ct, DevExpress.XtraEditors.ComboBoxEdit).Properties.Items.Count - 1
            ''        CType(ct, DevExpress.XtraEditors.ComboBoxEdit).Properties.Items(i) = GeriDon(m_Form, m_Lang, CType(ct, DevExpress.XtraEditors.LookUpEdit).Properties.Columns(i).FieldName)
            ''    Next
            ''End If


            If TypeOf ct Is DevExpress.XtraEditors.LabelControl Then
                'CType(ct, DevExpress.XtraEditors.LabelControl).Text = GeriDon(m_Form, m_Lang, ct.Name)
                If WritingMode = True Then
                    Save(mVar_FormCode, ct, ct.Text)
                Else
                    ct.Text = Read(mVar_FormCode, ct, ct.Text, mVar_Language)
                End If

                If AlignRight Then CType(ct, DevExpress.XtraEditors.LabelControl).Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far

            End If

            If TypeOf ct Is DevExpress.XtraBars.Docking.DockPanel Then
                'CType(ct, DevExpress.XtraBars.Docking.DockPanel).Text = GeriDon(m_Form, m_Lang, ct.Name)
                If WritingMode = True Then
                    Save(mVar_FormCode, ct, ct.Text)
                Else
                    ct.Text = Read(mVar_FormCode, ct, ct.Text, mVar_Language)
                End If
                If AlignRight Then CType(ct, DevExpress.XtraBars.Docking.DockPanel).Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far

            End If

            If TypeOf ct Is DevExpress.XtraEditors.CheckEdit Then
                'CType(ct, DevExpress.XtraEditors.CheckEdit).Text = GeriDon(m_Form, m_Lang, ct.Name)
                If WritingMode = True Then
                    Save(mVar_FormCode, ct, ct.Text)
                Else
                    ct.Text = Read(mVar_FormCode, ct, ct.Text, mVar_Language)
                End If
                If AlignRight Then CType(ct, DevExpress.XtraEditors.CheckEdit).Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far


            End If

            If TypeOf ct Is DevExpress.XtraBars.Ribbon.RibbonStatusBar Then
                'CType(ct, DevExpress.XtraBars.Ribbon.RibbonStatusBar).Text = GeriDon(m_Form, m_Lang, ct.Name)
                If WritingMode = True Then
                    Save(mVar_FormCode, ct, ct.Text)
                Else
                    ct.Text = Read(mVar_FormCode, ct, ct.Text, mVar_Language)
                End If


                For i As Integer = 0 To CType(ct, DevExpress.XtraBars.Ribbon.RibbonStatusBar).ItemLinks.Count - 1
                    With CType(ct, DevExpress.XtraBars.Ribbon.RibbonStatusBar).ItemLinks(i)


                        If WritingMode = True Then
                            Save(mVar_FormCode, ct.Name & "." & .Item.Name, .GetType.ToString, .Caption)
                        Else
                            .Caption = Read(mVar_FormCode, ct.Name & "." & .Item.Name, .Caption, mVar_Language)
                        End If
                        If AlignRight Then .Item.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far

                    End With

                Next

            End If

            If TypeOf ct Is DevExpress.XtraNavBar.NavBarControl Then
                Dim nb As DevExpress.XtraNavBar.NavBarControl = CType(ct, DevExpress.XtraNavBar.NavBarControl)
                For i As Integer = 0 To nb.Groups.Count - 1
                    If TypeOf nb.Groups(i) Is DevExpress.XtraNavBar.NavBarGroup Then
                        'nb.Groups(i).Caption = GeriDon(m_Form, m_Lang, nb.Groups(i).Name)
                        'nb.Groups(i).Hint = GeriDon(m_Form, m_Lang, nb.Groups(i).Name)
                        If WritingMode = True Then
                            Save(mVar_FormCode, nb.Groups(i).Name & ".Caption", nb.Groups(i).GetType.ToString, nb.Groups(i).Caption)
                        Else
                            nb.Groups(i).Caption = Read(mVar_FormCode, nb.Groups(i).Name & ".Caption", nb.Groups(i).Caption, mVar_Language)
                        End If
                        If WritingMode = True Then
                            Save(mVar_FormCode, nb.Groups(i).Name & ".Hint", nb.Groups(i).GetType.ToString, nb.Groups(i).Hint)
                        Else
                            nb.Groups(i).Hint = Read(mVar_FormCode, nb.Groups(i).Name & ".Hint", nb.Groups(i).Hint, mVar_Language)
                        End If

                        If AlignRight Then nb.Groups(i).Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far


                    End If
                Next
            End If



            If TypeOf ct Is DevExpress.XtraBars.BarDockControl Then
                Dim bdc As DevExpress.XtraBars.BarDockControl = CType(ct, DevExpress.XtraBars.BarDockControl)
                Dim xBars = bdc.Manager
                For i As Integer = 0 To xBars.Items.Count - 1
                    'xBars.Items(i).Caption = GeriDon(m_Form, m_Lang, xBars.Items(i).Name)

                    If WritingMode = True Then
                        Save(mVar_FormCode, xBars.Items(i).Name, xBars.Items(i).GetType.ToString, xBars.Items(i).Caption)
                    Else
                        xBars.Items(i).Caption = Read(mVar_FormCode, xBars.Items(i).Name, xBars.Items(i).Caption, mVar_Language)
                    End If
                    If AlignRight Then xBars.Items(i).Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                Next

            End If

            If TypeOf ct Is DevExpress.XtraEditors.RadioGroup Then
                Dim rg As DevExpress.XtraEditors.RadioGroup = CType(ct, DevExpress.XtraEditors.RadioGroup)
                For i As Integer = 0 To rg.Properties.Items.Count - 1
                    'rg.Properties.Items(i).Description = GeriDon(m_Form, m_Lang, rg.Properties.Items(i).Description)

                    If WritingMode = True Then
                        Save(mVar_FormCode, ct.Name & ".Properties.Items." & rg.Properties.Items(i).Description, rg.Properties.Items(i).GetType.ToString, rg.Properties.Items(i).Description)
                    Else
                        rg.Properties.Items(i).Description = Read(mVar_FormCode, ct.Name & ".Properties.Items." & rg.Properties.Items(i).Description, rg.Properties.Items(i).Description, mVar_Language)
                    End If
                Next
                If AlignRight Then rg.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            End If

            If ct.Controls.Count > 0 Then
                WalkInControl(mVar_FormCode, ct)
            End If

            'If TypeOf ct Is DevExpress.XtraBars.Ribbon.RibbonStatusBar Then
            '    'CType(ct, DevExpress.XtraBars.Ribbon.RibbonStatusBar).Text = GeriDon(m_Form, m_Lang, ct.Name)
            '    If WritingMode = True Then
            '        Save(mVar_FormCode,ct, ct.Text)
            '    Else
            '        ct.Text = Read(mVar_FormCode,ct, ct.Text, mVar_Language)
            '    End If
            '    For i As Integer = 0 To CType(ct, DevExpress.XtraBars.Ribbon.RibbonStatusBar).ItemLinks.Count - 1
            '        With CType(ct, DevExpress.XtraBars.Ribbon.RibbonStatusBar).ItemLinks(i)


            '            If WritingMode = True Then
            '                Save(mVar_FormCode,ct.Name & "." & .Item.Name, .GetType.ToString, .Caption)
            '            Else
            '                .Caption = Read(mVar_FormCode,ct.Name & "." & .Item.Name, .Caption, mVar_Language)
            '            End If
            '        End With
            '    Next

            'End If

        Next
    End Sub

    Public Function TText(ByVal sText As String, Optional ByVal FormCode As String = "Text") As String
        Try
            Return sText
            If WritingMode = False Then

                Return Read(FormCode, sText, sText, mVar_Language, False)
            Else
                Save(FormCode, sText, "System.String", sText)
                Return sText
            End If


        Catch ex As Exception
            MsgBox("(PiconnLanguage.TText) " & ex.Message)
        End Try
        Return sText
    End Function
End Class
