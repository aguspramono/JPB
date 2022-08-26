Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmImportDataPembelian
    Dim totalData As Integer
    Dim totalDataValid As Integer
    Dim totalDataTidakValid As Integer
    Dim totalDataPembelian As Integer
    Dim totalDataPembelianValid As Integer
    Dim totalDataPenjualan As Integer
    Dim totalDataPenjualanValid As Integer

    Private Sub btnLoadData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadData.Click
        'loadData()
        'testexport pakai teknik array, load data pakai read1-1
        testExport()
        clearIsi2()

        lblTotalNetto.Text = 0
        lblJumlahNettoPembelian.Text = 0
        lblJumlahNettoPenjualan.Text = 0
    End Sub

    Sub loadData()
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        If System.IO.File.Exists(txtCariFile.Text) Then
            'The file exists
        Else
            'the file doesn't exist
            MessageBox.Show(txtCariFile.Text & " Tidak ditemukan.", "warning")
            Exit Sub
        End If

        xlApp = CreateObject("Excel.Application")
        xlWorkBook = xlApp.Workbooks.Open(txtCariFile.Text, , , , "excel80timbang")
        xlWorkSheet = xlWorkBook.Worksheets("sheet1")
        Try
           
            'display the cells value B2
            'MsgBox(xlWorkSheet.UsedRange.Rows.Count)
            'MsgBox(xlWorkSheet.Cells(2, 2).value)

            dgView.Rows.Clear()
            Dim isiView(12) As Object

            'isiView(0) = ""
            For i As Integer = 3 To xlWorkSheet.UsedRange.Rows.Count
                For j As Integer = 0 To 12
                    If j < 10 Then
                        If j = 5 Or j = 6 Then
                            'tgl
                            Dim dt As Date = xlWorkSheet.Cells(i, j + 1).value
                            isiView(j) = CDate(dt)
                            'Console.Write(dt & " : ")
                        ElseIf j = 7 Or j = 8 Then
                            'jam
                            Dim dt As DateTime = (New DateTime()).AddDays(xlWorkSheet.Cells(i, j + 1).value)
                            isiView(j) = dt.TimeOfDay
                            'Console.Write(dt.TimeOfDay.ToString & " : ")
                        Else
                            isiView(j) = xlWorkSheet.Cells(i, j + 1).value
                            'Console.Write(xlWorkSheet.Cells(i, j + 1).value & " : ")
                        End If
                    Else
                        isiView(j) = xlWorkSheet.Cells(i, j + 2).value
                        'Console.Write(xlWorkSheet.Cells(i, j + 2).value & " : ")
                    End If
                Next
                Console.WriteLine()
                dgView.Rows.Add(isiView)
            Next

            'edit the cell with new value
            xlWorkBook.Close()
            xlApp.Quit()

            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)
        Catch ex As Exception

            xlWorkBook.Close()
            xlApp.Quit()

            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)
        End Try
    End Sub

    Sub testExport()
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        If System.IO.File.Exists(txtCariFile.Text) Then
            'The file exists
        Else
            'the file doesn't exist
            MessageBox.Show(txtCariFile.Text & " Tidak ditemukan.", "warning")
            Exit Sub
        End If
        xlApp = CreateObject("Excel.Application")
        xlWorkBook = xlApp.Workbooks.Open(txtCariFile.Text, , , , "excel80timbang")
        xlWorkSheet = xlWorkBook.Worksheets("sheet1")

        'jumlah column 16 cek benar salah + NAMA + JJG = 17
        'Console.WriteLine(xlWorkSheet.UsedRange.Columns.Count)
        If xlWorkSheet.UsedRange.Columns.Count = 17 Then
        Else
            MessageBox.Show("File Salah.", "Warning")
            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)
            GC.Collect()
            Exit Sub
        End If
        Try
            Dim arr(,) As Object
            ReDim arr(xlWorkSheet.UsedRange.Rows.Count, xlWorkSheet.UsedRange.Columns.Count)

            Dim Rng As Excel.Range
            With xlWorkSheet
                Rng = .Range(.Cells(1, 1), .Cells(arr.GetLength(0), arr.GetLength(1)))
            End With
            arr = Rng.Value

            dgView.Rows.Clear()
            'dgView.Rows.Add(arr)

            Dim isiView(13) As Object
            Dim tKota As String = ""

            For i As Integer = 3 To xlWorkSheet.UsedRange.Rows.Count
                If String.IsNullOrEmpty(arr(i, 1)) Then
                Else
                    For j As Integer = 0 To isiView.Length - 1
                        If j < 10 Then
                            If j = 5 Or j = 6 Then
                                'tgl
                                Dim dt As Date = arr(i, j + 1)
                                isiView(j) = CDate(dt)
                                'Console.WriteLine(arr(2, j + 1))
                            ElseIf j = 7 Or j = 8 Then
                                'jam
                                Dim dt As DateTime = (New DateTime()).AddDays(arr(i, j + 1))
                                isiView(j) = dt.TimeOfDay
                                ' Console.Wr iteLine(arr(2, j + 1))
                            ElseIf j = 0 Then
                                If tKota = "" Then
                                    tKota = arr(i, j + 1).ToString.Substring(4, 1)
                                    Console.WriteLine(arr(i, j + 1).ToString & " " & tKota)
                                Else

                                    If tKota <> arr(i, j + 1).ToString.Substring(4, 1) Then
                                        'Console.WriteLine(tKota & " : " & arr(i, j + 1).ToString.Substring(4, 1))
                                        MessageBox.Show("Ada NoTicket yang salah")
                                    End If


                                End If
                                isiView(j) = arr(i, j + 1)
                                'Console.WriteLine(arr(2, j + 1))
                            Else
                                isiView(j) = arr(i, j + 1)
                                ' Console.WriteLine(arr(2, j + 1))
                            End If
                        ElseIf j = 13 Then
                            isiView(j) = arr(i, j + 4)
                            '  Console.WriteLine(arr(2, j + 3))
                        Else
                            isiView(j) = arr(i, j + 2)
                            ' Console.WriteLine(arr(2, j + 2))
                        End If
                    Next
                    dgView.Rows.Add(isiView)
                End If
            Next
            'If tKota = "1" Then
            '    MessageBox.Show("Libo")
            'ElseIf tKota = "2" Then
            '    MessageBox.Show("Bina Baru")
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "warning", MessageBoxButtons.OK)
        Finally
            Try
                xlWorkBook.Close()
            Catch ex As Exception
            End Try
            Try
                xlApp.Quit()
            Catch ex As Exception
            End Try
            Try
                releaseObject(xlApp)
            Catch ex As Exception
            End Try
            Try
                releaseObject(xlWorkBook)
            Catch ex As Exception
            End Try
            Try
                releaseObject(xlWorkSheet)
            Catch ex As Exception
            End Try

            GC.Collect()
        End Try
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub btnCariFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCariFile.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        fd.Title = "Open File Dialog"
        'fd.InitialDirectory = "C:\Timbang\"
        'fd.InitialDirectory = clsKoneksi.letakDatabase
        fd.Filter = "Excel Files (*.xls)|*.xls"
        fd.FilterIndex = 1
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            txtCariFile.Text = fd.FileName
            clearIsi()
        End If
    End Sub

    Sub clearIsi()
        dgView.Rows.Clear()

        totalDataValid = 0
        totalDataTidakValid = 0
        totalData = 0
        totalDataPembelian = 0
        totalDataPenjualan = 0
        totalDataPembelianValid = 0
        totalDataPenjualanValid = 0

        lblDataValid.Text = "Data Valid : " & totalDataValid
        lblDataTidakValid.Text = "Data Tidak Valid : " & totalDataTidakValid
        lblTotalData.Text = "Total Data : " & totalData
        lblPembelian.Text = "Pembelian : " & totalDataPembelian
        lblPenjualan.Text = "Penjualan : " & totalDataPenjualan

    End Sub

    Sub clearIsi2()
        totalDataValid = 0
        totalDataTidakValid = 0
        totalData = 0
        totalDataPembelian = 0
        totalDataPenjualan = 0
        totalDataPembelianValid = 0
        totalDataPenjualanValid = 0

        lblDataValid.Text = "Data Valid : " & totalDataValid
        lblDataTidakValid.Text = "Data Tidak Valid : " & totalDataTidakValid
        lblTotalData.Text = "Total Data : " & totalData
        lblPembelian.Text = "Pembelian : " & totalDataPembelian
        lblPenjualan.Text = "Penjualan : " & totalDataPenjualan
    End Sub


    Private Sub btnCekData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCekData.Click
        lblJumlahNettoPembelian.Text = 0
        lblJumlahNettoPenjualan.Text = 0
        lblTotalNetto.Text = 0
        cekData()

        If dgView.RowCount > 0 Then
            dgView.ClearSelection()
            dgView.CurrentCell = dgView.Rows(0).Cells(0)
            dgView.Rows(0).Selected = True
        End If

        For i As Integer = 0 To dgView.Rows.Count - 1
            If (dgView.Rows(i).Cells(9).Value > dgView.Rows(i).Cells(10).Value Or dgView.Rows(i).Cells(9).Value = dgView.Rows(i).Cells(10).Value) And dgView.Rows(i).Cells(2).Value <> "SOLAR" And dgView.Rows(i).Cells(2).Value <> "CPO" And dgView.Rows(i).Cells(2).Value <> "PK" Then
                lblJumlahNettoPembelian.Text += dgView.Rows(i).Cells(11).Value
            ElseIf dgView.Rows(i).Cells(9).Value < dgView.Rows(i).Cells(10).Value Or dgView.Rows(i).Cells(2).Value = "SOLAR" Or dgView.Rows(i).Cells(2).Value = "CPO" Or dgView.Rows(i).Cells(2).Value = "PK" Then
                lblJumlahNettoPenjualan.Text += dgView.Rows(i).Cells(11).Value
            End If
            lblTotalNetto.Text += dgView.Rows(i).Cells(11).Value
        Next

        lblJumlahNettoPembelian.Text = FormatNumber(lblJumlahNettoPembelian.Text, 0)
        lblJumlahNettoPenjualan.Text = FormatNumber(lblJumlahNettoPenjualan.Text, 0)
        lblTotalNetto.Text = FormatNumber(lblTotalNetto.Text, 0)
    End Sub

    Sub cekData()
        totalData = 0
        totalDataValid = 0
        totalDataTidakValid = 0
        totalDataPembelian = 0
        totalDataPenjualan = 0
        totalDataPembelianValid = 0
        totalDataPenjualanValid = 0

        'cek noticket yg double di excel
        Dim tCekDataSama As String = ""
        For i As Integer = 0 To dgView.Rows.Count - 1
            For j As Integer = 0 To dgView.Rows.Count - 1
                If i <> j Then
                    If dgView.Rows(i).Cells(0).Value = dgView.Rows(j).Cells(0).Value Then
                        If tCekDataSama.IndexOf(dgView.Rows(i).Cells(0).Value) >= 0 Then
                        Else
                            If tCekDataSama = "" Then
                                tCekDataSama = dgView.Rows(i).Cells(0).Value
                            Else
                                tCekDataSama = tCekDataSama & ", " & dgView.Rows(i).Cells(0).Value
                            End If
                        End If
                    End If
                End If
            Next
        Next
        If tCekDataSama = "" Then
        Else
            MessageBox.Show("Ada NoTicket yang Sama : " & tCekDataSama, "warning")
            Exit Sub
        End If

        Dim strT As String = ""
        Dim strT2 As String = ""
        Console.WriteLine(dgView.Rows.Count)
        For i As Integer = 0 To dgView.Rows.Count - 1
            'pembelian
            If (dgView.Rows(i).Cells(9).Value > dgView.Rows(i).Cells(10).Value Or dgView.Rows(i).Cells(9).Value = dgView.Rows(i).Cells(10).Value) And dgView.Rows(i).Cells(2).Value <> "SOLAR" And dgView.Rows(i).Cells(2).Value <> "CPO" And dgView.Rows(i).Cells(2).Value <> "PK" Then
                If strT = "" Then
                    strT = "'" & dgView.Rows(i).Cells(0).Value & "'"
                Else
                    strT = strT & ",'" & dgView.Rows(i).Cells(0).Value & "'"
                End If
                totalDataPembelian += 1


                Console.WriteLine("D" & dgView.Rows(i).Cells(2).Value)
            ElseIf dgView.Rows(i).Cells(9).Value < dgView.Rows(i).Cells(10).Value Or dgView.Rows(i).Cells(2).Value = "SOLAR" Or dgView.Rows(i).Cells(2).Value = "CPO" Or dgView.Rows(i).Cells(2).Value = "PK" Then
                'penjualan
                If strT2 = "" Then
                    strT2 = "'" & dgView.Rows(i).Cells(0).Value & "'"
                Else
                    strT2 = strT2 & ",'" & dgView.Rows(i).Cells(0).Value & "'"
                End If
                totalDataPenjualan += 1

                'Console.WriteLine("E" & dgView.Rows(i).Cells(2).Value)
            End If
        Next

        Dim dsT As DataSet
        Dim dsT2 As DataSet
        For j As Integer = 0 To dgView.Rows.Count - 1
            dgView.Rows(j).DefaultCellStyle.BackColor = Color.LightGreen
        Next
        totalDataPembelianValid = totalDataPembelian
        totalDataPenjualanValid = totalDataPenjualan

        If totalDataPembelian > 0 Then
            dsT = clsKoneksi.selectCommand(1, "select NoTicket from Pembelian where NoTicket in(" & strT & ") and kodeKota='" & clsKoneksi.kotaOn & "'")
            For j As Integer = 0 To dgView.Rows.Count - 1
                For i As Integer = 0 To dsT.Tables(0).Rows.Count - 1
                    If dgView.Rows(j).Cells(0).Value = dsT.Tables(0).Rows(i).Item(0) Then
                        dgView.Rows(j).DefaultCellStyle.BackColor = Color.Pink
                        totalDataTidakValid += 1
                        totalDataPembelianValid -= 1
                        'Console.WriteLine(dgView.Rows(j).Cells(0).Value)
                    End If
                Next
            Next
        End If
        If totalDataPenjualan > 0 Then
            dsT2 = clsKoneksi.selectCommand(1, "select NoTicket from Penjualan where NoTicket in(" & strT2 & ") and kodeKota='" & clsKoneksi.kotaOn & "'")
            For j As Integer = 0 To dgView.Rows.Count - 1
                For k As Integer = 0 To dsT2.Tables(0).Rows.Count - 1
                    If dgView.Rows(j).Cells(0).Value = dsT2.Tables(0).Rows(k).Item(0) Then
                        dgView.Rows(j).DefaultCellStyle.BackColor = Color.Pink
                        totalDataTidakValid += 1
                        totalDataPenjualanValid -= 1
                    End If
                Next
            Next
        End If
        'Console.WriteLine(totalDataPembelianValid)
        'Console.WriteLine(totalDataPenjualanValid)

       
        totalData = dgView.Rows.Count
        totalDataValid = totalData - totalDataTidakValid

        lblDataValid.Text = "Data Valid : " & totalDataValid
        lblDataTidakValid.Text = "Data Tidak Valid : " & totalDataTidakValid
        lblTotalData.Text = "Total Data : " & totalData
        lblPembelian.Text = "Pembelian : " & totalDataPembelian
        lblPenjualan.Text = "Penjualan : " & totalDataPenjualan
    End Sub

    Private Sub btnImportData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportData.Click
        If dgView.Rows.Count < 1 Then
            MsgBox("Belum ada data")
            Return
        End If
        Dim a As String = dgView.Rows(0).Cells(0).Value
        Dim b As String = a.Substring(4, 1)
        Dim namakota As String
        Dim namakota2 As String
        If b = "1" Then
            namakota = "Libo"
        Else
            namakota = "BinaBaru"
        End If


        If clsKoneksi.kotaOn = "1" Then
            namakota2 = "Libo"
        Else
            namakota2 = "BinaBaru"
        End If

        If b <> clsKoneksi.kotaOn Then
            MsgBox("Data " & namakota & " tidak bisa di masukkan di " & namakota2 & "")
            Return
        End If

        'cekData()
        If totalDataPembelianValid = 0 And totalDataPenjualanValid = 0 Then
            MessageBox.Show("Tidak ada data Valid", "warning")
            Exit Sub
        End If
        Dim jlhDataMsk As Integer = 0
        If totalDataPembelianValid > 0 Then
            Dim myQuery As String = "INSERT INTO Pembelian "
            Dim myQuery2 As String = "INSERT INTO Pembelian2 "
            Dim namaKolom As String() = {"NoTicket", "Vehicle", "Product", "NoAccount", "DO", "[Tgl1]", "[Tgl2]", "[Jam1]", "[Jam2]", "Berat1Brutto", "Berat2Tarra", "Netto", "ADJ", "JumlahJanjang", "ADJNumber", "BJR", "KodeKota", "Kota"}

            Dim isiKolom As Object()
            Dim jlhKolom As Integer
            For i As Integer = 0 To dgView.Rows.Count - 1
                If dgView.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen Then
                    If (dgView.Rows(i).Cells(9).Value > dgView.Rows(i).Cells(10).Value Or dgView.Rows(i).Cells(9).Value = dgView.Rows(i).Cells(10).Value) And dgView.Rows(i).Cells(2).Value <> "SOLAR" And dgView.Rows(i).Cells(2).Value <> "CPO" And dgView.Rows(i).Cells(2).Value <> "PK" Then
                        '1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18
                        jlhKolom += 18
                    End If
                End If
            Next
            'cek berapa banyak data yg valid spy kolom bisa di redim
            ReDim isiKolom(jlhKolom)

            jlhKolom = 0
            For i As Integer = 0 To dgView.Rows.Count - 1
                If dgView.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen Then
                    If (dgView.Rows(i).Cells(9).Value > dgView.Rows(i).Cells(10).Value Or dgView.Rows(i).Cells(9).Value = dgView.Rows(i).Cells(10).Value) And dgView.Rows(i).Cells(2).Value <> "SOLAR" And dgView.Rows(i).Cells(2).Value <> "CPO" And dgView.Rows(i).Cells(2).Value <> "PK" Then
                        '1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18
                        ' 1 NoTicket
                        ' 2 Vehicle
                        ' 3 Product
                        ' 4 NoAccount
                        ' 5 DO
                        ' 6 [Tgl1]
                        ' 7 [Tgl2]
                        ' 8 [Jam1]
                        ' 9 [Jam2]
                        ' 10 Berat1Brutto
                        ' 11 Berat2Tarra 
                        ' 12 Netto
                        ' 13 ADJ
                        ' 14 JumlahJanjang
                        ' 15 ADJNumber
                        ' 16 BJR
                        ' 17 KodeKota
                        ' 18 Kota
                        For j As Integer = 0 To 18 - 1
                            Select Case j
                                Case 0
                                    ' 1 NoTicket
                                    isiKolom(jlhKolom) = "'" & dgView.Rows(i).Cells(j).Value.ToString.Replace("'", "") & "'"
                                Case 1
                                    ' 2 Vehicle
                                    isiKolom(jlhKolom) = "'" & dgView.Rows(i).Cells(j).Value.ToString.Replace("'", "").Replace(" ", "") & "'"
                                Case 2
                                    ' 3 Product
                                    isiKolom(jlhKolom) = "'" & dgView.Rows(i).Cells(j).Value.ToString.Replace("'", "") & "'"
                                Case 3
                                    ' 4 NoAccount
                                    isiKolom(jlhKolom) = "'" & dgView.Rows(i).Cells(j).Value.ToString.Replace("'", "") & "'"
                                Case 4
                                    ' 5 DO
                                    isiKolom(jlhKolom) = "'" & dgView.Rows(i).Cells(j).Value.ToString.Replace("'", "") & "'"
                                Case 5
                                    ' 6 [Tgl1]
                                    isiKolom(jlhKolom) = "'" & Format(dgView.Rows(i).Cells(j).Value, "yyyy-MM-dd") & "'"
                                Case 6
                                    ' 7 [Tgl2]
                                    isiKolom(jlhKolom) = "'" & Format(dgView.Rows(i).Cells(j).Value, "yyyy-MM-dd") & "'"
                                Case 7
                                    ' 8 [Jam1]
                                    Dim zDate As New Date(dgView.Rows(i).Cells(j).Value.Ticks)
                                    isiKolom(jlhKolom) = "'" & Format(zDate, "HH:mm:ss") & "'"
                                Case 8
                                    ' 9 [Jam2]
                                    Dim zDate As New Date(dgView.Rows(i).Cells(j).Value.Ticks)
                                    isiKolom(jlhKolom) = "'" & Format(zDate, "HH:mm:ss") & "'"
                                Case 9
                                    ' 10 Berat1Brutto
                                    isiKolom(jlhKolom) = dgView.Rows(i).Cells(j).Value.ToString.Replace(",", ".")
                                Case 10
                                    ' 11 Berat2Tarra
                                    isiKolom(jlhKolom) = dgView.Rows(i).Cells(j).Value.ToString.Replace(",", ".")
                                Case 11
                                    ' 12 Netto
                                    isiKolom(jlhKolom) = dgView.Rows(i).Cells(j).Value.ToString.Replace(",", ".")
                                Case 12
                                    ' 13 ADJ
                                    isiKolom(jlhKolom) = dgView.Rows(i).Cells(j).Value.ToString.Replace(",", ".")
                                Case 13
                                    ' 14 JumlahJanjang
                                    isiKolom(jlhKolom) = "'" & dgView.Rows(i).Cells(j).Value.ToString.Replace("'", "") & "'"
                                Case 14
                                    ' 15 ADJNumber
                                    isiKolom(jlhKolom) = (CDec(clsKoneksi.Rounding((dgView.Rows(i).Cells(12).Value * 100) / (dgView.Rows(i).Cells(11).Value + dgView.Rows(i).Cells(12).Value), 1))).ToString.Replace(",", ".")
                                Case 15
                                    ' 16 BJR
                                    Try
                                        isiKolom(jlhKolom) = "'" & (CDec(clsKoneksi.Rounding(dgView.Rows(i).Cells(11).Value / dgView.Rows(i).Cells(13).Value, 1))).ToString.Replace(",", ".") & "'"
                                    Catch ex As Exception
                                        isiKolom(jlhKolom) = "'" & dgView.Rows(i).Cells(13).Value.ToString.Replace("'", "") & "'"
                                    End Try
                                Case 16
                                    ' 17 KodeKota
                                    isiKolom(jlhKolom) = "'" & clsKoneksi.kotaOn & "'"
                                Case 17
                                    ' 18 Kota
                                    If clsKoneksi.kotaOn = "1" Then
                                        isiKolom(jlhKolom) = "'Libo'"
                                    ElseIf clsKoneksi.kotaOn = "2" Then
                                        isiKolom(jlhKolom) = "'BinaBaru'"
                                    End If

                            End Select
                            jlhKolom += 1
                        Next
                        jlhDataMsk += 1
                    End If
                End If
            Next
            'Data pembelian ke 1
            clsKoneksi.insertCommand2(1, myQuery, namaKolom, isiKolom)

            'Data pembelian ke 2
            clsKoneksi.insertCommand2(1, myQuery2, namaKolom, isiKolom)

        End If
        If totalDataPenjualanValid > 0 Then
            Dim myQuery As String = "INSERT INTO Penjualan "
            Dim namaKolom As String() = {"NoTicket", "Vehicle", "Product", "NoAccount", "DO", "[Tgl1]", "[Tgl2]", "[Jam1]", "[Jam2]", "Berat1Brutto", "Berat2Tarra", "Netto", "ADJ", "JumlahJanjang", "ADJNumber", "BJR", "KodeKota", "Kota"}

            Dim isiKolom As Object()
            Dim jlhKolom As Integer
            For i As Integer = 0 To dgView.Rows.Count - 1
                If dgView.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen Then
                    If dgView.Rows(i).Cells(9).Value < dgView.Rows(i).Cells(10).Value Or dgView.Rows(i).Cells(2).Value = "SOLAR" Or dgView.Rows(i).Cells(2).Value = "CPO" Or dgView.Rows(i).Cells(2).Value = "PK" Then
                        '1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18
                        jlhKolom += 18
                    End If
                End If
            Next
            'cek berapa banyak data yg valid spy kolom bisa di redim
            ReDim isiKolom(jlhKolom)

            jlhKolom = 0
            For i As Integer = 0 To dgView.Rows.Count - 1
                If dgView.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen Then
                    If dgView.Rows(i).Cells(9).Value < dgView.Rows(i).Cells(10).Value Or dgView.Rows(i).Cells(2).Value = "SOLAR" Or dgView.Rows(i).Cells(2).Value = "CPO" Or dgView.Rows(i).Cells(2).Value = "PK" Then
                        '1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18
                        ' 1 NoTicket
                        ' 2 Vehicle
                        ' 3 Product
                        ' 4 NoAccount
                        ' 5 DO
                        ' 6 [Tgl1]
                        ' 7 [Tgl2]
                        ' 8 [Jam1]
                        ' 9 [Jam2]
                        ' 10 Berat1Brutto
                        ' 11 Berat2Tarra
                        ' 12 Netto
                        ' 13 ADJ
                        ' 14 JumlahJanjang
                        ' 15 ADJNumber
                        ' 16 BJR
                        ' 17 KodeKota
                        ' 18 Kota
                        For j As Integer = 0 To 18 - 1
                            Select Case j
                                Case 0
                                    ' 1 NoTicket
                                    isiKolom(jlhKolom) = "'" & dgView.Rows(i).Cells(j).Value.ToString.Replace("'", "") & "'"
                                Case 1
                                    ' 2 Vehicle
                                    isiKolom(jlhKolom) = "'" & dgView.Rows(i).Cells(j).Value.ToString.Replace("'", "").Replace(" ", "") & "'"
                                Case 2
                                    ' 3 Product
                                    isiKolom(jlhKolom) = "'" & dgView.Rows(i).Cells(j).Value.ToString.Replace("'", "") & "'"
                                Case 3
                                    ' 4 NoAccount
                                    isiKolom(jlhKolom) = "'" & dgView.Rows(i).Cells(j).Value.ToString.Replace("'", "") & "'"
                                Case 4
                                    ' 5 DO
                                    isiKolom(jlhKolom) = "'" & dgView.Rows(i).Cells(j).Value.ToString.Replace("'", "") & "'"
                                Case 5
                                    ' 6 [Tgl1]
                                    isiKolom(jlhKolom) = "'" & Format(dgView.Rows(i).Cells(j).Value, "yyyy-MM-dd") & "'"
                                Case 6
                                    ' 7 [Tgl2]
                                    isiKolom(jlhKolom) = "'" & Format(dgView.Rows(i).Cells(j).Value, "yyyy-MM-dd") & "'"
                                Case 7
                                    ' 8 [Jam1]
                                    Dim zDate As New Date(dgView.Rows(i).Cells(j).Value.Ticks)
                                    isiKolom(jlhKolom) = "'" & Format(zDate, "HH:mm:ss") & "'"
                                Case 8
                                    ' 9 [Jam2]
                                    Dim zDate As New Date(dgView.Rows(i).Cells(j).Value.Ticks)
                                    isiKolom(jlhKolom) = "'" & Format(zDate, "HH:mm:ss") & "'"
                                Case 9
                                    ' 10 Berat1Brutto
                                    isiKolom(jlhKolom) = dgView.Rows(i).Cells(j).Value.ToString.Replace(",", ".")
                                Case 10
                                    ' 11 Berat2Tarra
                                    isiKolom(jlhKolom) = dgView.Rows(i).Cells(j).Value.ToString.Replace(",", ".")
                                Case 11
                                    ' 12 Netto
                                    isiKolom(jlhKolom) = dgView.Rows(i).Cells(j).Value.ToString.Replace(",", ".")
                                Case 12
                                    ' 13 ADJ
                                    isiKolom(jlhKolom) = dgView.Rows(i).Cells(j).Value.ToString.Replace(",", ".")
                                Case 13
                                    ' 14 JumlahJanjang
                                    isiKolom(jlhKolom) = "'" & dgView.Rows(i).Cells(j).Value.ToString.Replace("'", "") & "'"
                                Case 14
                                    ' 15 ADJNumber
                                    isiKolom(jlhKolom) = (CDec(clsKoneksi.Rounding((dgView.Rows(i).Cells(12).Value * 100) / (dgView.Rows(i).Cells(11).Value + dgView.Rows(i).Cells(12).Value), 1))).ToString.Replace(",", ".")
                                Case 15
                                    ' 16 BJR
                                    Try
                                        isiKolom(jlhKolom) = "'" & (CDec(clsKoneksi.Rounding(dgView.Rows(i).Cells(11).Value / dgView.Rows(i).Cells(13).Value, 1))).ToString.Replace(",", ".") & "'"
                                    Catch ex As Exception
                                        isiKolom(jlhKolom) = "'" & dgView.Rows(i).Cells(13).Value.ToString.Replace("'", "") & "'"
                                    End Try
                                Case 16
                                    ' 17 KodeKota
                                    isiKolom(jlhKolom) = "'" & clsKoneksi.kotaOn & "'"
                                Case 17
                                    ' 18 Kota
                                    If clsKoneksi.kotaOn = "1" Then
                                        isiKolom(jlhKolom) = "'Libo'"
                                    ElseIf clsKoneksi.kotaOn = "2" Then
                                        isiKolom(jlhKolom) = "'BinaBaru'"
                                    End If
                            End Select
                            jlhKolom += 1
                        Next
                        jlhDataMsk += 1
                    End If
                End If
            Next
            'For i As Integer = 0 To jlhKolom - 1
            '    Console.WriteLine("A " & i & " " & isiKolom(i).ToString)
            'Next
            clsKoneksi.insertCommand2(1, myQuery, namaKolom, isiKolom)
        End If
        MessageBox.Show(jlhDataMsk & " Data berhasil di Import", "warning")


        lblJumlahNettoPembelian.Text = 0
        lblJumlahNettoPenjualan.Text = 0
        lblTotalNetto.Text = 0
        cekData()

        If dgView.RowCount > 0 Then
            dgView.ClearSelection()
            dgView.CurrentCell = dgView.Rows(0).Cells(0)
            dgView.Rows(0).Selected = True
        End If

        For i As Integer = 0 To dgView.Rows.Count - 1
            If dgView.Rows(i).Cells(9).Value > dgView.Rows(i).Cells(10).Value And dgView.Rows(i).Cells(2).Value <> "SOLAR" And dgView.Rows(i).Cells(2).Value <> "CPO" And dgView.Rows(i).Cells(2).Value <> "PK" Then
                lblJumlahNettoPembelian.Text += dgView.Rows(i).Cells(11).Value
            ElseIf dgView.Rows(i).Cells(9).Value < dgView.Rows(i).Cells(10).Value Or dgView.Rows(i).Cells(2).Value = "SOLAR" Or dgView.Rows(i).Cells(2).Value = "CPO" Or dgView.Rows(i).Cells(2).Value = "PK" Then
                lblJumlahNettoPenjualan.Text += dgView.Rows(i).Cells(11).Value
            End If
            lblTotalNetto.Text += dgView.Rows(i).Cells(11).Value
        Next

        lblJumlahNettoPembelian.Text = FormatNumber(lblJumlahNettoPembelian.Text, 0)
        lblJumlahNettoPenjualan.Text = FormatNumber(lblJumlahNettoPenjualan.Text, 0)
        lblTotalNetto.Text = FormatNumber(lblTotalNetto.Text, 0)
    End Sub

End Class