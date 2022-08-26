<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInputHargaCustomerAnyKelompokPlat
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInputHargaCustomerAnyKelompokPlat))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpAkhir = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpAwal = New System.Windows.Forms.DateTimePicker()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.dgvView1 = New System.Windows.Forms.DataGridView()
        Me.kodeKelompokplat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cb1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgvView3 = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kdKelompokplat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.plat2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cb2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgView = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.tanggal = New DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn()
        Me.jam = New DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn()
        Me.kdKelompok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cb10 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgvKelompok = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.kdKelompokspsi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.spsi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cb4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvKelompok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpAkhir)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpAwal)
        Me.GroupBox1.Location = New System.Drawing.Point(5, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(436, 51)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tanggal"
        '
        'dtpAkhir
        '
        Me.dtpAkhir.Location = New System.Drawing.Point(230, 21)
        Me.dtpAkhir.Name = "dtpAkhir"
        Me.dtpAkhir.Size = New System.Drawing.Size(200, 20)
        Me.dtpAkhir.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(214, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "-"
        '
        'dtpAwal
        '
        Me.dtpAwal.Location = New System.Drawing.Point(7, 21)
        Me.dtpAwal.Name = "dtpAwal"
        Me.dtpAwal.Size = New System.Drawing.Size(200, 20)
        Me.dtpAwal.TabIndex = 0
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(5, 56)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(436, 39)
        Me.btnProses.TabIndex = 3
        Me.btnProses.Text = "Proses"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'dgvView1
        '
        Me.dgvView1.AllowUserToAddRows = False
        Me.dgvView1.AllowUserToDeleteRows = False
        Me.dgvView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodeKelompokplat, Me.cb1})
        Me.dgvView1.Location = New System.Drawing.Point(6, 274)
        Me.dgvView1.Name = "dgvView1"
        Me.dgvView1.ReadOnly = True
        Me.dgvView1.Size = New System.Drawing.Size(254, 85)
        Me.dgvView1.TabIndex = 6
        '
        'kodeKelompokplat
        '
        Me.kodeKelompokplat.HeaderText = "kodeKelompok"
        Me.kodeKelompokplat.Name = "kodeKelompokplat"
        Me.kodeKelompokplat.ReadOnly = True
        '
        'cb1
        '
        Me.cb1.HeaderText = ""
        Me.cb1.Name = "cb1"
        Me.cb1.ReadOnly = True
        '
        'dgvView3
        '
        Me.dgvView3.AllowUserToAddRows = False
        Me.dgvView3.AllowUserToDeleteRows = False
        Me.dgvView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.kdKelompokplat, Me.plat2, Me.cb2})
        Me.dgvView3.Location = New System.Drawing.Point(266, 274)
        Me.dgvView3.Name = "dgvView3"
        Me.dgvView3.ReadOnly = True
        Me.dgvView3.Size = New System.Drawing.Size(199, 109)
        Me.dgvView3.TabIndex = 8
        '
        'Column2
        '
        Me.Column2.HeaderText = "id"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'kdKelompokplat
        '
        Me.kdKelompokplat.HeaderText = "kodeKelompok"
        Me.kdKelompokplat.Name = "kdKelompokplat"
        Me.kdKelompokplat.ReadOnly = True
        '
        'plat2
        '
        Me.plat2.HeaderText = "plat"
        Me.plat2.Name = "plat2"
        Me.plat2.ReadOnly = True
        '
        'cb2
        '
        Me.cb2.HeaderText = ""
        Me.cb2.Name = "cb2"
        Me.cb2.ReadOnly = True
        '
        'dgView
        '
        Me.dgView.AllowUserToAddRows = False
        Me.dgView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tanggal, Me.jam, Me.kdKelompok, Me.harga, Me.cb10})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgView.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgView.EnableHeadersVisualStyles = False
        Me.dgView.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgView.HighlightSelectedColumnHeaders = False
        Me.dgView.Location = New System.Drawing.Point(6, 120)
        Me.dgView.MultiSelect = False
        Me.dgView.Name = "dgView"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgView.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgView.RowHeadersVisible = False
        Me.dgView.SelectAllSignVisible = False
        Me.dgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgView.Size = New System.Drawing.Size(399, 148)
        Me.dgView.TabIndex = 89
        '
        'tanggal
        '
        '
        '
        '
        Me.tanggal.BackgroundStyle.Class = "DataGridViewDateTimeBorder"
        Me.tanggal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        DataGridViewCellStyle2.Format = "D"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.tanggal.DefaultCellStyle = DataGridViewCellStyle2
        Me.tanggal.HeaderText = "Tanggal"
        Me.tanggal.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        '
        '
        '
        Me.tanggal.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.tanggal.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tanggal.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        '
        '
        '
        Me.tanggal.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tanggal.MonthCalendar.DisplayMonth = New Date(2019, 10, 1, 0, 0, 0, 0)
        Me.tanggal.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.tanggal.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.tanggal.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.tanggal.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tanggal.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tanggal.Width = 150
        '
        'jam
        '
        '
        '
        '
        Me.jam.BackgroundStyle.Class = "DataGridViewDateTimeBorder"
        Me.jam.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        DataGridViewCellStyle3.Format = "T"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.jam.DefaultCellStyle = DataGridViewCellStyle3
        Me.jam.Format = DevComponents.Editors.eDateTimePickerFormat.LongTime
        Me.jam.HeaderText = "Jam"
        Me.jam.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        '
        '
        '
        Me.jam.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.jam.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.jam.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        '
        '
        '
        Me.jam.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.jam.MonthCalendar.DisplayMonth = New Date(2019, 10, 1, 0, 0, 0, 0)
        Me.jam.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.jam.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.jam.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.jam.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.jam.MonthCalendar.Visible = False
        Me.jam.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.jam.Name = "jam"
        Me.jam.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'kdKelompok
        '
        Me.kdKelompok.HeaderText = "Kode Kelompok"
        Me.kdKelompok.Name = "kdKelompok"
        Me.kdKelompok.Width = 200
        '
        'harga
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.harga.DefaultCellStyle = DataGridViewCellStyle4
        Me.harga.HeaderText = "Harga"
        Me.harga.Name = "harga"
        Me.harga.Width = 140
        '
        'cb10
        '
        Me.cb10.HeaderText = "Pilih"
        Me.cb10.Name = "cb10"
        '
        'dgvKelompok
        '
        Me.dgvKelompok.AllowUserToAddRows = False
        Me.dgvKelompok.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvKelompok.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvKelompok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKelompok.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kdKelompokspsi, Me.fee, Me.spsi, Me.cb4})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvKelompok.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvKelompok.EnableHeadersVisualStyles = False
        Me.dgvKelompok.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvKelompok.HighlightSelectedColumnHeaders = False
        Me.dgvKelompok.Location = New System.Drawing.Point(447, 6)
        Me.dgvKelompok.MultiSelect = False
        Me.dgvKelompok.Name = "dgvKelompok"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvKelompok.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvKelompok.RowHeadersVisible = False
        Me.dgvKelompok.SelectAllSignVisible = False
        Me.dgvKelompok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvKelompok.Size = New System.Drawing.Size(545, 148)
        Me.dgvKelompok.TabIndex = 91
        '
        'kdKelompokspsi
        '
        Me.kdKelompokspsi.HeaderText = "Kode Kelompok"
        Me.kdKelompokspsi.Name = "kdKelompokspsi"
        Me.kdKelompokspsi.Width = 200
        '
        'fee
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.fee.DefaultCellStyle = DataGridViewCellStyle8
        Me.fee.HeaderText = "Fee"
        Me.fee.Name = "fee"
        Me.fee.Width = 140
        '
        'spsi
        '
        Me.spsi.HeaderText = "SPSI"
        Me.spsi.Name = "spsi"
        '
        'cb4
        '
        Me.cb4.HeaderText = "Pilih"
        Me.cb4.Name = "cb4"
        '
        'frmInputHargaCustomerAnyKelompokPlat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 100)
        Me.Controls.Add(Me.dgvKelompok)
        Me.Controls.Add(Me.dgView)
        Me.Controls.Add(Me.dgvView3)
        Me.Controls.Add(Me.dgvView1)
        Me.Controls.Add(Me.btnProses)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInputHargaCustomerAnyKelompokPlat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Harga Plat"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvKelompok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents dgvView1 As System.Windows.Forms.DataGridView
    Friend WithEvents dgvView3 As System.Windows.Forms.DataGridView
    Friend WithEvents kodeKelompokplat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cb1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents dgView As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents dgvKelompok As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents kdKelompokspsi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents spsi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cb4 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kdKelompokplat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents plat2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cb2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents tanggal As DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
    Friend WithEvents jam As DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
    Friend WithEvents kdKelompok As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents harga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cb10 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
