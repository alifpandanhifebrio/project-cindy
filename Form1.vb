Imports System.Data.OleDb
Public Class FormDataPasien
    Private Sub FormDataPasien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbkodepoli.Items.Add("A")
        cbkodepoli.Items.Add("B")
        cbkodepoli.Items.Add("C")
        Call koneksi()
        Call lihat_Form_data_pasien()
    End Sub
    Sub lihat_Form_data_pasien()
        cmd = New OleDbCommand("select*from tb_Pasien", cn)
        cmd.ExecuteNonQuery()
        da = New OleDbDataAdapter(cmd)
        tb = New DataTable
        da.Fill(tb)
        dgvdatapasien.DataSource = tb
        dgvdatapasien.Refresh()
    End Sub
    Sub bersihkan()
        dtptanggalkunjungan.Value = Now
        txtnorm.Clear()
        txtnamapasien.Clear()
        txttempat.Clear()
        dtptgllahir.Value = Now
        txtumur.Clear()
        cbjk.Text = "--pilih--"
        txtalamat.Clear()
        txtnotelp.Clear()
        cbcarabayar.Text = "--pilih--"
        cbkodepoli.Text = "--pilih--"
        txtnamapoli.Clear()
        cbdokter.Text = "--pilih--"
        txtdiagnosa.Clear()
    End Sub
    Private Sub btbaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbaru.Click
        Call bersihkan()
        txtnorm.Focus()
    End Sub
    Private Sub btsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsimpan.Click
        cmd = New OleDbCommand("insert into tb_Pasien (Tanggal_Kunjungan,No_RM,Nama_Pasien,Tempat_Lahir,Tanggal_Lahir,Umur,Jenis_Kelamin,Alamat,No_Telepon,Cara_Bayar,Kode_Poliklinik,Nama_Poliklinik,Dokter,Diagnosa) values(@tanggalkunjungan,@norm,@namapasien,@tempatlahir,@tanggallahir,@umur,@jeniskelamin,@alamat,@notelepon,@carabayar,@kodepoliklinik,@namapoliklinik,@dokter,@diagnosa)", cn)
        cmd.Parameters.AddWithValue("@tanggalkunjungan", Format(dtptanggalkunjungan.Value, "yyyy-MM-dd"))
        cmd.Parameters.AddWithValue("@norm", Val(txtnorm.Text))
        cmd.Parameters.AddWithValue("@namapasien", txtnamapasien.Text)
        cmd.Parameters.AddWithValue("@tempatlahir", txttempat.Text)
        cmd.Parameters.AddWithValue("@tanggallahir", Format(dtptgllahir.Value, "yyyy-MM-dd"))
        cmd.Parameters.AddWithValue("@umur", txtumur.Text)
        cmd.Parameters.AddWithValue("@jeniskelamin", cbjk.Text)
        cmd.Parameters.AddWithValue("@alamat", txtalamat.Text)
        cmd.Parameters.AddWithValue("@notelepon", txtnotelp.Text)
        cmd.Parameters.AddWithValue("@carabayar", cbcarabayar.Text)
        cmd.Parameters.AddWithValue("@kodepoliklinik", cbkodepoli.Text)
        cmd.Parameters.AddWithValue("@namapoliklinik", txtnamapoli.Text)
        cmd.Parameters.AddWithValue("@dokter", cbdokter.Text)
        cmd.Parameters.AddWithValue("@diagnosa", txtdiagnosa.Text)
        cmd.ExecuteNonQuery()
        MsgBox("data tersimpan", MsgBoxStyle.Information, "informasi")
        Call bersihkan()
        Call lihat_Form_data_pasien()
        txtnorm.Focus()
    End Sub
    Sub Kode_otomatis()
        Call koneksi()
        cmd = New OleDbCommand("select * from tb_Pasien where no_RM in (select max(no_RM)from tb_Pasien)", cn)
        Dim urutan As String
        Dim hitung As Long
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            urutan = "RM" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(dr.GetString(0), 3) = +1
            urutan = "RM" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        txtnorm.Text = urutan
    End Sub
    Private Sub btedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btedit.Click
        cmd = New OleDbCommand("update tb_Pasien set Tanggal_Kunjungan=@tanggalkunjungan,Nama_Pasien=@namapasien,Tempat_Lahir=@tempatlahir,Tanggal_Lahir=@tanggllahir,Umur=@umur,Jenis_Kelamin=@jk,Alamat=@alamat,No_Telepon=@notelepon,Cara_Bayar=@carabayar,Kode_Poliklinik=@kodepoliklinik,Nama_Poliklinik=@namapoliklinik,Dokter=@dokter,Diagnosa=@diagnosa where No_RM=@norm", cn)
        cmd.Parameters.AddWithValue("@tanggalkunjungan",
       Format(dtptanggalkunjungan.Value, "yyyy-MM-dd"))
        cmd.Parameters.AddWithValue("@namapasien", txtnamapasien.Text)
        cmd.Parameters.AddWithValue("@tempatlahir", txttempat.Text)
        cmd.Parameters.AddWithValue("@tanggallahir", Format(dtptgllahir.Value, "yyyyMM-dd"))
        cmd.Parameters.AddWithValue("@umur", txtumur.Text)
        cmd.Parameters.AddWithValue("@jk", cbjk.Text)
        cmd.Parameters.AddWithValue("@alamat", txtalamat.Text)
        cmd.Parameters.AddWithValue("@notelepon", txtnotelp.Text)
        cmd.Parameters.AddWithValue("@carabayar", cbcarabayar.Text)
        cmd.Parameters.AddWithValue("@kodepoli", cbkodepoli.Text)
        cmd.Parameters.AddWithValue("@namapoli", txtnamapoli.Text)
        cmd.Parameters.AddWithValue("@dokter", cbdokter.Text)
        cmd.Parameters.AddWithValue("@diagnosa", txtdiagnosa.Text)
        cmd.Parameters.AddWithValue("@norm", txtnorm.Text)
        cmd.ExecuteNonQuery()
        Call bersihkan()
        Call lihat_Form_data_pasien()
        txtnorm.ReadOnly = False
        btsimpan.Enabled = True
        MsgBox("Data Berhasil di Ubah..!")
    End Sub
    Private Sub bthapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bthapus.Click
        Dim hapus As String
        hapus = InputBox("Masukan No Rekam Medis yang akan dihapus:", "Hapus")
        cmd = New OleDbCommand("delete from tb_Pasien where no_RM=@no_RM", cn)
        cmd.Parameters.AddWithValue("No_RM", hapus)
        cmd.ExecuteNonQuery()
        Call bersihkan()
        Call lihat_Form_data_pasien()
        MsgBox("Data berhasil dihapus..!")
    End Sub
    Private Sub txtcaridata_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcaridata.TextChanged
        If txtcaridata.Text = "" Then
            Call lihat_Form_data_pasien()
        Else
            cmd = New OleDbCommand("select * from tb_Penyimpanan where no_rm like @norm or nama_pasien like @namapasien", cn)
            cmd.Parameters.AddWithValue("@norm", "%" & txtcaridata.Text & "%")
            cmd.Parameters.AddWithValue("@namapasien", "%" & txtcaridata.Text & "%")
            cmd.ExecuteNonQuery()
            da = New OleDbDataAdapter(cmd)
            tb = New DataTable
            da.Fill(tb)
            dgvdatapasien.DataSource = tb
            dgvdatapasien.Refresh()
        End If
    End Sub
    Private Sub btkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btkeluar.Click
        Dim pesan As String
        pesan = MsgBox("Anda akan keluar?", MsgBoxStyle.YesNo)
        If pesan = vbYes Then
            Close()
        End If
    End Sub
    Private Sub btbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbatal.Click
        Call bersihkan()
    End Sub
    Private Sub lihat_Pasien()
        Throw New NotImplementedException
    End Sub
    Private Sub dgvdatapasien_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvdatapasien.DoubleClick
        dtptanggalkunjungan.Value = dgvdatapasien.CurrentRow.Cells(0).Value
        txtnorm.Text = dgvdatapasien.CurrentRow.Cells(1).Value
        txtnamapasien.Text = dgvdatapasien.CurrentRow.Cells(2).Value
        txttempat.Text = dgvdatapasien.CurrentRow.Cells(3).Value
        dtptgllahir.Value = dgvdatapasien.CurrentRow.Cells(4).Value
        txtumur.Text = dgvdatapasien.CurrentRow.Cells(5).Value
        cbjk.Text = dgvdatapasien.CurrentRow.Cells(6).Value
        txtalamat.Text = dgvdatapasien.CurrentRow.Cells(7).Value
        txtnotelp.Text = dgvdatapasien.CurrentRow.Cells(8).Value
        cbcarabayar.Text = dgvdatapasien.CurrentRow.Cells(9).Value
        cbkodepoli.Text = dgvdatapasien.CurrentRow.Cells(10).Value
        txtnamapoli.Text = dgvdatapasien.CurrentRow.Cells(11).Value
        cbdokter.Text = dgvdatapasien.CurrentRow.Cells(12).Value
        txtdiagnosa.Text = dgvdatapasien.CurrentRow.Cells(13).Value
        txtnorm.ReadOnly = True
        btsimpan.Enabled = False
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
    Private Sub dtptgllahir_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtptgllahir.ValueChanged
        txtumur.Text = Year(Today) - Year(dtptgllahir.Value)
    End Sub
    Private Sub dgvdatapasien_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvdatapasien.CellContentClick
    End Sub


End Class
