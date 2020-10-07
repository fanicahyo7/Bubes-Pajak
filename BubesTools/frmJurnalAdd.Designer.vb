<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJurnalAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJurnalAdd))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnKeluar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSimpan = New DevExpress.XtraEditors.SimpleButton()
        Me.rDebetKredit = New DevExpress.XtraEditors.RadioGroup()
        Me.sJumlah = New DevExpress.XtraEditors.SpinEdit()
        Me.tKeterangan = New DevExpress.XtraEditors.TextEdit()
        Me.tKeteranganAkun = New DevExpress.XtraEditors.TextEdit()
        Me.cKodeAkun = New meCore.cMeButtonBrowser()
        Me.CMeButtonBrowser3View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dTanggalBukti = New DevExpress.XtraEditors.DateEdit()
        Me.cNoBukti = New meCore.cMeButtonBrowser()
        Me.CMeButtonBrowser1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cBuktiBaru = New System.Windows.Forms.CheckBox()
        Me.tNoBukti = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem9 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.rDebetKredit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sJumlah.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tKeterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tKeteranganAkun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cKodeAkun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMeButtonBrowser3View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dTanggalBukti.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dTanggalBukti.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cNoBukti.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMeButtonBrowser1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tNoBukti.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.btnKeluar)
        Me.LayoutControl1.Controls.Add(Me.btnSimpan)
        Me.LayoutControl1.Controls.Add(Me.rDebetKredit)
        Me.LayoutControl1.Controls.Add(Me.sJumlah)
        Me.LayoutControl1.Controls.Add(Me.tKeterangan)
        Me.LayoutControl1.Controls.Add(Me.tKeteranganAkun)
        Me.LayoutControl1.Controls.Add(Me.cKodeAkun)
        Me.LayoutControl1.Controls.Add(Me.dTanggalBukti)
        Me.LayoutControl1.Controls.Add(Me.cNoBukti)
        Me.LayoutControl1.Controls.Add(Me.cBuktiBaru)
        Me.LayoutControl1.Controls.Add(Me.tNoBukti)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(523, 212)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'btnKeluar
        '
        Me.btnKeluar.Image = CType(resources.GetObject("btnKeluar.Image"), System.Drawing.Image)
        Me.btnKeluar.Location = New System.Drawing.Point(404, 161)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(107, 38)
        Me.btnKeluar.StyleController = Me.LayoutControl1
        Me.btnKeluar.TabIndex = 20
        Me.btnKeluar.Text = "Keluar"
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = CType(resources.GetObject("btnSimpan.Image"), System.Drawing.Image)
        Me.btnSimpan.Location = New System.Drawing.Point(297, 161)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(103, 38)
        Me.btnSimpan.StyleController = Me.LayoutControl1
        Me.btnSimpan.TabIndex = 19
        Me.btnSimpan.Text = "Simpan"
        '
        'rDebetKredit
        '
        Me.rDebetKredit.Location = New System.Drawing.Point(265, 36)
        Me.rDebetKredit.Name = "rDebetKredit"
        Me.rDebetKredit.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Debet"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Kredit")})
        Me.rDebetKredit.Size = New System.Drawing.Size(145, 25)
        Me.rDebetKredit.StyleController = Me.LayoutControl1
        Me.rDebetKredit.TabIndex = 18
        '
        'sJumlah
        '
        Me.sJumlah.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.sJumlah.Location = New System.Drawing.Point(79, 137)
        Me.sJumlah.Name = "sJumlah"
        Me.sJumlah.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sJumlah.Size = New System.Drawing.Size(115, 20)
        Me.sJumlah.StyleController = Me.LayoutControl1
        Me.sJumlah.TabIndex = 17
        '
        'tKeterangan
        '
        Me.tKeterangan.Location = New System.Drawing.Point(79, 113)
        Me.tKeterangan.Name = "tKeterangan"
        Me.tKeterangan.Size = New System.Drawing.Size(432, 20)
        Me.tKeterangan.StyleController = Me.LayoutControl1
        Me.tKeterangan.TabIndex = 16
        '
        'tKeteranganAkun
        '
        Me.tKeteranganAkun.Location = New System.Drawing.Point(165, 89)
        Me.tKeteranganAkun.Name = "tKeteranganAkun"
        Me.tKeteranganAkun.Size = New System.Drawing.Size(271, 20)
        Me.tKeteranganAkun.StyleController = Me.LayoutControl1
        Me.tKeteranganAkun.TabIndex = 15
        '
        'cKodeAkun
        '
        Me.cKodeAkun.Location = New System.Drawing.Point(79, 89)
        Me.cKodeAkun.Name = "cKodeAkun"
        Me.cKodeAkun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cKodeAkun.Properties.NullText = ""
        Me.cKodeAkun.Properties.View = Me.CMeButtonBrowser3View
        Me.cKodeAkun.Size = New System.Drawing.Size(82, 20)
        Me.cKodeAkun.StyleController = Me.LayoutControl1
        Me.cKodeAkun.TabIndex = 12
        '
        'CMeButtonBrowser3View
        '
        Me.CMeButtonBrowser3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.CMeButtonBrowser3View.Name = "CMeButtonBrowser3View"
        Me.CMeButtonBrowser3View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.CMeButtonBrowser3View.OptionsView.ShowGroupPanel = False
        '
        'dTanggalBukti
        '
        Me.dTanggalBukti.EditValue = Nothing
        Me.dTanggalBukti.Location = New System.Drawing.Point(79, 36)
        Me.dTanggalBukti.Name = "dTanggalBukti"
        Me.dTanggalBukti.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dTanggalBukti.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dTanggalBukti.Size = New System.Drawing.Size(115, 20)
        Me.dTanggalBukti.StyleController = Me.LayoutControl1
        Me.dTanggalBukti.TabIndex = 8
        '
        'cNoBukti
        '
        Me.cNoBukti.Location = New System.Drawing.Point(79, 65)
        Me.cNoBukti.Name = "cNoBukti"
        Me.cNoBukti.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cNoBukti.Properties.NullText = ""
        Me.cNoBukti.Properties.View = Me.CMeButtonBrowser1View
        Me.cNoBukti.Size = New System.Drawing.Size(164, 20)
        Me.cNoBukti.StyleController = Me.LayoutControl1
        Me.cNoBukti.TabIndex = 7
        '
        'CMeButtonBrowser1View
        '
        Me.CMeButtonBrowser1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.CMeButtonBrowser1View.Name = "CMeButtonBrowser1View"
        Me.CMeButtonBrowser1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.CMeButtonBrowser1View.OptionsView.ShowGroupPanel = False
        '
        'cBuktiBaru
        '
        Me.cBuktiBaru.Location = New System.Drawing.Point(12, 12)
        Me.cBuktiBaru.Name = "cBuktiBaru"
        Me.cBuktiBaru.Size = New System.Drawing.Size(499, 20)
        Me.cBuktiBaru.TabIndex = 6
        Me.cBuktiBaru.Text = "No. Bukti Baru"
        Me.cBuktiBaru.UseVisualStyleBackColor = True
        '
        'tNoBukti
        '
        Me.tNoBukti.Location = New System.Drawing.Point(314, 65)
        Me.tNoBukti.Name = "tNoBukti"
        Me.tNoBukti.Size = New System.Drawing.Size(114, 20)
        Me.tNoBukti.StyleController = Me.LayoutControl1
        Me.tNoBukti.TabIndex = 5
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem2, Me.LayoutControlItem3, Me.LayoutControlItem9, Me.EmptySpaceItem7, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.EmptySpaceItem9, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.EmptySpaceItem1, Me.LayoutControlItem5, Me.EmptySpaceItem4, Me.LayoutControlItem15, Me.LayoutControlItem4, Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(523, 212)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(420, 53)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(83, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cBuktiBaru
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(503, 24)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cKodeAkun
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 77)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(153, 24)
        Me.LayoutControlItem9.Text = "Kode Akun"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(64, 13)
        '
        'EmptySpaceItem7
        '
        Me.EmptySpaceItem7.AllowHotTrack = False
        Me.EmptySpaceItem7.Location = New System.Drawing.Point(428, 77)
        Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Size = New System.Drawing.Size(75, 24)
        Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.tKeteranganAkun
        Me.LayoutControlItem12.Location = New System.Drawing.Point(153, 77)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(275, 24)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.tKeterangan
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 101)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(503, 24)
        Me.LayoutControlItem13.Text = "Keterangan"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(64, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.sJumlah
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 125)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(186, 24)
        Me.LayoutControlItem14.Text = "Jumlah"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(64, 13)
        '
        'EmptySpaceItem9
        '
        Me.EmptySpaceItem9.AllowHotTrack = False
        Me.EmptySpaceItem9.Location = New System.Drawing.Point(186, 125)
        Me.EmptySpaceItem9.Name = "EmptySpaceItem9"
        Me.EmptySpaceItem9.Size = New System.Drawing.Size(317, 24)
        Me.EmptySpaceItem9.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.btnSimpan
        Me.LayoutControlItem16.Location = New System.Drawing.Point(285, 149)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(107, 43)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.btnKeluar
        Me.LayoutControlItem17.Location = New System.Drawing.Point(392, 149)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(111, 43)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 149)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(285, 43)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.dTanggalBukti
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(186, 29)
        Me.LayoutControlItem5.Text = "Tanggal Bukti"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(64, 13)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(402, 24)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(101, 29)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.rDebetKredit
        Me.LayoutControlItem15.Location = New System.Drawing.Point(186, 24)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(216, 29)
        Me.LayoutControlItem15.Text = " "
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(64, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cNoBukti
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 53)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(235, 24)
        Me.LayoutControlItem4.Text = "No Bukti"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(64, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.tNoBukti
        Me.LayoutControlItem2.Location = New System.Drawing.Point(235, 53)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(185, 24)
        Me.LayoutControlItem2.Text = "No Bukti"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(64, 13)
        '
        'frmJurnalAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 212)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmJurnalAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmJurnalAdd"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.rDebetKredit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sJumlah.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tKeterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tKeteranganAkun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cKodeAkun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMeButtonBrowser3View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dTanggalBukti.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dTanggalBukti.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cNoBukti.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMeButtonBrowser1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tNoBukti.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents cNoBukti As meCore.cMeButtonBrowser
    Friend WithEvents CMeButtonBrowser1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cBuktiBaru As System.Windows.Forms.CheckBox
    Friend WithEvents tNoBukti As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dTanggalBukti As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents btnKeluar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rDebetKredit As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents sJumlah As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents tKeterangan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tKeteranganAkun As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cKodeAkun As meCore.cMeButtonBrowser
    Friend WithEvents CMeButtonBrowser3View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem9 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
End Class
