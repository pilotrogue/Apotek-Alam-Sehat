<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Input
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Input))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnInputKaryawan = New System.Windows.Forms.Button()
        Me.BtnInputSupplier = New System.Windows.Forms.Button()
        Me.BtnInputPelunasan = New System.Windows.Forms.Button()
        Me.BtnHome = New System.Windows.Forms.Button()
        Me.BtnInputPembelian = New System.Windows.Forms.Button()
        Me.BtnInputObat = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(886, 132)
        Me.Panel1.TabIndex = 2
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
        Me.Label1.Location = New System.Drawing.Point(410, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MENU INPUT"
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
        'btnInputKaryawan
        '
        Me.btnInputKaryawan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInputKaryawan.Location = New System.Drawing.Point(84, 183)
        Me.btnInputKaryawan.Name = "btnInputKaryawan"
        Me.btnInputKaryawan.Size = New System.Drawing.Size(200, 86)
        Me.btnInputKaryawan.TabIndex = 4
        Me.btnInputKaryawan.Text = "DATA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "KARYAWAN"
        Me.btnInputKaryawan.UseVisualStyleBackColor = True
        '
        'BtnInputSupplier
        '
        Me.BtnInputSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInputSupplier.Location = New System.Drawing.Point(341, 183)
        Me.BtnInputSupplier.Name = "BtnInputSupplier"
        Me.BtnInputSupplier.Size = New System.Drawing.Size(200, 86)
        Me.BtnInputSupplier.TabIndex = 5
        Me.BtnInputSupplier.Text = "DATA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SUPPLIER"
        Me.BtnInputSupplier.UseVisualStyleBackColor = True
        '
        'BtnInputPelunasan
        '
        Me.BtnInputPelunasan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInputPelunasan.Location = New System.Drawing.Point(599, 183)
        Me.BtnInputPelunasan.Name = "BtnInputPelunasan"
        Me.BtnInputPelunasan.Size = New System.Drawing.Size(200, 86)
        Me.BtnInputPelunasan.TabIndex = 6
        Me.BtnInputPelunasan.Text = "DATA PELUNASAN"
        Me.BtnInputPelunasan.UseVisualStyleBackColor = True
        '
        'BtnHome
        '
        Me.BtnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHome.Location = New System.Drawing.Point(599, 293)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(200, 86)
        Me.BtnHome.TabIndex = 9
        Me.BtnHome.Text = "HALAMAN " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "UTAMA"
        Me.BtnHome.UseVisualStyleBackColor = True
        '
        'BtnInputPembelian
        '
        Me.BtnInputPembelian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInputPembelian.Location = New System.Drawing.Point(341, 293)
        Me.BtnInputPembelian.Name = "BtnInputPembelian"
        Me.BtnInputPembelian.Size = New System.Drawing.Size(200, 86)
        Me.BtnInputPembelian.TabIndex = 8
        Me.BtnInputPembelian.Text = "DATA " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PEMBELIAN"
        Me.BtnInputPembelian.UseVisualStyleBackColor = True
        '
        'BtnInputObat
        '
        Me.BtnInputObat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInputObat.Location = New System.Drawing.Point(84, 293)
        Me.BtnInputObat.Name = "BtnInputObat"
        Me.BtnInputObat.Size = New System.Drawing.Size(200, 86)
        Me.BtnInputObat.TabIndex = 7
        Me.BtnInputObat.Text = "DATA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "OBAT"
        Me.BtnInputObat.UseVisualStyleBackColor = True
        '
        'F_Input
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(882, 453)
        Me.Controls.Add(Me.BtnHome)
        Me.Controls.Add(Me.BtnInputPembelian)
        Me.Controls.Add(Me.BtnInputObat)
        Me.Controls.Add(Me.BtnInputPelunasan)
        Me.Controls.Add(Me.BtnInputSupplier)
        Me.Controls.Add(Me.btnInputKaryawan)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_Input"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INPUT"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnInputKaryawan As System.Windows.Forms.Button
    Friend WithEvents BtnInputSupplier As System.Windows.Forms.Button
    Friend WithEvents BtnInputPelunasan As System.Windows.Forms.Button
    Friend WithEvents BtnHome As System.Windows.Forms.Button
    Friend WithEvents BtnInputPembelian As System.Windows.Forms.Button
    Friend WithEvents BtnInputObat As System.Windows.Forms.Button
End Class
