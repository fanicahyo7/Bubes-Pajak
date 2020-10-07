<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstKodeAkun
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMstKodeAkun))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.tKodeCabang = New DevExpress.XtraEditors.TextEdit()
        Me.btnSimpan = New DevExpress.XtraEditors.SimpleButton()
        Me.sLevelAkun = New DevExpress.XtraEditors.SpinEdit()
        Me.cStatusJurnal = New DevExpress.XtraEditors.CheckEdit()
        Me.btnKeluar = New DevExpress.XtraEditors.SimpleButton()
        Me.cKodeAkunInduk = New meCore.cMeButtonBrowser()
        Me.CMeButtonBrowser2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.rDebetOrKredit = New DevExpress.XtraEditors.RadioGroup()
        Me.tKeterangan = New DevExpress.XtraEditors.TextEdit()
        Me.tKodeAkun = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.tKodeCabang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sLevelAkun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cStatusJurnal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cKodeAkunInduk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMeButtonBrowser2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rDebetOrKredit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tKeterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tKodeAkun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.tKodeCabang)
        Me.LayoutControl1.Controls.Add(Me.btnSimpan)
        Me.LayoutControl1.Controls.Add(Me.sLevelAkun)
        Me.LayoutControl1.Controls.Add(Me.cStatusJurnal)
        Me.LayoutControl1.Controls.Add(Me.btnKeluar)
        Me.LayoutControl1.Controls.Add(Me.cKodeAkunInduk)
        Me.LayoutControl1.Controls.Add(Me.rDebetOrKredit)
        Me.LayoutControl1.Controls.Add(Me.tKeterangan)
        Me.LayoutControl1.Controls.Add(Me.tKodeAkun)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(478, 212)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'tKodeCabang
        '
        Me.tKodeCabang.Location = New System.Drawing.Point(234, 136)
        Me.tKodeCabang.Name = "tKodeCabang"
        Me.tKodeCabang.Size = New System.Drawing.Size(105, 20)
        Me.tKodeCabang.StyleController = Me.LayoutControl1
        Me.tKodeCabang.TabIndex = 18
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = CType(resources.GetObject("btnSimpan.Image"), System.Drawing.Image)
        Me.btnSimpan.Location = New System.Drawing.Point(240, 160)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(99, 38)
        Me.btnSimpan.StyleController = Me.LayoutControl1
        Me.btnSimpan.TabIndex = 17
        Me.btnSimpan.Text = "Simpan"
        '
        'sLevelAkun
        '
        Me.sLevelAkun.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.sLevelAkun.Location = New System.Drawing.Point(96, 136)
        Me.sLevelAkun.Name = "sLevelAkun"
        Me.sLevelAkun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sLevelAkun.Size = New System.Drawing.Size(50, 20)
        Me.sLevelAkun.StyleController = Me.LayoutControl1
        Me.sLevelAkun.TabIndex = 16
        '
        'cStatusJurnal
        '
        Me.cStatusJurnal.Location = New System.Drawing.Point(12, 12)
        Me.cStatusJurnal.Name = "cStatusJurnal"
        Me.cStatusJurnal.Properties.Caption = "Status Jurnal"
        Me.cStatusJurnal.Size = New System.Drawing.Size(454, 19)
        Me.cStatusJurnal.StyleController = Me.LayoutControl1
        Me.cStatusJurnal.TabIndex = 15
        '
        'btnKeluar
        '
        Me.btnKeluar.Image = CType(resources.GetObject("btnKeluar.Image"), System.Drawing.Image)
        Me.btnKeluar.Location = New System.Drawing.Point(343, 160)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(106, 38)
        Me.btnKeluar.StyleController = Me.LayoutControl1
        Me.btnKeluar.TabIndex = 14
        Me.btnKeluar.Text = "Keluar"
        '
        'cKodeAkunInduk
        '
        Me.cKodeAkunInduk.Location = New System.Drawing.Point(96, 112)
        Me.cKodeAkunInduk.Name = "cKodeAkunInduk"
        Me.cKodeAkunInduk.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cKodeAkunInduk.Properties.NullText = ""
        Me.cKodeAkunInduk.Properties.View = Me.CMeButtonBrowser2View
        Me.cKodeAkunInduk.Size = New System.Drawing.Size(132, 20)
        Me.cKodeAkunInduk.StyleController = Me.LayoutControl1
        Me.cKodeAkunInduk.TabIndex = 13
        '
        'CMeButtonBrowser2View
        '
        Me.CMeButtonBrowser2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.CMeButtonBrowser2View.Name = "CMeButtonBrowser2View"
        Me.CMeButtonBrowser2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.CMeButtonBrowser2View.OptionsView.ShowGroupPanel = False
        '
        'rDebetOrKredit
        '
        Me.rDebetOrKredit.Location = New System.Drawing.Point(96, 83)
        Me.rDebetOrKredit.Name = "rDebetOrKredit"
        Me.rDebetOrKredit.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(0, Short), "Debet"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Short), "Kredit")})
        Me.rDebetOrKredit.Size = New System.Drawing.Size(132, 25)
        Me.rDebetOrKredit.StyleController = Me.LayoutControl1
        Me.rDebetOrKredit.TabIndex = 11
        '
        'tKeterangan
        '
        Me.tKeterangan.Location = New System.Drawing.Point(96, 59)
        Me.tKeterangan.Name = "tKeterangan"
        Me.tKeterangan.Size = New System.Drawing.Size(370, 20)
        Me.tKeterangan.StyleController = Me.LayoutControl1
        Me.tKeterangan.TabIndex = 9
        '
        'tKodeAkun
        '
        Me.tKodeAkun.Location = New System.Drawing.Point(96, 35)
        Me.tKodeAkun.Name = "tKodeAkun"
        Me.tKodeAkun.Size = New System.Drawing.Size(133, 20)
        Me.tKodeAkun.StyleController = Me.LayoutControl1
        Me.tKodeAkun.TabIndex = 7
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem6, Me.LayoutControlItem8, Me.LayoutControlItem10, Me.LayoutControlItem1, Me.LayoutControlItem9, Me.EmptySpaceItem2, Me.EmptySpaceItem1, Me.EmptySpaceItem3, Me.LayoutControlItem2, Me.EmptySpaceItem4, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.EmptySpaceItem5})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(478, 212)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.tKodeAkun
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 23)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(221, 24)
        Me.LayoutControlItem4.Text = "Kode Akun"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.tKeterangan
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 47)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(458, 24)
        Me.LayoutControlItem6.Text = "Keterangan"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.rDebetOrKredit
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 71)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(220, 29)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(220, 29)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(220, 29)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.Text = "Debet or Kredit"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cKodeAkunInduk
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 100)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(220, 24)
        Me.LayoutControlItem10.Text = "Kode Akun Induk"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.btnKeluar
        Me.LayoutControlItem1.Location = New System.Drawing.Point(331, 148)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(110, 42)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(127, 44)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cStatusJurnal
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(458, 23)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(221, 23)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(237, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(220, 71)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(238, 29)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(220, 100)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(238, 24)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.sLevelAkun
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 124)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(138, 24)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(138, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(138, 24)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Level Akun"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(81, 13)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(331, 124)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(127, 24)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.btnSimpan
        Me.LayoutControlItem3.Location = New System.Drawing.Point(228, 148)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(103, 42)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(103, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(103, 44)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.tKodeCabang
        Me.LayoutControlItem5.Location = New System.Drawing.Point(138, 124)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(193, 24)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(193, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(193, 24)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "     Kode Cabang"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(81, 13)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(0, 148)
        Me.EmptySpaceItem5.MaxSize = New System.Drawing.Size(228, 42)
        Me.EmptySpaceItem5.MinSize = New System.Drawing.Size(228, 42)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(228, 44)
        Me.EmptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmMstKodeAkun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 212)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmMstKodeAkun"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMstKodeAkun"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.tKodeCabang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sLevelAkun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cStatusJurnal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cKodeAkunInduk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMeButtonBrowser2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rDebetOrKredit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tKeterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tKodeAkun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents cStatusJurnal As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnKeluar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cKodeAkunInduk As meCore.cMeButtonBrowser
    Friend WithEvents CMeButtonBrowser2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rDebetOrKredit As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents tKeterangan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tKodeAkun As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents btnSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sLevelAkun As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents tKodeCabang As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
End Class
