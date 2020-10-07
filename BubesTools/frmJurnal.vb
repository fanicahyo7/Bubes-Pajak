Imports meCore
Public Class frmJurnal

    Private Sub frmJurnal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rFilter.SelectedIndex = 0
        dTanggalAkhir.EditValue = DateAdd(DateInterval.Day, 0, Now)
        dTanggalAwal.EditValue = DateAdd(DateInterval.Day, -30, dTanggalAkhir.EditValue)
    End Sub

    Private Sub rFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rFilter.SelectedIndexChanged
        pubStartUpApp = Application.StartupPath
        PubConnStr = getSQLConIni(Application.StartupPath & "\sqlcon.ini")
        PubConnStr = Replace(PubConnStr, "Provider=SQLOLEDB.1;", "")
        pubUserEntry = "QC"

        If rFilter.SelectedIndex = 0 Then
            SetTextReadOnly({dTanggalAkhir, dTanggalAwal}, True)
        Else
            SetTextReadOnly({dTanggalAkhir, dTanggalAwal}, False)
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Dim tambahanquery As String = ""
        If rFilter.SelectedIndex = 1 Then
            tambahanquery = "where TanggalBukti between '" & Format(dTanggalAwal.EditValue, "yyyyMMdd") & "' and '" & Format(dTanggalAkhir.EditValue, "yyyyMMdd") & "'"
        End If
        Dim query As String = _
                    "select a.TanggalBukti,a.NoBukti,a.KodeAkun,b.Keterangan as KeteranganAkun,a.Keterangan," & _
                    "a.DebetOrKredit,Jumlah from tbACJurnal a " & _
                    "left join tbACKodeAkun b on a.KodeAkun = b.KodeAkun " & tambahanquery & " order by a.TanggalBukti Asc"
        dgJurnal.FirstInit(query, {0.5, 0.7, 0.6, 1.2, 1.2, 0.5, 0.6}, {"Jumlah"})
        dgJurnal.RefreshData()
    End Sub

    Private Sub dgJurnal_Load(sender As Object, e As EventArgs) Handles dgJurnal.Load

    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Using xx As New frmJurnalDetail
            xx.tglBukti = Format(dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "TanggalBukti"), "yyyyMMdd")
            xx.NoBukti = dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "NoBukti")
            xx.KodeAkun = dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "KodeAkun")
            xx.ShowDialog(Me)
        End Using
    End Sub
End Class
