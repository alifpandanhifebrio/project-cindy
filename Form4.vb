Imports System.Data.OleDb
Public Class Formpoli
    Private Sub Formdatapenyimpanan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbpoli.Items.Add("A")
        cbpoli.Items.Add("B")
        cbpoli.Items.Add("C")
        Call koneksi()
        Call lihat_data_poli()
    End Sub
    Sub bersihkan()
        cbpoli.Text = ""
        txtnamapoli.Text = ""
        txtnip.Text = ""
        txtnamapetugas.Text = ""
    End Sub
    Sub DataBaru()
        cbpoli.Text = ""
        txtnamapoli.Text = ""
        txtnip.Text = ""
        txtnamapetugas.Text = ""
    End Sub
    Sub lihat_data_poli()
        cmd = New OleDbCommand("select*from tb_Poliklinik", cn)
        cmd.ExecuteNonQuery()
        da = New OleDbDataAdapter(cmd)
        tb = New DataTable
        da.Fill(tb)
        dgvpoli.DataSource = tb
        dgvpoli.Refresh()
    End Sub
    Private Sub FormPoli_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call lihat_data_poli()
        Call cbpoli.Focus()
    End Sub
    Private Sub btsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsimpan.Click
        cmd = New OleDbCommand("insert into tb_Poliklinik(Kode_Poliklinik, Nama_Poliklinik, NIP_Petugas, Nama_Petugas)Values(@kodepoliklinik,@namapoliklinik,@nip,@namapetugas)", cn)
        cmd.Parameters.AddWithValue("@kodepoliklinik", cbpoli.Text)
        cmd.Parameters.AddWithValue("@namapoliklinik", txtnamapoli.Text)
        cmd.Parameters.AddWithValue("@nip", txtnip.Text)
        cmd.Parameters.AddWithValue("@namapetugas", txtnamapetugas.Text)
        cmd.ExecuteNonQuery()
        MsgBox("data tersimpan", MsgBoxStyle.Information, "informasi")
        Call bersihkan()
        Call lihat_data_poli()
        cbpoli.Focus()
    End Sub
    Private Sub bthapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bthapus.Click
        Dim hapus As String
        hapus = InputBox("Masukan NIP yang akan dihapus:", "hapus")
        cmd = New OleDbCommand("DELETE FROM tb_poliklinik WHERE nip=@nip", cn)
        cmd.Parameters.AddWithValue("@nip", hapus)
        cmd.ExecuteNonQuery()
        Call bersihkan()
        Call lihat_data_poli()
        MsgBox("data berhasil dihapus..!")
        cbpoli.Focus()
    End Sub
    Private Sub btbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbatal.Click
        Call bersihkan()
    End Sub
    Private Sub btkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btkeluar.Click
        Me.Close()
        MsgBox("Anda Akan Keluar?")
    End Sub
    Private Sub cbpoli_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbpoli.SelectedIndexChanged
        Select Case cbpoli.Text
            Case "A"
                txtnamapoli.Text = "UMUM"
            Case "B"
                txtnamapoli.Text = "ANAK"
            Case "C"
                txtnamapoli.Text = "KIA"
        End Select
    End Sub
    Private Sub dgvpoli_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvpoli.CellContentClick

    End Sub
    Private Sub btedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btedit.Click
        cmd = New OleDbCommand("update tb_poliklinik setPoliklinik=@kodepoliklinik,Nama_Poliklinik=@poliklinik,NIP=@nip,Nama_Petugas=@namapetugas where Kode_poliklinik=@kodepoliklinik", cn)
        cmd.Parameters.AddWithValue("@kodepoliklinik", cbpoli.Text)
        cmd.Parameters.AddWithValue("@namapoliklinik", txtnamapoli.Text)
        cmd.Parameters.AddWithValue("@nip", txtnip.Text)
        cmd.Parameters.AddWithValue("@namapetugas", txtnamapetugas.Text)
        cmd.ExecuteNonQuery()
        Call bersihkan()
        Call lihat_data_poli()
        txtnamapoli.ReadOnly = False
        btsimpan.Enabled = True
        MsgBox("Data Berhasil di Ubah..!")
    End Sub
    Private Sub dgvpoli_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvpoli.DoubleClick
        cbpoli.Text = dgvpoli.CurrentRow.Cells(0).Value
        txtnamapoli.Text = dgvpoli.CurrentRow.Cells(1).Value
        txtnip.Text = dgvpoli.CurrentRow.Cells(2).Value
        txtnamapetugas.Text = dgvpoli.CurrentRow.Cells(3).Value
        txtnamapetugas.ReadOnly = True
        btsimpan.Enabled = False
    End Sub
    Private Sub btbaru_Click(sender As System.Object, e As System.EventArgs) Handles btbaru.Click
    End Sub
End Class