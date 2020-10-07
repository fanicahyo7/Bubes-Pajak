
Imports System.Data.SqlClient

Public Class XtraForm1
    Dim dicA As New Dictionary(Of Integer, classFani)

    Private Sub XtraForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim bbUE As New classFani("Data Source=10.10.2.6\bukbes;Initial Catalog=BukbesAccUE;Persist Security Info=True;User ID=sa;Password=pancetgogogo;Connection Timeout=0")
        Dim bbUM As New classFani("Data Source=10.10.2.6\bukbes;Initial Catalog=BukbesAccUM;Persist Security Info=True;User ID=sa;Password=pancetgogogo;Connection Timeout=0")

        dicA.Add(0, bbUE)
        dicA.Add(1, bbUM)
        dicA.Add(2, bbUE)
        dicA.Add(3, bbUM)
        dicA.Add(4, bbUE)
        dicA.Add(5, bbUM)
        dicA.Add(6, bbUE)
        dicA.Add(7, bbUM)




        Dim data As String = "Query"
        da = New SqlDataAdapter(data, dicA(1).kon)
        Dim ds As New DataSet
        da.Fill(ds)



    End Sub
End Class