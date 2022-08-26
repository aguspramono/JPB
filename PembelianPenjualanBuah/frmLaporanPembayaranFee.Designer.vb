<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaporanPembayaranFee
    Inherits DevComponents.DotNetBar.OfficeForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLaporanPembayaranFee))
        Me.txtCari = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnLoad = New DevComponents.DotNetBar.ButtonX()
        Me.dtTglAwal = New System.Windows.Forms.DateTimePicker()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.chkPilihSemua = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.btnPrint = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.cboCari = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.dtTanggalAkhir = New System.Windows.Forms.DateTimePicker()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.dgView = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.CkPilih = New DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn()
        Me.Column6 = New DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoTicket = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTotalNetto = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTotalHarga = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblsemua = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.dgvFee = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvKelompok = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ckAtasan = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mnuKlikKanan = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuPulihkan = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbFeeStatus = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.PanelEx2.SuspendLayout()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        CType(Me.dgvFee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvKelompok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuKlikKanan.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCari
        '
        '
        '
        '
        Me.txtCari.Border.Class = "TextBoxBorder"
        Me.txtCari.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCari.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCari.Location = New System.Drawing.Point(312, 32)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(100, 20)
        Me.txtCari.TabIndex = 6
        '
        'btnLoad
        '
        Me.btnLoad.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLoad.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnLoad.Location = New System.Drawing.Point(548, 31)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnLoad.TabIndex = 5
        Me.btnLoad.Text = "Load"
        '
        'dtTglAwal
        '
        Me.dtTglAwal.Location = New System.Drawing.Point(3, 32)
        Me.dtTglAwal.Name = "dtTglAwal"
        Me.dtTglAwal.Size = New System.Drawing.Size(198, 20)
        Me.dtTglAwal.TabIndex = 3
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "DO"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "No Account"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "No Ticket"
        '
        'chkPilihSemua
        '
        '
        '
        '
        Me.chkPilihSemua.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkPilihSemua.Location = New System.Drawing.Point(207, 61)
        Me.chkPilihSemua.Name = "chkPilihSemua"
        Me.chkPilihSemua.Size = New System.Drawing.Size(87, 23)
        Me.chkPilihSemua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chkPilihSemua.TabIndex = 13
        Me.chkPilihSemua.Text = "Pilih Semua"
        '
        'btnPrint
        '
        Me.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPrint.Location = New System.Drawing.Point(629, 31)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(89, 23)
        Me.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPrint.TabIndex = 12
        Me.btnPrint.Text = "Print"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(207, 6)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(48, 23)
        Me.LabelX2.TabIndex = 9
        Me.LabelX2.Text = "Cari"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(3, 6)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(48, 23)
        Me.LabelX1.TabIndex = 8
        Me.LabelX1.Text = "Tanggal"
        '
        'cboCari
        '
        Me.cboCari.DisplayMember = "Text"
        Me.cboCari.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCari.FormattingEnabled = True
        Me.cboCari.ItemHeight = 16
        Me.cboCari.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem4, Me.ComboItem5})
        Me.cboCari.Location = New System.Drawing.Point(207, 31)
        Me.cboCari.Name = "cboCari"
        Me.cboCari.Size = New System.Drawing.Size(99, 22)
        Me.cboCari.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboCari.TabIndex = 7
        '
        'dtTanggalAkhir
        '
        Me.dtTanggalAkhir.Location = New System.Drawing.Point(3, 62)
        Me.dtTanggalAkhir.Name = "dtTanggalAkhir"
        Me.dtTanggalAkhir.Size = New System.Drawing.Size(198, 20)
        Me.dtTanggalAkhir.TabIndex = 4
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.dgView)
        Me.PanelEx2.Controls.Add(Me.StatusStrip1)
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx2.Location = New System.Drawing.Point(0, 94)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(835, 381)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 5
        '
        'dgView
        '
        Me.dgView.AllowUserToAddRows = False
        Me.dgView.AllowUserToDeleteRows = False
        Me.dgView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CkPilih, Me.Column6, Me.Column1, Me.NoTicket, Me.NoAccount, Me.Column4, Me.Column8, Me.Column9, Me.Column10, Me.Column12})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgView.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgView.EnableHeadersVisualStyles = False
        Me.dgView.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgView.HighlightSelectedColumnHeaders = False
        Me.dgView.Location = New System.Drawing.Point(0, 0)
        Me.dgView.Name = "dgView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgView.RowHeadersVisible = False
        Me.dgView.SelectAllSignVisible = False
        Me.dgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgView.Size = New System.Drawing.Size(835, 359)
        Me.dgView.TabIndex = 2
        '
        'CkPilih
        '
        Me.CkPilih.Checked = True
        Me.CkPilih.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.CkPilih.CheckValue = "N"
        Me.CkPilih.HeaderText = ""
        Me.CkPilih.Name = "CkPilih"
        Me.CkPilih.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CkPilih.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CkPilih.Width = 20
        '
        'Column6
        '
        '
        '
        '
        Me.Column6.BackgroundStyle.Class = "DataGridViewDateTimeBorder"
        Me.Column6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Column6.HeaderText = "Tanggal"
        Me.Column6.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        '
        '
        '
        Me.Column6.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.Column6.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Column6.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        '
        '
        '
        Me.Column6.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Column6.MonthCalendar.DisplayMonth = New Date(2017, 3, 1, 0, 0, 0, 0)
        Me.Column6.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.Column6.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.Column6.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.Column6.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Column6.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.Column6.Name = "Column6"
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.Width = 65
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nama"
        Me.Column1.Name = "Column1"
        '
        'NoTicket
        '
        Me.NoTicket.HeaderText = "NoTicket"
        Me.NoTicket.Name = "NoTicket"
        Me.NoTicket.Width = 70
        '
        'NoAccount
        '
        Me.NoAccount.HeaderText = "NoAccount"
        Me.NoAccount.Name = "NoAccount"
        Me.NoAccount.Width = 70
        '
        'Column4
        '
        Me.Column4.HeaderText = "Netto"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 50
        '
        'Column8
        '
        Me.Column8.HeaderText = "Fee"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 50
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
        Me.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column9.Width = 70
        '
        'Column10
        '
        Me.Column10.HeaderText = "Print"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 40
        '
        'Column12
        '
        Me.Column12.HeaderText = "User"
        Me.Column12.Name = "Column12"
        Me.Column12.Width = 50
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblTotalNetto, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.lblTotalHarga, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5, Me.lblsemua})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 359)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(835, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(76, 17)
        Me.ToolStripStatusLabel1.Text = "Total Netto : "
        '
        'lblTotalNetto
        '
        Me.lblTotalNetto.Name = "lblTotalNetto"
        Me.lblTotalNetto.Size = New System.Drawing.Size(13, 17)
        Me.lblTotalNetto.Text = "0"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel2.Text = "|"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(75, 17)
        Me.ToolStripStatusLabel3.Text = "Total Harga :"
        '
        'lblTotalHarga
        '
        Me.lblTotalHarga.Name = "lblTotalHarga"
        Me.lblTotalHarga.Size = New System.Drawing.Size(13, 17)
        Me.lblTotalHarga.Text = "0"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel4.Text = "|"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(61, 17)
        Me.ToolStripStatusLabel5.Text = "Rata-rata :"
        '
        'lblsemua
        '
        Me.lblsemua.Name = "lblsemua"
        Me.lblsemua.Size = New System.Drawing.Size(13, 17)
        Me.lblsemua.Text = "0"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.cbFeeStatus)
        Me.PanelEx1.Controls.Add(Me.dgvFee)
        Me.PanelEx1.Controls.Add(Me.dgvKelompok)
        Me.PanelEx1.Controls.Add(Me.ckAtasan)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.chkPilihSemua)
        Me.PanelEx1.Controls.Add(Me.btnPrint)
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.Controls.Add(Me.cboCari)
        Me.PanelEx1.Controls.Add(Me.txtCari)
        Me.PanelEx1.Controls.Add(Me.btnLoad)
        Me.PanelEx1.Controls.Add(Me.dtTanggalAkhir)
        Me.PanelEx1.Controls.Add(Me.dtTglAwal)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(835, 94)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 4
        '
        'dgvFee
        '
        Me.dgvFee.AllowUserToAddRows = False
        Me.dgvFee.AllowUserToDeleteRows = False
        Me.dgvFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column5})
        Me.dgvFee.Location = New System.Drawing.Point(916, 5)
        Me.dgvFee.Name = "dgvFee"
        Me.dgvFee.ReadOnly = True
        Me.dgvFee.Size = New System.Drawing.Size(244, 53)
        Me.dgvFee.TabIndex = 18
        Me.dgvFee.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "KodeKelompok"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Fee"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'dgvKelompok
        '
        Me.dgvKelompok.AllowUserToAddRows = False
        Me.dgvKelompok.AllowUserToDeleteRows = False
        Me.dgvKelompok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKelompok.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2})
        Me.dgvKelompok.Location = New System.Drawing.Point(750, 5)
        Me.dgvKelompok.Name = "dgvKelompok"
        Me.dgvKelompok.ReadOnly = True
        Me.dgvKelompok.Size = New System.Drawing.Size(160, 53)
        Me.dgvKelompok.TabIndex = 17
        Me.dgvKelompok.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "KodeKelompok"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'ckAtasan
        '
        '
        '
        '
        Me.ckAtasan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ckAtasan.Location = New System.Drawing.Point(301, 62)
        Me.ckAtasan.Name = "ckAtasan"
        Me.ckAtasan.Size = New System.Drawing.Size(111, 23)
        Me.ckAtasan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ckAtasan.TabIndex = 16
        Me.ckAtasan.Text = "Kecuali Grade A"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(418, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "*Warna Hijau Menunjukkan Sudah Dibuat Tagihan"
        '
        'mnuKlikKanan
        '
        Me.mnuKlikKanan.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuKlikKanan.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPulihkan})
        Me.mnuKlikKanan.Name = "mnuKlikKanan"
        Me.mnuKlikKanan.Size = New System.Drawing.Size(121, 26)
        '
        'mnuPulihkan
        '
        Me.mnuPulihkan.Name = "mnuPulihkan"
        Me.mnuPulihkan.Size = New System.Drawing.Size(120, 22)
        Me.mnuPulihkan.Text = "Pulihkan"
        '
        'cbFeeStatus
        '
        Me.cbFeeStatus.DisplayMember = "Text"
        Me.cbFeeStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbFeeStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFeeStatus.FormattingEnabled = True
        Me.cbFeeStatus.ItemHeight = 14
        Me.cbFeeStatus.Items.AddRange(New Object() {Me.ComboItem2, Me.ComboItem3, Me.ComboItem6})
        Me.cbFeeStatus.Location = New System.Drawing.Point(418, 32)
        Me.cbFeeStatus.Name = "cbFeeStatus"
        Me.cbFeeStatus.Size = New System.Drawing.Size(121, 20)
        Me.cbFeeStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbFeeStatus.TabIndex = 19
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Fee Aktif"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Fee Tidak Aktif"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "Semua Fee"
        '
        'frmLaporanPembayaranFee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 475)
        Me.Controls.Add(Me.PanelEx2)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLaporanPembayaranFee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Pembayaran Fee"
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.dgvFee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvKelompok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuKlikKanan.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtCari As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnLoad As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dtTglAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents chkPilihSemua As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents btnPrint As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboCari As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents dtTanggalAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents dgView As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ckAtasan As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents dgvKelompok As System.Windows.Forms.DataGridView
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvFee As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTotalNetto As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTotalHarga As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblsemua As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mnuKlikKanan As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuPulihkan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CkPilih As DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn
    Friend WithEvents Column6 As DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoTicket As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoAccount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbFeeStatus As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
End Class
