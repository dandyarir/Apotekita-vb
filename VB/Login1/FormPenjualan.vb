Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Threading
Imports MySql



Public Class Penjualan

    Dim no_pesan As Integer = 1
    Dim harga_satuan As Integer = 0

    Public Temp As Long = 0
    Public Output As [String]

    Public jml_brg As Integer = 0
    Public isTambahFormTambah As Boolean = True
    Public isSegar As Boolean = False
    Public temp_ubah_jumlah As Integer = 0
    Public isKurang As Boolean = False
    Public isHapus As Boolean = False

    Public totalharga As Integer = 0


    Private Sub tbJumlah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbJumlah.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            'MessageBox.Show("Hanya berupa angka")
            'e.Handled = True
        End If
    End Sub

    Private Sub tbJumlahEd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
    Handles tbJumlahEd.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            'MessageBox.Show("Hanya berupa angka")
            'e.Handled = True
        End If
    End Sub

    Private Sub cari()
        Dim koneksi As New MySqlConnection
        koneksi.ConnectionString = "server=localhost;user=root;password=;database=apotekita;AllowZeroDatetime=True"
        koneksi.Open()

        Dim adapter As New MySqlDataAdapter( _
        "SELECT a.id_obat as id_obat, a.nama_obat as nama_obat, a.harga as harga, a.expired_date as expired_date, a.no_bpom as no_bpom, a.no_barcode as no_barcode, a.keterangan as keterangan, b.jml_in as jumlah FROM obat a left join penerimaan b ON a.id_obat=b.id_obat WHERE keterangan LIKE '%" & tbCari.Text & "%' OR nama_obat LIKE '%" & tbCari.Text & "%' OR no_barcode LIKE '%" & tbCari.Text & "%'", koneksi)

        Dim tabel As New DataTable
        adapter.Fill(tabel)

        DataGridView_obat.DataSource = tabel

        koneksi.Close()


        If DataGridView_obat.RowCount > 1 Then
            Dim Input As [String] = DataGridView_obat.Rows( _
            DataGridView_obat.CurrentRow.Index).Cells("harga").Value
            Temp = Integer.Parse(Input)
            harga_satuan = Temp
            Dim Output As [String] = Temp.ToString("#,#.00")


            lbHargaItem.Text = Output
            lbHargaSatuan.Text = Output
        End If


    End Sub

    Private Sub cari_ed()
        Dim koneksi As New MySqlConnection
        koneksi.ConnectionString = "server=localhost;user=root;password=;database=apotekita;AllowZeroDatetime=True"
        koneksi.Open()

        Dim adapter As New MySqlDataAdapter( _
        "SELECT a.id_obat as id_obat, a.nama_obat as nama_obat, a.harga as harga, a.expired_date as expired_date, a.no_bpom as no_bpom, a.no_barcode as no_barcode, a.keterangan as keterangan, b.jml_in as jumlah FROM obat a left join penerimaan b ON a.id_obat=b.id_obat WHERE keterangan LIKE '%" & tbEditCari.Text & "%' OR nama_obat LIKE '%" & tbEditCari.Text & "%' OR no_barcode LIKE '%" _
        & tbEditCari.Text & "%'", koneksi)

        Dim tabel1 As New DataTable
        adapter.Fill(tabel1)

        DataGridView_obatEd.DataSource = tabel1

        koneksi.Close()

        If DataGridView_obatEd.RowCount > 1 Then
            'Mengubah jumlah
            Dim InputJumlah As [String] = DataGridView_pesan.Rows( _
            DataGridView_pesan.CurrentRow.Index).Cells("jumlah").Value
            tbJumlahEd.Text = InputJumlah

            'mengambil data harga
            Dim Input As [String] = DataGridView_obatEd.Rows( _
            DataGridView_obatEd.CurrentRow.Index).Cells("harga").Value
            Temp = Long.Parse(Input)
            harga_satuan = Temp
            Dim Output As [String] = Temp.ToString("#,#.00")

            'mengubah harga satuan
            lbHargaItemEd.Text = Output

            'mengkalian harga total
            Temp = lbHargaItemEd.Text * tbJumlahEd.Text
            Output = Temp.ToString("#,#.00")
            lbHargaItemTotalEd.Text = Output
        End If



    End Sub


    Private Sub segarkan()
        tbCari.Text = ""
        DataGridView_obat.DataSource = ""
        lbHargaItem.Text = "0,00"
        lbHargaSatuan.Text = "0,00"
        lbHargaItem.Text = "0,00"
        lbHargaSatuan.Text = "0,00"
        btnUbah.Visible = True

        'menghitung jumlah pesanan
        jml_brg = 0
        Dim cek_isi_dg As Integer = DataGridView_pesan.RowCount.ToString
        If cek_isi_dg >= 1 Then
            For Each row As DataGridViewRow In DataGridView_pesan.Rows
                jml_brg += row.Cells.Item(6).Value
                lbTotalBrg.Text = jml_brg
            Next
        End If

        'menhitung total harga pesanan
        jumlahTotalHarga()

        'kembali ke default
        harga_satuan = 0
        tbJumlah.Text = 1
        isTambahFormTambah = True
        isSegar = False
        isKurang = False
        temp_ubah_jumlah = 0

    End Sub


    Private Sub tbSegar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSegar.Click
        isSegar = True
        segarkan()
    End Sub


    Private Sub tbCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCari.TextChanged
        If tbCari.TextLength >= 3 Then
            cari()
        End If
        btnUbah.Visible = False
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click

        If String.IsNullOrEmpty(tbCari.Text) Then

        Else
            cari()
        End If


    End Sub

    Private Sub DataGridView_obat_CellClick(ByVal sender As System.Object, _
                                            ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) _
                                            Handles DataGridView_obat.CellClick

        Dim Input As [String] = DataGridView_obat.Rows( _
        DataGridView_obat.CurrentRow.Index).Cells("harga").Value
        Temp = Long.Parse(Input)
        harga_satuan = Temp
        Output = Temp.ToString("#,#.00")


        lbHargaItem.Text = Output
        lbHargaSatuan.Text = Output


    End Sub



    Private Sub DataGridView_pesan_CellClick(ByVal sender As System.Object, _
                                            ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) _
                                            Handles DataGridView_pesan.CellClick
        If DataGridView_pesan.CurrentRow.IsNewRow Then

        Else
            ''klo mau diklik pada tabel
            'MessageBox.Show(DataGridView_obat.RowCount)
            'btnTambahShow.Visible = True
            'btnUbah.Visible = False
            'gbUbah.Visible = True
            'gbTambah.Visible = False

            'Dim Input As [String] = DataGridView_pesan.Rows( _
            'DataGridView_pesan.CurrentRow.Index).Cells("harga").Value
            'Dim Temp As Integer = Integer.Parse(Input)
            'Dim Output As [String] = Temp.ToString("#,#.00")

            'lbHargaItemEd.Text = Output
        End If


    End Sub

    'Menampilkan form edit pesanan
    Private Sub btnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUbah.Click

        If DataGridView_pesan.SelectedCells.Count > 0 Then
            If DataGridView_pesan.CurrentRow.Selected = True Then
                If DataGridView_pesan.CurrentRow.IsNewRow Then

                Else
                    btnHapusItem.Visible = True
                    btnTambahShow.Visible = True
                    btnUbah.Visible = False
                    gbUbah.Visible = True
                    gbTambah.Visible = False

                    'Mengubah Harga
                    Dim Input As [String] = DataGridView_pesan.Rows( _
                    DataGridView_pesan.CurrentRow.Index).Cells("harga").Value
                    Temp = Long.Parse(Input)
                    Output = Temp.ToString("#,#.00")
                    lbHargaItemEd.Text = Output

                    'Mengubah jumlah
                    Dim InputJumlah As [String] = DataGridView_pesan.Rows( _
                    DataGridView_pesan.CurrentRow.Index).Cells("jumlah").Value
                    tbJumlahEd.Text = InputJumlah
                    temp_ubah_jumlah = InputJumlah


                    'Mengkalikan jumlahnya
                    Temp = lbHargaItemEd.Text * tbJumlahEd.Text
                    Output = Temp.ToString("#,#.00")
                    lbHargaItemTotalEd.Text = Output

                    'nomor id mengubah
                    lbNoItem.Text = DataGridView_pesan.Rows( _
                    DataGridView_pesan.CurrentRow.Index).Cells("nomor").Value

                    'default cari
                    tbEditCari.Text = DataGridView_pesan.Rows( _
                    DataGridView_pesan.CurrentRow.Index).Cells("nama_obat").Value

                End If
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbTime.Text = "Waktu saat ini " & Now.ToString()

    End Sub


    Private Sub Penjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim con As New MySqlConnection
        con.ConnectionString = "server=localhost;user=root;password=;database=apotekita;"
        con.Open()


        Dim sql_id As String = "select nama from pegawai where nama ='" & Login.username.Text _
        & "' and passwd =  '" & Login.pass.Text & "'"
        Dim cmd_id As New MySqlCommand(sql_id, con)
        Dim dr_id As MySqlDataReader = cmd_id.ExecuteReader()

        dr_id.Read()
        Dim namaNe As String = ""
        If dr_id.HasRows Then
            namaNe = dr_id("nama").ToString
        End If

        con.Close()

        refreshPemesanan()
        
        lbNama.Text = namaNe
        Timer1.Enabled = True

        lbHargaItem.Text = "0,00"

        
    End Sub

    Private Sub tbEditCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbEditCari.TextChanged
        If tbEditCari.TextLength >= 3 Then
            cari_ed()
        End If
    End Sub

    Private Sub btnCariEd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCariEd.Click
        If String.IsNullOrEmpty(tbCari.Text) Then

        Else
            cari_ed()
        End If

    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        If DataGridView_obat.RowCount > 0 Then
            DataGridView_pesan.Rows.Add(New String() {no_pesan, _
                                                      DataGridView_obat.Rows( _
                                                      DataGridView_obat.CurrentRow.Index).Cells("id_obat").Value, _
                                                      DataGridView_obat.Rows( _
                                                      DataGridView_obat.CurrentRow.Index).Cells("nama_obat").Value, _
                                                      DataGridView_obat.Rows( _
                                                      DataGridView_obat.CurrentRow.Index).Cells("expired_date").Value.ToString, _
                                                      DataGridView_obat.Rows( _
                                                      DataGridView_obat.CurrentRow.Index).Cells("no_barcode").Value, _
                                                      DataGridView_obat.Rows( _
                                                      DataGridView_obat.CurrentRow.Index).Cells("harga").Value, _
                                                      tbJumlah.Text, _
                                                      DataGridView_obat.Rows( _
                                                      DataGridView_obat.CurrentRow.Index).Cells("harga").Value * tbJumlah.Text _
                                                      })
            no_pesan += 1

        End If
        'jumlahTotalHarga()
        segarkan()
    End Sub


    Private Sub btnTambahShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambahShow.Click
        hilangEditGr()
    End Sub


    Private Sub tbJumlah_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbJumlah.TextChanged
        If tbJumlah.TextLength > 0 Then
            lbHargaItem.Text = harga_satuan * tbJumlah.Text

            Dim Input As [String] = lbHargaItem.Text
            Dim Temp As Long = Long.Parse(Input)
            Output = Temp.ToString("#,#.00")

            lbHargaItem.Text = Output
        End If
    End Sub


    Private Sub tbJumlahEd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbJumlahEd.TextChanged
        If tbJumlahEd.TextLength > 0 Then

            lbHargaItemTotalEd.Text = harga_satuan * tbJumlahEd.Text

            Dim Input As [String] = lbHargaItemTotalEd.Text
            Temp = Long.Parse(Input)
            Output = Temp.ToString("#,#.00")

            lbHargaItemTotalEd.Text = Output
        End If
    End Sub

    Private Sub DataGridView_obatEd_CellClick(ByVal sender As System.Object, _
                                              ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) _
                                              Handles DataGridView_obatEd.CellClick

        Dim Input As [String] = DataGridView_obatEd.Rows( _
        DataGridView_obatEd.CurrentRow.Index).Cells("harga").Value
        Temp = Long.Parse(Input)
        harga_satuan = Temp
        Output = Temp.ToString("#,#.00")

        tbJumlahEd.Text = 1
        lbHargaItemEd.Text = Output

        Temp = lbHargaItemEd.Text * tbJumlahEd.Text
        Output = Temp.ToString("#,#.00")
        lbHargaItemTotalEd.Text = Output
    End Sub

    Private Sub tampilEditGr()
        'munculkan edit grup
        btnHapusItem.Visible = True
        btnTambahShow.Visible = False
        btnUbah.Visible = True
        gbUbah.Visible = False
        gbTambah.Visible = True
    End Sub

    Private Sub hilangEditGr()
        'munculkan edit grup
        btnHapusItem.Visible = False
        btnTambahShow.Visible = False
        btnUbah.Visible = True
        gbUbah.Visible = False
        gbTambah.Visible = True
    End Sub

    'aksi Mengubah pesanan pada tabel pesanan
    Private Sub btnUbahItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUbahItem.Click

        'mengganti nama
        DataGridView_pesan.Rows(DataGridView_pesan.CurrentRow.Index).Cells("nama_obat").Value = DataGridView_obatEd.Rows( _
        DataGridView_obatEd.CurrentRow.Index).Cells("nama_obat").Value

        'mengganti id_obat
        DataGridView_pesan.Rows(DataGridView_pesan.CurrentRow.Index).Cells("id_obat").Value = DataGridView_obatEd.Rows( _
        DataGridView_obatEd.CurrentRow.Index).Cells("id_obat").Value

        'mengganti expired_date
        DataGridView_pesan.Rows(DataGridView_pesan.CurrentRow.Index).Cells("expired_date").Value = DataGridView_obatEd.Rows( _
        DataGridView_obatEd.CurrentRow.Index).Cells("expired_date").Value

        'mengganti no_barcode
        DataGridView_pesan.Rows(DataGridView_pesan.CurrentRow.Index).Cells("no_barcode").Value = DataGridView_obatEd.Rows( _
        DataGridView_obatEd.CurrentRow.Index).Cells("no_barcode").Value

        Dim hslHarga As String = ""
        'mengambil angka saja
        For Each ha As Char In lbHargaItemEd.Text
            If IsNumeric(ha) Then
                hslHarga = hslHarga & ha
            End If
        Next

        'mengganti harga
        DataGridView_pesan.Rows(DataGridView_pesan.CurrentRow.Index).Cells("harga").Value = hslHarga

        'mengganti jumlah
        DataGridView_pesan.Rows(DataGridView_pesan.CurrentRow.Index).Cells("jumlah").Value = tbJumlahEd.Text

        'mengganti total_harga_obat
        DataGridView_pesan.Rows(DataGridView_pesan.CurrentRow.Index).Cells("total_harga_obat").Value = hslHarga * tbJumlahEd.Text

        hilangEditGr()
        segarkan()
    End Sub



    Private Sub btnHapusItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapusItem.Click

        For Each row As DataGridViewRow In DataGridView_pesan.SelectedRows
            DataGridView_pesan.Rows.Remove(row)
        Next

        no_pesan = no_pesan - 1
        
        isHapus = True
        isTambahFormTambah = False

        segarkan()
        hilangEditGr()
        'kembalikan ke default
        isHapus = False

    End Sub

    Private Sub jumlahTotalHarga()
        'Dim harga_satuan, subtotalharga, subtotalbarang, totalbarang As Integer

        totalharga = 0
        Dim cek_isi_dg As Integer = DataGridView_pesan.RowCount.ToString
        If cek_isi_dg >= 1 Then
            For Each row As DataGridViewRow In DataGridView_pesan.Rows
                totalharga += row.Cells.Item(7).Value
            Next
        End If

        If totalharga = 0 Then
            lbTotal.Text = "0,00"
        Else
            lbTotal.Text = totalharga.ToString("#,#.00")
        End If


        'For i As Integer = 0 To no_pesan - 1
        '    harga_satuan = DataGridView_pesan.Rows(i).Cells(5).Value

        '    subtotalharga = harga_satuan * DataGridView_pesan.Rows(i).Cells(6).Value
        '    totalharga = totalharga + subtotalharga

        '    If i < no_pesan - 1 Then
        '        DataGridView_pesan.Rows(i).Cells(7).Value = subtotalharga
        '    End If


        '    subtotalbarang = DataGridView_pesan.Rows(i).Cells(6).Value
        '    totalbarang = totalbarang + subtotalbarang
        '    lbTotalBrg.Text = totalbarang

        '    If totalharga = 0 Then
        '        lbTotal.Text = "0,00"
        '    Else
        '        lbTotal.Text = totalharga.ToString("#,#.00")
        '    End If
        'Next

    End Sub

    Private Sub DataGridView_pesan_RowsRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles DataGridView_pesan.RowsRemoved
        no_pesan = no_pesan - 1
        Dim i As Integer = 0
        While i < DataGridView_pesan.RowCount

            If i < DataGridView_pesan.RowCount - 1 Then
                DataGridView_pesan.Rows(i).Cells(0).Value = i + 1
            End If

            i = i + 1
        End While
        segarkan()
    End Sub

    'Private Sub DataGridView_pesan_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_pesan.CellEndEdit
    '    jumlahTotalHarga()
    'End Sub



    '###### Daftar penjualan ########################
    Private Sub loadDaftarPenjualan()
        Dim koneksi As New MySqlConnection
        koneksi.ConnectionString = "server=localhost;user=root;password=;database=apotekita;AllowZeroDatetime=True"
        koneksi.Open()

        Dim adapter As New MySqlDataAdapter("SELECT aa.id_penjualan as faktur, aa.waktu ,bb.nama as nama, jml, harga FROM  " & _
                                            "(SELECT A.id_penjualan, A.waktu_transaksi as waktu, sum(B.jml_out) as jml, A.id_pegawai, B.harga " & _
                                            " FROM penjualan A left join (select a.id_penjualan, a.jml_out, sum(b.harga) as harga " & _
                                            " FROM detail_penjualan a left join obat b on a.id_obat = b.id_obat group by a.id_penjualan) B  " & _
                                            "ON A.id_penjualan = B.id_penjualan GROUP BY A.id_penjualan) aa left join pegawai bb " & _
                                            "ON aa.id_pegawai = bb.id_pegawai " _
                                            , koneksi)

        Dim tabel As New DataTable
        adapter.Fill(tabel)

        DataGridView_Penjualan.Columns(0).DataPropertyName = "faktur"
        DataGridView_Penjualan.Columns(1).DataPropertyName = "waktu"
        DataGridView_Penjualan.Columns(2).DataPropertyName = "nama"
        DataGridView_Penjualan.Columns(3).DataPropertyName = "jml"
        DataGridView_Penjualan.Columns(4).DataPropertyName = "harga"

        DataGridView_Penjualan.DataSource = tabel

        koneksi.Close()

    End Sub

    Private Sub loadDetailPenjualan(ByVal nofaktur As String)
        Dim koneksi As New MySqlConnection
        koneksi.ConnectionString = "server=localhost;user=root;password=;database=apotekita;AllowZeroDatetime=True"
        koneksi.Open()

        Dim adapter As New MySqlDataAdapter( _
        "SELECT ob.id_obat as 'ID Obat', ob.nama_obat as 'Nama obat', ob.harga as 'Harga', dp.jml_out as 'Jumlah item' from detail_penjualan dp left join obat ob on dp.id_obat = ob.id_obat where dp.id_penjualan=" & nofaktur, koneksi)

        Dim tabel As New DataTable
        adapter.Fill(tabel)

        DataGridView_detail.DataSource = tabel
        DataGridView_detail.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView_detail.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView_detail.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView_detail.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill


    End Sub

    Private Sub DataGridView_daftar_CellClick(ByVal sender As System.Object, _
                                             ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) _
                                             Handles DataGridView_Penjualan.CellClick

        Dim faktur As String = DataGridView_Penjualan.Rows( _
        DataGridView_Penjualan.CurrentRow.Index).Cells("id_penjualan").Value

        Dim waktu_transaksi As String = DataGridView_Penjualan.Rows( _
        DataGridView_Penjualan.CurrentRow.Index).Cells("waktu_transaksi").Value.ToString

        Dim nama As String = DataGridView_Penjualan.Rows( _
        DataGridView_Penjualan.CurrentRow.Index).Cells("nama").Value

        Dim jml_obat As String = DataGridView_Penjualan.Rows( _
        DataGridView_Penjualan.CurrentRow.Index).Cells("jml_obat").Value

        Dim total_item As String = DataGridView_Penjualan.Rows( _
        DataGridView_Penjualan.CurrentRow.Index).Cells("total_item").Value

        pn_detail_penjualan.Visible = True

        lb_nofak.Text = faktur
        lb_pegawai.Text = nama
        lb_waktu.Text = waktu_transaksi
        lb_jml_item_penj.Text = jml_obat
        lb_total_harga_penj.Text = total_item

        loadDetailPenjualan(faktur)
        'MessageBox.Show(faktur & waktu_transaksi & nama & jml_obat & total_item)
    End Sub

    Private Sub bersih_cari_penj()
        tb_cari_penj.Text = ""
        cb_penj_nama.Checked = False
        cb_penj_waktu.Checked = False
    End Sub

    Private Sub cari_penj()
        Dim koneksi As New MySqlConnection
        koneksi.ConnectionString = "server=localhost;user=root;password=;database=apotekita;AllowZeroDatetime=True"
        koneksi.Open()

        If cb_penj_nama.Checked = True And cb_penj_waktu.Checked = True Then
            Dim adapter As New MySqlDataAdapter("SELECT aa.id_penjualan as faktur, aa.waktu ,bb.nama as nama, jml, harga FROM  " & _
                                            "(SELECT A.id_penjualan, A.waktu_transaksi as waktu, sum(B.jml_out) as jml, A.id_pegawai, B.harga " & _
                                            " FROM penjualan A left join (select a.id_penjualan, a.jml_out, sum(b.harga) as harga " & _
                                            " FROM detail_penjualan a left join obat b on a.id_obat = b.id_obat group by a.id_penjualan) B  " & _
                                            "ON A.id_penjualan = B.id_penjualan GROUP BY A.id_penjualan) aa left join pegawai bb " & _
                                            "ON aa.id_pegawai = bb.id_pegawai " & _
                                            "WHERE aa.id_penjualan LIKE '%" & tb_cari_penj.Text & _
                                            "%' OR bb.nama LIKE '%" & tb_cari_penj.Text & _
                                            "%' OR aa.waktu LIKE '%" & tb_cari_penj.Text & _
                                            "%'" _
                                            , koneksi)
            Dim tabel As New DataTable
            adapter.Fill(tabel)

            DataGridView_Penjualan.DataSource = tabel
        ElseIf cb_penj_nama.Checked Then
            Dim adapter As New MySqlDataAdapter("SELECT aa.id_penjualan as faktur, aa.waktu ,bb.nama as nama, jml, harga FROM  " & _
                                            "(SELECT A.id_penjualan, A.waktu_transaksi as waktu, sum(B.jml_out) as jml, A.id_pegawai, B.harga " & _
                                            " FROM penjualan A left join (select a.id_penjualan, a.jml_out, sum(b.harga) as harga " & _
                                            " FROM detail_penjualan a left join obat b on a.id_obat = b.id_obat group by a.id_penjualan) B  " & _
                                            "ON A.id_penjualan = B.id_penjualan GROUP BY A.id_penjualan) aa left join pegawai bb " & _
                                            "ON aa.id_pegawai = bb.id_pegawai " & _
                                            "WHERE aa.id_penjualan LIKE '%" & tb_cari_penj.Text & _
                                            "%' OR bb.nama LIKE '%" & tb_cari_penj.Text & _
                                            "%'" _
                                            , koneksi)
            Dim tabel As New DataTable
            adapter.Fill(tabel)

            DataGridView_Penjualan.DataSource = tabel
        ElseIf cb_penj_waktu.Checked Then
            Dim adapter As New MySqlDataAdapter("SELECT aa.id_penjualan as faktur, aa.waktu ,bb.nama as nama, jml, harga FROM  " & _
                                            "(SELECT A.id_penjualan, A.waktu_transaksi as waktu, sum(B.jml_out) as jml, A.id_pegawai, B.harga " & _
                                            " FROM penjualan A left join (select a.id_penjualan, a.jml_out, sum(b.harga) as harga " & _
                                            " FROM detail_penjualan a left join obat b on a.id_obat = b.id_obat group by a.id_penjualan) B  " & _
                                            "ON A.id_penjualan = B.id_penjualan GROUP BY A.id_penjualan) aa left join pegawai bb " & _
                                            "ON aa.id_pegawai = bb.id_pegawai " & _
                                            "WHERE aa.id_penjualan LIKE '%" & tb_cari_penj.Text & _
                                            "%' OR aa.waktu LIKE '%" & tb_cari_penj.Text & _
                                            "%'" _
                                            , koneksi)
            Dim tabel As New DataTable
            adapter.Fill(tabel)

            DataGridView_Penjualan.DataSource = tabel
        Else
            Dim adapter As New MySqlDataAdapter("SELECT aa.id_penjualan as faktur, aa.waktu ,bb.nama as nama, jml, harga FROM  " & _
                                            "(SELECT A.id_penjualan, A.waktu_transaksi as waktu, sum(B.jml_out) as jml, A.id_pegawai, B.harga " & _
                                            " FROM penjualan A left join (select a.id_penjualan, a.jml_out, sum(b.harga) as harga " & _
                                            " FROM detail_penjualan a left join obat b on a.id_obat = b.id_obat group by a.id_penjualan) B  " & _
                                            "ON A.id_penjualan = B.id_penjualan GROUP BY A.id_penjualan) aa left join pegawai bb " & _
                                            "ON aa.id_pegawai = bb.id_pegawai " & _
                                            "WHERE aa.id_penjualan LIKE '%" & tb_cari_penj.Text & _
                                            "%'" _
                                            , koneksi)
            Dim tabel As New DataTable
            adapter.Fill(tabel)

            DataGridView_Penjualan.DataSource = tabel
        End If

        koneksi.Close()
    End Sub

    Private Sub btn_bersih_cari_penj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_bersih_cari_penj.Click
        bersih_cari_penj()
        loadDaftarPenjualan()
    End Sub

    Private Sub tb_cari_penj_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_cari_penj.TextChanged
        If tb_cari_penj.TextLength > 1 Then
            cari_penj()
        End If
    End Sub

    Private Sub btn_cari_daftar_penj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cari_daftar_penj.Click
        cari_penj()
    End Sub

    Private Sub btn_kembali_penj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_kembali_penj.Click
        pn_detail_penjualan.Visible = False
    End Sub

    Private Sub cb_penj_nama_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        loadDaftarPenjualan()
    End Sub

    Private Sub cb_penj_waktu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        loadDaftarPenjualan()
    End Sub

    Private Sub btn_segar_penj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_segar_penj.Click
        bersih_cari_penj()
        loadDaftarPenjualan()

    End Sub
    
    Private Sub btnPenjualan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPenjualan.Click
        PnPenjualan.Visible = True
        pnDafJual.Visible = False
    End Sub


    Private Sub btnDaftarJual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDaftarJual.Click
        PnPenjualan.Visible = False
        pnDafJual.Visible = True
        pn_detail_penjualan.Visible = False
        loadDaftarPenjualan()
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        menu_utama.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If noFakturtb.Text = "" Then
            MessageBox.Show("No Faktur harus diisi.", "Kesalahan")
        ElseIf DataGridView_pesan.RowCount > 1 Then
            SimpanPenjualan()
            MessageBox.Show("Data berhasil disimpan", "Simpan")
        Else
            MessageBox.Show("Data pemesanan kosong", "Kesalahan")
        End If
    End Sub

    'fungsi untuk insert ke penjualan dan pengambilan id pegawai current login
    Private Sub SimpanPenjualan()
        'Dim con1 As New MySqlConnection
        'con1.ConnectionString = "server=localhost;user=root;password=;database=apotekita;"
        'con1.Open()

        Dim con As New MySqlConnection
        con.ConnectionString = "server=localhost;user=root;password=;database=apotekita;"
        con.Open()
        Dim sql_id As String = "select id_pegawai,nama from pegawai where nama ='" & Login.username.Text _
        & "' and passwd =  '" & Login.pass.Text & "'"
        Dim cmd_id As New MySqlCommand(sql_id, con)
        Dim dr_id As MySqlDataReader = cmd_id.ExecuteReader()

        dr_id.Read()

        Dim idne As String = ""
        Dim namaNe As String = ""
        If dr_id.HasRows Then
            idne = dr_id("id_pegawai").ToString
            namaNe = dr_id("nama").ToString
        End If
        con.Close()

        'menambah ke penjualan
        con.Open()
        Dim sql As String = "INSERT INTO penjualan values ('" & lbNoFaktur.Text & "', '" & idne & "',(NOW()), '" & totalharga & "')"
        Dim cmd As New MySqlCommand(sql, con)
        cmd.ExecuteNonQuery()
        con.Close()

        Dim cek As String
        'menambah ke detail penjualan
        For Each row As DataGridViewRow In DataGridView_pesan.Rows
            'MessageBox.Show(lbNoFaktur.Text & row.Cells.Item(1).Value & row.Cells.Item(6).Value & row.Cells.Item(7).Value)
            con.Open()
            Dim sql_detail As String = "INSERT INTO detail_penjualan (`id_penjualan`, `id_obat`, `jml_out`, `jumlah_harga_item`) values ('" & lbNoFaktur.Text & "', '" & row.Cells.Item(1).Value & "', '" & row.Cells.Item(6).Value & "', '" & row.Cells.Item(7).Value & "')"
            Dim cmd_detail As New MySqlCommand(sql_detail, con)
            cmd_detail.ExecuteNonQuery()
    
            con.Close()
        Next


        refreshPemesanan()
        segarkan()
    End Sub
    
    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        If noFakturtb.Text = "" Then
            MessageBox.Show("No Faktur harus diisi.", "Kesalahan")
        ElseIf DataGridView_pesan.RowCount > 1 Then
            SimpanPenjualan()
            MessageBox.Show("Data berhasil disimpan", "Simpan")
        Else
            MessageBox.Show("Data pemesanan kosong", "Kesalahan")
        End If
    End Sub

    Private Sub refreshPemesanan()
        'nomorfaktur gabungan dari tanggal+nomor3digit
        Dim con As New MySqlConnection
        con.ConnectionString = "server=localhost;user=root;password=;database=apotekita;"
        con.Open()
        Dim waktu As String = Now.ToString()
        Dim hari As String = waktu.Substring(0, 2)
        Dim bulan As String = waktu.Substring(3, 2)
        Dim tahun As String = waktu.Substring(8, 2)

        Dim sql_nofak As String = "SELECT RIGHT(MAX(id_penjualan),3) as nomor_faktur FROM penjualan"
        Dim cmd_nofak As New MySqlCommand(sql_nofak, con)
        Dim dr_nofak As MySqlDataReader = cmd_nofak.ExecuteReader()

        dr_nofak.Read()
        Dim nomorfaktur As String = ""
        If dr_nofak.HasRows Then
            nomorfaktur = dr_nofak("nomor_faktur").ToString + 1
        End If

        lbNoFaktur.Text = tahun & bulan & hari & nomorfaktur

        con.Close()

        noFakturtb.Text = lbNoFaktur.Text


        If DataGridView_pesan.RowCount > 1 Then
            'hapussemua
            For Each row As DataGridViewRow In DataGridView_pesan.Rows
                DataGridView_pesan.Rows.Remove(row)
            Next
        End If

        

    End Sub
End Class
