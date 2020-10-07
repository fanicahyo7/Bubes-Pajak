'Imports System.Data.OleDb
'Imports meCore
'Imports System.Data.SqlClient
Public Class frmBubesEdit
    '    Dim dateMin As DateTime
    '    Dim dateMax As DateTime

    '    Private Sub btnImportExcel_Click(sender As Object, e As EventArgs) Handles btnImportExcel.Click
    '        OpenFileDialog1.Filter = "(*.xlsx)|*.xlsx|(*.xls)|*.xls|All files (*.*)|*.*"
    '        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then
    '            Exit Sub
    '        Else
    '            'dgJurnal.gvMain.LoadingPanelVisible = True
    '            'koneksiexcel(OpenFileDialog1.FileName)
    '            'Dim query As String = "select [Tanggal],[Thn] as Tahun,[Bln] as Bulan,[Nama Legal] as NamaLegal,[Kode Akun] as KodeAkun,[Nama Akun] as NamaAkun," & _
    '            '                               "[Alias Akun] as AliasAkun,[No# Bukti] as NoBukti,[Keterangan],[Debet_Internal] as DebetInternal,[Kredit_Internal] as KreditInternal,[Internal]," & _
    '            '                               "[Penys# Debet] as PenyesuaianDebet,[Penys# Kredit] as PenyesuaianKredit,[Penys# Komersial] as PenyesuaianKomersial,[Saldo Awal Komersial] as SaldoAwalKomersial,[Debet Komersial] as DebetKomersial," & _
    '            '                               "[Kredit Komersial] as KreditKomersial,[Komersial],[Saldo Akhir Komersial] as SaldoAkhirKomersial,[Keterangan1] from [Sheet1$]"
    '            'daexcel = New OleDbDataAdapter(query, konexcel)
    '            'dsexcel.Clear()
    '            'daexcel.Fill(dsexcel)
    '            'dgJurnal.DataSource = dsexcel.Tables(0)
    '            'dgJurnal.colWidth = {1, 0.5, 0.5, 1.8, 0.8, 1.6, 1.3, 1.5, 1.5, 1, _
    '            '                     1, 1, 1, 1, 1.1, 1.4, 1.1, 1.1, 1.1, 1.1, 2}
    '            'dgJurnal.colDecimalDigitforNumCol = 0
    '            'dgJurnal.ColHeaderHeight = 50
    '            'dgJurnal.colFitGrid = False
    '            'dgJurnal.colDecimalDigitforNumCol = 0
    '            'dgJurnal.colSum = {"Internal", "DebetInternal", "KreditInternal", _
    '            '                   "PenyesuaianKomersial", "PenyesuaianKredit", "PenyesuaianDebet", _
    '            '                   "SaldoAwalKomersial", "DebetKomersial", "KreditKomersial", "Komersial", "SaldoAkhirKomersial"}
    '            'dgJurnal.colForEntry = {"PenyesuaianDebet", "PenyesuaianKredit"}
    '            'dgJurnal.RefreshDataView()
    '            'dgJurnal.gvMain.LoadingPanelVisible = False
    '            'btnSimpan.Enabled = False

    '            'dateMin = dsexcel.Tables(0).Compute("min(Tanggal)", "")
    '            'dateMax = dsexcel.Tables(0).Compute("max(Tanggal)", "")

    '            'Dim querytgl As String = "select Max(Tanggal) as maxx, Min(Tanggal) as minn from [Sheet1$]"
    '            'cmdexcel = New OleDbCommand(querytgl, konexcel)
    '            'drexcel = cmdexcel.ExecuteReader
    '            'If drexcel.HasRows Then
    '            '    tanggalatas = drexcel!maxx
    '            '    tanggalbawah = drexcel!minn
    '            'Else
    '            '    tanggalatas = ""
    '            '    tanggalbawah = ""
    '            'End If
    '            'drexcel.Close()
    '        End If
    '        cekgrid()
    '    End Sub

    '    Sub cekgrid()
    '        If dgJurnal.gvMain.RowCount > 0 Then
    '            lFiltergroup.Enabled = True
    '        Else
    '            lFiltergroup.Enabled = False
    '        End If
    '    End Sub

    '    Private Sub frmBubesEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '        pubStartUpApp = Application.StartupPath
    '        PubConnStr = getSQLConIni(Application.StartupPath & "\sqlcon.ini")
    '        PubConnStr = Replace(PubConnStr, "Provider=SQLOLEDB.1;", "")
    '        pubUserEntry = "QC"
    '        koneksi()

    '        cCompany.FirstInit(PubConnStr, "Select KodeCompany,Nama from tbGNCompany", {tNama})

    '        cTahun.Properties.Items.Clear()
    '        For a = 2010 To 2040
    '            cTahun.Properties.Items.Add(a)
    '        Next
    '        cekgrid()
    '    End Sub

    '    Private Sub CtrlMeDataGrid1_Grid_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles dgJurnal.Grid_ValidateRow
    '        Dim jenis As String = ""
    '        If dgJurnal.GetRowCellValue(e.RowHandle, "DebetInternal") = "0" Or dgJurnal.GetRowCellValue(e.RowHandle, "DebetInternal") = "-" Then
    '            jenis = "KREDIT"
    '            dgJurnal.SetRowCellValue(e.RowHandle, "PenyesuaianDebet", 0)
    '        ElseIf dgJurnal.GetRowCellValue(e.RowHandle, "KreditInternal") = "0" Or dgJurnal.GetRowCellValue(e.RowHandle, "KreditInternal") = "-" Then
    '            jenis = "DEBET"
    '            dgJurnal.SetRowCellValue(e.RowHandle, "PenyesuaianKredit", 0)
    '        End If

    '        If IsDBNull(dgJurnal.GetRowCellValue(e.RowHandle, "PenyesuaianDebet")) Then
    '            dgJurnal.SetRowCellValue(e.RowHandle, "PenyesuaianDebet", 0)
    '        End If
    '        If IsDBNull(dgJurnal.GetRowCellValue(e.RowHandle, "PenyesuaianKredit")) Then
    '            dgJurnal.SetRowCellValue(e.RowHandle, "PenyesuaianKredit", 0)
    '        End If

    '        If jenis = "DEBET" Then
    '            dgJurnal.SetRowCellValue(e.RowHandle, "PenyesuaianKomersial", dgJurnal.GetRowCellValue(e.RowHandle, "PenyesuaianDebet"))
    '            dgJurnal.SetRowCellValue(e.RowHandle, "DebetKomersial", dgJurnal.GetRowCellValue(e.RowHandle, "PenyesuaianDebet") + dgJurnal.GetRowCellValue(e.RowHandle, "DebetInternal"))
    '            dgJurnal.SetRowCellValue(e.RowHandle, "KreditKomersial", 0)
    '        ElseIf jenis = "KREDIT" Then
    '            Dim kredit As Double = -1 * dgJurnal.GetRowCellValue(e.RowHandle, "PenyesuaianKredit")
    '            dgJurnal.SetRowCellValue(e.RowHandle, "PenyesuaianKomersial", kredit)
    '            dgJurnal.SetRowCellValue(e.RowHandle, "KreditKomersial", dgJurnal.GetRowCellValue(e.RowHandle, "PenyesuaianKredit") + dgJurnal.GetRowCellValue(e.RowHandle, "KreditInternal"))
    '            dgJurnal.SetRowCellValue(e.RowHandle, "DebetKomersial", 0)
    '        End If

    '        If dgJurnal.GetRowCellValue(e.RowHandle, "DebetKomersial") = 0 Then
    '            If dgJurnal.GetRowCellValue(e.RowHandle, "DebetInternal") = "-" Or IsDBNull(dgJurnal.GetRowCellValue(e.RowHandle, "DebetInternal")) Then
    '                dgJurnal.SetRowCellValue(e.RowHandle, "DebetKomersial", 0)
    '            Else
    '                dgJurnal.SetRowCellValue(e.RowHandle, "DebetKomersial", dgJurnal.GetRowCellValue(e.RowHandle, "DebetInternal"))
    '            End If
    '        End If

    '        If dgJurnal.GetRowCellValue(e.RowHandle, "KreditKomersial") = 0 Then
    '            If dgJurnal.GetRowCellValue(e.RowHandle, "KreditInternal") = "-" Or IsDBNull(dgJurnal.GetRowCellValue(e.RowHandle, "KreditInternal")) Then
    '                dgJurnal.SetRowCellValue(e.RowHandle, "KreditKomersial", 0)
    '            Else
    '                dgJurnal.SetRowCellValue(e.RowHandle, "KreditKomersial", dgJurnal.GetRowCellValue(e.RowHandle, "KreditInternal"))
    '            End If
    '        End If

    '        dgJurnal.SetRowCellValue(e.RowHandle, "Komersial", dgJurnal.GetRowCellValue(e.RowHandle, "DebetKomersial") - dgJurnal.GetRowCellValue(e.RowHandle, "KreditKomersial"))
    '        dgJurnal.SetRowCellValue(e.RowHandle, "SaldoAkhirKomersial", dgJurnal.GetRowCellValue(e.RowHandle, "SaldoAwalKomersial") + dgJurnal.GetRowCellValue(e.RowHandle, "Komersial"))
    '    End Sub

    '    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

    '        Dim jmlinternal As Double = dgJurnal.GetSummaryColDB("Internal")
    '        Dim jmlPensyKom As Double = dgJurnal.GetSummaryColDB("PenyesuaianKomersial")
    '        Dim jmlkomersial As Double = dgJurnal.GetSummaryColDB("Komersial")

    '        'Dim cekcompany As String = "select distinct substring([Kode Akun],1,2) as KodeAkun from [Sheet1$] where month([Tanggal])='01' and year([Tanggal])='2019'"


    '        If Not Math.Round(jmlinternal, 0) = 0 Or Not Math.Round(jmlPensyKom, 0) = 0 Or Not Math.Round(jmlkomersial, 0) = 0 Then
    '            MsgBox("TIDAK BALANCE!" & vbCrLf & "Data Tidak Dapat Disimpan!", vbCritical + vbOKOnly, "Peringatan")
    '        Else
    '            dgJurnal.gvMain.LoadingPanelVisible = True
    '            'hapus seluruh data di db
    '            Dim hapusdatajurnal As String = "delete from tbACJurnal where KodeCompany='" & cCompany.Text & "' and month(TanggalBukti)='" & tBln.Text & "' and year(TanggalBukti)='" & cTahun.Text & "'"
    '            cmd = New SqlCommand(hapusdatajurnal, kon)
    '            cmd.ExecuteNonQuery()

    '            Dim hapusvoucherdt As String = "delete from tbACVoucherDt where Substring(KodeAkun,1,2)='" & cCompany.Text & "'"
    '            cmd = New SqlCommand(hapusvoucherdt, kon)
    '            cmd.ExecuteNonQuery()

    '            Dim hapusvoucherhd As String = "delete from tbACVoucherHd where KodeCompany='" & cCompany.Text & "' and month(Tanggal)='" & tBln.Text & "' and year(Tanggal)='" & cTahun.Text & "'"
    '            cmd = New SqlCommand(hapusvoucherhd, kon)
    '            cmd.ExecuteNonQuery()

    '            'kelompokkan data di excel berdasarkan nobukti
    '            'Dim distictexcel As String = "select distinct [No# Bukti] as NoBukti from [Sheet1$] where [Kode Akun] like '" & cCompany.Text & "%' and [Bln]='" & tBln.Text & "' and [Thn]='" & cTahun.Text & "'"
    '            'daexcel = New OleDbDataAdapter(distictexcel, konexcel)
    '            'dsexcel.Clear()
    '            'daexcel.Fill(dsexcel)

    '            'Dim jmlnobukti As Integer = dsexcel.Tables(0).Rows.Count

    '            'For a = 0 To jmlnobukti - 1
    '            '    Dim nobukti As String = dsexcel.Tables(0).Rows(a).Item("NoBukti")

    '            'Dim querycaridatadidb As String = _
    '            '    "select * from tbacjurnal where NoBukti='" & nobukti & "' and KodeCompany='" & cCompany.Text & "'"
    '            cmd = New SqlCommand(querycaridatadidb, kon)
    '            dr = cmd.ExecuteReader
    '            Dim jnsbmbk As String = ""
    '            If dr.Read = False Then
    '                dr.Close()
    '                'jnsbmbk = Strings.Left(nobukti, 2)
    '                'Dim drowi() As DataRow = dgJurnal.DataSource.Select("NoBukti = '" & nobukti & "' and Tahun='" & cTahun.Text & "' and Bulan='" & tBln.Text & "'")
    '                If jnsbmbk = "BK" Then
    '                    'cari header bk dan simpan jurnal
    '                    For Each xx As DataRow In drowi
    '                        If Not xx!KreditKomersial = 0 Then
    '                            Dim idbank As String = ""
    '                            Dim cariidbank As String = "select * from tbackasbank where KodeAkun='" & xx!KodeAkun & "'"
    '                            cmd = New SqlCommand(cariidbank, kon)
    '                            Dim drkdakun As SqlDataReader = cmd.ExecuteReader
    '                            If drkdakun.Read Then
    '                                idbank = drkdakun!idbank
    '                            End If
    '                            drkdakun.Close()

    '                            Dim querysimpanhd As String = _
    '                                "insert into tbACVoucherHd (Nomor,Tanggal,KodeCompany,IdBank,FlagTransaksi,Keterangan1,Keterangan,Total,UserEntry,DateTimeEntry) values " & _
    '                                "('" & xx!NoBukti & "','" & Format(xx!Tanggal, "yyyyMMdd") & "','" & Strings.Mid(xx!NoBukti, 4, 2) & "'," & _
    '                                "'" & idbank & "','K','" & xx!Keterangan1 & "','" & xx!Keterangan & "'," & _
    '                                "'" & xx!KreditKomersial & "', '" & pubUserEntry & "','" & DTOC(Now, "-", True) & "')"
    '                            cmd = New SqlCommand(querysimpanhd, kon)
    '                            cmd.ExecuteNonQuery()

    '                            Dim querysimpanjurnal As String = _
    '                                "insert into tbACJurnal (KodeCompany,NoBukti,TanggalBukti,Tipe,KodeCabang,KodeAKun,NoUrutAkun,Keterangan,Jumlah,DebetOrKredit,UserEntry,DateTimeEntry) values " & _
    '                                "('" & Strings.Mid(xx!NoBukti, 4, 2) & "','" & xx!NoBukti & "','" & Format(xx!Tanggal, "yyyyMMdd") & "','1','" & Strings.Mid(xx!NoBukti, 4, 2) & ".01', " & _
    '                                "'" & xx!KodeAkun & "','1','" & xx!Keterangan & "','" & xx!DebetKomersial & "','K','" & pubUserEntry & "','" & DTOC(Now, "-", True) & "')"
    '                            cmd = New SqlCommand(querysimpanjurnal, kon)
    '                            cmd.ExecuteNonQuery()
    '                        End If
    '                    Next

    '                    'cari detail bk dan simpan jurnal
    '                    'For Each xx As DataRow In drowi
    '                    'If Not xx!DebetKomersial = 0 Then
    '                    Dim nomorurut As Integer = 0
    '                    Dim querycarinomor As String = "select Max(NoUrut) as NewNoUrut from tbACVoucherDt where Nomor='" & xx!NoBukti & "'"
    '                    cmd = New SqlCommand(querycarinomor, kon)
    '                    Dim drnomor As SqlDataReader = cmd.ExecuteReader
    '                    drnomor.Read()
    '                    If Not IsDBNull(drnomor!NewNoUrut) Then
    '                        nomorurut = drnomor!NewNoUrut + 1
    '                    Else
    '                        nomorurut = 2
    '                    End If
    '                    drnomor.Close()

    '                    'Dim querysimpandt As String = "insert into tbACVoucherDt (Nomor,NoUrut,KodeAkun,Keterangan,Jumlah,Saldo,UserEntry,DateTimeEntry) values " & _
    '                    '    "('" & xx!NoBukti & "','" & nomorurut & "','" & xx!KodeAkun & "','" & xx!Keterangan & "','" & xx!DebetKomersial & "','" & xx!SaldoAKhirKomersial & "','" & pubUserEntry & "','" & DTOC(Now, "-", True) & "')"
    '                    'cmd = New SqlCommand(querysimpandt, kon)
    '                    'cmd.ExecuteNonQuery()

    '                    'Dim querysimpanjurnal As String = _
    '                    '    "insert into tbACJurnal (KodeCompany,NoBukti,TanggalBukti,Tipe,KodeCabang,KodeAKun,NoUrutAkun,Keterangan,Jumlah,DebetOrKredit,UserEntry,DateTimeEntry) values " & _
    '                    '    "('" & Strings.Mid(xx!NoBukti, 4, 2) & "','" & xx!NoBukti & "','" & Format(xx!Tanggal, "yyyyMMdd") & "','1','" & Strings.Mid(xx!NoBukti, 4, 2) & ".00', " & _
    '                    '    "'" & xx!KodeAkun & "','" & nomorurut + 1 & "','" & xx!Keterangan & "','" & xx!DebetKomersial & "','D','" & pubUserEntry & "','" & DTOC(Now, "-", True) & "')"
    '                    'cmd = New SqlCommand(querysimpanjurnal, kon)
    '                    cmd.ExecuteNonQuery()
    '                End If
    '                'Next

    '            ElseIf jnsbmbk = "BM" Then
    '                'cari header bm dan simpan jurnal
    '                'For Each xx As DataRow In drowi
    '                'If Not xx!DebetKomersial = 0 Then
    '                Dim idbank As String = ""
    '                Dim cariidbank As String = "select * from tbackasbank where KodeAkun='" & xx!KodeAkun & "'"
    '                cmd = New SqlCommand(cariidbank, kon)
    '                Dim drkdakun As SqlDataReader = cmd.ExecuteReader
    '                If drkdakun.Read Then
    '                    idbank = drkdakun!idbank
    '                End If
    '                drkdakun.Close()
    '                Dim querysimpanhd As String = _
    '                    "insert into tbACVoucherHd (Nomor,Tanggal,KodeCompany,IdBank,FlagTransaksi,Keterangan1,Keterangan,Total,UserEntry,DateTimeEntry) values " & _
    '                    "('" & xx!NoBukti & "','" & Format(xx!Tanggal, "yyyyMMdd") & "','" & Strings.Mid(xx!NoBukti, 4, 2) & "'," & _
    '                    "'" & idbank & "','T','" & xx!Keterangan1 & "','" & xx!Keterangan & "'," & _
    '                    "'" & xx!DebetKomersial & "', '" & pubUserEntry & "','" & DTOC(Now, "-", True) & "')"
    '                cmd = New SqlCommand(querysimpanhd, kon)
    '                cmd.ExecuteNonQuery()

    '                Dim querysimpanjurnal As String = _
    '                    "insert into tbACJurnal (KodeCompany,NoBukti,TanggalBukti,Tipe,KodeCabang,KodeAKun,NoUrutAkun,Keterangan,Jumlah,DebetOrKredit,UserEntry,DateTimeEntry) values " & _
    '                    "('" & Strings.Mid(xx!NoBukti, 4, 2) & "','" & xx!NoBukti & "','" & Format(xx!Tanggal, "yyyyMMdd") & "','1','" & Strings.Mid(xx!NoBukti, 4, 2) & ".01' " & _
    '                    "'" & xx!KodeAkun & "','1','" & xx!Keterangan & "','" & xx!DebetKomersial & "','D','" & pubUserEntry & "','" & DTOC(Now, "-", True) & "')"
    '                cmd = New SqlCommand(querysimpanjurnal, kon)
    '                cmd.ExecuteNonQuery()
    '            End If

    '            'cari detail bm dan simpan jurnal
    '            If Not xx!KreditKomersial = 0 Then
    '                Dim nomorurut As Integer = 0
    '                Dim querycarinomor As String = "select Max(NoUrut) as NewNoUrut from tbACVoucherDt where Nomor='" & xx!NoBukti & "'"
    '                cmd = New SqlCommand(querycarinomor, kon)
    '                Dim drnomor As SqlDataReader = cmd.ExecuteReader
    '                drnomor.Read()
    '                If Not IsDBNull(drnomor!NewNoUrut) Then
    '                    nomorurut = drnomor!NewNoUrut + 1
    '                Else
    '                    nomorurut = 2
    '                End If
    '                drnomor.Close()

    '                Dim querysimpandt As String = "insert into tbACVoucherDt (Nomor,NomorUrut,KodeAkun,Keterangan,Jumlah,Saldo,UserEntry,DateTimeEntry) values " & _
    '                    "('" & xx!NoBukti & "','" & nomorurut & "','" & xx!KodeAkun & "','" & xx!Keterangan & "','" & xx!KreditKomersial & "','" & xx!SaldoAKhirKomersial & "','" & pubUserEntry & "','" & DTOC(Now, "-", True) & "')"
    '                cmd = New SqlCommand(querysimpandt, kon)
    '                cmd.ExecuteNonQuery()

    '                Dim querysimpanjurnal As String = _
    '                    "insert into tbACJurnal (KodeCompany,NoBukti,TanggalBukti,Tipe,KodeCabang,KodeAKun,NoUrutAkun,Keterangan,Jumlah,DebetOrKredit,UserEntry,DateTimeEntry) values " & _
    '                    "('" & Strings.Mid(xx!NoBukti, 4, 2) & "','" & xx!NoBukti & "','" & Format(xx!Tanggal, "yyyyMMdd") & "','1','" & Strings.Mid(xx!NoBukti, 4, 2) & ".01' " & _
    '                    "'" & xx!KodeAkun & "','" & nomorurut + 1 & "','" & xx!Keterangan & "','" & xx!DebetKomersial & "','K','" & pubUserEntry & "','" & DTOC(Now, "-", True) & "')"
    '                cmd = New SqlCommand(querysimpanjurnal, kon)
    '                cmd.ExecuteNonQuery()
    '            End If
    '                Next
    '            Else
    '                'simpan mem dan jpu
    '            End If
    '            'Else
    '            dr.Close()
    '        End If

    '        'Next
    '        'For Each ax As DataRow In drow
    '        '    'hapus
    '        '    Dim hapusjurnal As String = "delete from tbACJurnal where KodeCompany='" & Strings.Mid(ax!NoBukti, 4, 2) & "' and TanggalBukti between '" & Format(dateMin, "yyyyMMdd") & "' and '" & Format(dateMax, "yyyyMMdd") & "'"
    '        '    cmd = New SqlCommand(hapusjurnal, kon)
    '        '    cmd.ExecuteNonQuery()

    '        '    Dim hapusvoucheDt As String = "delete from tbACVoucherDt where DateTimeEntry between '" & Format(dateMin, "yyyyMMdd") & "' and '" & Format(dateMax, "yyyyMMdd") & "' and Substring(KodeAkun,1,2)='" & Strings.Mid(ax!NoBukti, 4, 2) & "'"
    '        '    cmd = New SqlCommand(hapusvoucheDt, kon)
    '        '    cmd.ExecuteNonQuery()

    '        '    Dim hapusvoucherHd As String = "delete from tbACVoucherHd where KodeCompany='" & Strings.Mid(ax!NoBukti, 4, 2) & "' and Tanggal between '" & Format(dateMin, "yyyyMMdd") & "' and '" & Format(dateMax, "yyyyMMdd") & "'"
    '        '    cmd = New SqlCommand(hapusvoucherHd, kon)
    '        '    cmd.ExecuteNonQuery()

    '        'Next


    '        'Dim dist As String = "select distinct [No# Bukti] as NoBukti from [Sheet1$] where [Tanggal]=''"
    '        'daexcel = New OleDbDataAdapter(dist, konexcel)
    '        'dsexcel.Clear()
    '        'daexcel.Fill(dsexcel)
    '        'Dim a As Integer = dsexcel.Tables(0).Rows.Count

    '        'Dim drow() As DataRow = dgJurnal.DataSource.Select("")
    '        'Dim bmbk As String = ""
    '        'For Each xx As DataRow In drow

    '        '    bmbk = Strings.Left(xx!NoBukti, 2)

    '        '    If bmbk = "BK" Then
    '        '        If Not xx!KreditKomersial = 0 Then
    '        '            Dim idbank As String = ""
    '        '            Dim cariidbank As String = "select * from tbackasbank where KodeAkun='" & xx!KodeAkun & "'"
    '        '            cmd = New SqlCommand(cariidbank, kon)
    '        '            dr = cmd.ExecuteReader
    '        '            If dr.Read Then
    '        '                idbank = dr!idbank
    '        '            End If
    '        '            dr.Close()

    '        '            Dim querysimpanhd As String = _
    '        '                "insert into tbACVoucherHd (Nomor,Tanggal,KodeCompany,IdBank,FlagTransaksi,Keterangan1,Keterangan,Total,UserEntry,DateTimeEntry) values " & _
    '        '                "('" & xx!NoBukti & "','" & Format(xx!Tanggal, "yyyyMMdd") & "','" & Strings.Mid(xx!NoBukti, 4, 2) & "'," & _
    '        '                "'" & idbank & "','K','" & xx!Keterangan1 & "','" & xx!Keterangan & "'," & _
    '        '                "'" & xx!KreditKomersial & "', '" & pubUserEntry & "','" & DTOC(Now, "-", True) & "')"
    '        '            cmd = New SqlCommand(querysimpanhd, kon)
    '        '            cmd.ExecuteNonQuery()

    '        '            Dim querysimpanjurnal As String = _
    '        '                "insert into tbACJurnal (KodeCompany,NoBukti,TanggalBukti,Tipe,KodeCabang,KodeAKun,NoUrutAkun,Keterangan,Jumlah,DebetOrKredit,UserEntry,DateTimeEntry) values " & _
    '        '                "('" & Strings.Mid(xx!NoBukti, 4, 2) & "','" & xx!NoBukti & "','" & Format(xx!Tanggal, "yyyyMMdd") & "','1','" & Strings.Mid(xx!NoBukti, 4, 2) & ".01', " & _
    '        '                "'" & xx!KodeAkun & "','1','" & xx!Keterangan & "','" & xx!DebetKomersial & "','K','" & pubUserEntry & "','" & DTOC(Now, "-", True) & "')"
    '        '            cmd = New SqlCommand(querysimpanjurnal, kon)
    '        '            cmd.ExecuteNonQuery()

    '        '        ElseIf Not xx!DebetKomersial = 0 Then
    '        '            Dim nomorurut As Integer = 0
    '        '            Dim querycarinomor As String = "select Max(NoUrut) as NewNoUrut from tbACVoucherDt where Nomor='" & xx!NoBukti & "'"
    '        '            cmd = New SqlCommand(querycarinomor, kon)
    '        '            dr = cmd.ExecuteReader
    '        '            dr.Read()
    '        '            If Not IsDBNull(dr!NewNoUrut) Then
    '        '                nomorurut = dr!NewNoUrut + 1
    '        '            Else
    '        '                nomorurut = 2
    '        '            End If
    '        '            dr.Close()

    '        '            Dim querysimpandt As String = "insert into tbACVoucherDt (Nomor,NoUrut,KodeAkun,Keterangan,Jumlah,Saldo,UserEntry,DateTimeEntry) values " & _
    '        '                "('" & xx!NoBukti & "','" & nomorurut & "','" & xx!KodeAkun & "','" & xx!Keterangan & "','" & xx!DebetKomersial & "','" & xx!SaldoAKhirKomersial & "','" & pubUserEntry & "','" & DTOC(Now, "-", True) & "')"
    '        '            cmd = New SqlCommand(querysimpandt, kon)
    '        '            cmd.ExecuteNonQuery()

    '        '            Dim querysimpanjurnal As String = _
    '        '                "insert into tbACJurnal (KodeCompany,NoBukti,TanggalBukti,Tipe,KodeCabang,KodeAKun,NoUrutAkun,Keterangan,Jumlah,DebetOrKredit,UserEntry,DateTimeEntry) values " & _
    '        '                "('" & Strings.Mid(xx!NoBukti, 4, 2) & "','" & xx!NoBukti & "','" & Format(xx!Tanggal, "yyyyMMdd") & "','1','" & Strings.Mid(xx!NoBukti, 4, 2) & ".00', " & _
    '        '                "'" & xx!KodeAkun & "','" & nomorurut + 1 & "','" & xx!Keterangan & "','" & xx!DebetKomersial & "','D','" & pubUserEntry & "','" & DTOC(Now, "-", True) & "')"
    '        '            cmd = New SqlCommand(querysimpanjurnal, kon)
    '        '            cmd.ExecuteNonQuery()

    '        '        End If

    '        '    ElseIf bmbk = "BM" Then
    '        '        If Not xx!DebetKomersial = 0 Then
    '        '            Dim idbank As String = ""
    '        '            Dim cariidbank As String = "select * from tbackasbank where KodeAkun='" & xx!KodeAkun & "'"
    '        '            cmd = New SqlCommand(cariidbank, kon)
    '        '            dr.Close()
    '        '            dr = cmd.ExecuteReader
    '        '            If dr.Read Then
    '        '                idbank = dr!idbank
    '        '            End If
    '        '            dr.Close()
    '        '            Dim querysimpanhd As String = _
    '        '                "insert into tbACVoucherHd (Nomor,Tanggal,KodeCompany,IdBank,FlagTransaksi,Keterangan1,Keterangan,Total,UserEntry,DateTimeEntry) values " & _
    '        '                "('" & xx!NoBukti & "','" & Format(xx!Tanggal, "yyyyMMdd") & "','" & Strings.Mid(xx!NoBukti, 4, 2) & "'," & _
    '        '                "'" & idbank & "','T','" & xx!Keterangan1 & "','" & xx!Keterangan & "'," & _
    '        '                "'" & xx!DebetKomersial & "', '" & pubUserEntry & "','" & DTOC(Now, "-", True) & "')"
    '        '            cmd = New SqlCommand(querysimpanhd, kon)
    '        '            cmd.ExecuteNonQuery()

    '        '            Dim querysimpanjurnal As String = _
    '        '                "insert into tbACJurnal (KodeCompany,NoBukti,TanggalBukti,Tipe,KodeCabang,KodeAKun,NoUrutAkun,Keterangan,Jumlah,DebetOrKredit,UserEntry,DateTimeEntry) values " & _
    '        '                "('" & Strings.Mid(xx!NoBukti, 4, 2) & "','" & xx!NoBukti & "','" & Format(xx!Tanggal, "yyyyMMdd") & "','1','" & Strings.Mid(xx!NoBukti, 4, 2) & ".01' " & _
    '        '                "'" & xx!KodeAkun & "','1','" & xx!Keterangan & "','" & xx!DebetKomersial & "','D','" & pubUserEntry & "','" & DTOC(Now, "-", True) & "')"
    '        '            cmd = New SqlCommand(querysimpanjurnal, kon)
    '        '            cmd.ExecuteNonQuery()

    '        '        ElseIf Not xx!KreditKomersial = 0 Then
    '        '            Dim nomorurut As Integer = 0
    '        '            Dim querycarinomor As String = "select Max(NoUrut) + 1 as NewNoUrut from tbACVoucherDt where Nomor='" & xx!NoBukti & "'"
    '        '            cmd = New SqlCommand(querycarinomor, kon)
    '        '            dr = cmd.ExecuteReader
    '        '            If dr.HasRows > 0 Then
    '        '                nomorurut = dr(0)
    '        '            Else
    '        '                nomorurut = 1
    '        '            End If
    '        '            dr.Close()

    '        '            Dim querysimpandt As String = "insert into tbACVoucherDt (Nomor,NomorUrut,KodeAkun,Keterangan,Jumlah,Saldo,UserEntry,DateTimeEntry) values " & _
    '        '                "('" & xx!NoBukti & "','" & nomorurut & "','" & xx!KodeAkun & "','" & xx!Keterangan & "','" & xx!KreditKomersial & "','" & xx!SaldoAKhirKomersial & "','" & pubUserEntry & "','" & DTOC(Now, "-", True) & "')"
    '        '            cmd = New SqlCommand(querysimpandt, kon)
    '        '            cmd.ExecuteNonQuery()

    '        '            Dim querysimpanjurnal As String = _
    '        '                "insert into tbACJurnal (KodeCompany,NoBukti,TanggalBukti,Tipe,KodeCabang,KodeAKun,NoUrutAkun,Keterangan,Jumlah,DebetOrKredit,UserEntry,DateTimeEntry) values " & _
    '        '                "('" & Strings.Mid(xx!NoBukti, 4, 2) & "','" & xx!NoBukti & "','" & Format(xx!Tanggal, "yyyyMMdd") & "','1','" & Strings.Mid(xx!NoBukti, 4, 2) & ".01' " & _
    '        '                "'" & xx!KodeAkun & "','" & nomorurut + 1 & "','" & xx!Keterangan & "','" & xx!DebetKomersial & "','K','" & pubUserEntry & "','" & DTOC(Now, "-", True) & "')"
    '        '            cmd = New SqlCommand(querysimpanjurnal, kon)
    '        '            cmd.ExecuteNonQuery()
    '        '        End If
    '        '    Else
    '        '        'buat jpu dan mem
    '        '        If Not xx!DebetKomersial = 0 Then

    '        '        ElseIf Not xx!KreditKomersial = 0 Then

    '        '        End If
    '        '    End If
    '        'Next
    '        dgJurnal.gvMain.LoadingPanelVisible = False
    '        MsgBox("Berhasil")
    '        'End If
    '    End Sub

    '    Private Sub btnFilter_Click_1(sender As Object, e As EventArgs) Handles btnFilter.Click
    '        If cCompany.Text = "" Or tNama.Text = "" Or tBln.Text = "" Or tBln.Text = "0" Or Not IsNumeric(tBln.Text) Then
    '            MsgBox("Lengkapi Filter!", vbCritical + vbOKOnly, "Peringatan")
    '        Else

    '            Dim query As String = "select [Tanggal],[Thn] as Tahun,[Bln] as Bulan,[Nama Legal] as NamaLegal,[Kode Akun] as KodeAKun,[Nama Akun] as NamaAkun," & _
    '                                               "[Alias Akun] as AliasAkun,[No# Bukti] as NoBukti,[Keterangan],[Debet_Internal] as DebetInternal,[Kredit_Internal] as KreditInternal,[Internal]," & _
    '                                               "[Penys# Debet] as PenyesuaianDebet,[Penys# Kredit] as PenyesuaianKredit,[Penys# Komersial] as PenyesuaianKomersial,[Saldo Awal Komersial] as SaldoAwalKomersial,[Debet Komersial] as DebetKomersial," & _
    '                                               "[Kredit Komersial] as KreditKomersial,[Komersial],[Saldo Akhir Komersial] as SaldoAkhirKomersial,[Keterangan1] from [Sheet1$] where [Kode Akun] like '" & cCompany.Text & "%' and Bln='" & tBln.Text & "' and Thn='" & cTahun.Text & "'"

    '            'dgJurnal.gvMain.LoadingPanelVisible = True
    '            'daexcel = New OleDbDataAdapter(query, konexcel)
    '            'dsexcel.Clear()
    '            'daexcel.Fill(dsexcel)
    '            'dgJurnal.DataSource = dsexcel.Tables(0)
    '            dgJurnal.colWidth = {1, 0.5, 0.5, 1.8, 0.8, 1.6, 1.3, 1.5, 1.5, 1, _
    '                                 1, 1, 1, 1, 1.1, 1.4, 1.1, 1.1, 1.1, 1.1, 2}
    '            dgJurnal.colDecimalDigitforNumCol = 0
    '            dgJurnal.ColHeaderHeight = 50
    '            dgJurnal.colFitGrid = False
    '            dgJurnal.colSum = {"Internal", "DebetInternal", "KreditInternal", _
    '                               "PenyesuaianKomersial", "PenyesuaianKredit", "PenyesuaianDebet", _
    '                               "SaldoAwalKomersial", "DebetKomersial", "KreditKomersial", "Komersial", "SaldoAkhirKomersial"}
    '            dgJurnal.colForEntry = {"PenyesuaianDebet", "PenyesuaianKredit"}
    '            dgJurnal.RefreshDataView()
    '            dgJurnal.gvMain.LoadingPanelVisible = False
    '            btnSimpan.Enabled = True
    '        End If
    '    End Sub

    '    Private Sub tBln_EditValueChanged(sender As Object, e As EventArgs) Handles tBln.EditValueChanged
    '        If Not IsNumeric(tBln.Text) Then
    '            tBln.Text = "01"
    '        End If
    '    End Sub

    '    Private Sub dgJurnal_Load(sender As Object, e As EventArgs) Handles dgJurnal.Load

    '    End Sub
End Class