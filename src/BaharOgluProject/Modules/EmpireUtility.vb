
'Imports System.CodeDom.Compiler
Imports Microsoft.VisualBasic 'More than just VB6 Runtime functions in here!
Imports System.Reflection
Imports Microsoft.Win32


Public Module PiconnUtility
#Region "API Calls"
    ' standard API declarations for INI access
    ' changing only "As Long" to "As Int32" (As Integer would work also)
    Private Declare Unicode Function WritePrivateProfileString Lib "kernel32" _
    Alias "WritePrivateProfileStringW" (ByVal lpApplicationName As String, _
    ByVal lpKeyName As String, ByVal lpString As String, _
    ByVal lpFileName As String) As Int32

    Private Declare Unicode Function GetPrivateProfileString Lib "kernel32" _
    Alias "GetPrivateProfileStringW" (ByVal lpApplicationName As String, _
    ByVal lpKeyName As String, ByVal lpDefault As String, _
    ByVal lpReturnedString As String, ByVal nSize As Int32, _
    ByVal lpFileName As String) As Int32
#End Region

    Public anaform As frmMainMenu


    Public Function INIRead(ByVal INIPath As String, _
    ByVal SectionName As String, ByVal KeyName As String, _
    Optional ByVal DefaultValue As String = "") As String
        ' primary version of call gets single value given all parameters
        Dim n As Int32
        Dim sData As String
        sData = Space$(1024) ' allocate some room 
        n = GetPrivateProfileString(SectionName, KeyName, DefaultValue, _
        sData, sData.Length, INIPath)
        If n > 0 Then ' return whatever it gave us
            INIRead = sData.Substring(0, n)
        Else
            INIRead = ""
        End If
    End Function


    Public Sub INIWrite(ByVal INIPath As String, ByVal SectionName As String, _
    ByVal KeyName As String, ByVal TheValue As String)
        Call WritePrivateProfileString(SectionName, KeyName, TheValue, INIPath)
    End Sub

    Public Sub INIDelete(ByVal INIPath As String, ByVal SectionName As String, _
    ByVal KeyName As String) ' delete single line from section
        Call WritePrivateProfileString(SectionName, KeyName, Nothing, INIPath)
    End Sub

    Public Sub INIDelete(ByVal INIPath As String, ByVal SectionName As String)
        ' delete section from INI file
        Call WritePrivateProfileString(SectionName, Nothing, Nothing, INIPath)
    End Sub

    Public Sub RaiseError(ByVal ModuleName As String, ByVal FunctionName As String, Optional ByVal UserName As String = "", Optional ByVal bShowError As Boolean = True, Optional ByVal AdditionalInformation As String = "")
        'On Error Resume Next
        Dim FileName As String
        Dim sw As IO.StreamWriter
        If Not IO.Directory.Exists(GetMyDir() & "\Log") Then
            IO.Directory.CreateDirectory(GetMyDir() & "\Log")
        End If
        FileName = GetMyDir() & "\Log\Err_" & Format(Today, "yyyyMMdd") & ".log"
        sw = IO.File.AppendText(FileName)
        sw.WriteLine(Format(Now, "yyyy-MM-dd HH:mm:ss") & " App: " & "    Module:" & ModuleName & "    Function:" & FunctionName)
        sw.WriteLine(Format(Now, "yyyy-MM-dd HH:mm:ss") & " Err:" & Err.Number & "-" & Err.Description)
        If AdditionalInformation <> "" Then
            sw.WriteLine(Format(Now, "yyyy-MM-dd HH:mm:ss") & " Additional Information :" & AdditionalInformation)
        End If

        sw.WriteLine("")
        sw.Close()
        sw.Dispose()
        If bShowError Then
            MsgBox("İşlem sırasında hata oluştu!" & vbNewLine & _
            "-------------------------------------------------------------------------------------------------" & vbNewLine & _
            "Modül:" & ModuleName & "   Fonksiyon:" & FunctionName & vbNewLine & _
            "-------------------------------------------------------------------------------------------------" & vbNewLine & _
            "Hata: " & Err.Number & "-" & Err.Description, MsgBoxStyle.Information)
        End If
    End Sub

    Public Function IfNull(ByVal Value As Object, ByVal Response As Object) As Object
        If Value Is Nothing Then
            Return Response
        Else
            If IsDBNull(Value) Then
                Return Response
            Else
                Return Value
            End If
        End If

    End Function

    Public Function IfDBNull(ByVal Value As Object, ByVal Response As Object) As Object
        Return IfNull(Value, Response)
    End Function

    Public Function CommaToPoint(ByVal Value As Double) As String

        CommaToPoint = Replace(CStr(Value), ",", ".")
    End Function

    Public Function CommaToPointStr(ByVal Value As String) As String
        Dim sbuf As String
        sbuf = Value
        If DecimalPointer() = "," Then
            sbuf = Replace(sbuf, ".", "")
            sbuf = Replace(sbuf, ",", ".")
        ElseIf DecimalPointer() = "." Then
            sbuf = Replace(sbuf, ",", "")
        End If
        Return sbuf
    End Function

    Public Function DecimalPointer() As String
        Dim a As Double
        Dim bufStr As String
        a = 1.1
        bufStr = CStr(a)
        DecimalPointer = ""
        If InStr(bufStr, ",") > 0 Then
            DecimalPointer = ","
        End If
        If InStr(bufStr, ".") > 0 Then
            DecimalPointer = "."
        End If
    End Function

    Public Function OnlyNumber(ByVal text As String) As String
        Dim i As Long
        Dim sBuf As String = ""
        For i = 1 To Len(text)
            If IsNumeric(Microsoft.VisualBasic.Mid(text, i, 1)) Or Microsoft.VisualBasic.Mid(text, i, 1) = "." Or Microsoft.VisualBasic.Mid(text, i, 1) = "," Then
                sBuf = sBuf & Microsoft.VisualBasic.Mid(text, i, 1)
            End If
        Next
        OnlyNumber = sBuf
    End Function

    Public Function sStartDate(ByVal Tarih As Date) As String
        sStartDate = "CONVERT(DATETIME, '" & Year(Tarih) & "-" & Month(Tarih) & "-" & Tarih.Day & " 00:00:00', 102)"
    End Function

    Public Function sEndDate(ByVal Tarih As Date) As String
        sEndDate = "CONVERT(DATETIME, '" & Year(Tarih) & "-" & Month(Tarih) & "-" & Tarih.Day & " 23:59:59', 102)"
    End Function

    Public Function SQLDateTime(ByVal Tarih As Date) As String
        If Year(Tarih) = 1 Then
            Return "CONVERT(DATETIME, '1899-12-30 00:00:00', 102)"
        Else
            Return "CONVERT(DATETIME, '" & Year(Tarih) & "-" & Month(Tarih) & "-" & Tarih.Day & " " & Hour(Tarih) & ":" & Minute(Tarih) & ":" & Second(Tarih) & "', 102)"
        End If


    End Function

    Public Function IncBelgeNo(ByVal text As String, Optional ByVal turkce As Boolean = False, Optional ByVal ingilizce As Boolean = False) As String
        '*******************************************************************************
        '* Name:  IncBelgeNo
        '* Date Created:  17.07.2006
        '* Created By: Talat
        '* Modified:
        '* Description: belge numarasını 1 arttırır
        '*******************************************************************************

        On Error GoTo IncStr_ERR
        Dim i As Long
        Dim harf As String
        Dim gecici As String

        'IncBelgeNo = IncStr(text)
        'Exit Function

        For i = Len(text) To 1 Step -1
            harf = IncBelgeNoSonraki(Mid(text, i, 1), turkce, ingilizce)
            If harf <> Chr(0) Then
                gecici = ""
                If i > 1 Then gecici = Mid(text, 1, i - 1)
                gecici = gecici & CStr(harf)
                If i < Len(text) Then gecici = gecici & Mid(text, i + 1, Len(text) - i)
                text = gecici
                Select Case harf
                    Case "a", "A", "0"
                        If i = 1 Then
                            text = "0" & text
                            Exit For
                        End If
                    Case Else
                        Exit For
                End Select
            End If
        Next

        IncBelgeNo = text

        Exit Function

