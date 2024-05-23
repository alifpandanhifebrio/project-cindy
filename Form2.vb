Imports System.Data.OleDb
Public Class FormPetugas
    Sub daftar()
        cmd = New OleDbCommand("select*form tb_Petugas order by nip_petugas", cn)
        cmd.ExecuteNonQuery()
        tb.Clear()
        da.Fill(tb)
    End Sub
    Sub bersihkan()
        txtnip.Text = ""
        txtnama.Text = ""
        cbjabatan.Text = ""
        txtusername.Text = ""
        txtpassword.Text = ""
        txtnip.Focus()
    End Sub
    Sub DataBaru()
        txtnip.Text = ""
        txtnama.Text = ""
        cbjabatan.Text = ""
        txtusername.Text = ""
        txtpassword.Text = ""
        txtnip.Focus()
    End Sub
    Sub Lihat_data_Petugas()
        cmd = New OleDbCommand("select * from tb_Petugas order by NIP_Petugas", cn)
        cmd.ExecuteNonQuery()
        da = New OleDbDataAdapter(cmd)
        tb = New DataTable
        da.Fill(tb)
        dgvdatapetugas.DataSource = tb
        dgvdatapetugas.Refresh()
    End Sub

    Private Sub FormPetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call Lihat_data_Petugas()
    End Sub
    Private Sub bthapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bthapus.Click
        Dim hapus As String
        hapus = InputBox("masukan Username yang akan dihapus:", "Hapus")
        cmd = New OleDbCommand("DELETE from tb_petugas WHERE Username=@Username", cn)
        cmd.Parameters.AddWithValue("@Username", hapus)
        cmd.ExecuteNonQuery()
        Call bersihkan()
        Call Lihat_data_Petugas()
        MsgBox("data berhasil dihapus..!")
        txtnip.Focus()
    End Sub
    Private Sub btbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbatal.Click
        Call bersihkan()
    End Sub
    Private Sub btkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btkeluar.Click
        Me.Close()
        MsgBox("Anda Akan Keluar?")
    End Sub
    Private Sub btsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsimpan.Click
        If txtnip.Text = "" Or txtnama.Text = "" Or cbjabatan.Text = "" Or
       txtusername.Text = "" Or txtpassword.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
 cmd = New OleDbCommand("INSERT INTO tb_Petugas VALUES(@NIP,@Nama,@Jabatan,@Username,@Password)", cn)
            cmd.Parameters.AddWithValue("@NIP", txtnip.Text)
            cmd.Parameters.AddWithValue("@nama", txtnama.Text)
            cmd.Parameters.AddWithValue("@jabatan", cbjabatan.Text)
            cmd.Parameters.AddWithValue("@username", txtusername.Text)
            cmd.Parameters.AddWithValue("@password", txtpassword.Text)
            cmd.ExecuteNonQuery()
            MsgBox("data tersimpan", MsgBoxStyle.Information, "informasi")
            Call bersihkan()
            Call Lihat_data_Petugas()
            txtnip.Focus()
            'Form_Login.Show()
        End If
    End Sub
    Private Sub dgvdatapetugas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvdatapetugas.DoubleClick
        txtnip.Text = dgvdatapetugas.CurrentRow.Cells(0).Value
        txtnama.Text = dgvdatapetugas.CurrentRow.Cells(1).Value
        cbjabatan.Text = dgvdatapetugas.CurrentRow.Cells(2).Value
        txtusername.Text = dgvdatapetugas.CurrentRow.Cells(3).Value
        txtpassword.Text = dgvdatapetugas.CurrentRow.Cells(4).Value
        txtnip.ReadOnly = True
        btsimpan.Enabled = False
    End Sub
    Private Sub btedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btedit.Click
        cmd = New OleDbCommand("Update tb_petugas set NIP=@nip,Nama=@nama,Jabatan=@jabatan,Username=@username WHERE Password=@password", cn)
        cmd.Parameters.AddWithValue("@nip", txtnip.Text)
        cmd.Parameters.AddWithValue("@nama", txtnama.Text)
        cmd.Parameters.AddWithValue("@jabatan", cbjabatan.Text)
        cmd.Parameters.AddWithValue("@username", txtusername.Text)
        cmd.Parameters.AddWithValue("@password", txtpassword.Text)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil di edit..!")
        Call bersihkan()
        Call Lihat_data_Petugas()
        txtnip.Focus()
        btsimpan.Enabled = True
    End Sub
End Class