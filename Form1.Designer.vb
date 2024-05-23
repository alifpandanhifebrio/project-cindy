<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataPasien
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtptgllahir = New System.Windows.Forms.DateTimePicker()
        Me.dtptanggalkunjungan = New System.Windows.Forms.DateTimePicker()
        Me.cbjk = New System.Windows.Forms.ComboBox()
        Me.txtumur = New System.Windows.Forms.TextBox()
        Me.txttempat = New System.Windows.Forms.TextBox()
        Me.txtnamapasien = New System.Windows.Forms.TextBox()
        Me.txtnorm = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtnamapoli = New System.Windows.Forms.TextBox()
        Me.cbdokter = New System.Windows.Forms.ComboBox()
        Me.cbkodepoli = New System.Windows.Forms.ComboBox()
        Me.cbcarabayar = New System.Windows.Forms.ComboBox()
        Me.txtnotelp = New System.Windows.Forms.TextBox()
        Me.txtdiagnosa = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtcaridata = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btbaru = New System.Windows.Forms.Button()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.btedit = New System.Windows.Forms.Button()
        Me.btbatal = New System.Windows.Forms.Button()
        Me.btkeluar = New System.Windows.Forms.Button()
        Me.dgvdatapasien = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvdatapasien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtptgllahir)
        Me.GroupBox1.Controls.Add(Me.dtptanggalkunjungan)
        Me.GroupBox1.Controls.Add(Me.cbjk)
        Me.GroupBox1.Controls.Add(Me.txtumur)
        Me.GroupBox1.Controls.Add(Me.txttempat)
        Me.GroupBox1.Controls.Add(Me.txtnamapasien)
        Me.GroupBox1.Controls.Add(Me.txtnorm)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 254)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'dtptgllahir
        '
        Me.dtptgllahir.Location = New System.Drawing.Point(145, 162)
        Me.dtptgllahir.Name = "dtptgllahir"
        Me.dtptgllahir.Size = New System.Drawing.Size(147, 20)
        Me.dtptgllahir.TabIndex = 14
        '
        'dtptanggalkunjungan
        '
        Me.dtptanggalkunjungan.Location = New System.Drawing.Point(145, 20)
        Me.dtptanggalkunjungan.Name = "dtptanggalkunjungan"
        Me.dtptanggalkunjungan.Size = New System.Drawing.Size(147, 20)
        Me.dtptanggalkunjungan.TabIndex = 13
        Me.dtptanggalkunjungan.Value = New Date(2022, 11, 2, 21, 13, 44, 0)
        '
        'cbjk
        '
        Me.cbjk.FormattingEnabled = True
        Me.cbjk.Items.AddRange(New Object() {"Perempuan", "Laki - Laki"})
        Me.cbjk.Location = New System.Drawing.Point(145, 227)
        Me.cbjk.Name = "cbjk"
        Me.cbjk.Size = New System.Drawing.Size(121, 21)
        Me.cbjk.TabIndex = 12
        '
        'txtumur
        '
        Me.txtumur.Location = New System.Drawing.Point(145, 188)
        Me.txtumur.Name = "txtumur"
        Me.txtumur.Size = New System.Drawing.Size(100, 20)
        Me.txtumur.TabIndex = 11
        '
        'txttempat
        '
        Me.txttempat.Location = New System.Drawing.Point(145, 119)
        Me.txttempat.Name = "txttempat"
        Me.txttempat.Size = New System.Drawing.Size(144, 20)
        Me.txttempat.TabIndex = 10
        '
        'txtnamapasien
        '
        Me.txtnamapasien.Location = New System.Drawing.Point(145, 87)
        Me.txtnamapasien.Name = "txtnamapasien"
        Me.txtnamapasien.Size = New System.Drawing.Size(164, 20)
        Me.txtnamapasien.TabIndex = 9
        '
        'txtnorm
        '
        Me.txtnorm.Location = New System.Drawing.Point(145, 48)
        Me.txtnorm.Name = "txtnorm"
        Me.txtnorm.Size = New System.Drawing.Size(121, 20)
        Me.txtnorm.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Jenis Kelamin"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(251, 191)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Tahun"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Umur"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tanggal Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tempat Lahir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Pasien"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No Rekam Medis"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tanggal Kunjungan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Alamat"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtnamapoli)
        Me.GroupBox2.Controls.Add(Me.cbdokter)
        Me.GroupBox2.Controls.Add(Me.cbkodepoli)
        Me.GroupBox2.Controls.Add(Me.cbcarabayar)
        Me.GroupBox2.Controls.Add(Me.txtnotelp)
        Me.GroupBox2.Controls.Add(Me.txtdiagnosa)
        Me.GroupBox2.Controls.Add(Me.txtalamat)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(333, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(357, 317)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'txtnamapoli
        '
        Me.txtnamapoli.Location = New System.Drawing.Point(165, 175)
        Me.txtnamapoli.Name = "txtnamapoli"
        Me.txtnamapoli.Size = New System.Drawing.Size(121, 20)
        Me.txtnamapoli.TabIndex = 19
        '
        'cbdokter
        '
        Me.cbdokter.FormattingEnabled = True
        Me.cbdokter.Items.AddRange(New Object() {"Cindy Surya", "Siti Fatimah", "Iin Inarotul", "Belinda"})
        Me.cbdokter.Location = New System.Drawing.Point(165, 204)
        Me.cbdokter.Name = "cbdokter"
        Me.cbdokter.Size = New System.Drawing.Size(121, 21)
        Me.cbdokter.TabIndex = 18
        '
        'cbkodepoli
        '
        Me.cbkodepoli.FormattingEnabled = True
        Me.cbkodepoli.Location = New System.Drawing.Point(165, 144)
        Me.cbkodepoli.Name = "cbkodepoli"
        Me.cbkodepoli.Size = New System.Drawing.Size(121, 21)
        Me.cbkodepoli.TabIndex = 17
        '
        'cbcarabayar
        '
        Me.cbcarabayar.FormattingEnabled = True
        Me.cbcarabayar.Items.AddRange(New Object() {"BPJS", "ASKES", "Umum"})
        Me.cbcarabayar.Location = New System.Drawing.Point(165, 116)
        Me.cbcarabayar.Name = "cbcarabayar"
        Me.cbcarabayar.Size = New System.Drawing.Size(121, 21)
        Me.cbcarabayar.TabIndex = 15
        '
        'txtnotelp
        '
        Me.txtnotelp.Location = New System.Drawing.Point(165, 91)
        Me.txtnotelp.Name = "txtnotelp"
        Me.txtnotelp.Size = New System.Drawing.Size(121, 20)
        Me.txtnotelp.TabIndex = 15
        '
        'txtdiagnosa
        '
        Me.txtdiagnosa.Location = New System.Drawing.Point(165, 231)
        Me.txtdiagnosa.Multiline = True
        Me.txtdiagnosa.Name = "txtdiagnosa"
        Me.txtdiagnosa.Size = New System.Drawing.Size(186, 73)
        Me.txtdiagnosa.TabIndex = 16
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(165, 17)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(186, 68)
        Me.txtalamat.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 241)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 13)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Diagnosa"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 178)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Nama Poliklinik"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 147)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Kode Poliklinik"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 207)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Dokter Yang Menangani"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 119)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Cara Bayar"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "No Telpon"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtcaridata)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 272)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(315, 57)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'txtcaridata
        '
        Me.txtcaridata.Location = New System.Drawing.Point(145, 24)
        Me.txtcaridata.Name = "txtcaridata"
        Me.txtcaridata.Size = New System.Drawing.Size(164, 20)
        Me.txtcaridata.TabIndex = 15
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 31)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 13)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Cari Data"
        '
        'btbaru
        '
        Me.btbaru.Location = New System.Drawing.Point(99, 365)
        Me.btbaru.Name = "btbaru"
        Me.btbaru.Size = New System.Drawing.Size(75, 23)
        Me.btbaru.TabIndex = 2
        Me.btbaru.Text = "BARU"
        Me.btbaru.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Location = New System.Drawing.Point(203, 365)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btsimpan.TabIndex = 3
        Me.btsimpan.Text = "SIMPAN"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'bthapus
        '
        Me.bthapus.Location = New System.Drawing.Point(290, 365)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(75, 23)
        Me.bthapus.TabIndex = 4
        Me.bthapus.Text = "HAPUS"
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'btedit
        '
        Me.btedit.Location = New System.Drawing.Point(387, 365)
        Me.btedit.Name = "btedit"
        Me.btedit.Size = New System.Drawing.Size(75, 23)
        Me.btedit.TabIndex = 5
        Me.btedit.Text = "EDIT"
        Me.btedit.UseVisualStyleBackColor = True
        '
        'btbatal
        '
        Me.btbatal.Location = New System.Drawing.Point(482, 365)
        Me.btbatal.Name = "btbatal"
        Me.btbatal.Size = New System.Drawing.Size(75, 23)
        Me.btbatal.TabIndex = 6
        Me.btbatal.Text = "BATAL"
        Me.btbatal.UseVisualStyleBackColor = True
        '
        'btkeluar
        '
        Me.btkeluar.Location = New System.Drawing.Point(574, 365)
        Me.btkeluar.Name = "btkeluar"
        Me.btkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btkeluar.TabIndex = 7
        Me.btkeluar.Text = "KELUAR"
        Me.btkeluar.UseVisualStyleBackColor = True
        '
        'dgvdatapasien
        '
        Me.dgvdatapasien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdatapasien.Location = New System.Drawing.Point(12, 394)
        Me.dgvdatapasien.Name = "dgvdatapasien"
        Me.dgvdatapasien.Size = New System.Drawing.Size(672, 122)
        Me.dgvdatapasien.TabIndex = 8
        '
        'FormDataPasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(702, 518)
        Me.Controls.Add(Me.dgvdatapasien)
        Me.Controls.Add(Me.btkeluar)
        Me.Controls.Add(Me.btbatal)
        Me.Controls.Add(Me.btedit)
        Me.Controls.Add(Me.bthapus)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.btbaru)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormDataPasien"
        Me.Text = "Form Data Pasien"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvdatapasien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtptgllahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtptanggalkunjungan As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbjk As System.Windows.Forms.ComboBox
    Friend WithEvents txtumur As System.Windows.Forms.TextBox
    Friend WithEvents txttempat As System.Windows.Forms.TextBox
    Friend WithEvents txtnamapasien As System.Windows.Forms.TextBox
    Friend WithEvents txtnorm As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtnamapoli As System.Windows.Forms.TextBox
    Friend WithEvents cbdokter As System.Windows.Forms.ComboBox
    Friend WithEvents cbkodepoli As System.Windows.Forms.ComboBox
    Friend WithEvents cbcarabayar As System.Windows.Forms.ComboBox
    Friend WithEvents txtnotelp As System.Windows.Forms.TextBox
    Friend WithEvents txtdiagnosa As System.Windows.Forms.TextBox
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtcaridata As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btbaru As System.Windows.Forms.Button
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents bthapus As System.Windows.Forms.Button
    Friend WithEvents btedit As System.Windows.Forms.Button
    Friend WithEvents btbatal As System.Windows.Forms.Button
    Friend WithEvents btkeluar As System.Windows.Forms.Button
    Friend WithEvents dgvdatapasien As System.Windows.Forms.DataGridView

End Class
