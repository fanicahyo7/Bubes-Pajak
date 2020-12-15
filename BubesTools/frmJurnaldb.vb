Imports meCore
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
'Imports DevExpress.XtraEditors.Repository.RepositoryItemComboBox
Imports DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid

Public Class frmJurnaldb
    'Dim WithEvents _riEditor As New RepositoryItemComboBox()
    Dim WithEvents _riEditor As New RepositoryItemSearchLookUpEdit()

    Dim ConnStrBB As String = ""

    Private Sub frmJurnaldb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dBulan.Properties.DisplayFormat.FormatString = "yyyy MMMM"
        dBulan.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        dBulan.Properties.EditMask = "yyyy MMMM"
        dBulan.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView
        dBulan.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView

        dBulan.EditValue = Now

        'cJenis.FirstInit(PubConnStr, "SELECT Jenis, ConnStr FROM mstUnitBukbes", {tJenis}, , , , , , , {"ConnStr"})
        cJenis.FirstInit(PubConnStr, "SELECT Jenis, ConnStr FROM mstUnitBukbes", , , , , , , , {"ConnStr"})
    End Sub

    Private Sub cJenis_EditValueChanged(sender As Object, e As EventArgs) Handles cJenis.EditValueChanged
        If cJenis.Text = "UE" Then
            tJenis.Text = "Data Source=10.10.2.23;Initial Catalog=BukbesAccUE;Persist Security Info=True;User ID=sa;Password=gogogo;Connection Timeout=0"
        Else
            tJenis.Text = "Data Source=10.10.2.23;Initial Catalog=BukbesAccUM;Persist Security Info=True;User ID=sa;Password=gogogo;Connection Timeout=0"
        End If

        koneksi(tJenis.Text)
        cCompany.FirstInit(tJenis.Text, "Select KodeCompany,Nama from tbGNCompany", {tNama}, , , , , , {0.5, 1})
    End Sub

    Private Sub btnAmbilData_Click(sender As Object, e As EventArgs) Handles btnAmbilData.Click
        If cCompany.Text = "" Then
            MsgBox("Data Filter Belum Lengkap!", vbCritical + vbOKOnly, "Peringatan")
        Else
            isigrid()
            cekposting()
            btnHistory.Enabled = True
        End If
    End Sub

    Sub isigrid()
        Dim data As String = _
        "select a.TanggalBukti,CONVERT(varchar(10),month(a.TanggalBukti)) as Bulan,CONVERT(varchar(10),year(a.TanggalBukti)) as Tahun,b.Nama as NamaLegal," & _
        "case when New='1' then '' else case when FlagPostingJurnalOri='1' then d.KodeAkunLama else case when a.KodeAkunLama is null then a.KodeAkun else a.KodeAkunLama end end end as KodeAkun," & _
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

        dgJurnal.gcMain.ForceInitialize()
        Dim query As String = "select KodeAkun,Keterangan from tbACKodeAkun " & _
            "where KodeCompany='" & cCompany.Text & "' and StatusJurnal='1' order by KodeAkun asc"

        Dim dt As New DataTable
        da = New SqlDataAdapter(query, kon)
        da.Fill(dt)
        _riEditor.DataSource = dt
        _riEditor.DisplayMember = "KodeAkun"
        _riEditor.ValueMember = "KodeAkun"

        dgJurnal.gcMain.RepositoryItems.Add(_riEditor)
        dgJurnal.gvMain.Columns(6).ColumnEdit = _riEditor

    End Sub

    Private Sub dgJurnal_Grid_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles dgJurnal.Grid_ValidateRow
        Dim jenis As String = ""

        dgJurnal.SetRowCellValue(e.RowHandle, "status", "DIEDIT")

        If Not dgJurnal.GetRowCellValue(e.RowHandle, "PenyesuaianDebet") = "0" And Not dgJurnal.GetRowCellValue(e.RowHandle, "KreditInternal") = "0" Then
            dgJurnal.SetRowCellValue(e.RowHandle, "status", "TIDAK DIEDIT")
        ElseIf Not dgJurnal.GetRowCellValue(e.RowHandle, "PenyesuaianKredit") = "0" And Not dgJurnal.GetRowCellValue(e.RowHandle, "DebetInternal") = "0" Then
            dgJurnal.SetRowCellValue(e.RowHandle, "status", "TIDAK DIEDIT")
        End If

        Dim slsi As String = ""
        If Not IsDBNull(dgJurnal.GetRowCellValue(e.RowHandle, "New")) Then
            slsi = "BARU"
        ElseIf dgJurnal.GetRowCellValue(e.RowHandle, "New").ToString = "1" Then
            slsi = "BARU"
        End If

        If Not slsi = "BARU" Then
            If dgJurnal.GetRowCellValue(e.RowHandle, "DebetInternal") = "0" Or dgJurnal.GetRowCellValue(e.RowHandle, "DebetInternal") = "0.0" Or IsDBNull(dgJurnal.GetRowCellValue(e.RowHandle, "DebetInternal")) Then
                jenis = "KREDIT"
                dgJurnal.SetRowCellValue(e.RowHandle, "PenyesuaianDebet", 0)
            ElseIf dgJurnal.GetRowCellValue(e.RowHandle, "KreditInternal") = "0" Or dgJurnal.GetRowCellValue(e.RowHandle, "KreditInternal") = "0.0" Or IsDBNull(dgJurnal.GetRowCellValue(e.RowHandle, "KreditInternal")) Then
                jenis = "DEBET"
                dgJurnal.SetRowCellValue(e.RowHandle, "PenyesuaianKredit", 0)
            End If
        Else
            If dgJurnal.GetRowCellValue(e.RowHandle, "DebetOrKredit") = "D" Then
                jenis = "DEBET"
                dgJurnal.SetRowCellValue(e.RowHandle, "PenyesuaianKredit", 0)
            ElseIf dgJurnal.GetRowCellValue(e.RowHandle, "DebetOrKredit") = "K" Then
                jenis = "KREDIT"
                dgJurnal.SetRowCellValue(e.RowHandle, "PenyesuaianDebet", 0)
            End If
        End If

        If IsDBNull(dgJurnal.GetRowCellValue(e.RowHandle, "PenyesuaianDebet")) Then
            dgJurnal.SetRowCellValue(e.RowHandle, "PenyesuaianDebet", 0)
        End If
        If IsDBNull(dgJurnal.GetRowCellValue(e.RowHandle, "PenyesuaianKredit")) Then
            dgJurnal.SetRowCellValue(e.RowHandle, "PenyesuaianKredit", 0)
        End If

        If jenis = "DEBET" Then
            dgJurnal.SetRowCellValue(e.RowHandle, "PenyesuaianKomersial", dgJurnal.GetRowCellValue(e.RowHandle, "PenyesuaianDebet"))
            dgJurnal.SetRowCellValue(e.RowHandle, "DebetKomersial", dgJurnal.GetRowCellValue(e.RowHandle, "PenyesuaianDebet") + dgJurnal.GetRowCellValue(e.RowHandle, "DebetInternal"))
            dgJurnal.SetRowCellValue(e.RowHandle, "KreditKomersial", 0)
        ElseIf jenis = "KREDIT" Then
            Dim kredit As Double = -1 * dgJurnal.GetRowCellValue(e.RowHandle, "PenyesuaianKredit")
            dgJurnal.SetRowCellValue(e.RowHandle, "PenyesuaianKomersial", kredit)
            dgJurnal.SetRowCellValue(e.RowHandle, "KreditKomersial", dgJurnal.GetRowCellValue(e.RowHandle, "PenyesuaianKredit") + dgJurnal.GetRowCellValue(e.RowHandle, "KreditInternal"))
            dgJurnal.SetRowCellValue(e.RowHandle, "DebetKomersial", 0)
        End If

        If dgJurnal.GetRowCellValue(e.RowHandle, "DebetKomersial") = 0 And dgJurnal.GetRowCellValue(e.RowHandle, "DebetInternal") = 0 Then
            If IsDBNull(dgJurnal.GetRowCellValue(e.RowHandle, "DebetInternal")) Then
                dgJurnal.SetRowCellValue(e.RowHandle, "DebetKomersial", 0)
            Else
                dgJurnal.SetRowCellValue(e.RowHandle, "DebetKomersial", dgJurnal.GetRowCellValue(e.RowHandle, "DebetInternal"))
            End If
        End If

        If dgJurnal.GetRowCellValue(e.RowHandle, "KreditKomersial") = 0 And dgJurnal.GetRowCellValue(e.RowHandle, "KreditInternal") = 0 Then
            If IsDBNull(dgJurnal.GetRowCellValue(e.RowHandle, "KreditInternal")) Then
                dgJurnal.SetRowCellValue(e.RowHandle, "KreditKomersial", 0)
            Else
                dgJurnal.SetRowCellValue(e.RowHandle, "KreditKomersial", dgJurnal.GetRowCellValue(e.RowHandle, "KreditInternal"))
            End If
        End If

        dgJurnal.SetRowCellValue(e.RowHandle, "Komersial", dgJurnal.GetRowCellValue(e.RowHandle, "DebetKomersial") - dgJurnal.GetRowCellValue(e.RowHandle, "KreditKomersial"))
    End Sub

    Private Sub _riEditor_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles _riEditor.EditValueChanging
        Dim kondisi As String = ""
        If Microsoft.VisualBasic.Left(dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "NoBukti"), 3) = "MEM" Then
            kondisi = "MEMJPU"
        ElseIf Microsoft.VisualBasic.Left(dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "NoBukti"), 3) = "JPU" Then
            kondisi = "MEMJPU"
        End If

        If dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "NoUrutAkun") = "1" And Not kondisi = "MEMJPU" Then
            Dim cekbank As String = _
                "select * from tbACKasBank where KodeAkun='" & e.NewValue & "'"
            cmd = New SqlCommand(cekbank, kon)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                MsgBox("Kode " & e.NewValue & " Tidak Memiliki Kode Bank untuk menjadi VoucherHeader!", vbCritical + vbOKOnly, "Peringatan")
                e.NewValue = e.OldValue
                dr.Close()
                Exit Sub
            End If
            dr.Close()
        End If

        Dim konfirmasi As String = MsgBox("Apakah Anda Yakin Mengubah" & vbCrLf & "Kode Akun " & e.OldValue & " Menjadi " & e.NewValue & " ?", vbQuestion + vbYesNo, "Konfirmasi")
        If konfirmasi = vbYes Then
            Dim query As String = "select KodeAkun,Keterangan from tbACKodeAkun where KodeAkun='" & e.NewValue & "'"
            cmd = New SqlCommand(query, kon)
            dr = cmd.ExecuteReader
            dr.Read()
            dgJurnal.SetRowCellValue(dgJurnal.FocusedRowHandle, "NamaAkunPajak", dr!Keterangan)
            dr.Close()
            dgJurnal.SetRowCellValue(dgJurnal.FocusedRowHandle, "status", "DIEDIT")
        Else
            e.NewValue = e.OldValue
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dgJurnal.gvMain.RowCount = 0 Then
            MsgBox("Tidak Ada Data", vbCritical + vbOKOnly, "Peringatan")
        Else
            Dim konfirmasi As String = MsgBox("Apakah Anda Yakin Menghapus Jurnal Dengan No.Bukti " & dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "NoBukti") & " Dan Kode Akun " & dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "KodeAkun") & "?", vbQuestion + vbYesNo, "Konfirmasi")
            If konfirmasi = vbYes Then
                dgJurnal.gvMain.LoadingPanelVisible = True
                Dim kdakunlma As String = ""
                If IsDBNull(dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "KodeAkunLama")) Then
                    kdakunlma = ""
                Else
                    kdakunlma = dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "KodeAkunLama")
                End If

                Dim kdakun As String = ""
                If dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "KodeAkunPajak") = kdakun Then
                    kdakun = "KodeAkun='" & dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "KodeAkun") & "'"
                Else
                    kdakun = "KodeAkun='" & dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "KodeAkunPajak") & "' and KodeAkunLama='" & dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "KodeAkunLama") & "'"
                End If

                Dim querycekjurnaledit As String = _
                    "select * from tbACJurnalEdit where NoBukti='" & dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "NoBukti") & "' and " & kdakun & " and NoUrutAkun='" & dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "NoUrutAkun") & "'"
                cmd = New SqlCommand(querycekjurnaledit, kon)
                dr = cmd.ExecuteReader
                dr.Read()
                Dim query As String = ""
                If dr.HasRows Then
                    query = "update tbACJurnalEdit set FlagDelete = '1',FlagPostingJurnalOri='0' where NoBukti='" & dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "NoBukti") & "' and KodeAkun='" & dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "KodeAkunPajak") & "' and NoUrutAkun='" & dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "NoUrutAkun") & "'"
                    dr.Close()
                Else
                    dr.Close()
                    Dim kodeakun As String = ""
                    If IsDBNull(dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "KodeAkunPajak")) Or dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "KodeAkunPajak") = "" Then
                        kodeakun = dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "KodeAkun")
                    Else
                        kodeakun = dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "KodeAkunPajak")
                    End If

                    Dim jml As Double = 0
                    If Not dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "DebetKomersial") = "0" Then
                        jml = dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "Komersial")
                    End If
                    If Not dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "KreditKomersial") = "0" Then
                        jml = dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "Komersial") * -1
                    End If

                    Dim kondisi As String = ""
                    If Microsoft.VisualBasic.Left(dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "NoBukti"), 3) = "MEM" Then
                        kondisi = "MEMJPU"
                    ElseIf Microsoft.VisualBasic.Left(dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "NoBukti"), 3) = "JPU" Then
                        kondisi = "MEMJPU"
                    End If

                    If Not kondisi = "MEMJPU" Then
                        If dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "NoUrutAkun") = "1" Then
                            Dim idbanklama As String = ""
                            Dim idbanksekarang As String = ""
                            Dim caribanklama As String = _
                                "select * from tbACKasBank where KodeAkun='" & dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "KodeAkun") & "'"
                            cmd = New SqlCommand(caribanklama, kon)
                            dr = cmd.ExecuteReader
                            dr.Read()
                            idbanklama = dr!IdBank
                            dr.Close()

                            Dim caribanksekarang As String = _
                                "select * from tbACKasBank where KodeAkun='" & dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "KodeAkunPajak") & "'"
                            cmd = New SqlCommand(caribanksekarang, kon)
                            dr = cmd.ExecuteReader
                            dr.Read()
                            idbanksekarang = dr!IdBank
                            dr.Close()

                            Dim carivoucherHd As String = _
                                "select * from tbACVoucherHd where Nomor='" & dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "NoBukti") & "' and IdBank='" & idbanklama & "'"
                            cmd = New SqlCommand(carivoucherHd, kon)
                            dr = cmd.ExecuteReader
                            dr.Read()

                            Dim datetimeentryhd As DateTime
                            Dim stringdateenrtyhd1 As String = ""
                            Dim stringdateentryhd2 As String = ""
                            If Not IsDBNull(dr!DateTimeEntry) Then
                                datetimeentryhd = dr!DateTimeEntry
                                stringdateenrtyhd1 = ",DateTimeEntry"
                                stringdateentryhd2 = ",'" & datetimeentryhd.ToString("yyyy-MM-dd hh:mm:ss") & "'"
                            End If

                            Dim tglhd As DateTime = dr!Tanggal
                            Dim stringtglhd1 As String = ""
                            Dim stringtglhd2 As String = ""
                            If Not IsDBNull(dr!Tanggal) Then
                                tglhd = dr!Tanggal
                                stringtglhd1 = ",Tanggal"
                                stringtglhd2 = ",'" & tglhd.ToString("yyyy-MM-dd hh:mm:ss") & "'"
                            End If

                            Dim datetimeupdatehd As DateTime
                            Dim stringdateupdatehd1 As String = ""
                            Dim stringdateupdatehd2 As String = ""
                            If Not IsDBNull(dr!DateTimeUpdate) Then
                                datetimeupdatehd = dr!DateTimeUpdate
                                stringdateupdatehd1 = ",DateTimeUpdate"
                                stringdateupdatehd2 = ",'" & datetimeupdatehd.ToString("yyyy-MM-dd hh:mm:ss") & "'"
                            End If

                            Dim querysimpanvoucherhd As String = _
                                "insert into tbACVoucherHdEdit (Nomor" & stringtglhd1 & ",KodeCompany,IdBank,FlagTransaksi," & _
                                "Keterangan1,Keterangan,Total,NoCekBG,BankCekBG," & _
                                "FlagTunai,FlagValidasi,FlagPosting,Catatan," & _
                                "UserEntry" & stringdateenrtyhd1 & ",UserUpdate" & stringdateupdatehd1 & ",NoUrut," & _
                                "cek,TadaID,NoRef,FlagDelete,FlagPostingOri) values (" & _
                                "'" & dr!Nomor & "'" & stringtglhd2 & ",'" & dr!KodeCompany & "','" & idbanklama & "','" & dr!FlagTransaksi & "'," & _
                                "'" & dr!Keterangan1 & "','" & dr!Keterangan & "','" & dr!Total & "','" & dr!NoCekBG & "','" & dr!BankCekBG & "'," & _
                                "'" & dr!FlagTunai & "','" & dr!FlagValidasi & "','" & dr!FlagPosting & "','" & dr!Catatan & "'," & _
                                "'" & dr!UserEntry & "'" & stringdateentryhd2 & ",'" & dr!UserUpdate & "'" & stringdateupdatehd2 & ",'" & dr!NoUrut & "'," & _
                                "'" & dr!cek & "','" & dr!TadaID & "','" & dr!NoRef & "','1','0')"
                            ' "cek,TadaID,NoRef,IdBankLama,TotalLama,FlagDelete,FlagPostingOri) values (" & _
                            '"'" & dr!cek & "','" & dr!TadaID & "','" & dr!NoRef & "','" & idbanklama & "','" & dr!Total & "','1','0')"
                            dr.Close()
                            cmd = New SqlCommand(querysimpanvoucherhd, kon)
                            cmd.ExecuteNonQuery()
                        Else
                            Dim carivoucherDt As String = _
                                "select * from tbACVoucherDt where Nomor='" & dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "NoBukti") & "' and KodeAkun='" & dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "KodeAkun") & "' and NoUrut='" & dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "NoUrutAkun") - 1 & "'"
                            cmd = New SqlCommand(carivoucherDt, kon)
                            dr = cmd.ExecuteReader
                            dr.Read()

                            Dim datetimeentrydt As DateTime
                            Dim stringdateenrtydt1 As String = ""
                            Dim stringdateentrydt2 As String = ""
                            If Not IsDBNull(dr!DateTimeEntry) Then
                                datetimeentrydt = dr!DateTimeEntry
                                stringdateenrtydt1 = ",DateTimeEntry"
                                stringdateentrydt2 = ",'" & datetimeentrydt.ToString("yyyy-MM-dd hh:mm:ss") & "'"
                            End If

                            Dim datetimeupdatedt As DateTime
                            Dim stringdateupdatedt1 As String = ""
                            Dim stringdateupdatedt2 As String = ""
                            If Not IsDBNull(dr!DateTimeUpdate) Then
                                datetimeupdatedt = dr!DateTimeUpdate
                                stringdateupdatedt1 = ",DateTimeUpdate"
                                stringdateupdatedt2 = ",'" & datetimeupdatedt.ToString("yyyy-MM-dd hh:mm:ss") & "'"
                            End If

                            Dim simpanvoucherdt As String = _
                                "insert into tbACVoucherDtEdit (Nomor,NoUrut,KodeAkun,KodeCabang,IdDepartemen," & _
                                "Keterangan,Jumlah,Saldo,UserEntry" & stringdateenrtydt1 & "," & _
                                "UserUpdate" & stringdateupdatedt1 & ",NoRecord,Cek,TadaID," & _
                                "FlagPostingOri,FlagDelete) values (" & _
                                "'" & dr!Nomor & "','" & dr!NoUrut & "','" & dr!KodeAkun & "','" & dr!KodeCabang & "','" & dr!IdDepartemen & "'," & _
                                "'" & dr!Keterangan & "','" & dr!Jumlah & "','" & dr!Saldo & "','" & dr!UserEntry & "'" & stringdateentrydt2 & "," & _
                                "'" & dr!UserUpdate & "'" & stringdateupdatedt2 & ",'" & dr!NoRecord & "','" & dr!Cek & "','" & dr!TadaID & "'," & _
                                "'0','1')"
                            '"KodeAkunLama,JumlahLama,FlagPostingOri,FlagDelete) values (" & _
                            '"'" & dr!KodeAkun & "','" & dr!Jumlah & "','0','1')"
                            dr.Close()
                            cmd = New SqlCommand(simpanvoucherdt, kon)
                            cmd.ExecuteNonQuery()
                        End If
                    End If

                    Dim caridata As String = _
                        "select * from tbACJurnal where NoBukti='" & dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "NoBukti") & "' and KodeAkun='" & dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "KodeAkun") & "' " & _
                            "and NoUrutAkun='" & dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "NoUrutAkun") & "'"
                    cmd = New SqlCommand(caridata, kon)
                    dr = cmd.ExecuteReader
                    dr.Read()

                    Dim datetimeentryacjurnal As DateTime
                    Dim stringdateentryacjurnal1 As String = ""
                    Dim stringdateentryacjurnal2 As String = ""
                    If Not IsDBNull(dr!DateTimeEntry) Then
                        datetimeentryacjurnal = dr!DateTimeEntry
                        stringdateentryacjurnal1 = ",DateTimeEntry"
                        stringdateentryacjurnal2 = ",'" & datetimeentryacjurnal.ToString("yyyy-MM-dd hh:mm:ss") & "'"
                    End If

                    Dim postingdate As DateTime
                    Dim stringpostingdate1 As String = ""
                    Dim stringpostingdate2 As String = ""
                    If Not IsDBNull(dr!PostingDate) Then
                        postingdate = dr!PostingDate
                        stringpostingdate1 = ",PostingDate"
                        stringpostingdate2 = ",'" & postingdate.ToString("yyyy-MM-dd hh:mm:ss") & "'"
                    End If

                    Dim tglbukti As DateTime
                    Dim stringtglbukti1 As String = ""
                    Dim stringtglbukti2 As String = ""
                    If Not IsDBNull(dr!TanggalBukti) Then
                        tglbukti = dr!TanggalBukti
                        stringtglbukti1 = ",TanggalBukti"
                        stringtglbukti2 = ",'" & tglbukti.ToString("yyyy-MM-dd hh:mm:ss") & "'"
                    End If

                    query = _
                        "insert into tbACJurnalEdit (KodeCompany,NoBukti" & stringtglbukti1 & ",Tipe,KodeCabang," & _
                        "IdDepartemen,KodeAkun,NoUrutAkun,Keterangan,Jumlah," & _
                        "DebetOrKredit,FlagPosting" & stringpostingdate1 & ",IdTransaksi,UserEntry" & _
                        "" & stringdateentryacjurnal1 & ",NoRecord,TadaID,KodeAkunLama,JumlahLama,NamaAkunPajak,FlagDelete) values (" & _
                        "'" & dr!KodeCompany & "','" & dr!NoBukti & "'" & stringtglbukti2 & ",'" & dr!Tipe & "','" & dr!KodeCabang & "'," & _
                        "'" & dr!IdDepartemen & "','" & dr!KodeAkun & "','" & dr!NoUrutAkun & "','" & dr!Keterangan & "','" & dr!Jumlah & "'," & _
                        "'" & dr!DebetOrKredit & "','" & dr!FlagPosting & "'" & stringpostingdate2 & ",'" & dr!IdTransaksi & "','" & dr!UserEntry & "'" & _
                        "" & stringdateentryacjurnal2 & ",'" & dr!NoRecord & "','" & dr!TadaID & "','" & dr!KodeAkun & "','" & dr!Jumlah & "','" & dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "NamaAkunPajak") & "','1')"
                    '"IdDepartemen,KodeAkun,NoUrutAkun,Keterangan,Jumlah," & _
                    '"'" & dr!IdDepartemen & "','" & kodeakun & "','" & dr!NoUrutAkun & "','" & dr!Keterangan & "','" & jml & "'," & _
                    '"DateTimeEntry,NoRecord,TadaID,KodeAkunLama,JumlahLama,NamaAkunPajak,FlagDelete) values (" & _
                    '"'" & datetimeentry.ToString("yyyy-MM-dd hh:mm:ss") & "','" & dr!NoRecord & "','" & dr!TadaID & "','" & dr!KodeAkun & "','" & dr!Jumlah & "','" & dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "NamaAkunPajak") & "','1')"
                    Dim editjurnalori As String = _
                        "update tbACJurnal set KodeAkunLama='" & dr!KodeAkun & "',JumlahLama='" & dr!Jumlah & "' " & _
                        "where NoBukti='" & dr!NoBukti & "' and NoUrutAkun='" & dr!NoUrutAkun & "' and KodeCompany='" & dr!KodeCompany & "' and KodeAkun='" & dr!KodeAkun & "'"

                    dr.Close()

                    cmd = New SqlCommand(editjurnalori, kon)
                    cmd.ExecuteNonQuery()
                End If
                cmd = New SqlCommand(query, kon)
                cmd.ExecuteNonQuery()

                MsgBox("Hapus Data Berhasil", vbInformation + vbOKOnly, "Informasi")
                isigrid()
                dgJurnal.gvMain.LoadingPanelVisible = False
            End If
            cekposting()
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If dgJurnal.gvMain.RowCount = 0 Then
            MsgBox("Tidak Ada Data", vbCritical + vbOKOnly, "Peringatan")
        Else
            Dim jmlkomersial As Double = dgJurnal.GetSummaryColDB("Komersial")
            If Not Math.Round(jmlkomersial, 0) = 0 Then
                MsgBox("TIDAK BALANCE!" & vbCrLf & "Data Tidak Dapat Disimpan!", vbCritical + vbOKOnly, "Peringatan")
            Else
                Dim konfirmasi As String = MsgBox("Apakah Anda Yakin Menyimpan Perubahan?", vbQuestion + vbYesNo, "Konfirmasi")
                If konfirmasi = vbYes Then
                    Dim data() As DataRow
                    data = dgJurnal.DataSource.Select("status = 'DIEDIT'")

                    If data.Length = 0 Then
                        MsgBox("Tidak Ada yang Diubah!", vbCritical + vbOKOnly, "Peringatan")
                        Exit Sub
                    Else
                        dgJurnal.gvMain.LoadingPanelVisible = True
                        For i = 0 To data.Count - 1
                            Dim kodeakun As String = ""
                            If data(i).Item("KodeAkunPajak") = "" Then
                                kodeakun = data(i).Item("KodeAkun")
                            Else
                                kodeakun = data(i).Item("KodeAkunPajak")
                            End If

                            Dim jml As Double = 0
                            If Not data(i).Item("DebetKomersial") = "0" Then
                                jml = data(i).Item("Komersial")
                            End If
                            If Not data(i).Item("KreditKomersial") = "0" Then
                                jml = data(i).Item("Komersial") * -1
                            End If

                            Dim kondisi As String = ""
                            If Microsoft.VisualBasic.Left(data(i).Item("NoBukti"), 3) = "MEM" Then
                                kondisi = "MEMJPU"
                            ElseIf Microsoft.VisualBasic.Left(data(i).Item("NoBukti"), 3) = "JPU" Then
                                kondisi = "MEMJPU"
                            End If

                            'If Not Strings.Left(data(i).Item("NoBukti"), 3) = "MEM" Or Not Strings.Left(data(i).Item("NoBukti"), 3) = "JPU" Then
                            If Not kondisi = "MEMJPU" Then
                                If data(i).Item("NoUrutAkun") = "1" Then
                                    Dim idbank As String = ""
                                    Dim idbankbaru As String = ""
                                    Dim qq As String = _
                                        "select IdBank from tbACKasBank where KodeAkun='" & data(i).Item("KodeAkun") & "' and KodeCompany='" & Strings.Left(data(i).Item("KodeAkun"), 2) & "'"
                                    cmd = New SqlCommand(qq, kon)
                                    dr = cmd.ExecuteReader
                                    dr.Read()
                                    idbank = dr!IdBank
                                    dr.Close()

                                    Dim qqq As String = _
                                        "select IdBank from tbACKasBank where KodeAkun='" & data(i).Item("KodeAkunPajak") & "' and KodeCompany='" & Strings.Left(data(i).Item("KodeAkunPajak"), 2) & "'"
                                    cmd = New SqlCommand(qqq, kon)
                                    dr = cmd.ExecuteReader
                                    dr.Read()
                                    If dr.HasRows Then
                                        idbankbaru = dr!IdBank
                                    End If
                                    dr.Close()

                                    Dim caridatahd As String = _
                                        "select * from tbACVoucherHdEdit where Nomor='" & data(i).Item("NoBukti") & "' and IdBankLama='" & idbank & "'"
                                    cmd = New SqlCommand(caridatahd, kon)
                                    dr = cmd.ExecuteReader
                                    dr.Read()
                                    Dim queryhd As String = ""
                                    If dr.HasRows Then
                                        Dim idbanklama As String = dr!IdBank
                                        dr.Close()
                                        'update
                                        queryhd = _
                                            "update tbACVoucherHdEdit set IdBank='" & idbankbaru & "',Total='" & jml & "' " & _
                                            "where Nomor='" & data(i).Item("NoBukti") & "' and IdBank='" & idbanklama & "' and IdBankLama='" & idbank & "'"
                                    Else
                                        dr.Close()
                                        Dim caridata As String = _
                                            "select * from tbACVoucherHd where Nomor='" & data(i).Item("NoBukti") & "' and IdBank='" & idbank & "'"
                                        cmd = New SqlCommand(caridata, kon)
                                        dr = cmd.ExecuteReader()
                                        dr.Read()

                                        Dim datetimeentryhdedit As DateTime
                                        Dim stringdateenrtyhdedit1 As String = ""
                                        Dim stringdateentryhdedit2 As String = ""
                                        If Not IsDBNull(dr!DateTimeEntry) Then
                                            datetimeentryhdedit = dr!DateTimeEntry
                                            stringdateenrtyhdedit1 = ",DateTimeEntry"
                                            stringdateentryhdedit2 = ",'" & datetimeentryhdedit.ToString("yyyy-MM-dd hh:mm:ss") & "'"
                                        End If

                                        Dim tgl As DateTime
                                        Dim stringtanggal1 As String = ""
                                        Dim stringtanggal2 As String = ""
                                        If Not IsDBNull(dr!Tanggal) Then
                                            tgl = dr!Tanggal
                                            stringtanggal1 = ",Tanggal"
                                            stringtanggal2 = ",'" & tgl.ToString("yyyy-MM-dd hh:mm:ss") & "'"
                                        End If

                                        Dim datetimeupdatehdedit As DateTime
                                        Dim stringdateupdatehdedit1 As String = ""
                                        Dim stringdateupdatehdedit2 As String = ""
                                        If Not IsDBNull(dr!DateTimeUpdate) Then
                                            datetimeupdatehdedit = dr!DateTimeUpdate
                                            stringdateupdatehdedit1 = ",DateTimeUpdate"
                                            stringdateupdatehdedit2 = ",'" & datetimeupdatehdedit.ToString("yyyy-MM-dd hh:mm:ss") & "'"
                                        End If

                                        'insert
                                        queryhd = _
                                            "insert into tbACVoucherHdEdit (Nomor" & stringtanggal1 & ",KodeCompany,IdBank,FlagTransaksi," & _
                                            "Keterangan1,Keterangan,Total,NoCekBG,TglJTCekBG," & _
                                            "FlagTunai,FlagValidasi,FlagPosting,Catatan,UserEntry" & _
                                            "" & stringdateenrtyhdedit1 & ",UserUpdate" & stringdateupdatehdedit1 & ",NoUrut,cek," & _
                                            "TadaID,NoRef,FlagDelete,IdBankLama,TotalLama,FlagPostingOri) values (" & _
                                            "'" & dr!Nomor & "'" & stringtanggal2 & ",'" & dr!KodeCompany & "','" & idbankbaru & "','" & dr!FlagTransaksi & "'," & _
                                            "'" & dr!Keterangan1 & "','" & dr!Keterangan & "','" & jml & "','" & dr!NoCekBG & "','" & dr!TglJTCekBG & "'," & _
                                            "'" & dr!FlagTunai & "','" & dr!FlagValidasi & "','" & dr!FlagPosting & "','" & dr!Catatan & "','" & dr!UserEntry & "'" & _
                                            "" & stringdateentryhdedit2 & ",'" & dr!UserUpdate & "'" & stringdateupdatehdedit2 & ",'" & dr!NoUrut & "','" & dr!cek & "'," & _
                                            "'" & dr!TadaID & "','" & dr!NoRef & "','0','" & idbank & "','" & dr!Total & "','0')"
                                        dr.Close()
                                    End If
                                    cmd = New SqlCommand(queryhd, kon)
                                    cmd.ExecuteNonQuery()
                                Else
                                    Dim caridatadt As String = _
                                        "select * from tbACVoucherDtEdit where Nomor='" & data(i).Item("NoBukti") & "' and KodeAkunLama='" & data(i).Item("KodeAkun") & "' and NoUrut='" & data(i).Item("NoUrutAkun") - 1 & "'"
                                    cmd = New SqlCommand(caridatadt, kon)
                                    dr = cmd.ExecuteReader
                                    dr.Read()
                                    Dim querydt As String = ""
                                    If dr.HasRows Then
                                        Dim kd As String = dr!KodeAkun
                                        dr.Close()
                                        'update
                                        querydt = _
                                            "update tbACVoucherDtEdit set KodeAkun='" & data(i).Item("KodeAkunPajak") & "',Jumlah='" & jml & "' " & _
                                            "where Nomor='" & data(i).Item("NoBukti") & "' and KodeAkun='" & kd & "' and KodeAkunLama='" & data(i).Item("KodeAkun") & "' and NoUrut='" & data(i).Item("NoUrutAkun") - 1 & "'"
                                    Else
                                        dr.Close()
                                        Dim caridata As String = _
                                            "select * from tbACVoucherDt where Nomor='" & data(i).Item("NoBukti") & "' and NoUrut='" & data(i).Item("NoUrutAkun") - 1 & "' and KodeAkun='" & data(i).Item("KodeAkun") & "'"
                                        cmd = New SqlCommand(caridata, kon)
                                        dr = cmd.ExecuteReader()
                                        dr.Read()

                                        Dim datetimeentrydtedit As DateTime
                                        Dim stringdateenrtydtedit1 As String = ""
                                        Dim stringdateentrydtedit2 As String = ""
                                        If Not IsDBNull(dr!DateTimeEntry) Then
                                            datetimeentrydtedit = dr!DateTimeEntry
                                            stringdateenrtydtedit1 = ",DateTimeEntry"
                                            stringdateentrydtedit2 = ",'" & datetimeentrydtedit.ToString("yyyy-MM-dd hh:mm:ss") & "'"
                                        End If

                                        Dim datetimeupdatedtedit As DateTime
                                        Dim stringdateupdatedtedit1 As String = ""
                                        Dim stringdateupdatedtedit2 As String = ""
                                        If Not IsDBNull(dr!DateTimeUpdate) Then
                                            datetimeupdatedtedit = dr!DateTimeUpdate
                                            stringdateupdatedtedit1 = ",DateTimeUpdate"
                                            stringdateupdatedtedit2 = ",'" & datetimeupdatedtedit.ToString("yyyy-MM-dd hh:mm:ss") & "'"
                                        End If

                                        'insert
                                        querydt = _
                                            "insert into tbACVoucherDtEdit (Nomor,NoUrut,KodeAkun,KodeCabang,IdDepartemen," & _
                                            "Keterangan,Jumlah,Saldo,UserEntry" & stringdateenrtydtedit1 & "," & _
                                            "UserUpdate" & stringdateupdatedtedit1 & ",NoRecord,Cek,TadaID," & _
                                            "FlagDelete,JumlahLama,KodeAkunLama,FlagPostingOri) values (" & _
                                            "'" & dr!Nomor & "','" & dr!NoUrut & "','" & kodeakun & "','" & dr!KodeCabang & "','" & dr!IdDepartemen & "'," & _
                                            "'" & dr!Keterangan & "','" & jml & "','" & dr!Saldo & "','" & dr!UserEntry & "'" & stringdateentrydtedit2 & "," & _
                                            "'" & dr!UserUpdate & "'" & stringdateupdatedtedit2 & ",'" & dr!NoRecord & "','" & dr!Cek & "','" & dr!TadaID & "'," & _
                                            "'0','" & dr!Jumlah & "','" & dr!KodeAkun & "','0')"
                                        dr.Close()
                                    End If
                                    cmd = New SqlCommand(querydt, kon)
                                    cmd.ExecuteNonQuery()
                                End If
                            End If

                            'cari dijurnaledit sudah ada apa belum. kalo belum insert kalo sudah ada edit
                            Dim slksi As String = ""
                            If data(i).Item("New").ToString = "1" Then
                                slksi = "BARU"
                            ElseIf Not IsDBNull(data(i).Item("New")) Then
                                slksi = "BARU"
                            End If
                            Dim cardatajurnaledit As String = ""
                            If Not slksi = "BARU" Then
                                cardatajurnaledit = _
                                "select * from tbACJurnalEdit where NoBukti='" & data(i).Item("NoBukti") & "' and KodeAkunLama='" & data(i).Item("KodeAkun") & "' " & _
                                "and NoUrutAkun='" & data(i).Item("NoUrutAkun") & "'"
                            Else
                                cardatajurnaledit = _
                                "select * from tbACJurnalEdit where NoBukti='" & data(i).Item("NoBukti") & "' and KodeAkunLama='" & data(i).Item("KodeAkunLama") & "' " & _
                                "and NoUrutAkun='" & data(i).Item("NoUrutAkun") & "'"
                            End If
                            
                            cmd = New SqlCommand(cardatajurnaledit, kon)
                            dr = cmd.ExecuteReader
                            dr.Read()
                            If dr.HasRows Then
                                Dim kd As String = dr!KodeAkun
                                dr.Close()
                                Dim updatejurnaledit As String

                                If Not slksi = "BARU" Then
                                    updatejurnaledit = _
                                        "update tbACJurnalEdit set KodeAkun='" & data(i).Item("KodeAkunPajak") & "', NamaAkunPajak='" & data(i).Item("NamaAkunPajak") & "', Jumlah='" & jml & "',FlagPostingJurnalOri='0' " & _
                                        "where NoBukti='" & data(i).Item("NoBukti") & "' and KodeAkun='" & kd & "' and KodeAkunLama='" & data(i).Item("KodeAkun") & "' and NoUrutAkun='" & data(i).Item("NoUrutAkun") & "'"
                                Else
                                    updatejurnaledit = _
                                        "update tbACJurnalEdit set KodeAkun='" & data(i).Item("KodeAkunPajak") & "', NamaAkunPajak='" & data(i).Item("NamaAkunPajak") & "', Jumlah='" & jml & "',FlagPostingJurnalOri='0' " & _
                                        "where NoBukti='" & data(i).Item("NoBukti") & "' and KodeAkun='" & kd & "' and KodeAkunLama='" & data(i).Item("KodeAkunLama") & "' and NoUrutAkun='" & data(i).Item("NoUrutAkun") & "'"
                                End If
                                cmd = New SqlCommand(updatejurnaledit, kon)
                                cmd.ExecuteNonQuery()
                            Else
                                dr.Close()
                                Dim caridata As String = _
                                "select * from tbACJurnal where NoBukti='" & data(i).Item("NoBukti") & "' and KodeAkun='" & data(i).Item("KodeAkun") & "' " & _
                                    "and NoUrutAkun='" & data(i).Item("NoUrutAkun") & "'"
                                cmd = New SqlCommand(caridata, kon)
                                dr = cmd.ExecuteReader
                                dr.Read()

                                Dim datetimeentryacjurnal As DateTime
                                Dim stringdateentryacjurnal1 As String = ""
                                Dim stringdateentryacjurnal2 As String = ""
                                If Not IsDBNull(dr!DateTimeEntry) Then
                                    datetimeentryacjurnal = dr!DateTimeEntry
                                    stringdateentryacjurnal1 = ",DateTimeEntry"
                                    stringdateentryacjurnal2 = ",'" & datetimeentryacjurnal.ToString("yyyy-MM-dd hh:mm:ss") & "'"
                                End If

                                Dim postingdate As DateTime
                                Dim stringpostingdate1 As String = ""
                                Dim stringpostingdate2 As String = ""
                                If Not IsDBNull(dr!PostingDate) Then
                                    postingdate = dr!PostingDate
                                    stringpostingdate1 = ",PostingDate"
                                    stringpostingdate2 = ",'" & postingdate.ToString("yyyy-MM-dd hh:mm:ss") & "'"
                                End If

                                Dim tglbukti As DateTime
                                Dim stringtglbukti1 As String = ""
                                Dim stringtglbukti2 As String = ""
                                If Not IsDBNull(dr!TanggalBukti) Then
                                    tglbukti = dr!TanggalBukti
                                    stringtglbukti1 = ",TanggalBukti"
                                    stringtglbukti2 = ",'" & tglbukti.ToString("yyyy-MM-dd hh:mm:ss") & "'"
                                End If

                                Dim queryhistoryedit As String = _
                                    "insert into tbACJurnalEdit (KodeCompany,NoBukti" & stringtglbukti1 & ",Tipe,KodeCabang," & _
                                    "IdDepartemen,KodeAkun,NoUrutAkun,Keterangan,Jumlah," & _
                                    "DebetOrKredit,FlagPosting" & stringpostingdate1 & ",IdTransaksi,UserEntry" & _
                                    "" & stringdateentryacjurnal1 & ",NoRecord,TadaID,KodeAkunLama,JumlahLama,NamaAkunPajak,FlagPostingJurnalOri) values (" & _
                                    "'" & dr!KodeCompany & "','" & dr!NoBukti & "'" & stringtglbukti2 & ",'" & dr!Tipe & "','" & dr!KodeCabang & "'," & _
                                    "'" & dr!IdDepartemen & "','" & kodeakun & "','" & dr!NoUrutAkun & "','" & dr!Keterangan & "','" & jml & "'," & _
                                    "'" & dr!DebetOrKredit & "','" & dr!FlagPosting & "'" & stringpostingdate2 & ",'" & dr!IdTransaksi & "','" & dr!UserEntry & "'" & _
                                    "" & stringdateentryacjurnal2 & ",'" & dr!NoRecord & "','" & dr!TadaID & "','" & dr!KodeAkun & "','" & dr!Jumlah & "','" & data(i).Item("NamaAkunPajak") & "','0')"

                                Dim editjurnalori As String = _
                                    "update tbACJurnal set KodeAkunLama='" & dr!KodeAkun & "',JumlahLama='" & dr!Jumlah & "' " & _
                                    "where NoBukti='" & dr!NoBukti & "' and NoUrutAkun='" & dr!NoUrutAkun & "' and KodeCompany='" & dr!KodeCompany & "' and KodeAkun='" & dr!KodeAkun & "'"

                                dr.Close()
                                cmd = New SqlCommand(queryhistoryedit, kon)
                                cmd.ExecuteNonQuery()

                                cmd = New SqlCommand(editjurnalori, kon)
                                cmd.ExecuteNonQuery()
                            End If
                        Next
                        MsgBox("Simpan Perubahan Berhasil", vbOKOnly + vbInformation, "Informasi")
                        isigrid()
                        dgJurnal.gvMain.LoadingPanelVisible = False
                    End If
                End If
            End If
            cekposting()
        End If
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        If cCompany.Text = "" Or cJenis.Text = "" Then
            MsgBox("Data Belum Lengkap!", vbCritical + vbOKOnly, "Peringatan")
        Else
            Using xx As New frmHistoryDelete(tJenis.Text, dBulan.EditValue)
                'xx.thn = cThn.Text
                'xx.bln = cBln.Text
                xx.kodecaompany = cCompany.Text
                xx.namacompany = tNama.Text
                xx.ShowDialog(Me)
                isigrid()
                cekposting()
            End Using
        End If
    End Sub

    Private Sub dgJurnal_Load(sender As Object, e As EventArgs) Handles dgJurnal.Load

    End Sub

    Private Sub btnResetData_Click(sender As Object, e As EventArgs) Handles btnResetData.Click
        If cCompany.Text = "" Or cJenis.Text = "" Then
            MsgBox("Lengkapi Data Terlebih Dahulu!", vbCritical + vbOKOnly, "Peringatan")
        Else
            Using xx As New frmResetJurnal(tJenis.Text, dBulan.EditValue, cCompany.Text)
                xx.ShowDialog(Me)
                btnAmbilData.PerformClick()
                cekposting()
            End Using
        End If
    End Sub

    Private Sub btnPosting_Click(sender As Object, e As EventArgs) Handles btnPosting.Click
        Dim konfirmasi As String = MsgBox("Apakah Anda Yakin Posting Perubahan?", vbQuestion + vbYesNo, "Konfirmasi")
        If konfirmasi = vbYes Then
            Dim dbdb As New cMeDB(tJenis.Text)
            Dim titikkumpul As String = _
                "select KodeCompany,NoBukti,TanggalBukti,Tipe,KodeCabang,IdDepartemen,KodeAkun,NoUrutAkun,Keterangan,Jumlah,DebetOrKredit," & _
                "FlagPosting,PostingDate,IdTransaksi,UserEntry,DateTimeEntry,UserUpdate,DateTimeUpdate,NoRecord," & _
                "TadaID,isnull(FlagDelete,0) as FlagDelete,KodeAkunLama,JumlahLama,NamaAkunPajak,FlagPostingJurnalOri,New " & _
                "from tbACJurnalEdit where isnull(FlagPostingJurnalOri,0) <> '1' and month(TanggalBukti)='" & Format(dBulan.EditValue, "MM") & "' and year(TanggalBukti)='" & Format(dBulan.EditValue, "yyyy") & "'"
            dbdb.FillMe(titikkumpul, False)

            For a = 0 To dbdb.Rows.Count - 1
                Dim query As String = ""
                Dim slksi As String = ""
                If Not dbdb.Rows(a).Item("New").ToString = "1" Then
                    slksi = "ntbaru"
                ElseIf IsDBNull(dbdb.Rows(a).Item("New")) Then
                    slksi = "ntbaru"
                End If

                If Not slksi = "ntbaru" Then
                    Dim postjur As String = _
                        "update tbACJurnal set FlagPosting='1',PostingDate='" & DTOC(Now, "/", True) & "' " & _
                        "where NoBukti='" & dbdb.Rows(a).Item("NoBukti") & "' and NoUrutAkun='" & dbdb.Rows(a).Item("NoUrutAkun") & "' and KodeAkunLama='" & dbdb.Rows(a).Item("KodeAkunLama") & "' and JumlahLama='" & dbdb.Rows(a).Item("JumlahLama") & "'"
                    cmd = New SqlCommand(postjur, kon)
                    cmd.ExecuteNonQuery()

                    Dim upjuredit As String = _
                        "update tbACJurnalEdit set FlagPosting='1',PostingDate='" & DTOC(Now, "/", True) & "' " & _
                        "where NoBukti='" & dbdb.Rows(a).Item("NoBukti") & "' and KodeAkun='" & dbdb.Rows(a).Item("KodeAkun") & "' and NoUrutAkun='" & dbdb.Rows(a).Item("NoUrutAkun") & "'"
                    cmd = New SqlCommand(upjuredit, kon)
                    cmd.ExecuteNonQuery()
                Else
                    If dbdb.Rows(a).Item("FlagDelete") = "1" Then
                        Dim qpost As String = ""
                        If dbdb.Rows(a).Item("NoUrutAkun") = "1" Then
                            Dim idbank As String = ""
                            Dim qq As String = _
                                "select IdBank from tbACKasBank where KodeAkun='" & dbdb.Rows(a).Item("KodeAkunLama") & "' and KodeCompany='" & dbdb.Rows(a).Item("KodeCompany") & "'"
                            cmd = New SqlCommand(qq, kon)
                            dr = cmd.ExecuteReader
                            dr.Read()
                            If dr.HasRows Then
                                idbank = dr!IdBank
                            End If
                            dr.Close()
                            query = _
                                "delete from tbACVoucherHd where IdBank='" & idbank & "' and KodeCompany='" & dbdb.Rows(a).Item("KodeCompany") & "' and Nomor='" & dbdb.Rows(a).Item("NoBukti") & "'"
                            qpost = _
                                "update tbACVoucherHdEdit set FlagPostingOri='1' " & _
                                "where IdBank='" & idbank & "' and KodeCompany='" & dbdb.Rows(a).Item("KodeCompany") & "' and Nomor='" & dbdb.Rows(a).Item("NoBukti") & "'"
                        Else
                            Dim nourutakun As Integer = dbdb.Rows(a).Item("NoUrutAkun") - 1
                            query = _
                                "delete from tbACVoucherDt where Nomor='" & dbdb.Rows(a).Item("NoBukti") & "' and KodeAkun='" & dbdb.Rows(a).Item("KodeAkunLama") & "' and NoUrut='" & nourutakun & "'"
                            qpost = _
                            "update tbACVoucherDtEdit set FlagPostingOri='1' " & _
                            "where Nomor='" & dbdb.Rows(a).Item("NoBukti") & "' and KodeAkun='" & dbdb.Rows(a).Item("KodeAkunLama") & "' and NoUrut='" & nourutakun & "'"
                        End If

                        If Not Strings.Left(dbdb.Rows(a).Item("NoBukti"), 3) = "JPU" Or Not Strings.Left(dbdb.Rows(a).Item("NoBukti"), 3) = "MEM" Then
                            cmd = New SqlCommand(qpost, kon)
                            cmd.ExecuteNonQuery()

                            cmd = New SqlCommand(query, kon)
                            cmd.ExecuteNonQuery()
                        End If

                        Dim hapusjurnalori As String = _
                            "delete from tbACJurnal " & _
                            "where NoBukti='" & dbdb.Rows(a).Item("NoBukti") & "' and NoUrutAkun='" & dbdb.Rows(a).Item("NoUrutAkun") & "' and KodeAkun='" & dbdb.Rows(a).Item("KodeAkunLama") & "' and Jumlah='" & dbdb.Rows(a).Item("JumlahLama") & "'"
                        cmd = New SqlCommand(hapusjurnalori, kon)
                        cmd.ExecuteNonQuery()
                    Else
                        Dim tbl As String = ""
                        Dim tbl2 As String = ""
                        Dim quetambah As String = ""
                        Dim quewhere As String = ""
                        Dim quewhereposting As String = ""
                        Dim nourutakun As Integer

                        Dim kondisi As String = ""
                        If Strings.Left(dbdb.Rows(a).Item("NoBukti"), 3) = "MEM" Then
                            kondisi = "MEMJPU"
                        ElseIf Strings.Left(dbdb.Rows(a).Item("NoBukti"), 3) = "JPU" Then
                            kondisi = "MEMJPU"
                        End If

                        If dbdb.Rows(a).Item("NoUrutAkun") = "1" And Not kondisi = "MEMJPU" Then
                            Dim idbank As String = ""
                            Dim idbankbaru As String = ""
                            Dim qq As String = _
                                "select IdBank from tbACKasBank where KodeAkun='" & dbdb.Rows(a).Item("KodeAkunLama") & "' and KodeCompany='" & dbdb.Rows(a).Item("KodeCompany") & "'"
                            cmd = New SqlCommand(qq, kon)
                            dr = cmd.ExecuteReader
                            dr.Read()
                            idbank = dr!IdBank
                            dr.Close()

                            Dim qqq As String = _
                                "select IdBank from tbACKasBank where KodeAkun='" & dbdb.Rows(a).Item("KodeAkun") & "' and KodeCompany='" & dbdb.Rows(a).Item("KodeCompany") & "'"
                            cmd = New SqlCommand(qqq, kon)
                            dr = cmd.ExecuteReader
                            dr.Read()
                            If dr.HasRows Then
                                idbankbaru = dr!IdBank
                            End If
                            dr.Close()

                            tbl = "tbACVoucherHd"
                            tbl2 = "tbACVoucherHdEdit"
                            nourutakun = dbdb.Rows(a).Item("NoUrutAkun")
                            quewhere = "IdBank ='" & idbank & "'"
                            quewhereposting = "IdBank='" & idbankbaru & "' and IdBankLama='" & idbank & "'"
                            quetambah = "IdBank ='" & idbankbaru & "',Total='" & dbdb.Rows(a).Item("Jumlah") & "',IdBankLama='" & idbank & "',TotalLama='" & dbdb.Rows(a).Item("JumlahLama") & "'"
                        Else
                            tbl = "tbACVoucherDt"
                            tbl2 = "tbACVoucherDtEdit"
                            nourutakun = dbdb.Rows(a).Item("NoUrutAkun") - 1
                            quewhere = "KodeAkun='" & dbdb.Rows(a).Item("KodeAkunLama") & "' and NoUrut='" & nourutakun & "'"
                            quewhereposting = "KodeAkun='" & dbdb.Rows(a).Item("KodeAkun") & "' and NoUrut='" & nourutakun & "' and KodeAkunLama='" & dbdb.Rows(a).Item("KodeAkunLama") & "'"
                            quetambah = "KodeAkun='" & dbdb.Rows(a).Item("KodeAkun") & "',Jumlah='" & dbdb.Rows(a).Item("Jumlah") & "',KodeAkunLama='" & dbdb.Rows(a).Item("KodeAkunLama") & "',JumlahLama='" & dbdb.Rows(a).Item("JumlahLama") & "'"
                        End If
                        query = _
                                "update " & tbl & " set " & quetambah & " " & _
                                "where Nomor='" & dbdb.Rows(a).Item("NoBukti") & "' and " & quewhere & ""

                        'If Not Strings.Left(dbdb.Rows(a).Item("NoBukti"), 3) = "JPU" Or Not Strings.Left(dbdb.Rows(a).Item("NoBukti"), 3) = "MEM" Then
                        If Not kondisi = "MEMJPU" Then
                            cmd = New SqlCommand(query, kon)
                            cmd.ExecuteNonQuery()

                            Dim qposting As String = _
                                "update " & tbl2 & " set FlagPostingOri='1' " & _
                                "where Nomor='" & dbdb.Rows(a).Item("NoBukti") & "' and " & quewhereposting & ""
                            cmd = New SqlCommand(qposting, kon)
                            cmd.ExecuteNonQuery()
                        End If

                        Dim editjurnalori As String = _
                            "update tbACJurnal set KodeAkun='" & dbdb.Rows(a).Item("KodeAkun") & "', Jumlah='" & dbdb.Rows(a).Item("Jumlah") & "'," & _
                            "KodeAkunLama='" & dbdb.Rows(a).Item("KodeAkunLama") & "',JumlahLama='" & dbdb.Rows(a).Item("JumlahLama") & "', FlagPosting='1' " & _
                            "where NoBukti='" & dbdb.Rows(a).Item("NoBukti") & "' and NoUrutAkun='" & dbdb.Rows(a).Item("NoUrutAkun") & "' and KodeAkunLama='" & dbdb.Rows(a).Item("KodeAkunLama") & "' and JumlahLama='" & dbdb.Rows(a).Item("JumlahLama") & "'"
                        cmd = New SqlCommand(editjurnalori, kon)
                        cmd.ExecuteNonQuery()
                    End If
                    cmd = New SqlCommand(query, kon)
                    cmd.ExecuteNonQuery()
                End If

                Dim editposting As String = _
                    "update tbACJurnalEdit set FlagPostingJurnalOri='1', FlagPosting='1' where NoBukti='" & dbdb.Rows(a).Item("NoBukti") & "' and KodeAkun='" & dbdb.Rows(a).Item("KodeAkun") & "' and NoUrutAkun='" & dbdb.Rows(a).Item("NoUrutAkun") & "'"
                cmd = New SqlCommand(editposting, kon)
                cmd.ExecuteNonQuery()
            Next
            'exec laba rugi
            cmd = New SqlCommand("exec sp_UpdGL '" & cCompany.Text & "'", kon)
            cmd.CommandTimeout = 0
            cmd.ExecuteNonQuery()

            'exec neraca
            cmd = New SqlCommand("exec sp_UpdNS '" & cCompany.Text & "'", kon)
            cmd.CommandTimeout = 0
            cmd.ExecuteNonQuery()
            MsgBox("Posting Perubahan Berhasil", vbInformation + vbOKOnly, "Informasi")
            btnAmbilData.PerformClick()
        End If
    End Sub

    Sub cekposting()
        Dim titikkumpul As String = _
                "select KodeCompany,NoBukti,TanggalBukti,Tipe,KodeCabang,IdDepartemen,KodeAkun,NoUrutAkun,Keterangan,Jumlah,DebetOrKredit," & _
                "FlagPosting,PostingDate,IdTransaksi,UserEntry,DateTimeEntry,UserUpdate,DateTimeUpdate,NoRecord," & _
                "TadaID,isnull(FlagDelete,0) as FlagDelete,KodeAkunLama,JumlahLama,NamaAkunPajak,FlagPostingJurnalOri" & _
                " from tbACJurnalEdit where isnull(FlagPostingJurnalOri,0) <> '1' and month(TanggalBukti)='" & Format(dBulan.EditValue, "MM") & "' and year(TanggalBukti)='" & Format(dBulan.EditValue, "yyyy") & "'"

        cmd = New SqlCommand(titikkumpul, kon)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            btnPosting.Enabled = True
        Else
            btnPosting.Enabled = False
        End If
        dr.Close()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If cJenis.Text = "" Or cCompany.Text = "" Then
            MsgBox("Data Belum Lengkap!", vbCritical + vbOKOnly, "Peringatan")
        Else
            Using xx As New frmJurnalAdd(tJenis.Text, cCompany.Text, dBulan.EditValue)
                xx.ShowDialog(Me)
                btnAmbilData.PerformClick()
            End Using
        End If
    End Sub
End Class