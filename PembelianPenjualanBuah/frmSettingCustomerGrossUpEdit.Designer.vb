<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettingCustomerGrossUpEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettingCustomerGrossUpEdit))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.txtNoAcc = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNamaCust = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtKelompok = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cmbPilih = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.btnUbah = New DevComponents.DotNetBar.ButtonX()
        Me.btnBatal = New DevComponents.DotNetBar.ButtonX()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnBatal)
        Me.Panel1.Controls.Add(Me.btnUbah)
        Me.Panel1.Controls.Add(Me.cmbPilih)
        Me.Panel1.Controls.Add(Me.txtKelompok)
        Me.Panel1.Controls.Add(Me.txtNamaCust)
        Me.Panel1.Controls.Add(Me.txtNoAcc)
        Me.Panel1.Controls.Add(Me.LabelX8)
        Me.Panel1.Controls.Add(Me.LabelX7)
        Me.Panel1.Controls.Add(Me.LabelX6)
        Me.Panel1.Controls.Add(Me.LabelX5)
        Me.Panel1.Controls.Add(Me.LabelX4)
        Me.Panel1.Controls.Add(Me.LabelX3)
        Me.Panel1.Controls.Add(Me.LabelX2)
        Me.Panel1.Controls.Add(Me.LabelX1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(298, 182)
        Me.Panel1.TabIndex = 0
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
        Me.LabelX1.Text = "No Account"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(12, 41)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(95, 23)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "Nama Customer"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(12, 70)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(95, 23)
        Me.LabelX3.TabIndex = 2
        Me.LabelX3.Text = "Kelompok"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(12, 99)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(95, 23)
        Me.LabelX4.TabIndex = 3
        Me.LabelX4.Text = "Tipe Gross Up"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(113, 12)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(16, 23)
        Me.LabelX5.TabIndex = 4
        Me.LabelX5.Text = ":"
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(113, 41)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(16, 23)
        Me.LabelX6.TabIndex = 5
        Me.LabelX6.Text = ":"
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(113, 70)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(16, 23)
        Me.LabelX7.TabIndex = 6
        Me.LabelX7.Text = ":"
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(113, 99)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(16, 23)
        Me.LabelX8.TabIndex = 7
        Me.LabelX8.Text = ":"
        '
        'txtNoAcc
        '
        '
        '
        '
        Me.txtNoAcc.Border.Class = "TextBoxBorder"
        Me.txtNoAcc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNoAcc.Enabled = False
        Me.txtNoAcc.Location = New System.Drawing.Point(135, 15)
        Me.txtNoAcc.Name = "txtNoAcc"
        Me.txtNoAcc.Size = New System.Drawing.Size(151, 20)
        Me.txtNoAcc.TabIndex = 8
        '
        'txtNamaCust
        '
        '
        '
        '
        Me.txtNamaCust.Border.Class = "TextBoxBorder"
        Me.txtNamaCust.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNamaCust.Enabled = False
        Me.txtNamaCust.Location = New System.Drawing.Point(135, 44)
        Me.txtNamaCust.Name = "txtNamaCust"
        Me.txtNamaCust.Size = New System.Drawing.Size(151, 20)
        Me.txtNamaCust.TabIndex = 9
        '
        'txtKelompok
        '
        '
        '
        '
        Me.txtKelompok.Border.Class = "TextBoxBorder"
        Me.txtKelompok.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtKelompok.Enabled = False
        Me.txtKelompok.Location = New System.Drawing.Point(135, 73)
        Me.txtKelompok.Name = "txtKelompok"
        Me.txtKelompok.Size = New System.Drawing.Size(151, 20)
        Me.txtKelompok.TabIndex = 10
        '
        'cmbPilih
        '
        Me.cmbPilih.DisplayMember = "Text"
        Me.cmbPilih.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbPilih.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPilih.FormattingEnabled = True
        Me.cmbPilih.ItemHeight = 14
        Me.cmbPilih.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4})
        Me.cmbPilih.Location = New System.Drawing.Point(135, 102)
        Me.cmbPilih.Name = "cmbPilih"
        Me.cmbPilih.Size = New System.Drawing.Size(151, 20)
        Me.cmbPilih.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbPilih.TabIndex = 11
        '
        'btnUbah
        '
        Me.btnUbah.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnUbah.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnUbah.Location = New System.Drawing.Point(12, 142)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(75, 23)
        Me.btnUbah.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnUbah.TabIndex = 12
        Me.btnUbah.Text = "&Ubah"
        '
        'btnBatal
        '
        Me.btnBatal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBatal.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBatal.Location = New System.Drawing.Point(93, 142)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBatal.TabIndex = 13
        Me.btnBatal.Text = "&Batal"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "NPWP 100/99.75"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "NPWP 50% 100/99.875"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Non NPWP 100/99.5"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Non NPWP 50% 100/99.75"
        '
        'frmSettingCustomerGrossUpEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 182)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettingCustomerGrossUpEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setting Customer Gross Up Edit"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnUbah As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmbPilih As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtKelompok As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNamaCust As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNoAcc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnBatal As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
End Class
