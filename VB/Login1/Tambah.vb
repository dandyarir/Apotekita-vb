Imports MySql.Data.MySqlClient

Public Class Tambah

    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        Dim koneksi As New MySqlConnection
        koneksi.ConnectionString = "server=localhost;user=root;password=;database=apotekita;"
        koneksi.Open()

        Dim cmd As New MySqlCommand
        cmd.CommandText = "INSERT INTO pegawai(id_pegawai,nama,jk,tempat_lahir,tanggal_lahir,alamat,passwd,created_at,hak_akses) VALUES ('" & _
        id_pegawai_tb.Text & "','" & nama_tb.Text & "','" & _
        jk_cb.Text & "','" & _
        tempat_lahir_tb.Text & "','" & CStr(DateTimePickerTL.Value.Year) & "-" & _
        CStr(DateTimePickerTL.Value.Month) & "-" & CStr(DateTimePickerTL.Value.Day) & "','" & alamat_tb.Text & "','" & _
        pass_tb.Text & "',(NOW()),'kasir')"
        cmd.Connection = koneksi

        If _
        id_pegawai_tb.Text = "" _
        Or nama_tb.Text = "" _
        Or jk_cb.Text = "" _
        Or tempat_lahir_tb.Text = "" _
        Or alamat_tb.Text = "" _
        Or pass_tb.Text = "" _
        Then
            MsgBox("Data belum lengkap", MsgBoxStyle.Exclamation, "Notifikasi")
        Else

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Data pegawai telah ditambahkan", MsgBoxStyle.OkOnly, "Notification")
                MainHRD.tampilTabel("id_pegawai,nama,jk,tempat_lahir,tanggal_lahir,alamat,passwd", "pegawai")
                koneksi.Close()
                Me.Visible = False
                id_pegawai_tb.Clear()
                nama_tb.Clear()
                tempat_lahir_tb.Clear()
                alamat_tb.Clear()
                pass_tb.Clear()

            Catch ex As MySqlException
                MsgBox("Data tidak dapat disimpan. " & ex.Message, MsgBoxStyle.Exclamation, "Notification")
            End Try
        End If
    End Sub


    Private Sub Cancel_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_tambah.Click
        Me.Visible = False
    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click

    End Sub
End Class