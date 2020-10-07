<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaporanJurnaldb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLaporanJurnaldb))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.tJenis = New DevExpress.XtraEditors.TextEdit()
        Me.cJenis = New meCore.cMeButtonBrowser()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dBulan = New DevExpress.XtraEditors.DateEdit()
        Me.btnAmbilData = New DevExpress.XtraEditors.SimpleButton()
        Me.cCompany = New meCore.cMeButtonBrowser()
        Me.CMeButtonBrowser1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tNama = New DevExpress.XtraEditors.TextEdit()
        Me.dgJurnal = New meCore.ctrlMeDataGrid()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.tJenis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cJenis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dBulan.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dBulan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cCompany.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMeButtonBrowser1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.tJenis)
        Me.LayoutControl1.Controls.Add(Me.cJenis)
        Me.LayoutControl1.Controls.Add(Me.dBulan)
        Me.LayoutControl1.Controls.Add(Me.btnAmbilData)
        Me.LayoutControl1.Controls.Add(Me.cCompany)
        Me.LayoutControl1.Controls.Add(Me.tNama)
        Me.LayoutControl1.Controls.Add(Me.dgJurnal)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(553, 144, 450, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(813, 392)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'tJenis
        '
        Me.tJenis.Location = New System.Drawing.Point(208, 12)
        Me.tJenis.Name = "tJenis"
        Me.tJenis.Size = New System.Drawing.Size(324, 20)
        Me.tJenis.StyleController = Me.LayoutControl1
        Me.tJenis.TabIndex = 15
        '
        'cJenis
        '
        Me.cJenis.Location = New System.Drawing.Point(87, 12)
        Me.cJenis.Name = "cJenis"
        Me.cJenis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cJenis.Properties.NullText = ""
        Me.cJenis.Properties.View = Me.GridView1
        Me.cJenis.Size = New System.Drawing.Size(117, 20)
        Me.cJenis.StyleController = Me.LayoutControl1
        Me.cJenis.TabIndex = 14
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'dBulan
        '
        Me.dBulan.EditValue = Nothing
        Me.dBulan.Location = New System.Drawing.Point(87, 62)
        Me.dBulan.Name = "dBulan"
        Me.dBulan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dBulan.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dBulan.Size = New System.Drawing.Size(117, 20)
        Me.dBulan.StyleController = Me.LayoutControl1
        Me.dBulan.TabIndex = 13
        '
        'btnAmbilData
        '
        Me.btnAmbilData.Image = CType(resources.GetObject("btnAmbilData.Image"), System.Drawing.Image)
        Me.btnAmbilData.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnAmbilData.Location = New System.Drawing.Point(12, 96)
        Me.btnAmbilData.Name = "btnAmbilData"
        Me.btnAmbilData.Size = New System.Drawing.Size(301, 55)
        Me.btnAmbilData.StyleController = Me.LayoutControl1
        Me.btnAmbilData.TabIndex = 9
        Me.btnAmbilData.Text = "Ambil Data"
        '
        'cCompany
        '
        Me.cCompany.Location = New System.Drawing.Point(87, 36)
        Me.cCompany.Name = "cCompany"
        Me.cCompany.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cCompany.Properties.NullText = ""
        Me.cCompany.Properties.View = Me.CMeButtonBrowser1View
        Me.cCompany.Size = New System.Drawing.Size(117, 20)
        Me.cCompany.StyleController = Me.LayoutControl1
        Me.cCompany.TabIndex = 6
        '
        'CMeButtonBrowser1View
        '
        Me.CMeButtonBrowser1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.CMeButtonBrowser1View.Name = "CMeButtonBrowser1View"
        Me.CMeButtonBrowser1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.CMeButtonBrowser1View.OptionsView.ShowGroupPanel = False
        '
        'tNama
        '
        Me.tNama.Location = New System.Drawing.Point(208, 36)
        Me.tNama.Name = "tNama"
        Me.tNama.Size = New System.Drawing.Size(324, 20)
        Me.tNama.StyleController = Me.LayoutControl1
        Me.tNama.TabIndex = 5
        '
        'dgJurnal
        '
        Me.dgJurnal.colSum = Nothing
        Me.dgJurnal.ConnString = Nothing
        Me.dgJurnal.dSourceUsePK = True
        Me.dgJurnal.FilterPopUpMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.dgJurnal.Location = New System.Drawing.Point(12, 155)
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
        Me.dgJurnal.Size = New System.Drawing.Size(789, 225)
        Me.dgJurnal.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem6, Me.EmptySpaceItem2, Me.EmptySpaceItem4, Me.LayoutControlItem5, Me.LayoutControlItem7, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(813, 392)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.dgJurnal
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 143)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(793, 229)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cCompany
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(196, 26)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(196, 26)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(196, 26)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "Kode Company"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(72, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.btnAmbilData
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(305, 59)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(305, 59)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(305, 59)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(524, 0)
        Me.EmptySpaceItem2.MaxSize = New System.Drawing.Size(269, 50)
        Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(269, 50)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(269, 50)
        Me.EmptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(305, 84)
        Me.EmptySpaceItem4.MaxSize = New System.Drawing.Size(488, 59)
        Me.EmptySpaceItem4.MinSize = New System.Drawing.Size(488, 59)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(488, 59)
        Me.EmptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cJenis
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(196, 24)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(196, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(196, 24)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "Jenis"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(72, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.tJenis
        Me.LayoutControlItem7.Location = New System.Drawing.Point(196, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(328, 24)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.tNama
        Me.LayoutControlItem2.Location = New System.Drawing.Point(196, 24)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(328, 26)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(328, 26)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(328, 26)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Nama Company"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.dBulan
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(196, 34)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(196, 34)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(196, 34)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "Periode"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(72, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(196, 50)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(597, 34)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmLaporanJurnaldb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 392)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmLaporanJurnaldb"
        Me.Text = "Jurnal DB"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.tJenis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cJenis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dBulan.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dBulan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cCompany.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMeButtonBrowser1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents dgJurnal As meCore.ctrlMeDataGrid
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents tNama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnAmbilData As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cCompany As meCore.cMeButtonBrowser
    Friend WithEvents CMeButtonBrowser1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents dBulan As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents tJenis As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cJenis As meCore.cMeButtonBrowser
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
End Class
