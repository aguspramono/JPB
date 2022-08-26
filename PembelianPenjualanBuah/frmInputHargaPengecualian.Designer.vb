<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInputHargaPengecualian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInputHargaPengecualian))
        Me.dtTglAwal = New System.Windows.Forms.DateTimePicker()
        Me.dtTanggalAkhir = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvHarga = New System.Windows.Forms.DataGridView()
        Me.kdKelompok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cb = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.ckPilihSemua = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvHarga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtTglAwal
        '
        Me.dtTglAwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTglAwal.Location = New System.Drawing.Point(6, 19)
        Me.dtTglAwal.Name = "dtTglAwal"
        Me.dtTglAwal.Size = New System.Drawing.Size(183, 22)
        Me.dtTglAwal.TabIndex = 82
        '
        'dtTanggalAkhir
        '
        Me.dtTanggalAkhir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTanggalAkhir.Location = New System.Drawing.Point(195, 19)
        Me.dtTanggalAkhir.Name = "dtTanggalAkhir"
        Me.dtTanggalAkhir.Size = New System.Drawing.Size(162, 22)
        Me.dtTanggalAkhir.TabIndex = 83
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtTglAwal)
        Me.GroupBox1.Controls.Add(Me.dtTanggalAkhir)
        Me.GroupBox1.Location = New System.Drawing.Point(4, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 50)
        Me.GroupBox1.TabIndex = 86
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tanggal"
        '
        'dgvHarga
        '
        Me.dgvHarga.AllowUserToAddRows = False
        Me.dgvHarga.AllowUserToDeleteRows = False
        Me.dgvHarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHarga.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kdKelompok, Me.harga, Me.cb})
        Me.dgvHarga.Location = New System.Drawing.Point(4, 74)
        Me.dgvHarga.Name = "dgvHarga"
        Me.dgvHarga.Size = New System.Drawing.Size(368, 193)
        Me.dgvHarga.TabIndex = 87
        '
        'kdKelompok
        '
        Me.kdKelompok.HeaderText = "kodeKelompok"
        Me.kdKelompok.Name = "kdKelompok"
        '
        'harga
        '
        Me.harga.HeaderText = "Harga"
        Me.harga.Name = "harga"
        '
        'cb
        '
        Me.cb.HeaderText = "Pilih"
        Me.cb.Name = "cb"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(4, 269)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(368, 45)
        Me.btnUpdate.TabIndex = 88
        Me.btnUpdate.Text = "OK"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'ckPilihSemua
        '
        Me.ckPilihSemua.AutoSize = True
        Me.ckPilihSemua.Location = New System.Drawing.Point(285, 53)
        Me.ckPilihSemua.Name = "ckPilihSemua"
        Me.ckPilihSemua.Size = New System.Drawing.Size(81, 17)
        Me.ckPilihSemua.TabIndex = 89
        Me.ckPilihSemua.Text = "Pilih Semua"
        Me.ckPilihSemua.UseVisualStyleBackColor = True
        '
        'frmInputHargaPengecualian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 319)
        Me.Controls.Add(Me.ckPilihSemua)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.dgvHarga)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInputHargaPengecualian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Harga Pengecualian"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvHarga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtTglAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtTanggalAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvHarga As System.Windows.Forms.DataGridView
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents ckPilihSemua As System.Windows.Forms.CheckBox
    Friend WithEvents kdKelompok As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents harga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cb As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
