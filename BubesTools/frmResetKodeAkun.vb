Imports meCore
Imports System.Data.SqlClient
Public Class frmResetKodeAkun

    Dim pConnStr As String = ""

    Public Sub New()
        InitializeComponent()
    End Sub
    Dim kodecompany As String
    Public Sub New(ConnStr As String, kodecompany As String)
        InitializeComponent()
        pConnStr = ConnStr
        Me.kodecompany = kodecompany
    End Sub

    Private Sub frmResetJurnal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Sub loaddata()
        Dim query As String = _
            "select cast(0 as bit) as Ambil," & _
                "KodeAkun,KodeCompany,IdKategori,Keterangan,LevelAkun,DebetOrKredit as [D/K],StatusJurnal,KodeAkunInduk,KodeCabang," & _
                "KodeAkunLama,KodeCompanyLama,IdKategoriLama,KeteranganLama,LevelAkunLama,DebetOrKreditLama as [D/KLama],StatusJurnalLama,KodeAkunIndukLama,KodeCabangLama," & _
                "case when FlagDelete = 0 then 'Diedit' else 'Dihapus' end as StatusPerubahan " & _
                "from tbACKodeAkunEdit where KodeCompany='" & kodecompany & "'"
        dgData.FirstInit(query, {0.5, _
                                 1, 1, 1, 2, 0.8, 0.5, 0.9, 1.2, 1, _
                                 1.3, 0.8, 1, 2.3, 1.1, 0.8, 1.2, 1.5, 1.3, 1.3}, , {"Ambil"}, {"KodeCompany", "IdKategori", "KodeCompanyLama", "IdKategoriLama"}, , , False)
        dgData.ConnString = pConnStr
        dgData.RefreshData(False)
    End Sub

    Private Sub cCall_CheckedChanged(sender As Object, e As EventArgs) Handles cCall.CheckedChanged
        Dim query As String = ""
        If cCall.Checked = True Then
            query = "select cast(1 as bit) as Ambil," & _
                "KodeAkun,KodeCompany,IdKategori,Keterangan,LevelAkun,DebetOrKredit as [D/K],StatusJurnal,KodeAkunInduk,KodeCabang," & _
                "KodeAkunLama,KodeCompanyLama,IdKategoriLama,KeteranganLama,LevelAkunLama,DebetOrKreditLama as [D/KLama],StatusJurnalLama,KodeAkunIndukLama,KodeCabangLama," & _
                "case when FlagDelete = 0 then 'Diedit' else 'Dihapus' end as StatusPerubahan " & _
                "from tbACKodeAkunEdit where KodeCompany='" & kodecompany & "'"
        Else
            query = "select cast(0 as bit) as Ambil," & _
                "KodeAkun,KodeCompany,IdKategori,Keterangan,LevelAkun,DebetOrKredit as [D/K],StatusJurnal,KodeAkunInduk,KodeCabang," & _
                "KodeAkunLama,KodeCompanyLama,IdKategoriLama,KeteranganLama,LevelAkunLama,DebetOrKreditLama as [D/KLama],StatusJurnalLama,KodeAkunIndukLama,KodeCabangLama," & _
                "case when FlagDelete = 0 then 'Diedit' else 'Dihapus' end as StatusPerubahan " & _
                "from tbACKodeAkunEdit where KodeCompany='" & kodecompany & "'"
        End If
        dgData.FirstInit(query, {0.5, _
                                1, 1, 1, 2, 0.8, 0.5, 0.9, 1.2, 1, _
                                1.3, 0.8, 1, 2.3, 1.1, 0.8, 1.2, 1.5, 1.3, 1.3}, , {"Ambil"}, {"KodeCompany", "IdKategori", "KodeCompanyLama", "IdKategoriLama"}, , , False)
        dgData.ConnString = pConnStr
        dgData.RefreshData(False)
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim drow() As DataRow
        drow = dgData.DataSource.select("Ambil = True")

        If Not drow.Length > 0 Then
            MsgBox("Pilih Data Yang Akan DiKembalikan Dulu!", vbCritical + vbOKOnly, "Peringatan")
        Else
            For i = 0 To drow.Length - 1
                If drow(i).Item("StatusPerubahan") = "Dihapus" Then
                    Dim ambilkodeakunedit As String = _
                        "select * from tbACKodeAkunEdit where KodeAkun='" & drow(i).Item("KodeAkun") & "'"
                    cmd = New SqlCommand(ambilkodeakunedit, kon)
                    dr = cmd.ExecuteReader
                    dr.Read()
                    Dim tambahkode As String = _
                        "insert into tbACKodeAkun (KodeAkun,Keterangan,LevelAkun,DebetOrKredit,IdKategori," & _
                        "StatusJurnal,KodeAkunInduk,KodeCabang,KodeCompany) values (" & _
                        "'" & dr!KodeAkun & "','" & dr!KeteranganLama & "','" & dr!LevelAkunLama & "','" & dr!DebetOrKreditLama & "','" & dr!IdKategoriLama & "'," & _
                        "'" & dr!StatusJurnalLama & "','" & dr!KodeAkunIndukLama & "','" & dr!KodeCabangLama & "')"
                    dr.Close()
                    cmd = New SqlCommand(tambahkode, kon)
                    cmd.ExecuteNonQuery()

                    Dim hapuskodeedit As String = _
                        "delete from tbACKodeAkunEdit where KodeAkun='" & drow(i).Item("KodeAkun") & "'"
                    cmd = New SqlCommand(hapuskodeedit, kon)
                    cmd.ExecuteNonQuery()

                ElseIf drow(i).Item("StatusPerubahan") = "Diedit" Then

                    Dim ubahjurnalori As String = _
                        "update tbACKodeAkun set KodeAkun='" & drow(i).Item("KodeAkunLama") & "',KodeCompany='" & drow(i).Item("KodeCompanyLama") & "',IdKategori='" & drow(i).Item("IdKategoriLama") & "'," & _
                        "Keterangan='" & drow(i).Item("KeteranganLama") & "',LevelAkun='" & drow(i).Item("LevelAkunLama") & "',DebetOrKredit='" & drow(i).Item(15) & "',StatusJurnal='" & drow(i).Item("StatusJurnalLama") & "'," & _
                        "KodeAkunInduk='" & drow(i).Item("KodeAkunIndukLama") & "',KodeCabang='" & drow(i).Item("KodeCabang") & "' where KodeAkun='" & drow(i).Item("KodeAkun") & "'"
                    cmd = New SqlCommand(ubahjurnalori, kon)
                    cmd.ExecuteNonQuery()

                    Dim hapuskodeedit As String = _
                        "delete from tbACKodeAkunEdit where KodeAkun='" & drow(i).Item("KodeAkun") & "'"
                    cmd = New SqlCommand(hapuskodeedit, kon)
                    cmd.ExecuteNonQuery()
                End If
            Next
            MsgBox("Reset Data Berhasil", vbInformation + vbOKOnly, "Informasi")
            loaddata()
        End If
    End Sub
End Class