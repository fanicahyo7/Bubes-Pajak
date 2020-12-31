Imports System.Data.SqlClient
Imports meCore
Public Class frmKodeAls
    Dim isNew As Double = True
    Private Sub frmKodeAls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadgrid()
    End Sub

    Sub loadgrid()
        'cJenis.FirstInit(PubConnStr, "SELECT Jenis, ConnStr FROM mstUnitBukbes", {tJenis}, , , , , , , {"ConnStr"})
        cJenis.FirstInit(PubConnStr, "SELECT Jenis, ConnStr FROM mstUnitBukbes", , , , , , , , {"ConnStr"})
        cJenis.EditValue = "UE"

        Dim querygrid As String = "select * from tbAlsKodeAkun "

        dgTambahKode.FirstInit(querygrid & "where Status='TAMBAH KODE AKUN' order by KodeAkun", _
                               , , , {"Status"})
        dgTambahKode.ConnString = tJenis.Text
        dgTambahKode.RefreshData(False)

        dgUbahNama.FirstInit(querygrid & "where Status='UBAH NAMA AKUN' order by KodeAkun", _
                       , , , {"Status", "KodeAKunPajak", "LevelAkun", "IdKategori", "StatusJurnal", "DebetOrKredit", "KodeAkunInduk"})
        dgUbahNama.ConnString = tJenis.Text
        dgUbahNama.RefreshData(False)

        dgGantiKode.FirstInit(querygrid & "where Status='UBAH KODE AKUN' order by KodeAkun", _
               , , , {"Status", "LevelAkun", "IdKategori", "StatusJurnal", "DebetOrKredit", "KodeAkunInduk"})
        dgGantiKode.ConnString = tJenis.Text
        dgGantiKode.RefreshData(False)
    End Sub

    Private Sub cJenis_EditValueChanged(sender As Object, e As EventArgs) Handles cJenis.EditValueChanged
        If cJenis.Text = "UE" Then
            tJenis.Text = "Data Source=10.10.2.23;Initial Catalog=BukbesAccUE;Persist Security Info=True;User ID=sa;Password=gogogo;Connection Timeout=0"
        Else
            tJenis.Text = "Data Source=10.10.2.23;Initial Catalog=BukbesAccUM;Persist Security Info=True;User ID=sa;Password=gogogo;Connection Timeout=0"
        End If

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
                    query += "update tbACJurnalEdit set NamaAkunPajak='" & dgUbahNama.GetRowCellValue(b, "KeteranganPajak") & "' where KodeAkun='" & dbcompany.Rows(a).Item("KodeCompany") & "." & dbcompany.Rows(a).Item("KodeCompany") & "." & dgUbahNama.GetRowCellValue(b, "KodeAkunPajak") & "'; "

                Next

                'ubah kode akun
                For b = 0 To dgGantiKode.gvMain.RowCount - 1
                    'cek kode
                    Dim dbdb As New cMeDB(tJenis.Text)
                    Dim pQuery As String = _
                        "Select KodeAkun, KodeCompany, IdKategori, Keterangan,LevelAkun,DebetOrKredit,StatusJurnal,KodeAkunInduk,KodeCabang from tbACKodeAkunEdit " & _
                        "where KodeAkun = '" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgGantiKode.GetRowCellValue(b, "KodeAkunPajak") & "' and KodeAkunLama = '" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgGantiKode.GetRowCellValue(b, "KodeAkun") & "'"
                    dbdb.FillMe(pQuery, True)

                    If dbdb.Rows.Count > 0 Then
                        isNew = False
                    Else
                        isNew = True
                    End If

                    If isNew = True Then
                        Dim carikode As String = "select * from tbACKodeAkun where KodeAkun='" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgGantiKode.GetRowCellValue(b, "KodeAkun") & "'"
                        cmd = New SqlCommand(carikode, kon)
                        rd = cmd.ExecuteReader
                        rd.Read()
                        If rd.HasRows = True Then
                            query += "insert into tbACKodeAkunEdit (" & _
                                "KodeAkun,Keterangan,KodeAkunInduk,LevelAkun,DebetOrKredit," & _
                                "StatusJurnal,KodeCompany,IdKategori,KodeAkunLama," & _
                                "KeteranganLama,IdKategoriLama,LevelAkunLama,DebetOrKreditLama,StatusJurnalLama," & _
                                "KodeAkunIndukLama,KodeCompanyLama,FlagDelete) values (" & _
                                "'" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgGantiKode.GetRowCellValue(b, "KodeAkunPajak") & "','" & dgGantiKode.GetRowCellValue(b, "KeteranganPajak") & "','" & rd!KodeAkunInduk & "','" & rd!LevelAkun & "','" & rd!DebetOrKredit & "'," & _
                                "'" & rd!StatusJurnal & "','" & dbcompany.Rows(a).Item("KodeCompany") & "','" & rd!IdKategori & "','" & rd!KodeAkun & "'," & _
                                "'" & rd!Keterangan & "','" & rd!IdKategori & "','" & rd!LevelAkun & "','" & rd!DebetOrKredit & "','" & rd!StatusJurnal & "'," & _
                                "'" & rd!KodeAkunInduk & "','" & rd!KodeCompany & "','0'); "
                        End If
                        rd.Close()

                        'voucher dt BELUM
                        Dim carivoucherdted As String = "select * from tbACVoucherDtEdit where KodeAkun='" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgGantiKode.GetRowCellValue(b, "KodeAkunPajak") & "' and KodeAkunLama='" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgGantiKode.GetRowCellValue(b, "KodeAkun") & "'"
                        cmd = New SqlCommand(carivoucherdted, kon)
                        rd = cmd.ExecuteReader
                        rd.Read()
                        If rd.HasRows = False Then
                            rd.Close()
                            Dim caridata As String = _
                                "select * from tbACVoucherDt where KodeAkun='" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgGantiKode.GetRowCellValue(b, "KodeAkun") & "' and KodeAkunLama='" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgGantiKode.GetRowCellValue(b, "KodeAkunPajak") & "'; "
                            cmd = New SqlCommand(caridata, kon)
                            rd = cmd.ExecuteReader()
                            rd.Read()
                            If rd.HasRows Then
                                Dim datetimeentrydtedit As DateTime
                                Dim stringdateenrtydtedit1 As String = ""
                                Dim stringdateentrydtedit2 As String = ""
                                If Not IsDBNull(rd!DateTimeEntry) Then
                                    datetimeentrydtedit = rd!DateTimeEntry
                                    stringdateenrtydtedit1 = ",DateTimeEntry"
                                    stringdateentrydtedit2 = ",'" & datetimeentrydtedit.ToString("yyyy-MM-dd hh:mm:ss") & "'"
                                End If

                                Dim datetimeupdatedtedit As DateTime
                                Dim stringdateupdatedtedit1 As String = ""
                                Dim stringdateupdatedtedit2 As String = ""
                                If Not IsDBNull(rd!DateTimeUpdate) Then
                                    datetimeupdatedtedit = rd!DateTimeUpdate
                                    stringdateupdatedtedit1 = ",DateTimeUpdate"
                                    stringdateupdatedtedit2 = ",'" & datetimeupdatedtedit.ToString("yyyy-MM-dd hh:mm:ss") & "'"
                                End If

                                'insert
                                query += _
                                    "insert into tbACVoucherDtEdit (Nomor,NoUrut,KodeAkun,KodeCabang,IdDepartemen," & _
                                    "Keterangan,Jumlah,Saldo,UserEntry" & stringdateenrtydtedit1 & "," & _
                                    "UserUpdate" & stringdateupdatedtedit1 & ",NoRecord,Cek,TadaID," & _
                                    "FlagDelete,JumlahLama,KodeAkunLama,FlagPostingOri) values (" & _
                                    "'" & rd!Nomor & "','" & rd!NoUrut & "','" & rd!KodeAkun & "','" & rd!KodeCabang & "','" & rd!IdDepartemen & "'," & _
                                    "'" & rd!Keterangan & "','" & rd!Jumlah & "','" & rd!Saldo & "','" & rd!UserEntry & "'" & stringdateentrydtedit2 & "," & _
                                    "'" & rd!UserUpdate & "'" & stringdateupdatedtedit2 & ",'" & rd!NoRecord & "','" & rd!Cek & "','" & rd!TadaID & "'," & _
                                    "'0','" & rd!JumlahLama & "','" & rd!KodeAkunLama & "','0'); "
                            End If
                            rd.Close()
                        Else
                            rd.Close()
                            query += "update tbACVoucherDtEdit set KodeAkun='" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgGantiKode.GetRowCellValue(b, "KodeAkunPajak") & "', KodeAkunLama='" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgGantiKode.GetRowCellValue(b, "KodeAkun") & "' where KodeAkun='" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgGantiKode.GetRowCellValue(b, "KodeAkunPajak") & "'; "
                        End If
                    Else
                        query += "update tbACKodeAkunEdit set KodeAkun='" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgGantiKode.GetRowCellValue(b, "KodeAkunPajak") & "', Keterangan='" & dgGantiKode.GetRowCellValue(b, "KeteranganPajak") & "' where KodeAkunLama='" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgGantiKode.GetRowCellValue(b, "KodeAkun") & "' and KodeAkun='" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgGantiKode.GetRowCellValue(b, "KodeAkunPajak") & "'; "
                        query += "update tbACKodeAkun set KodeAkun='" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgGantiKode.GetRowCellValue(b, "KodeAkunPajak") & "',Keterangan='" & dgGantiKode.GetRowCellValue(b, "KeteranganPajak") & "' where KodeAkun='" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgGantiKode.GetRowCellValue(b, "KodeAkun") & "'; "
                    End If

                    query += "update tbACVoucherDt set Keterangan='" & dgGantiKode.GetRowCellValue(b, "KeteranganPajak") & "' where KodeAkun='" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgGantiKode.GetRowCellValue(b, "KodeAkunPajak") & "'; "

                    'jurnal jurnaledit
                    query += "update tbACJurnalEdit set NamaAkunPajak='" & dgGantiKode.GetRowCellValue(b, "KeteranganPajak") & "' where KodeAkun='" & dbcompany.Rows(a).Item("KodeCompany") & "." & dgGantiKode.GetRowCellValue(b, "KodeAkunPajak") & "'; "

                Next
            Next
            query += "commit select 'sukses' as statusx end try begin catch rollback select 'gagal : ' + ERROR_MESSAGE() as statusx end catch"

            Dim db As New DataTable
            da = New SqlDataAdapter(query, kon)
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