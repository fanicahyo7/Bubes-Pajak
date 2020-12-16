<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.JurnalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditJurnalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KodeAkunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JurnalToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(568, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'JurnalToolStripMenuItem
        '
        Me.JurnalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditJurnalToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.KodeAkunToolStripMenuItem})
        Me.JurnalToolStripMenuItem.Name = "JurnalToolStripMenuItem"
        Me.JurnalToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.JurnalToolStripMenuItem.Text = "Jurnal"
        '
        'EditJurnalToolStripMenuItem
        '
        Me.EditJurnalToolStripMenuItem.Name = "EditJurnalToolStripMenuItem"
        Me.EditJurnalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditJurnalToolStripMenuItem.Text = "Edit Jurnal"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'KodeAkunToolStripMenuItem
        '
        Me.KodeAkunToolStripMenuItem.Name = "KodeAkunToolStripMenuItem"
        Me.KodeAkunToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.KodeAkunToolStripMenuItem.Text = "Kode Akun"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 305)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMenu"
        Me.Text = "frmMenu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents JurnalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditJurnalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KodeAkunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
