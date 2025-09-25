Imports System.Text
Imports System.Xml

''' <summary>
''' Summary description for TreeViewSerializer.
''' </summary>
Public Class TreeViewSerializer

    ' Xml tag for node, e.g. 'node' in case of <node></node>
    Private Const XmlNodeTag As String = "node"

    ' Xml attributes for node e.g. <node text="Asia" tag="" imageindex="1"></node>
    Private Const XmlNodeTextAtt As String = "text"
    Private Const XmlNodeTagAtt As String = "tag"
    Private Const XmlNodeImageIndexAtt As String = "imageindex"

    '
    ' TODO: Add constructor logic here
    '
    Public Sub New()
    End Sub

    'System.IO.StringWriter s;
    Public Sub SerializeTreeView(treeView As TreeView, fileName As String)
        Dim textWriter As New XmlTextWriter(fileName, System.Text.Encoding.UTF8)
        ' writing the xml declaration tag
        textWriter.WriteStartDocument()
        'textWriter.WriteRaw("\r\n");
        ' writing the main tag that encloses all node tags
        textWriter.WriteStartElement("TreeView")

        ' save the nodes, recursive method
        SaveNodes(treeView.Nodes, textWriter)

        textWriter.WriteEndElement()

        textWriter.Close()
    End Sub

    Private Sub SaveNodes(nodesCollection As TreeNodeCollection, textWriter As XmlTextWriter)
        For i As Integer = 0 To nodesCollection.Count - 1
            Dim node As TreeNode = nodesCollection(i)
            textWriter.WriteStartElement(XmlNodeTag)
            textWriter.WriteAttributeString(XmlNodeTextAtt, node.Text)
            textWriter.WriteAttributeString(XmlNodeImageIndexAtt, node.ImageIndex.ToString())
            textWriter.WriteAttributeString("key", node.Name)

            If node.Tag IsNot Nothing Then
                textWriter.WriteAttributeString("tag.bKategori", CType(node.Tag, kategoriItem).bKategori.ToString())
                textWriter.WriteAttributeString("tag.KategoriID", CType(node.Tag, kategoriItem).KategoriID.ToString())
                textWriter.WriteAttributeString("tag.UstKategoriID", CType(node.Tag, kategoriItem).UstKategoriID.ToString())
                textWriter.WriteAttributeString("tag.KendiFiyatBedenKullan", CType(node.Tag, kategoriItem).KendiFiyatBedenKullan.ToString())
                textWriter.WriteAttributeString("tag.KendiMasrafKullan", CType(node.Tag, kategoriItem).KendiMasrafKullan.ToString())
            End If

            ' add other node properties to serialize here

            If node.Nodes.Count > 0 Then


                SaveNodes(node.Nodes, textWriter)
            End If
            textWriter.WriteEndElement()
        Next
    End Sub

    Public Sub DeserializeTreeView(treeView As TreeView, fileName As String)
        Dim reader As XmlTextReader = Nothing
        Try
            ' disabling re-drawing of treeview till all nodes are added
            treeView.BeginUpdate()
            reader = New XmlTextReader(fileName)

            Dim parentNode As TreeNode = Nothing

            While reader.Read()
                If reader.NodeType = XmlNodeType.Element Then
                    If reader.Name = XmlNodeTag Then
                        Dim newNode As New TreeNode()
                        Dim isEmptyElement As Boolean = reader.IsEmptyElement

                        ' loading node attributes
                        Dim attributeCount As Integer = reader.AttributeCount
                        If attributeCount > 0 Then
                            For i As Integer = 0 To attributeCount - 1
                                reader.MoveToAttribute(i)

                                SetAttributeValue(newNode, reader.Name, reader.Value)
                            Next
                        End If

                        ' add new node to Parent Node or TreeView
                        If parentNode IsNot Nothing Then
                            parentNode.Nodes.Add(newNode)
                        Else
                            treeView.Nodes.Add(newNode)
                        End If

                        ' making current node 'ParentNode' if its not empty
                        If Not isEmptyElement Then
                            parentNode = newNode

                        End If
                    End If
                    ' moving up to in TreeView if end tag is encountered
                ElseIf reader.NodeType = XmlNodeType.EndElement Then
                    If reader.Name = XmlNodeTag Then
                        parentNode = parentNode.Parent
                    End If
                    'Ignore Xml Declaration                    
                ElseIf reader.NodeType = XmlNodeType.XmlDeclaration Then
                ElseIf reader.NodeType = XmlNodeType.None Then
                    Return
                ElseIf reader.NodeType = XmlNodeType.Text Then
                    parentNode.Nodes.Add(reader.Value)

                End If
            End While
        Finally
            ' enabling redrawing of treeview after all nodes are added
            treeView.EndUpdate()
            reader.Close()
        End Try
    End Sub

    ''' <summary>
    ''' Used by Deserialize method for setting properties of TreeNode from xml node attributes
    ''' </summary>
    ''' <param name="node"></param>
    ''' <param name="propertyName"></param>
    ''' <param name="value"></param>
    Private Sub SetAttributeValue(node As TreeNode, propertyName As String, value As String)
        If (node.Tag Is Nothing) Then
            node.Tag = New kategoriItem()
        End If
        If propertyName = XmlNodeTextAtt Then
            node.Text = value
        ElseIf propertyName = XmlNodeImageIndexAtt Then
            node.ImageIndex = Integer.Parse(value)
        ElseIf propertyName = "key" Then
            node.Name = value
        ElseIf propertyName = "tag.bKategori" Then
            CType(node.Tag, kategoriItem).bKategori = Convert.ToBoolean(value)
        ElseIf propertyName = "tag.KategoriID" Then
            CType(node.Tag, kategoriItem).KategoriID = Convert.ToInt32(value)
        ElseIf propertyName = "tag.UstKategoriID" Then
            CType(node.Tag, kategoriItem).UstKategoriID = Convert.ToInt32(value)
        ElseIf propertyName = "tag.KendiFiyatBedenKullan" Then
            CType(node.Tag, kategoriItem).KendiFiyatBedenKullan = Convert.ToInt32(value)
        ElseIf propertyName = "tag.KendiMasrafKullan" Then
            CType(node.Tag, kategoriItem).KendiMasrafKullan = Convert.ToInt32(value)
        End If


    End Sub

    Public Sub LoadXmlFileInTreeView(treeView As TreeView, fileName As String)
        Dim reader As XmlTextReader = Nothing
        Try
            treeView.BeginUpdate()
            reader = New XmlTextReader(fileName)

            Dim n As New TreeNode(fileName)
            treeView.Nodes.Add(n)
            While reader.Read()
                If reader.NodeType = XmlNodeType.Element Then
                    Dim isEmptyElement As Boolean = reader.IsEmptyElement
                    Dim text As New StringBuilder()
                    text.Append(reader.Name)
                    Dim attributeCount As Integer = reader.AttributeCount
                    If attributeCount > 0 Then
                        text.Append(" ( ")
                        For i As Integer = 0 To attributeCount - 1
                            If i <> 0 Then
                                text.Append(", ")
                            End If
                            reader.MoveToAttribute(i)
                            text.Append(reader.Name)
                            text.Append(" = ")
                            text.Append(reader.Value)
                        Next
                        text.Append(" ) ")
                    End If

                    If isEmptyElement Then
                        n.Nodes.Add(text.ToString())
                    Else
                        n = n.Nodes.Add(text.ToString())
                    End If
                ElseIf reader.NodeType = XmlNodeType.EndElement Then
                    n = n.Parent

                ElseIf reader.NodeType = XmlNodeType.XmlDeclaration Then
                ElseIf reader.NodeType = XmlNodeType.None Then
                    Return
                ElseIf reader.NodeType = XmlNodeType.Text Then
                    n.Nodes.Add(reader.Value)

                End If
            End While
        Finally
            treeView.EndUpdate()
            reader.Close()
        End Try
    End Sub
End Class
