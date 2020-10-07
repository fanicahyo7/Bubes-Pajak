Imports meCore
Imports System.Data.SqlClient
Public Class frmMstKodeAkunList

    Private Sub frmMstKodeAkunList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cJenis.FirstInit(PubConnStr, "SELECT Jenis, ConnStr FROM mstUnitBukbes", {tJenis}, , , , , , , {"ConnStr"})
    End Sub

    Private Sub cJenis_EditValueChanged(sender As Object, e As EventArgs) Handles cJenis.EditValueChanged
        koneksi(tJenis.Text)
        cCompany.FirstInit(tJenis.Text, "Select KodeCompany,Nama from tbGNCompany", {tNama}, , , , , , {0.5, 1})
    End Sub

    Private Sub cCompany_EditValueChanged(sender As Object, e As EventArgs) Handles cCompany.EditValueChanged
        Dim query As String = _
            "select IdKategori,Keterangan as [Keterangan / KelompokRekening],DebetOrKredit from tbACKategori order by NoUrut asc"
        'da = New SqlDataAdapter(query, kon)
        'Dim ds As New DataSet
        'da.Fill(ds)

        'Dim dn As New cMeDB(tJenis.Text)
        'dn.FillMe(ds.Tables(0))
        'dgKategori.DataSource = dn
        'dgKategori.gcMain.DataSource = dn
        'dgKategori.colWidth = {0, 3, 0}
        'dgKategori.colVisibleFalse = {"IdKategori", "DebetOrKredit"}
        'dgKategori.RefreshDataView()

        dgKategori.FirstInit(query, {0, 3, 0}, , , {"IdKategori", "DebetOrKredit"})
        dgKategori.ConnString = tJenis.Text
        dgKategori.RefreshData()
    End Sub

    Private Sub dgKategori_Grid_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles dgKategori.Grid_FocusedRowChanged
        editdgkodeakun()
    End Sub
    Sub editdgkodeakun()
        Dim query As String = _
            "select a.KodeAkun,a.Keterangan,a.KodeAkunInduk,a.LevelAkun,a.DebetOrKredit as [D / K],a.StatusJurnal,a.KodeCabang,b.KodeAkunLama from tbACKodeAkun a " & _
            "left join tbACKodeAkunEdit b on a.KodeAkun = b.KodeAkunLama " & _
            "where a.KodeAkun like '" & cCompany.Text & ".%' and a.IdKategori='" & dgKategori.GetRowCellValue(dgKategori.FocusedRowHandle, "IdKategori") & "' "

        'da = New SqlDataAdapter(query, kon)
        'Dim ds As New DataSet
        'da.Fill(ds)
        'Dim dn As New cMeDB(tJenis.Text)
        'dn.FillMe(ds.Tables(0))
        'dgKodeAkun.DataSource = dn
        'dgKodeAkun.gcMain.DataSource = dn
        'dgKodeAkun.colVisibleFalse = {"KodeAkunLama", "KodeCabang"}
        'dgKodeAkun.colWidth = {1, 2.3, 1.1, 0.7, 0.5, 1, 1.2}
        'dgKodeAkun.RefreshDataView()


        dgKodeAkun.FirstInit(query, {1, 2.3, 1.1, 0.7, 0.5, 1, 1.2}, , , {"KodeAkunLama", "KodeCabang"})
        dgKodeAkun.ConnString = tJenis.Text
        dgKodeAkun.RefreshData()
    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If cJenis.Text = "" Or cCompany.Text = "" Then
            MsgBox("Data Belum Lengkap!", vbCritical + vbOKOnly, "Peringatan")
        Else
            Using xx As New frmMstKodeAkun(tJenis.Text, cCompany.Text, dgKategori.GetRowCellValue(dgKategori.FocusedRowHandle, "IdKategori"), dgKategori.GetRowCellValue(dgKategori.FocusedRowHandle, "KodeCabang"))
                xx.ShowDialog(Me)
                editdgkodeakun()
            End Using
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If cJenis.Text = "" Or cCompany.Text = "" Then
            MsgBox("Data Belum Lengkap!", vbCritical + vbOKOnly, "Peringatan")
        Else
            Using xx As New frmMstKodeAkun(tJenis.Text, cCompany.Text, dgKategori.GetRowCellValue(dgKategori.FocusedRowHandle, "IdKategori"), dgKategori.GetRowCellValue(dgKategori.FocusedRowHandle, "KodeCabang"))
                xx.Tag = dgKodeAkun.GetRowCellValue(dgKodeAkun.FocusedRowHandle, "KodeAkun")
                xx.ShowDialog(Me)
                editdgkodeakun()
            End Using
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If cJenis.Text = "" Or cCompany.Text = "" Then
            MsgBox("Data Belum Lengkap!", vbCritical + vbOKOnly, "Peringatan")
        Else
            Dim konfirmasi As String = MsgBox("Apakah Anda Yakin Menghapus Kode Akun " & dgKodeAkun.GetRowCellValue(dgKodeAkun.FocusedRowHandle, "KodeAkun") & "?", vbQuestion + vbYesNo, "Konfirmasi")
            If konfirmasi = vbYes Then
                Dim cari As String = _
                "select * from tbACKodeAkunEdit where KodeAkun='" & dgKodeAkun.GetRowCellValue(dgKodeAkun.FocusedRowHandle, "KodeAkun") & "'"
                cmd = New SqlCommand(cari, kon)
                rd = cmd.ExecuteReader
                rd.Read()
                Dim queryedit As String = ""
                If rd.HasRows Then
                    queryedit = "update tbACKodeAKunEdit set FlagDelete='1' where KodeAkun='" & dgKodeAkun.GetRowCellValue(dgKodeAkun.FocusedRowHandle, "KodeAkun") & "'"
                Else
                    rd.Close()
                    Dim carikodeakun As String = "select * from tbACKodeAkun where KodeAkun='" & dgKodeAkun.GetRowCellValue(dgKodeAkun.FocusedRowHandle, "KodeAkun") & "'"
                    cmd = New SqlCommand(carikodeakun, kon)
                    rd = cmd.ExecuteReader
                    rd.Read()
                    queryedit = _
                        "insert into tbACKodeAkunEdit (" & _
                            "KodeAkun,Keterangan,KodeAkunInduk,LevelAkun,DebetOrKredit," & _
                            "StatusJurnal,KodeCompany,IdKategori,KodeCabang,KodeAkunLama," & _
                            "KeteranganLama,IdKategoriLama,LevelAkunLama,DebetOrKreditLama,StatusJurnalLama," & _
                            "KodeAkunIndukLama,KodeCabangLama,KodeCompanyLama,FlagDelete) values (" & _
                            "'" & rd!KodeAkun & "','" & rd!Keterangan & "','" & rd!KodeAkunInduk & "','" & rd!LevelAkun & "','" & rd!DebetOrKredit & "'," & _
                            "'" & rd!StatusJurnal & "','" & rd!KodeCompany & "','" & rd!IdKategori & "','" & rd!KodeCabang & "','" & rd!KodeAkun & "'," & _
                            "'" & rd!Keterangan & "','" & rd!IdKategori & "','" & rd!LevelAkun & "','" & rd!DebetOrKredit & "','" & rd!StatusJurnal & "'," & _
                            "'" & rd!KodeAkunInduk & "','" & rd!KodeCabang & "','" & rd!KodeCompany & "','1')"
                End If
                rd.Close()

                cmd = New SqlCommand(queryedit, kon)
                cmd.ExecuteNonQuery()

                Dim query As String = _
                    "delete from tbACKodeAkun where KodeAkun='" & dgKodeAkun.GetRowCellValue(dgKodeAkun.FocusedRowHandle, "KodeAkun") & "'"
                cmd = New SqlCommand(query, kon)
                cmd.ExecuteNonQuery()
                MsgBox("Hapus Berhasil", vbInformation + vbOKOnly, "Informasi")
                editdgkodeakun()
            End If
        End If
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Using xx As New frmResetKodeAkun(tJenis.Text, cCompany.Text)
            xx.ShowDialog(Me)
            editdgkodeakun()
        End Using
    End Sub
End Class