<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdatePotongan
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdatePotongan))
        Me.dgvPotongan = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.kdKelompok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.potongan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cb1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dtpTanggalDari = New System.Windows.Forms.DateTimePicker()
        Me.dtpTanggalSampai = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpdateHarga = New System.Windows.Forms.Button()
        Me.ckPilihSemua = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvPotongan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPotongan
        '
        Me.dgvPotongan.AllowUserToAddRows = False
        Me.dgvPotongan.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPotongan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPotongan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPotongan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kdKelompok, Me.potongan, Me.cb1})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPotongan.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPotongan.EnableHeadersVisualStyles = False
        Me.dgvPotongan.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvPotongan.Location = New System.Drawing.Point(1, 72)
        Me.dgvPotongan.Name = "dgvPotongan"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPotongan.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPotongan.RowHeadersVisible = False
        Me.dgvPotongan.Size = New System.Drawing.Size(357, 229)
        Me.dgvPotongan.TabIndex = 0
        '
        'kdKelompok
        '
        Me.kdKelompok.HeaderText = "Kode Kelompok"
        Me.kdKelompok.Name = "kdKelompok"
        Me.kdKelompok.Width = 170
        '
        'potongan
        '
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = "0"
        Me.potongan.DefaultCellStyle = DataGridViewCellStyle2
        Me.potongan.HeaderText = "Potongan"
        Me.potongan.Name = "potongan"
        '
        'cb1
        '
        Me.cb1.HeaderText = "Pilih"
        Me.cb1.Name = "cb1"
        Me.cb1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cb1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cb1.Width = 40
        '
        'dtpTanggalDari
        '
        Me.dtpTanggalDari.Location = New System.Drawing.Point(6, 18)
        Me.dtpTanggalDari.Name = "dtpTanggalDari"
        Me.dtpTanggalDari.Size = New System.Drawing.Size(154, 20)
        Me.dtpTanggalDari.TabIndex = 1
        '
        'dtpTanggalSampai
        '
        Me.dtpTanggalSampai.Location = New System.Drawing.Point(191, 18)
        Me.dtpTanggalSampai.Name = "dtpTanggalSampai"
        Me.dtpTanggalSampai.Size = New System.Drawing.Size(156, 20)
        Me.dtpTanggalSampai.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(171, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "-"
        '
        'btnUpdateHarga
        '
        Me.btnUpdateHarga.Location = New System.Drawing.Point(-1, 307)
        Me.btnUpdateHarga.Name = "btnUpdateHarga"
        Me.btnUpdateHarga.Size = New System.Drawing.Size(359, 42)
        Me.btnUpdateHarga.TabIndex = 4
        Me.btnUpdateHarga.Text = "Update Potongan Harga"
        Me.btnUpdateHarga.UseVisualStyleBackColor = True
        '
        'ckPilihSemua
        '
        Me.ckPilihSemua.AutoSize = True
        Me.ckPilihSemua.Location = New System.Drawing.Point(277, 54)
        Me.ckPilihSemua.Name = "ckPilihSemua"
        Me.ckPilihSemua.Size = New System.Drawing.Size(81, 17)
        Me.ckPilihSemua.TabIndex = 5
        Me.ckPilihSemua.Text = "Pilih Semua"
        Me.ckPilihSemua.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpTanggalDari)
        Me.GroupBox1.Controls.Add(Me.dtpTanggalSampai)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(-1, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(359, 49)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tanggal"
        '
        'frmUpdatePotongan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 350)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ckPilihSemua)
        Me.Controls.Add(Me.btnUpdateHarga)
        Me.Controls.Add(Me.dgvPotongan)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUpdatePotongan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Potongan"
        CType(Me.dgvPotongan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvPotongan As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents dtpTanggalDari As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTanggalSampai As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnUpdateHarga As System.Windows.Forms.Button
    Friend WithEvents kdKelompok As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents potongan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cb1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ckPilihSemua As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
