<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstKodeAkunList
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMstKodeAkunList))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnHapus = New DevExpress.XtraEditors.SimpleButton()
        Me.btnUbah = New DevExpress.XtraEditors.SimpleButton()
        Me.btnTambah = New DevExpress.XtraEditors.SimpleButton()
        Me.cCompany = New meCore.cMeButtonBrowser()
        Me.CMeButtonBrowser2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tNama = New DevExpress.XtraEditors.TextEdit()
        Me.tJenis = New DevExpress.XtraEditors.TextEdit()
        Me.cJenis = New meCore.cMeButtonBrowser()
        Me.CMeButtonBrowser1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dgKodeAkun = New meCore.ctrlMeDataGrid()
        Me.dgKategori = New meCore.ctrlMeDataGrid()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.btnHistory = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cCompany.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMeButtonBrowser2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tJenis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cJenis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMeButtonBrowser1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.btnHistory)
        Me.LayoutControl1.Controls.Add(Me.btnHapus)
        Me.LayoutControl1.Controls.Add(Me.btnUbah)
        Me.LayoutControl1.Controls.Add(Me.btnTambah)
        Me.LayoutControl1.Controls.Add(Me.cCompany)
        Me.LayoutControl1.Controls.Add(Me.tNama)
        Me.LayoutControl1.Controls.Add(Me.tJenis)
        Me.LayoutControl1.Controls.Add(Me.cJenis)
        Me.LayoutControl1.Controls.Add(Me.dgKodeAkun)
        Me.LayoutControl1.Controls.Add(Me.dgKategori)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(768, 394)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'btnHapus
        '
        Me.btnHapus.Image = CType(resources.GetObject("btnHapus.Image"), System.Drawing.Image)
        Me.btnHapus.Location = New System.Drawing.Point(629, 344)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(127, 38)
        Me.btnHapus.StyleController = Me.LayoutControl1
        Me.btnHapus.TabIndex = 12
        Me.btnHapus.Text = "Hapus"
        '
        'btnUbah
        '
        Me.btnUbah.Image = CType(resources.GetObject("btnUbah.Image"), System.Drawing.Image)
        Me.btnUbah.Location = New System.Drawing.Point(501, 344)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(124, 38)
        Me.btnUbah.StyleController = Me.LayoutControl1
        Me.btnUbah.TabIndex = 11
        Me.btnUbah.Text = "Ubah"
        '
        'btnTambah
        '
        Me.btnTambah.Image = CType(resources.GetObject("btnTambah.Image"), System.Drawing.Image)
        Me.btnTambah.Location = New System.Drawing.Point(352, 344)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(145, 38)
        Me.btnTambah.StyleController = Me.LayoutControl1
        Me.btnTambah.TabIndex = 10
        Me.btnTambah.Text = "Tambah"
        '
        'cCompany
        '
        Me.cCompany.Location = New System.Drawing.Point(87, 36)
        Me.cCompany.Name = "cCompany"
        Me.cCompany.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cCompany.Properties.NullText = ""
        Me.cCompany.Properties.View = Me.CMeButtonBrowser2View
        Me.cCompany.Size = New System.Drawing.Size(86, 20)
        Me.cCompany.StyleController = Me.LayoutControl1
        Me.cCompany.TabIndex = 9
        '
        'CMeButtonBrowser2View
        '
        Me.CMeButtonBrowser2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.CMeButtonBrowser2View.Name = "CMeButtonBrowser2View"
        Me.CMeButtonBrowser2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.CMeButtonBrowser2View.OptionsView.ShowGroupPanel = False
        '
        'tNama
        '
        Me.tNama.Location = New System.Drawing.Point(177, 36)
        Me.tNama.Name = "tNama"
        Me.tNama.Size = New System.Drawing.Size(227, 20)
        Me.tNama.StyleController = Me.LayoutControl1
        Me.tNama.TabIndex = 8
        '
        'tJenis
        '
        Me.tJenis.Location = New System.Drawing.Point(177, 12)
        Me.tJenis.Name = "tJenis"
        Me.tJenis.Size = New System.Drawing.Size(579, 20)
        Me.tJenis.StyleController = Me.LayoutControl1
        Me.tJenis.TabIndex = 7
        Me.tJenis.Visible = False
        '
        'cJenis
        '
        Me.cJenis.Location = New System.Drawing.Point(87, 12)
        Me.cJenis.Name = "cJenis"
        Me.cJenis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cJenis.Properties.NullText = ""
        Me.cJenis.Properties.View = Me.CMeButtonBrowser1View
        Me.cJenis.Size = New System.Drawing.Size(86, 20)
        Me.cJenis.StyleController = Me.LayoutControl1
        Me.cJenis.TabIndex = 6
        '
        'CMeButtonBrowser1View
        '
        Me.CMeButtonBrowser1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.CMeButtonBrowser1View.Name = "CMeButtonBrowser1View"
        Me.CMeButtonBrowser1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.CMeButtonBrowser1View.OptionsView.ShowGroupPanel = False
        '
        'dgKodeAkun
        '
        Me.dgKodeAkun.colSum = Nothing
        Me.dgKodeAkun.ConnString = Nothing
        Me.dgKodeAkun.dSourceUsePK = True
        Me.dgKodeAkun.FilterPopUpMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.dgKodeAkun.Location = New System.Drawing.Point(159, 60)
        Me.dgKodeAkun.Name = "dgKodeAkun"
        Me.dgKodeAkun.PopDeleteShow = False
        Me.dgKodeAkun.PopExportShow = True
        Me.dgKodeAkun.PopNewShow = False
        Me.dgKodeAkun.PopOpenShow = False
        Me.dgKodeAkun.PopPrintShow = False
        Me.dgKodeAkun.PopRefreshShow = False
        Me.dgKodeAkun.Query = Nothing
        Me.dgKodeAkun.QueryTime = Nothing
        Me.dgKodeAkun.ShowFooter = True
        Me.dgKodeAkun.Size = New System.Drawing.Size(597, 280)
        Me.dgKodeAkun.TabIndex = 5
        '
        'dgKategori
        '
        Me.dgKategori.colSum = Nothing
        Me.dgKategori.ConnString = Nothing
        Me.dgKategori.dSourceUsePK = True
        Me.dgKategori.FilterPopUpMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.dgKategori.Location = New System.Drawing.Point(12, 60)
        Me.dgKategori.Name = "dgKategori"
        Me.dgKategori.PopDeleteShow = False
        Me.dgKategori.PopExportShow = True
        Me.dgKategori.PopNewShow = False
        Me.dgKategori.PopOpenShow = False
        Me.dgKategori.PopPrintShow = False
        Me.dgKategori.PopRefreshShow = False
        Me.dgKategori.Query = Nothing
        Me.dgKategori.QueryTime = Nothing
        Me.dgKategori.ShowFooter = True
        Me.dgKategori.Size = New System.Drawing.Size(143, 280)
        Me.dgKategori.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.EmptySpaceItem1, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.EmptySpaceItem2, Me.LayoutControlItem10})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(768, 394)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.dgKategori
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(147, 284)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.dgKodeAkun
        Me.LayoutControlItem2.Location = New System.Drawing.Point(147, 48)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(601, 284)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cJenis
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(165, 24)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(165, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(165, 24)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "Jenis"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(72, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.tJenis
        Me.LayoutControlItem4.Location = New System.Drawing.Point(165, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(583, 24)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        Me.LayoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.tNama
        Me.LayoutControlItem5.Location = New System.Drawing.Point(165, 24)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(231, 24)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(231, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(231, 24)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cCompany
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(165, 24)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(165, 24)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(165, 24)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Kode Company"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(72, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(396, 24)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(352, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.btnTambah
        Me.LayoutControlItem7.Location = New System.Drawing.Point(340, 332)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(149, 42)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(149, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(149, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.btnUbah
        Me.LayoutControlItem8.Location = New System.Drawing.Point(489, 332)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(128, 42)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(128, 42)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(128, 42)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.btnHapus
        Me.LayoutControlItem9.Location = New System.Drawing.Point(617, 332)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(131, 42)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(131, 42)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(131, 42)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(100, 332)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(240, 42)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'btnHistory
        '
        Me.btnHistory.Image = CType(resources.GetObject("btnHistory.Image"), System.Drawing.Image)
        Me.btnHistory.Location = New System.Drawing.Point(12, 344)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(96, 38)
        Me.btnHistory.StyleController = Me.LayoutControl1
        Me.btnHistory.TabIndex = 13
        Me.btnHistory.Text = "Perubahan"
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.btnHistory
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 332)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(100, 42)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'frmMstKodeAkunList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 394)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmMstKodeAkunList"
        Me.Text = "frmMstKodeAkunList"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cCompany.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMeButtonBrowser2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tJenis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cJenis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMeButtonBrowser1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents dgKodeAkun As meCore.ctrlMeDataGrid
    Friend WithEvents dgKategori As meCore.ctrlMeDataGrid
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents tJenis As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cJenis As meCore.cMeButtonBrowser
    Friend WithEvents CMeButtonBrowser1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cCompany As meCore.cMeButtonBrowser
    Friend WithEvents CMeButtonBrowser2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tNama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents btnHapus As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnUbah As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTambah As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents btnHistory As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
End Class
