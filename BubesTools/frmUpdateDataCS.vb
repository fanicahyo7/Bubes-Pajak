Imports System.IO
Imports System.Data.SqlClient
Imports meCore

Public Class frmUpdateDataCS
    Dim lokasi As String = My.Application.Info.DirectoryPath & "\SettingUnit.txt"
    Dim isiprogres As Decimal = 0
    Private Sub frmUpdateDataCS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetTextReadOnly({tNamaDB})
        If File.Exists(lokasi) = True Then
            Dim BacaFile As New StreamReader(New FileStream(lokasi, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            Do While BacaFile.Peek <> -1
                Dim baris As String = BacaFile.ReadLine
                Dim dataKolom() As String = baris.Split(CChar(","))
                cUnit.Properties.Items.Add(dataKolom(0))
            Loop
            BacaFile.Close()
        End If
    End Sub

    Private Sub cUnit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cUnit.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub cUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cUnit.SelectedIndexChanged
        Dim ip As String = ""
        Dim username As String = ""
        Dim password As String = ""
        Dim dbname As String = ""
        Dim ada As Boolean = False

        If File.Exists(lokasi) = True Then
            Dim BacaFile As New StreamReader(New FileStream(lokasi, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            Do While BacaFile.Peek <> -1 And ada = False
                Dim baris As String = BacaFile.ReadLine
                Dim dataKolom() As String = baris.Split(CChar(","))
                If dataKolom(0) = cUnit.Text Then
                    ip = dataKolom(1)
                    username = dataKolom(2)
                    password = dataKolom(3)
                    dbname = dataKolom(4)
                    ada = True
                Else
                    ada = False
                End If
            Loop
            BacaFile.Close()
        End If

        If ada = True Then
            lblStatus.Text = koneksi(ip, dbname, username, password)
            tNamaDB.Text = dbname
        End If
    End Sub

    Private Sub btnUpdateData_Click(sender As Object, e As EventArgs) Handles btnUpdateData.Click
        listProgress.Items.Clear()
        Dim datatabel As New DataTable
        da = New SqlDataAdapter("select a.*,b.Faktur as Faktur2,b.Kode as Kode2,FORMAT (b.Tanggal, 'MM-yyyy') as Bulan from trCSDetailPajak a " & _
                                    "inner join trCSDetail b on a.Faktur = b.Faktur and a.KodeOri = b.Kode order by b.Tanggal asc", kon)
        da.Fill(datatabel)
        isiprogres = 0
        Dim proses As String = ""
        For a As Integer = 0 To datatabel.Rows.Count - 1
            Dim query As String = "update trCSDetail set Kode='" & datatabel.Rows(a)!Kode & "',Kode1='" & datatabel.Rows(a)!Kode & "' " & _
                "where Faktur='" & datatabel.Rows(a)!Faktur & "' and Kode='" & datatabel.Rows(a)!KodeOri & "'"
            cmd = New SqlCommand(query, kon)
            If proses = "" Then
                proses = datatabel.Rows(a)!Bulan
                listProgress.Items.Add("Sedang Update Periode " & proses)
            ElseIf Not proses = datatabel.Rows(a)!Bulan Then
                listProgress.Items.Add("Update Periode " & proses & " Sudah Selesai")
                proses = datatabel.Rows(a)!Bulan
                listProgress.Items.Add("Sedang Update Periode " & proses)
            End If
            cmd.ExecuteNonQuery()
            If a = datatabel.Rows.Count - 1 Then
                listProgress.Items.Add("Update Periode " & proses & " Sudah Selesai")
            End If

            Dim tambah As Decimal = 1 / CDec(datatabel.Rows.Count - 1) * 100
            isiprogres += tambah
            If Not isiprogres > 100 Then
                ProgressBar1.Value = isiprogres
                Label1.Text = Math.Round((ProgressBar1.Value / 100) * 100, 2) & "%"
            End If
        Next
        ProgressBar1.Value = 100
        Label1.Text = Math.Round((ProgressBar1.Value / 100) * 100, 2) & "%"
        MsgBox("Update Data Selesai", vbInformation + vbOKOnly, "Peringatan")
        ProgressBar1.Value = 0
        Label1.Text = Math.Round((ProgressBar1.Value / 100) * 100, 2) & "%"
    End Sub
End Class