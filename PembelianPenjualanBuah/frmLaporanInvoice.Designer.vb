<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaporanInvoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLaporanInvoice))
        Me.dtHTglAkhir = New System.Windows.Forms.DateTimePicker()
        Me.dtHTglAwal = New System.Windows.Forms.DateTimePicker()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.btnLaporanH = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.cboTipe = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.cboOrder = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem9 = New DevComponents.Editors.ComboItem()
        Me.ComboItem10 = New DevComponents.Editors.ComboItem()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.btnInvoiceDetail = New DevComponents.DotNetBar.ButtonX()
        Me.chkSisa = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.SuspendLayout()
        '
        'dtHTglAkhir
        '
        Me.dtHTglAkhir.Location = New System.Drawing.Point(84, 38)
        Me.dtHTglAkhir.Name = "dtHTglAkhir"
        Me.dtHTglAkhir.Size = New System.Drawing.Size(196, 20)
        Me.dtHTglAkhir.TabIndex = 22
        '
        'dtHTglAwal
        '
        Me.dtHTglAwal.Location = New System.Drawing.Point(84, 12)
        Me.dtHTglAwal.Name = "dtHTglAwal"
        Me.dtHTglAwal.Size = New System.Drawing.Size(196, 20)
        Me.dtHTglAwal.TabIndex = 21
        '
        'LabelX13
        '
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.Location = New System.Drawing.Point(68, 9)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(10, 23)
        Me.LabelX13.TabIndex = 17
        Me.LabelX13.Text = ":"
        '
        'btnLaporanH
        '
        Me.btnLaporanH.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLaporanH.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnLaporanH.Location = New System.Drawing.Point(34, 145)
        Me.btnLaporanH.Name = "btnLaporanH"
        Me.btnLaporanH.Size = New System.Drawing.Size(75, 23)
        Me.btnLaporanH.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnLaporanH.TabIndex = 16
        Me.btnLaporanH.Text = "Invoice"
        '
        'LabelX14
        '
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.Location = New System.Drawing.Point(5, 9)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(57, 23)
        Me.LabelX14.TabIndex = 15
        Me.LabelX14.Text = "Tgl"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(68, 61)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(10, 23)
        Me.LabelX1.TabIndex = 25
        Me.LabelX1.Text = ":"
        '
        'cboTipe
        '
        Me.cboTipe.DisplayMember = "Text"
        Me.cboTipe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipe.FormattingEnabled = True
        Me.cboTipe.ItemHeight = 14
        Me.cboTipe.Items.AddRange(New Object() {Me.ComboItem3, Me.ComboItem4, Me.ComboItem5, Me.ComboItem6})
        Me.cboTipe.Location = New System.Drawing.Point(84, 64)
        Me.cboTipe.Name = "cboTipe"
        Me.cboTipe.Size = New System.Drawing.Size(196, 20)
        Me.cboTipe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboTipe.TabIndex = 24
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "All"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "TBS"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "FEE"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "Belum ada Kode Pembayaran"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(5, 61)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(57, 23)
        Me.LabelX2.TabIndex = 23
        Me.LabelX2.Text = "View"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(68, 87)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(10, 23)
        Me.LabelX3.TabIndex = 28
        Me.LabelX3.Text = ":"
        '
        'cboOrder
        '
        Me.cboOrder.DisplayMember = "Text"
        Me.cboOrder.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOrder.FormattingEnabled = True
        Me.cboOrder.ItemHeight = 14
        Me.cboOrder.Items.AddRange(New Object() {Me.ComboItem9, Me.ComboItem10})
        Me.cboOrder.Location = New System.Drawing.Point(84, 90)
        Me.cboOrder.Name = "cboOrder"
        Me.cboOrder.Size = New System.Drawing.Size(196, 20)
        Me.cboOrder.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboOrder.TabIndex = 27
        '
        'ComboItem9
        '
        Me.ComboItem9.Text = "No Invoice"
        '
        'ComboItem10
        '
        Me.ComboItem10.Text = "No Account"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(5, 87)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(57, 23)
        Me.LabelX4.TabIndex = 26
        Me.LabelX4.Text = "Order By"
        '
        'btnInvoiceDetail
        '
        Me.btnInvoiceDetail.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnInvoiceDetail.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnInvoiceDetail.Location = New System.Drawing.Point(115, 145)
        Me.btnInvoiceDetail.Name = "btnInvoiceDetail"
        Me.btnInvoiceDetail.Size = New System.Drawing.Size(75, 23)
        Me.btnInvoiceDetail.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnInvoiceDetail.TabIndex = 29
        Me.btnInvoiceDetail.Text = "Detail"
        '
        'chkSisa
        '
        '
        '
        '
        Me.chkSisa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chkSisa.Location = New System.Drawing.Point(84, 116)
        Me.chkSisa.Name = "chkSisa"
        Me.chkSisa.Size = New System.Drawing.Size(100, 23)
        Me.chkSisa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chkSisa.TabIndex = 30
        Me.chkSisa.Text = "Sisa>0"
        '
        'frmLaporanInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 183)
        Me.Controls.Add(Me.chkSisa)
        Me.Controls.Add(Me.btnInvoiceDetail)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.cboOrder)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.cboTipe)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.dtHTglAkhir)
        Me.Controls.Add(Me.dtHTglAwal)
        Me.Controls.Add(Me.LabelX13)
        Me.Controls.Add(Me.btnLaporanH)
        Me.Controls.Add(Me.LabelX14)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLaporanInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Invoice"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtHTglAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtHTglAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnLaporanH As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboTipe As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cboOrder As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboItem9 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem10 As DevComponents.Editors.ComboItem
    Friend WithEvents btnInvoiceDetail As DevComponents.DotNetBar.ButtonX
    Friend WithEvents chkSisa As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
