<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaporanPembayaran
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLaporanPembayaran))
        Me.dgView = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.CKpilih = New DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn()
        Me.Column6 = New DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn()
        Me.NoTicket = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblJumlahNetto = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTotal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblsemua = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel8 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel9 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.cmbGross = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.cmbPilihanSpesial = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem9 = New DevComponents.Editors.ComboItem()
        Me.ComboItem10 = New DevComponents.Editors.ComboItem()
        Me.ComboItem11 = New DevComponents.Editors.ComboItem()
        Me.ckSpesial = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.ckkNoPPH = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.ckPengecualianHarga = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.ckAtasan = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkPilihSemua = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.btnPrint = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.cboCari = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.txtCari = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnLoad = New DevComponents.DotNetBar.ButtonX()
        Me.dtTanggalAkhir = New System.Windows.Forms.DateTimePicker()
        Me.dtTglAwal = New System.Windows.Forms.DateTimePicker()
        Me.mnuKlikKanan = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuPulihkan = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem8 = New DevComponents.Editors.ComboItem()
        Me.ComboItem12 = New DevComponents.Editors.ComboItem()
        Me.ComboItem13 = New DevComponents.Editors.ComboItem()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        Me.mnuKlikKanan.SuspendLayout()
        Me.SuspendLayout()
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
        Me.dgView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CKpilih, Me.Column6, Me.NoTicket, Me.Column2, Me.NoAccount, Me.Column1, Me.Column3, Me.Column11, Me.Column13, Me.Column14, Me.Column4, Me.Column5, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column12})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(110, Byte), Integer))
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
        Me.dgView.Size = New System.Drawing.Size(1000, 406)
        Me.dgView.TabIndex = 2
        '
        'CKpilih
        '
        Me.CKpilih.Checked = True
        Me.CKpilih.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.CKpilih.CheckValue = "N"
        Me.CKpilih.HeaderText = ""
        Me.CKpilih.Name = "CKpilih"
        Me.CKpilih.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CKpilih.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CKpilih.Width = 20
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
        '
        '
        '
        Me.Column6.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Column6.Name = "Column6"
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.Width = 65
        '
        'NoTicket
        '
        Me.NoTicket.HeaderText = "NoTicket"
        Me.NoTicket.Name = "NoTicket"
        Me.NoTicket.Width = 70
        '
        'Column2
        '
        Me.Column2.HeaderText = "No. Polisi"
        Me.Column2.Name = "Column2"
        '
        'NoAccount
        '
        Me.NoAccount.HeaderText = "NoAccount"
        Me.NoAccount.Name = "NoAccount"
        Me.NoAccount.Width = 70
        '
        'Column1
        '
        Me.Column1.HeaderText = "Product"
        Me.Column1.Name = "Column1"
        '
        'Column3
        '
        Me.Column3.HeaderText = "DO"
        Me.Column3.Name = "Column3"
        '
        'Column11
        '
        Me.Column11.HeaderText = "1st WT"
        Me.Column11.Name = "Column11"
        '
        'Column13
        '
        Me.Column13.HeaderText = "2nd WT"
        Me.Column13.Name = "Column13"
        '
        'Column14
        '
        Me.Column14.HeaderText = "Adj"
        Me.Column14.Name = "Column14"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Netto"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 50
        '
        'Column5
        '
        Me.Column5.HeaderText = "JJG"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 40
        '
        'Column7
        '
        Me.Column7.HeaderText = "BJR"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 40
        '
        'Column8
        '
        Me.Column8.HeaderText = "Harga"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 70
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
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.dgView)
        Me.PanelEx2.Controls.Add(Me.StatusStrip1)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx2.Location = New System.Drawing.Point(0, 94)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(1000, 428)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 3
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblJumlahNetto, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.lblTotal, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5, Me.lblsemua, Me.ToolStripStatusLabel6, Me.ToolStripStatusLabel7, Me.ToolStripStatusLabel8, Me.ToolStripStatusLabel9})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 406)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1000, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(84, 17)
        Me.ToolStripStatusLabel1.Text = "Jumlah Netto :"
        '
        'lblJumlahNetto
        '
        Me.lblJumlahNetto.Name = "lblJumlahNetto"
        Me.lblJumlahNetto.Size = New System.Drawing.Size(13, 17)
        Me.lblJumlahNetto.Text = "0"
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
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(79, 17)
        Me.ToolStripStatusLabel3.Text = "Jumlah Total :"
        '
        'lblTotal
        '
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(13, 17)
        Me.lblTotal.Text = "0"
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
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(64, 17)
        Me.ToolStripStatusLabel5.Text = "Rata-rata : "
        '
        'lblsemua
        '
        Me.lblsemua.Name = "lblsemua"
        Me.lblsemua.Size = New System.Drawing.Size(13, 17)
        Me.lblsemua.Text = "0"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel6.Text = "|"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.ForeColor = System.Drawing.Color.Green
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(271, 17)
        Me.ToolStripStatusLabel7.Text = "*Warna Hijau Menunjukkan Sudah Dibuat Tagihan"
        '
        'ToolStripStatusLabel8
        '
        Me.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
        Me.ToolStripStatusLabel8.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel8.Text = "|"
        '
        'ToolStripStatusLabel9
        '
        Me.ToolStripStatusLabel9.ForeColor = System.Drawing.Color.Red
        Me.ToolStripStatusLabel9.Name = "ToolStripStatusLabel9"
        Me.ToolStripStatusLabel9.Size = New System.Drawing.Size(319, 17)
        Me.ToolStripStatusLabel9.Text = "*Warna Merah Menunjukkan Sudah Dilakukan Pembayaran"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.cmbGross)
        Me.PanelEx1.Controls.Add(Me.cmbPilihanSpesial)
        Me.PanelEx1.Controls.Add(Me.ckSpesial)
        Me.PanelEx1.Controls.Add(Me.ckkNoPPH)
        Me.PanelEx1.Controls.Add(Me.ckPengecualianHarga)
        Me.PanelEx1.Controls.Add(Me.ckAtasan)
        Me.PanelEx1.Controls.Add(Me.chkPilihSemua)
        Me.PanelEx1.Controls.Add(Me.btnPrint)
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.Controls.Add(Me.cboCari)
        Me.PanelEx1.Controls.Add(Me.txtCari)
        Me.PanelEx1.Controls.Add(Me.btnLoad)
        Me.PanelEx1.Controls.Add(Me.dtTanggalAkhir)
        Me.PanelEx1.Controls.Add(Me.dtTglAwal)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1000, 94)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 2
        '
        'cmbGross
        '
        Me.cmbGross.DisplayMember = "Text"
        Me.cmbGross.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbGross.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGross.FormattingEnabled = True
        Me.cmbGross.ItemHeight = 16
        Me.cmbGross.Items.AddRange(New Object() {Me.ComboItem3, Me.ComboItem7, Me.ComboItem6, Me.ComboItem8, Me.ComboItem12, Me.ComboItem13})
        Me.cmbGross.Location = New System.Drawing.Point(521, 34)
        Me.cmbGross.Name = "cmbGross"
        Me.cmbGross.Size = New System.Drawing.Size(189, 22)
        Me.cmbGross.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbGross.TabIndex = 22
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Semua"
        '
        'ComboItem7
        '
        Me.ComboItem7.Text = "Tanpa Customer Gross Up"
        '
        'cmbPilihanSpesial
        '
        Me.cmbPilihanSpesial.DisplayMember = "Text"
        Me.cmbPilihanSpesial.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbPilihanSpesial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPilihanSpesial.FormattingEnabled = True
        Me.cmbPilihanSpesial.ItemHeight = 16
        Me.cmbPilihanSpesial.Items.AddRange(New Object() {Me.ComboItem9, Me.ComboItem10, Me.ComboItem11})
        Me.cmbPilihanSpesial.Location = New System.Drawing.Point(416, 34)
        Me.cmbPilihanSpesial.Name = "cmbPilihanSpesial"
        Me.cmbPilihanSpesial.Size = New System.Drawing.Size(99, 22)
        Me.cmbPilihanSpesial.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbPilihanSpesial.TabIndex = 21
        '
        'ComboItem9
        '
        Me.ComboItem9.Text = "Semua"
        '
        'ComboItem10
        '
        Me.ComboItem10.Text = "Spesial"
        '
        'ComboItem11
        '
        Me.ComboItem11.Text = "Tidak Spesial"
        '
        'ckSpesial
        '
        '
        '
        '
        Me.ckSpesial.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ckSpesial.Location = New System.Drawing.Point(520, 62)
        Me.ckSpesial.Name = "ckSpesial"
        Me.ckSpesial.Size = New System.Drawing.Size(60, 23)
        Me.ckSpesial.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ckSpesial.TabIndex = 20
        Me.ckSpesial.Text = "Spesial"
        '
        'ckkNoPPH
        '
        '
        '
        '
        Me.ckkNoPPH.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ckkNoPPH.Location = New System.Drawing.Point(429, 62)
        Me.ckkNoPPH.Name = "ckkNoPPH"
        Me.ckkNoPPH.Size = New System.Drawing.Size(82, 23)
        Me.ckkNoPPH.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ckkNoPPH.TabIndex = 18
        Me.ckkNoPPH.Text = "Tanpa PPH"
        '
        'ckPengecualianHarga
        '
        '
        '
        '
        Me.ckPengecualianHarga.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ckPengecualianHarga.Location = New System.Drawing.Point(588, 62)
        Me.ckPengecualianHarga.Name = "ckPengecualianHarga"
        Me.ckPengecualianHarga.Size = New System.Drawing.Size(111, 23)
        Me.ckPengecualianHarga.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ckPengecualianHarga.TabIndex = 17
        Me.ckPengecualianHarga.Text = "Pengecualian Harga"
        Me.ckPengecualianHarga.Visible = False
        '
        'ckAtasan
        '
        '
        '
        '
        Me.ckAtasan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ckAtasan.Location = New System.Drawing.Point(306, 63)
        Me.ckAtasan.Name = "ckAtasan"
        Me.ckAtasan.Size = New System.Drawing.Size(117, 23)
        Me.ckAtasan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ckAtasan.TabIndex = 15
        Me.ckAtasan.Text = "Kecuali Grade A"
        '
        'chkPilihSemua
        '
        '
        '
        '
        Me.chkPilihSemua.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkPilihSemua.Location = New System.Drawing.Point(207, 62)
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
        Me.btnPrint.Location = New System.Drawing.Point(716, 63)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
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
        Me.LabelX2.Location = New System.Drawing.Point(207, 5)
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
        Me.cboCari.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem4, Me.ComboItem5, Me.ComboItem2})
        Me.cboCari.Location = New System.Drawing.Point(207, 34)
        Me.cboCari.Name = "cboCari"
        Me.cboCari.Size = New System.Drawing.Size(99, 22)
        Me.cboCari.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboCari.TabIndex = 7
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "No Ticket"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "No Account"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "DO"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "kode Kelompok"
        '
        'txtCari
        '
        '
        '
        '
        Me.txtCari.Border.Class = "TextBoxBorder"
        Me.txtCari.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCari.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCari.Location = New System.Drawing.Point(310, 34)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(100, 20)
        Me.txtCari.TabIndex = 6
        '
        'btnLoad
        '
        Me.btnLoad.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLoad.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnLoad.Location = New System.Drawing.Point(716, 34)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnLoad.TabIndex = 5
        Me.btnLoad.Text = "Load"
        '
        'dtTanggalAkhir
        '
        Me.dtTanggalAkhir.Location = New System.Drawing.Point(3, 62)
        Me.dtTanggalAkhir.Name = "dtTanggalAkhir"
        Me.dtTanggalAkhir.Size = New System.Drawing.Size(198, 20)
        Me.dtTanggalAkhir.TabIndex = 4
        '
        'dtTglAwal
        '
        Me.dtTglAwal.Location = New System.Drawing.Point(3, 34)
        Me.dtTglAwal.Name = "dtTglAwal"
        Me.dtTglAwal.Size = New System.Drawing.Size(198, 20)
        Me.dtTglAwal.TabIndex = 3
        '
        'mnuKlikKanan
        '
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
        'ComboItem6
        '
        Me.ComboItem6.Text = "NPWP 100/99.75"
        '
        'ComboItem8
        '
        Me.ComboItem8.Text = "NPWP 50% 100/99.875"
        '
        'ComboItem12
        '
        Me.ComboItem12.Text = "Non NPWP 100/99.5"
        '
        'ComboItem13
        '
        Me.ComboItem13.Text = "Non NPWP 50% 100/99.75"
        '
        'frmLaporanPembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 522)
        Me.Controls.Add(Me.PanelEx2)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLaporanPembayaran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Pembayaran"
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.PanelEx1.ResumeLayout(False)
        Me.mnuKlikKanan.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgView As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnPrint As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboCari As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents txtCari As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnLoad As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dtTanggalAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtTglAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkPilihSemua As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents ckAtasan As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblJumlahNetto As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTotal As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblsemua As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mnuKlikKanan As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuPulihkan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ckPengecualianHarga As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents CKpilih As DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn
    Friend WithEvents Column6 As DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
    Friend WithEvents NoTicket As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoAccount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ckkNoPPH As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents ckSpesial As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cmbPilihanSpesial As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem9 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem10 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem11 As DevComponents.Editors.ComboItem
    Friend WithEvents cmbGross As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel8 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel9 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem12 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem13 As DevComponents.Editors.ComboItem
End Class
