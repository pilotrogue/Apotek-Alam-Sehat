<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Jurnal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Jurnal))
        Me.BtnHome = New System.Windows.Forms.Button()
        Me.BtnJurnalPengeluaranKas = New System.Windows.Forms.Button()
        Me.BtnJurnalPembelian = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnHome
        '
        Me.BtnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHome.Location = New System.Drawing.Point(346, 308)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(200, 86)
        Me.BtnHome.TabIndex = 8
        Me.BtnHome.Text = "HALAMAN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "UTAMA"
        Me.BtnHome.UseVisualStyleBackColor = True
        '
        'BtnJurnalPengeluaranKas
        '
        Me.BtnJurnalPengeluaranKas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnJurnalPengeluaranKas.Location = New System.Drawing.Point(464, 194)
        Me.BtnJurnalPengeluaranKas.Name = "BtnJurnalPengeluaranKas"
        Me.BtnJurnalPengeluaranKas.Size = New System.Drawing.Size(200, 86)
        Me.BtnJurnalPengeluaranKas.TabIndex = 7
        Me.BtnJurnalPengeluaranKas.Text = "PENGELUARAN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "KAS"
        Me.BtnJurnalPengeluaranKas.UseVisualStyleBackColor = True
        '
        'BtnJurnalPembelian
        '
        Me.BtnJurnalPembelian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnJurnalPembelian.Location = New System.Drawing.Point(220, 194)
        Me.BtnJurnalPembelian.Name = "BtnJurnalPembelian"
        Me.BtnJurnalPembelian.Size = New System.Drawing.Size(200, 86)
        Me.BtnJurnalPembelian.TabIndex = 6
        Me.BtnJurnalPembelian.Text = "JURNAL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PEMBELIAN"
        Me.BtnJurnalPembelian.UseVisualStyleBackColor = True
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
        Me.Panel1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(388, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MENU JURNAL"
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
        'F_Jurnal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(882, 453)
        Me.Controls.Add(Me.BtnHome)
        Me.Controls.Add(Me.BtnJurnalPengeluaranKas)
        Me.Controls.Add(Me.BtnJurnalPembelian)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_Jurnal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JURNAL"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnHome As System.Windows.Forms.Button
    Friend WithEvents BtnJurnalPengeluaranKas As System.Windows.Forms.Button
    Friend WithEvents BtnJurnalPembelian As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