IncStr_ERR:
        MsgBox("modGLB_Utility" & "IncBelgeNo")

    End Function

    Private Function IncBelgeNoSonraki(ByVal harf As String, ByVal turkce As Boolean, ByVal ingilizce As Boolean) As String
        '*******************************************************************************
        '* Name:  IncBelgeNoSonraki
        '* Date Created:  17.07.2006
        '* Created By: Talat
        '* Modified:
        '* Description: belge numarasının harfini 1 arttırır
        '*******************************************************************************

        On Error GoTo IncBelgeNoSonraki_ERR

        Select Case harf
            Case "Ç"
                IncBelgeNoSonraki = "D"
            Case "ç"
                IncBelgeNoSonraki = "d"
            Case "ı"
                IncBelgeNoSonraki = "i"
            Case "İ"
                IncBelgeNoSonraki = "J"
            Case "ğ"
                IncBelgeNoSonraki = "h"
            Case "Ğ"
                IncBelgeNoSonraki = "H"
            Case "ü"
                IncBelgeNoSonraki = "v"
            Case "Ü"
                IncBelgeNoSonraki = "V"
            Case "ş"
                IncBelgeNoSonraki = "t"
            Case "Ş"
                IncBelgeNoSonraki = "T"
            Case "ö"
                IncBelgeNoSonraki = "p"
            Case "Ö"
                IncBelgeNoSonraki = "P"
            Case "p"
                If ingilizce = True Then
                    IncBelgeNoSonraki = "q"
                Else
                    IncBelgeNoSonraki = "r"
                End If
            Case "P"
                If ingilizce = True Then
                    IncBelgeNoSonraki = "Q"
                Else
                    IncBelgeNoSonraki = "R"
                End If
            Case "v"
                If ingilizce = True Then
                    IncBelgeNoSonraki = "w"
                Else
                    IncBelgeNoSonraki = "y"
                End If
            Case "V"
                If ingilizce = True Then
                    IncBelgeNoSonraki = "W"
                Else
                    IncBelgeNoSonraki = "Y"
                End If
            Case "w"
                If ingilizce = True Then
                    IncBelgeNoSonraki = "x"
                Else
                    IncBelgeNoSonraki = "y"
                End If
            Case "W"
                If ingilizce = True Then
                    IncBelgeNoSonraki = "X"
                Else
                    IncBelgeNoSonraki = "Y"
                End If
            Case "c"
                If turkce = True Then
                    IncBelgeNoSonraki = "ç"
                Else
                    IncBelgeNoSonraki = "d"
                End If
            Case "C"
                If turkce = True Then
                    IncBelgeNoSonraki = "Ç"
                Else
                    IncBelgeNoSonraki = "D"
                End If
            Case "h"
                If turkce = True Then
                    IncBelgeNoSonraki = "ı"
                Else
                    IncBelgeNoSonraki = "i"
                End If
            Case "I"
                If turkce = True Then
                    IncBelgeNoSonraki = "İ"
                Else
                    IncBelgeNoSonraki = "J"
                End If
            Case "g"
                If turkce = True Then
                    IncBelgeNoSonraki = "ğ"
                Else
                    IncBelgeNoSonraki = "h"
                End If
            Case "G"
                If turkce = True Then
                    IncBelgeNoSonraki = "Ğ"
                Else
                    IncBelgeNoSonraki = "H"
                End If
            Case "o"
                If turkce = True Then
                    IncBelgeNoSonraki = "ö"
                Else
                    IncBelgeNoSonraki = "p"
                End If
            Case "O"
                If turkce = True Then
                    IncBelgeNoSonraki = "Ö"
                Else
                    IncBelgeNoSonraki = "P"
                End If
            Case "s"
                If turkce = True Then
                    IncBelgeNoSonraki = "ş"
                Else
                    IncBelgeNoSonraki = "t"
                End If
            Case "S"
                If turkce = True Then
                    IncBelgeNoSonraki = "Ş"
                Else
                    IncBelgeNoSonraki = "T"
                End If
            Case "u"
                If turkce = True Then
                    IncBelgeNoSonraki = "ü"
                Else
                    IncBelgeNoSonraki = "v"
                End If
            Case "U"
                If turkce = True Then
                    IncBelgeNoSonraki = "Ü"
                Else
                    IncBelgeNoSonraki = "V"
                End If
            Case "z"
                IncBelgeNoSonraki = "a"
            Case "Z"
                IncBelgeNoSonraki = "A"
            Case "9"
                IncBelgeNoSonraki = "0"
            Case Else
                If (Asc(harf) > 64 And Asc(harf) < 91) Or (Asc(harf) > 96 And Asc(harf) < 123) Or (Asc(harf) > 47 And Asc(harf) < 57) Then
                    IncBelgeNoSonraki = Chr(Asc(harf) + 1)
                Else
                    IncBelgeNoSonraki = Chr(0)
                End If
        End Select

        Exit Function

