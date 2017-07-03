Public Class frm_descripto
    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        txb_textdescrip.Clear()
        txb_textndescrip.Clear()
    End Sub

    Private Sub frm_descripto_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub

    Private Sub frm_descripto_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frm_menu.Show()
    End Sub

    Private Sub frm_descripto_Leave(sender As Object, e As EventArgs) Handles Me.Leave

    End Sub

    Private Sub frm_descripto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        encheVetores()
    End Sub
End Class