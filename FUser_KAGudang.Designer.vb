<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FUser_KAGudang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FUser_KAGudang))
        Me.BtnInputObat = New System.Windows.Forms.Button()
        Me.BtnInputSupplier = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnLaporanStokBarang = New System.Windows.Forms.Button()
        Me.BtnUpdateDataObat = New System.Windows.Forms.Button()
        Me.BtnUpdateDataSupplier = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnInputObat
        '
        Me.BtnInputObat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInputObat.Location = New System.Drawing.Point(261, 125)
        Me.BtnInputObat.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnInputObat.Name = "BtnInputObat"
        Me.BtnInputObat.Size = New System.Drawing.Size(150, 73)
        Me.BtnInputObat.TabIndex = 1
        Me.BtnInputObat.Text = "INPUT DATA " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "OBAT"
        Me.BtnInputObat.UseVisualStyleBackColor = True
        '
        'BtnInputSupplier
        '
        Me.BtnInputSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInputSupplier.Location = New System.Drawing.Point(36, 125)
        Me.BtnInputSupplier.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnInputSupplier.Name = "BtnInputSupplier"
        Me.BtnInputSupplier.Size = New System.Drawing.Size(150, 73)
        Me.BtnInputSupplier.TabIndex = 0
        Me.BtnInputSupplier.Text = "INPUT DATA SUPPLIER"
        Me.BtnInputSupplier.UseVisualStyleBackColor = True
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
        'BtnLogout
        '
        Me.BtnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.Location = New System.Drawing.Point(261, 321)
        Me.BtnLogout.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(150, 36)
        Me.BtnLogout.TabIndex = 3
        Me.BtnLogout.Text = "LOGOUT"
        Me.BtnLogout.UseVisualStyleBackColor = True
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
        Me.Panel1.TabIndex = 17
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
        'BtnLaporanStokBarang
        '
        Me.BtnLaporanStokBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLaporanStokBarang.Location = New System.Drawing.Point(482, 125)
        Me.BtnLaporanStokBarang.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnLaporanStokBarang.Name = "BtnLaporanStokBarang"
        Me.BtnLaporanStokBarang.Size = New System.Drawing.Size(150, 73)
        Me.BtnLaporanStokBarang.TabIndex = 2
        Me.BtnLaporanStokBarang.Text = "LAPORAN STOK BARANG"
        Me.BtnLaporanStokBarang.UseVisualStyleBackColor = True
        '
        'BtnUpdateDataObat
        '
        Me.BtnUpdateDataObat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateDataObat.Location = New System.Drawing.Point(261, 216)
        Me.BtnUpdateDataObat.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnUpdateDataObat.Name = "BtnUpdateDataObat"
        Me.BtnUpdateDataObat.Size = New System.Drawing.Size(150, 73)
        Me.BtnUpdateDataObat.TabIndex = 19
        Me.BtnUpdateDataObat.Text = "UPDATE DATA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " OBAT"
        Me.BtnUpdateDataObat.UseVisualStyleBackColor = True
        '
        'BtnUpdateDataSupplier
        '
        Me.BtnUpdateDataSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateDataSupplier.Location = New System.Drawing.Point(36, 216)
        Me.BtnUpdateDataSupplier.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnUpdateDataSupplier.Name = "BtnUpdateDataSupplier"
        Me.BtnUpdateDataSupplier.Size = New System.Drawing.Size(150, 73)
        Me.BtnUpdateDataSupplier.TabIndex = 18
        Me.BtnUpdateDataSupplier.Text = "UPDATE DATA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " SUPPLIER"
        Me.BtnUpdateDataSupplier.UseVisualStyleBackColor = True
        '
        'FUser_KAGudang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(662, 368)
        Me.Controls.Add(Me.BtnUpdateDataObat)
        Me.Controls.Add(Me.BtnUpdateDataSupplier)
        Me.Controls.Add(Me.BtnLaporanStokBarang)
        Me.Controls.Add(Me.BtnInputObat)
        Me.Controls.Add(Me.BtnInputSupplier)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FUser_KAGudang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HALAMAN UTAMA APOTEK ALAM SEHAT"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnInputObat As System.Windows.Forms.Button
    Friend WithEvents BtnInputSupplier As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnLogout As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnLaporanStokBarang As System.Windows.Forms.Button
    Friend WithEvents BtnUpdateDataObat As System.Windows.Forms.Button
    Friend WithEvents BtnUpdateDataSupplier As System.Windows.Forms.Button
End Class
