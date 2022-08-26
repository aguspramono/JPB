<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateHargaPlatData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdateHargaPlatData))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtKodeKelompok = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpJam = New System.Windows.Forms.DateTimePicker()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.DgvData = New System.Windows.Forms.DataGridView()
        Me.kodeKelompok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomorPlat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.perubahan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cb = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ckPilihSemua = New System.Windows.Forms.CheckBox()
        Me.mnuKlikKanan = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuEditHarga = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuKlikKanan.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtKodeKelompok)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 46)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kode Kelompok"
        '
        'txtKodeKelompok
        '
        Me.txtKodeKelompok.Enabled = False
        Me.txtKodeKelompok.Location = New System.Drawing.Point(7, 19)
        Me.txtKodeKelompok.Name = "txtKodeKelompok"
        Me.txtKodeKelompok.Size = New System.Drawing.Size(343, 20)
        Me.txtKodeKelompok.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpJam)
        Me.GroupBox2.Controls.Add(Me.dtpTanggal)
        Me.GroupBox2.Location = New System.Drawing.Point(370, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(372, 46)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tanggal dan Jam"
        '
        'dtpJam
        '
        Me.dtpJam.Enabled = False
        Me.dtpJam.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpJam.Location = New System.Drawing.Point(194, 19)
        Me.dtpJam.Name = "dtpJam"
        Me.dtpJam.Size = New System.Drawing.Size(171, 20)
        Me.dtpJam.TabIndex = 1
        Me.dtpJam.Value = New Date(2019, 9, 26, 0, 0, 0, 0)
        '
        'dtpTanggal
        '
        Me.dtpTanggal.Enabled = False
        Me.dtpTanggal.Location = New System.Drawing.Point(7, 19)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(181, 20)
        Me.dtpTanggal.TabIndex = 0
        '
        'DgvData
        '
        Me.DgvData.AllowUserToAddRows = False
        Me.DgvData.AllowUserToDeleteRows = False
        Me.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodeKelompok, Me.nomorPlat, Me.harga, Me.perubahan, Me.cb})
        Me.DgvData.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DgvData.Location = New System.Drawing.Point(0, 67)
        Me.DgvData.MultiSelect = False
        Me.DgvData.Name = "DgvData"
        Me.DgvData.RowHeadersVisible = False
        Me.DgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvData.Size = New System.Drawing.Size(913, 357)
        Me.DgvData.TabIndex = 3
        '
        'kodeKelompok
        '
        Me.kodeKelompok.HeaderText = "kodeKelompok"
        Me.kodeKelompok.Name = "kodeKelompok"
        Me.kodeKelompok.Width = 170
        '
        'nomorPlat
        '
        Me.nomorPlat.HeaderText = "Nomor Plat"
        Me.nomorPlat.Name = "nomorPlat"
        '
        'harga
        '
        Me.harga.HeaderText = "Harga"
        Me.harga.Name = "harga"
        '
        'perubahan
        '
        Me.perubahan.HeaderText = "Perubahan"
        Me.perubahan.Name = "perubahan"
        '
        'cb
        '
        Me.cb.HeaderText = "Pilih"
        Me.cb.Name = "cb"
        '
        'ckPilihSemua
        '
        Me.ckPilihSemua.AutoSize = True
        Me.ckPilihSemua.Location = New System.Drawing.Point(748, 21)
        Me.ckPilihSemua.Name = "ckPilihSemua"
        Me.ckPilihSemua.Size = New System.Drawing.Size(81, 17)
        Me.ckPilihSemua.TabIndex = 4
        Me.ckPilihSemua.Text = "Pilih Semua"
        Me.ckPilihSemua.UseVisualStyleBackColor = True
        '
        'mnuKlikKanan
        '
        Me.mnuKlikKanan.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditHarga})
        Me.mnuKlikKanan.Name = "mnuKlikKanan"
        Me.mnuKlikKanan.Size = New System.Drawing.Size(130, 26)
        '
        'mnuEditHarga
        '
        Me.mnuEditHarga.Name = "mnuEditHarga"
        Me.mnuEditHarga.Size = New System.Drawing.Size(129, 22)
        Me.mnuEditHarga.Text = "Edit Harga"
        '
        'frmUpdateHargaPlatData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 424)
        Me.Controls.Add(Me.ckPilihSemua)
        Me.Controls.Add(Me.DgvData)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUpdateHargaPlatData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Harga Plat Data"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuKlikKanan.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtKodeKelompok As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpJam As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents DgvData As System.Windows.Forms.DataGridView
    Friend WithEvents ckPilihSemua As System.Windows.Forms.CheckBox
    Friend WithEvents mnuKlikKanan As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuEditHarga As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kodeKelompok As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nomorPlat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents harga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents perubahan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cb As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
