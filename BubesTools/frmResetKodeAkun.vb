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
                If drow(i).Item("Keterangan") = "DiHapus" Then
                    If Not Strings.Left(drow(i).Item("NoBukti"), 3) = "MEM" Or Not Strings.Left(drow(i).Item("NoBukti"), 3) = "JPU" Then
                        If drow(i).Item("NoUrutAkun") = "1" Then
                            'hd
                            Dim idbank As String = ""
                            Dim cariidbank As String = _
                                "select IdBank from tbACKasBank where KodeAkun='" & drow(i).Item("KodeAkun") & "' and KodeCompany='" & Strings.Left(drow(i).Item("KodeAkunLama"), 2) & "'"
                            cmd = New SqlCommand(cariidbank, kon)
                            dr = cmd.ExecuteReader
                            dr.Read()
                            idbank = dr!IdBank
                            dr.Close()

                            Dim ambilhdedit As String = _
                                "select * from tbACVoucherHdEdit where Nomor='" & drow(i).Item("NoBukti") & "' and IdBank='" & idbank & "'"
                            cmd = New SqlCommand(ambilhdedit, kon)
                            dr = cmd.ExecuteReader
                            dr.Read()
                            Dim datetimeentryhd As DateTime = dr!DateTimeEntry
                            Dim datetimeupdatehd As DateTime = dr!DateTimeUpdate
                            Dim tglhd As DateTime = dr!Tanggal
                            Dim tambahhd As String = _
                                "insert into tbACVoucherHd (Nomor,Tanggal,KodeCompany,IdBank,FlagTransaksi," & _
                                "Keterangan1,Keterangan,Total,NoCekBG,BankCekBG," & _
                                "FlagTunai,FlagValidasi,FlagPosting,Catatan," & _
                                "UserEntry,DateTimeEntry,UserUpdate,DateTimeUpdate,NoUrut," & _
                                "cek,TadaID,NoRef) values (" & _
                                "'" & dr!Nomor & "','" & tglhd.ToString("yyyy-MM-dd hh:mm:ss") & "','" & dr!KodeCompany & "','" & idbank & "','" & dr!FlagTransaksi & "'," & _
                                "'" & dr!Keterangan1 & "','" & dr!Keterangan & "','" & dr!Total & "','" & dr!NoCekBG & "','" & dr!BankCekBG & "'," & _
                                "'" & dr!FlagTunai & "','" & dr!FlagValidasi & "','" & dr!FlagPosting & "','" & dr!Catatan & "'," & _
                                "'" & dr!UserEntry & "','" & datetimeentryhd.ToString("yyyy-MM-dd hh:mm:ss") & "','" & dr!UserUpdate & "','" & datetimeupdatehd.ToString("yyyy-MM-dd hh:mm:ss") & "','" & dr!NoUrut & "'," & _
                                "'" & dr!cek & "','" & dr!TadaID & "','" & dr!NoRef & "')"
                            dr.Close()
                            cmd = New SqlCommand(tambahhd, kon)
                            cmd.ExecuteNonQuery()

                            Dim hapushdedit As String = _
                                "delete from tbACVoucherHdEdit where Nomor='" & drow(i).Item("NoBukti") & "' and IdBank='" & idbank & "'"
                            cmd = New SqlCommand(hapushdedit, kon)
                            cmd.ExecuteNonQuery()
                        Else
                            'dt
                            Dim ambildtedit As String = _
                                "select * from tbACVoucherDtEdit where Nomor='" & drow(i).Item("NoBukti") & "' and KodeAkun='" & drow(i).Item("KodeAkun") & "' and NoUrut='" & drow(i).Item("NoUrutAkun") - 1 & "'"
                            cmd = New SqlCommand(ambildtedit, kon)
                            dr = cmd.ExecuteReader
                            dr.Read()
                            Dim datetimeentrydt As DateTime = dr!DateTimeEntry
                            Dim datetimeupdatedt As DateTime = dr!DateTimeUpdate
                            Dim tambahdt As String = _
                                 "insert into tbACVoucherDt (Nomor,NoUrut,KodeAkun,KodeCabang,IdDepartemen," & _
                                "Keterangan,Jumlah,Saldo,UserEntry,DateTimeEntry," & _
                                "UserUpdate,DateTimeUpdate,NoRecord,Cek,TadaID" & _
                                ") values (" & _
                                "'" & dr!Nomor & "','" & dr!NoUrut & "','" & dr!KodeAkun & "','" & dr!KodeCabang & "','" & dr!IdDepartemen & "'," & _
                                "'" & dr!Keterangan & "','" & dr!Jumlah & "','" & dr!Saldo & "','" & dr!UserEntry & "','" & datetimeentrydt.ToString("yyyy-MM-dd hh:mm:ss") & "'," & _
                                "'" & dr!UserUpdate & "','" & datetimeupdatedt.ToString("yyyy-MM-dd hh:mm:ss") & "','" & dr!NoRecord & "','" & dr!Cek & "','" & dr!TadaID & "'" & _
                                ")"
                            dr.Close()
                            cmd = New SqlCommand(tambahdt, kon)
                            cmd.ExecuteNonQuery()

                            Dim hapusdtedit As String = _
                                "delete from tbACVoucherDtEdit where Nomor='" & drow(i).Item("NoBukti") & "' and KodeAkun='" & drow(i).Item("KodeAkun") & "' and NoUrut='" & drow(i).Item("NoUrutAkun") - 1 & "'"
                            cmd = New SqlCommand(hapusdtedit, kon)
                            cmd.ExecuteNonQuery()
                        End If
                    End If
                    'jurnal
                    Dim ambiljurnaledit As String = _
                        "select * from tbACJurnalEdit where NoBukti='" & drow(i).Item("NoBukti") & "' and KodeAkun='" & drow(i).Item("KodeAkun") & "' and NoUrutAkun='" & drow(i).Item("NoUrutAkun") & "'"
                    cmd = New SqlCommand(ambiljurnaledit, kon)
                    dr = cmd.ExecuteReader
                    dr.Read()
                    Dim datetimeentry As DateTime = dr!DateTimeEntry
                    Dim postingdate As DateTime = dr!PostingDate
                    Dim tglbukti As DateTime = dr!TanggalBukti
                    Dim tambahjurnal As String = _
                         "insert into tbACJurnal (KodeCompany,NoBukti,TanggalBukti,Tipe,KodeCabang," & _
                        "IdDepartemen,KodeAkun,NoUrutAkun,Keterangan,Jumlah," & _
                        "DebetOrKredit,FlagPosting,PostingDate,IdTransaksi,UserEntry," & _
                        "DateTimeEntry,NoRecord,TadaID) values (" & _
                        "'" & dr!KodeCompany & "','" & dr!NoBukti & "','" & tglbukti.ToString("yyyy-MM-dd hh:mm:ss") & "','" & dr!Tipe & "','" & dr!KodeCabang & "'," & _
                        "'" & dr!IdDepartemen & "','" & dr!KodeAkun & "','" & dr!NoUrutAkun & "','" & dr!Keterangan & "','" & dr!Jumlah & "'," & _
                        "'" & dr!DebetOrKredit & "','" & dr!FlagPosting & "','" & postingdate.ToString("yyyy-MM-dd hh:mm:ss") & "','" & dr!IdTransaksi & "','" & dr!UserEntry & "'," & _
                        "'" & datetimeentry.ToString("yyyy-MM-dd hh:mm:ss") & "','" & dr!NoRecord & "','" & dr!TadaID & "')"
                    dr.Close()
                    cmd = New SqlCommand(tambahjurnal, kon)
                    cmd.ExecuteNonQuery()

                    Dim hapusjurnaledit As String = _
                        "delete from tbACJurnalEdit where NoBukti='" & drow(i).Item("NoBukti") & "' and KodeAkun='" & drow(i).Item("KodeAkun") & "' and NoUrutAkun='" & drow(i).Item("NoUrutAkun") & "'"
                    cmd = New SqlCommand(hapusjurnaledit, kon)
                    cmd.ExecuteNonQuery()

                ElseIf drow(i).Item("Keterangan") = "DiEdit" Then
                    Dim kondisi As String = ""
                    If Strings.Left(drow(i).Item("NoBukti"), 3) = "MEM" Then
                        kondisi = "MEMJPU"
                    ElseIf Strings.Left(drow(i).Item("NoBukti"), 3) = "JPU" Then
                        kondisi = "MEMJPU"
                    End If

                    If Not kondisi = "MEMJPU" Then
                        If drow(i).Item("NoUrutAkun") = "1" Then
                            Dim idbanklama As String = ""
                            Dim idbanksekarang As String = ""
                            Dim cariidbank As String = _
                                "select IdBank from tbACKasBank where KodeAkun='" & drow(i).Item("KodeAkunLama") & "' and KodeCompany='" & Strings.Left(drow(i).Item("KodeAkunLama"), 2) & "'"
                            cmd = New SqlCommand(cariidbank, kon)
                            dr = cmd.ExecuteReader
                            dr.Read()
                            idbanklama = dr!IdBank
                            dr.Close()

                            Dim qqq As String = _
                                "select IdBank from tbACKasBank where KodeAkun='" & drow(i).Item("KodeAkun") & "' and KodeCompany='" & Strings.Left(drow(i).Item("KodeAkun"), 2) & "'"
                            cmd = New SqlCommand(qqq, kon)
                            dr = cmd.ExecuteReader
                            dr.Read()
                            If dr.HasRows Then
                                idbanksekarang = dr!IdBank
                            End If
                            dr.Close()

                            'ubah vouhd ori
                            Dim ubahvouhdori As String = _
                                "update tbACVoucherHd set IdBank='" & idbanklama & "',Total='" & drow(i).Item("JumlahLama") & "',IdBankLama='',TotalLama='' " & _
                                "where Nomor='" & drow(i).Item("NoBukti") & "' and IdBankLama='" & idbanklama & "' and " & _
                                "TotalLama='" & drow(i).Item("JumlahLama") & "' and IdBank='" & idbanksekarang & "' and Total='" & drow(i).Item("Jumlah") & "'"
                            cmd = New SqlCommand(ubahvouhdori, kon)
                            cmd.ExecuteNonQuery()

                            'hapus vouhd edit
                            Dim hapusvouhdedit As String = _
                                "delete from tbACVoucherHdEdit where IdBank='" & idbanksekarang & "' and IdBankLama='" & idbanklama & "' and Nomor='" & drow(i).Item("NoBukti") & "' and " & _
                                "TotalLama='" & drow(i).Item("JumlahLama") & "' and Total='" & drow(i).Item("Jumlah") & "'"
                            cmd = New SqlCommand(hapusvouhdedit, kon)
                            cmd.ExecuteNonQuery()
                        Else
                            'ubah voudt ori
                            Dim ubahvoudtori As String = _
                                "update tbACVoucherDt set KodeAkun='" & drow(i).Item("KodeAkunLama") & "',Jumlah='" & drow(i).Item("JumlahLama") & "',KodeAkunLama='',JumlahLama='' " & _
                                "where Nomor='" & drow(i).Item("NoBukti") & "' and " & _
                                "KodeAkunLama='" & drow(i).Item("KodeAkunLama") & "' and JumlahLama='" & drow(i).Item("JumlahLama") & "' " & _
                                "and KodeAkun='" & drow(i).Item("KodeAkun") & "' and Jumlah='" & drow(i).Item("Jumlah") & "' and NoUrut='" & drow(i).Item("NoUrutAkun") - 1 & "'"
                            cmd = New SqlCommand(ubahvoudtori, kon)
                            cmd.ExecuteNonQuery()

                            'hapus voudt edit
                            Dim hapusvoudtedit As String = _
                                "delete from tbACVoucherDtEdit where KodeAkun='" & drow(i).Item("KodeAkun") & "' and KodeAkunLama='" & drow(i).Item("KodeAkunLama") & "' and Nomor='" & drow(i).Item("NoBukti") & "' and " & _
                                "Jumlah='" & drow(i).Item("Jumlah") & "' and JumlahLama='" & drow(i).Item("JumlahLama") & "' and NoUrut='" & drow(i).Item("NoUrutAkun") - 1 & "'"
                            cmd = New SqlCommand(hapusvoudtedit, kon)
                            cmd.ExecuteNonQuery()
                        End If
                    End If
                    'ubah jurnalori
                    Dim ubahjurnalori As String = _
                        "update tbACJurnal set KodeAkun='" & drow(i).Item("KodeAkunLama") & "',Jumlah='" & drow(i).Item("JumlahLama") & "',KodeAkunLama='',JumlahLama='' where " & _
                        "KodeAkun='" & drow(i).Item("KodeAkun") & "' and KodeAkunLama='" & drow(i).Item("KodeAkunLama") & "' and Jumlah='" & drow(i).Item("Jumlah") & "' and " & _
                        "JumlahLama='" & drow(i).Item("JumlahLama") & "' and NoUrutAkun='" & drow(i).Item("NoUrutAkun") & "' and NoBukti='" & drow(i).Item("NoBukti") & "'"
                    cmd = New SqlCommand(ubahjurnalori, kon)
                    cmd.ExecuteNonQuery()
                    'hapus jurnal edit
                    Dim hapusjurnaledit As String = _
                        "delete from tbACJurnalEdit where KodeAkun='" & drow(i).Item("KodeAkun") & "' and KodeAkunLama='" & drow(i).Item("KodeAkunLama") & "' and " & _
                        "NoBukti='" & drow(i).Item("NoBukti") & "' and Jumlah='" & drow(i).Item("Jumlah") & "' and JumlahLama='" & drow(i).Item("JumlahLama") & "'"
                    cmd = New SqlCommand(hapusjurnaledit, kon)
                    cmd.ExecuteNonQuery()
                End If
            Next
            MsgBox("Reset Data Berhasil", vbInformation + vbOKOnly, "Informasi")
            loaddata()
        End If
    End Sub
End Class