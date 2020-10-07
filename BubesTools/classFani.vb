Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports meCore

Public Class classFani
    Public kon As SqlConnection
    Public da As SqlDataAdapter
    Public cmd As SqlCommand
    Public dr As SqlDataReader

    Dim ConnStr As String

    Public Sub New(pConnStr As String)
        ConnStr = pConnStr
    End Sub

    Sub koneksi()
        'kon = New SqlConnection("data source=FANI; initial catalog=TM601KEDIRI; uid=sa; password=gogogo")
        kon = New SqlConnection(ConnStr)
        If kon.State = ConnectionState.Closed Then
            kon.Open()
        End If
    End Sub
End Class
