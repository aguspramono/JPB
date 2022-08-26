<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKelompokFeeEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKelompokFeeEdit))
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.txtFee = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnOk = New DevComponents.DotNetBar.ButtonX()
        Me.txtKeterangan = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtKodeFee = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ckAktif = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.SuspendLayout()
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(120, 7)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(10, 23)
        Me.LabelX6.TabIndex = 51
        Me.LabelX6.Text = ":"
        '
        'txtFee
        '
        Me.txtFee.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtFee.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtFee.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtFee.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtFee.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtFee.Border.Class = "TextBoxBorder"
        Me.txtFee.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFee.ForeColor = System.Drawing.Color.Black
        Me.txtFee.Location = New System.Drawing.Point(136, 10)
        Me.txtFee.Name = "txtFee"
        Me.txtFee.Size = New System.Drawing.Size(128, 22)
        Me.txtFee.TabIndex = 49
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(12, 8)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(63, 23)
        Me.LabelX1.TabIndex = 50
        Me.LabelX1.Text = "Fee"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(120, 34)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(10, 23)
        Me.LabelX5.TabIndex = 56
        Me.LabelX5.Text = ":"
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Location = New System.Drawing.Point(84, 89)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(66, 44)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 54
        Me.btnCancel.Text = "Cancel"
        '
        'btnOk
        '
        Me.btnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnOk.Location = New System.Drawing.Point(12, 89)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(66, 44)
        Me.btnOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnOk.TabIndex = 53
        Me.btnOk.Text = "Ok"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtKeterangan.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtKeterangan.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtKeterangan.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtKeterangan.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtKeterangan.Border.Class = "TextBoxBorder"
        Me.txtKeterangan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtKeterangan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeterangan.ForeColor = System.Drawing.Color.Black
        Me.txtKeterangan.Location = New System.Drawing.Point(136, 37)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(128, 22)
        Me.txtKeterangan.TabIndex = 52
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(12, 34)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(102, 23)
        Me.LabelX4.TabIndex = 55
        Me.LabelX4.Text = "Keterangan"
        '
        'txtKodeFee
        '
        Me.txtKodeFee.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtKodeFee.Border.Class = "TextBoxBorder"
        Me.txtKodeFee.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtKodeFee.ForeColor = System.Drawing.Color.Black
        Me.txtKodeFee.Location = New System.Drawing.Point(156, 89)
        Me.txtKodeFee.Name = "txtKodeFee"
        Me.txtKodeFee.Size = New System.Drawing.Size(19, 20)
        Me.txtKodeFee.TabIndex = 57
        Me.txtKodeFee.Visible = False
        '
        'ckAktif
        '
        '
        '
        '
        Me.ckAktif.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ckAktif.Location = New System.Drawing.Point(136, 64)
        Me.ckAktif.Name = "ckAktif"
        Me.ckAktif.Size = New System.Drawing.Size(100, 23)
        Me.ckAktif.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ckAktif.TabIndex = 58
        Me.ckAktif.Text = "Aktif"
        '
        'frmKelompokFeeEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 159)
        Me.Controls.Add(Me.ckAktif)
        Me.Controls.Add(Me.txtFee)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.txtKodeFee)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtKeterangan)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKelompokFeeEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FeeEdit"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtFee As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnOk As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtKeterangan As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtKodeFee As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ckAktif As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
