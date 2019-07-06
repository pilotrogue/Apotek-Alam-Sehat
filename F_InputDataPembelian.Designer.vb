<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_InputDataPembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_InputDataPembelian))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.TxtNoPembelian = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTglPembelian = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNoBukti = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTglJatuhTempo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNamaSupplier = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtNamaKaryawan = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtKeterangan = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtJenisPembelian = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.TxtTotalPembelian = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtUangDibayar = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtTotalHutang = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnHome = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(438, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(438, 44)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "APOTEK ALAM SEHAT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(439, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(428, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "INPUT DATA PEMBELIAN"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(390, 89)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1181, 132)
        Me.Panel1.TabIndex = 38
        '
        'BtnTambah
        '
        Me.BtnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.Location = New System.Drawing.Point(15, 802)
        Me.BtnTambah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(115, 38)
        Me.BtnTambah.TabIndex = 43
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'TxtNoPembelian
        '
        Me.TxtNoPembelian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNoPembelian.Location = New System.Drawing.Point(218, 145)
        Me.TxtNoPembelian.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNoPembelian.Name = "TxtNoPembelian"
        Me.TxtNoPembelian.Size = New System.Drawing.Size(185, 30)
        Me.TxtNoPembelian.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 25)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "No Pembelian"
        '
        'TxtTglPembelian
        '
        Me.TxtTglPembelian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTglPembelian.Location = New System.Drawing.Point(218, 183)
        Me.TxtTglPembelian.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtTglPembelian.Name = "TxtTglPembelian"
        Me.TxtTglPembelian.Size = New System.Drawing.Size(185, 30)
        Me.TxtTglPembelian.TabIndex = 45
        Me.TxtTglPembelian.Text = "12/12/2019"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 25)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Tanggal Pembelian"
        '
        'TxtNoBukti
        '
        Me.TxtNoBukti.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNoBukti.Location = New System.Drawing.Point(548, 145)
        Me.TxtNoBukti.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNoBukti.Name = "TxtNoBukti"
        Me.TxtNoBukti.Size = New System.Drawing.Size(185, 30)
        Me.TxtNoBukti.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(442, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 25)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "No Bukti"
        '
        'TxtTglJatuhTempo
        '
        Me.TxtTglJatuhTempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTglJatuhTempo.Location = New System.Drawing.Point(792, 180)
        Me.TxtTglJatuhTempo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtTglJatuhTempo.Name = "TxtTglJatuhTempo"
        Me.TxtTglJatuhTempo.Size = New System.Drawing.Size(200, 30)
        Me.TxtTglJatuhTempo.TabIndex = 44
        Me.TxtTglJatuhTempo.Text = "12/12/2019"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(787, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(205, 25)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Tanggal Jatuh Tempo"
        '
        'TxtNamaSupplier
        '
        Me.TxtNamaSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNamaSupplier.Location = New System.Drawing.Point(218, 223)
        Me.TxtNamaSupplier.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNamaSupplier.Name = "TxtNamaSupplier"
        Me.TxtNamaSupplier.Size = New System.Drawing.Size(405, 30)
        Me.TxtNamaSupplier.TabIndex = 49
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 25)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Nama Supplier"
        '
        'TxtNamaKaryawan
        '
        Me.TxtNamaKaryawan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNamaKaryawan.Location = New System.Drawing.Point(218, 301)
        Me.TxtNamaKaryawan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNamaKaryawan.Name = "TxtNamaKaryawan"
        Me.TxtNamaKaryawan.Size = New System.Drawing.Size(218, 30)
        Me.TxtNamaKaryawan.TabIndex = 51
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 301)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(157, 25)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Nama Karyawan"
        '
        'TxtKeterangan
        '
        Me.TxtKeterangan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKeterangan.Location = New System.Drawing.Point(218, 262)
        Me.TxtKeterangan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtKeterangan.Name = "TxtKeterangan"
        Me.TxtKeterangan.Size = New System.Drawing.Size(515, 30)
        Me.TxtKeterangan.TabIndex = 53
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 262)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 25)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Keterangan"
        '
        'TxtJenisPembelian
        '
        Me.TxtJenisPembelian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtJenisPembelian.Location = New System.Drawing.Point(604, 301)
        Me.TxtJenisPembelian.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtJenisPembelian.Name = "TxtJenisPembelian"
        Me.TxtJenisPembelian.Size = New System.Drawing.Size(129, 30)
        Me.TxtJenisPembelian.TabIndex = 55
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(442, 301)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(156, 25)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Jenis Pembelian"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 337)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(158, 25)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Detail Pembelian"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(17, 374)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RowTemplate.Height = 24
        Me.DGV.Size = New System.Drawing.Size(1144, 267)
        Me.DGV.TabIndex = 57
        '
        'TxtTotalPembelian
        '
        Me.TxtTotalPembelian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalPembelian.Location = New System.Drawing.Point(943, 651)
        Me.TxtTotalPembelian.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtTotalPembelian.Name = "TxtTotalPembelian"
        Me.TxtTotalPembelian.Size = New System.Drawing.Size(218, 30)
        Me.TxtTotalPembelian.TabIndex = 59
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(737, 651)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 25)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Total Utang"
        '
        'TxtUangDibayar
        '
        Me.TxtUangDibayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUangDibayar.Location = New System.Drawing.Point(943, 687)
        Me.TxtUangDibayar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtUangDibayar.Name = "TxtUangDibayar"
        Me.TxtUangDibayar.Size = New System.Drawing.Size(218, 30)
        Me.TxtUangDibayar.TabIndex = 61
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(737, 687)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(123, 25)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "Pembayaran"
        '
        'TxtTotalHutang
        '
        Me.TxtTotalHutang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalHutang.Location = New System.Drawing.Point(943, 722)
        Me.TxtTotalHutang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtTotalHutang.Name = "TxtTotalHutang"
        Me.TxtTotalHutang.Size = New System.Drawing.Size(218, 30)
        Me.TxtTotalHutang.TabIndex = 63
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(737, 722)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 25)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = "Sisa Utang"
        '
        'BtnHapus
        '
        Me.BtnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.Location = New System.Drawing.Point(208, 804)
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(115, 38)
        Me.BtnHapus.TabIndex = 65
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnHome
        '
        Me.BtnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHome.Location = New System.Drawing.Point(403, 804)
        Me.BtnHome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(115, 38)
        Me.BtnHome.TabIndex = 64
        Me.BtnHome.Text = "Tutup"
        Me.BtnHome.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(14, 667)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(462, 69)
        Me.Label15.TabIndex = 66
        Me.Label15.Text = "BELUM LUNAS"
        '
        'F_InputPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1182, 853)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnHome)
        Me.Controls.Add(Me.TxtTotalHutang)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtUangDibayar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtTotalPembelian)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtJenisPembelian)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtKeterangan)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtNamaKaryawan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtNamaSupplier)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtTglJatuhTempo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtNoBukti)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTglPembelian)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.TxtNoPembelian)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_InputPembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PEMBELIAN"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents TxtNoPembelian As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtTglPembelian As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtNoBukti As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtTglJatuhTempo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtNamaSupplier As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtNamaKaryawan As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtJenisPembelian As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents TxtTotalPembelian As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtUangDibayar As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtTotalHutang As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnHome As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
