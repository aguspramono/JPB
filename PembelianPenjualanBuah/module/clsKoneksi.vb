Imports System.Net   'Web
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports System.Data.OleDb

Public Class clsKoneksi
    Public Shared connetionString As String
    Public Shared connectionMain1 As OleDbConnection
    Public Shared connectionMain2 As OleDbConnection
    Public Shared connectionMain3 As OleDbConnection

    Public Shared kodeKota As String = "1"
    Public Shared namaKota As String = "Libo"

    Public Shared userNameGlobal As String
    'Public Shared connectionMain As MySqlConnection
    Public Shared kotaOn As String = "1"
    'admin
    Public Shared userNameAdmin As String = Decrypt("d2QhWrTXpVVbHTThaK4Mzw==")
    '7102drowssap
    Public Shared passWordAdmin As String = Decrypt("Fio2QBRti6TLWT+gM5DK5wgK+z0zl4g7sKXzt0GvBto=")
    Public Shared userNameLogin As String
    Public Shared passWordLogin As String
    Public Shared letakDatabase As String
    'excel80timbang
    'Public Shared passwordExcel As String = Decrypt("D4lG1NS/VYPlhcnKfdjLoHrHB/Bj6qqgSMBPGLDlPgs=")
    'nggaktauaku
    Public Shared passwordExcel As String = Decrypt("WB6x3OQhY3UqbRXBzzanlhaXKUb0TvW/SJ0vJalm7IE=")
    Public Shared passwordDatabaseAccess As String = Decrypt("hzE7fuDza7tjdXeaCNGPClXpgbWkulLwBW/wgSJr1xM=")
    Public Shared FILE_NAME As String = Application.StartupPath + "\Settings.txt"

    'Public Shared idSQL As String = Decrypt("lyCq3lLp7H5Npw3E0WgjYQ==")
    'Public Shared passSQL As String = Decrypt("APhG+X4fh+JG2HE6VTkUWsjkpltZQlXCK/O/fBOqKDw=")
    'datarudi_user2
    Public Shared idSQL As String = Decrypt("lNhwQRVpBDqvDHqD/Hs5M5Y2rGTKRN514pHpDx0PnKs=")
    'userke2
    Public Shared passSQL As String = Decrypt("Uh9hGL7KYenNk7yO4KyPJA==")
    'datarudi.com
    Public Shared serverSQL As String = Decrypt("lNhwQRVpBDqvDHqD/Hs5M/g8UvtvBhU4i80EDEFKccE=")
    'datarudi_kebun
    Public Shared databaseSQL As String = Decrypt("lNhwQRVpBDqvDHqD/Hs5MyywO9N2WCumQGFySFcfSQM=")
    'amagra@datarudi.com
    Public Shared ftpUsername As String = Decrypt("TSqNSXqtTmRHovhEsOmDKgK4NKWqsExI9Kv1HDSonlv0sAh/v7jOIBFUl5yzi2Ka")
    'Amagra91
    Public Shared ftpPassword As String = Decrypt("h6jd+0WhnNo2VuM92MnSV3od7pmYZvznEzsSV4HiyHs=")

    Public Shared Sub createNewConnection()
        'connetionString = "Data Source=localhost;Initial Catalog=PembelianPenjualanBuah;User ID=sa;Password=654321"
        'connetionString = "Data Source=127.0.0.1;Initial Catalog=PembelianPenjualanBuah;User ID=sa;Password=admin@SSA1"

        ' connetionString = "Data Source=" & serverSQL & ";Initial Catalog=" & databaseSQL & ";User ID=" & idSQL & ";Password=" & passSQL & ";"
        ' connectionMainS = New SqlConnection(connetionString)

        'connetionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=config.mdb;Password=1010101010;"

        If frmMainMenu.txtDatabase.Text = "" Then
            MessageBox.Show("Database belum disetting", "warning")
            frmSettingDatabase.ShowDialog()
            Return
        Else

        End If

        If File.Exists(frmMainMenu.txtDatabase.Text) Then
        Else
            MessageBox.Show("File Database Tidak Ditemukan", "Warning")
            frmSettingDatabase.ShowDialog()
            Return
        End If

        connetionString = "Provider=Microsoft.ACE.OLEDB.12.0.0;Data Source=" & frmMainMenu.txtDatabase.Text & ";Jet OLEDB:Database Password=@JPB2021;"
        connectionMain1 = New OleDbConnection(connetionString)
        'connetionString = "Provider=Microsoft.ACE.OLEDB.12.0.0;Data Source=" & Application.StartupPath & "\customer.mdb;Jet OLEDB:Database Password=customer91ssa;"
        'connectionMain2 = New OleDbConnection(connetionString)
    End Sub

    ''' <summary>
    ''' select*from customer where NoAccount=@NoAccount kalo pake like WHERE (body LIKE '%' + @query + '%') 
    ''' </summary>
    ''' <param name="myQuery">select*from customer where NoAccount=@NoAccount kalo pake like WHERE (body LIKE '%' + @query + '%')</param>
    ''' <param name="namaKolom">Nama Kolom </param>
    ''' <param name="isiKolom">Isi Kolom</param>
    ''' <param name="opt">Isi 1 kalo mau pake kolom</param>
    ''' 
    Public Shared Function selectCommand(ByVal pilihan As Integer, ByVal myQuery As String, Optional ByVal namaKolom As String() = Nothing, Optional ByVal isiKolom As Object() = Nothing, Optional ByVal opt As Integer = 0) As DataSet
        Dim ds As New DataSet()
        Try
            Dim dt As New DataTable()
            Dim cmd As New OleDbCommand
            cmd.Connection = getConnection(pilihan)
            cmd.Connection.Close()
            cmd.Connection.Open()
            cmd.CommandText = myQuery
            If opt = 1 Then
                For i As Integer = 0 To namaKolom.Length - 1
                    cmd.Parameters.AddWithValue("@" + namaKolom(i), isiKolom(i))
                Next
            End If
            Console.WriteLine(myQuery)
            Dim da As New OleDbDataAdapter(cmd)
            da.Fill(dt)
            ds.Tables.Add(dt)
            cmd.Connection.Close()
            Return ds

        Catch ex As System.Exception
            MessageBox.Show(ex.Message, "warning")
            Return ds
        End Try
    End Function

    ''' <summary>
    ''' Login
    ''' </summary>
    ''' <param name="userName">Username</param>
    ''' <param name="passWord">IsiPassword</param>
    ''' 
    Public Shared Function loginAccount(ByVal pilihan As Integer, ByVal userName As String, ByVal passWord As String) As Boolean
        Dim dsSet As New DataSet()

        'Try
        Using cmd As New OleDbCommand("select*from UserAccount where NamaPengguna=@userid and KataSandi=@passid", getConnection(pilihan))
            cmd.Parameters.AddWithValue("@userid", userName)
            cmd.Parameters.AddWithValue("@passid", passWord)
            cmd.Connection.Close()
            cmd.Connection.Open()
            Dim dap As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            dap.Fill(dsSet)
            cmd.Connection.Close()

            If dsSet.Tables(0).Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        End Using
        'Catch ex As Exception
        '    MessageBox.Show("Cek Koneksi", "warning")
        '    Return False
        'End Try
    End Function

    ''' <summary>
    ''' "UPDATE TableName SET ColoumnName = @ColoumnName WHERE kondisi = 1"
    ''' </summary>
    ''' <param name="myQuery">Isi dengan "UPDATE namaTable SET "</param>
    ''' <param name="namaKolom">Nama Kolom </param>
    ''' <param name="isiKolom">Isi Kolom</param>
    ''' <param name="kondisiWhere">Kondisi "where NoAccount =@NoAccount2"</param>
    ''' <param name="namaKolom2">Nama Kolom Where @NoAccount2</param>
    ''' <param name="isiKolom2">Isi Kolom where @NoAccount2</param>
    ''' <param name="opt">isi 1 kalo mau pakai namakolom2 di where,opt 2 cm mau pakai namakolom2 di where</param>
    ''' 
    Public Shared Sub updateCommand(ByVal pilihan As Integer, ByVal myQuery As String, ByVal namaKolom As String(), ByVal isiKolom As Object(), ByVal kondisiWhere As String, Optional ByVal namaKolom2 As String() = Nothing, Optional ByVal isiKolom2 As Object() = Nothing, Optional ByVal opt As Integer = 0)
        'Try
        Dim cmd As New OleDbCommand
        cmd.Connection = getConnection(pilihan)
        cmd.Connection.Close()
        cmd.Connection.Open()

        If opt = 2 Then
            For j As Integer = 0 To namaKolom2.Length - 1
                cmd.Parameters.AddWithValue("@" + namaKolom2(j).Replace("[", "").Replace("]", ""), isiKolom2(j))
            Next
        Else
            For i As Integer = 0 To namaKolom.Length - 1
                If i = 0 Then
                    myQuery = myQuery + namaKolom(i) + "= @" + namaKolom(i).Replace("[", "").Replace("]", "")
                Else
                    myQuery = myQuery + "," + namaKolom(i) + "= @" + namaKolom(i).Replace("[", "").Replace("]", "")
                End If
                cmd.Parameters.AddWithValue("@" + namaKolom(i).Replace("[", "").Replace("]", ""), isiKolom(i))
            Next
            If opt = 1 Then
                For j As Integer = 0 To namaKolom2.Length - 1
                    cmd.Parameters.AddWithValue("@" + namaKolom2(j).Replace("[", "").Replace("]", ""), isiKolom2(j))
                Next
            End If

        End If
        cmd.CommandText = myQuery + " " + kondisiWhere
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
        'Catch ex As System.Exception
        ' MessageBox.Show(ex.Message, "warning")
        ''lblValid.Text = (ex.Message)
        'End Try
    End Sub

    ''' <summary>
    ''' INSERT INTO Customer (NoAccount,Nama,Telp,Alamat,Kota,NoAccountParent,Keterangan) VALUES (NoAccount,Nama,Telp,Alamat,Kota,NoAccountParent,Keterangan)
    ''' </summary>
    ''' <param name="myQuery">Isi dengan "INSERT INTO namaTable  "</param>
    ''' <param name="namaKolom">Nama Kolom </param>
    ''' <param name="isiKolom">Isi Kolom</param>
    ''' 
    Public Shared Sub insertCommand(ByVal pilihan As Integer, ByVal myQuery As String, ByVal namaKolom As String(), ByVal isiKolom As Object())
        'Try
        Dim cmd As New OleDbCommand
        cmd.Connection = getConnection(pilihan)
        cmd.Connection.Close()
        cmd.Connection.Open()

        Dim query1 As String = ""
        Dim query2 As String = ""
        Dim jlhInsert As Integer = isiKolom.Length / namaKolom.Length
        If jlhInsert = 1 Then
            For i As Integer = 0 To namaKolom.Length - 1
                If i = 0 Then
                    query1 = query1 + namaKolom(i)
                    query2 = query2 + "@" + namaKolom(i).Replace("[", "").Replace("]", "")
                Else
                    query1 = query1 + "," + namaKolom(i)
                    query2 = query2 + "," + "@" + namaKolom(i).Replace("[", "").Replace("]", "")
                End If
            Next
            myQuery = myQuery + "(" + query1 + ") Values (" + query2 + ")"
            For i As Integer = 0 To namaKolom.Length - 1
                cmd.Parameters.AddWithValue("@" + namaKolom(i).Replace("[", "").Replace("]", ""), isiKolom(i))
            Next
        Else
            For i As Integer = 0 To jlhInsert - 1
                If i = 0 Then
                    query2 = "("
                Else
                    query2 = query2 + ",("
                End If
                For j As Integer = 0 To namaKolom.Length - 1
                    If i = 0 Then
                        If j = 0 Then
                            query1 = query1 + namaKolom(j)
                        Else
                            query1 = query1 + "," + namaKolom(j)
                        End If
                    End If
                    If j = 0 Then
                        query2 = query2 + "@" + namaKolom(j).Replace("[", "").Replace("]", "") + i.ToString
                    Else
                        query2 = query2 + "," + "@" + namaKolom(j).Replace("[", "").Replace("]", "") + i.ToString
                    End If
                Next
                query2 = query2 + ")"
            Next
            myQuery = myQuery + "(" + query1 + ") Values " + query2 + ""
            Dim cntJlh As Integer = 0
            For i As Integer = 0 To jlhInsert - 1
                For j As Integer = 0 To namaKolom.Length - 1
                    cmd.Parameters.AddWithValue("@" & namaKolom(j).Replace("[", "").Replace("]", "") & i.ToString, isiKolom(cntJlh))
                    cntJlh += 1
                Next
            Next
        End If
        cmd.CommandText = myQuery
        Console.WriteLine(myQuery)
        cmd.ExecuteNonQuery()

        cmd.Connection.Close()
        'Catch ex As System.Exception
        '    MessageBox.Show(ex.Message, "warning")
        '    'lblValid.Text = (ex.Message)
        'End Try
    End Sub

    ''' <summary>
    ''' INSERT INTO Customer (NoAccount,Nama,Telp,Alamat,Kota,NoAccountParent,Keterangan) VALUES (NoAccount,Nama,Telp,Alamat,Kota,NoAccountParent,Keterangan)
    ''' </summary>
    ''' <param name="myQuery">Isi dengan "INSERT INTO namaTable  "</param>
    ''' <param name="namaKolom">Nama Kolom </param>
    ''' <param name="isiKolom">Isi Kolom</param>
    ''' 
    Public Shared Sub insertCommand2(ByVal pilihan As Integer, ByVal myQuery As String, ByVal namaKolom As String(), ByVal isiKolom As Object())
        'Try

        Dim cmd As New OleDbCommand
        cmd.Connection = getConnection(pilihan)
        cmd.Connection.Close()
        cmd.Connection.Open()
        Dim isikolomT As Object() = isiKolom
        Dim rZ As Integer = Math.Ceiling(isikolomT.Length / namaKolom.Length / 60) - 1

        Dim myQueryT As String = myQuery
        For zz As Integer = 0 To rZ
            If zz = rZ Then
                ReDim isiKolom(isikolomT.Length - (zz * namaKolom.Length * 60) - 1)
            Else
                ReDim isiKolom(60 * namaKolom.Length - 1)
            End If
            Dim t As Integer = 0
            For k As Integer = zz * namaKolom.Length * 60 To (zz * namaKolom.Length * 60) + (60 * namaKolom.Length)
                If k > (zz * namaKolom.Length * 60) + isiKolom.Length - 1 Then
                    Exit For
                End If
                isiKolom(t) = isikolomT(k)
                t += 1
            Next

            Dim query1 As String = ""
            Dim query2 As String = ""
            myQuery = myQueryT
            Dim jlhInsert As Integer = isiKolom.Length / namaKolom.Length '100 / 10 = 10
            If jlhInsert = 0 Then
                Return
            End If
            If jlhInsert = 1 Then
                For i As Integer = 0 To namaKolom.Length - 1
                    If i = 0 Then
                        query1 = query1 & namaKolom(i)
                        query2 = query2 & isiKolom(i)
                    Else
                        query1 = query1 & "," & namaKolom(i)
                        query2 = query2 & "," & isiKolom(i)
                    End If
                Next
                myQuery = myQuery & "(" & query1 & ") Values (" & query2 & ")"
            Else
                Dim cntJlh As Integer = 0
                For i As Integer = 0 To jlhInsert - 1 '10 kali
                    If i = 0 Then
                        query2 = "SELECT TOP 1 "
                    Else
                        If i Mod 20 = 0 And i > 18 Then
                            query2 &= ") union all select " & query1 & " from( Select TOP 1 "
                        Else
                            query2 = query2 & " UNION Select TOP 1 "
                        End If
                    End If

                    For j As Integer = 0 To namaKolom.Length - 1
                        If i = 0 Then
                            If j = 0 Then
                                query1 = query1 & namaKolom(j)
                            Else
                                query1 = query1 & "," & namaKolom(j)
                            End If
                        End If
                        If j = 0 Then
                            query2 = query2 & isiKolom(cntJlh) & " as " & namaKolom(j)
                        Else
                            query2 = query2 & "," & isiKolom(cntJlh) & " as " & namaKolom(j)
                        End If
                        cntJlh += 1
                    Next
                    query2 = query2 & " from UserAccount "
                Next
                myQuery = myQuery & "(" & query1 & ") select " & query1 & " from( select " & query1 & " from( " & query2 & "))"

                'Dim cntJlh As Integer = 0
                'For i As Integer = 0 To jlhInsert - 1
                '    For j As Integer = 0 To namaKolom.Length - 1
                '        cmd.Parameters.AddWithValue("@" & namaKolom(j).Replace("[", "").Replace("]", "") & i.ToString, isiKolom(cntJlh))
                '        cntJlh += 1
                '    Next
                'Next
            End If
            cmd.CommandText = myQuery
            cmd.ExecuteNonQuery()
            'Console.WriteLine(myQuery)
        Next



        cmd.Connection.Close()
        'Catch ex As System.Exception
        '    MessageBox.Show(ex.Message, "warning")
        'Finally
        'End Try
    End Sub

    ''' <summary>
    ''' "Delete From TableName where ColumnName= 'asdasdasdasdas'"
    ''' </summary>
    ''' <param name="myQuery">Isi dengan "Delete From TableName where ColumnName= 'asdasdasdasdas'"</param>
    ''' <param name="namaKolom">Nama Kolom </param>
    ''' <param name="isiKolom">Isi Kolom</param>
    ''' <param name="opt">Isi 1 kalo mau pake kolom</param>
    ''' 
    Public Shared Sub deleteCommand(ByVal pilihan As Integer, ByVal myQuery As String, Optional ByVal namaKolom As String() = Nothing, Optional ByVal isiKolom As Object() = Nothing, Optional ByVal opt As Integer = 0)
        Try
            Dim cmd As New OleDbCommand
            cmd.Connection = getConnection(pilihan)
            cmd.Connection.Close()
            cmd.Connection.Open()

            cmd.CommandText = myQuery

            If opt = 1 Then
                For i As Integer = 0 To namaKolom.Length - 1
                    cmd.Parameters.AddWithValue("@" + namaKolom(i), isiKolom(i))
                Next
            End If

            cmd.ExecuteNonQuery()

            cmd.Connection.Close()
        Catch ex As System.Exception
            MessageBox.Show(ex.Message, "warning")
            'lblValid.Text = (ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="pilihan"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function getConnection(Optional ByVal pilihan As Integer = 1) As OleDbConnection
        Select Case pilihan
            Case 1
                Return connectionMain1
            Case 2
                Return connectionMain2
            Case 3
                Return connectionMain3
            Case Else
                Return connectionMain1
        End Select
    End Function

    ''' <summary>
    ''' Remove MS-Access database
    ''' </summary>
    ''' <param name="FileName">Database to remove</param>
    ''' <param name="WaitTime">Sleep time</param>
    ''' <param name="Loops">How many attempts to try</param>
    ''' <remarks></remarks>
    Public Shared Function RemoveAccessDatabase(ByVal FileName As String, ByVal WaitTime As Integer, ByVal Loops As Integer) As Boolean

        Dim Success As Boolean = False

        Dim LockFile As String = IO.Path.ChangeExtension(FileName, "ldb")

        For Counter As Integer = 0 To Loops
            If IO.File.Exists(LockFile) Then
                System.Threading.Thread.Sleep(WaitTime)
                IO.File.Delete(FileName)
            Else
                Success = True
                Exit For
            End If
        Next

        Return Success
    End Function


    ''' <summary>
    ''' Remove MS-Access database
    ''' </summary>
    ''' <param name="FileName">Database to remove</param>
    ''' <param name="WaitTime">Sleep time</param>
    ''' <param name="Loops">How many attempts to try</param>
    ''' <remarks></remarks>
    Public Shared Function RemoveImage(ByVal FileName As String, ByVal WaitTime As Integer, ByVal Loops As Integer) As Boolean
        Dim Success As Boolean = False
        Dim LockFile As String = IO.Path.ChangeExtension(FileName, "ldb")
        For Counter As Integer = 0 To Loops
            If IO.File.Exists(LockFile) Then
                System.Threading.Thread.Sleep(WaitTime)
                IO.File.Delete(FileName)
            Else
                Success = True
                Exit For
            End If
        Next
        Return Success
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="clearText"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function Encrypt(ByVal clearText As String) As String
        Dim EncryptionKey As String = "4magra"
        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, _
             &H65, &H64, &H76, &H65, &H64, &H65, _
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(clearBytes, 0, clearBytes.Length)
                    cs.Close()
                End Using
                clearText = Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
        Return clearText
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="cipherText"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function Decrypt(ByVal cipherText As String) As String
        Try
            Dim EncryptionKey As String = "4magra"
            Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
            Using encryptor As Aes = Aes.Create()
                Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, _
                 &H65, &H64, &H76, &H65, &H64, &H65, _
                 &H76})
                encryptor.Key = pdb.GetBytes(32)
                encryptor.IV = pdb.GetBytes(16)
                Using ms As New MemoryStream()
                    Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                        cs.Write(cipherBytes, 0, cipherBytes.Length)
                        cs.Close()
                    End Using
                    cipherText = Encoding.Unicode.GetString(ms.ToArray())
                End Using
            End Using
            Return cipherText
        Finally
            'Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>

    Public Shared Sub loadData()
        Try
            'awal login

            If File.Exists(FILE_NAME) = True Then
                Dim content2 As String() = ReadFile(FILE_NAME)

                serverSQL = Decrypt(content2(0))
                databaseSQL = Decrypt(content2(1))

            Else
                'Setting Awal
                MessageBox.Show("File Setting Tidak ditemukan, Program akan membuat file setting baru.", "warning")
                Dim objWriter As New StreamWriter(FILE_NAME)
                '192.168.0.110
                objWriter.WriteLine("j/AixpMxSonComwWCyabvNUQa44gRxbOMESyB+Od5z8=")
                'PembelianPenjualanBuah
                objWriter.WriteLine("qJRpTGu0j9JAjJ09lgp9HLGwYWod5vzNakoqMlUaKG/Nbg52rDFQHcT1EWK7ZXOo")
                objWriter.Close()

                serverSQL = Decrypt("j/AixpMxSonComwWCyabvNUQa44gRxbOMESyB+Od5z8=")
                databaseSQL = Decrypt("qJRpTGu0j9JAjJ09lgp9HLGwYWod5vzNakoqMlUaKG/Nbg52rDFQHcT1EWK7ZXOo")
            End If
        Catch ex As Exception
            MessageBox.Show("File Setting Rusak, Program akan membuat file setting baru.", "warning")
            Dim objWriter As New StreamWriter(FILE_NAME)
            '192.168.0.110
            objWriter.WriteLine("j/AixpMxSonComwWCyabvNUQa44gRxbOMESyB+Od5z8=")
            'PembelianPenjualanBuah
            objWriter.WriteLine("qJRpTGu0j9JAjJ09lgp9HLGwYWod5vzNakoqMlUaKG/Nbg52rDFQHcT1EWK7ZXOo")
            objWriter.Close()

            serverSQL = Decrypt("j/AixpMxSonComwWCyabvNUQa44gRxbOMESyB+Od5z8=")
            databaseSQL = Decrypt("qJRpTGu0j9JAjJ09lgp9HLGwYWod5vzNakoqMlUaKG/Nbg52rDFQHcT1EWK7ZXOo")
        End Try
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Filename"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ReadFile(ByVal Filename As String) As String()
        Dim Sl As New List(Of String)
        Using Sr As New StreamReader(Filename)
            While Sr.Peek >= 0
                Sl.Add(Sr.ReadLine())
            End While
        End Using

        Return Sl.ToArray
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="nilai"></param>
    ''' <param name="koma"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function Rounding(ByVal nilai, ByVal koma) As Decimal
        'If nilai is 
        If Double.IsInfinity(nilai) Or Double.IsNaN(nilai) Then
            Return 0
        End If
        Try
            Return Math.Round(nilai, koma, MidpointRounding.AwayFromZero)
        Catch ex As Exception
            Return nilai
        End Try
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="nama"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetCounter(ByVal nama) As String
        Dim myQuery As String = "select*from KodeCounter "
        Dim namaKolom As String() = {"Cari"}
        Dim isiKolom As Object() = {nama}
        myQuery = myQuery & "where KodeCounter=@cari"
        Dim tDs As DataSet = selectCommand(1, myQuery, namaKolom, isiKolom, 1)
        Dim isiView As Integer
        If tDs.Tables(0).Rows.Count = 0 Then
            Dim myQuery3 As String = "INSERT INTO KodeCounter "
            Dim namaKolom3 As String() = {"KodeCounter", "CounterJalan"}
            Dim isiKolom3 As Object() = {nama, 2}
            insertCommand(1, myQuery3, namaKolom3, isiKolom3)
            isiView = 1
        Else
            isiView = tDs.Tables(0).Rows(0).Item(1)
            Dim myQuery3 As String = "Update KodeCounter SET "
            Dim namaKolom3 As String() = {"KodeCounter", "CounterJalan"}
            Dim isiKolom3 As Object() = {nama, (isiView + 1)}
            Dim kondisiWhere As String = " where KodeCounter =@KodeCounter2"
            Dim namaKolom2 As String() = {"KodeCounter2"}
            Dim isiKolom2 As Object() = {nama}
            updateCommand(1, myQuery3, namaKolom3, isiKolom3, kondisiWhere, namaKolom2, isiKolom2, 1)
        End If
        Return isiView
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="e"></param>
    ''' <param name="bukaNo"></param>
    ''' <remarks></remarks>
    Public Shared Sub textBoxOnlyNumber(e As KeyPressEventArgs, Optional ByVal bukaNo As Object() = Nothing)
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers
        '44, 46. 
        Dim decimalSeparator As String = Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator
        Dim tNumber As Integer
        If decimalSeparator = "," Then
            tNumber = 44
        Else
            tNumber = 46
        End If
        If IsNothing(bukaNo) Then
        Else
            For i As Integer = 0 To bukaNo.Length - 1
                If Asc(e.KeyChar) = bukaNo(i) Then
                    Exit Sub
                End If
            Next
        End If

        If Asc(e.KeyChar) <> 8 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                    If Asc(e.KeyChar) = tNumber Then
                    Else
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="dateTime"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function tglAwalBulan(dateTime As DateTime) As DateTime
        Return New DateTime(dateTime.Year, dateTime.Month, 1)
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="dateTime"></param>
    ''' <returns></returns> 
    ''' <remarks></remarks>
    Public Shared Function tglAkhirBulan(dateTime As DateTime) As DateTime
        Dim firstDayOfTheMonth As New DateTime(dateTime.Year, dateTime.Month, 1)
        Return firstDayOfTheMonth.AddMonths(1).AddDays(-1)
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="pBox"></param>
    ''' <param name="pImage"></param>
    ''' <remarks></remarks>
    Public Shared Sub ResizePicture(ByVal pBox As PictureBox, ByVal pImage As Image)
        Dim lnewWidth As Integer, lnewHeight As Integer
        Dim lWidth As Integer = pImage.Width
        Dim lHeight As Integer = pImage.Height

        'If image Width > pictureBox Width, resize Width
        If lWidth > pBox.Width Then
            lnewWidth = pBox.Width 'New Width = PBox Width
            lHeight = Convert.ToInt32(lHeight * (lnewWidth / lWidth)) 'Risize Height keeping proportions
        Else
            lnewWidth = lWidth 'If not, keep the original Width value
        End If

        'If the image Height > The pictureBox Height, resize Height
        If lHeight > pBox.Height Then
            lnewHeight = pBox.Height  'New Height = PB Height
            lnewWidth = Convert.ToInt32(lnewWidth * (lnewHeight / lHeight))  'Risize Width keeping proportions
        Else
            lnewHeight = lHeight  'If not, use the same value
        End If

        Dim lBitmap As Bitmap = New System.Drawing.Bitmap(lnewWidth, lnewHeight)
        Dim lGr As Graphics = System.Drawing.Graphics.FromImage(lBitmap)

        'Add resized to Picturebox, if you want it centered: In Design mode, Change SizeMode property to CenterImage
        lGr.DrawImage(pImage, 0, 0, lnewWidth, lnewHeight)
        pBox.Image = lBitmap

        lGr.Dispose()
        lGr = Nothing
    End Sub

    ''' <summary>
    ''' mendapatkan nama file dari path yang di isi 
    ''' </summary>
    ''' <param name="tNamaFile">Isi dengan path beserta dengan nama file.</param>
    ''' 
    Public Shared Function getFileName(tNamaFile As String) As String
        Dim FileNameStart As Integer = tNamaFile.LastIndexOf("\") + 1
        Dim FileNameStop As Integer = tNamaFile.Length - FileNameStart
        Dim fileName As String = tNamaFile.Substring(FileNameStart, FileNameStop)

        Return fileName
    End Function

    ''' <summary>
    ''' mendapatkan File Extension dari path yang di isi 
    ''' </summary>
    ''' <param name="tNamaFile">Isi dengan path beserta dengan nama file.</param>
    ''' 
    Public Shared Function getFileExtension(tNamaFile As String) As String
        Dim FileNameStart As Integer = tNamaFile.LastIndexOf(".") + 1
        Dim FileNameStop As Integer = tNamaFile.Length - FileNameStart
        Dim fileName As String = tNamaFile.Substring(FileNameStart, FileNameStop)

        Return fileName
    End Function

    ''' <summary>
    ''' Mengambil data dari key/value dari item combo box yang terpilih 
    ''' </summary>
    ''' <param name="tComboBox">Isi dengan ComboBox yang dipilih.</param>
    ''' <param name="tPilih">0(default) mengambil key, 1 mengambil value</param>
    ''' 
    Public Shared Function getComboBoxKeyVal(tComboBox As ComboBox, Optional ByVal tPilih As Integer = 0)
        Dim key As String = DirectCast(tComboBox.SelectedItem, KeyValuePair(Of String, String)).Key
        Dim value As String = DirectCast(tComboBox.SelectedItem, KeyValuePair(Of String, String)).Value
        If tPilih = 0 Then
            Return key
        Else
            Return value
        End If
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="bytes"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function BytesConverter(ByVal bytes As Long) As String
        Dim KB As Long = 1024
        Dim MB As Long = KB * KB
        Dim GB As Long = KB * KB * KB
        Dim TB As Long = KB * KB * KB * KB
        Dim returnVal As String = "0 Bytes"

        Select Case bytes
            Case Is <= KB
                returnVal = bytes & " Bytes"
            Case Is > TB
                returnVal = (bytes / KB / KB / KB / KB).ToString("0.00") & " TB"
            Case Is > GB
                returnVal = (bytes / KB / KB / KB).ToString("0.00") & " GB"
            Case Is > MB
                returnVal = (bytes / KB / KB).ToString("0.00") & " MB"
            Case Is > KB
                returnVal = (bytes / KB).ToString("0.00") & " KB"
        End Select

        Return returnVal.ToString
    End Function


    Public Shared Sub OnlyNumber(e As KeyPressEventArgs, mynumber As TextBox)
        Select Case e.KeyChar
            Case CChar(vbBack) 'JIKA TOMBOL BACKSPACE
                e.Handled = False 'LANJUT INPUT
            Case "0"c, "1"c, "2"c, "3"c, "4"c, "5"c, "6"c, "7"c, "8"c, "9"c 'JIKA TOMBOL 0-9
                e.Handled = False
            Case "-"c 'JIKA TOMBOL - (MINUS)
                If mynumber.Text.Contains("-"c) = True Then 'JIKA TEXTBOX SUDAH PUNYA HURUF MINUS
                    e.Handled = True 'STOP INPUT
                Else 'JIKA TEXTBOX BELUM ADA HURUF MINUS
                    If mynumber.Text = String.Empty Then 'JIKA TEXTBOX MASIH KOSONG
                        e.Handled = False 'LANJUT INPUT HURUF MINUS
                    Else 'JIKA BELUM ADA HURUF MINUS TAPI SUDAH ADA ANGKA
                        e.Handled = True 'STOP INPUT HURUF MINUS
                    End If
                End If
            Case CChar(System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator) 'JIKA TOMBOL PEMISAH DESIMAL
                'JIKA SUDAH ADA HURUF PEMISAH DESIMAL
                If mynumber.Text.Contains(CChar(System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator)) = True Then
                    e.Handled = True 'STOP INPUT
                Else 'JIKA BELUM ADA HURUF PEMISAH DESIMAL
                    If mynumber.Text = String.Empty Then 'JIKA TEXTBOX MASIH KOSONG
                        'TAMBAHKAN O (NOL) DIDEPAN HURUF PEMISAH DESIMAL
                        mynumber.Text = "0"c & CChar(System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator)
                        'STOP INPUT
                        e.Handled = True
                        'PINDAHKAN CURSOR DITEXTBOX KE BELAKANG TEXT
                        mynumber.Select(mynumber.Text.Length, 0)
                    Else 'JIKA BELUM ADA HURUF PEMISAH DESIMAL TAPI SUDAH ADA ANGKA
                        e.Handled = False 'LANJUT INPUT
                    End If
                End If
            Case CChar(System.Globalization.NumberFormatInfo.CurrentInfo.NumberGroupSeparator) 'JIKA TOMBOL PEMISAH RIBUAN
                'JIKA SUDAH ADA HURUF PEMISAH DESIMAL
                If mynumber.Text.Contains(CChar(System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator)) = True Then
                    e.Handled = True 'STOP INPUT
                Else 'JIKA BELUM ADA HURUF PEMISAH DESIMAL
                    If mynumber.Text = String.Empty Then 'JIKA TEXTBOX MASIH KOSONG
                        'TAMBAHKAN O (NOL) DIDEPAN HURUF PEMISAH DESIMAL
                        mynumber.Text = "0"c & CChar(System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator)
                        'STOP INPUT
                        e.Handled = True
                        'PINDAHKAN CURSOR DITEXTBOX KE BELAKANG TEXT
                        mynumber.Select(mynumber.Text.Length, 0)
                    Else 'JIKA BELUM ADA HURUF PEMISAH DESIMAL TAPI SUDAH ADA ANGKA
                        e.KeyChar = CChar(System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator) 'LANJUT INPUT TAPI HURUFNYA DIUBAH
                    End If
                End If
            Case Else 'JIKA BUKA TOMBOL BACKSPACE, 0-9, -, PEMISAH DESIMAL, PEMISAH RIBUAN
                e.Handled = True 'STOP INPUT
        End Select
    End Sub


    Public Shared Function md5(sPassword As String) As String
        Dim x As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(sPassword)
        bs = x.ComputeHash(bs)
        Dim s As New System.Text.StringBuilder()
        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower())
        Next
        Return s.ToString()
    End Function



    Public Shared Function EmptyCount(ByVal dgrid As DataGridView, Optional ByVal intColumn As Integer = -1) As Integer
        Dim count As Integer = 0

        If dgrid IsNot Nothing AndAlso dgrid.Rows.Count > 0 Then
            If intColumn >= 0 Then 'Specific Column...
                If intColumn <= dgrid.Columns.Count Then
                    count = dgrid.Rows.Cast(Of DataGridViewRow).Where(Function(rs) Not rs.IsNewRow) _
                        .Select(Function(r) r.Cells(intColumn)).Where(Function(r) r.Value Is DBNull.Value _
                         OrElse String.IsNullOrEmpty(CStr(r.Value))).Count
                End If
            Else 'Any columns...
                count = dgrid.Rows.Cast(Of DataGridViewRow).Where(Function(rs) Not rs.IsNewRow) _
                         .Where(Function(r) r.Cells.Cast(Of DataGridViewCell).ToList _
                         .Any(Function(c) c.Value Is DBNull.Value _
                         OrElse String.IsNullOrEmpty(CStr(c.Value).Trim))).Count
            End If
        End If

        Return count
    End Function

End Class
