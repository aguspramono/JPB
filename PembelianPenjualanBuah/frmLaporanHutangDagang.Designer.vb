<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaporanHutangDagang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLaporanHutangDagang))
        Me.btnProses = New DevComponents.DotNetBar.ButtonX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbTahun2 = New System.Windows.Forms.ComboBox()
        Me.cmbbulan2 = New System.Windows.Forms.ComboBox()
        Me.ckRekap = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.ckTahun = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.txtCari = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnProses
        '
        Me.btnProses.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnProses.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnProses.Location = New System.Drawing.Point(8, 125)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(250, 36)
        Me.btnProses.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnProses.TabIndex = 0
        Me.btnProses.Text = "Proses"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbTahun2)
        Me.Panel1.Controls.Add(Me.cmbbulan2)
        Me.Panel1.Controls.Add(Me.ckRekap)
        Me.Panel1.Controls.Add(Me.ckTahun)
        Me.Panel1.Controls.Add(Me.txtCari)
        Me.Panel1.Controls.Add(Me.LabelX3)
        Me.Panel1.Controls.Add(Me.LabelX2)
        Me.Panel1.Controls.Add(Me.LabelX1)
        Me.Panel1.Controls.Add(Me.btnProses)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(264, 166)
        Me.Panel1.TabIndex = 1
        '
        'cmbTahun2
        '
        Me.cmbTahun2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTahun2.FormattingEnabled = True
        Me.cmbTahun2.Location = New System.Drawing.Point(59, 70)
        Me.cmbTahun2.Name = "cmbTahun2"
        Me.cmbTahun2.Size = New System.Drawing.Size(195, 21)
        Me.cmbTahun2.TabIndex = 12
        '
        'cmbbulan2
        '
        Me.cmbbulan2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbulan2.FormattingEnabled = True
        Me.cmbbulan2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cmbbulan2.Location = New System.Drawing.Point(59, 43)
        Me.cmbbulan2.Name = "cmbbulan2"
        Me.cmbbulan2.Size = New System.Drawing.Size(195, 21)
        Me.cmbbulan2.TabIndex = 11
        '
        'ckRekap
        '
        '
        '
        '
        Me.ckRekap.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ckRekap.Location = New System.Drawing.Point(158, 96)
        Me.ckRekap.Name = "ckRekap"
        Me.ckRekap.Size = New System.Drawing.Size(100, 23)
        Me.ckRekap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ckRekap.TabIndex = 10
        Me.ckRekap.Text = "Rekap"
        '
        'ckTahun
        '
        '
        '
        '
        Me.ckTahun.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ckTahun.Location = New System.Drawing.Point(59, 96)
        Me.ckTahun.Name = "ckTahun"
        Me.ckTahun.Size = New System.Drawing.Size(100, 23)
        Me.ckTahun.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ckTahun.TabIndex = 9
        Me.ckTahun.Text = "Tahunan"
        '
        'txtCari
        '
        '
        '
        '
        Me.txtCari.Border.Class = "TextBoxBorder"
        Me.txtCari.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCari.Location = New System.Drawing.Point(59, 15)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(195, 20)
        Me.txtCari.TabIndex = 7
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(8, 12)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(47, 23)
        Me.LabelX3.TabIndex = 6
        Me.LabelX3.Text = "NoAcc :"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(8, 67)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Tahun :"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(8, 41)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Bulan :"
        '
        'frmLaporanHutangDagang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 166)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLaporanHutangDagang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Hutang Dagang"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnProses As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCari As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ckTahun As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents ckRekap As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cmbbulan2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTahun2 As System.Windows.Forms.ComboBox
End Class
