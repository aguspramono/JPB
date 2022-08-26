<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateHarga2
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
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.dthelp2 = New System.Windows.Forms.DateTimePicker()
        Me.btnUpdateHarga = New DevComponents.DotNetBar.ButtonX()
        Me.btnLoad2 = New DevComponents.DotNetBar.ButtonX()
        Me.dtHelp = New System.Windows.Forms.DateTimePicker()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.dtAkhir = New System.Windows.Forms.DateTimePicker()
        Me.dtAwal = New System.Windows.Forms.DateTimePicker()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.mnuTambah = New System.Windows.Forms.ToolStripMenuItem()
        Me.klikKananMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgView = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.cboGrade = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.btnShowHide = New DevComponents.DotNetBar.ButtonX()
        Me.btnLoad = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.klikKananMenu.SuspendLayout()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx2.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuEdit
        '
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(147, 22)
        Me.mnuEdit.Text = "Edit"
        Me.mnuEdit.ToolTipText = "Klik di tgl Untuk Mengupdate semua Kelompok yang di tampilkan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Atau Pilih Salah S" & _
    "atu kelompok untuk hanya mengupdate  Satu Kelompok"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.LabelX5.Location = New System.Drawing.Point(466, 7)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(296, 25)
        Me.LabelX5.TabIndex = 82
        Me.LabelX5.Text = "*Update harga di JPB terlebih dahulu sebelum" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mengupdate harga rata2"
        '
        'dthelp2
        '
        Me.dthelp2.Location = New System.Drawing.Point(518, 41)
        Me.dthelp2.Name = "dthelp2"
        Me.dthelp2.Size = New System.Drawing.Size(170, 20)
        Me.dthelp2.TabIndex = 81
        Me.dthelp2.Visible = False
        '
        'btnUpdateHarga
        '
        Me.btnUpdateHarga.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnUpdateHarga.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnUpdateHarga.Location = New System.Drawing.Point(340, 11)
        Me.btnUpdateHarga.Name = "btnUpdateHarga"
        Me.btnUpdateHarga.Size = New System.Drawing.Size(113, 23)
        Me.btnUpdateHarga.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnUpdateHarga.TabIndex = 80
        Me.btnUpdateHarga.Text = "Update Harga Rata2"
        '
        'btnLoad2
        '
        Me.btnLoad2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLoad2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnLoad2.Location = New System.Drawing.Point(434, 58)
        Me.btnLoad2.Name = "btnLoad2"
        Me.btnLoad2.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnLoad2.TabIndex = 79
        Me.btnLoad2.Text = "Load"
        Me.btnLoad2.Visible = False
        '
        'dtHelp
        '
        Me.dtHelp.Location = New System.Drawing.Point(518, 61)
        Me.dtHelp.Name = "dtHelp"
        Me.dtHelp.Size = New System.Drawing.Size(170, 20)
        Me.dtHelp.TabIndex = 78
        Me.dtHelp.Visible = False
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(61, 9)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(10, 23)
        Me.LabelX1.TabIndex = 77
        Me.LabelX1.Text = ":"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(9, 9)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(46, 23)
        Me.LabelX2.TabIndex = 76
        Me.LabelX2.Text = "Grade"
        '
        'dtAkhir
        '
        Me.dtAkhir.Location = New System.Drawing.Point(77, 61)
        Me.dtAkhir.Name = "dtAkhir"
        Me.dtAkhir.Size = New System.Drawing.Size(173, 20)
        Me.dtAkhir.TabIndex = 75
        '
        'dtAwal
        '
        Me.dtAwal.Location = New System.Drawing.Point(77, 38)
        Me.dtAwal.Name = "dtAwal"
        Me.dtAwal.Size = New System.Drawing.Size(173, 20)
        Me.dtAwal.TabIndex = 74
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(61, 35)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(10, 23)
        Me.LabelX4.TabIndex = 73
        Me.LabelX4.Text = ":"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(9, 35)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(30, 23)
        Me.LabelX3.TabIndex = 72
        Me.LabelX3.Text = "Tgl"
        '
        'mnuTambah
        '
        Me.mnuTambah.Name = "mnuTambah"
        Me.mnuTambah.Size = New System.Drawing.Size(147, 22)
        Me.mnuTambah.Text = "Tambah"
        '
        'klikKananMenu
        '
        Me.klikKananMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTambah, Me.mnuUpdate, Me.mnuEdit})
        Me.klikKananMenu.Name = "klikKananMenu"
        Me.klikKananMenu.Size = New System.Drawing.Size(148, 70)
        '
        'mnuUpdate
        '
        Me.mnuUpdate.Name = "mnuUpdate"
        Me.mnuUpdate.Size = New System.Drawing.Size(147, 22)
        Me.mnuUpdate.Text = "Update Harga"
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.dgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgView.Size = New System.Drawing.Size(1306, 547)
        Me.dgView.TabIndex = 3
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.dgView)
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx2.Location = New System.Drawing.Point(0, 84)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(1306, 547)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 3
        '
        'cboGrade
        '
        Me.cboGrade.DisplayMember = "Text"
        Me.cboGrade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGrade.FormattingEnabled = True
        Me.cboGrade.ItemHeight = 14
        Me.cboGrade.Items.AddRange(New Object() {Me.ComboItem4, Me.ComboItem1, Me.ComboItem2, Me.ComboItem3})
        Me.cboGrade.Location = New System.Drawing.Point(77, 12)
        Me.cboGrade.Name = "cboGrade"
        Me.cboGrade.Size = New System.Drawing.Size(173, 20)
        Me.cboGrade.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboGrade.TabIndex = 65
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "All"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "A"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "B"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "C"
        '
        'btnShowHide
        '
        Me.btnShowHide.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnShowHide.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnShowHide.Location = New System.Drawing.Point(695, 58)
        Me.btnShowHide.Name = "btnShowHide"
        Me.btnShowHide.Size = New System.Drawing.Size(75, 23)
        Me.btnShowHide.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnShowHide.TabIndex = 1
        Me.btnShowHide.Text = "Show/Hide"
        '
        'btnLoad
        '
        Me.btnLoad.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLoad.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnLoad.Location = New System.Drawing.Point(260, 11)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "Load"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.LabelX5)
        Me.PanelEx1.Controls.Add(Me.dthelp2)
        Me.PanelEx1.Controls.Add(Me.btnUpdateHarga)
        Me.PanelEx1.Controls.Add(Me.btnLoad2)
        Me.PanelEx1.Controls.Add(Me.dtHelp)
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.Controls.Add(Me.LabelX2)
        Me.PanelEx1.Controls.Add(Me.dtAkhir)
        Me.PanelEx1.Controls.Add(Me.dtAwal)
        Me.PanelEx1.Controls.Add(Me.LabelX4)
        Me.PanelEx1.Controls.Add(Me.LabelX3)
        Me.PanelEx1.Controls.Add(Me.cboGrade)
        Me.PanelEx1.Controls.Add(Me.btnShowHide)
        Me.PanelEx1.Controls.Add(Me.btnLoad)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1306, 84)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 2
        '
        'frmUpdateHarga2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1306, 631)
        Me.Controls.Add(Me.PanelEx2)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUpdateHarga2"
        Me.Text = "frmUpdateHarga2"
        Me.klikKananMenu.ResumeLayout(False)
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dthelp2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnUpdateHarga As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnLoad2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dtHelp As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents mnuTambah As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents klikKananMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuUpdate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgView As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents cboGrade As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents btnShowHide As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnLoad As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
End Class
