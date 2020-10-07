Imports meCore
Imports System.Data.SqlClient
Public Class frmMstKodeAkun
    Dim isNew As Boolean = True
    Dim pKode As String = "asdjaksdjqi01298310owueqiowueakdh"
    Private Sub cStatusJurnal_CheckedChanged(sender As Object, e As EventArgs) Handles cStatusJurnal.CheckedChanged
        tKodeCabang.Text = ""
        If cStatusJurnal.Checked = False Then
            LayoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        Else
            LayoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        End If
    End Sub

    Private Sub frmMstKodeAkun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sLevelAkun.Properties.MaxValue = 9
        sLevelAkun.Properties.MinValue = 0
        koneksi(konekdbumue)
        'Dim db As New cMeDB(konekdbumue)
        Dim query As String = _
            "select a.KodeAkun,a.Keterangan,a.KodeAkunInduk,a.LevelAkun,a.DebetOrKredit as [D / K],a.StatusJurnal,a.KodeCabang,b.KodeAkunLama from tbACKodeAkun a " & _
            "left join tbACKodeAkunEdit b on a.KodeAkun = b.KodeAkunLama " & _
            "where a.KodeAkun like '" & kodecompany & ".%' and a.IdKategori='" & idkategori & "' "
        'db.FillMe(query)
        'cKodeAkunInduk.Properties.DataSource = db
        'cKodeAkunInduk.Properties.DisplayMember = "KodeAkun"
        'cKodeAkunInduk.Properties.ValueMember = "KodeAkun"
        cKodeAkunInduk.FirstInit(konekdbumue, query, , , , , , , {1, 1, 1, 0.8, 0.5, 1, 1, 1}, {"KodeAkunLama", "KodeCabang"})

        If Me.Tag <> "" Then pKode = Me.Tag

        loaddetail()
    End Sub


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Dim konekdbumue, kodecompany, idkategori, kodecabang As String
    Public Sub New(konekdbumue As String, kodecompany As String, idkategori As String, kodecabang As String)

        ' This call is required by the designer.
        InitializeComponent()
        Me.konekdbumue = konekdbumue
        Me.kodecompany = kodecompany
        Me.idkategori = idkategori
        Me.kodecabang = kodecabang
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Sub loaddetail()
        Dim dbdb As New cMeDB(konekdbumue)
        Dim pQuery As String = _
            "Select KodeAkun, KodeCompany, IdKategori, Keterangan,LevelAkun,DebetOrKredit,StatusJurnal,KodeAkunInduk,KodeCabang from tbACKodeAkun " & _
            "where KodeAkun = '" & pKode & "'"
        dbdb.FillMe(pQuery, True)

        If dbdb.Rows.Count > 0 Then
            isNew = False
            FillFormFromDataRow(Me, dbdb.Rows(0))
            If dbdb.Rows(0)!StatusJurnal = True Then
                cStatusJurnal.Checked = True
                LayoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Else
                cStatusJurnal.Checked = False
                LayoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            End If
            If dbdb.Rows(0)!DebetOrKredit = "D" Then
                rDebetOrKredit.SelectedIndex = 0
            ElseIf dbdb.Rows(0)!DebetOrKredit = "K" Then
                rDebetOrKredit.SelectedIndex = 1
            End If
            SetTextReadOnly({tKodeAkun})
        Else
            isNew = True
            cStatusJurnal.Checked = False
            tKodeAkun.Text = kodecompany & "."
            cStatusJurnal.Checked = False
            LayoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If
    End Sub

    Private Sub tKodeAkun_EditValueChanged(sender As Object, e As EventArgs) Handles tKodeAkun.EditValueChanged
        If Not Strings.Left(tKodeAkun.Text, 2) = kodecompany Then
            tKodeAkun.Text = kodecompany & "."
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If CheckBeforeSave({tKodeAkun, tKeterangan}) = True Then
            Try
                Dim cek As Boolean
                If cStatusJurnal.Checked = False Then
                    cek = False
                Else
                    cek = True
                End If
                Dim dork As String
                If rDebetOrKredit.SelectedIndex = 0 Then
                    dork = "D"
                Else
                    dork = "K"
                End If

                Dim querytabeledit As String = ""
                Dim querytabelori As String = ""
                If isNew = True Then
                    querytabeledit = _
                        "insert into tbACKodeAkunEdit (" & _
                        "KodeAkun,Keterangan,KodeAkunInduk,LevelAkun,DebetOrKredit," & _
                        "StatusJurnal,KodeCompany,IdKategori,KodeCabang,KodeAkunLama," & _
                        "KeteranganLama,IdKategoriLama,LevelAkunLama,DebetOrKreditLama,StatusJurnalLama," & _
                        "KodeAkunIndukLama,KodeCabangLama,KodeCompanyLama,FlagDelete) values (" & _
                        "'" & tKodeAkun.Text & "','" & tKeterangan.Text & "','" & cKodeAkunInduk.Text & "','" & sLevelAkun.EditValue & "','" & dork & "'," & _
                        "'" & cek & "','" & kodecompany & "','" & idkategori & "','" & kodecabang & "','" & tKodeAkun.Text & "'," & _
                        "'" & tKeterangan.Text & "','" & idkategori & "','" & sLevelAkun.EditValue & "','" & dork & "','" & cek & "'," & _
                        "'" & cKodeAkunInduk.Text & "','" & kodecabang & "','" & kodecompany & "','0')"

                    querytabelori = _
                        "insert into tbACKodeAkun (" & _
                        "KodeAkun,Keterangan,KodeAkunInduk,LevelAkun,DebetOrKredit," & _
                        "StatusJurnal,KodeCompany,IdKategori,KodeCabang) values (" & _
                        "'" & tKodeAkun.Text & "','" & tKeterangan.Text & "','" & cKodeAkunInduk.Text & "','" & sLevelAkun.EditValue & "','" & dork & "'," & _
                        "'" & cek & "','" & kodecompany & "','" & idkategori & "','" & kodecabang & "')"
                Else
                    Dim cari As String = _
                    "select * from tbACKodeAkunEdit where KodeAkunLama='" & tKodeAkun.Text & "'"
                    cmd = New SqlCommand(cari, kon)
                    rd = cmd.ExecuteReader
                    rd.Read()
                    If rd.HasRows = False Then
                        rd.Close()
                        Dim cari2 As String = _
                            "select * from tbACKodeAkun where KodeAkun='" & tKodeAkun.Text & "'"
                        cmd = New SqlCommand(cari2, kon)
                        rd = cmd.ExecuteReader
                        rd.Read()

                        querytabeledit = _
                            "insert into tbACKodeAkunEdit (" & _
                            "KodeAkun,Keterangan,KodeAkunInduk,LevelAkun,DebetOrKredit," & _
                            "StatusJurnal,KodeCompany,IdKategori,KodeCabang,KodeAkunLama," & _
                            "KeteranganLama,IdKategoriLama,LevelAkunLama,DebetOrKreditLama,StatusJurnalLama," & _
                            "KodeAkunIndukLama,KodeCabangLama,KodeCompanyLama,FlagDelete) values (" & _
                            "'" & tKodeAkun.Text & "','" & tKeterangan.Text & "','" & cKodeAkunInduk.Text & "','" & sLevelAkun.EditValue & "','" & dork & "'," & _
                            "'" & cek & "','" & kodecompany & "','" & idkategori & "','" & kodecabang & "','" & rd!KodeAkun & "'," & _
                            "'" & rd!Keterangan & "','" & rd!IdKategori & "','" & rd!LevelAkun & "','" & rd!DebetOrKredit & "','" & rd!StatusJurnal & "'," & _
                            "'" & rd!KodeAkunInduk & "','" & rd!KodeCabang & "','" & rd!KodeCompany & "','0')"

                        querytabelori = _
                            "update tbACKodeAkun set " & _
                            "KodeCompany='" & kodecompany & "',IdKategori='" & idkategori & "',Keterangan='" & tKeterangan.Text & "'," & _
                            "LevelAkun='" & sLevelAkun.EditValue & "',DebetOrKredit='" & dork & "',StatusJurnal='" & cek & "'," & _
                            "KodeAkunInduk='" & cKodeAkunInduk.Text & "',KodeCabang='" & tKodeCabang.Text & "' " & _
                            "where KodeAkun='" & tKodeAkun.Text & "'"

                        'querytabelori = _
                        '    "insert into tbACKodeAkun (KodeAkun,KodeCompany,IdKategori,Keterangan,LevelAkun,DebetOrKredit,StatusJurnal,KodeAkunInduk,KodeCabang) values ( " & _
                        '    "'" & tKodeAkun.Text & "','" & kodecompany & "','" & idkategori & "',Keterangan='" & tKeterangan.Text & "','" & sLevelAkun.EditValue & "','" & dork & "','" & cek & "','" & cKodeAkunInduk.Text & "','" & tKodeCabang.Text & "')"
                    Else
                        querytabeledit = _
                            "update tbACKodeAkunEdit set " & _
                            "Keterangan='" & tKeterangan.Text & "',KodeAkunInduk='" & cKodeAkunInduk.Text & "',LevelAkun='" & sLevelAkun.EditValue & "'," & _
                            "DebetOrKredit='" & dork & "', StatusJurnal='" & cek & "',KodeCompany='" & kodecompany & "'," & _
                            "IdKategori='" & idkategori & "',KodeCabang='" & tKodeCabang.Text & "'," & _
                            "KodeAkunLama='" & rd!KodeAkunLama & "',KeteranganLama='" & rd!KeteranganLama & "',IdKategoriLama='" & rd!IdKategoriLama & "'," & _
                            "LevelAkunLama='" & rd!LevelAkunLama & "',DebetOrKreditLama='" & rd!DebetOrKredit & "',StatusJurnalLama='" & rd!StatusJurnal & "'," & _
                            "KodeAkunIndukLama='" & rd!KodeAkunInduk & "',KodeCabangLama='" & rd!KodeCabang & "',KodeCompanyLama='" & rd!KodeCompany & "' " & _
                            "where KodeAkun='" & tKodeAkun.Text & "' and KodeAkunLama='" & rd!KodeAkun & "'"

                        querytabelori = _
                            "update tbACKodeAkun set " & _
                            "KodeCompany='" & kodecompany & "',IdKategori='" & idkategori & "',Keterangan='" & tKeterangan.Text & "'," & _
                            "LevelAkun='" & sLevelAkun.EditValue & "',DebetOrKredit='" & dork & "',StatusJurnal='" & cek & "'," & _
                            "KodeAkunInduk='" & cKodeAkunInduk.Text & "',KodeCabang='" & tKodeCabang.Text & "' " & _
                            "where KodeAkun='" & tKodeAkun.Text & "'"
                    End If
                    rd.Close()
                End If
                cmd = New SqlCommand(querytabelori, kon)
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand(querytabeledit, kon)
                cmd.ExecuteNonQuery()

                Pesan({IIf(isNew = True, "Simpan", "Update") & " Data BERHASIL"})
                Me.Close()
            Catch ex As Exception
                Pesan({"GAGAL SIMPAN DATA", "", "Err : " & ex.Message.ToString})
            End Try
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Close()
    End Sub
End Class