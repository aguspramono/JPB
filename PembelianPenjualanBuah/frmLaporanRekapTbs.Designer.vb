<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaporanRekapTbs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLaporanRekapTbs))
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.cmbBulan = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.cmbTahun = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.btnProses = New DevComponents.DotNetBar.ButtonX()
        Me.txtCustomer = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.cbPilih = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(10, -1)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 24)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Cari"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(418, 0)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(64, 24)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Bulan"
        '
        'cmbBulan
        '
        Me.cmbBulan.DisplayMember = "Text"
        Me.cmbBulan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbBulan.FormattingEnabled = True
        Me.cmbBulan.ItemHeight = 14
        Me.cmbBulan.Location = New System.Drawing.Point(418, 30)
        Me.cmbBulan.Name = "cmbBulan"
        Me.cmbBulan.Size = New System.Drawing.Size(101, 20)
        Me.cmbBulan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbBulan.TabIndex = 4
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(527, 0)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(64, 24)
        Me.LabelX3.TabIndex = 5
        Me.LabelX3.Text = "Tahun"
        '
        'cmbTahun
        '
        Me.cmbTahun.DisplayMember = "Text"
        Me.cmbTahun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTahun.FormattingEnabled = True
        Me.cmbTahun.ItemHeight = 14
        Me.cmbTahun.Location = New System.Drawing.Point(525, 30)
        Me.cmbTahun.Name = "cmbTahun"
        Me.cmbTahun.Size = New System.Drawing.Size(101, 20)
        Me.cmbTahun.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbTahun.TabIndex = 6
        '
        'btnProses
        '
        Me.btnProses.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnProses.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnProses.Location = New System.Drawing.Point(632, 28)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(107, 23)
        Me.btnProses.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnProses.TabIndex = 7
        Me.btnProses.Text = "Proses"
        '
        'txtCustomer
        '
        '
        '
        '
        Me.txtCustomer.Border.Class = "TextBoxBorder"
        Me.txtCustomer.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCustomer.Location = New System.Drawing.Point(10, 30)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(185, 20)
        Me.txtCustomer.TabIndex = 8
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(215, -1)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(108, 24)
        Me.LabelX4.TabIndex = 10
        Me.LabelX4.Text = "Pilih"
        '
        'cbPilih
        '
        Me.cbPilih.DisplayMember = "Text"
        Me.cbPilih.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbPilih.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPilih.FormattingEnabled = True
        Me.cbPilih.ItemHeight = 14
        Me.cbPilih.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2})
        Me.cbPilih.Location = New System.Drawing.Point(212, 30)
        Me.cbPilih.Name = "cbPilih"
        Me.cbPilih.Size = New System.Drawing.Size(197, 20)
        Me.cbPilih.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbPilih.TabIndex = 11
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Customer"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Kode Kelompok"
        '
        'frmLaporanRekapTbs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 62)
        Me.Controls.Add(Me.cbPilih)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.txtCustomer)
        Me.Controls.Add(Me.btnProses)
        Me.Controls.Add(Me.cmbTahun)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.cmbBulan)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLaporanRekapTbs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rekap TBS"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbBulan As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbTahun As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents btnProses As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtCustomer As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbPilih As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
End Class
