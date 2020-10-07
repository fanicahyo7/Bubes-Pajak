Imports meCore
Public Class frmJurnalDetail
    Public tglBukti, NoBukti, KodeAkun As String
    Dim isNew As Boolean = True
    Dim db As New cMeDB
    Private Sub frmJurnalDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDetail()
    End Sub

    Sub loadDetail()
        Dim query As String = _
       "select a.TanggalBukti,a.NoBukti,a.KodeAkun,b.Keterangan as KeteranganAkun,a.Keterangan,a.DebetOrKredit," & _
       "Jumlah from tbACJurnal a left join tbACKodeAkun b on a.KodeAkun = b.KodeAkun " & _
       "where a.TanggalBukti='" & tglBukti & "' and a.NoBukti='" & NoBukti & "' and a.KodeAkun='" & KodeAkun & "'"
        db.FillMe(query, True)

        If db.Rows.Count > 0 Then
            isNew = False
            FillFormFromDataRow(Me, db.Rows(0))
        Else

        End If
    End Sub
End Class