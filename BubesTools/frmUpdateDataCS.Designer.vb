<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateDataCS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdateDataCS))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStatus = New DevExpress.XtraEditors.LabelControl()
        Me.tNamaDB = New DevExpress.XtraEditors.TextEdit()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.listProgress = New System.Windows.Forms.ListBox()
        Me.btnUpdateData = New DevExpress.XtraEditors.SimpleButton()
        Me.cUnit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.tNamaDB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.Label1)
        Me.LayoutControl1.Controls.Add(Me.lblStatus)
        Me.LayoutControl1.Controls.Add(Me.tNamaDB)
        Me.LayoutControl1.Controls.Add(Me.ProgressBar1)
        Me.LayoutControl1.Controls.Add(Me.listProgress)
        Me.LayoutControl1.Controls.Add(Me.btnUpdateData)
        Me.LayoutControl1.Controls.Add(Me.cUnit)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1010, 466)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(906, 409)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 45)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "0%"
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(12, 60)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(70, 13)
        Me.lblStatus.StyleController = Me.LayoutControl1
        Me.lblStatus.TabIndex = 9
        Me.lblStatus.Text = "Status Koneksi"
        '
        'tNamaDB
        '
        Me.tNamaDB.Location = New System.Drawing.Point(58, 36)
        Me.tNamaDB.Name = "tNamaDB"
        Me.tNamaDB.Size = New System.Drawing.Size(325, 20)
        Me.tNamaDB.StyleController = Me.LayoutControl1
        Me.tNamaDB.TabIndex = 8
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 409)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(890, 45)
        Me.ProgressBar1.TabIndex = 7
        '
        'listProgress
        '
        Me.listProgress.FormattingEnabled = True
        Me.listProgress.Location = New System.Drawing.Point(12, 136)
        Me.listProgress.Name = "listProgress"
        Me.listProgress.Size = New System.Drawing.Size(986, 264)
        Me.listProgress.TabIndex = 6
        '
        'btnUpdateData
        '
        Me.btnUpdateData.Image = CType(resources.GetObject("btnUpdateData.Image"), System.Drawing.Image)
        Me.btnUpdateData.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnUpdateData.Location = New System.Drawing.Point(12, 77)
        Me.btnUpdateData.Name = "btnUpdateData"
        Me.btnUpdateData.Size = New System.Drawing.Size(986, 55)
        Me.btnUpdateData.StyleController = Me.LayoutControl1
        Me.btnUpdateData.TabIndex = 5
        Me.btnUpdateData.Text = "Update Data"
        '
        'cUnit
        '
        Me.cUnit.Location = New System.Drawing.Point(58, 12)
        Me.cUnit.Name = "cUnit"
        Me.cUnit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cUnit.Size = New System.Drawing.Size(325, 20)
        Me.cUnit.StyleController = Me.LayoutControl1
        Me.cUnit.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.EmptySpaceItem1, Me.EmptySpaceItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1010, 466)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cUnit
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(375, 24)
        Me.LayoutControlItem1.Text = "Pilih Unit"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(43, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.btnUpdateData
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 65)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(990, 59)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.listProgress
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 124)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(990, 273)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.ProgressBar1
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 397)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(894, 49)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.tNamaDB
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(375, 24)
        Me.LayoutControlItem5.Text = "Nama DB"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(43, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.lblStatus
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(990, 17)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.Label1
        Me.LayoutControlItem7.Location = New System.Drawing.Point(894, 397)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(96, 49)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(375, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(615, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(375, 24)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(615, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmUpdateDataCS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 466)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmUpdateDataCS"
        Me.Text = "Update CS Detail"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.tNamaDB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents listProgress As System.Windows.Forms.ListBox
    Friend WithEvents btnUpdateData As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cUnit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents tNamaDB As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
End Class
