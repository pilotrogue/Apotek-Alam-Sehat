<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPm_CariJurnalPembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FPm_CariJurnalPembelian))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnHome = New System.Windows.Forms.Button()
        Me.BtnTampilkan = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.tglAkhirDTP = New System.Windows.Forms.DateTimePicker()
        Me.tglAwalDTP = New System.Windows.Forms.DateTimePicker()
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
        Me.Label1.Location = New System.Drawing.Point(352, 18)
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
        Me.Panel1.Location = New System.Drawing.Point(-3, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(885, 132)
        Me.Panel1.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.BtnHome.Size = New System.Drawing.Size(123, 38)
        Me.BtnHome.TabIndex = 3
        Me.BtnHome.Text = "Tutup"
        Me.BtnHome.UseVisualStyleBackColor = True
        '
        'BtnTampilkan
        '
        Me.BtnTampilkan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTampilkan.Location = New System.Drawing.Point(317, 385)
        Me.BtnTampilkan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnTampilkan.Name = "BtnTampilkan"
        Me.BtnTampilkan.Size = New System.Drawing.Size(123, 38)
        Me.BtnTampilkan.TabIndex = 1
        Me.BtnTampilkan.Text = "Tampilkan"
        Me.BtnTampilkan.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(185, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 24)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Tanggal Akhir"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(185, 190)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(125, 24)
        Me.Label.TabIndex = 44
        Me.Label.Text = "Tanggal Awal"
        '
        'tglAkhirDTP
        '
        Me.tglAkhirDTP.CustomFormat = "MM/dd/yyyy"
        Me.tglAkhirDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tglAkhirDTP.Location = New System.Drawing.Point(347, 240)
        Me.tglAkhirDTP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tglAkhirDTP.Name = "tglAkhirDTP"
        Me.tglAkhirDTP.Size = New System.Drawing.Size(265, 22)
        Me.tglAkhirDTP.TabIndex = 1
        '
        'tglAwalDTP
        '
        Me.tglAwalDTP.CustomFormat = "MM/dd/yyyy"
        Me.tglAwalDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tglAwalDTP.Location = New System.Drawing.Point(347, 187)
        Me.tglAwalDTP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tglAwalDTP.Name = "tglAwalDTP"
        Me.tglAwalDTP.Size = New System.Drawing.Size(265, 22)
        Me.tglAwalDTP.TabIndex = 0
        '
        'FPm_CariJurnalPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(883, 453)
        Me.Controls.Add(Me.tglAkhirDTP)
        Me.Controls.Add(Me.tglAwalDTP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.BtnHome)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnTampilkan)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FPm_CariJurnalPembelian"
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents tglAkhirDTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents tglAwalDTP As System.Windows.Forms.DateTimePicker
End Class
