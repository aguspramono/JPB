Public Class frmInputMultiJumlahSPSI

    Sub clearData()
        dgvData.Rows.Clear()
        dgvData.ClearSelection()
        dgvData.CurrentCell = dgvData.Item("Column1", 0)
        dgvData.BeginEdit(True)
        Dim row As String() = New String() {" "}
        dgvData.Rows.Add(row)
        dgvData.ClearSelection()
        dgvData.Rows(0).Cells(0).Selected = True
        mnuKlikKanan.Enabled = True
        btnSimpan.Enabled = False
        btnCekData.Enabled = True

        lblDataTidakValid.Text = "Data Tidak Valid: 0"
        lblDataValid.Text = "Data Valid: 0"


        For i As Integer = 0 To dgvData.Rows.Count - 1
            dgvData.Rows(i).HeaderCell.Value = i.ToString()
        Next
    End Sub
    Private Sub CopyToClipboard()
        ' Copy to clipboard
        Dim dataObj As DataObject = dgvData.GetClipboardContent()
        If (Not IsNothing(dataObj)) Then
            Clipboard.SetDataObject(dataObj)
        End If
    End Sub
    Private Sub PasteClipboardValue()

        ' Show Error if no cell is selected
        If (dgvData.SelectedCells.Count = 0) Then
            MessageBox.Show("Please select a cell", "Paste", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the starting Cell
        Dim startCell As DataGridViewCell = GetStartCell(dgvData)
        ' Get the clipboard value in a dictionary
        Dim cbValue As New Dictionary(Of Integer, Dictionary(Of Integer, String))
        cbValue = ClipBoardValues(Clipboard.GetText())


        Dim iRowIndex As Integer = startCell.RowIndex
        Dim nomorPaste As Integer = 0
        For Each rowKey As Integer In cbValue.Keys
            Dim iColIndex As Integer = startCell.ColumnIndex
            'Console.WriteLine(iColIndex + 1)
            For Each cellKey As Integer In cbValue(rowKey).Keys
                ' Check if the index is within the limit
                If (iColIndex <= dgvData.Columns.Count - 1 And _
                iRowIndex <= dgvData.Rows.Count - 1) Then
                    Dim item() As Object = cbValue(rowKey)(cellKey).Split(vbTab)


                    For j As Integer = 0 To item.Count - 1
                        Dim cell As DataGridViewCell = dgvData(iColIndex + j, iRowIndex)
                        cell.Value = item(j)
                    Next
                    nomorPaste += 1
                    dgvData.Rows.Add()

                End If
                iColIndex += 1
            Next
            iRowIndex += 1
        Next
        iRowIndex = 0


        For i As Integer = 0 To dgvData.Rows.Count - 1
            dgvData.Rows(i).HeaderCell.Value = i.ToString()
        Next

    End Sub
    Private Function GetStartCell(dgView As DataGridView) As DataGridViewCell
        ' get the smallest row,column index
        If (dgView.SelectedCells.Count = 0) Then
            Return Nothing
        End If
        Dim rowIndex As Integer = dgView.Rows.Count - 1
        Dim colIndex As Integer = dgView.Columns.Count - 1

        For Each dgvCell As DataGridViewCell In dgView.SelectedCells
            If (dgvCell.RowIndex < rowIndex) Then
                rowIndex = dgvCell.RowIndex
            End If
            If (dgvCell.ColumnIndex < colIndex) Then
                colIndex = dgvCell.ColumnIndex
            End If
        Next
        Return dgView(colIndex, rowIndex)
    End Function
    Private Function ClipBoardValues(clipboardValue As String) As Dictionary(Of Integer, Dictionary(Of Integer, String))
        Dim copyValues As Dictionary(Of Integer, Dictionary(Of Integer, String)) = _
        New Dictionary(Of Integer, Dictionary(Of Integer, String))()

        Dim lines As String() = clipboardValue.Split(vbCrLf)

        For i As Integer = 0 To lines.Length - 1
            copyValues(i) = New Dictionary(Of Integer, String)()
            Dim lineContent As String() = lines(i).Split("\t")

            ' if an empty cell value copied, then set the dictionary with an empty string
            ' else Set value to dictionary
            If (lineContent.Length = 0) Then
                copyValues(i)(0) = String.Empty
            Else
                For j As Integer = 0 To lineContent.Length - 1
                    copyValues(i)(j) = lineContent(j)
                Next
            End If
        Next
        Return copyValues
    End Function

    Private Sub frmInputMultiJumlahSPSI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearData()
    End Sub

    Private Sub mnuCopy_Click(sender As Object, e As EventArgs) Handles mnuCopy.Click
        CopyToClipboard()
    End Sub

    Private Sub mnuCut_Click(sender As Object, e As EventArgs) Handles mnuCut.Click
        'Copy to clipboard
        CopyToClipboard()
        'Clear selected cells
        For Each dgvCell As DataGridViewCell In dgvData.SelectedCells
            dgvCell.Value = String.Empty
        Next
    End Sub

    Private Sub mnuPaste_Click(sender As Object, e As EventArgs) Handles mnuPaste.Click
        PasteClipboardValue()
        'remove empty row
        For y As Integer = dgvData.Rows.Count - 1 To 0 Step -1
            If y = dgvData.NewRowIndex Then Continue For
            Dim empty As Boolean = True
            For x As Integer = 0 To dgvData.Rows(y).Cells.Count - 1
                If dgvData.Rows(y).Cells(x).Value IsNot Nothing AndAlso dgvData.Rows(y).Cells(x).Value.ToString <> "" Then
                    empty = False
                End If
            Next
            If empty Then
                dgvData.Rows.RemoveAt(y)
            End If
        Next
    End Sub

    Private Sub dgvData_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvData.CellMouseClick
        'if the datagridview was right clicked, set the currentcell to the right-clicked cell and then show a context menu with options for filling the right-clicked cell
        If (e.Button = Windows.Forms.MouseButtons.Right) Then
            Try
                'highlight the right-clicked cell, make it the dgv's current cell
                dgvData.CurrentRow.Selected = False
                dgvData.Rows(e.RowIndex).Selected = True
                dgvData.CurrentCell = dgvData.Rows(e.RowIndex).Cells(e.ColumnIndex)
                dgvData.ContextMenuStrip = mnuKlikKanan
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub btnBersih_Click(sender As Object, e As EventArgs) Handles btnBersih.Click
        clearData()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim decimalSeparator As String = Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator
        Dim simpan As Boolean = True

        Dim jumlahRowsIsi As Double = 0
        Dim jumlahDataValid As Double = 0
        Dim myQuery3 As String = "INSERT INTO SpsiPenjumlahan "
        Dim namaKolom3 As String() = {"Tanggal", "NoAcc", "NoBukti", "Nama", "SPSI", "Keterangan", "Nilai", "KodeKota"}


        For i As Integer = 0 To dgvData.Rows.Count - 1
            If dgvData.Rows(i).Cells(0).Value Is Nothing Or dgvData.Rows(i).Cells(0).Value = " " Or dgvData.Rows(i).Cells(0).Value = vbLf Then
                dgvData.Rows(i).Cells(0).Value = ""
            End If

            If dgvData.Rows(i).Cells(1).Value Is Nothing Or dgvData.Rows(i).Cells(1).Value = " " Or dgvData.Rows(i).Cells(1).Value = vbLf Then
                dgvData.Rows(i).Cells(1).Value = ""
            End If

            If dgvData.Rows(i).Cells(0).Value <> "" And dgvData.Rows(i).Cells(1).Value <> "" Then
                jumlahRowsIsi += 1
            End If
        Next

        If jumlahRowsIsi > 0 Then
            For i = 0 To jumlahRowsIsi - 1
                If dgvData.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen Then
                    jumlahDataValid += 1
                End If
            Next
        End If

        Dim isiKolom3(8) As Object
        ReDim isiKolom3((namaKolom3.Length * jumlahDataValid) - 1)
        Dim cntT As Integer = 0

        If jumlahDataValid = 1 Then
            Try
                For i = 0 To jumlahRowsIsi - 1

                    If dgvData.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen Then
                        Dim edate = dgvData.Rows(i).Cells(0).Value
                        Dim format() = {"d-MMM-yy", "dd-MMM-yy", "dd/MM/yyyy", "d/M/yyyy", "M/d/yyyy", "dd-MM-yyyy", "ddd, MMMM dd, yyyy", "dd MMMM yyyy"}
                        Dim expenddt As Date
                        Date.TryParseExact(edate, format,
                            System.Globalization.CultureInfo.CurrentCulture,
                            Globalization.DateTimeStyles.NoCurrentDateDefault, expenddt)

                        Dim noBukti As String = dgvData.Rows(i).Cells(2).Value
                        noBukti = noBukti.Replace(" ", "")

                        isiKolom3(cntT + 0) = expenddt
                        isiKolom3(cntT + 1) = dgvData.Rows(i).Cells(1).Value
                        isiKolom3(cntT + 2) = noBukti
                        isiKolom3(cntT + 3) = dgvData.Rows(i).Cells(3).Value
                        isiKolom3(cntT + 4) = dgvData.Rows(i).Cells(4).Value
                        isiKolom3(cntT + 5) = dgvData.Rows(i).Cells(5).Value
                        isiKolom3(cntT + 6) = Convert.ToDouble(dgvData.Rows(i).Cells(6).Value)
                        isiKolom3(cntT + 7) = clsKoneksi.kotaOn
                        cntT += 8
                    End If
                Next
                clsKoneksi.insertCommand(1, myQuery3, namaKolom3, isiKolom3)
            Catch ex As Exception
                MsgBox("Terjadi Kesalahan, Pastikan isi sesuai dengan nama kolom", vbCritical)
                simpan = False
            End Try

        ElseIf jumlahDataValid > 1 Then
            Try
                For i As Integer = 0 To jumlahRowsIsi - 1
                    If dgvData.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen Then
                        Dim edate As String = dgvData.Rows(i).Cells(0).Value
                        Dim edate1 As String = edate.Replace(vbLf, "")
                        Dim format() = {"d-MMM-yy", "dd-MMM-yy", "dd/MM/yyyy", "d/M/yyyy", "M/d/yyyy", "dd-MM-yyyy", "ddd, MMMM dd, yyyy", "dd MMMM yyyy"}
                        Dim expenddt As Date
                        Date.TryParseExact(edate1, format,
                            System.Globalization.CultureInfo.CurrentCulture,
                            Globalization.DateTimeStyles.NoCurrentDateDefault, expenddt)

                        Dim noBukti As String = dgvData.Rows(i).Cells(2).Value
                        noBukti = noBukti.Replace(" ", "")


                        isiKolom3(cntT + 0) = "'" & expenddt & "'"
                        isiKolom3(cntT + 1) = "'" & dgvData.Rows(i).Cells(1).Value & "'"
                        isiKolom3(cntT + 2) = "'" & noBukti & "'"
                        isiKolom3(cntT + 3) = "'" & dgvData.Rows(i).Cells(3).Value & "'"
                        isiKolom3(cntT + 4) = "'" & dgvData.Rows(i).Cells(4).Value & "'"
                        isiKolom3(cntT + 5) = "'" & dgvData.Rows(i).Cells(5).Value & "'"
                        If decimalSeparator = "," Then
                            isiKolom3(cntT + 6) = CDbl(dgvData.Rows(i).Cells(6).Value).ToString.Replace(",", ".")
                        Else
                            isiKolom3(cntT + 6) = CDbl(dgvData.Rows(i).Cells(6).Value)
                        End If
                        isiKolom3(cntT + 7) = clsKoneksi.kotaOn
                        cntT += 8
                    Else

                    End If

                Next
                clsKoneksi.insertCommand2(1, myQuery3, namaKolom3, isiKolom3)
            Catch ex As Exception
                MsgBox("Terjadi Kesalahan, Pastikan isi sesuai dengan nama kolom", vbCritical)
                simpan = False
            End Try

        Else
            MsgBox("Tidak ada data yang valid", vbCritical)
            simpan = False
        End If
        If simpan = True Then
            MsgBox("Data berhasil disimpan")
            clearData()
        End If
        

    End Sub

    Private Sub btnCekData_Click(sender As Object, e As EventArgs) Handles btnCekData.Click

        Dim jumlahRowsIsi As Double = 0
        Dim jumlahDataAda As Double = 0
        Dim jumlahBedaNama As Double = 0
        Dim jumlahDataValid As Double = 0
        If dgvData.Rows.Count > 0 Then

            For i As Integer = 0 To dgvData.Rows.Count - 1
                If dgvData.Rows(i).Cells(0).Value Is Nothing Or dgvData.Rows(i).Cells(0).Value = " " Or dgvData.Rows(i).Cells(0).Value = vbLf Then
                    dgvData.Rows(i).Cells(0).Value = ""
                End If

                If dgvData.Rows(i).Cells(1).Value Is Nothing Or dgvData.Rows(i).Cells(1).Value = " " Or dgvData.Rows(i).Cells(1).Value = vbLf Then
                    dgvData.Rows(i).Cells(1).Value = ""
                End If


                If dgvData.Rows(i).Cells(0).Value <> "" And dgvData.Rows(i).Cells(1).Value <> "" Then
                    jumlahRowsIsi += 1
                End If
            Next


            If jumlahRowsIsi > 0 Then
                For j As Integer = 0 To jumlahRowsIsi - 1
                    dgvData.Rows(j).DefaultCellStyle.BackColor = Color.LightGreen

                    If dgvData.Rows(j).Cells(0).Value Is Nothing Or dgvData.Rows(j).Cells(0).Value = " " Then
                        dgvData.Rows(j).Cells(0).Value = ""
                    End If


                Next

                Dim noBukti As String = String.Empty
                For i As Integer = 0 To jumlahRowsIsi - 1
                    noBukti &= "'" & dgvData.Rows(i).Cells(2).Value & "',"
                Next

                noBukti = noBukti.Remove(noBukti.Length - 1, 1)
                noBukti = noBukti.Replace(" ", "")


                Dim myQuery As String = "select NoBukti,Nama from SpsiPenjumlahan where NoBukti in(" & noBukti & ") and KodeKota='" & clsKoneksi.kotaOn & "' order by Tanggal"
                myQuery = myQuery
                Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
                Dim isiView(1) As Object
                'isiView(0) = ""
                For i As Integer = 0 To tDs.Tables(0).Rows.Count - 1
                    For j As Integer = 0 To isiView.Length - 1
                        If tDs.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                            isiView(j) = ""
                        Else
                            isiView(j) = tDs.Tables(0).Rows(i).Item(j)
                        End If
                    Next

                    For k As Integer = 0 To jumlahRowsIsi - 1
                        Dim noBukti2 As String = dgvData.Rows(k).Cells(2).Value
                        noBukti2 = noBukti2.Replace(" ", "")

                        Dim edate As String = dgvData.Rows(i).Cells(0).Value
                        edate = edate.Replace(vbLf, "")
                        Dim format() = {"d-MMM-yy", "dd-MMM-yy", "dd/MM/yyyy", "d/M/yyyy", "M/d/yyyy", "dd-MM-yyyy", "ddd, MMMM dd, yyyy", "dd MMMM yyyy"}
                        Dim expenddt As Date
                        Date.TryParseExact(edate, format,
                            System.Globalization.DateTimeFormatInfo.InvariantInfo,
                            Globalization.DateTimeStyles.None, expenddt)

                        If isiView(0) = noBukti2 And isiView(1) = dgvData.Rows(k).Cells(3).Value Then
                            dgvData.Rows(k).DefaultCellStyle.BackColor = Color.Pink
                            jumlahDataAda += 1
                        End If
                    Next
                Next


                For i As Integer = 0 To jumlahRowsIsi - 1
                    If dgvData.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen Then
                        jumlahDataValid += 1
                    End If
                Next

                If jumlahDataAda > 0 Then
                    MsgBox("Ada data yang sudah ada didatabase, data yang sudah ada tidak akan dimasukkan lagi.", vbExclamation)
                End If


                lblDataTidakValid.Text = "Data Tidak Valid: " & jumlahRowsIsi - jumlahDataValid
                lblDataValid.Text = "Data Valid: " & jumlahDataValid
                mnuKlikKanan.Enabled = False
                btnSimpan.Enabled = True
                btnCekData.Enabled = False

            Else
                MsgBox("Tidak ada data yang valid", vbCritical)
            End If
        Else
            MsgBox("Belum ada data", vbCritical)
        End If
    End Sub
End Class