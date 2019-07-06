<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_InputDataObat
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_InputDataObat))
        Me.TxtHargaBeliObat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtSatuanObat = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNamaObat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnHome = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.TxtIDObat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TObatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_PembelianDataSet = New AplikasiApotek.DB_PembelianDataSet()
        Me.T_ObatTableAdapter = New AplikasiApotek.DB_PembelianDataSetTableAdapters.T_ObatTableAdapter()
        Me.TxtHargaJual = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtStokObat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TObatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_PembelianDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtHargaBeliObat
        '
        Me.TxtHargaBeliObat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHargaBeliObat.Location = New System.Drawing.Point(289, 234)
        Me.TxtHargaBeliObat.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtHargaBeliObat.Name = "TxtHargaBeliObat"
        Me.TxtHargaBeliObat.Size = New System.Drawing.Size(231, 26)
        Me.TxtHargaBeliObat.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(134, 234)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 20)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Harga Beli"
        '
        'TxtSatuanObat
        '
        Me.TxtSatuanObat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSatuanObat.Location = New System.Drawing.Point(289, 176)
        Me.TxtSatuanObat.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtSatuanObat.Name = "TxtSatuanObat"
        Me.TxtSatuanObat.Size = New System.Drawing.Size(231, 26)
        Me.TxtSatuanObat.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(134, 176)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 20)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Satuan"
        '
        'TxtNamaObat
        '
        Me.TxtNamaObat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNamaObat.Location = New System.Drawing.Point(289, 144)
        Me.TxtNamaObat.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNamaObat.Name = "TxtNamaObat"
        Me.TxtNamaObat.Size = New System.Drawing.Size(231, 26)
        Me.TxtNamaObat.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(134, 144)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Nama Obat"
        '
        'BtnHome
        '
        Me.BtnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHome.Location = New System.Drawing.Point(346, 306)
        Me.BtnHome.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(86, 31)
        Me.BtnHome.TabIndex = 6
        Me.BtnHome.Text = "Tutup"
        Me.BtnHome.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.Location = New System.Drawing.Point(237, 306)
        Me.BtnTambah.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(86, 31)
        Me.BtnTambah.TabIndex = 5
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'TxtIDObat
        '
        Me.TxtIDObat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIDObat.Location = New System.Drawing.Point(289, 111)
        Me.TxtIDObat.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtIDObat.Name = "TxtIDObat"
        Me.TxtIDObat.ReadOnly = True
        Me.TxtIDObat.Size = New System.Drawing.Size(231, 26)
        Me.TxtIDObat.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(134, 111)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "ID Obat"
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
        Me.Panel1.Size = New System.Drawing.Size(686, 107)
        Me.Panel1.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(259, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(353, 36)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "APOTEK ALAM SEHAT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(293, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "INPUT DATA OBAT"
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
        'TObatBindingSource
        '
        Me.TObatBindingSource.DataMember = "T_Obat"
        Me.TObatBindingSource.DataSource = Me.DB_PembelianDataSet
        '
        'DB_PembelianDataSet
        '
        Me.DB_PembelianDataSet.DataSetName = "DB_PembelianDataSet"
        Me.DB_PembelianDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'T_ObatTableAdapter
        '
        Me.T_ObatTableAdapter.ClearBeforeFill = True
        '
        'TxtHargaJual
        '
        Me.TxtHargaJual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHargaJual.Location = New System.Drawing.Point(289, 265)
        Me.TxtHargaJual.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtHargaJual.Name = "TxtHargaJual"
        Me.TxtHargaJual.Size = New System.Drawing.Size(231, 26)
        Me.TxtHargaJual.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(135, 265)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 20)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Harga Jual"
        '
        'TxtStokObat
        '
        Me.TxtStokObat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStokObat.Location = New System.Drawing.Point(289, 205)
        Me.TxtStokObat.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtStokObat.Name = "TxtStokObat"
        Me.TxtStokObat.Size = New System.Drawing.Size(231, 26)
        Me.TxtStokObat.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(134, 205)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 20)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Stok"
        '
        'F_InputDataObat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(684, 361)
        Me.Controls.Add(Me.TxtStokObat)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtHargaJual)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtHargaBeliObat)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtSatuanObat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtNamaObat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnHome)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.TxtIDObat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "F_InputDataObat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DATA OBAT"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TObatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_PembelianDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtHargaBeliObat As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtSatuanObat As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtNamaObat As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnHome As System.Windows.Forms.Button
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents TxtIDObat As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DB_PembelianDataSet As AplikasiApotek.DB_PembelianDataSet
    Friend WithEvents TObatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_ObatTableAdapter As AplikasiApotek.DB_PembelianDataSetTableAdapters.T_ObatTableAdapter
    Friend WithEvents TxtHargaJual As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtStokObat As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
