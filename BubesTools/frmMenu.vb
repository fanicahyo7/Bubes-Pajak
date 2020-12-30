Imports meCore
Public Class frmMenu

    Private Sub EditJurnalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditJurnalToolStripMenuItem.Click
        Using xx As New frmJurnaldb
            xx.ShowDialog(Me)
        End Using
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pubStartUpApp = Application.StartupPath
        PubConnStr = getSQLConIni(Application.StartupPath & "\sqlcon.ini")
        PubConnStr = Replace(PubConnStr, "Provider=SQLOLEDB.1;", "")
        pubUserEntry = "QC"
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        Using xx As New frmLaporanJurnaldb
            xx.ShowDialog(Me)
        End Using
    End Sub

    Private Sub KodeAkunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KodeAkunToolStripMenuItem.Click
        Using xx As New frmMstKodeAkunList
            xx.ShowDialog(Me)
        End Using
    End Sub

    Private Sub AlsKodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlsKodeToolStripMenuItem.Click
        Using xx As New frmKodeAls
            xx.ShowDialog(Me)
        End Using
    End Sub
End Class