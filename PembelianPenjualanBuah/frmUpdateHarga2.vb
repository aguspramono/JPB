Public Class frmUpdateHarga2
    Dim rSebelum, cSebelum As Integer
    Dim tScroll As Boolean = False
    Dim modeDgView As Boolean = False
    Dim bTemp As Boolean = False
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        loadMain()
    End Sub
    Sub loadMain()
        rSebelum = 0
        Dim myQuery As String = "select kodekelompok,kelompok from kelompok where kodekota='" & clsKoneksi.kotaOn & "' "
        Dim myQuery2 As String = "select kodekelompok from kelompok where kodekota='" & clsKoneksi.kotaOn & "' "
        myQuery = myQuery & " and Grade<>'P' "
        myQuery2 = myQuery2 & " and Grade<>'P' "
        Dim intT As Integer = cboGrade.SelectedIndex
        Select Case intT
            Case 1
                myQuery = myQuery & " and Grade='A' "
                myQuery2 = myQuery2 & " and Grade='A' "
            Case 2


                myQuery = myQuery & " and Grade='B' "
                myQuery2 = myQuery2 & " and Grade='B' "
            Case 3
                myQuery = myQuery & " and Grade='C' "
                myQuery2 = myQuery2 & " and Grade='C' "
        End Select

        myQuery = myQuery & " order by KodeKelompok"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1,myQuery)
        dgView.Columns.Clear()
        dgView.Columns.Add("Tgl", "Tgl")
        dgView.Columns(dgView.Columns.Count - 1).Width = 70
        dgView.Columns.Add("Jam", "Jam")
        dgView.Columns(dgView.Columns.Count - 1).Width = 70
        dgView.Columns.Add("HargaPapan", "Hrg Papan")
        dgView.Columns(dgView.Columns.Count - 1).Width = 60
        dgView.Columns.Add("PerubahanPPN", "(+-)")
        dgView.Columns(dgView.Columns.Count - 1).Width = 40
        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            dgView.Columns.Add(tDs.Tables(0).Rows(i).Item(0), tDs.Tables(0).Rows(i).Item(1))
            dgView.Columns(dgView.Columns.Count - 1).Width = 60
            dgView.Columns.Add(tDs.Tables(0).Rows(i).Item(0) & "BR", "(+-)")
            dgView.Columns(dgView.Columns.Count - 1).Width = 40
            dgView.Columns(dgView.Columns.Count - 1).Visible = False
        Next
        dgView.Rows.Clear()
        Dim isiView(4) As Object
        ReDim isiView(dgView.Columns.Count - 1)

        For j As Integer = 2 To isiView.Length - 1
            If j Mod 2 = 0 Then isiView(j) = True
        Next
        dgView.Rows.Add(isiView)

        For i As Integer = 2 To dgView.Columns.Count - 1
            If i Mod 2 = 0 Then
                dgView.Rows(0).Cells(i) = New DataGridViewCheckBoxCell
                dgView.Rows(0).Cells(i).Value = False
            End If
        Next


        dgView.Columns("PerubahanPPN").Frozen = True
        dgView.Rows(0).Frozen = True

        dgView.Columns(3).DividerWidth = 1
        For j As Integer = 4 To dgView.Columns.Count - 1
            If j Mod 2 = 0 Then dgView.Columns(j).DividerWidth = 1
        Next

        For i As Integer = 0 To dgView.Columns.Count - 1
            dgView.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        loadIsi(myQuery2)
    End Sub
    Sub loadIsi(q1 As String)
        Dim myQuery2 = "Select distinct([Tgl]),jam from harga where (kodekelompok in(" & q1 & ") or kodeKelompok='HargaPapan')"
        Dim namaKolom As String() = {"tgl1", "tgl2"}
        Dim isiKolom As Object() = {dtAwal.Value.Date, dtAkhir.Value.Date}

        myQuery2 = myQuery2 & " and (tgl>=@tgl1 and tgl<=@tgl2) and kodekota='" & clsKoneksi.kotaOn & "'"
        myQuery2 = myQuery2 & " order by tgl,jam"
        Dim tDs2 As DataSet = clsKoneksi.selectCommand(1,myQuery2, namaKolom, isiKolom, 1)
        Dim arr2d1(3, 2) As Object
        ReDim arr2d1(tDs2.Tables(0).Rows.Count - 1, 2)
        For i As Integer = 0 To tDs2.Tables(0).Rows.Count - 1
            arr2d1(i, 0) = tDs2.Tables(0).Rows(i).Item(0)
            arr2d1(i, 1) = tDs2.Tables(0).Rows(i).Item(1)
            arr2d1(i, 2) = i + 1
        Next
        Dim arrList As ArrayList = New ArrayList
        Dim arr2d2(3) As Object

        dtHelp.Format = DateTimePickerFormat.Time
        For k As Integer = 0 To DateDiff(DateInterval.Day, dtAwal.Value.Date, dtAkhir.Value.Date)
            Dim tBool As Boolean = True
            dtHelp.Value = Convert.ToDateTime(CDate(dtAwal.Value.AddDays(k)).Date.ToLongDateString & " " & "00:00:00")
            For i As Integer = 0 To arr2d1.GetLength(0) - 1
                If dtHelp.Value.Date = CDate(arr2d1(i, 0)).Date Then
                    arr2d2(0) = arr2d1(i, 0)
                    arr2d2(1) = arr2d1(i, 1)
                    arr2d2(2) = arr2d1(i, 2)
                    arrList.Add(arr2d2)
                    tBool = False
                    ReDim arr2d2(3)
                End If
                If arr2d1(i, 0) > dtHelp.Value Then
                    Exit For
                End If
            Next

            If tBool Then
                arr2d2(0) = dtHelp.Value.Date
                arr2d2(1) = dtHelp.Value.TimeOfDay
                arr2d2(2) = 0
                arrList.Add(arr2d2)
                ReDim arr2d2(3)
            End If
        Next


        Dim myquery4 = "DECLARE @cols AS NVARCHAR(MAX), " & _
                        "@cols2  AS NVARCHAR(MAX), " & _
                        "@query  AS NVARCHAR(MAX); " & _
                        "SET @cols = STUFF((SELECT ',isnull(' + QUOTENAME(k.KodeKelompok) + ',0) as ' + QUOTENAME(k.KodeKelompok)   as KodeKelompok2 " & _
                                    "FROM Kelompok k  where k.kodekelompok in(" & q1 & ") and k.kodekota='" & clsKoneksi.kotaOn & "' order by KodeKelompok2 " & _
                                    "FOR XML PATH(''), TYPE " & _
                                    ").value('.', 'NVARCHAR(MAX)') " & _
                                    ",1,1,''); " & _
                        "SET @cols2 = STUFF((SELECT ',' + QUOTENAME(k.KodeKelompok)  as KodeKelompok2 " & _
                                    "FROM Kelompok k where k.kodekelompok in(" & q1 & ") and k.kodekota='" & clsKoneksi.kotaOn & "'   order by KodeKelompok2 " & _
                                    "FOR XML PATH(''), TYPE " & _
                                    ").value('.', 'NVARCHAR(MAX)') " & _
                                    ",1,1,''); " & _
                        "set @query = 'SELECT tgl,jam,isnull(HargaPapan,0) as HargaPapan, ' + @cols + ' from  " & _
                        "( " & _
                            "Select tgl " & _
                            ", Jam " & _
                            ",harga " & _
                            ",KodeKelompok " & _
                            "from [Harga] where (tgl>=''" & dtAwal.Value.Year & "-" & dtAwal.Value.Month & "-" & dtAwal.Value.Date.Day & "'' and tgl<=''" & dtAkhir.Value.Year & "-" & dtAkhir.Value.Month & "-" & dtAkhir.Value.Date.Day & "'') and kodekota=''" & clsKoneksi.kotaOn & "''" & _
                        ") x " & _
                        "pivot  " & _
                        "( " & _
                            "max(harga) " & _
                            "for KodeKelompok in (HargaPapan,' + @cols2 + ') " & _
                        ") p  " & _
                        "order by tgl,jam'; " & _
                        "execute(@query); "
        Dim myquery5 = "DECLARE @cols AS NVARCHAR(MAX), " & _
                       "@cols2  AS NVARCHAR(MAX), " & _
                       "@query  AS NVARCHAR(MAX); " & _
                       "SET @cols = STUFF((SELECT ',isnull(' + QUOTENAME(k.KodeKelompok) + ',0) as ' + QUOTENAME(k.KodeKelompok)   as KodeKelompok2 " & _
                                   "FROM Kelompok k where k.kodekelompok in(" & q1 & ") and k.kodekota='" & clsKoneksi.kotaOn & "'   order by KodeKelompok2 " & _
                                   "FOR XML PATH(''), TYPE " & _
                                   ").value('.', 'NVARCHAR(MAX)') " & _
                                   ",1,1,'') ;" & _
                        "SET @cols2 = STUFF((SELECT ',' + QUOTENAME(k.KodeKelompok)  as KodeKelompok2 " & _
                                    "FROM Kelompok k where k.kodekelompok in(" & q1 & ") and k.kodekota='" & clsKoneksi.kotaOn & "'   order by KodeKelompok2 " & _
                                    "FOR XML PATH(''), TYPE " & _
                                    ").value('.', 'NVARCHAR(MAX)') " & _
                                    ",1,1,''); " & _
                       "set @query = 'SELECT tgl,jam,isnull(HargaPapan,0) as HargaPapan, ' + @cols + ' from  " & _
                       "( " & _
                           "select tgl " & _
                           ", Jam " & _
                           ",perubahan " & _
                           ",KodeKelompok " & _
                           "from [Harga] where (tgl>=''" & dtAwal.Value.Year & "-" & dtAwal.Value.Month & "-" & dtAwal.Value.Date.Day & "'' and tgl<=''" & dtAkhir.Value.Year & "-" & dtAkhir.Value.Month & "-" & dtAkhir.Value.Date.Day & "'') and kodekota=''" & clsKoneksi.kotaOn & "''" & _
                       ") x " & _
                       "pivot  " & _
                       "( " & _
                           "max(Perubahan) " & _
                           "for KodeKelompok in (HargaPapan,' + @cols2 + ') " & _
                       ") p  " & _
                       "order by tgl,jam' ;" & _
                       "execute(@query) ;"


        Dim myQuery = "Select*from harga where (kodekelompok in(" & q1 & ") or kodeKelompok='HargaPapan')"
        'Dim namaKolom As String() = {"tgl1", "tgl2"}
        'Dim isiKolom As Object() = {dtAwal.Value.Date, dtAkhir.Value.Date}

        myQuery = myQuery & " and (tgl>=@tgl1 and tgl<=@tgl2) and kodekota='" & clsKoneksi.kotaOn & "'"
        myQuery = myQuery & " order by tgl,jam"

        Dim tDs As DataSet = clsKoneksi.selectCommand(1,myquery4)
        Dim tDs3 As DataSet = clsKoneksi.selectCommand(1,myquery5)
        'dgView.Rows.Clear()
        Dim isiView(5) As Object
        ReDim isiView(dgView.ColumnCount - 1)
        '5
        Dim tCnt As Integer = 0
        Dim tCnt2 As Integer = 0
        Dim arrList2 As ArrayList = New ArrayList
        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            tCnt = 0
            tCnt2 = 0
            For j As Integer = 0 To (isiView.Length) / 2
                If j < 2 Then
                    If j = 0 Then
                        isiView(tCnt) = tDs.Tables(0).Rows(i).Item(tCnt2).date.date
                    Else
                        isiView(tCnt) = tDs.Tables(0).Rows(i).Item(tCnt2)
                    End If
                    tCnt += 1
                    tCnt2 += 1
                Else
                    isiView(tCnt) = tDs.Tables(0).Rows(i).Item(tCnt2)
                    tCnt += 1
                    isiView(tCnt) = tDs3.Tables(0).Rows(i).Item(tCnt2)
                    tCnt += 1
                    tCnt2 += 1
                End If
            Next
            arrList2.Add(isiView)
            ReDim isiView(dgView.ColumnCount - 1)
        Next

        Dim isiView2(5) As Object
        Dim isiView3(5) As Object
        ReDim isiView2(dgView.Columns.Count - 1)

        For i As Integer = 0 To arrList.Count - 1
            ReDim isiView2(dgView.Columns.Count - 1)
            isiView3 = arrList.Item(i)
            isiView2(0) = isiView3(0).toShortDatestring
            isiView2(1) = isiView3(1)
            isiView2(2) = isiView3(2)
            If isiView2(2) <> 0 Then
                isiView2(2) = "-"
                isiView2 = arrList2.Item(0)
                isiView2(0) = isiView2(0).toShortDatestring
                dgView.Rows.Add(isiView2)
                arrList2.RemoveAt(0)
            Else
                isiView2(2) = "-"
                dgView.Rows.Add(isiView2)
            End If
        Next
    End Sub

    Sub loadIsi3(q1 As String)
        Dim myQuery2 = "Select distinct([Tgl]),jam from harga where (kodekelompok in(" & q1 & ") or kodeKelompok='HargaPapan')"
        Dim namaKolom As String() = {"tgl1", "tgl2"}
        Dim isiKolom As Object() = {dtAwal.Value.Date, dtAkhir.Value.Date}

        myQuery2 = myQuery2 & " and (tgl>=@tgl1 and tgl<=@tgl2) and kodekota='" & clsKoneksi.kotaOn & "'"
        myQuery2 = myQuery2 & " order by tgl,jam"
        Dim tDs2 As DataSet = clsKoneksi.selectCommand(1,myQuery2, namaKolom, isiKolom, 1)
        Dim arr2d1(3, 2) As Object
        ReDim arr2d1(tDs2.Tables(0).Rows.Count - 1, 2)
        For i As Integer = 0 To tDs2.Tables(0).Rows.Count - 1
            arr2d1(i, 0) = tDs2.Tables(0).Rows(i).Item(0)
            arr2d1(i, 1) = tDs2.Tables(0).Rows(i).Item(1)
            arr2d1(i, 2) = i + 1
        Next
        Dim arrList As ArrayList = New ArrayList
        Dim arr2d2(3) As Object

        dtHelp.Format = DateTimePickerFormat.Time
        For k As Integer = 0 To DateDiff(DateInterval.Day, dtAwal.Value.Date, dtAkhir.Value.Date)
            Dim tBool As Boolean = True
            dtHelp.Value = Convert.ToDateTime(CDate(dtAwal.Value.AddDays(k)).Date.ToLongDateString & " " & "00:00:00")
            For i As Integer = 0 To arr2d1.GetLength(0) - 1
                If dtHelp.Value.Date = CDate(arr2d1(i, 0)).Date Then
                    arr2d2(0) = arr2d1(i, 0)
                    arr2d2(1) = arr2d1(i, 1)
                    arr2d2(2) = arr2d1(i, 2)
                    arrList.Add(arr2d2)
                    tBool = False
                    ReDim arr2d2(3)
                End If
                If arr2d1(i, 0) > dtHelp.Value Then
                    Exit For
                End If
            Next

            If tBool Then
                arr2d2(0) = dtHelp.Value.Date
                arr2d2(1) = dtHelp.Value.TimeOfDay
                arr2d2(2) = 0
                arrList.Add(arr2d2)
                ReDim arr2d2(3)
            End If
        Next

        Dim myQuery = "Select*from harga where (kodekelompok in(" & q1 & ") or kodeKelompok='HargaPapan')"
        'Dim namaKolom As String() = {"tgl1", "tgl2"}
        'Dim isiKolom As Object() = {dtAwal.Value.Date, dtAkhir.Value.Date}

        myQuery = myQuery & " and (tgl>=@tgl1 and tgl<=@tgl2) and kodekota='" & clsKoneksi.kotaOn & "'"
        myQuery = myQuery & " order by tgl,jam"

        Dim tDs As DataSet = clsKoneksi.selectCommand(1,myQuery, namaKolom, isiKolom, 1)
        'dgView.Rows.Clear()
        Dim isiView(5) As Object
        ReDim isiView((tDs.Tables(0).Rows.Count) * 6)
        '5
        Dim tCnt As Integer = 0
        For i As Integer = 0 To (isiView.Length \ 6) - 1
            For j As Integer = 0 To 5
                isiView(tCnt) = tDs.Tables(0).Rows(i).Item(j)
                tCnt += 1
            Next
        Next

        Dim isiView2(5) As Object
        Dim isiView3(5) As Object
        ReDim isiView2(dgView.Columns.Count - 1)

        For i As Integer = 0 To arrList.Count - 1
            ReDim isiView2(dgView.Columns.Count - 1)
            isiView3 = arrList.Item(i)
            isiView2(0) = isiView3(0).toShortDatestring
            isiView2(1) = isiView3(1)
            isiView2(2) = isiView3(2)
            If isiView2(2) <> 0 Then
                isiView2(2) = 0
                For l As Integer = 2 To dgView.Columns.Count - 1 Step 2
                    For m As Integer = 0 To isiView.Length - 2 Step 6
                        If CDate(isiView2(0)).Date = CDate(isiView(m + 1)).Date And isiView2(1) = isiView(m + 2) And dgView.Columns(l).Name = isiView(m) Then
                            isiView2(l) = isiView(m + 3)
                            isiView2(l + 1) = isiView(m + 4)
                        End If
                    Next
                Next
                dgView.Rows.Add(isiView2)
            Else
                isiView2(2) = 0
                dgView.Rows.Add(isiView2)
            End If
        Next


        'For k As Integer = 0 To DateDiff(DateInterval.Day, dtAwal.Value.Date, dtAkhir.Value.Date)
        '    isiView2(0) = CDate(dtAwal.Value.AddDays(k)).Date
        '    For l As Integer = 1 To dgView.Columns.Count - 1 Step 2
        '        For i As Integer = 0 To isiView.Length - 2 Step 6
        '            If isiView2(0) = CDate(isiView(i + 1)).Date And dgView.Columns(l).Name = isiView(i) Then
        '                isiView2(l) = isiView(i + 2)
        '                isiView2(l + 1) = isiView(i + 3)
        '            End If
        '        Next
        '    Next
        '    dgView.Rows.Add(isiView2)
        'Next
    End Sub

    Sub loadIsi2(q1 As String)
        Dim myQuery = "Select*from harga where (kodekelompok in(" & q1 & ") or kodeKelompok='HargaPapan')"
        Dim namaKolom As String() = {"tgl1", "tgl2"}
        Dim isiKolom As Object() = {dtAwal.Value.Date, dtAkhir.Value.Date}

        myQuery = myQuery & " and (tgl>=@tgl1 and tgl<=@tgl2) and kodekota='" & clsKoneksi.kotaOn & "'"
        myQuery = myQuery & " order by tgl,jam"

        Dim tDs As DataSet = clsKoneksi.selectCommand(1,myQuery, namaKolom, isiKolom, 1)
        'dgView.Rows.Clear()
        Dim isiView(5) As Object
        ReDim isiView((tDs.Tables(0).Rows.Count) * 6)
        '5
        Dim tCnt As Integer = 0
        For i As Integer = 0 To (isiView.Length \ 6) - 1
            Console.WriteLine(i)
            For j As Integer = 0 To 5
                isiView(tCnt) = tDs.Tables(0).Rows(i).Item(j)
                'Console.WriteLine(tCnt & " " & isiView(tCnt))
                tCnt += 1
            Next
        Next
        Dim isiView2(5) As Object
        ReDim isiView2(dgView.Columns.Count - 1)
        For k As Integer = 0 To DateDiff(DateInterval.Day, dtAwal.Value.Date, dtAkhir.Value.Date)
            isiView2(0) = CDate(dtAwal.Value.AddDays(k)).Date
            For l As Integer = 1 To dgView.Columns.Count - 1 Step 2
                For i As Integer = 0 To isiView.Length - 2 Step 6
                    'Console.WriteLine(isiView2(0) & " " & isiView(i + 1) & " - " & dgView.Columns(l).Name & " " & isiView(i))
                    If isiView2(0) = CDate(isiView(i + 1)).Date And dgView.Columns(l).Name = isiView(i) Then
                        isiView2(l) = isiView(i + 2)
                        isiView2(l + 1) = isiView(i + 3)
                    End If
                Next
            Next
            dgView.Rows.Add(isiView2)
        Next
    End Sub

    Private Sub frmUpdateHarga_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Dgview_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgView.CellEnter
        If dgView.Rows.Count > 0 Then
            Try
                dgView.Rows(0).Cells(cSebelum).Style.BackColor = Color.White
                dgView.Rows(0).Cells(e.ColumnIndex).Style.BackColor = Color.LightGreen
            Catch ex As Exception

            End Try

            If e.RowIndex <> 0 Then
                Try
                    dgView.Rows(rSebelum).DefaultCellStyle.BackColor = Color.White
                    dgView.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGreen
                Catch ex As Exception

                End Try
                rSebelum = e.RowIndex

                If e.ColumnIndex = 0 Then
                    If modeDgView = False Then
                        dgView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                        Try
                            dgView.Rows(e.RowIndex).Selected = True
                        Catch ex As Exception
                        End Try
                        modeDgView = True
                    End If
                Else
                    If modeDgView Then
                        dgView.SelectionMode = DataGridViewSelectionMode.CellSelect
                        Try
                            dgView.Rows(e.RowIndex).Cells(e.ColumnIndex).Selected = True
                        Catch ex As Exception
                        End Try
                        modeDgView = False
                    End If
                End If
            Else
                If modeDgView Then
                    dgView.SelectionMode = DataGridViewSelectionMode.CellSelect
                    Try
                        dgView.Rows(e.RowIndex).Cells(e.ColumnIndex).Selected = True
                    Catch ex As Exception
                    End Try
                    modeDgView = False
                End If
            End If
            cSebelum = e.ColumnIndex
        End If
    End Sub


    Private Sub dgView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgView.CellContentClick

    End Sub

    Private Sub btnShowHide_Click(sender As Object, e As EventArgs) Handles btnShowHide.Click
        Try
            Dim tBool As Boolean = dgView.Columns(5).Visible
            For j As Integer = 4 To dgView.Columns.Count - 1
                If j Mod 2 = 1 Then dgView.Columns(j).Visible = Not tBool
                If tBool Then
                    If j Mod 2 = 0 Then dgView.Columns(j).DividerWidth = 1
                    If j Mod 2 = 1 Then dgView.Columns(j).DividerWidth = 0
                Else
                    If j Mod 2 = 0 Then dgView.Columns(j).DividerWidth = 0
                    If j Mod 2 = 1 Then dgView.Columns(j).DividerWidth = 1
                End If
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgView_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgView.CellPainting
        'If e.ColumnIndex > 2 And e.ColumnIndex Mod 2 = 1 Then
        '    If e.RowIndex >= 0 Then
        '        'Dim Brush As New SolidBrush(dgView.ColumnHeadersDefaultCellStyle.BackColor)
        '        'e.Graphics.FillRectangle(Brush, e.CellBounds)
        '        'Brush.Dispose()
        '        e.Paint(e.CellBounds, DataGridViewPaintParts.All And Not DataGridViewPaintParts.ContentBackground)

        '        'ControlPaint.DrawBorder(e.Graphics, e.CellBounds, dgView.GridColor, 1, ButtonBorderStyle.Solid, dgView.GridColor, 1, ButtonBorderStyle.Solid, dgView.GridColor, 1, ButtonBorderStyle.Solid, dgView.GridColor, 1, ButtonBorderStyle.Solid)
        '        ControlPaint.DrawBorder(e.Graphics, e.CellBounds, dgView.GridColor, 2, ButtonBorderStyle.Solid, dgView.GridColor, 1, ButtonBorderStyle.None, dgView.GridColor, 1, ButtonBorderStyle.None, dgView.GridColor, 1, ButtonBorderStyle.None)

        '        e.Handled = True
        '    End If
        'End If

        '    Using backgroundBrush As Brush = New SolidBrush(If((e.State And DataGridViewElementStates.Selected), e.CellStyle.SelectionBackColor, e.CellStyle.BackColor))
        '        e.Graphics.FillRectangle(backgroundBrush, e.CellBounds)
        '    End Using
        '    Dim gridPen As Pen = Pens.Red
        '    ' Draw top.
        ''  If e.RowIndex = range.Top Then
        'e.Graphics.DrawLine(gridPen, e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Top)
        ''  End If
        ' '' Draw bottom.
        ''If e.RowIndex = range.Bottom - 1 Then
        ''    e.Graphics.DrawLine(gridPen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1)
        ''End If
        ' '' Draw left.
        ''If e.ColumnIndex = range.Left Then
        ''    e.Graphics.DrawLine(gridPen, e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Left, e.CellBounds.Bottom - 1)
        ''End If
        ' '' Draw right.
        ''If e.ColumnIndex = range.Right - 1 Then
        ''    e.Graphics.DrawLine(gridPen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1)
        ''End If
        'e.PaintContent(e.CellBounds)
        'e.Handled = True

    End Sub

    Private Sub frmUpdateHarga_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
    End Sub

    Private Sub frmUpdateHarga_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        dtAkhir.Value = Now
        dtAwal.Value = Now.AddDays(-10)

        cboGrade.SelectedIndex = 0
    End Sub

    Private Sub dgView_KeyUp(sender As Object, e As KeyEventArgs) Handles dgView.KeyUp
    End Sub

    Private Sub dgView_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgView.KeyPress
        If e.KeyChar = Convert.ToChar(32) Then


            If dgView.SelectedCells.Count > 0 Then
                If dgView.SelectedCells(0).ColumnIndex > 1 Then
                    If dgView.SelectedCells(0).ColumnIndex Mod 2 = 1 Then
                        dgView.Rows(0).Cells(dgView.SelectedCells(0).ColumnIndex - 1).Value = Not dgView.Rows(0).Cells(dgView.SelectedCells(0).ColumnIndex - 1).Value
                    Else
                        dgView.Rows(0).Cells(dgView.SelectedCells(0).ColumnIndex).Value = Not dgView.Rows(0).Cells(dgView.SelectedCells(0).ColumnIndex).Value
                    End If

                End If
            End If

        End If
    End Sub

    Private Sub dgView_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgView.CellMouseClick
        If e.RowIndex = 0 Then
            If e.Button = Windows.Forms.MouseButtons.Left Then
                If dgView.SelectedCells(0).ColumnIndex > 1 Then
                    If dgView.SelectedCells(0).ColumnIndex Mod 2 = 1 Then
                        'dgView.Rows(0).Cells(dgView.SelectedCells(0).ColumnIndex - 1).Value = Not dgView.Rows(0).Cells(dgView.SelectedCells(0).ColumnIndex - 1).Value
                    Else
                        dgView.Rows(0).Cells(dgView.SelectedCells(0).ColumnIndex).Value = Not dgView.Rows(0).Cells(dgView.SelectedCells(0).ColumnIndex).Value
                    End If
                End If
            End If
        End If
    End Sub

    ''' <summary>
    ''' default "00:00:00"
    ''' </summary>
    Sub setjamDtHelp(Optional ByVal jamT As String = "00:00:00")
        dtHelp.Format = DateTimePickerFormat.Time
        dtHelp.Value = Convert.ToDateTime(Now.Date.ToLongDateString & " " & jamT)
    End Sub

    Private Sub mnuUpdate_Click(sender As Object, e As EventArgs) Handles mnuUpdate.Click
        Dim kodeKelompokA As String = ""
        For i As Integer = 2 To dgView.Columns.Count - 1
            If i Mod 2 = 0 Then
                If kodeKelompokA = "" Then
                    kodeKelompokA = "'" & dgView.Columns(i).Name & "'"
                Else
                    kodeKelompokA = kodeKelompokA & ",'" & dgView.Columns(i).Name & "'"
                End If
            End If
        Next
        Dim ts As TimeSpan
        If rSebelum < 1 Then
            MessageBox.Show("Harap Pilih Data", "warning")
            Exit Sub
        End If
        dthelp2.Value = DateTime.Parse(dgView.Rows(rSebelum).Cells(0).Value)
        ts = DirectCast(dgView.Rows(rSebelum).Cells(1).Value, TimeSpan)

        Dim myQuery As String = "INSERT INTO Harga (KodeKelompok,[Tgl],[Jam],Harga,Perubahan,KodeKota) " & _
                              "select hargaT.KodeKelompok,@tglAA,@jamAA,hargaT.harga,hargaT.perubahan,hargaT.KodeKota   from( " & _
                              "SELECT h.KodeKelompok " & _
                              ",h.Tgl " & _
                              ",h.Jam " & _
                              ",isnull((select top 1 harga from harga where kodeKota='" & clsKoneksi.kotaOn & "'and KodeKelompok=h.KodeKelompok  and ((tgl <=@tglAA and Jam<=@jamAA) or tgl <@TglAA) order by tgl desc,jam desc),0) as harga " & _
                              ",0 as perubahan " & _
                              ",h.KodeKota " & _
                              ",h.autoUP " & _
                              ",ROW_NUMBER() OVER (PARTITION BY KodeKelompok ORDER BY tgl desc,jam desc) as rowNumber2 " & _
                              "FROM Harga h " & _
                              "where  " & _
                              "kodekelompok in(" & kodeKelompokA & ")  " & _
                              "and KodeKelompok not in(select KodeKelompok from harga where tgl=@tglAA and jam =@jamAA and kodeKota='" & clsKoneksi.kotaOn & "') " & _
                              "and kodeKota='" & clsKoneksi.kotaOn & "'" & _
                              ") as hargaT "
        Dim kondisiWhere As String = " where  hargaT.rowNumber2=1 "
        Dim namaKolom As String() = {""}
        Dim isiKolom As Object() = {""}
        Dim namaKolom2 As String() = {"tglAA", "jamAA"}
        Dim isiKolom2 As Object() = {dthelp2.Value, ts}
        Console.WriteLine(dthelp2.Value.ToString & " " & ts.ToString & " " & kodeKelompokA)

        clsKoneksi.updateCommand(1,myQuery, namaKolom, isiKolom, kondisiWhere, namaKolom2, isiKolom2, 2)

        loadMain()
    End Sub

    Private Sub mnuEdit_Click(sender As Object, e As EventArgs) Handles mnuEdit.Click

        Dim kodeKelompokA As String = ""
        Dim kodeKelompokB As String = ""
        frmUpdateHargaEdit.jlhData = 0
        For i As Integer = 2 To dgView.Columns.Count - 1
            If i Mod 2 = 0 Then
                If kodeKelompokA = "" Then
                    If bTemp Then
                        kodeKelompokA = "'" & dgView.Columns(i).Name & "'"
                        kodeKelompokB = dgView.Columns(i).Name
                        frmUpdateHargaEdit.jlhData += 1
                    Else
                        If dgView.Rows(0).Cells(i).Value Then
                            kodeKelompokA = "'" & dgView.Columns(i).Name & "'"
                            kodeKelompokB = dgView.Columns(i).Name
                            frmUpdateHargaEdit.jlhData += 1
                        End If
                    End If
                Else
                    If bTemp Then
                        kodeKelompokA = kodeKelompokA & ",'" & dgView.Columns(i).Name & "'"
                        kodeKelompokB = kodeKelompokB & "," & dgView.Columns(i).Name & ""
                        frmUpdateHargaEdit.jlhData += 1
                    Else
                        If dgView.Rows(0).Cells(i).Value Then
                            kodeKelompokA = kodeKelompokA & ",'" & dgView.Columns(i).Name & "'"
                            kodeKelompokB = kodeKelompokB & "," & dgView.Columns(i).Name & ""
                            frmUpdateHargaEdit.jlhData += 1
                        End If
                    End If
                End If
            End If
        Next
        frmUpdateHargaEdit.txtKelompok.Text = kodeKelompokB
        frmUpdateHargaEdit.txtKelompok2.Text = kodeKelompokA
        Dim ts As TimeSpan
        If rSebelum < 1 Or kodeKelompokB = "" Then
            MessageBox.Show("Harap Pilih Data", "warning")
            Exit Sub
        End If
        frmUpdateHargaEdit.dtHelp.Value = DateTime.Parse(dgView.Rows(rSebelum).Cells(0).Value)
        ts = DirectCast(dgView.Rows(rSebelum).Cells(1).Value, TimeSpan)
        frmUpdateHargaEdit.ts = ts
        frmUpdateHargaEdit.lblTgl.Text = frmUpdateHargaEdit.dtHelp.Value.Date.ToShortDateString
        frmUpdateHargaEdit.lblJam.Text = ts.ToString
        frmUpdateHargaEdit.txtHarga.Text = "0"
        frmUpdateHargaEdit.ShowDialog(Me)
    End Sub

    Private Sub dgView_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgView.CellMouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If e.ColumnIndex > 1 Then
                mnuTambah.Visible = False
                mnuEdit.Visible = True
                mnuUpdate.Visible = False
                bTemp = False
            Else
                bTemp = True
                mnuTambah.Visible = True
                mnuEdit.Visible = True
                mnuUpdate.Visible = True
            End If
        End If
    End Sub

    Private Sub dgView_MouseUp(sender As Object, e As MouseEventArgs) Handles dgView.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            'Console.WriteLine("A")
            'If dgView.SelectedColumns(0).Index Then
            klikKananMenu.Show(dgView, e.Location)
        End If
    End Sub


    Private Sub klikKananMenu_Closed(sender As Object, e As ToolStripDropDownClosedEventArgs) Handles klikKananMenu.Closed
        klikKananMenu.ShowItemToolTips = False
        mnuTambah.Visible = True
        mnuEdit.Visible = False
        mnuUpdate.Visible = False
    End Sub


    Private Sub dgView_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgView.CellLeave

    End Sub

    Private Sub btnLoad2_Click(sender As Object, e As EventArgs) Handles btnLoad2.Click
        Dim myQuery As String = "select kodekelompok,kelompok from kelompok where kodekota='" & clsKoneksi.kotaOn & "' "
        Dim myQuery2 As String = "select kodekelompok from kelompok where kodekota='" & clsKoneksi.kotaOn & "' "
        myQuery = myQuery & " and Grade<>'P' "
        myQuery2 = myQuery2 & " and Grade<>'P' "
        Dim intT As Integer = cboGrade.SelectedIndex
        Select Case intT
            Case 1
                myQuery = myQuery & " and Grade='A' "
                myQuery2 = myQuery2 & " and Grade='A' "
            Case 2
                myQuery = myQuery & " and Grade='B' "
                myQuery2 = myQuery2 & " and Grade='B' "
            Case 3
                myQuery = myQuery & " and Grade='C' "
                myQuery2 = myQuery2 & " and Grade='C' "
        End Select

        myQuery = myQuery & " order by KodeKelompok"
        Dim tDs As DataSet = clsKoneksi.selectCommand(1,myQuery)
        dgView.Columns.Clear()
        dgView.Columns.Add("Tgl", "Tgl")
        dgView.Columns(dgView.Columns.Count - 1).Width = 70
        dgView.Columns.Add("Jam", "Jam")
        dgView.Columns(dgView.Columns.Count - 1).Width = 70
        dgView.Columns.Add("HargaPapan", "Hrg Papan")
        dgView.Columns(dgView.Columns.Count - 1).Width = 60
        dgView.Columns.Add("PerubahanPPN", "(+-)")
        dgView.Columns(dgView.Columns.Count - 1).Width = 30
        For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
            dgView.Columns.Add(tDs.Tables(0).Rows(i).Item(0), tDs.Tables(0).Rows(i).Item(1))
            dgView.Columns(dgView.Columns.Count - 1).Width = 60
            dgView.Columns.Add(tDs.Tables(0).Rows(i).Item(0) & "BR", "(+-)")
            dgView.Columns(dgView.Columns.Count - 1).Width = 35
            dgView.Columns(dgView.Columns.Count - 1).Visible = False
        Next
        dgView.Rows.Clear()
        Dim isiView(4) As Object
        ReDim isiView(dgView.Columns.Count - 1)

        For j As Integer = 4 To isiView.Length - 1
            If j Mod 2 = 0 Then isiView(j) = True
        Next
        dgView.Rows.Add(isiView)

        For i As Integer = 4 To dgView.Columns.Count - 1
            If i Mod 2 = 0 Then
                dgView.Rows(0).Cells(i) = New DataGridViewCheckBoxCell
                dgView.Rows(0).Cells(i).Value = False
            End If
        Next


        dgView.Columns("PerubahanPPN").Frozen = True
        dgView.Rows(0).Frozen = True

        dgView.Columns(3).DividerWidth = 1
        For j As Integer = 4 To dgView.Columns.Count - 1
            If j Mod 2 = 0 Then dgView.Columns(j).DividerWidth = 1
        Next

        For i As Integer = 0 To dgView.Columns.Count - 1
            dgView.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        loadIsi3(myQuery2)
    End Sub

    Private Sub btnUpdateHarga_Click(sender As Object, e As EventArgs) Handles btnUpdateHarga.Click
        Dim myQuery As String = "DECLARE @StartDate DATE = @tglAwalAA " & _
                                ", @EndDate DATE = @tglAkhirAA " & _
                                ", @KodeKota int = @kodeKotaAA " & _
                                ", @Grade varchar(8) = @gradeAA; " & _
                                "delete harga where " & _
                                "KodeKelompok in (select KodeKelompok from Kelompok where grade=@Grade) " & _
                                "and tgl >=@StartDate and tgl<=@EndDate and KodeKota=@kodekota; " & _
                                "INSERT INTO Harga (KodeKelompok,[Tgl],[Jam],Harga,Perubahan,KodeKota) " & _
                                "select k.KodeKelompok,ab.tgl,ab.jam,isnull(ab.Hargarata,0) as harga,0,@kodekota from Kelompok k cross join ( " & _
                                "(SELECT  (DATEADD(DAY, nbr - 1, @StartDate)) as tgl,'00:00:00' as jam,(select sum(p1.total) from Pembelian p1 join Customer c on p1.NoAccount=c.NoAccount  where c.KodeKota=@kodekota and p1.KodeKota=@kodekota and c.Grade<>@Grade and p1.tgl2>=DATEFROMPARTS(YEAR((DATEADD(DAY, nbr - 1, @StartDate))) , MONTH((DATEADD(DAY, nbr - 1, @StartDate))) ,1) and p1.Tgl2<=(DATEADD(DAY, nbr - 1, @StartDate))) " & _
                                "/(select sum(p1.Netto) from Pembelian p1 join Customer c on p1.NoAccount=c.NoAccount where  c.KodeKota=@kodekota and p1.KodeKota=@kodekota and c.Grade<>@Grade and p1.tgl2>=DATEFROMPARTS(YEAR((DATEADD(DAY, nbr - 1, @StartDate))) , MONTH((DATEADD(DAY, nbr - 1, @StartDate))) ,1) and p1.Tgl2<=(DATEADD(DAY, nbr - 1, @StartDate))) as Hargarata  " & _
                                "FROM    ( SELECT    ROW_NUMBER() OVER ( ORDER BY c.object_id ) AS Nbr " & _
                                "FROM      sys.columns c " & _
                                ") nbrs "
        Dim kondisiWhere As String = " WHERE   nbr - 1 <= DATEDIFF(DAY, @StartDate, @EndDate))) ab where k.Grade=@Grade and k.KodeKota=@kodekota order by ab.tgl "
        Dim namaKolom As String() = {""}
        Dim isiKolom As Object() = {""}
        Dim namaKolom2 As String() = {"tglAwalAA", "tglAkhirAA", "kodeKotaAA", "gradeAA"}
        Dim isiKolom2 As Object() = {dtAwal.Value.Date, dtAkhir.Value.Date, clsKoneksi.kotaOn, "A"}

        clsKoneksi.updateCommand(1,myQuery, namaKolom, isiKolom, kondisiWhere, namaKolom2, isiKolom2, 2)

        loadMain()
    End Sub

    Private Sub klikKananMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles klikKananMenu.Opening

    End Sub

    Private Sub mnuTambah_Click(sender As Object, e As EventArgs) Handles mnuTambah.Click
        frmUpdateHargaTambahdetail.ShowDialog()
    End Sub

    Private Sub PanelEx1_Click(sender As Object, e As EventArgs) Handles PanelEx1.Click

    End Sub

    Private Sub LabelX5_Click(sender As Object, e As EventArgs) Handles LabelX5.Click

    End Sub
End Class