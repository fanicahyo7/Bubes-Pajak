<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJurnal
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnUbah = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.dTanggalAkhir = New DevExpress.XtraEditors.DateEdit()
        Me.dTanggalAwal = New DevExpress.XtraEditors.DateEdit()
        Me.rFilter = New DevExpress.XtraEditors.RadioGroup()
        Me.dgJurnal = New meCore.ctrlMeDataGrid()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.CMeButtonBrowser1 = New meCore.cMeButtonBrowser()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.CMeButtonBrowser1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dTanggalAkhir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dTanggalAkhir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dTanggalAwal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dTanggalAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rFilter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMeButtonBrowser1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMeButtonBrowser1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.CMeButtonBrowser1)
        Me.LayoutControl1.Controls.Add(Me.DataGridView1)
        Me.LayoutControl1.Controls.Add(Me.btnUbah)
        Me.LayoutControl1.Controls.Add(Me.btnRefresh)
        Me.LayoutControl1.Controls.Add(Me.dTanggalAkhir)
        Me.LayoutControl1.Controls.Add(Me.dTanggalAwal)
        Me.LayoutControl1.Controls.Add(Me.rFilter)
        Me.LayoutControl1.Controls.Add(Me.dgJurnal)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(832, 501)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(111, 445)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(709, 44)
        Me.DataGridView1.TabIndex = 11
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(678, 65)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(142, 22)
        Me.btnUbah.StyleController = Me.LayoutControl1
        Me.btnUbah.TabIndex = 10
        Me.btnUbah.Text = "Ubah Data"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(12, 65)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(178, 22)
        Me.btnRefresh.StyleController = Me.LayoutControl1
        Me.btnRefresh.TabIndex = 9
        Me.btnRefresh.Text = "Refresh Data"
        '
        'dTanggalAkhir
        '
        Me.dTanggalAkhir.EditValue = Nothing
        Me.dTanggalAkhir.Location = New System.Drawing.Point(270, 41)
        Me.dTanggalAkhir.Name = "dTanggalAkhir"
        Me.dTanggalAkhir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dTanggalAkhir.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dTanggalAkhir.Size = New System.Drawing.Size(59, 20)
        Me.dTanggalAkhir.StyleController = Me.LayoutControl1
        Me.dTanggalAkhir.TabIndex = 8
        '
        'dTanggalAwal
        '
        Me.dTanggalAwal.EditValue = Nothing
        Me.dTanggalAwal.Location = New System.Drawing.Point(111, 41)
        Me.dTanggalAwal.Name = "dTanggalAwal"
        Me.dTanggalAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dTanggalAwal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dTanggalAwal.Size = New System.Drawing.Size(56, 20)
        Me.dTanggalAwal.StyleController = Me.LayoutControl1
        Me.dTanggalAwal.TabIndex = 7
        '
        'rFilter
        '
        Me.rFilter.Location = New System.Drawing.Point(111, 12)
        Me.rFilter.Name = "rFilter"
        Me.rFilter.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Semua"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Tanggal")})
        Me.rFilter.Size = New System.Drawing.Size(112, 25)
        Me.rFilter.StyleController = Me.LayoutControl1
        Me.rFilter.TabIndex = 6
        '
        'dgJurnal
        '
        Me.dgJurnal.colSum = Nothing
        Me.dgJurnal.ConnString = Nothing
        Me.dgJurnal.dSourceUsePK = True
        Me.dgJurnal.FilterPopUpMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
        Me.dgJurnal.Location = New System.Drawing.Point(12, 91)
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
        Me.dgJurnal.Size = New System.Drawing.Size(808, 326)
        Me.dgJurnal.TabIndex = 5
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(832, 501)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.dgJurnal
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 79)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(812, 330)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.dTanggalAwal
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 29)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(159, 24)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(159, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(159, 24)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "Tanggal Awal"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(96, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.rFilter
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(215, 29)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(215, 29)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(215, 29)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "Filter"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(96, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.btnRefresh
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 53)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(182, 26)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(182, 26)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(182, 26)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.dTanggalAkhir
        Me.LayoutControlItem1.Location = New System.Drawing.Point(159, 29)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(162, 24)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(162, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(162, 24)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Tanggal Akhir"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(96, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(215, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(597, 29)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(321, 29)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(491, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(182, 53)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(484, 26)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.btnUbah
        Me.LayoutControlItem6.Location = New System.Drawing.Point(666, 53)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(146, 26)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.DataGridView1
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 433)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(812, 48)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(96, 13)
        '
        'CMeButtonBrowser1
        '
        Me.CMeButtonBrowser1.Location = New System.Drawing.Point(111, 421)
        Me.CMeButtonBrowser1.Name = "CMeButtonBrowser1"
        Me.CMeButtonBrowser1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CMeButtonBrowser1.Properties.NullText = ""
        Me.CMeButtonBrowser1.Properties.View = Me.CMeButtonBrowser1View
        Me.CMeButtonBrowser1.Size = New System.Drawing.Size(709, 20)
        Me.CMeButtonBrowser1.StyleController = Me.LayoutControl1
        Me.CMeButtonBrowser1.TabIndex = 12
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.CMeButtonBrowser1
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 409)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(812, 24)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(96, 13)
        '
        'CMeButtonBrowser1View
        '
        Me.CMeButtonBrowser1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.CMeButtonBrowser1View.Name = "CMeButtonBrowser1View"
        Me.CMeButtonBrowser1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.CMeButtonBrowser1View.OptionsView.ShowGroupPanel = False
        '
        'frmJurnal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 501)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmJurnal"
        Me.Text = "frmJurnal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dTanggalAkhir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dTanggalAkhir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dTanggalAwal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dTanggalAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rFilter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMeButtonBrowser1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMeButtonBrowser1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents dgJurnal As meCore.ctrlMeDataGrid
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dTanggalAkhir As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dTanggalAwal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents rFilter As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents btnUbah As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CMeButtonBrowser1 As meCore.cMeButtonBrowser
    Friend WithEvents CMeButtonBrowser1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

End Class
