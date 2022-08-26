<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettingTanggalFee
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettingTanggalFee))
        Me.lblTanggalDari = New DevComponents.DotNetBar.LabelX()
        Me.lblTanggalSampai = New DevComponents.DotNetBar.LabelX()
        Me.lblFee = New DevComponents.DotNetBar.LabelX()
        Me.lblKelompok = New DevComponents.DotNetBar.LabelX()
        Me.txtKelompok = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dtpTanggalDari = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dtpTanggalSampai = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.txtFee = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnCariKelompok = New DevComponents.DotNetBar.ButtonX()
        Me.btnBaru = New DevComponents.DotNetBar.ButtonX()
        Me.dgvView = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.clmID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmKelompok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEdit = New DevComponents.DotNetBar.ButtonX()
        Me.btnOk = New DevComponents.DotNetBar.ButtonX()
        Me.btnBatal = New DevComponents.DotNetBar.ButtonX()
        CType(Me.dtpTanggalDari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTanggalSampai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTanggalDari
        '
        '
        '
        '
        Me.lblTanggalDari.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblTanggalDari.Location = New System.Drawing.Point(2, 41)
        Me.lblTanggalDari.Name = "lblTanggalDari"
        Me.lblTanggalDari.Size = New System.Drawing.Size(75, 23)
        Me.lblTanggalDari.TabIndex = 0
        Me.lblTanggalDari.Text = "Tanggal Dari"
        '
        'lblTanggalSampai
        '
        '
        '
        '
        Me.lblTanggalSampai.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblTanggalSampai.Location = New System.Drawing.Point(2, 70)
        Me.lblTanggalSampai.Name = "lblTanggalSampai"
        Me.lblTanggalSampai.Size = New System.Drawing.Size(99, 23)
        Me.lblTanggalSampai.TabIndex = 1
        Me.lblTanggalSampai.Text = "Tanggal Sampai"
        '
        'lblFee
        '
        '
        '
        '
        Me.lblFee.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblFee.Location = New System.Drawing.Point(2, 99)
        Me.lblFee.Name = "lblFee"
        Me.lblFee.Size = New System.Drawing.Size(99, 23)
        Me.lblFee.TabIndex = 2
        Me.lblFee.Text = "Fee"
        '
        'lblKelompok
        '
        '
        '
        '
        Me.lblKelompok.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblKelompok.Location = New System.Drawing.Point(2, 12)
        Me.lblKelompok.Name = "lblKelompok"
        Me.lblKelompok.Size = New System.Drawing.Size(99, 23)
        Me.lblKelompok.TabIndex = 3
        Me.lblKelompok.Text = "Kelompok"
        '
        'txtKelompok
        '
        '
        '
        '
        Me.txtKelompok.Border.Class = "TextBoxBorder"
        Me.txtKelompok.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtKelompok.Enabled = False
        Me.txtKelompok.Location = New System.Drawing.Point(110, 15)
        Me.txtKelompok.Name = "txtKelompok"
        Me.txtKelompok.Size = New System.Drawing.Size(200, 20)
        Me.txtKelompok.TabIndex = 4
        '
        'dtpTanggalDari
        '
        '
        '
        '
        Me.dtpTanggalDari.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtpTanggalDari.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpTanggalDari.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtpTanggalDari.ButtonDropDown.Visible = True
        Me.dtpTanggalDari.IsPopupCalendarOpen = False
        Me.dtpTanggalDari.Location = New System.Drawing.Point(110, 44)
        '
        '
        '
        Me.dtpTanggalDari.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtpTanggalDari.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpTanggalDari.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtpTanggalDari.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtpTanggalDari.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtpTanggalDari.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpTanggalDari.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtpTanggalDari.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtpTanggalDari.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtpTanggalDari.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtpTanggalDari.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpTanggalDari.MonthCalendar.DisplayMonth = New Date(2020, 10, 1, 0, 0, 0, 0)
        Me.dtpTanggalDari.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.dtpTanggalDari.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtpTanggalDari.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtpTanggalDari.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtpTanggalDari.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpTanggalDari.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtpTanggalDari.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpTanggalDari.MonthCalendar.TodayButtonVisible = True
        Me.dtpTanggalDari.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtpTanggalDari.Name = "dtpTanggalDari"
        Me.dtpTanggalDari.Size = New System.Drawing.Size(249, 20)
        Me.dtpTanggalDari.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtpTanggalDari.TabIndex = 5
        '
        'dtpTanggalSampai
        '
        '
        '
        '
        Me.dtpTanggalSampai.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtpTanggalSampai.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpTanggalSampai.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtpTanggalSampai.ButtonDropDown.Visible = True
        Me.dtpTanggalSampai.IsPopupCalendarOpen = False
        Me.dtpTanggalSampai.Location = New System.Drawing.Point(110, 73)
        '
        '
        '
        Me.dtpTanggalSampai.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtpTanggalSampai.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpTanggalSampai.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtpTanggalSampai.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtpTanggalSampai.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtpTanggalSampai.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpTanggalSampai.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtpTanggalSampai.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtpTanggalSampai.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtpTanggalSampai.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtpTanggalSampai.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpTanggalSampai.MonthCalendar.DisplayMonth = New Date(2020, 10, 1, 0, 0, 0, 0)
        Me.dtpTanggalSampai.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.dtpTanggalSampai.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtpTanggalSampai.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtpTanggalSampai.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtpTanggalSampai.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpTanggalSampai.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtpTanggalSampai.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpTanggalSampai.MonthCalendar.TodayButtonVisible = True
        Me.dtpTanggalSampai.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtpTanggalSampai.Name = "dtpTanggalSampai"
        Me.dtpTanggalSampai.Size = New System.Drawing.Size(249, 20)
        Me.dtpTanggalSampai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtpTanggalSampai.TabIndex = 6
        '
        'txtFee
        '
        '
        '
        '
        Me.txtFee.Border.Class = "TextBoxBorder"
        Me.txtFee.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtFee.Enabled = False
        Me.txtFee.Location = New System.Drawing.Point(110, 102)
        Me.txtFee.Name = "txtFee"
        Me.txtFee.Size = New System.Drawing.Size(249, 20)
        Me.txtFee.TabIndex = 7
        '
        'btnCariKelompok
        '
        Me.btnCariKelompok.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCariKelompok.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCariKelompok.Enabled = False
        Me.btnCariKelompok.Location = New System.Drawing.Point(316, 13)
        Me.btnCariKelompok.Name = "btnCariKelompok"
        Me.btnCariKelompok.Size = New System.Drawing.Size(43, 23)
        Me.btnCariKelompok.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCariKelompok.TabIndex = 8
        Me.btnCariKelompok.Text = "---"
        '
        'btnBaru
        '
        Me.btnBaru.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBaru.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBaru.Location = New System.Drawing.Point(2, 284)
        Me.btnBaru.Name = "btnBaru"
        Me.btnBaru.Size = New System.Drawing.Size(81, 33)
        Me.btnBaru.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBaru.TabIndex = 9
        Me.btnBaru.Text = "&Baru"
        '
        'dgvView
        '
        Me.dgvView.AllowUserToAddRows = False
        Me.dgvView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmID, Me.clmKelompok, Me.clmTanggal, Me.clmFee})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvView.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvView.EnableHeadersVisualStyles = False
        Me.dgvView.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvView.Location = New System.Drawing.Point(2, 128)
        Me.dgvView.Name = "dgvView"
        Me.dgvView.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvView.RowHeadersVisible = False
        Me.dgvView.Size = New System.Drawing.Size(357, 150)
        Me.dgvView.TabIndex = 10
        '
        'clmID
        '
        Me.clmID.HeaderText = "ID"
        Me.clmID.Name = "clmID"
        Me.clmID.ReadOnly = True
        Me.clmID.Visible = False
        '
        'clmKelompok
        '
        Me.clmKelompok.HeaderText = "Kelompok"
        Me.clmKelompok.Name = "clmKelompok"
        Me.clmKelompok.ReadOnly = True
        '
        'clmTanggal
        '
        Me.clmTanggal.HeaderText = "Tanggal"
        Me.clmTanggal.Name = "clmTanggal"
        Me.clmTanggal.ReadOnly = True
        '
        'clmFee
        '
        Me.clmFee.HeaderText = "Fee"
        Me.clmFee.Name = "clmFee"
        Me.clmFee.ReadOnly = True
        '
        'btnEdit
        '
        Me.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEdit.Location = New System.Drawing.Point(89, 284)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(81, 33)
        Me.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEdit.TabIndex = 11
        Me.btnEdit.Text = "&Edit"
        '
        'btnOk
        '
        Me.btnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnOk.Enabled = False
        Me.btnOk.Location = New System.Drawing.Point(176, 284)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(81, 33)
        Me.btnOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnOk.TabIndex = 12
        Me.btnOk.Text = "&Ok"
        '
        'btnBatal
        '
        Me.btnBatal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBatal.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBatal.Enabled = False
        Me.btnBatal.Location = New System.Drawing.Point(263, 284)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(81, 33)
        Me.btnBatal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBatal.TabIndex = 13
        Me.btnBatal.Text = "&Batal"
        '
        'frmSettingTanggalFee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 319)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.dgvView)
        Me.Controls.Add(Me.btnBaru)
        Me.Controls.Add(Me.btnCariKelompok)
        Me.Controls.Add(Me.txtFee)
        Me.Controls.Add(Me.dtpTanggalSampai)
        Me.Controls.Add(Me.dtpTanggalDari)
        Me.Controls.Add(Me.txtKelompok)
        Me.Controls.Add(Me.lblKelompok)
        Me.Controls.Add(Me.lblFee)
        Me.Controls.Add(Me.lblTanggalSampai)
        Me.Controls.Add(Me.lblTanggalDari)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettingTanggalFee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setting Tanggal Fee"
        CType(Me.dtpTanggalDari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTanggalSampai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTanggalDari As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblTanggalSampai As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblFee As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblKelompok As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtKelompok As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dtpTanggalDari As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dtpTanggalSampai As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents txtFee As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnCariKelompok As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnBaru As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgvView As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btnEdit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnOk As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnBatal As DevComponents.DotNetBar.ButtonX
    Friend WithEvents clmID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmKelompok As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTanggal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFee As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
