<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tambah
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
        Me.DateTimePickerTL = New System.Windows.Forms.DateTimePicker
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.jk_cb = New System.Windows.Forms.ComboBox
        Me.Cancel_tambah = New System.Windows.Forms.Button
        Me.Label16 = New System.Windows.Forms.Label
        Me.Submit = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.pass_tb = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.alamat_tb = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.tempat_lahir_tb = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.nama_tb = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.id_pegawai_tb = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.CekID = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePickerTL
        '
        Me.DateTimePickerTL.Location = New System.Drawing.Point(154, 163)
        Me.DateTimePickerTL.Name = "DateTimePickerTL"
        Me.DateTimePickerTL.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerTL.TabIndex = 55
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(129, 111)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(10, 13)
        Me.Label18.TabIndex = 54
        Me.Label18.Text = ":"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(33, 111)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 13)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "Jenis Kelamin"
        '
        'jk_cb
        '
        Me.jk_cb.FormattingEnabled = True
        Me.jk_cb.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.jk_cb.Location = New System.Drawing.Point(154, 108)
        Me.jk_cb.Name = "jk_cb"
        Me.jk_cb.Size = New System.Drawing.Size(112, 21)
        Me.jk_cb.TabIndex = 52
        '
        'Cancel_tambah
        '
        Me.Cancel_tambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_tambah.Location = New System.Drawing.Point(231, 348)
        Me.Cancel_tambah.Name = "Cancel_tambah"
        Me.Cancel_tambah.Size = New System.Drawing.Size(124, 47)
        Me.Cancel_tambah.TabIndex = 51
        Me.Cancel_tambah.Text = "Cancel"
        Me.Cancel_tambah.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(171, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(170, 20)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "TAMBAH PEGAWAI"
        '
        'Submit
        '
        Me.Submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit.Location = New System.Drawing.Point(361, 348)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(135, 47)
        Me.Submit.TabIndex = 49
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(129, 299)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(10, 13)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(33, 299)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 13)
        Me.Label15.TabIndex = 47
        Me.Label15.Text = "Password"
        '
        'pass_tb
        '
        Me.pass_tb.Location = New System.Drawing.Point(154, 296)
        Me.pass_tb.Name = "pass_tb"
        Me.pass_tb.Size = New System.Drawing.Size(201, 20)
        Me.pass_tb.TabIndex = 46
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(129, 192)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(10, 13)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(33, 192)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 13)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Alamat"
        '
        'alamat_tb
        '
        Me.alamat_tb.Location = New System.Drawing.Point(154, 189)
        Me.alamat_tb.Multiline = True
        Me.alamat_tb.Name = "alamat_tb"
        Me.alamat_tb.Size = New System.Drawing.Size(291, 101)
        Me.alamat_tb.TabIndex = 43
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(129, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 13)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(129, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(129, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(129, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(33, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Tanggal Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(33, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Tempat Lahir"
        '
        'tempat_lahir_tb
        '
        Me.tempat_lahir_tb.Location = New System.Drawing.Point(154, 135)
        Me.tempat_lahir_tb.Name = "tempat_lahir_tb"
        Me.tempat_lahir_tb.Size = New System.Drawing.Size(201, 20)
        Me.tempat_lahir_tb.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(33, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Nama"
        '
        'nama_tb
        '
        Me.nama_tb.Location = New System.Drawing.Point(154, 82)
        Me.nama_tb.Name = "nama_tb"
        Me.nama_tb.Size = New System.Drawing.Size(201, 20)
        Me.nama_tb.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(33, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "id_pegawai"
        '
        'id_pegawai_tb
        '
        Me.id_pegawai_tb.Location = New System.Drawing.Point(154, 56)
        Me.id_pegawai_tb.Name = "id_pegawai_tb"
        Me.id_pegawai_tb.Size = New System.Drawing.Size(70, 20)
        Me.id_pegawai_tb.TabIndex = 32
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(540, 433)
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'CekID
        '
        Me.CekID.Location = New System.Drawing.Point(231, 41)
        Me.CekID.Name = "CekID"
        Me.CekID.Size = New System.Drawing.Size(101, 35)
        Me.CekID.TabIndex = 57
        Me.CekID.Text = "Cek List ID Pegawai"
        Me.CekID.UseVisualStyleBackColor = True
        '
        'Tambah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 414)
        Me.Controls.Add(Me.CekID)
        Me.Controls.Add(Me.DateTimePickerTL)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.jk_cb)
        Me.Controls.Add(Me.Cancel_tambah)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.pass_tb)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.alamat_tb)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tempat_lahir_tb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nama_tb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.id_pegawai_tb)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Tambah"
        Me.Text = "Tambah"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePickerTL As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents jk_cb As System.Windows.Forms.ComboBox
    Friend WithEvents Cancel_tambah As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Submit As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents pass_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents alamat_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tempat_lahir_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nama_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents id_pegawai_tb As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CekID As System.Windows.Forms.Button
End Class
