<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formpoli
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
        Me.dgvpoli = New System.Windows.Forms.DataGridView()
        Me.cbpoli = New System.Windows.Forms.ComboBox()
        Me.txtnamapoli = New System.Windows.Forms.TextBox()
        Me.txtnamapetugas = New System.Windows.Forms.TextBox()
        Me.txtnip = New System.Windows.Forms.TextBox()
        Me.btkeluar = New System.Windows.Forms.Button()
        Me.btedit = New System.Windows.Forms.Button()
        Me.btbatal = New System.Windows.Forms.Button()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.btbaru = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvpoli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvpoli
        '
        Me.dgvpoli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpoli.Location = New System.Drawing.Point(21, 241)
        Me.dgvpoli.Name = "dgvpoli"
        Me.dgvpoli.Size = New System.Drawing.Size(482, 122)
        Me.dgvpoli.TabIndex = 33
        '
        'cbpoli
        '
        Me.cbpoli.FormattingEnabled = True
        Me.cbpoli.Location = New System.Drawing.Point(204, 49)
        Me.cbpoli.Name = "cbpoli"
        Me.cbpoli.Size = New System.Drawing.Size(121, 21)
        Me.cbpoli.TabIndex = 32
        '
        'txtnamapoli
        '
        Me.txtnamapoli.Location = New System.Drawing.Point(204, 90)
        Me.txtnamapoli.Name = "txtnamapoli"
        Me.txtnamapoli.Size = New System.Drawing.Size(100, 20)
        Me.txtnamapoli.TabIndex = 30
        '
        'txtnamapetugas
        '
        Me.txtnamapetugas.Location = New System.Drawing.Point(204, 159)
        Me.txtnamapetugas.Name = "txtnamapetugas"
        Me.txtnamapetugas.Size = New System.Drawing.Size(100, 20)
        Me.txtnamapetugas.TabIndex = 29
        '
        'txtnip
        '
        Me.txtnip.Location = New System.Drawing.Point(204, 125)
        Me.txtnip.Name = "txtnip"
        Me.txtnip.Size = New System.Drawing.Size(100, 20)
        Me.txtnip.TabIndex = 28
        '
        'btkeluar
        '
        Me.btkeluar.Location = New System.Drawing.Point(428, 212)
        Me.btkeluar.Name = "btkeluar"
        Me.btkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btkeluar.TabIndex = 27
        Me.btkeluar.Text = "KELUAR"
        Me.btkeluar.UseVisualStyleBackColor = True
        '
        'btedit
        '
        Me.btedit.Location = New System.Drawing.Point(347, 212)
        Me.btedit.Name = "btedit"
        Me.btedit.Size = New System.Drawing.Size(75, 23)
        Me.btedit.TabIndex = 26
        Me.btedit.Text = "EDIT"
        Me.btedit.UseVisualStyleBackColor = True
        '
        'btbatal
        '
        Me.btbatal.Location = New System.Drawing.Point(266, 212)
        Me.btbatal.Name = "btbatal"
        Me.btbatal.Size = New System.Drawing.Size(75, 23)
        Me.btbatal.TabIndex = 25
        Me.btbatal.Text = "BATAL"
        Me.btbatal.UseVisualStyleBackColor = True
        '
        'bthapus
        '
        Me.bthapus.Location = New System.Drawing.Point(183, 212)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(75, 23)
        Me.bthapus.TabIndex = 24
        Me.bthapus.Text = "HAPUS"
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Location = New System.Drawing.Point(102, 212)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btsimpan.TabIndex = 23
        Me.btsimpan.Text = "SIMPAN"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'btbaru
        '
        Me.btbaru.Location = New System.Drawing.Point(21, 212)
        Me.btbaru.Name = "btbaru"
        Me.btbaru.Size = New System.Drawing.Size(75, 23)
        Me.btbaru.TabIndex = 22
        Me.btbaru.Text = "BARU"
        Me.btbaru.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(92, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Nama Petugas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(92, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "NIP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(92, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Nama poliklinik"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(92, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Kode poliklinik"
        '
        'Formpoli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(533, 384)
        Me.Controls.Add(Me.dgvpoli)
        Me.Controls.Add(Me.cbpoli)
        Me.Controls.Add(Me.txtnamapoli)
        Me.Controls.Add(Me.txtnamapetugas)
        Me.Controls.Add(Me.txtnip)
        Me.Controls.Add(Me.btkeluar)
        Me.Controls.Add(Me.btedit)
        Me.Controls.Add(Me.btbatal)
        Me.Controls.Add(Me.bthapus)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.btbaru)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Formpoli"
        Me.Text = "Data Poliklinik"
        CType(Me.dgvpoli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvpoli As System.Windows.Forms.DataGridView
    Friend WithEvents cbpoli As System.Windows.Forms.ComboBox
    Friend WithEvents txtnamapoli As System.Windows.Forms.TextBox
    Friend WithEvents txtnamapetugas As System.Windows.Forms.TextBox
    Friend WithEvents txtnip As System.Windows.Forms.TextBox
    Friend WithEvents btkeluar As System.Windows.Forms.Button
    Friend WithEvents btedit As System.Windows.Forms.Button
    Friend WithEvents btbatal As System.Windows.Forms.Button
    Friend WithEvents bthapus As System.Windows.Forms.Button
    Friend WithEvents btsimpan As System.Windows.Forms.Button
    Friend WithEvents btbaru As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
