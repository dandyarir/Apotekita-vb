Imports MySql.Data.MySqlClient
Public Class Ubah

    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        Dim koneksi As New MySqlConnection
        koneksi.ConnectionString = "server=localhost;user=root;password=;database=apotekita;"
        koneksi.Open()
        'MessageBox.Show(Main_HRD.DataGridViewPeg.Rows( _
        'Main_HRD.DataGridViewPeg.CurrentRow.Index).Cells("id_pegawai").Value)
        Dim cmd As New MySqlCommand
        cmd.CommandText = "UPDATE pegawai SET id_pegawai='" & _
        id_pegawai_tb.Text & "', nama='" & _
        nama_tb.Text & "', jk='" & _
        jk_cb.Text & "', tempat_lahir='" & _
        tempat_lahir_tb.Text & "', tanggal_lahir='" & _
        CStr(DateTimePickerTL.Value.Year) & "-" & _
        CStr(DateTimePickerTL.Value.Month) & "-" & CStr(DateTimePickerTL.Value.Day) & "', alamat='" & _
        alamat_tb.Text & "', passwd='" & _
        pass_tb.Text & "', updated_at=(NOW())" & _
        " WHERE id_pegawai='" & _
        MainHRD.DataGridViewPeg.Rows( _
        MainHRD.DataGridViewPeg.CurrentRow.Index).Cells("id_pegawai").Value & "'"
        cmd.Connection = koneksi

        cmd.ExecuteNonQuery()
        MainHRD.tampilTabel("id_pegawai,nama,jk,tempat_lahir,tanggal_lahir,alamat,passwd", "pegawai")
        Me.Visible = False
        koneksi.Close()
    End Sub


    Private Sub Cancel_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_tambah.Click
        Me.Visible = False
    End Sub

End Class