Imports meCore
Imports System.Data.SqlClient

Public Class frmKodeAkunJurnal

    Private Sub frmKodeAkunJurnal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dBulan.Properties.DisplayFormat.FormatString = "yyyy MMMM"
        dBulan.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        dBulan.Properties.EditMask = "yyyy MMMM"
        dBulan.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView
        dBulan.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView

        dBulan.EditValue = Now

        cJenis.FirstInit(PubConnStr, "SELECT Jenis, ConnStr FROM mstUnitBukbes", , , , , , , , {"ConnStr"})
    End Sub

    Private Sub cJenis_EditValueChanged(sender As Object, e As EventArgs) Handles cJenis.EditValueChanged
        If cJenis.Text = "UE" Then
            tJenis.Text = "Data Source=10.10.2.23;Initial Catalog=BukbesAccUE;Persist Security Info=True;User ID=sa;Password=gogogo;Connection Timeout=0"
        Else
            tJenis.Text = "Data Source=10.10.2.23;Initial Catalog=BukbesAccUM;Persist Security Info=True;User ID=sa;Password=gogogo;Connection Timeout=0"
        End If

        koneksi(tJenis.Text)
        cCompany.FirstInit(tJenis.Text, "Select KodeCompany,Nama from tbGNCompany", {tCompany}, , , , , , {0.5, 1})
    End Sub

    Private Sub cCompany_EditValueChanged(sender As Object, e As EventArgs) Handles cCompany.EditValueChanged
        cKodeAkun.FirstInit(tJenis.Text, "select KodeAKun,Keterangan from tbACKodeAkun where KodeCompany='" & cCompany.Text & "'", {tKodeAkun})
    End Sub

    Private Sub btnAmbil_Click(sender As Object, e As EventArgs) Handles btnAmbil.Click
        isigrid()
    End Sub
    Sub isigrid()
        Dim data As String = _
        "select a.TanggalBukti,CONVERT(varchar(10),month(a.TanggalBukti)) as Bulan,CONVERT(varchar(10),year(a.TanggalBukti)) as Tahun,b.Nama as NamaLegal," & _
        "case when New='1' then '' else case when FlagPostingJurnalOri='1' then d.KodeAkunLama else a.KodeAkun end end as KodeAkun," & _
        "case when New='1' then '' else case when e.KodeAkun is null then (select Keterangan from tbACKodeAkun where kodeakun=(case when d.KodeAkunLama is not null then d.KodeAkunLama else a.KodeAkun end)) else e.KeteranganLama end end as NamaAkun," & _
        "case when FlagPostingJurnalOri is not null then d.KodeAkun else a.KodeAkun end as KodeAkunPajak," & _
        "(select Keterangan from tbACKodeAkun where kodeakun=case when FlagPostingJurnalOri is not null then d.KodeAkun else a.KodeAkun end) as NamaAkunPajak," & _
        "a.NoBukti, a.Keterangan, " & _
        "DebetInternal = case when New='1' then cast(0 as numeric(18)) else " & _
        "case when a.DebetOrKredit = 'D' then case when d.JumlahLama is not null then d.JumlahLama else a.Jumlah End else cast(0 as numeric(18)) end end," & _
        "KreditInternal = case when New='1' then cast(0 as numeric(18)) else " & _
        "case when a.DebetOrKredit = 'K' then case when d.JumlahLama is not null then d.JumlahLama else a.Jumlah End else cast(0 as numeric(18)) end end," & _
        "Internal = case when New='1' then cast(0 as numeric(18)) else case when a.DebetOrKredit = 'K' then " & _
        "case when d.JumlahLama is not null then d.JumlahLama * -1 else a.Jumlah * -1 End " & _
        "when a.DebetOrKredit = 'D' then " & _
        "case when d.JumlahLama is not null then d.JumlahLama else a.Jumlah End end end," & _
        "PenyesuaianDebet = case when a.DebetOrKredit = 'D' then " & _
        "case when New='1' then d.Jumlah else " & _
        "isnull(d.Jumlah,0) - isnull(d.JumlahLama,0) end else cast(0 as numeric(18)) end," & _
        "PenyesuaianKredit = case when a.DebetOrKredit = 'K' then " & _
        "case when New='1' then d.Jumlah else " & _
        "isnull(d.Jumlah,0) - isnull(d.JumlahLama,0) end else cast(0 as numeric(18)) end," & _
        "PenyesuaianKomersial = case when New='1' then " & _
        "case when a.DebetOrKredit='D' then d.Jumlah " & _
        "when a.DebetOrKredit='K' then d.Jumlah * -1 end " & _
        "else isnull(d.Jumlah,0) - isnull(d.JumlahLama,0) end," & _
        "DebetKomersial = " & _
            "case when a.DebetOrKredit = 'D' then " & _
            "	case when d.JumlahLama is null then a.Jumlah else d.Jumlah end " & _
            "else cast(0 as numeric(18)) end, " & _
        "KreditKomersial = " & _
            "case when a.DebetOrKredit = 'K' then " & _
            "	case when d.JumlahLama is null then a.Jumlah else d.Jumlah end " & _
            "else cast(0 as numeric(18)) end, " & _
        "Komersial = " & _
            "case when a.DebetOrKredit = 'K' then " & _
            "	case when d.JumlahLama is null then " & _
            "	a.Jumlah * -1 else d.Jumlah * -1 end " & _
            "when a.DebetOrKredit = 'D' then " & _
            "	case when d.JumlahLama is null then " & _
            "	a.Jumlah else d.Jumlah end " & _
            "end," & _
        "'' as Keterangan1 ," & _
        "ROW_NUMBER() over(Partition by a.kodeakun order by a.TanggalBukti) as urut,'TIDAK DIEDIT' as status,a.NoUrutAkun," & _
        "case when d.FlagDelete is null then 0 when d.FlagDelete is not null then d.FlagDelete end as FlagDelete," & _
        "d.NamaAkunPajak,d.KodeAkunLama,d.JumlahLama,d.New,a.DebetOrKredit " & _
        "from tbACJurnal a " & _
        "left join tbGNCompany b on b.KodeCompany = a.KodeCompany " & _
        "left join tbACKodeAkun c on a.KodeAkun = c.KodeAkun " & _
        "left join tbACJurnalEdit d on a.KodeAkunLama = d.KodeAkunLama and a.NoBukti=d.NoBukti and a.JumlahLama = d.JumlahLama and a.NoUrutAkun =d.NoUrutAkun and a.KodeCompany=d.KodeCompany " & _
        "left join tbACKodeAkunEdit e on a.KodeAkun = e.KodeAkunLama or a.KodeAkunLama = e.KodeAkun " & _
        "where substring(a.KodeAkun,1,2)='" & cCompany.Text & "' and month(a.TanggalBukti)='" & Format(dBulan.EditValue, "MM") & "' and year(a.TanggalBukti)='" & Format(dBulan.EditValue, "yyyy") & "'" & _
        "and (d.FlagDelete = 0 or d.FlagDelete is null) and (a.FlagPosting='1' or d.New is not null) " & _
        "order by KodeAkun,TanggalBukti"

        dgJurnal.FirstInit(data, _
                           {0.9, 0.4, 0.5, 1.5, _
                            1, 1.5, _
                            1.3, _
                            1.8, _
                            1.3, 1.8, _
                            1, 1, 1, _
                            1, 1, 1, _
                            1, 1, 1, _
                            1, 0.5, 0.5}, _
                        {"DebetInternal", "KreditInternal", "Internal", "DebetKomersial", "KreditKomersial", "Komersial", "PenyesuaianKomersial"}, _
                        {"PenyesuaianDebet", "PenyesuaianKredit", "KodeAkunPajak"}, {"DebetOrKredit", "New", "urut", "status", "NamaAkunPajak1", "FlagDelete", "KodeAkunLama", "JumlahLama", "Keterangan1"}, , 50, False, )
        dgJurnal.ConnString = tJenis.Text
        dgJurnal.RefreshData(False)
    End Sub
End Class