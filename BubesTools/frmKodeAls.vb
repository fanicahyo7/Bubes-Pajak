Imports System.Data.SqlClient
Imports meCore
Public Class frmKodeAls
    Dim isNew As Double = True
    Private Sub frmKodeAls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadgrid()

        dTanggal.Properties.DisplayFormat.FormatString = "yyyy MMMM"
        dTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        dTanggal.Properties.EditMask = "yyyy MMMM"
        dTanggal.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView
        dTanggal.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView

        dTanggal.EditValue = Now
        LayoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        LayoutControlItem10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        LayoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        LayoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    End Sub

    Sub loadgrid()
        cJenis.FirstInit(PubConnStr, "SELECT Jenis, ConnStr FROM mstUnitBukbes", {tJenis}, , , , , , , {"ConnStr"})
        'cJenis.FirstInit(PubConnStr, "SELECT Jenis, ConnStr FROM mstUnitBukbes", , , , , , , , {"ConnStr"})
        cJenis.EditValue = "UE"

        Dim querygrid As String = "select * from tbAlsKodeAkun "

        dgTambahKode.FirstInit(querygrid & "where Status='TAMBAH KODE AKUN' order by KodeAkun", _
                              {0.5, 0.8, 1, 0.8, 1, 0.5, 0.5, 0.5, 0.5, 0.5}, , , {"Status"})
        dgTambahKode.ConnString = tJenis.Text
        dgTambahKode.RefreshData(False)

        dgUbahNama.FirstInit(querygrid & "where Status='UBAH NAMA AKUN' order by KodeAkun", _
                       {0.5, 0.8, 1, 0.8, 1, 0.5, 0.5, 0.5, 0.5, 0.5}, , , {"Status", "KodeAKunPajak", "LevelAkun", "IdKategori", "StatusJurnal", "DebetOrKredit", "KodeAkunInduk"})
        dgUbahNama.ConnString = tJenis.Text
        dgUbahNama.RefreshData(False)

        dgGantiKode.FirstInit(querygrid & "where Status='UBAH KODE AKUN' order by KodeAkun", _
               {0.5, 0.8, 1, 0.8, 1, 0.5, 0.5, 0.5, 0.5, 0.5}, , , {"Status", "LevelAkun", "IdKategori", "StatusJurnal", "DebetOrKredit", "KodeAkunInduk"})
        dgGantiKode.ConnString = tJenis.Text
        dgGantiKode.RefreshData(False)
    End Sub

    Private Sub cJenis_EditValueChanged(sender As Object, e As EventArgs) Handles cJenis.EditValueChanged
        'If cJenis.Text = "UE" Then
        '    tJenis.Text = "Data Source=10.10.2.23;Initial Catalog=BukbesAccUE;Persist Security Info=True;User ID=sa;Password=gogogo;Connection Timeout=0"
        'Else
        '    tJenis.Text = "Data Source=10.10.2.23;Initial Catalog=BukbesAccUM;Persist Security Info=True;User ID=sa;Password=gogogo;Connection Timeout=0"
        'End If

        koneksi(tJenis.Text)
    End Sub

    Private Sub btnTerapkan_Click(sender As Object, e As EventArgs) Handles btnTerapkan.Click
        Dim konfirmasi As String = MsgBox("Apakah Anda Yakin Menambah dan Mengubah Kode ?", vbQuestion + vbYesNo, "Konfirmasi")
        If konfirmasi = vbYes Then
            Dim query As String = "begin try begin transaction "
            Dim dbcompany As New cMeDB(tJenis.Text)
            dbcompany.FillMe("Select KodeCompany,Nama from tbGNCompanyAls", True)
            For a = 0 To dbcompany.Rows.Count - 1
                'tambah kode
                For b = 0 To dgTambahKode.gvMain.RowCount - 1
                    'cek kode
                    Dim dbdb As New cMeDB(tJenis.Text)
                    Dim pQuery As String = _
                        "Select KodeAkun, KodeCompany, IdKategori, Keterangan,LevelAkun,DebetOrKredit,StatusJurnal,KodeAkunInduk,KodeCabang from tbACKodeAkun " & _
                        "where KodeAkun = '" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgTambahKode.GetRowCellValue(b, "KodeAkun") & "'"
                    dbdb.FillMe(pQuery, True)

                    If dbdb.Rows.Count > 0 Then
                        isNew = False
                    Else
                        isNew = True
                    End If

                    If isNew = True Then
                        query += _
                        "insert into tbACKodeAkunEdit (" & _
                            "KodeAkun,Keterangan,KodeAkunInduk,LevelAkun,DebetOrKredit," & _
                            "StatusJurnal,KodeCompany,IdKategori,KodeAkunLama," & _
                            "KeteranganLama,IdKategoriLama,LevelAkunLama,DebetOrKreditLama,StatusJurnalLama," & _
                            "KodeAkunIndukLama,KodeCompanyLama,FlagDelete) values (" & _
                            "'" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgTambahKode.GetRowCellValue(b, "KodeAkunPajak") & "','" & dgTambahKode.GetRowCellValue(b, "KeteranganPajak") & "','" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgTambahKode.GetRowCellValue(b, "KodeAkunInduk") & "','" & dgTambahKode.GetRowCellValue(b, "LevelAkun") & "','" & dgTambahKode.GetRowCellValue(b, "DebetOrKredit") & "'," & _
                            "'" & dgTambahKode.GetRowCellValue(b, "StatusJurnal") & "','" & dbcompany.Rows(a).Item("KodeCompany") & "','" & dgTambahKode.GetRowCellValue(b, "IdKategori") & "','" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgTambahKode.GetRowCellValue(b, "KodeAkun") & "'," & _
                            "'" & dgTambahKode.GetRowCellValue(b, "Keterangan") & "','" & dgTambahKode.GetRowCellValue(b, "IdKategori") & "','" & dgTambahKode.GetRowCellValue(b, "LevelAkun") & "','" & dgTambahKode.GetRowCellValue(b, "DebetOrKredit") & "','" & dgTambahKode.GetRowCellValue(b, "StatusJurnal") & "'," & _
                            "'" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgTambahKode.GetRowCellValue(b, "KodeAkunInduk") & "','" & dbcompany.Rows(a).Item("KodeCompany") & "','0'); "

                        query += _
                        "insert into tbACKodeAkun (" & _
                            "KodeAkun,Keterangan,KodeAkunInduk,LevelAkun,DebetOrKredit," & _
                            "StatusJurnal,KodeCompany,IdKategori) values (" & _
                            "'" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgTambahKode.GetRowCellValue(b, "KodeAkunPajak") & "','" & dgTambahKode.GetRowCellValue(b, "KeteranganPajak") & "','" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgTambahKode.GetRowCellValue(b, "KodeAkunInduk") & "','" & dgTambahKode.GetRowCellValue(b, "LevelAkun") & "','" & dgTambahKode.GetRowCellValue(b, "DebetOrKredit") & "'," & _
                            "'" & dgTambahKode.GetRowCellValue(b, "StatusJurnal") & "','" & dbcompany.Rows(a).Item("KodeCompany") & "','" & dgTambahKode.GetRowCellValue(b, "IdKategori") & "'); "
                    Else
                        Dim cari As String = _
                            "select * from tbACKodeAkunEdit where KodeAkunLama='" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgTambahKode.GetRowCellValue(b, "KodeAkun") & "'"
                        cmd = New SqlCommand(cari, kon)
                        rd = cmd.ExecuteReader
                        rd.Read()
                        If rd.HasRows = False Then
                            rd.Close()
                            Dim cari2 As String = _
                                "select * from tbACKodeAkun where KodeAkun='" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgTambahKode.GetRowCellValue(b, "KodeAkunPajak") & "'"
                            cmd = New SqlCommand(cari2, kon)
                            rd = cmd.ExecuteReader
                            rd.Read()

                            query += "insert into tbACKodeAkunEdit (" & _
                                "KodeAkun,Keterangan,KodeAkunInduk,LevelAkun,DebetOrKredit," & _
                                "StatusJurnal,KodeCompany,IdKategori,KodeAkunLama," & _
                                "KeteranganLama,IdKategoriLama,LevelAkunLama,DebetOrKreditLama,StatusJurnalLama," & _
                                "KodeAkunIndukLama,KodeCompanyLama,FlagDelete) values (" & _
                                "'" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgTambahKode.GetRowCellValue(b, "KodeAkunPajak") & "','" & dgTambahKode.GetRowCellValue(b, "KeteranganPajak") & "','" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgTambahKode.GetRowCellValue(b, "KodeAkunInduk") & "','" & dgTambahKode.GetRowCellValue(b, "LevelAkun") & "','" & dgTambahKode.GetRowCellValue(b, "DebetOrKredit") & "'," & _
                                "'" & dgTambahKode.GetRowCellValue(b, "StatusJurnal") & "','" & dbcompany.Rows(a).Item("KodeCompany") & "','" & dgTambahKode.GetRowCellValue(b, "IdKategori") & "','" & rd!KodeAkun & "'," & _
                                "'" & rd!Keterangan & "','" & rd!IdKategori & "','" & rd!LevelAkun & "','" & rd!DebetOrKredit & "','" & rd!StatusJurnal & "'," & _
                                "'" & rd!KodeAkunInduk & "','" & rd!KodeCompany & "','0'); "

                            query += _
                                "update tbACKodeAkun set " & _
                                "KodeCompany='" & dbcompany.Rows(a).Item("KodeCompany") & "',IdKategori='" & dgTambahKode.GetRowCellValue(b, "IdKategori") & "',Keterangan='" & dgTambahKode.GetRowCellValue(b, "KeteranganPajak") & "'," & _
                                "LevelAkun='" & dgTambahKode.GetRowCellValue(b, "LevelAkun") & "',DebetOrKredit='" & dgTambahKode.GetRowCellValue(b, "DebetOrKredit") & "',StatusJurnal='" & dgTambahKode.GetRowCellValue(b, "StatusJurnal") & "'," & _
                                "KodeAkunInduk='" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgTambahKode.GetRowCellValue(b, "KodeAkunInduk") & "' " & _
                                "where KodeAkun='" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgTambahKode.GetRowCellValue(b, "KodeAkunPajak") & "'; "
                        Else
                            query += _
                                "update tbACKodeAkunEdit set " & _
                                "Keterangan='" & dgTambahKode.GetRowCellValue(b, "KeteranganPajak") & "',KodeAkunInduk='" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgTambahKode.GetRowCellValue(b, "KodeAkunInduk") & "',LevelAkun='" & dgTambahKode.GetRowCellValue(b, "LevelAkun") & "'," & _
                                "DebetOrKredit='" & dgTambahKode.GetRowCellValue(b, "DebetOrKredit") & "', StatusJurnal='" & dgTambahKode.GetRowCellValue(b, "StatusJurnal") & "',KodeCompany='" & dbcompany.Rows(a).Item("KodeCompany") & "'," & _
                                "IdKategori='" & dgTambahKode.GetRowCellValue(b, "IdKategori") & "'," & _
                                "KodeAkunLama='" & rd!KodeAkunLama & "',KeteranganLama='" & rd!KeteranganLama & "',IdKategoriLama='" & rd!IdKategoriLama & "'," & _
                                "LevelAkunLama='" & rd!LevelAkunLama & "',DebetOrKreditLama='" & rd!DebetOrKredit & "',StatusJurnalLama='" & rd!StatusJurnal & "'," & _
                                "KodeAkunIndukLama='" & rd!KodeAkunInduk & "',KodeCabangLama='" & rd!KodeCabang & "',KodeCompanyLama='" & rd!KodeCompany & "' " & _
                                "where KodeAkun='" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgTambahKode.GetRowCellValue(b, "KodeAkunPajak") & "' and KodeAkunLama='" & rd!KodeAkun & "'; "

                            query += _
                                "update tbACKodeAkun set " & _
                                "KodeCompany='" & dbcompany.Rows(a).Item("KodeCompany") & "',IdKategori='" & dgTambahKode.GetRowCellValue(b, "IdKategori") & "',Keterangan='" & dgTambahKode.GetRowCellValue(b, "KeteranganPajak") & "'," & _
                                "LevelAkun='" & dgTambahKode.GetRowCellValue(b, "LevelAkun") & "',DebetOrKredit='" & dgTambahKode.GetRowCellValue(b, "DebetOrKredit") & "',StatusJurnal='" & dgTambahKode.GetRowCellValue(b, "StatusJurnal") & "'," & _
                                "KodeAkunInduk='" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgTambahKode.GetRowCellValue(b, "KodeAkunInduk") & "' " & _
                                "where KodeAkun='" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgTambahKode.GetRowCellValue(b, "KodeAkunPajak") & "'; "
                        End If
                        rd.Close()
                    End If
                Next

                'ubah nama kode
                For b = 0 To dgUbahNama.gvMain.RowCount - 1
                    'cek kode
                    Dim dbdb As New cMeDB(tJenis.Text)
                    Dim pQuery As String = _
                        "Select KodeAkun, KodeCompany, IdKategori, Keterangan,LevelAkun,DebetOrKredit,StatusJurnal,KodeAkunInduk,KodeCabang from tbACKodeAkunEdit " & _
                        "where KodeAkun = '" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgUbahNama.GetRowCellValue(b, "KodeAkunPajak") & "'"
                    dbdb.FillMe(pQuery, True)

                    If dbdb.Rows.Count > 0 Then
                        isNew = False
                    Else
                        isNew = True
                    End If

                    If isNew = True Then
                        Dim carikode As String = "select * from tbACKodeAkun where KodeAkun='" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgUbahNama.GetRowCellValue(b, "KodeAkun") & "'"
                        cmd = New SqlCommand(carikode, kon)
                        rd = cmd.ExecuteReader
                        rd.Read()
                        If rd.HasRows Then
                            query += "insert into tbACKodeAkunEdit (" & _
                                "KodeAkun,Keterangan,KodeAkunInduk,LevelAkun,DebetOrKredit," & _
                                "StatusJurnal,KodeCompany,IdKategori,KodeAkunLama," & _
                                "KeteranganLama,IdKategoriLama,LevelAkunLama,DebetOrKreditLama,StatusJurnalLama," & _
                                "KodeAkunIndukLama,KodeCompanyLama,FlagDelete) values (" & _
                                "'" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgUbahNama.GetRowCellValue(b, "KodeAkunPajak") & "','" & dgUbahNama.GetRowCellValue(b, "KeteranganPajak") & "','" & rd!KodeAkunInduk & "','" & rd!LevelAkun & "','" & rd!DebetOrKredit & "'," & _
                                "'" & rd!StatusJurnal & "','" & dbcompany.Rows(a).Item("KodeCompany") & "','" & rd!IdKategori & "','" & rd!KodeAkun & "'," & _
                                "'" & rd!Keterangan & "','" & rd!IdKategori & "','" & rd!LevelAkun & "','" & rd!DebetOrKredit & "','" & rd!StatusJurnal & "'," & _
                                "'" & rd!KodeAkunInduk & "','" & rd!KodeCompany & "','0'); "
                        End If
                        rd.Close()
                    Else
                        query += "update tbACKodeAkunEdit set Keterangan='" & dgUbahNama.GetRowCellValue(b, "KeteranganPajak") & "' where KodeAkunLama='" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgUbahNama.GetRowCellValue(b, "KodeAkun") & "' and KodeAkun='" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgUbahNama.GetRowCellValue(b, "KodeAkunPajak") & "'; "

                    End If
                    query += "update tbACKodeAkun set Keterangan='" & dgUbahNama.GetRowCellValue(b, "KeteranganPajak") & "' where KodeAkun='" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgUbahNama.GetRowCellValue(b, "KodeAkunPajak") & "'; "


                    'jurnal jurnaledit
                    query += "update tbACJurnalEdit set NamaAkunPajak='" & dgUbahNama.GetRowCellValue(b, "KeteranganPajak") & "' where KodeAkun='" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgUbahNama.GetRowCellValue(b, "KodeAkunPajak") & "'; "

                Next

                'ubah kode akun
                For b = 0 To dgGantiKode.gvMain.RowCount - 1

                    Dim dtjurnal As New cMeDB(tJenis.Text)
                    Dim carijurnal As String = _
                        "Select d.KodeAkunLama as KodeAkunLamatbEdit,d.New,d.FlagDelete,a.* from tbACJurnal a " & _
                        "left join tbACJurnalEdit d on a.KodeAkunLama = d.KodeAkunLama and a.NoBukti=d.NoBukti and a.NoUrutAkun =d.NoUrutAkun and a.KodeCompany=d.KodeCompany " & _
                        "where a.KodeAkun = '" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgGantiKode.GetRowCellValue(b, "KodeAkun") & "' and d.FlagDelete is null and month(a.TanggalBukti)='" & Format(dTanggal.EditValue, "MM") & "' and year(a.TanggalBukti)='" & Format(dTanggal.EditValue, "yyyy") & "'"
                    dtjurnal.FillMe(carijurnal)

                    For j = 0 To dtjurnal.Rows.Count - 1
                        Dim kodeakun As String = ""
                        kodeakun = dbcompany.Rows(a).Item("KodeCompany") & "." & dgGantiKode.GetRowCellValue(b, "KodeAkunPajak") & ""

                        Dim jml As Double = 0
                        jml = dtjurnal.Rows(j).Item("Jumlah")

                        Dim kondisi As String = ""
                        If Microsoft.VisualBasic.Left(dtjurnal.Rows(j).Item("NoBukti"), 3) = "MEM" Then
                            kondisi = "MEMJPU"
                        ElseIf Microsoft.VisualBasic.Left(dtjurnal.Rows(j).Item("NoBukti"), 3) = "JPU" Then
                            kondisi = "MEMJPU"
                        End If

                        If Not kondisi = "MEMJPU" Then
                            If dtjurnal.Rows(j).Item("NoUrutAkun") = "1" Then
                                Dim idbank As String = ""
                                Dim idbankbaru As String = ""
                                Dim qq As String = _
                                    "select IdBank from tbACKasBank where KodeAkun='" & dtjurnal.Rows(j).Item("KodeAkun") & "' and KodeCompany='" & Strings.Left(dtjurnal.Rows(j).Item("KodeAkun"), 2) & "'"
                                cmd = New SqlCommand(qq, kon)
                                dr = cmd.ExecuteReader
                                dr.Read()
                                idbank = dr!IdBank
                                dr.Close()

                                Dim qqq As String = _
                                    "select IdBank from tbACKasBank where KodeAkun='" & dtjurnal.Rows(j).Item("KodeAkunPajak") & "' and KodeCompany='" & Strings.Left(dtjurnal.Rows(j).Item("KodeAkunPajak"), 2) & "'"
                                cmd = New SqlCommand(qqq, kon)
                                dr = cmd.ExecuteReader
                                dr.Read()
                                If dr.HasRows Then
                                    idbankbaru = dr!IdBank
                                End If
                                dr.Close()

                                Dim caridatahd As String = _
                                    "select * from tbACVoucherHdEdit where Nomor='" & dtjurnal.Rows(j).Item("NoBukti") & "' and IdBankLama='" & idbank & "'"
                                cmd = New SqlCommand(caridatahd, kon)
                                dr = cmd.ExecuteReader
                                dr.Read()
                                Dim queryhd As String = ""
                                If dr.HasRows Then
                                    Dim idbanklama As String = dr!IdBank
                                    'update
                                    query += _
                                        "update tbACVoucherHdEdit set IdBank='" & idbankbaru & "',Total='" & dtjurnal.Rows(j).Item("Total") & "' " & _
                                        "where Nomor='" & dtjurnal.Rows(j).Item("NoBukti") & "' and IdBank='" & idbanklama & "' and IdBankLama='" & idbank & "'; "
                                    '"update tbACVoucherHdEdit set IdBank='" & idbankbaru & "',Total='" & dtjurnal.Rows(j).Item("Total") & "',FlagPosting='1' " & _
                                    dr.Close()
                                Else
                                    dr.Close()
                                    Dim caridata As String = _
                                        "select * from tbACVoucherHd where Nomor='" & dtjurnal.Rows(j).Item("NoBukti") & "' and IdBank='" & idbank & "'"
                                    cmd = New SqlCommand(caridata, kon)
                                    dr = cmd.ExecuteReader()
                                    dr.Read()
                                    If dr.HasRows Then
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
                                        query += _
                                            "insert into tbACVoucherHdEdit (Nomor" & stringtanggal1 & ",KodeCompany,IdBank,FlagTransaksi," & _
                                            "Keterangan1,Keterangan,Total,NoCekBG,TglJTCekBG," & _
                                            "FlagTunai,FlagValidasi,FlagPosting,Catatan,UserEntry" & _
                                            "" & stringdateenrtyhdedit1 & ",UserUpdate" & stringdateupdatehdedit1 & ",NoUrut,cek," & _
                                            "TadaID,NoRef,FlagDelete,IdBankLama,TotalLama,FlagPostingOri) values (" & _
                                            "'" & dr!Nomor & "'" & stringtanggal2 & ",'" & dr!KodeCompany & "','" & idbankbaru & "','" & dr!FlagTransaksi & "'," & _
                                            "'" & dr!Keterangan1 & "','" & dr!Keterangan & "','" & jml & "','" & dr!NoCekBG & "','" & dr!TglJTCekBG & "'," & _
                                            "'" & dr!FlagTunai & "','" & dr!FlagValidasi & "','" & dr!FlagPosting & "','" & dr!Catatan & "','" & dr!UserEntry & "'" & _
                                            "" & stringdateentryhdedit2 & ",'" & dr!UserUpdate & "'" & stringdateupdatehdedit2 & ",'" & dr!NoUrut & "','" & dr!cek & "'," & _
                                            "'" & dr!TadaID & "','" & dr!NoRef & "','0','" & idbank & "','" & dr!Total & "','0'); "
                                    End If

                                    dr.Close()
                                End If

                            Else
                                Dim caridatadt As String = _
                                    "select * from tbACVoucherDtEdit where Nomor='" & dtjurnal.Rows(j).Item("NoBukti") & "' and KodeAkunLama='" & dtjurnal.Rows(j).Item("KodeAkun") & "' and NoUrut='" & dtjurnal.Rows(j).Item("NoUrutAkun") - 1 & "'"
                                cmd = New SqlCommand(caridatadt, kon)
                                dr = cmd.ExecuteReader
                                dr.Read()
                                Dim querydt As String = ""
                                If dr.HasRows Then
                                    Dim kd As String = dr!KodeAkun
                                    'update
                                    query += _
                                        "update tbACVoucherDtEdit set KodeAkun='" & kodeakun & "',Jumlah='" & jml & "' " & _
                                        "where Nomor='" & dtjurnal.Rows(j).Item("NoBukti") & "' and KodeAkun='" & kd & "' and NoUrut='" & dtjurnal.Rows(j).Item("NoUrutAkun") - 1 & "'; "
                                    dr.Close()
                                Else
                                    dr.Close()
                                    Dim caridata As String = _
                                        "select * from tbACVoucherDt where Nomor='" & dtjurnal.Rows(j).Item("NoBukti") & "' and NoUrut='" & dtjurnal.Rows(j).Item("NoUrutAkun") - 1 & "' and KodeAkun='" & dtjurnal.Rows(j).Item("KodeAkun") & "'"
                                    cmd = New SqlCommand(caridata, kon)
                                    dr = cmd.ExecuteReader()
                                    dr.Read()
                                    If dr.HasRows Then
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
                                        query += _
                                            "insert into tbACVoucherDtEdit (Nomor,NoUrut,KodeAkun,KodeCabang,IdDepartemen," & _
                                            "Keterangan,Jumlah,Saldo,UserEntry" & stringdateenrtydtedit1 & "," & _
                                            "UserUpdate" & stringdateupdatedtedit1 & ",NoRecord,Cek,TadaID," & _
                                            "FlagDelete,JumlahLama,KodeAkunLama,FlagPostingOri) values (" & _
                                            "'" & dr!Nomor & "','" & dr!NoUrut & "','" & kodeakun & "','" & dr!KodeCabang & "','" & dr!IdDepartemen & "'," & _
                                            "'" & dr!Keterangan.ToString.Replace("'", "''") & "','" & jml & "','" & dr!Saldo & "','" & dr!UserEntry & "'" & stringdateentrydtedit2 & "," & _
                                            "'" & dr!UserUpdate & "'" & stringdateupdatedtedit2 & ",'" & dr!NoRecord & "','" & dr!Cek & "','" & dr!TadaID & "'," & _
                                            "'0','" & dr!Jumlah & "','" & dr!KodeAkun & "','0'); "
                                    End If
                                    dr.Close()
                                End If
                            End If
                        End If

                        Dim notNew As Boolean = False
                        If IsDBNull(dtjurnal.Rows(j).Item("New")) Then
                            notNew = True
                        ElseIf dtjurnal.Rows(j).Item("New") = "0" Then
                            notNew = True
                        End If

                        Dim cardatajurnaledit As String = ""
                        If notNew = True Then
                            cardatajurnaledit = _
                            "select * from tbACJurnalEdit where NoBukti='" & dtjurnal.Rows(j).Item("NoBukti") & "' and KodeAkunLama='" & dtjurnal.Rows(j).Item("KodeAkun") & "' " & _
                            "and NoUrutAkun='" & dtjurnal.Rows(j).Item("NoUrutAkun") & "'"
                        Else
                            cardatajurnaledit = _
                            "select * from tbACJurnalEdit where NoBukti='" & dtjurnal.Rows(j).Item("NoBukti") & "' and KodeAkunLama='" & dtjurnal.Rows(j).Item("KodeAkunLama") & "' " & _
                            "and NoUrutAkun='" & dtjurnal.Rows(j).Item("NoUrutAkun") & "'"
                        End If

                        cmd = New SqlCommand(cardatajurnaledit, kon)
                        dr = cmd.ExecuteReader
                        dr.Read()

                        If dr.HasRows Then
                            Dim kd As String = dr!KodeAkun
                            dr.Close()

                            If notNew = True Then
                                query += _
                                    "update tbACJurnalEdit set KodeAkun='" & kodeakun & "', NamaAkunPajak='" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgGantiKode.GetRowCellValue(b, "KeteranganPajak") & "', Jumlah='" & jml & "',FlagPostingJurnalOri='0' " & _
                                    "where NoBukti='" & dtjurnal.Rows(j).Item("NoBukti") & "' and KodeAkun='" & kd & "' and KodeAkunLama='" & dtjurnal.Rows(j).Item("KodeAkun") & "' and NoUrutAkun='" & dtjurnal.Rows(j).Item("NoUrutAkun") & "'; "
                            Else
                                query += _
                                    "update tbACJurnalEdit set KodeAkun='" & dtjurnal.Rows(j).Item("KodeAkunPajak") & "', NamaAkunPajak='" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgGantiKode.GetRowCellValue(b, "KeteranganPajak") & "', Jumlah='" & jml & "',FlagPostingJurnalOri='0' " & _
                                    "where NoBukti='" & dtjurnal.Rows(j).Item("NoBukti") & "' and KodeAkun='" & kd & "' and KodeAkunLama='" & dtjurnal.Rows(j).Item("KodeAkunLama") & "' and NoUrutAkun='" & dtjurnal.Rows(j).Item("NoUrutAkun") & "'; "
                            End If
                        Else
                            dr.Close()
                            Dim caridata As String = _
                            "select * from tbACJurnal where NoBukti='" & dtjurnal.Rows(j).Item("NoBukti") & "' and KodeAkun='" & dtjurnal.Rows(j).Item("KodeAkun") & "' " & _
                                "and NoUrutAkun='" & dtjurnal.Rows(j).Item("NoUrutAkun") & "'"
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

                            query += _
                                "insert into tbACJurnalEdit (KodeCompany,NoBukti" & stringtglbukti1 & ",Tipe,KodeCabang," & _
                                "IdDepartemen,KodeAkun,NoUrutAkun,Keterangan,Jumlah," & _
                                "DebetOrKredit,FlagPosting" & stringpostingdate1 & ",IdTransaksi,UserEntry" & _
                                "" & stringdateentryacjurnal1 & ",NoRecord,TadaID,KodeAkunLama,JumlahLama,NamaAkunPajak,FlagPostingJurnalOri) values (" & _
                                "'" & dr!KodeCompany & "','" & dr!NoBukti & "'" & stringtglbukti2 & ",'" & dr!Tipe & "','" & dr!KodeCabang & "'," & _
                                "'" & dr!IdDepartemen & "','" & kodeakun & "','" & dr!NoUrutAkun & "','" & dr!Keterangan.ToString.Replace("'", "''") & "','" & jml & "'," & _
                                "'" & dr!DebetOrKredit & "','" & dr!FlagPosting & "'" & stringpostingdate2 & ",'" & dr!IdTransaksi & "','" & dr!UserEntry & "'" & _
                                "" & stringdateentryacjurnal2 & ",'" & dr!NoRecord & "','" & dr!TadaID & "','" & dr!KodeAkun & "','" & dr!Jumlah & "','" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgGantiKode.GetRowCellValue(b, "KeteranganPajak") & "','0'); "

                            query += _
                                "update tbACJurnal set KodeAkunLama='" & dr!KodeAkun & "',JumlahLama='" & dr!Jumlah & "' " & _
                                "where NoBukti='" & dr!NoBukti & "' and NoUrutAkun='" & dr!NoUrutAkun & "' and KodeCompany='" & dr!KodeCompany & "' and KodeAkun='" & dr!KodeAkun & "'; "

                            dr.Close()
                        End If
                    Next
                Next
            Next
            query += "commit select 'sukses' as statusx end try begin catch rollback select 'gagal : ' + ERROR_MESSAGE() as statusx end catch"

            Dim db As New DataTable
            da = New SqlDataAdapter(query, kon)
            da.SelectCommand.CommandTimeout = 0
            da.Fill(db)

            If db.Rows.Count > 0 Then
                If (db.Rows(0)!statusx).ToString.Contains("gagal") Then
                    Pesan({"Tambah dan Ubah Kode gagal", "", db.Rows(0)!statusx})
                Else
                    MsgBox("Tambah dan Ubah Kode Berhasil", vbInformation + vbOKOnly, "Informasi")
                End If
            End If
        End If
    End Sub
End Class