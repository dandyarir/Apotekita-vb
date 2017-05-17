Imports MySql.Data.MySqlClient

Public Class form1

    Private Sub tampil()
        Dim koneksi As New MySqlConnection
        koneksi.ConnectionString = "server=localhost;user=root;password=;database=apotekita;"
        koneksi.Open()


        Dim cmd As New MySqlCommand
        cmd.CommandText = "SELECT * from obat where id_obat like '%" & TextBox13.Text & "%'"
        cmd.Connection = koneksi


        Dim adapter As New MySqlDataAdapter(cmd)
        Dim tabel As New DataTable
        adapter.Fill(tabel)
        DataGridView1.DataSource = tabel
        koneksi.Close()
    End Sub
    Private Sub tampilCari()
        Dim koneksi As New MySqlConnection
        koneksi.ConnectionString = "server=localhost;user=root;password=;database=apotekita;"
        koneksi.Open()


        Dim cmd As New MySqlCommand
        cmd.CommandText = "SELECT * from obat where " & cari_cb.Text & " like '%" & TextBox14.Text & "%'"
        cmd.Connection = koneksi


        Dim adapter As New MySqlDataAdapter(cmd)
        Dim tabel As New DataTable
        adapter.Fill(tabel)
        DataGridView2.DataSource = tabel
        koneksi.Close()
        DataGridView2.ReadOnly = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Panel2.Visible = False
        Panel4.Visible = False
        Panel3.Visible = True
        tampilCari()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Panel3.Visible = False
        Panel4.Visible = False
        Panel2.Visible = True
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = True
        tampilCari()
    End Sub

    Private Sub Buttontbh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If (TextBox1.Text = "") Then
            MessageBox.Show("ID OBAT harus diisi")
        Else
            Dim result As Integer = MessageBox.Show("Apakah Anda yakin?", "Tambah Data", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                tambah()
            End If
        End If
    End Sub
    Private Sub tambah()
        Dim koneksi As New MySqlConnection
        koneksi.ConnectionString = "server=localhost;user=root;password=;database=apotekita;"
        koneksi.Open()


        Dim cek As String = "SELECT id_obat from obat where id_obat='" & TextBox1.Text & "'"
        Dim cmd_idObat As New MySqlCommand(cek, koneksi)
        Dim dr_idObat As MySqlDataReader = cmd_idObat.ExecuteReader
        dr_idObat.Read()
        koneksi.Close()

        If dr_idObat.HasRows Then
            MessageBox.Show("ID Obat sudah ada.", "Duplikasi.")
        Else
            koneksi.Open()
            Dim cmd As New MySqlCommand
            cmd.CommandText = "INSERT INTO obat VALUES ('" & _
            TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" _
            & CStr(DateTimePicker1.Value.Year) & "-" & _
            CStr(DateTimePicker1.Value.Month) & "-" & CStr(DateTimePicker1.Value.Day) & _
            "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & _
            TextBox6.Text & "')"

            cmd.Connection = koneksi

            cmd.ExecuteNonQuery()
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""

            koneksi.Close()
        End If

        
    End Sub
    Private Sub hapus()
        Dim koneksi As New MySqlConnection
        koneksi.ConnectionString = "server=localhost;user=root;password=;database=apotekita;"
        koneksi.Open()

        Dim nitha As New MySqlCommand
        nitha.CommandText = "Delete from obat where id_obat='" & TextBox7.Text & "'"
        nitha.Connection = koneksi
        nitha.ExecuteNonQuery()

        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        koneksi.Close()
        tampil()

    End Sub
    Private Sub simpan()
        Dim koneksi As New MySqlConnection
        koneksi.ConnectionString = "server=localhost;user=root;password=;database=apotekita;"
        koneksi.Open()


        Dim cmd As New MySqlCommand
        cmd.CommandText = "UPDATE obat set id_obat='" & TextBox7.Text & "',nama_obat='" & _
        TextBox8.Text & "', harga='" & TextBox9.Text & "', no_bpom='" & TextBox10.Text & "', expired_date='" & CStr(DateTimePicker2.Value.Year) & "-" & _
        CStr(DateTimePicker2.Value.Month) & "-" & CStr(DateTimePicker2.Value.Day) & _
        "', no_barcode='" & TextBox11.Text & "', keterangan='" & TextBox12.Text & "' where id_obat='" & DataGridView1.Rows( _
        DataGridView1.CurrentRow.Index).Cells("id_obat").Value & "'"
        cmd.Connection = koneksi

        cmd.ExecuteNonQuery()
        'TextBox8.Text = ""
        'TextBox9.Text = ""
        'TextBox10.Text = ""
        'TextBox11.Text = ""
        'TextBox12.Text = ""
        koneksi.Close()
        tampil()

    End Sub


    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cari.Click
        tampil()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBox7.Text = DataGridView1.Rows( _
        DataGridView1.CurrentRow.Index).Cells("id_obat").Value

        TextBox8.Text = DataGridView1.Rows( _
        DataGridView1.CurrentRow.Index).Cells("nama_obat").Value

        TextBox9.Text = DataGridView1.Rows( _
        DataGridView1.CurrentRow.Index).Cells("harga").Value

        TextBox10.Text = DataGridView1.Rows( _
        DataGridView1.CurrentRow.Index).Cells("no_bpom").Value

        TextBox11.Text = DataGridView1.Rows( _
        DataGridView1.CurrentRow.Index).Cells("no_barcode").Value

        TextBox12.Text = DataGridView1.Rows( _
        DataGridView1.CurrentRow.Index).Cells("keterangan").Value

        DateTimePicker2.Value = DataGridView1.Rows( _
        DataGridView1.CurrentRow.Index).Cells("expired_date").Value

    End Sub


    Private Sub btnUpdatespn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan.Click
        Dim result As Integer = MessageBox.Show("Anda yakin ingin menyimpan?", "Simpan Data", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            simpan()
        Else
            tampil()
        End If
    End Sub

    Private Sub btnUpdatehps_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hps.Click
        Dim result As Integer = MessageBox.Show("Apakah Anda yakin ingin menghapus?", "Hapus Data", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            hapus()
        Else
            tampil()
        End If
    End Sub

    Private Sub TextBoxCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox14.TextChanged
        If TextBox14.Text.Length >= 3 Then
            tampilCari()
        ElseIf TextBox14.Text.Length = 0 Then
            tampilCari()
        End If
    End Sub

    Private Sub DataGridView2_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        TextBox20.Text = DataGridView2.Rows( _
        DataGridView2.CurrentRow.Index).Cells("id_obat").Value

        TextBox19.Text = DataGridView2.Rows( _
        DataGridView2.CurrentRow.Index).Cells("nama_obat").Value

        TextBox18.Text = DataGridView2.Rows( _
        DataGridView2.CurrentRow.Index).Cells("harga").Value

        TextBox17.Text = DataGridView2.Rows( _
        DataGridView2.CurrentRow.Index).Cells("no_bpom").Value

        TextBox16.Text = DataGridView2.Rows( _
        DataGridView2.CurrentRow.Index).Cells("no_barcode").Value

        TextBox15.Text = DataGridView2.Rows( _
        DataGridView2.CurrentRow.Index).Cells("keterangan").Value

        DateTimePicker3.Value = DataGridView2.Rows( _
        DataGridView2.CurrentRow.Index).Cells("expired_date").Value
    End Sub


    Private Sub form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cari_cb.SelectedIndex = 0
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        menu_utama.Visible = True
        Me.Close()
    End Sub

    Private Sub ref_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ref_btn.Click
        form_idObatRef.Visible = True
    End Sub
End Class
