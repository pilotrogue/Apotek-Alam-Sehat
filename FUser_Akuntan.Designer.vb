<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FUser_Akuntan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FUser_Akuntan))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.BtnJurnalPenjualan = New System.Windows.Forms.Button()
        Me.BtnJurnalPembelian = New System.Windows.Forms.Button()
        Me.BtnJurnalPengeluaranKas = New System.Windows.Forms.Button()
        Me.BtnJurnalPenerimaanKas = New System.Windows.Forms.Button()
        Me.ButtonLaporanNeraca = New System.Windows.Forms.Button()
        Me.BtnLaporanLabaRugi = New System.Windows.Forms.Button()
        Me.BtnLaporanUntungRugi = New System.Windows.Forms.Button()
        Me.BtnLaporanUtangDagang = New System.Windows.Forms.Button()
        Me.BtnLaporanPiutangDagang = New System.Windows.Forms.Button()
        Me.BtnJurnalUmum = New System.Windows.Forms.Button()
        Me.BtnBukuBesar = New System.Windows.Forms.Button()
        Me.BtnInputJurnal = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(274, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "HALAMAN UTAMA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(233, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(353, 36)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "APOTEK ALAM SEHAT"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(664, 107)
        Me.Panel1.TabIndex = 23
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(220, 72)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BtnLogout
        '
        Me.BtnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.Location = New System.Drawing.Point(260, 323)
        Me.BtnLogout.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(150, 36)
        Me.BtnLogout.TabIndex = 24
        Me.BtnLogout.Text = "LOGOUT"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'BtnJurnalPenjualan
        '
        Me.BtnJurnalPenjualan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnJurnalPenjualan.Location = New System.Drawing.Point(174, 180)
        Me.BtnJurnalPenjualan.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnJurnalPenjualan.Name = "BtnJurnalPenjualan"
        Me.BtnJurnalPenjualan.Size = New System.Drawing.Size(150, 69)
        Me.BtnJurnalPenjualan.TabIndex = 5
        Me.BtnJurnalPenjualan.Text = "LAPORAN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "JURNAL PENJUALAN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnJurnalPenjualan.UseVisualStyleBackColor = True
        '
        'BtnJurnalPembelian
        '
        Me.BtnJurnalPembelian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnJurnalPembelian.Location = New System.Drawing.Point(9, 180)
        Me.BtnJurnalPembelian.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnJurnalPembelian.Name = "BtnJurnalPembelian"
        Me.BtnJurnalPembelian.Size = New System.Drawing.Size(150, 69)
        Me.BtnJurnalPembelian.TabIndex = 4
        Me.BtnJurnalPembelian.Text = "LAPORAN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "JURNAL PEMBELIAN"
        Me.BtnJurnalPembelian.UseVisualStyleBackColor = True
        '
        'BtnJurnalPengeluaranKas
        '
        Me.BtnJurnalPengeluaranKas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnJurnalPengeluaranKas.Location = New System.Drawing.Point(503, 180)
        Me.BtnJurnalPengeluaranKas.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnJurnalPengeluaranKas.Name = "BtnJurnalPengeluaranKas"
        Me.BtnJurnalPengeluaranKas.Size = New System.Drawing.Size(150, 69)
        Me.BtnJurnalPengeluaranKas.TabIndex = 7
        Me.BtnJurnalPengeluaranKas.Text = "LAPORAN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "JURNAL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PENGELUARAN KAS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnJurnalPengeluaranKas.UseVisualStyleBackColor = True
        '
        'BtnJurnalPenerimaanKas
        '
        Me.BtnJurnalPenerimaanKas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnJurnalPenerimaanKas.Location = New System.Drawing.Point(338, 183)
        Me.BtnJurnalPenerimaanKas.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnJurnalPenerimaanKas.Name = "BtnJurnalPenerimaanKas"
        Me.BtnJurnalPenerimaanKas.Size = New System.Drawing.Size(150, 69)
        Me.BtnJurnalPenerimaanKas.TabIndex = 6
        Me.BtnJurnalPenerimaanKas.Text = "LAPORAN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "JURNAL " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PENERIMAAN KAS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnJurnalPenerimaanKas.UseVisualStyleBackColor = True
        '
        'ButtonLaporanNeraca
        '
        Me.ButtonLaporanNeraca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLaporanNeraca.Location = New System.Drawing.Point(503, 112)
        Me.ButtonLaporanNeraca.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonLaporanNeraca.Name = "ButtonLaporanNeraca"
        Me.ButtonLaporanNeraca.Size = New System.Drawing.Size(150, 65)
        Me.ButtonLaporanNeraca.TabIndex = 3
        Me.ButtonLaporanNeraca.Text = "LAPORAN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NERACA"
        Me.ButtonLaporanNeraca.UseVisualStyleBackColor = True
        '
        'BtnLaporanLabaRugi
        '
        Me.BtnLaporanLabaRugi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLaporanLabaRugi.Location = New System.Drawing.Point(338, 115)
        Me.BtnLaporanLabaRugi.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnLaporanLabaRugi.Name = "BtnLaporanLabaRugi"
        Me.BtnLaporanLabaRugi.Size = New System.Drawing.Size(150, 65)
        Me.BtnLaporanLabaRugi.TabIndex = 2
        Me.BtnLaporanLabaRugi.Text = "LAPORAN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "LABA RUGI"
        Me.BtnLaporanLabaRugi.UseVisualStyleBackColor = True
        '
        'BtnLaporanUntungRugi
        '
        Me.BtnLaporanUntungRugi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLaporanUntungRugi.Location = New System.Drawing.Point(503, 253)
        Me.BtnLaporanUntungRugi.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnLaporanUntungRugi.Name = "BtnLaporanUntungRugi"
        Me.BtnLaporanUntungRugi.Size = New System.Drawing.Size(150, 65)
        Me.BtnLaporanUntungRugi.TabIndex = 11
        Me.BtnLaporanUntungRugi.Text = "LAPORAN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "UNTUNG RUGI"
        Me.BtnLaporanUntungRugi.UseVisualStyleBackColor = True
        '
        'BtnLaporanUtangDagang
        '
        Me.BtnLaporanUtangDagang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLaporanUtangDagang.Location = New System.Drawing.Point(338, 255)
        Me.BtnLaporanUtangDagang.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnLaporanUtangDagang.Name = "BtnLaporanUtangDagang"
        Me.BtnLaporanUtangDagang.Size = New System.Drawing.Size(150, 65)
        Me.BtnLaporanUtangDagang.TabIndex = 10
        Me.BtnLaporanUtangDagang.Text = "LAPORAN " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "UTANG DAGANG"
        Me.BtnLaporanUtangDagang.UseVisualStyleBackColor = True
        '
        'BtnLaporanPiutangDagang
        '
        Me.BtnLaporanPiutangDagang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLaporanPiutangDagang.Location = New System.Drawing.Point(174, 253)
        Me.BtnLaporanPiutangDagang.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnLaporanPiutangDagang.Name = "BtnLaporanPiutangDagang"
        Me.BtnLaporanPiutangDagang.Size = New System.Drawing.Size(150, 65)
        Me.BtnLaporanPiutangDagang.TabIndex = 9
        Me.BtnLaporanPiutangDagang.Text = "LAPORAN PIUTANG"
        Me.BtnLaporanPiutangDagang.UseVisualStyleBackColor = True
        '
        'BtnJurnalUmum
        '
        Me.BtnJurnalUmum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnJurnalUmum.Location = New System.Drawing.Point(9, 253)
        Me.BtnJurnalUmum.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnJurnalUmum.Name = "BtnJurnalUmum"
        Me.BtnJurnalUmum.Size = New System.Drawing.Size(150, 65)
        Me.BtnJurnalUmum.TabIndex = 8
        Me.BtnJurnalUmum.Text = "JURNAL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "UMUM"
        Me.BtnJurnalUmum.UseVisualStyleBackColor = True
        '
        'BtnBukuBesar
        '
        Me.BtnBukuBesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBukuBesar.Location = New System.Drawing.Point(174, 112)
        Me.BtnBukuBesar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBukuBesar.Name = "BtnBukuBesar"
        Me.BtnBukuBesar.Size = New System.Drawing.Size(150, 65)
        Me.BtnBukuBesar.TabIndex = 1
        Me.BtnBukuBesar.Text = "BUKU" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BESAR"
        Me.BtnBukuBesar.UseVisualStyleBackColor = True
        '
        'BtnInputJurnal
        '
        Me.BtnInputJurnal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInputJurnal.Location = New System.Drawing.Point(9, 112)
        Me.BtnInputJurnal.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnInputJurnal.Name = "BtnInputJurnal"
        Me.BtnInputJurnal.Size = New System.Drawing.Size(150, 65)
        Me.BtnInputJurnal.TabIndex = 0
        Me.BtnInputJurnal.Text = "INPUT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "JURNAL"
        Me.BtnInputJurnal.UseVisualStyleBackColor = True
        '
        'FUser_Akuntan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(662, 368)
        Me.Controls.Add(Me.BtnLaporanUntungRugi)
        Me.Controls.Add(Me.BtnLaporanUtangDagang)
        Me.Controls.Add(Me.BtnLaporanPiutangDagang)
        Me.Controls.Add(Me.BtnJurnalUmum)
        Me.Controls.Add(Me.BtnJurnalPengeluaranKas)
        Me.Controls.Add(Me.BtnJurnalPenerimaanKas)
        Me.Controls.Add(Me.ButtonLaporanNeraca)
        Me.Controls.Add(Me.BtnLaporanLabaRugi)
        Me.Controls.Add(Me.BtnJurnalPenjualan)
        Me.Controls.Add(Me.BtnJurnalPembelian)
        Me.Controls.Add(Me.BtnBukuBesar)
        Me.Controls.Add(Me.BtnInputJurnal)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnLogout)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FUser_Akuntan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HALAMAN UTAMA APOTEK ALAM SEHAT"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnLogout As System.Windows.Forms.Button
    Friend WithEvents BtnJurnalPenjualan As System.Windows.Forms.Button
    Friend WithEvents BtnJurnalPembelian As System.Windows.Forms.Button
    Friend WithEvents BtnJurnalPengeluaranKas As System.Windows.Forms.Button
    Friend WithEvents BtnJurnalPenerimaanKas As System.Windows.Forms.Button
    Friend WithEvents ButtonLaporanNeraca As System.Windows.Forms.Button
    Friend WithEvents BtnLaporanLabaRugi As System.Windows.Forms.Button
    Friend WithEvents BtnLaporanUntungRugi As System.Windows.Forms.Button
    Friend WithEvents BtnLaporanUtangDagang As System.Windows.Forms.Button
    Friend WithEvents BtnLaporanPiutangDagang As System.Windows.Forms.Button
    Friend WithEvents BtnJurnalUmum As System.Windows.Forms.Button
    Friend WithEvents BtnBukuBesar As System.Windows.Forms.Button
    Friend WithEvents BtnInputJurnal As System.Windows.Forms.Button
End Class
