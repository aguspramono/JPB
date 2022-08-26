<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInputHargaDetail
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInputHargaDetail))
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.dtTanggalAkhir = New System.Windows.Forms.DateTimePicker()
        Me.dtTglAwal = New System.Windows.Forms.DateTimePicker()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.cboGrade = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.SuperTooltip1 = New DevComponents.DotNetBar.SuperTooltip()
        Me.dtTglGrade = New System.Windows.Forms.DateTimePicker()
        Me.btnOk = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.dgvHarga2 = New System.Windows.Forms.DataGridView()
        Me.harga2KodeKelompok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga2NoTicket = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga2NoAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga1Tgl = New DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn()
        Me.harga2Jam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga2JamHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga2Harga = New DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn()
        Me.cbHarga2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.dgvHarga2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(9, 5)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(48, 23)
        Me.LabelX1.TabIndex = 11
        Me.LabelX1.Text = "Tanggal"
        '
        'dtTanggalAkhir
        '
        Me.dtTanggalAkhir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTanggalAkhir.Location = New System.Drawing.Point(107, 36)
        Me.dtTanggalAkhir.Name = "dtTanggalAkhir"
        Me.dtTanggalAkhir.Size = New System.Drawing.Size(196, 22)
        Me.dtTanggalAkhir.TabIndex = 10
        '
        'dtTglAwal
        '
        Me.dtTglAwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTglAwal.Location = New System.Drawing.Point(107, 8)
        Me.dtTglAwal.Name = "dtTglAwal"
        Me.dtTglAwal.Size = New System.Drawing.Size(196, 22)
        Me.dtTglAwal.TabIndex = 9
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(97, 61)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(10, 23)
        Me.LabelX2.TabIndex = 80
        Me.LabelX2.Text = ":"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(9, 61)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(46, 23)
        Me.LabelX3.TabIndex = 79
        Me.LabelX3.Text = "Grade"
        '
        'cboGrade
        '
        Me.cboGrade.DisplayMember = "Text"
        Me.cboGrade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGrade.FormattingEnabled = True
        Me.cboGrade.ItemHeight = 16
        Me.cboGrade.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2})
        Me.cboGrade.Location = New System.Drawing.Point(107, 64)
        Me.cboGrade.Name = "cboGrade"
        Me.cboGrade.Size = New System.Drawing.Size(196, 22)
        Me.cboGrade.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SuperTooltip1.SetSuperTooltip(Me.cboGrade, New DevComponents.DotNetBar.SuperTooltipInfo("", "", "Grade A " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Untuk Kebun Sendiri Mesti pilih pakai harga rata2 tanggal berapa" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gra" & _
            "de B & C" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Sesuai Dengan Daftar Harga", Nothing, Nothing, DevComponents.DotNetBar.eTooltipColor.Gray, False, False, New System.Drawing.Size(0, 0)))
        Me.cboGrade.TabIndex = 78
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "A"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "B & C"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(99, 6)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(10, 23)
        Me.LabelX4.TabIndex = 81
        Me.LabelX4.Text = ":"
        '
        'dtTglGrade
        '
        Me.dtTglGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTglGrade.Location = New System.Drawing.Point(107, 90)
        Me.dtTglGrade.Name = "dtTglGrade"
        Me.dtTglGrade.Size = New System.Drawing.Size(196, 22)
        Me.dtTglGrade.TabIndex = 82
        '
        'btnOk
        '
        Me.btnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(9, 118)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 39)
        Me.btnOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnOk.TabIndex = 83
        Me.btnOk.Text = "Ok"
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(89, 118)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 39)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 84
        Me.btnCancel.Text = "Cancel"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelX5.Location = New System.Drawing.Point(9, 163)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(244, 23)
        Me.LabelX5.TabIndex = 85
        Me.LabelX5.Text = "* JPB di Edit Manual, tidak ikut terupdate lagi"
        '
        'dgvHarga2
        '
        Me.dgvHarga2.AllowUserToAddRows = False
        Me.dgvHarga2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHarga2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.harga2KodeKelompok, Me.harga2NoTicket, Me.harga2NoAccount, Me.harga1Tgl, Me.harga2Jam, Me.harga2JamHarga, Me.harga2Harga, Me.cbHarga2})
        Me.dgvHarga2.Location = New System.Drawing.Point(309, 8)
        Me.dgvHarga2.Name = "dgvHarga2"
        Me.dgvHarga2.ReadOnly = True
        Me.dgvHarga2.Size = New System.Drawing.Size(820, 166)
        Me.dgvHarga2.TabIndex = 92
        Me.dgvHarga2.Visible = False
        '
        'harga2KodeKelompok
        '
        Me.harga2KodeKelompok.HeaderText = "KodeKelompok"
        Me.harga2KodeKelompok.Name = "harga2KodeKelompok"
        Me.harga2KodeKelompok.ReadOnly = True
        '
        'harga2NoTicket
        '
        Me.harga2NoTicket.HeaderText = "NoTicket"
        Me.harga2NoTicket.Name = "harga2NoTicket"
        Me.harga2NoTicket.ReadOnly = True
        '
        'harga2NoAccount
        '
        Me.harga2NoAccount.HeaderText = "NoAccount"
        Me.harga2NoAccount.Name = "harga2NoAccount"
        Me.harga2NoAccount.ReadOnly = True
        '
        'harga1Tgl
        '
        '
        '
        '
        Me.harga1Tgl.BackgroundStyle.Class = "DataGridViewDateTimeBorder"
        Me.harga1Tgl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.harga1Tgl.DefaultCellStyle = DataGridViewCellStyle1
        Me.harga1Tgl.HeaderText = "Tgl2"
        Me.harga1Tgl.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        '
        '
        '
        Me.harga1Tgl.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.harga1Tgl.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.harga1Tgl.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        '
        '
        '
        Me.harga1Tgl.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.harga1Tgl.MonthCalendar.DisplayMonth = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.harga1Tgl.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.harga1Tgl.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.harga1Tgl.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.harga1Tgl.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.harga1Tgl.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.harga1Tgl.Name = "harga1Tgl"
        Me.harga1Tgl.ReadOnly = True
        Me.harga1Tgl.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'harga2Jam
        '
        DataGridViewCellStyle2.Format = "T"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.harga2Jam.DefaultCellStyle = DataGridViewCellStyle2
        Me.harga2Jam.HeaderText = "Jam2"
        Me.harga2Jam.Name = "harga2Jam"
        Me.harga2Jam.ReadOnly = True
        Me.harga2Jam.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'harga2JamHarga
        '
        DataGridViewCellStyle3.Format = "T"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.harga2JamHarga.DefaultCellStyle = DataGridViewCellStyle3
        Me.harga2JamHarga.HeaderText = "JamHarga"
        Me.harga2JamHarga.Name = "harga2JamHarga"
        Me.harga2JamHarga.ReadOnly = True
        Me.harga2JamHarga.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'harga2Harga
        '
        '
        '
        '
        Me.harga2Harga.BackgroundStyle.Class = "DataGridViewNumericBorder"
        Me.harga2Harga.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        DataGridViewCellStyle4.NullValue = Nothing
        Me.harga2Harga.DefaultCellStyle = DataGridViewCellStyle4
        Me.harga2Harga.HeaderText = "Harga"
        Me.harga2Harga.Increment = 1.0R
        Me.harga2Harga.Name = "harga2Harga"
        Me.harga2Harga.ReadOnly = True
        Me.harga2Harga.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'cbHarga2
        '
        Me.cbHarga2.HeaderText = "Pilih"
        Me.cbHarga2.Name = "cbHarga2"
        Me.cbHarga2.ReadOnly = True
        '
        'frmInputHargaDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 184)
        Me.Controls.Add(Me.dgvHarga2)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.dtTglAwal)
        Me.Controls.Add(Me.dtTanggalAkhir)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.cboGrade)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.dtTglGrade)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX4)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInputHargaDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Harga"
        CType(Me.dgvHarga2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtTanggalAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtTglAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboGrade As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents SuperTooltip1 As DevComponents.DotNetBar.SuperTooltip
    Friend WithEvents dtTglGrade As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnOk As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgvHarga2 As System.Windows.Forms.DataGridView
    Friend WithEvents harga2KodeKelompok As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents harga2NoTicket As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents harga2NoAccount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents harga1Tgl As DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
    Friend WithEvents harga2Jam As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents harga2JamHarga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents harga2Harga As DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn
    Friend WithEvents cbHarga2 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
