<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInputJumlahSPSI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInputJumlahSPSI))
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.txtNoAcc = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNoBukti = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNama = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtSPSI = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtKeterangan = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNilai = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dtpTanggal = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.btnCariNama = New DevComponents.DotNetBar.ButtonX()
        Me.btnOk = New DevComponents.DotNetBar.ButtonX()
        Me.btnBatal = New DevComponents.DotNetBar.ButtonX()
        CType(Me.dtpTanggal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(12, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Tanggal"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(12, 44)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "No. ACC"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(12, 76)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 2
        Me.LabelX3.Text = "No. Bukti"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(12, 108)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(75, 23)
        Me.LabelX4.TabIndex = 3
        Me.LabelX4.Text = "Nama"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(12, 141)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(75, 23)
        Me.LabelX5.TabIndex = 4
        Me.LabelX5.Text = "SPSI"
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(12, 173)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(75, 23)
        Me.LabelX6.TabIndex = 5
        Me.LabelX6.Text = "Keterangan"
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(12, 243)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(75, 23)
        Me.LabelX7.TabIndex = 6
        Me.LabelX7.Text = "Nilai"
        '
        'txtNoAcc
        '
        '
        '
        '
        Me.txtNoAcc.Border.Class = "TextBoxBorder"
        Me.txtNoAcc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNoAcc.Location = New System.Drawing.Point(93, 44)
        Me.txtNoAcc.Name = "txtNoAcc"
        Me.txtNoAcc.Size = New System.Drawing.Size(239, 20)
        Me.txtNoAcc.TabIndex = 7
        '
        'txtNoBukti
        '
        '
        '
        '
        Me.txtNoBukti.Border.Class = "TextBoxBorder"
        Me.txtNoBukti.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNoBukti.Location = New System.Drawing.Point(93, 79)
        Me.txtNoBukti.Name = "txtNoBukti"
        Me.txtNoBukti.Size = New System.Drawing.Size(239, 20)
        Me.txtNoBukti.TabIndex = 8
        '
        'txtNama
        '
        '
        '
        '
        Me.txtNama.Border.Class = "TextBoxBorder"
        Me.txtNama.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNama.Location = New System.Drawing.Point(93, 111)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(239, 20)
        Me.txtNama.TabIndex = 9
        '
        'txtSPSI
        '
        '
        '
        '
        Me.txtSPSI.Border.Class = "TextBoxBorder"
        Me.txtSPSI.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSPSI.Location = New System.Drawing.Point(93, 141)
        Me.txtSPSI.Name = "txtSPSI"
        Me.txtSPSI.Size = New System.Drawing.Size(239, 20)
        Me.txtSPSI.TabIndex = 10
        '
        'txtKeterangan
        '
        '
        '
        '
        Me.txtKeterangan.Border.Class = "TextBoxBorder"
        Me.txtKeterangan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtKeterangan.Location = New System.Drawing.Point(93, 176)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(239, 59)
        Me.txtKeterangan.TabIndex = 11
        '
        'txtNilai
        '
        '
        '
        '
        Me.txtNilai.Border.Class = "TextBoxBorder"
        Me.txtNilai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNilai.Location = New System.Drawing.Point(93, 246)
        Me.txtNilai.Name = "txtNilai"
        Me.txtNilai.Size = New System.Drawing.Size(239, 20)
        Me.txtNilai.TabIndex = 12
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
        Me.dtpTanggal.Location = New System.Drawing.Point(93, 12)
        '
        '
        '
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
        Me.dtpTanggal.MonthCalendar.DisplayMonth = New Date(2020, 10, 1, 0, 0, 0, 0)
        Me.dtpTanggal.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.dtpTanggal.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtpTanggal.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpTanggal.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtpTanggal.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpTanggal.MonthCalendar.TodayButtonVisible = True
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(239, 20)
        Me.dtpTanggal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtpTanggal.TabIndex = 13
        '
        'btnCariNama
        '
        Me.btnCariNama.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCariNama.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCariNama.Location = New System.Drawing.Point(200, 296)
        Me.btnCariNama.Name = "btnCariNama"
        Me.btnCariNama.Size = New System.Drawing.Size(29, 20)
        Me.btnCariNama.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCariNama.TabIndex = 14
        Me.btnCariNama.Text = "---"
        Me.btnCariNama.Visible = False
        '
        'btnOk
        '
        Me.btnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnOk.Location = New System.Drawing.Point(12, 282)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 34)
        Me.btnOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnOk.TabIndex = 15
        Me.btnOk.Text = "&Ok"
        '
        'btnBatal
        '
        Me.btnBatal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBatal.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBatal.Location = New System.Drawing.Point(93, 282)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 34)
        Me.btnBatal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBatal.TabIndex = 16
        Me.btnBatal.Text = "&Batal"
        '
        'frmInputJumlahSPSI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 344)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCariNama)
        Me.Controls.Add(Me.dtpTanggal)
        Me.Controls.Add(Me.txtNilai)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.txtSPSI)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNoBukti)
        Me.Controls.Add(Me.txtNoAcc)
        Me.Controls.Add(Me.LabelX7)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInputJumlahSPSI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Jumlah SPSI"
        CType(Me.dtpTanggal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Private WithEvents btnCariNama As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnOk As DevComponents.DotNetBar.ButtonX
    Private WithEvents btnBatal As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtNoAcc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNoBukti As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNama As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtSPSI As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtKeterangan As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNilai As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dtpTanggal As DevComponents.Editors.DateTimeAdv.DateTimeInput
End Class