IncBelgeNoSonraki_ERR:
        MsgBox("modGLB_Utility" & "IncBelgeNoSonraki")

    End Function

    Public Function GetMyDir() As String
        Dim fi As System.IO.FileInfo
        Dim di As System.IO.DirectoryInfo
        Dim pc As System.Diagnostics.Process
        Try
            pc = System.Diagnostics.Process.GetCurrentProcess
            fi = New System.IO.FileInfo(pc.MainModule.FileName)
            di = fi.Directory
            GetMyDir = di.FullName
        Finally
            fi = Nothing
            di = Nothing
            pc = Nothing
        End Try
    End Function

    Public Function GetIniFileName()
        Dim filename As String = Mid(Application.ExecutablePath, 1, Application.ExecutablePath.Length - 3) & "ini"
        Return filename

    End Function
    Public Function WriteLog(ByVal sMsg As String) As Boolean
        On Error GoTo HELL
        Dim fs As IO.StreamWriter
        Dim sFileName As String
        If IO.Directory.Exists(GetMyDir() & "\Log") = False Then
            IO.Directory.CreateDirectory(GetMyDir() & "\Log")
        End If
        sFileName = GetMyDir() & "\Log\Log_" & Format(Now, "yyyyMMdd") & ".log"
        fs = IO.File.AppendText(sFileName)
        fs.WriteLine(Format(Now, "yyyy.MM.dd HH:mm:ss") & " " & sMsg)
        fs.Close()
