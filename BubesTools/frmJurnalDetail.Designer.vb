<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJurnalDetail
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.tTanggalBukti = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.tNoBukti = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.cKodeAkun = New meCore.cMeButtonBrowser()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.CMeButtonBrowser1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tKeteranganAkun = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.tKeterangan = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.tDebetOrKredit = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.tJumlah = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.btnSimpan = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.btnBatal = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tTanggalBukti.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tNoBukti.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cKodeAkun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMeButtonBrowser1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tKeteranganAkun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tKeterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tDebetOrKredit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tJumlah.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.btnBatal)
        Me.LayoutControl1.Controls.Add(Me.btnSimpan)
        Me.LayoutControl1.Controls.Add(Me.tJumlah)
        Me.LayoutControl1.Controls.Add(Me.tDebetOrKredit)
        Me.LayoutControl1.Controls.Add(Me.tKeterangan)
        Me.LayoutControl1.Controls.Add(Me.tKeteranganAkun)
        Me.LayoutControl1.Controls.Add(Me.cKodeAkun)
        Me.LayoutControl1.Controls.Add(Me.tNoBukti)
        Me.LayoutControl1.Controls.Add(Me.tTanggalBukti)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(599, 217)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.EmptySpaceItem4, Me.EmptySpaceItem5, Me.EmptySpaceItem6, Me.EmptySpaceItem7, Me.EmptySpaceItem8})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(599, 217)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'tTanggalBukti
        '
        Me.tTanggalBukti.Location = New System.Drawing.Point(99, 12)
        Me.tTanggalBukti.Name = "tTanggalBukti"
        Me.tTanggalBukti.Size = New System.Drawing.Size(105, 20)
        Me.tTanggalBukti.StyleController = Me.LayoutControl1
        Me.tTanggalBukti.TabIndex = 4
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.tTanggalBukti
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(196, 24)
        Me.LayoutControlItem1.Text = "Tanggal Bukti"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(83, 13)
        '
        'tNoBukti
        '
        Me.tNoBukti.Location = New System.Drawing.Point(99, 36)
        Me.tNoBukti.Name = "tNoBukti"
        Me.tNoBukti.Size = New System.Drawing.Size(198, 20)
        Me.tNoBukti.StyleController = Me.LayoutControl1
        Me.tNoBukti.TabIndex = 5
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.tNoBukti
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(289, 24)
        Me.LayoutControlItem2.Text = "No. Bukti"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(83, 13)
        '
        'cKodeAkun
        '
        Me.cKodeAkun.Location = New System.Drawing.Point(99, 60)
        Me.cKodeAkun.Name = "cKodeAkun"
        Me.cKodeAkun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cKodeAkun.Properties.NullText = ""
        Me.cKodeAkun.Properties.View = Me.CMeButtonBrowser1View
        Me.cKodeAkun.Size = New System.Drawing.Size(105, 20)
        Me.cKodeAkun.StyleController = Me.LayoutControl1
        Me.cKodeAkun.TabIndex = 6
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cKodeAkun
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(196, 24)
        Me.LayoutControlItem3.Text = "Kode Akun"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(83, 13)
        '
        'CMeButtonBrowser1View
        '
        Me.CMeButtonBrowser1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.CMeButtonBrowser1View.Name = "CMeButtonBrowser1View"
        Me.CMeButtonBrowser1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.CMeButtonBrowser1View.OptionsView.ShowGroupPanel = False
        '
        'tKeteranganAkun
        '
        Me.tKeteranganAkun.Location = New System.Drawing.Point(99, 84)
        Me.tKeteranganAkun.Name = "tKeteranganAkun"
        Me.tKeteranganAkun.Size = New System.Drawing.Size(247, 20)
        Me.tKeteranganAkun.StyleController = Me.LayoutControl1
        Me.tKeteranganAkun.TabIndex = 7
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.tKeteranganAkun
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(338, 24)
        Me.LayoutControlItem4.Text = "Keterangan Akun"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(83, 13)
        '
        'tKeterangan
        '
        Me.tKeterangan.Location = New System.Drawing.Point(99, 108)
        Me.tKeterangan.Name = "tKeterangan"
        Me.tKeterangan.Size = New System.Drawing.Size(426, 20)
        Me.tKeterangan.StyleController = Me.LayoutControl1
        Me.tKeterangan.TabIndex = 8
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.tKeterangan
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(517, 24)
        Me.LayoutControlItem5.Text = "Keterangan"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(83, 13)
        '
        'tDebetOrKredit
        '
        Me.tDebetOrKredit.Location = New System.Drawing.Point(99, 132)
        Me.tDebetOrKredit.Name = "tDebetOrKredit"
        Me.tDebetOrKredit.Size = New System.Drawing.Size(67, 20)
        Me.tDebetOrKredit.StyleController = Me.LayoutControl1
        Me.tDebetOrKredit.TabIndex = 9
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.tDebetOrKredit
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(158, 24)
        Me.LayoutControlItem6.Text = "Debet or Kredit"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(83, 13)
        '
        'tJumlah
        '
        Me.tJumlah.Location = New System.Drawing.Point(99, 156)
        Me.tJumlah.Name = "tJumlah"
        Me.tJumlah.Size = New System.Drawing.Size(83, 20)
        Me.tJumlah.StyleController = Me.LayoutControl1
        Me.tJumlah.TabIndex = 10
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.tJumlah
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(174, 24)
        Me.LayoutControlItem7.Text = "Jumlah"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(83, 13)
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(322, 180)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(135, 22)
        Me.btnSimpan.StyleController = Me.LayoutControl1
        Me.btnSimpan.TabIndex = 11
        Me.btnSimpan.Text = "Simpan"
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.btnSimpan
        Me.LayoutControlItem8.Location = New System.Drawing.Point(310, 168)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(139, 29)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(461, 180)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(126, 22)
        Me.btnBatal.StyleController = Me.LayoutControl1
        Me.btnBatal.TabIndex = 12
        Me.btnBatal.Text = "Batal"
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.btnBatal
        Me.LayoutControlItem9.Location = New System.Drawing.Point(449, 168)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(130, 29)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(196, 0)
        Me.EmptySpaceItem1.MaxSize = New System.Drawing.Size(383, 24)
        Me.EmptySpaceItem1.MinSize = New System.Drawing.Size(383, 24)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(383, 24)
        Me.EmptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(289, 24)
        Me.EmptySpaceItem2.MaxSize = New System.Drawing.Size(290, 24)
        Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(290, 24)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(290, 24)
        Me.EmptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(196, 48)
        Me.EmptySpaceItem3.MaxSize = New System.Drawing.Size(383, 24)
        Me.EmptySpaceItem3.MinSize = New System.Drawing.Size(383, 24)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(383, 24)
        Me.EmptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(338, 72)
        Me.EmptySpaceItem4.MaxSize = New System.Drawing.Size(241, 24)
        Me.EmptySpaceItem4.MinSize = New System.Drawing.Size(241, 24)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(241, 24)
        Me.EmptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(517, 96)
        Me.EmptySpaceItem5.MaxSize = New System.Drawing.Size(62, 24)
        Me.EmptySpaceItem5.MinSize = New System.Drawing.Size(62, 24)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(62, 24)
        Me.EmptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(158, 120)
        Me.EmptySpaceItem6.MaxSize = New System.Drawing.Size(421, 24)
        Me.EmptySpaceItem6.MinSize = New System.Drawing.Size(421, 24)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(421, 24)
        Me.EmptySpaceItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem7
        '
        Me.EmptySpaceItem7.AllowHotTrack = False
        Me.EmptySpaceItem7.Location = New System.Drawing.Point(174, 144)
        Me.EmptySpaceItem7.MaxSize = New System.Drawing.Size(405, 24)
        Me.EmptySpaceItem7.MinSize = New System.Drawing.Size(405, 24)
        Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Size = New System.Drawing.Size(405, 24)
        Me.EmptySpaceItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem8
        '
        Me.EmptySpaceItem8.AllowHotTrack = False
        Me.EmptySpaceItem8.Location = New System.Drawing.Point(0, 168)
        Me.EmptySpaceItem8.Name = "EmptySpaceItem8"
        Me.EmptySpaceItem8.Size = New System.Drawing.Size(310, 29)
        Me.EmptySpaceItem8.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmJurnalDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 217)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmJurnalDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmJurnalDetail"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tTanggalBukti.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tNoBukti.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cKodeAkun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMeButtonBrowser1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tKeteranganAkun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tKeterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tDebetOrKredit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tJumlah.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents btnBatal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tJumlah As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tDebetOrKredit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tKeterangan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tKeteranganAkun As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cKodeAkun As meCore.cMeButtonBrowser
    Friend WithEvents CMeButtonBrowser1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tNoBukti As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tTanggalBukti As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem
End Class
