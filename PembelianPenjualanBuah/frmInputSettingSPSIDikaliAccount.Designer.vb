<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInputSettingSPSIDikaliAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInputSettingSPSIDikaliAccount))
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtKelompok = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtSPSI = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnCariKelompok = New DevComponents.DotNetBar.ButtonX()
        Me.btnOk = New DevComponents.DotNetBar.ButtonX()
        Me.btnBatal = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(12, 9)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 2
        Me.LabelX3.Text = "Kelompok"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(12, 39)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(75, 23)
        Me.LabelX4.TabIndex = 3
        Me.LabelX4.Text = "SPSI"
        '
        'txtKelompok
        '
        '
        '
        '
        Me.txtKelompok.Border.Class = "TextBoxBorder"
        Me.txtKelompok.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtKelompok.Enabled = False
        Me.txtKelompok.Location = New System.Drawing.Point(84, 12)
        Me.txtKelompok.Name = "txtKelompok"
        Me.txtKelompok.Size = New System.Drawing.Size(150, 20)
        Me.txtKelompok.TabIndex = 4
        '
        'txtSPSI
        '
        '
        '
        '
        Me.txtSPSI.Border.Class = "TextBoxBorder"
        Me.txtSPSI.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSPSI.Location = New System.Drawing.Point(84, 42)
        Me.txtSPSI.Name = "txtSPSI"
        Me.txtSPSI.Size = New System.Drawing.Size(196, 20)
        Me.txtSPSI.TabIndex = 5
        '
        'btnCariKelompok
        '
        Me.btnCariKelompok.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCariKelompok.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCariKelompok.Location = New System.Drawing.Point(239, 12)
        Me.btnCariKelompok.Name = "btnCariKelompok"
        Me.btnCariKelompok.Size = New System.Drawing.Size(41, 23)
        Me.btnCariKelompok.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCariKelompok.TabIndex = 6
        Me.btnCariKelompok.Text = "---"
        '
        'btnOk
        '
        Me.btnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnOk.Location = New System.Drawing.Point(12, 71)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(66, 31)
        Me.btnOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnOk.TabIndex = 7
        Me.btnOk.Text = "&Oke"
        '
        'btnBatal
        '
        Me.btnBatal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBatal.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBatal.Location = New System.Drawing.Point(84, 71)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(66, 31)
        Me.btnBatal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBatal.TabIndex = 8
        Me.btnBatal.Text = "&Batal"
        '
        'frmInputSettingSPSIDikaliAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 119)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCariKelompok)
        Me.Controls.Add(Me.txtSPSI)
        Me.Controls.Add(Me.txtKelompok)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInputSettingSPSIDikaliAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Setting SPSI Dikali Account"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtKelompok As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtSPSI As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnCariKelompok As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnOk As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnBatal As DevComponents.DotNetBar.ButtonX
End Class
