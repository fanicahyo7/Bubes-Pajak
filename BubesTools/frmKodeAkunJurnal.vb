Imports meCore
Imports System.Data.SqlClient

Public Class frmKodeAkunJurnal

    Private Sub frmKodeAkunJurnal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LayoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        LayoutControlGroup2.Enabled = False
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
        cKodeAkun.FirstInit(tJenis.Text, "select KodeAKun,Keterangan from tbACKodeAkun where KodeCompany='" & cCompany.Text & "' and StatusJurnal='1' order by KodeAkun asc", {tKodeAkun})
    End Sub

    Private Sub btnAmbil_Click(sender As Object, e As EventArgs) Handles btnAmbil.Click
        isigrid()
        LayoutControlGroup2.Enabled = True
        cKodeAkunPajak.FirstInit(tJenis.Text, "select KodeAKun,Keterangan from tbACKodeAkun where KodeCompany='" & cCompany.Text & "' and KodeAkun <> '" & cKodeAkun.Text & "' and StatusJurnal='1' order by KodeAkun asc", {tKodeAkunPajak})
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
        "where substring(a.KodeAkun,1,2)='" & cCompany.Text & "' and case when a.KodeAkunLama is null then a.KodeAkun else a.KodeAkunLama end='" & cKodeAkun.Text & "' and month(a.TanggalBukti)='" & Format(dBulan.EditValue, "MM") & "' and year(a.TanggalBukti)='" & Format(dBulan.EditValue, "yyyy") & "'" & _
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
                         , {"DebetOrKredit", "New", "urut", "status", "NamaAkunPajak1", "FlagDelete", "KodeAkunLama", "JumlahLama", "Keterangan1"}, , 50, False, )
        dgJurnal.ConnString = tJenis.Text
        dgJurnal.RefreshData(False)
    End Sub

    Private Sub btnGantiKode_Click(sender As Object, e As EventArgs) Handles btnGantiKode.Click
        If cKodeAkunPajak.Text = "" Then
            MsgBox("Kode Akun Pajak Belum Dpilih!", vbCritical + vbOKOnly, "Peringatan")
        Else
            Dim konfirmasi As String = MsgBox("Apakah Anda Yakin Mengganti Kode Akun " & cKodeAkun.Text & " dengan Kode Akun " & cKodeAkunPajak.Text & "?", vbQuestion + vbYesNo, "Konfirmasi")
            If konfirmasi = vbYes Then
                For a = 0 To dgJurnal.gvMain.RowCount - 1
                    Dim kondisi As String = ""
                    If Microsoft.VisualBasic.Left(dgJurnal.GetRowCellValue(a, "NoBukti"), 3) = "MEM" Then
                        kondisi = "MEMJPU"
                    ElseIf Microsoft.VisualBasic.Left(dgJurnal.GetRowCellValue(a, "NoBukti"), 3) = "JPU" Then
                        kondisi = "MEMJPU"
                    End If

                    If dgJurnal.GetRowCellValue(a, "NoUrutAkun") = "1" And Not kondisi = "MEMJPU" Then
                        Dim cekbank As String = _
                            "select * from tbACKasBank where KodeAkun='" & cKodeAkunPajak.Text & "'"
                        cmd = New SqlCommand(cekbank, kon)
                        dr = cmd.ExecuteReader
                        dr.Read()
                        If Not dr.HasRows Then
                            MsgBox("Kode " & cKodeAkunPajak.Text & " Tidak Memiliki Kode Bank untuk menjadi VoucherHeader!", vbCritical + vbOKOnly, "Peringatan")
                            dr.Close()
                            Exit Sub
                        End If
                        dr.Close()
                    End If
                Next

                dgJurnal.gvMain.LoadingPanelVisible = True
                For i = 0 To dgJurnal.gvMain.RowCount - 1
                    Dim kodeakun As String = ""
                    kodeakun = cKodeAkunPajak.Text

                    Dim jml As Double = 0
                    If Not dgJurnal.GetRowCellValue(i, "DebetKomersial") = "0" Then
                        jml = dgJurnal.GetRowCellValue(i, "Komersial")
                    End If
                    If Not dgJurnal.GetRowCellValue(i, "KreditKomersial") = "0" Then
                        jml = dgJurnal.GetRowCellValue(i, "Komersial") * -1
                    End If

                    Dim kondisi As String = ""
                    If Microsoft.VisualBasic.Left(dgJurnal.GetRowCellValue(i, "NoBukti"), 3) = "MEM" Then
                        kondisi = "MEMJPU"
                    ElseIf Microsoft.VisualBasic.Left(dgJurnal.GetRowCellValue(i, "NoBukti"), 3) = "JPU" Then
                        kondisi = "MEMJPU"
                    End If

                    'If Not Strings.Left(data(i).Item("NoBukti"), 3) = "MEM" Or Not Strings.Left(data(i).Item("NoBukti"), 3) = "JPU" Then
                    If Not kondisi = "MEMJPU" Then
                        If dgJurnal.GetRowCellValue(i, "NoUrutAkun") = "1" Then
                            Dim idbank As String = ""
                            Dim idbankbaru As String = ""
                            Dim qq As String = _
                                "select IdBank from tbACKasBank where KodeAkun='" & cKodeAkun.Text & "' and KodeCompany='" & Strings.Left(cKodeAkun.Text, 2) & "'"
                            cmd = New SqlCommand(qq, kon)
                            dr = cmd.ExecuteReader
                            dr.Read()
                            idbank = dr!IdBank
                            dr.Close()

                            Dim qqq As String = _
                                "select IdBank from tbACKasBank where KodeAkun='" & cKodeAkunPajak.Text & "' and KodeCompany='" & Strings.Left(cKodeAkunPajak.Text, 2) & "'"
                            cmd = New SqlCommand(qqq, kon)
                            dr = cmd.ExecuteReader
                            dr.Read()
                            If dr.HasRows Then
                                idbankbaru = dr!IdBank
                            End If
                            dr.Close()

                            Dim caridatahd As String = _
                                "select * from tbACVoucherHdEdit where Nomor='" & dgJurnal.GetRowCellValue(i, "NoBukti") & "' and IdBankLama='" & idbank & "'"
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
                                    "where Nomor='" & dgJurnal.GetRowCellValue(i, "NoBukti") & "' and IdBank='" & idbanklama & "' and IdBankLama='" & idbank & "'"
                            Else
                                dr.Close()
                                Dim caridata As String = _
                                    "select * from tbACVoucherHd where Nomor='" & dgJurnal.GetRowCellValue(i, "NoBukti") & "' and IdBank='" & idbank & "'"
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
                                "select * from tbACVoucherDtEdit where Nomor='" & dgJurnal.GetRowCellValue(i, "NoBukti") & "' and KodeAkunLama='" & cKodeAkun.Text & "' and NoUrut='" & dgJurnal.GetRowCellValue(i, "NoUrutAkun") - 1 & "'"
                            cmd = New SqlCommand(caridatadt, kon)
                            dr = cmd.ExecuteReader
                            dr.Read()
                            Dim querydt As String = ""
                            If dr.HasRows Then
                                Dim kd As String = dr!KodeAkun
                                dr.Close()
                                'update
                                querydt = _
                                    "update tbACVoucherDtEdit set KodeAkun='" & cKodeAkunPajak.Text & "',Jumlah='" & jml & "' " & _
                                    "where Nomor='" & dgJurnal.GetRowCellValue(i, "NoBukti") & "' and KodeAkun='" & kd & "' and KodeAkunLama='" & cKodeAkun.Text & "' and NoUrut='" & dgJurnal.GetRowCellValue(i, "NoUrutAkun") - 1 & "'"
                            Else
                                dr.Close()
                                Dim caridata As String = _
                                    "select * from tbACVoucherDt where Nomor='" & dgJurnal.GetRowCellValue(i, "NoBukti") & "' and NoUrut='" & dgJurnal.GetRowCellValue(i, "NoUrutAkun") - 1 & "' and KodeAkun='" & tKodeAkun.Text & "'"
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
                    If dgJurnal.GetRowCellValue(i, "New").ToString = "1" Then
                        slksi = "BARU"
                    ElseIf Not IsDBNull(dgJurnal.GetRowCellValue(i, "New")) Then
                        slksi = "BARU"
                    End If
                    Dim cardatajurnaledit As String = ""
                    If Not slksi = "BARU" Then
                        cardatajurnaledit = _
                        "select * from tbACJurnalEdit where NoBukti='" & dgJurnal.GetRowCellValue(i, "NoBukti") & "' and KodeAkunLama='" & dgJurnal.GetRowCellValue(i, "KodeAkunLama") & "' " & _
                        "and NoUrutAkun='" & dgJurnal.GetRowCellValue(i, "NoUrutAkun") & "'"
                    Else
                        cardatajurnaledit = _
                        "select * from tbACJurnalEdit where NoBukti='" & dgJurnal.GetRowCellValue(i, "NoBukti") & "' and KodeAkunLama='" & dgJurnal.GetRowCellValue(i, "KodeAkunLama") & "' " & _
                        "and NoUrutAkun='" & dgJurnal.GetRowCellValue(i, "NoUrutAkun") & "'"
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
                                "update tbACJurnalEdit set KodeAkun='" & cKodeAkunPajak.Text & "', NamaAkunPajak='" & tKodeAkunPajak.Text & "', Jumlah='" & jml & "',FlagPostingJurnalOri='0' " & _
                                "where NoBukti='" & dgJurnal.GetRowCellValue(i, "NoBukti") & "' and KodeAkun='" & kd & "' and KodeAkunLama='" & dgJurnal.GetRowCellValue(i, "KodeAkun") & "' and NoUrutAkun='" & dgJurnal.GetRowCellValue(i, "NoUrutAkun") & "'"
                        Else
                            updatejurnaledit = _
                                "update tbACJurnalEdit set KodeAkun='" & cKodeAkunPajak.Text & "', NamaAkunPajak='" & tKodeAkunPajak.Text & "', Jumlah='" & jml & "',FlagPostingJurnalOri='0' " & _
                                "where NoBukti='" & dgJurnal.GetRowCellValue(i, "NoBukti") & "' and KodeAkun='" & kd & "' and KodeAkunLama='" & dgJurnal.GetRowCellValue(i, "KodeAkunLama") & "' and NoUrutAkun='" & dgJurnal.GetRowCellValue(i, "NoUrutAkun") & "'"
                        End If
                        cmd = New SqlCommand(updatejurnaledit, kon)
                        cmd.ExecuteNonQuery()
                    Else
                        dr.Close()
                        Dim caridata As String = _
                        "select * from tbACJurnal where NoBukti='" & dgJurnal.GetRowCellValue(i, "NoBukti") & "' and KodeAkun='" & cKodeAkun.Text & "' " & _
                            "and NoUrutAkun='" & dgJurnal.GetRowCellValue(i, "NoUrutAkun") & "'"
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
                            "" & stringdateentryacjurnal2 & ",'" & dr!NoRecord & "','" & dr!TadaID & "','" & dr!KodeAkun & "','" & dr!Jumlah & "','" & dgJurnal.GetRowCellValue(i, "NamaAkunPajak") & "','0')"

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
    End Sub
End Class