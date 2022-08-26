Public Class frmUpdateHarga
    Dim rSebelum, cSebelum As Integer
    Dim tScroll As Boolean = False
    Dim modeDgView As Boolean = False
    Dim bTemp As Boolean = False
    Dim editMode As Boolean = False
    Dim doneEdit As Boolean = True
    Dim tC As Integer = 0
    Dim tR As Integer = 0
    Dim tAwal As Object = 0
    Dim tAwal2 As Object = 0
    Dim enterTekan As Boolean = False
    Public dtHelp23 As Object

    Sub loadMain()
        editMode = False
        tC = 0
        tR = 0
        tAwal = 0
        doneEdit = True
        enterTekan = False

        rSebelum = 0
        Dim myQuery As String = "select kodekelompok,kelompok,UrutanHarga from kelompok where kodeKelompok like '%" & txtKelompok.Text & "%'and hidekelompok='N' and kodekota='" & clsKoneksi.kotaOn & "' "
        Dim myQuery2 As String = "select kodekelompok from kelompok where kodeKelompok like '%" & txtKelompok.Text & "%'and hidekelompok='N' and kodekota='" & clsKoneksi.kotaOn & "' "
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

        myQuery = myQuery & " order by UrutanHarga "

        Dim tDs As DataSet = clsKoneksi.selectCommand(1, myQuery)
        dgView.Columns.Clear()
        dgView.Columns.Add("Tgl", "Tgl")
        dgView.Columns(dgView.Columns.Count - 1).Width = 70

        dgView.Columns.Add("Jam", "Jam")
        dgView.Columns(dgView.Columns.Count - 1).Width = 70
        dgView.Columns.Add("hargaPapan", "Hrg Papan")
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

        Dim myQuery3 As String = "Select top 1 kodekelompok from kelompok where grade='A' and kodeKota='" & clsKoneksi.kotaOn & "'"
        Dim tDs2 As DataSet = clsKoneksi.selectCommand(1, myQuery3)
        Dim isiView2(0) As Object
        Dim kodeKelompok As String = ""

        For i As Integer = 0 To tDs2.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView2.Length - 1
                If tDs2.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView2(j) = ""
                Else
                    isiView2(j) = tDs2.Tables(0).Rows(i).Item(j)
                End If
            Next
            kodeKelompok = isiView2(0)
        Next

        Try
            dgView.Columns(kodeKelompok).DefaultCellStyle.Format = "N2"
        Catch ex As Exception

        End Try

        loadIsi2()
        loadIsi()
        loadIsi3()
    End Sub
    Sub loadIsi2()
        Dim grade As String = ""
        Dim tanggal As String
        Dim plat As String
        Dim intT As Integer = cboGrade.SelectedIndex
        Select Case intT
            Case 0
                grade = "Kelompok.Grade<>'P'"
            Case 1
                grade = "Kelompok.Grade='A'"
            Case 2
                grade = "Kelompok.Grade='B'"
            Case 3
                grade = "Kelompok.Grade='C'"
        End Select

        tanggal = "(Harga.tgl>=#" & Format(dtAwal.Value.Date, "MM/dd/yyyy") & "# and Harga.tgl<=#" & Format(dtAkhir.Value.Date, "MM/dd/yyyy") & "#)"

        If ckHargaPlat.Checked = False Then
            plat = " Plat Is Null"
        Else
            plat = " Harga.plat<>''"
        End If
        Dim tDs1 As DataSet
        Dim myQuery1 As String
        'myQuery1 = "select distinct([Harga.tgl]),Harga.jam from Harga left JOIN Kelompok ON Kelompok.KodeKelompok = Harga.KodeKelompok where " & grade & " and " & tanggal & " and Harga.kodekota='" & clsKoneksi.kotaOn & "' and Harga.kodeKelompok like '%" & txtKelompok.Text & "%' or Harga.kodeKelompok='hargaPapan'  order by Harga.tgl ASC,harga.jam ASC"
        myQuery1 = " select distinct tanggal,jam from (select distinct([Harga.tgl]) as tanggal,format(Harga.jam,""Long Time"") as jam from Harga left JOIN Kelompok ON Kelompok.KodeKelompok = Harga.KodeKelompok where (" & grade & " or Harga.kodeKelompok='hargaPapan') and " & tanggal & " and Harga.kodekota='" & clsKoneksi.kotaOn & "' and (Harga.kodeKelompok like '%" & txtKelompok.Text & "%' or Harga.kodeKelompok='hargaPapan') and (Harga.Plat Is Null or Harga.Plat='')  order by Harga.tgl ASC) order by tanggal,jam"

        dgView3.Rows.Clear()
        tDs1 = clsKoneksi.selectCommand(1, myQuery1)
        Dim isiView1(7) As Object
        ReDim isiView1(tDs1.Tables(0).Columns.Count - 1)
        'isiView(0) = "" 
        For i As Integer = 0 To tDs1.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView1.Length - 1
                If tDs1.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView1(j) = ""
                Else
                    isiView1(j) = tDs1.Tables(0).Rows(i).Item(j)
                End If
            Next
            dgView.Rows.Add(isiView1)
            dgView3.Rows.Add(isiView1)
        Next
        dgView.Columns(0).DefaultCellStyle = dgView3.Columns(0).DefaultCellStyle
        dgView.Columns(1).DefaultCellStyle = dgView3.Columns(1).DefaultCellStyle
    End Sub
    Sub loadIsi()
        Dim grade As String = ""
        Dim tanggal As String
        Dim plat As String
        Dim intT As Integer = cboGrade.SelectedIndex
        Select Case intT
            Case 0
                grade = "Kelompok.Grade<>'P'"
            Case 1
                grade = "Kelompok.Grade='A'"
            Case 2
                grade = "Kelompok.Grade='B'"
            Case 3
                grade = "Kelompok.Grade='C'"
        End Select

        tanggal = "(Harga.tgl>=#" & Format(dtAwal.Value.Date, "MM/dd/yyyy") & "# and Harga.tgl<=#" & Format(dtAkhir.Value.Date, "MM/dd/yyyy") & "#)"

        If ckHargaPlat.Checked = False Then
            plat = " Plat Is Null"
        Else
            plat = " Harga.plat<>''"
        End If
        Dim tDs1 As DataSet
        Dim myQuery1 As String

        myQuery1 = "select distinct([Harga.tgl]),format(Harga.jam,""Long Time"") as jam, Harga.perubahan as hargapapan,Harga.perubahan as ppn,Harga.kodeKelompok,Kelompok.urutanHarga,Harga.harga,Harga.Plat from Harga left JOIN Kelompok ON Kelompok.KodeKelompok = Harga.KodeKelompok where (" & grade & " or Harga.kodeKelompok='hargaPapan') and " & tanggal & " and Harga.kodekota='" & clsKoneksi.kotaOn & "' and (Harga.kodeKelompok like '%" & txtKelompok.Text & "%' or Harga.kodeKelompok='hargaPapan') and (Harga.Plat Is Null or Harga.Plat='') order by Harga.tgl ASC"
        dgView2.Rows.Clear()
        tDs1 = clsKoneksi.selectCommand(1, myQuery1)
        Dim isiView1(7) As Object
        'isiView(0) = "" 
        For i As Integer = 0 To tDs1.Tables(0).Rows.Count - 1
            For j As Integer = 0 To isiView1.Length - 1
                If tDs1.Tables(0).Rows(i).Item(j) Is DBNull.Value Then
                    isiView1(j) = ""
                Else
                    isiView1(j) = tDs1.Tables(0).Rows(i).Item(j)
                End If
            Next
            dgView2.Rows.Add(isiView1)

        Next
    End Sub

    Sub loadIsi3()
        For j As Integer = 1 To dgView.Rows.Count - 1
            For k As Integer = 2 To dgView.Columns.Count - 1
                If dgView.Columns(k).HeaderText <> "(+-)" Then
