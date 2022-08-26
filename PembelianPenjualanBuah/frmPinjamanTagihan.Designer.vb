<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPinjamanTagihan
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPinjamanTagihan))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.txtSisaPinjaman = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.txtJumlahLunas = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtJumlahPinjaman = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtNama = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtNoAccount = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtKodePinjaman = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.btnTambahData = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.txtTotalTagihan = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvData = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.mnuKlikKanan = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuHapus = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDefault = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLunas = New System.Windows.Forms.ToolStripMenuItem()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuKlikKanan.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LabelX6)
        Me.Panel1.Controls.Add(Me.txtSisaPinjaman)
        Me.Panel1.Controls.Add(Me.LabelX5)
        Me.Panel1.Controls.Add(Me.txtJumlahLunas)
        Me.Panel1.Controls.Add(Me.LabelX4)
        Me.Panel1.Controls.Add(Me.txtJumlahPinjaman)
        Me.Panel1.Controls.Add(Me.LabelX3)
        Me.Panel1.Controls.Add(Me.txtNama)
        Me.Panel1.Controls.Add(Me.LabelX2)
        Me.Panel1.Controls.Add(Me.txtNoAccount)
        Me.Panel1.Controls.Add(Me.LabelX1)
        Me.Panel1.Controls.Add(Me.txtKodePinjaman)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(577, 88)
        Me.Panel1.TabIndex = 0
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(278, 57)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(85, 23)
        Me.LabelX6.TabIndex = 11
        Me.LabelX6.Text = "Sisa Pinjaman :"
        '
        'txtSisaPinjaman
        '
        '
        '
        '
        Me.txtSisaPinjaman.Border.Class = "TextBoxBorder"
        Me.txtSisaPinjaman.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSisaPinjaman.Enabled = False
        Me.txtSisaPinjaman.Location = New System.Drawing.Point(390, 58)
        Me.txtSisaPinjaman.Name = "txtSisaPinjaman"
        Me.txtSisaPinjaman.Size = New System.Drawing.Size(159, 20)
        Me.txtSisaPinjaman.TabIndex = 10
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(278, 32)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(106, 23)
        Me.LabelX5.TabIndex = 9
        Me.LabelX5.Text = "Dikatakan Lunas :"
        '
        'txtJumlahLunas
        '
        '
        '
        '
        Me.txtJumlahLunas.Border.Class = "TextBoxBorder"
        Me.txtJumlahLunas.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtJumlahLunas.Enabled = False
        Me.txtJumlahLunas.Location = New System.Drawing.Point(390, 33)
        Me.txtJumlahLunas.Name = "txtJumlahLunas"
        Me.txtJumlahLunas.Size = New System.Drawing.Size(159, 20)
        Me.txtJumlahLunas.TabIndex = 8
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(278, 6)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(106, 23)
        Me.LabelX4.TabIndex = 7
        Me.LabelX4.Text = "Jumlah Pinjaman :"
        '
        'txtJumlahPinjaman
        '
        '
        '
        '
        Me.txtJumlahPinjaman.Border.Class = "TextBoxBorder"
        Me.txtJumlahPinjaman.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtJumlahPinjaman.Enabled = False
        Me.txtJumlahPinjaman.Location = New System.Drawing.Point(390, 7)
        Me.txtJumlahPinjaman.Name = "txtJumlahPinjaman"
        Me.txtJumlahPinjaman.Size = New System.Drawing.Size(159, 20)
        Me.txtJumlahPinjaman.TabIndex = 6
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(12, 58)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(85, 23)
        Me.LabelX3.TabIndex = 5
        Me.LabelX3.Text = "Nama :"
        '
        'txtNama
        '
        '
        '
        '
        Me.txtNama.Border.Class = "TextBoxBorder"
        Me.txtNama.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNama.Enabled = False
        Me.txtNama.Location = New System.Drawing.Point(102, 59)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(159, 20)
        Me.txtNama.TabIndex = 4
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(12, 32)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(85, 23)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "No Account :"
        '
        'txtNoAccount
        '
        '
        '
        '
        Me.txtNoAccount.Border.Class = "TextBoxBorder"
        Me.txtNoAccount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNoAccount.Enabled = False
        Me.txtNoAccount.Location = New System.Drawing.Point(102, 33)
        Me.txtNoAccount.Name = "txtNoAccount"
        Me.txtNoAccount.Size = New System.Drawing.Size(159, 20)
        Me.txtNoAccount.TabIndex = 2
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(12, 6)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(85, 23)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Kode Pinjaman :"
        '
        'txtKodePinjaman
        '
        '
        '
        '
        Me.txtKodePinjaman.Border.Class = "TextBoxBorder"
        Me.txtKodePinjaman.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtKodePinjaman.Enabled = False
        Me.txtKodePinjaman.Location = New System.Drawing.Point(102, 7)
        Me.txtKodePinjaman.Name = "txtKodePinjaman"
        Me.txtKodePinjaman.Size = New System.Drawing.Size(159, 20)
        Me.txtKodePinjaman.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LabelX8)
        Me.Panel2.Controls.Add(Me.btnTambahData)
        Me.Panel2.Controls.Add(Me.LabelX7)
        Me.Panel2.Controls.Add(Me.txtTotalTagihan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 385)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(577, 31)
        Me.Panel2.TabIndex = 1
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.ForeColor = System.Drawing.Color.Green
        Me.LabelX8.Location = New System.Drawing.Point(165, 3)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(188, 23)
        Me.LabelX8.TabIndex = 15
        Me.LabelX8.Text = "*Menunjukkan Default (Diprint)"
        '
        'btnTambahData
        '
        Me.btnTambahData.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnTambahData.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnTambahData.Location = New System.Drawing.Point(4, 4)
        Me.btnTambahData.Name = "btnTambahData"
        Me.btnTambahData.Size = New System.Drawing.Size(155, 23)
        Me.btnTambahData.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnTambahData.TabIndex = 14
        Me.btnTambahData.Text = "Tambah Data Tagihan"
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(359, 4)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(43, 23)
        Me.LabelX7.TabIndex = 13
        Me.LabelX7.Text = "Total :"
        '
        'txtTotalTagihan
        '
        '
        '
        '
        Me.txtTotalTagihan.Border.Class = "TextBoxBorder"
        Me.txtTotalTagihan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTotalTagihan.Enabled = False
        Me.txtTotalTagihan.Location = New System.Drawing.Point(408, 5)
        Me.txtTotalTagihan.Name = "txtTotalTagihan"
        Me.txtTotalTagihan.Size = New System.Drawing.Size(159, 20)
        Me.txtTotalTagihan.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgvData)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 88)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(577, 297)
        Me.Panel3.TabIndex = 2
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvData.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvData.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvData.Location = New System.Drawing.Point(0, 0)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.RowHeadersVisible = False
        Me.dgvData.Size = New System.Drawing.Size(577, 297)
        Me.dgvData.TabIndex = 0
        '
        'mnuKlikKanan
        '
        Me.mnuKlikKanan.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEdit, Me.mnuHapus, Me.mnuDefault, Me.mnuLunas})
        Me.mnuKlikKanan.Name = "mnuKlikKanan"
        Me.mnuKlikKanan.Size = New System.Drawing.Size(183, 114)
        '
        'mnuHapus
        '
        Me.mnuHapus.Name = "mnuHapus"
        Me.mnuHapus.Size = New System.Drawing.Size(182, 22)
        Me.mnuHapus.Text = "Hapus"
        '
        'mnuEdit
        '
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(182, 22)
        Me.mnuEdit.Text = "Edit"
        '
        'mnuDefault
        '
        Me.mnuDefault.Name = "mnuDefault"
        Me.mnuDefault.Size = New System.Drawing.Size(182, 22)
        Me.mnuDefault.Text = "Jadikan Default"
        '
        'mnuLunas
        '
        Me.mnuLunas.Name = "mnuLunas"
        Me.mnuLunas.Size = New System.Drawing.Size(182, 22)
        Me.mnuLunas.Text = "Ubah Menjadi Lunas"
        '
        'Column1
        '
        Me.Column1.HeaderText = "IDPinjamanTagihan"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        DataGridViewCellStyle9.Format = "d"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle9
        Me.Column2.HeaderText = "Tanggal"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Jumlah"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Keterangan"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "status"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        '
        'frmPinjamanTagihan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 416)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPinjamanTagihan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Pinjaman Tagihan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuKlikKanan.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtKodePinjaman As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNoAccount As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNama As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSisaPinjaman As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtJumlahLunas As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtJumlahPinjaman As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTotalTagihan As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnTambahData As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgvData As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents mnuKlikKanan As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuHapus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDefault As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLunas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
