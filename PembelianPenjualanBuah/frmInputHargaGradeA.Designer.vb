<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInputHargaGradeA
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInputHargaGradeA))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.btnOke = New DevComponents.DotNetBar.ButtonX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.Tgl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbsMasuk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hargaRill = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.akkTbsMasuk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AkkHargaRill = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.akkHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cb2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgvTotalSekarang = New System.Windows.Forms.DataGridView()
        Me.tanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.netto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cb1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dtpTglAkhir = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTotalSekarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tanggal"
        '
        'dtpTanggal
        '
        Me.dtpTanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTanggal.Location = New System.Drawing.Point(97, 3)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(177, 22)
        Me.dtpTanggal.TabIndex = 1
        '
        'btnOke
        '
        Me.btnOke.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOke.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnOke.Location = New System.Drawing.Point(10, 31)
        Me.btnOke.Name = "btnOke"
        Me.btnOke.Size = New System.Drawing.Size(264, 33)
        Me.btnOke.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnOke.TabIndex = 63
        Me.btnOke.Text = "OK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 16)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = ":"
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tgl, Me.tbsMasuk, Me.hargaRill, Me.akkTbsMasuk, Me.AkkHargaRill, Me.harga, Me.akkHarga, Me.cb2})
        Me.dgvData.Location = New System.Drawing.Point(10, 76)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.RowHeadersVisible = False
        Me.dgvData.Size = New System.Drawing.Size(638, 193)
        Me.dgvData.TabIndex = 65
        '
        'Tgl
        '
        DataGridViewCellStyle1.Format = "D"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Tgl.DefaultCellStyle = DataGridViewCellStyle1
        Me.Tgl.HeaderText = "Tanggal"
        Me.Tgl.Name = "Tgl"
        Me.Tgl.ReadOnly = True
        '
        'tbsMasuk
        '
        Me.tbsMasuk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.NullValue = Nothing
        Me.tbsMasuk.DefaultCellStyle = DataGridViewCellStyle2
        Me.tbsMasuk.HeaderText = "TBS Masuk"
        Me.tbsMasuk.Name = "tbsMasuk"
        Me.tbsMasuk.ReadOnly = True
        Me.tbsMasuk.Width = 81
        '
        'hargaRill
        '
        Me.hargaRill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.NullValue = Nothing
        Me.hargaRill.DefaultCellStyle = DataGridViewCellStyle3
        Me.hargaRill.HeaderText = "Harga Rill"
        Me.hargaRill.Name = "hargaRill"
        Me.hargaRill.ReadOnly = True
        Me.hargaRill.Width = 72
        '
        'akkTbsMasuk
        '
        Me.akkTbsMasuk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.NullValue = Nothing
        Me.akkTbsMasuk.DefaultCellStyle = DataGridViewCellStyle4
        Me.akkTbsMasuk.HeaderText = "Akk. TBS Masuk"
        Me.akkTbsMasuk.Name = "akkTbsMasuk"
        Me.akkTbsMasuk.ReadOnly = True
        Me.akkTbsMasuk.Width = 104
        '
        'AkkHargaRill
        '
        Me.AkkHargaRill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.NullValue = Nothing
        Me.AkkHargaRill.DefaultCellStyle = DataGridViewCellStyle5
        Me.AkkHargaRill.HeaderText = "Akk. Harga Rill"
        Me.AkkHargaRill.Name = "AkkHargaRill"
        Me.AkkHargaRill.ReadOnly = True
        Me.AkkHargaRill.Width = 82
        '
        'harga
        '
        Me.harga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.NullValue = Nothing
        Me.harga.DefaultCellStyle = DataGridViewCellStyle6
        Me.harga.HeaderText = "Harga"
        Me.harga.Name = "harga"
        Me.harga.ReadOnly = True
        Me.harga.Width = 61
        '
        'akkHarga
        '
        Me.akkHarga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.NullValue = Nothing
        Me.akkHarga.DefaultCellStyle = DataGridViewCellStyle7
        Me.akkHarga.HeaderText = "Akk. Harga"
        Me.akkHarga.Name = "akkHarga"
        Me.akkHarga.ReadOnly = True
        Me.akkHarga.Width = 79
        '
        'cb2
        '
        Me.cb2.HeaderText = "pilih"
        Me.cb2.Name = "cb2"
        Me.cb2.ReadOnly = True
        Me.cb2.Visible = False
        '
        'dgvTotalSekarang
        '
        Me.dgvTotalSekarang.AllowUserToAddRows = False
        Me.dgvTotalSekarang.AllowUserToDeleteRows = False
        Me.dgvTotalSekarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTotalSekarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tanggal, Me.netto, Me.total, Me.cb1})
        Me.dgvTotalSekarang.Location = New System.Drawing.Point(663, 75)
        Me.dgvTotalSekarang.Name = "dgvTotalSekarang"
        Me.dgvTotalSekarang.ReadOnly = True
        Me.dgvTotalSekarang.RowHeadersVisible = False
        Me.dgvTotalSekarang.Size = New System.Drawing.Size(388, 193)
        Me.dgvTotalSekarang.TabIndex = 66
        '
        'tanggal
        '
        DataGridViewCellStyle8.Format = "D"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.tanggal.DefaultCellStyle = DataGridViewCellStyle8
        Me.tanggal.HeaderText = "Tanggal"
        Me.tanggal.Name = "tanggal"
        Me.tanggal.ReadOnly = True
        '
        'netto
        '
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.netto.DefaultCellStyle = DataGridViewCellStyle9
        Me.netto.HeaderText = "Netto"
        Me.netto.Name = "netto"
        Me.netto.ReadOnly = True
        '
        'total
        '
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.total.DefaultCellStyle = DataGridViewCellStyle10
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'cb1
        '
        Me.cb1.HeaderText = "pilih"
        Me.cb1.Name = "cb1"
        Me.cb1.ReadOnly = True
        Me.cb1.Visible = False
        '
        'dtpTglAkhir
        '
        Me.dtpTglAkhir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTglAkhir.Location = New System.Drawing.Point(320, 3)
        Me.dtpTglAkhir.Name = "dtpTglAkhir"
        Me.dtpTglAkhir.Size = New System.Drawing.Size(177, 22)
        Me.dtpTglAkhir.TabIndex = 67
        '
        'frmInputHargaGradeA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 69)
        Me.Controls.Add(Me.dtpTglAkhir)
        Me.Controls.Add(Me.dgvTotalSekarang)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnOke)
        Me.Controls.Add(Me.dtpTanggal)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInputHargaGradeA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Harga Grade A"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTotalSekarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnOke As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents dgvTotalSekarang As System.Windows.Forms.DataGridView
    Friend WithEvents tanggal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents netto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cb1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents dtpTglAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Tgl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tbsMasuk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hargaRill As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents akkTbsMasuk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AkkHargaRill As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents harga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents akkHarga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cb2 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
