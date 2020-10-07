<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistoryDelete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistoryDelete))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnRestore = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAmbilData = New DevExpress.XtraEditors.SimpleButton()
        Me.cCompany = New meCore.cMeButtonBrowser()
        Me.CMeButtonBrowser1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tNama = New DevExpress.XtraEditors.TextEdit()
        Me.dgJurnal = New meCore.ctrlMeDataGrid()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.dBulan = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cCompany.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMeButtonBrowser1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dBulan.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dBulan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.dBulan)
        Me.LayoutControl1.Controls.Add(Me.btnRestore)
        Me.LayoutControl1.Controls.Add(Me.btnAmbilData)
        Me.LayoutControl1.Controls.Add(Me.cCompany)
        Me.LayoutControl1.Controls.Add(Me.tNama)
        Me.LayoutControl1.Controls.Add(Me.dgJurnal)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(553, 144, 450, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(886, 519)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'btnRestore
        '
        Me.btnRestore.Image = CType(resources.GetObject("btnRestore.Image"), System.Drawing.Image)
        Me.btnRestore.Location = New System.Drawing.Point(696, 469)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(178, 38)
        Me.btnRestore.StyleController = Me.LayoutControl1
        Me.btnRestore.TabIndex = 13
        Me.btnRestore.Text = "Restore Data"
        '
        'btnAmbilData
        '
        Me.btnAmbilData.Image = CType(resources.GetObject("btnAmbilData.Image"), System.Drawing.Image)
        Me.btnAmbilData.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnAmbilData.Location = New System.Drawing.Point(12, 60)
        Me.btnAmbilData.Name = "btnAmbilData"
        Me.btnAmbilData.Size = New System.Drawing.Size(301, 55)
        Me.btnAmbilData.StyleController = Me.LayoutControl1
        Me.btnAmbilData.TabIndex = 9
        Me.btnAmbilData.Text = "Ambil Data"
        '
        'cCompany
        '
        Me.cCompany.Location = New System.Drawing.Point(90, 12)
        Me.cCompany.Name = "cCompany"
        Me.cCompany.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cCompany.Properties.NullText = ""
        Me.cCompany.Properties.View = Me.CMeButtonBrowser1View
        Me.cCompany.Size = New System.Drawing.Size(60, 20)
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
        Me.tNama.Location = New System.Drawing.Point(90, 36)
        Me.tNama.Name = "tNama"
        Me.tNama.Size = New System.Drawing.Size(223, 20)
        Me.tNama.StyleController = Me.LayoutControl1
        Me.tNama.TabIndex = 5
        '
        'dgJurnal
        '
        Me.dgJurnal.colSum = Nothing
        Me.dgJurnal.ConnString = Nothing
        Me.dgJurnal.dSourceUsePK = True
        Me.dgJurnal.FilterPopUpMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.dgJurnal.Location = New System.Drawing.Point(12, 119)
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
        Me.dgJurnal.Size = New System.Drawing.Size(862, 346)
        Me.dgJurnal.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem6, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.EmptySpaceItem4, Me.LayoutControlItem4, Me.EmptySpaceItem5, Me.LayoutControlItem5})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(886, 519)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.dgJurnal
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 107)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(866, 350)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.tNama
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(305, 24)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(305, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(305, 24)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Nama Company"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(75, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cCompany
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(142, 24)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(142, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(142, 24)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "Kode Company"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(75, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.btnAmbilData
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(305, 59)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(305, 59)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(305, 59)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(142, 0)
        Me.EmptySpaceItem1.MaxSize = New System.Drawing.Size(163, 24)
        Me.EmptySpaceItem1.MinSize = New System.Drawing.Size(163, 24)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(163, 24)
        Me.EmptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(511, 0)
        Me.EmptySpaceItem2.MaxSize = New System.Drawing.Size(355, 24)
        Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(355, 24)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(355, 24)
        Me.EmptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(305, 24)
        Me.EmptySpaceItem3.MaxSize = New System.Drawing.Size(318, 24)
        Me.EmptySpaceItem3.MinSize = New System.Drawing.Size(318, 24)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(561, 24)
        Me.EmptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(305, 48)
        Me.EmptySpaceItem4.MaxSize = New System.Drawing.Size(488, 59)
        Me.EmptySpaceItem4.MinSize = New System.Drawing.Size(488, 59)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(561, 59)
        Me.EmptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.btnRestore
        Me.LayoutControlItem4.Location = New System.Drawing.Point(684, 457)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(182, 42)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(0, 457)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(684, 42)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'dBulan
        '
        Me.dBulan.EditValue = Nothing
        Me.dBulan.Location = New System.Drawing.Point(395, 12)
        Me.dBulan.Name = "dBulan"
        Me.dBulan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dBulan.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dBulan.Size = New System.Drawing.Size(124, 20)
        Me.dBulan.StyleController = Me.LayoutControl1
        Me.dBulan.TabIndex = 14
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.dBulan
        Me.LayoutControlItem5.Location = New System.Drawing.Point(305, 0)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(206, 24)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(206, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(206, 24)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "Periode"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(75, 13)
        '
        'frmHistoryDelete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 519)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmHistoryDelete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jurnal DB"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cCompany.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMeButtonBrowser1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dBulan.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dBulan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents btnRestore As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents dBulan As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
End Class
