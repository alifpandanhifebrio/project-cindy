Imports System.Data.OleDb
Public Class FormPenyimpanan

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbkodepoli.Items.Add("A")
        cbkodepoli.Items.Add("B")
        cbkodepoli.Items.Add("C")
        Call koneksi()
        Call lihat_data_penyimpanan()
    End Sub

    Sub lihat_data_penyimpanan()
        cmd = New OleDbCommand("select*from tb_penyimpanan", cn)
        cmd.ExecuteNonQuery()
        da = New OleDbDataAdapter(cmd)
        tb = New DataTable
        da.Fill(tb)
        DGVpenyimpanan.DataSource = tb
        DGVpenyimpanan.Refresh()
    End Sub
    Sub bersihkan()
        txtnorm.Clear()
        txtnamapasien.Clear()
        dtptanggalkunjungan.Value = Now
        cbcarabayar.Text = "--pilih--"
        cbkodepoli.Text = "--pilih--"
        txtnamapoli.Clear()
        cbdokter.Text = "--pilih--"
        txtdiagnosa.Clear()
        cbrak.Text = "--pilih--"
        dtptanggal.Value = Now
        txtnippetugas.Clear()
        txtnamapetugas.Clear()
        txtketerangan.Clear()
        cbstatusberkas.Text = "--pilih--"
 End Sub
    Private Sub btbaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbaru.Click
        Call bersihkan()
        txtnorm.Focus()
        cmd = New OleDbCommand("select max(no_rm) from tb_penyimpanan", cn)
        dr = cmd.ExecuteReader
        dr.Read()
        If IsDBNull(dr.Item(0)) = True Then
            txtnorm.Text = 1
            dr.Close()
        Else
            txtnorm.Text = dr.Item(0) + 1
            dr.Close()
        End If
        txtnorm.ReadOnly = False
        cbkodepoli.Focus()
        btsimpan.Enabled = True
    End Sub
    Private Sub FormPenyimpanan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        lihat_data_penyimpanan()
        cmd = New OleDbCommand("select no_rm from tb_pasien", cn)
        dr = cmd.ExecuteReader()
        cbkodepoli.Items.Clear()
        Do While dr.Read
            cbkodepoli.Items.Add(dr.Item(0))
        Loop
        dr.Close()
    End Sub
    Private Sub btsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsimpan.Click
 cmd = New OleDbCommand("insert into tb_penyimpanan (Nama_Pasien,Tanggal_Kunjungan,Cara_Bayar,Kode_Poliklinik,Nama_Poliklinik,Dokter,Diagnosa, Rak_Penyimpanan, Tanggal_Penyimpanan, NIP_Petugas, Nama_Petugas, Keterangan, Status_Berkas,No_RM) values(@namapasien,@tanggalkunjungan,@carabayar,@kodepoliklinik,@namapoliklinik,@dokter,@diagnosa,@rakpenyimpanan,@tanggalpenyimpanan,@nippetugas,@namapetugas,@keterangan,@statusberkas,@norm)", cn)
        cmd.Parameters.AddWithValue("@namapasien", txtnamapasien.Text)
        cmd.Parameters.AddWithValue("@tanggalkunjungan",
       Format(dtptanggalkunjungan.Value, "yyyy-MM-dd"))
        cmd.Parameters.AddWithValue("@carabayar", cbcarabayar.Text)
        cmd.Parameters.AddWithValue("@kodepoliklinik", cbkodepoli.Text)
        cmd.Parameters.AddWithValue("@namapoliklinik", txtnamapoli.Text)
        cmd.Parameters.AddWithValue("@dokter", cbdokter.Text)
        cmd.Parameters.AddWithValue("@diagnosa", txtdiagnosa.Text)
        cmd.Parameters.AddWithValue("@rakpenyimpanan", cbrak.Text)
        cmd.Parameters.AddWithValue("@tanggalpenyimpanan", Format(dtptanggal.Value,"yyyy-MM-dd"))
        cmd.Parameters.AddWithValue("@nippetugas", txtnippetugas.Text)
        cmd.Parameters.AddWithValue("@namapetugas", txtnamapetugas.Text)
        cmd.Parameters.AddWithValue("@keterangan", txtketerangan.Text)
        cmd.Parameters.AddWithValue("@statusberkas", cbstatusberkas.Text)
        cmd.Parameters.AddWithValue("@norm", txtnorm.Text)
        cmd.ExecuteNonQuery()
        MsgBox("data tersimpan", MsgBoxStyle.Information, "informasi")
        Call bersihkan()
        Call lihat_data_penyimpanan()
        txtnorm.Focus()
    End Sub
    Private Sub btedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btedit.Click
 cmd = New OleDbCommand("update tb_penyimpanan set No_RM=@norm,Nama_Pasien=@namapasien, Tanggal_Kunjungan=@tanggalkunjungan, Cara_Bayar=@carabayar, Kode_Poliklinik=@kodepoliklinik, Nama_Poliklinik=@namapoliklinik, Dokter=@dokter, Diagnosa=@diagnosa, Rak_Penyimpanan=@rakpenyimpanan, Tanggal_Penyimpanan=@tanggalpenyimpanan, NIP_Petugas=@nippetugas, Nama_Petugas=@namapetugas, Keterangan=@keterangan, Status_Berkas=@statusberkas WHERE No_RM=@norm", cn)
        cmd.Parameters.AddWithValue("@norm", txtnorm.Text)
        cmd.Parameters.AddWithValue("@namapasien", txtnamapasien.Text)
        cmd.Parameters.AddWithValue("@tanggalkunjungan",
       Format(dtptanggalkunjungan.Value, "yyyy-MM-dd"))
        cmd.Parameters.AddWithValue("@carabayar", cbcarabayar.Text)
        cmd.Parameters.AddWithValue("@kodepoliklinik", cbkodepoli.Text)
        cmd.Parameters.AddWithValue("@namapoliklinik", txtnamapoli.Text)
        cmd.Parameters.AddWithValue("@dokter", cbdokter.Text)
        cmd.Parameters.AddWithValue("@diagnosa", txtdiagnosa.Text)
        cmd.Parameters.AddWithValue("@rakpenyimpanan", cbrak.Text)
        cmd.Parameters.AddWithValue("@tanggalpenyimpanan", Format(dtptanggal.Value,
       "yyyy-MM-dd"))
        cmd.Parameters.AddWithValue("@nippetugas", txtnippetugas.Text)
        cmd.Parameters.AddWithValue("@namapetugas", txtnamapetugas.Text)
        cmd.Parameters.AddWithValue("@keterangan", txtketerangan.Text)
        cmd.Parameters.AddWithValue("@statusberkas", cbstatusberkas.Text)
        cmd.ExecuteNonQuery()
        MsgBox("data berhasil diubah...!")
        Call bersihkan()
        Call lihat_data_penyimpanan()
        txtnorm.Focus()
        btsimpan.Show()
    End Sub
    Private Sub txtcaridata_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcaridata.TextChanged
        If txtcaridata.Text = "" Then
            Call lihat_data_penyimpanan()
        Else
 cmd = New OleDbCommand("select * from tb_penyimpanan where no_rm like @norm or nama_pasien like @namapasien", cn)
            cmd.Parameters.AddWithValue("@norm", "%" & txtcaridata.Text & "%")
            cmd.Parameters.AddWithValue("@namapasien", "%" & txtcaridata.Text & "%")
            cmd.ExecuteNonQuery()
            da = New OleDbDataAdapter(cmd)
            tb = New DataTable
            da.Fill(tb)
            DGVPenyimpanan.DataSource = tb
            DGVPenyimpanan.Refresh()
        End If
    End Sub
    Private Sub bthapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bthapus.Click
        Dim hapus As String
        hapus = InputBox("masukan No RM yang akan dihapus:", "Hapus")
        cmd = New OleDbCommand("DELETE FROM tb_penyimpanan WHERE no_rm=@norm", cn)
        cmd.Parameters.AddWithValue("@no_rm", hapus)
        cmd.ExecuteNonQuery()
        Call bersihkan()
        Call lihat_data_penyimpanan()
        MsgBox("data berhasil dihapus..!")
        txtnamapasien.Focus()
    End Sub
    Private Sub cbkodepoli_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbkodepoli.SelectedIndexChanged
        Select Case cbkodepoli.Text
            Case "A"
                txtnamapoli.Text = "UMUM"
            Case "B"
                txtnamapoli.Text = "ANAK"
            Case "C"
                txtnamapoli.Text = "KIA"
        End Select
    End Sub
    Private Sub DGVpenyimpanan_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVPenyimpanan.DoubleClick
        txtnorm.Text = DGVPenyimpanan.CurrentRow.Cells(0).Value
        txtnamapasien.Text = DGVPenyimpanan.CurrentRow.Cells(1).Value
        dtptanggalkunjungan.Text = DGVPenyimpanan.CurrentRow.Cells(2).Value
        cbcarabayar.Text = DGVPenyimpanan.CurrentRow.Cells(3).Value
        cbkodepoli.Text = DGVPenyimpanan.CurrentRow.Cells(4).Value
        txtnamapoli.Text = DGVPenyimpanan.CurrentRow.Cells(5).Value
        cbrak.Text = DGVPenyimpanan.CurrentRow.Cells(8).Value
        dtptanggal.Text = DGVPenyimpanan.CurrentRow.Cells(9).Value
        txtnippetugas.Text = DGVPenyimpanan.CurrentRow.Cells(10).Value
        txtnamapetugas.Text = DGVPenyimpanan.CurrentRow.Cells(11).Value
        txtketerangan.Text = DGVPenyimpanan.CurrentRow.Cells(12).Value
        cbstatusberkas.Text = DGVPenyimpanan.CurrentRow.Cells(13).Value
        txtnorm.ReadOnly = True
        btsimpan.Enabled = False
    End Sub
    Private Sub btkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btkeluar.Click
        Me.Close()
        MsgBox("Anda Akan Keluar?")
    End Sub
    Private Sub btbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbatal.Click
        Call bersihkan()
    End Sub
    Private Sub txtnorm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnorm.TextChanged
        cmd = New OleDbCommand("Select Nama_Pasien, Tanggal_Kunjungan, Cara_Bayar, Kode_Poliklinik, Nama_Poliklinik, Dokter, Diagnosa from tb_pasien where No_RM=@No_RM", cn)
        cmd.Parameters.AddWithValue("@No_RM", txtnorm.Text)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows = True Then
            txtnamapasien.Text = dr.Item(0)
            dtptanggalkunjungan.Text = dr.Item(1)
            cbcarabayar.Text = dr.Item(2)
            cbkodepoli.Text = dr.Item(3)
            txtnamapoli.Text = dr.Item(4)
            cbdokter.Text = dr.Item(5)
            txtdiagnosa.Text = dr.Item(6)
            dr.Close()
        Else
            dr.Close()
            MsgBox("No RM belum terdaftar")
        End If
    End Sub

    Shared Function CrystalReportViewer1() As Object
        Throw New NotImplementedException
    End Function






End Class