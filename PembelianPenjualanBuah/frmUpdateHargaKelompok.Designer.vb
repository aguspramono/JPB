<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateHargaKelompok
    Inherits DevComponents.DotNetBar.Office2007Form
    'Inherits System.Windows.Forms.Form

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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdateHargaKelompok))
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.dgvKelompok = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.kdKelompok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CkPilih = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnUpdateHarga = New DevComponents.DotNetBar.ButtonX()
        Me.dtpHelp2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpJam = New System.Windows.Forms.DateTimePicker()
        Me.dtpHelp3 = New System.Windows.Forms.DateTimePicker()
        Me.dgvHarga = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.kodeKelompok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jam = New DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.perubahan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kodeKota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.autoup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCari = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnCari = New DevComponents.DotNetBar.ButtonX()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ckPilihSemua = New System.Windows.Forms.CheckBox()
        Me.MyLabel2 = New PembelianPenjualanBuah.MyLabel()
        Me.MyLabel1 = New PembelianPenjualanBuah.MyLabel()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.dgvKelompok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvHarga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.dgvKelompok)
        Me.GroupPanel1.Location = New System.Drawing.Point(2, 75)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(448, 303)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 0
        Me.GroupPanel1.Text = "Pilih Karyawan"
        '
        'dgvKelompok
        '
        Me.dgvKelompok.AllowUserToAddRows = False
        Me.dgvKelompok.AllowUserToDeleteRows = False
        Me.dgvKelompok.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvKelompok.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvKelompok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKelompok.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kdKelompok, Me.CkPilih})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvKelompok.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvKelompok.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvKelompok.EnableHeadersVisualStyles = False
        Me.dgvKelompok.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvKelompok.Location = New System.Drawing.Point(0, 0)
        Me.dgvKelompok.Name = "dgvKelompok"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvKelompok.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvKelompok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvKelompok.Size = New System.Drawing.Size(442, 282)
        Me.dgvKelompok.TabIndex = 0
        '
        'kdKelompok
        '
        Me.kdKelompok.HeaderText = "Kode Kelompok"
        Me.kdKelompok.Name = "kdKelompok"
        Me.kdKelompok.Width = 280
        '
        'CkPilih
        '
        Me.CkPilih.HeaderText = "Pilih"
        Me.CkPilih.Name = "CkPilih"
        Me.CkPilih.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CkPilih.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'btnUpdateHarga
        '
        Me.btnUpdateHarga.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnUpdateHarga.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnUpdateHarga.Location = New System.Drawing.Point(8, 427)
        Me.btnUpdateHarga.Name = "btnUpdateHarga"
        Me.btnUpdateHarga.Size = New System.Drawing.Size(438, 43)
        Me.btnUpdateHarga.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnUpdateHarga.TabIndex = 1
        Me.btnUpdateHarga.Text = "Update Harga"
        '
        'dtpHelp2
        '
        Me.dtpHelp2.Location = New System.Drawing.Point(8, 402)
        Me.dtpHelp2.Name = "dtpHelp2"
        Me.dtpHelp2.Size = New System.Drawing.Size(207, 20)
        Me.dtpHelp2.TabIndex = 2
        '
        'dtpJam
        '
        Me.dtpJam.CustomFormat = "HH:mm:ss"
        Me.dtpJam.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpJam.Location = New System.Drawing.Point(221, 402)
        Me.dtpJam.Name = "dtpJam"
        Me.dtpJam.ShowUpDown = True
        Me.dtpJam.Size = New System.Drawing.Size(228, 20)
        Me.dtpJam.TabIndex = 3
        Me.dtpJam.Value = New Date(2019, 7, 22, 0, 0, 0, 0)
        '
        'dtpHelp3
        '
        Me.dtpHelp3.Location = New System.Drawing.Point(276, 10)
        Me.dtpHelp3.Name = "dtpHelp3"
        Me.dtpHelp3.Size = New System.Drawing.Size(163, 20)
        Me.dtpHelp3.TabIndex = 4
        Me.dtpHelp3.Visible = False
        '
        'dgvHarga
        '
        Me.dgvHarga.AllowUserToAddRows = False
        Me.dgvHarga.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHarga.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvHarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHarga.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodeKelompok, Me.tgl, Me.jam, Me.harga, Me.Column1, Me.perubahan, Me.kodeKota, Me.autoup})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvHarga.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvHarga.EnableHeadersVisualStyles = False
        Me.dgvHarga.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvHarga.Location = New System.Drawing.Point(456, 8)
        Me.dgvHarga.Name = "dgvHarga"
        Me.dgvHarga.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHarga.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvHarga.RowHeadersVisible = False
        Me.dgvHarga.Size = New System.Drawing.Size(939, 460)
        Me.dgvHarga.TabIndex = 5
        Me.dgvHarga.Visible = False
        '
        'kodeKelompok
        '
        Me.kodeKelompok.HeaderText = "Kode Kelompok"
        Me.kodeKelompok.Name = "kodeKelompok"
        Me.kodeKelompok.ReadOnly = True
        '
        'tgl
        '
        DataGridViewCellStyle5.Format = "d"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.tgl.DefaultCellStyle = DataGridViewCellStyle5
        Me.tgl.HeaderText = "Tgl"
        Me.tgl.Name = "tgl"
        Me.tgl.ReadOnly = True
        '
        'jam
        '
        '
        '
        '
        Me.jam.BackgroundStyle.Class = "DataGridViewDateTimeBorder"
        Me.jam.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        DataGridViewCellStyle6.Format = "T"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.jam.DefaultCellStyle = DataGridViewCellStyle6
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
        Me.jam.MonthCalendar.DisplayMonth = New Date(2021, 3, 1, 0, 0, 0, 0)
        Me.jam.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.jam.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.jam.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.jam.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.jam.Name = "jam"
        Me.jam.ReadOnly = True
        Me.jam.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'harga
        '
        Me.harga.HeaderText = "Harga"
        Me.harga.Name = "harga"
        Me.harga.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Plat"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'perubahan
        '
        Me.perubahan.HeaderText = "Perubahan"
        Me.perubahan.Name = "perubahan"
        Me.perubahan.ReadOnly = True
        '
        'kodeKota
        '
        Me.kodeKota.HeaderText = "Kode Kota"
        Me.kodeKota.Name = "kodeKota"
        Me.kodeKota.ReadOnly = True
        '
        'autoup
        '
        Me.autoup.HeaderText = "Auto Up"
        Me.autoup.Name = "autoup"
        Me.autoup.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCari)
        Me.GroupBox2.Controls.Add(Me.btnCari)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.dtpHelp3)
        Me.GroupBox2.Location = New System.Drawing.Point(4, -2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(445, 63)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cari"
        '
        'txtCari
        '
        '
        '
        '
        Me.txtCari.Border.Class = "TextBoxBorder"
        Me.txtCari.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCari.Location = New System.Drawing.Point(10, 35)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(336, 20)
        Me.txtCari.TabIndex = 3
        '
        'btnCari
        '
        Me.btnCari.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCari.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCari.Location = New System.Drawing.Point(352, 34)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(87, 23)
        Me.btnCari.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCari.TabIndex = 2
        Me.btnCari.Text = "Load Data"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Kode Kelompok"
        '
        'ckPilihSemua
        '
        Me.ckPilihSemua.AutoSize = True
        Me.ckPilihSemua.Location = New System.Drawing.Point(365, 64)
        Me.ckPilihSemua.Name = "ckPilihSemua"
        Me.ckPilihSemua.Size = New System.Drawing.Size(81, 17)
        Me.ckPilihSemua.TabIndex = 11
        Me.ckPilihSemua.Text = "Pilih Semua"
        Me.ckPilihSemua.UseVisualStyleBackColor = True
        '
        'MyLabel2
        '
        Me.MyLabel2.AutoSize = True
        Me.MyLabel2.Height2 = 0
        Me.MyLabel2.IndexButton = 0
        Me.MyLabel2.IndexKebun = 0
        Me.MyLabel2.IndexKebunS = ""
        Me.MyLabel2.Location = New System.Drawing.Point(5, 386)
        Me.MyLabel2.Name = "MyLabel2"
        Me.MyLabel2.NumberOfSides = 0
        Me.MyLabel2.OffsetAngleInDegrees = 0.0R
        Me.MyLabel2.Size = New System.Drawing.Size(52, 13)
        Me.MyLabel2.TabIndex = 7
        Me.MyLabel2.Text = "Tanggal :"
        Me.MyLabel2.Width2 = 0
        '
        'MyLabel1
        '
        Me.MyLabel1.AutoSize = True
        Me.MyLabel1.Height2 = 0
        Me.MyLabel1.IndexButton = 0
        Me.MyLabel1.IndexKebun = 0
        Me.MyLabel1.IndexKebunS = ""
        Me.MyLabel1.Location = New System.Drawing.Point(218, 386)
        Me.MyLabel1.Name = "MyLabel1"
        Me.MyLabel1.NumberOfSides = 0
        Me.MyLabel1.OffsetAngleInDegrees = 0.0R
        Me.MyLabel1.Size = New System.Drawing.Size(32, 13)
        Me.MyLabel1.TabIndex = 6
        Me.MyLabel1.Text = "Jam :"
        Me.MyLabel1.Width2 = 0
        '
        'frmUpdateHargaKelompok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 477)
        Me.Controls.Add(Me.ckPilihSemua)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MyLabel2)
        Me.Controls.Add(Me.MyLabel1)
        Me.Controls.Add(Me.dgvHarga)
        Me.Controls.Add(Me.dtpJam)
        Me.Controls.Add(Me.dtpHelp2)
        Me.Controls.Add(Me.btnUpdateHarga)
        Me.Controls.Add(Me.GroupPanel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUpdateHargaKelompok"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.dgvKelompok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvHarga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents dgvKelompok As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btnUpdateHarga As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dtpHelp2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpJam As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHelp3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvHarga As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents MyLabel1 As PembelianPenjualanBuah.MyLabel
    Friend WithEvents MyLabel2 As PembelianPenjualanBuah.MyLabel
    Friend WithEvents kdKelompok As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CkPilih As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCari As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnCari As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ckPilihSemua As System.Windows.Forms.CheckBox
    Friend WithEvents kodeKelompok As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tgl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jam As DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
    Friend WithEvents harga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents perubahan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kodeKota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents autoup As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
