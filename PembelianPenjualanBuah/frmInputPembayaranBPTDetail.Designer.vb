<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInputPembayaranBPTDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInputPembayaranBPTDetail))
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtpTanggal2 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.dtpTanggal = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.txtJumlah = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtTotal = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnbatal = New DevComponents.DotNetBar.ButtonX()
        Me.btnSimpan = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.mnuKlikKanan = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuTambah = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHapus = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dtpTanggal2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTanggal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuKlikKanan.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgView)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(682, 179)
        Me.Panel1.TabIndex = 0
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
        Me.dgView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column1, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column8, Me.Column9, Me.Column10})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.dgView.Size = New System.Drawing.Size(682, 179)
        Me.dgView.TabIndex = 9
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dtpTanggal2)
        Me.Panel2.Controls.Add(Me.LabelX4)
        Me.Panel2.Controls.Add(Me.dtpTanggal)
        Me.Panel2.Controls.Add(Me.txtJumlah)
        Me.Panel2.Controls.Add(Me.txtTotal)
        Me.Panel2.Controls.Add(Me.btnbatal)
        Me.Panel2.Controls.Add(Me.btnSimpan)
        Me.Panel2.Controls.Add(Me.LabelX3)
        Me.Panel2.Controls.Add(Me.LabelX2)
        Me.Panel2.Controls.Add(Me.LabelX1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 179)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(682, 134)
        Me.Panel2.TabIndex = 1
        '
        'dtpTanggal2
        '
        '
        '
        '
        Me.dtpTanggal2.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtpTanggal2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpTanggal2.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtpTanggal2.ButtonDropDown.Visible = True
        Me.dtpTanggal2.IsPopupCalendarOpen = False
        Me.dtpTanggal2.Location = New System.Drawing.Point(318, 49)
        '
        '
        '
        Me.dtpTanggal2.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtpTanggal2.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpTanggal2.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtpTanggal2.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtpTanggal2.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtpTanggal2.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpTanggal2.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtpTanggal2.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtpTanggal2.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtpTanggal2.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtpTanggal2.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpTanggal2.MonthCalendar.DisplayMonth = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.dtpTanggal2.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtpTanggal2.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtpTanggal2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtpTanggal2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpTanggal2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtpTanggal2.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpTanggal2.MonthCalendar.TodayButtonVisible = True
        Me.dtpTanggal2.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtpTanggal2.Name = "dtpTanggal2"
        Me.dtpTanggal2.Size = New System.Drawing.Size(123, 20)
        Me.dtpTanggal2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtpTanggal2.TabIndex = 10
        Me.dtpTanggal2.Visible = False
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(204, 96)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(208, 23)
        Me.LabelX4.TabIndex = 9
        Me.LabelX4.Text = "*Klik kanan pada tabel untuk menu pilihan"
        '
        'dtpTanggal
        '
        '
        '
        '
        Me.dtpTanggal.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtpTanggal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpTanggal.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtpTanggal.ButtonDropDown.Visible = True
        Me.dtpTanggal.IsPopupCalendarOpen = False
        Me.dtpTanggal.Location = New System.Drawing.Point(72, 36)
        '
        '
        '
        Me.dtpTanggal.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtpTanggal.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpTanggal.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtpTanggal.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtpTanggal.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtpTanggal.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpTanggal.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtpTanggal.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtpTanggal.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtpTanggal.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtpTanggal.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpTanggal.MonthCalendar.DisplayMonth = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.dtpTanggal.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtpTanggal.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtpTanggal.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtpTanggal.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpTanggal.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtpTanggal.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpTanggal.MonthCalendar.TodayButtonVisible = True
        Me.dtpTanggal.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtpTanggal.TabIndex = 8
        '
        'txtJumlah
        '
        '
        '
        '
        Me.txtJumlah.Border.Class = "TextBoxBorder"
        Me.txtJumlah.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtJumlah.Enabled = False
        Me.txtJumlah.Location = New System.Drawing.Point(72, 64)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(200, 20)
        Me.txtJumlah.TabIndex = 7
        Me.txtJumlah.Text = "0"
        '
        'txtTotal
        '
        '
        '
        '
        Me.txtTotal.Border.Class = "TextBoxBorder"
        Me.txtTotal.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(72, 9)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(200, 20)
        Me.txtTotal.TabIndex = 5
        '
        'btnbatal
        '
        Me.btnbatal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnbatal.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnbatal.Location = New System.Drawing.Point(109, 92)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(89, 30)
        Me.btnbatal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnbatal.TabIndex = 4
        Me.btnbatal.Text = "Batal"
        '
        'btnSimpan
        '
        Me.btnSimpan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSimpan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSimpan.Location = New System.Drawing.Point(12, 92)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(89, 30)
        Me.btnSimpan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSimpan.TabIndex = 3
        Me.btnSimpan.Text = "Simpan"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(12, 64)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 2
        Me.LabelX3.Text = "Jumlah :"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(12, 35)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "Tanggal :"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(12, 6)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Total :"
        '
        'mnuKlikKanan
        '
        Me.mnuKlikKanan.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTambah, Me.mnuHapus})
        Me.mnuKlikKanan.Name = "mnuKlikKanan"
        Me.mnuKlikKanan.Size = New System.Drawing.Size(117, 48)
        '
        'mnuTambah
        '
        Me.mnuTambah.Name = "mnuTambah"
        Me.mnuTambah.Size = New System.Drawing.Size(116, 22)
        Me.mnuTambah.Text = "Tambah"
        '
        'mnuHapus
        '
        Me.mnuHapus.Name = "mnuHapus"
        Me.mnuHapus.Size = New System.Drawing.Size(116, 22)
        Me.mnuHapus.Text = "Hapus"
        '
        'frmInputPembayaranBPTDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 313)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInputPembayaranBPTDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Pembayaran BPT Detail"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dtpTanggal2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTanggal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuKlikKanan.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgView As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mnuKlikKanan As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuTambah As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHapus As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Private WithEvents btnSimpan As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnbatal As DevComponents.DotNetBar.ButtonX
    Private WithEvents dtpTanggal As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Private WithEvents txtJumlah As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txtTotal As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Private WithEvents dtpTanggal2 As DevComponents.Editors.DateTimeAdv.DateTimeInput
End Class
