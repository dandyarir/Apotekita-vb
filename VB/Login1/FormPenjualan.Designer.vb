<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Penjualan
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Penjualan))
        Me.PnPenjualan = New System.Windows.Forms.Panel
        Me.lbNoFaktur = New System.Windows.Forms.Label
        Me.Button7 = New System.Windows.Forms.Button
        Me.btnUbah = New System.Windows.Forms.Button
        Me.btnHapusItem = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.btnCetak = New System.Windows.Forms.Button
        Me.gbTambah = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lbHargaSatuan = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.tbSegar = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.lbHargaItem = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.DataGridView_obat = New System.Windows.Forms.DataGridView
        Me.btnTambah = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbJumlah = New System.Windows.Forms.TextBox
        Me.tbCari = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnCari = New System.Windows.Forms.Button
        Me.DataGridView_pesan = New System.Windows.Forms.DataGridView
        Me.nomor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.id_obat = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nama_obat = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.expired_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.no_barcode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.total_harga_obat = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.lbTotalBrg = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lbTotal = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.noFakturtb = New System.Windows.Forms.TextBox
        Me.lbFakturView = New System.Windows.Forms.Label
        Me.gbUbah = New System.Windows.Forms.GroupBox
        Me.lbNoItem = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnCariEd = New System.Windows.Forms.Button
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.lbHargaItemEd = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.lbHargaItemTotalEd = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.DataGridView_obatEd = New System.Windows.Forms.DataGridView
        Me.Label22 = New System.Windows.Forms.Label
        Me.btnUbahItem = New System.Windows.Forms.Button
        Me.tbJumlahEd = New System.Windows.Forms.TextBox
        Me.tbEditCari = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.btnTambahShow = New System.Windows.Forms.Button
        Me.pnDafJual = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnBef = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.DataGridView_Penjualan = New System.Windows.Forms.DataGridView
        Me.id_penjualan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.waktu_transaksi = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.jml_obat = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.total_item = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btn_segar_penj = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.cb_penj_waktu = New System.Windows.Forms.CheckBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.cb_penj_nama = New System.Windows.Forms.CheckBox
        Me.btn_bersih_cari_penj = New System.Windows.Forms.Button
        Me.btn_cari_daftar_penj = New System.Windows.Forms.Button
        Me.tb_cari_penj = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.lbNama = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lbTime = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnKeluar = New System.Windows.Forms.Button
        Me.btnDaftarJual = New System.Windows.Forms.Button
        Me.btnPenjualan = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.DataGridView_detail = New System.Windows.Forms.DataGridView
        Me.btn_kembali_penj = New System.Windows.Forms.Button
        Me.lb_nofak = New System.Windows.Forms.Label
        Me.lb_waktu = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.lb_pegawai = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.lb_jml_item_penj = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.lb_total_harga_penj = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.pn_detail_penjualan = New System.Windows.Forms.Panel
        Me.PnPenjualan.SuspendLayout()
        Me.gbTambah.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView_obat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_pesan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.gbUbah.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.DataGridView_obatEd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnDafJual.SuspendLayout()
        CType(Me.DataGridView_Penjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DataGridView_detail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pn_detail_penjualan.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnPenjualan
        '
        Me.PnPenjualan.Controls.Add(Me.lbNoFaktur)
        Me.PnPenjualan.Controls.Add(Me.Button7)
        Me.PnPenjualan.Controls.Add(Me.btnUbah)
        Me.PnPenjualan.Controls.Add(Me.btnHapusItem)
        Me.PnPenjualan.Controls.Add(Me.Label12)
        Me.PnPenjualan.Controls.Add(Me.btnCetak)
        Me.PnPenjualan.Controls.Add(Me.gbTambah)
        Me.PnPenjualan.Controls.Add(Me.DataGridView_pesan)
        Me.PnPenjualan.Controls.Add(Me.Panel3)
        Me.PnPenjualan.Controls.Add(Me.noFakturtb)
        Me.PnPenjualan.Controls.Add(Me.lbFakturView)
        Me.PnPenjualan.Controls.Add(Me.gbUbah)
        Me.PnPenjualan.Controls.Add(Me.btnTambahShow)
        Me.PnPenjualan.Location = New System.Drawing.Point(107, 46)
        Me.PnPenjualan.Name = "PnPenjualan"
        Me.PnPenjualan.Size = New System.Drawing.Size(1078, 590)
        Me.PnPenjualan.TabIndex = 0
        '
        'lbNoFaktur
        '
        Me.lbNoFaktur.AutoSize = True
        Me.lbNoFaktur.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNoFaktur.Location = New System.Drawing.Point(138, 14)
        Me.lbNoFaktur.Name = "lbNoFaktur"
        Me.lbNoFaktur.Size = New System.Drawing.Size(119, 22)
        Me.lbNoFaktur.TabIndex = 22
        Me.lbNoFaktur.Text = "Nomor Faktur"
        '
        'Button7
        '
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Image = Global.Login.My.Resources.Resources.ic_save_black_24dp
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.Location = New System.Drawing.Point(871, 462)
        Me.Button7.Name = "Button7"
        Me.Button7.Padding = New System.Windows.Forms.Padding(3)
        Me.Button7.Size = New System.Drawing.Size(200, 56)
        Me.Button7.TabIndex = 20
        Me.Button7.Text = "Simpan"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbah.Image = Global.Login.My.Resources.Resources.ic_launch_black_24dp
        Me.btnUbah.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUbah.Location = New System.Drawing.Point(872, 317)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Padding = New System.Windows.Forms.Padding(5)
        Me.btnUbah.Size = New System.Drawing.Size(200, 60)
        Me.btnUbah.TabIndex = 19
        Me.btnUbah.Text = "Ubah item"
        Me.btnUbah.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUbah.UseVisualStyleBackColor = True
        Me.btnUbah.Visible = False
        '
        'btnHapusItem
        '
        Me.btnHapusItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapusItem.Image = Global.Login.My.Resources.Resources.ic_delete_black_24dp
        Me.btnHapusItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHapusItem.Location = New System.Drawing.Point(872, 384)
        Me.btnHapusItem.Name = "btnHapusItem"
        Me.btnHapusItem.Padding = New System.Windows.Forms.Padding(20, 1, 0, 0)
        Me.btnHapusItem.Size = New System.Drawing.Size(199, 72)
        Me.btnHapusItem.TabIndex = 18
        Me.btnHapusItem.Text = "Hapus Pesanan"
        Me.btnHapusItem.UseVisualStyleBackColor = True
        Me.btnHapusItem.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label12.Location = New System.Drawing.Point(6, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(333, 20)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Pilih Baris item yang dipesan untuk mengubah"
        '
        'btnCetak
        '
        Me.btnCetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCetak.Image = Global.Login.My.Resources.Resources.ic_print_black_36dp
        Me.btnCetak.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCetak.Location = New System.Drawing.Point(871, 521)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(200, 60)
        Me.btnCetak.TabIndex = 17
        Me.btnCetak.Text = "Simpan dan Cetak Struk"
        Me.btnCetak.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'gbTambah
        '
        Me.gbTambah.Controls.Add(Me.Panel1)
        Me.gbTambah.Controls.Add(Me.tbSegar)
        Me.gbTambah.Controls.Add(Me.Label13)
        Me.gbTambah.Controls.Add(Me.Panel4)
        Me.gbTambah.Controls.Add(Me.DataGridView_obat)
        Me.gbTambah.Controls.Add(Me.btnTambah)
        Me.gbTambah.Controls.Add(Me.Label2)
        Me.gbTambah.Controls.Add(Me.tbJumlah)
        Me.gbTambah.Controls.Add(Me.tbCari)
        Me.gbTambah.Controls.Add(Me.Label8)
        Me.gbTambah.Controls.Add(Me.Label7)
        Me.gbTambah.Controls.Add(Me.btnCari)
        Me.gbTambah.Location = New System.Drawing.Point(7, 313)
        Me.gbTambah.Name = "gbTambah"
        Me.gbTambah.Size = New System.Drawing.Size(858, 274)
        Me.gbTambah.TabIndex = 17
        Me.gbTambah.TabStop = False
        Me.gbTambah.Text = "Tambah Obat"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.lbHargaSatuan)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(6, 204)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(527, 33)
        Me.Panel1.TabIndex = 8
        '
        'lbHargaSatuan
        '
        Me.lbHargaSatuan.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbHargaSatuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHargaSatuan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbHargaSatuan.Location = New System.Drawing.Point(230, 0)
        Me.lbHargaSatuan.Name = "lbHargaSatuan"
        Me.lbHargaSatuan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbHargaSatuan.Size = New System.Drawing.Size(297, 33)
        Me.lbHargaSatuan.TabIndex = 6
        Me.lbHargaSatuan.Text = "0,00"
        Me.lbHargaSatuan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(292, 33)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Harga Satuan Item"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbSegar
        '
        Me.tbSegar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSegar.Image = Global.Login.My.Resources.Resources.ic_sync_black_24dp
        Me.tbSegar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tbSegar.Location = New System.Drawing.Point(539, 235)
        Me.tbSegar.Name = "tbSegar"
        Me.tbSegar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.tbSegar.Size = New System.Drawing.Size(149, 31)
        Me.tbSegar.TabIndex = 6
        Me.tbSegar.Text = "Segarkan"
        Me.tbSegar.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label13.Location = New System.Drawing.Point(6, 41)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(202, 17)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Pilih obat untuk menambahkan"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Controls.Add(Me.lbHargaItem)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Location = New System.Drawing.Point(6, 235)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(527, 33)
        Me.Panel4.TabIndex = 7
        '
        'lbHargaItem
        '
        Me.lbHargaItem.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbHargaItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHargaItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbHargaItem.Location = New System.Drawing.Point(230, 0)
        Me.lbHargaItem.Name = "lbHargaItem"
        Me.lbHargaItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbHargaItem.Size = New System.Drawing.Size(297, 33)
        Me.lbHargaItem.TabIndex = 6
        Me.lbHargaItem.Text = "0,00"
        Me.lbHargaItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(292, 33)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Harga Total Item"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView_obat
        '
        Me.DataGridView_obat.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView_obat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_obat.Location = New System.Drawing.Point(6, 61)
        Me.DataGridView_obat.Name = "DataGridView_obat"
        Me.DataGridView_obat.ReadOnly = True
        Me.DataGridView_obat.Size = New System.Drawing.Size(837, 134)
        Me.DataGridView_obat.TabIndex = 3
        '
        'btnTambah
        '
        Me.btnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.Image = Global.Login.My.Resources.Resources.ic_add_black_24dp
        Me.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambah.Location = New System.Drawing.Point(695, 235)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Padding = New System.Windows.Forms.Padding(5, 0, 10, 0)
        Me.btnTambah.Size = New System.Drawing.Size(148, 31)
        Me.btnTambah.TabIndex = 5
        Me.btnTambah.Text = "Tambah Obat"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(212, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 22)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nama Obat/Barkode"
        '
        'tbJumlah
        '
        Me.tbJumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbJumlah.Location = New System.Drawing.Point(761, 201)
        Me.tbJumlah.Name = "tbJumlah"
        Me.tbJumlah.Size = New System.Drawing.Size(79, 27)
        Me.tbJumlah.TabIndex = 4
        Me.tbJumlah.Text = "1"
        '
        'tbCari
        '
        Me.tbCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCari.Location = New System.Drawing.Point(391, 16)
        Me.tbCari.Name = "tbCari"
        Me.tbCari.Size = New System.Drawing.Size(291, 27)
        Me.tbCari.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(650, 204)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 22)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Jumlah item"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label7.Location = New System.Drawing.Point(5, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 22)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Pencarian Obat"
        '
        'btnCari
        '
        Me.btnCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCari.Image = Global.Login.My.Resources.Resources.ic_search_black_24dp
        Me.btnCari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCari.Location = New System.Drawing.Point(695, 14)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnCari.Size = New System.Drawing.Size(148, 31)
        Me.btnCari.TabIndex = 2
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'DataGridView_pesan
        '
        Me.DataGridView_pesan.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView_pesan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_pesan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nomor, Me.id_obat, Me.nama_obat, Me.expired_date, Me.no_barcode, Me.harga, Me.jumlah, Me.total_harga_obat})
        Me.DataGridView_pesan.Location = New System.Drawing.Point(0, 99)
        Me.DataGridView_pesan.Name = "DataGridView_pesan"
        Me.DataGridView_pesan.ShowCellErrors = False
        Me.DataGridView_pesan.Size = New System.Drawing.Size(1078, 210)
        Me.DataGridView_pesan.TabIndex = 9
        '
        'nomor
        '
        Me.nomor.HeaderText = "NO"
        Me.nomor.Name = "nomor"
        Me.nomor.Width = 50
        '
        'id_obat
        '
        Me.id_obat.HeaderText = "ID OBAT"
        Me.id_obat.Name = "id_obat"
        '
        'nama_obat
        '
        Me.nama_obat.HeaderText = "NAMA OBAT"
        Me.nama_obat.Name = "nama_obat"
        Me.nama_obat.Width = 200
        '
        'expired_date
        '
        Me.expired_date.HeaderText = "TANGAL KADALUARSA"
        Me.expired_date.Name = "expired_date"
        '
        'no_barcode
        '
        Me.no_barcode.HeaderText = "NO BARKODE"
        Me.no_barcode.Name = "no_barcode"
        Me.no_barcode.Width = 150
        '
        'harga
        '
        Me.harga.HeaderText = "HARGA SATUAN"
        Me.harga.Name = "harga"
        Me.harga.Width = 150
        '
        'jumlah
        '
        Me.jumlah.HeaderText = "JUMLAH"
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Width = 80
        '
        'total_harga_obat
        '
        Me.total_harga_obat.HeaderText = "TOTAL HARGA OBAT"
        Me.total_harga_obat.Name = "total_harga_obat"
        Me.total_harga_obat.Width = 200
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.lbTotal)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(562, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(516, 102)
        Me.Panel3.TabIndex = 4
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Controls.Add(Me.lbTotalBrg)
        Me.Panel5.Location = New System.Drawing.Point(218, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(292, 41)
        Me.Panel5.TabIndex = 9
        '
        'lbTotalBrg
        '
        Me.lbTotalBrg.AutoSize = True
        Me.lbTotalBrg.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbTotalBrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalBrg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbTotalBrg.Location = New System.Drawing.Point(256, 0)
        Me.lbTotalBrg.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.lbTotalBrg.Name = "lbTotalBrg"
        Me.lbTotalBrg.Padding = New System.Windows.Forms.Padding(0, 10, 10, 0)
        Me.lbTotalBrg.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbTotalBrg.Size = New System.Drawing.Size(36, 39)
        Me.lbTotalBrg.TabIndex = 8
        Me.lbTotalBrg.Text = "0"
        Me.lbTotalBrg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(5, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(195, 31)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Jumlah Barang"
        '
        'lbTotal
        '
        Me.lbTotal.AutoSize = True
        Me.lbTotal.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbTotal.Location = New System.Drawing.Point(384, 0)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Padding = New System.Windows.Forms.Padding(0, 35, 0, 0)
        Me.lbTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbTotal.Size = New System.Drawing.Size(132, 98)
        Me.lbTotal.TabIndex = 6
        Me.lbTotal.Text = "0,00"
        Me.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(3, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 46)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Total"
        '
        'noFakturtb
        '
        Me.noFakturtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noFakturtb.Location = New System.Drawing.Point(13, 105)
        Me.noFakturtb.Name = "noFakturtb"
        Me.noFakturtb.Size = New System.Drawing.Size(167, 27)
        Me.noFakturtb.TabIndex = 0
        Me.noFakturtb.Visible = False
        '
        'lbFakturView
        '
        Me.lbFakturView.AutoSize = True
        Me.lbFakturView.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFakturView.Location = New System.Drawing.Point(13, 14)
        Me.lbFakturView.Name = "lbFakturView"
        Me.lbFakturView.Size = New System.Drawing.Size(119, 22)
        Me.lbFakturView.TabIndex = 0
        Me.lbFakturView.Text = "Nomor Faktur"
        '
        'gbUbah
        '
        Me.gbUbah.Controls.Add(Me.lbNoItem)
        Me.gbUbah.Controls.Add(Me.Label3)
        Me.gbUbah.Controls.Add(Me.btnCariEd)
        Me.gbUbah.Controls.Add(Me.Panel6)
        Me.gbUbah.Controls.Add(Me.Label15)
        Me.gbUbah.Controls.Add(Me.Panel7)
        Me.gbUbah.Controls.Add(Me.DataGridView_obatEd)
        Me.gbUbah.Controls.Add(Me.Label22)
        Me.gbUbah.Controls.Add(Me.btnUbahItem)
        Me.gbUbah.Controls.Add(Me.tbJumlahEd)
        Me.gbUbah.Controls.Add(Me.tbEditCari)
        Me.gbUbah.Controls.Add(Me.Label23)
        Me.gbUbah.Controls.Add(Me.Label24)
        Me.gbUbah.Location = New System.Drawing.Point(7, 313)
        Me.gbUbah.Name = "gbUbah"
        Me.gbUbah.Size = New System.Drawing.Size(858, 274)
        Me.gbUbah.TabIndex = 18
        Me.gbUbah.TabStop = False
        Me.gbUbah.Text = "Ubah item pesanan"
        Me.gbUbah.Visible = False
        '
        'lbNoItem
        '
        Me.lbNoItem.AutoSize = True
        Me.lbNoItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNoItem.Location = New System.Drawing.Point(612, 204)
        Me.lbNoItem.Name = "lbNoItem"
        Me.lbNoItem.Size = New System.Drawing.Size(20, 22)
        Me.lbNoItem.TabIndex = 21
        Me.lbNoItem.Text = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(540, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 22)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Item No."
        '
        'btnCariEd
        '
        Me.btnCariEd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCariEd.Image = Global.Login.My.Resources.Resources.ic_search_black_24dp
        Me.btnCariEd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCariEd.Location = New System.Drawing.Point(695, 14)
        Me.btnCariEd.Name = "btnCariEd"
        Me.btnCariEd.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnCariEd.Size = New System.Drawing.Size(148, 31)
        Me.btnCariEd.TabIndex = 19
        Me.btnCariEd.Text = "Cari"
        Me.btnCariEd.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Controls.Add(Me.lbHargaItemEd)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Location = New System.Drawing.Point(6, 204)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(527, 33)
        Me.Panel6.TabIndex = 8
        '
        'lbHargaItemEd
        '
        Me.lbHargaItemEd.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbHargaItemEd.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHargaItemEd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbHargaItemEd.Location = New System.Drawing.Point(230, 0)
        Me.lbHargaItemEd.Name = "lbHargaItemEd"
        Me.lbHargaItemEd.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbHargaItemEd.Size = New System.Drawing.Size(297, 33)
        Me.lbHargaItemEd.TabIndex = 6
        Me.lbHargaItemEd.Text = "0,00"
        Me.lbHargaItemEd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(292, 33)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Harga Satuan Item"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label15.Location = New System.Drawing.Point(6, 41)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(235, 17)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Pilih obat untuk mengubah pesanan"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Black
        Me.Panel7.Controls.Add(Me.lbHargaItemTotalEd)
        Me.Panel7.Controls.Add(Me.Label21)
        Me.Panel7.Location = New System.Drawing.Point(6, 235)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(527, 33)
        Me.Panel7.TabIndex = 7
        '
        'lbHargaItemTotalEd
        '
        Me.lbHargaItemTotalEd.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbHargaItemTotalEd.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHargaItemTotalEd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lbHargaItemTotalEd.Location = New System.Drawing.Point(230, 0)
        Me.lbHargaItemTotalEd.Name = "lbHargaItemTotalEd"
        Me.lbHargaItemTotalEd.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbHargaItemTotalEd.Size = New System.Drawing.Size(297, 33)
        Me.lbHargaItemTotalEd.TabIndex = 6
        Me.lbHargaItemTotalEd.Text = "0,00"
        Me.lbHargaItemTotalEd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(0, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(292, 33)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "Harga Total Item"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView_obatEd
        '
        Me.DataGridView_obatEd.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView_obatEd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_obatEd.Location = New System.Drawing.Point(6, 61)
        Me.DataGridView_obatEd.Name = "DataGridView_obatEd"
        Me.DataGridView_obatEd.ReadOnly = True
        Me.DataGridView_obatEd.Size = New System.Drawing.Size(837, 134)
        Me.DataGridView_obatEd.TabIndex = 3
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(212, 19)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(173, 22)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "Nama Obat/Barkode"
        '
        'btnUbahItem
        '
        Me.btnUbahItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbahItem.Image = Global.Login.My.Resources.Resources.ic_mode_edit_black_24dp
        Me.btnUbahItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUbahItem.Location = New System.Drawing.Point(544, 230)
        Me.btnUbahItem.Name = "btnUbahItem"
        Me.btnUbahItem.Padding = New System.Windows.Forms.Padding(60, 0, 0, 0)
        Me.btnUbahItem.Size = New System.Drawing.Size(296, 31)
        Me.btnUbahItem.TabIndex = 16
        Me.btnUbahItem.Text = "Ubah Pesanan"
        Me.btnUbahItem.UseVisualStyleBackColor = True
        '
        'tbJumlahEd
        '
        Me.tbJumlahEd.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbJumlahEd.Location = New System.Drawing.Point(773, 201)
        Me.tbJumlahEd.Name = "tbJumlahEd"
        Me.tbJumlahEd.Size = New System.Drawing.Size(67, 27)
        Me.tbJumlahEd.TabIndex = 4
        Me.tbJumlahEd.Text = "1"
        '
        'tbEditCari
        '
        Me.tbEditCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEditCari.Location = New System.Drawing.Point(398, 16)
        Me.tbEditCari.Name = "tbEditCari"
        Me.tbEditCari.Size = New System.Drawing.Size(291, 27)
        Me.tbEditCari.TabIndex = 7
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(662, 204)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(105, 22)
        Me.Label23.TabIndex = 14
        Me.Label23.Text = "Jumlah item"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label24.Location = New System.Drawing.Point(5, 19)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(149, 22)
        Me.Label24.TabIndex = 8
        Me.Label24.Text = "Pencarian Obat"
        '
        'btnTambahShow
        '
        Me.btnTambahShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnTambahShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahShow.Image = Global.Login.My.Resources.Resources.ic_redo_black_24dp1
        Me.btnTambahShow.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnTambahShow.Location = New System.Drawing.Point(872, 318)
        Me.btnTambahShow.Name = "btnTambahShow"
        Me.btnTambahShow.Padding = New System.Windows.Forms.Padding(4)
        Me.btnTambahShow.Size = New System.Drawing.Size(200, 60)
        Me.btnTambahShow.TabIndex = 21
        Me.btnTambahShow.Text = "Kembali"
        Me.btnTambahShow.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTambahShow.UseVisualStyleBackColor = True
        Me.btnTambahShow.Visible = False
        '
        'pnDafJual
        '
        Me.pnDafJual.Controls.Add(Me.pn_detail_penjualan)
        Me.pnDafJual.Controls.Add(Me.Button2)
        Me.pnDafJual.Controls.Add(Me.btnBef)
        Me.pnDafJual.Controls.Add(Me.btnNext)
        Me.pnDafJual.Controls.Add(Me.DataGridView_Penjualan)
        Me.pnDafJual.Controls.Add(Me.btn_segar_penj)
        Me.pnDafJual.Controls.Add(Me.Label11)
        Me.pnDafJual.Controls.Add(Me.Label26)
        Me.pnDafJual.Controls.Add(Me.cb_penj_waktu)
        Me.pnDafJual.Controls.Add(Me.Label30)
        Me.pnDafJual.Controls.Add(Me.cb_penj_nama)
        Me.pnDafJual.Controls.Add(Me.btn_bersih_cari_penj)
        Me.pnDafJual.Controls.Add(Me.btn_cari_daftar_penj)
        Me.pnDafJual.Controls.Add(Me.tb_cari_penj)
        Me.pnDafJual.Controls.Add(Me.Label28)
        Me.pnDafJual.Controls.Add(Me.Label14)
        Me.pnDafJual.Location = New System.Drawing.Point(104, 46)
        Me.pnDafJual.Name = "pnDafJual"
        Me.pnDafJual.Size = New System.Drawing.Size(1079, 590)
        Me.pnDafJual.TabIndex = 12
        Me.pnDafJual.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(459, 520)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(4)
        Me.Button2.Size = New System.Drawing.Size(200, 60)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Lembar Awal"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'btnBef
        '
        Me.btnBef.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBef.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBef.Location = New System.Drawing.Point(665, 520)
        Me.btnBef.Name = "btnBef"
        Me.btnBef.Padding = New System.Windows.Forms.Padding(4)
        Me.btnBef.Size = New System.Drawing.Size(200, 60)
        Me.btnBef.TabIndex = 23
        Me.btnBef.Text = "Lembar Setelahnya"
        Me.btnBef.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBef.UseVisualStyleBackColor = True
        Me.btnBef.Visible = False
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNext.Location = New System.Drawing.Point(871, 520)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Padding = New System.Windows.Forms.Padding(4)
        Me.btnNext.Size = New System.Drawing.Size(200, 60)
        Me.btnNext.TabIndex = 22
        Me.btnNext.Text = "Lembar Sebelumnya"
        Me.btnNext.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNext.UseVisualStyleBackColor = True
        Me.btnNext.Visible = False
        '
        'DataGridView_Penjualan
        '
        Me.DataGridView_Penjualan.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView_Penjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Penjualan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_penjualan, Me.waktu_transaksi, Me.nama, Me.jml_obat, Me.total_item})
        Me.DataGridView_Penjualan.Location = New System.Drawing.Point(16, 141)
        Me.DataGridView_Penjualan.Name = "DataGridView_Penjualan"
        Me.DataGridView_Penjualan.ReadOnly = True
        Me.DataGridView_Penjualan.Size = New System.Drawing.Size(1055, 371)
        Me.DataGridView_Penjualan.TabIndex = 4
        '
        'id_penjualan
        '
        Me.id_penjualan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.id_penjualan.HeaderText = "Nomor Faktur"
        Me.id_penjualan.Name = "id_penjualan"
        Me.id_penjualan.ReadOnly = True
        '
        'waktu_transaksi
        '
        Me.waktu_transaksi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.waktu_transaksi.HeaderText = "Waktu dan Tanggal"
        Me.waktu_transaksi.Name = "waktu_transaksi"
        Me.waktu_transaksi.ReadOnly = True
        '
        'nama
        '
        Me.nama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nama.HeaderText = "Pegawai"
        Me.nama.Name = "nama"
        Me.nama.ReadOnly = True
        '
        'jml_obat
        '
        Me.jml_obat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.jml_obat.HeaderText = "Jumlah Item"
        Me.jml_obat.Name = "jml_obat"
        Me.jml_obat.ReadOnly = True
        '
        'total_item
        '
        Me.total_item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.total_item.HeaderText = "Total Harga"
        Me.total_item.Name = "total_item"
        Me.total_item.ReadOnly = True
        '
        'btn_segar_penj
        '
        Me.btn_segar_penj.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_segar_penj.Image = Global.Login.My.Resources.Resources.ic_sync_black_24dp
        Me.btn_segar_penj.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_segar_penj.Location = New System.Drawing.Point(18, 520)
        Me.btn_segar_penj.Name = "btn_segar_penj"
        Me.btn_segar_penj.Padding = New System.Windows.Forms.Padding(4)
        Me.btn_segar_penj.Size = New System.Drawing.Size(430, 60)
        Me.btn_segar_penj.TabIndex = 27
        Me.btn_segar_penj.Text = "Segarkan"
        Me.btn_segar_penj.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_segar_penj.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label11.Location = New System.Drawing.Point(273, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(565, 25)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Melihat daftar nota penjualan dan mengakses detail penjualan"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Snow
        Me.Label26.Location = New System.Drawing.Point(367, 7)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(367, 37)
        Me.Label26.TabIndex = 28
        Me.Label26.Text = "Daftar Penjualan Apotekita"
        '
        'cb_penj_waktu
        '
        Me.cb_penj_waktu.AutoSize = True
        Me.cb_penj_waktu.Location = New System.Drawing.Point(948, 118)
        Me.cb_penj_waktu.Name = "cb_penj_waktu"
        Me.cb_penj_waktu.Size = New System.Drawing.Size(117, 17)
        Me.cb_penj_waktu.TabIndex = 42
        Me.cb_penj_waktu.Text = "Waktu dan tanggal"
        Me.cb_penj_waktu.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(493, 112)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(348, 25)
        Me.Label30.TabIndex = 41
        Me.Label30.Text = "Penyaringan pencarian lanjut berdasarkan :"
        '
        'cb_penj_nama
        '
        Me.cb_penj_nama.AutoSize = True
        Me.cb_penj_nama.Location = New System.Drawing.Point(847, 118)
        Me.cb_penj_nama.Name = "cb_penj_nama"
        Me.cb_penj_nama.Size = New System.Drawing.Size(98, 17)
        Me.cb_penj_nama.TabIndex = 40
        Me.cb_penj_nama.Text = "Nama Pegawai"
        Me.cb_penj_nama.UseVisualStyleBackColor = True
        '
        'btn_bersih_cari_penj
        '
        Me.btn_bersih_cari_penj.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bersih_cari_penj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_bersih_cari_penj.Location = New System.Drawing.Point(922, 82)
        Me.btn_bersih_cari_penj.Name = "btn_bersih_cari_penj"
        Me.btn_bersih_cari_penj.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_bersih_cari_penj.Size = New System.Drawing.Size(149, 31)
        Me.btn_bersih_cari_penj.TabIndex = 39
        Me.btn_bersih_cari_penj.Text = "Bersihkan"
        Me.btn_bersih_cari_penj.UseVisualStyleBackColor = True
        '
        'btn_cari_daftar_penj
        '
        Me.btn_cari_daftar_penj.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cari_daftar_penj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cari_daftar_penj.Location = New System.Drawing.Point(768, 82)
        Me.btn_cari_daftar_penj.Name = "btn_cari_daftar_penj"
        Me.btn_cari_daftar_penj.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_cari_daftar_penj.Size = New System.Drawing.Size(148, 31)
        Me.btn_cari_daftar_penj.TabIndex = 38
        Me.btn_cari_daftar_penj.Text = "Cari"
        Me.btn_cari_daftar_penj.UseVisualStyleBackColor = True
        '
        'tb_cari_penj
        '
        Me.tb_cari_penj.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cari_penj.Location = New System.Drawing.Point(382, 84)
        Me.tb_cari_penj.Name = "tb_cari_penj"
        Me.tb_cari_penj.Size = New System.Drawing.Size(378, 27)
        Me.tb_cari_penj.TabIndex = 37
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Tai Le", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(15, 84)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(365, 23)
        Me.Label28.TabIndex = 36
        Me.Label28.Text = "Pencarian nota (menggunakan nomor faktur)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(14, 116)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(377, 22)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Klik pada daftar untuk melihat detail penjualan"
        '
        'lbNama
        '
        Me.lbNama.AutoSize = True
        Me.lbNama.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNama.ForeColor = System.Drawing.Color.Snow
        Me.lbNama.Location = New System.Drawing.Point(1026, 81)
        Me.lbNama.Name = "lbNama"
        Me.lbNama.Size = New System.Drawing.Size(40, 21)
        Me.lbNama.TabIndex = 3
        Me.lbNama.Text = "Rini"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(886, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Selamat datang,"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lbTime)
        Me.Panel2.Controls.Add(Me.lbNama)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(107, -69)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1078, 114)
        Me.Panel2.TabIndex = 5
        '
        'lbTime
        '
        Me.lbTime.AutoSize = True
        Me.lbTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTime.ForeColor = System.Drawing.Color.Snow
        Me.lbTime.Location = New System.Drawing.Point(13, 81)
        Me.lbTime.Name = "lbTime"
        Me.lbTime.Size = New System.Drawing.Size(166, 21)
        Me.lbTime.TabIndex = 5
        Me.lbTime.Text = "31/4/2017 08:00 WIB"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 639)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1179, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(114, 17)
        Me.ToolStripStatusLabel1.Text = "Terhubung ke server"
        '
        'Timer1
        '
        '
        'btnKeluar
        '
        Me.btnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.Image = Global.Login.My.Resources.Resources.ic_exit_to_app_black_24dp
        Me.btnKeluar.Location = New System.Drawing.Point(8, 531)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Padding = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.btnKeluar.Size = New System.Drawing.Size(89, 102)
        Me.btnKeluar.TabIndex = 2
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnDaftarJual
        '
        Me.btnDaftarJual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDaftarJual.Image = CType(resources.GetObject("btnDaftarJual.Image"), System.Drawing.Image)
        Me.btnDaftarJual.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDaftarJual.Location = New System.Drawing.Point(8, 219)
        Me.btnDaftarJual.Name = "btnDaftarJual"
        Me.btnDaftarJual.Padding = New System.Windows.Forms.Padding(0, 5, 0, 10)
        Me.btnDaftarJual.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDaftarJual.Size = New System.Drawing.Size(89, 96)
        Me.btnDaftarJual.TabIndex = 14
        Me.btnDaftarJual.Text = "Daftar Penjualan"
        Me.btnDaftarJual.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDaftarJual.UseVisualStyleBackColor = True
        '
        'btnPenjualan
        '
        Me.btnPenjualan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPenjualan.Image = CType(resources.GetObject("btnPenjualan.Image"), System.Drawing.Image)
        Me.btnPenjualan.Location = New System.Drawing.Point(8, 113)
        Me.btnPenjualan.Name = "btnPenjualan"
        Me.btnPenjualan.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.btnPenjualan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnPenjualan.Size = New System.Drawing.Size(89, 89)
        Me.btnPenjualan.TabIndex = 13
        Me.btnPenjualan.Text = "Penjualan"
        Me.btnPenjualan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPenjualan.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.Location = New System.Drawing.Point(8, 6)
        Me.Button8.Name = "Button8"
        Me.Button8.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.Button8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button8.Size = New System.Drawing.Size(89, 87)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "Menu Utama"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label20.Location = New System.Drawing.Point(485, 48)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(271, 25)
        Me.Label20.TabIndex = 34
        Me.Label20.Text = "Melihat detail nota penjualan"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Snow
        Me.Label16.Location = New System.Drawing.Point(433, 10)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(361, 37)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Detail Penjualan Apotekita"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(243, 87)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(129, 22)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Nomor Faktur :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(243, 118)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(174, 22)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Waktu pemesanan : "
        '
        'DataGridView_detail
        '
        Me.DataGridView_detail.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_detail.Location = New System.Drawing.Point(28, 160)
        Me.DataGridView_detail.Name = "DataGridView_detail"
        Me.DataGridView_detail.ReadOnly = True
        Me.DataGridView_detail.Size = New System.Drawing.Size(1023, 410)
        Me.DataGridView_detail.TabIndex = 9
        '
        'btn_kembali_penj
        '
        Me.btn_kembali_penj.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_kembali_penj.Image = Global.Login.My.Resources.Resources.ic_undo_black_48dp
        Me.btn_kembali_penj.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_kembali_penj.Location = New System.Drawing.Point(27, 15)
        Me.btn_kembali_penj.Name = "btn_kembali_penj"
        Me.btn_kembali_penj.Padding = New System.Windows.Forms.Padding(4, 0, 4, 8)
        Me.btn_kembali_penj.Size = New System.Drawing.Size(200, 96)
        Me.btn_kembali_penj.TabIndex = 24
        Me.btn_kembali_penj.Text = "Kembali ke daftar penjualan"
        Me.btn_kembali_penj.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_kembali_penj.UseVisualStyleBackColor = True
        '
        'lb_nofak
        '
        Me.lb_nofak.AutoSize = True
        Me.lb_nofak.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_nofak.Location = New System.Drawing.Point(377, 88)
        Me.lb_nofak.Name = "lb_nofak"
        Me.lb_nofak.Size = New System.Drawing.Size(40, 22)
        Me.lb_nofak.TabIndex = 25
        Me.lb_nofak.Text = "000"
        '
        'lb_waktu
        '
        Me.lb_waktu.AutoSize = True
        Me.lb_waktu.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_waktu.Location = New System.Drawing.Point(410, 118)
        Me.lb_waktu.Name = "lb_waktu"
        Me.lb_waktu.Size = New System.Drawing.Size(177, 22)
        Me.lb_waktu.TabIndex = 26
        Me.lb_waktu.Text = "2017-03-09 10:07:24"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(598, 87)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(123, 22)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "Dilayani oleh :"
        '
        'lb_pegawai
        '
        Me.lb_pegawai.AutoSize = True
        Me.lb_pegawai.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_pegawai.Location = New System.Drawing.Point(727, 87)
        Me.lb_pegawai.Name = "lb_pegawai"
        Me.lb_pegawai.Size = New System.Drawing.Size(40, 22)
        Me.lb_pegawai.TabIndex = 28
        Me.lb_pegawai.Text = "000"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(598, 118)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(120, 22)
        Me.Label25.TabIndex = 29
        Me.Label25.Text = "Jumlah Item : "
        '
        'lb_jml_item_penj
        '
        Me.lb_jml_item_penj.AutoSize = True
        Me.lb_jml_item_penj.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_jml_item_penj.Location = New System.Drawing.Point(727, 118)
        Me.lb_jml_item_penj.Name = "lb_jml_item_penj"
        Me.lb_jml_item_penj.Size = New System.Drawing.Size(40, 22)
        Me.lb_jml_item_penj.TabIndex = 30
        Me.lb_jml_item_penj.Text = "000"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(795, 118)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(120, 22)
        Me.Label27.TabIndex = 31
        Me.Label27.Text = "Total Harga : "
        '
        'lb_total_harga_penj
        '
        Me.lb_total_harga_penj.AutoSize = True
        Me.lb_total_harga_penj.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_total_harga_penj.Location = New System.Drawing.Point(925, 118)
        Me.lb_total_harga_penj.Name = "lb_total_harga_penj"
        Me.lb_total_harga_penj.Size = New System.Drawing.Size(40, 22)
        Me.lb_total_harga_penj.TabIndex = 32
        Me.lb_total_harga_penj.Text = "000"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(29, 135)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(195, 22)
        Me.Label29.TabIndex = 33
        Me.Label29.Text = "Detail daftar penjualan "
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.Login.My.Resources.Resources.ic_print_black_36dp
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(851, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(200, 60)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "Cetak ulang struk"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'pn_detail_penjualan
        '
        Me.pn_detail_penjualan.Controls.Add(Me.Button3)
        Me.pn_detail_penjualan.Controls.Add(Me.Label29)
        Me.pn_detail_penjualan.Controls.Add(Me.lb_total_harga_penj)
        Me.pn_detail_penjualan.Controls.Add(Me.Label27)
        Me.pn_detail_penjualan.Controls.Add(Me.lb_jml_item_penj)
        Me.pn_detail_penjualan.Controls.Add(Me.Label25)
        Me.pn_detail_penjualan.Controls.Add(Me.lb_pegawai)
        Me.pn_detail_penjualan.Controls.Add(Me.Label19)
        Me.pn_detail_penjualan.Controls.Add(Me.lb_waktu)
        Me.pn_detail_penjualan.Controls.Add(Me.lb_nofak)
        Me.pn_detail_penjualan.Controls.Add(Me.btn_kembali_penj)
        Me.pn_detail_penjualan.Controls.Add(Me.DataGridView_detail)
        Me.pn_detail_penjualan.Controls.Add(Me.Label18)
        Me.pn_detail_penjualan.Controls.Add(Me.Label17)
        Me.pn_detail_penjualan.Controls.Add(Me.Label16)
        Me.pn_detail_penjualan.Controls.Add(Me.Label20)
        Me.pn_detail_penjualan.Location = New System.Drawing.Point(3, 0)
        Me.pn_detail_penjualan.Name = "pn_detail_penjualan"
        Me.pn_detail_penjualan.Size = New System.Drawing.Size(1072, 587)
        Me.pn_detail_penjualan.TabIndex = 26
        Me.pn_detail_penjualan.Visible = False
        '
        'Penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1179, 661)
        Me.Controls.Add(Me.PnPenjualan)
        Me.Controls.Add(Me.btnDaftarJual)
        Me.Controls.Add(Me.btnPenjualan)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnDafJual)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Penjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penjualan Apotikita"
        Me.PnPenjualan.ResumeLayout(False)
        Me.PnPenjualan.PerformLayout()
        Me.gbTambah.ResumeLayout(False)
        Me.gbTambah.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.DataGridView_obat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_pesan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.gbUbah.ResumeLayout(False)
        Me.gbUbah.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.DataGridView_obatEd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnDafJual.ResumeLayout(False)
        Me.pnDafJual.PerformLayout()
        CType(Me.DataGridView_Penjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DataGridView_detail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pn_detail_penjualan.ResumeLayout(False)
        Me.pn_detail_penjualan.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnPenjualan As System.Windows.Forms.Panel
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents lbNama As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbFakturView As System.Windows.Forms.Label
    Friend WithEvents lbTime As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbTotal As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbCari As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView_obat As System.Windows.Forms.DataGridView
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents DataGridView_pesan As System.Windows.Forms.DataGridView
    Friend WithEvents tbJumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gbTambah As System.Windows.Forms.GroupBox
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents btnCetak As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lbHargaItem As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbTotalBrg As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnUbahItem As System.Windows.Forms.Button
    Friend WithEvents tbEditCari As System.Windows.Forms.TextBox
    Friend WithEvents btnHapusItem As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents tbSegar As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnCariEd As System.Windows.Forms.Button
    Friend WithEvents nomor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_obat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama_obat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents expired_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents no_barcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents harga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_harga_obat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnTambahShow As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbHargaSatuan As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gbUbah As System.Windows.Forms.GroupBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents lbHargaItemEd As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents lbHargaItemTotalEd As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents DataGridView_obatEd As System.Windows.Forms.DataGridView
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents tbJumlahEd As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lbNoItem As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pnDafJual As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnBef As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents DataGridView_Penjualan As System.Windows.Forms.DataGridView
    Friend WithEvents id_penjualan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents waktu_transaksi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jml_obat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_segar_penj As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cb_penj_waktu As System.Windows.Forms.CheckBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents cb_penj_nama As System.Windows.Forms.CheckBox
    Friend WithEvents btn_bersih_cari_penj As System.Windows.Forms.Button
    Friend WithEvents btn_cari_daftar_penj As System.Windows.Forms.Button
    Friend WithEvents tb_cari_penj As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnDaftarJual As System.Windows.Forms.Button
    Friend WithEvents btnPenjualan As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lbNoFaktur As System.Windows.Forms.Label
    Friend WithEvents noFakturtb As System.Windows.Forms.TextBox
    Friend WithEvents pn_detail_penjualan As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents lb_total_harga_penj As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents lb_jml_item_penj As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents lb_pegawai As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lb_waktu As System.Windows.Forms.Label
    Friend WithEvents lb_nofak As System.Windows.Forms.Label
    Friend WithEvents btn_kembali_penj As System.Windows.Forms.Button
    Friend WithEvents DataGridView_detail As System.Windows.Forms.DataGridView
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label

End Class
