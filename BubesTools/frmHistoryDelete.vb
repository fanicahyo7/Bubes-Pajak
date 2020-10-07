Imports meCore
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Repository.RepositoryItemComboBox
Imports DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid

Public Class frmHistoryDelete
    Public kodecaompany As String
    Public namacompany As String
    Dim pConnstr As String = ""
    Dim tanggal As Date

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ConnStr As String, tanggal1 As Date)
        InitializeComponent()
        Me.pConnstr = ConnStr
        Me.tanggal = tanggal1
    End Sub

    Private Sub frmHistoryDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi(pConnstr)
        cCompany.FirstInit(pConnstr, "Select KodeCompany,Nama from tbGNCompany", {tNama}, , , , , , {0.5, 1})

        'cThn.Items.Clear()
        'For i = DateTime.Now.Year - 5 To DateTime.Now.Year
        '    cThn.Items.Add(i)
        'Next

        dBulan.Properties.DisplayFormat.FormatString = "yyyy MMMM"
        dBulan.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        dBulan.Properties.EditMask = "yyyy MMMM"
        dBulan.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView
        dBulan.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView

        dBulan.EditValue = tanggal

        cCompany.Text = kodecaompany
        tNama.Text = namacompany
        'cBln.Text = bln
        'cThn.Text = thn

        SetTextReadOnly({cCompany, tNama, btnAmbilData})

        If cCompany.Text = "" Then
            MsgBox("Data Filter Belum Lengkap!", vbCritical + vbOKOnly, "Peringatan")
        Else
            isigrid()
        End If
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
                "select cast(0 as bit) as Pilih,a.TanggalBukti,CONVERT(varchar(10),month(a.TanggalBukti)) as Bulan,CONVERT(varchar(10),year(a.TanggalBukti)) as Tahun,b.Nama as NamaLegal," & _
                "a.KodeAkun," & _
                "a.NamaAkunPajak," & _
                "a.NoBukti, a.Keterangan, " & _
                "DebetKomersial = case when a.DebetOrKredit = 'D' then a.Jumlah else cast(0 as numeric(18)) end," & _
                "KreditKomersial = case when a.DebetOrKredit = 'K' then a.Jumlah else cast(0 as numeric(18)) end," & _
                "Komersial = case when a.DebetOrKredit = 'K' then a.Jumlah * -1 " & _
                "when a.DebetOrKredit = 'D' then a.Jumlah end," & _
                "'' as Keterangan1, " & _
                "ROW_NUMBER() over(Partition by a.kodeakun order by a.tanggalbukti) as urut,NoUrutAkun " & _
                "from tbACJurnalEdit a " & _
                "left join tbGNCompany b on b.KodeCompany = a.KodeCompany " & _
                "left join tbACKodeAkun c on a.KodeAkun = c.KodeAkun " & _
                "where substring(a.KodeAkun,1,2)='" & cCompany.Text & "' and month(a.TanggalBukti)='" & Format(dBulan.EditValue, "MM") & "' and year(a.TanggalBukti)='" & Format(dBulan.EditValue, "yyyy") & "' and FlagDelete='1' and (FlagPostingJurnalOri='0' or FlagPostingJurnalOri is null)" & _
                "order by KodeAkun,TanggalBukti"

        dgJurnal.gvMain.LoadingPanelVisible = True

        da = New SqlDataAdapter(data, kon)
        Dim ds As New DataSet
        da.Fill(ds)

        Dim dn As New cMeDB(pConnstr)
        dn.FillMe(ds.Tables(0))
        dgJurnal.DataSource = dn
        dgJurnal.gcMain.DataSource = ds.Tables(0)
        dgJurnal.colWidth = {0.5, 0.9, 0.4, 0.5, 1.5, 1.5, 1.3, 1.8, _
                            1, 1, 1, 1, 1.2}
        dgJurnal.ColHeaderHeight = 50
        dgJurnal.colFitGrid = False
        dgJurnal.colSum = {"DebetKomersial", "KreditKomersial", "Komersial", "SaldoAwalKomersial", "SaldoAkhirKomersial"}
        dgJurnal.colVisibleFalse = {"urut", "NoUrutAkun", "Keterangan1"}
        dgJurnal.colForEntry = {"Pilih"}
        dgJurnal.RefreshDataView()
        dgJurnal.gvMain.LoadingPanelVisible = False
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        Dim drow() As DataRow
        drow = dgJurnal.DataSource.Select("Pilih = True")

        If drow.Length <= 0 Then
            MsgBox("Tidak Ada Data yang Akan DiRestore!", vbCritical + vbOKOnly, "Peringatan")
        Else
            Dim konfirmasi As String = MsgBox("Apakah Anda Yakin Merestore Jurnal Dengan No.Bukti " & dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "NoBukti") & " Dan Kode Akun " & dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "KodeAkun") & "?", vbQuestion + vbYesNo, "Konfirmasi")
            If konfirmasi = vbYes Then
                For i = 0 To drow.Length - 1
                    'Dim query As String = "update tbACJurnalEdit set FlagDelete = '0' where NoBukti='" & drow(i).Item("NoBukti") & "' and KodeAkun='" & drow(i).Item("KodeAkun") & "' and NoUrutAkun='" & drow(i).Item("NoUrutAkun") & "'"
                    Dim query As String = "delete from tbACJurnalEdit where NoBukti='" & drow(i).Item("NoBukti") & "' and KodeAkun='" & drow(i).Item("KodeAkun") & "' and NoUrutAkun='" & drow(i).Item("NoUrutAkun") & "'"
                    cmd = New SqlCommand(query, kon)
                    cmd.ExecuteNonQuery()

                    Dim tbl As String = ""
                    Dim pluswhere As String = ""

                    Dim kondisi As String = ""
                    If Strings.Left(dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "NoBukti"), 3) = "MEM" Then
                        kondisi = "MEMJPU"
                    ElseIf Strings.Left(dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "NoBukti"), 3) = "JPU" Then
                        kondisi = "MEMJPU"
                    End If
                    If Not kondisi = "MEMJPU" Then
                        If dgJurnal.GetRowCellValue(dgJurnal.FocusedRowHandle, "NoUrutAkun") = "1" Then
                            tbl = "tbACVoucherHdEdit"
                            Dim cariidbank As String = "select IdBank from tbACKasBank where KodeAkun='" & drow(i).Item("KodeAkun") & "'"
                            cmd = New SqlCommand(cariidbank, kon)
                            dr = cmd.ExecuteReader
                            dr.Read()
                            pluswhere = "IdBank='" & dr!IdBank & "'"
                            dr.Close()
                        Else
                            tbl = "tbACVoucherDtEdit"
                            pluswhere = "KodeAkun='" & drow(i).Item("KodeAkun") & "' and NoUrut='" & drow(i).Item("NoUrutAkun") - 1 & "'"
                        End If
                        Dim queryhapushddt As String = _
                            "delete from " & tbl & " " & _
                            "where Nomor='" & drow(i).Item("NoBukti") & "' and " & pluswhere & ""
                        cmd = New SqlCommand(queryhapushddt, kon)
                        cmd.ExecuteNonQuery()
                    End If
                Next
                MsgBox("Restore Data Berhasil", vbInformation + vbOKOnly, "Informasi")
                isigrid()
            End If
        End If
    End Sub
End Class