<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_InputDataKaryawan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_InputDataKaryawan))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnHome = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.TxtIDKaryawan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNamaKaryawan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtKontakKaryawan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtUsernameKaryawan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtPasswordKaryawan = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.T_KasirTableAdapter1 = New AplikasiApotek.DB_PembelianDataSetTableAdapters.T_KasirTableAdapter()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.roleComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(257, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "INPUT DATA KARYAWAN"
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
        Me.Panel1.Size = New System.Drawing.Size(687, 107)
        Me.Panel1.TabIndex = 3
        '
        'BtnHome
        '
        Me.BtnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHome.Location = New System.Drawing.Point(352, 310)
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
        Me.BtnTambah.Location = New System.Drawing.Point(239, 310)
        Me.BtnTambah.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(86, 31)
        Me.BtnTambah.TabIndex = 5
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'TxtIDKaryawan
        '
        Me.TxtIDKaryawan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIDKaryawan.Location = New System.Drawing.Point(290, 111)
        Me.TxtIDKaryawan.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtIDKaryawan.Name = "TxtIDKaryawan"
        Me.TxtIDKaryawan.ReadOnly = True
        Me.TxtIDKaryawan.Size = New System.Drawing.Size(231, 26)
        Me.TxtIDKaryawan.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(135, 111)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "ID Akun"
        '
        'TxtNamaKaryawan
        '
        Me.TxtNamaKaryawan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNamaKaryawan.Location = New System.Drawing.Point(290, 144)
        Me.TxtNamaKaryawan.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNamaKaryawan.Name = "TxtNamaKaryawan"
        Me.TxtNamaKaryawan.Size = New System.Drawing.Size(231, 26)
        Me.TxtNamaKaryawan.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(135, 144)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nama Akun"
        '
        'TxtKontakKaryawan
        '
        Me.TxtKontakKaryawan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKontakKaryawan.Location = New System.Drawing.Point(290, 176)
        Me.TxtKontakKaryawan.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtKontakKaryawan.Name = "TxtKontakKaryawan"
        Me.TxtKontakKaryawan.Size = New System.Drawing.Size(231, 26)
        Me.TxtKontakKaryawan.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(135, 176)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Kontak"
        '
        'TxtUsernameKaryawan
        '
        Me.TxtUsernameKaryawan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsernameKaryawan.Location = New System.Drawing.Point(290, 209)
        Me.TxtUsernameKaryawan.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtUsernameKaryawan.Name = "TxtUsernameKaryawan"
        Me.TxtUsernameKaryawan.Size = New System.Drawing.Size(231, 26)
        Me.TxtUsernameKaryawan.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(135, 209)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Username"
        '
        'TxtPasswordKaryawan
        '
        Me.TxtPasswordKaryawan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPasswordKaryawan.Location = New System.Drawing.Point(290, 241)
        Me.TxtPasswordKaryawan.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPasswordKaryawan.Name = "TxtPasswordKaryawan"
        Me.TxtPasswordKaryawan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPasswordKaryawan.Size = New System.Drawing.Size(231, 26)
        Me.TxtPasswordKaryawan.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(135, 241)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 20)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Password"
        '
        'T_KasirTableAdapter1
        '
        Me.T_KasirTableAdapter1.ClearBeforeFill = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(135, 275)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 20)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Role"
        '
        'roleComboBox
        '
        Me.roleComboBox.FormattingEnabled = True
        Me.roleComboBox.Location = New System.Drawing.Point(289, 274)
        Me.roleComboBox.Name = "roleComboBox"
        Me.roleComboBox.Size = New System.Drawing.Size(232, 21)
        Me.roleComboBox.TabIndex = 4
        '
        'F_InputDataKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(684, 361)
        Me.Controls.Add(Me.roleComboBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtPasswordKaryawan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtUsernameKaryawan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtKontakKaryawan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtNamaKaryawan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnHome)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.TxtIDKaryawan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "F_InputDataKaryawan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INPUT DATA KARYAWAN"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnHome As System.Windows.Forms.Button
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents TxtIDKaryawan As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtNamaKaryawan As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtKontakKaryawan As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtUsernameKaryawan As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtPasswordKaryawan As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents T_KasirTableAdapter1 As AplikasiApotek.DB_PembelianDataSetTableAdapters.T_KasirTableAdapter
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents roleComboBox As System.Windows.Forms.ComboBox
End Class
