Imports System.Data.OleDb
Public Class Printpenyimpananpepoli
    Sub tampilkan_print_penyimpananperpoli()
        Call koneksi()
        cmd = New OleDbCommand("select distinct Nama_Poliklinik from tb_penyimpanan", cn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            cbnamapoli.Items.Add(dr.Item(0))
        Loop
    End Sub
    Private Sub bttampilkan_Click(sender As Object, e As EventArgs) Handles bttampilkan.Click
        If cbnamapoli.Text = "" Then
            MsgBox("Pilih Nama Poliklinik")
        Else
            Laporanpenyimpananperpoli.Show()
            Laporanpenyimpananperpoli.CrystalReportViewer1.SelectionFormula = "({tb_Penyimpanan.Nama_Poliklinik})='" & cbnamapoli.Text & "' and {tb_Penyimpanan.Tanggal_Penyimpanan} >= #" & Format(DateTimePicker1.Value, "MM/dd/yyyy") & "# and {tb_penyimpanan.Tanggal_Penyimpanan} <= #" & Format(DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            Laporanpenyimpananperpoli.CrystalReportViewer1.RefreshReport()
        End If
    End Sub
    Private Sub printpenyimpananperpoli_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampilkan_print_penyimpananperpoli()
    End Sub

End Class