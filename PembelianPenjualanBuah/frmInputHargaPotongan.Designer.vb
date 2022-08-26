<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInputHargaPotongan
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInputHargaPotongan))
        Me.dgView = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Manual = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.klikKanan = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.KembaliKeHargaJPBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSingleEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMultipleEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.btnAtmp = New DevComponents.DotNetBar.ButtonX()
        Me.btnPJML = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.btnPotongan = New DevComponents.DotNetBar.ButtonX()
        Me.cboOrder = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem8 = New DevComponents.Editors.ComboItem()
        Me.ComboItem9 = New DevComponents.Editors.ComboItem()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.cboCari = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.txtCari = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnLoad = New DevComponents.DotNetBar.ButtonX()
        Me.dtTanggalAkhir = New System.Windows.Forms.DateTimePicker()
        Me.dtTglAwal = New System.Windows.Forms.DateTimePicker()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTotalJanjang = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblJumlahTotal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblJumlahNetto = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.klikKanan.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgView
        '
        Me.dgView.AllowUserToAddRows = False
        Me.dgView.AllowUserToDeleteRows = False
        Me.dgView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column6, Me.Column14, Me.Column2, Me.Column4, Me.Column18, Me.Column5, Me.Column3, Me.Column10, Me.Column11, Me.Column13, Me.Column9, Me.Column15, Me.Column12, Me.Column8, Me.Column19, Me.Column17, Me.Column7, Me.Column16, Me.Manual})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgView.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgView.EnableHeadersVisualStyles = False
        Me.dgView.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgView.HighlightSelectedColumnHeaders = False
        Me.dgView.Location = New System.Drawing.Point(0, 0)
        Me.dgView.Name = "dgView"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgView.RowHeadersVisible = False
        Me.dgView.SelectAllSignVisible = False
        Me.dgView.Size = New System.Drawing.Size(1105, 424)
        Me.dgView.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "NoTicket"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 70
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
        'Column14
        '
        DataGridViewCellStyle2.Format = "T"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column14.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column14.HeaderText = "Jam"
        Me.Column14.Name = "Column14"
        Me.Column14.Width = 55
        '
        'Column2
        '
        Me.Column2.HeaderText = "Vech"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 60
        '
        'Column4
        '
        Me.Column4.HeaderText = "NoAccount"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 70
        '
        'Column18
        '
        Me.Column18.HeaderText = "Kode Kelompok"
        Me.Column18.Name = "Column18"
        Me.Column18.Width = 65
        '
        'Column5
        '
        Me.Column5.HeaderText = "DO"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 55
        '
        'Column3
        '
        Me.Column3.HeaderText = "Product"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 80
        '
        'Column10
        '
        Me.Column10.HeaderText = "WG1"
        Me.Column10.Name = "Column10"
        Me.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column10.Width = 50
        '
        'Column11
        '
        Me.Column11.HeaderText = "WG2"
        Me.Column11.Name = "Column11"
        Me.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column11.Width = 50
        '
        'Column13
        '
        Me.Column13.HeaderText = "ADJ"
        Me.Column13.Name = "Column13"
        Me.Column13.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column13.Width = 45
        '
        'Column9
        '
        Me.Column9.HeaderText = "Jlh JJG"
        Me.Column9.Name = "Column9"
        Me.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column9.Width = 50
        '
        'Column15
        '
        Me.Column15.HeaderText = "BJR"
        Me.Column15.Name = "Column15"
        Me.Column15.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column15.Width = 50
        '
        'Column12
        '
        Me.Column12.HeaderText = "Net"
        Me.Column12.Name = "Column12"
        Me.Column12.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column12.Width = 50
        '
        'Column8
        '
        '
        '
        '
        Me.Column8.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.Column8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Column8.HeaderText = "Harga"
        Me.Column8.Increment = 1.0R
        Me.Column8.Name = "Column8"
        Me.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column8.Width = 70
        '
        'Column19
        '
        Me.Column19.HeaderText = "Potongan"
        Me.Column19.Name = "Column19"
        '
        'Column17
        '
        '
        '
        '
        Me.Column17.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.Column17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Column17.HeaderText = "Total"
        Me.Column17.Increment = 1.0R
        Me.Column17.Name = "Column17"
        Me.Column17.Width = 75
        '
        'Column7
        '
        Me.Column7.HeaderText = "KodeKota"
        Me.Column7.Name = "Column7"
        Me.Column7.Visible = False
        Me.Column7.Width = 50
        '
        'Column16
        '
        Me.Column16.HeaderText = "BeliJual"
        Me.Column16.Name = "Column16"
        Me.Column16.Visible = False
        '
        'Manual
        '
        Me.Manual.HeaderText = "M"
        Me.Manual.Name = "Manual"
        Me.Manual.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Manual.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Manual.Width = 30
        '
        'klikKanan
        '
        Me.klikKanan.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEdit, Me.KembaliKeHargaJPBToolStripMenuItem})
        Me.klikKanan.Name = "klikKanan"
        Me.klikKanan.Size = New System.Drawing.Size(189, 70)
        '
        'mnuEdit
        '
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(188, 22)
        Me.mnuEdit.Text = "Edit"
        '
        'KembaliKeHargaJPBToolStripMenuItem
        '
        Me.KembaliKeHargaJPBToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSingleEdit, Me.mnuMultipleEdit})
        Me.KembaliKeHargaJPBToolStripMenuItem.Name = "KembaliKeHargaJPBToolStripMenuItem"
        Me.KembaliKeHargaJPBToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.KembaliKeHargaJPBToolStripMenuItem.Text = "Kembali ke Harga JPB"
        '
        'mnuSingleEdit
        '
        Me.mnuSingleEdit.Name = "mnuSingleEdit"
        Me.mnuSingleEdit.Size = New System.Drawing.Size(152, 22)
        Me.mnuSingleEdit.Text = "Single Edit"
        '
        'mnuMultipleEdit
        '
        Me.mnuMultipleEdit.Name = "mnuMultipleEdit"
        Me.mnuMultipleEdit.Size = New System.Drawing.Size(152, 22)
        Me.mnuMultipleEdit.Text = "Multiple Edit"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.LabelX4)
        Me.PanelEx1.Controls.Add(Me.btnAtmp)
        Me.PanelEx1.Controls.Add(Me.btnPJML)
        Me.PanelEx1.Controls.Add(Me.ButtonX1)
        Me.PanelEx1.Controls.Add(Me.btnPotongan)
        Me.PanelEx1.Controls.Add(Me.cboOrder)
        Me.PanelEx1.Controls.Add(Me.LabelX3)
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
        Me.PanelEx1.Size = New System.Drawing.Size(1105, 36)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 2
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(170, 4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(10, 23)
        Me.LabelX4.TabIndex = 18
        Me.LabelX4.Text = "-"
        '
        'btnAtmp
        '
        Me.btnAtmp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAtmp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAtmp.Location = New System.Drawing.Point(1056, 7)
        Me.btnAtmp.Name = "btnAtmp"
        Me.btnAtmp.Size = New System.Drawing.Size(32, 23)
        Me.btnAtmp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAtmp.TabIndex = 17
        Me.btnAtmp.Text = "Update ATMP dan Sejenisnya"
        Me.btnAtmp.Visible = False
        '
        'btnPJML
        '
        Me.btnPJML.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPJML.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPJML.Location = New System.Drawing.Point(1023, 7)
        Me.btnPJML.Name = "btnPJML"
        Me.btnPJML.Size = New System.Drawing.Size(27, 23)
        Me.btnPJML.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPJML.TabIndex = 16
        Me.btnPJML.Text = "Update PJLM dan Sejenisnya"
        Me.btnPJML.Visible = False
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(1094, 7)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(35, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 15
        Me.ButtonX1.Text = "Update HUTGAUL dan Sejenisnya"
        Me.ButtonX1.Visible = False
        '
        'btnPotongan
        '
        Me.btnPotongan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPotongan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPotongan.Location = New System.Drawing.Point(808, 7)
        Me.btnPotongan.Name = "btnPotongan"
        Me.btnPotongan.Size = New System.Drawing.Size(134, 23)
        Me.btnPotongan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPotongan.TabIndex = 14
        Me.btnPotongan.Text = "Update Potongan"
        '
        'cboOrder
        '
        Me.cboOrder.DisplayMember = "Text"
        Me.cboOrder.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOrder.FormattingEnabled = True
        Me.cboOrder.ItemHeight = 16
        Me.cboOrder.Items.AddRange(New Object() {Me.ComboItem2, Me.ComboItem8, Me.ComboItem9})
        Me.cboOrder.Location = New System.Drawing.Point(621, 7)
        Me.cboOrder.Name = "cboOrder"
        Me.cboOrder.Size = New System.Drawing.Size(100, 22)
        Me.cboOrder.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboOrder.TabIndex = 11
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "No Ticket"
        '
        'ComboItem8
        '
        Me.ComboItem8.Text = "KodeKelompok"
        '
        'ComboItem9
        '
        Me.ComboItem9.Text = "NoAccount"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(567, 5)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(48, 23)
        Me.LabelX3.TabIndex = 10
        Me.LabelX3.Text = "Order By"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(324, 6)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(30, 23)
        Me.LabelX2.TabIndex = 9
        Me.LabelX2.Text = "Cari"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(3, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(23, 23)
        Me.LabelX1.TabIndex = 8
        Me.LabelX1.Text = "Tgl"
        '
        'cboCari
        '
        Me.cboCari.DisplayMember = "Text"
        Me.cboCari.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCari.FormattingEnabled = True
        Me.cboCari.ItemHeight = 16
        Me.cboCari.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem3, Me.ComboItem4, Me.ComboItem6, Me.ComboItem5, Me.ComboItem7})
        Me.cboCari.Location = New System.Drawing.Point(356, 6)
        Me.cboCari.Name = "cboCari"
        Me.cboCari.Size = New System.Drawing.Size(99, 22)
        Me.cboCari.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboCari.TabIndex = 7
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "No Ticket"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Vehicle"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "No Account"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "Kode Kelompok"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "DO"
        '
        'ComboItem7
        '
        Me.ComboItem7.Text = "Product"
        '
        'txtCari
        '
        '
        '
        '
        Me.txtCari.Border.Class = "TextBoxBorder"
        Me.txtCari.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCari.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCari.Location = New System.Drawing.Point(461, 7)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(100, 20)
        Me.txtCari.TabIndex = 6
        '
        'btnLoad
        '
        Me.btnLoad.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLoad.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnLoad.Location = New System.Drawing.Point(727, 7)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnLoad.TabIndex = 5
        Me.btnLoad.Text = "Load"
        '
        'dtTanggalAkhir
        '
        Me.dtTanggalAkhir.Location = New System.Drawing.Point(186, 6)
        Me.dtTanggalAkhir.Name = "dtTanggalAkhir"
        Me.dtTanggalAkhir.Size = New System.Drawing.Size(132, 20)
        Me.dtTanggalAkhir.TabIndex = 4
        '
        'dtTglAwal
        '
        Me.dtTglAwal.Location = New System.Drawing.Point(32, 6)
        Me.dtTglAwal.Name = "dtTglAwal"
        Me.dtTglAwal.Size = New System.Drawing.Size(133, 20)
        Me.dtTglAwal.TabIndex = 3
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.dgView)
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx2.Location = New System.Drawing.Point(0, 36)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(1105, 424)
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
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblTotalJanjang, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.lblJumlahTotal, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5, Me.lblJumlahNetto, Me.ToolStripStatusLabel6})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 460)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1105, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(86, 17)
        Me.ToolStripStatusLabel1.Text = "Total Janjang : "
        '
        'lblTotalJanjang
        '
        Me.lblTotalJanjang.Name = "lblTotalJanjang"
        Me.lblTotalJanjang.Size = New System.Drawing.Size(13, 17)
        Me.lblTotalJanjang.Text = "0"
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
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(81, 17)
        Me.ToolStripStatusLabel3.Text = "Jumlah Total :"
        '
        'lblJumlahTotal
        '
        Me.lblJumlahTotal.Name = "lblJumlahTotal"
        Me.lblJumlahTotal.Size = New System.Drawing.Size(13, 17)
        Me.lblJumlahTotal.Text = "0"
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
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(84, 17)
        Me.ToolStripStatusLabel5.Text = "Jumlah Netto :"
        '
        'lblJumlahNetto
        '
        Me.lblJumlahNetto.Name = "lblJumlahNetto"
        Me.lblJumlahNetto.Size = New System.Drawing.Size(13, 17)
        Me.lblJumlahNetto.Text = "0"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(234, 17)
        Me.ToolStripStatusLabel6.Text = "Warna kuning menunjukkan ada potongan"
        '
        'frmInputHargaPotongan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 482)
        Me.Controls.Add(Me.PanelEx2)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInputHargaPotongan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JPB Potongan"
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.klikKanan.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgView As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents klikKanan As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnPotongan As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cboOrder As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem9 As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboCari As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents txtCari As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnLoad As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dtTanggalAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtTglAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnPJML As DevComponents.DotNetBar.ButtonX
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTotalJanjang As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblJumlahTotal As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblJumlahNetto As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
    Friend WithEvents Column19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Manual As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btnAtmp As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents KembaliKeHargaJPBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSingleEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMultipleEdit As System.Windows.Forms.ToolStripMenuItem
End Class
