<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPembayaran
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPembayaran))
        Me.txtTotal = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dgView = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.txtTotal2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.klikKananMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuTambah = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHapus = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtNoPembayaranlama = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnCari2 = New DevComponents.DotNetBar.ButtonX()
        Me.dtTanggal = New System.Windows.Forms.DateTimePicker()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.txtKeterangan = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.btnCari = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnOk = New DevComponents.DotNetBar.ButtonX()
        Me.btnHapus = New DevComponents.DotNetBar.ButtonX()
        Me.btnEdit = New DevComponents.DotNetBar.ButtonX()
        Me.btnBaru = New DevComponents.DotNetBar.ButtonX()
        Me.txtNama = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNoAccount = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNoPembayaran = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.btnPembayaranTBS = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX()
        Me.txtDibayar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtSisa = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX()
        Me.dgvData2 = New System.Windows.Forms.DataGridView()
        Me.Column25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvData3 = New System.Windows.Forms.DataGridView()
        Me.Column26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtKodeParam = New System.Windows.Forms.TextBox()
        Me.txtPPH = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX19 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX20 = New DevComponents.DotNetBar.LabelX()
        Me.txtSPSI = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX21 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX22 = New DevComponents.DotNetBar.LabelX()
        Me.txtTotalLast = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX23 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX24 = New DevComponents.DotNetBar.LabelX()
        Me.ckPPH = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.ckSPSI = New DevComponents.DotNetBar.Controls.CheckBoxX()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.klikKananMenu.SuspendLayout()
        CType(Me.dgvData2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvData3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTotal
        '
        '
        '
        '
        Me.txtTotal.Border.Class = "TextBoxBorder"
        Me.txtTotal.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTotal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtTotal.Location = New System.Drawing.Point(344, 36)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(23, 20)
        Me.txtTotal.TabIndex = 140
        Me.txtTotal.Visible = False
        '
        'dgView
        '
        Me.dgView.AllowUserToAddRows = False
        Me.dgView.AllowUserToDeleteRows = False
        Me.dgView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column1, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column8, Me.Column9, Me.Column10, Me.Column7, Me.Column11})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgView.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgView.EnableHeadersVisualStyles = False
        Me.dgView.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgView.HighlightSelectedColumnHeaders = False
        Me.dgView.Location = New System.Drawing.Point(5, 218)
        Me.dgView.MultiSelect = False
        Me.dgView.Name = "dgView"
        Me.dgView.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgView.RowHeadersVisible = False
        Me.dgView.SelectAllSignVisible = False
        Me.dgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgView.Size = New System.Drawing.Size(657, 163)
        Me.dgView.TabIndex = 8
        '
        'Column2
        '
        Me.Column2.HeaderText = "KodePembayaran"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "No Ticket"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 70
        '
        'Column3
        '
        '
        '
        '
        Me.Column3.BackgroundStyle.Class = "DataGridViewDateTimeBorder"
        Me.Column3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Column3.HeaderText = "Tgl"
        Me.Column3.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        '
        '
        '
        Me.Column3.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.Column3.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Column3.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        '
        '
        '
        Me.Column3.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Column3.MonthCalendar.DisplayMonth = New Date(2017, 4, 1, 0, 0, 0, 0)
        Me.Column3.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.Column3.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.Column3.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.Column3.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Column3.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 70
        '
        'Column4
        '
        Me.Column4.HeaderText = "KodeProduct"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Visible = False
        '
        'Column5
        '
        Me.Column5.HeaderText = "Product"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 70
        '
        'Column6
        '
        '
        '
        '
        Me.Column6.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.Column6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Column6.HeaderText = "Netto"
        Me.Column6.Increment = 1.0R
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.Width = 60
        '
        'Column8
        '
        Me.Column8.HeaderText = "Harga"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column8.Width = 60
        '
        'Column9
        '
        '
        '
        '
        Me.Column9.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.Column9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Column9.HeaderText = "Total"
        Me.Column9.Increment = 1.0R
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column9.Width = 80
        '
        'Column10
        '
        Me.Column10.HeaderText = "KodeKota"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Visible = False
        '
        'Column7
        '
        Me.Column7.HeaderText = "Keterangan"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        '
        'Column11
        '
        Me.Column11.HeaderText = "StatusBayar"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Visible = False
        '
        'LabelX13
        '
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.Location = New System.Drawing.Point(121, 55)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(10, 23)
        Me.LabelX13.TabIndex = 138
        Me.LabelX13.Text = ":"
        '
        'txtTotal2
        '
        '
        '
        '
        Me.txtTotal2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTotal2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtTotal2.Location = New System.Drawing.Point(137, 60)
        Me.txtTotal2.Name = "txtTotal2"
        Me.txtTotal2.ReadOnly = True
        Me.txtTotal2.Size = New System.Drawing.Size(204, 14)
        Me.txtTotal2.TabIndex = 3
        '
        'LabelX14
        '
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.Location = New System.Drawing.Point(4, 55)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(86, 23)
        Me.LabelX14.TabIndex = 136
        Me.LabelX14.Text = "Total"
        '
        'klikKananMenu
        '
        Me.klikKananMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTambah, Me.mnuHapus})
        Me.klikKananMenu.Name = "klikKananMenu"
        Me.klikKananMenu.Size = New System.Drawing.Size(119, 48)
        '
        'mnuTambah
        '
        Me.mnuTambah.Name = "mnuTambah"
        Me.mnuTambah.Size = New System.Drawing.Size(118, 22)
        Me.mnuTambah.Text = "Tambah"
        '
        'mnuHapus
        '
        Me.mnuHapus.Name = "mnuHapus"
        Me.mnuHapus.Size = New System.Drawing.Size(118, 22)
        Me.mnuHapus.Text = "Hapus"
        '
        'txtNoPembayaranlama
        '
        '
        '
        '
        Me.txtNoPembayaranlama.Border.Class = "TextBoxBorder"
        Me.txtNoPembayaranlama.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNoPembayaranlama.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNoPembayaranlama.Location = New System.Drawing.Point(344, 3)
        Me.txtNoPembayaranlama.Name = "txtNoPembayaranlama"
        Me.txtNoPembayaranlama.ReadOnly = True
        Me.txtNoPembayaranlama.Size = New System.Drawing.Size(23, 20)
        Me.txtNoPembayaranlama.TabIndex = 141
        Me.txtNoPembayaranlama.Visible = False
        '
        'btnCari2
        '
        Me.btnCari2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCari2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCari2.Location = New System.Drawing.Point(640, 2)
        Me.btnCari2.Name = "btnCari2"
        Me.btnCari2.Size = New System.Drawing.Size(22, 23)
        Me.btnCari2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCari2.TabIndex = 6
        Me.btnCari2.Text = "..."
        '
        'dtTanggal
        '
        Me.dtTanggal.Location = New System.Drawing.Point(137, 32)
        Me.dtTanggal.Name = "dtTanggal"
        Me.dtTanggal.Size = New System.Drawing.Size(204, 20)
        Me.dtTanggal.TabIndex = 2
        '
        'LabelX11
        '
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Location = New System.Drawing.Point(119, 81)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(10, 23)
        Me.LabelX11.TabIndex = 129
        Me.LabelX11.Text = ":"
        '
        'txtKeterangan
        '
        '
        '
        '
        Me.txtKeterangan.Border.Class = "TextBoxBorder"
        Me.txtKeterangan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtKeterangan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtKeterangan.Location = New System.Drawing.Point(135, 84)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(206, 99)
        Me.txtKeterangan.TabIndex = 4
        '
        'LabelX12
        '
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Location = New System.Drawing.Point(5, 81)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(86, 23)
        Me.LabelX12.TabIndex = 127
        Me.LabelX12.Text = "Keterangan"
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(490, 26)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(10, 23)
        Me.LabelX9.TabIndex = 126
        Me.LabelX9.Text = ":"
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(490, 0)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(10, 23)
        Me.LabelX8.TabIndex = 125
        Me.LabelX8.Text = ":"
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(120, 29)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(10, 23)
        Me.LabelX7.TabIndex = 124
        Me.LabelX7.Text = ":"
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(122, 3)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(10, 23)
        Me.LabelX6.TabIndex = 123
        Me.LabelX6.Text = ":"
        '
        'btnCari
        '
        Me.btnCari.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCari.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCari.Location = New System.Drawing.Point(319, 3)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(22, 23)
        Me.btnCari.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCari.TabIndex = 1
        Me.btnCari.Text = "..."
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Location = New System.Drawing.Point(292, 387)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(66, 44)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        '
        'btnOk
        '
        Me.btnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnOk.Location = New System.Drawing.Point(220, 387)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(66, 44)
        Me.btnOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnOk.TabIndex = 12
        Me.btnOk.Text = "Ok"
        '
        'btnHapus
        '
        Me.btnHapus.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnHapus.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnHapus.Location = New System.Drawing.Point(148, 387)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(66, 44)
        Me.btnHapus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnHapus.TabIndex = 11
        Me.btnHapus.Text = "Hapus"
        '
        'btnEdit
        '
        Me.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEdit.Location = New System.Drawing.Point(76, 387)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(66, 44)
        Me.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEdit.TabIndex = 10
        Me.btnEdit.Text = "Edit"
        '
        'btnBaru
        '
        Me.btnBaru.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBaru.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBaru.Location = New System.Drawing.Point(4, 387)
        Me.btnBaru.Name = "btnBaru"
        Me.btnBaru.Size = New System.Drawing.Size(66, 44)
        Me.btnBaru.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBaru.TabIndex = 9
        Me.btnBaru.Text = "Baru"
        '
        'txtNama
        '
        '
        '
        '
        Me.txtNama.Border.Class = "TextBoxBorder"
        Me.txtNama.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNama.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNama.Location = New System.Drawing.Point(506, 29)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.ReadOnly = True
        Me.txtNama.Size = New System.Drawing.Size(156, 20)
        Me.txtNama.TabIndex = 7
        '
        'txtNoAccount
        '
        '
        '
        '
        Me.txtNoAccount.Border.Class = "TextBoxBorder"
        Me.txtNoAccount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNoAccount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNoAccount.Location = New System.Drawing.Point(506, 3)
        Me.txtNoAccount.Name = "txtNoAccount"
        Me.txtNoAccount.ReadOnly = True
        Me.txtNoAccount.Size = New System.Drawing.Size(128, 20)
        Me.txtNoAccount.TabIndex = 5
        '
        'txtNoPembayaran
        '
        '
        '
        '
        Me.txtNoPembayaran.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNoPembayaran.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNoPembayaran.Location = New System.Drawing.Point(138, 7)
        Me.txtNoPembayaran.Name = "txtNoPembayaran"
        Me.txtNoPembayaran.Size = New System.Drawing.Size(176, 14)
        Me.txtNoPembayaran.TabIndex = 0
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(373, 27)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(86, 23)
        Me.LabelX4.TabIndex = 113
        Me.LabelX4.Text = "Nama"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(373, 3)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(86, 23)
        Me.LabelX3.TabIndex = 112
        Me.LabelX3.Text = "No Account"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(4, 29)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(86, 23)
        Me.LabelX2.TabIndex = 111
        Me.LabelX2.Text = "Tanggal"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(5, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(86, 23)
        Me.LabelX1.TabIndex = 110
        Me.LabelX1.Text = "No Pembayaran"
        '
        'btnPembayaranTBS
        '
        Me.btnPembayaranTBS.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPembayaranTBS.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPembayaranTBS.Location = New System.Drawing.Point(505, 387)
        Me.btnPembayaranTBS.Name = "btnPembayaranTBS"
        Me.btnPembayaranTBS.Size = New System.Drawing.Size(156, 44)
        Me.btnPembayaranTBS.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPembayaranTBS.TabIndex = 142
        Me.btnPembayaranTBS.Text = "Pembayaran TBS"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(490, 55)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(10, 23)
        Me.LabelX5.TabIndex = 144
        Me.LabelX5.Text = ":"
        '
        'LabelX10
        '
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Location = New System.Drawing.Point(373, 53)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(86, 23)
        Me.LabelX10.TabIndex = 143
        Me.LabelX10.Text = "Dibayar"
        '
        'LabelX15
        '
        '
        '
        '
        Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX15.Location = New System.Drawing.Point(490, 82)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(10, 23)
        Me.LabelX15.TabIndex = 146
        Me.LabelX15.Text = ":"
        '
        'LabelX16
        '
        '
        '
        '
        Me.LabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX16.Location = New System.Drawing.Point(373, 81)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.Size = New System.Drawing.Size(86, 23)
        Me.LabelX16.TabIndex = 145
        Me.LabelX16.Text = "Sisa Bayar"
        '
        'txtDibayar
        '
        '
        '
        '
        Me.txtDibayar.Border.Class = "TextBoxBorder"
        Me.txtDibayar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDibayar.Enabled = False
        Me.txtDibayar.Location = New System.Drawing.Point(506, 55)
        Me.txtDibayar.Name = "txtDibayar"
        Me.txtDibayar.Size = New System.Drawing.Size(157, 20)
        Me.txtDibayar.TabIndex = 147
        '
        'txtSisa
        '
        '
        '
        '
        Me.txtSisa.Border.Class = "TextBoxBorder"
        Me.txtSisa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSisa.Enabled = False
        Me.txtSisa.Location = New System.Drawing.Point(506, 85)
        Me.txtSisa.Name = "txtSisa"
        Me.txtSisa.Size = New System.Drawing.Size(157, 20)
        Me.txtSisa.TabIndex = 148
        '
        'LabelX17
        '
        '
        '
        '
        Me.LabelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX17.ForeColor = System.Drawing.Color.Green
        Me.LabelX17.Location = New System.Drawing.Point(552, 189)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.Size = New System.Drawing.Size(67, 23)
        Me.LabelX17.TabIndex = 149
        Me.LabelX17.Text = "*Lunas"
        '
        'LabelX18
        '
        '
        '
        '
        Me.LabelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelX18.Location = New System.Drawing.Point(594, 189)
        Me.LabelX18.Name = "LabelX18"
        Me.LabelX18.Size = New System.Drawing.Size(67, 23)
        Me.LabelX18.TabIndex = 150
        Me.LabelX18.Text = "*Pembayaran"
        '
        'dgvData2
        '
        Me.dgvData2.AllowUserToAddRows = False
        Me.dgvData2.AllowUserToDeleteRows = False
        Me.dgvData2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column25, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column16})
        Me.dgvData2.Location = New System.Drawing.Point(686, 7)
        Me.dgvData2.Name = "dgvData2"
        Me.dgvData2.ReadOnly = True
        Me.dgvData2.RowHeadersVisible = False
        Me.dgvData2.Size = New System.Drawing.Size(786, 150)
        Me.dgvData2.TabIndex = 151
        Me.dgvData2.Visible = False
        '
        'Column25
        '
        Me.Column25.HeaderText = "ID"
        Me.Column25.Name = "Column25"
        Me.Column25.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.HeaderText = "KodePembayaranBpt"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Column13
        '
        Me.Column13.HeaderText = "NoPembayaran"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        '
        'Column14
        '
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Column14.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column14.HeaderText = "Tgl"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        '
        'Column15
        '
        Me.Column15.HeaderText = "Jumlah"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        '
        'Column16
        '
        Me.Column16.HeaderText = "KodeParam"
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        '
        'dgvData3
        '
        Me.dgvData3.AllowUserToAddRows = False
        Me.dgvData3.AllowUserToDeleteRows = False
        Me.dgvData3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column26, Me.Column17, Me.Column18, Me.Column19, Me.Column20, Me.Column21, Me.Column22, Me.Column23, Me.Column24})
        Me.dgvData3.Location = New System.Drawing.Point(686, 172)
        Me.dgvData3.Name = "dgvData3"
        Me.dgvData3.ReadOnly = True
        Me.dgvData3.RowHeadersVisible = False
        Me.dgvData3.Size = New System.Drawing.Size(786, 150)
        Me.dgvData3.TabIndex = 152
        Me.dgvData3.Visible = False
        '
        'Column26
        '
        Me.Column26.HeaderText = "ID"
        Me.Column26.Name = "Column26"
        Me.Column26.ReadOnly = True
        '
        'Column17
        '
        Me.Column17.HeaderText = "KodePembayaranBpt"
        Me.Column17.Name = "Column17"
        Me.Column17.ReadOnly = True
        '
        'Column18
        '
        Me.Column18.HeaderText = "KodePembayaran"
        Me.Column18.Name = "Column18"
        Me.Column18.ReadOnly = True
        '
        'Column19
        '
        Me.Column19.HeaderText = "NoTicket"
        Me.Column19.Name = "Column19"
        Me.Column19.ReadOnly = True
        '
        'Column20
        '
        DataGridViewCellStyle5.Format = "d"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Column20.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column20.HeaderText = "Tgl"
        Me.Column20.Name = "Column20"
        Me.Column20.ReadOnly = True
        '
        'Column21
        '
        Me.Column21.HeaderText = "Jumlah"
        Me.Column21.Name = "Column21"
        Me.Column21.ReadOnly = True
        '
        'Column22
        '
        Me.Column22.HeaderText = "Dibayar"
        Me.Column22.Name = "Column22"
        Me.Column22.ReadOnly = True
        '
        'Column23
        '
        Me.Column23.HeaderText = "Sisa"
        Me.Column23.Name = "Column23"
        Me.Column23.ReadOnly = True
        '
        'Column24
        '
        Me.Column24.HeaderText = "KodeParam"
        Me.Column24.Name = "Column24"
        Me.Column24.ReadOnly = True
        '
        'txtKodeParam
        '
        Me.txtKodeParam.Location = New System.Drawing.Point(343, 109)
        Me.txtKodeParam.Name = "txtKodeParam"
        Me.txtKodeParam.Size = New System.Drawing.Size(24, 20)
        Me.txtKodeParam.TabIndex = 153
        Me.txtKodeParam.Visible = False
        '
        'txtPPH
        '
        '
        '
        '
        Me.txtPPH.Border.Class = "TextBoxBorder"
        Me.txtPPH.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPPH.Enabled = False
        Me.txtPPH.Location = New System.Drawing.Point(506, 111)
        Me.txtPPH.Name = "txtPPH"
        Me.txtPPH.Size = New System.Drawing.Size(128, 20)
        Me.txtPPH.TabIndex = 156
        Me.txtPPH.Text = "0"
        '
        'LabelX19
        '
        '
        '
        '
        Me.LabelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX19.Location = New System.Drawing.Point(490, 108)
        Me.LabelX19.Name = "LabelX19"
        Me.LabelX19.Size = New System.Drawing.Size(10, 23)
        Me.LabelX19.TabIndex = 155
        Me.LabelX19.Text = ":"
        '
        'LabelX20
        '
        '
        '
        '
        Me.LabelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX20.Location = New System.Drawing.Point(373, 107)
        Me.LabelX20.Name = "LabelX20"
        Me.LabelX20.Size = New System.Drawing.Size(86, 23)
        Me.LabelX20.TabIndex = 154
        Me.LabelX20.Text = "PPH"
        '
        'txtSPSI
        '
        '
        '
        '
        Me.txtSPSI.Border.Class = "TextBoxBorder"
        Me.txtSPSI.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSPSI.Enabled = False
        Me.txtSPSI.Location = New System.Drawing.Point(506, 137)
        Me.txtSPSI.Name = "txtSPSI"
        Me.txtSPSI.Size = New System.Drawing.Size(128, 20)
        Me.txtSPSI.TabIndex = 159
        Me.txtSPSI.Text = "0"
        '
        'LabelX21
        '
        '
        '
        '
        Me.LabelX21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX21.Location = New System.Drawing.Point(490, 134)
        Me.LabelX21.Name = "LabelX21"
        Me.LabelX21.Size = New System.Drawing.Size(10, 23)
        Me.LabelX21.TabIndex = 158
        Me.LabelX21.Text = ":"
        '
        'LabelX22
        '
        '
        '
        '
        Me.LabelX22.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX22.Location = New System.Drawing.Point(373, 133)
        Me.LabelX22.Name = "LabelX22"
        Me.LabelX22.Size = New System.Drawing.Size(86, 23)
        Me.LabelX22.TabIndex = 157
        Me.LabelX22.Text = "SPSI"
        '
        'txtTotalLast
        '
        '
        '
        '
        Me.txtTotalLast.Border.Class = "TextBoxBorder"
        Me.txtTotalLast.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTotalLast.Enabled = False
        Me.txtTotalLast.Location = New System.Drawing.Point(505, 163)
        Me.txtTotalLast.Name = "txtTotalLast"
        Me.txtTotalLast.Size = New System.Drawing.Size(157, 20)
        Me.txtTotalLast.TabIndex = 162
        '
        'LabelX23
        '
        '
        '
        '
        Me.LabelX23.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX23.Location = New System.Drawing.Point(489, 160)
        Me.LabelX23.Name = "LabelX23"
        Me.LabelX23.Size = New System.Drawing.Size(10, 23)
        Me.LabelX23.TabIndex = 161
        Me.LabelX23.Text = ":"
        '
        'LabelX24
        '
        '
        '
        '
        Me.LabelX24.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX24.Location = New System.Drawing.Point(372, 159)
        Me.LabelX24.Name = "LabelX24"
        Me.LabelX24.Size = New System.Drawing.Size(86, 23)
        Me.LabelX24.TabIndex = 160
        Me.LabelX24.Text = "Total"
        '
        'ckPPH
        '
        '
        '
        '
        Me.ckPPH.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ckPPH.Location = New System.Drawing.Point(643, 110)
        Me.ckPPH.Name = "ckPPH"
        Me.ckPPH.Size = New System.Drawing.Size(20, 23)
        Me.ckPPH.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ckPPH.TabIndex = 163
        '
        'ckSPSI
        '
        '
        '
        '
        Me.ckSPSI.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ckSPSI.Location = New System.Drawing.Point(643, 136)
        Me.ckSPSI.Name = "ckSPSI"
        Me.ckSPSI.Size = New System.Drawing.Size(20, 23)
        Me.ckSPSI.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ckSPSI.TabIndex = 164
        '
        'frmPembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 437)
        Me.Controls.Add(Me.ckSPSI)
        Me.Controls.Add(Me.ckPPH)
        Me.Controls.Add(Me.txtTotalLast)
        Me.Controls.Add(Me.LabelX23)
        Me.Controls.Add(Me.LabelX24)
        Me.Controls.Add(Me.txtSPSI)
        Me.Controls.Add(Me.LabelX21)
        Me.Controls.Add(Me.LabelX22)
        Me.Controls.Add(Me.txtPPH)
        Me.Controls.Add(Me.LabelX19)
        Me.Controls.Add(Me.LabelX20)
        Me.Controls.Add(Me.txtKodeParam)
        Me.Controls.Add(Me.dgvData3)
        Me.Controls.Add(Me.dgvData2)
        Me.Controls.Add(Me.LabelX18)
        Me.Controls.Add(Me.LabelX17)
        Me.Controls.Add(Me.txtSisa)
        Me.Controls.Add(Me.txtDibayar)
        Me.Controls.Add(Me.LabelX15)
        Me.Controls.Add(Me.LabelX16)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.LabelX10)
        Me.Controls.Add(Me.btnPembayaranTBS)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.dgView)
        Me.Controls.Add(Me.LabelX13)
        Me.Controls.Add(Me.txtTotal2)
        Me.Controls.Add(Me.LabelX14)
        Me.Controls.Add(Me.txtNoPembayaranlama)
        Me.Controls.Add(Me.btnCari2)
        Me.Controls.Add(Me.dtTanggal)
        Me.Controls.Add(Me.LabelX11)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.LabelX12)
        Me.Controls.Add(Me.LabelX9)
        Me.Controls.Add(Me.LabelX8)
        Me.Controls.Add(Me.LabelX7)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnBaru)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNoAccount)
        Me.Controls.Add(Me.txtNoPembayaran)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPembayaran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Pembayaran TBS"
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.klikKananMenu.ResumeLayout(False)
        CType(Me.dgvData2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvData3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTotal As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dgView As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTotal2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents klikKananMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuTambah As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHapus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtNoPembayaranlama As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnCari2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dtTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtKeterangan As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnCari As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnOk As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnHapus As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEdit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnBaru As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtNama As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNoAccount As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNoPembayaran As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnPembayaranTBS As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDibayar As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtSisa As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvData2 As System.Windows.Forms.DataGridView
    Friend WithEvents dgvData3 As System.Windows.Forms.DataGridView
    Friend WithEvents Column25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtKodeParam As System.Windows.Forms.TextBox
    Friend WithEvents txtPPH As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX20 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSPSI As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX21 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX22 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTotalLast As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX23 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX24 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ckPPH As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents ckSPSI As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