HELL:

    End Function

    Public Function StrToByteArray(ByVal str As String) As Byte()
        Dim encoding As New System.Text.ASCIIEncoding()
        Return encoding.GetBytes(str)
    End Function 'StrToByteArray

    Public Function SetParam(ByRef Parameters As ArrayList, ByVal ParamName As String, ByVal ParamValue As Object) As Boolean
        Dim bFound As Boolean = False
        Dim pr As New SqlClient.SqlParameter
        For Each pr In Parameters
            If pr.ParameterName = ParamName Then
                bFound = True
                Exit For
            End If
        Next
        If bFound Then
            pr.Value = ParamValue
        End If
        Return bFound
    End Function

    Public Function GetParamValue(ByRef Parameters As ArrayList, ByVal ParamName As String) As Object
        Dim bFound As Boolean = False
        Dim pr As New SqlClient.SqlParameter
        Dim sParamName As String = ""
        For Each pr In Parameters
            sParamName = ""
            If pr.ParameterName <> "" Then
                If Mid(pr.ParameterName, 1, 1) = "@" Then
                    sParamName = Mid(pr.ParameterName, 2, pr.ParameterName.Length - 1)
                Else
                    sParamName = pr.ParameterName
                End If
            End If
            If sParamName = ParamName Then
                bFound = True
                Exit For
            End If
        Next
        If bFound Then
            Return pr.Value
        Else
            Return ""
        End If
    End Function


    Public Function ProcessCommand(ByVal command As String) As Double
        Dim MyProvider As New VBCodeProvider 'Create a new VB Code Compiler
        Dim cp As New System.CodeDom.Compiler.CompilerParameters     'Create a new Compiler parameter object.
        Dim ret As Double = 0
        cp.GenerateExecutable = False        'Don't create an object on disk
        cp.GenerateInMemory = True           'But do create one in memory.
        'If cp.OutputAssembly is used with a VBCodeProvider, it seems to want to read before it is executed.  
        'See C# CodeBank example for explanation of why it was used.


        Dim TempModuleSource As String = "'Option Strict On" & vbNewLine & "Imports System" & Environment.NewLine & _
                                         "Imports System.Math" & Environment.NewLine & _
                                         "Namespace ns " & Environment.NewLine & _
                                         "Public Class class1" & Environment.NewLine & _
                                         "Public  Function Evaluate()" & Environment.NewLine & _
                                         "Return " & command & Environment.NewLine & _
                                         "End Function" & Environment.NewLine & _
                                         "End Class" & Environment.NewLine & _
                                         "End Namespace"
        'Create a compiler output results object and compile the source code.
        Dim cr As CodeDom.Compiler.CompilerResults = MyProvider.CompileAssemblyFromSource(cp, TempModuleSource)
        If cr.Errors.Count > 0 Then
            'If the expression passed is invalid or "", the compiler will generate errors.
            'Throw New ArgumentOutOfRangeException("Invalid Expression - please use something VB could evaluate")
            Return 0
        Else

            'Find our Evaluate method.
            Dim methInfo As MethodInfo = cr.CompiledAssembly.GetType("ns.class1").GetMethod("Evaluate")
            'Invoke it on nothing, so that we can get the return value
            ret = Convert.ToDouble(methInfo.Invoke(Nothing, Nothing))
            If Double.IsNaN(ret) Or Double.IsInfinity(ret) Or Double.IsNegativeInfinity(ret) Or Double.IsPositiveInfinity(ret) Then
                ret = 0
            End If
            Return ret
        End If
    End Function


    Public Sub CalcColumns(ByVal ActiveFieldName As String, ByVal Formula As String, ByRef dr As DataRow, Optional ByVal BeginSign As String = "[", Optional ByVal EndSign As String = "]")

        Dim Value As Double = 0
        Dim Variants As New ArrayList
        Dim sFormula As String
        Dim SubFormula As String = ""
        Dim i As Long, j As Integer, sbuf As String = ""
        Dim EqualFieldName As String = ""
        Dim EsittirNoktasi As Integer = 0

        sFormula = Replace(Formula, " ", "")
        If Trim(sFormula) = "" Then Exit Sub
        If Mid(sFormula, sFormula.Length, 1) <> ";" Then sFormula &= ";"
        i = 0
        Do While Split(sFormula, ";")(i) <> ""
            sbuf = Split(sFormula, ";")(i)
            sbuf = Replace(sbuf, ";", "")
            EsittirNoktasi = InStr(sbuf, "=")
            If EsittirNoktasi > 0 Then
                EqualFieldName = GetEqualFieldNameInFormula(sbuf)

                SubFormula = Mid(sbuf, EsittirNoktasi + 1, sbuf.Length - (EsittirNoktasi))
                If SubFormula <> "" Then
                    Variants = New ArrayList
                    Variants = GetVariantsInFormula(SubFormula)
                    For j = 0 To Variants.Count - 1
                        Value = 0
                        If IsNumeric(IfNull(dr(Variants(j)), 0)) Then
                            Value = IfNull(dr(Variants(j)), 0)
                        End If

                        SubFormula = Replace(SubFormula, BeginSign & Variants(j) & EndSign, CommaToPoint(Value))
                    Next
                    Try
                        If EqualFieldName = "" Then
                            dr(ActiveFieldName) = ProcessCommand(SubFormula)
                        Else
                            dr(EqualFieldName) = ProcessCommand(SubFormula)
                        End If

                    Catch ex As Exception
                        If EqualFieldName = "" Then
                            dr(ActiveFieldName) = 0
                        Else
                            dr(EqualFieldName) = 0
                        End If

                    End Try
                End If
            End If
            i = i + 1
        Loop

    End Sub

    Public Function GetEqualFieldNameInFormula(ByVal Formula As String, Optional ByVal BeginSign As String = "[", Optional ByVal EndSign As String = "]") As String
        Dim sbuf As String = ""
        Dim ar As New ArrayList
        Dim start As Integer = 0
        Dim i As Integer = 1
        Dim nstop As Integer = 0
        If Trim(Formula) = "" Then Return ""
        If Mid(Trim(Formula), 1, 1) = "=" Then Return ""

        Do While i < Formula.Length
            If Mid(Formula, i, 1) = BeginSign Then
                start = i + 1
                nstop = InStr(start, Formula, EndSign)
                If start < nstop Then
                    If nstop > 0 Then
                        sbuf = Mid(Formula, start, nstop - start)
                        Return sbuf
                        i = nstop + 1
                    Else
                        Exit Do
                    End If
                Else
                    i = i + 1
                End If
            Else
                i = i + 1
            End If
        Loop
        Return ""
    End Function

    Public Function GetVariantsInFormula(ByVal Formula As String, Optional ByVal BeginSign As String = "[", Optional ByVal EndSign As String = "]") As ArrayList
        Dim sbuf As String = ""
        Dim ar As New ArrayList
        Dim start As Integer = 0
        Dim i As Integer = 1
        Dim nstop As Integer = 0

        Do While i < Formula.Length
            If Mid(Formula, i, 1) = BeginSign Then
                start = i + 1
                nstop = InStr(start, Formula, EndSign)
                If start < nstop Then
                    If nstop > 0 Then
                        sbuf = Mid(Formula, start, nstop - start)
                        ar.Add(sbuf)
                        i = nstop + 1
                    Else
                        Exit Do
                    End If
                Else
                    i = i + 1
                End If
            Else
                i = i + 1
            End If
        Loop

        Return ar
    End Function

    Public Function GetNodeValue(ByVal Node As Xml.XmlNode, ByVal ItemName As String, Optional ByVal DefaultValue As Object = "") As String
        'On Error GoTo HELL
        If Node Is Nothing Then Return ""
        Dim n As Xml.XmlNode
        For Each n In Node.ChildNodes
            If n.Name = ItemName Then
                Return n.InnerText
            End If
        Next
        Return IfNull(DefaultValue, "")
        'HELL:
        '            Return DefaultValue
    End Function

    Public Sub SetDataRow(ByRef dr As DataRow, ByVal ColumnName As String, ByVal Value As Object)
        Try
            dr(ColumnName) = Value
        Catch ex As Exception

        End Try


    End Sub

    Public Function ParamNameCompare(ByVal Param1 As String, ByVal Param2 As String) As Boolean
        Dim sParam1 As String = ""
        Dim sParam2 As String = ""
        If Param1 <> "" Then
            If Mid(Param1, 1, 1) = "@" Then
                sParam1 = Mid(Param1, 2, Len(Param1) - 1)
            Else
                sParam1 = Param1
            End If
        End If
        If Param2 <> "" Then
            If Mid(Param2, 1, 1) = "@" Then
                sParam2 = Mid(Param2, 2, Len(Param2) - 1)
            Else
                sParam2 = Param2
            End If
        End If

        If UCase(sParam1) = UCase(sParam2) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function UCaseEng(ByVal sText As String) As String
        Dim sbuf As String = ""
        Dim i As Long
        Dim ch As String = ""
        For i = 1 To Len(sText)
            ch = Mid(sText, i, 1)
            Select Case ch
                Case "ş", "Ş" : ch = "S"
                Case "i", "ı", "İ" : ch = "I"
                Case "ç", "Ç" : ch = "C"
                Case "ö", "Ö" : ch = "O"
                Case "ü", "Ü" : ch = "U"
                Case "ğ", "Ğ" : ch = "G"

            End Select
            sbuf &= UCase(ch)
        Next
        Return sbuf
    End Function

    
    Public Function GetPiconnVariant(ByVal conn As SqlClient.SqlConnection, ByVal VariantName As String) As String
        Dim VariantValue As String = ""
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim da As SqlClient.SqlDataAdapter
            Dim dt As DataTable

            cmd.Connection = conn
            cmd.CommandText = "SELECT VariantValue FROM Piconn_Variants WHERE Deleted = 0 AND VariantName =@VariantName"
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlClient.SqlParameter("@VariantName", VariantName))
            da = New SqlClient.SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                VariantValue = IfNull(dt.Rows(0).Item("VariantValue"), "")
            End If
            dt.Dispose()
            da.Dispose()
            cmd.Dispose()

        Catch ex As Exception

            MsgBox(ex.Message)
        End Try

        Return VariantValue
    End Function

    Public Function SetPiconnVariant(ByVal conn As SqlClient.SqlConnection, ByVal VariantName As String, ByVal VariantValue As String) As Boolean
        Dim cmd As New SqlClient.SqlCommand

        Try

            cmd.Connection = conn
            cmd.Parameters.Clear()
            cmd.Parameters.Add(New SqlClient.SqlParameter("@VariantName", Mid(VariantName, 1, 100)))
            cmd.Parameters.Add(New SqlClient.SqlParameter("@VariantValue", Mid(VariantValue, 1, 255)))

            cmd.CommandText = "IF EXISTS(SELECT * FROM Piconn_Variants WHERE Deleted = 0 AND VariantName =@VariantName) BEGIN " & vbNewLine
            cmd.CommandText &= "    UPDATE Piconn_Variants SET VariantValue=@VariantValue WHERE Deleted = 0 AND VariantName =@VariantName " & vbNewLine
            cmd.CommandText &= " END ELSE BEGIN " & vbNewLine
            cmd.CommandText &= "INSERT INTO Piconn_Variants(Deleted,CreatedBy,CreatedDate,ModifiedBy,ModifiedDate,VariantName,VariantValue) VALUES (" & vbNewLine
            cmd.CommandText &= "0,0,GETDATE(),0,GETDATE(),@VariantName,@VariantValue) " & vbNewLine
            cmd.CommandText &= " END " & vbNewLine

            cmd.ExecuteNonQuery()

            cmd.Dispose()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try


    End Function

    Public Function GetSQLTypeVB(ByVal sSQLType As String) As String
        Select Case sSQLType
            Case "name", "varchar", "nchar", "char", "ntext", "nvarchar", "text" : Return "System.String"
            Case "bigint", "int" : Return "System.Int64"
            Case "binary", "varbinary", "image", "sql_variant", "timestamp" : Return "System.Object"
            Case "datetime", "smalldatetime" : Return "System.DateTime"
            Case "decimal", "float", "money", "numeric", "real", "smallmoney" : Return "System.Double"
            Case "smallint" : Return "System.Int32"
            Case "tinyint" : Return "System.Byte"
            Case "bit" : Return "System.Boolean"
            Case "uniqueidentifier" : Return "System.Guid"

            Case Else
                Return "System.String"
        End Select

    End Function

    Public Function GetSQLTypeToVBType(ByVal sSQLType As String) As Type

        Return Type.GetType(GetSQLTypeVB(sSQLType))
    End Function

    Public Function GetSqlDBTypeFromString(ByVal sSqlType As String) As SqlDbType
        sSqlType = UCaseEng(sSqlType)
        Select Case sSqlType
            Case "BIGINT" : Return SqlDbType.BigInt
            Case "BINARY" : Return SqlDbType.Binary
            Case "BIT" : Return SqlDbType.Bit
            Case "CHAR" : Return SqlDbType.Char
            Case "DATE" : Return SqlDbType.Date
            Case "DATETIME" : Return SqlDbType.DateTime
            Case "DATETIME2" : Return SqlDbType.DateTime2
            Case "DATETIMEOFFSET" : Return SqlDbType.DateTimeOffset
            Case "DECIMAL" : Return SqlDbType.Decimal
            Case "FLOAT" : Return SqlDbType.Float
            Case "IMAGE" : Return SqlDbType.Image
            Case "INT" : Return SqlDbType.Int
            Case "MONEY" : Return SqlDbType.Money
            Case "NCHAR" : Return SqlDbType.NChar
            Case "NTEXT" : Return SqlDbType.NText
            Case "NVARCHAR" : Return SqlDbType.NVarChar
            Case "REAL" : Return SqlDbType.Real
            Case "SMALLDATETIME" : Return SqlDbType.SmallDateTime
            Case "SMALLINT" : Return SqlDbType.SmallInt
            Case "SMALLMONEY" : Return SqlDbType.SmallMoney
            Case "STRUCTURED" : Return SqlDbType.Structured
            Case "TEXT" : Return SqlDbType.Text
            Case "TIME" : Return SqlDbType.Time
            Case "TIMESTAMP" : Return SqlDbType.Timestamp
            Case "TINYINT" : Return SqlDbType.TinyInt
            Case "UDT" : Return SqlDbType.Udt
            Case "UNIQUEIDENTIFIER" : Return SqlDbType.UniqueIdentifier
            Case "VARBINARY" : Return SqlDbType.VarBinary
            Case "VARCHAR" : Return SqlDbType.VarChar
            Case "VARIANT" : Return SqlDbType.Variant
            Case "XML" : Return SqlDbType.Xml
            Case Else
                Return SqlDbType.NVarChar
        End Select
    End Function

    Public Function GetTypeToSqlDbType(ByVal type As System.Type) As SqlDbType
        Select Case type.ToString
            Case "System.String" : Return SqlDbType.NVarChar
            Case "System.Char" : Return SqlDbType.Char
            Case "System.Int16" : Return SqlDbType.SmallInt
            Case "System.Byte" : Return SqlDbType.TinyInt
            Case "System.Int64", "System.Int32" : Return SqlDbType.Int
            Case "System.Boolean" : Return SqlDbType.Bit
            Case "System.Guid" : Return SqlDbType.UniqueIdentifier
            Case "System.Double" : Return SqlDbType.Float
            Case "System.Object" : Return SqlDbType.VarBinary
            Case Else
                Return SqlDbType.NVarChar
        End Select
    End Function

    Public Function If0Null(ByVal Value As Object) As Double
        If Not Value Is Nothing Then
            If Not IsDBNull(Value) Then
                If Value = System.Double.NaN Or Value = System.Double.NegativeInfinity Or Value = System.Double.PositiveInfinity Then
                    Return CDbl(0)
                End If
            End If

        End If
        Return CDbl(IfNull(Value, 0))

    End Function

    Public Function IfNullGuid(ByVal Value As Object) As Guid
        If Not Value Is Nothing Then
            If Not IsDBNull(Value) Then
                Try
                    If TypeOf Value Is System.Guid Then
                        Return CType(Value, System.Guid)
                    Else
                        Return New Guid(Value.ToString)
                    End If


                Catch ex As Exception
                    Return Guid.Empty
                End Try

            End If

        End If
        Return Guid.Empty
    End Function

    Public Function EqGuidSQL(ByVal Value As Object) As String
        If Not Value Is Nothing Then
            If Not IsDBNull(Value) Then
                If TypeOf Value Is System.Guid Then
                    Return " = '" & CType(Value, System.Guid).ToString & "' "
                End If

            End If

        End If
        Return " IS NULL "
    End Function

    Public Function IfNullGuidSQL(ByVal Value As Object) As String
        If Not Value Is Nothing Then
            If Not IsDBNull(Value) Then
                If TypeOf Value Is System.Guid Then
                    Return "'" & CType(Value, System.Guid).ToString & "'"
                End If

            End If

        End If
        Return "NULL"
    End Function

    Public Function IsNullGuid(ByVal Value As Object) As Boolean
        If Value Is Nothing Then Return True
        If IsDBNull(Value) Then Return True
        If Not TypeOf Value Is System.Guid Then Return True
        ' "00000000-0000-0000-0000-000000000000"

        If CType(Value, Guid).ToString = "" Or CType(Value, Guid).ToString = Guid.Empty.ToString Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function NewDataColumn(ByVal ColumnName As String, ByVal dataType As System.Type, Optional ByVal Caption As String = "") As DataColumn
        Try
            Dim dc As New DataColumn(ColumnName, dataType)
            If Caption = "" Then
                dc.Caption = ColumnName
            Else
                dc.Caption = Caption
            End If

            Return dc
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return New DataColumn
    End Function

    Public Function SaveRegHKLM(ByVal AppName As String, ByVal Key As String, ByVal Value As Object) As Boolean
        Try
            Dim regKey As RegistryKey

            regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", True)

            If regKey.OpenSubKey(AppName) Is Nothing Then
                regKey.CreateSubKey(AppName)

            End If


            regKey.OpenSubKey(AppName, True).SetValue(Key, Value)
            regKey.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Public Function GetRegHKLM(ByVal AppName As String, ByVal Key As String, Optional ByVal DefaultValue As String = "") As Object
        Try
            Dim regKey As RegistryKey
            Dim value As Object
            regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", True)

            If regKey.OpenSubKey(AppName) Is Nothing Then
                regKey.CreateSubKey(AppName)

            End If

            value = regKey.OpenSubKey(AppName, True).GetValue(Key)
            regKey.Close()
            Return value
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return DefaultValue
    End Function


End Module

