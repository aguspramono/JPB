<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettingDatabase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettingDatabase))
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.lblNamaDatabase = New DevComponents.DotNetBar.LabelX()
        Me.lblDbBaru = New DevComponents.DotNetBar.LabelX()
        Me.btnCari = New DevComponents.DotNetBar.ButtonX()
        Me.txtPath = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnKoneksi = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.lblNamaDatabase)
        Me.GroupPanel1.Controls.Add(Me.lblDbBaru)
        Me.GroupPanel1.Controls.Add(Me.btnCari)
        Me.GroupPanel1.Controls.Add(Me.txtPath)
        Me.GroupPanel1.Location = New System.Drawing.Point(5, 1)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(319, 64)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 0
        Me.GroupPanel1.Text = "Setting Database"
        '
        'lblNamaDatabase
        '
        '
        '
        '
        Me.lblNamaDatabase.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblNamaDatabase.Location = New System.Drawing.Point(109, -2)
        Me.lblNamaDatabase.Name = "lblNamaDatabase"
        Me.lblNamaDatabase.Size = New System.Drawing.Size(93, 10)
        Me.lblNamaDatabase.TabIndex = 3
        Me.lblNamaDatabase.Text = "HTD.mdb"
        Me.lblNamaDatabase.Visible = False
        '
        'lblDbBaru
        '
        '
        '
        '
        Me.lblDbBaru.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblDbBaru.Location = New System.Drawing.Point(267, -5)
        Me.lblDbBaru.Name = "lblDbBaru"
        Me.lblDbBaru.Size = New System.Drawing.Size(44, 13)
        Me.lblDbBaru.TabIndex = 2
        Me.lblDbBaru.Visible = False
        '
        'btnCari
        '
        Me.btnCari.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCari.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCari.Location = New System.Drawing.Point(272, 9)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(38, 23)
        Me.btnCari.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCari.TabIndex = 1
        Me.btnCari.Text = "..."
        '
        'txtPath
        '
        '
        '
        '
        Me.txtPath.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtPath.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtPath.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtPath.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.[Double]
        Me.txtPath.Border.Class = "TextBoxBorder"
        Me.txtPath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPath.Location = New System.Drawing.Point(4, 10)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(262, 22)
        Me.txtPath.TabIndex = 0
        '
        'btnKoneksi
        '
        Me.btnKoneksi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnKoneksi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnKoneksi.Location = New System.Drawing.Point(5, 70)
        Me.btnKoneksi.Name = "btnKoneksi"
        Me.btnKoneksi.Size = New System.Drawing.Size(319, 34)
        Me.btnKoneksi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnKoneksi.TabIndex = 1
        Me.btnKoneksi.Text = "KONEKSIKAN"
        '
        'frmSettingDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 123)
        Me.Controls.Add(Me.btnKoneksi)
        Me.Controls.Add(Me.GroupPanel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettingDatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setting Database"
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnCari As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtPath As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnKoneksi As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblDbBaru As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblNamaDatabase As DevComponents.DotNetBar.LabelX
End Class
