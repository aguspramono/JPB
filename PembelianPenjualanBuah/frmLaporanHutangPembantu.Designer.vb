<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaporanHutangPembantu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLaporanHutangPembantu))
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.btnProses = New DevComponents.DotNetBar.ButtonX()
        Me.txtCustomer = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnCariCustomer = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtNoBukti = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.dtpDari = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dtpSampai = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.rdTahunan = New System.Windows.Forms.RadioButton()
        Me.rdBulanan = New System.Windows.Forms.RadioButton()
        Me.rdHarian = New System.Windows.Forms.RadioButton()
        Me.btnReset = New DevComponents.DotNetBar.ButtonX()
        Me.dgvData1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvData2 = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgTest = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtpDari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpSampai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvData1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvData2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(12, 6)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(59, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Customer"
        '
        'btnProses
        '
        Me.btnProses.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnProses.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnProses.Location = New System.Drawing.Point(12, 149)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(133, 23)
        Me.btnProses.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnProses.TabIndex = 1
        Me.btnProses.Text = "Proses"
        '
        'txtCustomer
        '
        '
        '
        '
        Me.txtCustomer.Border.Class = "TextBoxBorder"
        Me.txtCustomer.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCustomer.Enabled = False
        Me.txtCustomer.Location = New System.Drawing.Point(93, 9)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(170, 20)
        Me.txtCustomer.TabIndex = 2
        '
        'btnCariCustomer
        '
        Me.btnCariCustomer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCariCustomer.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCariCustomer.Location = New System.Drawing.Point(269, 9)
        Me.btnCariCustomer.Name = "btnCariCustomer"
        Me.btnCariCustomer.Size = New System.Drawing.Size(40, 20)
        Me.btnCariCustomer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCariCustomer.TabIndex = 3
        Me.btnCariCustomer.Text = "---"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(77, 6)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(10, 23)
        Me.LabelX2.TabIndex = 4
        Me.LabelX2.Text = ":"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(12, 35)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(59, 23)
        Me.LabelX3.TabIndex = 5
        Me.LabelX3.Text = "No Bukti"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(77, 35)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(10, 23)
        Me.LabelX4.TabIndex = 6
        Me.LabelX4.Text = ":"
        '
        'txtNoBukti
        '
        '
        '
        '
        Me.txtNoBukti.Border.Class = "TextBoxBorder"
        Me.txtNoBukti.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNoBukti.Location = New System.Drawing.Point(93, 38)
        Me.txtNoBukti.Name = "txtNoBukti"
        Me.txtNoBukti.Size = New System.Drawing.Size(216, 20)
        Me.txtNoBukti.TabIndex = 7
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(12, 64)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(59, 23)
        Me.LabelX5.TabIndex = 8
        Me.LabelX5.Text = "Tanggal"
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(77, 64)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(10, 23)
        Me.LabelX6.TabIndex = 9
        Me.LabelX6.Text = ":"
        '
        'dtpDari
        '
        '
        '
        '
        Me.dtpDari.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtpDari.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpDari.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtpDari.ButtonDropDown.Visible = True
        Me.dtpDari.IsPopupCalendarOpen = False
        Me.dtpDari.Location = New System.Drawing.Point(93, 66)
        '
        '
        '
        Me.dtpDari.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtpDari.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpDari.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtpDari.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtpDari.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtpDari.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpDari.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtpDari.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtpDari.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtpDari.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtpDari.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpDari.MonthCalendar.DisplayMonth = New Date(2020, 11, 1, 0, 0, 0, 0)
        Me.dtpDari.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.dtpDari.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtpDari.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtpDari.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtpDari.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpDari.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtpDari.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpDari.MonthCalendar.TodayButtonVisible = True
        Me.dtpDari.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtpDari.Name = "dtpDari"
        Me.dtpDari.Size = New System.Drawing.Size(216, 20)
        Me.dtpDari.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtpDari.TabIndex = 10
        '
        'dtpSampai
        '
        '
        '
        '
        Me.dtpSampai.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtpSampai.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpSampai.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtpSampai.ButtonDropDown.Visible = True
        Me.dtpSampai.IsPopupCalendarOpen = False
        Me.dtpSampai.Location = New System.Drawing.Point(111, 96)
        '
        '
        '
        Me.dtpSampai.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtpSampai.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpSampai.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtpSampai.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtpSampai.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtpSampai.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpSampai.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtpSampai.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtpSampai.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtpSampai.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtpSampai.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpSampai.MonthCalendar.DisplayMonth = New Date(2020, 11, 1, 0, 0, 0, 0)
        Me.dtpSampai.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.dtpSampai.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtpSampai.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtpSampai.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtpSampai.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpSampai.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtpSampai.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpSampai.MonthCalendar.TodayButtonVisible = True
        Me.dtpSampai.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtpSampai.Name = "dtpSampai"
        Me.dtpSampai.Size = New System.Drawing.Size(198, 20)
        Me.dtpSampai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtpSampai.TabIndex = 11
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(93, 95)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(10, 23)
        Me.LabelX7.TabIndex = 12
        Me.LabelX7.Text = "-"
        '
        'rdTahunan
        '
        Me.rdTahunan.AutoSize = True
        Me.rdTahunan.Location = New System.Drawing.Point(12, 101)
        Me.rdTahunan.Name = "rdTahunan"
        Me.rdTahunan.Size = New System.Drawing.Size(68, 17)
        Me.rdTahunan.TabIndex = 13
        Me.rdTahunan.TabStop = True
        Me.rdTahunan.Text = "Tahunan"
        Me.rdTahunan.UseVisualStyleBackColor = True
        Me.rdTahunan.Visible = False
        '
        'rdBulanan
        '
        Me.rdBulanan.AutoSize = True
        Me.rdBulanan.Location = New System.Drawing.Point(245, 122)
        Me.rdBulanan.Name = "rdBulanan"
        Me.rdBulanan.Size = New System.Drawing.Size(64, 17)
        Me.rdBulanan.TabIndex = 14
        Me.rdBulanan.TabStop = True
        Me.rdBulanan.Text = "Bulanan"
        Me.rdBulanan.UseVisualStyleBackColor = True
        '
        'rdHarian
        '
        Me.rdHarian.AutoSize = True
        Me.rdHarian.Location = New System.Drawing.Point(174, 122)
        Me.rdHarian.Name = "rdHarian"
        Me.rdHarian.Size = New System.Drawing.Size(56, 17)
        Me.rdHarian.TabIndex = 15
        Me.rdHarian.TabStop = True
        Me.rdHarian.Text = "Harian"
        Me.rdHarian.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnReset.Location = New System.Drawing.Point(151, 149)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(133, 23)
        Me.btnReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnReset.TabIndex = 16
        Me.btnReset.Text = "Reset Filter"
        '
        'dgvData1
        '
        Me.dgvData1.AllowUserToAddRows = False
        Me.dgvData1.AllowUserToDeleteRows = False
        Me.dgvData1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.dgvData1.Location = New System.Drawing.Point(347, 6)
        Me.dgvData1.Name = "dgvData1"
        Me.dgvData1.ReadOnly = True
        Me.dgvData1.Size = New System.Drawing.Size(160, 206)
        Me.dgvData1.TabIndex = 18
        Me.dgvData1.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "KodeKelompok"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'dgvData2
        '
        Me.dgvData2.AllowUserToAddRows = False
        Me.dgvData2.AllowUserToDeleteRows = False
        Me.dgvData2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3, Me.Column16, Me.Column17})
        Me.dgvData2.Location = New System.Drawing.Point(508, 6)
        Me.dgvData2.Name = "dgvData2"
        Me.dgvData2.ReadOnly = True
        Me.dgvData2.Size = New System.Drawing.Size(717, 206)
        Me.dgvData2.TabIndex = 19
        Me.dgvData2.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "KodeKelompok"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Fee"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column16
        '
        Me.Column16.HeaderText = "KodePembayaran"
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        '
        'Column17
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column17.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column17.HeaderText = "Tanggal"
        Me.Column17.Name = "Column17"
        Me.Column17.ReadOnly = True
        '
        'dgTest
        '
        Me.dgTest.AllowUserToAddRows = False
        Me.dgTest.AllowUserToDeleteRows = False
        Me.dgTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTest.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column6, Me.Column11, Me.Column19, Me.Column7, Me.Column12, Me.Column21, Me.Column8, Me.Column13, Me.Column23, Me.Column9, Me.Column14, Me.Column25, Me.Column10, Me.Column15, Me.Column27})
        Me.dgTest.Location = New System.Drawing.Point(12, 224)
        Me.dgTest.Name = "dgTest"
        Me.dgTest.ReadOnly = True
        Me.dgTest.RowHeadersVisible = False
        Me.dgTest.Size = New System.Drawing.Size(1393, 392)
        Me.dgTest.TabIndex = 20
        Me.dgTest.Visible = False
        '
        'Column5
        '
        Me.Column5.HeaderText = "NoTicket"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Fee1"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.HeaderText = "KodeFee1"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column19
        '
        Me.Column19.HeaderText = "Tgl1"
        Me.Column19.Name = "Column19"
        Me.Column19.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Fee2"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.HeaderText = "KodeFee2"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Column21
        '
        Me.Column21.HeaderText = "Tgl2"
        Me.Column21.Name = "Column21"
        Me.Column21.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Fee3"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column13
        '
        Me.Column13.HeaderText = "KodeFee3"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        '
        'Column23
        '
        Me.Column23.HeaderText = "Tgl3"
        Me.Column23.Name = "Column23"
        Me.Column23.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Fee4"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column14
        '
        Me.Column14.HeaderText = "KodeFee4"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        '
        'Column25
        '
        Me.Column25.HeaderText = "Tgl4"
        Me.Column25.Name = "Column25"
        Me.Column25.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "Fee5"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column15
        '
        Me.Column15.HeaderText = "KodeFee5"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        '
        'Column27
        '
        Me.Column27.HeaderText = "Tgl5"
        Me.Column27.Name = "Column27"
        Me.Column27.ReadOnly = True
        '
        'frmLaporanHutangPembantu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 181)
        Me.Controls.Add(Me.dgTest)
        Me.Controls.Add(Me.dgvData2)
        Me.Controls.Add(Me.dgvData1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.rdHarian)
        Me.Controls.Add(Me.rdBulanan)
        Me.Controls.Add(Me.rdTahunan)
        Me.Controls.Add(Me.LabelX7)
        Me.Controls.Add(Me.dtpSampai)
        Me.Controls.Add(Me.dtpDari)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.txtNoBukti)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.btnCariCustomer)
        Me.Controls.Add(Me.txtCustomer)
        Me.Controls.Add(Me.btnProses)
        Me.Controls.Add(Me.LabelX1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLaporanHutangPembantu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Laporan Hutang Dagang"
        CType(Me.dtpDari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpSampai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvData1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvData2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnProses As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtCustomer As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnCariCustomer As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNoBukti As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpDari As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dtpSampai As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents rdTahunan As System.Windows.Forms.RadioButton
    Friend WithEvents rdBulanan As System.Windows.Forms.RadioButton
    Friend WithEvents rdHarian As System.Windows.Forms.RadioButton
    Friend WithEvents btnReset As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgvData1 As System.Windows.Forms.DataGridView
    Friend WithEvents dgvData2 As System.Windows.Forms.DataGridView
    Friend WithEvents dgTest As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column27 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
