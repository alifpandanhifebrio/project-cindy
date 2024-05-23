Imports System.Data.OleDb
Public Class Printpenyimpanan
    Sub tampilkan_print_penyimpanan()
        Call koneksi()
        cmd = New OleDbCommand("select distinct Tanggal_Penyimpanan from tb_Penyimpanan ", cn)
        dr = cmd.ExecuteReader

        Do While dr.Read
        Loop
    End Sub
    Private Sub bttampilkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttampilkan.Click
        Lappenyimpanan.Show()
        Lappenyimpanan.CrystalReportViewer1.SelectionFormula = "{tb_penyimpanan.Tanggal_Penyimpanan} >= #" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "# and {tb_penyimpanan.Tanggal_Penyimpanan} <= #" & Format(DateTimePicker2.Value, "dd/MM/yyyy") & "#"
        Lappenyimpanan.CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub printpenyimpanan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampilkan_print_penyimpanan()
    End Sub

End Class