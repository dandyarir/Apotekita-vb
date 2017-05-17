Imports MySql.Data.MySqlClient
Imports Login

Public Class MainHRD
    Public Sub tampilTabel(ByVal kolom As String, ByVal nama_tabel As String)
        Dim koneksi As New MySqlConnection
        koneksi.ConnectionString = "server=localhost;user=root;password=;database=apotekita;"
        koneksi.Open()

        Dim cmd As New MySqlCommand
        cmd.CommandText = "SELECT " & kolom & " FROM " & nama_tabel
        cmd.Connection = koneksi

        Dim adapter As New MySqlDataAdapter(cmd)
        Dim tabel As New DataTable
        adapter.Fill(tabel)
        DataGridViewPeg.DataSource = tabel

        koneksi.Close()
    End Sub

    Private Sub Main_HRD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampilTabel("id_pegawai,nama,jk,tempat_lahir,tanggal_lahir,alamat,passwd", "pegawai")
        Cari_cb.SelectedIndex = 0

    End Sub

    Private Sub Tambah_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tambah_Btn.Click
        Tambah.Visible = True
    End Sub

    Private Sub Ubah_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ubah_btn.Click
        Ubah.Visible = True
    End Sub

    Private Sub Hapus_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hapus_btn.Click
        Dim result As Integer = MessageBox.Show("Apakah ada yakin ingin menghapus??", "Hapus Data", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim koneksi As New MySqlConnection
            koneksi.ConnectionString = "server=localhost;user=root;password=;database=apotekita;"
            koneksi.Open()

            Dim cmd As New MySqlCommand
            cmd.CommandText = "DELETE FROM pegawai WHERE id_pegawai='" & _
            DataGridViewPeg.Rows( _
            DataGridViewPeg.CurrentRow.Index).Cells("id_pegawai").Value & "'"
            cmd.Connection = koneksi

            cmd.ExecuteNonQuery()
            tampilTabel("id_pegawai,nama,jk,tempat_lahir,tanggal_lahir,alamat,passwd", "pegawai")
            koneksi.Close()
        Else
            tampilTabel("id_pegawai,nama,jk,tempat_lahir,tanggal_lahir,alamat,passwd", "pegawai")
        End If

    End Sub

    Private Sub Cari_tb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cari_tb.TextChanged
        Dim kata As String = ""
        If Cari_cb.Text = "ID" Then
            kata = "id_pegawai"
        ElseIf Cari_cb.Text = "Nama" Then
            kata = "nama"
        ElseIf Cari_cb.Text = "Jenis kelamin" Then
            kata = "jk"
        ElseIf Cari_cb.Text = "Tempat lahir" Then
            kata = "tempat_lahir"
        ElseIf Cari_cb.Text = "Tanggal lahir" Then
            kata = "tanggal_lahir"
        ElseIf Cari_cb.Text = "Alamat" Then
            kata = "alamat"
        End If


        Dim koneksi As New MySqlConnection
        koneksi.ConnectionString = "server=localhost;user=root;password=;database=apotekita;"
        koneksi.Open()

        Dim cmd As New MySqlCommand

        If Cari_cb.Text = "Semua" Then
            cmd.CommandText = "SELECT id_pegawai,nama,jk,tempat_lahir,tanggal_lahir,alamat,passwd FROM pegawai WHERE id_pegawai LIKE '%" _
            & Cari_tb.Text & "%' OR nama LIKE '%" _
            & Cari_tb.Text & "%' OR jk LIKE '%" _
            & Cari_tb.Text & "%' OR tempat_lahir LIKE '%" _
            & Cari_tb.Text & "%' OR tanggal_lahir LIKE '%" _
            & Cari_tb.Text & "%' OR alamat LIKE '%" _
            & Cari_tb.Text & "%'"
            cmd.Connection = koneksi
        Else
            cmd.CommandText = "SELECT id_pegawai,nama,jk,tempat_lahir,tanggal_lahir,alamat,passwd FROM pegawai WHERE " & kata & " LIKE '%" & Cari_tb.Text & "%'"
            cmd.Connection = koneksi
        End If

        Dim adapter As New MySqlDataAdapter(cmd)
        Dim tabel As New DataTable
        adapter.Fill(tabel)
        DataGridViewPeg.DataSource = tabel

        koneksi.Close()
    End Sub

    Private Sub DataGridViewPeg_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewPeg.CellContentClick
        Ubah.id_pegawai_tb.Text = DataGridViewPeg.Rows( _
        DataGridViewPeg.CurrentRow.Index).Cells("id_pegawai").Value

        Ubah.nama_tb.Text = DataGridViewPeg.Rows( _
        DataGridViewPeg.CurrentRow.Index).Cells("nama").Value

        Ubah.jk_cb.Text = DataGridViewPeg.Rows( _
        DataGridViewPeg.CurrentRow.Index).Cells("jk").Value

        Ubah.tempat_lahir_tb.Text = DataGridViewPeg.Rows( _
        DataGridViewPeg.CurrentRow.Index).Cells("tempat_lahir").Value

        Ubah.DateTimePickerTL.Text = DataGridViewPeg.Rows( _
        DataGridViewPeg.CurrentRow.Index).Cells("tanggal_lahir").Value

        Ubah.alamat_tb.Text = DataGridViewPeg.Rows( _
        DataGridViewPeg.CurrentRow.Index).Cells("alamat").Value

        Ubah.pass_tb.Text = DataGridViewPeg.Rows( _
        DataGridViewPeg.CurrentRow.Index).Cells("passwd").Value
    End Sub

    Private Sub ouut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ouut.Click
        Dim keluar As String
        keluar = MsgBox("Yakin!?", vbQuestion + vbYesNo, "Konfirmasi")
        If keluar = vbYes Then
            Me.Close()
            Login.Visible = True
            Login.username.Text = ""
            Login.pass.Text = ""
        Else
            Me.Show()
        End If
    End Sub

End Class