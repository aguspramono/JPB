<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPJMLdanSejenis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPJMLdanSejenis))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpSampai = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDari = New System.Windows.Forms.DateTimePicker()
        Me.btnUpdateHarga = New System.Windows.Forms.Button()
        Me.dgvHitung = New System.Windows.Forms.DataGridView()
        Me.NoAcc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vehicle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hargaAsli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hargaAkhir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cb = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvHitung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpSampai)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpDari)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(439, 42)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tanggal"
        '
        'dtpSampai
        '
        Me.dtpSampai.Location = New System.Drawing.Point(228, 16)
        Me.dtpSampai.Name = "dtpSampai"
        Me.dtpSampai.Size = New System.Drawing.Size(200, 20)
        Me.dtpSampai.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(213, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "-"
        '
        'dtpDari
        '
        Me.dtpDari.Location = New System.Drawing.Point(8, 16)
        Me.dtpDari.Name = "dtpDari"
        Me.dtpDari.Size = New System.Drawing.Size(200, 20)
        Me.dtpDari.TabIndex = 0
        '
        'btnUpdateHarga
        '
        Me.btnUpdateHarga.Location = New System.Drawing.Point(443, 9)
        Me.btnUpdateHarga.Name = "btnUpdateHarga"
        Me.btnUpdateHarga.Size = New System.Drawing.Size(60, 37)
        Me.btnUpdateHarga.TabIndex = 1
        Me.btnUpdateHarga.Text = "&Cek Data"
        Me.btnUpdateHarga.UseVisualStyleBackColor = True
        '
        'dgvHitung
        '
        Me.dgvHitung.AllowUserToAddRows = False
        Me.dgvHitung.AllowUserToDeleteRows = False
        Me.dgvHitung.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvHitung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHitung.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoAcc, Me.tanggal, Me.vehicle, Me.Column8, Me.Column10, Me.hargaAsli, Me.Column9, Me.hargaAkhir, Me.total, Me.cb})
        Me.dgvHitung.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvHitung.Location = New System.Drawing.Point(0, 59)
        Me.dgvHitung.Name = "dgvHitung"
        Me.dgvHitung.ReadOnly = True
        Me.dgvHitung.RowHeadersVisible = False
        Me.dgvHitung.Size = New System.Drawing.Size(946, 329)
        Me.dgvHitung.TabIndex = 14
        '
        'NoAcc
        '
        Me.NoAcc.HeaderText = "noAcc"
        Me.NoAcc.Name = "NoAcc"
        Me.NoAcc.ReadOnly = True
        Me.NoAcc.Visible = False
        '
        'tanggal
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.tanggal.DefaultCellStyle = DataGridViewCellStyle1
        Me.tanggal.HeaderText = "Tanggal"
        Me.tanggal.Name = "tanggal"
        Me.tanggal.ReadOnly = True
        '
        'vehicle
        '
        Me.vehicle.HeaderText = "Vehicle"
        Me.vehicle.Name = "vehicle"
        Me.vehicle.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Nama"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "Netto"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'hargaAsli
        '
        Me.hargaAsli.HeaderText = "Harga"
        Me.hargaAsli.Name = "hargaAsli"
        Me.hargaAsli.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "round"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'hargaAkhir
        '
        Me.hargaAkhir.HeaderText = "(Harga+Round)"
        Me.hargaAkhir.Name = "hargaAkhir"
        Me.hargaAkhir.ReadOnly = True
        '
        'total
        '
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.total.DefaultCellStyle = DataGridViewCellStyle2
        Me.total.HeaderText = "Netto*(Harga+Round)"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Width = 150
        '
        'cb
        '
        Me.cb.HeaderText = ""
        Me.cb.Name = "cb"
        Me.cb.ReadOnly = True
        Me.cb.Visible = False
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(506, 9)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(87, 37)
        Me.btnOk.TabIndex = 15
        Me.btnOk.Text = "&Update Harga"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'frmPJMLdanSejenis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 388)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.dgvHitung)
        Me.Controls.Add(Me.btnUpdateHarga)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPJMLdanSejenis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PJML dan Sejenis"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvHitung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpSampai As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDari As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnUpdateHarga As System.Windows.Forms.Button
    Friend WithEvents dgvHitung As System.Windows.Forms.DataGridView
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents NoAcc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tanggal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vehicle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hargaAsli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hargaAkhir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cb As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
