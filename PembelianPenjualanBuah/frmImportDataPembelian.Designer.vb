<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportDataPembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImportDataPembelian))
        Me.txtCariFile = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnCariFile = New DevComponents.DotNetBar.ButtonX()
        Me.btnLoadData = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.dgView = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn()
        Me.Column7 = New DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.lblTotalNetto = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.lblJumlahNettoPenjualan = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblJumlahNettoPembelian = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnImportData = New DevComponents.DotNetBar.ButtonX()
        Me.lblPenjualan = New DevComponents.DotNetBar.LabelX()
        Me.lblPembelian = New DevComponents.DotNetBar.LabelX()
        Me.lblTotalData = New DevComponents.DotNetBar.LabelX()
        Me.lblDataTidakValid = New DevComponents.DotNetBar.LabelX()
        Me.lblDataValid = New DevComponents.DotNetBar.LabelX()
        Me.btnCekData = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCariFile
        '
        Me.txtCariFile.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.txtCariFile.Border.Class = "TextBoxBorder"
        Me.txtCariFile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCariFile.Location = New System.Drawing.Point(3, 12)
        Me.txtCariFile.Name = "txtCariFile"
        Me.txtCariFile.ReadOnly = True
        Me.txtCariFile.Size = New System.Drawing.Size(222, 20)
        Me.txtCariFile.TabIndex = 1
        '
        'btnCariFile
        '
        Me.btnCariFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCariFile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCariFile.Location = New System.Drawing.Point(231, 11)
        Me.btnCariFile.Name = "btnCariFile"
        Me.btnCariFile.Size = New System.Drawing.Size(57, 23)
        Me.btnCariFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCariFile.TabIndex = 2
        Me.btnCariFile.Text = "Cari File"
        '
        'btnLoadData
        '
        Me.btnLoadData.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLoadData.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnLoadData.Location = New System.Drawing.Point(294, 11)
        Me.btnLoadData.Name = "btnLoadData"
        Me.btnLoadData.Size = New System.Drawing.Size(57, 23)
        Me.btnLoadData.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnLoadData.TabIndex = 3
        Me.btnLoadData.Text = "LoadData"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.txtCariFile)
        Me.PanelEx1.Controls.Add(Me.btnLoadData)
        Me.PanelEx1.Controls.Add(Me.btnCariFile)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(965, 42)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 4
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.dgView)
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx2.Location = New System.Drawing.Point(0, 42)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(965, 360)
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14})
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
        Me.dgView.Size = New System.Drawing.Size(965, 360)
        Me.dgView.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "NoTicket"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 70
        '
        'Column2
        '
        Me.Column2.HeaderText = "Vech"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 60
        '
        'Column3
        '
        Me.Column3.HeaderText = "Product"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 80
        '
        'Column4
        '
        Me.Column4.HeaderText = "NoAccount"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 80
        '
        'Column5
        '
        Me.Column5.HeaderText = "DO"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 80
        '
        'Column6
        '
        '
        '
        '
        Me.Column6.BackgroundStyle.Class = "DataGridViewDateTimeBorder"
        Me.Column6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Column6.HeaderText = "Tgl1"
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
        Me.Column6.ReadOnly = True
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.Width = 65
        '
        'Column7
        '
        '
        '
        '
        Me.Column7.BackgroundStyle.Class = "DataGridViewDateTimeBorder"
        Me.Column7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Column7.HeaderText = "Tgl2"
        Me.Column7.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left
        '
        '
        '
        Me.Column7.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.Column7.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Column7.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        '
        '
        '
        Me.Column7.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Column7.MonthCalendar.DisplayMonth = New Date(2017, 3, 1, 0, 0, 0, 0)
        Me.Column7.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.Column7.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.Column7.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.Column7.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Column7.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column7.Width = 65
        '
        'Column8
        '
        Me.Column8.HeaderText = "Jam1"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 50
        '
        'Column9
        '
        Me.Column9.HeaderText = "Jam2"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 50
        '
        'Column10
        '
        Me.Column10.HeaderText = "WG1"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 50
        '
        'Column11
        '
        Me.Column11.HeaderText = "WG2"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 50
        '
        'Column12
        '
        Me.Column12.HeaderText = "Net"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 50
        '
        'Column13
        '
        Me.Column13.HeaderText = "ADJ"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Width = 40
        '
        'Column14
        '
        Me.Column14.HeaderText = "JLH JJG"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Width = 40
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.lblTotalNetto)
        Me.PanelEx3.Controls.Add(Me.LabelX1)
        Me.PanelEx3.Controls.Add(Me.lblJumlahNettoPenjualan)
        Me.PanelEx3.Controls.Add(Me.Label4)
        Me.PanelEx3.Controls.Add(Me.Label5)
        Me.PanelEx3.Controls.Add(Me.lblJumlahNettoPembelian)
        Me.PanelEx3.Controls.Add(Me.Label2)
        Me.PanelEx3.Controls.Add(Me.Label1)
        Me.PanelEx3.Controls.Add(Me.btnImportData)
        Me.PanelEx3.Controls.Add(Me.lblPenjualan)
        Me.PanelEx3.Controls.Add(Me.lblPembelian)
        Me.PanelEx3.Controls.Add(Me.lblTotalData)
        Me.PanelEx3.Controls.Add(Me.lblDataTidakValid)
        Me.PanelEx3.Controls.Add(Me.lblDataValid)
        Me.PanelEx3.Controls.Add(Me.btnCekData)
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEx3.Location = New System.Drawing.Point(0, 402)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(965, 59)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 6
        '
        'lblTotalNetto
        '
        '
        '
        '
        Me.lblTotalNetto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblTotalNetto.Location = New System.Drawing.Point(425, 3)
        Me.lblTotalNetto.Name = "lblTotalNetto"
        Me.lblTotalNetto.Size = New System.Drawing.Size(72, 23)
        Me.lblTotalNetto.TabIndex = 17
        Me.lblTotalNetto.Text = "0"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(358, 2)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(72, 23)
        Me.LabelX1.TabIndex = 16
        Me.LabelX1.Text = "Total Netto :"
        '
        'lblJumlahNettoPenjualan
        '
        Me.lblJumlahNettoPenjualan.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahNettoPenjualan.ForeColor = System.Drawing.Color.Blue
        Me.lblJumlahNettoPenjualan.Location = New System.Drawing.Point(697, 30)
        Me.lblJumlahNettoPenjualan.Name = "lblJumlahNettoPenjualan"
        Me.lblJumlahNettoPenjualan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblJumlahNettoPenjualan.Size = New System.Drawing.Size(99, 22)
        Me.lblJumlahNettoPenjualan.TabIndex = 15
        Me.lblJumlahNettoPenjualan.Text = "0"
        Me.lblJumlahNettoPenjualan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(679, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(573, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Netto Penjualan"
        '
        'lblJumlahNettoPembelian
        '
        Me.lblJumlahNettoPembelian.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahNettoPembelian.ForeColor = System.Drawing.Color.Blue
        Me.lblJumlahNettoPembelian.Location = New System.Drawing.Point(483, 30)
        Me.lblJumlahNettoPembelian.Name = "lblJumlahNettoPembelian"
        Me.lblJumlahNettoPembelian.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblJumlahNettoPembelian.Size = New System.Drawing.Size(84, 22)
        Me.lblJumlahNettoPembelian.TabIndex = 12
        Me.lblJumlahNettoPembelian.Text = "0"
        Me.lblJumlahNettoPembelian.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(465, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(355, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Netto Pembelian"
        '
        'btnImportData
        '
        Me.btnImportData.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnImportData.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnImportData.Location = New System.Drawing.Point(865, 24)
        Me.btnImportData.Name = "btnImportData"
        Me.btnImportData.Size = New System.Drawing.Size(68, 23)
        Me.btnImportData.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnImportData.TabIndex = 9
        Me.btnImportData.Text = "Import Data"
        '
        'lblPenjualan
        '
        '
        '
        '
        Me.lblPenjualan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblPenjualan.Location = New System.Drawing.Point(231, 30)
        Me.lblPenjualan.Name = "lblPenjualan"
        Me.lblPenjualan.Size = New System.Drawing.Size(87, 23)
        Me.lblPenjualan.TabIndex = 8
        Me.lblPenjualan.Text = "Penjualan :"
        '
        'lblPembelian
        '
        '
        '
        '
        Me.lblPembelian.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblPembelian.Location = New System.Drawing.Point(138, 30)
        Me.lblPembelian.Name = "lblPembelian"
        Me.lblPembelian.Size = New System.Drawing.Size(87, 23)
        Me.lblPembelian.TabIndex = 7
        Me.lblPembelian.Text = "Pembelian :"
        '
        'lblTotalData
        '
        '
        '
        '
        Me.lblTotalData.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblTotalData.Location = New System.Drawing.Point(140, 3)
        Me.lblTotalData.Name = "lblTotalData"
        Me.lblTotalData.Size = New System.Drawing.Size(178, 23)
        Me.lblTotalData.TabIndex = 6
        Me.lblTotalData.Text = "Total Data :"
        '
        'lblDataTidakValid
        '
        Me.lblDataTidakValid.BackColor = System.Drawing.Color.LightPink
        '
        '
        '
        Me.lblDataTidakValid.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblDataTidakValid.Location = New System.Drawing.Point(3, 30)
        Me.lblDataTidakValid.Name = "lblDataTidakValid"
        Me.lblDataTidakValid.Size = New System.Drawing.Size(131, 23)
        Me.lblDataTidakValid.TabIndex = 5
        Me.lblDataTidakValid.Text = "Data Tidak Valid :"
        '
        'lblDataValid
        '
        Me.lblDataValid.BackColor = System.Drawing.Color.LightGreen
        '
        '
        '
        Me.lblDataValid.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblDataValid.Location = New System.Drawing.Point(3, 3)
        Me.lblDataValid.Name = "lblDataValid"
        Me.lblDataValid.Size = New System.Drawing.Size(131, 23)
        Me.lblDataValid.TabIndex = 4
        Me.lblDataValid.Text = "Data Valid :"
        '
        'btnCekData
        '
        Me.btnCekData.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCekData.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCekData.Location = New System.Drawing.Point(802, 24)
        Me.btnCekData.Name = "btnCekData"
        Me.btnCekData.Size = New System.Drawing.Size(57, 23)
        Me.btnCekData.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCekData.TabIndex = 3
        Me.btnCekData.Text = "Cek Data"
        '
        'frmImportDataPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 461)
        Me.Controls.Add(Me.PanelEx2)
        Me.Controls.Add(Me.PanelEx3)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImportDataPembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import Data JPB"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx3.ResumeLayout(False)
        Me.PanelEx3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtCariFile As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnCariFile As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnLoadData As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents dgView As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btnCekData As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblTotalData As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblDataTidakValid As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblDataValid As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblPenjualan As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblPembelian As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnImportData As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
    Friend WithEvents Column7 As DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblJumlahNettoPembelian As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblJumlahNettoPenjualan As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblTotalNetto As DevComponents.DotNetBar.LabelX
End Class
