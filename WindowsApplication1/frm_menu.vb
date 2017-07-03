Public Class frm_menu
    Private Sub btn_crip_Click(sender As Object, e As EventArgs) Handles btn_crip.Click
        frm_cripto.Show()
        Hide()
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Application.Exit()
    End Sub

    Private Sub btn_sobre_Click(sender As Object, e As EventArgs) Handles btn_sobre.Click
        frm_sobre.Show()
    End Sub

    Private Sub btn_descrip_Click(sender As Object, e As EventArgs) Handles btn_descrip.Click
        frm_descripto.Show()
        Hide()
    End Sub
End Class
