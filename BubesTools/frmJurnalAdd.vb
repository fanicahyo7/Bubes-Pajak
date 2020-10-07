Imports meCore
Imports System.Data.SqlClient
Public Class frmJurnalAdd
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Dim konekdbumue, kodecompany As String
    Dim tanggal As Date
    Public Sub New(konekdbumue As String, kodecompany As String, tanggal1 As Date)

        ' This call is required by the designer.
        InitializeComponent()
        Me.konekdbumue = konekdbumue
        Me.kodecompany = kodecompany
        Me.tanggal = tanggal1
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub frmJurnalAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi(konekdbumue)

        cBuktiBaru.Checked = False
        LayoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        LayoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        dTanggalBukti.EditValue = tanggal
        SetTextReadOnly({tNoBukti})
        tKeterangan.Properties.CharacterCasing = CharacterCasing.Upper
        'tKodeCabang1.Text = kodecompany

        cKodeAkun.FirstInit(konekdbumue, "select KodeAkun,Keterangan from tbACKodeAkun where KodeCompany='" & kodecompany & "'", {tKeteranganAkun})
        cNoBukti.FirstInit(konekdbumue, "select distinct NoBukti,Keterangan from tbACJurnal where left(NoBukti,3) = 'JPU' and KodeCompany='" & kodecompany & "' and SUBSTRING(nobukti,8,4)='" & Format(dTanggalBukti.EditValue, "yyMM") & "' order by NoBukti asc")
    End Sub

    Sub nobuktibaru()
        Dim cari As String = ""
        Dim query As String = _
            "select top 1 NoBukti from tbACJurnal where NoBukti like 'JPU." & kodecompany & "." & Format(dTanggalBukti.EditValue, "yyMM") & ".%' order by NoBukti DESC"
        cmd = New SqlCommand(query, kon)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            tNoBukti.Text = "JPU." & kodecompany & "." & Format(dTanggalBukti.EditValue, "yyMM") & ".0001"
        Else
            If Strings.Left(rd.Item("NoBukti").ToString, 12) <> "JPU." & kodecompany & "." & Format(dTanggalBukti.EditValue, "yyMM") & "." Then
                tNoBukti.Text = "JPU." & kodecompany & "." & Format(dTanggalBukti.EditValue, "yyMM") & ".0001"
            Else
                cari = Val(Strings.Mid(rd.Item("NoBukti").ToString, 13, 4)) + 1
                tNoBukti.Text = "JPU." & kodecompany & "." & Format(dTanggalBukti.EditValue, "yyMM") + cari.PadLeft(4, "0")
                If Len(cari) = 1 Then
                    tNoBukti.Text = "JPU." & kodecompany & "." & Format(dTanggalBukti.EditValue, "yyMM") & "." & "000" & cari
                ElseIf Len(cari) = 2 Then
                    tNoBukti.Text = "JPU." & kodecompany & "." & Format(dTanggalBukti.EditValue, "yyMM") & "." & "00" & cari
                ElseIf Len(cari) = 3 Then
                    tNoBukti.Text = "JPU." & kodecompany & "." & Format(dTanggalBukti.EditValue, "yyMM") & "." & "0" & cari
                ElseIf Len(cari) = 4 Then
                    tNoBukti.Text = "JPU." & kodecompany & "." & Format(dTanggalBukti.EditValue, "yyMM") & "." & cari
                End If
            End If
        End If
        rd.Close()
    End Sub

    'Sub nobuktibaru()
    '    Dim cari As String = ""
    '    Dim query As String = _
    '        "select top 1 NoBukti from tbACJurnal where NoBukti like 'JPU." & kodecompany & "." & Date.Now.ToString("yyMM") & ".%' order by NoBukti DESC"
    '    cmd = New SqlCommand(query, kon)
    '    rd = cmd.ExecuteReader
    '    rd.Read()
    '    If Not rd.HasRows Then
    '        tNoBukti.Text = "JPU." & kodecompany & "." & Date.Now.ToString("yyMM") & ".0001"
    '    Else
    '        If Strings.Left(rd.Item("NoBukti").ToString, 12) <> "JPU." & kodecompany & "." & Date.Now.ToString("yyMM") & "." Then
    '            tNoBukti.Text = "JPU." & kodecompany & "." & Date.Now.ToString("yyMM") & ".0001"
    '        Else
    '            cari = Val(Strings.Mid(rd.Item("NoBukti").ToString, 13, 4)) + 1
    '            tNoBukti.Text = "JPU." & kodecompany & "." & Date.Now.ToString("yyMM") + cari.PadLeft(4, "0")
    '            If Len(cari) = 1 Then
    '                tNoBukti.Text = "JPU." & kodecompany & "." & Date.Now.ToString("yyMM") & "." & "000" & cari
    '            ElseIf Len(cari) = 2 Then
    '                tNoBukti.Text = "JPU." & kodecompany & "." & Date.Now.ToString("yyMM") & "." & "00" & cari
    '            ElseIf Len(cari) = 3 Then
    '                tNoBukti.Text = "JPU." & kodecompany & "." & Date.Now.ToString("yyMM") & "." & "0" & cari
    '            ElseIf Len(cari) = 4 Then
    '                tNoBukti.Text = "JPU." & kodecompany & "." & Date.Now.ToString("yyMM") & "." & cari
    '            End If
    '        End If
    '    End If
    '    rd.Close()
    'End Sub
    
    Private Sub cBuktiBaru_CheckedChanged(sender As Object, e As EventArgs) Handles cBuktiBaru.CheckedChanged
        If cBuktiBaru.Checked = True Then
            LayoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LayoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            nobuktibaru()
        Else
            LayoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If CheckBeforeSave({tKeterangan}) = True Then
            Try
                Dim nobukti, dbtorkrdt, dbtorkrdt2, idtransaksi, tipe As String
                Dim nourutakun As Integer
                Dim cariidtransaksi As String = ""
                Dim query As String = ""
                Dim querycari As String = ""
                Dim idbank As String = ""

                Dim caridibank As String = _
                    "select * from tbACKasBank where KodeAkun ='" & cKodeAkun.Text & "'"
                cmd = New SqlCommand(caridibank, kon)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    idbank = rd!IdBank
                Else
                    idbank = "99"
                End If
                rd.Close()

                If cBuktiBaru.Checked = True Then
                    nobukti = tNoBukti.Text
                    'nourutakun = 1
                    'iddepartemen = "99"

                    'cariidtransaksi = _
                    '    "select top 1 IdTransaksi as Hasil from tbACJurnal order by IdTransaksi DESC"

                    If rDebetKredit.SelectedIndex = 0 Then
                        dbtorkrdt2 = "T"
                    Else
                        dbtorkrdt2 = "K"
                    End If

                    query = _
                    "insert into tbACTransaksiKasBank (" & _
                    "KodeCompany,Tanggal,FlagTransaksi,TipeTransaksi," & _
                    "IdBank,KodeAkun,StatusTransaksi,IdDepartemen,Jumlah," & _
                    "Keterangan,NoRef,FlagTunai,FlagTolak,FlagValidasi," & _
                    "FlagPosting,NoBukti,TglBukti,UserEntry,DateTimeEntry" & _
                    ") values (" & _
                    "'" & kodecompany & "','" & DTOC(dTanggalBukti.Text, "/", False) & "','" & dbtorkrdt2 & "','1'," & _
                    "'" & idbank & "','" & cKodeAkun.Text & "','N','00','" & sJumlah.EditValue & "'," & _
                    "'" & tKeterangan.Text & "','','0','0','1'," & _
                    "'1','" & nobukti & "','" & DTOC(dTanggalBukti.Text, "/", False) & "','" & pubUserEntry & "','" & DTOC(Now, "/", True) & "')"

                    querycari = "update tbACJurnal set FlagPosting='1', PostingDate='" & DTOC(Now, "/", True) & "' where " & _
                        "KodeCompany='" & kodecompany & "' and NoBukti='" & nobukti & "' and TanggalBukti='" & DTOC(dTanggalBukti.Text, "/", False) & "' and " & _
                        "KodeAkun='" & cKodeAkun.Text & "' and FlagPosting='0' and NoUrutAkun='1'"
                Else
                    nobukti = cNoBukti.Text
                    'iddepartemen = "00"
                    Dim cari As String = _
                        "select top 1 * from tbACJurnal where NoBukti='" & nobukti & "' order by NoBukti,NoUrutAkun desc"
                    cmd = New SqlCommand(cari, kon)
                    rd = cmd.ExecuteReader
                    rd.Read()
                    nourutakun = rd!NoUrutAkun + 1
                    rd.Close()

                    cariidtransaksi = _
                        "select top 1 IdTransaksi,Tipe from tbACJurnal where NoBukti='" & nobukti & "' order by IdTransaksi DESC"
                    cmd = New SqlCommand(cariidtransaksi, kon)
                    rd = cmd.ExecuteReader
                    rd.Read()
                    idtransaksi = rd!IdTransaksi
                    tipe = rd!Tipe
                    rd.Close()

                    If rDebetKredit.SelectedIndex = 0 Then
                        dbtorkrdt = "D"
                        'tipe = "0"
                    Else
                        dbtorkrdt = "K"
                        'tipe = "1"
                    End If

                    Dim query2 As String = _
                        "insert into tbACJurnalEdit (" & _
                        "KodeCompany,NoBukti,TanggalBukti,Tipe,KodeCabang," & _
                        "IdDepartemen,KodeAkun,NoUrutAkun,Keterangan,Jumlah," & _
                        "DebetOrKredit,FlagPosting,PostingDate,IdTransaksi,UserEntry,DateTimeEntry," & _
                        "KodeAkunLama,JumlahLama," & _
                        "FlagDelete,NamaAkunPajak,FlagPostingJurnalOri" & _
                        ") values (" & _
                        "'" & kodecompany & "','" & nobukti & "','" & DTOC(dTanggalBukti.Text, "/", False) & "','" & tipe & "','" & kodecompany & ".00'," & _
                        "'" & idbank & "','" & cKodeAkun.Text & "','" & nourutakun & "','" & tKeterangan.Text & "','" & sJumlah.EditValue & "'," & _
                        "'" & dbtorkrdt & "','1','" & DTOC(Now, "/", True) & "','" & idtransaksi & "','" & pubUserEntry & "','" & DTOC(Now, "/", True) & "'," & _
                        "'" & cKodeAkun.Text & "','" & sJumlah.EditValue & "'," & _
                        "'0','" & tKeteranganAkun.Text & "','1')"
                    'cmd = New SqlCommand(query2, kon)
                    'cmd.ExecuteNonQuery()

                    query = _
                        "insert into tbACJurnal (" & _
                        "KodeCompany,NoBukti,TanggalBukti,Tipe,KodeCabang," & _
                        "IdDepartemen,KodeAkun,NoUrutAkun,Keterangan,Jumlah," & _
                        "DebetOrKredit,FlagPosting,PostingDate,IdTransaksi,UserEntry,DateTimeEntry" & _
                        ") values (" & _
                        "'" & kodecompany & "','" & nobukti & "','" & DTOC(dTanggalBukti.Text, "/", False) & "','" & tipe & "','" & kodecompany & ".00'," & _
                        "'" & idbank & "','" & cKodeAkun.Text & "','" & nourutakun & "','" & tKeterangan.Text & "','" & sJumlah.EditValue & "'," & _
                        "'" & dbtorkrdt & "','1','" & DTOC(Now, "/", True) & "','" & idtransaksi & "','" & pubUserEntry & "','" & DTOC(Now, "/", True) & "')"
                End If


                'If rDebetKredit.SelectedIndex = 0 Then
                '    dbtorkrdt = "D"
                '    dbtorkrdt2 = "T"
                '    tipe = "0"
                'Else
                '    dbtorkrdt = "K"
                '    dbtorkrdt2 = "K"
                '    tipe = "1"
                'End If

                'Dim queryidts As String = _
                '    "insert into tbACTransaksiKasBank (" & _
                '    "KodeCompany,Tanggal,FlagTransaksi,TipeTransaksi," & _
                '    "IdBank,KodeAkun,StatusTransaksi,IdDepartemen,Jumlah," & _
                '    "Keterangan,NoRef,FlagTunai,FlagTolak,FlagValidasi," & _
                '    "FlagPosting,NoBukti,TglBukti,UserEntry,DateTimeEntry" & _
                '    ") values (" & _
                '    "'" & kodecompany & "','" & DTOC(dTanggalBukti.Text, "/", False) & "','" & dbtorkrdt2 & "','1'," & _
                '    "'99','" & cKodeAkun.Text & "','N','00','" & sJumlah.EditValue & "'," & _
                '    "'" & tKeterangan.Text & "','','0','0','1'," & _
                '    "'1','" & nobukti & "','" & DTOC(dTanggalBukti.Text, "/", False) & "','" & pubUserEntry & "','" & DTOC(Now, "/", True) & "')"
                'cmd = New SqlCommand(queryidts, kon)
                'cmd.ExecuteNonQuery()

                'Dim query As String = _
                '    "insert into tbACJurnalEdit (" & _
                '    "KodeCompany,NoBukti,TanggalBukti,Tipe,KodeCabang," & _
                '    "IdDepartemen,KodeAkun,NoUrutAkun,Keterangan,Jumlah," & _
                '    "DebetOrKredit,FlagPosting,PostingDate,IdTransaksi,UserEntry,DateTimeEntry," & _
                '    "KodeAkunLama,JumlahLama," & _
                '    "FlagDelete,NamaAkunPajak,FlagPostingJurnalOri" & _
                '    ") values (" & _
                '    "'" & kodecompany & "','" & nobukti & "','" & DTOC(dTanggalBukti.Text, "/", False) & "','" & tipe & "','" & kodecompany & "'," & _
                '    "'" & iddepartemen & "','" & cKodeAkun.Text & "','" & nourutakun & "','" & tKeterangan.Text & "','" & sJumlah.EditValue & "'," & _
                '    "'" & dbtorkrdt & "','1','" & DTOC(Now, "/", True) & "','" & idtransaksi & "','" & pubUserEntry & "','" & DTOC(Now, "/", True) & "'," & _
                '    "'" & cKodeAkun.Text & "','" & sJumlah.EditValue & "'," & _
                '    "'0','" & tKeteranganAkun.Text & "','1')"
                cmd = New SqlCommand(query, kon)
                cmd.ExecuteNonQuery()

                If cBuktiBaru.Checked = True Then
                    cmd = New SqlCommand(querycari, kon)
                    cmd.ExecuteNonQuery()
                End If

                'Dim queryori As String = _
                '    "insert into tbACJurnal (" & _
                '    "KodeCompany,NoBukti,TanggalBukti,Tipe,KodeCabang," & _
                '    "IdDepartemen,KodeAkun,NoUrutAkun,Keterangan,Jumlah," & _
                '    "DebetOrKredit,FlagPosting,PostingDate,IdTransaksi,UserEntry,DateTimeEntry," & _
                '    "NoRecord,KodeAkunLama,JumlahLama" & _
                '    ") values (" & _
                '    "'" & kodecompany & "','" & nobukti & "','" & DTOC(dTanggalBukti.Text, "/", False) & "','0','" & tKodeCabang1.Text & tKodeCabang2.Text & "'," & _
                '    "'" & iddepartemen & "','" & cKodeAkun.Text & "','" & nourutakun & "','" & tKeterangan.Text & "','" & sJumlah.EditValue & "'," & _
                '    "'" & dbtorkrdt & "','1','" & DTOC(Now, "/", True) & "','" & idtransaksi & "','" & pubUserEntry & "','" & DTOC(Now, "/", True) & "'," & _
                '    "'','" & cKodeAkun.Text & "','" & sJumlah.EditValue & "'" & _
                '    ")"
                'cmd = New SqlCommand(queryori, kon)
                'cmd.ExecuteNonQuery()

                MsgBox("Tambah Data Berhasil", vbInformation + vbOKOnly, "Informasi")
                Me.Close()
            Catch ex As Exception
                Pesan({"GAGAL SIMPAN DATA", "", "Err : " & ex.Message.ToString})
            End Try
        End If
    End Sub

    Private Sub dTanggalBukti_EditValueChanged(sender As Object, e As EventArgs) Handles dTanggalBukti.EditValueChanged
        If cBuktiBaru.Checked = True Then
            nobuktibaru()
            '    Else
            '        cNoBukti.FirstInit(konekdbumue, "select distinct NoBukti,Keterangan from tbACJurnal where left(NoBukti,3) = 'JPU' and KodeCompany='" & kodecompany & "' and SUBSTRING(nobukti,8,4)='" & Format(dTanggalBukti.EditValue, "yyMM") & "' order by NoBukti asc")
        End If
    End Sub
End Class