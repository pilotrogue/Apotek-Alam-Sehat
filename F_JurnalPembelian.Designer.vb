<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_JurnalPembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_JurnalPembelian))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnHome = New System.Windows.Forms.Button()
        Me.BtnTampilkan = New System.Windows.Forms.Button()
        Me.TxtTanggalAkhir = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTglAwal = New System.Windows.Forms.TextBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(311, 57)
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
        Me.Label1.Location = New System.Drawing.Point(352, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "JURNAL PEMBELIAN"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(886, 132)
        Me.Panel1.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(293, 89)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BtnHome
        '
        Me.BtnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHome.Location = New System.Drawing.Point(491, 385)
        Me.BtnHome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(122, 38)
        Me.BtnHome.TabIndex = 43
        Me.BtnHome.Text = "Tutup"
        Me.BtnHome.UseVisualStyleBackColor = True
        '
        'BtnTampilkan
        '
        Me.BtnTampilkan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTampilkan.Location = New System.Drawing.Point(317, 385)
        Me.BtnTampilkan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnTampilkan.Name = "BtnTampilkan"
        Me.BtnTampilkan.Size = New System.Drawing.Size(122, 38)
        Me.BtnTampilkan.TabIndex = 42
        Me.BtnTampilkan.Text = "Tampilkan"
        Me.BtnTampilkan.UseVisualStyleBackColor = True
        '
        'TxtTanggalAkhir
        '
        Me.TxtTanggalAkhir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTanggalAkhir.Location = New System.Drawing.Point(391, 243)
        Me.TxtTanggalAkhir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtTanggalAkhir.Name = "TxtTanggalAkhir"
        Me.TxtTanggalAkhir.Size = New System.Drawing.Size(307, 28)
        Me.TxtTanggalAkhir.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(185, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 24)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Tanggal Akhir"
        '
        'TxtTglAwal
        '
        Me.TxtTglAwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTglAwal.Location = New System.Drawing.Point(391, 189)
        Me.TxtTglAwal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtTglAwal.Name = "TxtTglAwal"
        Me.TxtTglAwal.Size = New System.Drawing.Size(307, 28)
        Me.TxtTglAwal.TabIndex = 45
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(185, 189)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(125, 24)
        Me.Label.TabIndex = 44
        Me.Label.Text = "Tanggal Awal"
        '
        'F_JurnalPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(882, 453)
        Me.Controls.Add(Me.TxtTanggalAkhir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTglAwal)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.BtnHome)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnTampilkan)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_JurnalPembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JURNAL PEMBELIAN"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnHome As System.Windows.Forms.Button
    Friend WithEvents BtnTampilkan As System.Windows.Forms.Button
    Friend WithEvents TxtTanggalAkhir As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTglAwal As System.Windows.Forms.TextBox
    Friend WithEvents Label As System.Windows.Forms.Label
End Class
