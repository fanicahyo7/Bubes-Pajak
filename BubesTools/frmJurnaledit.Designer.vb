<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBubesEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBubesEdit))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cTahun = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnFilter = New DevExpress.XtraEditors.SimpleButton()
        Me.tBln = New DevExpress.XtraEditors.TextEdit()
        Me.btnSimpan = New DevExpress.XtraEditors.SimpleButton()
        Me.tNama = New DevExpress.XtraEditors.TextEdit()
        Me.cCompany = New meCore.cMeButtonBrowser()
        Me.CMeButtonBrowser1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnImportExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.dgJurnal = New meCore.ctrlMeDataGrid()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lFiltergroup = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cTahun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tBln.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cCompany.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMeButtonBrowser1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lFiltergroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cTahun)
        Me.LayoutControl1.Controls.Add(Me.btnFilter)
        Me.LayoutControl1.Controls.Add(Me.tBln)
        Me.LayoutControl1.Controls.Add(Me.btnSimpan)
        Me.LayoutControl1.Controls.Add(Me.tNama)
        Me.LayoutControl1.Controls.Add(Me.cCompany)
        Me.LayoutControl1.Controls.Add(Me.btnImportExcel)
        Me.LayoutControl1.Controls.Add(Me.dgJurnal)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(778, 486)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cTahun
        '
        Me.cTahun.Location = New System.Drawing.Point(234, 132)
        Me.cTahun.Name = "cTahun"
        Me.cTahun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cTahun.Size = New System.Drawing.Size(89, 20)
        Me.cTahun.StyleController = Me.LayoutControl1
        Me.cTahun.TabIndex = 14
        '
        'btnFilter
        '
        Me.btnFilter.Image = CType(resources.GetObject("btnFilter.Image"), System.Drawing.Image)
        Me.btnFilter.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnFilter.Location = New System.Drawing.Point(24, 156)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(754, 55)
        Me.btnFilter.StyleController = Me.LayoutControl1
        Me.btnFilter.TabIndex = 13
        Me.btnFilter.Text = "Filter"
        '
        'tBln
        '
        Me.tBln.Location = New System.Drawing.Point(102, 132)
        Me.tBln.Name = "tBln"
        Me.tBln.Size = New System.Drawing.Size(50, 20)
        Me.tBln.StyleController = Me.LayoutControl1
        Me.tBln.TabIndex = 12
        '
        'btnSimpan
        '
        Me.btnSimpan.Enabled = False
        Me.btnSimpan.Image = CType(resources.GetObject("btnSimpan.Image"), System.Drawing.Image)
        Me.btnSimpan.Location = New System.Drawing.Point(623, 419)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(167, 38)
        Me.btnSimpan.StyleController = Me.LayoutControl1
        Me.btnSimpan.TabIndex = 11
        Me.btnSimpan.Text = "Simpan Perubahan"
        '
        'tNama
        '
        Me.tNama.Location = New System.Drawing.Point(102, 108)
        Me.tNama.Name = "tNama"
        Me.tNama.Size = New System.Drawing.Size(275, 20)
        Me.tNama.StyleController = Me.LayoutControl1
        Me.tNama.TabIndex = 8
        '
        'cCompany
        '
        Me.cCompany.Location = New System.Drawing.Point(102, 84)
        Me.cCompany.Name = "cCompany"
        Me.cCompany.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cCompany.Properties.NullText = ""
        Me.cCompany.Properties.View = Me.CMeButtonBrowser1View
        Me.cCompany.Size = New System.Drawing.Size(106, 20)
        Me.cCompany.StyleController = Me.LayoutControl1
        Me.cCompany.TabIndex = 7
        '
        'CMeButtonBrowser1View
        '
        Me.CMeButtonBrowser1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.CMeButtonBrowser1View.Name = "CMeButtonBrowser1View"
        Me.CMeButtonBrowser1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.CMeButtonBrowser1View.OptionsView.ShowGroupPanel = False
        '
        'btnImportExcel
        '
        Me.btnImportExcel.Image = CType(resources.GetObject("btnImportExcel.Image"), System.Drawing.Image)
        Me.btnImportExcel.Location = New System.Drawing.Point(637, 12)
        Me.btnImportExcel.Name = "btnImportExcel"
        Me.btnImportExcel.Size = New System.Drawing.Size(153, 38)
        Me.btnImportExcel.StyleController = Me.LayoutControl1
        Me.btnImportExcel.TabIndex = 5
        Me.btnImportExcel.Text = "Import Excel"
        '
        'dgJurnal
        '
        Me.dgJurnal.colSum = Nothing
        Me.dgJurnal.ConnString = Nothing
        Me.dgJurnal.dSourceUsePK = True
        Me.dgJurnal.FilterPopUpMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.dgJurnal.Location = New System.Drawing.Point(12, 227)
        Me.dgJurnal.Name = "dgJurnal"
        Me.dgJurnal.PopDeleteShow = False
        Me.dgJurnal.PopExportShow = True
        Me.dgJurnal.PopNewShow = False
        Me.dgJurnal.PopOpenShow = False
        Me.dgJurnal.PopPrintShow = False
        Me.dgJurnal.PopRefreshShow = False
        Me.dgJurnal.Query = Nothing
        Me.dgJurnal.QueryTime = Nothing
        Me.dgJurnal.ShowFooter = True
        Me.dgJurnal.Size = New System.Drawing.Size(778, 188)
        Me.dgJurnal.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.EmptySpaceItem1, Me.LayoutControlItem3, Me.lFiltergroup, Me.EmptySpaceItem5})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(802, 469)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.dgJurnal
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 215)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(782, 192)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.btnImportExcel
        Me.LayoutControlItem2.Location = New System.Drawing.Point(625, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(157, 42)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(625, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.btnSimpan
        Me.LayoutControlItem3.Location = New System.Drawing.Point(611, 407)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(171, 42)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'lFiltergroup
        '
        Me.lFiltergroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem8, Me.EmptySpaceItem4, Me.EmptySpaceItem3, Me.EmptySpaceItem2, Me.LayoutControlItem7, Me.LayoutControlItem6})
        Me.lFiltergroup.Location = New System.Drawing.Point(0, 42)
        Me.lFiltergroup.Name = "lFiltergroup"
        Me.lFiltergroup.Size = New System.Drawing.Size(782, 173)
        Me.lFiltergroup.Text = "Filter"
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cCompany
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(188, 24)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(188, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(188, 24)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "Kode Company"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(75, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.tNama
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(357, 24)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(357, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(357, 24)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "Nama Company"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(75, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.tBln
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(132, 24)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(132, 24)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(132, 24)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.Text = "Bulan"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(75, 13)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(303, 48)
        Me.EmptySpaceItem4.MaxSize = New System.Drawing.Size(455, 24)
        Me.EmptySpaceItem4.MinSize = New System.Drawing.Size(455, 24)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(455, 24)
        Me.EmptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(357, 24)
        Me.EmptySpaceItem3.MaxSize = New System.Drawing.Size(401, 24)
        Me.EmptySpaceItem3.MinSize = New System.Drawing.Size(401, 24)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(401, 24)
        Me.EmptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(188, 0)
        Me.EmptySpaceItem2.MaxSize = New System.Drawing.Size(570, 24)
        Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(570, 24)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(570, 24)
        Me.EmptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.btnFilter
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(758, 59)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cTahun
        Me.LayoutControlItem6.Location = New System.Drawing.Point(132, 48)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(171, 24)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(171, 24)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(171, 24)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Tahun"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(75, 13)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(0, 407)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(611, 42)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmBubesEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 486)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmBubesEdit"
        Me.Text = "frmBubesEdit"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cTahun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tBln.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cCompany.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMeButtonBrowser1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lFiltergroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents btnImportExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgJurnal As meCore.ctrlMeDataGrid
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cCompany As meCore.cMeButtonBrowser
    Friend WithEvents CMeButtonBrowser1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents tNama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents btnSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnFilter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tBln As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lFiltergroup As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cTahun As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
End Class
