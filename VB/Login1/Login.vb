Imports MySql.Data.MySqlClient

Public Class Login

    Private Sub databaseTampil(ByVal kolom As String, _
                               ByVal nama_tabel As String)
        Dim koneksi As New MySqlConnection
        'untuk port yang dipakai oleh server
        'koneksi.ConnectionString = "server=localhost:8000;user=root;password=;database=apotekita;"
        koneksi.ConnectionString = "server=localhost;user=root;password=;database=apotekita;"
        koneksi.Open()
        koneksi.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New MySqlConnection
        con.ConnectionString = "server=localhost;user=root;password=;database=apotekita;"
        con.Open()

        Dim sql As String = "select * from pegawai where nama ='" & username.Text & "' and passwd =  '" & pass.Text & "'"
        Dim cmd As New MySqlCommand(sql, con)
        Dim dr As MySqlDataReader = cmd.ExecuteReader()


        dr.Read()
        
        If dr.HasRows Then

            Me.Hide()

            If dr("hak_akses").ToString = "kasir" Then
                menu_utama.Show()
                menu_utama.lblkasir.Text = "Login sebagai " + dr("hak_akses")
            ElseIf dr("hak_akses").ToString = "hrd" Then
                MainHRD.Show()
                MainHRD.Label1.Text = "Login sebagai " + dr("hak_akses")
            Else
                MsgBox("Anda tidak mempunyai Hak Akses Penuh" + vbCrLf + "Hak Akses Anda = " + dr("hak_akses"))
                Me.Show()
            End If
            'MsgBox("Anda berhasil login !", vbInformation, "Informasi")
            'menu_utama.Show()
            'Me.Visible = False
        Else
            MsgBox("Maaf User atau Password anda salah !", vbInformation, "Informasi")
            username.Clear()
            pass.Clear()
        End If
        dr.Close()
        con.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim keluar As String
        keluar = MsgBox("Yakin!?", vbQuestion + vbYesNo, "Konfirmasi")
        If keluar = vbYes Then
            Me.Close()
        Else
            Me.Show()
        End If
    End Sub


End Class
