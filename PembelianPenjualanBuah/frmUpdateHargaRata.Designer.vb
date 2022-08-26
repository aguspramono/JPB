<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateHargaRata
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdateHargaRata))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.btnUpdateHarga = New System.Windows.Forms.Button()
        Me.dtpAkhir = New System.Windows.Forms.DateTimePicker()
        Me.dtpAwal = New System.Windows.Forms.DateTimePicker()
        Me.dgvKodeKelompok = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvKodeKelompok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tanggal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = ":"
        '
        'dtpTanggal
        '
        Me.dtpTanggal.Location = New System.Drawing.Point(88, 7)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(200, 20)
        Me.dtpTanggal.TabIndex = 2
        '
        'btnUpdateHarga
        '
        Me.btnUpdateHarga.Location = New System.Drawing.Point(9, 32)
        Me.btnUpdateHarga.Name = "btnUpdateHarga"
        Me.btnUpdateHarga.Size = New System.Drawing.Size(279, 37)
        Me.btnUpdateHarga.TabIndex = 3
        Me.btnUpdateHarga.Text = "Update Harga"
        Me.btnUpdateHarga.UseVisualStyleBackColor = True
        '
        'dtpAkhir
        '
        Me.dtpAkhir.Location = New System.Drawing.Point(310, 12)
        Me.dtpAkhir.Name = "dtpAkhir"
        Me.dtpAkhir.Size = New System.Drawing.Size(200, 20)
        Me.dtpAkhir.TabIndex = 4
        '
        'dtpAwal
        '
        Me.dtpAwal.Location = New System.Drawing.Point(310, 44)
        Me.dtpAwal.Name = "dtpAwal"
        Me.dtpAwal.Size = New System.Drawing.Size(200, 20)
        Me.dtpAwal.TabIndex = 5
        '
        'dgvKodeKelompok
        '
        Me.dgvKodeKelompok.AllowUserToAddRows = False
        Me.dgvKodeKelompok.AllowUserToDeleteRows = False
        Me.dgvKodeKelompok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKodeKelompok.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.dgvKodeKelompok.Location = New System.Drawing.Point(12, 80)
        Me.dgvKodeKelompok.Name = "dgvKodeKelompok"
        Me.dgvKodeKelompok.ReadOnly = True
        Me.dgvKodeKelompok.RowHeadersVisible = False
        Me.dgvKodeKelompok.Size = New System.Drawing.Size(240, 131)
        Me.dgvKodeKelompok.TabIndex = 6
        Me.dgvKodeKelompok.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "KodeKelompok"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'frmUpdateHargaRata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 73)
        Me.Controls.Add(Me.dgvKodeKelompok)
        Me.Controls.Add(Me.dtpAwal)
        Me.Controls.Add(Me.dtpAkhir)
        Me.Controls.Add(Me.btnUpdateHarga)
        Me.Controls.Add(Me.dtpTanggal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUpdateHargaRata"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Harga Rata-Rata"
        CType(Me.dgvKodeKelompok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnUpdateHarga As System.Windows.Forms.Button
    Friend WithEvents dtpAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvKodeKelompok As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
