<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPetugas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btbaru = New System.Windows.Forms.Button()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.btbatal = New System.Windows.Forms.Button()
        Me.btedit = New System.Windows.Forms.Button()
        Me.btkeluar = New System.Windows.Forms.Button()
        Me.txtnip = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.cbjabatan = New System.Windows.Forms.ComboBox()
        Me.dgvdatapetugas = New System.Windows.Forms.DataGridView()
        CType(Me.dgvdatapetugas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(122, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(122, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(122, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jabatan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(122, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Username"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(122, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Password"
        '
        'btbaru
        '
        Me.btbaru.Location = New System.Drawing.Point(23, 261)
        Me.btbaru.Name = "btbaru"
        Me.btbaru.Size = New System.Drawing.Size(75, 23)
        Me.btbaru.TabIndex = 5
        Me.btbaru.Text = "BARU"
        Me.btbaru.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Location = New System.Drawing.Point(104, 263)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btsimpan.TabIndex = 6
        Me.btsimpan.Text = "SIMPAN"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'bthapus
        '
        Me.bthapus.Location = New System.Drawing.Point(185, 261)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(75, 23)
        Me.bthapus.TabIndex = 7
        Me.bthapus.Text = "HAPUS"
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'btbatal
        '
        Me.btbatal.Location = New System.Drawing.Point(268, 261)
        Me.btbatal.Name = "btbatal"
        Me.btbatal.Size = New System.Drawing.Size(75, 23)
        Me.btbatal.TabIndex = 8
        Me.btbatal.Text = "BATAL"
        Me.btbatal.UseVisualStyleBackColor = True
        '
        'btedit
        '
        Me.btedit.Location = New System.Drawing.Point(349, 261)
        Me.btedit.Name = "btedit"
        Me.btedit.Size = New System.Drawing.Size(75, 23)
        Me.btedit.TabIndex = 9
        Me.btedit.Text = "EDIT"
        Me.btedit.UseVisualStyleBackColor = True
        '
        'btkeluar
        '
        Me.btkeluar.Location = New System.Drawing.Point(430, 261)
        Me.btkeluar.Name = "btkeluar"
        Me.btkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btkeluar.TabIndex = 10
        Me.btkeluar.Text = "KELUAR"
        Me.btkeluar.UseVisualStyleBackColor = True
        '
        'txtnip
        '
        Me.txtnip.Location = New System.Drawing.Point(234, 44)
        Me.txtnip.Name = "txtnip"
        Me.txtnip.Size = New System.Drawing.Size(100, 20)
        Me.txtnip.TabIndex = 11
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(234, 154)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(100, 20)
        Me.txtusername.TabIndex = 12
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(234, 85)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(100, 20)
        Me.txtnama.TabIndex = 13
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(234, 194)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(100, 20)
        Me.txtpassword.TabIndex = 14
        '
        'cbjabatan
        '
        Me.cbjabatan.FormattingEnabled = True
        Me.cbjabatan.Items.AddRange(New Object() {"Petugas TU", "Staff"})
        Me.cbjabatan.Location = New System.Drawing.Point(234, 120)
        Me.cbjabatan.Name = "cbjabatan"
        Me.cbjabatan.Size = New System.Drawing.Size(121, 21)
        Me.cbjabatan.TabIndex = 15
        Me.cbjabatan.Text = "S"
        '
        'dgvdatapetugas
        '
        Me.dgvdatapetugas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdatapetugas.Location = New System.Drawing.Point(23, 290)
        Me.dgvdatapetugas.Name = "dgvdatapetugas"
        Me.dgvdatapetugas.Size = New System.Drawing.Size(482, 122)
        Me.dgvdatapetugas.TabIndex = 16
        '
        'FormPetugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(533, 416)
        Me.Controls.Add(Me.dgvdatapetugas)
        Me.Controls.Add(Me.cbjabatan)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.txtnip)
        Me.Controls.Add(Me.btkeluar)
        Me.Controls.Add(Me.btedit)
        Me.Controls.Add(Me.btbatal)
        Me.Controls.Add(Me.bthapus)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.btbaru)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPetugas"
        Me.Text = "Data Petugas"
        CType(Me.dgvdatapetugas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btbaru As System.Windows.Forms.Button
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents bthapus As System.Windows.Forms.Button
    Friend WithEvents btbatal As System.Windows.Forms.Button
    Friend WithEvents btedit As System.Windows.Forms.Button
    Friend WithEvents btkeluar As System.Windows.Forms.Button
    Friend WithEvents txtnip As System.Windows.Forms.TextBox
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents cbjabatan As System.Windows.Forms.ComboBox
    Friend WithEvents dgvdatapetugas As System.Windows.Forms.DataGridView
End Class
