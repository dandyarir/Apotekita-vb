<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainHRD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainHRD))
        Me.Hapus_btn = New System.Windows.Forms.Button
        Me.Cari_cb = New System.Windows.Forms.ComboBox
        Me.Berda = New System.Windows.Forms.Label
        Me.Cari_tb = New System.Windows.Forms.TextBox
        Me.Ubah_btn = New System.Windows.Forms.Button
        Me.Tambah_Btn = New System.Windows.Forms.Button
        Me.DataGridViewPeg = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ouut = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.DataGridViewPeg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Hapus_btn
        '
        Me.Hapus_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Hapus_btn.Image = CType(resources.GetObject("Hapus_btn.Image"), System.Drawing.Image)
        Me.Hapus_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Hapus_btn.Location = New System.Drawing.Point(475, 71)
        Me.Hapus_btn.Name = "Hapus_btn"
        Me.Hapus_btn.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Hapus_btn.Size = New System.Drawing.Size(105, 33)
        Me.Hapus_btn.TabIndex = 14
        Me.Hapus_btn.Text = "HAPUS"
        Me.Hapus_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Hapus_btn.UseVisualStyleBackColor = True
        '
        'Cari_cb
        '
        Me.Cari_cb.FormattingEnabled = True
        Me.Cari_cb.Items.AddRange(New Object() {"Semua", "ID", "Nama", "Jenis kelamin", "Tempat lahir", "Tanggal lahir", "Alamat"})
        Me.Cari_cb.Location = New System.Drawing.Point(306, 125)
        Me.Cari_cb.Name = "Cari_cb"
        Me.Cari_cb.Size = New System.Drawing.Size(121, 21)
        Me.Cari_cb.TabIndex = 13
        '
        'Berda
        '
        Me.Berda.AutoSize = True
        Me.Berda.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Berda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Berda.Location = New System.Drawing.Point(211, 128)
        Me.Berda.Name = "Berda"
        Me.Berda.Size = New System.Drawing.Size(87, 13)
        Me.Berda.TabIndex = 12
        Me.Berda.Text = "Cari berdasarkan"
        '
        'Cari_tb
        '
        Me.Cari_tb.Location = New System.Drawing.Point(433, 125)
        Me.Cari_tb.Multiline = True
        Me.Cari_tb.Name = "Cari_tb"
        Me.Cari_tb.Size = New System.Drawing.Size(147, 21)
        Me.Cari_tb.TabIndex = 11
        '
        'Ubah_btn
        '
        Me.Ubah_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Ubah_btn.Image = CType(resources.GetObject("Ubah_btn.Image"), System.Drawing.Image)
        Me.Ubah_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Ubah_btn.Location = New System.Drawing.Point(359, 71)
        Me.Ubah_btn.Name = "Ubah_btn"
        Me.Ubah_btn.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Ubah_btn.Size = New System.Drawing.Size(95, 33)
        Me.Ubah_btn.TabIndex = 10
        Me.Ubah_btn.Text = "UBAH"
        Me.Ubah_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Ubah_btn.UseVisualStyleBackColor = True
        '
        'Tambah_Btn
        '
        Me.Tambah_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Tambah_Btn.Image = CType(resources.GetObject("Tambah_Btn.Image"), System.Drawing.Image)
        Me.Tambah_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Tambah_Btn.Location = New System.Drawing.Point(217, 71)
        Me.Tambah_Btn.Name = "Tambah_Btn"
        Me.Tambah_Btn.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Tambah_Btn.Size = New System.Drawing.Size(122, 33)
        Me.Tambah_Btn.TabIndex = 9
        Me.Tambah_Btn.Text = "TAMBAH "
        Me.Tambah_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Tambah_Btn.UseVisualStyleBackColor = True
        '
        'DataGridViewPeg
        '
        Me.DataGridViewPeg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPeg.Location = New System.Drawing.Point(12, 170)
        Me.DataGridViewPeg.Name = "DataGridViewPeg"
        Me.DataGridViewPeg.Size = New System.Drawing.Size(787, 204)
        Me.DataGridViewPeg.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(12, 390)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Human Resource Department"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(819, 422)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'ouut
        '
        Me.ouut.Location = New System.Drawing.Point(724, 384)
        Me.ouut.Name = "ouut"
        Me.ouut.Size = New System.Drawing.Size(75, 23)
        Me.ouut.TabIndex = 17
        Me.ouut.Text = "Log Out"
        Me.ouut.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(303, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Human Resource Department"
        '
        'MainHRD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 416)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ouut)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Hapus_btn)
        Me.Controls.Add(Me.Cari_cb)
        Me.Controls.Add(Me.Berda)
        Me.Controls.Add(Me.Cari_tb)
        Me.Controls.Add(Me.Ubah_btn)
        Me.Controls.Add(Me.Tambah_Btn)
        Me.Controls.Add(Me.DataGridViewPeg)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MainHRD"
        Me.Text = "Form2"
        CType(Me.DataGridViewPeg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Hapus_btn As System.Windows.Forms.Button
    Friend WithEvents Cari_cb As System.Windows.Forms.ComboBox
    Friend WithEvents Berda As System.Windows.Forms.Label
    Friend WithEvents Cari_tb As System.Windows.Forms.TextBox
    Friend WithEvents Ubah_btn As System.Windows.Forms.Button
    Friend WithEvents Tambah_Btn As System.Windows.Forms.Button
    Friend WithEvents DataGridViewPeg As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ouut As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
