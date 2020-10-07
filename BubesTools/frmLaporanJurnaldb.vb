Imports meCore
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Repository.RepositoryItemComboBox
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid

Public Class frmLaporanJurnaldb

    Private Sub frmJurnaldb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cJenis.FirstInit(PubConnStr, "SELECT Jenis, ConnStr FROM mstUnitBukbes", {tJenis}, , , , , , , {"ConnStr"})
        LayoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

        dBulan.Properties.DisplayFormat.FormatString = "yyyy MMMM"
        dBulan.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        dBulan.Properties.EditMask = "yyyy MMMM"
        dBulan.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView
        dBulan.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView

        dBulan.EditValue = Now

        'cThn.Items.Clear()
        'For i = DateTime.Now.Year - 5 To DateTime.Now.Year
        '    cThn.Items.Add(i)
        'Next
    End Sub

    Private Sub btnAmbilData_Click(sender As Object, e As EventArgs) Handles btnAmbilData.Click
        If cCompany.Text = "" Then
            MsgBox("Data Filter Belum Lengkap!", vbCritical + vbOKOnly, "Peringatan")
        Else
            isigrid()
        End If
    End Sub
    Sub isigrid()
        Dim data As String = _
                "select a.TanggalBukti,CONVERT(varchar(10),month(a.TanggalBukti)) as Bulan,CONVERT(varchar(10),year(a.TanggalBukti)) as Tahun,b.Nama as NamaLegal," & _
                "case when d.KodeAkunLama is not null then d.KodeAkun else a.KodeAkun end as KodeAkun," & _
                "case when d.NamaAkunPajak is not null then d.NamaAkunPajak else c.Keterangan end as NamaAkun," & _
                "a.NoBukti, a.Keterangan, " & _
                "cast(0 as numeric(18)) as SaldoAwalKomersial," & _
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
                "cast(0 as numeric(18)) as SaldoAkhirKomersial," & _
                "'' as Keterangan1, " & _
                "ROW_NUMBER() over(Partition by case when d.KodeAkunLama is null then a.kodeakun else d.kodeakun end order by a.TanggalBukti) as urut,a.NoUrutAkun, " & _
                "case when d.FlagDelete is null then 0 when d.FlagDelete is not null then d.FlagDelete end as FlagDelete," & _
                "d.NamaAkunPajak,d.KodeAkunLama,d.JumlahLama " & _
                "from tbACJurnal a " & _
                "left join tbGNCompany b on b.KodeCompany = a.KodeCompany " & _
                "left join tbACKodeAkun c on a.KodeAkun = c.KodeAkun " & _
                "left join tbACJurnalEdit d on a.KodeAkun = d.KodeAkunLama and a.NoBukti=d.NoBukti and a.Jumlah = d.JumlahLama and a.NoUrutAkun =d.NoUrutAkun " & _
                "where substring(a.KodeAkun,1,2)='" & cCompany.Text & "' and month(a.TanggalBukti)='" & Format(dBulan.EditValue, "MM") & "' and year(a.TanggalBukti)='" & Format(dBulan.EditValue, "yyyy") & "' " & _
                "and (d.FlagDelete = 0 or d.FlagDelete is null) " & _
                "order by KodeAkun,TanggalBukti"

        'dgJurnal.gvMain.LoadingPanelVisible = True

        'da = New SqlDataAdapter(data, kon)
        'Dim ds As New DataSet
        'da.Fill(ds)

        'dgJurnal.DataSource = ds.Tables(0)
        'dgJurnal.gcMain.DataSource = ds.Tables(0)

        dgJurnal.FirstInit(data, {0.9, 0.4, 0.5, 1.5, _
                              1, 1.5, _
                              1.3, _
                              1.8, _
                              1.3, 1.8, _
                              1, 1, 1, _
                              1, 0.5, 0.5}, _
                          {"DebetKomersial", "KreditKomersial", "Komersial", "SaldoAwalKomersial", "SaldoAkhirKomersial"} _
                          , , {"urut", "NoUrutAkun", "FlagDelete", "NamaAkunPajak", "KodeAkunLama", "JumlahLama", "Keterangan1"} _
                          , , 50, False, , , , )
        dgJurnal.ConnString = tJenis.Text
        dgJurnal.RefreshData(False)

        'dgJurnal.colWidth = {0.9, 0.4, 0.5, 1.5, _
        '                      1, 1.5, _
        '                      1.3, _
        '                      1.8, _
        '                      1.3, 1.8, _
        '                      1, 1, 1, _
        '                      1, 0.5, 0.5}
        'dgJurnal.ColHeaderHeight = 50
        'dgJurnal.colFitGrid = False
        'dgJurnal.colSum = {"DebetKomersial", "KreditKomersial", "Komersial", "SaldoAwalKomersial", "SaldoAkhirKomersial"}
        'dgJurnal.colVisibleFalse = {"urut", "NoUrutAkun", "FlagDelete", "NamaAkunPajak", "KodeAkunLama", "JumlahLama", "Keterangan1"}
        'dgJurnal.RefreshDataView()
        'dgJurnal.gvMain.LoadingPanelVisible = False
        pasangsaldoawal()
    End Sub

    Sub pasangsaldoawal()
        Dim kodesekarang As String = ""
        Dim urut As Integer = 0
        Dim komersial As Long = 0
        Dim tgl As Date = Format(dBulan.EditValue, "yyyy") & "/" & Format(dBulan.EditValue, "MM") & "/01"
        Dim tglblnbefore As String = Format(DateAdd(DateInterval.Day, -1, tgl), "yyyyMMdd")

        For a = 0 To dgJurnal.gvMain.RowCount - 1
            kodesekarang = dgJurnal.GetRowCellValue(a, "KodeAkun")
            urut = dgJurnal.GetRowCellValue(a, "urut")
            komersial = dgJurnal.GetRowCellValue(a, "Komersial")
            If urut = 1 Then
                Dim carisaldo As String = _
                    "with ctejurnal as(" & _
                    "select distinct KodeAkun from tbACJurnal " & _
                    "where month(TanggalBukti)='" & Format(dBulan.EditValue, "MM") & "' and year(tanggalbukti)='" & Format(dBulan.EditValue, "yyyy") & "' and substring(KodeAkun,1,2)='" & cCompany.Text & "'" & _
                    "), " & _
                    "ctejmlDebet as(" & _
                    "select KodeAkun,sum(jumlah) as jumlahDebet from tbACJurnal " & _
                    "where DebetOrKredit='D' and TanggalBukti <= '" & tglblnbefore & "' " & _
                    "group by KodeAkun" & _
                    "), " & _
                    "ctejmlKredit as(" & _
                    "select KodeAkun,sum(jumlah) as jumlahKredit from tbACJurnal " & _
                    "where DebetOrKredit='K' and TanggalBukti <= '" & tglblnbefore & "' " & _
                    "group by KodeAkun" & _
                    ") " & _
                    "select a.KodeAkun, isnull((b.jumlahDebet - c.jumlahKredit),0) as Jml from ctejurnal a " & _
                    "left join ctejmlDebet b on a.KodeAkun = b.KodeAkun " & _
                    "left join ctejmlKredit c on a.KodeAkun =c.KodeAkun " & _
                    "where a.KodeAkun='" & kodesekarang & "'"
                cmd = New SqlCommand(carisaldo, kon)
                dr = cmd.ExecuteReader
                dr.Read()

                'if null maka buat 0
                Dim jml As Double = 0
                If Not dr.HasRows Then
                    jml = 0
                End If

                dgJurnal.SetRowCellValue(a, "SaldoAwalKomersial", jml)
                dgJurnal.SetRowCellValue(a, "SaldoAkhirKomersial", dgJurnal.GetRowCellValue(a, "SaldoAwalKomersial") + dgJurnal.GetRowCellValue(a, "Komersial"))
                dr.Close()
            Else
                dgJurnal.SetRowCellValue(a, "SaldoAwalKomersial", dgJurnal.GetRowCellValue(a - 1, "SaldoAkhirKomersial"))
                dgJurnal.SetRowCellValue(a, "SaldoAkhirKomersial", dgJurnal.GetRowCellValue(a, "SaldoAwalKomersial") + dgJurnal.GetRowCellValue(a, "Komersial"))
            End If
        Next
    End Sub

    Private Sub dgJurnal_Grid_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles dgJurnal.Grid_ValidateRow
        'Dim jenis As String = ""
        'If dgJurnal.GetRowCellValue(e.RowHandle, "DebetInternal") = "0" Or dgJurnal.GetRowCellValue(e.RowHandle, "DebetInternal") = "0.0" Or IsDBNull(dgJurnal.GetRowCellValue(e.RowHandle, "DebetInternal")) Then
        '    jenis = "KREDIT"
        '    dgJurnal.SetRowCellValue(e.RowHandle, "PenyesuaianDebet", 0)
        'ElseIf dgJurnal.GetRowCellValue(e.RowHandle, "KreditInternal") = "0" Or dgJurnal.GetRowCellValue(e.RowHandle, "KreditInternal") = "0.0" Or IsDBNull(dgJurnal.GetRowCellValue(e.RowHandle, "KreditInternal")) Then
        '    jenis = "DEBET"
        '    dgJurnal.SetRowCellValue(e.RowHandle, "PenyesuaianKredit", 0)
        'End If

        'If IsDBNull(dgJurnal.GetRowCellValue(e.RowHandle, "PenyesuaianDebet")) Then
        '    dgJurnal.SetRowCellValue(e.RowHandle, "PenyesuaianDebet", 0)
        'End If
        'If IsDBNull(dgJurnal.GetRowCellValue(e.RowHandle, "PenyesuaianKredit")) Then
        '    dgJurnal.SetRowCellValue(e.RowHandle, "PenyesuaianKredit", 0)
        'End If

        'If jenis = "DEBET" Then
        '    dgJurnal.SetRowCellValue(e.RowHandle, "PenyesuaianKomersial", dgJurnal.GetRowCellValue(e.RowHandle, "PenyesuaianDebet"))
        '    dgJurnal.SetRowCellValue(e.RowHandle, "DebetKomersial", dgJurnal.GetRowCellValue(e.RowHandle, "PenyesuaianDebet") + dgJurnal.GetRowCellValue(e.RowHandle, "DebetInternal"))
        '    dgJurnal.SetRowCellValue(e.RowHandle, "KreditKomersial", 0)
        'ElseIf jenis = "KREDIT" Then
        '    Dim kredit As Double = -1 * dgJurnal.GetRowCellValue(e.RowHandle, "PenyesuaianKredit")
        '    dgJurnal.SetRowCellValue(e.RowHandle, "PenyesuaianKomersial", kredit)
        '    dgJurnal.SetRowCellValue(e.RowHandle, "KreditKomersial", dgJurnal.GetRowCellValue(e.RowHandle, "PenyesuaianKredit") + dgJurnal.GetRowCellValue(e.RowHandle, "KreditInternal"))
        '    dgJurnal.SetRowCellValue(e.RowHandle, "DebetKomersial", 0)
        'End If

        'If dgJurnal.GetRowCellValue(e.RowHandle, "DebetKomersial") = 0 Then
        '    If IsDBNull(dgJurnal.GetRowCellValue(e.RowHandle, "DebetInternal")) Then
        '        dgJurnal.SetRowCellValue(e.RowHandle, "DebetKomersial", 0)
        '    Else
        '        dgJurnal.SetRowCellValue(e.RowHandle, "DebetKomersial", dgJurnal.GetRowCellValue(e.RowHandle, "DebetInternal"))
        '    End If
        'End If

        'If dgJurnal.GetRowCellValue(e.RowHandle, "KreditKomersial") = 0 Then
        '    If IsDBNull(dgJurnal.GetRowCellValue(e.RowHandle, "KreditInternal")) Then
        '        dgJurnal.SetRowCellValue(e.RowHandle, "KreditKomersial", 0)
        '    Else
        '        dgJurnal.SetRowCellValue(e.RowHandle, "KreditKomersial", dgJurnal.GetRowCellValue(e.RowHandle, "KreditInternal"))
        '    End If
        'End If

        'dgJurnal.SetRowCellValue(e.RowHandle, "Komersial", dgJurnal.GetRowCellValue(e.RowHandle, "DebetKomersial") - dgJurnal.GetRowCellValue(e.RowHandle, "KreditKomersial"))
        'dgJurnal.SetRowCellValue(e.RowHandle, "SaldoAkhirKomersial", dgJurnal.GetRowCellValue(e.RowHandle, "SaldoAwalKomersial") + dgJurnal.GetRowCellValue(e.RowHandle, "Komersial"))
    End Sub

    Private Sub cJenis_EditValueChanged(sender As Object, e As EventArgs) Handles cJenis.EditValueChanged
        koneksi(tJenis.Text)
        cCompany.FirstInit(tJenis.Text, "Select KodeCompany,Nama from tbGNCompany", {tNama}, , , , , , {0.5, 1})
    End Sub
End Class