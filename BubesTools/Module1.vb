Imports System.Data.SqlClient
Module Module1
    Public cmd As SqlCommand
    Public kon As SqlConnection
    Public rd As SqlDataReader
    Public da As SqlDataAdapter
    Public ds As DataSet
    Public dt As DataTable

    Public dr As SqlDataReader

    Sub koneksi(Optional connstr As String = Nothing)
        If connstr Is Nothing Then connstr = meCore.PubConnStr
        'kon = New SqlConnection("data source=FANI; initial catalog=TM601KEDIRI; uid=sa; password=gogogo")
        kon = New SqlConnection(connstr)
        If kon.State = ConnectionState.Closed Then
            kon.Open()
        End If
    End Sub

    Public Function koneksi(ByVal ip As String, ByVal namadb As String, ByVal username As String, ByVal pass As String) As String
        Dim stringcon As String = "data source=" & ip & "; initial catalog=" & namadb & "; uid=" & username & "; password=" & pass & ""

        kon = New SqlConnection(stringcon)
        Dim pesan As String = "Tidak Terkoneksi"
        Try
            If kon.State = ConnectionState.Closed Then
                kon.Open()
                pesan = "Terkoneksi " & ip
            End If
            Return pesan
        Catch ex As Exception
            MsgBox(ex.Message)
            Return "Tidak Terkoneksi"
        End Try
    End Function
End Module