lanjut:
                    For i As Integer = 0 To dgView2.Rows.Count - 1
                        If dgView.Rows(j).Cells(0).Value = dgView2.Rows(i).Cells(0).Value And dgView.Rows(j).Cells(1).Value = dgView2.Rows(i).Cells(1).Value Then
                            If dgView.Columns(k).Name = dgView2.Rows(i).Cells(4).Value Then
                                dgView.Rows(j).Cells(k).Value = dgView2.Rows(i).Cells(6).Value
                                dgView.Rows(j).Cells(k + 1).Value = dgView2.Rows(i).Cells(3).Value
                                dgView2.Rows.RemoveAt(i)
                                GoTo lanjut
                            End If
                        Else

                        End If
                    Next
                End If
            Next
        Next
    End Sub
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        loadMain()
    End Sub
    Private Sub frmUpdateHarga_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        dtAkhir.Value = Now
        dtAwal.Value = Now.AddDays(-10)
        cboGrade.SelectedIndex = 0
    End Sub

    ''' <summary>
    ''' default "00:00:00"
    ''' </summary>
    Sub setjamDtHelp(Optional ByVal jamT As String = "00:00:00")
        dtHelp.Format = DateTimePickerFormat.Time
        dtHelp.Value = Convert.ToDateTime(Now.Date.ToLongDateString & " " & jamT)
    End Sub

    Private Sub mnuEdit_Click(sender As Object, e As EventArgs) Handles mnuEdit.Click
        Dim a As Integer = dgView.CurrentRow.Index
        Dim kodeKelompokA As String = ""
        Dim jumlahDatacek As Integer = 0
        For i As Integer = 2 To dgView.Columns.Count - 1
            If i Mod 2 = 0 Then
                If dgView.Rows(0).Cells(i).Value = True Then
                    If kodeKelompokA = "" Then
                        kodeKelompokA = "'" & dgView.Columns(i).Name & "'"
                    Else
                        kodeKelompokA = kodeKelompokA & ",'" & dgView.Columns(i).Name & "'"
                    End If
                    jumlahDatacek += 1
                End If
            End If
        Next

        If jumlahDatacek > 1 Then
            MsgBox("Maaf, untuk saat ini data update hanya bisa 1 data saja.")
            Return
        End If

        If kodeKelompokA = "" Then
            MsgBox("Pilih Data", vbCritical)
            Return
        End If

        frmUpdateHargaEdit.lblTgl.Text = dgView.Item(0, a).Value
        frmUpdateHargaEdit.dtHelp.Text = dgView.Item(0, a).Value
        frmUpdateHargaEdit.lblJam.Text = dgView.Item(1, a).Value
        frmUpdateHargaEdit.dtHelp2 = dgView.Item(1, a).Value
        frmUpdateHargaEdit.tRow = a
        frmUpdateHargaEdit.txtHarga.Text = "0"
        frmUpdateHargaEdit.txtKelompok.Text = kodeKelompokA
        frmUpdateHargaEdit.txtKelompok2.Text = kodeKelompokA
        frmUpdateHargaEdit.jlhData = jumlahDatacek
        frmUpdateHargaEdit.ShowDialog(Me)
    End Sub

    Private Sub dgView_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgView.CellBeginEdit
        tC = e.ColumnIndex
        tR = e.RowIndex
        If tR < 1 Then Return

        editMode = True

        tAwal = dgView.Item(e.ColumnIndex, e.RowIndex).Value
        tAwal2 = dgView.Item(e.ColumnIndex + 1, e.RowIndex).Value
        doneEdit = False
    End Sub

    Private Sub dgView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgView.CellEndEdit
        If tR < 1 Then Return
        '  If tC < 2 Then Return
        editMode = False
        Dim tb As Boolean = False
        If doneEdit = False Or tC < 2 Then
            doneEdit = True
            dgView.Item(tC, tR).Value = tAwal
        Else
            If dgView.Item(tC, tR).Value = Nothing Then
                MsgBox("Data tidak boleh kosong", vbCritical, "Warning")
                Exit Sub
            End If
            dgView.Item(tC, tR).Value = CDbl(dgView.Item(tC, tR).Value.ToString.Replace(" ", ""))
            Dim tPerubahan As Double = 0
            tPerubahan = dgView.Item(tC, tR).Value - tAwal
            dgView.Item(tC + 1, tR).Value = dgView.Item(tC + 1, tR).Value + tPerubahan
            dtHelp.Text = dgView.Item(0, tR).Value
            dtHelp23 = dgView.Item(1, tR).Value
            If dgView.Columns(tC).Name = "hargaPapan" Then
                Dim kondisiWhere1 As String
                Dim myQuery1 As String = "UPDATE Harga h inner join papan p on p.kodeKelompok=h.kodeKelompok " & _
                                        "SET  " & _
                                        "h.Harga=iif(h.harga > 0,h.Harga+@PerubahanAA,h.Harga+@PerubahanAA+p.penambahanHarga) " & _
                                        ",h.Perubahan = h.Perubahan+ @PerubahanAA "
                kondisiWhere1 = "WHERE h.Tgl = @tglAA and h.Jam=@jamAA and h.KodeKota=@KodeKotaAA"
                Dim namaKolom1 As String() = {""}
                Dim isiKolom1 As Object() = {""}
                Dim namaKolom3 As String() = {"PerubahanAA", "tglAA", "jamAA", "KodeKotaAA"}
                Dim isiKolom3 As Object() = {tPerubahan, dtHelp.Value, dtHelp23, clsKoneksi.kotaOn}
                clsKoneksi.updateCommand(1, myQuery1, namaKolom1, isiKolom1, kondisiWhere1, namaKolom3, isiKolom3, 2)
                tb = True
            End If

            Dim tDs1 As DataSet
            Dim queryCekData = "select kodeKelompok from harga where KodeKelompok in('" & dgView.Columns(tC).Name & "') and Tgl=#" & dtHelp.Value.ToString("MM/dd/yyyy") & "# and Jam=#" & dtHelp23 & "# and KodeKota='" & clsKoneksi.kotaOn & "'"
            tDs1 = clsKoneksi.selectCommand(1, queryCekData)
            If (tDs1.Tables(0).Rows.Count > 0) Then
                Dim kondisiWhere As String
                Dim myQuery As String = "UPDATE Harga " & _
                                        "SET  " & _
                                        "Harga = Harga+@PerubahanAA " & _
                                        ",Perubahan = Perubahan+ @PerubahanAA "
                kondisiWhere = "WHERE KodeKelompok in ('" & dgView.Columns(tC).Name & "') and Tgl = @tglAA and Jam=@jamAA and KodeKota=@KodeKotaAA"
                Dim namaKolom As String() = {""}
                Dim isiKolom As Object() = {""}
                Dim namaKolom2 As String() = {"PerubahanAA", "tglAA", "jamAA", "KodeKotaAA"}
                Dim isiKolom2 As Object() = {tPerubahan, dtHelp.Value, dtHelp23, clsKoneksi.kotaOn}
                Console.WriteLine(dgView.Item(tC, tR).Value)
                clsKoneksi.updateCommand(1, myQuery, namaKolom, isiKolom, kondisiWhere, namaKolom2, isiKolom2, 2)
            Else

                If tPerubahan = Nothing Then
                    MsgBox("Data tidak boleh kosong", vbCritical)
                    Return
                End If
                Dim myQuery6 As String = "INSERT INTO harga "
                Dim namaKolom6 As String() = {"KodeKelompok", "[Tgl]", "[Jam]", "Harga", "Perubahan", "KodeKota", "autoUp"}
                Dim isiKolom6 As Object() = {dgView.Columns(tC).Name, dtHelp.Value.Date, dtHelp23, tPerubahan, tPerubahan, clsKoneksi.kotaOn, "0"}
                clsKoneksi.insertCommand(1, myQuery6, namaKolom6, isiKolom6)
            End If
            If tb Then loadMain()

        End If
    End Sub

    Private Sub dgView_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgView.CellMouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            bTemp = True
        End If
    End Sub

    Private Sub dgView_MouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgView.CellMouseUp
        Try
            If e.Button = MouseButtons.Right Then
                Dim Rowindexx As Integer
                Me.dgView.Rows(e.RowIndex).Selected = True
                Rowindexx = e.RowIndex
                Me.dgView.CurrentCell = Me.dgView.Rows(e.RowIndex).Cells(1)
                Me.klikKananMenu.Show(Me.dgView, e.Location)
                Me.klikKananMenu.Show(Cursor.Position)
            End If
        Catch ex As Exception
            MsgBox("Klik data", vbExclamation)
        End Try
    End Sub

    Private Sub klikKananMenu_Closed(sender As Object, e As ToolStripDropDownClosedEventArgs) Handles klikKananMenu.Closed
        klikKananMenu.ShowItemToolTips = False
    End Sub

    Private Sub btnUpdateHarga_Click(sender As Object, e As EventArgs) Handles btnUpdateHarga.Click
        frmUpdateHargaRata.ShowDialog()
    End Sub

    Private Sub mnuTambah_Click(sender As Object, e As EventArgs) Handles mnuTambah.Click
        frmUpdateHargaTambahdetail.ShowDialog()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs)
        frmUpdateHargaCoba.ShowDialog()
    End Sub

    Private Sub ButtonX1_Click_1(sender As Object, e As EventArgs)
        frmUpdateHargaCoba.ShowDialog()
    End Sub

    Private Sub btnUpdateHarga2_Click(sender As Object, e As EventArgs) Handles btnUpdateHarga2.Click
        frmUpdateHargaKelompok.ShowDialog()
    End Sub

    Private Sub btnPlat_Click(sender As Object, e As EventArgs) Handles btnPlat.Click
        frmUpdateHargaPlat.ShowDialog()
    End Sub

    Private Sub frmUpdateHarga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadIsi3()
    End Sub

    Private Sub hargaPlat_Click(sender As Object, e As EventArgs) Handles hargaPlat.Click
        Dim a As Integer = dgView.CurrentRow.Index
        Dim kodeKelompokA As String = ""
        For i As Integer = 2 To dgView.Columns.Count - 1
            If i Mod 2 = 0 Then
                If dgView.Rows(0).Cells(i).Value = True Then
                    If kodeKelompokA = "" Then
                        kodeKelompokA = "'" & dgView.Columns(i).Name & "'"
                    Else
                        kodeKelompokA = kodeKelompokA & ",'" & dgView.Columns(i).Name & "'"
                    End If
                End If
            End If
        Next

        If kodeKelompokA = "" Then
            MsgBox("Ceklis data terlebih dahulu", vbCritical)
            Return
        End If

        frmUpdateHargaPlatData.txtKodeKelompok.Text = kodeKelompokA
        frmUpdateHargaPlatData.dtpTanggal.Value = dgView.Item(0, a).Value
        frmUpdateHargaPlatData.dtpJam.Value = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, CDate(dgView.Item(1, a).Value).Hour, CDate(dgView.Item(1, a).Value).Minute, CDate(dgView.Item(1, a).Value).Second)
        frmUpdateHargaPlatData.dtHelp = dgView.Item(1, a).Value
        frmUpdateHargaPlatData.ShowDialog()
    End Sub

    Private Sub btnShowHide_Click(sender As Object, e As EventArgs) Handles btnShowHide.Click
        Try
            Dim tBool As Boolean = dgView.Columns(5).Visible
            For j As Integer = 4 To dgView.Columns.Count - 1
                If j Mod 2 = 1 Then dgView.Columns(j).Visible = Not tBool
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonX1_Click_2(sender As Object, e As EventArgs)
        loadIsi()
    End Sub

    Private Sub mnuEditHarga_Click(sender As Object, e As EventArgs) Handles mnuEditHarga.Click
        Dim a As Integer = dgView.CurrentRow.Index
        Dim t As Integer = 0

        Dim kodeKelompokA As String = ""
        For i As Integer = 2 To dgView.Columns.Count - 1
            If i Mod 2 = 0 Then
                If dgView.Rows(0).Cells(i).Value = True Then
                    t = i
                    If kodeKelompokA = "" Then
                        kodeKelompokA = "'" & dgView.Columns(i).Name & "'"
                    Else
                        kodeKelompokA = kodeKelompokA & ",'" & dgView.Columns(i).Name & "'"
                    End If
                End If
            End If
        Next
        If kodeKelompokA = "" Then
            MsgBox("Kelompok belum dipilih")
            Return
        End If

        frmEditHargaNotUpdate.dtpTanggal.Value = dgView.Item(0, a).Value
        frmEditHargaNotUpdate.lblJam.Text = dgView.Item(1, a).Value
        frmEditHargaNotUpdate.dtHelp2 = dgView.Item(1, a).Value
        frmEditHargaNotUpdate.txtKelompok.Text = kodeKelompokA
        frmEditHargaNotUpdate.tRow = a
        frmEditHargaNotUpdate.txtHarga.Text = dgView.Item(t, a).Value
        frmEditHargaNotUpdate.lblHargaLama.Text = dgView.Item(t, a).Value
        frmEditHargaNotUpdate.ShowDialog(Me)
    End Sub

    Private Sub cell_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Space Then
            editMode = False
            doneEdit = True
            enterTekan = True
            dgView.EndEdit()
        End If
    End Sub

    Private Sub dgView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgView.EditingControlShowing
        AddHandler e.Control.KeyDown, AddressOf cell_KeyDown
        For i As Integer = 0 To dgView.Columns.Count - 1
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
        Next
    End Sub

    Private Sub TextBox_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        clsKoneksi.textBoxOnlyNumber(e)
    End Sub

    Sub loadUpdateHarga(tRow As Integer, tPerubahan As Double)
        Dim a As Integer = dgView.CurrentRow.Index
        Dim kodeKelompokA As String = ""
        For i As Integer = 2 To dgView.Columns.Count - 1
            If i Mod 2 = 0 Then
                If dgView.Rows(0).Cells(i).Value = True Then
                    dgView.Item(i, tRow).Value = dgView.Item(i, tRow).Value + tPerubahan
                    dgView.Item(i + 1, tRow).Value = dgView.Item(i + 1, tRow).Value + tPerubahan
                End If
            End If
        Next
    End Sub

    Sub loadUpdateHargaNotperubahan(tRow As Integer, tPerubahan As Double)
        Dim a As Integer = dgView.CurrentRow.Index
        Dim kodeKelompokA As String = ""
        For i As Integer = 2 To dgView.Columns.Count - 1
            If i Mod 2 = 0 Then
                If dgView.Rows(0).Cells(i).Value = True Then
                    dgView.Item(i, tRow).Value = tPerubahan
                    dgView.Item(i + 1, tRow).Value = tPerubahan
                End If
            End If
        Next
    End Sub

    Private Sub txtKelompok_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKelompok.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            loadMain()
        End If
    End Sub
    Private Sub MnuHapusPertanggal_Click(sender As Object, e As EventArgs) Handles MnuHapusPertanggal.Click
        If MsgBox("Yakin ingin menghapus data ini ? data pada tanggal " & dgView.SelectedCells(0).Value & " dan jam " & dgView.SelectedCells(1).Value & " akan terhapus", vbQuestion + vbYesNo) = vbYes Then
            Dim myQuery2 As String = "delete from harga where tgl=@tgl and Jam=@jam and KodeKota=@kodeKota"
            Dim namaKolom2 As String() = {"tgl", "Jam", "kodeKota"}
            Dim isiKolom2 As Object() = {CDate(dgView.SelectedCells(0).Value), dgView.SelectedCells(1).Value, clsKoneksi.kotaOn}
            clsKoneksi.deleteCommand(1, myQuery2, namaKolom2, isiKolom2, 1)
            loadMain()
        End If
    End Sub

    Private Sub btnKalkulasi_Click(sender As Object, e As EventArgs)
        FrmAkkHargaRata2.ShowDialog()
    End Sub
End Class
