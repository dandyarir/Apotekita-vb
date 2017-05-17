
Public Class menu_utama
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        form1.Visible = True
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Penjualan.Show()
        Me.Close()
    End Sub

    Private Sub out_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles out.Click
        Dim keluar As String
        keluar = MsgBox("Yakin!?", vbQuestion + vbYesNo, "Konfirmasi")
        If keluar = vbYes Then

            Login.Visible = True
            Me.Close()
            Login.username.Text = " "
            Login.pass.Text = ""
        Else
            Me.Show()
        End If
    End Sub

End Class