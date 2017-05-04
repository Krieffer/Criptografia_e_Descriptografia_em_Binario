Public Class frm_menu
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

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

    Private Sub frm_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
