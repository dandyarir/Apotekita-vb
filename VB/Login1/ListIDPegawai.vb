Imports MySql.Data.MySqlClient

Public Class ListIDPegawai
    Private Sub ListIDPegawai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim koneksi As New MySqlConnection
        koneksi.ConnectionString = "server=localhost;user=root;password=;database=apotekita;"
        koneksi.Open()

        Dim cmd As New MySqlCommand
        cmd.CommandText = "SELECT id_pegawai,nama FROM pegawai"
        cmd.Connection = koneksi

        Dim adapter As New MySqlDataAdapter(cmd)
        Dim tabel As New DataTable
        adapter.Fill(tabel)
        DataGridViewList.DataSource = tabel
        DataGridViewList.ReadOnly = True

        koneksi.Close()
    End Sub
End Class