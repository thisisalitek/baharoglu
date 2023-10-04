'Imports PiconnUtility.dynamoEmpire.PiconnUtility
'Imports PiconnDefaultDBSettings.dynamoEmpire
'Imports PiconnUpgrade.modUpgradeUtil

Public Module Upgrade

	Public Const ProgramVersion As String = "1.5.2"


	Public Function LocalVersionControl() As Boolean
		Dim sActiveVersion As String = ""
		Dim msg As String = ""
		Dim bVersionExecuted As Boolean = False
		Dim bError As Boolean = False
		Dim sPrgVer As String = "", sDBVer As String = ""
		Dim conn As SqlClient.SqlConnection = AppConn.dbConn
		Try
			If conn.State <> ConnectionState.Open Then
				MsgBox("Uzak sunucu baglantisi yok!")
				Return False
			End If
			VariantTableControl(conn)
Tekrar:
			sActiveVersion = GetPiconnVariant(conn, "Version")
			If sActiveVersion = "" Then sActiveVersion = "0.0.0"
			Select Case sActiveVersion
				Case "0.0.0", "1.0.0"

					SetPiconnVariant(conn, "Version", "1.0.1")

					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.0.0", "1.0.1"
					If RunVersionScript(conn, "sql_ver_01.00.02.sql") Then
						SetPiconnVariant(conn, "Version", "1.0.2")
					Else
						msg = "Ver:1.0.2 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar

				Case "1.0.2"
					If RunVersionScript(conn, "sql_ver_01.00.03.sql") Then
						SetPiconnVariant(conn, "Version", "1.0.3")
					Else
						msg = "Ver:1.0.3 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar

				Case "1.0.3"
					If RunVersionScript(conn, "sql_ver_01.00.04.sql") Then
						SetPiconnVariant(conn, "Version", "1.0.4")
					Else
						msg = "Ver:1.0.4 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.0.4"
					If RunVersionScript(conn, "sql_ver_01.00.05.sql") Then
						SetPiconnVariant(conn, "Version", "1.0.5")
					Else
						msg = "Ver:1.0.5 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.0.5"
					If RunVersionScript(conn, "sql_ver_01.00.06.sql") Then
						SetPiconnVariant(conn, "Version", "1.0.6")
					Else
						msg = "Ver:1.0.6 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.0.6"
					If RunVersionScript(conn, "sql_ver_01.00.07.sql") Then
						SetPiconnVariant(conn, "Version", "1.0.7")
					Else
						msg = "Ver:1.0.7 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.0.7"
					If RunVersionScript(conn, "sql_ver_01.00.08.sql") Then
						SetPiconnVariant(conn, "Version", "1.0.8")
					Else
						msg = "Ver:1.0.8 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.0.8"
					If RunVersionScript(conn, "sql_ver_01.00.09.sql") Then
						SetPiconnVariant(conn, "Version", "1.0.9")
					Else
						msg = "Ver:1.0.9 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.0.9"
					If RunVersionScript(conn, "sql_ver_01.00.10.sql") Then
						SetPiconnVariant(conn, "Version", "1.0.10")
					Else
						msg = "Ver:1.0.10 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar

				Case "1.0.10"
					If RunVersionScript(conn, "sql_ver_01.00.11.sql") Then
						SetPiconnVariant(conn, "Version", "1.0.11")
					Else
						msg = "Ver:1.0.11 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.0.11", "1.0.12"
					If RunVersionScript(conn, "sql_ver_01.00.13.sql") Then
						SetPiconnVariant(conn, "Version", "1.0.13")
					Else
						msg = "Ver:1.0.13 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar

				Case "1.0.13"
					If RunVersionScript(conn, "sql_ver_01.00.14.sql") Then
						SetPiconnVariant(conn, "Version", "1.0.14")
					Else
						msg = "Ver:1.0.14 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.0.14"
					If RunVersionScript(conn, "sql_ver_01.00.15.sql") Then
						SetPiconnVariant(conn, "Version", "1.0.15")
					Else
						msg = "Ver:1.0.15 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.0.15", "1.0.16"
					If RunVersionScript(conn, "sql_ver_01.00.17.sql") Then
						SetPiconnVariant(conn, "Version", "1.0.17")
					Else
						msg = "Ver:1.0.17 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar

				Case "1.0.17", "1.0.18", "1.0.19"
					If RunVersionScript(conn, "sql_ver_01.00.20.sql") Then
						SetPiconnVariant(conn, "Version", "1.0.20")
					Else
						msg = "Ver:1.0.20 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar

				Case "1.0.20"
					If RunVersionScript(conn, "sql_ver_01.00.21.sql") Then
						SetPiconnVariant(conn, "Version", "1.0.21")
					Else
						msg = "Ver:1.0.21 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar

				Case "1.0.21"
					If RunVersionScript(conn, "sql_ver_01.00.22.sql") Then
						SetPiconnVariant(conn, "Version", "1.0.22")
					Else
						msg = "Ver:1.0.22 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar

				Case "1.0.22", "1.0.23"
					If RunVersionScript(conn, "sql_ver_01.00.24.sql") Then
						SetPiconnVariant(conn, "Version", "1.0.24")
					Else
						msg = "Ver:1.0.24 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.0.24"
					If RunVersionScript(conn, "sql_ver_01.00.25.sql") Then
						SetPiconnVariant(conn, "Version", "1.0.25")
					Else
						msg = "Ver:1.0.25 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.0.25"
					If RunVersionScript(conn, "sql_ver_01.00.26.sql") Then
						SetPiconnVariant(conn, "Version", "1.0.26")
					Else
						msg = "Ver:1.0.26 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.0.26"
					If RunVersionScript(conn, "sql_ver_01.00.27.sql") Then
						SetPiconnVariant(conn, "Version", "1.0.27")
					Else
						msg = "Ver:1.0.27 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.0.27"
					If RunVersionScript(conn, "sql_ver_01.01.01.sql") Then
						SetPiconnVariant(conn, "Version", "1.1.1")
					Else
						msg = "Ver:1.1.1 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.1.1"
					If RunVersionScript(conn, "sql_ver_01.01.02.sql") Then
						SetPiconnVariant(conn, "Version", "1.1.2")
					Else
						msg = "Ver:1.1.2 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.1.2", "1.1.3"
					If RunVersionScript(conn, "sql_ver_01.01.04.sql") Then
						SetPiconnVariant(conn, "Version", "1.1.4")
					Else
						msg = "Ver:1.1.4 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.1.4", "1.1.5", "1.1.6", "1.1.7"
					If RunVersionScript(conn, "sql_ver_01.01.08.sql") Then
						SetPiconnVariant(conn, "Version", "1.1.8")
					Else
						msg = "Ver:1.1.8 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.1.8"
					If RunVersionScript(conn, "sql_ver_01.02.01.sql") Then
						SetPiconnVariant(conn, "Version", "1.2.1")
					Else
						msg = "Ver:1.2.1 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.2.1"
					If RunVersionScript(conn, "sql_ver_01.02.02.sql") Then
						SetPiconnVariant(conn, "Version", "1.2.2")
					Else
						msg = "Ver:1.2.2 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.2.2"
					If RunVersionScript(conn, "sql_ver_01.02.03.sql") Then
						SetPiconnVariant(conn, "Version", "1.2.3")
					Else
						msg = "Ver:1.2.3 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.2.3"
					If RunVersionScript(conn, "sql_ver_01.02.04.sql") Then
						SetPiconnVariant(conn, "Version", "1.2.4")
					Else
						msg = "Ver:1.2.4 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.2.4"
					If RunVersionScript(conn, "sql_ver_01.02.05.sql") Then
						SetPiconnVariant(conn, "Version", "1.2.5")
					Else
						msg = "Ver:1.2.5 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.2.5"
					If RunVersionScript(conn, "sql_ver_01.02.06.sql") Then
						SetPiconnVariant(conn, "Version", "1.2.6")
					Else
						msg = "Ver:1.2.6 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.2.6"
					If RunVersionScript(conn, "sql_ver_01.02.07.sql") Then
						SetPiconnVariant(conn, "Version", "1.2.7")
					Else
						msg = "Ver:1.2.7 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.2.7"
					If RunVersionScript(conn, "sql_ver_01.02.08.sql") Then
						SetPiconnVariant(conn, "Version", "1.2.8")
					Else
						msg = "Ver:1.2.8 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.2.8", "1.2.9", "1.2.10"
					If RunVersionScript(conn, "sql_ver_01.02.11.sql") Then
						SetPiconnVariant(conn, "Version", "1.2.11")
					Else
						msg = "Ver:1.2.11 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.2.11"
					If RunVersionScript(conn, "sql_ver_01.02.12.sql") Then
						SetPiconnVariant(conn, "Version", "1.2.12")
					Else
						msg = "Ver:1.2.12 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.2.12"
					If RunVersionScript(conn, "sql_ver_01.02.13.sql") Then
						SetPiconnVariant(conn, "Version", "1.2.13")
					Else
						msg = "Ver:1.2.13 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.2.13"
					If RunVersionScript(conn, "sql_ver_01.02.14.sql") Then
						SetPiconnVariant(conn, "Version", "1.2.14")
					Else
						msg = "Ver:1.2.14 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.2.14"
					If RunVersionScript(conn, "sql_ver_01.02.15.sql") Then
						SetPiconnVariant(conn, "Version", "1.2.15")
					Else
						msg = "Ver:1.2.15 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.2.15"
					If RunVersionScript(conn, "sql_ver_01.03.03.sql") Then
						SetPiconnVariant(conn, "Version", "1.3.3")
					Else
						msg = "Ver:1.3.3 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.3.3"
					If RunVersionScript(conn, "sql_ver_01.03.04.sql") Then
						SetPiconnVariant(conn, "Version", "1.3.4")
					Else
						msg = "Ver:1.3.4 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.3.4"
					If RunVersionScript(conn, "sql_ver_01.03.05.sql") Then
						SetPiconnVariant(conn, "Version", "1.3.5")
					Else
						msg = "Ver:1.3.5 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.3.5"
					If RunVersionScript(conn, "sql_ver_01.03.06.sql") Then
						SetPiconnVariant(conn, "Version", "1.3.6")
					Else
						msg = "Ver:1.3.6 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.3.6"
					If RunVersionScript(conn, "sql_ver_01.04.02.sql") Then
						SetPiconnVariant(conn, "Version", "1.4.2")
					Else
						msg = "Ver:1.4.2 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.4.2"
					SetPiconnVariant(conn, "Version", "1.5.1")
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
				Case "1.5.1"
					If RunVersionScript(conn, "sql_ver_01.05.02.sql") Then
						SetPiconnVariant(conn, "Version", "1.5.2")
					Else
						msg = "Ver:1.5.2 " & AppConn.PiconnLanguage.TText("versiyon geçişinde hata oluştu.")
						bError = True
					End If
					bVersionExecuted = True
					If bError = False Then GoTo Tekrar
			End Select



			If bError Then
				If MsgBox("[FIRM DB ERROR] " & msg & vbNewLine & "Devam ederseniz veri bütünlügünüz bozulabilir! Devam etmek istediginizden emin misiniz?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Devam?") <> MsgBoxResult.Yes Then
					Return False
				Else
					Return True
				End If
			End If

			sPrgVer = VersionStrCorrect(ProgramVersion)
			sActiveVersion = GetPiconnVariant(conn, "Version")
			sDBVer = VersionStrCorrect(sActiveVersion)
			If sPrgVer < sDBVer Then
				If Mid(sPrgVer, 1, 2) <> Mid(sDBVer, 1, 2) Then
					MsgBox("Major versiyonlar farkli! Programi bu veri tabaninda çaliştiramazsiniz!")
					Return False
				End If
				If MsgBox("[FIRM DB ERROR] " & AppConn.PiconnLanguage.TText("Program Versiyon:") & ProgramVersion & "   " & AppConn.PiconnLanguage.TText("Veri Tabani Versiyonu:") & sActiveVersion & vbNewLine & AppConn.PiconnLanguage.TText("Program versiyonu yüklü olan veri tabani versiyonundan küçük.") & vbNewLine &
																		AppConn.PiconnLanguage.TText("Veri kaybi yaşayabilirsiniz. Lütfen programinizi yükseltiniz. Devam etmek istiyor musunuz?"), MsgBoxStyle.Critical + MsgBoxStyle.YesNo, AppConn.PiconnLanguage.TText("Uyari!")) <> MsgBoxResult.Yes Then
					Return False
				Else
					Return True
				End If
			End If

			Return True
		Catch ex As Exception
			MsgBox("(LocalVersionControl)" & ex.Message)
			Return False
		End Try

	End Function





	Public Function VersionStrCorrect(ByVal Ver As String) As String
		Dim sbuf As String = ""
		Dim ch As String = ""
		Dim i As Integer
		If Trim(Ver) = "" Then Return ""
		If Mid(Ver, Len(Ver), 1) <> "." Then Ver &= "."
		i = 0
		Do While Split(Ver, ".")(i) <> ""
			ch = Split(Ver, ".")(i)
			If IsNumeric(ch) Then
				sbuf &= Format(CInt(ch), "0000") & "."
			Else
				sbuf &= ch & "."
			End If
			i += 1
		Loop
		If Trim(sbuf) <> "" Then
			If Mid(sbuf, Len(sbuf), 1) = "." Then
				sbuf = Mid(sbuf, 1, Len(sbuf) - 1)
			End If
		End If
		Return sbuf

	End Function

	Public Function VersionStrCorrect2Digit(ByVal Ver As String) As String
		Dim sbuf As String = ""
		Dim ch As String = ""
		Dim i As Integer
		If Trim(Ver) = "" Then Return ""
		If Mid(Ver, Len(Ver), 1) <> "." Then Ver &= "."
		i = 0
		Do While Split(Ver, ".")(i) <> ""
			ch = Split(Ver, ".")(i)
			If IsNumeric(ch) Then
				sbuf &= Format(CInt(ch), "00") & "."
			Else
				sbuf &= ch & "."
			End If
			i += 1
		Loop
		If Trim(sbuf) <> "" Then
			If Mid(sbuf, Len(sbuf), 1) = "." Then
				sbuf = Mid(sbuf, 1, Len(sbuf) - 1)
			End If
		End If
		Return sbuf

	End Function

	Public Function RunVersionScript(ByVal conn As SqlClient.SqlConnection, ByVal ScriptFileName As String) As Boolean
		Dim cmd As New SqlClient.SqlCommand
		Dim SQL As String = ""
		Dim subSQL As String = ""
		Dim i As Integer
		Dim sr As System.IO.StreamReader
		Dim FileName As String = GetMyDir() & "\DBScripts\" & ScriptFileName
		Try

			If IO.File.Exists(FileName) = False Then
				MsgBox(FileName & " bulunamadi.")
				Return False
			End If
			sr = New IO.StreamReader(FileName)
			SQL = sr.ReadToEnd
			sr.Close()
			sr.Dispose()
			If Trim(SQL) = "" Then
				MsgBox(FileName & " script boş.")
				Return False
			End If
			i = 0
			SQL &= vbNewLine & vbNewLine
			cmd.Connection = conn
			Try
				subSQL = Split(SQL, "GO" & vbNewLine)(i)
			Catch ex As Exception
				subSQL = ""
			End Try
			If subSQL = "" Then subSQL = SQL
			Do While subSQL <> ""

				cmd.CommandText = subSQL
				cmd.ExecuteNonQuery()
				i += 1
				Try
					subSQL = Split(SQL, "GO" & vbNewLine)(i)
				Catch ex As Exception
					subSQL = ""
				End Try
			Loop


			cmd.Dispose()
			Return True
		Catch ex As Exception
			MsgBox("(RunVersionScript) FileName:" & ScriptFileName & vbNewLine & ex.Message)
			Return False
		End Try

	End Function

	Public Function VariantTableControl(ByVal Conn As SqlClient.SqlConnection) As Boolean
		Dim cmd As New SqlClient.SqlCommand
		Dim rs As SqlClient.SqlDataReader
		Dim bFound As Boolean = False
		Try

			cmd.Connection = Conn
			cmd.CommandText = "SELECT * FROM sysobjects WHERE (xtype = 'U') AND (name = N'Piconn_Variants')"
			rs = cmd.ExecuteReader
			If rs.Read Then
				bFound = True
			End If
			rs.Close()
			If bFound = False Then

				MsgBox("Piconn_Variants Tablosu bulunamadi! Lütfen sistem yöneticiniz ile görüşünüz.")
				Return False
			Else
				Return True
			End If

		Catch ex As Exception
			MsgBox("(VariantTableControl)" & ex.Message)
			Return False
		End Try

	End Function

End Module
